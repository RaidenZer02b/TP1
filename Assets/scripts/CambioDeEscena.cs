using System.Collections; // Necesario para usar IEnumerator y Corrutinas
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{

    [Header("Configuración de Teletransporte")]
    [Tooltip("Escribe aquí el nombre exacto de la escena a la que quieres ir")]
    public string nombreEscenaDestino;

    [Tooltip("Etiqueta del objeto que activará el teletransporte (por defecto 'Player')")]
    public string tagDelJugador = "Player";

    [Tooltip("UI o menú que se mostrará al tocar la zona")]
    public GameObject uiAMostrar;

    [Tooltip("Tiempo en segundos que se mostrará la UI antes de cambiar de escena")]
    public float tiempoDeEspera = 2.0f;

    private bool cambiandoDeEscena = false;

    // Para juegos en 3D
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagDelJugador) && !cambiandoDeEscena)
        {
            StartCoroutine(CambiarEscenaConRetraso3D());
        }
    }

    private IEnumerator CambiarEscenaConRetraso3D()
    {
        cambiandoDeEscena = true;

        if (uiAMostrar != null)
        {
            uiAMostrar.SetActive(true);
        }

        // Espera la cantidad de segundos configurada
        yield return new WaitForSeconds(tiempoDeEspera);

        CargarSiguienteEscena();
    }

    /* Si tu juego es 2D, usa estos métodos en lugar de los de 3D:
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(tagDelJugador) && !cambiandoDeEscena)
        {
            StartCoroutine(CambiarEscenaConRetraso2D());
        }
    }

    private IEnumerator CambiarEscenaConRetraso2D()
    {
        cambiandoDeEscena = true;

        if (uiAMostrar != null)
        {
            uiAMostrar.SetActive(true);
        }

        yield return new WaitForSeconds(tiempoDeEspera);

        CargarPorNombre(nombreEscenaDestino);
    }
    */

    // Métodos anteriores
    public void CargarPorNombre(string nombreEscena) => SceneManager.LoadScene(nombreEscena);

    public void CargarPorIndice(int indiceEscena) => SceneManager.LoadScene(indiceEscena);

    public void CargarSiguienteEscena()
    {
        int indiceActual = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indiceActual + 1);
    }

    public void SalirDelJuego()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}