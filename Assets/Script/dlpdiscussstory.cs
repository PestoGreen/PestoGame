using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class dlpdiscussstory : MonoBehaviour
{
    public GameObject DialoguePanel,dlp,dlpd,dlps,dlpb,dlpall,dlpsis,dlpbro;
    public Text DialogueText;
    public string[] dialogue;
    private int index;
    public float wordspeed;
    public bool playerisclose;
    public GameObject conbtn,blk,p1,p2,dad,pressX,tool,settings,phonebtn,notice,noticetext,noticeontool,script;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("dlpstoryfinish") == 1)
        {
            script.GetComponent<BoxCollider2D>().enabled = false;
            script.GetComponent<dlpdiscussstory>().enabled = false;
            dlps.SetActive(false);
            dlpsis.SetActive(false);
            dlpbro.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && playerisclose)
        {
            pressX.SetActive(false);
            //DialoguePanel.SetActive(true);
            //StartCoroutine(Typing());
            //if (DialoguePanel.activeInHierarchy)
            //{
            //    DialogueText.text = "";
            //    index = 0;
            //    DialoguePanel.SetActive(false);
            //    dlps.SetActive(false);
            //    dlpb.SetActive(false);
            //    dlp.SetActive(false);
            //    dlpd.SetActive(false);
            //    dlpall.SetActive(false);
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
            dlps.SetActive(true);
        }
        if (index == 1)
        {
            dlps.SetActive(false);
            dlpb.SetActive(true);
        }
        if (index == 2)
        {
            dlpb.SetActive(false);
            dlp.SetActive(true);
        }
        if(index == 3)
        {
            dlp.SetActive(false);
            dlpd.SetActive(true);
        }
        if (index == 6)
        {
            dlpd.SetActive(false);
            dlp.SetActive(true);
        }
        if (index == 7)
        {
            dlp.SetActive(false);
            dlpd.SetActive(true);
        }
        if (index == 15)
        {
            dlpd.SetActive(false);
            dlpb.SetActive(true);
        }
        if (index == 16)
        {
            dlpb.SetActive(false);
            dlpd.SetActive(true);
        }
        if (index == 21)
        {
            dlpd.SetActive(false);
            dlp.SetActive(true);
        }
        if (index == 24)
        {
            dlp.SetActive(false);
            dlpd.SetActive(true);
        }
        if (index == 25)
        {
            dlpd.SetActive(false);
            dlpall.SetActive(true);
        }
        if (index == 26)
        {
            dlpall.SetActive(false);
            dlpd.SetActive(true);
        }
    }
    public void zerotext()
    {
        playerisclose = false;
        dlpd.SetActive(false);
        DialogueText.text = "";
        index = 0;
        DialoguePanel.SetActive(false);
        p2.GetComponent<playermovement>().enabled = true;
        PlayerPrefs.SetInt("dlpstory1", 1);
        PlayerPrefs.SetInt("dlpstoryfinish", 1);
        PlayerPrefs.SetInt("notice", 1);
        tool.SetActive(true);
        settings.SetActive(true);
        phonebtn.SetActive(true);
        script.GetComponent<BoxCollider2D>().enabled = false;
        noticeontool.SetActive(true);
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
        Invoke("xletter", 7.2f);
    }
    void xletter()
    {
        pressX.SetActive(true);
    }
}
