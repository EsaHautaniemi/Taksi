public class InactiveState : PassengerState
{
    public InactiveState(Passenger passenger): base(passenger) {}

    public override void EnterState()
    {
        if(passenger != null)
        {
            PassengerManager.DespawnPassenger(passenger);
        }
    }

    public override void ExitState()
    {
        PassengerManager.SpawnPassenger(passenger, passenger.startpoint);
    }
}
