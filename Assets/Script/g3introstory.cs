using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class g3introstory : MonoBehaviour
{
    public GameObject DialoguePanel, dlp, rpman, xletter,dlpmove,dlp1move;
    public Text DialogueText;
    public string[] dialogue;
    private int index;
    public float wordspeed;
    public bool playerisclose;
    public GameObject conbtn, tool, settings, phonebtn, script,chooseA, chooseB,chooseC;
    int i = 0, j = 0,k=0;


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
        }
        if (PlayerPrefs.GetInt("g3intro") == 1)
        {
            zerotext();
        }
        if (PlayerPrefs.GetInt("g3finish") == 1)
        {
            script.GetComponent<g3introstory>().enabled = false;
            script.GetComponent<g3finman>().enabled = true;
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
        if (index == 2)
        {
            dlp.SetActive(true);
            rpman.SetActive(false);
            chooseA.SetActive(true);
            chooseB.SetActive(true);
            chooseC.SetActive(true);
            conbtn.SetActive(false);
            if (i == 1)
            {
                NextLine();
                chooseA.SetActive(false);
                chooseB.SetActive(false);
                chooseC.SetActive(false);
                i = 0;
            }
            if (j == 1)
            {
                index = 4;
                NextLine();
                chooseA.SetActive(false);
                chooseB.SetActive(false);
                chooseC.SetActive(false);
                j = 0;
            }
            if (k == 1)
            {
                index = 6;
                NextLine();
                chooseA.SetActive(false);
                chooseB.SetActive(false);
                chooseC.SetActive(false);
                k = 0;
            }
        }
        if (index == 3 ||index==5 ||index==7)
        {
            dlp.SetActive(false);
            rpman.SetActive(true);
        }
        if (index == 4 || index==6 || index==8)
        {
            dlp.SetActive(true);
            rpman.SetActive(false);
        }
        if (index == 9)
        {
            dlp.SetActive(false);
            rpman.SetActive(true);
        }

    }
    public void A()
    {
        i++;
        PlayerPrefs.SetInt("g3mapa", 1);
    }
    public void B()
    {
        j++;
        PlayerPrefs.SetInt("g3mapb", 1);

    }
    public void C()
    {
        k++;
        PlayerPrefs.SetInt("g3mapc", 1);

    }
    public void zerotext()
    {
        DialogueText.text = "";
        index = 0;
        DialoguePanel.SetActive(false);
        PlayerPrefs.SetInt("notice", 1);
        PlayerPrefs.SetInt("gototaxi", 0);
        PlayerPrefs.SetInt("g2fin", 0);
        PlayerPrefs.SetInt("g3intro", 1);
        tool.SetActive(true);
        settings.SetActive(true);
        phonebtn.SetActive(true);
        dlpmove.GetComponent<playermovement>().enabled = true;
        dlp1move.GetComponent<playermovement>().enabled = true;

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
        if (index == 4 || index == 6 || index == 8)
        {
            Invoke("btn", 2.5f);
            
            index = 8;
        }
    }
    void btn()
    {
        conbtn.SetActive(true);
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
