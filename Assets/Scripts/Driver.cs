using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnRate = 100f;
    [SerializeField] float moveSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
        
        float moveAmount = move * moveSpeed * Time.deltaTime;
        float turnAmount = turn * turnRate * Time.deltaTime;
        
        transform.Translate(new Vector3(0, moveAmount, 0));
        transform.Rotate(new Vector3(0, 0, turnAmount));
    }
}
