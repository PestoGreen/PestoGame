using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public GameObject player,player2,player3,p22,p23,p24, smallmap;
    //public float currentTime;
    public float camsize;
    public bool sizeok,p1,p2,p3,p1ok,p2ok,p3ok;
    public GameObject blk;
    public GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("firsttime") != 1)
        {
            cam.GetComponent<Animator>().enabled = true;
        }
        else
        {
            cam.GetComponent<Animator>().enabled = false;
            GetComponent<Camera>().orthographicSize = 15;
            smallmap.SetActive(true);
            if (PlayerPrefs.GetInt("teen") >= 1)
            {
                p1ok = true;
            }
            if (PlayerPrefs.GetInt("dlp") >= 1)
            {
                p2ok = true;
            }
            if (PlayerPrefs.GetInt("grn") >= 1)
            {
                p3ok = true;
            }
        }
        if (PlayerPrefs.GetInt("teen") == 1)
        {
            p1 = true;
        }
        if (PlayerPrefs.GetInt("dlp") == 1)
        {
            p2 = true;
        }
        if (PlayerPrefs.GetInt("grn") == 1)
        {
            p3 = true;
        }
        //PlayerPrefs.DeleteAll();
        player.GetComponent<playermovement>().enabled = true;
        player2.GetComponent<playermovement>().enabled = true;
        player3.GetComponent<playermovement>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

        //currentTime = Time.time;
        //GetComponent<Camera>().orthographicSize = 100 - currentTime * 10;
        if (GetComponent<Camera>().orthographicSize < 15)
        {
            GetComponent<Camera>().orthographicSize = 15;
            sizeok = true;
            blk.SetActive(true);
            PlayerPrefs.SetInt("firsttime",1);
            Invoke("sm", 1.8f);

        }
        if (sizeok == true && p1 == true)
        {
            Invoke("delayp1", 1.5f);
        }
        if(p1ok == true)
        {
            player.SetActive(true);
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        }
        if (sizeok == true && p2 == true)
        {
            Invoke("delayp2", 1.5f);
        }
        if (p2ok == true)
        {
            player2.SetActive(true);
            transform.position = new Vector3(player2.transform.position.x, player2.transform.position.y, -10);
            if (PlayerPrefs.GetInt("dlp") == 2)
            {
                player2.SetActive(false);
                p22.SetActive(true);
                p23.SetActive(false);
                p24.SetActive(false);
                transform.position = new Vector3(p22.transform.position.x, p22.transform.position.y, -10);
            }
            if (PlayerPrefs.GetInt("dlp") == 3)
            {
                player2.SetActive(false);
                p22.SetActive(false);
                p23.SetActive(true);
                p24.SetActive(false);
                transform.position = new Vector3(p23.transform.position.x, p23.transform.position.y, -10);
            }
            if (PlayerPrefs.GetInt("dlp") == 4)
            {
                player2.SetActive(false);
                p22.SetActive(false);
                p23.SetActive(false);
                p24.SetActive(true);
                transform.position = new Vector3(p24.transform.position.x, p24.transform.position.y, -10);
            }
        }
        if (sizeok == true && p3 == true)
        {
            Invoke("delayp3", 1.5f);
        }
        if (p3ok == true)
        {
            player3.SetActive(true);
            transform.position = new Vector3(player3.transform.position.x, player3.transform.position.y, -10);
        }
    }
    public void delayp1()
    {
        p1ok = true;
    }
    public void delayp2()
    {
        p2ok = true;
    }
    public void delayp3()
    {
        p3ok = true;
    }
    void sm()
    {
        smallmap.SetActive(true);
    }
}
