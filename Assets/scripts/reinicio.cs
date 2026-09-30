using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reinicio : MonoBehaviour
{

    public GameObject ui;

    private void OnTriggerEnter(Collider collision)
    {
        // Versión para juegos en
        if (collision.CompareTag("Player"))
        {
            ui.SetActive(true);
        }
    }

    public void ReiniciarEscena()
    {
        // Carga de nuevo la escena activa actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
