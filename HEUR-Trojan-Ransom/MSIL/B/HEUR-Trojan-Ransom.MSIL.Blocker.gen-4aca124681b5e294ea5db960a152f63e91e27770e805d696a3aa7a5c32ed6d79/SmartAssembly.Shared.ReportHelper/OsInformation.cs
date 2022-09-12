using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns10;
using ns2;
using ns4;
using ns8;

namespace SmartAssembly.Shared.ReportHelper;

public static class OsInformation
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct1
	{
		public string string_0;

		public int int_0;
	}

	[NonSerialized]
	internal static GetString getString_0;

	public static string smethod_0(Version version_0)
	{
		return smethod_1(version_0);
	}

	private unsafe static string smethod_1(Version version_0)
	{
		void* ptr = stackalloc byte[10];
		((byte*)ptr)[8] = (OsVersionInformation.smethod_0() ? ((byte)1) : ((byte)0));
		((byte*)ptr)[9] = (OsVersionInformation.smethod_1() ? ((byte)1) : ((byte)0));
		*(int*)ptr = version_0.Major;
		if (*(int*)ptr != 5)
		{
			if (*(int*)ptr != 6)
			{
				if (*(int*)ptr == 10 && version_0.Minor == 0)
				{
					if (((byte*)ptr)[8] == 0)
					{
						if (version_0.Build < 17623)
						{
							return getString_0(107390991);
						}
						return getString_0(107390962);
					}
					return getString_0(107390528);
				}
			}
			else
			{
				*(int*)((byte*)ptr + 4) = version_0.Minor;
				switch (*(int*)((byte*)ptr + 4))
				{
				case 0:
					if (((byte*)ptr)[8] == 0)
					{
						return getString_0(107390716);
					}
					return getString_0(107390687);
				case 1:
					if (((byte*)ptr)[8] == 0)
					{
						return getString_0(107390634);
					}
					return getString_0(107390601);
				case 2:
					if (((byte*)ptr)[8] == 0)
					{
						return getString_0(107390620);
					}
					return getString_0(107390591);
				case 3:
					if (((byte*)ptr)[8] == 0)
					{
						return getString_0(107390546);
					}
					return getString_0(107390513);
				case 4:
					return getString_0(107390528);
				}
			}
		}
		else
		{
			*(int*)((byte*)ptr + 4) = version_0.Minor;
			switch (*(int*)((byte*)ptr + 4))
			{
			case 0:
				return getString_0(107391328);
			case 1:
				return getString_0(107391279);
			case 2:
				if ((((byte*)ptr)[8] & ((byte*)ptr)[9]) == 0)
				{
					return getString_0(107391294);
				}
				return getString_0(107390753);
			}
		}
		return string.Format(getString_0(107390933), version_0.Major, version_0.Minor, version_0.Build, version_0.Revision);
	}

	public static Version smethod_2(Version version_0)
	{
		return smethod_6(smethod_5(), version_0);
	}

	public static void smethod_3(out Enum1 enum1_0, ref Version version_0, ref Version version_1, ref string string_0, out string string_1, out bool bool_0)
	{
		enum1_0 = smethod_5();
		version_1 = smethod_6(enum1_0, version_1);
		string_1 = smethod_4(version_1);
		bool_0 = OsVersionInformation.smethod_1();
	}

	public static string smethod_4(Version version_0)
	{
		return string.Format(getString_0(107390900), version_0.Major, version_0.Minor, version_0.Build, version_0.Revision);
	}

	private static Enum1 smethod_5()
	{
		return Enum1.const_0;
	}

	private static Version smethod_6(Enum1 enum1_0, Version version_0)
	{
		return smethod_7(version_0);
	}

	private unsafe static Version smethod_7(Version version_0)
	{
		void* ptr = stackalloc byte[20];
		try
		{
			if (!(version_0 >= new Version(6, 2)))
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
			Enum3 enum3_;
			using Class7 @class = Class9.smethod_0(Class6.uintptr_2, Enum4.const_0, Enum2.const_0, getString_0(107390855), out enum3_) ?? Class9.smethod_0(Class6.uintptr_2, Enum4.const_0, Enum2.const_0, getString_0(107390794), out enum3_);
			if (enum3_ == Enum3.const_2)
			{
				int major = 0;
				int minor = 0;
				*(int*)ptr = 0;
				*(int*)((byte*)ptr + 4) = 0;
				object object_3;
				if (@class.vmethod_1(getString_0(107390237), out var object_) && @class.vmethod_1(getString_0(107390200), out var object_2))
				{
					if (object_ is int)
					{
						*(int*)((byte*)ptr + 8) = (int)object_;
						major = *(int*)((byte*)ptr + 8);
					}
					if (object_2 is int)
					{
						*(int*)((byte*)ptr + 12) = (int)object_2;
						minor = *(int*)((byte*)ptr + 12);
					}
				}
				else if (@class.vmethod_1(getString_0(107390131), out object_3) && object_3 is string string_)
				{
					Version version = smethod_8(string_);
					major = version.Major;
					minor = version.Minor;
				}
				if (@class.vmethod_1(getString_0(107390142), out var object_4) && object_4 is string string_2)
				{
					*(int*)ptr = smethod_8(string_2).Major;
				}
				if (@class.vmethod_1(getString_0(107390117), out var object_5) && object_5 is int)
				{
					*(int*)((byte*)ptr + 16) = (int)object_5;
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

	private unsafe static Version smethod_8(string string_0)
	{
		void* ptr = stackalloc byte[12];
		Struct1 struct1_ = default(Struct1);
		struct1_.string_0 = string_0;
		struct1_.int_0 = 0;
		int[] array = new int[4];
		*(int*)ptr = 0;
		while (*(int*)ptr < 4)
		{
			smethod_9(ref struct1_);
			*(int*)((byte*)ptr + 4) = smethod_10(ref struct1_);
			if (*(int*)((byte*)ptr + 4) == 0)
			{
				break;
			}
			if (int.TryParse(struct1_.string_0.Substring(struct1_.int_0, *(int*)((byte*)ptr + 4)), out *(int*)((byte*)ptr + 8)))
			{
				array[*(int*)ptr] = *(int*)((byte*)ptr + 8);
			}
			struct1_.int_0 += *(int*)((byte*)ptr + 4);
			(*(int*)ptr)++;
		}
		return new Version(array[0], array[1], array[2], array[3]);
	}

	internal static void smethod_9(ref Struct1 struct1_0)
	{
		while (struct1_0.int_0 < struct1_0.string_0.Length && !char.IsNumber(struct1_0.string_0[struct1_0.int_0]))
		{
			struct1_0.int_0++;
		}
	}

	internal static int smethod_10(ref Struct1 struct1_0)
	{
		int i;
		for (i = struct1_0.int_0; i < struct1_0.string_0.Length && char.IsNumber(struct1_0.string_0[i]); i++)
		{
		}
		return i - struct1_0.int_0;
	}

	static OsInformation()
	{
		Strings.CreateGetStringDelegate(typeof(OsInformation));
	}
}
