using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreatePlay : MonoBehaviour
{
    public Button Play;
    public Button Create;
    // Start is called before the first frame update
    void Start()
    {
        

    }
    public void OnClickCreate()
    {
        if(Play.interactable)
        {
            SceneManager.LoadScene("Second Scene");
        }
    }

    public void OnClickPlay()
    {
        if(Create.interactable)
        {
            SceneManager.LoadScene("Third Scene");
            
        }
    }
}
