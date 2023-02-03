using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class g4choosing : MonoBehaviour
{
    int i, j, k;
    public GameObject sure;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        j = 0;
        k = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (i == 1 && j == 1 && k == 1)
        {
            sure.GetComponent<Button>().interactable = enabled;
        }
    }
    public void e1()
    {
        PlayerPrefs.SetInt("eng", 1);
        i = 1;
    }
    public void e2()
    {
        PlayerPrefs.SetInt("eng", 2);
        i = 1;
    }
    public void e3()
    {
        PlayerPrefs.SetInt("eng", 3);
        i = 1;
    }
    public void e4()
    {
        PlayerPrefs.SetInt("eng", 4);
        i = 1;
    }
    public void a1()
    {
        PlayerPrefs.SetInt("acc", 1);
        j = 1;
    }
    public void a2()
    {
        PlayerPrefs.SetInt("acc", 2);
        j = 1;
    }
    public void a3()
    {
        PlayerPrefs.SetInt("acc", 3);
        j = 1;
    }
    public void m1()
    {
        PlayerPrefs.SetInt("mng", 1);
        k = 1;
    }
    public void m2()
    {
        PlayerPrefs.SetInt("mng", 2);
        k = 1;
    }
    public void insure()
    {
        PlayerPrefs.SetInt("insure", 1);
    }
    public void cancelinsure()
    {
        PlayerPrefs.SetInt("insure", 0);
    }
    public void bonus()
    {
        PlayerPrefs.SetInt("bonus", 1);
    }
    public void cancelbonus()
    {
        PlayerPrefs.SetInt("bonus", 0);
    }
    public void lincense()
    {
        PlayerPrefs.SetInt("license", 1);
    }
    public void cancellincense()
    {
        PlayerPrefs.SetInt("license", 0);
    }
}
