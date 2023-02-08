using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_turn_bool : MonoBehaviour
{
    public bool enemy_Aturn;
    public bool enemy_Bturn;
    public bool player_turn;
    public GameObject bid_price;
    public GameObject enemy_random_manager_A;
    public GameObject enemy_random_manager_B;
    public GameObject enemy_pass_A;
    public GameObject enemy_pass_B;
    public GameObject pop;
    public GameObject pop1;
    // Start is called before the first frame update
    void not_player_turn()
    {
        player_turn = false;
    }

    void enemy_A_turn()
    {
        enemy_Aturn = true;
        enemy_Bturn = false;
    }

    void enemy_b_turn()
    {
        enemy_Aturn = false;
        enemy_Bturn = true;
    }

    void is_player_turn()
    {
        player_turn = true;
    }

     void Update()
    {
        if(player_turn==true)
        {
            if(bid_price.GetComponent<bid_price_text>().bid_price >= 7000)
            {
                Debug.Log("player win!!!");
                Destroy(enemy_random_manager_A);
                Destroy(enemy_random_manager_B);
                Invoke("kaiB", 2);
                Invoke("winn", 1);
                player_turn = false;
            }
        }
        if (player_turn == false)
        {
            if(enemy_Aturn == true)
            {
                if (bid_price.GetComponent<bid_price_text>().bid_price >= 7500)
                {
                    Invoke("overA", 1);
                    Debug.Log("Awin,you lose try again");
                }
            }

            if (enemy_Bturn == true)
            {
                if (bid_price.GetComponent<bid_price_text>().bid_price >= 7500)
                {
                    Invoke("overB", 1);
                    Debug.Log("Bwin,you lose try again");
                }
            }

        }


    }

    void kaiB()
    {
        enemy_pass_B.SetActive(true);
        pop.SetActive(true);
        Invoke("kaiA", 2);
    }

    void kaiA()
    {
        enemy_pass_A.SetActive(true);
        pop1.SetActive(true);
        Invoke("win", 2);
    }

    void over()
    {
        SceneManager.LoadScene("Game over");
    }

    void win()
    {
        SceneManager.LoadScene("Victory");

    }
    void winn()
    {
        calculate.money -= bid_price.GetComponent<bid_price_text>().bid_price;
        Debug.Log(calculate.money);
    }
    void overA()
    {
        SceneManager.LoadScene("Awin");
    }
    void overB()
    {
        SceneManager.LoadScene("Bwin");
    }


}
