using StateDesign.DTO;

namespace StateDesign.States.ModeStates
{
    public class ModeBusyState : ModeState
    {
        public ModeBusyState(ModeState modeState)
        {
            Initialize();
            this.Device = modeState.Device;
        }

        public ModeBusyState(Device device)
        {
            Initialize();
            this.Device = device;
        }

        private void Initialize()
        {
            Name = "Busy";
        }

        public string Name { get; set; }
        
        public override void SetModeToBusy()
        {
            // already Busy
        }

        public override void SetModeToPowerUp()
        {
            // can't move to Powerup mode, we're already busy
        }

        public override void SetModeToIdle()
        {
            // Switch to Idle state
            this.Device.Mode = new ModeIdleState(this);
        }

        public override void SetModeToPowerDown()
        {
            // We're busy, but we allow to power down.
            // Cleanup any resources and then set the state
            this.Device.Mode = new ModePowerDownState(this);
        }
    }
}