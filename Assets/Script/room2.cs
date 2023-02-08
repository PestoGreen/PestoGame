using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class room2 : MonoBehaviour
{
    public GameObject collid,blk,dlp,dlp2;
    
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("intoroom2") == 1)
        {
            dlp.SetActive(false);
            dlp2.SetActive(true);
            PlayerPrefs.SetInt("intoroom2", 0);
        }
        else
        {
            dlp2.SetActive(false);
            dlp.SetActive(true);
        }
        if ( PlayerPrefs.GetInt("emerg2mes")==1 || PlayerPrefs.GetInt("emerg2fin")==1)
        {
            collid.GetComponent<BoxCollider2D>().isTrigger = false;
        }
        else
        {
            collid.GetComponent<BoxCollider2D>().isTrigger = true;
        }
        Debug.Log(calculate.money);
        Debug.Log(calculate.resilv);
        Debug.Log(calculate.grnlv);
        //PlayerPrefs.GetInt("momtext") == 1 ||
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void emerg2story()
    {
       SceneManager.LoadScene("emerg2sc");
    }
    public void intolasttalk()
    {
        blk.SetActive(true);
        Invoke("last", 1.5f);
    }
    void last()
    {
        if (PlayerPrefs.GetInt("g3mapa") == 2)
        {
            SceneManager.LoadScene("lastmapa");
        }
        else if (PlayerPrefs.GetInt("g3mapb") == 2)
        {
            SceneManager.LoadScene("lastmapb");
        }
        else if (PlayerPrefs.GetInt("g3mapc") == 2)
        {
            SceneManager.LoadScene("lastmapc");
        }
    }
}
