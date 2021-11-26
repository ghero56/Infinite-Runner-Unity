using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg_spawn : MonoBehaviour
{
    float timer=3;// contador de segundos

    float dificultad = 10;// contador de dificultad

    public GameObject bg_01;
    public GameObject bg_02;
    public GameObject bg_03;
    public GameObject bg_04;

    float switcher=1;

    void Update(){// funcion update para los cambios constantes en enenmigos
        timer += Time.deltaTime;

        switcher = Random.Range(0, 5);

        if(dificultad <= 10f && dificultad >= 0.7f)// la dificultad ira creciendo conforme pasa el nivel
            dificultad -= 0.000001f ;// disminuyendo la cantidad de tiempo que debe esperar para generar un enemigo

        if(dificultad < 0.7f && dificultad >= 0.5f)// la dificultad no pasara de este limite
            dificultad -= 0.00000002f;// a no ser

        if(timer > dificultad){// condicional de tiempo (al reducir o aumentar el valor, aumenta la dificultad)
            Vector3 posi_luz = new Vector3(3f,0,0);// creamos el vector para posicionar el enemigo
            Quaternion rotate = new Quaternion();// creamos rotacion en un vector
            if(switcher<=1)
                Instantiate(bg_01,posi_luz,rotate);// instanciamos un enemigo en la posicion del vector, sin rotacion
            else if(switcher>1 && switcher<=2)
                Instantiate(bg_02,posi_luz,rotate);// instanciamos un enemigo en la posicion del vector, sin rotacion
            else if(switcher>2 && switcher<=3){
                posi_luz*=3;
                Instantiate(bg_03,posi_luz,rotate);// instanciamos un enemigo en la posicion del vector, sin rotacion
            }
            else if(switcher>3 && switcher<=4)
                Instantiate(bg_04,posi_luz,rotate);// instanciamos un enemigo en la posicion del vector, sin rotacion
            timer = 0;// regresamos el contador a 0
        }
    }
}
