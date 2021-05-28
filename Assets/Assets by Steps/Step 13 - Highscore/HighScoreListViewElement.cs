using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Step13
{   public class HighScoreListViewElement : MonoBehaviour
    {
        public TextMeshProUGUI nameLabel;
        public TextMeshProUGUI scoreLabel;

        public void Show(string name, int score)
        {
            nameLabel.text = name;
            scoreLabel.text = score.ToString();
        }
    }
}

