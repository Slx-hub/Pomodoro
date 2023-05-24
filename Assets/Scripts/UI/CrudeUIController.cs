using System.Collections;
using System.Collections.Generic;
using TMPro; 
using Pomo.Core;

namespace Pomo.UI
{
    public class CrudeUIController : AUIController
    {
        public TMP_Text buttonText;
        private bool running = false;
        public void AlarmButtonPressed() {
            Notify();
            running = !running;
            if (buttonText is not null) {
                if (running) {
                    buttonText.text = "Stop Timer";
                } else {
                    buttonText.text = "Start Timer";
                }
            }
        } 
    }
}