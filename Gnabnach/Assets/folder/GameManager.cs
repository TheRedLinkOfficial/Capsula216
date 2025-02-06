using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{public int Moedas;
private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        Moedas = FindObjectsOfType<Coin>().Length;
        TryGetComponent(out source);
    }


public void SubtrairCoins(int valor){

    Moedas -= valor;

}

    // Update is called once per frame
    void Update()
    {
        
    }
}
