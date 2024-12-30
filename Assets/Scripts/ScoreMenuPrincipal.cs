using TMPro;
using UnityEngine;

public class ScoreMenuPrincipal : MonoBehaviour
{
   
    public TextMeshProUGUI bestScoreNumber; 

    private int score = 0; // Puntuaci�n actual.

    void Start()
    {
        //Al iniciar, muestra la mejor puntuaci�n guardada.
        int bestScore = PlayerPrefs.GetInt("BestScore", 0); //Obtiene la mejor puntuaci�n guardada.
        bestScoreNumber.text = bestScore.ToString();  //Muestra la mejor puntuaci�n.
    }

    public void UpdateScore()
    {
        score++;  
        UpdateBestScore();  //Comprueba si se debe actualizar la mejor puntuaci�n.
    }

    public void UpdateBestScore()
    {
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);  //Obtiene la mejor puntuaci�n guardada.

        //Si la puntuaci�n actual es mayor que la mejor puntuaci�n guardada:
        if (score > bestScore)
        {
            //Guarda la nueva mejor puntuaci�n.
            PlayerPrefs.SetInt("BestScore", score);
            PlayerPrefs.Save();  // Asegura que se guarde en el disco.

            //Actualiza el texto con la nueva mejor puntuaci�n.
            bestScoreNumber.text = score.ToString();
        }
    }
}
