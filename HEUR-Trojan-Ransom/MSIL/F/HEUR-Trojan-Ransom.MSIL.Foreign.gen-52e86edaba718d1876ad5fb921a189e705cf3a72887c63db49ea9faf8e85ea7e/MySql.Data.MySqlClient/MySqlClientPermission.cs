using System;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MySql.Data.MySqlClient;

[Serializable]
public sealed class MySqlClientPermission : DBDataPermission
{
	[NonSerialized]
	internal static GetString getString_0;

	public MySqlClientPermission(PermissionState permissionState)
		: base(permissionState)
	{
	}

	private MySqlClientPermission(MySqlClientPermission permission)
		: base((DBDataPermission)(object)permission)
	{
	}

	internal MySqlClientPermission(MySqlClientPermissionAttribute permissionAttribute)
		: base((DBDataPermissionAttribute)(object)permissionAttribute)
	{
	}

	internal MySqlClientPermission(DBDataPermission permission)
		: base(permission)
	{
	}

	internal MySqlClientPermission(string connectionString)
		: base(PermissionState.None)
	{
		if (connectionString != null && connectionString.Length != 0)
		{
			((DBDataPermission)this).Add(connectionString, string.Empty, KeyRestrictionBehavior.AllowOnly);
		}
		else
		{
			((DBDataPermission)this).Add(string.Empty, string.Empty, KeyRestrictionBehavior.AllowOnly);
		}
	}

	void DBDataPermission.Add(string connectionString, string restrictions, KeyRestrictionBehavior behavior)
	{
		((DBDataPermission)this).Add(connectionString, restrictions, behavior);
	}

	IPermission DBDataPermission.Copy()
	{
		return (IPermission)(object)new MySqlClientPermission(this);
	}

	static MySqlClientPermission()
	{
		Strings.CreateGetStringDelegate(typeof(MySqlClientPermission));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398385), getString_0(107398380)).Replace(getString_0(107398343), getString_0(107398338)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398333)))
		{
			throw new SecurityException(getString_0(107398308));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
