using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anti : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
void OnCollisionEnter2D(Collision2D other){

    if(other.gameObject.tag == "monstro"){Destroy(gameObject);}
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
