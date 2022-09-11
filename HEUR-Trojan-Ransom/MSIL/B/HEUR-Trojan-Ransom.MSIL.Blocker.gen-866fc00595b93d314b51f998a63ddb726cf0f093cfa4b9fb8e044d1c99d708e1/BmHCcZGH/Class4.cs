using System;
using System.Reflection;

namespace BmHCcZGH;

internal sealed class Class4
{
	private static volatile bool bool_0;

	private static volatile bool bool_1;

	public static bool Boolean_0
	{
		get
		{
			if (!bool_1)
			{
				if (Environment.OSVersion.Platform != PlatformID.Win32NT)
				{
					bool_0 = false;
				}
				else if (Environment.OSVersion.Version.Major >= 6 && (Environment.OSVersion.Version.Major != 6 || Environment.OSVersion.Version.Minor > 1))
				{
					bool_0 = smethod_1();
				}
				else
				{
					bool_0 = false;
				}
				bool_1 = true;
			}
			return bool_0;
		}
	}

	internal static bool smethod_0(string[] string_0, ResolveEventArgs resolveEventArgs_0, AppDomain appDomain_0, out Assembly assembly_0)
	{
		int num = 0;
		Assembly assembly_;
		while (true)
		{
			if (num < string_0.Length)
			{
				string string_ = string_0[num];
				if (Class8.smethod_2(resolveEventArgs_0, string_, appDomain_0, out assembly_))
				{
					break;
				}
				num++;
				continue;
			}
			assembly_0 = null;
			return false;
		}
		assembly_0 = assembly_;
		return true;
	}

	private static bool smethod_1()
	{
		return false;
	}
}
