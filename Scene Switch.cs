using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update


    public Button Return;


    




    public void OnClickreturn()
    {
        if(Return.interactable)
        {       
            SceneManager.LoadScene("SampleScene");
            AudioSource[] audioSources = FindObjectsOfType<AudioSource>();

            foreach (AudioSource audioSource in audioSources)
            {
                audioSource.Stop();
            }
        }
    }

   


}
