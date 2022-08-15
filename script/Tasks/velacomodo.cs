using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velacomodo : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animvelasala;
    // Start is called before the first frame update
    void Start()
    {
        animvelasala = GetComponent<Animator>();
        animvelasala.SetInteger("velasala", 0);
    }
    

    public void apagavelasala()
    {
        animvelasala.SetInteger("velasala", 1);    
    }
}
