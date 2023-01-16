using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{

    private static BackgroundMusic instance = null;       //Created an instance for the class and made it private and later added getter function to use it in another script
    public static BackgroundMusic Instance               // getter function to access background music
    {
        get { return instance; }
    }

    void Awake()                                   // this function applies before start of the game to initialize the variables
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);              // if current sound!=bg sound destroy
            return;
        }
        else
        {
            instance = this;                       // else initialize it to current sound
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
