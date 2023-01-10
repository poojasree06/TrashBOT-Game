using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideControl : MonoBehaviour
{

    // max left and right sides a player can move in the water
    public static float leftSide=280f;
    public static float rightSide=1100f;
    public  float internalLeft;
    public  float internalRight;
    void Update()
    {
        internalLeft =leftSide;
        internalRight=rightSide;

    }

}
