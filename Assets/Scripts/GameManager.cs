using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject gameOverCanvas;
    public Button pauseButton;  //el botón que hará la pausa
    public Button resumeButton; //el botón de reanudar
    private bool isPaused = false;

    void Start()
    {
        Time.timeScale = 1; //Reinicia el juego
        
        //pauseButton.onClick.AddListener(PauseGame);  //añade el evento de clic al botón
        //Asegúrate de que el botón de reanudar solo esté visible cuando el juego está pausado
        //resumeButton.gameObject.SetActive(false); // Al inicio el botón de reanudar está desactivado
    }

    void Update()
    {
        //Si el Canvas de GameOver está activo, presionando Enter reinicia el juego
        if (gameOverCanvas.activeSelf && Input.GetKeyDown(KeyCode.Return)) 
        {
            Restart();
        }
    }

    void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0; //pausa el juego
        pauseButton.gameObject.SetActive(false); //desactiva el botón de pausa
        resumeButton.gameObject.SetActive(true); //activa el botón de reanudar
    }

    void ResumeGame()
    {
        isPaused = false;

        Time.timeScale = 1; //reanuda el juego
        pauseButton.gameObject.SetActive(true); //activa el botón de pausa
        resumeButton.gameObject.SetActive(false); //desactiva el botón de reanudar
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
