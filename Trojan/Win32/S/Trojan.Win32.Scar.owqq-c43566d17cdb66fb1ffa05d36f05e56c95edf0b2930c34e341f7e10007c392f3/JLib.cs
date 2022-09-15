using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

internal static class JLib
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct TokPriv1Luid
	{
		public int Count;

		public long Luid;

		public int Attr;
	}

	public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

	public const int SE_PRIVILEGE_ENABLED = 2;

	public const int TOKEN_QUERY = 8;

	public const int TOKEN_ADJUST_PRIVILEGES = 32;

	public const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

	public const int EWX_LOGOFF = 0;

	public const int EWX_SHUTDOWN = 1;

	public const int EWX_REBOOT = 2;

	public const int EWX_FORCE = 4;

	public const int EWX_POWEROFF = 8;

	public const int EWX_FORCEIFHUNG = 16;

	private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

	[DllImport("user32.dll", SetLastError = true)]
	public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	public static extern int GetWindowText(IntPtr hWnd, StringBuilder strText, int maxCount);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	public static extern int GetWindowTextLength(IntPtr hWnd);

	[DllImport("user32.dll")]
	public static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

	[DllImport("kernel32.dll", ExactSpelling = true)]
	internal static extern IntPtr GetCurrentProcess();

	[DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr phtok);

	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern bool LookupPrivilegeValue(string host, string name, ref long pluid);

	[DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall, ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

	[DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool ExitWindowsEx(int flg, int rea);

	public static void DoExitWin(int flg)
	{
		IntPtr currentProcess = GetCurrentProcess();
		IntPtr phtok = IntPtr.Zero;
		OpenProcessToken(currentProcess, 40, ref phtok);
		TokPriv1Luid newst = default(TokPriv1Luid);
		newst.Count = 1;
		newst.Luid = 0L;
		newst.Attr = 2;
		LookupPrivilegeValue(null, "SeShutdownPrivilege", ref newst.Luid);
		AdjustTokenPrivileges(phtok, disall: false, ref newst, 0, IntPtr.Zero, IntPtr.Zero);
		ExitWindowsEx(flg, 0);
	}

	public static string GetWindowText(IntPtr hWnd)
	{
		int windowTextLength = GetWindowTextLength(hWnd);
		if (windowTextLength > 0)
		{
			StringBuilder stringBuilder = new StringBuilder(windowTextLength + 1);
			GetWindowText(hWnd, stringBuilder, stringBuilder.Capacity);
			return stringBuilder.ToString();
		}
		return string.Empty;
	}

	public static IEnumerable<IntPtr> FindWindows(EnumWindowsProc filter)
	{
		List<IntPtr> windows = new List<IntPtr>();
		EnumWindows(delegate(IntPtr wnd, IntPtr param)
		{
			if (filter(wnd, param))
			{
				windows.Add(wnd);
			}
			return true;
		}, IntPtr.Zero);
		return windows;
	}

	public static IEnumerable<IntPtr> FindWindowsWithText(string titleText)
	{
		return FindWindows((IntPtr wnd, IntPtr param) => GetWindowText(wnd).Contains(titleText));
	}

	public static byte[] read(FileStream s, int length, int c)
	{
		BinaryReader binaryReader = new BinaryReader(s);
		binaryReader.BaseStream.Seek(c, SeekOrigin.Begin);
		byte[] array = new byte[length];
		int num = length;
		int num2 = 0;
		while (num > 0)
		{
			int num3 = binaryReader.Read(array, num2, num);
			if (num3 == 0)
			{
				break;
			}
			num2 += num3;
			num -= num3;
		}
		binaryReader.Close();
		return array;
	}

	public static string XOR(string text, string key)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < text.Length; i++)
		{
			stringBuilder.Append((char)(text[i] ^ key[i % key.Length]));
		}
		return stringBuilder.ToString();
	}

	public static bool mutexCheck(string m)
	{
		Mutex mutex = new Mutex(initiallyOwned: false, m);
		try
		{
			if (mutex.WaitOne(0, exitContext: false))
			{
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public static byte rollDice(byte numberSides)
	{
		if (numberSides <= 0)
		{
			throw new ArgumentOutOfRangeException("numberSides");
		}
		byte[] array = new byte[1];
		do
		{
			rngCsp.GetBytes(array);
		}
		while (!IsFairRoll(array[0], numberSides));
		return (byte)((int)array[0] % (int)numberSides + 1);
	}

	private static bool IsFairRoll(byte roll, byte numSides)
	{
		int num = 255 / (int)numSides;
		return roll < numSides * num;
	}

	public static string randStringU(int length)
	{
		string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
		char[] array = new char[length];
		new Random();
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = text[rollDice((byte)(text.Length - 1))];
		}
		return new string(array);
	}

	public static string randString(int length)
	{
		string text = "abcdefghijklmnopqrstuvwxyz";
		string text2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
		char[] array = new char[length];
		new Random();
		array[0] = text[rollDice((byte)(text.Length - 1))];
		for (int i = 1; i < array.Length; i++)
		{
			array[i] = text2[rollDice((byte)(text2.Length - 1))];
		}
		return new string(array);
	}

	public static string GetMd5Hash(string input)
	{
		MD5 mD = MD5.Create();
		byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(input));
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	public static bool VerifyMd5Hash(string input, string hash)
	{
		string md5Hash = GetMd5Hash(input);
		StringComparer ordinalIgnoreCase = StringComparer.OrdinalIgnoreCase;
		if (ordinalIgnoreCase.Compare(md5Hash, hash) == 0)
		{
			return true;
		}
		return false;
	}

	public static string ConvertStringArrayToStringJoin(string[] array)
	{
		return string.Join(" ", array);
	}

	public static bool dateCheck(int m, int d)
	{
		if (DateTime.Today.Month.ToString() == m.ToString())
		{
			if (DateTime.Today.Day.ToString() == d.ToString())
			{
				return true;
			}
			return false;
		}
		return false;
	}

	public static bool isAlphaNumeric(char s)
	{
		return Enumerable.Contains("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", s);
	}

	public static void standardExceptionBox(Exception e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(e.ToString() + "\n\n" + e.StackTrace);
	}

	public static string repeatTime(int times, string s)
	{
		int i = 0;
		string text = "";
		for (; i <= times; i++)
		{
			text += s;
		}
		return text;
	}
}
