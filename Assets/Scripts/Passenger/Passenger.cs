
using System;
using System.Collections.Generic;
using UnityEngine;

public class Passenger : MonoBehaviour
{
    private MeshRenderer mesh;

    public static event Action<Passenger> OnEnter;
    public static event Action<Passenger> OnExit;

    readonly Dictionary<State, PassengerState> States = new Dictionary<State, PassengerState>();
    
    public PassengerState currentState;

    public float walkSpeed;
    public Transform target;

    public Transform startpoint;
    public Transform destination;

    [SerializeField] float distanceToTargetThreshold;

    public void Awake()
    {
        mesh = GetComponentInChildren<MeshRenderer>();

        States.Add(State.Inactive, new InactiveState(this));
        States.Add(State.Idle, new IdleState(this));
        States.Add(State.Walk, new WalkState(this));
        States.Add(State.Travel, new TravelState(this));

        SetState(State.Inactive);

        SetTarget(null);
    }

    private void Update()
    {
        currentState.UpdateState();
    }

    public void Initialize(Transform startpoint, Transform destination)
    {
        this.startpoint = startpoint;
        this.destination = destination;
    }

    public void SetTarget(Transform target)
    {
        this.target = target;
    }

    public void WalkTowardsTarget()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.forward * walkSpeed * Time.deltaTime);
    }

    public bool TargetReached()
    {
        return Vector3.Distance(transform.position, target.position) < distanceToTargetThreshold;
    }

    public void GetInTaxi(Taxi taxi)
    {
        OnEnter(this);

        SetVisible(false);
        transform.position = taxi.transform.position;
        transform.parent = taxi.transform;
    }

    public void GetOutOfTaxi(Taxi taxi)
    {
        
        transform.parent = null;
        transform.position = taxi.FindClosestDoor(target).position;
        SetVisible(true);
        
        OnExit(this);
    }

    public void SetState(State state)
    {
        if(currentState != null)
        {
            currentState.ExitState();
        }

        currentState = States[state];

        if(currentState != null)
        {
            currentState.EnterState();
        }
    }

    public void SetVisible(bool visible)
    {
        mesh.enabled = visible;
    }
}
