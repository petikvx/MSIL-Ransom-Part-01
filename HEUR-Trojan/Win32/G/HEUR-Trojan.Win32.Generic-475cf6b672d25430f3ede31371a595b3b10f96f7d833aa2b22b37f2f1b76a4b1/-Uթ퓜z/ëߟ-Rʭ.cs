using System;
using System.Management;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace _07FBUթ퓜z;

public class ëߟ_FFFDRʭ
{
	public static RegistryKey W_F0B9Ś_0739_FFFD(string _07B9ﾭ_07B4Қ_FFFD)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\" + _07B9ﾭ_07B4Қ_FFFD, writable: true);
		if (!_FFFDŎک_0327㹃(registryKey))
		{
			registryKey = Registry.CurrentUser.CreateSubKey("Software\\" + _07B9ﾭ_07B4Қ_FFFD);
		}
		return registryKey;
	}

	public static bool _FFFDŎک_0327㹃(RegistryKey ɮڿŧ_FFFD_FFFD)
	{
		bool flag = ɮڿŧ_FFFD_FFFD == null;
		return !flag;
	}

	private static ManagementObject ӓ_07B8ٷ_0739Թ(string Ӻ_02E8_FFFDک_06DA)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		ManagementClass val = new ManagementClass(Ӻ_02E8_FFFDک_06DA);
		ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
		try
		{
			enumerator = val.GetInstances().GetEnumerator();
			while (enumerator.MoveNext())
			{
				ManagementBaseObject current = enumerator.get_Current();
				ManagementObject val2 = (ManagementObject)current;
				if (val2 != null)
				{
					return val2;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return null;
	}

	public static string ľ뫆_FFFD_0331ô()
	{
		string result;
		try
		{
			ManagementObject val = ӓ_07B8ٷ_0739Թ("Win32_OperatingSystem");
			result = ((val != null) ? (((ManagementBaseObject)val).get_Item("Version") as string) : string.Empty);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = string.Empty;
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
