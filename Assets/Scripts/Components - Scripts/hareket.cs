using UnityEngine;

public class hareket : MonoBehaviour
{
    public GameObject nesne;
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (horizontal, 0f, vertical) * speed * Time.deltaTime;

        nesne.GetComponent<Transform>().transform.Translate (movement);
    }
}
