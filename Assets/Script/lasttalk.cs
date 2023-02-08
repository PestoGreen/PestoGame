using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lasttalk : MonoBehaviour
{
    public GameObject DialoguePanel, dlp, pl;
    public Text DialogueText;
    public string[] dialogue;
    private int index;
    public float wordspeed;
    public bool playerisclose = true;
    public GameObject conbtn;
    public GameObject blk;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(calculate.money);
        Debug.Log(calculate.resilv);
        Debug.Log(calculate.grnlv);
    }

    // Update is called once per frame
    void Update()
    {

        if (playerisclose)
        {
            //if (DialoguePanel.activeInHierarchy)
            //{

            //    DialogueText.text = "";
            //    index = 0;
            //    DialoguePanel.SetActive(false);
            //    tool.SetActive(true);
            //    settings.SetActive(true);
            //    phonebtn.SetActive(true);
            //}
            if (!DialoguePanel.activeInHierarchy)
            {
                DialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }
        if (DialogueText.text == dialogue[index])
        {
            conbtn.SetActive(true);
        }
        if (index == 0)
        {
            dlp.SetActive(true);
            pl.SetActive(false);
        }
        if (index == 1)
        {
            pl.SetActive(true);
            dlp.SetActive(false);
        }
    }

    public void zerotext()
    {
        DialogueText.text = "";
        index = 0;
        DialoguePanel.SetActive(false);
        blk.SetActive(true);
        if (calculate.money >= 1250 && calculate.resilv >= 7 && calculate.grnlv >=7)
        {
            Invoke("f1", 3f);
        }
        else if (calculate.money >= 1250 && calculate.resilv < 7 && calculate.grnlv >= 7)
        {
            Invoke("f2", 3f);
        }
        else if (calculate.money >= 1250 && calculate.resilv >= 7 && calculate.grnlv < 7)
        {
            Invoke("f3", 3f);
        }
        else if (calculate.money < 1250 && calculate.resilv >= 7 && calculate.grnlv >= 7)
        {
            Invoke("f4", 3f);
        }
        else
        {
            Invoke("f5", 3f);
        }
    }
    void f1()
    {
        SceneManager.LoadScene("final1");
    }
    void f2()
    {
        SceneManager.LoadScene("final2");
    }
    void f3()
    {
        SceneManager.LoadScene("final3");
    }
    void f4()
    {
        SceneManager.LoadScene("final4");
    }
    void f5()
    {
        SceneManager.LoadScene("final5");
    }
    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            DialogueText.text += letter;
            yield return new WaitForSeconds(wordspeed);
        }
    }
    public void NextLine()
    {
        conbtn.SetActive(false);
        if (index < dialogue.Length - 1)
        {
            index++;
            DialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zerotext();
            playerisclose = false;
        }
    }
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("dlp"))
    //    {
    //        playerisclose = true;
    //    }
    //}
    //private void OnTriggerExit2D(Collider2D other)
    //{
    //    if (other.CompareTag("dlp"))
    //    { 
    //        playerisclose = false;
    //        DialogueText.text = "";
    //        index = 0;
    //        DialoguePanel.SetActive(false);
    //    }
    //}
}
