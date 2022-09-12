using System;
using System.Configuration;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using Coache.Common;
using Data;

namespace Coache.Business;

public class LoginService
{
	public User Login(string userName, string password)
	{
		ValidateLockedUser(userName);
		string value = ComputeHash(password, new SHA256CryptoServiceProvider());
		DataRow dataRow = SqlDataAccess.ExecuteDataRowQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.Login", SqlDataAccessArgs.CreateWith("@Nombre", userName).And("@Password", value).Arguments);
		if (dataRow == null)
		{
			throw new Exception("Usuario o contraseña inválidos");
		}
		User user = new User
		{
			UserID = int.Parse(dataRow["ID"].ToString()),
			RoleID = int.Parse(dataRow["ID_Rol"].ToString()),
			UserName = dataRow["Nombre"].ToString()
		};
		SetUserFunctionalities(user);
		return user;
	}

	public bool UpdateUserPassword(User user, string oldPassword, string newPassword)
	{
		string value = ComputeHash(oldPassword, new SHA256CryptoServiceProvider());
		string value2 = ComputeHash(newPassword, new SHA256CryptoServiceProvider());
		return SqlDataAccess.ExecuteScalarQuery<object>(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.UpdateUserPassword", SqlDataAccessArgs.CreateWith("@ID_Usuario", user.UserID).And("@OldPassword", value).And("@NewPassword", value2)
			.Arguments) != null;
		}

		public string ComputeHash(string input, HashAlgorithm algorithm)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(input);
			return BitConverter.ToString(algorithm.ComputeHash(bytes));
		}

		private void ValidateLockedUser(string userName)
		{
			if (int.Parse((SqlDataAccess.ExecuteScalarQuery<object>(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.GetUserLoginAttempts", SqlDataAccessArgs.CreateWith("@Nombre", userName).Arguments) ?? throw new Exception("Usuario o contraseña inválidos")).ToString()) == 3)
			{
				throw new Exception("Usuario Bloqueado, contacte al administrador del sistema");
			}
		}

		private void SetUserFunctionalities(User user)
		{
			foreach (Functionalities roleFunctionality in new FunctionalitiesManager().GetRoleFunctionalities(user.RoleID))
			{
				user.Permissions.Add(roleFunctionality);
			}
		}
	}
