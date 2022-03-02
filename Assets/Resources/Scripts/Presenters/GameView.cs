using System;
using hSantos.BattleTank.Controllers;
using hSantos.BattleTank.Presenters;
using UnityEngine;

public class GameView : MonoBehaviour, IObserver<ScreenButtonView> {

    private GameSettings settings;
    [SerializeField] private HudView hudView;
    [SerializeField] private TankController tankControllerA;
    [SerializeField] private TankController tankControllerB;
    [SerializeField] private ScoreGoalView scoreGoalViewA;
    [SerializeField] private ScoreGoalView scoreGoalViewB;
    public void StartGame(GameSettings settings) {
        this.settings = settings;
        hudView.Initiate(this);
        scoreGoalViewA.Initiate(hudView);
        scoreGoalViewB.Initiate(hudView);
    }

    public void OnNotify(ScreenButtonView item) {
        switch (item.PlayerMessage) {
            case PlayerMessage.Player1:
                tankControllerA.NotifyClick();
                break;
            case PlayerMessage.Player2:
                tankControllerB.NotifyClick();
                break;
            default:
                throw new NotImplementedException();
        }
    }
}
