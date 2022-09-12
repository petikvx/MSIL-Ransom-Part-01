using System;
using System.Data;
using System.Data.Common;
using System.Security;
using System.Security.Permissions;

namespace MySql.Data.MySqlClient;

[Serializable]
public sealed class MySqlClientPermission : DBDataPermission
{
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

	public override void Add(string connectionString, string restrictions, KeyRestrictionBehavior behavior)
	{
		((DBDataPermission)this).Add(connectionString, restrictions, behavior);
	}

	public override IPermission Copy()
	{
		return (IPermission)(object)new MySqlClientPermission(this);
	}
}
