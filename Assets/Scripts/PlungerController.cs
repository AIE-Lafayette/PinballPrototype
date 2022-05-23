// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlungerController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlungerController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlungerController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlungerController"",
    ""maps"": [
        {
            ""name"": ""Charge"",
            ""id"": ""72dd62dd-44b8-4c8d-856b-13c1ad93d698"",
            ""actions"": [
                {
                    ""name"": ""pullback"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d7524167-0100-4ccb-b489-9f457c4171b1"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fda58328-475b-4f7d-a398-22c4729128d0"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""pullback"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Charge
        m_Charge = asset.FindActionMap("Charge", throwIfNotFound: true);
        m_Charge_pullback = m_Charge.FindAction("pullback", throwIfNotFound: true);
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

    // Charge
    private readonly InputActionMap m_Charge;
    private IChargeActions m_ChargeActionsCallbackInterface;
    private readonly InputAction m_Charge_pullback;
    public struct ChargeActions
    {
        private @PlungerController m_Wrapper;
        public ChargeActions(@PlungerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @pullback => m_Wrapper.m_Charge_pullback;
        public InputActionMap Get() { return m_Wrapper.m_Charge; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ChargeActions set) { return set.Get(); }
        public void SetCallbacks(IChargeActions instance)
        {
            if (m_Wrapper.m_ChargeActionsCallbackInterface != null)
            {
                @pullback.started -= m_Wrapper.m_ChargeActionsCallbackInterface.OnPullback;
                @pullback.performed -= m_Wrapper.m_ChargeActionsCallbackInterface.OnPullback;
                @pullback.canceled -= m_Wrapper.m_ChargeActionsCallbackInterface.OnPullback;
            }
            m_Wrapper.m_ChargeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @pullback.started += instance.OnPullback;
                @pullback.performed += instance.OnPullback;
                @pullback.canceled += instance.OnPullback;
            }
        }
    }
    public ChargeActions @Charge => new ChargeActions(this);
    public interface IChargeActions
    {
        void OnPullback(InputAction.CallbackContext context);
    }
}
