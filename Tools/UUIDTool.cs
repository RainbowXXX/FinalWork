using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWork.Tools
{
    internal class UUIDTool
    {
        public static string GetUUID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
