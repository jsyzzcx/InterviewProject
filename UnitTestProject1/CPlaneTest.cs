using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    
    
    /// <summary>
    ///这是 CPlaneTest 的测试类，旨在
    ///包含所有 CPlaneTest 单元测试
    ///</summary>
    [TestClass()]
    public class CPlaneTest
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
        ///CPlane 构造函数 的测试
        ///</summary>
        [TestMethod()]
        public void CPlaneConstructorTest()
        {
            CPlane target = new CPlane();
            Assert.Inconclusive("TODO: 实现用来验证目标的代码");
        }

        /// <summary>
        ///Drive 的测试
        ///</summary>
        [TestMethod()]
        public void DriveTest()
        {
            CPlane target = new CPlane(); // TODO: 初始化为适当的值
            target.Drive();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///Print 的测试
        ///</summary>
        [TestMethod()]
        public void PrintTest()
        {
            CPlane target = new CPlane(); // TODO: 初始化为适当的值
            target.Print();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///Load 的测试
        ///</summary>
        [TestMethod()]
        public void LoadTest()
        {
            CPlane target = new CPlane(); // TODO: 初始化为适当的值
            string expected = string.Empty; // TODO: 初始化为适当的值
            string actual;
            target.Load = expected;
            actual = target.Load;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///NetWeight 的测试
        ///</summary>
        [TestMethod()]
        public void NetWeightTest()
        {
            CPlane target = new CPlane(); // TODO: 初始化为适当的值
            string expected = string.Empty; // TODO: 初始化为适当的值
            string actual;
            target.NetWeight = expected;
            actual = target.NetWeight;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///PlaneType 的测试
        ///</summary>
        [TestMethod()]
        public void PlaneTypeTest()
        {
            CPlane target = new CPlane(); // TODO: 初始化为适当的值
            CPlane.PlaneTypes expected = new CPlane.PlaneTypes(); // TODO: 初始化为适当的值
            CPlane.PlaneTypes actual;
            target.PlaneType = expected;
            actual = target.PlaneType;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Wingspan 的测试
        ///</summary>
        [TestMethod()]
        public void WingspanTest()
        {
            CPlane target = new CPlane(); // TODO: 初始化为适当的值
            string expected = string.Empty; // TODO: 初始化为适当的值
            string actual;
            target.Wingspan = expected;
            actual = target.Wingspan;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }
    }
}
