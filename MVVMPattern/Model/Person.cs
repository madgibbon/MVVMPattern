﻿using System;
namespace MVVMPattern.Model
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public DateTime Birthday { get; set; }
    }
}