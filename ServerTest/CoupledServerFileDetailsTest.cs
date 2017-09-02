using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerBusinessLogic;

namespace ServerTest
{
    [TestClass]
    public class CoupledServerFileDetailsTest
    {
        [TestMethod]
        //This is not a unit test as we are not mocking the depednecy
        public void CoupledServerFileNameTest()
        {
            //Arrange
            CoupledServerFileDetails serverFileDetails = new CoupledServerFileDetails();
            string expectedFile = @"C:\Images\CodeWithVijay.jpg";

            //Act
            string actualFile = serverFileDetails.GetFile();

            //Assert
            //Assert
            //﻿If I give any other value other than C:\Images\CodeWithVijay.jpg
            //﻿My test will fail as my test is testing actual data as well
            //which is not supposed to do in unit test﻿
            Assert.AreEqual(expectedFile, actualFile);
        }


        [TestMethod]
        public void DeCoupledServerFileNameTestWithManualMocking()
        {
            //Arrange
            IFileConfig mockConfig = new MockFileConfig();

            DeCoupledServerFileDetails serverFileDetails = new DeCoupledServerFileDetails(mockConfig);
            string expectedFile = @"TestPath\TestFileName";

            //Act
            string actualFile = serverFileDetails.GetFile();

            //Assert

            Assert.AreEqual(expectedFile, actualFile);
        }

        [TestMethod]
        public void DeCoupledServerFileNameTestWithMOQ()
        {
            //Arrange
            IFileConfig mockConfig = new MockFileConfig();

            DeCoupledServerFileDetails serverFileDetails = new DeCoupledServerFileDetails(mockConfig);
            string expectedFile = @"TestPath\TestFileName";

            //Act
            string actualFile = serverFileDetails.GetFile();

            //Assert

            Assert.AreEqual(expectedFile, actualFile);
        }
    }

}
