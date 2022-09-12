using Coache.Business;
using Coache.Common;

namespace Coache.Core;

internal class Session
{
	public static User User { get; private set; }

	public static int DefaultRoleID { get; private set; }

	public static void StartSession(User user)
	{
		User = user;
		if (user.Permissions.Contains(Functionalities.AdministrarRoles))
		{
			DefaultRoleID = new RolesManager().GetDefaultRoleID();
		}
		ViewsManager.LoadMenu();
	}

	public static void Close()
	{
		User = null;
		ViewsManager.Reset();
	}
}
