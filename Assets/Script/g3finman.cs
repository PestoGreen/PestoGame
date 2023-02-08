using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class g3finman : MonoBehaviour
{
    public GameObject DialoguePanel, dlp,rp, xletter, dlpmove, dlp1move,bk;
    public Text DialogueText;
    public string[] dialogue;
    private int index;
    public float wordspeed;
    public bool playerisclose;
    public GameObject conbtn, tool, settings, phonebtn,script;
    //public GameObject rpman;
    // Start is called before the first frame update
    void Start()
    {
        //if (PlayerPrefs.GetInt("g3finish") == 1)
        //{
        //    rpman.SetActive(true);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && playerisclose)
        {
            if (PlayerPrefs.GetInt("g3finish") == 1)
            {
                script.GetComponent<g1finman>().enabled = false;
                script.GetComponent<g3introstory>().enabled = false;
            }
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
                xletter.SetActive(false);
                tool.SetActive(false);
                settings.SetActive(false);
                phonebtn.SetActive(false);
                DialoguePanel.SetActive(true);
                StartCoroutine(Typing());
                dlpmove.GetComponent<playermovement>().enabled = false;
                dlp1move.GetComponent<playermovement>().enabled = false;

            }
        }
        if (DialogueText.text == dialogue[index])
        {
            conbtn.SetActive(true);
        }
        if (index == 0)
        {
            rp.SetActive(true);
            dlp.SetActive(false);
        }
        if (index == 1)
        {
            dlp.SetActive(true);
            rp.SetActive(false);
        }
        if (index == 2)
        {
            dlp.SetActive(false);
            rp.SetActive(true);
        }
    }
    public void zerotext()
    {
        DialogueText.text = "";
        index = 0;
        DialoguePanel.SetActive(false);
        PlayerPrefs.SetInt("notice", 1);
        PlayerPrefs.SetInt("g3finish", 0);
        PlayerPrefs.SetInt("g2finish", 0);
        PlayerPrefs.SetInt("game1fin", 0);
        PlayerPrefs.SetInt("designmes", 0);
        PlayerPrefs.SetInt("dlp", 1);
        PlayerPrefs.SetInt("g4intro", 1);
        PlayerPrefs.SetInt("employees", 1);
        tool.SetActive(true);
        settings.SetActive(true);
        phonebtn.SetActive(true);
        dlpmove.GetComponent<playermovement>().enabled = true;
        dlp1move.GetComponent<playermovement>().enabled = true;
        bk.SetActive(true);
        Invoke("csc", 1.5f);
    }
    void csc()
    {
        SceneManager.LoadScene("Room2");
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
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("dlp"))
        {
            xletter.SetActive(true);
            playerisclose = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("dlp"))
        {
            xletter.SetActive(false);
            playerisclose = false;
            DialogueText.text = "";
            index = 0;
            DialoguePanel.SetActive(false);
        }
    }
}
