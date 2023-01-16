using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    public float moveSpeed=50f; // player speed to move forward
    public float leftRightSpeed=150f; // player speed to move left and right
    public float timer = 60;
    Score a;                        // display score
    void Start()
    {
        Debug.Log("Game Started");
         a = FindObjectOfType<Score>();  // getting the score object
    }

    void Update()
    {
        /*translating the player in the space*/

        transform.Translate(Vector3.forward*Time.deltaTime*moveSpeed,Space.World); 
      

        /*Getting left and right inputs from the keyboard*/

        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
            if(this.gameObject.transform.position.x>SideControl.leftSide){
                transform.Translate(Vector3.left*Time.deltaTime*leftRightSpeed);
            }
        } 
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)){
            if(this.gameObject.transform.position.x<SideControl.rightSide){
                transform.Translate(Vector3.right*Time.deltaTime*leftRightSpeed);
            }
        } 

        /* stopping the player movement after 60 seconds of time*/

        if(timer>0){
            timer -= Time.deltaTime;
        }
        else{
            if(a.score!=a.goal){
                moveSpeed=0;
                leftRightSpeed=0;
            }
        }
    }
}
