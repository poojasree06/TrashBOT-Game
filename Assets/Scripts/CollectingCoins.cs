using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Collecting coins is nothing but collecting waste items */
public class CollectingCoins : MonoBehaviour
{
    public int coins;                      // counter for score (i.e no.of waste collected)

   public void OnTriggerEnter(Collider Col)       // Collider function 
   {
     if(Col.gameObject.tag == "waste")            // if collision happens with material tagged as waste 
     {
       // Debug.Log("Waste Collected");
        Col.gameObject.SetActive(false);
        Destroy(Col.gameObject);                   // Destroy that material
        Score.instance.AddPoint();                 // and increament counter by 1 i.e by calling the increament function from score.cs script
     }
   }
   
    void Update()
    {
        
    }
}
