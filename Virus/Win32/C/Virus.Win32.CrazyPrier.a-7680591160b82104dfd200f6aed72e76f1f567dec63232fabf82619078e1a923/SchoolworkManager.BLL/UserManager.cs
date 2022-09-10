using System.Collections.Generic;
using SchoolworkManager.DAL;
using SchoolworkManager.Module;

namespace SchoolworkManager.BLL;

public class UserManager
{
	public bool AddAUser(User user)
	{
		return UserService.Insert(user);
	}

	public bool DeleteAUser(User user)
	{
		return UserService.Delete(user);
	}

	public bool ModifyAUser(User user)
	{
		return UserService.Update(user);
	}

	public User GetAUserById(int id)
	{
		return UserService.SelectById(id);
	}

	public List<User> GetAllUser()
	{
		return UserService.SelectAll();
	}

	public User Login(string loginName, string loginPassword)
	{
		return UserService.SelectByLogin(loginName, loginPassword);
	}
}
