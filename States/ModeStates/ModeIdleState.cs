using StateDesign.DTO;

namespace StateDesign.States.ModeStates
{
    internal class ModeIdleState : ModeState
    {
        public string Name { get; set; }

        public ModeIdleState(ModeState modeState)
        {
            Initialize();
            this.Device = modeState.Device;
        }

        public ModeIdleState(Device device)
        {
            Initialize();
            this.Device = device;
        }

        private void Initialize()
        {
            Name = "Idling";
        }

        public override void SetModeToIdle()
        {
            // already in Idle state
        }

        public override void SetModeToPowerUp()
        {
            this.Device.Mode = new ModePowerUpState(this);
        }

        public override void SetModeToBusy()
        {
            this.Device.Mode = new ModeBusyState(this);
        }

        public override void SetModeToPowerDown()
        {
            this.Device.Mode = new ModePowerDownState(this);
        }
    }
}