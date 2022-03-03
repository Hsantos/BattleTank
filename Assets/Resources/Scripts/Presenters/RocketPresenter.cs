using hSantos.BattleTank.UseCases;
using UnityEngine;

namespace hSantos.BattleTank.Presenters {
    [RequireComponent(typeof(Rigidbody2D))]
    public class RocketPresenter : MonoBehaviour, IRocketOutput {

        private Rigidbody2D body;
        
        private void Awake() {
            body = GetComponent<Rigidbody2D>();
        }

        public Vector3 Velocity => body.velocity;
        public Quaternion Rotation => transform.rotation;

        public void Launch(Vector3 impulse) {
            body.AddForce(impulse, ForceMode2D.Impulse);
        }

        public void ChangeDirection(Vector3 impulse, Quaternion rotation, Vector2 velocity) {
            transform.rotation = rotation;
            body.velocity = velocity;
            body.AddForce(impulse, ForceMode2D.Impulse);
        }

        public void Explode() {
            //Do some animation
        }
    }
}
