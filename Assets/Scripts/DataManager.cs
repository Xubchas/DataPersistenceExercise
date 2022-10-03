using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    
    public string playerName;
    public List<Score> currentHighScores;


    void Awake()
    {
        //singleton pattern
        if(Instance != null){
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        
    }

    [System.Serializable]
    public class Score{
        public string recordName;
        public int recordScore;
    }

    [System.Serializable]
    public class HighScoreList{
        public List<Score> highScoreList;
    }

    public void SaveHighscores(){
        HighScoreList data = new HighScoreList();
        data.highScoreList = currentHighScores;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighScores(){
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path)){
            string json = File.ReadAllText(path);
            HighScoreList data = JsonUtility.FromJson<HighScoreList>(json);
            currentHighScores = data.highScoreList;
        }

    }

    //returns the position from 1-10 of the added score, 0 if not added
    public int attemptAddScore(){
        return 0;
    }
}
