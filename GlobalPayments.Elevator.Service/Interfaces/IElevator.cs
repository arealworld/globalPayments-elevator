using GlobalPayments.Elevator.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static GlobalPayments.Elevator.Domain.Enums;

namespace GlobalPayments.Elevator.Service.Interfaces
{
    public interface IElevator
    {
        public void Initialize();
        public void InitializeListOfRequest();

        public ElevatorState GetCurrentState();
        public ElevatorFloor GetCurrentFloor();
        public ElevatorDirection GetCurrentDirection();

        public List<ElevatorRequest> GetRequests();
        public int GetNumberOfRequests();

        public List<ElevatorRequest> GetPendingRequests(bool orderByAsc);
        public int GetNumberOfPendingRequests();

        public void AddElevatorRequest(bool isInternal, ElevatorFloor floor, ElevatorDirection direction);

        public void MoveElevator();

        public bool IsButtonBlocked(bool isInternal, ElevatorFloor floor, ElevatorDirection direction);
    }
}
