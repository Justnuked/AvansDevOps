using Microsoft.VisualStudio.TestTools.UnitTesting;
using PipeLine.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace PipeLine.Classes.Tests
{
    [TestClass()]
    public class PipelineTests
    {
        [TestMethod()]
        public void AddingModulesToPipeline()
        {
            //arrange
            Pipeline pipeline = new Pipeline("Test", Pipeline.PipeLineType.DEVELOPMENT);

            Mock<BuildCSharp> buildModuleMock = new Mock<BuildCSharp>();
            buildModuleMock.Setup(x => x.GetStatus()).Returns(Status.SUCCES);

            //act
            pipeline.AddModule(buildModuleMock.Object);

            //assert
            Assert.IsTrue(pipeline.GetAllModules().Count == 1);
        }
    }
}