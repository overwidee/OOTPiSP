namespace example3.Models
{
    public class Transport
    {
        public string Name { get; set; }
        public TransportType TransportType { get; set; }
        public string Number { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsBusy => BusyBy != null;
        public Employee BusyBy { get; set; }
    }

    public enum TransportType
    {
        Car,
        Tractor,
        Harvester
    }
}