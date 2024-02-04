using UnityEngine;
using System.Linq;

public class MoveArrow : MonoBehaviour
{
    public float vitesseDeplacement = 100f; // Speed of movement
    public SpriteRenderer arrowSpriteRenderer;

    void Start()
    {
        
        //Invoke("ScaleUpgrade",2.5f);
        Invoke("ScaleDowngrade",1.5f);
        Destroy(gameObject,3f);
    }
    void Update()
    {
        // Move the arrow to the right
        transform.Translate(Vector3.left * vitesseDeplacement * Time.deltaTime);
 
    }

    void ScaleUpgrade()
    {
        transform.localScale *= 4f; 
    }

    void ScaleDowngrade()
    {
        transform.localScale *= 0.25f; 
    }


    
    

    
}