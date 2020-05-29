using UnityEngine;

public enum State
{
    Inactive,
    Idle,
    Walk,
    Travel,
}

public abstract class PassengerState
{
    protected Passenger passenger;

    protected PassengerState(Passenger passenger)
    {
        this.passenger = passenger;
    }

    public virtual void EnterState() {}
    public virtual void UpdateState() {}
    public virtual void ExitState() {}
}
