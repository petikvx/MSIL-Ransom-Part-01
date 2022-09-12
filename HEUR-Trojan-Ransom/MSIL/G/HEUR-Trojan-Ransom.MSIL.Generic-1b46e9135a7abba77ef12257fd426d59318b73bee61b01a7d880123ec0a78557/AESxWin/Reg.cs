using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using A6yJVNZuoAn9NC1LAS;
using Microsoft.Win32;

namespace AESxWin;

public static class Reg
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string Read(string KeyName)
	{
		//Discarded unreachable code: IL_0005, IL_0057
		//IL_0006: Incompatible stack heights: 0 vs 1
		_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 1;
			goto IL_0064;
		}
		int num2 = 5;
		if (0 == 0)
		{
			goto IL_0060;
		}
		goto IL_00e2;
		IL_0064:
		RegistryKey registryKey = default(RegistryKey);
		RegistryKey currentUser = default(RegistryKey);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			switch (num)
			{
			case 6:
				registryKey = currentUser.OpenSubKey(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2220));
				num = 2;
				continue;
			case 0:
			case 1:
				currentUser = Registry.CurrentUser;
				num = 6;
				continue;
			case 2:
				flag = registryKey == null;
				goto case 3;
			default:
				num = 3;
				continue;
			case 4:
			case 5:
				result = null;
				num2 = 7;
				if (0 == 0)
				{
					goto IL_0060;
				}
				goto case 3;
			case 3:
				if (flag)
				{
					goto case 4;
				}
				try
				{
					return (string)registryKey.GetValue(KeyName);
				}
				catch (Exception)
				{
					return null;
				}
			case 7:
				break;
			}
			break;
		}
		goto IL_00e2;
		IL_00e2:
		return result;
		IL_0060:
		num = num2;
		goto IL_0064;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Write(string KeyName, object Value)
	{
		//Discarded unreachable code: IL_0005, IL_0040
		//IL_0006: Incompatible stack heights: 0 vs 1
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			_ = 1;
			int num;
			if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				num = 3;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_0049;
			IL_007a:
			RegistryKey registryKey = default(RegistryKey);
			registryKey.SetValue(KeyName, Value);
			num = 4;
			goto IL_0049;
			IL_002a:
			registryKey = currentUser.CreateSubKey(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2220));
			goto IL_007a;
			IL_0049:
			switch (num)
			{
			case 0:
			case 3:
				break;
			default:
				goto IL_007a;
			case 4:
				return true;
			}
			goto IL_002a;
		}
		catch (Exception)
		{
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterInStartup(bool isChecked, string executablePath)
	{
		//Discarded unreachable code: IL_0005, IL_0021
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_00b9: Incompatible stack heights: 0 vs 1
		int num = 5;
		if (false)
		{
			goto IL_0016;
		}
		goto IL_002a;
		IL_002a:
		bool flag = default(bool);
		RegistryKey registryKey = default(RegistryKey);
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				break;
			default:
				num = 3;
				if (true)
				{
					continue;
				}
				goto IL_005e;
			case 3:
				goto IL_005e;
			case 0:
			case 1:
				flag = isChecked;
				break;
			case 5:
				goto IL_0098;
			case 6:
				return;
			}
			break;
			IL_0098:
			registryKey = Registry.CurrentUser.OpenSubKey(S7EI44sMaZQ92MiG6X.pA2PN5iOW(196), writable: true);
			_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
			num = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 4 : 0);
		}
		goto IL_0016;
		IL_005e:
		registryKey.SetValue(Assembly.GetExecutingAssembly().GetName().Name, executablePath);
		num = 6;
		goto IL_002a;
		IL_0016:
		if (flag)
		{
			goto IL_005e;
		}
		try
		{
			registryKey.DeleteValue(Assembly.GetExecutingAssembly().GetName().Name);
		}
		catch
		{
		}
	}

	internal static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return true;
	}

	internal static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return false;
	}
}
