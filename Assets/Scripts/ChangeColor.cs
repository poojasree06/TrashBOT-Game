using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer = 60;
    Score a;
    public Material[] material;
    Renderer rend;
    public TextMeshProUGUI timeText;

    void Start()
    {        
        rend=GetComponent<Renderer>();
        rend.enabled=true;
        rend.sharedMaterial=material[0];
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
    {
        if(a.score!=a.goal){
            Debug.Log("Change Color");
            rend.sharedMaterial=material[1];
        }  
    }

    }
}
