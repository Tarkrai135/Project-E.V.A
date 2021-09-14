// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""dd70fe9f-14f8-488c-a8b3-bd014bed371d"",
            ""actions"": [
                {
                    ""name"": ""MoveKeyboard"",
                    ""type"": ""Value"",
                    ""id"": ""43b7004f-5fd9-47a5-9daf-06ea6891d285"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookMouse"",
                    ""type"": ""Value"",
                    ""id"": ""6a513d95-6411-4813-ad41-d49fbf3935a8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookGamepad"",
                    ""type"": ""Value"",
                    ""id"": ""579c406c-d01b-48ce-889e-583596dd4997"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EngineOnKeyboard"",
                    ""type"": ""Button"",
                    ""id"": ""919157c2-5be3-4c79-8e0a-872057cae726"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""EngineOffKeyboard"",
                    ""type"": ""Button"",
                    ""id"": ""6f3bc041-5ae7-47cb-a585-af428ed7644f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""MoveGamepad"",
                    ""type"": ""Value"",
                    ""id"": ""80b12dc8-c6b7-43bc-a589-dd459c4efaec"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EngineOnGamepad"",
                    ""type"": ""Button"",
                    ""id"": ""d48e8eea-5a8a-4b24-9c9f-1246855a12f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""EngineOffGamepad"",
                    ""type"": ""Button"",
                    ""id"": ""08834157-38b4-4b1c-aea5-a620d0298142"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""PauseGameKeyboard"",
                    ""type"": ""Button"",
                    ""id"": ""8fa74258-76c2-4063-843d-e166304ae4a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PauseGameGamepad"",
                    ""type"": ""Button"",
                    ""id"": ""fbe029db-32f8-4fe7-8a62-8b4b69556745"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""00ca640b-d935-4593-8157-c05846ea39b3"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e2062cb9-1b15-46a2-838c-2f8d72a0bdd9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8180e8bd-4097-4f4e-ab88-4523101a6ce9"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""320bffee-a40b-4347-ac70-c210eb8bc73a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1c5327b5-f71c-4f60-99c7-4e737386f1d1"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d2581a9b-1d11-4566-b27d-b92aff5fabbc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2e46982e-44cc-431b-9f0b-c11910bf467a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcfe95b8-67b9-4526-84b5-5d0bc98d6400"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""77bff152-3580-4b21-b6de-dcd0c7e41164"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""82cb066d-8d60-4851-b069-7acbd2265457"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""EngineOnKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b68c7b95-8327-4c82-9bc1-c4c4ba7dfb64"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""EngineOffKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0a9a862-ceec-42ee-a4ce-8a85a6e07e3e"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""LookMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b447dd50-d8a8-4382-80aa-20ada7bdc33a"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LookGamepad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be166a1e-83d5-4c08-bf49-dcb157ce9d9a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveGamepad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""138157f0-ba2c-4834-80b6-042bf1f784e1"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EngineOnGamepad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84bc0106-9de6-4959-859f-9f5ca1896e4a"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""EngineOffGamepad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b78f7c67-e8ba-4940-9fa1-3730294857a3"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""PauseGameKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef9a5c0c-9890-4394-83cf-af4af86c0ace"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PauseGameGamepad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""57c3c436-df0b-4810-a9d9-3ecfefc4d41c"",
            ""actions"": [
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""19df3594-c6dc-4e5b-9820-0c8c3bf3b09a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SubmitGamepad"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b828c93c-3ece-46b4-9996-2c958f034b97"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Navigate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""15172f32-4cec-43dd-af03-1bfc5384d0c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bf2db1b7-81f8-4756-a22b-3f4b67cf5119"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2539f094-f3f2-46ca-9d19-2cbff0ab3adc"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8cb20711-12e9-4358-a8f9-ce4d3c4bf2d2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SubmitGamepad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""89f3c3b5-1b60-4bef-acc1-2d13416d9f02"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""939b02b0-feec-4f7e-ad64-8654b650a2b8"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Click"",
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
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MoveKeyboard = m_Player.FindAction("MoveKeyboard", throwIfNotFound: true);
        m_Player_LookMouse = m_Player.FindAction("LookMouse", throwIfNotFound: true);
        m_Player_LookGamepad = m_Player.FindAction("LookGamepad", throwIfNotFound: true);
        m_Player_EngineOnKeyboard = m_Player.FindAction("EngineOnKeyboard", throwIfNotFound: true);
        m_Player_EngineOffKeyboard = m_Player.FindAction("EngineOffKeyboard", throwIfNotFound: true);
        m_Player_MoveGamepad = m_Player.FindAction("MoveGamepad", throwIfNotFound: true);
        m_Player_EngineOnGamepad = m_Player.FindAction("EngineOnGamepad", throwIfNotFound: true);
        m_Player_EngineOffGamepad = m_Player.FindAction("EngineOffGamepad", throwIfNotFound: true);
        m_Player_PauseGameKeyboard = m_Player.FindAction("PauseGameKeyboard", throwIfNotFound: true);
        m_Player_PauseGameGamepad = m_Player.FindAction("PauseGameGamepad", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
        m_UI_SubmitGamepad = m_UI.FindAction("SubmitGamepad", throwIfNotFound: true);
        m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_MoveKeyboard;
    private readonly InputAction m_Player_LookMouse;
    private readonly InputAction m_Player_LookGamepad;
    private readonly InputAction m_Player_EngineOnKeyboard;
    private readonly InputAction m_Player_EngineOffKeyboard;
    private readonly InputAction m_Player_MoveGamepad;
    private readonly InputAction m_Player_EngineOnGamepad;
    private readonly InputAction m_Player_EngineOffGamepad;
    private readonly InputAction m_Player_PauseGameKeyboard;
    private readonly InputAction m_Player_PauseGameGamepad;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveKeyboard => m_Wrapper.m_Player_MoveKeyboard;
        public InputAction @LookMouse => m_Wrapper.m_Player_LookMouse;
        public InputAction @LookGamepad => m_Wrapper.m_Player_LookGamepad;
        public InputAction @EngineOnKeyboard => m_Wrapper.m_Player_EngineOnKeyboard;
        public InputAction @EngineOffKeyboard => m_Wrapper.m_Player_EngineOffKeyboard;
        public InputAction @MoveGamepad => m_Wrapper.m_Player_MoveGamepad;
        public InputAction @EngineOnGamepad => m_Wrapper.m_Player_EngineOnGamepad;
        public InputAction @EngineOffGamepad => m_Wrapper.m_Player_EngineOffGamepad;
        public InputAction @PauseGameKeyboard => m_Wrapper.m_Player_PauseGameKeyboard;
        public InputAction @PauseGameGamepad => m_Wrapper.m_Player_PauseGameGamepad;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MoveKeyboard.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveKeyboard;
                @MoveKeyboard.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveKeyboard;
                @MoveKeyboard.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveKeyboard;
                @LookMouse.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookMouse;
                @LookMouse.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookMouse;
                @LookMouse.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookMouse;
                @LookGamepad.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookGamepad;
                @LookGamepad.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookGamepad;
                @LookGamepad.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookGamepad;
                @EngineOnKeyboard.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEngineOnKeyboard;
                @EngineOnKeyboard.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEngineOnKeyboard;
                @EngineOnKeyboard.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEngineOnKeyboard;
                @EngineOffKeyboard.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEngineOffKeyboard;
                @EngineOffKeyboard.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEngineOffKeyboard;
                @EngineOffKeyboard.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEngineOffKeyboard;
                @MoveGamepad.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveGamepad;
                @MoveGamepad.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveGamepad;
                @MoveGamepad.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveGamepad;
                @EngineOnGamepad.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEngineOnGamepad;
                @EngineOnGamepad.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEngineOnGamepad;
                @EngineOnGamepad.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEngineOnGamepad;
                @EngineOffGamepad.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEngineOffGamepad;
                @EngineOffGamepad.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEngineOffGamepad;
                @EngineOffGamepad.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEngineOffGamepad;
                @PauseGameKeyboard.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseGameKeyboard;
                @PauseGameKeyboard.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseGameKeyboard;
                @PauseGameKeyboard.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseGameKeyboard;
                @PauseGameGamepad.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseGameGamepad;
                @PauseGameGamepad.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseGameGamepad;
                @PauseGameGamepad.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseGameGamepad;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveKeyboard.started += instance.OnMoveKeyboard;
                @MoveKeyboard.performed += instance.OnMoveKeyboard;
                @MoveKeyboard.canceled += instance.OnMoveKeyboard;
                @LookMouse.started += instance.OnLookMouse;
                @LookMouse.performed += instance.OnLookMouse;
                @LookMouse.canceled += instance.OnLookMouse;
                @LookGamepad.started += instance.OnLookGamepad;
                @LookGamepad.performed += instance.OnLookGamepad;
                @LookGamepad.canceled += instance.OnLookGamepad;
                @EngineOnKeyboard.started += instance.OnEngineOnKeyboard;
                @EngineOnKeyboard.performed += instance.OnEngineOnKeyboard;
                @EngineOnKeyboard.canceled += instance.OnEngineOnKeyboard;
                @EngineOffKeyboard.started += instance.OnEngineOffKeyboard;
                @EngineOffKeyboard.performed += instance.OnEngineOffKeyboard;
                @EngineOffKeyboard.canceled += instance.OnEngineOffKeyboard;
                @MoveGamepad.started += instance.OnMoveGamepad;
                @MoveGamepad.performed += instance.OnMoveGamepad;
                @MoveGamepad.canceled += instance.OnMoveGamepad;
                @EngineOnGamepad.started += instance.OnEngineOnGamepad;
                @EngineOnGamepad.performed += instance.OnEngineOnGamepad;
                @EngineOnGamepad.canceled += instance.OnEngineOnGamepad;
                @EngineOffGamepad.started += instance.OnEngineOffGamepad;
                @EngineOffGamepad.performed += instance.OnEngineOffGamepad;
                @EngineOffGamepad.canceled += instance.OnEngineOffGamepad;
                @PauseGameKeyboard.started += instance.OnPauseGameKeyboard;
                @PauseGameKeyboard.performed += instance.OnPauseGameKeyboard;
                @PauseGameKeyboard.canceled += instance.OnPauseGameKeyboard;
                @PauseGameGamepad.started += instance.OnPauseGameGamepad;
                @PauseGameGamepad.performed += instance.OnPauseGameGamepad;
                @PauseGameGamepad.canceled += instance.OnPauseGameGamepad;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Point;
    private readonly InputAction m_UI_SubmitGamepad;
    private readonly InputAction m_UI_Navigate;
    private readonly InputAction m_UI_Click;
    public struct UIActions
    {
        private @PlayerControls m_Wrapper;
        public UIActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Point => m_Wrapper.m_UI_Point;
        public InputAction @SubmitGamepad => m_Wrapper.m_UI_SubmitGamepad;
        public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
        public InputAction @Click => m_Wrapper.m_UI_Click;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @SubmitGamepad.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmitGamepad;
                @SubmitGamepad.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmitGamepad;
                @SubmitGamepad.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmitGamepad;
                @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @SubmitGamepad.started += instance.OnSubmitGamepad;
                @SubmitGamepad.performed += instance.OnSubmitGamepad;
                @SubmitGamepad.canceled += instance.OnSubmitGamepad;
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
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
    public interface IPlayerActions
    {
        void OnMoveKeyboard(InputAction.CallbackContext context);
        void OnLookMouse(InputAction.CallbackContext context);
        void OnLookGamepad(InputAction.CallbackContext context);
        void OnEngineOnKeyboard(InputAction.CallbackContext context);
        void OnEngineOffKeyboard(InputAction.CallbackContext context);
        void OnMoveGamepad(InputAction.CallbackContext context);
        void OnEngineOnGamepad(InputAction.CallbackContext context);
        void OnEngineOffGamepad(InputAction.CallbackContext context);
        void OnPauseGameKeyboard(InputAction.CallbackContext context);
        void OnPauseGameGamepad(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnPoint(InputAction.CallbackContext context);
        void OnSubmitGamepad(InputAction.CallbackContext context);
        void OnNavigate(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
    }
}
