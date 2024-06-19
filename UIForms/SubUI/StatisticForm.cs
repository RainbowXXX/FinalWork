using Dapper;
using FinalWork.Configs;
using FinalWork.Entities;
using FinalWork.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWork.UIForms.SubUI
{
    public partial class StatisticForm : Form
    {
        private Thread _thread;
        private List<ListViewItem> hottest_books_, hottest_author_;
        private List<ListViewItem> active_readers_, dishonest_readers_;
        private CancellationTokenSource cts = new CancellationTokenSource();

        private List<ListViewItem> hottest_books
        {
            get
            {
                return hottest_books_;
            }
            set
            {
                if (!Equals(hottest_books_, value)) {
                    hottest_books_ = value;
                    this.Invoke((MethodInvoker)delegate { listView2.Items.Clear(); });
                    foreach (var item in hottest_books_) this.Invoke((MethodInvoker)delegate { listView2.Items.Add(item); });
                }
            }
        }

        private List<ListViewItem> hottest_author
        {
            get
            {
                return hottest_author_;
            }
            set
            {
                if (!Equals(hottest_author_, value))
                {
                    hottest_author_ = value;
                    this.Invoke((MethodInvoker)delegate { listView4.Items.Clear(); });
                    foreach (var item in hottest_author_) this.Invoke((MethodInvoker)delegate { listView4.Items.Add(item); });
                }
            }
        }

        private List<ListViewItem> active_readers
        {
            get
            {
                return active_readers_;
            }
            set
            {
                if (!Equals(active_readers_, value))
                {
                    active_readers_ = value;
                    this.Invoke((MethodInvoker)delegate { listView1.Items.Clear(); });
                    foreach (var item in active_readers_) this.Invoke((MethodInvoker)delegate { listView1.Items.Add(item); });
                }
            }
        }

        private List<ListViewItem> dishonest_readers
        {
            get
            {
                return dishonest_readers_;
            }
            set
            {
                if (!Equals(dishonest_readers_, value))
                {
                    dishonest_readers_ = value;
                    this.Invoke((MethodInvoker)delegate { listView3.Items.Clear(); });
                    foreach (var item in dishonest_readers_) this.Invoke((MethodInvoker)delegate { listView3.Items.Add(item); });
                }
            }
        }

        public StatisticForm()
        {
            InitializeComponent();

            listView1.Visible = GlobalTools.user_level > UserLoginEntity.PrivilegeLevel.USER_LEVEL;
            listView3.Visible = GlobalTools.user_level > UserLoginEntity.PrivilegeLevel.USER_LEVEL;
            label1.Visible = GlobalTools.user_level > UserLoginEntity.PrivilegeLevel.USER_LEVEL;
            label3.Visible = GlobalTools.user_level > UserLoginEntity.PrivilegeLevel.USER_LEVEL;

            this.Shown += (sender, e) => {
                hottest_books = new List<ListViewItem>();
                active_readers = new List<ListViewItem>();
                dishonest_readers = new List<ListViewItem>();
                _thread = new Thread(() => refresh_data(cts.Token));
                _thread.Start();
            };
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            cts.Cancel();
            _thread.Join();

            // 确保调用基类方法
            base.OnFormClosing(e);
        }


        private void refresh_data(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                // 计算距离现在一个月零十五天前的时间
                DateTime borrowTime = DateTime.Now.AddMonths(-1).AddDays(-15);
                var optionalParams = new { BorrowTime = borrowTime };
                var dishonest_borrow_list = SqlHandler.Instance.conn.Query<BorrowEntity>("SELECT * FROM borrow WHERE is_returned = 0 AND borrow_time < @BorrowTime", optionalParams).ToList();
                List<ListViewItem> tmp = new List<ListViewItem>();
                foreach (var borrow in dishonest_borrow_list)
                {
                    BookEntity book = BookTools.FindBook(borrow.Bid) ?? throw new ArgumentNullException(nameof(book));
                    UserLoginEntity userLogin = UserTools.GetUserInfo(borrow.Uid) ?? throw new ArgumentNullException(nameof(userLogin));
                    UserOptionalInfoEntity userOptionalInfo = UserTools.GetUserOptionalInfo(borrow.Uid, false) ?? new UserOptionalInfoEntity(userLogin.Id, null, null, null, null, null, null);
                    ListViewItem listViewItem = new ListViewItem(userLogin.UserName);
                    listViewItem.SubItems.Add(userOptionalInfo.name);
                    listViewItem.SubItems.Add(book.Title);
                    listViewItem.SubItems.Add(borrow.BorrowTime.ToString());

                    tmp.Add(listViewItem);
                }
                dishonest_readers = tmp;

                tmp = new List<ListViewItem>();
                DateTime sinceTime = DateTime.Now.AddMonths(-6);
                optionalParams = new { BorrowTime = sinceTime };
                var active_readers_list = SqlHandler.Instance.conn.Query<BorrowEntity>("SELECT * FROM borrow WHERE borrow_time > @BorrowTime", optionalParams).ToList();
                Dictionary<int, int> borrow_map = new Dictionary<int, int>();
                foreach (var reader in active_readers_list)
                {
                    if(borrow_map.ContainsKey(reader.Uid)) borrow_map[reader.Uid]++;
                    else borrow_map.Add(reader.Uid, 1);
                }
                List<KeyValuePair<int, int>> active_reader_list = new List<KeyValuePair<int, int>>();
                foreach (var reader_pair in borrow_map) active_reader_list.Add(new KeyValuePair<int, int>(reader_pair.Value, reader_pair.Key));
                active_reader_list.Sort((lhs, rhs) => -lhs.Key.CompareTo(rhs.Key));
                foreach (var reader_pair in active_reader_list)
                {
                    UserLoginEntity userLogin = UserTools.GetUserInfo(reader_pair.Value) ?? throw new ArgumentNullException(nameof(userLogin));
                    ListViewItem listViewItem = new ListViewItem(userLogin.UserName);
                    listViewItem.SubItems.Add(reader_pair.Key.ToString());

                    tmp.Add(listViewItem);
                }
                active_readers = tmp;

                tmp = new List<ListViewItem>();
                borrow_map = new Dictionary<int, int>();
                foreach (var borrow in active_readers_list)
                {
                    if (borrow_map.ContainsKey(borrow.Bid)) borrow_map[borrow.Bid]++;
                    else borrow_map.Add(borrow.Bid, 1);
                }
                List<KeyValuePair<int, int>> active_book_list = new List<KeyValuePair<int, int>>();
                foreach (var reader_pair in borrow_map) active_book_list.Add(new KeyValuePair<int, int>(reader_pair.Value, reader_pair.Key));
                active_book_list.Sort((lhs, rhs) => -lhs.Key.CompareTo(rhs.Key));
                foreach (var reader_pair in active_book_list)
                {
                    BookEntity book = BookTools.FindBook(reader_pair.Value) ?? throw new ArgumentNullException(nameof(book));
                    ListViewItem listViewItem = new ListViewItem(book.Title);

                    tmp.Add(listViewItem);
                }
                hottest_books = tmp;

                tmp = new List<ListViewItem>();
                var author_map = new Dictionary<string, int>();
                foreach (var borrow in active_readers_list)
                {
                    BookEntity book = BookTools.FindBook(borrow.Bid) ?? throw new ArgumentNullException();
                    if (author_map.ContainsKey(book.Author)) author_map[book.Author]++;
                    else author_map.Add(book.Author, 1);
                }
                List<KeyValuePair<int, string>> active_author_list = new List<KeyValuePair<int, string>>();
                foreach (var reader_pair in author_map) active_author_list.Add(new KeyValuePair<int, string>(reader_pair.Value, reader_pair.Key));
                active_author_list.Sort((lhs, rhs) => -lhs.Key.CompareTo(rhs.Key));
                foreach (var reader_pair in active_author_list)
                {
                    ListViewItem listViewItem = new ListViewItem(reader_pair.Value);

                    tmp.Add(listViewItem);
                }
                hottest_author = tmp;

                break;
                Thread.Sleep(1000);
            }
        }
    }
}
