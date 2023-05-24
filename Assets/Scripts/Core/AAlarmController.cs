using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pomo.Core
{
    public abstract class AAlarmController : ASimpleEventCaster
    {
        public void AlarmFinished() {
            Notify();
        } 

        public abstract void Ring();
    }
}
