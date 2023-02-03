using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class npctalk : MonoBehaviour
{
    public GameObject DialoguePanel;
    public Text DialogueText;
    public string[] dialogue;
    private int index;
    public float wordspeed;
    public bool playerisclose;
    public GameObject conbtn,choosing;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && playerisclose)
        {
            if (DialoguePanel.activeInHierarchy)
            {
                DialogueText.text = "";
                index = 0;
                DialoguePanel.SetActive(false);
            }
            else
            {
                DialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }
        if(DialogueText.text == dialogue[index])
        {
            conbtn.SetActive(true);
        }
        //if (DialoguePanel.activeInHierarchy && playerisclose && Input.GetMouseButtonDown(0))
        //{
        //    //dialogue[index] = "";
        //    conbtn.SetActive(false);
        //    if (index < dialogue.Length - 1)
        //    {
        //        index++;
        //        DialogueText.text = "";
        //        StartCoroutine(Typing());
        //    }
        //    else
        //    {
        //        zerotext();
        //    }
        //}
    }
    public void zerotext()
    {
        DialogueText.text = "";
        index = 0;
        DialoguePanel.SetActive(false);
        choosing.SetActive(true);
    }
    IEnumerator Typing()
    {
        foreach(char letter in dialogue[index].ToCharArray())
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
        if (other.CompareTag("grn")|| other.CompareTag("teen")|| other.CompareTag("dlp"))
        {
            playerisclose = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("grn") || other.CompareTag("teen") || other.CompareTag("dlp"))
        {
            playerisclose = false;
            DialogueText.text = "";
            index = 0;
            DialoguePanel.SetActive(false);
            choosing.SetActive(false);
        }
    }
}
