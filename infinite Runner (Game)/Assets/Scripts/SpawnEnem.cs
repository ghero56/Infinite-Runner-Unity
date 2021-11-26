using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnEnem : MonoBehaviour
{
    public int Cant_enemy = 0;// cantidad de enenmigos

    public Text score;// variable de tipo texto

    public string pun_tex;// variable ca

    public int puntaje = 1;

    float timer;// contador de segundos

    float dificultad = 3;// contador de dificultad

    public GameObject Enemy;// Buscamos un objeto enemigo

    void Update(){// funcion update para los cambios constantes en enenmigos
        timer += Time.deltaTime*2;

        if(dificultad <= 3f && dificultad >= 0.7f)// la dificultad ira creciendo conforme pasa el nivel
            dificultad -= 0.0001f ;// disminuyendo la cantidad de tiempo que debe esperar para generar un enemigo

        if(dificultad < 0.7f && dificultad >= 0.5f)// la dificultad no pasara de este limite
            dificultad -= 0.001f;// a no ser

        if(dificultad < 0.5f && dificultad >= 0.3f)// la dificultad no pasara de este limite
            dificultad -= 0.01f;// a no ser

        if(timer > dificultad){// condicional de tiempo (al reducir o aumentar el valor, aumenta la dificultad)
            float y = Random.Range(-0.2f, 1.8f);// creo el flotante y para recibir
            Vector3 posi_enem = new Vector3(2f,y,0);// creamos el vector para posicionar el enemigo
            Quaternion rotate = new Quaternion();// creamos rotacion en un vector
            Instantiate(Enemy,posi_enem,rotate);// instanciamos un enemigo en la posicion del vector, sin rotacion
            timer = 0;// regresamos el contador a 0
        }
    }

    public void Puntos(){
        puntaje *= (int)(Time.fixedDeltaTime + 100);
        score.text = puntaje.ToString();
    }
}
