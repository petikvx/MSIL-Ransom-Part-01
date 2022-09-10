using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace VaultMirror;

[Serializable]
public class Settings
{
	private static string FILENAME = "settings.dat";

	private Dictionary<string, Login> m_logins;

	private Settings()
	{
		m_logins = new Dictionary<string, Login>();
	}

	public void AddLogin(Login login)
	{
		m_logins[login.Server.ToLower() + ";" + login.Vault.ToLower()] = login;
	}

	public Login GetLogin(string server, string vault)
	{
		string key = server.ToLower() + ";" + vault.ToLower();
		if (m_logins.ContainsKey(key))
		{
			return m_logins[key];
		}
		return null;
	}

	public Login GetOnlyLogin()
	{
		if (m_logins.Count == 1)
		{
			Dictionary<string, Login>.Enumerator enumerator = m_logins.GetEnumerator();
			enumerator.MoveNext();
			return enumerator.Current.Value;
		}
		return null;
	}

	public static Settings LoadSettings()
	{
		IFormatter formatter = new BinaryFormatter();
		Stream stream = null;
		try
		{
			stream = new FileStream(FILENAME, FileMode.Open);
			return (Settings)formatter.Deserialize(stream);
		}
		catch
		{
		}
		finally
		{
			stream?.Close();
		}
		return new Settings();
	}

	public void SaveSettings()
	{
		IFormatter formatter = new BinaryFormatter();
		Stream stream = null;
		try
		{
			stream = new FileStream(FILENAME, FileMode.Create);
			formatter.Serialize(stream, this);
		}
		catch
		{
		}
		finally
		{
			stream?.Close();
		}
	}
}
