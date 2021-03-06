﻿using Microsoft.AspNet.Identity.EntityFramework;

using NUnit.Framework;

using SalaryCalculator.Data;
using SalaryCalculator.Data.Contracts;
using SalaryCalculator.Data.Models;

namespace SalaryCalculator.Tests.Data.SalaryCalculatorDbContextTests
{
    [TestFixture]
    public class CreateMethod_Should
    {
        [Test]
        public void DbContext_ShouldCreateInstance_WhenCreateMethodIsInvoked()
        {
            // Arrange & Act
            ISalaryCalculatorDbContext dbContext = SalaryCalculatorDbContext.Create();

            // Assert
            Assert.IsInstanceOf(typeof(IdentityDbContext<User>), dbContext);
        }
    }
}
