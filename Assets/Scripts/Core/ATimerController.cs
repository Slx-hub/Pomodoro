using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pomo.Core
{
    public abstract class ATimerController : ASimpleEventCaster
    {
        public void Ring() {
                Notify();
        } 

        public abstract void ToggleTimer();
    }
}
