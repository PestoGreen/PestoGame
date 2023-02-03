using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class g4fin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sure()
    {
        if (PlayerPrefs.GetInt("eng") == 1)
        {
            calculate.money -= 1500;
        }
        else if (PlayerPrefs.GetInt("eng") == 2)
        {
            calculate.money -= 900;
        }
        else if (PlayerPrefs.GetInt("eng") == 3)
        {
            calculate.money -= 1500;
        }
        else if (PlayerPrefs.GetInt("eng") == 4)
        {
            calculate.money -= 1000;
        }
        if (PlayerPrefs.GetInt("acc") == 1)
        {
            calculate.money -= 1450;
        }
        else if (PlayerPrefs.GetInt("acc") == 2)
        {
            calculate.money -= 1150;
        }
        else if (PlayerPrefs.GetInt("acc") == 3)
        {
            calculate.money -= 1300;
        }
        if (PlayerPrefs.GetInt("mng") == 1)
        {
            calculate.money -= 1800;
        }
        else if (PlayerPrefs.GetInt("mng") == 2)
        {
            calculate.money -= 1800;
        }
        if (PlayerPrefs.GetInt("insure") == 1)
        {
            calculate.money -= 600;
        }
        if (PlayerPrefs.GetInt("bonus") == 1)
        {
            calculate.money -= 400;
        }
        if (PlayerPrefs.GetInt("license") == 1)
        {
            calculate.money -= 500;
        }
        PlayerPrefs.SetInt("g4finish", 1);
        PlayerPrefs.SetInt("employees", 0);
        //PlayerPrefs.SetInt("notice", 1);
        PlayerPrefs.SetInt("g4intro", 0);
        SceneManager.LoadScene("dlpdicuss");
        calculate.money += 2500;
        Debug.Log(calculate.money);
    }
}
