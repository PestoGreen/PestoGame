using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageOvrt : MonoBehaviour
{
    private int coount;
    public GameObject panel;
    public gameover spacenott;
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        coount++;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(coount>=2)
        {
            panel.SetActive(true);
            spacenott.over = false;
        }
    }
}
