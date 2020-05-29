// GENERATED AUTOMATICALLY FROM 'Assets/Misc/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Drive"",
            ""id"": ""3ac0b34c-2a49-4a75-b89c-9f2f929df935"",
            ""actions"": [
                {
                    ""name"": ""Throttle"",
                    ""type"": ""Value"",
                    ""id"": ""81b4ba06-8e1b-486a-93aa-492b5f29b644"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Value"",
                    ""id"": ""bbcb4133-fe1a-4414-a213-d1db2b5d536f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steer"",
                    ""type"": ""Value"",
                    ""id"": ""a325665a-076e-485e-9dcb-a7a5d82bdb07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GearUp"",
                    ""type"": ""Button"",
                    ""id"": ""696ee96d-5160-4d69-92a1-2ca15e6da1f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GearDown"",
                    ""type"": ""Button"",
                    ""id"": ""0166fa11-d12a-4bce-a0c3-62e83dcb8388"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraRotation"",
                    ""type"": ""Value"",
                    ""id"": ""b8c430d1-9a9f-480a-b4b8-d70659430903"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Quit"",
                    ""type"": ""Button"",
                    ""id"": ""47e0c98a-9fa4-4694-9121-609ef02caede"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StopEngine"",
                    ""type"": ""Button"",
                    ""id"": ""54cb2497-d081-438c-b5c8-3859fc85010d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=1)""
                },
                {
                    ""name"": ""ToggleHeadlights"",
                    ""type"": ""Button"",
                    ""id"": ""bf639555-b945-422a-98a9-ac0777d07e2f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cf570df8-edbc-4ef5-a6e5-ba5f6594167f"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f43bb7d-b5ab-47a3-ad33-13d5b7c74095"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4088d4a6-a768-4e61-86bd-eacbbb545e01"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3243843d-ac3a-4e21-908e-17cba8d1f2f9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6754f5e3-92df-4970-9332-49d175177d91"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e66ce0a-3e4b-41b2-bfda-8b68c2e9a18e"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e357ef07-78c6-4320-a846-59f897a103ad"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac485ed0-5664-43ba-a6a1-e6e6b6190fa6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Left Stick"",
                    ""id"": ""cbdf6ca7-8b27-47f0-b502-e15f936cdbdb"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6dd7fffd-5331-428f-8c36-dc92ab19597f"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2bc4cfde-c6a3-48d5-93c7-6da564cacebc"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""26a19fa2-ce9d-4398-80d9-a147970e2276"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""20c3fa17-bf95-4a4b-a6f0-4d883b3bb001"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""59fe6710-074c-4fe0-a672-2720dfab2dd2"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""0d32bc54-e937-4c7a-987b-6d13a9a32934"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3baacd6c-f169-44ea-b152-2829e5a9adb6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""67e9027c-459d-4406-9f75-a188aa540d11"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a2c6b5e9-361a-4b0b-8246-d167660f2c79"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GearUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ce00404-9649-4b3f-9ba4-e0227c6c38f6"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GearUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""717514be-47f1-487f-b872-5196397b1570"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GearUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""607b02cf-12a2-4db3-bf6a-4b9cfe4e3c44"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GearDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88262aea-c869-4925-b691-67189b21a0e5"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GearDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9638841d-ee20-490d-8c14-91e893ea1aa9"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GearDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ac8dd0f-098c-4655-ac7b-1025e2fd9bba"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fbb4f46b-7ed0-4f69-acce-139dcf663602"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3abd7c45-4b77-4ca1-bc1e-20bd350da21f"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StopEngine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea3e3e3d-9fc6-4054-9781-c57980ba2e12"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StopEngine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be801d05-d452-4b81-9700-8bf3b98ef386"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleHeadlights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""698e190b-00e4-438b-8b41-64757b5c6f44"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleHeadlights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""EngineOff"",
            ""id"": ""662c71f9-c262-49a7-a2cf-34ccfa359870"",
            ""actions"": [
                {
                    ""name"": ""Trigger"",
                    ""type"": ""Value"",
                    ""id"": ""d612811f-4b23-4184-85cc-36bbf2fd110c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Value"",
                    ""id"": ""cb4a3840-b09c-46af-a5a4-7a045df4b03b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steer"",
                    ""type"": ""Value"",
                    ""id"": ""98abcbdc-51aa-497b-959f-1af2a9ccbb5b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GearUp"",
                    ""type"": ""Button"",
                    ""id"": ""c6734129-9804-4a07-a834-267db3020e47"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GearDown"",
                    ""type"": ""Button"",
                    ""id"": ""fb60dc29-b229-448c-a557-52135da8a22e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraRotation"",
                    ""type"": ""Value"",
                    ""id"": ""7388a3e6-7d20-4b9f-9624-728d231c196b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Quit"",
                    ""type"": ""Button"",
                    ""id"": ""6cc7332f-bfc3-45d0-ab3c-f79019b399a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StartEngine"",
                    ""type"": ""Button"",
                    ""id"": ""f3222597-36b5-4cde-8eea-d677756c3ef9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""162c743c-d781-45c8-ac45-981d3761c250"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ff01070-ac72-4c15-a516-36fa4f9bf0d1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90e23148-376b-471e-a9c3-73153b55469f"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce2ce26e-492d-41bf-852a-71a0ee04a074"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1436839-1a94-430a-af5f-82629b51866c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5193f2a7-e9bc-4da3-8540-5f28e9695114"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Left Stick"",
                    ""id"": ""3b12c7fc-da61-4d8d-933f-180cf7004800"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d539bf04-f857-42e5-bcfe-37ceda80ac4e"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""41f12beb-5860-4262-bfa7-e770aaf79aa7"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""b84e6c42-96ed-4334-a3ed-a636ddf4d4a6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b23f0527-94cc-4cf9-acb6-355efbdffca8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b5b57e32-4fb1-4b57-8f2a-6f8c4c8e7f12"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""83b8c748-bcb2-4ff2-bad2-d1550d8c64db"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d09b66f6-076d-48d7-b361-3280b4679390"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9321e86e-6cc3-486d-a590-1c5456cd36a7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3da79eed-008f-4092-8953-70bad790990e"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GearUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""301dffb8-201e-4db2-8e27-c9a118b35bea"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GearUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2fb3929f-76c2-4599-ba3e-cea97b6a4611"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GearUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4470a0c-173e-4bc1-807b-60f78f76047f"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GearDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8bc2219b-ef70-4adb-8b13-9aa252ab848a"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GearDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15f859a0-3c02-408a-a5fe-9e882cd39b56"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GearDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00b4e933-606e-46a6-b4ad-fa139fe76162"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1bc5b54d-0ef3-425c-a430-217e21e85774"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68ede105-17f7-451d-809a-ae5d22537098"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartEngine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""edddf52a-11eb-4c68-b8c9-1efd1c1fa2e7"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartEngine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Drive
        m_Drive = asset.FindActionMap("Drive", throwIfNotFound: true);
        m_Drive_Throttle = m_Drive.FindAction("Throttle", throwIfNotFound: true);
        m_Drive_Brake = m_Drive.FindAction("Brake", throwIfNotFound: true);
        m_Drive_Steer = m_Drive.FindAction("Steer", throwIfNotFound: true);
        m_Drive_GearUp = m_Drive.FindAction("GearUp", throwIfNotFound: true);
        m_Drive_GearDown = m_Drive.FindAction("GearDown", throwIfNotFound: true);
        m_Drive_CameraRotation = m_Drive.FindAction("CameraRotation", throwIfNotFound: true);
        m_Drive_Quit = m_Drive.FindAction("Quit", throwIfNotFound: true);
        m_Drive_StopEngine = m_Drive.FindAction("StopEngine", throwIfNotFound: true);
        m_Drive_ToggleHeadlights = m_Drive.FindAction("ToggleHeadlights", throwIfNotFound: true);
        // EngineOff
        m_EngineOff = asset.FindActionMap("EngineOff", throwIfNotFound: true);
        m_EngineOff_Trigger = m_EngineOff.FindAction("Trigger", throwIfNotFound: true);
        m_EngineOff_Brake = m_EngineOff.FindAction("Brake", throwIfNotFound: true);
        m_EngineOff_Steer = m_EngineOff.FindAction("Steer", throwIfNotFound: true);
        m_EngineOff_GearUp = m_EngineOff.FindAction("GearUp", throwIfNotFound: true);
        m_EngineOff_GearDown = m_EngineOff.FindAction("GearDown", throwIfNotFound: true);
        m_EngineOff_CameraRotation = m_EngineOff.FindAction("CameraRotation", throwIfNotFound: true);
        m_EngineOff_Quit = m_EngineOff.FindAction("Quit", throwIfNotFound: true);
        m_EngineOff_StartEngine = m_EngineOff.FindAction("StartEngine", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Drive
    private readonly InputActionMap m_Drive;
    private IDriveActions m_DriveActionsCallbackInterface;
    private readonly InputAction m_Drive_Throttle;
    private readonly InputAction m_Drive_Brake;
    private readonly InputAction m_Drive_Steer;
    private readonly InputAction m_Drive_GearUp;
    private readonly InputAction m_Drive_GearDown;
    private readonly InputAction m_Drive_CameraRotation;
    private readonly InputAction m_Drive_Quit;
    private readonly InputAction m_Drive_StopEngine;
    private readonly InputAction m_Drive_ToggleHeadlights;
    public struct DriveActions
    {
        private @InputActions m_Wrapper;
        public DriveActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Throttle => m_Wrapper.m_Drive_Throttle;
        public InputAction @Brake => m_Wrapper.m_Drive_Brake;
        public InputAction @Steer => m_Wrapper.m_Drive_Steer;
        public InputAction @GearUp => m_Wrapper.m_Drive_GearUp;
        public InputAction @GearDown => m_Wrapper.m_Drive_GearDown;
        public InputAction @CameraRotation => m_Wrapper.m_Drive_CameraRotation;
        public InputAction @Quit => m_Wrapper.m_Drive_Quit;
        public InputAction @StopEngine => m_Wrapper.m_Drive_StopEngine;
        public InputAction @ToggleHeadlights => m_Wrapper.m_Drive_ToggleHeadlights;
        public InputActionMap Get() { return m_Wrapper.m_Drive; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DriveActions set) { return set.Get(); }
        public void SetCallbacks(IDriveActions instance)
        {
            if (m_Wrapper.m_DriveActionsCallbackInterface != null)
            {
                @Throttle.started -= m_Wrapper.m_DriveActionsCallbackInterface.OnThrottle;
                @Throttle.performed -= m_Wrapper.m_DriveActionsCallbackInterface.OnThrottle;
                @Throttle.canceled -= m_Wrapper.m_DriveActionsCallbackInterface.OnThrottle;
                @Brake.started -= m_Wrapper.m_DriveActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_DriveActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_DriveActionsCallbackInterface.OnBrake;
                @Steer.started -= m_Wrapper.m_DriveActionsCallbackInterface.OnSteer;
                @Steer.performed -= m_Wrapper.m_DriveActionsCallbackInterface.OnSteer;
                @Steer.canceled -= m_Wrapper.m_DriveActionsCallbackInterface.OnSteer;
                @GearUp.started -= m_Wrapper.m_DriveActionsCallbackInterface.OnGearUp;
                @GearUp.performed -= m_Wrapper.m_DriveActionsCallbackInterface.OnGearUp;
                @GearUp.canceled -= m_Wrapper.m_DriveActionsCallbackInterface.OnGearUp;
                @GearDown.started -= m_Wrapper.m_DriveActionsCallbackInterface.OnGearDown;
                @GearDown.performed -= m_Wrapper.m_DriveActionsCallbackInterface.OnGearDown;
                @GearDown.canceled -= m_Wrapper.m_DriveActionsCallbackInterface.OnGearDown;
                @CameraRotation.started -= m_Wrapper.m_DriveActionsCallbackInterface.OnCameraRotation;
                @CameraRotation.performed -= m_Wrapper.m_DriveActionsCallbackInterface.OnCameraRotation;
                @CameraRotation.canceled -= m_Wrapper.m_DriveActionsCallbackInterface.OnCameraRotation;
                @Quit.started -= m_Wrapper.m_DriveActionsCallbackInterface.OnQuit;
                @Quit.performed -= m_Wrapper.m_DriveActionsCallbackInterface.OnQuit;
                @Quit.canceled -= m_Wrapper.m_DriveActionsCallbackInterface.OnQuit;
                @StopEngine.started -= m_Wrapper.m_DriveActionsCallbackInterface.OnStopEngine;
                @StopEngine.performed -= m_Wrapper.m_DriveActionsCallbackInterface.OnStopEngine;
                @StopEngine.canceled -= m_Wrapper.m_DriveActionsCallbackInterface.OnStopEngine;
                @ToggleHeadlights.started -= m_Wrapper.m_DriveActionsCallbackInterface.OnToggleHeadlights;
                @ToggleHeadlights.performed -= m_Wrapper.m_DriveActionsCallbackInterface.OnToggleHeadlights;
                @ToggleHeadlights.canceled -= m_Wrapper.m_DriveActionsCallbackInterface.OnToggleHeadlights;
            }
            m_Wrapper.m_DriveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Throttle.started += instance.OnThrottle;
                @Throttle.performed += instance.OnThrottle;
                @Throttle.canceled += instance.OnThrottle;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
                @Steer.started += instance.OnSteer;
                @Steer.performed += instance.OnSteer;
                @Steer.canceled += instance.OnSteer;
                @GearUp.started += instance.OnGearUp;
                @GearUp.performed += instance.OnGearUp;
                @GearUp.canceled += instance.OnGearUp;
                @GearDown.started += instance.OnGearDown;
                @GearDown.performed += instance.OnGearDown;
                @GearDown.canceled += instance.OnGearDown;
                @CameraRotation.started += instance.OnCameraRotation;
                @CameraRotation.performed += instance.OnCameraRotation;
                @CameraRotation.canceled += instance.OnCameraRotation;
                @Quit.started += instance.OnQuit;
                @Quit.performed += instance.OnQuit;
                @Quit.canceled += instance.OnQuit;
                @StopEngine.started += instance.OnStopEngine;
                @StopEngine.performed += instance.OnStopEngine;
                @StopEngine.canceled += instance.OnStopEngine;
                @ToggleHeadlights.started += instance.OnToggleHeadlights;
                @ToggleHeadlights.performed += instance.OnToggleHeadlights;
                @ToggleHeadlights.canceled += instance.OnToggleHeadlights;
            }
        }
    }
    public DriveActions @Drive => new DriveActions(this);

    // EngineOff
    private readonly InputActionMap m_EngineOff;
    private IEngineOffActions m_EngineOffActionsCallbackInterface;
    private readonly InputAction m_EngineOff_Trigger;
    private readonly InputAction m_EngineOff_Brake;
    private readonly InputAction m_EngineOff_Steer;
    private readonly InputAction m_EngineOff_GearUp;
    private readonly InputAction m_EngineOff_GearDown;
    private readonly InputAction m_EngineOff_CameraRotation;
    private readonly InputAction m_EngineOff_Quit;
    private readonly InputAction m_EngineOff_StartEngine;
    public struct EngineOffActions
    {
        private @InputActions m_Wrapper;
        public EngineOffActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Trigger => m_Wrapper.m_EngineOff_Trigger;
        public InputAction @Brake => m_Wrapper.m_EngineOff_Brake;
        public InputAction @Steer => m_Wrapper.m_EngineOff_Steer;
        public InputAction @GearUp => m_Wrapper.m_EngineOff_GearUp;
        public InputAction @GearDown => m_Wrapper.m_EngineOff_GearDown;
        public InputAction @CameraRotation => m_Wrapper.m_EngineOff_CameraRotation;
        public InputAction @Quit => m_Wrapper.m_EngineOff_Quit;
        public InputAction @StartEngine => m_Wrapper.m_EngineOff_StartEngine;
        public InputActionMap Get() { return m_Wrapper.m_EngineOff; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EngineOffActions set) { return set.Get(); }
        public void SetCallbacks(IEngineOffActions instance)
        {
            if (m_Wrapper.m_EngineOffActionsCallbackInterface != null)
            {
                @Trigger.started -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnTrigger;
                @Trigger.performed -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnTrigger;
                @Trigger.canceled -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnTrigger;
                @Brake.started -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnBrake;
                @Steer.started -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnSteer;
                @Steer.performed -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnSteer;
                @Steer.canceled -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnSteer;
                @GearUp.started -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnGearUp;
                @GearUp.performed -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnGearUp;
                @GearUp.canceled -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnGearUp;
                @GearDown.started -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnGearDown;
                @GearDown.performed -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnGearDown;
                @GearDown.canceled -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnGearDown;
                @CameraRotation.started -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnCameraRotation;
                @CameraRotation.performed -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnCameraRotation;
                @CameraRotation.canceled -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnCameraRotation;
                @Quit.started -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnQuit;
                @Quit.performed -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnQuit;
                @Quit.canceled -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnQuit;
                @StartEngine.started -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnStartEngine;
                @StartEngine.performed -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnStartEngine;
                @StartEngine.canceled -= m_Wrapper.m_EngineOffActionsCallbackInterface.OnStartEngine;
            }
            m_Wrapper.m_EngineOffActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Trigger.started += instance.OnTrigger;
                @Trigger.performed += instance.OnTrigger;
                @Trigger.canceled += instance.OnTrigger;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
                @Steer.started += instance.OnSteer;
                @Steer.performed += instance.OnSteer;
                @Steer.canceled += instance.OnSteer;
                @GearUp.started += instance.OnGearUp;
                @GearUp.performed += instance.OnGearUp;
                @GearUp.canceled += instance.OnGearUp;
                @GearDown.started += instance.OnGearDown;
                @GearDown.performed += instance.OnGearDown;
                @GearDown.canceled += instance.OnGearDown;
                @CameraRotation.started += instance.OnCameraRotation;
                @CameraRotation.performed += instance.OnCameraRotation;
                @CameraRotation.canceled += instance.OnCameraRotation;
                @Quit.started += instance.OnQuit;
                @Quit.performed += instance.OnQuit;
                @Quit.canceled += instance.OnQuit;
                @StartEngine.started += instance.OnStartEngine;
                @StartEngine.performed += instance.OnStartEngine;
                @StartEngine.canceled += instance.OnStartEngine;
            }
        }
    }
    public EngineOffActions @EngineOff => new EngineOffActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IDriveActions
    {
        void OnThrottle(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnSteer(InputAction.CallbackContext context);
        void OnGearUp(InputAction.CallbackContext context);
        void OnGearDown(InputAction.CallbackContext context);
        void OnCameraRotation(InputAction.CallbackContext context);
        void OnQuit(InputAction.CallbackContext context);
        void OnStopEngine(InputAction.CallbackContext context);
        void OnToggleHeadlights(InputAction.CallbackContext context);
    }
    public interface IEngineOffActions
    {
        void OnTrigger(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnSteer(InputAction.CallbackContext context);
        void OnGearUp(InputAction.CallbackContext context);
        void OnGearDown(InputAction.CallbackContext context);
        void OnCameraRotation(InputAction.CallbackContext context);
        void OnQuit(InputAction.CallbackContext context);
        void OnStartEngine(InputAction.CallbackContext context);
    }
}
