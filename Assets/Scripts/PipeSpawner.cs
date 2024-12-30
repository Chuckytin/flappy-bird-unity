using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    
    public GameObject pipePrefab; //Prefab de la tuber�a, se asigna desde el Inspector de Unity

    public float heightRange = 0.5f; //maxRange para la aparici�n de las tuber�as

    public float maxTimeSpawn = 1.75f; //maxTime aparici�n tuber�as

    private float timer; //temporizador entre la creaci�n de las tuber�as

    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        
        timer += Time.deltaTime; //Aumenta el temporizador con el tiempo que ha pasado desde el �ltimo fotograma

        if (timer > maxTimeSpawn)
        {
            SpawnPipe();

            timer = 0; //resetea el temporizador
        }
    }

    public void SpawnPipe()
    {
        //Calcula la posici�n de la nueva tuber�a, sumando un valor aleatorio dentro del rango
        Vector3 spawnPosition = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));

        //Crea la nueva tuber�a a la posici�n calculada y con rotaci�n por defecto (Quaternion.identity)
        GameObject newPipe = Instantiate(pipePrefab, spawnPosition, Quaternion.identity);

        //Destruye la nueva tuber�a despu�s de 12 segundos
        Destroy(newPipe, 12f);
    }
}
