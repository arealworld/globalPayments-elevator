using System;
using System.Collections.Generic;
using System.Text;
using static GlobalPayments.Elevator.Domain.Enums;

namespace GlobalPayments.Elevator.Domain
{
    public class ElevatorRequest
    {
        public ElevatorFloor Floor { get; set; }
        public bool Completed { get; set; } = false;
        public ElevatorDirection Direction { get; set; }

        public string Description => $"Floor: {(int)Floor}, Completed: {Completed}";
    }
}
