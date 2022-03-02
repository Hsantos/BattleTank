using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour {
    [SerializeField] private Text labelScorePlayer1;
    [SerializeField] private Text labelScorePlayer2;


    public void UpdateScorePlayerA(int score) {
        labelScorePlayer1.text = score.ToString();
    }
    
    public void UpdateScorePlayerB(int score) {
        labelScorePlayer2.text = score.ToString();
    }
}
