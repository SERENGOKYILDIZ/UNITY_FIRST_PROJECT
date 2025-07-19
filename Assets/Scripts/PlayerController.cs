using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //---------- Player Movement ----------//
    public float speed;

    //---------- FlashLight ----------//
    public GameObject flashLight;
    bool is_on;

    //---------- Fire ----------//
    RaycastHit hit;

    private void Start()
    {
        //---------- FlashLight ----------//
        is_on = flashLight.GetComponent<Light>().enabled;
    }
    private void Update()
    {
        //---------- Player Movement ----------//
        // Tuşların oluşturduğu bir vektörü değişkene atadık.
        Vector3 playerVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        // Hız için ayrı bir vektör tanımladık.
        Vector3 moveVelocity = playerVector * Time.deltaTime * speed;
        // Hız ile konum değişimi yapılıyor. (Güncellendi kamera için)
        transform.Translate(moveVelocity);

        //---------- FlashLight ----------//
        if (Input.GetKeyDown(KeyCode.F))
        {
            is_on = !is_on;
            flashLight.GetComponent<Light>().enabled = is_on;
        }

        /*
         * GameObject.FindGameObjectWithTag("MainCamera") = Camera.main;
         * 
         * aynı anlama gelir. (Özel durum)
         */

        //---------- Fire ----------//
        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity))
            {
                if(hit.collider.gameObject.tag == "Enemy")
                {
                    // Belirtilen GameObject'i siler
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
