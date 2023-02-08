using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ending : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void end()
    {
        SceneManager.LoadScene("Pick");
    }
    public void toend1()
    {
        SceneManager.LoadScene("winplay");
    }
    public void toend2()
    {
        SceneManager.LoadScene("loseplay");
    }
}
