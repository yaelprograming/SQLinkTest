using SQLink_test.Data;
using SQLink_test.Entity;

namespace SQLink_test.service
{
    public interface IDataContext
    {
        public List<User> LoadData();
        public bool SaveData(List<User> data);

    }
}
