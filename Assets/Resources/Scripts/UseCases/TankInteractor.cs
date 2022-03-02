using UnityEngine;

namespace hSantos.BattleTank.UseCases {
    public class TankInteractor: Interactor<ITankOutput> {
        private bool rotationStarted;
        private float speed = 0.5f;
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
            output.Shoot();
        }
    }
}