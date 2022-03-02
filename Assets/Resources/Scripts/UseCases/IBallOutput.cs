
using UnityEngine;

namespace hSantos.BattleTank.UseCases {
    public interface IBallOutput {
        void ReceiveHit(Vector2 direction);
        void ReceiveFriction(Vector2 friction);
        Vector2 Velocity { get; }
    }
}
