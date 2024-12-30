using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void QuitGame()
    { 
        Application.Quit();
        Debug.Log("El juego se ha cerrado.");
    }

}
