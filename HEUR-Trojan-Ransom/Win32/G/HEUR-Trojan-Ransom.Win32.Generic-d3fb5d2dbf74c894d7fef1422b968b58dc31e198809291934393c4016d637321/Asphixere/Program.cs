using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Asphixere.Properties;

namespace Asphixere;

internal static class Program
{
	[STAThread]
	private unsafe static void Main()
	{
		GCHandle gCHandle = GCHandle.Alloc(Resources.Byte_0, GCHandleType.Pinned);
		try
		{
			Application.Run((Form)(object)new Form1(new UnmanagedMemoryStream((byte*)gCHandle.AddrOfPinnedObject().ToPointer(), Resources.Byte_0.Length)));
		}
		catch (Exception)
		{
		}
		try
		{
			if (gCHandle.IsAllocated)
			{
				gCHandle.Free();
			}
		}
		catch
		{
		}
	}
}
