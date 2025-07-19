using UnityEngine;

public class RaycastControl : MonoBehaviour
{
    RaycastHit hit; // Lazerin çarptığı cismin bilgilerini taşır.
    private void Update()
    {
        // İşlevsiz ama görünen bir lazer ekler.
        // Hani ateş etmeye ve item bakmaya yarayan lazer varya onu.
        // Lazerin yönünü z ekseni yapalım. z'si bir olan bir yönelim vektörü ile
        // Not: Çalıştırınca Scene pencerisince 1 birimlik beyaz bir çizgi olarak gözükür.
        //Debug.DrawRay(transform.position, new Vector3(0, 0, 1));

        // "Vector3.forward = new Vector3(0, 0, 1)" anlamına gelir zaten. Renk verdik ayrıca.
        //Debug.DrawRay(transform.position, Vector3.forward, Color.red);

        // Cismin Local yönüne bakması için değişiklik yaptık. Arttık döndükçe önünüe bakabiliyor.
        // Yere baktığı zaman itemları görebilir.
        //Debug.DrawRay(transform.position, transform.forward, Color.red);                    //Ön

        // Bu arada bunlarda kullanılabilir. Üzerine gelince hangi taraf olduğu yazıyor.
        //Debug.DrawRay(transform.position, transform.forward * (-1), Color.red);           //Arka (Vektörel çarpım ile)
        //Debug.DrawRay(transform.position, transform.up, Color.red);                       //Üst
        //Debug.DrawRay(transform.position, transform.up * (-1), Color.red);                //Alt (Vektörel çarpım ile)
        //Debug.DrawRay(transform.position, transform.right, Color.red);                    //Sağ
        //Debug.DrawRay(transform.position, transform.right * (-1), Color.red);             //Sol (Vektörel çarpım ile)

        /// Şimdi Gerçek bir lazer üzerinde çalışma zamanı:
        // (Pozisyon, yönelim, çıkış hiti, lazer uzunluğu)
        // Eğer cismimizin önünde bir cisim var ise bool = true olur
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
            // Aşağıda yazılan ifade ile direk GameObject'i çekebiliriz.
            GameObject target = hit.collider.gameObject;
            print("Eşya var: " + target.name);
            // Not: Fark edildiği gibi eğer çarpılan objede collider compenenti yoksa bilgi çekemeyiz.
        }
    }
}
