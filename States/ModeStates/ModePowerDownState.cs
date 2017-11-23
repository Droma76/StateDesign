using StateDesign.DTO;

namespace StateDesign.States.ModeStates
{
    public class ModePowerDownState : ModeState
    {
        public string Name { get; set; }

        public ModePowerDownState(ModeState modeState)
        {
            Initialize();
            this.Device = modeState.Device;
        }

        public ModePowerDownState(Device device)
        {
            Initialize();
            this.Device = device;
        }

        private void Initialize()
        {
            Name = "Powering Down";
        }

        public override void SetModeToPowerDown()
        {
            // already in PowerDownState
        }

        public override void SetModeToPowerUp()
        {
            this.Device.Mode=new ModePowerUpState(this);
        }

        public override void SetModeToIdle()
        {
            // Switch to Idle state
            this.Device.Mode = new ModeIdleState(this);
        }

        public override void SetModeToBusy()
        {
            // can't set to busy, we're powered down
        }
    }
}
