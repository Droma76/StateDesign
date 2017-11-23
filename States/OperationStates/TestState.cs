using StateDesign.DTO;

namespace StateDesign.States.OperationStates
{
    public class TestState : ConfigurationState
    {
        public Device Device { get; set; }

        public TestState(ConfigurationState configurationState)
        {
            this.Device = configurationState.Device;
            Initialize();
        }

        public TestState(Device device)
        {
            this.Device = device;
            Initialize();
        }

        private void Initialize()
        {
            Name = "Production";

            // Here we want to setup the device under the 
            // production configuration and how it should 
            // behave. In this production configuration, we
            // want the door to be in a closed state. To do
            // this, we can either call the Close() method
            // on the Door or we can manipulate the 
            // DoorState directly and instantiate an 
            // instance of the DoorClosedState.
            this.Device.Door.Close();
        }

        public override void SetProductionConfiguration()
        {
            this.Device.ConfigurationState = new ProductionState(this);
        }

        public override void SetTestConfiguration()
        {
            // already in Test State
        }
    }
}