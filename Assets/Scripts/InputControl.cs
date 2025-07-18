using UnityEngine;

public class InputControl : MonoBehaviour
{
    private void Update()
    {
        // 0 = Sol tık, 1 = Sağ tık, 2 = Orta tuş

        // GetMouseButtonDown = Bir kez basınca çalışır
        /*
        if (Input.GetMouseButtonDown(0))
        {
            print("Sol Tık Tıklandı");
        }
        else if (Input.GetMouseButtonDown(1))
        {
            print("Sağ Tık Tıklandı");
        }
        else if (Input.GetMouseButtonDown(2))
        {
            print("Orta Tık Tıklandı");
        }
        */

        // GetMouseButton = Basılı tutulduğu müddetçe çalışır
        /*
        if (Input.GetMouseButton(0))
        {
            print("Sol Tık Tıklanıyor");
        }
        else if (Input.GetMouseButton(1))
        {
            print("Sağ Tık Tıklanıyor");
        }
        else if (Input.GetMouseButton(2))
        {
            print("Orta Tık Tıklanıyor");
        }
        */

        // GetMouseButtonUp = Basıp çekince bir kez çalışır
        /*
        if (Input.GetMouseButtonUp(0))
        {
            print("Sol Tık Tıklanmış");
        }
        else if (Input.GetMouseButtonUp(1))
        {
            print("Sağ Tık Tıklanmış");
        }
        else if (Input.GetMouseButtonUp(2))
        {
            print("Orta Tık Tıklanmış");
        }
        */

        // GetMouseButton ve türevleri nasılsa aynısı GetKey ve türevleri içinde geçerli
        /*
        if (Input.GetKeyDown(KeyCode.F))
        {
            print("F tuşuna Tıklandı");
        }
        if (Input.GetKey(KeyCode.F))
        {
            print("F tuşuna Tıklanıyor");
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            print("F tuşuna Tıklanmış");
        }
        */

        // GetAxis = Yön tuşlarını kontrol etmeye yarar.
        // Not: Edit - >Project Settings... -> Input Manager kısmından ayarlanan tuş takımlarını kontrol eder.
        // Horizontal = Yatay Eksen, Vertical = Düşey Eksen
        //print(Input.GetAxis("Horizontal"));
        //print(Input.GetAxis("Vertical"));
    }
}
