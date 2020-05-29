using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    [SerializeField] float camSpeed;

    [SerializeField] Transform target;
    [SerializeField] Vector3 offset = new Vector3(0f, 5f, -15f);
    [SerializeField] float distanceDamp;

    public Vector3 velocity = Vector3.one;

    private void FixedUpdate()
    {
        SmoothFollow();
    }

    private void SmoothFollow()
    {
        Vector3 toPosition = target.position + (target.rotation * offset);
        Vector3 currentPosition = Vector3.SmoothDamp(transform.position, toPosition, ref velocity, distanceDamp);
        transform.position = currentPosition;

        transform.LookAt(target);
    }
}
