﻿using AutoMapper;
using Moq;
using NUnit.Framework;
using SalaryCalculator.Configuration.Mappings;
using SalaryCalculator.Data.Models;
using SalaryCalculator.Data.Services.Contracts;
using SalaryCalculatorWeb.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SalaryCalculatorWeb.Tests.Controllers.EmployeeControllerTests
{
    [TestFixture]
    public class Index_Should
    {
        [Test]
        public void ReturnViewResultAsListOfEmployees()
        {
            // Arrange
            var mockedMappService = new Mock<IMapService>();
            var employeeService = new Mock<IEmployeeService>();
            EmployeesController emplController = new EmployeesController(mockedMappService.Object, employeeService.Object);

            // Act
            emplController.Index();

            // Assert
            Assert.IsInstanceOf<ViewResult>(emplController.Index());
        }
    }
}
