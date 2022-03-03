using hSantos.BattleTank.UseCases;
using UnityEngine;
using UnityEngine.Events;

namespace hSantos.BattleTank.Controllers {
    public class RocketController : ControllerMonoBehaviour<RocketInteractor, IRocketOutput> {

        public UnityAction<RocketController> OnExplode;
        public void Launch(Transform originTransform, float speed) {
            interactor.Launch(-originTransform.up, speed);
        }

        private void OnCollisionEnter2D(Collision2D collision) {
            if (collision.gameObject.GetComponent<WallView>() != null) {
                interactor.OnCollisionWall();
            } else if (collision.gameObject.GetComponent<IBallOutput>() != null) {
                interactor.OnExplode();
                OnExplode?.Invoke(this);
            }
        }
        
    }
}
