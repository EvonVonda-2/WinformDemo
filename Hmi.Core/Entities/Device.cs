namespace Hmi.Core.Entities
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ip { get; set; }
        public int Port { get; set; }
        public byte StationId { get; set; }
        public bool IsEnabled { get; set; }
    }
}
