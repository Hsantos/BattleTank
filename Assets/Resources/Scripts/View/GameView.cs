using System;
using UnityEngine;

public class GameView : MonoBehaviour, IObserver<ScreenButtonView> {

    private GameSettings settings;
    [SerializeField] private HudView hudView;
    [SerializeField] private TankView tankViewA;
    [SerializeField] private TankView tankViewB;
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
                tankViewA.NotifyClick();
                break;
            case PlayerMessage.Player2:
                tankViewB.NotifyClick();
                break;
            default:
                throw new NotImplementedException();
        }
    }
}
