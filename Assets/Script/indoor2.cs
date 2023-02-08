using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class indoor2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("dlp"))
        {
            SceneManager.LoadScene("Room2");
            PlayerPrefs.SetInt("dlp", 1);
            PlayerPrefs.SetInt("intoroom2", 1);
        }
    }
}
