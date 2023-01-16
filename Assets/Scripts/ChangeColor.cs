using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
/* changing water color to black indicating water pollution */

public class ChangeColor : MonoBehaviour
{
  
    public float timer = 60; 
    Score a; // screen score
    public Material[] material; // array of color materials
    Renderer rend;       // water component in the game
    void Start()
    {        
        rend=GetComponent<Renderer>();
        rend.enabled=true;
        rend.sharedMaterial=material[0];       // initial water color
        a = FindObjectOfType<Score>();
        
    }

    // Update is called once per frame
    void Update(){
        Change();
    }
    public void Change(){

     if(timer > 0){
        timer -= Time.deltaTime;
    }
    else                                 
    /* after completion of 60 seconds if the player didn't reac the goal then change the water color */
    {
        if(a.score!=a.goal){
            Debug.Log("Change Color");
            rend.sharedMaterial=material[1];
        }  
    }

    }
}
