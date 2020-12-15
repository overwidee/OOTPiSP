namespace example3.Models
{
    public class FreightTransport : Transport
    {
        protected override string GetInspectionInterval()
        {
            return "/ техосмотр - необходимо проходить 2 раза в год";
        }
    }

    public class Agricultural : Transport
    {
        protected override string GetInspectionInterval()
        {
            return "/ техосмотр - необходимо проходить 1 раз в год";
        }
    }
    
    public abstract class Transport
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsBusy => BusyBy != null;
        public Employee BusyBy { get; set; }
        protected string Appointment { get; set; }
        protected abstract string GetInspectionInterval();
        public override string ToString()
        {
            return $"{Name} {Number} {GetInspectionInterval()}";
        }
    }

    public enum TransportType
    {
        Car,
        Tractor,
        Harvester
    }
}