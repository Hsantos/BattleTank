using hSantos.BattleTank.UseCases;
using UnityEngine;

namespace hSantos.BattleTank.Presenters {
    
    [RequireComponent(typeof(Rigidbody2D))]
    public class BallPresenter : MonoBehaviour, IBallOutput {
        private Rigidbody2D body;

        [SerializeField] private ParticleSystem particleSystem;
        public Vector2 Velocity => body.velocity;
        private void Awake() {
            body = GetComponent<Rigidbody2D>();
        }

        public void ReceiveHit(Vector2 hit) {
            body.AddForce(hit, ForceMode2D.Impulse);

            var particleSystemVelocityOverLifetime = particleSystem.velocityOverLifetime;
            particleSystemVelocityOverLifetime.yMultiplier = -(Mathf.Round(hit.normalized.y));

            
            particleSystem.Play();
        }

        public void ReceiveFriction(Vector2 friction) {
            body.velocity = friction;
        }
    }
}
