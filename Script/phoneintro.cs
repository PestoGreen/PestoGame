using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class phoneintro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("mtxt", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void mtxt()
    {
        SceneManager.LoadScene("pppapp");
    }
}
