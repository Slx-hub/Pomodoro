using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pomo.Core
{
    public class GameController : MonoBehaviour
    {
        public AUIController uiController;
        public ATimerController timerController;
        public AAlarmController alarmController;

        void Start()
        {
            Application.targetFrameRate = 30;

            uiController.Register(ButtonPressed);
            timerController.Register(AlarmRinging);
            alarmController.Register(AlarmDone);
        }

        public void ButtonPressed() {
            Debug.Log("Click!");
            timerController.ToggleTimer();
        }

        public void AlarmRinging() {
            Debug.Log("Ring Ring!");
            alarmController.Ring();
        }

        public void AlarmDone() {
            Debug.Log("....");
        }
    }
}
