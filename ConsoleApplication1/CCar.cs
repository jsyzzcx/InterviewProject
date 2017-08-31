using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class CCar : CVehicle, IAction
    {
        public enum CarTypes : byte
        {
            CarType0  = 0,  //个人车辆
            CarType1  = 1  //工程车辆
        }
       
 

        /// <summary>
        /// 最大速度
        /// </summary>
        public string MaximumSpeed { get; set; }

        /// <summary>
        /// 颜色
        /// </summary>
        public string Colour { get; set; }

        /// <summary>
        /// 车辆类型
        /// </summary>
        public CarTypes CarType { get; set; }

        public void Drive()  
        {
            System.Console.WriteLine("驾驶汽车");
        }
        public void Print()
        {
            Console.WriteLine("车辆的信息：车牌是{0},发动机功率是{1},最高速度是{2},颜色是{3},类型是{4}",
                                            this.SerialNumber,
                                            this.EnginePower,
                                            this.MaximumSpeed,
                                            this.Colour,
                                            this.CarType);

        }




    }



}
