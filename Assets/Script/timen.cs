using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timen : MonoBehaviour
{
    public int m_seconds;
    public int m_min;
    private int m_sec;
    public Text m_timer;
    public GameObject player_pass;
    public GameObject play_1;
    public GameObject pass_countt;
    public GameObject enemy_manager_B;
    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        m_sec = 10;
        m_timer.text = string.Format("{0}:{1}", m_min.ToString("00"),m_sec.ToString("00"));
        m_seconds = (m_min * 60) + 10;

        while(m_seconds > 0 )
        {
            yield return new WaitForSeconds(1);

            m_seconds--;
            m_sec--;

            if(m_sec < 0 && m_min >0)
            {
                m_min -= 1;
                m_sec = 59;
            }
            else if (m_sec < 0 && m_min ==0)
            {
                m_sec = 0;
            }
            m_timer.text = string.Format("{0}:{1}", m_min.ToString("00"), m_sec.ToString("00"));
        }
        yield return new WaitForSeconds(1);
        player_pass.SetActive(true);
        pass_countt.SendMessage("pass");
        enemy_manager_B.SetActive(true);
        play_1.SetActive(false);
        gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
}
