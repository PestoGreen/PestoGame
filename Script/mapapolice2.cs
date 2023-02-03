using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mapapolice2 : MonoBehaviour
{
    public GameObject DialoguePanel, dlp, resi;
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
            resi.SetActive(false);
        }
        if (index == 1)
        {
            resi.SetActive(true);
            dlp.SetActive(false);
        }
        if (index == 3)
        {
            dlp.SetActive(true);
            resi.SetActive(false);
        }
        if (index == 4)
        {
            resi.SetActive(true);
            dlp.SetActive(false);
        }
        if (index == 5)
        {
            dlp.SetActive(true);
            resi.SetActive(false);
        }
    }

    public void zerotext()
    {
        DialogueText.text = "";
        index = 0;
        DialoguePanel.SetActive(false);
        PlayerPrefs.SetInt("notice", 1);
        blk.SetActive(true);
        Invoke("csc", 3.5f);
        PlayerPrefs.SetInt("emerg", 4);
        PlayerPrefs.SetInt("emerg2mes", 1);
        calculate.resilv += 3;
    }
    void csc()
    {
        SceneManager.LoadScene("fewdayslater");
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
