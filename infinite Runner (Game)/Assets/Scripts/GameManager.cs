using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject menu; // objeto menu de pausa para activar o desactivar

    public GameObject game; // juego principal

    void FixedUpdate(){// comprobar a cada momento
        if(Input.GetKeyDown(KeyCode.Escape)){// presionamos ESC
            if(Time.timeScale==0){// si es verdadero el menu de pausa
                Resume();// regresamos
            }else{// si es falso
                Pausar();// activamos la funcion de pausa
            }
        }
    }

    public void Return(){// funcion return para regresar al menu
        SceneManager.LoadScene(0);// llamamos al menu principal
        Time.timeScale = 1;// reactivamos el tiempo en caso de hacerlo desde el menu de pausa
    }

    public void Iniciar(){// funcion que llama al juego
        menu.SetActive(false);
        game.SetActive(true);
        Time.timeScale = 1;// en dado caso de reiniciar el juego desde el menu de pausa
    }

    public void Resume(){// regresar
        menu.SetActive(false);// desactivamos el menu
        game.SetActive(true);
        Time.timeScale = 1;// escala de tiempo en 1
    }

    public void Pausar(){ // pausa el juego
        Time.timeScale = 0;// escala de tiempo en 0
        game.SetActive(false); // se pausa el juego
        menu.SetActive(true); // activamos el menu de pausa
    }

    public void Cerrar() => Application.Quit();// cierra definitivamente el juego
}
