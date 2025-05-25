using SQLink_test.Entity;

namespace SQLink_test.service
{
    public interface IUserService
    {
        public List<User> GetAllUsers();
        public User GetUserById(int id);
        public bool UpdataData(User user);
        public bool AddUser(User user);
        public bool DeleteUser(int id); 

    }
}