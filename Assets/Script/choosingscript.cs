using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choosingscript : MonoBehaviour
{
    public GameObject choosingpanel;
    // Start is called before the first frame update
    void Start()
    {
        if (choosingpanel.activeInHierarchy)
        {
            Debug.Log("tgbnhyhn");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void clschs()
    {
        choosingpanel.SetActive(false);
    }
}
