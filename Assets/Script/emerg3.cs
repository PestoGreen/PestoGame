using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emerg3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void lic()
    {
        if (PlayerPrefs.GetInt("license") == 1)
        {
            calculate.money += 1000;
            calculate.resilv += 2;
            PlayerPrefs.SetInt("license", 2);
        }
    }
}
