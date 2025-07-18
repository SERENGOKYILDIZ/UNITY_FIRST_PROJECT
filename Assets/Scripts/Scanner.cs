using UnityEngine;

public class Scanner : MonoBehaviour
{
    public GameObject enemy;            // Tek eleman

    public GameObject[] enemies;        // Dizi eleman

    private void Start()
    {
        // Tag'i "Enemy" olan GameObject'i tanımlar.
        /*
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        enemy.GetComponent<Transform>().localScale = new Vector3(2, 2, 6);
        print(enemy);
        */

        /*
        // Tag'i "Enemy" olan GameObject'leri tanımlar.
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        for(int i = 0; i < enemies.Length; i++)
        {
            enemies[i].GetComponent<Transform>().localScale = new Vector3(2, 2, 6);
            print(enemies[i]);
        }
        */

        // Direk adı ile bulmak için
        enemy = GameObject.Find("myCube - Enemy");
        print(enemy);
    }
}
