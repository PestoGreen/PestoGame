using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dealer_send_message : MonoBehaviour
{
    public GameObject message_received;
    public GameObject bid_price;
    public GameObject player_cash;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("send", 7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void send ()
    {
        message_received.SendMessage("dealler_send");
        bid_price.SetActive(true);
        player_cash.SetActive(true);
    }
}
