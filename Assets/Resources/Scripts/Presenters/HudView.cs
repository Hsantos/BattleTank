using UnityEngine;

public class HudView : MonoBehaviour, IObserver<ScoreGoalView> {
    [SerializeField] private ScreenButtonView buttonUp;
    [SerializeField] private ScreenButtonView buttonDown;
    [SerializeField] private ScoreView scoreView;

    private int countScoreA;
    private int countScoreB;
    public void Initiate(IObserver<ScreenButtonView> observer, GameSettings gameSettings) {
        buttonUp.Initiate(observer,gameSettings.playerInputDelay);
        buttonDown.Initiate(observer,gameSettings.playerInputDelay);
        
        scoreView.UpdateScorePlayerA(0);
        scoreView.UpdateScorePlayerB(0);
    }

    public void OnNotify(ScoreGoalView item) {
        
        switch (item.PlayerMessage) {
            case PlayerMessage.Player1:
                countScoreB++;
                scoreView.UpdateScorePlayerB(countScoreB);
                break;
            case PlayerMessage.Player2: 
                countScoreA++;
                scoreView.UpdateScorePlayerA(countScoreA);
                break;
        }
    }
}
