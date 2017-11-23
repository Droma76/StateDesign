using StateDesign.DTO;

namespace StateDesign.States.ModeStates
{
    public class ModePowerUpState : ModeState
    {
        public ModePowerUpState(ModeState modeState)
        {
            Initialize();
            this.Device = modeState.Device;
        }

        public ModePowerUpState(Device device)
        {
            Initialize();
            this.Device = device;
        }

        private void Initialize()
        {
            Name = "Powering Up";
        }

        public string Name { get; set; }

        public override void SetModeToPowerUp()
        {
            // We're in powerup state already
        }

        public override void SetModeToIdle()
        {
            // Switch to Idle state
            this.Device.Mode = new ModeIdleState(this);
        }

        public override void SetModeToBusy()
        {
            // Can't set mode to busy, we're still powering up
        }

        public override void SetModeToPowerDown()
        {
            // We're busy, but we allow to power down.
            // Cleanup any resources and then set the state
            this.Device.Mode = new ModePowerDownState(this);
        }
    }
}
