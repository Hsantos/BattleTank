
using UnityEngine;

namespace hSantos.BattleTank.UseCases {
    public interface ITankOutput {
        void Shoot(float speed);
        void DoRotation(Vector3 direction);
    }
}
