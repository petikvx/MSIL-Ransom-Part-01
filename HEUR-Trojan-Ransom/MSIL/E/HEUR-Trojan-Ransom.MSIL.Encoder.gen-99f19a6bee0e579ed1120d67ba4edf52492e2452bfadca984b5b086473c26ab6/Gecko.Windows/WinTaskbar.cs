using System;
using Gecko.Interop;

namespace Gecko.Windows;

public sealed class WinTaskbar
{
	private readonly ComPtr<nsIWinTaskbar> _winTaskbar;

	public bool Available => _winTaskbar.Instance.GetAvailableAttribute();

	public string DefaultGroupId => nsString.Get(_winTaskbar.Instance.GetDefaultGroupIdAttribute);

	public WinTaskbar()
	{
		_winTaskbar = Xpcom.CreateInstance2<nsIWinTaskbar>("@mozilla.org/windows-taskbar;1");
	}

	public JumpListBuilder CreateJumpListBuilder()
	{
		return new JumpListBuilder(_winTaskbar.Instance.CreateJumpListBuilder());
	}

	public void PrepareFullScreenHWND(IntPtr aWindow, bool aFullScreen)
	{
		_winTaskbar.Instance.PrepareFullScreenHWND(aWindow, aFullScreen);
	}

	public void SetGroupIdForWindow(GeckoWindow aParent, string aIdentifier)
	{
		nsString.Set(delegate(nsAString x)
		{
			_winTaskbar.Instance.SetGroupIdForWindow(aParent.DomWindow, x);
		}, aIdentifier);
	}
}
