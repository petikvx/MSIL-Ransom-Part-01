using System;
using System.Reflection;
using System.Runtime.CompilerServices;

public class EX
{
	public class ASMInit
	{
		private Assembly assembly_0;

		private static bool bool_0;

		public ASMInit(byte[] Init)
		{
			assembly_0 = Assembly.Load(Init);
		}

		public Assembly Ret()
		{
			return assembly_0;
		}
	}

	private string string_0;

	private string string_1;

	internal byte[] byte_0;

	internal object[] object_0;

	public EX(byte[] ASM, string CN, string MN, object[] args)
	{
		byte[] array = (byte_0 = ASM);
		string_0 = CN;
		string_1 = MN;
		object[] array2 = (object_0 = args);
	}

	public void Run()
	{
		ASMInit aSMInit = new ASMInit(byte_0);
		Assembly assembly = aSMInit.Ret();
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
