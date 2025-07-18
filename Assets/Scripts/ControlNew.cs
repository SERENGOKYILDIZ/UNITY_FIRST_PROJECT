using UnityEngine;

public class ControlNew : MonoBehaviour
{
    /*
    public Rigidbody rb;
    */
    // MovePosition ile konum hareketi yapıldı
    /*
    public GameObject target;
    public Vector3 myVec;

    private void Start()
    {
        Vector3 vec = target.GetComponent<Transform>().position;
        rb.MovePosition(vec);
        myVec = vec;
    }

    private void Update()
    {
        rb.MovePosition(myVec);
    }
    */

    // Velocity ile hız verdik
    /*
    public Vector3 direction;
    private void Start()
    {
        rb.linearVelocity = direction;
    }
    */
    public GameObject myCube;
    public Vector3 myTransform;
    private void Start()
    {
        // Belirtilen objenin boyutunu değiştirir
        //myCube.GetComponent<Transform>().localScale = new Vector3(10, 5, 3);

        // Belirtilen objenin konuma götürür. Geçerli konum ile verilen vektörü toplar
        // o yüzden sürekli çalışırsa gitmeye devam eder.
        // myCube.GetComponent<Transform>().Translate(myTransform);

        // Bu sefer vektörce döndürür. Gene vektörel toplama vardır.
        myCube.GetComponent<Transform>().Rotate(myTransform);

        // Sadece Transform Component'ini özel tanımlama yapılabilir.
        myCube.transform.Rotate(myTransform);

    }

    /*
    private void Update()
    {
        myCube.GetComponent<Transform>().Translate(myTransform);
    }
    */
}
