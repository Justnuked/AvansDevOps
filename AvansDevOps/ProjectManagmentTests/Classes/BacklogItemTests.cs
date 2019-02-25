using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectManagment.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using ProjectManagment.Classes;

namespace ProjectManagment.Classes.Tests
{
    [TestClass()]
    public class BacklogItemTests
    {
        [TestMethod()]
        public void ProgressTest()
        {
            //arrange
            Mock<Sprint> sprint = new Mock<Sprint>();
            
            Backlog backlog = new Backlog(sprint.Object);

            BacklogItem headItem = new BacklogItem("Desc");

            backlog.AddBacklogItem(headItem);

            //act
            headItem.Progress();

            //assert

            Assert.IsTrue(headItem.state.GetType().Equals("doing"));
        }

        [TestMethod()]
        public void ProgressTestSubItem()
        {
            //arrange
            Mock<Sprint> sprint = new Mock<Sprint>();

            Backlog backlog = new Backlog(sprint.Object);

            BacklogItem headItem = new BacklogItem("Desc");
            BacklogItem subItem = new BacklogItem("sub");

            backlog.AddBacklogItem(headItem);
            headItem.AddSubItem(subItem);

            //act
            headItem.Progress();
            subItem.Progress();

            //assert
            Assert.IsTrue(headItem.state.GetType().Equals("doing"));
            Assert.IsTrue(subItem.state.GetType().Equals("doing"));
        }

        [TestMethod()]
        public void CheckDoneHeadItemIfSubItemsAreDone()
        {
            //arrange
            Mock<Sprint> sprint = new Mock<Sprint>();

            Backlog backlog = new Backlog(sprint.Object);

            BacklogItem headItem = new BacklogItem("Desc");
            BacklogItem subItem = new BacklogItem("sub");

            backlog.AddBacklogItem(headItem);
            headItem.AddSubItem(subItem);

            //act
            headItem.Progress();
            subItem.Progress();
            subItem.Progress();
            headItem.Progress();

            //assert
            Assert.IsTrue(subItem.state.GetType().Equals("done"));
            Assert.IsTrue(headItem.state.GetType().Equals("done"));
        }

        [TestMethod()]
        public void CheckNotDoneHeadItemIfSubItemsAreNotDone()
        {
            //arrange
            Mock<Sprint> sprint = new Mock<Sprint>();

            Backlog backlog = new Backlog(sprint.Object);

            BacklogItem headItem = new BacklogItem("Desc");
            BacklogItem subItem = new BacklogItem("sub");

            backlog.AddBacklogItem(headItem);
            headItem.AddSubItem(subItem);

            //act
            headItem.Progress();
            headItem.Progress();

            //assert
            Assert.IsFalse(headItem.state.GetType().Equals("done"));
        }

        [TestMethod()]
        public void CheckSetBackHeadItem()
        {
            //arrange
            Mock<Sprint> sprint = new Mock<Sprint>();

            Backlog backlog = new Backlog(sprint.Object);

            BacklogItem headItem = new BacklogItem("Desc");

            backlog.AddBacklogItem(headItem);

            //act
            headItem.Progress();
            headItem.state.SetBack();

            //assert
            Assert.IsTrue(headItem.state.GetType().Equals("todo"));
        }

        [TestMethod()]
        public void CheckSetBackSubItem()
        {
            //arrange
            Mock<Sprint> sprint = new Mock<Sprint>();

            Backlog backlog = new Backlog(sprint.Object);

            BacklogItem headItem = new BacklogItem("Desc");
            BacklogItem subItem = new BacklogItem("sub");

            backlog.AddBacklogItem(headItem);
            headItem.AddSubItem(subItem);

            //act
            headItem.Progress();
            subItem.Progress();
            subItem.state.SetBack();

            //assert
            Assert.IsTrue(subItem.state.GetType().Equals("todo"));
            Assert.IsTrue(headItem.state.GetType().Equals("doing"));
        }

        [TestMethod()]
        public void CheckSetBackMainItemState()
        {
            //arrange
            Mock<Sprint> sprint = new Mock<Sprint>();

            Backlog backlog = new Backlog(sprint.Object);

            BacklogItem headItem = new BacklogItem("Desc");
            BacklogItem subItem = new BacklogItem("sub");

            backlog.AddBacklogItem(headItem);
            headItem.AddSubItem(subItem);

            //act
            headItem.Progress();
            subItem.Progress();
            subItem.Progress();
            subItem.state.SetBack();

            //assert
            Assert.IsTrue(subItem.state.GetType().Equals("todo"));
            Assert.IsTrue(headItem.state.GetType().Equals("doing"));
        }
    }
}