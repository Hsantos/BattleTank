using UnityEngine;

public class Startup : MonoBehaviour {
    [SerializeField] private GameSettingsScriptableObject gameSettings;
    [SerializeField] private GameView gameView;

    void Start() {
        gameView.StartGame(gameSettings.GameSetting);
    }
}
