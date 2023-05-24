using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using Pomo.Core;

namespace Pomo.Timer
{
    public class CrudeTimerController : ATimerController
    {
        
        public TMP_Text timerText;
        private int[] timerArray = {25*60,5*60};
        private float timeLeft;
        private int timerRun = 0;
        private bool isRunning = false;

        void Start()
        {
            timeLeft = timerArray[0];
            setTime();
        }

        void Update()
        {
            if (isRunning) {
                timeLeft -= Time.deltaTime;
                if (timeLeft < 0) {
                    timeLeft = timerArray[++timerRun % timerArray.Length];
                    Ring();
                }
                setTime();
            }
        }

        public override void ToggleTimer() {
            Debug.Log("Tick Tock MF!");
            isRunning = !isRunning;
            timerRun = 0;
            timeLeft = timerArray[0];
            setTime();
        }

        private void setTime() {
            int minutes = Mathf.FloorToInt(timeLeft / 60);
            int seconds = Mathf.FloorToInt(timeLeft % 60);

            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        } 
        
    }
}