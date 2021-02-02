// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/CharacterInputController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CharacterInputController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CharacterInputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CharacterInputController"",
    ""maps"": [
        {
            ""name"": ""CharacterAction"",
            ""id"": ""20c3600b-24f9-408d-b18a-8840b45ac4b2"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""PassThrough"",
                    ""id"": ""36c6bc75-f952-49b1-8d87-07ea93925bd9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0cc5153e-371d-4469-b126-491d449c0947"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""09d34dab-6689-4ed0-bc00-4ca99e6c0a9a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WalkKeyboard"",
                    ""id"": ""2d8e0724-b28d-4eed-9669-0eea30c8cbdb"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""67a663d3-0ffd-46a5-8fdf-3b8b43f0a868"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""36196b0c-c2be-4b1e-9ef4-0d82fbef1d20"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WalkGamepad"",
                    ""id"": ""5b7de4f0-9e59-44a6-8d6b-bf814f5317b4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""041b2e45-e096-4838-999a-0acfceec6b80"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6ab8b862-b668-4815-9c0b-c10cee09682e"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1b7037b7-5ee1-40e2-ac28-abe0f898fb61"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf73d0ec-1091-4372-8892-ca7795ce70a2"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4db9f4fd-d47f-4033-aadf-394df11b6765"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48b951b0-33aa-4ff8-8165-700f253275cf"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CharacterAction
        m_CharacterAction = asset.FindActionMap("CharacterAction", throwIfNotFound: true);
        m_CharacterAction_Walk = m_CharacterAction.FindAction("Walk", throwIfNotFound: true);
        m_CharacterAction_Run = m_CharacterAction.FindAction("Run", throwIfNotFound: true);
        m_CharacterAction_Jump = m_CharacterAction.FindAction("Jump", throwIfNotFound: true);
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

    // CharacterAction
    private readonly InputActionMap m_CharacterAction;
    private ICharacterActionActions m_CharacterActionActionsCallbackInterface;
    private readonly InputAction m_CharacterAction_Walk;
    private readonly InputAction m_CharacterAction_Run;
    private readonly InputAction m_CharacterAction_Jump;
    public struct CharacterActionActions
    {
        private @CharacterInputController m_Wrapper;
        public CharacterActionActions(@CharacterInputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_CharacterAction_Walk;
        public InputAction @Run => m_Wrapper.m_CharacterAction_Run;
        public InputAction @Jump => m_Wrapper.m_CharacterAction_Jump;
        public InputActionMap Get() { return m_Wrapper.m_CharacterAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActionActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterActionActions instance)
        {
            if (m_Wrapper.m_CharacterActionActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_CharacterActionActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_CharacterActionActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_CharacterActionActionsCallbackInterface.OnWalk;
                @Run.started -= m_Wrapper.m_CharacterActionActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_CharacterActionActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_CharacterActionActionsCallbackInterface.OnRun;
                @Jump.started -= m_Wrapper.m_CharacterActionActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterActionActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterActionActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_CharacterActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public CharacterActionActions @CharacterAction => new CharacterActionActions(this);
    public interface ICharacterActionActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
