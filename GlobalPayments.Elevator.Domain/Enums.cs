using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalPayments.Elevator.Domain
{
    public class Enums
    {
        public enum ElevatorDirection
        {
            None,
            Up,
            Down
        }

        public enum ElevatorState
        {
            On_Hold,
            Blocked,
            Opening_Doors,
            Closing_Doors
        }

        public enum ElevatorFloor
        {
            First = 1,
            Second = 2,
            Third = 3,
            Fourth = 4,
            Fifth = 5
        }
    }
}
