using System;

namespace VaultMirror;

[Serializable]
public class Login
{
	public string Username;

	public string Password;

	public string Server;

	public string Vault;

	public string MirrorFolder;

	public DateTime LastSyncTime = DateTime.MinValue;

	public Login(string username, string password, string server, string vault, string mirrorFolder, DateTime lastSyncTime)
	{
		Username = username;
		Password = password;
		Server = server;
		Vault = vault;
		MirrorFolder = mirrorFolder;
		LastSyncTime = lastSyncTime;
	}
}
