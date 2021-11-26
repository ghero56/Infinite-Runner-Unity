using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ligthmovement : MonoBehaviour
{
    Rigidbody2D Cuerpo;// le damos los atributos de cuerpo rigido

    public GameObject objeto;

    Vector2 Movement;// vector movimiento

    int i = 10;

    void Start(){
        Cuerpo = GetComponent<Rigidbody2D>();
        Movement.x = -20;
    }

    void Update(){
        if(Time.deltaTime > i){
            Cuerpo.velocity *= 5;
            i+=10;
        }
        Cuerpo.velocity = Movement * Time.deltaTime;
    }

    void OnBecameInvisible(){
        GameObject.Destroy(objeto);
    }
}
