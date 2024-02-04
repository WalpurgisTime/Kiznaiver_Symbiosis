using UnityEngine;
using TMPro;

public class RainbowText : MonoBehaviour
{
    public float colorChangeSpeed = 1.0f; // Vitesse de changement de couleur
    public TextMeshProUGUI textMeshPro;
    private float hueValue = 0.0f;

    void Start()
    {

        // Optionnel : Assurez-vous que le matériel TextMeshPro a une couleur blanche de base
        textMeshPro.color = Color.white;
    }

    void Update()
    {
        // Change la couleur en utilisant la fonction HSVToRGB pour obtenir des couleurs de l'arc-en-ciel
        Color rainbowColor = Color.HSVToRGB(hueValue, 1.0f, 1.0f);

        // Applique la couleur au TextMeshPro
        textMeshPro.color = rainbowColor;

        // Incrémente la valeur de la teinte pour passer à la prochaine couleur de l'arc-en-ciel
        hueValue += colorChangeSpeed * Time.deltaTime;

        // Assurez-vous que la valeur de la teinte reste dans la plage [0, 1]
        if (hueValue > 1.0f)
        {
            hueValue -= 1.0f;
        }
    }
}
