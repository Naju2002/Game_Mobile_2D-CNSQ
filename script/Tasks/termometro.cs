using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class termometro : MonoBehaviour
{
    public GameObject PanelVenceu;
    public Text Graus;
    private int grausvalor;
    public AudioSource certo;
   
    // public int score;
    // private Menu Mn;
    void Start()
    {
        grausvalor = 37;
        while (grausvalor >= 36 & grausvalor <= 38)
        {
            grausvalor = Random.Range(1, 50);

        }

        //int grausvalor = Random.Range(1, 6);

        // Graus.text = "48";
        PanelVenceu.SetActive(false);
        Graus.text = grausvalor.ToString();
        
    }

    public void aumenta()
    {
        //  grausvalor++;

        grausvalor = grausvalor + 1;
        if (grausvalor > 50)
        {
            grausvalor = 50;
        }
        Graus.text = grausvalor.ToString();
    }

    public void abaixa()
    {
        // grausvalor--;

        grausvalor = grausvalor - 1;
        if (grausvalor < -5)
        {
            grausvalor = -5;
        }
        Graus.text = grausvalor.ToString();

    }
    private void Update()
    {
        if (grausvalor >= 29 & grausvalor <= 39)
        {
            Graus.color = Color.white;
        }
        if (grausvalor <= 29)
        {
            Graus.color = Color.cyan;
        }

        if (grausvalor >= 39)
        {
            Graus.color = Color.red;
        }

        if (grausvalor >= 36 & grausvalor <= 38)
        {
            Graus.color = Color.green;
        }
    }

 

    IEnumerator Ponto()
    {          
        yield return new WaitForSeconds(0.1f);
        PanelVenceu.SetActive(true);      
    }

    public void ganha()
    {
        if (grausvalor >= 36 & grausvalor <= 38)
        {
            GameManager.scoreNumberM++;
            certo.Play();
            StartCoroutine("Ponto");
        }
        
      //  if (grausvalor != 37)
      //  {
       //     print
       // }

    }

}
