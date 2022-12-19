using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Variable para controlar el tiempo en el que PacMan es invencible
    public float invincibleTime = 0.0f;

    //Creamos el Singleton del GameManager
    public static GameManager sharedInstance;

    private void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Hacemos que el contador de tiempo vaya decreciendo hasta que se vacíe
        //Si el contador aún no está vacío
        if (invincibleTime > 0)
        {
            //Usando el Time.deltaTime le restamos 1 cada segundo al contador, porque le restamos las partes proporcionales de ese segundo divididas en frames
            invincibleTime -= Time.deltaTime;
        }
    }

    //Es un método para inicializar el contador de tiempo de invencibilidad. Al llamarlo le pasamos ese tiempo por parámetro
    public void MakeInvincibleFor(float numberOfSeconds)
    {
        //Inicializamos el contador de tiempo de invencibilidad
        invincibleTime += numberOfSeconds;
    }
}
