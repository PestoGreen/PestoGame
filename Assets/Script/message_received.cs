using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class message_received : MonoBehaviour
{
    public GameObject enemyrandom_manager_A;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void dealler_send()
    {
        enemyrandom_manager_A.SetActive(true);
    }
}
