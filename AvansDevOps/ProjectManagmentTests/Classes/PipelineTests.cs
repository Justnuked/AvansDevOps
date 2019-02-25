using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectManagment.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using ProjectManagment.Classes;
using PipeLine.Classes;
using PipeLine.Interfaces;

namespace ProjectManagment.Classes.Tests
{
    [TestClass()]
    public class PipelineTests
    {
        [TestMethod()]
        public void AddingModulesToPipeline()
        {
            //arrange
            Pipeline pipeline = new Pipeline("Test", Pipeline.PipeLineType.DEVELOPMENT);

            Mock<IPipeLineModule> buildModuleMock = new Mock<IPipeLineModule>();
            buildModuleMock.Setup(x => x.GetStatus()).Returns(Status.SUCCES);

            //act
            pipeline.AddModule(buildModuleMock.Object);

            //assert
            Assert.IsTrue(pipeline.GetAllModules().Count == 1);
        }

        [TestMethod()]
        public void RemoveModuleFromPipeline()
        {
            //arrange
            Pipeline pipeline = new Pipeline("Test", Pipeline.PipeLineType.DEVELOPMENT);

            Mock<IPipeLineModule> buildModuleMock = new Mock<IPipeLineModule>();
            buildModuleMock.Setup(x => x.GetStatus()).Returns(Status.SUCCES);

            //act
            pipeline.AddModule(buildModuleMock.Object);
            pipeline.RemoveModule(buildModuleMock.Object);

            //assert
            Assert.IsTrue(pipeline.GetAllModules().Count == 0);
        }

        [TestMethod()]
        public void RemoveModuleFromPipelineThatIsNotInPipeline()
        {
            //arrange
            Pipeline pipeline = new Pipeline("Test", Pipeline.PipeLineType.DEVELOPMENT);

            Mock<IPipeLineModule> buildModuleMock = new Mock<IPipeLineModule>();
            buildModuleMock.Setup(x => x.GetStatus()).Returns(Status.SUCCES);

            Mock<IPipeLineModule> mock2 = new Mock<IPipeLineModule>();
            mock2.Setup(x => x.GetStatus()).Returns(Status.SUCCES);

            //act
            pipeline.AddModule(buildModuleMock.Object);
            pipeline.RemoveModule(mock2.Object);

            //assert
            Assert.IsTrue(pipeline.GetAllModules().Count == 1);
        }

        [TestMethod()]
        public void RunningPipeLineSuccess()
        {
            //arrange
            Pipeline pipeline = new Pipeline("Test", Pipeline.PipeLineType.DEVELOPMENT);

            Mock<IPipeLineModule> mock1 = new Mock<IPipeLineModule>();
            mock1.Setup(x => x.GetStatus()).Returns(Status.SUCCES);

            Mock<IPipeLineModule> mock2 = new Mock<IPipeLineModule>();
            mock2.Setup(x => x.GetStatus()).Returns(Status.SUCCES);

            //act
            pipeline.AddModule(mock1.Object);
            pipeline.AddModule(mock2.Object);

            pipeline.Execute();


            //assert
            Assert.IsTrue(pipeline.GetFailedModule() == null);
        }

        [TestMethod()]
        public void RunningPipeLineFailure()
        {
            //arrange
            Pipeline pipeline = new Pipeline("Test", Pipeline.PipeLineType.DEVELOPMENT);

            Mock<IPipeLineModule> mock1 = new Mock<IPipeLineModule>();
            mock1.Setup(x => x.GetStatus()).Returns(Status.SUCCES);

            Mock<IPipeLineModule> mock2 = new Mock<IPipeLineModule>();
            mock2.Setup(x => x.GetStatus()).Returns(Status.FAILED);

            //act
            pipeline.AddModule(mock1.Object);
            pipeline.AddModule(mock2.Object);

            pipeline.Execute();


            //assert
            Assert.IsTrue(pipeline.GetFailedModule() != null);
        }
    }
}