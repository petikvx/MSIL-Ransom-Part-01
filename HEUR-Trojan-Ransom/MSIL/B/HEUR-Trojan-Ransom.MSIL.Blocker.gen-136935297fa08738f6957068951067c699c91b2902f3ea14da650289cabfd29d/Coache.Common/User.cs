using System.Collections.Generic;

namespace Coache.Common;

public class User
{
	public List<Functionalities> Permissions { get; private set; }

	public int UserID { get; set; }

	public int RoleID { get; set; }

	public string UserName { get; set; }

	public DetalleEntidad DetalleEntidad { get; set; }

	public User()
	{
		Permissions = new List<Functionalities>();
		DetalleEntidad = new DetalleEntidad();
	}

	public override string ToString()
	{
		return UserName;
	}

	public override bool Equals(object obj)
	{
		if (!obj.GetType().IsSubclassOf(typeof(User)))
		{
			return false;
		}
		return ((User)obj).UserID == UserID;
	}

	public override int GetHashCode()
	{
		return UserID.GetHashCode();
	}
}
