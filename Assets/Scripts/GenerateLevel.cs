using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos=4450; // starting position of river terrain gamesection
    public bool creatingGameSection =false;
    public int sectionNum; // game section number
    void Update()
    {
        if(creatingGameSection==false){
            creatingGameSection=true;
            StartCoroutine(GenerateSection());
        }
    }
 // generating endless game section to play
    IEnumerator GenerateSection(){
          sectionNum=Random.Range(0,3);
          Instantiate(section[sectionNum],new Vector3(0,0,zPos),Quaternion.identity);
          zPos+=50;
          yield return new WaitForSeconds(10); // waiting time to generate new section
          creatingGameSection=false;

    }
}
