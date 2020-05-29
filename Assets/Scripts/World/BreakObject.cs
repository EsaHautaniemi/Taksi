using System;
using UnityEngine;

public class BreakObject : MonoBehaviour
{
    [SerializeField] GameObject brokenObject;
    [SerializeField] float monetaryValue;
    [SerializeField] float destroyInSeconds;

    public static event Action<string, float> OnObjectDestroyed;

    private void Awake()
    {
        brokenObject = Instantiate(brokenObject, transform.position, transform.rotation);
        brokenObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Taxi"))
        {
            OnObjectDestroyed?.Invoke(gameObject.tag, monetaryValue);
        }

        brokenObject.SetActive(true);
        Destroy(gameObject);
        Destroy(brokenObject, destroyInSeconds);
    }   
}
