using UnityEngine;

public class PipeScore : MonoBehaviour
{

    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //si colisiona el Player con el box collider en modo Trigger, encuentra el Score y llama al método UpdateScore
        if (collision.CompareTag("Player"))
        { 
            FindAnyObjectByType<Score>().UpdateScore();
            audioSource.Play(); //se activa el sonido
        }
    }

}
