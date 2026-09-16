using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    public void ChangeCurrentScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
