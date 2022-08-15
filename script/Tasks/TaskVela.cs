using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskVela : MonoBehaviour
{
    public GameObject PanelVenceu;
    private Animator animvela;
    public GameObject timer;
    public AudioSource audiovela;
    public AudioSource fogovela;
    void Start()
    {
        fogovela.Play();
        timer.SetActive(true);
        Timer.time = 20;
        PanelVenceu.SetActive(false);
        animvela = GetComponent<Animator>();

        animvela.SetInteger("velatesc", 0);
    }

   
    public void apagavela()
    {
        
        timer.SetActive(false);
        animvela.SetInteger("velatesc", 1);
        if(animvela == true)
        {
            GameManager.scoreNumberM++;
        }
      

        StartCoroutine("vela");
       

    }
    IEnumerator vela()
    {
        fogovela.Pause();
        // GameManager.scoreNumberM++;
        yield return new WaitForSeconds(0.6f);
        PanelVenceu.SetActive(true);
        audiovela.Play();
    }


}
