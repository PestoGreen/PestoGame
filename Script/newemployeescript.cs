using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newemployeescript : MonoBehaviour
{
    public GameObject e1, e2, e3, e4, a1, a2, a3, m1, m2;
    public GameObject DialoguePanel, dlp, emp, xletter, dlpmove;
    public Text DialogueText;
    public string[] dialogue;
    private int index;
    public float wordspeed;
    public bool playerisclose;
    public GameObject conbtn, tool, settings, phonebtn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("eng") == 1)
        {
            e1.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("eng") == 2)
        {
            e2.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("eng") == 3)
        {
            e3.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("eng") == 4)
        {
            e4.SetActive(true);
        }
        if (PlayerPrefs.GetInt("acc") == 1)
        {
            a1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("acc") == 2)
        {
            a2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("acc") == 3)
        {
            a3.SetActive(true);
        }
        if (PlayerPrefs.GetInt("mng") == 1)
        {
            m1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("mng") == 2)
        {
            m2.SetActive(true);
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

            }
        }
        if (DialogueText.text == dialogue[index])
        {
            conbtn.SetActive(true);
        }
        if (index == 0)
        {
            emp.SetActive(false);
            dlp.SetActive(true);
        }
        if (index == 1)
        {
            dlp.SetActive(false);
            emp.SetActive(true);
        }
        if (index == 2)
        {
            dlp.SetActive(true);
            emp.SetActive(false);
        }
        if (index == 4)
        {
            dlp.SetActive(false);
            emp.SetActive(true);
        }
    }
    public void zerotext()
    {
        DialogueText.text = "";
        index = 0;
        DialoguePanel.SetActive(false);
        PlayerPrefs.SetInt("employeefin", 1);
        tool.SetActive(true);
        settings.SetActive(true);
        phonebtn.SetActive(true);
        dlpmove.GetComponent<playermovement>().enabled = true;
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
