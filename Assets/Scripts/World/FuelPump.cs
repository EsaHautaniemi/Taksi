using UnityEngine;

public class FuelPump : MonoBehaviour
{
    [SerializeField] Taxi taxi;
    [SerializeField] CarController car;

    [SerializeField] float fuelPrice;
    [SerializeField] float fuelFlowRate;

    private void OnTriggerEnter(Collider other)
    {
        taxi = FindObjectOfType<Taxi>();
        car = FindObjectOfType<CarController>();
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Taxi"))
        {
            if(!car.engineRunning && taxi.GetBalance() >= fuelPrice)
            {
                float fuelFlow = fuelFlowRate * InputManager.Trigger * Time.deltaTime;

                if(car.fueltank.Refuel(fuelFlow))
                {
                    taxi.ChangeBalance(-fuelPrice * fuelFlow);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        taxi = null;
        car = null;
    }
}
