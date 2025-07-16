using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Basic Variables
    string name;
    int num;
    float lenght;
    bool button;

    // public/private
    private int myNum = 2;
    public string myName;
    public bool goster;

    //Arrays
    float[] values = {1.2f, 0.5f};

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Hello World");
    }


    // Start'dan daha önce çalışır
    private void Awake()
    {
        
    }

    // Saniyede 300 kez çalışır (ortalama)
    void Update()
    {
        
    }

    // Update gibi ama saniyede 60 kez çalışır
    private void FixedUpdate()
    {
        
    }

    // Update çalıştıkdan sonra çalışır
    private void LateUpdate()
    {
        
    }
}
