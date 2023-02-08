using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_manager_A : MonoBehaviour
{

    public int random;
    public GameObject twohun;
    public GameObject fivehun;
    public GameObject pass;
    public GameObject bid_price;
    public GameObject play_1;
    public GameObject timer;
    public GameObject player_bool;
    public AudioSource pop;
    // Start is called before the first frame update
    void OnEnable()
    {
        player_bool.SendMessage("not_player_turn");
        player_bool.SendMessage("enemy_A_turn");
        random=Random.Range(0, 2);  
        if(random==0)
        {
            twohun.SetActive(true);
            pop.Play();
            bid_price.SendMessage("plustwohun");
            

        }
        else if(random==1)
        {
            pop.Play();
            fivehun.SetActive(true);
            bid_price.SendMessage("plusfivehun");
            
        }

        Invoke("guan", 2);

    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void guan()
    {
        gameObject.SetActive(false);
        play_1.SetActive(true);
        timer.SetActive(true);
    }
}
