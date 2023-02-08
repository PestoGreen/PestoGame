using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cmap : MonoBehaviour
{
    public GameObject return1, teen, resi, grp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("return") == 1)
        {
            return1.SetActive(true);
            PlayerPrefs.SetInt("return", 0);
        }
        if (PlayerPrefs.GetInt("cmapteen") == 1)
        {
            teen.SetActive(true);
        }
        if (PlayerPrefs.GetInt("cmapresi") == 1)
        {
            resi.SetActive(true);
        }
        if (PlayerPrefs.GetInt("cmapgrp") == 1)
        {
            grp.SetActive(true);
        }
        if (PlayerPrefs.GetInt("cmapteen") == 1 && PlayerPrefs.GetInt("cmapgrp") == 1 && PlayerPrefs.GetInt("cmapresi") == 1)
        {
            PlayerPrefs.SetInt("cmapfinish", 1);
            Debug.Log("kekekeke");

        }
        if (PlayerPrefs.GetInt("amapfinish") == 1 && PlayerPrefs.GetInt("bmapfinish")==1 && PlayerPrefs.GetInt("cmapfinish") == 1)
        {
            allfinish();
        }
        if (PlayerPrefs.GetInt("cTwin") == 1)
        {
            calculate.resilv += 1;
            PlayerPrefs.SetInt("cTwin", 0);
        }
        if (PlayerPrefs.GetInt("cRwin") == 1)
        {
            calculate.resilv += 1;
            PlayerPrefs.SetInt("cRwin", 0);

        }
    }
    void allfinish()
    {
        Debug.Log("tepppp");
        PlayerPrefs.SetInt("amapfinish", 0);
        PlayerPrefs.SetInt("bmapfinish", 0);
        PlayerPrefs.SetInt("cmapfinish", 0);
        PlayerPrefs.SetInt("g2finish", 1);
        PlayerPrefs.SetInt("g2fin", 1);
        PlayerPrefs.SetInt("notice", 1);
        PlayerPrefs.SetInt("taxiready", 0);
    }
}
