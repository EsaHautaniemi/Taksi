using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static int Gear { get; private set; }
    public static float Throttle { get; private set; }
    public static float Brake { get; private set; }
    public static float Steer { get; private set; }
    public static float CameraRotation { get; private set; }
    public static float Trigger { get; private set; }

    InputActions Inputs;

    private void Awake()
    {
        Gear = 1; // Mieti fiksumpi paikka/toteutus tälle

        Inputs = new InputActions();

        Inputs.Drive.Enable();
        Inputs.EngineOff.Disable();

        Inputs.Drive.Throttle.performed += context => Throttle = context.ReadValue<float>();
        Inputs.Drive.Throttle.canceled += context => Throttle = 0f;

        Inputs.Drive.Brake.performed += context => Brake = context.ReadValue<float>();
        Inputs.Drive.Brake.canceled += context => Brake = 0f;

        Inputs.Drive.Brake.performed += context => FindObjectOfType<Lights>().Taillights(true);
        Inputs.Drive.Brake.canceled += context => FindObjectOfType<Lights>().Taillights(false);

        Inputs.Drive.Steer.performed += context => Steer = context.ReadValue<float>();
        Inputs.Drive.Steer.canceled += context => Steer = 0f;

        Inputs.Drive.GearUp.performed += context => Gear = 1;
        Inputs.Drive.GearDown.performed += context => Gear = -1;

        Inputs.Drive.CameraRotation.performed += context => CameraRotation = context.ReadValue<float>();
        Inputs.Drive.CameraRotation.canceled += context => CameraRotation = 0f;


        Inputs.Drive.ToggleHeadlights.performed += context => FindObjectOfType<Lights>().ToggleHeadlights(context);

        Inputs.Drive.StopEngine.performed += context => StopEngine();

        // Ei kuulu Drive-action mappiin, muutettava myöhemmin.
        Inputs.Drive.Quit.performed += context => GameManager.QuitGame();

        //////////////////////////////////////////////////////////////////////////////////////

        Inputs.EngineOff.Trigger.performed += context => Trigger = context.ReadValue<float>();
        Inputs.EngineOff.Trigger.canceled += context => Trigger = 0f;

        Inputs.EngineOff.Brake.performed += context => Brake = context.ReadValue<float>();
        Inputs.EngineOff.Brake.canceled += context => Brake = 0f;

        Inputs.EngineOff.Steer.performed += context => Steer = context.ReadValue<float>();
        Inputs.EngineOff.Steer.canceled += context => Steer = 0f;

        Inputs.EngineOff.GearUp.performed += context => Gear = 1;
        Inputs.EngineOff.GearDown.performed += context => Gear = -1;

        Inputs.EngineOff.CameraRotation.performed += context => CameraRotation = context.ReadValue<float>();
        Inputs.EngineOff.CameraRotation.canceled += context => CameraRotation = 0f;

        Inputs.EngineOff.StartEngine.performed += context => StartEngine();

        Inputs.EngineOff.Quit.performed += context => GameManager.QuitGame();
    }
        
    public void StartEngine()
    {
        FindObjectOfType<CarController>().StartEngine();
        Inputs.asset.FindActionMap("EngineOff").Disable();
        Inputs.asset.FindActionMap("Drive").Enable();
    }

    public void StopEngine()
    {
        FindObjectOfType<CarController>().StopEngine();
        Inputs.asset.FindActionMap("Drive").Disable(); 
        Inputs.asset.FindActionMap("EngineOff").Enable();
    }

    private void OnEnable()
    {
        Inputs.Enable();
    }

    private void OnDestroy()
    {
        Inputs.Disable();
    }
}
