using StateDesign.DTO;

namespace StateDesign.States.DoorStates
{
    internal class DoorBrokenState : DoorState
    {
        public DoorBrokenState(DoorState doorState)
        {
            Initialize();
            this.Door = doorState.Door;
        }
        public DoorBrokenState(Door door)
        {
            Initialize();
            this.Door = door;
        }
        private void Initialize()
        {
            Name = "Broken";
        }
        public override void Break()
        {
            // already broken
        }

        public override void Unlock()
        {
            // can't operate a broken door
        }

        public override void Close()
        {
            // can't operate a broken door
        }
        public override void Open()
        {
            // can't operate a broken door
        }

        public override void Lock()
        {
            // can't operate a broken door
        }
    }
}