using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "GameSettings", menuName = "ScriptableObjects/GameSettings")]
public class GameSettingsScriptableObject : ScriptableObject {
    [SerializeField] public GameSettings GameSetting;
}
