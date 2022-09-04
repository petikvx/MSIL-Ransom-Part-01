using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace jusched;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("CheckedListBox1")]
	private CheckedListBox _CheckedListBox1;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button1 = value;
		}
	}

	internal virtual CheckedListBox CheckedListBox1
	{
		get
		{
			return _CheckedListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckedListBox1 = value;
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

	internal virtual PictureBox PictureBox2
	{
		get
		{
			return _PictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PictureBox2 = value;
		}
	}

	internal virtual PictureBox PictureBox3
	{
		get
		{
			return _PictureBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = PictureBox3_Click;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).remove_Click(eventHandler);
			}
			_PictureBox3 = value;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).add_Click(eventHandler);
			}
		}
	}

	internal virtual RichTextBox RichTextBox1
	{
		get
		{
			return _RichTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RichTextBox1 = value;
		}
	}

	public Form1()
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		Button1 = new Button();
		CheckedListBox1 = new CheckedListBox();
		ListBox1 = new ListBox();
		PictureBox1 = new PictureBox();
		PictureBox2 = new PictureBox();
		PictureBox3 = new PictureBox();
		RichTextBox1 = new RichTextBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(182, 75);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ListControl)CheckedListBox1).set_FormattingEnabled(true);
		CheckedListBox checkedListBox = CheckedListBox1;
		location = new Point(43, 34);
		((Control)checkedListBox).set_Location(location);
		((Control)CheckedListBox1).set_Name("CheckedListBox1");
		CheckedListBox checkedListBox2 = CheckedListBox1;
		size = new Size(120, 94);
		((Control)checkedListBox2).set_Size(size);
		((Control)CheckedListBox1).set_TabIndex(1);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		location = new Point(43, 150);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		size = new Size(120, 95);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(2);
		PictureBox pictureBox = PictureBox1;
		location = new Point(169, 150);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(100, 50);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(3);
		PictureBox1.set_TabStop(false);
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(169, 12);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox2).set_Name("PictureBox2");
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(100, 50);
		((Control)pictureBox4).set_Size(size);
		PictureBox2.set_TabIndex(4);
		PictureBox2.set_TabStop(false);
		PictureBox pictureBox5 = PictureBox3;
		location = new Point(169, 206);
		((Control)pictureBox5).set_Location(location);
		((Control)PictureBox3).set_Name("PictureBox3");
		PictureBox pictureBox6 = PictureBox3;
		size = new Size(100, 50);
		((Control)pictureBox6).set_Size(size);
		PictureBox3.set_TabIndex(5);
		PictureBox3.set_TabStop(false);
		RichTextBox richTextBox = RichTextBox1;
		location = new Point(3, 93);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox1).set_Name("RichTextBox1");
		RichTextBox richTextBox2 = RichTextBox1;
		size = new Size(100, 96);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox1).set_TabIndex(6);
		RichTextBox1.set_Text("");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		size = new Size(340, 286);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox3);
		((Control)this).get_Controls().Add((Control)(object)PictureBox2);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).get_Controls().Add((Control)(object)CheckedListBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).set_Enabled(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
	}
}
