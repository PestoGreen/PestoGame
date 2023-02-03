using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Amapteennpc : MonoBehaviour
{
    public GameObject DialoguePanel, a1, a2, a3, b1, b2, b3, xletter, dlpmove,dlp,teennpc,teennpcmad;
    public Text DialogueText;
    public string[] dialogue;
    private int index;
    public float wordspeed;
    public bool playerisclose;
    public GameObject conbtn, chooseA, chooseB, lastconbtn, tool, settings, phonebtn,ppp;
    int i = 0, j = 0;
    float p = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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
                tool.SetActive(false);
                settings.SetActive(false);
                phonebtn.SetActive(false);
                DialoguePanel.SetActive(true);
                StartCoroutine(Typing());
                xletter.SetActive(false);
                dlpmove.GetComponent<playermovement>().enabled = false;
            }
        }
        if (DialogueText.text == dialogue[index])
        {
            conbtn.SetActive(true);
        }
        if (index == 0)
        {
            dlp.SetActive(true);
            teennpc.SetActive(false);
            teennpcmad.SetActive(false);
        }
        if (index == 3)
        {
            dlp.SetActive(false);
            teennpc.SetActive(true);
        }
        if (index == 6)
        {
            dlp.SetActive(true);
            teennpc.SetActive(false);
            chooseA.SetActive(true);
            chooseB.SetActive(true);
            a1.SetActive(true);
            b1.SetActive(true);
            a2.SetActive(false);
            b2.SetActive(false);
            a3.SetActive(false);
            b3.SetActive(false);
            conbtn.SetActive(false);
            if (i == 1)
            {
                index = 7;
                NextLine();
                chooseA.SetActive(false);
                chooseB.SetActive(false);
                p -= 1;
            }
            if (j == 1)
            {
                NextLine();
                chooseA.SetActive(false);
                chooseB.SetActive(false);
            }
        }
        if (index == 7)
        {
            dlp.SetActive(false);
            teennpc.SetActive(true);
            chooseA.SetActive(true);
            chooseB.SetActive(true);
            a1.SetActive(false);
            b1.SetActive(false);
            a2.SetActive(true);
            b2.SetActive(true);
            a3.SetActive(false);
            b3.SetActive(false);
            conbtn.SetActive(false);
            if (i == 1)
            {
                NextLine();
                chooseA.SetActive(false);
                chooseB.SetActive(false);
                j-=1;
            }
            if (j == 2)
            {
                index = 8;
                NextLine();
                chooseA.SetActive(false);
                chooseB.SetActive(false);
            }
        }
        if (index == 8)
        {
            dlp.SetActive(false);
            teennpc.SetActive(true);
            chooseA.SetActive(true);
            chooseB.SetActive(true);
            a1.SetActive(false);
            b1.SetActive(false);
            a2.SetActive(false);
            b2.SetActive(false);
            a3.SetActive(true);
            b3.SetActive(true);
            conbtn.SetActive(false);
            if (i == 2)
            {
                index = 10;
                NextLine();
                chooseA.SetActive(false);
                chooseB.SetActive(false);
                p += 3;
                PlayerPrefs.SetInt("aTwin", 1);
            }
            
            if (j==1)
            {
                index = 11;
                NextLine();
                chooseA.SetActive(false);
                chooseB.SetActive(false);
                p -= 5;
            }
        }
        if (index == 10)
        {
            chooseA.SetActive(true);
            chooseB.SetActive(true);
            a1.SetActive(false);
            b1.SetActive(false);
            a2.SetActive(false);
            b2.SetActive(false);
            a3.SetActive(true);
            b3.SetActive(true);
            conbtn.SetActive(false);
            if (i == 1)
            {
                index = 10;
                NextLine();
                chooseA.SetActive(false);
                chooseB.SetActive(false);
                p += 3;
                PlayerPrefs.SetInt("aTwin", 1);

            }
            if (j == 3)
            { 
                    index = 11;
                    NextLine();
                    chooseA.SetActive(false);
                    chooseB.SetActive(false);
                p -= 5;
            }
        }

        if (index == 11 || index ==12)
        {
            lastconbtn.SetActive(true);
            i = 0;
            j = 0;
        }
        if (p < 5)
        {
            teennpc.SetActive(false);
            teennpcmad.SetActive(true);
            Debug.Log("teenlose");
        }
    }
    public void A()
    {
        i++;
    }
    public void B()
    {
        j++;
    }
    public void zerotext()
    {
        dlp.SetActive(true);
        teennpc.SetActive(false);
        teennpcmad.SetActive(false);
        DialogueText.text = "";
        index = 0;
        DialoguePanel.SetActive(false);
        PlayerPrefs.SetInt("amapteen", 1);
        tool.SetActive(true);
        settings.SetActive(true);
        phonebtn.SetActive(true);
        dlpmove.GetComponent<playermovement>().enabled = true;
        PlayerPrefs.SetInt("return", 1);
        
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
        if (PlayerPrefs.GetInt("amapteen") == 1)
        {
            zerotext();
        }
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
            ppp.SetActive(true);
            playerisclose = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("dlp"))
        {
            xletter.SetActive(false);
            ppp.SetActive(false);
            playerisclose = false;
            DialogueText.text = "";
            index = 0;
            DialoguePanel.SetActive(false);
        }
    }
}
