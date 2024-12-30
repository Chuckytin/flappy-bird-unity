using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    
    public GameObject pipePrefab; //Prefab de la tubería, se asigna desde el Inspector de Unity

    public float heightRange = 0.5f; //maxRange para la aparición de las tuberías

    public float maxTimeSpawn = 1.75f; //maxTime aparición tuberías

    private float timer; //temporizador entre la creación de las tuberías

    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        
        timer += Time.deltaTime; //Aumenta el temporizador con el tiempo que ha pasado desde el último fotograma

        if (timer > maxTimeSpawn)
        {
            SpawnPipe();

            timer = 0; //resetea el temporizador
        }
    }

    public void SpawnPipe()
    {
        //Calcula la posición de la nueva tubería, sumando un valor aleatorio dentro del rango
        Vector3 spawnPosition = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));

        //Crea la nueva tubería a la posición calculada y con rotación por defecto (Quaternion.identity)
        GameObject newPipe = Instantiate(pipePrefab, spawnPosition, Quaternion.identity);

        //Destruye la nueva tubería después de 12 segundos
        Destroy(newPipe, 12f);
    }
}
