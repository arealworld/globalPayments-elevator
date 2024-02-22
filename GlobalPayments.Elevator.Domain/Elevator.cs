using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static GlobalPayments.Elevator.Domain.Enums;

namespace GlobalPayments.Elevator.Domain
{
    public class Elevator
    {
        public ElevatorState State { get; set; }
        public ElevatorFloor Floor { get; set; }
        public ElevatorDirection Direction { get; set; }

        public List<ElevatorInternalButton> InternalBlockedButtons { get; set; }
        public List<ElevatorExternalButton> ExternalBlockedButtons { get; set; }

        public List<ElevatorRequest> Requests { get; set; }
        public List<ElevatorRequest> PendingRequestsOrderByAsc => Requests.Where(x => !x.Completed).OrderBy(x => x.Floor).ToList();
        public List<ElevatorRequest> PendingRequestsOrderByDesc => Requests.Where(x => !x.Completed).OrderByDescending(x => x.Floor).ToList();
    }
}
