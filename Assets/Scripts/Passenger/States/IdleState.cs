public class IdleState : PassengerState
{
    public IdleState(Passenger passenger) : base(passenger){}

    public override void EnterState()
    {
        Taxi.OnStartpointReached += Taxi_OnStartpointReached;
    }

    public override void ExitState()
    {
        Taxi.OnStartpointReached -= Taxi_OnStartpointReached;
    }

    public void Taxi_OnStartpointReached(Taxi taxi)
    {
        passenger.SetTarget(taxi.FindClosestDoor(passenger.transform));
        passenger.SetState(State.Walk);
    }
}
