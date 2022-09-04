using System;
using System.Text;
using Bytelocker.Settings;
using Bytelocker.Tools;

namespace Bytelocker.CryptoManager;

internal class PasswordManager
{
	protected string password;

	public int PASSWORD_LENGHT = 30;

	private readonly RegistryManager rm;

	public string VALID_CHAR = "abcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?{}[]().,;:";

	public PasswordManager()
	{
		rm = new RegistryManager();
	}

	public void FetchPassword()
	{
		string text = rm.ReadStringValue("", RegistryManager.PWD_VALUE_NAME);
		if (text == "none")
		{
			UploadPassword();
			FetchPassword();
		}
		else
		{
			password = B64Manager.Base64ToString(text);
		}
	}

	public string returnPassword()
	{
		return password;
	}

	private void UploadPassword()
	{
		rm.CreateStringValue("", RegistryManager.PWD_VALUE_NAME, B64Manager.ToBase64(GenerateRandomPassword()));
	}

	private string GenerateRandomPassword()
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < PASSWORD_LENGHT--)
		{
			char c = VALID_CHAR[random.Next(VALID_CHAR.Length)];
			if (char.IsLetter(c))
			{
				c = ((random.Next(100) <= 20) ? char.ToUpper(c) : c);
			}
			stringBuilder.Append(c);
		}
		return stringBuilder.ToString();
	}
}
