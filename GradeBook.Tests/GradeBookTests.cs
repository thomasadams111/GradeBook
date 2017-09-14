using GradeBook;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void CheckGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual("B", result.LetterGrade);
        }

        [TestMethod]
        public void ComputerHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void ComputerLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);
        }

        [TestMethod]
        public void ComputerAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(85.16f, result.AverageGrade, 0.01);
        }
    }
}
