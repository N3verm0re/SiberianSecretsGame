// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/PlayerControls.inputactions'

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
            ""name"": ""Gameplay"",
            ""id"": ""09b94e3e-29a3-425d-bee8-b2a29d5613b8"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""5461b459-1e4a-4929-a595-985ef6a8c258"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""75ef8475-9ab0-4836-9140-1d4c10b525a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""69cf09f1-eb39-438f-843c-3cb85ea535da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4457bf97-53f4-403f-bb73-8beb46c1bc9c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59da8625-57ab-4aec-9a4d-7b906a1e652e"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fef7b44d-5238-4113-b035-80ae258153b8"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MenuNavigation"",
            ""id"": ""08e596ff-ca07-4eeb-b232-d937593c445a"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""5edf7904-e9e9-41d8-ac14-aa065fb4fdf0"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""56530162-c22a-4453-8452-f8cef4a170bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""2806aa83-2ea3-4296-ae5d-2eac6c3ef375"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ManipulateValue"",
                    ""type"": ""Value"",
                    ""id"": ""fdd3b338-d272-4aae-9691-90f1cdd4ed32"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""0ccec7d2-8a8e-4d42-98c7-2660b31706df"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a1699725-26e7-4df1-8d6e-6cc10ffdf2a7"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7eea377a-53d6-4f83-b0d0-3bc12cdc915a"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ad7f5382-625b-4da2-adcc-56324325c97e"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f5f74c1c-449d-4e76-9ded-52c9ad4cee72"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ce1f1270-847d-4477-bdcd-2b036f592fd8"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80124a9b-11da-4418-a832-2fb9d36bbb54"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""4047c28a-1354-422f-ba20-6c3175a11509"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ManipulateValue"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7948e09b-efdb-44f6-a796-59ee6b54dfcf"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ManipulateValue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3ee795e7-c0a5-4d17-8769-690fe122aee2"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ManipulateValue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""PauseNavigation"",
            ""id"": ""ef27b631-080e-4edd-afb8-adf417abcc9d"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""ebee90fa-2969-4132-9c2a-13743df1bdcd"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""09be2f20-c67c-41b4-bf42-b0187161b0a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Unpause"",
                    ""type"": ""Button"",
                    ""id"": ""80289ec9-e0b2-4580-9cdf-f2ced019ef56"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ManipulateValue"",
                    ""type"": ""Value"",
                    ""id"": ""704bf01b-4cb9-4609-b55b-82e42c7204d9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""559695b8-8b33-4f60-9928-8f6eaf88831a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""713144f7-d787-4fb7-99c3-88e6a5036e79"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a40da13c-eff3-4395-9a77-9b2f5f6ce698"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""549d438a-ebf0-4018-8a25-e3ae724fd628"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""26bbe11e-6a09-4345-87a8-be7d453cf71d"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f406d5c8-4d5d-4d6d-8a9a-1ea765e0b67f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a6e6629-054b-4eaa-bceb-9fe3e40b3c4b"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Unpause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""aa3d7e4c-054e-459a-89d3-3935d8f9209b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ManipulateValue"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bb7e3dd8-1474-4adc-be1e-bc712634e9b0"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ManipulateValue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3eac109c-e05c-4bfb-81ed-3fcac674a8da"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ManipulateValue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
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
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
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
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
        m_Gameplay_Interact = m_Gameplay.FindAction("Interact", throwIfNotFound: true);
        // MenuNavigation
        m_MenuNavigation = asset.FindActionMap("MenuNavigation", throwIfNotFound: true);
        m_MenuNavigation_Navigate = m_MenuNavigation.FindAction("Navigate", throwIfNotFound: true);
        m_MenuNavigation_Select = m_MenuNavigation.FindAction("Select", throwIfNotFound: true);
        m_MenuNavigation_Cancel = m_MenuNavigation.FindAction("Cancel", throwIfNotFound: true);
        m_MenuNavigation_ManipulateValue = m_MenuNavigation.FindAction("ManipulateValue", throwIfNotFound: true);
        // PauseNavigation
        m_PauseNavigation = asset.FindActionMap("PauseNavigation", throwIfNotFound: true);
        m_PauseNavigation_Navigate = m_PauseNavigation.FindAction("Navigate", throwIfNotFound: true);
        m_PauseNavigation_Select = m_PauseNavigation.FindAction("Select", throwIfNotFound: true);
        m_PauseNavigation_Unpause = m_PauseNavigation.FindAction("Unpause", throwIfNotFound: true);
        m_PauseNavigation_ManipulateValue = m_PauseNavigation.FindAction("ManipulateValue", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Pause;
    private readonly InputAction m_Gameplay_Interact;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
        public InputAction @Interact => m_Wrapper.m_Gameplay_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Pause.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Interact.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // MenuNavigation
    private readonly InputActionMap m_MenuNavigation;
    private IMenuNavigationActions m_MenuNavigationActionsCallbackInterface;
    private readonly InputAction m_MenuNavigation_Navigate;
    private readonly InputAction m_MenuNavigation_Select;
    private readonly InputAction m_MenuNavigation_Cancel;
    private readonly InputAction m_MenuNavigation_ManipulateValue;
    public struct MenuNavigationActions
    {
        private @PlayerControls m_Wrapper;
        public MenuNavigationActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_MenuNavigation_Navigate;
        public InputAction @Select => m_Wrapper.m_MenuNavigation_Select;
        public InputAction @Cancel => m_Wrapper.m_MenuNavigation_Cancel;
        public InputAction @ManipulateValue => m_Wrapper.m_MenuNavigation_ManipulateValue;
        public InputActionMap Get() { return m_Wrapper.m_MenuNavigation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuNavigationActions set) { return set.Get(); }
        public void SetCallbacks(IMenuNavigationActions instance)
        {
            if (m_Wrapper.m_MenuNavigationActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnNavigate;
                @Select.started -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnSelect;
                @Cancel.started -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnCancel;
                @ManipulateValue.started -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnManipulateValue;
                @ManipulateValue.performed -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnManipulateValue;
                @ManipulateValue.canceled -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnManipulateValue;
            }
            m_Wrapper.m_MenuNavigationActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @ManipulateValue.started += instance.OnManipulateValue;
                @ManipulateValue.performed += instance.OnManipulateValue;
                @ManipulateValue.canceled += instance.OnManipulateValue;
            }
        }
    }
    public MenuNavigationActions @MenuNavigation => new MenuNavigationActions(this);

    // PauseNavigation
    private readonly InputActionMap m_PauseNavigation;
    private IPauseNavigationActions m_PauseNavigationActionsCallbackInterface;
    private readonly InputAction m_PauseNavigation_Navigate;
    private readonly InputAction m_PauseNavigation_Select;
    private readonly InputAction m_PauseNavigation_Unpause;
    private readonly InputAction m_PauseNavigation_ManipulateValue;
    public struct PauseNavigationActions
    {
        private @PlayerControls m_Wrapper;
        public PauseNavigationActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_PauseNavigation_Navigate;
        public InputAction @Select => m_Wrapper.m_PauseNavigation_Select;
        public InputAction @Unpause => m_Wrapper.m_PauseNavigation_Unpause;
        public InputAction @ManipulateValue => m_Wrapper.m_PauseNavigation_ManipulateValue;
        public InputActionMap Get() { return m_Wrapper.m_PauseNavigation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseNavigationActions set) { return set.Get(); }
        public void SetCallbacks(IPauseNavigationActions instance)
        {
            if (m_Wrapper.m_PauseNavigationActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_PauseNavigationActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_PauseNavigationActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_PauseNavigationActionsCallbackInterface.OnNavigate;
                @Select.started -= m_Wrapper.m_PauseNavigationActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_PauseNavigationActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_PauseNavigationActionsCallbackInterface.OnSelect;
                @Unpause.started -= m_Wrapper.m_PauseNavigationActionsCallbackInterface.OnUnpause;
                @Unpause.performed -= m_Wrapper.m_PauseNavigationActionsCallbackInterface.OnUnpause;
                @Unpause.canceled -= m_Wrapper.m_PauseNavigationActionsCallbackInterface.OnUnpause;
                @ManipulateValue.started -= m_Wrapper.m_PauseNavigationActionsCallbackInterface.OnManipulateValue;
                @ManipulateValue.performed -= m_Wrapper.m_PauseNavigationActionsCallbackInterface.OnManipulateValue;
                @ManipulateValue.canceled -= m_Wrapper.m_PauseNavigationActionsCallbackInterface.OnManipulateValue;
            }
            m_Wrapper.m_PauseNavigationActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Unpause.started += instance.OnUnpause;
                @Unpause.performed += instance.OnUnpause;
                @Unpause.canceled += instance.OnUnpause;
                @ManipulateValue.started += instance.OnManipulateValue;
                @ManipulateValue.performed += instance.OnManipulateValue;
                @ManipulateValue.canceled += instance.OnManipulateValue;
            }
        }
    }
    public PauseNavigationActions @PauseNavigation => new PauseNavigationActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IMenuNavigationActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnManipulateValue(InputAction.CallbackContext context);
    }
    public interface IPauseNavigationActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnUnpause(InputAction.CallbackContext context);
        void OnManipulateValue(InputAction.CallbackContext context);
    }
}
