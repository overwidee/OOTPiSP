namespace example3.Models
{
    public class Transport
    {
        public Transport()
        {
            
        }

        public Transport(string name, TransportType type, string number, string model)
        {
            Name = name;
            TransportType = type;
            Number = number;
            Model = model;
        }
        
        public string Name { get; }
        public TransportType TransportType { get; }
        public string Number { get; }
        public string Model { get; }
    }

    public enum TransportType
    {
        Car,
        Tractor,
        Harvester
    }
}