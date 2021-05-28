using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Step13
{
    public class HighScoreListView : MonoBehaviour
    {
        public Transform root;
        public HighScoreListViewElement highScoreListViewElementPrefab;

        public void ShowHighScore(HighScoreList highScoreList)
        {
            foreach(HighScoreEntry highScoreEntry in highScoreList.highScoreEntries)
            {
                Add(highScoreEntry);
            }
        }

        public void Add(HighScoreEntry highScoreEntry)
        {
            HighScoreListViewElement element = Instantiate<HighScoreListViewElement>(highScoreListViewElementPrefab, root);
            element.Show(highScoreEntry.name, highScoreEntry.highScore);
        }
    }
}