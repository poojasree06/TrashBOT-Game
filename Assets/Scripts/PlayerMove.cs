using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    public float moveSpeed=100f; // player speed to move forward
    public float leftRightSpeed=210f; // player speed to move left and right
    void Start()
    {
        Debug.Log("Game Started");
    }

    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*moveSpeed,Space.World); // translating the player in the space

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
    }
}
