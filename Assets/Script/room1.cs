using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room1 : MonoBehaviour
{
    public GameObject teen;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("teen") == 1)
        {
            teen.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
