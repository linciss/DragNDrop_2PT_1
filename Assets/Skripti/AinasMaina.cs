using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AinasMaina : MonoBehaviour {

    //aiziet uz sakum ekranu
    public void UzSakumu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    //aiziet uz speles ainu
    public void UzSpelesAinu()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }


    //aptur speli
    public void Apturet()
    {
        Application.Quit();
    }
}
