using UnityEngine;

public class CamaraPersistente:MonoBehaviour

  


{
    private static CamaraPersistente instancia;

    private void Awake()
    {
        // Si ya existe una cámara persistente, destruimos los duplicados que aparezcan al cambiar de escena
        if (instancia != null && instancia != this)
        {
            Destroy(gameObject);
            return;
        }

        // Marcar esta cámara para que NO se destruya al cambiar de escena
        instancia = this;
        DontDestroyOnLoad(gameObject);
    }
}

