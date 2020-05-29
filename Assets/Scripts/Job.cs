using UnityEngine;

public class Job : ScriptableObject
{
    public float fare { get; private set; }
    public Location startpoint { get; private set; }
    public Location destination { get; private set; }

    public void Initialize(Location startpoint, Location destination)
    {
        this.startpoint = startpoint;
        this.destination = destination;

        fare = 50;
    }
}
