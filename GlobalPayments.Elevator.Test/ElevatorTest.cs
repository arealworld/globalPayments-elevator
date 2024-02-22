using GlobalPayments.Elevator.Service.Services;
using System;
using Xunit;
using static GlobalPayments.Elevator.Domain.Enums;

namespace GlobalPayments.Elevator.Test
{
    public class ElevatorTest
    {
        private ElevatorService _elevatorService;

        [Fact]
        public void When_InitializeElevator_Expect_ElevatorStateAsOnHold()
        {
            //Arrange
            _elevatorService = new ElevatorService(new Domain.Elevator());

            //Act
            _elevatorService.Initialize();

            //Assert
            Assert.Equal(ElevatorState.On_Hold, _elevatorService.GetCurrentState());
        }

        [Fact]
        public void Should_ThrowException_When_ElevatorListOfRequestsIsNull()
        {
            //Arrange
            _elevatorService = new ElevatorService(new Domain.Elevator());

            //Act
            //Assert
            Assert.Throws<Exception>(() => _elevatorService.GetRequests());
        }

        [Theory]
        [InlineData(false, ElevatorFloor.Fourth, ElevatorDirection.Up)]
        public void When_AddOneElevatorRequest_Expect_OnePendingRequests(bool isInternalButton, ElevatorFloor floor, ElevatorDirection direction)
        {
            //Arrange
            _elevatorService = new ElevatorService(new Domain.Elevator());
            _elevatorService.Initialize();
            _elevatorService.InitializeListOfRequest();

            //Act
            _elevatorService.AddElevatorRequest(isInternalButton, floor, direction);

            //Assert
            Assert.Equal(1, _elevatorService.GetNumberOfPendingRequests());
        }

        [Fact]
        public void Should_MaintainCurrentFloor_When_ElevatorRequestIsEqualToCurrentFloor()
        {
            //Arrange
            _elevatorService = new ElevatorService(new Domain.Elevator());
            _elevatorService.Initialize();
            _elevatorService.InitializeListOfRequest();
            _elevatorService.AddElevatorRequest(false, ElevatorFloor.First, ElevatorDirection.Up);

            //Act
            _elevatorService.MoveElevator();

            //Assert
            Assert.Equal(ElevatorFloor.First, _elevatorService.GetCurrentFloor());
        }

        [Fact]
        public void Should_ChangeCurrentFloor_When_ElevatorRequestIsNotEqualToCurrentFloor()
        {
            //Arrange
            _elevatorService = new ElevatorService(new Domain.Elevator());
            _elevatorService.Initialize();
            _elevatorService.InitializeListOfRequest();
            _elevatorService.AddElevatorRequest(false, ElevatorFloor.Fourth, ElevatorDirection.Up);

            //Act
            _elevatorService.MoveElevator();

            //Assert
            Assert.NotEqual(ElevatorFloor.First, _elevatorService.GetCurrentFloor());
        }

        [Fact]
        public void Should_ReturnToFifthFloor_When_CallManyTimesTheElevator()
        {
            //Arrange
            _elevatorService = new ElevatorService(new Domain.Elevator());
            _elevatorService.Initialize();
            _elevatorService.InitializeListOfRequest();
            
            _elevatorService.AddElevatorRequest(false, ElevatorFloor.Fourth, ElevatorDirection.Up);
            _elevatorService.AddElevatorRequest(false, ElevatorFloor.Second, ElevatorDirection.Down);
            _elevatorService.AddElevatorRequest(true, ElevatorFloor.Fifth, ElevatorDirection.Up);
            _elevatorService.AddElevatorRequest(false, ElevatorFloor.Fourth, ElevatorDirection.Down);
            _elevatorService.AddElevatorRequest(true, ElevatorFloor.Fourth, ElevatorDirection.Up);
            _elevatorService.AddElevatorRequest(true, ElevatorFloor.First, ElevatorDirection.None);

            //Act
            _elevatorService.MoveElevator();

            //Assert
            Assert.Equal(ElevatorFloor.Fifth, _elevatorService.GetCurrentFloor());
        }

        [Fact]
        public void Should_DoNotHavePendingRequests_When_ElevatorHasFinished()
        {
            //Arrange
            _elevatorService = new ElevatorService(new Domain.Elevator());
            _elevatorService.Initialize();
            _elevatorService.InitializeListOfRequest();

            _elevatorService.AddElevatorRequest(false, ElevatorFloor.Fourth, ElevatorDirection.Up);
            _elevatorService.AddElevatorRequest(false, ElevatorFloor.Second, ElevatorDirection.Down);
            _elevatorService.AddElevatorRequest(true, ElevatorFloor.Fifth, ElevatorDirection.Up);
            _elevatorService.AddElevatorRequest(false, ElevatorFloor.Fourth, ElevatorDirection.Down);
            _elevatorService.AddElevatorRequest(true, ElevatorFloor.Fourth, ElevatorDirection.Up);
            _elevatorService.AddElevatorRequest(true, ElevatorFloor.First, ElevatorDirection.None);
            _elevatorService.AddElevatorRequest(false, ElevatorFloor.Fourth, ElevatorDirection.Down);
            _elevatorService.AddElevatorRequest(false, ElevatorFloor.Second, ElevatorDirection.Down);
            _elevatorService.AddElevatorRequest(true, ElevatorFloor.Fifth, ElevatorDirection.Up);
            _elevatorService.AddElevatorRequest(false, ElevatorFloor.Third, ElevatorDirection.Down);
            _elevatorService.AddElevatorRequest(true, ElevatorFloor.Fourth, ElevatorDirection.Up);
            _elevatorService.AddElevatorRequest(true, ElevatorFloor.First, ElevatorDirection.Down);
            _elevatorService.AddElevatorRequest(false, ElevatorFloor.Fourth, ElevatorDirection.Up);
            _elevatorService.AddElevatorRequest(true, ElevatorFloor.Second, ElevatorDirection.Down);
            _elevatorService.AddElevatorRequest(true, ElevatorFloor.Third, ElevatorDirection.Up);
            _elevatorService.AddElevatorRequest(false, ElevatorFloor.Fourth, ElevatorDirection.Down);
            _elevatorService.AddElevatorRequest(true, ElevatorFloor.Fourth, ElevatorDirection.Up);
            _elevatorService.AddElevatorRequest(true, ElevatorFloor.First, ElevatorDirection.None);
            _elevatorService.AddElevatorRequest(false, ElevatorFloor.Fifth, ElevatorDirection.Up);
            _elevatorService.AddElevatorRequest(false, ElevatorFloor.Second, ElevatorDirection.Down);
            _elevatorService.AddElevatorRequest(true, ElevatorFloor.Fifth, ElevatorDirection.Up);
            _elevatorService.AddElevatorRequest(false, ElevatorFloor.Fourth, ElevatorDirection.Down);
            _elevatorService.AddElevatorRequest(true, ElevatorFloor.Fourth, ElevatorDirection.Up);
            _elevatorService.AddElevatorRequest(true, ElevatorFloor.First, ElevatorDirection.None);

            //Act
            _elevatorService.MoveElevator();

            //Assert
            Assert.Equal(0, _elevatorService.GetNumberOfPendingRequests());
        }
    }
}
