using System;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class7
{
	public static void smethod_0(string string_0, int int_0, long long_0)
	{
		FileStream fileStream = new FileStream(string_0, FileMode.Create, FileAccess.Write);
		byte[] array = new byte[int_0 - 1 + 1];
		long num = default(long);
		do
		{
			int num2 = (int)Math.Min(array.Length, long_0 - num);
			fileStream.Write(array, 0, num2);
			num += num2;
		}
		while (num != long_0);
		fileStream.Close();
	}

	public static GStruct3 smethod_1(string string_0)
	{
		GStruct3 result = default(GStruct3);
		try
		{
			FileInfo fileInfo = new FileInfo(string_0);
			FileStream fileStream = fileInfo.OpenRead();
			result.string_0 = Class18.smethod_3(fileStream);
			result.long_0 = fileInfo.Length;
			fileStream.Close();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			GStruct3 gStruct = default(GStruct3);
			GStruct3 result2 = gStruct;
			ProjectData.ClearProjectError();
			return result2;
		}
	}

	public static bool smethod_2(string string_0, long long_0, string string_1)
	{
		FileInfo fileInfo = new FileInfo(string_0);
		if (!fileInfo.get_Exists())
		{
			return false;
		}
		if (fileInfo.Length != long_0)
		{
			return false;
		}
		FileStream fileStream = fileInfo.OpenRead();
		string text = Class18.smethod_3(fileStream);
		fileStream.Close();
		return Operators.CompareString(text, string_1, false) == 0;
	}

	public static bool smethod_3(string string_0, long long_0, long long_1, string string_1)
	{
		FileInfo fileInfo = new FileInfo(string_0);
		if (fileInfo.get_Exists())
		{
			if (fileInfo.Length != long_0)
			{
				return false;
			}
			if (long_1 == 0L)
			{
				return true;
			}
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read);
			string text = Class18.smethod_4(fileStream, 5242880, long_1);
			fileStream.Close();
			return Operators.CompareString(text, string_1, false) == 0;
		}
		if (long_1 != 0L)
		{
			return false;
		}
		smethod_0(string_0, 5242880, long_0);
		return true;
	}

	public static string smethod_4(string string_0, long long_0)
	{
		if (long_0 == 0L)
		{
			return string.Empty;
		}
		FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read);
		string result = Class18.smethod_4(fileStream, 5242880, long_0);
		fileStream.Close();
		return result;
	}

	public static byte[] smethod_5(string string_0, long long_0, int int_0)
	{
		FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read);
		int num = (int)Math.Min(fileStream.Length - long_0, int_0);
		byte[] array = new byte[num - 1 + 1];
		fileStream.Position = long_0;
		int num2 = default(int);
		do
		{
			int count = (int)Math.Min(fileStream.Length - num2, array.Length);
			int num3 = fileStream.Read(array, num2, count);
			num2 += num3;
		}
		while (num2 != array.Length);
		fileStream.Close();
		return array;
	}

	public static void smethod_6(string string_0, byte[] byte_0, long long_0)
	{
		FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Write);
		fileStream.Position = long_0;
		fileStream.Write(byte_0, 0, byte_0.Length);
		fileStream.Close();
	}
}
