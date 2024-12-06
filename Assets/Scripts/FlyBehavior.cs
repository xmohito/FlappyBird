using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlyBehavior : MonoBehaviour
{
    [SerializeField] private float _velocity = 1.5f;
    [SerializeField] private float _rotationSpeed = 10f;

    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {

        if(Keyboard.current.spaceKey.wasPressedThisFrame) {
            _rb.velocity = Vector2.up * _velocity;
        }
    }

    private void FixedUpdate() {

        transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        GameManager.instance.GameOver();
    }
}
