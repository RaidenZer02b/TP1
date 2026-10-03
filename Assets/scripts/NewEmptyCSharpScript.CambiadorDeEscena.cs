using UnityEngine;
using UnityEngine.SceneManagement;

public partial class NewEmptyCSharpScript { }



    

    public class CambiadorDeEscena : MonoBehaviour
    {
        [Header("Configuración de Teletransporte")]
        [Tooltip("Escribe aquí el nombre exacto de la escena a la que quieres ir")]
        public string nombreEscenaDestino;

        [Tooltip("Etiqueta del objeto que activará el teletransporte (por defecto 'Player')")]
        public string tagDelJugador = "Player";

        // Para juegos en 3D
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(tagDelJugador))
            {
                CargarPorNombre(nombreEscenaDestino);
            }
        }

        /* Si tu juego es 2D, usa este método en lugar del anterior:
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag(tagDelJugador))
            {
                CargarPorNombre(nombreEscenaDestino);
            }
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


 
