using System;
using UnityEngine;

public class Fueltank : MonoBehaviour
{
    [SerializeField] float fuel;
    [SerializeField] float capacity;
    public float fuelConsumption;

    public float GetFuel()
    {
        return fuel;
    }

    public bool Refuel(float amount)
    {
        if(fuel <= (capacity - amount))
        {
            fuel += amount;
            fuel = Mathf.Min(capacity, fuel);
            
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ConsumeFuel()
    {
        if(fuel > 0f)
        {
            fuel -= fuelConsumption * InputManager.Throttle * Time.deltaTime;

            fuel = Mathf.Max(0f, fuel);
        }
    }
}
