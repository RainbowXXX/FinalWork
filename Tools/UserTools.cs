using Dapper;
using FinalWork.Configs;
using FinalWork.Entities;
using FinalWork.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography;
using System.Xml.Linq;


namespace FinalWork.Tools
{
    public class UserTools
    {
        public static bool RemoveUser(string username)
        {
            var user = GetUserInfo(username) ?? throw new ArgumentNullException();
            return RemoveUser(user.Id);
        }
        public static bool RemoveUser(int uid)
        {
            using (var transaction = SqlHandler.Instance.conn.BeginTransaction())
            {
                var tmp = new { Uid = uid };
                SqlHandler.Instance.conn.Execute("DELETE FROM user_points WHERE uid=@Uid", tmp);
                SqlHandler.Instance.conn.Execute("DELETE FROM user WHERE uid=@Uid", tmp);
                SqlHandler.Instance.conn.Execute("DELETE FROM user_login WHERE id=@Uid", tmp);
                transaction.Commit();
            }
            return true;
        }

        public static UserLoginEntity? validate_user(string username, string passwd)
        {
            string query = "SELECT * FROM user_login WHERE user_name=@UserName;";

            var optionalParams = new { UserName = username };
            var entities = SqlHandler.Instance.conn.Query<UserLoginEntity>(query, optionalParams).ToList();

            // 如果不是1代表没找到用户, 因为用户名是唯一的
            if (entities.Count != 1)
            {
                Thread.Sleep(RandomTools.getRandomNum(890, 2632));
                return null;
            }

            var user = entities[0];
            string passwd_sha256 = Sha256Tool.Calc(passwd + user.PasswordSalt);

            // 密码验证不通过
            if (passwd_sha256 != user.PasswordHash) return null;

            return user;
        }

        public static bool ChangePasswd(string username, string passwd)
        {
            string query = "UPDATE user_login SET password_hash = @PasswordHash, password_salt = @PasswordSalt WHERE user_name = @UserName";

            var salt = UUIDTool.GetUUID();
            var hash = Sha256Tool.Calc(passwd + salt);
            var optionalParams = new { UserName = username, PasswordSalt = salt, PasswordHash = hash };
            return SqlHandler.Instance.conn.Execute(query, optionalParams) == 1;
        }

        public static UserLoginEntity? GetUserInfo(string username)
        {
            string query = "SELECT * FROM user_login WHERE user_name=@UserName;";

            var optionalParams = new { UserName = username };
            var entities = SqlHandler.Instance.conn.Query<UserLoginEntity>(query, optionalParams).ToList();

            // 如果不是1代表没找到用户, 因为用户名是唯一的
            if (entities.Count != 1)
            {
                Thread.Sleep(RandomTools.getRandomNum(890, 2632));
                return null;
            }

            var user = entities[0];
            return user;
        }

        public static UserLoginEntity? GetUserInfo(int uid)
        {
            string query = "SELECT * FROM user_login WHERE id=@Id;";

            var optionalParams = new { Id = uid };
            var entities = SqlHandler.Instance.conn.Query<UserLoginEntity>(query, optionalParams).ToList();

            // 如果不是1代表没找到用户, 因为用户名是唯一的
            if (entities.Count != 1)
            {
                Thread.Sleep(RandomTools.getRandomNum(890, 2632));
                return null;
            }

            var user = entities[0];
            return user;
        }

        public static UserOptionalInfoEntity? GetUserOptionalInfo(string username, bool creat_if_not_exist)
        {
            string query = "SELECT * FROM user_login WHERE user_name=@UserName;";

            var optionalParams = new { UserName = username };
            var entities = SqlHandler.Instance.conn.Query<UserLoginEntity>(query, optionalParams).ToList();

            // 如果不是1代表没找到用户, 因为用户名是唯一的
            if (entities.Count != 1)
            {
                Thread.Sleep(RandomTools.getRandomNum(890, 2632));
                return null;
            }

            var user = entities[0];

            return GetUserOptionalInfo(user.Id, creat_if_not_exist);
        }

