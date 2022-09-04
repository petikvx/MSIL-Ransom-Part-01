using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Encoder;

public class Form1 : Form
{
	private BackgroundWorker IndexWorker = new BackgroundWorker();

	private BackgroundWorker EncrypterWorker = new BackgroundWorker();

	private string password = "";

	public string Path = "";

	public static List<Direct> Paths;

	private int pin = 0;

	private int pi = 0;

	private IContainer components = null;

	private TextBox textBox1;

	private TextBox textBox2;

	private Label label1;

	private Label label2;

	private Button button5;

	private Button button6;

	private Button button7;

	[DllImport("User32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

	[DllImport("User32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

	public Form1()
	{
		Paths = new List<Direct>();
		InitializeComponent();
		IndexWorker.ProgressChanged += IndexProgressChanged;
		IndexWorker.DoWork += GetDirectories;
		IndexWorker.RunWorkerCompleted += IndexCompleted;
		EncrypterWorker.WorkerReportsProgress = true;
		EncrypterWorker.ProgressChanged += EncryptionProgressChanged;
		EncrypterWorker.DoWork += EncryptFiles;
		if (!RegisterHotKey(((Control)this).get_Handle(), 0, 5u, 118u))
		{
		}
	}

	private void EncryptionProgressChanged(object sender, ProgressChangedEventArgs e)
	{
		if (e.ProgressPercentage == 1)
		{
			int num = (int)e.UserState;
			((Control)label1).set_Text(num.ToString());
		}
		else
		{
			((Control)label2).set_Text("Complete");
		}
	}

	private void EncryptFiles(object sender, DoWorkEventArgs e)
	{
		int num = 0;
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		foreach (Direct path in Paths)
		{
			foreach (string file in path.Files)
			{
				try
				{
					EncDec.Encrypt(path.FullPath + "/" + file, path.FullPath + "/" + file + ".ENC", password);
					File.Delete(path.FullPath + "/" + file);
					num++;
					backgroundWorker.ReportProgress(1, num);
				}
				catch (Exception)
				{
				}
			}
		}
		backgroundWorker.ReportProgress(2, num);
	}

	private void IndexProgressChanged(object sender, ProgressChangedEventArgs e)
	{
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 786)
		{
			if (((Control)this).get_Visible())
			{
				((Control)this).set_Visible(false);
			}
			else
			{
				((Control)this).set_Visible(true);
			}
		}
		((Form)this).WndProc(ref m);
	}

	public void EncryptFile(string path)
	{
		try
		{
			EncDec.Encrypt(path, path + ".ENC", ((Control)textBox1).get_Text());
		}
		catch (Exception)
		{
		}
	}

	public void GetDirectories(string path)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		Direct item = default(Direct);
		item.LocalPath = directoryInfo.FullName.Remove(0, Path.Length);
		item.FullPath = directoryInfo.FullName;
		try
		{
			FileInfo[] files = directoryInfo.GetFiles();
			item.Files = new List<string>();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				if (fileInfo.Name.Substring(fileInfo.Name.Length - 3, 3) != "ENC")
				{
					item.Files.Add(fileInfo.Name);
				}
			}
			Paths.Add(item);
		}
		catch (Exception)
		{
		}
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		foreach (DirectoryInfo directoryInfo2 in directories)
		{
			if (directoryInfo2.Attributes.ToString().Contains("Directory"))
			{
				try
				{
					GetDirectories(directoryInfo2.FullName);
				}
				catch (Exception)
				{
				}
			}
		}
	}

	private void button5_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		FolderBrowserDialog val = new FolderBrowserDialog();
		DialogResult val2 = ((CommonDialog)val).ShowDialog();
		if ((int)val2 == 1)
		{
			string text = (Path = val.get_SelectedPath());
			IndexWorker.RunWorkerAsync();
			((Control)label2).set_Text("Indexing...");
		}
	}

	private void IndexCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		int num = pin;
		for (int i = 0; i < Paths.Count - num; i++)
		{
			Direct direct = Paths[i + num];
			foreach (string file in direct.Files)
			{
				pi++;
				((TextBoxBase)textBox2).AppendText(direct.FullPath + "\\" + file + "\r\n");
			}
			pin++;
		}
		((Control)label2).set_Text(pi.ToString());
	}

	private void GetDirectories(object sender, DoWorkEventArgs e)
	{
		GetDirectories(Path);
	}

	private void button6_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		FileDialog val = (FileDialog)new OpenFileDialog();
		DialogResult val2 = ((CommonDialog)val).ShowDialog();
		if ((int)val2 == 1)
		{
			string[] fileNames = val.get_FileNames();
			string[] array = fileNames;
			foreach (string text in array)
			{
				Direct item = default(Direct);
				FileInfo fileInfo = new FileInfo(text);
				item.FullPath = fileInfo.DirectoryName;
				item.Files = new List<string>();
				item.Files.Add(fileInfo.Name);
				Paths.Add(item);
				((TextBoxBase)textBox2).AppendText(text + "\r\n");
			}
		}
	}

	private void button7_Click(object sender, EventArgs e)
	{
		password = ((Control)textBox1).get_Text();
		pin = 0;
		pi = 0;
		EncrypterWorker.RunWorkerAsync();
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		label1 = new Label();
		label2 = new Label();
		button5 = new Button();
		button6 = new Button();
		button7 = new Button();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_Location(new Point(199, 272));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(206, 20));
		((Control)textBox1).set_TabIndex(1);
		((Control)textBox2).set_Location(new Point(12, 12));
		((TextBoxBase)textBox2).set_Multiline(true);
		((Control)textBox2).set_Name("textBox2");
		((TextBoxBase)textBox2).set_ReadOnly(true);
		textBox2.set_ScrollBars((ScrollBars)2);
		((Control)textBox2).set_Size(new Size(399, 191));
		((Control)textBox2).set_TabIndex(3);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(13, 210));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(13, 13));
		((Control)label1).set_TabIndex(6);
		((Control)label1).set_Text("0");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(13, 223));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(13, 13));
		((Control)label2).set_TabIndex(7);
		((Control)label2).set_Text("0");
		((Control)button5).set_Location(new Point(16, 240));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(176, 23));
		((Control)button5).set_TabIndex(8);
		((Control)button5).set_Text("Проиндексировать папку");
		((ButtonBase)button5).set_UseVisualStyleBackColor(true);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((Control)button6).set_Location(new Point(199, 240));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(206, 23));
		((Control)button6).set_TabIndex(9);
		((Control)button6).set_Text("Добавить файл");
		((ButtonBase)button6).set_UseVisualStyleBackColor(true);
		((Control)button6).add_Click((EventHandler)button6_Click);
		((Control)button7).set_Location(new Point(16, 270));
		((Control)button7).set_Name("button7");
		((Control)button7).set_Size(new Size(176, 23));
		((Control)button7).set_TabIndex(10);
		((Control)button7).set_Text("Зишифровать файлы");
		((ButtonBase)button7).set_UseVisualStyleBackColor(true);
		((Control)button7).add_Click((EventHandler)button7_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(417, 305));
		((Control)this).get_Controls().Add((Control)(object)button7);
		((Control)this).get_Controls().Add((Control)(object)button6);
		((Control)this).get_Controls().Add((Control)(object)button5);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Шифратор");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
