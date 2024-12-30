using TMPro;
using UnityEngine;

public class ScoreMenuPrincipal : MonoBehaviour
{
   
    public TextMeshProUGUI bestScoreNumber; 

    private int score = 0; // Puntuación actual.

    void Start()
    {
        //Al iniciar, muestra la mejor puntuación guardada.
        int bestScore = PlayerPrefs.GetInt("BestScore", 0); //Obtiene la mejor puntuación guardada.
        bestScoreNumber.text = bestScore.ToString();  //Muestra la mejor puntuación.
    }

    public void UpdateScore()
    {
        score++;  
        UpdateBestScore();  //Comprueba si se debe actualizar la mejor puntuación.
    }

    public void UpdateBestScore()
    {
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);  //Obtiene la mejor puntuación guardada.

        //Si la puntuación actual es mayor que la mejor puntuación guardada:
        if (score > bestScore)
        {
            //Guarda la nueva mejor puntuación.
            PlayerPrefs.SetInt("BestScore", score);
            PlayerPrefs.Save();  // Asegura que se guarde en el disco.

            //Actualiza el texto con la nueva mejor puntuación.
            bestScoreNumber.text = score.ToString();
        }
    }
}
