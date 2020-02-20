using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishGrower : MonoBehaviour
{
    //float startTime;
    float timer;

    bool timerUp = false;

    // Start is called before the first frame update
    void Start()
    {
        //startTime = Time.time;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.parent.parent.tag == "Slot")
        {
            timer += Time.deltaTime;
        }

        if(timer >= 5)
        {
            timerUp = true;
        }

        if(timerUp == true)
        {
            timer = 0;
            //this.transform.parent = null;
            this.transform.parent.GetComponent<DishFiller>().GrowDish();
        }
    }

}
