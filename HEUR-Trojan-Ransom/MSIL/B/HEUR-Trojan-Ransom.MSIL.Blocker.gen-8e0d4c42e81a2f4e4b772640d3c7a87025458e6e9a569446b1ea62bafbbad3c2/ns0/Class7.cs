using System.IO;
using System.Security;
using System.Security.Permissions;
using ns1;

namespace ns0;

internal static class Class7
{
	public static readonly CodeAccessPermission codeAccessPermission_0 = (CodeAccessPermission)new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);

	public static readonly CodeAccessPermission codeAccessPermission_1 = (CodeAccessPermission)new ReflectionPermission(PermissionState.Unrestricted);

	internal static void smethod_0(byte[] byte_0)
	{
		for (int i = 0; i < GStruct0.byte_0.Length; i++)
		{
			GClass0.smethod_0(byte_0, i);
		}
	}

	public static string smethod_1(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		FileIOPermission val = new FileIOPermission(PermissionState.None);
		val.set_AllFiles((FileIOPermissionAccess)8);
		((CodeAccessPermission)val).Assert();
		try
		{
			return Path.GetFullPath(string_0);
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
	}
}
