using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class outdoor : MonoBehaviour
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
        if(other.CompareTag("grn") || other.CompareTag("teen") || other.CompareTag("dlp"))
        {
            SceneManager.LoadScene("Gamesc1");
            PlayerPrefs.SetInt("downstair", 0);
            
        }
    }
}
