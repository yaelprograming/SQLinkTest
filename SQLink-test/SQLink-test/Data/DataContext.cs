using Newtonsoft.Json;
using SQLink_test.Entity;
using SQLink_test.service;
using System.Text.Json;

namespace SQLink_test.Data
{
    public class DataContext : IDataContext
    {
        //public List<object> LoadData(Object type)
        //{

        //    try
        //    {
        //        string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");
        //        string jsonString = File.ReadAllText(path);
        //        var data = JsonSerializer.Deserialize<List<object>>(jsonString);

        //        if (data == null) { return null; }

        //        return data;
        //    }
        //    catch
        //    {
        //        return null;
        //    }

        //}

        //public bool SaveData(List<TicketsDb> data)
        //{
        //    try
        //    {
        //        string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");
        //        string jsonString = JsonSerializer.Serialize<List<TicketsDb>>(data);

        //        File.WriteAllText(path, jsonString);
        //        return true;
        //    }
        //    catch { return false; }
        //}
        public List<User> LoadData()
        {
            throw new NotImplementedException();
        }

        public bool SaveData(List<User> data)
        {
            throw new NotImplementedException();
        }
    }
}

