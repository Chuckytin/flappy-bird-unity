using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject gameOverCanvas;
    public Button pauseButton;  //el bot�n que har� la pausa
    public Button resumeButton; //el bot�n de reanudar
    private bool isPaused = false;

    void Start()
    {
        Time.timeScale = 1; //Reinicia el juego
        
        //pauseButton.onClick.AddListener(PauseGame);  //a�ade el evento de clic al bot�n
        //Aseg�rate de que el bot�n de reanudar solo est� visible cuando el juego est� pausado
        //resumeButton.gameObject.SetActive(false); // Al inicio el bot�n de reanudar est� desactivado
    }

    void Update()
    {
        //Si el Canvas de GameOver est� activo, presionando Enter reinicia el juego
        if (gameOverCanvas.activeSelf && Input.GetKeyDown(KeyCode.Return)) 
        {
            Restart();
        }
    }

    void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0; //pausa el juego
        pauseButton.gameObject.SetActive(false); //desactiva el bot�n de pausa
        resumeButton.gameObject.SetActive(true); //activa el bot�n de reanudar
    }

    void ResumeGame()
    {
        isPaused = false;

        Time.timeScale = 1; //reanuda el juego
        pauseButton.gameObject.SetActive(true); //activa el bot�n de pausa
        resumeButton.gameObject.SetActive(false); //desactiva el bot�n de reanudar
    }

    public void GameOver()
    { 
        gameOverCanvas.SetActive(true); //activa el Canvas "GameOver"
        Time.timeScale = 0; //pausa el juego
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //carga la escena actual para reiniciar el juego
    }

}
