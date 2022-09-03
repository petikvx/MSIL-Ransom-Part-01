using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns1;

internal sealed class Class5
{
	public static object smethod_0(byte[] byte_0, string string_0, string string_1, object[] object_0)
	{
		Assembly assembly = Assembly.Load(byte_0);
		Type[] types = assembly.GetTypes();
		int num = 0;
		Type type;
		object result = default(object);
		while (true)
		{
			if (num < types.Length)
			{
				type = types[num];
				if (type.IsClass && type.FullName!.EndsWith("." + string_0))
				{
					break;
				}
				num++;
				continue;
			}
			return result;
		}
		object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type));
		return RuntimeHelpers.GetObjectValue(type.InvokeMember(string_1, BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), object_0));
	}
}
