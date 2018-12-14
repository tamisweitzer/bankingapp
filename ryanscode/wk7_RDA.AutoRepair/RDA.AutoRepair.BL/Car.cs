using System;

namespace RDA.AutoRepair.BL
{
    public class Car : Vehicle // Car inherits from Vehicle
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

    }
}
