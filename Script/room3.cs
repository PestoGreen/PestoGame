using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room3 : MonoBehaviour
{
    public GameObject dlp,grn,dlp2,grn2,rpman;
    // Start is called before the first frame update
    void Start()
    {

        //PlayerPrefs.SetInt("g2finish", 1);
        if (PlayerPrefs.GetInt("dlp") > 0)
        {
            dlp.SetActive(true);
            grn.SetActive(false);
            if (PlayerPrefs.GetInt("downstair") == 1)
            {
                dlp.SetActive(false);
                dlp2.SetActive(true);
            }
        }
        if (PlayerPrefs.GetInt("grn") == 1)
        {
            grn.SetActive(true);
            if (PlayerPrefs.GetInt("downstair") == 1)
            {
                grn.SetActive(false);
                grn2.SetActive(true);
            }
        }
        if (PlayerPrefs.GetInt("game1fin") == 1 || PlayerPrefs.GetInt("g2finish")==1 || PlayerPrefs.GetInt("g3finish") == 1)
        {
            rpman.SetActive(true);
        }
        else
        {
            rpman.SetActive(false);
        }
        //if (PlayerPrefs.GetInt("g3finish") == 1)
        //{
        //    rpman.SetActive(false);
        //    rpman2.SetActive(true);
        //}
        //else
        //{
        //    rpman2.SetActive(false);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
