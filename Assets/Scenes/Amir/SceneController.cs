using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public Button killAlienButton;
    public Button escapeButton;
    public GameObject choicePanel;

    // Start is called before the first frame update
    void Start()
    {
        if (killAlienButton != null)
        {
            killAlienButton.onClick.AddListener(() => { SceneManager.LoadScene("Mo7y"); });
        }

        if (escapeButton != null)
        {
            escapeButton.onClick.AddListener(() => { SceneManager.LoadScene("John"); });
        }

        choicePanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
