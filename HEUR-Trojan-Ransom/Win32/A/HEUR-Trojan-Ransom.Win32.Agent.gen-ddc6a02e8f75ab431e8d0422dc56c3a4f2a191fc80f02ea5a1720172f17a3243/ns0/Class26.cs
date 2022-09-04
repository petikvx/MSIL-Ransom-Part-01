using System;
using System.Collections.Generic;
using ns1;
using ns2;
using ns3;
using ns4;
using ns5;

namespace ns0;

internal static class Class26
{
	public static void smethod_0(string filename, bool removeIcon = true)
	{
		smethod_3(filename, out var firstIcon, out var firstVersion);
		if (firstVersion != null)
		{
			try
			{
				firstVersion.vmethod_3(filename);
			}
			catch
			{
			}
		}
		if (removeIcon && firstIcon != null)
		{
			try
			{
				firstIcon.vmethod_3(filename);
			}
			catch
			{
			}
		}
		Class6 @class = new Class6();
		@class.method_5("1.0.7601.2342");
		@class.method_7("1.0.7601.2342");
		Class17 class2 = new Class17();
		@class[class2.method_0()] = class2;
		Class16 class3 = new Class16();
		class3.method_4(1033);
		class3.method_6(1200);
		class2.method_3().Add(class3.method_0(), class3);
		class3["ProductName"] = "Windows Virtual Service Provider";
		class3["FileDescription"] = "Windows Virtual Service Provider";
		class3["CompanyName"] = "Microsoft Corporation\0";
		class3["LegalCopyright"] = "© Microsoft Corporation. All rights reserved.";
		class3["ProductVersion"] = $"{@class.method_6()}\0";
		Class15 class4 = new Class15();
		@class[class4.method_0()] = class4;
		Class14 class5 = new Class14("Translation");
		class4.method_3().Add(class5.method_0(), class5);
		class5[Class18.smethod_8()] = 1300;
		if (@class.method_8() != null)
		{
			_ = @class.method_8().method_0().uint_9;
		}
		try
		{
			@class.vmethod_2(filename);
		}
		catch (Exception)
		{
		}
	}

	public static void smethod_1(string string_0)
	{
		smethod_3(string_0, out var firstIcon, out var firstVersion);
		if (firstVersion != null)
		{
			try
			{
				firstVersion.vmethod_3(string_0);
			}
			catch
			{
			}
		}
		if (firstIcon != null)
		{
			try
			{
				firstIcon.vmethod_3(string_0);
			}
			catch
			{
			}
		}
	}

	public static void smethod_2(string string_0, string string_1)
	{
		smethod_3(string_0, out var firstIcon, out var firstVersion);
		smethod_3(string_1, out var firstIcon2, out var firstVersion2);
		try
		{
			firstIcon2?.vmethod_3(string_1);
		}
		catch (Exception)
		{
		}
		try
		{
			firstVersion2?.vmethod_3(string_1);
		}
		catch (Exception)
		{
		}
		try
		{
			firstIcon?.vmethod_2(string_1);
		}
		catch (Exception)
		{
		}
		try
		{
			firstVersion?.vmethod_2(string_1);
		}
		catch (Exception)
		{
		}
	}

	private static void smethod_3(string filename, out Class10 firstIcon, out Class6 firstVersion)
	{
		firstIcon = null;
		firstVersion = null;
		try
		{
			using Class24 @class = new Class24();
			@class.method_2(filename);
			foreach (KeyValuePair<Class4, List<Class5>> item in @class.method_0())
			{
				Class3.Enum1 @enum;
				try
				{
					@enum = item.Key.method_2();
				}
				catch (Exception)
				{
					continue;
				}
				if (firstIcon == null && @enum == Class3.Enum1.const_12)
				{
					firstIcon = (Class10)item.Value[0];
				}
				else if (firstVersion == null && @enum == Class3.Enum1.const_13)
				{
					firstVersion = (Class6)item.Value[0];
				}
			}
		}
		catch (Exception)
		{
		}
	}
}
