using hSantos.BattleTank.UseCases;

namespace hSantos.BattleTank.Controllers {
    public class TankController : ControllerMonoBehaviour<TankInteractor,ITankOutput> {
        void Update() {
            interactor.UpdateTank();
        }

        public void NotifyClick() {
            interactor.NotifyClick();
        }
    }
}
