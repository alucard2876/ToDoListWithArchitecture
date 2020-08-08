using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Domain.Entities
{
    public class User : EntityBase
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }
        protected User()
        {

        }
        public User(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName)) throw new ArgumentNullException(nameof(userName));
            if (string.IsNullOrEmpty(password)) throw new ArgumentNullException(nameof(password));
            UserName = userName;
            Password = password;
        }
        public void UpdateUserName(string userName)
        {
            if (string.IsNullOrEmpty(userName)) throw new ArgumentNullException(nameof(userName));
            UserName = userName;
        }
        public void UpdatePassword(string password)
        {
            if (string.IsNullOrEmpty(password)) throw new ArgumentNullException(nameof(password));
            Password = password;
        }
    }
}
