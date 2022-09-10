using System.Runtime.CompilerServices;
using EkIJjm7vjs8xMISmTn;
using Microsoft.Win32;
using RieScwKGfOFkaVYpDu;

namespace g4pCthJAI7lShClxyE;

internal sealed class wV82w1bQF7p1eI0i9A
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string p1E214wQcv()
	{
		//Discarded unreachable code: IL_0089
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(OUxsnfjqaRYByilt9V._0001());
			int num = 4;
			string result = default(string);
			string result2 = default(string);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					IL_0096:
					switch (num2)
					{
					case 4:
						if (registryKey == null)
						{
							num2 = 6;
							if (true)
							{
								continue;
							}
							goto case 3;
						}
						goto case 0;
					case 3:
						result = null;
						num2 = 5;
						if (!EC1Wqjsw7Sb9X1EaPHw())
						{
							continue;
						}
						goto case 7;
					case 7:
						registryKey.Close();
						num = 8;
						break;
					case 0:
					case 2:
						while (registryKey != null)
						{
							result2 = (string)registryKey.GetValue(teuVAA2ghHDQmtOkUp.dYB2ebULO8(45547), null);
							num2 = 7;
							if (false)
							{
								continue;
							}
							goto IL_0096;
						}
						goto case 3;
					default:
						num = 3;
						break;
					case 1:
					case 6:
						registryKey = Registry.LocalMachine.OpenSubKey(OUxsnfjqaRYByilt9V._0002());
						num2 = 0;
						if (true)
						{
							continue;
						}
						goto case 8;
					case 8:
						return result2;
					case 5:
						return result;
					}
					break;
				}
			}
		}
		catch
		{
			return null;
		}
	}

	internal static bool wSP07Gzd0dOSpIbKry()
	{
		return true;
	}

	internal static bool EC1Wqjsw7Sb9X1EaPHw()
	{
		return false;
	}
}
