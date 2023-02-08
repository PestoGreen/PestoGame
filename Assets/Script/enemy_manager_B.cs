using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_manager_B : MonoBehaviour
{

    public int random;
    public GameObject twohun;
    public GameObject fivehun;
    public GameObject pass;
    public GameObject bid_price;
    public GameObject play_1;
    public GameObject player_bool;
    public AudioSource pop;
    // Start is called before the first frame update
    void OnEnable()
    {
        Invoke("kai", 2);



    }

    // Update is called once per frame
    void kai()
    {
        player_bool.SendMessage("not_player_turn");
        player_bool.SendMessage("enemy_b_turn");
            random=Random.Range(0, 2);  
        if(random==0)
        {
            twohun.SetActive(true);
            bid_price.SendMessage("plustwohun");
            pop.Play();

        }
        else if(random==1)
        {
            fivehun.SetActive(true);
            bid_price.SendMessage("plusfivehun");
            pop.Play();
        }
        Invoke("guan", 2);
    }

    void guan()
    {
       gameObject.SetActive(false);
        play_1.SetActive(true);

    }
}
