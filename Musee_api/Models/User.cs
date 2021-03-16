using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musee_api.Models
{
    public class User
    {
        public int Id;
        public string Username;
        public string Email;
        public string Password;
        public virtual ICollection<Activity> Activities { get; set; }
        public User()
        {
            Activities = new List<Activity>();
        }

    }
}
