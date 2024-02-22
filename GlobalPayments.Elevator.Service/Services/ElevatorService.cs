using GlobalPayments.Elevator.Domain;
using GlobalPayments.Elevator.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static GlobalPayments.Elevator.Domain.Enums;

namespace GlobalPayments.Elevator.Service.Services
{
    public class ElevatorService : IElevator
    {
        private Domain.Elevator _elevator;

        #region "Constructor"

        public ElevatorService(Domain.Elevator elevator)
        {
            _elevator = elevator;
        }

        #endregion

        #region "Public methods"

        public void Initialize()
        {
            _elevator.State = ElevatorState.On_Hold;
            _elevator.Floor = ElevatorFloor.First;
            _elevator.Direction = ElevatorDirection.None;

            _elevator.InternalBlockedButtons = new List<ElevatorInternalButton>();
            _elevator.ExternalBlockedButtons = new List<ElevatorExternalButton>();
        }

        public void InitializeListOfRequest()
        {
            if (_elevator.Requests == null)
            {
                _elevator.Requests = new List<ElevatorRequest>();
            }
        }

        public ElevatorState GetCurrentState()
        {
            return _elevator.State;
        }

        public ElevatorFloor GetCurrentFloor()
        {
            return _elevator.Floor;
        }

        public ElevatorDirection GetCurrentDirection()
        {
            return _elevator.Direction;
        }

