using hSantos.BattleTank.UseCases;
using UnityEngine;

namespace hSantos.BattleTank.Controllers {
    public class RocketController : ControllerMonoBehaviour<RocketInteractor, IRocketOutput> {
        
        public void Launch(Transform originTransform) {
            interactor.Launch(-originTransform.up);
        }

        private void OnCollisionEnter2D(Collision2D collision) {
            if (collision.gameObject.GetComponent<WallView>() != null) {
                interactor.OnCollisionWall();
            } else if (collision.gameObject.GetComponent<IBallOutput>() != null) {
                interactor.OnExplode();
            }
        }
        
    }
}
