using System;
using System.Net;
using System.Security;
using System.Security.Permissions;

namespace ns6;

internal sealed class Class155 : MarshalByRefObject
{
	private Class155()
	{
	}

	public static PermissionSet smethod_0(bool bool_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		PermissionSet permissionSet = new PermissionSet(null);
		permissionSet.AddPermission((IPermission?)new SecurityPermission(SecurityPermissionFlag.Execution));
		permissionSet.AddPermission((IPermission?)new SocketPermission(PermissionState.Unrestricted));
		permissionSet.AddPermission((IPermission?)new SecurityPermission(SecurityPermissionFlag.UnmanagedCode));
		permissionSet.AddPermission((IPermission?)new DnsPermission(PermissionState.Unrestricted));
		permissionSet.AddPermission((IPermission?)new FileIOPermission(PermissionState.Unrestricted));
		permissionSet.AddPermission((IPermission?)new EnvironmentPermission(PermissionState.Unrestricted));
		if (bool_0)
		{
			permissionSet.AddPermission((IPermission?)new ReflectionPermission(PermissionState.Unrestricted));
		}
		return permissionSet;
	}
}
