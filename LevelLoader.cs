using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public int levelToChange;
    public int scoreGoal;
    public static int level;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreManager.scoreCount > scoreGoal)
        {
            SceneManager.LoadScene(levelToChange);
        }
    }
}
