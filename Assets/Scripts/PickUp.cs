using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform hand;
    public Transform firstPersHoldPos;

    bool colliding = false;
    bool pickedUp = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hand.childCount == 0)
        {
            pickedUp = false;
        }

        if(hand.childCount > 0)
        {
            pickedUp = true;
        }


        
        if(pickedUp == false)
        {
            if(colliding == true)
            {
                Debug.Log("No held item and in position to pick up");
                if(Input.GetKeyDown("e"))
                {
                    Debug.Log("Pressed button to pick up object");
                    PickUpObject();
                }
            }
            else
            {
                if(Input.GetKeyDown("e"))
                {
                    Debug.Log("Pressed button to pick up object, but not in position to pick up object");
                }
            }
        }
        else if(pickedUp == true)
        {
            if(Input.GetKeyDown("q"))
            {
                Debug.Log("Pressed button to put down object");
                PutDownObject();
            }
        }
        else
        {
            if(Input.GetKeyDown("q"))
            {
                Debug.Log("There is no held item");
            }
        }
        
    }

    void PickUpObject()
    {
        if(pickedUp == false)
        {
            if(GetComponent<Rigidbody>().isKinematic == false)
            {
                GetComponent<Collider>().enabled = false;
            }
        
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = hand.position;
            this.transform.parent = GameObject.Find("Hand").transform;

            pickedUp = true;

            Debug.Log("Object should be picked up");
        }
    }

    void PutDownObject()
    {
        if(this.transform.parent == hand.transform)
        {
            this.transform.position = firstPersHoldPos.position;
            this.transform.parent = null;
            GetComponent<Collider>().enabled = true;
            GetComponent<Rigidbody>().useGravity = true;

            pickedUp = false;

            Debug.Log("Object should be put down");
        
            colliding = false;
        }
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "PickUp")
        {
            Debug.Log("Entered pick up space");
            colliding = true;
            // if(Input.GetKeyDown("e"))
            // {
            //     Debug.Log("Pressed button to pick up object");
            //     PickUpObject();
            // }
        }
        else{
            Debug.Log("Entered other collider");
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "PickUp")
        {
            Debug.Log("left pick up space");
            colliding = false;
        }
    }
}
