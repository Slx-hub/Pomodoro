using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pomo.Core
{
    public abstract class ASimpleEventCaster : MonoBehaviour
    {
        
        private readonly List<Action> listeners = new List<Action>();
        public void Register(Action listener) {
            if (!listeners.Contains(listener)) {
                listeners.Add(listener);
            }
        }

        protected void Notify() {
            listeners.ForEach(act => act());
        } 
    }
}
