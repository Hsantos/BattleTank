using hSantos.BattleTank.UseCases;
using UnityEngine;

namespace hSantos.BattleTank.Presenters {
    
    [RequireComponent(typeof(Rigidbody2D))]
    public class BallPresenter : MonoBehaviour, IBallOutput {
        private Rigidbody2D body;
        public Vector2 Velocity => body.velocity;
        private void Awake() {
            body = GetComponent<Rigidbody2D>();
        }

        public void ReceiveHit(Vector2 hit) {
            body.AddForce(hit, ForceMode2D.Impulse);
        }

        public void ReceiveFriction(Vector2 friction) {
            body.velocity = friction;
        }
    }
}
