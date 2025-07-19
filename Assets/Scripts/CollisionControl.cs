using UnityEngine;

public class CollisionControl : MonoBehaviour
{
    // Eğer herhangi bir collider componentli bir GameObject ile çarpışırsa bu fonksiyon çalışır.
    // İki cismin çarpışmasının tetiklenmesinde kullanılabilir.
    // Not: İki GameObject'ten en az herhangi birinde RigidBody componenti olmalı.
    /*
    private void OnCollisionEnter(Collision collision)
    {
        print("Eleman: " + collision.gameObject.name);
    }
    */

    // Bu ise bizim collider'ımızın içinden geçmesi durumunda çalışır.
    // Oyuncunun bir odaya girdiği zaman tetik alması gibi durumlarda kullanılabilir.
    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
    }
}
