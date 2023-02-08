using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class level3_choosemanager : MonoBehaviour
{
    public GameObject dianli;
    public GameObject shigong;
    public GameObject carpark;
    public GameObject bianlishangdian;
    public GameObject solarsystem;
    public GameObject pool_animal;
    public GameObject indoor_color;
    public GameObject air_pollution;
    public GameObject voice_block;
    public GameObject trash_processing;
    public GameObject environment_check;
    public GameObject stye;
    public GameObject panel;
    public int cost;
    public GameObject textfn;
    public GameObject cost_text;
    public GameObject fn,bk;
    public int i,j;
    public bool test;
    // Start is called before the first frame update
    void Start()
    {
        test = true;
    }

    // Update is called once per frame
    void Update()
    {
        cost_text.GetComponent<Text>().text = "當前花費：" + cost;
        
        textfn.GetComponent<Text>().text = "當前價格為" + cost + ",祝你開工大吉！";
        if (i == 1)
        {
            PlayerPrefs.SetInt("ggreen", 1);
        }
        else if (i == 2)
        {
            PlayerPrefs.SetInt("ggreen", 2);
        }
        else if (i == 3)
        {
            PlayerPrefs.SetInt("ggreen", 3);
        }
        if (test)
        {
            if (i > 0)
            {
                calculate.grnlv += 2;
                test = false;
            }
        }
    }

    void Open()
    {
        Invoke("bla", 2f);
        cost += 1500;
        PlayerPrefs.SetInt("o1", 1);
    }
    void UnOpen()
    {
        Invoke("bla", 2f);
        PlayerPrefs.SetInt("o1", 0);

    }


    void Open2()
    {
        Invoke("bla2", 2f);
        cost += 1000;
        PlayerPrefs.SetInt("o2", 1);

    }
    void UnOpen2()
    {
        Invoke("bla2", 2f);
        PlayerPrefs.SetInt("o2", 0);

    }

    void Open3()
    {
        Invoke("bla3",2f);
        cost += 800;
        PlayerPrefs.SetInt("o3", 1);

    }

    void UnOpen3()
    {
        Invoke("bla3", 2f);
        cost += 1200;
        PlayerPrefs.SetInt("o3", 2);

    }
    void Open4()
    {
        cost += 200;
        Invoke("bla4", 2f);
        PlayerPrefs.SetInt("o4", 1);

    }
    void UnOpen4()
    {
        Invoke("bla4", 2f);
        PlayerPrefs.SetInt("o4", 0);

    }
    void Open5()
    {
        cost += 750;
        Invoke("bla5", 2f);
        PlayerPrefs.SetInt("o5", 1);

    }
    void UnOpen5()
    {
        Invoke("bla5", 2f);
        PlayerPrefs.SetInt("o5", 0);

    }


    void Open6()
    {
        cost += 150;
        Invoke("bla6", 2f);
        PlayerPrefs.SetInt("o6", 1);

    }
    void UnOpen6()
    {
        Invoke("bla6", 2f);
        PlayerPrefs.SetInt("o6", 0);

    }

    void Open7()
    {
        cost += 150;
        Invoke("bla7", 2f);
        PlayerPrefs.SetInt("o7", 1);

    }
    void UnOpen7()
    {
        Invoke("bla7", 2f);
        PlayerPrefs.SetInt("o7", 0);

    }
    void Open8()
    {
        cost += 500;
        Invoke("bla8", 2f);
        PlayerPrefs.SetInt("o8", 1);

    }
    void UnOpen8()
    {
        cost += 200;
        Invoke("bla8", 2f);
        PlayerPrefs.SetInt("o8", 2);

    }
    void Open9()
    {
        cost += 500;
        Invoke("bla9", 2f);
        PlayerPrefs.SetInt("o9", 1);
        
    }
    void UnOpen9()
    {
        Invoke("bla9", 2f);
        PlayerPrefs.SetInt("o9", 0);

    }

    void Open10()
    {
        cost += 100;
        Invoke("bla10", 2f);
        PlayerPrefs.SetInt("o10", 1);

    }
    void UnOpen10()
    {
        Invoke("bla10", 2f);
        PlayerPrefs.SetInt("o10", 0);

    }

    void Open11()
    {
        cost += 500;
        Invoke("bla11", 2f);
        PlayerPrefs.SetInt("o11", 1);

    }
    void UnOpen11()
    {
        Invoke("bla11", 2f);
        PlayerPrefs.SetInt("o11", 0);

    }
    void Open12()
    {
        cost += 500;

        Invoke("bla12", 2f);
        PlayerPrefs.SetInt("o12", 1);

    }
    void UnOpen12()
    {
        Invoke("bla12", 2f);
        PlayerPrefs.SetInt("o12", 0);

    }

    void Open13()
    {
        cost += 150;
        Invoke("bla13",2f);
        PlayerPrefs.SetInt("o13", 1);

    }

    void UnOpen13()
    {
        cost += 300;
        Invoke("bla13", 2f);
        PlayerPrefs.SetInt("o13", 2);

    }
    void bla()
    {
        dianli.SetActive(true);
        panel.SetActive(true);

    }
    void bla2()
    {
        shigong.SetActive(true);
        panel.SetActive(true);
    }
    void bla3()
    {
        carpark.SetActive(true);
        panel.SetActive(true);
    }
    void bla4()
    {
        bianlishangdian.SetActive(true);
        panel.SetActive(true);
    }
    void bla5()
    {
        solarsystem.SetActive(true);
        panel.SetActive(true);

    }
    void bla6()
    {
        pool_animal.SetActive(true);
        panel.SetActive(true);

    }
    void bla7()
    {
        indoor_color.SetActive(true);
        panel.SetActive(true);
    }
    void bla8()
    {
        air_pollution.SetActive(true);
        panel.SetActive(true);
    }
    void bla9()
    {
        voice_block.SetActive(true);
        panel.SetActive(true);

    }
    void bla10()
    {
        trash_processing.SetActive(true);
        panel.SetActive(true);
    }
    void bla11()
    {
        environment_check.SetActive(true);
        panel.SetActive(true);
    }
    void bla12()
    {
        stye.SetActive(true);
        panel.SetActive(true);
    }

    void bla13()
    {
        fn.SetActive(true);
    }
    public void end()
    {
        PlayerPrefs.SetInt("notice", 1);
        PlayerPrefs.SetInt("g3finish", 1);
        PlayerPrefs.SetInt("g3intro", 0);
        PlayerPrefs.SetInt("dlp", 2);
        PlayerPrefs.SetInt("designmes", 1);
        bk.SetActive(true);
        Invoke("changesc", 2f);
        calculate.money += 2500;
        calculate.money -= cost;
        Debug.Log(calculate.money);
    }
    void changesc()
    {
        SceneManager.LoadScene("Gamesc1");
    }
    public void noise()
    {
        PlayerPrefs.SetInt("noise", 1);
    }
    public void src()
    {
        PlayerPrefs.SetInt("src", 1);
    }
    public void water()
    {
        PlayerPrefs.SetInt("water", 1);
    }
    public void green()
    {
        i++;
        PlayerPrefs.SetInt("green", 1);
    }
    public void ele()
    {
        calculate.grnlv += 1;
    }
    public void envi()
    {
        j++;
    }
}
