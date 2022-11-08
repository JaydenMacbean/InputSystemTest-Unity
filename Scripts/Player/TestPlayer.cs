using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class TestPlayer : MonoBehaviour
{
     
    public CharacterAttributes characterStats;    
    FGController fgcontroller;
    

    [SerializeField] private Vector2 moveInput;
    private Rigidbody RB;

    [SerializeField] private InputActionReference actionReference;
    [SerializeField] private bool firstTap;

    private void Awake() 
    {

        #region Controls


        fgcontroller = new FGController();
        fgcontroller.FGControls.Enable();

        fgcontroller.FGControls.I8.performed += ctx => Jump();
        fgcontroller.FGControls.I2.performed += ctx => Crouch();
        fgcontroller.FGControls.I44.performed += ctx => Backdash();

        var sixSix = new InputAction();
        //sixSix.AddBinding("<Gamepad>/D-Pad").WithInteraction(""); 

        if(actionReference.action.interactions.Contains("Tap") && actionReference.action.interactions.Contains("Hold"))
        {
            actionReference.action.performed += ctx =>
            {
                /*switch (ctx)
                {
                    case ctx.interaction is TapInteraction:

                        firstTap = true;
                        break;

                    case ctx.interaction is HoldInteraction:

                        Run2();
                        break;

                }*/

                if(ctx.interaction is TapInteraction)
                {
                    firstTap = true;
                    Debug.Log("First tap is pressed");
                }

                else if (ctx.interaction is HoldInteraction && firstTap == true)
                {
                    Debug.Log("Second tap is pressed");
                    Run2();
                }
            };

            
        }
        
        
        

        #endregion

        RB = GetComponent<Rigidbody>();

        switch (characterStats.characterWeight)
        {
            
            case "L":
                characterStats.characterWeight = "Lightweight";
                Debug.Log("This character's a lightweight!");
                break;

            case "M":
                characterStats.characterWeight = "Mediumweight";
                Debug.Log("This character's a mediumweight!");
                break;
                 
            case "H":
                characterStats.characterWeight = "Heavyweight";
                Debug.Log("This character's a heavyweight!");
                break;

            
        }
            
        

    }

    private void Start()
    {
        characterStats.isBlockingAllowed = true;
        characterStats.isRunningAllowed = true;
        firstTap = false;
    }

    private void FixedUpdate()
    {
        TestWalk();

        
        
    }

    void OnEnable()
    {
        fgcontroller.FGControls.Enable();
        actionReference.action.Enable();
    }

    void OnDisable()
    {
        fgcontroller.FGControls.Disable();
    }

    void Jump()
    {
        Debug.Log("Jumping up");
    }

    void Crouch()
    {
        Debug.Log("Crouching down");
    }

    void TestWalk()
    {
        moveInput = fgcontroller.FGControls.Walk.ReadValue<Vector2>();
        RB.velocity = moveInput * characterStats.walkSpeed;
        if(moveInput != Vector2.zero)
        {
            Debug.Log("Justice invuln walk lololo");
        }

        
    }

    /*void Walk(Vector2 walkCtx)
    {
        Debug.Log("Walking forward");

        walkCtx = fgcontroller.FGControls.Walk.ReadValue<Vector2>();
        float targetedSpeed = moveInput.x * characterStats.walkSpeed;
        float speedDif = targetedSpeed - RB.velocity.x;

        RB.AddForce(speedDif * Vector2.right, ForceMode.Force);
    }*/

    private void Run()
    {
    }

    public void Run2()
    {
        Debug.Log("Running forward, can't block rn");

        moveInput = fgcontroller.FGControls.I66.ReadValue<Vector2>();
        RB.velocity = moveInput * characterStats.initialRunSpeed;
    }

    void Backdash()
    {
        Debug.Log("Backdash Pot Buster");
    }

    void Flip()
    {

    }
    
    

}
