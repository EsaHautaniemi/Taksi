using UnityEngine;

public class LocationManager : MonoBehaviour
{
    private static Location[] locations;
    
    private static int lastLocationIndex = -1;
    private static int locationIndex = -1;

    private void Awake()
    {
        locations = GetComponentsInChildren<Location>();
    }

    public static Location GetRandomLocation()
    {
        while (locationIndex == lastLocationIndex)
        {
            locationIndex = Random.Range(0, locations.Length);
        }

        lastLocationIndex = locationIndex;
        return locations[locationIndex];
    }
}
