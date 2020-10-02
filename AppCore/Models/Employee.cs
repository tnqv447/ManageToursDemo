﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SEX Sex { get; set; }
        public string IdentityCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public int JobId { get; set; }
        public Job Job { get; set; }

        public STATUS Status { get; set; } = STATUS.AVAILABLE;

        public Employee()
        {
        }

        public Employee(string name, SEX sex, string identityCode, string phoneNumber, string address, int jobId, STATUS status = STATUS.AVAILABLE)
        {
            Name = name;
            Sex = sex;
            IdentityCode = identityCode;
            PhoneNumber = phoneNumber;
            Address = address;
            JobId = jobId;
            Status = status;
        }
    }
}