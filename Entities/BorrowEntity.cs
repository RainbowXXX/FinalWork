using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWork.Entities
{
    public class BorrowEntity
    {
        public int Id { get; set; }
        public int Uid { get; set; }
        public int Bid { get; set; }
        public bool IsReturned { get; set; }
        public DateTime BorrowTime { get; set; }

        // System.Int32 id, System.Int32 uid, System.Int32 bid, System.Boolean is_returned, System.DateTime borrow_time
        public BorrowEntity(int id, int uid, int bid, bool is_returned, DateTime borrow_time)
        {
            Id = id;
            Uid = uid;
            Bid = bid;
            IsReturned = is_returned;
            BorrowTime = borrow_time;
        }
    }
}
