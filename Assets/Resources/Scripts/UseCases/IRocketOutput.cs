
using UnityEngine;

namespace hSantos.BattleTank.UseCases {
    public interface IRocketOutput {
        Quaternion Rotation { get; }
        void Launch(Vector3 impulse);
        void ChangeDirection(Vector3 impulse, Quaternion rotation, Vector2 velocity);
        void Explode();
    }
}