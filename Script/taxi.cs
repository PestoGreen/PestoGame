using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class taxi : MonoBehaviour
{
    //public Animator taximove;
    public GameObject black, teen, dlp, grn, taxichoose,taxipoint,taximove,a,b,c,d,dlp2,dlp3,dlp4;
    public float speed;
    public bool choose;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (choose == true)
        {
            taxichoose.SetActive(false);
            Vector3 a = taximove.transform.position;
            Vector3 b = taxipoint.transform.position;
            transform.position = Vector3.MoveTowards(a, b, speed);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("grn") || other.CompareTag("teen") || other.CompareTag("dlp") && PlayerPrefs.GetInt("gototaxi") == 1)
        {
            taxichoose.SetActive(true);
        }
        if (PlayerPrefs.GetInt("emerg") == 1)
        {
            a.SetActive(true);
        }
        if (PlayerPrefs.GetInt("emerg") == 2)
        {
            b.SetActive(true);
        }
        if (PlayerPrefs.GetInt("emerg") == 3)
        {
            c.SetActive(true);
        }
        if (PlayerPrefs.GetInt("gotog5") == 1)
        {
            d.SetActive(true);
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("grn") || other.CompareTag("teen") || other.CompareTag("dlp"))
        {
            taxichoose.SetActive(false);
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
        }
    }
    void blk()
    {
        black.SetActive(true);
    }
    void map()
    {
        SceneManager.LoadScene("Gamesc1");
    }
    void mapa()
    {
        SceneManager.LoadScene("Mapa");
    }
    void mapb()
    {
        SceneManager.LoadScene("mapb");
    }
    void mapc()
    {
        SceneManager.LoadScene("mapc");
    }
    public void chooseA()
    {
        choose = true;
        //taximove.SetBool("in", true);
        teen.GetComponent<SpriteRenderer>().enabled = false;
        dlp.GetComponent<SpriteRenderer>().enabled = false;
        dlp2.GetComponent<SpriteRenderer>().enabled = false;
        dlp3.GetComponent<SpriteRenderer>().enabled = false;
        dlp4.GetComponent<SpriteRenderer>().enabled = false;
        grn.GetComponent<SpriteRenderer>().enabled = false;
        //PlayerPrefs.SetInt("dlp", 4);
        Invoke("blk", 1f);
        Invoke("mapa", 3f);
    }
    public void aa()
    {
        SceneManager.LoadScene("mapabuild");
    }
    public void bb()
    {
        SceneManager.LoadScene("mapbbuild");
    }
    public void cc()
    {
        SceneManager.LoadScene("mapcbuild");
    }
    public void dd()
    {
        SceneManager.LoadScene("game5");
        PlayerPrefs.SetInt("gotog5", 0);
    }
    public void chooseB()
    {
        choose = true;
        //taximove.SetBool("in", true);
        teen.GetComponent<SpriteRenderer>().enabled = false;
        dlp.GetComponent<SpriteRenderer>().enabled = false;
        dlp2.GetComponent<SpriteRenderer>().enabled = false;
        dlp3.GetComponent<SpriteRenderer>().enabled = false;
        dlp4.GetComponent<SpriteRenderer>().enabled = false;
        grn.GetComponent<SpriteRenderer>().enabled = false;
        //PlayerPrefs.SetInt("dlp", 4);
        Invoke("blk", 1f);
        Invoke("mapb", 3f);
    }
    public void chooseC()
    {
        choose = true;
        //taximove.SetBool("in", true);
        teen.GetComponent<SpriteRenderer>().enabled = false;
        dlp.GetComponent<SpriteRenderer>().enabled = false;
        dlp2.GetComponent<SpriteRenderer>().enabled = false;
        dlp3.GetComponent<SpriteRenderer>().enabled = false;
        dlp4.GetComponent<SpriteRenderer>().enabled = false;
        grn.GetComponent<SpriteRenderer>().enabled = false;
        //PlayerPrefs.SetInt("dlp", 4);
        Invoke("blk", 1f);
        Invoke("mapc", 3f);
    }
    public void chooseback()
    {
        choose = true;
        //taximove.SetBool("in", true);
        teen.GetComponent<SpriteRenderer>().enabled = false;
        dlp.GetComponent<SpriteRenderer>().enabled = false;
        dlp2.GetComponent<SpriteRenderer>().enabled = false;
        dlp3.GetComponent<SpriteRenderer>().enabled = false;
        dlp4.GetComponent<SpriteRenderer>().enabled = false;
        grn.GetComponent<SpriteRenderer>().enabled = false;
        PlayerPrefs.SetInt("dlp", 4);
        Invoke("blk", 1f);
        Invoke("map", 3f);
    }
}
