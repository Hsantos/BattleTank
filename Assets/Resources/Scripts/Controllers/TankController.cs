using hSantos.BattleTank.UseCases;

namespace hSantos.BattleTank.Controllers {
    public class TankController : ControllerMonoBehaviour<TankInteractor,ITankOutput> {

        public void Initiate(GameSettings settings) {
            interactor.Initiate(settings);
        }
        void Update() {
            interactor.UpdateTank();
        }

        public void NotifyClick() {
            interactor.NotifyClick();
        }
    }
}
