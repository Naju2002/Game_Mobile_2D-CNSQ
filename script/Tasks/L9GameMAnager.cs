using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L9GameMAnager : MonoBehaviour {

    public GameObject tampa, tampaBlack;

    public GameObject PanelVenceu;

    public GameObject timer;

    public int score;

    public string Perde;

    Vector3 initialTampaPosition;

    bool tampaBool = false;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;


    void Start()
    {
        timer.SetActive(true);
        Timer.time = 20;
        PanelVenceu.SetActive(false);
        Score.scoreNumber = 0;
        initialTampaPosition = tampa.transform.position;
    }
    public void DragTampa()
    {
        tampa.transform.position = Input.mousePosition;
    }
    public void DropTampa()
    {
        float distance = Vector3.Distance(tampa.transform.position, tampaBlack.transform.position);
        if (distance < 50)
        {
            tampa.transform.position = tampaBlack.transform.position;
            Score.scoreNumber += 1;
            tampaBool = true;
            if (tampaBool == true)
            {
                GameManager.scoreNumberM++;
            }
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            tampa.transform.position = initialTampaPosition;
            source.clip = incorrect;
            source.Play();
        }
    }

    void LateUpdate()
    {
        if (Score.scoreNumber >= 1)
        {
            //Destroy(timer);
            timer.SetActive(false);
            PanelVenceu.SetActive(true);
        }

    }
}
