using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWork.Entities
{
    public class PointEntity
    {
        public int Uid { get; set; }
        public double points {  get; set; }

        public PointEntity(int uid, double points)
        {
            Uid = uid;
            this.points = points;
        }
    }
}
