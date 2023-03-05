using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Game : MonoBehaviour
{
    public float deger;
    public Text skor;
    public int puan = 3;



    void Start()
    {
        puan = 3;
    }


    void Update()
    {
        skor.text = deger.ToString("f0");
    }

    void OnCollisionEnter(Collision temas)
    {
        if (temas.gameObject.tag == "varil") 
        {
            deger -= 1;
        }
        if(temas.gameObject.tag == "varil")
        {
            puan--;
        }
        if(puan <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
       
    }

}
