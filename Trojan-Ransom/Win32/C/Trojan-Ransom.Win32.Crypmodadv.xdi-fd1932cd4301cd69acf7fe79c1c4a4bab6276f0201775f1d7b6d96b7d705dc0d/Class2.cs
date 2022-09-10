using System;
using System.Runtime.CompilerServices;
using Microsoft.Win32;

internal static class Class2
{
	[SpecialName]
	internal static string smethod_0()
	{
		int num = 0;
		num = -18843;
		int num2 = num;
		num = -18843;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return smethod_1();
		}
	}

	private static string smethod_1()
	{
		RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
		string result = default(string);
		int num;
		try
		{
			RegistryKey registryKey2 = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Cryptography");
			try
			{
				num = 0;
				int num2 = num;
				while (true)
				{
					object obj;
					object obj2;
					switch (num2)
					{
					case 6:
						num = 4;
						num2 = num;
						continue;
					case 4:
						obj = null;
						goto IL_003e;
					case 3:
						obj = registryKey2.GetValue("MachineGuid");
						if (obj == null)
						{
							goto IL_003e;
						}
						obj2 = obj.ToString();
						if (obj2 == null)
						{
							goto IL_0066;
						}
						goto IL_0078;
					case 2:
						obj2 = null;
						goto IL_0066;
					case 1:
						obj2 = "null";
						goto IL_0078;
					default:
						if (registryKey2 == null)
						{
							num = 6;
							num2 = num;
						}
						else
						{
							num = 3;
							num2 = num;
						}
						continue;
					case 5:
						break;
						IL_003e:
						num = 2;
						num2 = num;
						continue;
						IL_0066:
						num = 1;
						num2 = num;
						continue;
						IL_0078:
						result = (string)obj2;
						num = 5;
						num2 = num;
						continue;
					}
					break;
				}
			}
			finally
			{
				num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
					{
						num = -21844;
						int num3 = num;
						num = -21844;
						switch (num3 == num)
						{
						default:
							if (0 == 0)
							{
							}
							if (registryKey2 != null)
							{
								num = 0;
								num2 = num;
								continue;
							}
							goto end_IL_0155;
						case false:
						case true:
							break;
						}
						break;
					}
					case 0:
						((IDisposable)registryKey2).Dispose();
						break;
					case 1:
						goto end_IL_0155;
					}
					num = 1;
					num2 = num;
					continue;
					end_IL_0155:
					break;
				}
			}
		}
		finally
		{
			num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (registryKey != null)
					{
						num = 0;
						num2 = num;
						continue;
					}
					break;
				case 0:
					((IDisposable)registryKey).Dispose();
					num = 1;
					num2 = num;
					continue;
				case 1:
					break;
				}
				break;
			}
		}
		num = 0;
		if (1 == 0)
		{
		}
		return result;
	}
}
