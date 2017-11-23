using StateDesign.DTO;

namespace StateDesign.States.OperationStates
{
    public abstract class ConfigurationState : DomainObject
    {
        public Device Device { get; set; }

        public virtual void SetProductionConfiguration() { }

        public virtual void SetTestConfiguration() { }
    }
}