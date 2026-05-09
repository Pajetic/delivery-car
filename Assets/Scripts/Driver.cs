using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] private float turnRate = 200f;
    [SerializeField] private float baseSpeed = 5f;
    [SerializeField] private float boostSpeed = 10f;
    [SerializeField] private float currentSpeed = 5f;

    // Update is called once per frame
    private void Update()
    {
        float move = 0f;
        float turn = 0f;
        
        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }
        
        if (Keyboard.current.aKey.isPressed)
        {
            turn = 1f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            turn = -1f;
        }
        
        float moveAmount = move * currentSpeed * Time.deltaTime;
        float turnAmount = turn * turnRate * Time.deltaTime;
        
        transform.Translate(new Vector3(0, moveAmount, 0));
        transform.Rotate(new Vector3(0, 0, turnAmount));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boost"))
        {
            currentSpeed = boostSpeed;
            Destroy(other.gameObject);
            Debug.Log("Boost");
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        currentSpeed = baseSpeed;
    }
}
