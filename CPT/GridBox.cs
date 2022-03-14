using System;
using System.Collections;
using UnityEngine;

namespace CPT {
    public class GridBox : MonoBehaviour {
        public string assignedLetter;
        public string word;

        public void Awake() {
            StartCoroutine(DelayLogs(0.5f));
        }

        private IEnumerator DelayLogs(float seconds) {
            yield return new WaitForSecondsRealtime(seconds);
            Debug.Log($"Assigned Letter: {assignedLetter}\nAssigned Word: {word}");
        }
    }
}