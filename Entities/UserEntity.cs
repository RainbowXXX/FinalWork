using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWork.Entities
{
    public class UserEntity
    {
        public UserLoginEntity Login { get; set; }
        public UserOptionalInfoEntity? OptionalInfo { get; set; }

        public UserEntity(UserLoginEntity login, UserOptionalInfoEntity? optionalInfo)
        {
            Login = login ?? throw new ArgumentNullException(nameof(login));
            OptionalInfo = optionalInfo;
        }
    }
}
