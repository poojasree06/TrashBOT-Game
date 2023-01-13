using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingCoins : MonoBehaviour
{
    public int coins;

    void Start()
    {
        
    }
   public void OnTriggerEnter(Collider Col)
   {
     if(Col.gameObject.tag == "waste")
     {
       // Debug.Log("Waste Collected");
        //coins = coins+1;
        Col.gameObject.SetActive(false);
        Destroy(Col.gameObject);
        Score.instance.AddPoint();
     }
   }
   
    void Update()
    {
        
    }
}
