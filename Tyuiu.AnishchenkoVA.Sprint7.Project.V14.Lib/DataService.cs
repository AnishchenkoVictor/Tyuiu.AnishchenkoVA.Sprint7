using Newtonsoft.Json;
using System.Diagnostics.Metrics;

namespace Tyuiu.AnishchenkoVA.Sprint7.Project.V14.Lib
{
    public class DataService
    {
        public List<Transport> GetTransport()
        {
            string jsonFilePath = "../../../../transport.json";
            string json = File.ReadAllText(jsonFilePath);
            var transports = JsonConvert.DeserializeObject<List<Transport>>(json);
            return transports;
        }

        public List<Transport> SearchTransport(int filterNumber)
        {
            string jsonFilePath = "../../../../transport.json";
            string json = File.ReadAllText(jsonFilePath);
            var transports = JsonConvert.DeserializeObject<List<Transport>>(json);
            var filteredTransports = transports.FindAll(bus => bus.number == filterNumber);
            return filteredTransports;
        }

        public List<Transport> SortTransport(int index)
        {
            string jsonFilePath = "../../../../transport.json";

            string json = File.ReadAllText(jsonFilePath);

            var transports = JsonConvert.DeserializeObject<List<Transport>>(json);

            switch (index)
            {
                case 0:
                    return transports.OrderBy(c => c.transport).ToList();
                case 1:
                    return transports.OrderBy(c => c.number).ToList();
                case 2:
                    return transports.OrderBy(c => c.dateOfStart).ToList();
                case 3:
                    return transports.OrderBy(c => c.startBusStation).ToList();
                case 4:
                    return transports.OrderBy(c => c.endBusStation).ToList();
                case 5:
                    return transports.OrderBy(c => c.timeOfRoute).ToList();
                case 6:
                    return transports.OrderBy(c => c.description).ToList();
                default:
                    return transports.ToList();

            }
        }

    }
}
