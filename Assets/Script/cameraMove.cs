using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cameraMove : MonoBehaviour
{
    public int count;
    public int countt;
    public float speed;
    /*public GameObject rope;
    public GameObject stage;*/
    //public realCameraFollow followw;
    public GameObject cam,test;
    public GameObject rope;
    public GameObject cloud,bk;
    public GameObject win;
    public Text texxt;
    public float y = 2.3f;
    // Start is called before the first frame update
    void Start()
    {
        count = 1;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("house"))
        {
            count++;
            countt++;
            texxt.text = "Floor:" + countt;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log(count);
        if (count %4==0)
        {
            //count = 0;
            //followw.targetpos.y += 2f;
            Debug.Log("up");
            upp();         
        }
        if(countt>=6)
        {
            win.SetActive(true);
            PlayerPrefs.SetInt("momtext", 0);
            PlayerPrefs.SetInt("notice", 1);
            PlayerPrefs.SetInt("g5intro", 0);
            PlayerPrefs.SetInt("gotog5", 0);
            Invoke("bkk", 1f);
            Invoke("csc", 3f);
        }
    }
    void upp()
    {
        count = 1;
        cam.transform.Translate(new Vector2(0, 4));
        rope.transform.Translate(new Vector2(0, 4));
        test.transform.Translate(new Vector2(0, 5));
        cloud.transform.Translate(new Vector2(0, 4));
        /*cam.transform.position += new Vector3(0, speed,0);
        rope.transform.position += new Vector3(0, speed, 0);*/

    }
    void bkk()
    {
        bk.SetActive(true);
    }
    void csc()
    {
        SceneManager.LoadScene("fewdayslater");
        PlayerPrefs.SetInt("dlp", 1);
        if (PlayerPrefs.GetInt("g3mapa") == 2)
        {
            PlayerPrefs.SetInt("emerg", 1);
        }
        if (PlayerPrefs.GetInt("g3mapb") == 2)
        {
            PlayerPrefs.SetInt("emerg", 2);
        }
        if (PlayerPrefs.GetInt("g3mapc") == 2)
        {
            PlayerPrefs.SetInt("emerg", 3);
        }
    }

}
