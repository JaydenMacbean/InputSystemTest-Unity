// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/FGController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @FGController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @FGController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FGController"",
    ""maps"": [
        {
            ""name"": ""FGControls"",
            ""id"": ""d4474479-e182-4732-9ee7-5beea3741430"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""45fd21b3-7101-409f-b741-b7767f6061b6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""I2"",
                    ""type"": ""Value"",
                    ""id"": ""8b1d2449-63fd-4491-ba08-3f1686409c8d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""I8"",
                    ""type"": ""Value"",
                    ""id"": ""603e1261-9f0d-4e35-8546-29d6f9650a1f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""I66"",
                    ""type"": ""Button"",
                    ""id"": ""d738e199-e08b-4f79-b1a4-9223bd3ee4b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap,Hold""
                },
                {
                    ""name"": ""I66KB"",
                    ""type"": ""Button"",
                    ""id"": ""3e46c800-560f-457d-9694-9283eaab810d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""I44"",
                    ""type"": ""Button"",
                    ""id"": ""1a0b4621-2933-4982-a492-f3237123586e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""I44KB"",
                    ""type"": ""Button"",
                    ""id"": ""c0696c2f-016c-4ba1-899b-eb8f6423e8af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Punch"",
                    ""type"": ""Button"",
                    ""id"": ""24a13473-62f8-45d2-a147-84d740faca55"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Kick"",
                    ""type"": ""Button"",
                    ""id"": ""e1ccff4b-a530-4320-aafa-9965568f69ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Slash"",
                    ""type"": ""Button"",
                    ""id"": ""7fcf20e2-0fd9-4257-a2e4-11d53b839196"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Heavy Slash"",
                    ""type"": ""Button"",
                    ""id"": ""f400c71a-dda6-4a26-a15a-1df08abce3b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dust"",
                    ""type"": ""Button"",
                    ""id"": ""8b2e03be-96c5-44df-a048-995241f13617"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Options"",
                    ""type"": ""Button"",
                    ""id"": ""a3e703de-c301-412c-8b93-c08cc8f0e468"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Restart"",
                    ""type"": ""Button"",
                    ""id"": ""b58ac224-06ea-4664-b52f-e1de6a72070c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cf64f73b-18c9-4eb4-9c44-3ac4c1a752a9"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""I2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c98da52f-a3b5-4e38-856b-dec7e7cdeadc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""I2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a42c9c3-ed0b-44f5-be13-714abdcfa70f"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""I8"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5733e82d-c916-4d05-85d1-046ff9fcdf00"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""I8"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a1019ef-458c-49c7-9f03-68d4f4e07592"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": ""MultiTap(tapDelay=0.27)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""I44"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6fe30290-05fa-4d4d-b922-7d4115d2c043"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""I44"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7224979d-9624-4c11-bd04-45cd68a5668b"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Punch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd580d35-7b42-4ed2-9c92-f145fd4dccb7"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Kick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7bbe2791-908e-4eda-ab83-07f08a5351e1"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14bcac77-7fe2-4b17-a084-27bfc641e979"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Heavy Slash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87a9a2d2-fe88-4d12-89c7-9588ae6ddcf1"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74dd1a4a-cf32-4f07-8781-d1e17c44a5ae"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Options"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b2d6606-5e4c-46f7-b0b6-9dfddd6c93ae"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bebbc2f4-4f85-4926-83f9-e6f779d8e9b4"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""I66KB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d15f9b0-22a4-4ff9-93b4-a12b1862497f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""MultiTap(tapDelay=0.27)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""I44KB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""2f67f452-53de-4c8f-9274-ca68d2c0579c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b9401b3f-758f-447c-a844-b828fdd03905"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8f9bacda-f92c-4cbe-b5ab-f0863885e73a"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6d37895a-bb82-45f6-acc6-4fb48f362147"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""I66"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0bdafffd-b860-45eb-809b-177fb1414832"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""I66"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // FGControls
        m_FGControls = asset.FindActionMap("FGControls", throwIfNotFound: true);
        m_FGControls_Walk = m_FGControls.FindAction("Walk", throwIfNotFound: true);
        m_FGControls_I2 = m_FGControls.FindAction("I2", throwIfNotFound: true);
        m_FGControls_I8 = m_FGControls.FindAction("I8", throwIfNotFound: true);
        m_FGControls_I66 = m_FGControls.FindAction("I66", throwIfNotFound: true);
        m_FGControls_I66KB = m_FGControls.FindAction("I66KB", throwIfNotFound: true);
        m_FGControls_I44 = m_FGControls.FindAction("I44", throwIfNotFound: true);
        m_FGControls_I44KB = m_FGControls.FindAction("I44KB", throwIfNotFound: true);
        m_FGControls_Punch = m_FGControls.FindAction("Punch", throwIfNotFound: true);
        m_FGControls_Kick = m_FGControls.FindAction("Kick", throwIfNotFound: true);
        m_FGControls_Slash = m_FGControls.FindAction("Slash", throwIfNotFound: true);
        m_FGControls_HeavySlash = m_FGControls.FindAction("Heavy Slash", throwIfNotFound: true);
        m_FGControls_Dust = m_FGControls.FindAction("Dust", throwIfNotFound: true);
        m_FGControls_Options = m_FGControls.FindAction("Options", throwIfNotFound: true);
        m_FGControls_Restart = m_FGControls.FindAction("Restart", throwIfNotFound: true);
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

    // FGControls
    private readonly InputActionMap m_FGControls;
    private IFGControlsActions m_FGControlsActionsCallbackInterface;
    private readonly InputAction m_FGControls_Walk;
    private readonly InputAction m_FGControls_I2;
    private readonly InputAction m_FGControls_I8;
    private readonly InputAction m_FGControls_I66;
    private readonly InputAction m_FGControls_I66KB;
    private readonly InputAction m_FGControls_I44;
    private readonly InputAction m_FGControls_I44KB;
    private readonly InputAction m_FGControls_Punch;
    private readonly InputAction m_FGControls_Kick;
    private readonly InputAction m_FGControls_Slash;
    private readonly InputAction m_FGControls_HeavySlash;
    private readonly InputAction m_FGControls_Dust;
    private readonly InputAction m_FGControls_Options;
    private readonly InputAction m_FGControls_Restart;
    public struct FGControlsActions
    {
        private @FGController m_Wrapper;
        public FGControlsActions(@FGController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_FGControls_Walk;
        public InputAction @I2 => m_Wrapper.m_FGControls_I2;
        public InputAction @I8 => m_Wrapper.m_FGControls_I8;
        public InputAction @I66 => m_Wrapper.m_FGControls_I66;
        public InputAction @I66KB => m_Wrapper.m_FGControls_I66KB;
        public InputAction @I44 => m_Wrapper.m_FGControls_I44;
        public InputAction @I44KB => m_Wrapper.m_FGControls_I44KB;
        public InputAction @Punch => m_Wrapper.m_FGControls_Punch;
        public InputAction @Kick => m_Wrapper.m_FGControls_Kick;
        public InputAction @Slash => m_Wrapper.m_FGControls_Slash;
        public InputAction @HeavySlash => m_Wrapper.m_FGControls_HeavySlash;
        public InputAction @Dust => m_Wrapper.m_FGControls_Dust;
        public InputAction @Options => m_Wrapper.m_FGControls_Options;
        public InputAction @Restart => m_Wrapper.m_FGControls_Restart;
        public InputActionMap Get() { return m_Wrapper.m_FGControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FGControlsActions set) { return set.Get(); }
        public void SetCallbacks(IFGControlsActions instance)
        {
            if (m_Wrapper.m_FGControlsActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnWalk;
                @I2.started -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnI2;
                @I2.performed -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnI2;
                @I2.canceled -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnI2;
                @I8.started -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnI8;
                @I8.performed -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnI8;
                @I8.canceled -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnI8;
                @I66.started -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnI66;
                @I66.performed -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnI66;
                @I66.canceled -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnI66;
                @I66KB.started -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnI66KB;
                @I66KB.performed -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnI66KB;
                @I66KB.canceled -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnI66KB;
                @I44.started -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnI44;
                @I44.performed -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnI44;
                @I44.canceled -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnI44;
                @I44KB.started -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnI44KB;
                @I44KB.performed -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnI44KB;
                @I44KB.canceled -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnI44KB;
                @Punch.started -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnPunch;
                @Punch.performed -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnPunch;
                @Punch.canceled -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnPunch;
                @Kick.started -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnKick;
                @Kick.performed -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnKick;
                @Kick.canceled -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnKick;
                @Slash.started -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnSlash;
                @Slash.performed -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnSlash;
                @Slash.canceled -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnSlash;
                @HeavySlash.started -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnHeavySlash;
                @HeavySlash.performed -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnHeavySlash;
                @HeavySlash.canceled -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnHeavySlash;
                @Dust.started -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnDust;
                @Dust.performed -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnDust;
                @Dust.canceled -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnDust;
                @Options.started -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnOptions;
                @Options.performed -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnOptions;
                @Options.canceled -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnOptions;
                @Restart.started -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnRestart;
                @Restart.performed -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnRestart;
                @Restart.canceled -= m_Wrapper.m_FGControlsActionsCallbackInterface.OnRestart;
            }
            m_Wrapper.m_FGControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @I2.started += instance.OnI2;
                @I2.performed += instance.OnI2;
                @I2.canceled += instance.OnI2;
                @I8.started += instance.OnI8;
                @I8.performed += instance.OnI8;
                @I8.canceled += instance.OnI8;
                @I66.started += instance.OnI66;
                @I66.performed += instance.OnI66;
                @I66.canceled += instance.OnI66;
                @I66KB.started += instance.OnI66KB;
                @I66KB.performed += instance.OnI66KB;
                @I66KB.canceled += instance.OnI66KB;
                @I44.started += instance.OnI44;
                @I44.performed += instance.OnI44;
                @I44.canceled += instance.OnI44;
                @I44KB.started += instance.OnI44KB;
                @I44KB.performed += instance.OnI44KB;
                @I44KB.canceled += instance.OnI44KB;
                @Punch.started += instance.OnPunch;
                @Punch.performed += instance.OnPunch;
                @Punch.canceled += instance.OnPunch;
                @Kick.started += instance.OnKick;
                @Kick.performed += instance.OnKick;
                @Kick.canceled += instance.OnKick;
                @Slash.started += instance.OnSlash;
                @Slash.performed += instance.OnSlash;
                @Slash.canceled += instance.OnSlash;
                @HeavySlash.started += instance.OnHeavySlash;
                @HeavySlash.performed += instance.OnHeavySlash;
                @HeavySlash.canceled += instance.OnHeavySlash;
                @Dust.started += instance.OnDust;
                @Dust.performed += instance.OnDust;
                @Dust.canceled += instance.OnDust;
                @Options.started += instance.OnOptions;
                @Options.performed += instance.OnOptions;
                @Options.canceled += instance.OnOptions;
                @Restart.started += instance.OnRestart;
                @Restart.performed += instance.OnRestart;
                @Restart.canceled += instance.OnRestart;
            }
        }
    }
    public FGControlsActions @FGControls => new FGControlsActions(this);
    public interface IFGControlsActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnI2(InputAction.CallbackContext context);
        void OnI8(InputAction.CallbackContext context);
        void OnI66(InputAction.CallbackContext context);
        void OnI66KB(InputAction.CallbackContext context);
        void OnI44(InputAction.CallbackContext context);
        void OnI44KB(InputAction.CallbackContext context);
        void OnPunch(InputAction.CallbackContext context);
        void OnKick(InputAction.CallbackContext context);
        void OnSlash(InputAction.CallbackContext context);
        void OnHeavySlash(InputAction.CallbackContext context);
        void OnDust(InputAction.CallbackContext context);
        void OnOptions(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
    }
}
