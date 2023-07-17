using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class WinGameScreen : MonoBehaviour
{
    public Button play_again; 

    void Start()
    {
        play_again.onClick.AddListener(ProcessButton);
    }

    void ProcessButton() {
        SceneManager.LoadScene("level");
    }

    public void Setup() {
        gameObject.SetActive(true);
    }
}
