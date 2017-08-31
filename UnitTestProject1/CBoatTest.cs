using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    
    
    /// <summary>
    ///这是 CBoatTest 的测试类，旨在
    ///包含所有 CBoatTest 单元测试
    ///</summary>
    [TestClass()]
    public class CBoatTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///CBoat 构造函数 的测试
        ///</summary>
        [TestMethod()]
        public void CBoatConstructorTest()
        {
            CBoat target = new CBoat();
            Assert.Inconclusive("TODO: 实现用来验证目标的代码");
        }

        /// <summary>
        ///Drive 的测试
        ///</summary>
        [TestMethod()]
        public void DriveTest()
        {
            CBoat target = new CBoat(); // TODO: 初始化为适当的值
            target.Drive();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///Print 的测试
        ///</summary>
        [TestMethod()]
        public void PrintTest()
        {
            CBoat target = new CBoat(); // TODO: 初始化为适当的值
            target.Print();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///BoatType 的测试
        ///</summary>
        [TestMethod()]
        public void BoatTypeTest()
        {
            CBoat target = new CBoat(); // TODO: 初始化为适当的值
            CBoat.BoatTypes expected = new CBoat.BoatTypes(); // TODO: 初始化为适当的值
            CBoat.BoatTypes actual;
            target.BoatType = expected;
            actual = target.BoatType;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///MaximumSpeed 的测试
        ///</summary>
        [TestMethod()]
        public void MaximumSpeedTest()
        {
            CBoat target = new CBoat(); // TODO: 初始化为适当的值
            string expected = string.Empty; // TODO: 初始化为适当的值
            string actual;
            target.MaximumSpeed = expected;
            actual = target.MaximumSpeed;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Tonnage 的测试
        ///</summary>
        [TestMethod()]
        public void TonnageTest()
        {
            CBoat target = new CBoat(); // TODO: 初始化为适当的值
            string expected = string.Empty; // TODO: 初始化为适当的值
            string actual;
            target.Tonnage = expected;
            actual = target.Tonnage;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }
    }
}
