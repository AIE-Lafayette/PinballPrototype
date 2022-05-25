// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PauseUI.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PauseUI : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PauseUI()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PauseUI"",
    ""maps"": [
        {
            ""name"": ""Pause"",
            ""id"": ""62376adb-ee89-4eda-bc87-182ad1b16853"",
            ""actions"": [
                {
                    ""name"": ""PauseButton"",
                    ""type"": ""Button"",
                    ""id"": ""280cf04a-c393-43d6-bb69-382560f949ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""edd151fa-81b3-4ad3-8620-7504444018ed"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Pause
        m_Pause = asset.FindActionMap("Pause", throwIfNotFound: true);
        m_Pause_PauseButton = m_Pause.FindAction("PauseButton", throwIfNotFound: true);
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

    // Pause
    private readonly InputActionMap m_Pause;
    private IPauseActions m_PauseActionsCallbackInterface;
    private readonly InputAction m_Pause_PauseButton;
    public struct PauseActions
    {
        private @PauseUI m_Wrapper;
        public PauseActions(@PauseUI wrapper) { m_Wrapper = wrapper; }
        public InputAction @PauseButton => m_Wrapper.m_Pause_PauseButton;
        public InputActionMap Get() { return m_Wrapper.m_Pause; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseActions set) { return set.Get(); }
        public void SetCallbacks(IPauseActions instance)
        {
            if (m_Wrapper.m_PauseActionsCallbackInterface != null)
            {
                @PauseButton.started -= m_Wrapper.m_PauseActionsCallbackInterface.OnPauseButton;
                @PauseButton.performed -= m_Wrapper.m_PauseActionsCallbackInterface.OnPauseButton;
                @PauseButton.canceled -= m_Wrapper.m_PauseActionsCallbackInterface.OnPauseButton;
            }
            m_Wrapper.m_PauseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PauseButton.started += instance.OnPauseButton;
                @PauseButton.performed += instance.OnPauseButton;
                @PauseButton.canceled += instance.OnPauseButton;
            }
        }
    }
    public PauseActions @Pause => new PauseActions(this);
    public interface IPauseActions
    {
        void OnPauseButton(InputAction.CallbackContext context);
    }
}
