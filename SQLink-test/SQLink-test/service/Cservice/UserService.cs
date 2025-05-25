using Newtonsoft.Json;
using SQLink_test.Entity;

namespace SQLink_test.service.Cservice
{
    public class UserService:IUserService
    {
        readonly IDataContext _db;

        public UserService(IDataContext db)
        {
            _db = db;
        }
        public List<User> GetAllUsers()
        {
            using (StreamReader r = new StreamReader("~/Data/data.json"))
            {
                string json = r.ReadToEnd();
                if (string.IsNullOrWhiteSpace(json)) return null; 
                var users = JsonConvert.DeserializeObject<List<User>>(json);
                if (users == null || users.Count == 0) return null;
                return users;
            }
        }
        public User GetUserById(int id) {
            using (StreamReader r = new StreamReader("~/Data/data.json"))
            {
                string json = r.ReadToEnd();
                if (string.IsNullOrWhiteSpace(json)) return null;
                var users = JsonConvert.DeserializeObject<List<User>>(json);
                if (users == null || users.Count == 0) return null;
                var user = users.FirstOrDefault(x => x.Id == id); 
                return user;
            }
        }

        public bool AddUser(User user)
        {
            if (user == null) return false;
             var data = _db.LoadData();
            data.Add(user);
         return   _db.SaveData(data);
        }

        public bool DeleteUser(int id)
        {
            var data = _db.LoadData();
            data.Remove(GetUserById(id));
            return _db.SaveData(data);
        }

        public bool UpdataData(User user)
        {
            if (user == null) return false;
            var data = _db.LoadData();
            User user1 = data.Find(u=>u.Id==user.Id);
            if (user1 == null) return false;
            user1.Email = user.Email;
            user1.Password = user.Password;
            return true;
        }

    }
}
