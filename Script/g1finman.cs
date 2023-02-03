using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class g1finman : MonoBehaviour
{

    public GameObject DialoguePanel,dlp,rpman,xletter,dlpmove,dlp1move;
    public Text DialogueText;
    public string[] dialogue;
    private int index,i=0;
    public float wordspeed;
    public bool playerisclose;
    public GameObject conbtn, tool, settings, phonebtn,script;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("g2finish") == 1)
        {
            script.GetComponent<g1finman>().enabled = false;
            script.GetComponent<g3introstory>().enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.X) && playerisclose)
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
        if (index == 1)
        {
            dlp.SetActive(true);
            rpman.SetActive(false);
        }
        if (index == 2)
        {
            dlp.SetActive(false);
            rpman.SetActive(true);
        }
        if (i == 1)
        {
            calculate.money += 2500;
            i = 2;
        }
    }
    public void zerotext()
    {
        DialogueText.text = "";
        index = 0;
        DialoguePanel.SetActive(false);
        PlayerPrefs.SetInt("notice", 1);
        PlayerPrefs.SetInt("taxiready", 1);
        PlayerPrefs.SetInt("gototaxi", 1);
        PlayerPrefs.SetInt("game1fin", 0);
        tool.SetActive(true);
        settings.SetActive(true);
        phonebtn.SetActive(true);
        dlpmove.GetComponent<playermovement>().enabled = true;
        dlp1move.GetComponent<playermovement>().enabled = true;
        i++;
        

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
