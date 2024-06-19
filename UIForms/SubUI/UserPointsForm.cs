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
    public partial class UserPointsForm : Form
    {
        public UserPointsForm()
        {
            InitializeComponent();

            List<PointEntity> pointEntities = SqlHandler.Instance.conn.Query<PointEntity>("SELECT * FROM user_points;").ToList();
            int idx = 1;
            foreach (PointEntity pointEntity in pointEntities)
            {
                ListViewItem item = new ListViewItem((idx++).ToString());
                item.SubItems.Add(UserTools.GetUserInfo(pointEntity.Uid)?.UserName ?? throw new ArgumentNullException());
                item.SubItems.Add(pointEntity.points.ToString());
                item.SubItems.Add(pointEntity.points<0? "异常": pointEntity.points == 0 ? "危险" : "正常");

                listView1.Items.Add(item);
            }
        }
    }
}
