using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

[StandardModule]
internal sealed class scanners
{
	public static string mdsc(string filename)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		string text = default(string);
		int num = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
					FileStream inputStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
					mD5CryptoServiceProvider.ComputeHash(inputStream);
					byte[] hash = mD5CryptoServiceProvider.Hash;
					StringBuilder stringBuilder = new StringBuilder();
					byte[] array = hash;
					foreach (byte b in array)
					{
						stringBuilder.Append($"{b:X2}");
					}
					text = stringBuilder.ToString();
					goto end_IL_0001;
				}
				case 124:
					num = -1;
					switch (num2)
					{
					case 2:
						num3 = 1;
						goto end_IL_0001;
					}
					break;
				}
				goto IL_00b8;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj, num3);
				try0001_dispatch = 124;
				continue;
			}
			break;
			IL_00b8:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		string result = text;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string shsc(string filename)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		string text = default(string);
		int num = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
					FileStream inputStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
					sHA1CryptoServiceProvider.ComputeHash(inputStream);
					byte[] hash = sHA1CryptoServiceProvider.Hash;
					StringBuilder stringBuilder = new StringBuilder();
					byte[] array = hash;
					foreach (byte b in array)
					{
						stringBuilder.Append($"{b:X2}");
					}
					text = stringBuilder.ToString();
					goto end_IL_0001;
				}
				case 124:
					num = -1;
					switch (num2)
					{
					case 2:
						num3 = 1;
						goto end_IL_0001;
					}
					break;
				}
				goto IL_00b8;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj, num3);
				try0001_dispatch = 124;
				continue;
			}
			break;
			IL_00b8:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		string result = text;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
