using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using Task.Data;
using Task.Data.Model;
using Task.Data.Repositories;

namespace Task.Service
{
    public class UserService
    {
 
        private EFRepository<User> _userRepository;
        private EFRepository<Role> _roleRepository;
        private EFRepository<Data.Model.Action> _actionRepository;

        public UserService(EFBlogContext EFBlogContext)
        {
            _userRepository = new EFRepository<User>(EFBlogContext);
            _roleRepository = new EFRepository<Role>(EFBlogContext);
            _actionRepository = new EFRepository<Data.Model.Action>(EFBlogContext);
        }
       //glimpse kullan
        public List<User> GetUsers()
        {         
          List<User> sorgu = _userRepository.GetAll().ToList();
           return sorgu;                  
        }
        public void AddRole(Role role)
        {
            _roleRepository.Add(role);
                 
        }
        public void AddUser(User user)
        {
            // _userRepository.Add(user);
            _userRepository.AddOrUpdate(user);
        }
        public Role GetRoleById(int id)
        {
           return _roleRepository.GetById(id);
        }
        public User GetUserByMail(string email)
        {
            return _userRepository.GetAll().Where(u => u.Email ==email).FirstOrDefault();
        }

        public string GetUserPassword(string userName)
        {
           return _userRepository.GetAll().Where(c => c.Email == userName).FirstOrDefault().PassWord;
           
        }
        public List<Data.Model.Action>  getRoleActions(Role role)
        {
            return role.Actions.ToList();
        }
        public User findUserbyTickedId(string tickedId)
        {
            return _userRepository.GetAll().Where(c => c.TicketId == tickedId).FirstOrDefault();
        }

        public List<Role> getRoles()
        {
          return  _roleRepository.GetAll().ToList();
        }

    }

}
