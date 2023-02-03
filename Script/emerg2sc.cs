using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emerg2sc : MonoBehaviour
{
    public GameObject sc;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("green") != 1)
        {
            sc.SetActive(true);
            sc.GetComponent<emerg2talk2>().enabled = true;
        }
        else if (PlayerPrefs.GetInt("green") == 1)
        {
            sc.SetActive(true);
            sc.GetComponent<emerg2talk>().enabled = true;
            calculate.resilv += 1;
            calculate.grnlv += 4;
            if (PlayerPrefs.GetInt("ggreen") == 1)
            {
                calculate.money += 300;
            }
            else if (PlayerPrefs.GetInt("ggreen") == 2)
            {
                calculate.money += 600;
            }
            else if (PlayerPrefs.GetInt("ggreen") == 3)
            {
                calculate.money += 900;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
