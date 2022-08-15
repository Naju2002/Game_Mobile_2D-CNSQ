using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirTask : MonoBehaviour
{
    public GameObject Panel;
    
    void OnMouseDown()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
        else
        {
            Panel.SetActive(false);
        }
    }
}
