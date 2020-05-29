using UnityEngine;

public class WalkState : PassengerState
{
    public WalkState(Passenger passenger) : base(passenger) {}
    
    public override void UpdateState()
    {
        passenger.WalkTowardsTarget();

        if(passenger.TargetReached())
        {
            if(passenger.target == passenger.destination)
            {
                passenger.SetState(State.Inactive);
            }
            else
            {
                passenger.SetState(State.Travel);
            }
        }
    }
}
