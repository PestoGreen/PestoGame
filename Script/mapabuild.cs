using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapabuild : MonoBehaviour
{
    public GameObject o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11, o12, o13,o14,o15,o16,o17,o18,o19;
    public GameObject start;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("emerg2fin") != 1)
        {
            if (PlayerPrefs.GetInt("noise") != 1)
            {
                Invoke("story", 2f);
                start.GetComponent<mapapolice>().enabled = true;
                calculate.money -= 1000;
            }
            else if (PlayerPrefs.GetInt("noise") == 1)
            {
                Invoke("story", 2f);
                start.GetComponent<mapapolice2>().enabled = true;
            }
        }
        else
        {
            Invoke("story", 2f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("o1") == 1)
        {
            o3.SetActive(true);
            o2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("o2") == 1)
        {
            o1.SetActive(true);
            o2.SetActive(true);

        }
        if (PlayerPrefs.GetInt("o3") == 1)
        {
            o4.SetActive(true);
            o6.SetActive(true);

        }
        if (PlayerPrefs.GetInt("o3") == 2)
        {
            o5.SetActive(true);
            o6.SetActive(true);

        }
        if (PlayerPrefs.GetInt("o4") == 1)
        {
            o10.SetActive(true);

        }
        if (PlayerPrefs.GetInt("o5") == 1)
        {
            o9.SetActive(true);

        }
        if (PlayerPrefs.GetInt("o6") == 1)
        {
            o7.SetActive(true);
            o8.SetActive(true);

        }
        if (PlayerPrefs.GetInt("o7") == 1)
        {
            o12.SetActive(true);

        }
        if (PlayerPrefs.GetInt("o8") == 1)
        {
            o15.SetActive(true);

        }
        if (PlayerPrefs.GetInt("o8") == 2)
        {
            o16.SetActive(true);

        }
        if (PlayerPrefs.GetInt("o9") == 1)
        {
            o13.SetActive(true);

        }
        if (PlayerPrefs.GetInt("o10") == 1)
        {
            o14.SetActive(true);

        }
        if (PlayerPrefs.GetInt("o11") == 1)
        {
            o11.SetActive(true);

        }
        if (PlayerPrefs.GetInt("o12") == 1)
        {
            o19.SetActive(true);

        }
        if (PlayerPrefs.GetInt("o13") == 1)
        {
            o18.SetActive(true);

        }
        if (PlayerPrefs.GetInt("o13") == 2)
        {
            o17.SetActive(true);

        }
    }
    void story()
    {
        start.SetActive(true);
    }
}
