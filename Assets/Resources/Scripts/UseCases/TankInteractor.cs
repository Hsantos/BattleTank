using UnityEngine;

namespace hSantos.BattleTank.UseCases {
    public class TankInteractor: Interactor<ITankOutput> {
        private bool rotationStarted;
        private float speed;
        private float rocketSpeed;

        public void Initiate(GameSettings settings) {
            speed = settings.tankSpeedRotation;
            rocketSpeed = settings.rocketSpeed;
        }
        public TankInteractor() {
            rotationStarted = true;
        }

        public void UpdateTank() {
            if (!rotationStarted) {
                return;
            }

            output.DoRotation(new Vector3(0, 0, (-180 * Time.deltaTime * speed)));
        }

        public void NotifyClick() {
            output.Shoot(rocketSpeed);
        }
    }
}