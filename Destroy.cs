using UnityEngine;

public class DestroySimilarElements : MonoBehaviour
{
    public GameObject[] elementsArray;

    void Start()
    {
        // Vérifie s'il y a au moins un élément dans l'array
        if (elementsArray.Length > 0)
        {
            // Parcourt les éléments de l'array
            for (int i = 0; i < elementsArray.Length; i++)
            {
                // Recherche des éléments similaires dans la scène
                FindAndDestroySimilarElements(elementsArray[i]);
            }
        }
    }

    void FindAndDestroySimilarElements(GameObject targetElement)
    {
        // Obtient tous les GameObjects actifs dans la scène
        GameObject[] allObjects = GameObject.FindObjectsOfType<GameObject>();

        // Utilise un booléen pour s'assurer que nous avons gardé au moins une copie
        bool keptOneCopy = false;

        // Parcourt les éléments de la scène pour comparer avec le targetElement
        for (int i = 0; i < allObjects.Length; i++)
        {
            // Vérifie si l'élément de la scène est similaire au targetElement
            if (AreElementsSimilar(targetElement, allObjects[i]))
            {
                // Si nous n'avons pas encore gardé une copie, on la garde
                if (!keptOneCopy)
                {
                    keptOneCopy = true;
                }
                else
                {
                    // Détruit les éléments supplémentaires similaires
                    Destroy(allObjects[i]);
                }
            }
        }
    }

    bool AreElementsSimilar(GameObject element1, GameObject element2)
    {
        // Ajoutez ici votre logique pour vérifier la similarité des éléments.
        // Cela peut dépendre de la comparaison de composants, de positions, etc.

        // Exemple basique : vérifie si les noms des GameObjects sont les mêmes
        return element1.name == element2.name;
    }
}
