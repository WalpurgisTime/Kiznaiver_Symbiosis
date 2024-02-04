using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

public class UMenu : MonoBehaviour
{
    private bool isPaused = false;
    public Button Paused;
    public Button Paused2;
    public Button QuitButton;
    public GameObject MENU;
    public AudioMixer audioMixer;
    public Dropdown resolutionDropDown; // Fixed typo 'DropDown' to 'Dropdown'
    private Resolution[] resolutions;
    public Toggle Toggle1;

    void Start()
    {
        MENU.SetActive(true); // Set the menu to inactive initially

        // Get available screen resolutions
        resolutions = Screen.resolutions.Select(resolution => new Resolution{width = resolution.width,height = resolution.height}).Distinct().ToArray();
        resolutionDropDown.ClearOptions();

        List<string> options = new List<string>();
        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);
            
            if(resolutions[i].width == Screen.width && resolutions[i].height == Screen.height)
            {
                currentResolutionIndex = i;
            }
            
            
        }

        // Add options to the dropdown
        resolutionDropDown.AddOptions(options);
        resolutionDropDown.value = currentResolutionIndex;
        resolutionDropDown.RefreshShownValue();
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        if(Toggle1.isOn)
        {
            Screen.fullScreen = isFullScreen;
        }
        
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width,resolution.height,Screen.fullScreen);
    }

    public void OnClickPause()
    {
        if (Paused.interactable)
        {
            Time.timeScale = 0f;
            MENU.SetActive(true);
            StopAllMusic();
        }
    }

    public void OnClickPause2()
    {
        if (Paused2.interactable)
        {
            Time.timeScale = 1f;
            MENU.SetActive(false);
            ResumeAllMusic();
        }
    }

    void StopAllMusic()
    {
        // Récupérer tous les objets audio dans la scène
        AudioSource[] audioSources = FindObjectsOfType<AudioSource>();

        // Parcourir tous les objets audio et arrêter la lecture
        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.Pause();
        }
    }

    void ResumeAllMusic()
    {
        AudioSource[] audioSources = FindObjectsOfType<AudioSource>();
        // Parcourir tous les objets audio et reprendre la lecture
        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.UnPause(); // Utiliser UnPause() pour reprendre la lecture après une pause
        }
    }

    public void OnClickQuit()
    {
        if(QuitButton.interactable)
        {
            Application.Quit();
        }
        
    }
}
