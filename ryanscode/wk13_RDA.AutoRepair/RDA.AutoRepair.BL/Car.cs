using System;

namespace RDA.AutoRepair.BL
{
    public class Car : Vehicle, IComparable<Car> // Car inherits from Vehicle
    {
        // fields
        private int year = DateTime.Now.Year;

        public int Year
        {
            get { return year; }
            set
            {
                if (value > 1910)
                {
                    year = value;
                }
                else
                {
                    InvalidYearException iye = new InvalidYearException();
                    iye.InvalidYear = value;
                    throw iye;
                }
            }
        }

        public string DisplayName
        {
            get { return Year + " " + Make + " " + Model; }
        }

        // constructor
        public Car()
        {
            //UpdateVIN("4"); // calls the protected
        }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public int CompareTo(Car other)
        {
            return Year.CompareTo(other.Year);
        }
    }
}
