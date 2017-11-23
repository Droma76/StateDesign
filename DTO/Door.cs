using StateDesign.States.DoorStates;

namespace StateDesign.DTO
{
    public class Door
    {
        public DomainObject DoorState { get; set; }
        public Device Device { get; set; }

        public Door(Device device)
        {
            this.Device = device;
        }

        public void Close()
        {
            this.DoorState =new DoorClosedState(this);
        }
    }
}
