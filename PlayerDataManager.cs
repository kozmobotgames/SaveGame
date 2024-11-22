using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDataManager : MonoBehaviour
{
    public Transform playerTransform;
    public int health;
    public int score;

    public void SaveGame()
    {
        PlayerData playerData = new PlayerData();
        playerData.position = new float[] { playerTransform.position.x, playerTransform.position.y, playerTransform.position.z };
        playerData.health = GameManager.health;
        playerData.score = ScoreManager.scoreCount;

        string json = JsonUtility.ToJson(playerData);
        string path = Application.persistentDataPath + "/playerData.json";
        System.IO.File.WriteAllText(path, json);
    }

    public void LoadGame()
    {
        string path = Application.persistentDataPath + "/playerData.json";
        if (File.Exists(path))
        {
            string json = System.IO.File.ReadAllText(path);
            PlayerData loadedData = JsonUtility.FromJson<PlayerData>(json);
            
            //disable the controller of the player
            FindObjectOfType<CharacterController>().enabled = false;

            //update player's transform position
            playerTransform.position = new Vector3(loadedData.position[0], loadedData.position[1], loadedData.position[2]);
            Vector3 loadedPosition = new Vector3(loadedData.position[0], loadedData.position[1], loadedData.position[2]);

            //load all the values from playerdata script
            playerTransform.position = loadedPosition;
            GameManager.health = loadedData.health;
            ScoreManager.scoreCount = loadedData.score;

            //re-enable the controller after loading the values
            FindObjectOfType<CharacterController>().enabled = true;
        }
        else
        {
            Debug.LogWarning("File not found!");
        }
    }

    public void LoadPosition()
    {
        string path = Application.persistentDataPath + "/playerData.json";
        if (File.Exists(path))
        {
            string json = System.IO.File.ReadAllText(path);
            PlayerData loadedData = JsonUtility.FromJson<PlayerData>(json);

            //disable the controller of the player
            FindObjectOfType<CharacterController>().enabled = false;

            //update player's transform position
            playerTransform.position = new Vector3(loadedData.position[0], loadedData.position[1], loadedData.position[2]);
            Vector3 loadedPosition = new Vector3(loadedData.position[0], loadedData.position[1], loadedData.position[2]);

            //load all the values from playerdata script
            playerTransform.position = loadedPosition;

            //re-enable the controller after loading the values
            FindObjectOfType<CharacterController>().enabled = true;
        }
        else
        {
            Debug.LogWarning("File not found!");
        }
    }
}
