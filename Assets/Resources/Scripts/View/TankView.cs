using System;
using UnityEngine;

public class TankView : MonoBehaviour {
    private bool rotationStarted;
    private float speed = 0.5f;
    [SerializeField] private Transform rocketOrigin;
    private void Awake() {
        StartBehaviour();
    }

    public void NotifyClick() {
        DispatchRocket(Instantiate(Resources.Load<RocketView>("Prefabs/Rocket"),rocketOrigin.position, rocketOrigin.rotation));
    }
    private void DispatchRocket(RocketView rocket) {
        rocket.Launch(rocketOrigin);
    }

    private void StartBehaviour() {
        rotationStarted = true;
    }
    
    private void StopBehaviour() {
        rotationStarted = false;
    }

    void Update() {
        if (!rotationStarted) {
            return;
        }
        
        transform.Rotate(0,0,(-180*Time.deltaTime * speed));
    }
}
