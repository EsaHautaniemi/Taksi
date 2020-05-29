using UnityEngine;

public class Wheel : MonoBehaviour
{
    [SerializeField] bool steer;
    [SerializeField] bool power;
    [SerializeField] bool brake;

    public float steerAngle = 0;
    public float torque = 0;
    public float brakeTorque = 0;
    public float tractionControl = 0;

    private WheelCollider wheelCollider;
    private Transform wheelTransform;

    private void Start()
    {
        wheelCollider = GetComponent<WheelCollider>();
        wheelTransform = GetComponentInChildren<MeshRenderer>().transform;
    }

    private void Update()
    {
        wheelCollider.GetWorldPose(out Vector3 pos, out Quaternion rot);
        wheelTransform.position = pos;
        wheelTransform.rotation = rot;

        WheelHit hit;
        if(wheelCollider.GetGroundHit(out hit))
        {
            tractionControl = -hit.forwardSlip;
        }
    }

    private void FixedUpdate()
    {
        if (power)
        {
            wheelCollider.motorTorque = torque - (tractionControl * torque);
        }

        if (steer)
        {    
            wheelCollider.steerAngle = steerAngle;
        }

        if (brake)
        {
            wheelCollider.brakeTorque = brakeTorque;
        }
    }
}
