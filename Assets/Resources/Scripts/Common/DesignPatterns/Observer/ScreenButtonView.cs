using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ScreenButtonView : ObservableMonoBehaviour<ScreenButtonView> {
    
    private Button button;
    [SerializeField] private PlayerMessage playerMessage;
    public PlayerMessage PlayerMessage => playerMessage;
    public bool canPressButton;
    private float timeLeft;
    private float inputDelay;
    private void Awake() {
        button = GetComponent<Button>();
    }

    public void Initiate(IObserver<ScreenButtonView> observer, float inputDelay) {
        this.inputDelay = inputDelay;
        timeLeft = inputDelay;
        Register(observer);
        
        button.onClick.AddListener(()=> {
            if (canPressButton) {
                canPressButton = false;
                NotifyAllObservers(this);
            }
        });
    }
    
    void Update()
    {
        if (canPressButton) {
            return;
        }
        
        timeLeft -= Time.deltaTime;
        if( timeLeft <= 0)
        {
            canPressButton = true;
            timeLeft = inputDelay;
        }
    }
}
