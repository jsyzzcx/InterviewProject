using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<object> olist = new List<object>();

            //var car1 = new  
            //{
            //    SerialNumber = "1号",
            //    LicensePlate = "nf123456",
            //    EnginePower ="147千瓦",
            //    MaximumSpeed = "200公里/小时",
            //    Colour ="绿色",
            //    CarType =CCar.CarTypes.CarType0
            //};
            // var car2 = new  
            //{
            //    SerialNumber = "2号",
            //    LicensePlate = "nf654321",
            //    EnginePower ="150千瓦",
            //    MaximumSpeed = "195公里/小时",
            //    Colour = "蓝色",
            //    CarType =CCar.CarTypes.CarType0
            //};
 
            //olist.Add(car1);
            //olist.Add(car2);

 
            ////print(olist);
            //print(car1);
            //print(car2);
            //compare(car1, car2);


            CCar CCar1 = new CCar();
            CCar1.SerialNumber = "nf123456";
            CCar1.EnginePower = "147千瓦";
            CCar1.MaximumSpeed = "200公里/小时";
            CCar1.Colour = "绿色";
            CCar1.CarType = CCar.CarTypes.CarType0;
            CCar CCar2 = new CCar();
            CCar2.SerialNumber = "nf654321";
            CCar2.EnginePower = "150千瓦";
            CCar2.MaximumSpeed = "195公里/小时";
            CCar2.Colour = "蓝色";
            CCar2.CarType = CCar.CarTypes.CarType1;



            CCar1.Drive();
            CCar1.Print();
            CCar2.Print();
            Compare(CCar1, CCar2);


            CPlane CPlane1 = new CPlane();
            CPlane1.SerialNumber = "ln1234";
            CPlane1.EnginePower = "1000千瓦";
            CPlane1.Wingspan = "30m";
            CPlane1.Load = "2T";
            CPlane1.NetWeight = "10T";
            CPlane1.PlaneType = CPlane.PlaneTypes.PlaneType0;

            CPlane1.Drive();
            CPlane1.Print();

     

            CBoat CBoat1 = new CBoat();
            CBoat1.SerialNumber = "abc123";
            CBoat1.EnginePower = "100千瓦";
            CBoat1.MaximumSpeed = "30节每小时";
            CBoat1.Tonnage = "500公斤";
            CBoat1.BoatType = CBoat.BoatTypes.BoatType0;
         
            CBoat1.Drive();
            CBoat1.Print();


            JsonExp(CBoat1);

            Console.ReadKey();

        }

        /// <summary>
        ///  比较，2个车，是否同一辆
        /// </summary>
        /// <param name="_CCar1"></param>
        /// <param name="_CCar2"></param>
        public static void Compare(CCar _CCar1, CCar _CCar2)
        {
            if (_CCar1.SerialNumber.Equals(_CCar2.SerialNumber) &&
                _CCar1.EnginePower.Equals(_CCar2.EnginePower) &&
                _CCar1.MaximumSpeed.Equals(_CCar2.MaximumSpeed) &&
                _CCar1.Colour.Equals(_CCar2.Colour))
            {
                Console.WriteLine("{0}车和{1}车 是一样的", _CCar1.SerialNumber, _CCar2.SerialNumber);
            }
            else
            {
                Console.WriteLine("{0}车和{1}车 是不一样的", _CCar1.SerialNumber, _CCar2.SerialNumber);
            }
        }

        /// <summary>
        /// json文件导出
        /// </summary>
        public static void JsonExp(object obj)
       {

           string jsonData = JsonConvert.SerializeObject(obj);

           using (FileStream fs = new FileStream(@"c:\json.txt", FileMode.OpenOrCreate))
           {
               StreamWriter sw = new StreamWriter(fs);
               sw.Write(jsonData);
               sw.Close();
           }

           Console.WriteLine("json文件已导出到C盘下："+ jsonData);
        

       }










        /// <summary>
        /// 打印出，所有的车辆信息
        /// </summary>
        /// <param name="olist"></param>
        //public static void printList(List<object> olist)
        //{
        //    foreach (dynamic item in olist)
        //    {
        //        Console.WriteLine(item.SerialNumber);
        //    }
        //}
        /// <summary>
        /// 打印出单个车辆信息
        /// </summary>
        /// <param name="_CCar"></param>
        //public static void print(object _CCar)
        //{
        //    Console.WriteLine("{0}的信息是：车牌是{1},发动机功率是{2},最高速度是{3},颜色是{4},类型是{5}",
        //    _CCar.GetType().GetProperty("SerialNumber").GetValue(_CCar).ToString(),
        //    _CCar.GetType().GetProperty("LicensePlate").GetValue(_CCar).ToString(),
        //    _CCar.GetType().GetProperty("EnginePower").GetValue(_CCar).ToString(),
        //    _CCar.GetType().GetProperty("MaximumSpeed").GetValue(_CCar).ToString(),
        //    _CCar.GetType().GetProperty("Colour").GetValue(_CCar).ToString(),
        //    _CCar.GetType().GetProperty("CarType").GetValue(_CCar).ToString());
        //}
        /// <summary>
        /// 比较，2个车，是否同一辆
        /// </summary>
        /// <param name="_CCar"></param>
        //public static void compare(object _CCar1, object _CCar2)
        //{
        //    if (_CCar1.GetType().GetProperty("SerialNumber").GetValue(_CCar1).ToString().Equals(_CCar2.GetType().GetProperty("SerialNumber").GetValue(_CCar2).ToString()) &&
        //        _CCar1.GetType().GetProperty("LicensePlate").GetValue(_CCar1).ToString().Equals(_CCar2.GetType().GetProperty("LicensePlate").GetValue(_CCar2).ToString()) &&
        //        _CCar1.GetType().GetProperty("EnginePower").GetValue(_CCar1).ToString().Equals(_CCar2.GetType().GetProperty("EnginePower").GetValue(_CCar2).ToString()) &&
        //       _CCar1.GetType().GetProperty("MaximumSpeed").GetValue(_CCar1).ToString().Equals(_CCar2.GetType().GetProperty("MaximumSpeed").GetValue(_CCar2).ToString())
        //       )
        //    {
        //        Console.WriteLine("{0}车和{1}车 是一样的", _CCar1.GetType().GetProperty("SerialNumber").GetValue(_CCar1).ToString(), _CCar2.GetType().GetProperty("SerialNumber").GetValue(_CCar2).ToString());
        //    }
        //    else
        //    {
        //        Console.WriteLine("{0}车和{1}车 是不一样的", _CCar1.GetType().GetProperty("SerialNumber").GetValue(_CCar1).ToString(), _CCar2.GetType().GetProperty("SerialNumber").GetValue(_CCar2).ToString());
        //    }
        //}
   

    }
}
