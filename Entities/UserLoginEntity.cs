using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWork.Entities
{
    public class UserLoginEntity
    {
        public enum PrivilegeLevel {
            USER_LEVEL = 0,
            ADMIN_LEVEL = 1,
            SYSADMIN_LEVEL = 2
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public PrivilegeLevel Privilege { get; set; }

        public UserLoginEntity(int id, int privilege, string user_name, string password_hash, string password_salt)
        {
            Id = id;
            Privilege = (PrivilegeLevel)privilege;
            UserName = user_name ?? throw new ArgumentNullException(nameof(user_name));
            PasswordHash = password_hash ?? throw new ArgumentNullException(nameof(password_hash));
            PasswordSalt = password_salt ?? throw new ArgumentNullException(nameof(password_salt));
        }
    }
}
