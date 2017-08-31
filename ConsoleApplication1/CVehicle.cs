using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class CVehicle
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// 发动机功率
        /// </summary>
        public string EnginePower { get; set; }

    }
}
