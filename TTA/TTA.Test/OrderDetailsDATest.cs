﻿using TTA.DAL.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TTA.Model;

namespace TTA.Test
{
    
    
    /// <summary>
    ///This is a test class for OrderDetailsDATest and is intended
    ///to contain all OrderDetailsDATest Unit Tests
    ///</summary>
    [TestClass()]
    public class OrderDetailsDATest
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
        ///A test for GetById
        ///</summary>
        [TestMethod()]
        public void GetByIdTest()
        {
            OrderDetailsDA target = new OrderDetailsDA(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            ProductDE expected = null; // TODO: Initialize to an appropriate value
            ProductDE actual;
            actual = target.GetById(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
