using UnityEngine;
using TMPro;
using System;

public class HUDManager : MonoBehaviour
{
    [SerializeField] Fueltank fueltank;

    [SerializeField] Color32 positiveBalance;
    [SerializeField] Color32 negativeBalance;

    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] TextMeshProUGUI targetText;
    [SerializeField] TextMeshProUGUI speedText;
    [SerializeField] TextMeshProUGUI FuelText;

    private void Awake()
    {
        fueltank = FindObjectOfType<Fueltank>();

        moneyText.faceColor = positiveBalance;
        Taxi.OnBalanceChanged += Taxi_OnBalanceChanged;
        Taxi.OnTargetChanged += Taxi_OnTargetChanged;
    }

    private void Update()
    {
        UpdateSpeedText(CarController.Speed);
        UpdateFuelText();
    }

    private void UpdateFuelText()
    {
        FuelText.text = $"{fueltank.GetFuel():F2}L";
    }

    public void UpdateMoneyText(float money)
    {
        if (money >= 0f)
        {
            moneyText.faceColor = positiveBalance;
        }
        else
        {
            moneyText.faceColor = negativeBalance;
        }
        
        moneyText.text = "$" + money.ToString("F2");
    }

    public void UpdateSpeedText(float speed)
    {
        speedText.text = $"{Math.Round(speed)} KM/H";
    }

    public void Taxi_OnBalanceChanged(float money)
    {
        UpdateMoneyText(money);
    }

    public void Taxi_OnTargetChanged(Location location)
    {
        if(location != null)
        {
            targetText.text = location.Name;
        }
        else
        {
            targetText.text = "";
        }
    }

    private void OnEnable()
    {
        Taxi.OnBalanceChanged += Taxi_OnBalanceChanged;
        Taxi.OnTargetChanged += Taxi_OnTargetChanged;
    }

    private void OnDisable()
    {
        Taxi.OnBalanceChanged -= Taxi_OnBalanceChanged;
        Taxi.OnTargetChanged -= Taxi_OnTargetChanged;
    }
}
