using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed;
    [SerializeField] Vector3 axis;

    void Update()
    {
        transform.Rotate(axis, rotationSpeed * Time.deltaTime);
    }
}
