using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProgressBar : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider progressBar;

    private void Start()
    {
        progressBar.minValue = 0f;
        progressBar.maxValue = audioSource.clip.length;
        progressBar.value = 0f;

        
    }

    

    public IEnumerator UpdateProgressBar()
    {
        while (audioSource.isPlaying)
        {
            Debug.Log("On y est ");
            progressBar.value = audioSource.time;
            yield return new WaitForSeconds(0.1f);
        }
        progressBar.value = audioSource.clip.length;
    }
}
