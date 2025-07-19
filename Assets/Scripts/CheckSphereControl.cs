using UnityEngine;

public class CheckSphereControl : MonoBehaviour
{
    private void Update()
    {
        // Bu komut hayali bir obje oluşturur ve o hayali küreyi tarar.
        // Hani düşmanın etrafı araması gibi.
        // Ama neye çarptığını kontrol edemiyoruz bununla.
        if(Physics.CheckSphere(transform.position, 1))
        {
            print("OK");
        }
    }
}
