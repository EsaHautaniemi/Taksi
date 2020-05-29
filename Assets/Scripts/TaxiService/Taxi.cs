using System;
using UnityEngine;

public class Taxi : MonoBehaviour
{
    [SerializeField] Passenger passenger;
    [SerializeField] Transform target;
    [SerializeField] float money;

    public Transform passengerDoorLeft;
    public Transform passengerDoorRight;

    public static event Action<float> OnBalanceChanged;
    public static event Action<Location> OnTargetChanged;
    public static event Action<Taxi> OnStartpointReached;
    public static event Action OnDestinationReached;

    private void Awake()
    {
        target = null;
    }

    private void Start()
    {
        ChangeBalance(0);
    }

    private void Update()
    {
        if(target != null)
        {
            if (CarController.Speed < 0.1f && TargetReached())
            {
                if (passenger == null)
                {
                    OnStartpointReached?.Invoke(this);
                }
                else
                {
                    OnDestinationReached?.Invoke();
                }
            }
        }
    }

    private bool TargetReached()
    {
        return Vector3.Distance(transform.position, target.position) < 5f;
    }

    private void SetTarget(Location nextTarget)
    {
        target = nextTarget.taxiTarget;
        OnTargetChanged?.Invoke(nextTarget);
    }

    public Transform FindClosestDoor(Transform target)
    {
        float distanceFromLeftDoor = Vector3.Distance(passengerDoorLeft.transform.position, target.position);
        float distanceFromRightDoor = Vector3.Distance(passengerDoorRight.transform.position, target.position);

        if (distanceFromLeftDoor < distanceFromRightDoor)
        {
            return passengerDoorLeft;
        }
        else 
        {
            return passengerDoorRight;
        }
    }

    public void ChangeBalance(float amount)
    {
        money += amount;
        OnBalanceChanged?.Invoke(money);
    }

    public float GetBalance()
    {
        return money;
    }

    public void JobManager_OnJobGenerated(Job job)
    {
        SetTarget(job.startpoint);
    }

    public void BreakObject_OnObjectDestroyed(string objectName, float monetaryValue)
    {
        ChangeBalance(-monetaryValue);
    }

    public void Passenger_OnEnter(Passenger passenger)
    {
        Debug.Log("Passenger" + passenger);
        
        this.passenger = passenger;
        SetTarget(JobManager.currentJob.destination);
    }

    private void Passenger_OnExit(Passenger passenger)
    {
        this.passenger = null;
    }

    public void JobManager_OnJobCompleted(float amount)
    {
        ChangeBalance(amount);
    }

    private void OnEnable()
    {
        Passenger.OnEnter += Passenger_OnEnter;
        Passenger.OnExit += Passenger_OnExit;

        JobManager.OnJobGenerated += JobManager_OnJobGenerated;
        JobManager.OnJobCompleted += JobManager_OnJobCompleted;

        BreakObject.OnObjectDestroyed += BreakObject_OnObjectDestroyed;
    }

    private void OnDestroy()
    {
        Passenger.OnEnter -= Passenger_OnEnter;

        JobManager.OnJobGenerated -= JobManager_OnJobGenerated;
        JobManager.OnJobCompleted -= JobManager_OnJobCompleted;

        BreakObject.OnObjectDestroyed -= BreakObject_OnObjectDestroyed;
    }
}
