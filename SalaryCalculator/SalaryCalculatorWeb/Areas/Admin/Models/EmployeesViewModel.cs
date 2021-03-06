﻿using SalaryCalculator.Configuration.Mappings;
using SalaryCalculator.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalaryCalculatorWeb.Areas.Admin.Models
{
    public class EmployeesViewModel : IMapFrom<Employee>
    {
        public virtual int Id { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string MiddleName { get; set; }

        public virtual string LastName { get; set; }

        public virtual string PersonalId { get; set; }
    }
}