using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWork.Tools
{
    public class RandomTools
    {
        private static Random _random = new Random();

        public static int getRandomNum(int lower_bound, int upper_bound) {
            return _random.Next(lower_bound, upper_bound);
        }
    }
}
