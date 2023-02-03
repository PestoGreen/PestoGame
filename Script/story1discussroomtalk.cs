using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class story1discussroomtalk : MonoBehaviour
{
    public GameObject DialoguePanel, dlp, albert, calvin, chairperson,ab,cl,cp;
    public Text DialogueText;
    public string[] dialogue;
    private int index;
    public float wordspeed;
    public bool playerisclose;
    public GameObject conbtn, blk, p1, p2, dad, pressX,rule, tool, settings, phonebtn,script;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("dlpstory1") != 1)
        {
            script.GetComponent<BoxCollider2D>().enabled = false;
            ab.SetActive(false);
            cl.SetActive(false);
            cp.SetActive(false);
        }
        if (PlayerPrefs.GetInt("downstair") == 0)
        {
            p1.SetActive(true);
            p2.SetActive(false);
        }
        if (PlayerPrefs.GetInt("game1finp2") == 1)
        {
            p1.SetActive(false);
            p2.SetActive(true);
            p2.GetComponent<playermovement>().enabled = true;
            PlayerPrefs.SetInt("game1finp2", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && playerisclose)
        {
            pressX.SetActive(false);
            //if (DialoguePanel.activeInHierarchy)
            //{
            //    DialogueText.text = "";
            //    index = 0;
            //    DialoguePanel.SetActive(false);
            //    calvin.SetActive(false);
            //    albert.SetActive(false);
            //    dlp.SetActive(false);
            //    tool.SetActive(true);
            //    settings.SetActive(true);
            //    phonebtn.SetActive(true);
            //}
            if (!DialoguePanel.activeInHierarchy)
            {

                tool.SetActive(false);
                settings.SetActive(false);
                phonebtn.SetActive(false);
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
            albert.SetActive(true);
            chairperson.SetActive(false);
            calvin.SetActive(false);
            dlp.SetActive(false);
        }
        if (index == 3)
        {
            albert.SetActive(false);
            calvin.SetActive(true);
        }
        if (index == 7)
        {
            calvin.SetActive(false);
            dlp.SetActive(true);
        }
        if (index == 12)
        {
            dlp.SetActive(false);
            chairperson.SetActive(true);
        }
    }
    public void zerotext()
    {
        DialogueText.text = "";
        index = 0;
        DialoguePanel.SetActive(false);
        rule.SetActive(true);
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
        pressX.SetActive(false);
        if (index < dialogue.Length - 1)
        {
            index++;
            DialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zerotext();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("dlp"))
        {
            Invoke("startstory", 2.5f);
            Invoke("changeP", 1.5f);
            blk.SetActive(true);
        }
    }
    void startstory()
    {
        playerisclose = true;
        //blk.SetActive(false);
    }
    void changeP()
    {
        dad.SetActive(true);
        p1.SetActive(false);
        p2.SetActive(true);
        Invoke("xletter", 2f);
    }
    void xletter()
    {
        pressX.SetActive(true);
    }
    public void rulefin()
    {
        SceneManager.LoadScene("Game");
    }
}
