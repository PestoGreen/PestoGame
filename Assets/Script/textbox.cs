using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textbox : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        Invoke("waitasecond",2);
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void waitasecond()
    {
        gameObject.SetActive(false);
    }
}
