using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TomadaDaSala : MonoBehaviour
{
    public GameObject tampaDaTomada, tampaDaTomadaBlack;

    public GameObject PanelVenceu;

    public GameObject  timer;

   public int score;

   //public string Perde;

    Vector3 initialTampaDaTomadaPosition;

    bool tampaDaTomadaBool = false;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;


    void Start()
    {
        timer.SetActive(true);
        Timer.time = 20;
        PanelVenceu.SetActive(false);
        ScoreTomadaSala.scoreNumber = 0;
        initialTampaDaTomadaPosition = tampaDaTomada.transform.position;
    }
    public void DragTampa()
    {
        tampaDaTomada.transform.position = Input.mousePosition;
    }
    public void DropTampa()
    {
        float distance = Vector3.Distance(tampaDaTomada.transform.position, tampaDaTomadaBlack.transform.position);
        if (distance < 50)
        {
            tampaDaTomada.transform.position = tampaDaTomadaBlack.transform.position;
            ScoreTomadaSala.scoreNumber += 1;
            tampaDaTomadaBool = true;
            if (tampaDaTomadaBool == true)
            {
                GameManager.scoreNumberM++;
            }
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            tampaDaTomada.transform.position = initialTampaDaTomadaPosition;
            source.clip = incorrect;
            source.Play();
        }
    }

    void LateUpdate()
    {
        if (ScoreTomadaSala.scoreNumber >= 1)
        {
            //Destroy(timer);
            timer.SetActive(false);
            PanelVenceu.SetActive(true);
        }
        
    }

}
