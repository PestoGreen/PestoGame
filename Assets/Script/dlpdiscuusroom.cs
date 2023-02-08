using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dlpdiscuusroom : MonoBehaviour
{
    public GameObject  dlpd,box,designer,employee,newemp,script;
    
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("g3intro") == 1)
        {
            dlpd.SetActive(false);
            box.SetActive(false);
            designer.SetActive(true);
            //script.SetActive(false);
        }
        else
        {
            box.SetActive(true);
            designer.SetActive(false);
        }
        if (PlayerPrefs.GetInt("g4intro") == 1)
        {
            dlpd.SetActive(false);
            box.SetActive(false);
            employee.SetActive(true);
        }
        else
        {
            box.SetActive(true);
            employee.SetActive(false);
        }
        if (PlayerPrefs.GetInt("g4finish") == 1)
        {
            dlpd.SetActive(false);
            box.SetActive(false);
            newemp.SetActive(true);
            
        }
        else
        {
            box.SetActive(true);
            newemp.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
