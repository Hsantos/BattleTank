using hSantos.BattleTank.UseCases;
using UnityEngine;

namespace Hsantos.BattleTank.UseCases {
    public class BallInteractor: Interactor<IBallOutput> {
        
        private int force = 50;
        private int speed;
        public void UpdateHit(Vector2 direction) {
            speed += force;
            output.ReceiveHit(direction * force);
        }
        public void UpdateFriction() {
            if (speed > 0) {
                var velocity = output.Velocity;
                velocity -= 0.1f * velocity;
                output.ReceiveFriction(velocity);
                speed--;
            }
        }

        
    }
}
