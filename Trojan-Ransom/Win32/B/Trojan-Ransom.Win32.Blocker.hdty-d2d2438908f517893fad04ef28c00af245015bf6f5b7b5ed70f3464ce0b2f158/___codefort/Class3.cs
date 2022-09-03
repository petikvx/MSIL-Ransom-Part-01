using System;
using System.Reflection;

namespace ___codefort;

internal static class Class3
{
	private static object object_0;

	private static bool bool_0;

	static Class3()
	{
		object_0 = new object();
		bool_0 = false;
	}

	internal static void smethod_0()
	{
		lock (object_0)
		{
			if (bool_0)
			{
				return;
			}
			bool_0 = true;
		}
		try
		{
			smethod_1("This application was obfuscated using a trial version of CodeFort.\nIt is strictly forbidden to publish this obfuscated application in any form.\nSee more at www.codefort.org");
		}
		catch
		{
			bool_0 = false;
		}
	}

	private static void smethod_1(string string_0)
	{
		Type type = Assembly.Load("System.Windows.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089").GetType("System.Windows.Forms.MessageBox");
		MethodInfo method = type.GetMethod("Show", new Type[1] { typeof(string) });
		method.Invoke(null, new object[1] { string_0 });
	}
}
