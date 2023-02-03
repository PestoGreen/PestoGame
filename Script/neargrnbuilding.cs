using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neargrnbuilding : MonoBehaviour
{
    public Animator buildingname;
    public GameObject mappoint1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("teen") || other.CompareTag("dlp") || other.CompareTag("grn"))
        {
            buildingname.SetBool("exit", true);
            mappoint1.SetActive(false);
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("teen") || other.CompareTag("dlp") || other.CompareTag("grn"))
        {
            buildingname.SetBool("exit", false);
            
        }
    }
}
