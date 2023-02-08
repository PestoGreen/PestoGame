using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amap : MonoBehaviour
{
    public GameObject return1,teen,resi,grp;
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
        if (PlayerPrefs.GetInt("amapteen") == 1)
        {
            teen.SetActive(true);
        }
        if (PlayerPrefs.GetInt("amapresi") == 1)
        {
            resi.SetActive(true);
        }
        if (PlayerPrefs.GetInt("amapgrp") == 1)
        {
            grp.SetActive(true);
        }
        if (PlayerPrefs.GetInt("amapteen")==1 && PlayerPrefs.GetInt("amapgrp")==1 && PlayerPrefs.GetInt("amapresi") == 1)
        {
            PlayerPrefs.SetInt("amapfinish", 1);
            Debug.Log("kekeke");
        }
        if(PlayerPrefs.GetInt("amapfinish")==1 && PlayerPrefs.GetInt("bmapfinish")==1 && PlayerPrefs.GetInt("cmapfinish") == 1)
        {
            allfinish();
        }
        if (PlayerPrefs.GetInt("aTwin") == 1)
        {
            calculate.resilv += 1;
            PlayerPrefs.SetInt("aTwin", 0);
        }
        if (PlayerPrefs.GetInt("aRwin") == 1)
        {
            calculate.resilv += 1;
            PlayerPrefs.SetInt("aRwin", 0);
        }
        if (PlayerPrefs.GetInt("aGwin") == 1)
        {
            calculate.resilv += 1;
            PlayerPrefs.SetInt("aGwin", 0);
        }
        Debug.Log(calculate.resilv);
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
