using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class victoryribbon : MonoBehaviour
{
    public GameObject ribbon, s1, s2,blk;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ribbontime", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ribbontime()
    {
        ribbon.SetActive(true);
        s1.SetActive(true);
        s2.SetActive(true);
        PlayerPrefs.SetInt("game1fin", 1);
        PlayerPrefs.SetInt("notice", 1);
        PlayerPrefs.SetInt("dlpstory1", 0);
        PlayerPrefs.SetInt("game1finp2", 1);
        Invoke("blktime", 4f);
    }
    void blktime()
    {
        blk.SetActive(true);
        Invoke("changesc", 2f);
    }
    void changesc()
    {
        SceneManager.LoadScene("discussroom");
    }
}
