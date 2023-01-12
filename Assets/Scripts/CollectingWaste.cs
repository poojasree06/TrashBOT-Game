using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingWaste : MonoBehaviour
{
    public int waste;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag=="waste")
        {
            Debug.Log("Waste collected..");
            waste=waste+1;
            //Col.gameObject.SetActive(false);
            Destroy(Col.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
