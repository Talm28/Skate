using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TouchManager : MonoBehaviour
{
    public PenguinMovement _penguinMovement;

    private PlayerInput _playerInput;
    private InputAction _touchPress;

    private void Awake() {
        _playerInput = GetComponent<PlayerInput>();
        _touchPress = _playerInput.actions["TouchPress"];
        
    }

    private void OnEnable() {
       _touchPress.performed += _penguinMovement.Jump;
    }

    private void OnDisable() {
        _touchPress.performed -= _penguinMovement.Jump;
    }
}