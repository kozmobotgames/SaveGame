using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameButton : MonoBehaviour
{
    private void Start()
    {
        if (MenuNavigation.isLoaded)
        {
            Debug.Log("Level: " + LevelLoader.level);
            FindObjectOfType<PlayerDataManager>().LoadGame();
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
}
