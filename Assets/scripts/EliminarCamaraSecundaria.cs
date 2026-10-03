using UnityEngine;

public class EliminarCamaraSecundaria: MonoBehaviour
{

    



    private void Start()
    {
        Camera mainCam = Camera.main;
        if (mainCam != null && mainCam.gameObject != this.gameObject)
        {
            Destroy(gameObject);
        }
    }
}

