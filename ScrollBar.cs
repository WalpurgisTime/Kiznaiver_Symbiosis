using System.Collections;
using UnityEngine;
using UnityEngine.UI;



public class ScriptDeModificationDeScale : MonoBehaviour
{
    public GameObject monObject;
    public Button button;
    private bool Opened;

    [Header("Animator Controllers")]
    public Animator animator2;
    public RuntimeAnimatorController newAnimatorController;
    public RuntimeAnimatorController oldAnimatorController;

    [Header("Animation Clips")]
    public AnimationClip clip2;
    public AnimationClip clip3;

    void Start()
    {
        Opened = true;
        animator2.enabled = false; // Désactiver l'Animator au démarrage
    }

    public void OnClick()
    {
        if (button.interactable)
        {
            if (Opened)
            {
                Opened = false;
                monObject.SetActive(true);

                animator2.enabled = true;
                animator2.runtimeAnimatorController = oldAnimatorController;

                animator2.StopPlayback(); //
                animator2.Play(clip2.name);
            }
            else
            {
                Opened = true;
 
                animator2.enabled = true; // Activer l'Animator lorsque le bouton est cliqué
                animator2.runtimeAnimatorController = newAnimatorController;

                animator2.StopPlayback(); //
                animator2.Play(clip3.name);
            }
        }
    }
}

