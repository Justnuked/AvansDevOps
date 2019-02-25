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
    public class SprintTests
    {
        [TestMethod()]
        public void TestAddReviewDocumentWhenSprintIsActive()
        {
            Sprint sprint = new Sprint(DateTime.Today, DateTime.Today.AddDays(10));
            ReviewDocument document = new ReviewDocument();

            sprint.Start();

            sprint.AddReviewDocument(document);

            Assert.IsTrue(sprint.GetDocument() == null);
        }

        [TestMethod()]
        public void TestAddReviewDocument()
        {
            Sprint sprint = new Sprint(DateTime.Today, DateTime.Today);
            ReviewDocument document = new ReviewDocument();

            sprint.Start();
            sprint.CheckTime();

            sprint.AddReviewDocument(document);

            Assert.IsTrue(sprint.GetDocument() != null);
        }
    }
}