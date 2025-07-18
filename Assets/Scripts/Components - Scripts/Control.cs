using UnityEngine;

public class Control : MonoBehaviour
{
    public GameObject myLight;
    public int sayi;

    public Light light;
    void Start()
    {
        //print(myLight);
        myLight.GetComponent<Light>().intensity = 100;

        /* 
         Eğer "GetComponent<Light>().intensity = 100;" şeklinde yazsaydım.
         Direk kodun bağlı olduğu GameObject'in içinde arayacaktı Component'i.
        */

        //print(this);

        //print(sayi);


        //-------------------------------------------------------------------//

        // Görüldüğü gibi Component'lar bir değişken gibi tanımlanabilir ve kullanılabilir.
        light = myLight.GetComponent<Light>();
        light.intensity = 100;
        light.color = Color.red;
    }

    public void Print()
    {
        print("Yazdırma işlemi");
    }
}
