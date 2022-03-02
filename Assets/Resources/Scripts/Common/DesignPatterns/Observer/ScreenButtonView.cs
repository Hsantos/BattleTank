using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ScreenButtonView : ObservableMonoBehaviour<ScreenButtonView> {
    
    private Button button;
    [SerializeField] private PlayerMessage playerMessage;
    public PlayerMessage PlayerMessage => playerMessage;

    private void Awake() {
        button = GetComponent<Button>();
    }

    public void Initiate(IObserver<ScreenButtonView> observer) {
        Register(observer);
        button.onClick.AddListener(()=> {
            NotifyAllObservers(this);
        });
    }
}
