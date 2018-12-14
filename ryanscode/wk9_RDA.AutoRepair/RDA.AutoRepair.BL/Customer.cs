﻿
using System;
using System.Collections.Generic;

namespace RDA.AutoRepair.BL
{
    public class Customer : IComparable<Customer>
    {
        // Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public List<Car> Cars { get; set; }

        public string DisplayName
        {
            get { return LastName + ", " + FirstName; }
        }

        // Constructor
        public Customer()
        {
            Cars = new List<Car>();
        }

        public Customer(string firstName, string lastName, string phone)
        {
            Cars = new List<Car>();
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phone;
        }

        // Methods
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public int CompareTo(Customer other)
        {
            return DisplayName.CompareTo(other.DisplayName);
        }
    }
}
