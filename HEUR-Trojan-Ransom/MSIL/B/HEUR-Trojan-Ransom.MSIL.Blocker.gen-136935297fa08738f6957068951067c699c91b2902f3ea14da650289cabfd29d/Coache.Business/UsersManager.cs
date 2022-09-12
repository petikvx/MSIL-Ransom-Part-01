using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using Coache.Common;
using Data;

namespace Coache.Business;

public class UsersManager
{
	public void DeleteAccount(User user)
	{
		SqlDataAccess.ExecuteNonQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.DeleteUser", SqlDataAccessArgs.CreateWith("@User_ID", user.UserID).Arguments);
	}

	public int CreateAccount(User user, string password)
	{
		string value = new LoginService().ComputeHash(password, new SHA256CryptoServiceProvider());
		return SqlDataAccess.ExecuteScalarQuery<int>(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.InsertUser", SqlDataAccessArgs.CreateWith("@UserName", user.UserName).And("@Password", value).And("@ID_Rol", user.RoleID)
			.Arguments);
		}

		public int CreateProfileAccount(User user, Profile profile, string password)
		{
			SqlTransaction val = (SessionData.Contains("Transaction") ? SessionData.Get<SqlTransaction>("Transaction") : null);
			string value = new LoginService().ComputeHash(password, new SHA256CryptoServiceProvider());
			int num = 0;
			if (val != null)
			{
				return SqlDataAccess.ExecuteScalarQuery<int>("GRUPO_N.InsertProfileUser", SqlDataAccessArgs.CreateWith("@UserName", user.UserName).And("@Password", value).And("@ProfileName", profile.ToString())
					.Arguments, val);
				}
				return SqlDataAccess.ExecuteScalarQuery<int>(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.InsertProfileUser", SqlDataAccessArgs.CreateWith("@UserName", user.UserName).And("@Password", value).And("@ProfileName", profile.ToString())
					.Arguments);
				}
			}
