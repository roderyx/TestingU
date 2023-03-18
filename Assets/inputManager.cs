using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class inputManager : MonoBehaviour{

    // Variables to define in the editor
    [SerializeField]
    private int velocity;

    // Variables to get from the object
    private Rigidbody2D MyRigidbody;

    // Local variables
    private Vector2 MovementInput;
    private bool jumpPressed;

    // Start is called before the first frame update
    void Start()
    {
        MyRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove(InputValue value){
        MovementInput = value.Get<Vector2>();
    }

    void OnJump(InputValue value){
        jumpPressed = value.isPressed;
    }
}
