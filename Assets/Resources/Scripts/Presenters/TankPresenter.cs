using hSantos.BattleTank.Controllers;
using hSantos.BattleTank.UseCases;
using UnityEngine;

namespace hSantos.BattleTank.Presenters {
    public class TankPresenter : MonoBehaviour, ITankOutput {
        [SerializeField] private Transform rocketOrigin;
        [SerializeField] private RocketPresenter prefabRef;

        public void Shoot(float speed) {
            var obj = Instantiate(prefabRef, rocketOrigin.position, rocketOrigin.rotation);
            var rocket = obj.GetComponent<RocketController>();
            rocket.Launch(rocketOrigin, speed);
        }

        public void DoRotation(Vector3 direction) {
            transform.Rotate(direction.x, direction.y, direction.z);
        }
    }
}
