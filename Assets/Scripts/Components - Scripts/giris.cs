using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class giris : MonoBehaviour
{
    public GameObject girisYazisi;
    TextMeshProUGUI textMeshProUGUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textMeshProUGUI = girisYazisi.GetComponent<TextMeshProUGUI>();
        if (textMeshProUGUI == null)
        {
            Debug.LogError("girisYazisi GameObject does not have a TextMeshPro component.");
            return;
        }
        textMeshProUGUI.text = "Hoş buldum kanka";
        textMeshProUGUI.color = Color.darkRed; // Set the text color to white
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onTiklama()
    {
        textMeshProUGUI.text = "Tıklandı!!";
        textMeshProUGUI.color = Color.darkRed; // Set the text color to white
    }
}
