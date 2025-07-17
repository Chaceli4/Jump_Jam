using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetVariable : MonoBehaviour
{   
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt(ButtonName.One.ToString(), 0);
        PlayerPrefs.SetInt(ButtonName.Two.ToString(), 0);
        PlayerPrefs.SetInt(ButtonName.Three.ToString(), 0);
    }

}

public enum ButtonName
{
    One, 
    Two, 
    Three
}

