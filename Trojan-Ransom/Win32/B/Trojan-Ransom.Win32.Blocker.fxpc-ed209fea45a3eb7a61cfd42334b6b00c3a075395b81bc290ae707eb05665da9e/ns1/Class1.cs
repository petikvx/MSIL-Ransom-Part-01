using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns1;

internal class Class1
{
	public class Class2
	{
		private Assembly assembly_0;

		public Class2(byte[] byte_0)
		{
			assembly_0 = Assembly.Load(byte_0);
		}

		public Assembly method_0()
		{
			return assembly_0;
		}
	}

	private byte[] byte_0;

	private string string_0;

	private string string_1;

	private object[] object_0;

	public Class1(byte[] byte_1, string string_2, string string_3, object[] object_1)
	{
		byte_0 = byte_1;
		string_0 = string_2;
		string_1 = string_3;
		object_0 = object_1;
	}

	public void method_0()
	{
		Class2 @class = new Class2(byte_0);
		Assembly assembly = @class.method_0();
		Type[] types = assembly.GetTypes();
		foreach (Type type in types)
		{
			if (type.IsClass && type.FullName!.EndsWith("." + string_0))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type));
				type.InvokeMember(string_1, BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), object_0);
			}
		}
	}
}
