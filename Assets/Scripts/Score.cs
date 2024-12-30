using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;

    private int score = 0;

    void Start()
    {
        //inicializa la puntuaci�n actual y la mejor puntuaci�n desde PlayerPrefs.
        score = 0;
        scoreText.text = score.ToString();
        bestScoreText.text = PlayerPrefs.GetInt("BestScore", 0).ToString();
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();

        UpdateBestScore(); //comprueba si hay que actualizar la mejor puntuaci�n
    }

    public void UpdateBestScore()
    {

        int bestScore = PlayerPrefs.GetInt("BestScore", 0);

        if (score > bestScore)
        {
            PlayerPrefs.SetInt("BestScore", score); //guarda la nueva mejor puntuaci�n
            PlayerPrefs.Save(); //guarda en el disco la puntuaci�n
            bestScoreText.text = score.ToString();
        }
    }

}
