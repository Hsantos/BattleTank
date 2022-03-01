using System;
using UnityEngine;

public class ScoreGoalView : ObservableMonoBehaviour<ScoreGoalView> {

    [SerializeField] private PlayerMessage playerMessage;
    public PlayerMessage PlayerMessage => playerMessage;
    
    public void Initiate(IObserver<ScoreGoalView> observer) {
        Register(observer);
    }
   
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("OnCollisionEnter2D Hit Goal");
        if (other.transform.GetComponent<BallView>() != null) {
            NotifyAllObservers(this);
        }
    }
}
