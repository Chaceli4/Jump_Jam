using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonChance : MonoBehaviour
{
    public ButtonName ButtonName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.tag)
        {
            case "Player":
            {
                    PlayerPrefs.SetInt(ButtonName.ToString(), 1);
                    break;
            }
        }
    }

}
