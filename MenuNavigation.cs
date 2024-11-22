using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{
    private PlayerData dataManager;
    public static bool isLoaded;
    public int levelToLoad;

    private void Start()
    {

    }

    public void NewGame()
    {
        isLoaded = false;
        ScoreManager.scoreCount = 0;
        Debug.Log("Game is not loaded! " + isLoaded);
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadGame()
    {
        isLoaded = true;
        //ScoreManager.scoreCount = dataManager.score;
        Debug.Log("Game is loaded! " + isLoaded);
        Debug.Log("Level " + LevelLoader.level);
        if(LevelLoader.level == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (LevelLoader.level == 1)
        {
            SceneManager.LoadScene("LevelTwo");
        }
        if (LevelLoader.level == 2)
        {
            SceneManager.LoadScene("Level3");
        }
    }
}
