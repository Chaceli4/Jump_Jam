using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadIn : MonoBehaviour
{
    public ButtonName ButtonName;
    public GameObject Victory;
    public GameObject Loss;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt(ButtonName.ToString()) == 1)
        {
            Victory.SetActive(false);
            Loss.SetActive(true);
        }
        else
        {
            Victory.SetActive(true);
            Loss.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
