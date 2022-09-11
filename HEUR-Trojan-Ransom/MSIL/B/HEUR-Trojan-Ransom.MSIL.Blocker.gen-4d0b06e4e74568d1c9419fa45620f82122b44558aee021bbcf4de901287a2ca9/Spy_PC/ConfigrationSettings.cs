using System;
using System.IO;

namespace Spy_PC;

internal class ConfigrationSettings
{
	private static ConfigrationSettings instance;

	public string url = "";

	public string email = "";

	public string password = "";

	public string company_id = "";

	private CryptoClass cyptoClass = CryptoClass.Instance;

	public static ConfigrationSettings Instance
	{
		get
		{
			if (instance == null)
			{
				instance = new ConfigrationSettings();
			}
			return instance;
		}
	}

	private ConfigrationSettings()
	{
	}

	public void SetValues(string url, string company_id)
	{
		this.url = url;
		this.company_id = company_id;
		string text = cyptoClass.EncryptText(this.url + "___" + this.company_id);
		string[] contents = new string[1] { text };
		File.WriteAllLines("config.properties", contents);
	}

	public void SetValues(string url)
	{
		string fullPath = Path.GetFullPath(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\");
		string[] contents = new string[1] { url };
		File.WriteAllLines(fullPath + "config.properties", contents);
	}

	public void SetValues(string email, string password, string company_id)
	{
		this.email = email;
		this.password = password;
		string text = cyptoClass.EncryptText(this.email + "___" + this.password);
		string[] contents = new string[1] { text };
		File.WriteAllLines("session.properties", contents);
	}
}
