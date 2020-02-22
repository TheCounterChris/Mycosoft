using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class UISwitcher : MonoBehaviour
{
    public GameObject UI1;
    public GameObject UI2;
    public Collider Character;

    // Start is called before the first frame update
    void OnTriggerStay()
    {
    if (Input.GetButtonDown ("Interact"))
    //  if (UISwitch != null)
    {
        UISwitch();
    }
    }
    void UISwitch()
    {
        if (Character.isTrigger)
        {
            UI1.GetComponent<Canvas>().enabled =false;
            UI2.SetActive(true);
        }
    }


}
