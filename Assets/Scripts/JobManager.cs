using System;
using UnityEngine;

public class JobManager : MonoBehaviour
{
    static GameObject passengerLocationRing;
    static GameObject destinationLocationRing;

    public static Job currentJob;

    public static event Action<Job> OnJobGenerated;
    public static event Action<float> OnJobCompleted;

    private void Awake()
    {
        currentJob = ScriptableObject.CreateInstance<Job>();

        passengerLocationRing = transform.GetChild(0).gameObject;
        destinationLocationRing = transform.GetChild(1).gameObject;

        passengerLocationRing.SetActive(true);
        destinationLocationRing.SetActive(true);
    }

    public static void GenerateNewJob()
    {
        currentJob.Initialize(LocationManager.GetRandomLocation(), LocationManager.GetRandomLocation());

        OnJobGenerated?.Invoke(currentJob);

        passengerLocationRing.transform.position = currentJob.startpoint.taxiTarget.position;
        passengerLocationRing.SetActive(true);

        destinationLocationRing.transform.position = currentJob.destination.taxiTarget.position;
        destinationLocationRing.SetActive(false);
    }

    public void JobCompleted()
    {
        OnJobCompleted(currentJob.fare);
        GenerateNewJob();
    }

    public void Taxi_OnTargetChanged(Location taxiTarget)
    {
        if(taxiTarget == currentJob.startpoint)
        {
            passengerLocationRing.SetActive(true);
            destinationLocationRing.SetActive(false);
        }
        else if(taxiTarget == currentJob.destination)
        {
            passengerLocationRing.SetActive(false);
            destinationLocationRing.SetActive(true);
        }
    }

    public void Passenger_OnExit(Passenger passenger)
    {
        JobCompleted();
    }

    public void Taxi_OnStartpointReached(Taxi taxi)
    {
        passengerLocationRing.SetActive(false);
    }

    public void Taxi_OnDestinationReached()
    {
        destinationLocationRing.SetActive(false);
    }

    private void OnEnable()
    {
        Taxi.OnTargetChanged += Taxi_OnTargetChanged;
        Taxi.OnStartpointReached += Taxi_OnStartpointReached;
        Taxi.OnDestinationReached += Taxi_OnDestinationReached;

        Passenger.OnExit += Passenger_OnExit;
    }
    private void OnDisable()
    {
        Taxi.OnTargetChanged -= Taxi_OnTargetChanged;
        Taxi.OnStartpointReached -= Taxi_OnStartpointReached;
        Taxi.OnDestinationReached -= Taxi_OnDestinationReached;

        Passenger.OnExit -= Passenger_OnExit;
    }
}
