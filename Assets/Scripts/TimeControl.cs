using UnityEngine;

public class TimeControl : MonoBehaviour
{
    float timer;
    /*
    private void Update()
    {
        // Time.deltaTime = Fps'in 1/f hali. Örneğin 300fps ise 1/300
        // Bilgisayar hangi hızda olursa olsun tam 1 saniye olarak artar.
        timer += 1 * Time.deltaTime;
        print((int)timer);
    }
    */

    private void FixedUpdate()
    {
        // Bilgisayar hangi hızda olursa olsun tam 1 saniye olarak artar.
        // 1/60 * 1
        timer += 1 * Time.fixedDeltaTime;
        print((int)timer);
    }
}
