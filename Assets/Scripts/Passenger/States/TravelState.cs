using UnityEngine;

class TravelState : PassengerState
{
    Taxi taxi = GameObject.FindObjectOfType<Taxi>();
    public TravelState(Passenger passenger) : base(passenger) {}

    public override void EnterState()
    {
        Taxi.OnDestinationReached += Taxi_OnDestinationReached;
        passenger.GetInTaxi(taxi);
    }

    public override void ExitState()
    {
        passenger.GetOutOfTaxi(taxi);
        Taxi.OnDestinationReached -= Taxi_OnDestinationReached;
    }

    public void Taxi_OnDestinationReached()
    {
        passenger.SetTarget(passenger.destination);
        passenger.SetState(State.Walk);
    }
}