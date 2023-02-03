using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class toolbarcontroll : MonoBehaviour
{
    public Animator settingsani,scheduleani,phonebtnani,phoneani,settingpage,smallmap;
    public GameObject close,toolbar,toolbtn2,settingbtn,textpage,notice,noticeontool,noticeonphone;
    public GameObject noticetext, noticetext2, noticetext3, noticetext4, noticetext5, noticetext6, noticetext7,noticetext8,noticetext9,noticetext10,noticetext11,noticetext12, noticetext13;
    public GameObject money1, rhrt, ghrt;
    public int money2,rhrt2,ghrt2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("g5intro") == 2)
        {
            PlayerPrefs.SetInt("gotog5", 1);
            noticetext8.SetActive(true);
            
        }
        money2 = calculate.money;
        rhrt2 = calculate.resilv;
        ghrt2 = calculate.grnlv;
        money1.GetComponent<Text>().text =""+ money2;
        rhrt.GetComponent<Text>().text = "" + rhrt2;
        ghrt.GetComponent<Text>().text = "" + ghrt2;
        if (PlayerPrefs.GetInt("notice") == 1)
        {
            noticeontool.SetActive(true);
        }
    }
    public void toolbarpressed()
    {
        if (PlayerPrefs.GetInt("notice") == 1)
        {
            PlayerPrefs.SetInt("notice", 0);
            noticeontool.SetActive(false);
        }
        if (PlayerPrefs.GetInt("dlpstory1") == 1)
        {
            notice.SetActive(true);
            noticeonphone.SetActive(true);
        }
        if (PlayerPrefs.GetInt("game1fin") == 1)
        {
            notice.SetActive(true);
            noticeonphone.SetActive(true);
        }
        if (PlayerPrefs.GetInt("taxiready") == 1)
        {
            notice.SetActive(true);
            noticeonphone.SetActive(true);
        }
        if (PlayerPrefs.GetInt("g2fin") == 1)
        {
            notice.SetActive(true);
            noticeonphone.SetActive(true);
        }
        if (PlayerPrefs.GetInt("g3intro") == 1)
        {
            notice.SetActive(true);
            noticeonphone.SetActive(true);
        }
        if (PlayerPrefs.GetInt("designmes") == 1)
        {
            notice.SetActive(true);
            noticeonphone.SetActive(true);
        }
        if (PlayerPrefs.GetInt("employees") == 1)
        {
            notice.SetActive(true);
            noticeonphone.SetActive(true);
        }
        if (PlayerPrefs.GetInt("g5intro") == 1)
        {
            notice.SetActive(true);
            noticeonphone.SetActive(true);
        }
        if(PlayerPrefs.GetInt("emerg")<4 && PlayerPrefs.GetInt("emerg") > 0)
        {
            notice.SetActive(true);
            noticeonphone.SetActive(true);
        }
        if (PlayerPrefs.GetInt("emerg2mes") == 1)
        {
            notice.SetActive(true);
            noticeonphone.SetActive(true);
        }
        if (PlayerPrefs.GetInt("emerg2fin") == 1)
        {
            notice.SetActive(true);
            noticeonphone.SetActive(true);
        }
        close.SetActive(true);
        toolbar.SetActive(false);
        settingsani.SetBool("ispressed", true);
        scheduleani.SetBool("ispressed", true);
        phonebtnani.SetBool("ispressed", true);
        smallmap.SetBool("ispressed", true);
    }
    public void clsbtnpressed()
    {
        toolbar.SetActive(true);
        close.SetActive(false);
        toolbtn2.SetActive(false);
        //settingbtn.SetActive(true);
        settingsani.SetBool("ispressed", false);
        scheduleani.SetBool("ispressed", false);
        settingpage.SetBool("ispressed", false);
        phonebtnani.SetBool("ispressed", false);
        phoneani.SetBool("ispressed", false);
        textpage.SetActive(false);
        noticeonphone.SetActive(false);
        smallmap.SetBool("ispressed", false);
    }
    public void settings()
    {
        toolbtn2.SetActive(true);
        textpage.SetActive(false);
        //settingbtn.SetActive(false);
        scheduleani.SetBool("ispressed", false);
        settingpage.SetBool("ispressed", true);
        phoneani.SetBool("ispressed", false);
    }
    public void phone()
    {
        phoneani.SetBool("ispressed", true);
        scheduleani.SetBool("ispressed", false);
        settingpage.SetBool("ispressed", false);
    }
    public void toolbtn2pressed()
    {
        toolbtn2.SetActive(false);
        textpage.SetActive(false);
        //settingbtn.SetActive(true);
        scheduleani.SetBool("ispressed", true);
        settingpage.SetBool("ispressed", false);
        phoneani.SetBool("ispressed", false);
    }

    public void g5taxi()
    {
        PlayerPrefs.SetInt("g5intro", 2);
    }
    public void textbtn()
    {
        textpage.SetActive(true);
        noticeonphone.SetActive(false);
        notice.SetActive(false);
        if(PlayerPrefs.GetInt("dlpstory1") == 1)
        {
            noticetext.SetActive(true);
        }
        else
        {
            noticetext.SetActive(false);
        }
        if (PlayerPrefs.GetInt("game1fin") == 1)
        {
            noticetext2.SetActive(true);
        }
        else
        {
            noticetext2.SetActive(false);
        }
        if (PlayerPrefs.GetInt("taxiready") == 1)
        {
            noticetext3.SetActive(true);
        }
        else
        {
            noticetext3.SetActive(false);
        }
        if (PlayerPrefs.GetInt("g2fin") == 1)
        {
            noticetext4.SetActive(true);
        }
        else
        {
            noticetext4.SetActive(false);
        }
        if (PlayerPrefs.GetInt("g3intro") == 1)
        {
            noticetext5.SetActive(true);
        }
        else
        {
            noticetext5.SetActive(false);
        }
        if (PlayerPrefs.GetInt("designmes") == 1)
        {
            noticetext6.SetActive(true);
        }
        else
        {
            noticetext6.SetActive(false);
        }
        if (PlayerPrefs.GetInt("employees") == 1)
        {
            noticetext7.SetActive(true);
        }
        else
        {
            noticetext7.SetActive(false);
        }
        if (PlayerPrefs.GetInt("g5intro") == 1)
        {
            noticetext8.SetActive(true);
        }

        if (PlayerPrefs.GetInt("emerg") == 1)
        {
            noticetext9.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("emerg") == 2)
        {
            noticetext10.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("emerg") == 3)
        {
            noticetext11.SetActive(true);
        }
        else
        {
            noticetext11.SetActive(false);
            noticetext9.SetActive(false);
            noticetext10.SetActive(false);
        }
        if (PlayerPrefs.GetInt("emerg2mes") == 1)
        {
            noticetext12.SetActive(true);
        }
        else
        {
            noticetext12.SetActive(false);
        }
        if (PlayerPrefs.GetInt("emerg2fin") == 1)
        {
            noticetext13.SetActive(true);
        }
        else
        {
            noticetext13.SetActive(false);
        }
    }
}
