//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Input/GameControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @GameControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameControls"",
    ""maps"": [
        {
            ""name"": ""MovementActions"",
            ""id"": ""7f11ed2d-d4c0-4807-9189-eac439a14820"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""fa06fc26-949d-4fa5-8b66-106f277bc9c0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eaa3beba-7ac6-4b92-a3d9-c4035cd2e943"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""6f93d51b-e3f1-435f-ab5d-c979f3333572"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0a9282a4-fb7b-4bf8-bad4-ea516f247d60"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a4a52c65-755a-4174-93c0-e9cb4e5a04e3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""59152499-4c3e-4ea3-8ff6-807ca249d761"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""385dbf7a-2b8d-48a8-a1a8-54af4a1da748"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""ShootActions"",
            ""id"": ""d1e8cfb1-9aba-4355-9a79-20c9e6780a80"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Value"",
                    ""id"": ""fbc0f213-ba69-4853-9dff-a9600ae1cf68"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cce1c775-ffbf-4d59-bd3e-f078e1db8ce0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""New control scheme"",
            ""bindingGroup"": ""New control scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // MovementActions
        m_MovementActions = asset.FindActionMap("MovementActions", throwIfNotFound: true);
        m_MovementActions_Movement = m_MovementActions.FindAction("Movement", throwIfNotFound: true);
        // ShootActions
        m_ShootActions = asset.FindActionMap("ShootActions", throwIfNotFound: true);
        m_ShootActions_Shoot = m_ShootActions.FindAction("Shoot", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // MovementActions
    private readonly InputActionMap m_MovementActions;
    private List<IMovementActionsActions> m_MovementActionsActionsCallbackInterfaces = new List<IMovementActionsActions>();
    private readonly InputAction m_MovementActions_Movement;
    public struct MovementActionsActions
    {
        private @GameControls m_Wrapper;
        public MovementActionsActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_MovementActions_Movement;
        public InputActionMap Get() { return m_Wrapper.m_MovementActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActionsActions set) { return set.Get(); }
        public void AddCallbacks(IMovementActionsActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementActionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementActionsActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
        }

        private void UnregisterCallbacks(IMovementActionsActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
        }

        public void RemoveCallbacks(IMovementActionsActions instance)
        {
            if (m_Wrapper.m_MovementActionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementActionsActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementActionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementActionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementActionsActions @MovementActions => new MovementActionsActions(this);

    // ShootActions
    private readonly InputActionMap m_ShootActions;
    private List<IShootActionsActions> m_ShootActionsActionsCallbackInterfaces = new List<IShootActionsActions>();
    private readonly InputAction m_ShootActions_Shoot;
    public struct ShootActionsActions
    {
        private @GameControls m_Wrapper;
        public ShootActionsActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_ShootActions_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_ShootActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShootActionsActions set) { return set.Get(); }
        public void AddCallbacks(IShootActionsActions instance)
        {
            if (instance == null || m_Wrapper.m_ShootActionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ShootActionsActionsCallbackInterfaces.Add(instance);
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
        }

        private void UnregisterCallbacks(IShootActionsActions instance)
        {
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
        }

        public void RemoveCallbacks(IShootActionsActions instance)
        {
            if (m_Wrapper.m_ShootActionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IShootActionsActions instance)
        {
            foreach (var item in m_Wrapper.m_ShootActionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ShootActionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ShootActionsActions @ShootActions => new ShootActionsActions(this);
    private int m_NewcontrolschemeSchemeIndex = -1;
    public InputControlScheme NewcontrolschemeScheme
    {
        get
        {
            if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
            return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
        }
    }
    public interface IMovementActionsActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IShootActionsActions
    {
        void OnShoot(InputAction.CallbackContext context);
    }
}