        public List<ElevatorRequest> GetRequests()
        {
            try
            {
                return _elevator.Requests.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int GetNumberOfRequests()
        {
            try
            {
                return _elevator.Requests.Count;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ElevatorRequest> GetPendingRequests(bool orderByAsc)
        {
            try
            {
                if (!orderByAsc)
                {
                    return _elevator.PendingRequestsOrderByDesc;
                }
                return _elevator.PendingRequestsOrderByAsc;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int GetNumberOfPendingRequests()
        {
            try
            {
                return _elevator.PendingRequestsOrderByAsc.Count;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddElevatorRequest(bool isInternal, ElevatorFloor floor, ElevatorDirection direction)
        {
            try
            {
                ElevatorRequest elevatorRequest = new ElevatorRequest() { Floor = floor, Direction = direction };

                if (direction == ElevatorDirection.None && GetCurrentFloor() < floor)
                {
                    direction = ElevatorDirection.Up;
                }

                if (direction == ElevatorDirection.None && GetCurrentFloor() > floor)
                {
                    direction = ElevatorDirection.Down;
                }

                if (isInternal)
                {
                    ElevatorInternalButton elevatorInternalButton = new ElevatorInternalButton() { Floor = floor };
                    AddRequest(elevatorRequest, elevatorInternalButton);
                }
                else
                {
                    ElevatorExternalButton elevatorExternalButton = new ElevatorExternalButton() { Floor = floor, Direction = direction };
                    AddRequest(elevatorRequest, elevatorExternalButton);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void MoveElevator()
        {
            try
            {
                while (GetNumberOfPendingRequests() > 0)
                {
                    ElevatorRequest nextRequest = new ElevatorRequest();

                    if (GetNumberOfPendingRequests() == 1)
                    {
                        nextRequest = _elevator.PendingRequestsOrderByAsc.FirstOrDefault();

                        SetDirection(nextRequest.Floor);
                    }

                    if (GetCurrentDirection() == ElevatorDirection.None)
                    {
                        nextRequest = _elevator.PendingRequestsOrderByAsc.FirstOrDefault();
                        _elevator.Direction = nextRequest.Direction;

                        SetDirection(nextRequest.Floor);
                    }

                    if (GetCurrentDirection() == ElevatorDirection.Up)
                    {
                        nextRequest = _elevator.PendingRequestsOrderByAsc.FirstOrDefault();

                        if (GetCurrentFloor() > nextRequest.Floor)
                        {
                            nextRequest = _elevator.PendingRequestsOrderByDesc.FirstOrDefault();
                        }
                    }

                    if (GetCurrentDirection() == ElevatorDirection.Down)
                    {
                        nextRequest = _elevator.PendingRequestsOrderByDesc.FirstOrDefault();

                        if (GetCurrentFloor() < nextRequest.Floor)
                        {
                            nextRequest = _elevator.PendingRequestsOrderByAsc.FirstOrDefault();
                        }
                    }

                    if (GetCurrentFloor() == nextRequest.Floor)
                    {
                        CompleteRequest(nextRequest.Floor);
                        UnlockButtons(nextRequest.Floor);

                        _elevator.State = ElevatorState.Opening_Doors;
                        Thread.Sleep(3000);
                        _elevator.State = ElevatorState.Closing_Doors;
                        Thread.Sleep(3000);

                        if (GetCurrentFloor() == ElevatorFloor.Fifth)
                        {
                            _elevator.Direction = ElevatorDirection.Down;
                        }
                        if (GetCurrentFloor() == ElevatorFloor.First)
                        {
                            _elevator.Direction = ElevatorDirection.Up;
                        }
                    }
                    else
                    {
                        if (_elevator.Direction == ElevatorDirection.Up)
                        {
                            _elevator.Floor += 1;
                            _elevator.State = ElevatorState.Blocked;
                            Thread.Sleep(3000);
                        }
                        if (_elevator.Direction == ElevatorDirection.Down)
                        {
                            _elevator.Floor -= 1;
                            _elevator.State = ElevatorState.Blocked;
                            Thread.Sleep(3000);
                        }
                    }
                }

                _elevator.State = ElevatorState.On_Hold;
                _elevator.Direction = ElevatorDirection.None;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool IsButtonBlocked(bool isInternal, ElevatorFloor floor, ElevatorDirection direction)
        {
            try
            {
                if (isInternal)
                {
                    return _elevator.InternalBlockedButtons.Exists(x => x.Floor == floor);
                }
                return _elevator.ExternalBlockedButtons.Exists(x => x.Floor == floor && x.Direction == direction);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region "Private methods"

        private void BlockInternalButton(ElevatorInternalButton elevatorInternalButton)
        {
            try
            {
                if (!_elevator.InternalBlockedButtons.Contains(elevatorInternalButton))
                {
                    _elevator.InternalBlockedButtons.Add(elevatorInternalButton);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void BlockExternalButton(ElevatorExternalButton elevatorExternalButton)
        {
            try
            {
                if (!_elevator.ExternalBlockedButtons.Contains(elevatorExternalButton))
                {
                    _elevator.ExternalBlockedButtons.Add(elevatorExternalButton);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void AddRequest(ElevatorRequest elevatorRequest, ElevatorInternalButton elevatorInternalButton)
        {
            try
            {
                BlockInternalButton(elevatorInternalButton);

                if (!GetPendingRequests(true).Exists(x => x.Floor == elevatorRequest.Floor))
                {
                    _elevator.Requests.Add(elevatorRequest);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void AddRequest(ElevatorRequest elevatorRequest, ElevatorExternalButton elevatorExternalButton)
        {
            try
            {
                BlockExternalButton(elevatorExternalButton);

                if (!GetPendingRequests(true).Exists(x => x.Floor == elevatorRequest.Floor))
                {
                    _elevator.Requests.Add(elevatorRequest);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void CompleteRequest(ElevatorFloor floor)
        {
            try
            {
                if (GetPendingRequests(true).Exists(x => x.Floor == floor))
                {
                    _elevator.Requests.Where(x => x.Floor == floor && !x.Completed).ToList().ForEach(y => y.Completed = true);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void UnlockButtons(ElevatorFloor floor)
        {
            try
            {
                _elevator.InternalBlockedButtons.RemoveAll(x => x.Floor == floor);
                _elevator.ExternalBlockedButtons.RemoveAll(x => x.Floor == floor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void SetDirection(ElevatorFloor floor)
        {
            if (GetCurrentFloor() == floor)
            {
                _elevator.Direction = ElevatorDirection.None;
            }
            if (GetCurrentFloor() != floor && GetCurrentFloor() < floor)
            {
                _elevator.Direction = ElevatorDirection.Up;
            }
            if (GetCurrentFloor() != floor && GetCurrentFloor() > floor)
            {
                _elevator.Direction = ElevatorDirection.Down;
            }
        }

        #endregion
    }
}
