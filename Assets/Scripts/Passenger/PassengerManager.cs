using System;
using System.Collections.Generic;
using UnityEngine;

public class PassengerManager : MonoBehaviour
{
    private static List<Passenger> passengers = new List<Passenger>();

    private void Awake()
    {
        foreach(Passenger passenger in GetComponentsInChildren<Passenger>(true))
        {
            passengers.Add(passenger);
            passenger.transform.position = new Vector3(0f, -100f, 0f);
        }

        Debug.Log("Passenger count: " + passengers.Count);
    }

    private void JobManager_OnJobGenerated(Job job)
    {
        // Mitä tehdään jos jostain syystä kaikki matkustajat olis jo maailmalla ja yritetään spawnata lisää?

        int randomIndex = UnityEngine.Random.Range(0, passengers.Count);
        
        Passenger passenger = passengers[randomIndex];

        passenger.Initialize(job.startpoint.passengerTarget, job.destination.passengerTarget);
        passenger.SetState(State.Idle);
    }

    public static void SpawnPassenger(Passenger passenger, Transform spawnpoint)
    {
        if(passengers.Count > 0)
        {
            passenger.transform.position = spawnpoint.position;
            passenger.SetVisible(true);
            passengers.Remove(passenger);
        }
    }

    public static void DespawnPassenger(Passenger passenger)
    {
        passengers.Add(passenger);

        passenger.target = null;
        passenger.startpoint = null;
        passenger.destination = null;
        passenger.SetVisible(false);
        passenger.transform.position = new Vector3(0f, -100f, 0f);
    }
    private void OnEnable()
    {
        JobManager.OnJobGenerated += JobManager_OnJobGenerated;
    }

    private void OnDisable()
    {
        JobManager.OnJobGenerated -= JobManager_OnJobGenerated;
    }
}
