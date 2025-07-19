using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController_New_Input_System : MonoBehaviour
{
    //---------- Player Movement ----------//
    public float speed;
    public InputActionReference move;

    //---------- FlashLight ----------//
    public GameObject flashLight;
    public InputActionReference flash;
    bool is_on;

    //---------- Fire ----------//
    RaycastHit hit;
    public InputActionReference fire;
    private void Start()
    {
        //---------- FlashLight ----------//
        is_on = flashLight.GetComponent<Light>().enabled;
    }
    private void Update()
    {
        //---------- Player Movement ----------//
        // Tuşların oluşturduğu bir vektörü değişkene atadık.
        Vector2 vec = move.action.ReadValue<Vector2>();
        Vector3 playerVector = new Vector3(vec.x, 0, vec.y);
        // Hız için ayrı bir vektör tanımladık.
        Vector3 moveVelocity = playerVector * Time.deltaTime * speed;
        // Hız ile konum değişimi yapılıyor. (Güncellendi kamera için)
        transform.Translate(moveVelocity);

    }
    private void OnEnable()
    {
        flash.action.Enable();
        flash.action.started += Flash;

        fire.action.Enable();
        fire.action.started += Fire;
    }

    private void OnDisable()
    {
        flash.action.started -= Flash;
        fire.action.started -= Fire;
    }

    //---------- FlashLight ----------//
    private void Flash(InputAction.CallbackContext context)
    {
        is_on = !is_on;
        flashLight.GetComponent<Light>().enabled = is_on;

    }
    //---------- Fire ----------//
    private void Fire(InputAction.CallbackContext context)
    {
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject.tag == "Enemy")
            {
                // Belirtilen GameObject'i siler
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
