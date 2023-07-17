using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class LoseGameScreen : MonoBehaviour
{
    public Button try_again; 
    public Level level;
    private List<TileType>[,] saved_grid;
    GameObject[] gameObjects;

    void Start()
    {
        level = GameObject.Find("Level").GetComponent<Level>();
        try_again.onClick.AddListener(ProcessButton);
    }

    void ProcessButton() {
        level.Restart();
    }

    public void Setup() {
        gameObject.SetActive(true);
    }

    public void Hide() {
        gameObject.SetActive(false);
    }
}