using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace ServerTest
{
    public class DeCoupledServerFileDetailsTest
    {
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
            Mock<IFileConfig> mockConfig = new Mock<IFileConfig>();
            mockConfig.SetupGet(a => a.FilePath).Returns(@"TestPath\");
            mockConfig.SetupGet(a => a.FileName).Returns("TestFileName");

            DeCoupledServerFileDetails serverFileDetails = new DeCoupledServerFileDetails(mockConfig.Object);
            string expectedFile = @"TestPath\TestFileName";

            //Act
            string actualFile = serverFileDetails.GetFile();

            //Assert
            Assert.AreEqual(expectedFile, actualFile);
        }
    }
    public class MockFileConfig : IFileConfig
    {
        public string FilePath => @"TestPath\";

        public string FileName => "TestFileName";
    }
}
