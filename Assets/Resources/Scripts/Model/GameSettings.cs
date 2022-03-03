
using System;
using UnityEngine;

[Serializable]
public class GameSettings {
    [Header("The velocity of the tank rotation. It's faster if the value is higher")]
    [Space(20f)]
    public float tankSpeedRotation;
    
    [Header("Speed velocity of the rocket after launch. It's faster if the value is higher")]
    [Space(20f)]
    public float rocketSpeed;
    
    [Header("Affect the friction of the ball. It's slower if the value is higher")]
    [Space(50f)]
    public int ballWeight;
    
    [Header("Seconds delay during player input, to avoid stress input, more delay if the value is higher")]
    [Space(20f)]
    public float playerInputDelay;
}
