using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public GameObject panel;
    public bool over;
    void start()
    {
        over = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("gameover");
        panel.SetActive (true);
        over = false;
    }

   
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        
    }
    public void again()
    {
        SceneManager.LoadScene("game5");
    }
}
