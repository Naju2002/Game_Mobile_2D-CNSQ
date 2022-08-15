using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text text;
    public static float time;
   
    public string Perde;

    void Start()
    {
        time =20;
    }

    void Update()
    {
        time -= Time.deltaTime;
        text.text = "" + Mathf.Round(time);

        if (time <= 10)
        {
            text.color = Color.red;
        }

        if (Timer.time <= 1)
        {
           // text.text = "0";
            SceneManager.LoadScene(Perde);
        }
         
    }
}
