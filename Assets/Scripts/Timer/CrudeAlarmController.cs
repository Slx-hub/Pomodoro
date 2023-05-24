using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pomo.Core;

namespace Pomo.Timer
{
    public class CrudeAlarmController : AAlarmController
    {
        public AudioSource audioSource;
        public override void Ring()
        {
            audioSource.Play();
        }
    }

}