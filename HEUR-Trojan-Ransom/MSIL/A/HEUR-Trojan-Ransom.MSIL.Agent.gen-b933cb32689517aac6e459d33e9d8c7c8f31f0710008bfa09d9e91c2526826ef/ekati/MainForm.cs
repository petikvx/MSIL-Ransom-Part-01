using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ekati;

public class MainForm : Form
{
	private static Logger logger = new Logger();

	private IContainer components = null;

	private Button buttonShowDesktop;

	private Button ButtonEPR;

	public MainForm()
	{
		InitializeComponent();
	}

	private void buttonShowDesktop_Click(object sender, EventArgs e)
	{
		ProcessDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
	}

	public void ProcessDirectory(string targetDirectory)
	{
		string[] directories = Directory.GetDirectories(targetDirectory);
		for (int i = 0; i < directories.Length; i++)
		{
			if (directories[i].ToLower().EndsWith("documents") || directories[i].ToLower().EndsWith("music") || directories[i].ToLower().EndsWith("pictures") || directories[i].ToLower().EndsWith("videos"))
			{
				string[] files = Directory.GetFiles(directories[i]);
				string[] array = files;
				foreach (string originalFile in array)
				{
					ProcessFile(originalFile);
				}
			}
		}
	}

	public void ProcessFile(string originalFile)
	{
		if (!originalFile.Contains(".encrypted"))
		{
			logger.AddtoLogFile("\tOriginal file: " + originalFile);
			File.Move(originalFile, originalFile + ".encrypted");
			logger.AddtoLogFile("\tRenamed file: " + Path.GetFileName(originalFile));
			return;
		}
		string text = originalFile;
		int num = text.LastIndexOf(".");
		if (num > 0)
		{
			text = text.Substring(0, num);
		}
		File.Move(originalFile, text);
		logger.AddtoLogFile("\tRenamed file: " + Path.GetFileName(originalFile));
	}

	public void ProcessRollback(string targetDirectory)
	{
		string[] files = Directory.GetFiles(targetDirectory);
		string[] array = files;
		foreach (string originalFile in array)
		{
			ProcessFileRollback(originalFile);
		}
		string[] directories = Directory.GetDirectories(targetDirectory);
		string[] array2 = directories;
		foreach (string targetDirectory2 in array2)
		{
			ProcessRollback(targetDirectory2);
		}
	}

	public void ProcessFileRollback(string originalFile)
	{
		if (originalFile.Contains(".encrypted") && !File.GetAttributes(originalFile).HasFlag(FileAttributes.Hidden))
		{
			string text = originalFile;
			int num = text.LastIndexOf(".");
			if (num > 0)
			{
				text = text.Substring(0, num);
			}
			logger.AddtoLogFile("\tOriginal file: " + originalFile);
			logger.AddtoLogFile("\tNew file: " + text);
			logger.AddtoLogFile("\tRenamed file: " + Path.GetFileName(originalFile));
			File.Move(originalFile, text);
			logger.AddtoLogFile("\tRenamed file: " + Path.GetFileName(originalFile));
		}
	}

	private void ButtonEPR_Click(object sender, EventArgs e)
	{
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
		buttonShowDesktop = new Button();
		ButtonEPR = new Button();
		((Control)this).SuspendLayout();
		((Control)buttonShowDesktop).set_Location(new Point(48, 38));
		((Control)buttonShowDesktop).set_Name("buttonShowDesktop");
		((Control)buttonShowDesktop).set_Size(new Size(150, 23));
		((Control)buttonShowDesktop).set_TabIndex(0);
		((Control)buttonShowDesktop).set_Text("Encrypt Desktop");
		((ButtonBase)buttonShowDesktop).set_UseVisualStyleBackColor(true);
		((Control)buttonShowDesktop).add_Click((EventHandler)buttonShowDesktop_Click);
		((Control)ButtonEPR).set_Location(new Point(48, 99));
		((Control)ButtonEPR).set_Name("ButtonEPR");
		((Control)ButtonEPR).set_Size(new Size(150, 23));
		((Control)ButtonEPR).set_TabIndex(1);
		((Control)ButtonEPR).set_Text("Process Other EPRs");
		((ButtonBase)ButtonEPR).set_UseVisualStyleBackColor(true);
		((Control)ButtonEPR).add_Click((EventHandler)ButtonEPR_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(505, 232));
		((Control)this).get_Controls().Add((Control)(object)ButtonEPR);
		((Control)this).get_Controls().Add((Control)(object)buttonShowDesktop);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("MainForm");
		((Control)this).set_Text("Ekati EPR Tester Main Form");
		((Control)this).ResumeLayout(false);
	}
}
