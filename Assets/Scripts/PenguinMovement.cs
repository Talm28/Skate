using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PenguinMovement : MonoBehaviour
{
    [SerializeField] private float _jumpPower;
    [SerializeField] private int _jumpAmount;

    private Rigidbody2D _rb;
    private int _currJumpAmout;

    private void Awake() {
        _rb = GetComponent<Rigidbody2D>(); 
    }

    private void Start() {
        _currJumpAmout = _jumpAmount;
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (_currJumpAmout > 0)
        {
            _currJumpAmout--;
            // Reset rigidbody velocity
            _rb.velocity = Vector2.zero;
            _rb.AddForce(new Vector2(0,_jumpPower));
        }
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // If the penguin hit the floor reset the jumps number
        if(other.gameObject.tag == "Floor")
            _currJumpAmout = _jumpAmount;
    }
}
