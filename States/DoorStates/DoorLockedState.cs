using StateDesign.DTO;
using StateDesign.States.ModeStates;
using StateDesign.States.OperationStates;

namespace StateDesign.States.DoorStates
{
    internal class DoorLockedState : DoorState
    {
        public DoorLockedState(DoorState doorState)
        {
            Initialize();
            this.Door = doorState.Door;
        }
        public DoorLockedState(Door door)
        {
            Initialize();
            this.Door = door;
        }
        private void Initialize()
        {
            Name = "Locked";
        }

        public override void Lock()
        {
            // already locked
        }

        public override void Close()
        {
            // Already closed and locked
        }

        public override void Open()
        {
            // can't open a locked door
        }

        public override void Break()
        {
            // To simulate production vs test configuration
            // scenarios, we can't break a door in test 
            // configuration. So, we need to check the 
            // Device's ConfigurationState. We also want to
            // make sure this is only possible while the 
            // device is Idle.
            //
            // Important:
            // ==========
            // As you can see in the If statement, we can 
            // now use a combination of different states to 
            // check business rules and conditions by simply
            // combining the existence of certain class 
            // types. This is allows for super easy 
            // maintenance as it 100% encapsulates these 
            // rules in one place (in the Break() method in 
            // this case).
            if ((this.Door.Device.ConfigurationState is ProductionState) &&
                (this.Door.Device.Mode is ModeIdleState))
            {
                this.Door.DoorState = new DoorBrokenState(this);
            }
        }

        public override void Unlock()
        {
            this.Door.DoorState=new DoorUnlockedState(this);
        }
    }
}