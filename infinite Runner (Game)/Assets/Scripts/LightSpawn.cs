using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSpawn : MonoBehaviour
{
    float timer=3;// contador de segundos

    float dificultad = 6;// contador de dificultad

    public GameObject Light_01;
    public GameObject Light_02;
    public GameObject Light_03;

    float switcher=1;

    void Update(){// funcion update para los cambios constantes en enenmigos
        timer += Time.deltaTime;

        switcher = Random.Range(0, 4);

        if(dificultad <= 6f && dificultad >= 0.7f)// la dificultad ira creciendo conforme pasa el nivel
            dificultad -= 0.000001f ;// disminuyendo la cantidad de tiempo que debe esperar para generar un enemigo

        if(dificultad < 0.7f && dificultad >= 0.5f)// la dificultad no pasara de este limite
            dificultad -= 0.00000001f;// a no ser

        if(timer > dificultad){// condicional de tiempo (al reducir o aumentar el valor, aumenta la dificultad)
            Vector3 posi_luz = new Vector3(3f,0,0);// creamos el vector para posicionar el enemigo
            Quaternion rotate = new Quaternion();// creamos rotacion en un vector
            if(switcher<=1)
                Instantiate(Light_01,posi_luz,rotate);// instanciamos un enemigo en la posicion del vector, sin rotacion
            if(switcher>1 && switcher<=2)
                Instantiate(Light_02,posi_luz,rotate);// instanciamos un enemigo en la posicion del vector, sin rotacion
            if(switcher>2 && switcher<=3)
                Instantiate(Light_03,posi_luz,rotate);// instanciamos un enemigo en la posicion del vector, sin rotacion
            timer = 0;// regresamos el contador a 0
        }
    }
}
