using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class midleSpawn : MonoBehaviour
{
    float timer=10;// contador de segundos

    float dificultad = 10;// contador de dificultad

    public GameObject Mid_01;
    public GameObject Mid_02;
    public GameObject Mid_03;
    public GameObject Mid_04;

    float switcher=1;

    void Update(){
        timer += Time.deltaTime;

        switcher = Random.Range(0, 5);

        if(dificultad <= 10f && dificultad >= 0.7f)// la dificultad ira creciendo conforme pasa el nivel
            dificultad -= 0.000001f ;// disminuyendo la cantidad de tiempo que debe esperar para generar un enemigo

        if(dificultad < 0.7f && dificultad >= 0.5f)// la dificultad no pasara de este limite
            dificultad -= 0.00000001f;// a no ser

        if(timer > dificultad){// condicional de tiempo (al reducir o aumentar el valor, aumenta la dificultad)
            Vector3 posi_luz = new Vector3(6f,0,0);// creamos el vector para posicionar el enemigo
            Quaternion rotate = new Quaternion();// creamos rotacion en un vector
            if(switcher<=1)
                Instantiate(Mid_01,posi_luz,rotate);// instanciamos un arbol_01 en la posicion del vector, sin rotacion
            if(switcher>1 && switcher<=2)
                Instantiate(Mid_02,posi_luz,rotate);// instanciamos un arbol_02 en la posicion del vector, sin rotacion
            if(switcher>2 && switcher<=3){
                posi_luz*=3;
                Instantiate(Mid_03,posi_luz,rotate);// instanciamos un arbol_03 en la posicion del vector, sin rotacion
            }
            if(switcher>3 && switcher<=4)
                Instantiate(Mid_04,posi_luz,rotate);// instanciamos un arbol_04 en la posicion del vector, sin rotacion
            timer = 0;// regresamos el contador a 0
        }
    }
}
