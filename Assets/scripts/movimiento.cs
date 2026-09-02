using UnityEngine;
using UnityEngine.InputSystem;

public class movimiento : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float speed; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.IsPressed()) 

        {
            rigidbody.AddForce(Vector3.forward* Time.fixedDeltaTime * speed, ForceMode.Impulse);
        }

        if (Keyboard.current.dKey.IsPressed())

        {
            rigidbody.AddForce(Vector3.left * Time.fixedDeltaTime * speed, ForceMode.Impulse);
        }
        if (Keyboard.current.aKey.IsPressed())

        {
            rigidbody.AddForce(Vector3.right * Time.fixedDeltaTime * speed, ForceMode.Impulse);
        }

        if (Keyboard.current.sKey.IsPressed())

        {
            rigidbody.AddForce(Vector3.back * Time.fixedDeltaTime * speed, ForceMode.Impulse);
        }

        if (Keyboard.current.spaceKey.IsPressed())
        {
            rigidbody.AddForce(Vector3.up * Time.fixedDeltaTime * speed, ForceMode.Impulse);
        }
    }
}
