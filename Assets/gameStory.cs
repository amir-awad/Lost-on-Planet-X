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

        choicePanel.SetActive(false);
        playableDirector = GetComponent<PlayableDirector>();

        // Add the PlayTimeline method to the button's OnClick event
        if (loadTimelineButton != null)
        {
            Button button = loadTimelineButton.GetComponent<Button>();
            if (button != null)
            {
                button.onClick.AddListener(PlayTimeline); // Add the PlayTimeline method
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
    }

    public void PlayTimeline()
    {
        myText.text = "Hello� can you hear me? Is anyone out there?\r\n\r\nYour ship, the Stellar Horizon, was on a routine mission when disaster struck�a glowing asteroid collided with the hull, forcing a crash landing on an uncharted planet. You awaken surrounded by alien landscapes, the air thick with unfamiliar sounds and dangers lurking in the shadows. The wreckage of your ship is scattered, and your crew is missing. With limited resources, your mission is clear: explore the planet to gather supplies, uncover its secrets, and locate your crew. The path back to safety won�t be easy�hostile creatures and ancient mysteries stand in your way. Every decision you make could mean survival or being lost forever on this alien world.";

        playableDirector.Play(); // Play the timeline
        loadTimelineButton.SetActive(false); // Disable the button

    }

    // Update is called once per frame
    void Update()
    {
        // Add any runtime logic here if needed
    }
}
