using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Music : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;


    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public AudioSource audioSource4;
    public AudioSource audioSource5;
    public AudioSource audioSource6;
    public AudioSource audioSource7;
    public AudioSource audioSource8;

    public Sprite imageMusiqueActive;
    public Sprite imageMusiqueInactive;

    public OtherScript readfile;

    private void IsStartFunction()
    {
        if(readfile.StartGameBool)
        {
            audioSource1.Stop();
            audioSource2.Stop();
            audioSource3.Stop();
            audioSource4.Stop();
            audioSource5.Stop();
            audioSource6.Stop();
            audioSource7.Stop();
            audioSource8.Stop();
        }
    }
    

    void Update()
    {
        IsStartFunction();
    }

    public void OnClick1()
    {
        if(button1.interactable)
        {
            if (audioSource1.isPlaying)
            {
                // Si la musique est en cours de lecture, l'arrête
                audioSource1.Stop();
                button1.image.sprite = imageMusiqueInactive;
                
            }
            else
            {
                // Si la musique est arrêtée, la démarre
                audioSource1.Play();
                Debug.Log(audioSource1.isPlaying);
                button1.image.sprite = imageMusiqueActive;
            }

            audioSource2.Stop();
            audioSource3.Stop();
            audioSource4.Stop();
            audioSource5.Stop();
            audioSource6.Stop();
            audioSource7.Stop();
            audioSource8.Stop();

        }
    }

    public void OnClick2()
    {
        if(button2.interactable)
        {
            if (audioSource2.isPlaying)
            {
                // Si la musique est en cours de lecture, l'arrête
                audioSource2.Stop();
                button2.image.sprite = imageMusiqueInactive;
            }
            else
            {
                // Si la musique est arrêtée, la démarre
                audioSource2.Play();
                button2.image.sprite = imageMusiqueActive;
            }

            audioSource1.Stop();
            audioSource3.Stop();
            audioSource4.Stop();
            audioSource5.Stop();
            audioSource6.Stop();
            audioSource7.Stop();
            audioSource8.Stop();
        }
    }
     public void OnClick3()
    {
        if(button3.interactable)
        {
            if (audioSource3.isPlaying)
            {
                // Si la musique est en cours de lecture, l'arrête
                audioSource3.Stop();
                button3.image.sprite = imageMusiqueInactive;
            }
            else
            {
                // Si la musique est arrêtée, la démarre
                audioSource3.Play();
                button3.image.sprite = imageMusiqueActive;
            }

            audioSource2.Stop();
            audioSource1.Stop();
            audioSource4.Stop();
            audioSource5.Stop();
            audioSource6.Stop();
            audioSource7.Stop();
            audioSource8.Stop();
        }
    }
     public void OnClick4()
    {
        if(button4.interactable)
        {
            if (audioSource4.isPlaying)
            {
                // Si la musique est en cours de lecture, l'arrête
                audioSource4.Stop();
                button4.image.sprite = imageMusiqueInactive;
            }
            else
            {
                // Si la musique est arrêtée, la démarre
                audioSource4.Play();
                button4.image.sprite = imageMusiqueActive;
            }

            audioSource2.Stop();
            audioSource3.Stop();
            audioSource1.Stop();
            audioSource5.Stop();
            audioSource6.Stop();
            audioSource7.Stop();
            audioSource8.Stop();
        }
    }
     public void OnClick5()
    {
        if(button5.interactable)
        {
            if (audioSource5.isPlaying)
            {
                // Si la musique est en cours de lecture, l'arrête
                audioSource5.Stop();
                button5.image.sprite = imageMusiqueInactive;
            }
            else
            {
                // Si la musique est arrêtée, la démarre
                audioSource5.Play();
                button5.image.sprite = imageMusiqueActive;
            }

            audioSource2.Stop();
            audioSource3.Stop();
            audioSource4.Stop();
            audioSource1.Stop();
            audioSource6.Stop();
            audioSource7.Stop();
            audioSource8.Stop();
        }
    }
     public void OnClick6()
    {
        if(button6.interactable)
        {
            if (audioSource6.isPlaying)
            {
                // Si la musique est en cours de lecture, l'arrête
                audioSource6.Stop();
                button6.image.sprite = imageMusiqueInactive;
            }
            else
            {
                // Si la musique est arrêtée, la démarre
                audioSource6.Play();
                button6.image.sprite = imageMusiqueActive;
            }

            audioSource2.Stop();
            audioSource3.Stop();
            audioSource4.Stop();
            audioSource5.Stop();
            audioSource1.Stop();
            audioSource7.Stop();
            audioSource8.Stop();
        }
    }
     public void OnClick7()
    {
        if(button7.interactable)
        {
            if (audioSource7.isPlaying)
            {
                // Si la musique est en cours de lecture, l'arrête
                audioSource7.Stop();
                button7.image.sprite = imageMusiqueInactive;
            }
            else
            {
                // Si la musique est arrêtée, la démarre
                audioSource7.Play();
                button7.image.sprite = imageMusiqueActive;
            }

            audioSource2.Stop();
            audioSource3.Stop();
            audioSource4.Stop();
            audioSource5.Stop();
            audioSource6.Stop();
            audioSource1.Stop();
            audioSource8.Stop();
        }
    }
     public void OnClick8()
    {
        if(button8.interactable)
        {
            if (audioSource8.isPlaying)
            {
                // Si la musique est en cours de lecture, l'arrête
                audioSource8.Stop();
                button8.image.sprite = imageMusiqueInactive;
            }
            else
            {
                // Si la musique est arrêtée, la démarre
                audioSource8.Play();
                button8.image.sprite = imageMusiqueActive;
            }

            audioSource2.Stop();
            audioSource3.Stop();
            audioSource4.Stop();
            audioSource5.Stop();
            audioSource6.Stop();
            audioSource7.Stop();
            audioSource1.Stop();
        }
    }


}
