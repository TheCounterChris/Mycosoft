using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonHolder : MonoBehaviour
{
    public GameObject firstPersHoldPos;
    public Transform firstPersonHoldPosition;

    bool beingHeld = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
        // if(Input.GetMouseButtonDown(1))
        // {
        //     Debug.Log("Secondary Mouse Button Pressed");
        //     if(beingHeld == false)
        //     {
        //         Debug.Log("Picking up object");
        //         PickUp();
        //     }
        //     else if(beingHeld == true)
        //     {
        //         Debug.Log("Putting down object");
        //         PutDown();
        //     }
        //     else
        //     {
        //         Debug.Log("Your shit is broke bruh");
        //     }
        // }
        
    //}

    // private void OnMouseDown() 
    // {
    //     GetComponent<Rigidbody>().useGravity = false;
    //     this.transform.position = firstPersonHoldPosition.position;
    //     this.transform.parent = firstPersHoldPos.transform;
    // }

    void PickUp()
    {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = firstPersonHoldPosition.position;
        this.transform.parent = firstPersHoldPos.transform;
        Debug.Log("Picked up object");

        GetComponent<RotateObject>().enabled = true;

        beingHeld = true;
    }

    void PutDown()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        Debug.Log("Put down object");

        beingHeld = false;
    }

    private void OnMouseOver() 
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(beingHeld == false)
            {
                PickUp();
            }
            else if(beingHeld == true)
            {
                PutDown();
            }
            else
            {
                Debug.Log("yo shit broke");
            }
        }
        
    }
}
