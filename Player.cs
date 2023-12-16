using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed = 5.0f; // A játékos mozgási sebessége

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
        
    }

}