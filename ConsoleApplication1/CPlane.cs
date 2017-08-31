using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public  class CPlane : CVehicle, IAction
    {
        public enum PlaneTypes : byte
        {
            PlaneType0 = 0,  //喷气式 
            PlaneType1 = 1  //螺旋桨
        }
       
        /// <summary>
        /// 翼展
        /// </summary>
        public string Wingspan { get; set; }

        /// <summary>
        /// 负载
        /// </summary>
        public string Load { get; set; }

        /// <summary>
        /// 净重量
        /// </summary>
        public string NetWeight { get; set; }

        /// <summary>
        ///飞机类型
        /// </summary>
        public PlaneTypes PlaneType { get; set; }


        public void Drive()  
        {
            System.Console.WriteLine("驾驶飞机");
        }
        public void Print()
        {
            Console.WriteLine("飞机的信息：编号是{0},发动机功率是{1},翼展是{2},负载是{3},净重量是{4}类型是{5}",
                                            this.SerialNumber,
                                            this.EnginePower,
                                            this.Wingspan,
                                            this.Load,
                                            this.NetWeight,
                                            this.PlaneType);

        }

    }
}
