using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class intomomtext : MonoBehaviour
{
    public GameObject mtxtbk;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("employeefin") == 1)
        {
            mtxtbk.SetActive(true);
            Invoke("changesc", 2f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void changesc()
    {
        SceneManager.LoadScene("phoneintro");
    }
}
