using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    [SerializeField] float moveSpeed=10f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Started");
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject();
    }

    void MoveObject(){
        float xVal=Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float zVal=Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
        transform.Translate(xVal,0,zVal);
    }
}
