using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cash_received : MonoBehaviour
{
    public int cash;
    public int bid_price;
    public int bidd;
    public GameObject bid_object;
    // Start is called before the first frame update
    void Update()
    {
        bidd = cash - bid_price;
        gameObject.GetComponent<Text>().text = "資金：" + bidd;
        bid_price = bid_object.GetComponent<bid_price_text>().bid_price;
    }


}
