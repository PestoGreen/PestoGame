using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class g5ruletalk : MonoBehaviour
{
    public GameObject DialoguePanel, dlp, eng, xletter,start;
    public Text DialogueText;
    public string[] dialogue;
    private int index;
    public float wordspeed;
    public bool playerisclose=true;
    public GameObject conbtn;
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
            eng.SetActive(true);
            dlp.SetActive(false);
        }
        if (index == 1)
        {
            eng.SetActive(true);
            dlp.SetActive(false);
        }
        if (index == 2)
        {
            eng.SetActive(false);
            dlp.SetActive(true);
        }
    }
    public void zerotext()
    {
        DialogueText.text = "";
        index = 0;
        DialoguePanel.SetActive(false);
        start.SetActive(true);
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
}
