using System;

namespace Orcus.Utilities.WindowsDesktop;

public struct Window
{
	public IntPtr Handle { get; }

	public Window(IntPtr handle)
	{
		Handle = handle;
	}
}
