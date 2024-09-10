using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    Vector2 screenBounds;
    int score;

    public Vector2 ScreenBounds { get => screenBounds;  }
    public int Score { get => score; set => score = value; }

    private void Awake()
    {
        #region Singleton
        // Verifica se a inst�ncia � nula
        if (instance == null)
        {
            instance = this; // Define a inst�ncia para este objeto
        }
        else if (instance != this)
        {
            Destroy(gameObject); // Destroi o objeto se j� houver uma inst�ncia existente
        }

        #endregion

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        screenBounds.x += 1;



    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
