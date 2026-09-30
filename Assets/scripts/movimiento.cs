using UnityEngine;
using UnityEngine.InputSystem;

public class movimiento : MonoBehaviour
{
    public Rigidbody rigidbody;
    public bool jump;
    public float speed;
    public float jumpforce;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.IsPressed())

        {
            rigidbody.AddForce(Vector3.forward * Time.fixedDeltaTime * speed, ForceMode.Impulse);
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

        if (Keyboard.current.spaceKey.IsPressed() && jump)
        {
            rigidbody.AddForce(Vector3.up  * jumpforce, ForceMode.Impulse);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        // Detecta si choca contra un objeto con un nombre específico
        if (collision.gameObject.tag == "piso")
        {
            jump = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        // Detecta si choca contra un objeto con un nombre específico
        if (collision.gameObject.tag == "piso")
        {
            jump = false;
        }
    }

}
