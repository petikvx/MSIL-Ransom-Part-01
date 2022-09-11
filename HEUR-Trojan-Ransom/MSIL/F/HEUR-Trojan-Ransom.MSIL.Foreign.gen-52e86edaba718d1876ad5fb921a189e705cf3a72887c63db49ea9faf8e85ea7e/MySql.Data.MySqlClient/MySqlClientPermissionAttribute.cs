using System;
using System.Data.Common;
using System.Security;
using System.Security.Permissions;

namespace MySql.Data.MySqlClient;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
public sealed class MySqlClientPermissionAttribute : DBDataPermissionAttribute
{
	public MySqlClientPermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	IPermission SecurityAttribute.CreatePermission()
	{
		return (IPermission)(object)new MySqlClientPermission(this);
	}
}
