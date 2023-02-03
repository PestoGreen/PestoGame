using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_scene_manager : MonoBehaviour
{
    public GameObject button;
    // Start is called before the first frame update
    public void ButtonMoveScene(string level)
    {
        SceneManager.LoadScene(level);
    }

     void Start()
    {
        Invoke("wait", 3);
    }

    void wait()
    {
        button.SetActive(true);
    }
}
