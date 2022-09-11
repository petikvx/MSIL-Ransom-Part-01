using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Ransome;

public class Ware : Form
{
	private string[] allFiles = new string[1];

	private int curFile = 0;

	private int delFile = 0;

	private string userPath = "C:\\Users\\" + Environment.UserName + "\\";

	private IContainer components = null;

	private ListBox listBox1;

	private Label label1;

	private Button button1;

	public Ware()
	{
		InitializeComponent();
	}

	private void getAllFiles(string path)
	{
		try
		{
			string[] files = Directory.GetFiles(path);
			string[] directories = Directory.GetDirectories(path);
			string[] array = files;
			foreach (string text in array)
			{
				allFiles[curFile] = text;
				curFile++;
				Array.Resize(ref allFiles, allFiles.Length + 1);
			}
			string[] array2 = directories;
			foreach (string path2 in array2)
			{
				getAllFiles(path2);
			}
		}
		catch (Exception)
		{
		}
	}

	private void Deleter()
	{
		Random random = new Random();
		for (int i = 0; i < 10; i++)
		{
			delFile = random.Next(0, allFiles.Length - 2);
			listBox1.get_Items().Add((object)Path.GetFileName(allFiles[delFile]));
		}
	}

	private void Ware_Load(object sender, EventArgs e)
	{
		getAllFiles(userPath + "Documents");
		getAllFiles(userPath + "Downloads");
		getAllFiles(userPath + "Pictures");
		getAllFiles(userPath + "Videos");
		getAllFiles(userPath + "Desktop");
		getAllFiles(userPath + "Music");
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (!driveInfo.Name.Contains("C"))
			{
				getAllFiles(driveInfo.Name);
			}
		}
		Deleter();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Form1 form = new Form1();
		((Control)form).Show();
		((Control)this).Hide();
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		listBox1 = new ListBox();
		label1 = new Label();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((ListControl)listBox1).set_FormattingEnabled(true);
		((Control)listBox1).set_Location(new Point(12, 29));
		((Control)listBox1).set_Name("listBox1");
		((Control)listBox1).set_Size(new Size(310, 225));
		((Control)listBox1).set_TabIndex(0);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(106, 13));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(65, 13));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Deleted files");
		((Control)button1).set_Location(new Point(85, 262));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(150, 23));
		((Control)button1).set_TabIndex(2);
		((Control)button1).set_Text("Bruh");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(334, 297));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)listBox1);
		((Control)this).set_Name("Ware");
		((Control)this).set_Text("Ware");
		((Form)this).add_Load((EventHandler)Ware_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
