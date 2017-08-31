using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class CBoat : CVehicle, IAction
    {
        public enum BoatTypes : byte
        {
            BoatType0 = 0,  //民用
            BoatType1 = 1  //游艇
        }

        /// <summary>
        /// 最大速度
        /// </summary>
        public string MaximumSpeed { get; set; }

        /// <summary>
        /// 总吨位
        /// </summary>
        public string Tonnage { get; set; }

        /// <summary>
        /// 轮船类型
        /// </summary>
        public BoatTypes BoatType { get; set; }


        public void Drive()
        {
            System.Console.WriteLine("驾驶轮船");
        }
        public void Print()
        {
            Console.WriteLine("轮船的信息：编号是{0},发动机功率是{1},最大速度是{2},总吨位是{3},类型是{4}",
                                            this.SerialNumber,
                                            this.EnginePower,
                                            this.MaximumSpeed,
                                            this.Tonnage,
                                            this.BoatType);

        }

    }
}
