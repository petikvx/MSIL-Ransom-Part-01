using System;
using System.Collections.Generic;
using System.Linq;
using Coache.Common;

namespace Coache.Business;

public class ProfileManager
{
	public List<Profile> GetAllProfiles()
	{
		return Enum.GetValues(typeof(Profile)).Cast<Profile>().ToList();
	}

	public List<Profile> GetRegistrationProfiles()
	{
		List<Profile> list = Enum.GetValues(typeof(Profile)).Cast<Profile>().ToList();
		list.Remove(Profile.Administrador);
		return list;
	}
}
