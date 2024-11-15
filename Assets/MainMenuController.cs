using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public Button backToStartMenu;
    // Start is called before the first frame update
    void Start()
    {
        if (backToStartMenu != null)
        {
            backToStartMenu.onClick.AddListener(() => { SceneManager.LoadScene("Wael"); });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
