using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pick : MonoBehaviour
{
    public Animator tbtn, dbtn, gbtn, tintro, dintro, gintro;
    // Start is called before the first frame update
    void Start()
    {
        //if (PlayerPrefs.GetInt("teen") == 1)
        //{
        //    SceneManager.LoadScene("sc1");
        //}
        PlayerPrefs.DeleteAll();
        calculate.money = 10000;
        calculate.grnlv = 0;
        calculate.resilv = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void teen()
    {
        dbtn.SetBool("pressed", true);
        tbtn.SetBool("cls", false);
        dbtn.SetBool("cls", false);
        gbtn.SetBool("cls", false);
        gbtn.SetBool("pressed", true);
        tintro.SetBool("pressed", true);
    }
    public void teencls()
    {
        dbtn.SetBool("pressed", false);
        tbtn.SetBool("cls", true);
        dbtn.SetBool("cls", true);
        gbtn.SetBool("cls", true);
        gbtn.SetBool("pressed", false);
        tintro.SetBool("pressed", false);
    }
    public void teenok()
    {
        PlayerPrefs.SetInt("teen", 1);
        SceneManager.LoadScene("Room1");
    }
    public void developer()
    {
        dbtn.SetBool("pressed2", true);
        tbtn.SetBool("cls", false);
        dbtn.SetBool("cls", false);
        gbtn.SetBool("cls", false);
        tbtn.SetBool("pressed2", true);
        gbtn.SetBool("pressed", true);
        dintro.SetBool("pressed", true);
    }
    public void dlpcls()
    {
        dbtn.SetBool("pressed2", false);
        tbtn.SetBool("cls", true);
        dbtn.SetBool("cls", true);
        gbtn.SetBool("cls", true);
        tbtn.SetBool("pressed2", false);
        gbtn.SetBool("pressed", false);
        dintro.SetBool("pressed", false);
    }
    public void dlpok()
    {
        PlayerPrefs.SetInt("dlp", 1);
        SceneManager.LoadScene("Room2");
    }
    public void government()
    {
        gbtn.SetBool("pressed2", true);
        tbtn.SetBool("cls", false);
        gbtn.SetBool("cls", false);
        dbtn.SetBool("cls", false);
        tbtn.SetBool("pressed2", true);
        dbtn.SetBool("pressed", true);
        gintro.SetBool("pressed", true);
    }
    public void gcls()
    {
        gbtn.SetBool("pressed2", false);
        tbtn.SetBool("cls", true);
        gbtn.SetBool("cls", true);
        dbtn.SetBool("cls", true);
        tbtn.SetBool("pressed2", false);
        dbtn.SetBool("pressed", false);
        gintro.SetBool("pressed", false);
    }
    public void grnok()
    {
        PlayerPrefs.SetInt("grn", 1);
        SceneManager.LoadScene("Room3");
    }
}
