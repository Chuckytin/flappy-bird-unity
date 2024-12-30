using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;

    private int score = 0;

    void Start()
    {
        //inicializa la puntuación actual y la mejor puntuación desde PlayerPrefs.
        score = 0;
        scoreText.text = score.ToString();
        bestScoreText.text = PlayerPrefs.GetInt("BestScore", 0).ToString();
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();

        UpdateBestScore(); //comprueba si hay que actualizar la mejor puntuación
    }

    public void UpdateBestScore()
    {

        int bestScore = PlayerPrefs.GetInt("BestScore", 0);

        if (score > bestScore)
        {
            PlayerPrefs.SetInt("BestScore", score); //guarda la nueva mejor puntuación
            PlayerPrefs.Save(); //guarda en el disco la puntuación
            bestScoreText.text = score.ToString();
        }
    }

}
