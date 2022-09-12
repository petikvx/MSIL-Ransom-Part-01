using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using ns0;
using ns1;
using ns2;
using ns3;

namespace ns8;

internal static class Class18
{
	[DllImport("advapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int RegOpenKeyEx(UIntPtr uintptr_0, string string_0, int int_0, int int_1, out UIntPtr uintptr_1);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int RegQueryValueEx(UIntPtr uintptr_0, string string_0, int[] int_0, ref int int_1, [Out] byte[] byte_0, ref int int_2);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern int RegCloseKey(UIntPtr uintptr_0);

	internal static Class15 OpenKey(UIntPtr uintptr_0, Enum5 enum5_0, Enum3 enum3_0, string string_0, out Enum4 enum4_0)
	{
		try
		{
			UIntPtr uintptr_;
			switch (RegOpenKeyEx(uintptr_0, string_0, 0, (int)enum3_0 | (int)enum5_0, out uintptr_))
			{
			default:
				enum4_0 = Enum4.const_0;
				break;
			case 0:
				enum4_0 = Enum4.const_2;
				return new Class16(uintptr_);
			case 1:
				enum4_0 = Enum4.const_3;
				break;
			case 2:
				enum4_0 = Enum4.const_4;
				break;
			}
		}
		catch
		{
			enum4_0 = Enum4.const_0;
		}
		return null;
	}

	internal unsafe static object GetValue(UIntPtr uintptr_0, string string_0)
	{
		void* ptr = stackalloc byte[16];
		try
		{
			*(int*)ptr = -1;
			*(int*)((byte*)ptr + 4) = -1;
			if (RegQueryValueEx(uintptr_0, string_0, null, ref *(int*)ptr, null, ref *(int*)((byte*)ptr + 4)) == 0)
			{
				switch (*(int*)ptr)
				{
				case 1:
				{
					byte[] array4 = new byte[*(int*)((byte*)ptr + 4)];
					if (RegQueryValueEx(uintptr_0, string_0, null, ref *(int*)ptr, array4, ref *(int*)((byte*)ptr + 4)) != 0)
					{
						return null;
					}
					return Encoding.Unicode.GetString(array4).TrimEnd(new char[1]);
				}
				case 2:
				{
					byte[] array5 = new byte[*(int*)((byte*)ptr + 4)];
					if (RegQueryValueEx(uintptr_0, string_0, null, ref *(int*)ptr, array5, ref *(int*)((byte*)ptr + 4)) != 0)
					{
						return null;
					}
					return Environment.ExpandEnvironmentVariables(Encoding.Unicode.GetString(array5).TrimEnd(new char[1]));
				}
				case 4:
					if (*(int*)((byte*)ptr + 4) <= 4)
					{
						byte[] array2 = new byte[*(int*)((byte*)ptr + 4)];
						if (RegQueryValueEx(uintptr_0, string_0, null, ref *(int*)ptr, array2, ref *(int*)((byte*)ptr + 4)) != 0)
						{
							return null;
						}
						return BitConverter.ToInt32(array2, 0);
					}
					goto case 11;
				case 7:
				{
					byte[] array = new byte[*(int*)((byte*)ptr + 4)];
					if (RegQueryValueEx(uintptr_0, string_0, null, ref *(int*)ptr, array, ref *(int*)((byte*)ptr + 4)) != 0)
					{
						return null;
					}
					*(int*)((byte*)ptr + 8) = 0;
					List<string> list = new List<string>();
					*(int*)((byte*)ptr + 12) = 0;
					while (*(int*)((byte*)ptr + 12) < *(int*)((byte*)ptr + 4))
					{
						if (array[*(int*)((byte*)ptr + 12)] == 0)
						{
							list.Add(Encoding.Unicode.GetString(array, *(int*)((byte*)ptr + 8), *(int*)((byte*)ptr + 12) - *(int*)((byte*)ptr + 8)).TrimEnd(new char[1]));
							*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 12) + 1;
						}
						(*(int*)((byte*)ptr + 12))++;
					}
					return list;
				}
				default:
					return null;
				case 11:
					if (*(int*)((byte*)ptr + 4) <= 8)
					{
						byte[] array3 = new byte[*(int*)((byte*)ptr + 4)];
						if (RegQueryValueEx(uintptr_0, string_0, null, ref *(int*)ptr, array3, ref *(int*)((byte*)ptr + 4)) != 0)
						{
							return null;
						}
						return BitConverter.ToInt64(array3, 0);
					}
					break;
				case 0:
				case 3:
				case 5:
					break;
				}
				byte[] array6 = new byte[*(int*)((byte*)ptr + 4)];
				if (RegQueryValueEx(uintptr_0, string_0, null, ref *(int*)ptr, array6, ref *(int*)((byte*)ptr + 4)) != 0)
				{
					return null;
				}
				return array6;
			}
		}
		catch
		{
		}
		return null;
	}

	internal static Enum4 smethod_0(UIntPtr uintptr_0)
	{
		try
		{
			if (RegCloseKey(uintptr_0) == 0)
			{
				return Enum4.const_2;
			}
		}
		catch
		{
		}
		return Enum4.const_0;
	}
}
