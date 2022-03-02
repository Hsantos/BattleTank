using System;
using hSantos.BattleTank.Presenters;
using UnityEngine;

public class ScoreGoalView : ObservableMonoBehaviour<ScoreGoalView> {

    [SerializeField] private PlayerMessage playerMessage;
    public PlayerMessage PlayerMessage => playerMessage;
    
    public void Initiate(IObserver<ScoreGoalView> observer) {
        Register(observer);
    }
   
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.transform.GetComponent<BallPresenter>() != null) {
            NotifyAllObservers(this);
        }
    }
}
