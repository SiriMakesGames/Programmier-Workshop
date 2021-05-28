using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using Step11;
using TMPro;

namespace Step13
{
    public class ScoreSaver : MonoBehaviour
    {
        public BounceCounter bounceCounter;
        public HighScoreListView highScoreListView;
        public TMP_InputField inputField;

        private HighScoreList highScoreList;
        private string path;
            
        private void Awake() 
        {
            path = $"{Application.persistentDataPath}/highScoreList.txt";
            Debug.Log(path);
            ReadHighScoreList();
            highScoreListView.ShowHighScore(highScoreList);
        }

        private void OnEnable()
        {
            inputField.enabled = true;
            inputField.text = "Your name";
        }

        private void ReadHighScoreList()
        {
            string json = ReadFromFile();
            if(string.IsNullOrEmpty(json))
            {
                highScoreList = new HighScoreList();
            }
            else
            {
                highScoreList = JsonUtility.FromJson<HighScoreList>(json);
            }
        }

        private string ReadFromFile()
        {
            if(!File.Exists(path))
            {
                return string.Empty;
            }

            return File.ReadAllText(path);
        }
        public void SaveScore (string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                return;
            }

            inputField.enabled = false;

            HighScoreEntry newEntry = highScoreList.Add(name, bounceCounter.Score);
            SaveToFile(JsonUtility.ToJson(highScoreList));
            highScoreListView.Add(newEntry);
        }

        private void SaveToFile(string json)
        {
            if(!File.Exists(path))
            {
                var fs = new FileStream(path, FileMode.Create);
                fs.Dispose();
            }

            File.WriteAllText(path, json);
        }
    }

    [Serializable]
    public class HighScoreEntry
    {
        public string name;
        public int highScore;
    }

    [Serializable]
    public class HighScoreList
    {
        public List<HighScoreEntry> highScoreEntries = new List<HighScoreEntry>();

        public HighScoreEntry Add(string name, int score)
        {
            HighScoreEntry newEntry = new HighScoreEntry(){name = name, highScore = score};
            highScoreEntries.Add(newEntry);
            return newEntry;
        }
    }
}