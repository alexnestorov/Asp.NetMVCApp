﻿using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Moq;
using NUnit.Framework;
using SalaryCalculator.Data.Models;
using SalaryCalculatorWeb.Controllers;
using SalaryCalculatorWeb.Models.ManageViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SalaryCalculatorWeb.Tests.Controllers.ManageControllerTests
{
    [TestFixture]
    public class ChangePassword_Should
    {
        [Test]
        public void ReturnViewResult_WhenIsCalled()
        {
            // Arrange
            ManageController manageController = new ManageController();

            // Act
            ViewResult result = manageController.ChangePassword() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void ReturnChangePasswordViewModel_WhenModelStateIsNotValid()
        {
            // Arrange
            var mockedStore = new Mock<IUserStore<User>>();
            var mockedUserManager = new Mock<ApplicationUserManager>(mockedStore.Object);

            var mockedAuthenticationManager = new Mock<IAuthenticationManager>();
            var mockedSignInManager = new Mock<ApplicationSignInManager>(mockedUserManager.Object, mockedAuthenticationManager.Object);

            var mockedViewModel = new Mock<ChangePasswordViewModel>();
            ManageController manageController = new ManageController(mockedUserManager.Object, mockedSignInManager.Object);
            manageController.ModelState.AddModelError("invalid", "invalid");

            // Act
            var actionResultTask = manageController.ChangePassword(mockedViewModel.Object);
            actionResultTask.Wait();
            var viewResult = actionResultTask.Result as ViewResult;

            // Assert
            Assert.IsInstanceOf<ChangePasswordViewModel>(viewResult.Model);
        }
    }
}