        public static UserOptionalInfoEntity? GetUserOptionalInfo(int uid, bool creat_if_not_exist)
        {
            var optionalParams = new { Uid = uid };
            List<UserOptionalInfoEntity> userOptionalInfos = SqlHandler.Instance.conn.Query<UserOptionalInfoEntity>("SELECT * FROM user WHERE uid=@Uid;", optionalParams).ToList();

            if(userOptionalInfos.Count != 1)
            {
                UserOptionalInfoEntity userOptionalInfo = new UserOptionalInfoEntity(uid, null, null, -1, null, null, null);
                return CreateUserOptionalInfo(userOptionalInfo);
            }

            return userOptionalInfos[0];
        }

        public static void SetUserOptionalInfo(int uid, UserOptionalInfoEntity userOptionalInfo)
        {
            GetUserOptionalInfo(uid, true);
            SqlHandler.Instance.conn.Execute("UPDATE work_database.user t SET " +
                "t.name = @Name," +
                " t.gender = @Gender," +
                " t.age = @Age," +
                " t.email = @Email," +
                " t.profession = @Profession," +
                " t.hobby = @Hobby" +
                " WHERE t.uid = @Uid;", userOptionalInfo);

        }

        public static UserOptionalInfoEntity? CreateUserOptionalInfo(int uid)
        {
            var optionalParams = new { Uid = uid };
            SqlHandler.Instance.conn.Execute("INSERT INTO work_database.user (uid, name, gender, age, email, profession, hobby) VALUES (@Uid, null, null, null, null, null, null);", optionalParams);
            var userOptionalInfos = SqlHandler.Instance.conn.Query<UserOptionalInfoEntity>("SELECT * FROM user WHERE uid=@Uid;", optionalParams).ToList();
            if (userOptionalInfos.Count != 1) return null;
            return userOptionalInfos[0];
        }

        public static UserOptionalInfoEntity? CreateUserOptionalInfo(UserOptionalInfoEntity userOptionalInfo)
        {
            var optionalParams = new { Uid = userOptionalInfo.uid, Name = userOptionalInfo.name, Gender = userOptionalInfo.gender, Age = userOptionalInfo.age, Email = userOptionalInfo.email, Profession = userOptionalInfo.profession, Hobby = userOptionalInfo.hobby };
            SqlHandler.Instance.conn.Execute("INSERT INTO work_database.user (uid, name, gender, age, email, profession, hobby) VALUES (@Uid, @Name, @Gender, @Age, @Email, @Profession, @Hobby);", optionalParams);
            var userOptionalInfos = SqlHandler.Instance.conn.Query<UserOptionalInfoEntity>("SELECT * FROM user WHERE uid=@Uid;", optionalParams).ToList();
            if (userOptionalInfos.Count != 1) return null;
            return userOptionalInfos[0];
        }

        public static int? CreateUser(string username, UserLoginEntity.PrivilegeLevel privilege, UserOptionalInfoEntity? userOptionalInfo)
        {
            var optional_params = new { UserName = username, Privilege = (int)privilege, PasswordHash = "0", PasswordSalt = "0" };
            SqlHandler.Instance.conn.Execute("INSERT INTO user_login (privilege, user_name, password_hash, password_salt) VALUES (@Privilege, @UserName, @PasswordHash, @PasswordSalt);", optional_params);
            var userLoginInfo = GetUserInfo(username);
            if (userLoginInfo is null) return null;
            if (userOptionalInfo is null) return userLoginInfo.Id;
            if(privilege > UserLoginEntity.PrivilegeLevel.USER_LEVEL) return userLoginInfo.Id;
            SqlHandler.Instance.conn.Execute("INSERT INTO user_points (uid, points) VALUES (@Uid, 0);", new { Uid = userLoginInfo.Id });
            if (userOptionalInfo is null) CreateUserOptionalInfo(userLoginInfo.Id);
            else { userOptionalInfo.uid = userLoginInfo.Id; CreateUserOptionalInfo(userOptionalInfo); }
            return userLoginInfo.Id;
        }
    }
}
