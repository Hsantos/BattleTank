
using UnityEngine;

namespace hSantos.BattleTank.UseCases {
    public interface ITankOutput {
        void Shoot();
        void DoRotation(Vector3 direction);
    }
}
