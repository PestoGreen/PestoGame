using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class test : MonoBehaviour
{
    public GameObject t10;
    public GameObject t11;
    public GameObject t12;
    public GameObject t13;
    public GameObject t14;
    public GameObject t15;
    public GameObject t16;
    public GameObject t17;
    public GameObject t18;
    public GameObject t19;
    public GameObject t20;
    public GameObject t21;
    public GameObject t22;
    public GameObject t23;
    public GameObject t24;
    public GameObject t25;
    public GameObject t26;
    public GameObject t27;
    public GameObject t28;
    public GameObject t29;
    public GameObject t30;
    public GameObject t31;
    public GameObject t32;
    public GameObject t33;
    public GameObject t34;
    public GameObject t35;
    public GameObject t36;
    public GameObject t37;
    public GameObject t38;
    public GameObject t39;
    public GameObject t40;
    public GameObject t41;
    public GameObject t42;
    public GameObject t43;
    public GameObject t44;
    public GameObject t45;
    public GameObject t46;
    public GameObject t47;
    public GameObject t48;
    public GameObject t49;
    public GameObject t50;
    public GameObject t51;
    public GameObject blackanimation;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localPosition.y >= -2540)
        {
            t10.SetActive(true);
        }
        if (transform.localPosition.y >= -2400)
        {
            t11.SetActive(true);
        }
        if (transform.localPosition.y >= -2260)
        {
            t12.SetActive(true);
        }
        if (transform.localPosition.y >= -2120)
        {
            t13.SetActive(true);
        }
        if (transform.localPosition.y >= -1980)
        {
            t14.SetActive(true);
        }
        if (transform.localPosition.y >= -1840)
        {
            t15.SetActive(true);
        }
        if (transform.localPosition.y >= -1700)
        {
            t16.SetActive(true);
        }
        if (transform.localPosition.y >= -1560)
        {
            t17.SetActive(true);
        }
        if (transform.localPosition.y >= -1420)
        {
            t18.SetActive(true);
        }
        if (transform.localPosition.y >= -1280)
        {
            t19.SetActive(true);
        }
        if (transform.localPosition.y >= -1140)
        {
            t20.SetActive(true);
        }
        if (transform.localPosition.y >= -1000)
        {
            t21.SetActive(true);
        }
        if (transform.localPosition.y >= -860)
        {
            t22.SetActive(true);
        }
        if (transform.localPosition.y >= -720)
        {
            t23.SetActive(true);
        }
        if (transform.localPosition.y >= -580)
        {
            t24.SetActive(true);
        }
        if (transform.localPosition.y >= -440)
        {
            t25.SetActive(true);
        }
        if (transform.localPosition.y >= -300)
        {
            t26.SetActive(true);
        }
        if (transform.localPosition.y >= -160)
        {
            t27.SetActive(true);
        }
        if (transform.localPosition.y >= -20)
        {
            t28.SetActive(true);
        }
        if (transform.localPosition.y >= 120)
        {
            t29.SetActive(true);
        }
        if (transform.localPosition.y >= 260)
        {
            t30.SetActive(true);
        }
        if (transform.localPosition.y >= 400)
        {
            t31.SetActive(true);
        }
        if (transform.localPosition.y >= 540)
        {
            t32.SetActive(true);
        }
        if (transform.localPosition.y >= 680)
        {
            t33.SetActive(true);
        }
        if (transform.localPosition.y >= 820)
        {
            t34.SetActive(true);
        }
        if (transform.localPosition.y >= 960)
        {
            t35.SetActive(true);
        }
        if (transform.localPosition.y >= 1100)
        {
            t36.SetActive(true);
        }
        if (transform.localPosition.y >= 1240)
        {
            t37.SetActive(true);
        }
        if (transform.localPosition.y >= 1380)
        {
            t38.SetActive(true);
        }
        if (transform.localPosition.y >= 1520)
        {
            t39.SetActive(true);
        }
        if (transform.localPosition.y >= 1660)
        {
            t40.SetActive(true);
        }
        if (transform.localPosition.y >= 1800)
        {
            t41.SetActive(true);
        }
        if (transform.localPosition.y >= 1940)
        {
            t42.SetActive(true);
        }
        if (transform.localPosition.y >= 2080)
        {
            t43.SetActive(true);
        }
        if (transform.localPosition.y >= 2220)
        {
            t44.SetActive(true);
        }
        if (transform.localPosition.y >= 2360)
        {
            t45.SetActive(true);
        }
        if (transform.localPosition.y >= 2500)
        {
            t46.SetActive(true);
        }
        if (transform.localPosition.y >= 2640)
        {
            t47.SetActive(true);
        }
        if (transform.localPosition.y >= 2780)
        {
            t48.SetActive(true);
        }
        if (transform.localPosition.y >= 2920)
        {
            t49.SetActive(true);
        }
        if (transform.localPosition.y >= 3060)
        {
            t50.SetActive(true);
        }
        if (transform.localPosition.y >= 3120)
        {
            t51.SetActive(true);
            Invoke("animationplay", 2f);
        }
    }

    void animationplay()
    {
        blackanimation.SetActive(true);
        Invoke("csc", 1.5f);
        
    }
    void csc()
    {
        SceneManager.LoadScene("Room2");
        PlayerPrefs.SetInt("dlp", 1);
        PlayerPrefs.SetInt("g5intro", 1);
        PlayerPrefs.SetInt("momtext", 1);
        PlayerPrefs.SetInt("notice", 1);
    }
}
