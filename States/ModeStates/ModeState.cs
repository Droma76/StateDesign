using StateDesign.DTO;

namespace StateDesign.States.ModeStates
{
    public abstract class ModeState
    {
        public Device Device { get; set; }

        public virtual void SetModeToPowerUp() { }

        public virtual void SetModeToIdle() { }

        public virtual void SetModeToBusy() { }

        public virtual void SetModeToPowerDown() { }
    }
}
