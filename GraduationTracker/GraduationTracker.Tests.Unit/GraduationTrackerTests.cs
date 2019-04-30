using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using GraduationTracker.DataObjects;
using GraduationTracker.Enums;
using GraduationTracker.Repository.Abstract;
using GraduationTracker.Repository.Concrete;

namespace GraduationTracker.Tests.Unit
{
    [TestClass]
    public class GraduationTrackerTests
    {

        private IGraduationTracker _tracker;
        private IDiplomaRepository _diplomas;
        private IStudentRepository _students;

        private Diploma diploma;


        [ClassInitialize]
        public void ClassInit()
        {
            _tracker = new GraduationTracker();
            _diplomas = new DiplomaRepository();
            _students = new StudentRepository();
        }
        
        [TestInitialize]
        public void TestInit()
        {
            diploma = _diplomas.GetAll().FirstOrDefault();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            _tracker = null;
            _diplomas = null;
            _students = null;
        }

        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataTestMethod]
        public void TestHasCredits(int studentId)
        {
            // Arrange
            var student = _students.Get(studentId);

            // Act
            var graduated = _tracker.HasGraduated(diploma, student);
            
            // Assert
            Assert.IsTrue(graduated.Item1);

        }


        [DataRow(4)]
        [DataTestMethod]
        public void TestHasNoCredits(int studentId)
        {
            // Arrange
            var student = _students.Get(studentId);

            // Act
            var graduated = _tracker.HasGraduated(diploma, student);

            // Assert
            Assert.IsFalse(graduated.Item1);

        }


    }
}
