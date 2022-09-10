using System;
using System.Runtime.InteropServices;

namespace MakeExeZip;

internal class NativeMethods
{
	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	internal static extern IntPtr BeginUpdateResource(string fileName, bool deleteExistingResource);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	internal static extern bool UpdateResource(IntPtr hUpdate, int lpType, string lpName, int wLanguage, byte[] data, int cbData);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	internal static extern bool EndUpdateResource(IntPtr hUpdate, bool fDiscard);
}
