// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PaddleControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PaddleControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PaddleControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PaddleControls"",
    ""maps"": [
        {
            ""name"": ""Paddle Controller"",
            ""id"": ""29ada114-597e-495e-94fd-cfc15828bf41"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""4db8f767-612c-430e-9d80-2ed1c965f565"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""A and D Paddle"",
                    ""id"": ""f16d74c2-3622-487c-8337-a0aec4c39b6d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fe77a26b-a27b-4651-81ce-0ec7fd3c74e5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6b3212ba-aa16-45cb-9940-a48402ce38ce"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Paddle Controller
        m_PaddleController = asset.FindActionMap("Paddle Controller", throwIfNotFound: true);
        m_PaddleController_Newaction = m_PaddleController.FindAction("New action", throwIfNotFound: true);
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

    // Paddle Controller
    private readonly InputActionMap m_PaddleController;
    private IPaddleControllerActions m_PaddleControllerActionsCallbackInterface;
    private readonly InputAction m_PaddleController_Newaction;
    public struct PaddleControllerActions
    {
        private @PaddleControls m_Wrapper;
        public PaddleControllerActions(@PaddleControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_PaddleController_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_PaddleController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PaddleControllerActions set) { return set.Get(); }
        public void SetCallbacks(IPaddleControllerActions instance)
        {
            if (m_Wrapper.m_PaddleControllerActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_PaddleControllerActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_PaddleControllerActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_PaddleControllerActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_PaddleControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public PaddleControllerActions @PaddleController => new PaddleControllerActions(this);
    public interface IPaddleControllerActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
