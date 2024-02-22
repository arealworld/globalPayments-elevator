using System;
using System.Collections.Generic;
using System.Text;
using static GlobalPayments.Elevator.Domain.Enums;

namespace GlobalPayments.Elevator.Domain
{
    public class ElevatorButton
    {
        public ElevatorFloor Floor { get; set; }
    }

    public class ElevatorInternalButton : ElevatorButton
    {

    }

    public class ElevatorExternalButton : ElevatorButton
    {
        public ElevatorDirection Direction { get; set; }
    }
}
