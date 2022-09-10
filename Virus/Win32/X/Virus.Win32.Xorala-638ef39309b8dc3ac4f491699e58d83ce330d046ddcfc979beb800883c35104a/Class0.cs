using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using Microsoft.Win32;
using log4net;

internal class Class0
{
	[Flags]
	public enum Enum0 : uint
	{
		flag_0 = 1u,
		flag_1 = 2u,
		flag_2 = 4u,
		flag_3 = 8u,
		flag_4 = 0x10u,
		flag_5 = 0x20u,
		flag_6 = 0x40u,
		flag_7 = 0x80u,
		flag_8 = 0x400u,
		flag_9 = 0x4000u
	}

	private const string string_0 = "appliand";

	private const string string_1 = "appliandMP";

	private const string string_2 = "nt_appliandmp";

	private const uint uint_0 = 1u;

	private const uint uint_1 = 983103u;

	private const uint uint_2 = 983040u;

	private const uint uint_3 = 1u;

	private const uint uint_4 = 2u;

	private const uint uint_5 = 4u;

	private const uint uint_6 = 8u;

	private const uint uint_7 = 16u;

	private const uint uint_8 = 32u;

	private const uint uint_9 = 64u;

	private const uint uint_10 = 128u;

	private const uint uint_11 = 256u;

	private const uint uint_12 = 983551u;

	private const int int_0 = -536870334;

	private const int int_1 = -2147180503;

	private static readonly ILog ilog_0 = LogManager.GetLogger(typeof(Class0));

	[DllImport("AdvApi32.dll")]
	private static extern IntPtr LockServiceDatabase(IntPtr intptr_0);

	[DllImport("AdvApi32.dll")]
	private static extern bool UnlockServiceDatabase(IntPtr intptr_0);

	[DllImport("AdvApi32.dll", SetLastError = true)]
	private static extern void CloseServiceHandle(IntPtr intptr_0);

	[DllImport("AdvApi32.dll", SetLastError = true)]
	private static extern bool DeleteService(IntPtr intptr_0);

	[DllImport("AdvApi32.dll", SetLastError = true)]
	private static extern IntPtr OpenService(IntPtr intptr_0, string string_3, uint uint_13);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern IntPtr OpenSCManager(string string_3, string string_4, uint uint_13);

