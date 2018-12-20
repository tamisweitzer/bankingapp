using System;
using System.Data;


namespace TSS.BankingApp.BL
{
    public class Person
    {
        // Properties
        public string SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public int Age {
            get {
                DateTime CurrentYear = new DateTime();
                return (CurrentYear.Year - BirthDate.Year);
            }
        }
        public DateTime BirthDate { get; set; }



       // Constructors
       public Person()
        {
            
        }


        public Person( string ssn, string firstname, string lastname, DateTime birthdate)
        {
            SSN = ssn;
            FirstName = firstname;
            LastName = lastname;
            BirthDate = birthdate;
        }
    }
}