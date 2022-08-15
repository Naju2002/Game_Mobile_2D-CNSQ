using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreTextM;
    public static int scoreNumberM;

    public string proximaCena;
    public AudioSource audioVitoria;

    void Start()
    {
        audioVitoria.Pause();
        PlayerPrefs.GetInt("ScoreM", scoreNumberM);
    }
    


    void Update()
    {

        PlayerPrefs.SetInt("ScoreM", scoreNumberM);
        scoreTextM.text = scoreNumberM.ToString();

        if (PlayerPrefs.GetInt("HighScoreM") < scoreNumberM)

            PlayerPrefs.SetInt("HighScoreM", scoreNumberM);

        if(scoreNumberM == 11)
        {
            StartCoroutine("Venceu");
        }
    }
    IEnumerator Venceu()
    {
        
        yield return new WaitForSeconds(0.10f);
        SceneManager.LoadScene(proximaCena);
        audioVitoria.Play();
    }

}
