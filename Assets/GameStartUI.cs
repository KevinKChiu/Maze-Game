using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameStartUI : MonoBehaviour
{
    public Button start; 

    void Start()
    {
        start.onClick.AddListener(ProcessButton);
    }

    void ProcessButton() {
        SceneManager.LoadScene("level");
    }
}
