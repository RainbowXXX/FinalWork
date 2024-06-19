using Dapper;
using FinalWork.Configs;
using FinalWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinalWork.Tools
{
    public class BorrowTools
    {
        public static List<BorrowEntity> GetBorrows()
        {
            var optionalParams = new { Uid = GlobalTools.cur_uid };
            return SqlHandler.Instance.conn.Query<BorrowEntity>("SELECT * FROM borrow WHERE uid = @Uid AND is_returned = 0;", optionalParams).ToList();
        }

        public static bool BorrowBook(BorrowEntity borrow)
        {
            if (SqlHandler.Instance.conn.Execute("INSERT INTO work_database.borrow (uid, bid, is_returned, borrow_time) VALUES (@Uid, @Bid, DEFAULT, DEFAULT);", borrow) != 1) return false;
            if (SqlHandler.Instance.conn.Execute("UPDATE books t SET t.inventory = t.inventory - 1 WHERE t.id = @Bid;", borrow) != 1) return false;
            return true;
        }

        public static bool return_book(BorrowEntity borrow)
        {
            using (var transaction = SqlHandler.Instance.conn.BeginTransaction()) {
                if (SqlHandler.Instance.conn.Execute("UPDATE borrow t SET t.is_returned = 1 WHERE t.id = @Id;", borrow) != 1) return false;
                if (SqlHandler.Instance.conn.Execute("UPDATE books t SET t.inventory = t.inventory + 1 WHERE t.id = @Bid;", borrow) != 1) return false;
                transaction.Commit();
                return true;
            }
        }
    }
}
