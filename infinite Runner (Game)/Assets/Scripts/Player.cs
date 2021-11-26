using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour{

    public GameManager mang; // renombramos el GameManager

    public int scoreInt = 0;
    public Text scoreText;

    Vector2 moveInput; // vector de dos ejes
    public float speed = 100; // velocidad del presonaje

    Rigidbody2D RigidB; // se le da el atributo Rigidbody2D
    public Collider2D collision;

    public Joystick touch;

    void Start(){ // al iniciar el juego
        collision = GetComponent<Collider2D>();
        RigidB = GetComponent<Rigidbody2D>();
    }

    void Update() => moveInput.y = touch.Vertical;// le soy los valores verticales a la parte 'y' de el vector "moveInput"

    void FixedUpdate(){ // a cada rato sin tener que realizar todo
        RigidB.velocity = moveInput * speed * Time.fixedDeltaTime;// movemos al jugador con una cierta velocidad
        if(Time.deltaTime<1){
            if(scoreInt<=1000){
                scoreInt+=1;
            }
            else if(scoreInt>=1000 && scoreInt<=2000){
                scoreInt+=2;
            }
            else if(scoreInt>=2000 && scoreInt<=4000){
                scoreInt+=5;
            }
            else if(scoreInt>=4000 && scoreInt<=5000){
                scoreInt+=10;
            }
            else if(scoreInt>=5000){
                scoreInt+=20;
            }
        }
        SendScore(scoreInt);
    }

    public void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Finish")
            mang.Return();
    }

    public void SendScore(int entero){
        scoreText.text = (entero/100).ToString();
    }
}
