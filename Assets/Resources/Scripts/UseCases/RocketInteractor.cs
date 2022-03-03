using UnityEngine;

namespace hSantos.BattleTank.UseCases {
    public class RocketInteractor: Interactor<IRocketOutput> {
        private float speed;
        private Vector3 direction;
        public void Launch(Vector3 direction, float speed) {
            this.speed = speed;
            this.direction = direction;
            var impulse = direction * speed;
            output.Launch(impulse);
        }
        public void OnCollisionWall() {
            Quaternion rot = output.Rotation;
            var quart = new Quaternion(rot.x, rot.y, rot.z * -1, rot.w);
            direction = new Vector3(direction.x * -1, direction.y, direction.z) * speed;
            output.ChangeDirection(direction, quart, Vector2.zero);
        }
        
        public void OnExplode() => output.Explode();
    }
}
