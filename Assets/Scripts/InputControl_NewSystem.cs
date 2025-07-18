using UnityEngine;
using UnityEngine.InputSystem;

public class InputControl_NewSystem : MonoBehaviour
{
    public float moveSpeed;

    // Aciton Map'te bulunan Action'lar
    public InputActionReference move;
    public InputActionReference fire;

    Rigidbody rb;
    Vector3 vec;
    Vector2 _moveDirection;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Buradadan WASD tuşlarına yaptığımız atama ile oluşan Vector2 değişkenini çekiyoruz.
        _moveDirection = move.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        // Rigidbody'miz 3D olduğu için Vector2'yi Vector3'e çeviriyoruz.
        vec = new Vector3(_moveDirection.x, _moveDirection.y);

        // Sürekli olarak oluşan vektörü hız eklemesi yapıyoruz. (x-z ekseni için biraz değiştirdik)
        rb.linearVelocity = new Vector3(vec.x * moveSpeed, 0, vec.y * moveSpeed);
    }

    private void OnEnable()     // Her InputAction olayı olunca buraya girer.
    {
        fire.action.started += Fire;
    }
    private void OnDisable()    // Her InputAction olayı olmadığı zaman buraya girer.
    {
        fire.action.started -= Fire;
    }

    private void Fire(InputAction.CallbackContext context) //Belirttiğimiz olayın fonksiyonu
    {
        // Örneğin F tuşuna basınca aşağısı çalışacak
        Debug.Log("Ateş tuşuna basındı!");
    }
}
