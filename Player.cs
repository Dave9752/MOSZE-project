using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int keys = 0;  // A játékos által begyűjtött kulcsok száma
    public float speed = 5.0f; // A játékos mozgási sebessége

    public Text keyAmount; // A kulcsok számát megjelenítő szövegobjektum
    public Text youWin; // A játékos győzelmét jelző szövegobjektum
    public GameObject door; // A befejezést blokkoló objektum

    // A játék kezdete előtti inicializálás
    void Start()
    {

    }

    // A játék folyamán minden képkockában végrehajtandó frissítés
    [System.Obsolete]
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) // A játékos balra mozgatása
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow)) // A játékos jobbra mozgatása
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow)) // A játékos felfelé mozgatása
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow)) // A játékos lefelé mozgatása
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
        if (keys==7) // Ha a játékos összes (7) kulcsot megszerezte
             {
                 Destroy(door); // A befejezést blokkoló objektum eltávolítása
             }
    }
// A 2D-s ütközések kezelésére szolgáló metódus
private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Keys") // Ha a kulcsokkal való ütközés történt
        {
            keys++; // Kulcs számának növelése
            keyAmount.text = "Keys: " + keys; // A kulcs számának frissítése
            Destroy(collision.gameObject); // A kulcs objektum eltávolítása
        }
        if (collision.gameObject.tag == "Exit") // Ha a cél objektummal való ütközés történt
        {
            youWin.text = "Gratulálok, nyertél! :)"; // Győztes üzenet megjelenítése
        }
        if (collision.gameObject.tag == "Enemies") // Ha az ellenséges objektummal való ütközés történt
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // A pálya újratöltése
        }  
    }
}
