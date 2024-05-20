// GENERATED AUTOMATICALLY FROM 'Assets/Controls/InputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputSystem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystem"",
    ""maps"": [
        {
            ""name"": ""ActionMap"",
            ""id"": ""74290121-c805-4954-88a6-738a9955ac79"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""da6cb1f1-ce7d-4a62-bebd-7a28df31993f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""2d4d0d41-b755-4207-ba29-9644f0d5fce3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WhiteMagicSelf"",
                    ""type"": ""Button"",
                    ""id"": ""3ef531c0-9f16-4a89-91dc-9263e893e1ca"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WhiteMagicArea"",
                    ""type"": ""Button"",
                    ""id"": ""2680ed74-568a-429c-b86f-aaba6b8d57a9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShieldDome"",
                    ""type"": ""Button"",
                    ""id"": ""0f040493-62dd-4577-ab78-45b22a561600"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShieldWall"",
                    ""type"": ""Button"",
                    ""id"": ""0eeec50c-dbf5-49da-8254-274405ab5674"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LightiningProjectile"",
                    ""type"": ""Button"",
                    ""id"": ""885a069d-9e31-43cd-85ec-82f96a08b49f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LightiningArea"",
                    ""type"": ""Button"",
                    ""id"": ""f20243f4-b25e-49d3-b604-64b1fd2f8c12"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BlackMagicProjectile"",
                    ""type"": ""Button"",
                    ""id"": ""841df285-52fa-464e-b31a-d20c369f889d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BlackMagicArea"",
                    ""type"": ""Button"",
                    ""id"": ""04fafb2a-5665-424d-aa34-128df9001864"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""443f3778-dea7-4fcd-94dc-0c7cb95fa021"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""184d06a7-9580-4106-a3e5-2d27487dc975"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""08954757-a6c6-465b-89e9-5743abdf8abb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e145bf0e-9eb6-4132-9a09-4cb5ec724346"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7b0ebe62-35a2-4c13-9ea3-79a14045ec89"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""5cb10864-dcf6-45e8-8885-0007d340f6e3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c620b20e-25a1-495d-848f-9ae32772de2c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a7d3a9b5-0908-4cfd-a69c-7be5eee7f756"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""700c52aa-c843-4d47-955a-aa0c6f296e03"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7eb552af-c591-43a0-91fe-98ec5be085ff"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""02ec9093-54c6-4d8d-8ce6-c2ae0ecb0429"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c93fb23-3ccb-43d8-8e88-8db6e461e9c0"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WhiteMagicSelf"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0a44223-c4cb-4f1e-a2e1-0428c88c008d"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WhiteMagicArea"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa336377-3633-475c-8db3-4d29675c1be7"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShieldDome"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f9a4f5e-b744-40d7-be62-df3384bf543d"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShieldWall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2b0c2da-aad0-40be-963a-967b6ce94676"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LightiningProjectile"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7f612e0-6700-40b5-8208-4519e35ee3c1"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LightiningArea"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c49e1c0b-38a5-4119-abbe-b6c8db0a2285"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BlackMagicProjectile"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""885e9c58-ae54-4bbf-8958-1ff595bb4a6a"",
                    ""path"": ""<Keyboard>/semicolon"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BlackMagicArea"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // ActionMap
        m_ActionMap = asset.FindActionMap("ActionMap", throwIfNotFound: true);
        m_ActionMap_Move = m_ActionMap.FindAction("Move", throwIfNotFound: true);
        m_ActionMap_Interact = m_ActionMap.FindAction("Interact", throwIfNotFound: true);
        m_ActionMap_WhiteMagicSelf = m_ActionMap.FindAction("WhiteMagicSelf", throwIfNotFound: true);
        m_ActionMap_WhiteMagicArea = m_ActionMap.FindAction("WhiteMagicArea", throwIfNotFound: true);
        m_ActionMap_ShieldDome = m_ActionMap.FindAction("ShieldDome", throwIfNotFound: true);
        m_ActionMap_ShieldWall = m_ActionMap.FindAction("ShieldWall", throwIfNotFound: true);
        m_ActionMap_LightiningProjectile = m_ActionMap.FindAction("LightiningProjectile", throwIfNotFound: true);
        m_ActionMap_LightiningArea = m_ActionMap.FindAction("LightiningArea", throwIfNotFound: true);
        m_ActionMap_BlackMagicProjectile = m_ActionMap.FindAction("BlackMagicProjectile", throwIfNotFound: true);
        m_ActionMap_BlackMagicArea = m_ActionMap.FindAction("BlackMagicArea", throwIfNotFound: true);
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

    // ActionMap
    private readonly InputActionMap m_ActionMap;
    private IActionMapActions m_ActionMapActionsCallbackInterface;
    private readonly InputAction m_ActionMap_Move;
    private readonly InputAction m_ActionMap_Interact;
    private readonly InputAction m_ActionMap_WhiteMagicSelf;
    private readonly InputAction m_ActionMap_WhiteMagicArea;
    private readonly InputAction m_ActionMap_ShieldDome;
    private readonly InputAction m_ActionMap_ShieldWall;
    private readonly InputAction m_ActionMap_LightiningProjectile;
    private readonly InputAction m_ActionMap_LightiningArea;
    private readonly InputAction m_ActionMap_BlackMagicProjectile;
    private readonly InputAction m_ActionMap_BlackMagicArea;
    public struct ActionMapActions
    {
        private @InputSystem m_Wrapper;
        public ActionMapActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_ActionMap_Move;
        public InputAction @Interact => m_Wrapper.m_ActionMap_Interact;
        public InputAction @WhiteMagicSelf => m_Wrapper.m_ActionMap_WhiteMagicSelf;
        public InputAction @WhiteMagicArea => m_Wrapper.m_ActionMap_WhiteMagicArea;
        public InputAction @ShieldDome => m_Wrapper.m_ActionMap_ShieldDome;
        public InputAction @ShieldWall => m_Wrapper.m_ActionMap_ShieldWall;
        public InputAction @LightiningProjectile => m_Wrapper.m_ActionMap_LightiningProjectile;
        public InputAction @LightiningArea => m_Wrapper.m_ActionMap_LightiningArea;
        public InputAction @BlackMagicProjectile => m_Wrapper.m_ActionMap_BlackMagicProjectile;
        public InputAction @BlackMagicArea => m_Wrapper.m_ActionMap_BlackMagicArea;
        public InputActionMap Get() { return m_Wrapper.m_ActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionMapActions set) { return set.Get(); }
        public void SetCallbacks(IActionMapActions instance)
        {
            if (m_Wrapper.m_ActionMapActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMove;
                @Interact.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnInteract;
                @WhiteMagicSelf.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnWhiteMagicSelf;
                @WhiteMagicSelf.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnWhiteMagicSelf;
                @WhiteMagicSelf.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnWhiteMagicSelf;
                @WhiteMagicArea.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnWhiteMagicArea;
                @WhiteMagicArea.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnWhiteMagicArea;
                @WhiteMagicArea.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnWhiteMagicArea;
                @ShieldDome.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnShieldDome;
                @ShieldDome.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnShieldDome;
                @ShieldDome.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnShieldDome;
                @ShieldWall.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnShieldWall;
                @ShieldWall.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnShieldWall;
                @ShieldWall.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnShieldWall;
                @LightiningProjectile.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnLightiningProjectile;
                @LightiningProjectile.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnLightiningProjectile;
                @LightiningProjectile.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnLightiningProjectile;
                @LightiningArea.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnLightiningArea;
                @LightiningArea.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnLightiningArea;
                @LightiningArea.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnLightiningArea;
                @BlackMagicProjectile.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnBlackMagicProjectile;
                @BlackMagicProjectile.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnBlackMagicProjectile;
                @BlackMagicProjectile.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnBlackMagicProjectile;
                @BlackMagicArea.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnBlackMagicArea;
                @BlackMagicArea.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnBlackMagicArea;
                @BlackMagicArea.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnBlackMagicArea;
            }
            m_Wrapper.m_ActionMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @WhiteMagicSelf.started += instance.OnWhiteMagicSelf;
                @WhiteMagicSelf.performed += instance.OnWhiteMagicSelf;
                @WhiteMagicSelf.canceled += instance.OnWhiteMagicSelf;
                @WhiteMagicArea.started += instance.OnWhiteMagicArea;
                @WhiteMagicArea.performed += instance.OnWhiteMagicArea;
                @WhiteMagicArea.canceled += instance.OnWhiteMagicArea;
                @ShieldDome.started += instance.OnShieldDome;
                @ShieldDome.performed += instance.OnShieldDome;
                @ShieldDome.canceled += instance.OnShieldDome;
                @ShieldWall.started += instance.OnShieldWall;
                @ShieldWall.performed += instance.OnShieldWall;
                @ShieldWall.canceled += instance.OnShieldWall;
                @LightiningProjectile.started += instance.OnLightiningProjectile;
                @LightiningProjectile.performed += instance.OnLightiningProjectile;
                @LightiningProjectile.canceled += instance.OnLightiningProjectile;
                @LightiningArea.started += instance.OnLightiningArea;
                @LightiningArea.performed += instance.OnLightiningArea;
                @LightiningArea.canceled += instance.OnLightiningArea;
                @BlackMagicProjectile.started += instance.OnBlackMagicProjectile;
                @BlackMagicProjectile.performed += instance.OnBlackMagicProjectile;
                @BlackMagicProjectile.canceled += instance.OnBlackMagicProjectile;
                @BlackMagicArea.started += instance.OnBlackMagicArea;
                @BlackMagicArea.performed += instance.OnBlackMagicArea;
                @BlackMagicArea.canceled += instance.OnBlackMagicArea;
            }
        }
    }
    public ActionMapActions @ActionMap => new ActionMapActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IActionMapActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnWhiteMagicSelf(InputAction.CallbackContext context);
        void OnWhiteMagicArea(InputAction.CallbackContext context);
        void OnShieldDome(InputAction.CallbackContext context);
        void OnShieldWall(InputAction.CallbackContext context);
        void OnLightiningProjectile(InputAction.CallbackContext context);
        void OnLightiningArea(InputAction.CallbackContext context);
        void OnBlackMagicProjectile(InputAction.CallbackContext context);
        void OnBlackMagicArea(InputAction.CallbackContext context);
    }
}
