using System;
using hSantos.BattleTank.Controllers;
using hSantos.BattleTank.UseCases;
using UnityEngine;

namespace hSantos.BattleTank.Presenters {
    public class TankPresenter : MonoBehaviour, ITankOutput {
        [SerializeField] private Transform rocketOrigin;
        [SerializeField] private ObjectPoolingMonoBehaviour objectPooling;

       
        public void Shoot(float speed) {
            
            var obj = objectPooling.GetObjectInThePool();
            obj.transform.localPosition = rocketOrigin.position;
            obj.transform.localRotation = rocketOrigin.rotation;
            
            var rocket = obj.GetComponent<RocketController>();
            rocket.OnExplode = OnRocketExplode;
            rocket.Launch(rocketOrigin, speed);
        }

        public void DoRotation(Vector3 direction) {
            transform.Rotate(direction.x, direction.y, direction.z);
        }

        private void OnRocketExplode(RocketController rocket) {
            objectPooling.ReturnObjectInThePool(rocket.gameObject);
        }
    }
}
