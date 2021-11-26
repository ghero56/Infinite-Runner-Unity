using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    public GameObject Mini,Big;

    int change = 0;

    void Start()
    {
        Big.gameObject.SetActive(true);
        Mini.gameObject.SetActive(false);
    }

    void Update(){// constante lectura
        if(Input.GetKey(KeyCode.Space))
            change = Chan(change);
    }

    int Chan(int chan){
        if(chan == 0){
            Big.gameObject.SetActive(false);
            Mini.gameObject.SetActive(true);
            chan = 1;
        }else{
            Big.gameObject.SetActive(true);
            Mini.gameObject.SetActive(false);
            chan = 0;
        }
        return chan;
    }
}
