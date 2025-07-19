using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSensitiviy = 100f;
    public GameObject player;
    float xRotation;

    private void Start()
    {
        // Mouse odağını oyuna odaklar.
        Cursor.lockState = CursorLockMode.Locked;
        // Mouse imlecini gizler
        Cursor.visible = false;
    }
    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitiviy;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensitiviy;

        xRotation -= mouseY;                                            // Ters olduğu için çıkarttık
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);                  // Sınır belirlemek için kullanılır.

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);    // X eksenini bu şekilde snırlı atadık.

        player.transform.Rotate(Vector3.up * mouseX);
    }
}
