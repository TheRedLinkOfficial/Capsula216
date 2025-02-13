using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monastro : MonoBehaviour
{

public int speedy = 5;
public int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

void mudar(){
    if (direction == 1){direction = 2;}
    else if (direction == 2){direction = 1;}
}


void OnTriggerEnter2D (Collider2D other){
if (other.gameObject.tag == "barreira"){
    mudar();}
else if (other.gameObject.tag == "anti"){
    Destroy(gameObject);
    }
}



    // Update is called once per frame
    void Update()
    {
        if (direction == 1){
            gameObject.transform.position += new Vector3(speedy*Time.deltaTime,0,0);
        }
        else if (direction == 2){
            gameObject.transform.position += new Vector3(-speedy*Time.deltaTime,0,0);
        }
    }
}
