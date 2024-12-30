using UnityEngine;

public class FlappyBird : MonoBehaviour
{

    public float velocity = 2f;
    public Rigidbody2D rigidbody2D;

    public float rotationSpeed = 25;

    public AudioSource audioSource;

    void Start()
    {
        
    }

    
    void Update()
    {
        //detecta clic izquierdo o tecla Espacio
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) 
        {
            //Aplica una velocidad hacia arriba
            rigidbody2D.linearVelocity = Vector2.up * velocity;

            //Resetea la rotación para que no se siga girando al saltar
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        //rotaci�n del p�jaro independientemente de la velocidad de fotogramas
        transform.rotation = Quaternion.Euler(0, 0, rigidbody2D.linearVelocity.y * rotationSpeed * Time.deltaTime * 100);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindAnyObjectByType<GameManager>().GameOver();
        audioSource.Play();
    }
}
