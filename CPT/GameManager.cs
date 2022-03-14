using System.Collections.Generic;
using UnityEngine;

namespace CPT; 

public class GameManager : MonoBehaviour {
    #pragma warning disable CS0649
    private static GameManager _instance;
    #pragma warning restore CS0649
    
    public static GameManager Instance {
        get {
            if(_instance == null)
                Debug.LogError("GameManager instance is null!");
            return _instance;
        }
    }
    
    public List<string> selectedWords = new List<string>();
    public GameObject box;
    public Transform[] gridPoints;

    public void Awake() {
        PopulateWordList();
        CreateGrid();
    }

    public void CreateGrid() {
        foreach (var word in selectedWords) {
            var i = 0;
            foreach (var letter in word) {
                var newBox = Instantiate(box, transform).GetComponent<GridBox>();
                newBox.assignedLetter = letter.ToString();
                newBox.word = word;
                newBox.transform.position = gridPoints[i].position;
                i++;
            }
        }
    }

    public void PopulateWordList() {
        selectedWords.Clear();
        for (var i = 0; i < 5; i++) {
            selectedWords.Add(Utils.PickRandomWord(Random.Range(3, 5)));
        }
    }

    public string GetWordAtIndex(int index) {
        return selectedWords[index];
    }
}