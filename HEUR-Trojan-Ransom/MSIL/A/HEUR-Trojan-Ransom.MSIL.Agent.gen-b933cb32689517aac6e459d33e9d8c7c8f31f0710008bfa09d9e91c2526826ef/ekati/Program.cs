using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using ekati.Properties;

namespace ekati;

internal class Program
{
	private static bool gui = false;

	private static bool rollback = false;

	private static bool debug = true;

	private static Logger logger = new Logger();

	private static readonly List<string> EPR_Excel_Security = new List<string>(new string[3] { "\\Excel\\Security", "Level", "1" });

	private static readonly List<string> EPR_Word_Security = new List<string>(new string[3] { "\\Word\\Security", "Level", "1" });

	private static readonly List<string> EPR_Registry_Autorun = new List<string>(new string[3] { "\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "EPRTest", "c:\\temp\\eprtest.exe" });

	private static readonly List<string> EPR_Iexplorer_Dis_Cert_Rev_Chk = new List<string>(new string[3] { "\\Excel\\Security", "CertificateRevocation", "0" });

	private static readonly List<string> EPR_Iexplorer_No_Js_Dbg = new List<string>(new string[3] { "\\Excel\\Security", "DisableScriptDebuggerIE", "yes" });

	private static readonly List<string> EPR_Control_Panel_Disabled = new List<string>(new string[3] { "\\Excel\\Security", "NoControlPanel", "1" });

	private static readonly List<string> EPR_Download_Dir_Disabled = new List<string>(new string[3] { "\\Excel\\Security", "NoSelectDownloadDir", "1" });

	private static readonly List<string> EPR_Desktop_Disabled = new List<string>(new string[3] { "\\Excel\\Security", "NoDesktop", "1" });

	private static CspParameters cspp = new CspParameters();

	private static RSACryptoServiceProvider rsa;

	private const string keyName = "ekati";

	[STAThread]
	private static void Main(string[] args)
	{
		try
		{
			Arguments arguments = new Arguments(args);
			if (arguments["gui"] != null)
			{
				gui = Convert.ToBoolean(arguments["gui"]);
			}
			if (arguments["rollback"] != null)
			{
				rollback = Convert.ToBoolean(arguments["rollback"]);
			}
			if (arguments["debug"] != null)
			{
				debug = Convert.ToBoolean(arguments["debug"]);
			}
			Version version = Assembly.GetEntryAssembly()!.GetName().Version;
			if (debug)
			{
				logger.AddtoLogFile("Running ekati: " + version.ToString() + "\r\n");
			}
			if (rollback)
			{
				MainForm mainForm = new MainForm();
				if (debug)
				{
					logger.AddtoLogFile("Rollback files on user desktop:");
				}
				mainForm.ProcessRollback(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
				if (debug)
				{
					logger.AddtoLogFile(" ");
				}
				if (Application.get_MessageLoop())
				{
					Application.Exit();
				}
				else
				{
					Environment.Exit(1);
				}
			}
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string[] array;
			try
			{
				array = Directory.GetFiles(folderPath + "\\Documents", "*.encrypt");
			}
			catch
			{
				array = new string[0];
			}
			if (array.Length != 0)
			{
				ThreadWork threadWork = new ThreadWork();
				threadWork.SetDebug(debug);
				Thread thread = new Thread(threadWork.ThreadFour);
				thread.Start();
				return;
			}
			ThreadWork threadWork2 = new ThreadWork();
			threadWork2.SetDebug(debug);
			Thread thread2 = new Thread(threadWork2.ThreadOne);
			Thread thread3 = new Thread(threadWork2.ThreadTwo);
			Thread thread4 = new Thread(threadWork2.ThreadThree);
			Thread thread5 = new Thread(threadWork2.ThreadFour);
			Thread thread6 = new Thread(threadWork2.ThreadFive);
			thread2.Start();
			thread3.Start();
			thread4.Start();
			thread5.Start();
			thread6.Start();
			EPR_Suspicious_Extension();
			EPR_WriteRegistry(EPR_Control_Panel_Disabled);
			EPR_WriteRegistry(EPR_Excel_Security);
			EPR_WriteRegistry(EPR_Word_Security);
			EPR_WriteRegistry(EPR_Iexplorer_Dis_Cert_Rev_Chk);
			EPR_WriteRegistry(EPR_Iexplorer_No_Js_Dbg);
			EPR_WriteRegistry(EPR_Registry_Autorun);
			EPR_WriteRegistry(EPR_Download_Dir_Disabled);
			EPR_WriteRegistry(EPR_Desktop_Disabled);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c message.html";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
		}
		catch (Exception ex)
		{
			logger.AddtoLogFile("Error: " + ex.Message);
		}
	}

	public static void ShowHelp()
	{
		Version version = Assembly.GetEntryAssembly()!.GetName().Version;
		logger.AddtoLogFile("Running ekati version: " + version.ToString());
		Console.WriteLine("");
		Console.WriteLine("Name: ");
		Console.WriteLine("\tekait version: " + version.ToString());
		Console.WriteLine("");
		Console.WriteLine("Synopsis:");
		Console.WriteLine("\tekati.exe [Parameters]");
		Console.WriteLine("");
		Console.WriteLine("Parameters (Optional):");
		Console.WriteLine("\t-gui=<yes or no, default is no>");
		Console.WriteLine("");
		Console.WriteLine("Contact:");
		Console.WriteLine("\tContact me for any questions or issues: lwei@malwarebytes.com");
		Environment.Exit(0);
	}

	public static void EPR_Suspicious_Extension()
	{
		string text = Path.Combine(Path.GetTempPath(), "vacation.jpg.exe");
		using (FileStream stream = File.Create(text))
		{
			using StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.WriteLine("File written by Ekati");
		}
		if (debug)
		{
			logger.AddtoLogFile("Created file: \r\n\t" + text + "\r\n");
		}
	}

	public static void EPR_WriteRegistry(List<string> item)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Malwarebytes\\Ekati\\" + item[0]);
		registryKey.SetValue(item[1], item[2]);
		registryKey.Close();
		Thread.Sleep(1000);
		if (debug)
		{
			logger.AddtoLogFile("Registry written: \r\n\tSOFTWARE\\Malwarebytes\\Ekati\\" + item[0] + ", " + item[1] + ", " + item[2] + "\r\n");
		}
	}

	public static bool BlockWebProtection()
	{
		string text = "100.24.169.13";
		try
		{
			IPHostEntry hostEntry = Dns.GetHostEntry("iptest.malwarebytes.com");
			if (hostEntry.AddressList.Length != 0)
			{
				text = hostEntry.AddressList[0].ToString();
			}
			WebClient webClient = new WebClient();
			webClient.DownloadFile("http://" + text, "iptest.html");
			return false;
		}
		catch (Exception)
		{
			logger.AddtoLogFile("Web Protected blocked site successfully");
			return true;
		}
	}

	public static void CreateFiles()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string[] array = new string[4] { "dir1", "dir2", "dir3", "dir4" };
			string[] array2 = new string[4] { ".pdf", ".jpg", ".mp4", ".mp3" };
			string contents = "some text from ekati for files to be encrypted";
			for (int i = 0; i < array.Length; i++)
			{
				Directory.CreateDirectory(".\\" + array[i]);
				for (int j = 0; j < 5; j++)
				{
					File.WriteAllText(".\\" + array[i] + "\\file" + j + array2[i], contents);
				}
			}
			ProcessDirectory(Directory.GetCurrentDirectory());
		}
		catch (Exception ex)
		{
			MessageBox.Show("Error creating files.\r\n" + ex.Message, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private static void CreatesKey()
	{
		cspp.KeyContainerName = "ekati";
		cspp.Flags |= CspProviderFlags.UseDefaultKeyContainer;
		rsa = new RSACryptoServiceProvider(cspp)
		{
			PersistKeyInCsp = true
		};
	}

	private static void EncryptFile(string inFile)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged
		{
			KeySize = 256,
			BlockSize = 256,
			Mode = CipherMode.CBC
		};
		ICryptoTransform transform = rijndaelManaged.CreateEncryptor();
		byte[] array = rsa.Encrypt(rijndaelManaged.Key, fOAEP: false);
		byte[] array2 = new byte[4];
		byte[] array3 = new byte[4];
		int num = array.Length;
		array2 = BitConverter.GetBytes(num);
		int num2 = rijndaelManaged.IV.Length;
		array3 = BitConverter.GetBytes(num2);
		int num3 = inFile.LastIndexOf("\\") + 1;
		string directoryName = Path.GetDirectoryName(inFile);
		string path = Path.Combine(directoryName, inFile.Substring(num3, inFile.LastIndexOf(".") - num3) + ".encrypted");
		using (FileStream fileStream = new FileStream(path, FileMode.Create))
		{
			fileStream.Write(array2, 0, 4);
			fileStream.Write(array3, 0, 4);
			fileStream.Write(array, 0, num);
			fileStream.Write(rijndaelManaged.IV, 0, num2);
			using (CryptoStream cryptoStream = new CryptoStream(fileStream, transform, CryptoStreamMode.Write))
			{
				int num4 = 0;
				int num5 = 0;
				int num6 = rijndaelManaged.BlockSize / 8;
				byte[] buffer = new byte[num6];
				int num7 = 0;
				using (FileStream fileStream2 = new FileStream(inFile, FileMode.Open))
				{
					do
					{
						num4 = fileStream2.Read(buffer, 0, num6);
						num5 += num4;
						cryptoStream.Write(buffer, 0, num4);
						num7 += num6;
					}
					while (num4 > 0);
					fileStream2.Close();
				}
				cryptoStream.FlushFinalBlock();
				cryptoStream.Close();
			}
			fileStream.Close();
		}
		File.Delete(inFile);
	}

	public static void ProcessDirectory(string targetDirectory)
	{
		CreatesKey();
		string[] directories = Directory.GetDirectories(targetDirectory);
		string text = "";
		for (int i = 0; i < directories.Length; i++)
		{
			text = Path.GetFileName(directories[i].ToLower());
			if (text.StartsWith("dir"))
			{
				string[] files = Directory.GetFiles(directories[i]);
				for (int j = 0; j < files.Length; j++)
				{
					ProcessFile(files[j]);
				}
			}
		}
	}

	public static void ProcessFile(string originalFile)
	{
		if (!originalFile.Contains(".encrypted") && !File.GetAttributes(originalFile).HasFlag(FileAttributes.Hidden))
		{
			EncryptFile(originalFile);
			logger.AddtoLogFile("\tEncrypted file: " + Path.GetFileName(originalFile));
		}
	}

	public static void TestRansom()
	{
		try
		{
			File.WriteAllBytes("diamond.exe", Resources.diamond);
			Process process = new Process();
			process.StartInfo.FileName = "diamond.exe";
			process.StartInfo.Arguments = " ";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.UseShellExecute = false;
			process.Start();
			process.WaitForExit();
			string text = "";
			while (!process.StandardOutput.EndOfStream)
			{
				text = text + "\t" + process.StandardOutput.ReadLine() + "\r\n";
			}
			string text2 = "";
			while (!process.StandardError.EndOfStream)
			{
				text2 = text2 + "\t" + process.StandardError.ReadLine() + "\r\n";
			}
			if (debug)
			{
				logger.AddtoLogFile("Executed command (diamond.exe): \r\n\t" + process.StartInfo.FileName + " " + process.StartInfo.Arguments + "\r\n");
			}
		}
		catch (Exception ex)
		{
			logger.AddtoLogFile("Error in topaz: \r\n" + ex.Message);
		}
	}
}
