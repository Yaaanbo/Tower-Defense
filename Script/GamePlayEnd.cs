using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayEnd : MonoBehaviour
{
    float timer = 0;
    // Start is called before the first frame update
    void Update()
    {
        if (Data.isGameOver)
        {
            timer += Time.deltaTime;
             if (timer > 2)
             {
                SceneManager.LoadScene("GameOver");
             }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
          Application.Quit();
        }
    }
}
