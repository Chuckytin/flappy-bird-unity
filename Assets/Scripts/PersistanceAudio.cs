using UnityEngine;

public class PersistanceAudio : MonoBehaviour
{
    private static PersistanceAudio instance;

    void Awake()
    {
        //Verificar si ya existe una instancia de este objeto.
        if (instance == null)
        {
            //Si no existe, esta instancia es la que debe persistir.
            instance = this;
            DontDestroyOnLoad(gameObject); // No destruir el objeto al cambiar de escena.
        }
        else
        {
            //Si ya existe una instancia, destruir este objeto para evitar duplicados.
            Destroy(gameObject);
        }
    }
}
