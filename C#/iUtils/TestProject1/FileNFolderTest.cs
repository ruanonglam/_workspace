using iUtils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for FileNFolderTest and is intended
    ///to contain all FileNFolderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FileNFolderTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for getFileNameFromPath
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void copyFileNameFromPathTest()
        {
            FileNFolder target = new FileNFolder();
            string path = null;
            string expected = null;
            string actual;
            actual = target.copyFileNameFromPath(path);
            //Assert.AreEqual(expected, actual);
            Assert.Fail();
        }

        /// <summary>
        ///A test for cutFile
        ///</summary>
        [TestMethod()]
        public void cutFileTest()
        {
            FileNFolder target = new FileNFolder(); // TODO: Initialize to an appropriate value
            string from = string.Empty; // TODO: Initialize to an appropriate value
            string to = string.Empty; // TODO: Initialize to an appropriate value
            target.cutFile(from, to);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for copyFile
        ///</summary>
        [TestMethod()]
        public void copyFileTest()
        {
            FileNFolder target = new FileNFolder(); // TODO: Initialize to an appropriate value
            string from = string.Empty; // TODO: Initialize to an appropriate value
            string to = string.Empty; // TODO: Initialize to an appropriate value
            target.copyFile(from, to);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
