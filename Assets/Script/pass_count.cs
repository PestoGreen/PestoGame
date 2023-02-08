using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pass_count : MonoBehaviour
{

    public int passcount;
    public GameObject pass_allert;
    // Start is called before the first frame update
    void pass()
    {
        passcount++;
    }

    // Update is called once per frame
    void Update()
    {

        gameObject.GetComponent<Text>().text = "Pass:" + passcount + "/3";
        if(passcount ==3)
        {
            pass_allert.SetActive(true);
        }

        if(passcount >= 4)
        {
            Debug.Log("game over");
            SceneManager.LoadScene("Game over");
        }
    }
}
