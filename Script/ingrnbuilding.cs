using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ingrnbuilding : MonoBehaviour
{
    public GameObject floorchoose;
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
        if (other.CompareTag("teen") || other.CompareTag("dlp") || other.CompareTag("grn"))
        {
            floorchoose.SetActive(true);
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("teen") || other.CompareTag("dlp") || other.CompareTag("grn"))
        {
            floorchoose.SetActive(false);
        }
    }
    public void firstfloor()
    {
        PlayerPrefs.SetInt("dlp", 3);
        SceneManager.LoadScene("Room3");
        floorchoose.SetActive(false);
    }
    public void secondfloor()
    {
        PlayerPrefs.SetInt("dlp", 3);
        SceneManager.LoadScene("discussroom");
        floorchoose.SetActive(false);
    }
}
