using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateChanger : MonoBehaviour
{
    public GameObject State1;
    public GameObject State2;
    public GameObject State3;
    public GameObject State4;
    public GameObject State5;
    public GameObject State6;
    public GameObject Particles;

    // Start is called before the first frame update
    void Start()
    {
        State1.SetActive(true);
        State2.SetActive(false);
        State3.SetActive(false);
        State4.SetActive(false);
        State5.SetActive(false);
        State6.SetActive(false);
        Particles.SetActive(false);

        Invoke("Change1", 5.0f);
        Invoke("Change2", 10.0f);
        Invoke("Change3", 15.0f);
        Invoke("Change4", 20.0f);
        Invoke("Change5", 25.0f);

        Invoke("ParticleOff1", 7.5f); //turns the particles back off for each stage of upward growth
        Invoke("ParticleOff2", 12.5f);
        Invoke("ParticleOff3", 17.5f);
       
    }
    void Change1()
    {
        State1.SetActive(false);
        State2.SetActive(true);
        Particles.SetActive(true);
    
    }
    void ParticleOff1()
    {
        Particles.SetActive(false);
    }
    void Change2()
    {
        State2.SetActive(false);
        State3.SetActive(true);
        Particles.SetActive(true);
    }
        void ParticleOff2()
    {
        Particles.SetActive(false);
    }
        void Change3()
    {
        State3.SetActive(false);
        State4.SetActive(true);    
        Particles.SetActive(true);
    }
        void ParticleOff3()
    {
        Particles.SetActive(false);
    }
        void Change4()
    {
        State4.SetActive(false);
        State5.SetActive(true);
    }
        void Change5()
    {
        State5.SetActive(false);
        State6.SetActive(true);
    }

}
