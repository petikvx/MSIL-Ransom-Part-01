using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;

internal class Class9 : SafeHandleZeroOrMinusOneIsInvalid
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class10
	{
		public static readonly Class10 class10_0 = new Class10();

		internal void method_0(object sender, EventArgs e)
		{
			bool_0 = true;
		}
	}

	private static bool bool_0;

	static Class9()
	{
		Application.add_ApplicationExit((EventHandler)delegate
		{
			bool_0 = true;
		});
	}

	public Class9()
		: base(ownsHandle: true)
	{
	}

	protected override bool ReleaseHandle()
	{
		if (bool_0)
		{
			return true;
		}
		return Class8.UnhookWindowsHookEx(handle) != 0;
	}
}
