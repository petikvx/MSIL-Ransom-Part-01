using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;
using ns1;
using ns2;
using ns4;

namespace SmartAssembly.Shared.ReportHelper;

public static class OsInformation
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct Struct4
	{
		public string string_0;

		public int int_0;
	}

	internal unsafe static string smethod_0(Version version_0)
	{
		void* ptr = stackalloc byte[6];
		((byte*)ptr)[4] = (OsVersionInformation.smethod_0() ? ((byte)1) : ((byte)0));
		((byte*)ptr)[5] = (OsVersionInformation.IsX64 ? ((byte)1) : ((byte)0));
		*(int*)ptr = version_0.Major;
		if (*(int*)ptr != 5)
		{
			if (*(int*)ptr != 6)
			{
				if (*(int*)ptr == 10)
				{
					*(int*)ptr = version_0.Minor;
					if (*(int*)ptr == 0)
					{
						if (((byte*)ptr)[4] == 0)
						{
							if (version_0.Build < 17623)
							{
								return "Windows Server 2016";
							}
							return "Windows Server 2019";
						}
						return "Windows 10";
					}
				}
			}
			else
			{
				*(int*)ptr = version_0.Minor;
				switch (*(int*)ptr)
				{
				case 0:
					if (((byte*)ptr)[4] == 0)
					{
						return "Windows Server 2008";
					}
					return "Windows Vista";
				case 1:
					if (((byte*)ptr)[4] == 0)
					{
						return "Windows Server 2008 R2";
					}
					return "Windows 7";
				case 2:
					if (((byte*)ptr)[4] == 0)
					{
						return "Windows Server 2012";
					}
					return "Windows 8";
				case 3:
					if (((byte*)ptr)[4] == 0)
					{
						return "Windows Server 2012 R2";
					}
					return "Windows 8.1";
				case 4:
					return "Windows 10";
				}
			}
		}
		else
		{
			*(int*)ptr = version_0.Minor;
			switch (*(int*)ptr)
			{
			case 0:
				return "Windows 2000";
			case 1:
				return "Windows XP";
			case 2:
				if ((((byte*)ptr)[4] & ((byte*)ptr)[5]) == 0)
				{
					return "Windows Server 2003";
				}
				return "Windows XP 64-Bit Edition";
			}
		}
		return $"Windows {version_0.Major}.{version_0.Minor}.{version_0.Build}.{version_0.Revision}";
	}

	internal static Enum2 smethod_1()
	{
		return Enum2.const_0;
	}

	internal static Version smethod_2(Enum2 enum2_0, Version version_0)
	{
		return smethod_3(version_0);
	}

	private unsafe static Version smethod_3(Version version_0)
	{
		void* ptr = stackalloc byte[20];
		try
		{
			if (version_0.Major < 6 || version_0.Minor < 2)
			{
				if (version_0.Major != 0)
				{
					return version_0;
				}
				if (version_0.Minor != 0)
				{
					return version_0;
				}
			}
			Enum4 enum4_;
			using Class15 @class = Class32.smethod_12(Class14.uintptr_2, Enum5.const_0, Enum3.const_0, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", out enum4_) ?? Class32.smethod_12(Class14.uintptr_2, Enum5.const_0, Enum3.const_0, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion", out enum4_);
			if (enum4_ == Enum4.const_2)
			{
				int major = 0;
				int minor = 0;
				*(int*)ptr = 0;
				*(int*)((byte*)ptr + 4) = 0;
				object object_3;
				object obj;
				if (@class.vmethod_1("CurrentMajorVersionNumber", out var object_) && @class.vmethod_1("CurrentMinorVersionNumber", out var object_2))
				{
					if ((obj = object_) is int)
					{
						*(int*)((byte*)ptr + 8) = (int)obj;
						major = *(int*)((byte*)ptr + 8);
					}
					if ((obj = object_2) is int)
					{
						*(int*)((byte*)ptr + 12) = (int)obj;
						minor = *(int*)((byte*)ptr + 12);
					}
				}
				else if (@class.vmethod_1("CurrentVersion", out object_3) && object_3 is string string_)
				{
					Version version = smethod_4(string_);
					major = version.Major;
					minor = version.Minor;
				}
				if (@class.vmethod_1("CurrentBuildNumber", out var object_4) && object_4 is string string_2)
				{
					*(int*)ptr = smethod_4(string_2).Major;
				}
				if (@class.vmethod_1("UBR", out var object_5) && (obj = object_5) is int)
				{
					*(int*)((byte*)ptr + 16) = (int)obj;
					*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 16);
				}
				return new Version(major, minor, *(int*)ptr, *(int*)((byte*)ptr + 4));
			}
			return version_0;
		}
		catch
		{
			return version_0;
		}
	}

	private unsafe static Version smethod_4(string string_0)
	{
		void* ptr = stackalloc byte[12];
		Struct4 struct4_ = default(Struct4);
		struct4_.string_0 = string_0;
		struct4_.int_0 = 0;
		int[] array = new int[4];
		*(int*)ptr = 0;
		while (*(int*)ptr < 4)
		{
			smethod_5(ref struct4_);
			*(int*)((byte*)ptr + 4) = smethod_6(ref struct4_);
			if (*(int*)((byte*)ptr + 4) == 0)
			{
				break;
			}
			if (int.TryParse(struct4_.string_0.Substring(struct4_.int_0, *(int*)((byte*)ptr + 4)), out *(int*)((byte*)ptr + 8)))
			{
				array[*(int*)ptr] = *(int*)((byte*)ptr + 8);
			}
			struct4_.int_0 += *(int*)((byte*)ptr + 4);
			(*(int*)ptr)++;
		}
		return new Version(array[0], array[1], array[2], array[3]);
	}

	[CompilerGenerated]
	internal static void smethod_5(ref Struct4 struct4_0)
	{
		while (struct4_0.int_0 < struct4_0.string_0.Length && !char.IsNumber(struct4_0.string_0[struct4_0.int_0]))
		{
			struct4_0.int_0++;
		}
	}

	[CompilerGenerated]
	internal static int smethod_6(ref Struct4 struct4_0)
	{
		int i;
		for (i = struct4_0.int_0; i < struct4_0.string_0.Length && char.IsNumber(struct4_0.string_0[i]); i++)
		{
		}
		return i - struct4_0.int_0;
	}
}
