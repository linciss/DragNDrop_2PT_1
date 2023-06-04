using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AinasMaina : MonoBehaviour {

    public GameObject panel;
    public bool spelesStatus = false;

    //pauzē spēli
    public void pause()
    {
       panel.SetActive(true);
        spelesStatus = false;
    }

    // sāk spēli
    public void saktSpeli()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
        spelesStatus = true;
    }

    //turpina speli
    public void turpinatSpeli()
    {
        panel.SetActive(false);
        spelesStatus = true;
    }

    //aptur speli
    public void Apturet()
    {
        Application.Quit();
    }


}
