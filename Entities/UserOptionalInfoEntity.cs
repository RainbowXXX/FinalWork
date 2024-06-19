using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWork.Entities
{
    public class UserOptionalInfoEntity
    {
        public int uid { get; set; }
        public string? name { get; set; }
        public string? gender { get; set; }
        public Int32? age { get; set; }
        public string? email { get; set; }
        public string? profession { get; set; }
        public string? hobby { get; set; }

        public UserOptionalInfoEntity(int uid, string? name, string? gender, Int32? age, string? email, string? profession, string? hobby)
        {
            this.uid = uid;
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.email = email;
            this.profession = profession;
            this.hobby = hobby;
        }

    }
}
