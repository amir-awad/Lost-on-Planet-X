using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Playables;
using UnityEngine.UI; // Added for button
using UnityEngine.SceneManagement;

public class gameStory : MonoBehaviour
{
    public Button leftButton;
    public Button rightButton;
    public GameObject choicePanel;
    public GameObject loadTimelineButton;
    public GameObject startMenu;
    public GameObject backToStartMenu; // Reference to backToStartMenu button
    public Button quitButton;
    public TextMeshProUGUI myText;
    private PlayableDirector playableDirector;

    void Start()
    {
        if (leftButton != null)
        {
           leftButton.onClick.AddListener(() => { SceneManager.LoadScene("Amir"); });       
        }

        if (rightButton != null)
        {
            rightButton.onClick.AddListener(() => { SceneManager.LoadScene("Ibrahim"); });
        }

        if (quitButton != null)
        {
            quitButton.onClick.AddListener(() => { Application.Quit(); });
        }

        backToStartMenu.SetActive(false);
        choicePanel.SetActive(false);
        playableDirector = GetComponent<PlayableDirector>();

        if (loadTimelineButton != null)
        {
            Button button = loadTimelineButton.GetComponent<Button>();
            if (button != null)
            {
                button.onClick.AddListener(PlayTimeline);
            }
            else
            {
                Debug.LogError("Button component not found on loadTimelineButton!");
            }
        }
        else
        {
            Debug.LogError("loadTimelineButton is not assigned!");
        }

        // Add listener to backToStartMenu button
        if (backToStartMenu != null)
        {   
            Button backButton = backToStartMenu.GetComponent<Button>();
            if (backButton != null)
            {
                backButton.onClick.AddListener(BackToStartMenu); // Add BackToStartMenu method
            }
            else
            {
                Debug.LogError("Button component not found on backToStartMenu!");
            }
        }
        else
        {
            Debug.LogError("backToStartMenu is not assigned!");
        }
    }

    public void PlayTimeline()
    {
        myText.text = "Hello� can you hear me? Is anyone out there?\r\n\r\nYour ship, the Stellar Horizon, was on a routine mission when disaster struck�a glowing asteroid collided with the hull, forcing a crash landing on an uncharted planet. You awaken surrounded by alien landscapes, the air thick with unfamiliar sounds and dangers lurking in the shadows. The wreckage of your ship is scattered, and your crew is missing. With limited resources, your mission is clear: explore the planet to gather supplies, uncover its secrets, and locate your crew. The path back to safety won�t be easy�hostile creatures and ancient mysteries stand in your way. Every decision you make could mean survival or being lost forever on this alien world.";

        playableDirector.Play(); // Play the timeline
        startMenu.SetActive(false); // Hide the start menu
    }

    public void BackToStartMenu()
    {
        // Reset the timeline
        playableDirector.Stop();
        playableDirector.time = 0;

        // Show the start menu
        startMenu.SetActive(true);

        // Hide any other UI elements if necessary
        choicePanel.SetActive(false);

        myText.text = "Credits:\nAnimations: Mixamo\nModels: Mixamo\nSound Tracks: Pixabay";

        // Hide the backToStartMenu button
        backToStartMenu.SetActive(false);

    }

    void Update()
    {
        // Add any runtime logic here if needed
    }
}
