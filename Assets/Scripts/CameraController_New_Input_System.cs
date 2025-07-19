using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController_New_Input_System : MonoBehaviour
{
    public float mouseSensitiviy = 100f;
    public GameObject player;
    float xRotation;
    public InputActionReference mouse;

    private void Start()
    {
        // Mouse odağını oyuna odaklar.
        Cursor.lockState = CursorLockMode.Locked;
        // Mouse imlecini gizler
        Cursor.visible = false;
    }
    private void Update()
    {
        Vector2 delta = Mouse.current.delta.ReadValue();

        float mouseX = delta.x * Time.deltaTime * mouseSensitiviy / 20;
        float mouseY = delta.y * Time.deltaTime * mouseSensitiviy / 20;

        xRotation -= mouseY;                                            // Ters olduğu için çıkarttık
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);                  // Sınır belirlemek için kullanılır.

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);    // X eksenini bu şekilde snırlı atadık.

        player.transform.Rotate(Vector3.up * mouseX);
    }
}
