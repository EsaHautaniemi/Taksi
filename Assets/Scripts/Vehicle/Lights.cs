using UnityEngine;

public class Lights : MonoBehaviour
{
    [SerializeField] GameObject leftHeadlight;
    [SerializeField] GameObject rightHeadlight;
    [SerializeField] GameObject leftTaillight;
    [SerializeField] GameObject rightTaillight;

    [SerializeField] Material headlightMaterial;
    [SerializeField] Material taillightMaterial;

    Color headlightEmission;
    Color taillightEmission;

    bool headlights;

    private void Awake()
    {
        headlights = true;

        leftHeadlight.SetActive(false);
        rightHeadlight.SetActive(false);
        leftTaillight.SetActive(false);
        rightTaillight.SetActive(false);

        headlightEmission = headlightMaterial.GetColor("_EmissionColor");
        taillightEmission = taillightMaterial.GetColor("_EmissionColor");

        headlightMaterial.SetColor("_EmissionColor", Color.black);
        taillightMaterial.SetColor("_EmissionColor", Color.black);
    }

    public void ToggleHeadlights(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        Debug.Log("Headlights toggled");

        headlights = !headlights;

        leftHeadlight.SetActive(headlights);
        rightHeadlight.SetActive(headlights);

        if (headlights)
        {
            headlightMaterial.SetColor("_EmissionColor", headlightEmission);
        }
        else
        {
            headlightMaterial.SetColor("_EmissionColor", Color.black);
        }
    }

    public void Taillights(bool light)
    {
        leftTaillight.SetActive(light);
        rightTaillight.SetActive(light);

        if (light)
        {
            taillightMaterial.SetColor("_EmissionColor", taillightEmission);
        }
        else
        {
            taillightMaterial.SetColor("_EmissionColor", Color.black);
        }
    }

    private void OnEnable()
    {
        CarController.OnEngineStart += CarController_OnEngineStart;
        CarController.OnEngineStop += CarController_OnEngineStop;
    }

    private void OnDisable()
    {
        headlightMaterial.SetColor("_EmissionColor", headlightEmission);
        taillightMaterial.SetColor("_EmissionColor", taillightEmission);

        CarController.OnEngineStart -= CarController_OnEngineStart;
        CarController.OnEngineStop -= CarController_OnEngineStop;
    }

    private void CarController_OnEngineStart()
    {
        leftHeadlight.SetActive(true);
        rightHeadlight.SetActive(true);

        headlightMaterial.SetColor("_EmissionColor", headlightEmission);
    }

    private void CarController_OnEngineStop()
    {
        leftHeadlight.SetActive(false);
        rightHeadlight.SetActive(false);

        leftTaillight.SetActive(false);
        rightTaillight.SetActive(false);

        headlightMaterial.SetColor("_EmissionColor", Color.black);
    }
}
