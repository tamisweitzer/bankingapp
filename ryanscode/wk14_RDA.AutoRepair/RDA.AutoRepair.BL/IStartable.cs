using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDA.AutoRepair.BL
{
    public enum DoorState
    {
        Closed, Opening, Open, Closing
    }


    public interface IStartable
    {
        bool NeedsKey { get; set; }

        //DoorState PassengerDoor { get; set; }

        void Start();
    }
}
