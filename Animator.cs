using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatorScript : MonoBehaviour
{
    public GameObject monObject;
    public Button button;
    private bool Opened;

    public Animator animator2;
    public AnimationClip clip2;

    void Start()
    {
        Opened = true;
    }

    public void OnClick()
    {
        if (button.interactable)
        {
            if (Opened)
            {
                Opened = false;
                animator2.Play(clip2.name); // Play from the start
            }
            else
            {
                Opened = true;
                animator2.Play(clip2.name); // Play from the end (reverse)
            }

            // Debugging information
            Debug.Log("Animation is now " + (Opened ? "opened" : "closed"));
        }
    }
}
