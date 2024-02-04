using UnityEngine;

public class DestroyDuplicatesOnSceneChange : MonoBehaviour
{
    
    public GameObject[] objectsToPersist;

    private void Awake()
    {
        foreach (GameObject obj in objectsToPersist)
        {
            DontDestroyOnLoad(obj);
        }
    }

}
