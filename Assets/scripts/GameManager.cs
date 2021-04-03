using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameOverCanvas;

     private void Start() 
    {
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
    }
    
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void LoadGameAgain()
    {
        SceneManager.LoadScene(0);
    }
}
