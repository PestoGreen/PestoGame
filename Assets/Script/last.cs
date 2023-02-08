using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class last : MonoBehaviour
{
    public GameObject money1, rhrt, ghrt;
    public int money2, rhrt2, ghrt2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        money2 = calculate.money;
        rhrt2 = calculate.resilv;
        ghrt2 = calculate.grnlv;
        money1.GetComponent<Text>().text = "" + money2;
        rhrt.GetComponent<Text>().text = "" + rhrt2;
        ghrt.GetComponent<Text>().text = "" + ghrt2;
    }
}
