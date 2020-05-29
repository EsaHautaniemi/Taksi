using UnityEngine;

public class TimeOfDay : MonoBehaviour
{
    [SerializeField] Light sun;
    [SerializeField] Light moon;

    [SerializeField] Gradient dayGradient;
    [SerializeField] Gradient nightGradient;

    [SerializeField] float dayDuration;
    [SerializeField] float nightDuration;

    [SerializeField] float timeProgressSpeed;

    [SerializeField] float currentTimeOfDay;

    float dayDurationNormalized;
    float nightDurationNormalized;

    float totalDuration;
    float rotationSpeed;

    private void Start()
    {
        currentTimeOfDay = 0f;
        totalDuration = dayDuration + nightDuration;

        dayDurationNormalized = dayDuration / totalDuration;
        nightDurationNormalized = nightDuration / totalDuration;
    }

    private void Update()
    {
        currentTimeOfDay += Time.deltaTime * timeProgressSpeed;
        
        if(currentTimeOfDay > (totalDuration))
        {
            currentTimeOfDay = 0f;
        }

        if (currentTimeOfDay > dayDuration)
        {
            moon.gameObject.SetActive(true);
            sun.gameObject.SetActive(false);

            moon.color = nightGradient.Evaluate(nightDurationNormalized);
            rotationSpeed = (360 * Time.deltaTime / (totalDuration * ( 1 - dayDurationNormalized))) / 2f;
            
        }
        else
        {
            sun.gameObject.SetActive(true);
            moon.gameObject.SetActive(false);

            sun.color = dayGradient.Evaluate(dayDurationNormalized);
            rotationSpeed = (360 * Time.deltaTime / (totalDuration * (1 - nightDurationNormalized))) / 2f;
        }
        
        transform.Rotate(rotationSpeed, 0f, 0f);
        transform.Rotate(rotationSpeed / 10f, 0, 0, Space.World);
    }
}
