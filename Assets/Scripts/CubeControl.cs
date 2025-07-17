using UnityEngine;

public class CubeControl : MonoBehaviour
{
    private void Start()
    {
        // Bounds = Box Collider'ın sınırlarının konum bilgisine erişim sağlar.
        float max = GetComponent<BoxCollider>().bounds.max.y;
        float min = GetComponent<BoxCollider>().bounds.min.y;
        print("Max : " + max + ", Min : " + min);

        //Vector
        Vector2 vector;
        vector.x = 3f;
        vector.y = 4f;
        print(vector);
    }
}
