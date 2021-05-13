using UnityEngine;
using TMPro;

namespace Step11
{
    public class BounceCounter : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI counterLabel;
        private int counter;
        
        private void Awake()
        {
            Reset();
        }

        private void UpdateBounceLabel()
        {
            counterLabel.text = counter.ToString();
        }

        private void OnTriggerExit2D(Collider2D collider2D)
        {
            if(collider2D.gameObject.tag != "Ball")
            {
                return;
            }

            counter++;
            UpdateBounceLabel();
        }

        public void Reset()
        {
            counter = 0;
            UpdateBounceLabel();
        }
    }
}

