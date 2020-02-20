using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutPoint : MonoBehaviour
{

    //Transform parentTransform;
    //GameObject parentObj;
    //parentScript;

    bool beenCut = false;
    // Start is called before the first frame update
    void Awake()
    {
        //parentTransform = this.transform.parent;
        //parentObj = parentTransform.gameObject;
        //parentScript = this.transform.parent.gameObject.GetComponent<GillExtraction>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() 
    {
        Debug.Log("clicked");

        if(beenCut == false)
        {
            beenCut = true;
            //parentScript.UpdateCut();
            this.transform.parent.gameObject.GetComponent<GillExtraction>().UpdateCut();
        }
    }
}
