using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishFiller : MonoBehaviour
{

    public GameObject emptyDish;
    public GameObject fullDish;
    public GameObject grownDish;

    public GameObject gills;

    public void fillDish()
    {
        emptyDish.SetActive(false);
        fullDish.SetActive(true);

        gills.SetActive(false);
    }

    public void GrowDish()
    {
        fullDish.SetActive(false);
        grownDish.SetActive(true);
        //grownDish.transform.parent = this.transform;
    }
}