	[DllImport("Setupapi.dll")]
	private static extern bool SetupUninstallOEMInf(string string_3, uint uint_13, IntPtr intptr_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern int FormatMessage(int int_2, ref IntPtr intptr_0, int int_3, int int_4, ref string string_3, int int_5, IntPtr intptr_1);

	private static string smethod_0(int int_2)
	{
		int num = 14;
		string string_ = string.Empty;
		switch (int_2)
		{
		default:
			try
			{
				IntPtr intptr_ = IntPtr.Zero;
				IntPtr zero = IntPtr.Zero;
				if (FormatMessage(4864, ref intptr_, int_2, 0, ref string_, 255, zero) == 0)
				{
					return $"Error code: {int_2}.\r\n\r\nPlease see the FAQ on www.jaksta.com for details on how to resolve this issue.";
				}
				return $"{string_}.\r\n\r\nPlease see the FAQ on www.jaksta.com for details on how to resolve this issue.";
			}
			catch (Exception ex)
			{
				return $"Error code: {int_2}. {ex.Message}\r\n\r\nPlease see the FAQ on www.jaksta.com for details on how to resolve this issue.";
			}
		case -536870334:
			return "You need to update the root certificates on your machine in order to allow this installation to continue.\r\n\r\nPlease see the FAQ on www.jaksta.com for details on how to resolve this issue.";
		case -2147180503:
			return "You have reached the maximum number of network monitoring applications that windows allows.\r\n\r\nSee the FAQ section on www.jaksta.com for details on how to adjust the maximum number of these type of programs.";
		}
	}

	private static string smethod_1()
	{
		return smethod_0(Marshal.GetLastWin32Error());
	}

	private static void smethod_2()
	{
		int num = 19;
		Console.WriteLine($"Searching for any dangling miniport drivers");
		bool flag = false;
		RegistryKey registryKey = null;
		try
		{
			registryKey = Registry.LocalMachine;
			RegistryKey registryKey2 = registryKey.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002bE10318}");
			string[] subKeyNames = registryKey2.GetSubKeyNames();
			foreach (string text in subKeyNames)
			{
				Console.WriteLine($"Searching {text}");
				RegistryKey registryKey3 = null;
				try
				{
					registryKey3 = registryKey2.OpenSubKey(text, writable: true);
					string text2 = (string)registryKey3.GetValue("ComponentId", string.Empty);
					if (text2 == "nt_appliandmp")
					{
						Enum0 @enum = (Enum0)Convert.ToInt32(registryKey3.GetValue("Characteristics", 0));
						Console.WriteLine($"Found one in {text} with characteristics {@enum}");
						if (@enum != 0)
						{
							Enum0 enum2 = @enum & ~Enum0.flag_5;
							registryKey3.SetValue("Characteristics", (uint)enum2, RegistryValueKind.DWord);
							flag = true;
							Console.WriteLine($"Removed NCF_NOT_USER_REMOVABLE. Characteristics now {enum2}");
						}
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
				finally
				{
					registryKey3?.Close();
				}
			}
		}
		catch (Exception ex2)
		{
			Console.WriteLine(ex2.Message);
		}
		finally
		{
			registryKey?.Close();
		}
		if (flag)
		{
			Console.WriteLine($">>>>> Dangling miniports have been found. Please start your device manager, show hidden devices from the View menu and uninstall any Applian Miniports displayed under the network adapters node by selecting them and then the Action > Uninstall menu. <<<<<");
		}
		else
		{
			Console.WriteLine($"No dangling miniports found.");
		}
	}

	private static void smethod_3(string string_3)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		int num = 18;
		Console.WriteLine($"Cleaning up driver service {string_3}");
		Console.WriteLine($"Stopping any existing {string_3} service");
		try
		{
			ServiceController val = new ServiceController(string_3);
			if ((int)val.get_Status() != 1)
			{
				val.Stop();
				Console.WriteLine("Waiting up to 20 seconds for the driver to stop before continuing");
				val.WaitForStatus((ServiceControllerStatus)1, new TimeSpan(0, 0, 0, 20, 0));
			}
			val.Close();
			IntPtr intptr_ = OpenSCManager(null, null, 983103u);
			if (intptr_.Equals((object?)(nint)IntPtr.Zero))
			{
				Console.WriteLine($"Unexpected error opening SC Mgr: {smethod_1()}");
				return;
			}
			IntPtr intptr_2 = LockServiceDatabase(intptr_);
			if (intptr_2.Equals((object?)(nint)IntPtr.Zero))
			{
				Console.WriteLine($"Unexpected error locking SC Mgr: {smethod_1()}");
			}
			else
			{
				IntPtr intptr_3 = OpenService(intptr_, string_3, 983551u);
				if (intptr_3.Equals((object?)(nint)IntPtr.Zero))
				{
					Console.WriteLine($"Unexpected error opening service {string_3}: {smethod_1()}");
				}
				else
				{
					if (DeleteService(intptr_3))
					{
						Console.WriteLine($"Successfully deleted driver: {string_3}");
					}
					else
					{
						Console.WriteLine($"Unexpected error deleting service {string_3}: {smethod_1()}");
					}
					CloseServiceHandle(intptr_3);
				}
				UnlockServiceDatabase(intptr_2);
			}
			CloseServiceHandle(intptr_);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
		}
	}

	private static void smethod_4()
	{
		int num = 14;
		string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "pnputil.exe");
		string text = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), ".."), "inf");
		if (Directory.Exists(text))
		{
			string[] files = Directory.GetFiles(text, "oem*.inf");
			Console.WriteLine($"Found {files.Length} inf files in {text}");
			for (int i = 0; i < files.Length; i++)
			{
				Console.WriteLine($"Searching {files[i]} ");
				StreamReader streamReader = null;
				try
				{
					streamReader = File.OpenText(files[i]);
					string text2 = streamReader.ReadLine();
					if (text2 != null && (text2.ToLower().Equals("; -- appliand.inf --") || text2.ToLower().Equals("; -- appliand_m.inf --")))
					{
						streamReader.Close();
						bool flag = false;
						try
						{
							Console.WriteLine($"Removing inf: {files[i]}");
							if (smethod_7())
							{
								Process process = new Process();
								process.OutputDataReceived += smethod_6;
								process.ErrorDataReceived += smethod_5;
								process.StartInfo.FileName = fileName;
								process.StartInfo.Arguments = $"-d {Path.GetFileName(files[i])}";
								process.StartInfo.CreateNoWindow = true;
								process.StartInfo.UseShellExecute = false;
								process.StartInfo.WorkingDirectory = text;
								process.StartInfo.RedirectStandardError = true;
								process.StartInfo.RedirectStandardOutput = true;
								process.Start();
								process.BeginErrorReadLine();
								process.BeginOutputReadLine();
								process.WaitForExit();
								if (process.ExitCode == 0)
								{
									Console.WriteLine($"Removed using pnputil.exe -d");
								}
								else
								{
									Process process2 = new Process();
									process2.OutputDataReceived += smethod_6;
									process2.ErrorDataReceived += smethod_5;
									process2.StartInfo.FileName = fileName;
									process2.StartInfo.Arguments = $"-f -d {Path.GetFileName(files[i])}";
									process2.StartInfo.CreateNoWindow = true;
									process2.StartInfo.UseShellExecute = false;
									process2.StartInfo.WorkingDirectory = text;
									process2.StartInfo.RedirectStandardError = true;
									process2.StartInfo.RedirectStandardOutput = true;
									process2.Start();
									process2.BeginErrorReadLine();
									process2.BeginOutputReadLine();
									process2.WaitForExit();
									if (process2.ExitCode == 0)
									{
										Console.WriteLine($"Removed using pnputil.exe -f -d");
									}
									else
									{
										flag = true;
									}
								}
							}
							else if (SetupUninstallOEMInf(Path.GetFileName(files[i]), 1u, IntPtr.Zero))
							{
								Console.WriteLine($"Removed using SetupUninstallOEMInf");
							}
							else
							{
								flag = true;
							}
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.Message, ex);
						}
						if (flag)
						{
							try
							{
								File.Delete(files[i]);
								Console.WriteLine($"Removed using Delete");
							}
							catch (Exception ex2)
							{
								Console.WriteLine(ex2.Message, ex2);
							}
							try
							{
								string text3 = Path.ChangeExtension(files[i], "PNF");
								Console.WriteLine($"Removing pnf: {text3}");
								File.Delete(text3);
							}
							catch (Exception ex3)
							{
								Console.WriteLine(ex3.Message, ex3);
							}
						}
					}
					else
					{
						streamReader.Close();
					}
				}
				catch (Exception ex4)
				{
					streamReader?.Close();
					Console.WriteLine(ex4.Message, ex4);
				}
			}
		}
		else
		{
			Console.WriteLine($"{text} doesnt exist");
		}
	}

	private static void smethod_5(object sender, DataReceivedEventArgs e)
	{
		Console.WriteLine(e.Data);
	}

	private static void smethod_6(object sender, DataReceivedEventArgs e)
	{
		Console.WriteLine(e.Data);
	}

	private static bool smethod_7()
	{
		int num = 16;
		if (IntPtr.Size == 8)
		{
			return true;
		}
		if (smethod_8("kernel32.dll", "IsWow64Process") && IsWow64Process(GetCurrentProcess(), out var bool_))
		{
			return bool_;
		}
		return false;
	}

	private static bool smethod_8(string string_3, string string_4)
	{
		IntPtr moduleHandle = GetModuleHandle(string_3);
		if (moduleHandle == IntPtr.Zero)
		{
			return false;
		}
		return GetProcAddress(moduleHandle, string_4) != IntPtr.Zero;
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr GetModuleHandle(string string_3);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPStr)] string string_3);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWow64Process(IntPtr intptr_0, out bool bool_0);

	private static void Main(string[] args)
	{
		int num = 13;
		Console.WriteLine($"driver cleanup - begin");
		foreach (string text in args)
		{
			if (text.Equals("inf"))
			{
				smethod_4();
			}
			else if (text.Equals("service"))
			{
				smethod_3("appliand");
				smethod_3("appliandMP");
			}
			else if (text.Equals("miniport"))
			{
				smethod_2();
			}
		}
		Console.WriteLine($"Driver cleanup - end");
	}
}
