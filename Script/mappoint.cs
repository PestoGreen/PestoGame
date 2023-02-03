using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mappoint : MonoBehaviour
{
    public GameObject point1, point2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("dlpstoryfinish") == 0)
        {
            point1.SetActive(true);
            point2.SetActive(false);
        }
        if (PlayerPrefs.GetInt("dlpstoryfinish") == 1)
        {
            point1.SetActive(false);
            point2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("gototaxi") == 1)
        {
            point1.SetActive(false);
            point2.SetActive(false);
        }
        if (PlayerPrefs.GetInt("g2finish") == 1)
        {
            point1.SetActive(false);
            point2.SetActive(true);
        }
        if(PlayerPrefs.GetInt("g3intro") == 1)
        {
            point1.SetActive(true);
            point2.SetActive(false);
        }
        if(PlayerPrefs.GetInt("g3finish") == 1)
        {
            point1.SetActive(false);
            point2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("g4intro") == 1)
        {
            point1.SetActive(true);
            point2.SetActive(false);
        }
    }
}
