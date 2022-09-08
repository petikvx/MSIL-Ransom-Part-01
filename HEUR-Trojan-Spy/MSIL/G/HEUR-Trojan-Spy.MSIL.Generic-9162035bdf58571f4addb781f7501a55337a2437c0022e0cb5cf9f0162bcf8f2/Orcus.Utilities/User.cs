using System;
using System.Security.Principal;

namespace Orcus.Utilities;

internal static class User
{
	private static WindowsIdentity _user;

	private static bool? _isAdministrator;

	public static WindowsIdentity UserIdentity => _user ?? (_user = WindowsIdentity.GetCurrent());

	public static bool IsAdministrator
	{
		get
		{
			bool? isAdministrator = _isAdministrator;
			if (!isAdministrator.HasValue)
			{
				bool? flag = (_isAdministrator = IsUserAdministrator());
				return flag.Value;
			}
			return isAdministrator.GetValueOrDefault();
		}
	}

	private static bool IsUserAdministrator()
	{
		try
		{
			if (UserIdentity == null)
			{
				return false;
			}
			return new WindowsPrincipal(UserIdentity).IsInRole(WindowsBuiltInRole.Administrator);
		}
		catch (UnauthorizedAccessException)
		{
			return false;
		}
	}
}
