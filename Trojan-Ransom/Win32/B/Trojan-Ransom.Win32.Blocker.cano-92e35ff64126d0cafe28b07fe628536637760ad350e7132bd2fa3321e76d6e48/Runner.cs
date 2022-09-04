using System;
using System.Reflection;

internal class Runner
{
	public static string RunStuff(Type typex, object ClassyObject, byte[] files)
	{
		typex.InvokeMember("TheTings", BindingFlags.InvokeMethod, null, ClassyObject, new object[1] { files });
		return "0";
	}
}
