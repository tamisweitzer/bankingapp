using System;

namespace RDA.AutoRepair.BL
{
    public class InvalidYearException : Exception
    {
        public int InvalidYear { get; set; }
    }
}
