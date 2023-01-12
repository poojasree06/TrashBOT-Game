using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideControl : MonoBehaviour
{

    // max left and right sides a player can move in the water
    public static float leftSide=335f;
    public static float rightSide=550f;
    public  float internalLeft;
    public  float internalRight;
    void Update()
    {
        internalLeft =leftSide;
        internalRight=rightSide;

    }

}
