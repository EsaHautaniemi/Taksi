using System;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public static event Action OnEngineStart;
    public static event Action OnEngineStop;

    public bool engineRunning;

    private Rigidbody rb;
    private Wheel[] wheels;

    public Fueltank fueltank;

    [SerializeField] Transform centerOfMass;
    [SerializeField] float motorTorque;
    [SerializeField] float brakingForce;
    [SerializeField] float maxSpeed;
    [SerializeField] float maxSteer;

    [SerializeField] AudioClip startEngineSound;
    [SerializeField] AudioClip stopEngineSound;
    [SerializeField] AudioClip runningEngine;
    [SerializeField] float maxPitch;
    
    AudioSource soundPlayer;

    public static float Speed { get; private set; }

    private void Awake()
    {
        engineRunning = false;

        rb = GetComponent<Rigidbody>();
        wheels = GetComponentsInChildren<Wheel>();

        fueltank = GetComponent<Fueltank>();
        soundPlayer = GetComponent<AudioSource>();
    }

    private void Start()
    {
        rb.centerOfMass = centerOfMass.localPosition;
        soundPlayer.clip = runningEngine;

    }

    private void Update()
    {
        Speed = rb.velocity.magnitude * 3.6f;

        foreach (Wheel wheel in wheels)
        {
            if (engineRunning && fueltank.GetFuel() > 0f && Speed < maxSpeed)
            {
                wheel.torque = InputManager.Throttle * motorTorque * InputManager.Gear;
            }
            else
            {
                wheel.torque = 0;
            }

            wheel.brakeTorque = InputManager.Brake * brakingForce;
            wheel.steerAngle = InputManager.Steer * maxSteer;
        }

        if(engineRunning)
        {
            if (fueltank.GetFuel() <= 0f)
            {
                StopEngine();
                return;
            }

            fueltank.ConsumeFuel();

            float pitchFactor = Speed / maxSpeed;
            soundPlayer.pitch = 1 + (maxPitch * pitchFactor);
            
        }
    }

    public void StartEngine()
    {
        soundPlayer.PlayOneShot(startEngineSound);
        engineRunning = true;
        soundPlayer.Play();

        OnEngineStart?.Invoke();
    }

    public void StopEngine()
    {
        soundPlayer.Stop();
        engineRunning = false;
        soundPlayer.PlayOneShot(stopEngineSound);

        OnEngineStop?.Invoke();
    }
}
