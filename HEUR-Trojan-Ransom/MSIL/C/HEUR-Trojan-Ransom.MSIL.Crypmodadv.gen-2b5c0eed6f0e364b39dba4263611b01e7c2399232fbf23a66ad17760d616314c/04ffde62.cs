using System;
using System.Collections;
using System.IO;
using System.Reflection;

internal class _04ffde62
{
	internal object _50f84b7c;

	internal int _00dde824;

	internal Hashtable _651afd10;

	internal static void _09331e90()
	{
		try
		{
			while (true)
			{
				int num = -1082682245;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E._3ffe0377(num)) % 5u)
					{
					case 3u:
						break;
					default:
						return;
					case 2u:
						AppDomain.CurrentDomain.AssemblyResolve += _8cf468f4;
						num = (num2 * 665948448) ^ 0x497DC416;
						continue;
					case 0u:
						num = (num2 * 1491381247) ^ -1500653989;
						continue;
					case 4u:
						num = (num2 * 1209000808) ^ -320982337;
						continue;
					case 1u:
						return;
					}
					break;
				}
			}
		}
		catch (Exception)
		{
			while (true)
			{
				int num3 = 1423396732;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E._3ffe0377(num3)) % 4u)
					{
					case 3u:
						break;
					default:
						return;
					case 2u:
						num3 = (num2 * -869151084) ^ 0x69D8E1C5;
						continue;
					case 1u:
						num3 = (num2 * -1746654291) ^ -1679595313;
						continue;
					case 0u:
						return;
					}
					break;
				}
			}
		}
	}

	internal static Assembly _8cf468f4(object P_0, ResolveEventArgs P_1)
	{
		Assembly result = default(Assembly);
		try
		{
			while (true)
			{
				int num = 1721669327;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E._3ffe0377(num)) % 3u)
					{
					case 0u:
						break;
					case 1u:
						goto IL_0023;
					default:
						return result;
					case 2u:
						return result;
					}
					break;
					IL_0023:
					result = null;
					num = (num2 * 775001288) ^ 0x21EFB8F7;
				}
			}
		}
		catch (Exception)
		{
			while (true)
			{
				int num3 = 605269983;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E._3ffe0377(num3)) % 4u)
					{
					case 0u:
						break;
					case 3u:
						num3 = (num2 * -1371784446) ^ 0x153456FA;
						continue;
					case 2u:
						result = null;
						num3 = (num2 * 1772744983) ^ 0x51212ACB;
						continue;
					default:
						return result;
					case 1u:
						return result;
					}
					break;
				}
			}
		}
	}

	internal static void f11e5e35(Stream P_0)
	{
	}

	internal _04ffde62()
	{
		while (true)
		{
			int num = 1740236081;
			while (true)
			{
				int num2;
				switch ((uint)(num2 = _003CModule_003E._3ffe0377(num)) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0027;
				case 1u:
					return;
				}
				break;
				IL_0027:
				num = (num2 * 443022860) ^ -1350814303;
			}
		}
	}
}
