using hSantos.BattleTank.UseCases;
using Hsantos.BattleTank.UseCases;
using UnityEngine;

namespace hSantos.BattleTank.Controllers {
    public class BallController : ControllerMonoBehaviour<BallInteractor,IBallOutput> {
        
        private void OnCollisionEnter2D(Collision2D collision) {
            
            interactor.UpdateHit(collision.transform.up * -1);
        }
        private void FixedUpdate() {
            interactor.UpdateFriction();
        }
    }
}
