using UnityEngine;

public class test : MonoBehaviour
{
    public Control control;
    private void Awake()
    {
        //GetComponent<Control>().sayi = 200;

        //GetComponent<Control>().Print();

        // Görüldüğü gibi kendi yazdığımız scriptler bile değişken olarak tanımlanabilir.
        control = GetComponent<Control>();
        control.sayi = 1000;
    }
}
