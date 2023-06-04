using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpelesBeigas : MonoBehaviour {

	// Use this for initialization
	public AinasMaina aina;
	public Objekti objekti;
	public GameObject beiguEkrans;
	public Text laikaTeksts;
    public GameObject[] zvaigznes;
    

	public float laiks = 0f;
	string teksts;
    TimeSpan t;
    
    


    // Update is called once per frame
    void Update () {
        Debug.Log(laiks);
        //ja statuss ir true, tad spēle turpinās
        if (!aina.spelesStatus)
			return;

        // ja objekti ir vairāk par 12, tad spēle beidzas
		if (objekti.nomestasMasinas >= 12)
		{
            aina.spelesStatus = false;
            beiguEkrans.SetActive(true);
            raditZvaigznes(laiks);
            t = TimeSpan.FromSeconds(laiks);
            teksts = string.Format("{0}:{1}:{2}", ((int)t.TotalHours), t.Minutes, t.Seconds);
            laikaTeksts.text = "Laiks: " + teksts;
			return;
		}

        laiks += Time.deltaTime;
      
    }


    //nosaka zvaigžņu skaitu un parāda tās
    public void raditZvaigznes(float laiks)
    {

        if (laiks <= 120)
        {
            for (int i = 0; i < 3; i++)
            {
                zvaigznes[i].SetActive(true);
            }
        
        }
        if (laiks > 120 && laiks <= 180)
        {
            for(int i =0; i< 2; i++)
            {
                zvaigznes[i].SetActive(true);
            }
        }
        else
        {
            zvaigznes[0].SetActive(true);
        }


    }

}
