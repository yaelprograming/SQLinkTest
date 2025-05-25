using SQLink_test.Entity;
using SQLink_test.service;
using System.Text.Json;

namespace SQLink_test.Data
{
    public class DbcontextTicket 
    {
        public List<Ticket> LoadData()
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "dataTickets.json");
                string jsonString = File.ReadAllText(path);
                var data = JsonSerializer.Deserialize<List<Ticket>>(jsonString);

                if (data == null) { return null; }

                return data;
            }
            catch
            {
                return null;
            }

        }

        public bool SaveData(List<Ticket> data)
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "dataTicket.json");



                string jsonString = JsonSerializer.Serialize<List<Ticket>>(data);

                File.WriteAllText(path, jsonString);
                return true;
            }
            catch { return false; }
        }

    }
}



