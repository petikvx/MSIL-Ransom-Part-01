using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

[StandardModule]
internal sealed class mResource
{
	[DllImport("kernel32.dll")]
	private static extern IntPtr FindResource(IntPtr hModule, string lpName, string lpType);

	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

	[DllImport("kernel32.dll")]
	private static extern IntPtr LockResource(IntPtr hResData);

	[DllImport("kernel32")]
	private static extern uint SizeofResource(IntPtr hModule, IntPtr hResInfo);

	public static string getData(string sFile, string sKey)
	{
		byte[] array = new byte[2];
		IntPtr hResInfo = FindResource(IntPtr.Zero, sFile, sKey);
		IntPtr hResData = LoadResource(IntPtr.Zero, hResInfo);
		IntPtr source = LockResource(hResData);
		uint num = SizeofResource(IntPtr.Zero, hResInfo);
		try
		{
			Array.Resize(ref array, checked((int)num));
			Marshal.Copy(source, array, 0, Convert.ToInt32(num));
			return Encoding.Default.GetString(array);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
