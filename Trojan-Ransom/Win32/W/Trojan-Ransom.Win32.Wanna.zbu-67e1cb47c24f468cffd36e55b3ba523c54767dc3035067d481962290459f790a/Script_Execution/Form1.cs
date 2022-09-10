using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Script_Execution;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("RichTextBox3")]
	private RichTextBox _RichTextBox3;

	[AccessedThroughProperty("TabPage5")]
	private TabPage _TabPage5;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("TabPage3")]
	private TabPage _TabPage3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("RichTextBox2")]
	private RichTextBox _RichTextBox2;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("TabPage4")]
	private TabPage _TabPage4;

	[AccessedThroughProperty("Button10")]
	private Button _Button10;

	[AccessedThroughProperty("Button9")]
	private Button _Button9;

	[AccessedThroughProperty("Button8")]
	private Button _Button8;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Button7")]
	private Button _Button7;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("Button13")]
	private Button _Button13;

	[AccessedThroughProperty("Button12")]
	private Button _Button12;

	[AccessedThroughProperty("Button11")]
	private Button _Button11;

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

	internal virtual Button Button3
	{
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button3 = value;
		}
	}

	internal virtual GroupBox GroupBox1
	{
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GroupBox1 = value;
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

	internal virtual TabControl TabControl1
	{
		get
		{
			return _TabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TabControl1 = value;
		}
	}

	internal virtual TabPage TabPage1
	{
		get
		{
			return _TabPage1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TabPage1 = value;
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

	internal virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = TextBox1_TextChanged;
			KeyEventHandler val = new KeyEventHandler(TextBox1_KeyDown);
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).remove_TextChanged(eventHandler);
				((Control)_TextBox1).remove_KeyDown(val);
			}
			_TextBox1 = value;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).add_TextChanged(eventHandler);
				((Control)_TextBox1).add_KeyDown(val);
			}
		}
	}

	internal virtual Button Button5
	{
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button5 = value;
		}
	}

	internal virtual RichTextBox RichTextBox3
	{
		get
		{
			return _RichTextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RichTextBox3 = value;
		}
	}

	internal virtual TabPage TabPage5
	{
		get
		{
			return _TabPage5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TabPage5 = value;
		}
	}

	internal virtual TabPage TabPage2
	{
		get
		{
			return _TabPage2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TabPage2 = value;
		}
	}

	internal virtual TabPage TabPage3
	{
		get
		{
			return _TabPage3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TabPage3 = value;
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
			EventHandler eventHandler = Label1_Click;
			if (_Label1 != null)
			{
				((Control)_Label1).remove_Click(eventHandler);
			}
			_Label1 = value;
			if (_Label1 != null)
			{
				((Control)_Label1).add_Click(eventHandler);
			}
		}
	}

	internal virtual GroupBox GroupBox2
	{
		get
		{
			return _GroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GroupBox2 = value;
		}
	}

	internal virtual RichTextBox RichTextBox2
	{
		get
		{
			return _RichTextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RichTextBox2 = value;
		}
	}

	internal virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button2 = value;
		}
	}

	internal virtual Button Button4
	{
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button4 = value;
		}
	}

	internal virtual TabPage TabPage4
	{
		get
		{
			return _TabPage4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TabPage4 = value;
		}
	}

	internal virtual Button Button10
	{
		get
		{
			return _Button10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button10 = value;
		}
	}

	internal virtual Button Button9
	{
		get
		{
			return _Button9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button9 = value;
		}
	}

	internal virtual Button Button8
	{
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button8 = value;
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

	internal virtual Button Button7
	{
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button7 = value;
		}
	}

	internal virtual Button Button6
	{
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button6_Click;
			if (_Button6 != null)
			{
				((Control)_Button6).remove_Click(eventHandler);
			}
			_Button6 = value;
			if (_Button6 != null)
			{
				((Control)_Button6).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button13
	{
		get
		{
			return _Button13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button13 = value;
		}
	}

	internal virtual Button Button12
	{
		get
		{
			return _Button12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button12 = value;
		}
	}

	internal virtual Button Button11
	{
		get
		{
			return _Button11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button11 = value;
		}
	}

	public Form1()
	{
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
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected O, but got Unknown
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_106b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1075: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Button1 = new Button();
		Button3 = new Button();
		GroupBox1 = new GroupBox();
		RichTextBox1 = new RichTextBox();
		TabControl1 = new TabControl();
		TabPage1 = new TabPage();
		Label2 = new Label();
		TextBox1 = new TextBox();
		Button5 = new Button();
		RichTextBox3 = new RichTextBox();
		TabPage5 = new TabPage();
		TabPage2 = new TabPage();
		TabPage3 = new TabPage();
		Label1 = new Label();
		GroupBox2 = new GroupBox();
		RichTextBox2 = new RichTextBox();
		Button2 = new Button();
		Button4 = new Button();
		TabPage4 = new TabPage();
		Button6 = new Button();
		Button7 = new Button();
		Label3 = new Label();
		TextBox2 = new TextBox();
		Button8 = new Button();
		Button9 = new Button();
		Button10 = new Button();
		Button11 = new Button();
		Button12 = new Button();
		Button13 = new Button();
		((Control)GroupBox1).SuspendLayout();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)TabPage5).SuspendLayout();
		((Control)TabPage2).SuspendLayout();
		((Control)TabPage3).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((Control)TabPage4).SuspendLayout();
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(491, 263);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(171, 37);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Execute");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button3;
		location = new Point(8, 263);
		((Control)button3).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button4 = Button3;
		size = new Size(171, 37);
		((Control)button4).set_Size(size);
		((Control)Button3).set_TabIndex(2);
		((ButtonBase)Button3).set_Text("Clear");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((Control)GroupBox1).get_Controls().Add((Control)(object)RichTextBox1);
		GroupBox groupBox = GroupBox1;
		location = new Point(8, 6);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(654, 251);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(3);
		GroupBox1.set_TabStop(false);
		((TextBoxBase)RichTextBox1).set_BorderStyle((BorderStyle)1);
		RichTextBox richTextBox = RichTextBox1;
		location = new Point(6, 17);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox1).set_Name("RichTextBox1");
		RichTextBox richTextBox2 = RichTextBox1;
		size = new Size(642, 228);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox1).set_TabIndex(0);
		RichTextBox1.set_Text("");
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage1);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage5);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage2);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage3);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage4);
		((Control)TabControl1).set_Dock((DockStyle)5);
		TabControl tabControl = TabControl1;
		location = new Point(0, 0);
		((Control)tabControl).set_Location(location);
		((Control)TabControl1).set_Name("TabControl1");
		TabControl1.set_SelectedIndex(0);
		TabControl tabControl2 = TabControl1;
		size = new Size(678, 334);
		((Control)tabControl2).set_Size(size);
		((Control)TabControl1).set_TabIndex(4);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label2);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBox1);
		((Control)TabPage1).get_Controls().Add((Control)(object)Button5);
		((Control)TabPage1).get_Controls().Add((Control)(object)RichTextBox3);
		TabPage tabPage = TabPage1;
		location = new Point(4, 22);
		tabPage.set_Location(location);
		((Control)TabPage1).set_Name("TabPage1");
		TabPage tabPage2 = TabPage1;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage2).set_Padding(padding);
		TabPage tabPage3 = TabPage1;
		size = new Size(670, 308);
		((Control)tabPage3).set_Size(size);
		TabPage1.set_TabIndex(0);
		TabPage1.set_Text("Main");
		TabPage1.set_UseVisualStyleBackColor(true);
		Label2.set_AutoSize(true);
		Label label = Label2;
		location = new Point(8, 282);
		((Control)label).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label2 = Label2;
		size = new Size(57, 13);
		((Control)label2).set_Size(size);
		((Control)Label2).set_TabIndex(3);
		Label2.set_Text("Command:");
		TextBox textBox = TextBox1;
		location = new Point(71, 279);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(512, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(2);
		Button button5 = Button5;
		location = new Point(589, 277);
		((Control)button5).set_Location(location);
		((Control)Button5).set_Name("Button5");
		Button button6 = Button5;
		size = new Size(73, 23);
		((Control)button6).set_Size(size);
		((Control)Button5).set_TabIndex(1);
		((ButtonBase)Button5).set_Text("Execute");
		((ButtonBase)Button5).set_UseVisualStyleBackColor(true);
		RichTextBox3.set_Font(new Font("Lucida Sans Unicode", 15.25f));
		RichTextBox richTextBox3 = RichTextBox3;
		location = new Point(8, 6);
		((Control)richTextBox3).set_Location(location);
		((Control)RichTextBox3).set_Name("RichTextBox3");
		((TextBoxBase)RichTextBox3).set_ReadOnly(true);
		RichTextBox richTextBox4 = RichTextBox3;
		size = new Size(654, 265);
		((Control)richTextBox4).set_Size(size);
		((Control)RichTextBox3).set_TabIndex(0);
		RichTextBox3.set_Text("Type \"cmds\" to see comands\n");
		((Control)TabPage5).get_Controls().Add((Control)(object)Button13);
		((Control)TabPage5).get_Controls().Add((Control)(object)Button12);
		((Control)TabPage5).get_Controls().Add((Control)(object)Button11);
		((Control)TabPage5).get_Controls().Add((Control)(object)Button10);
		((Control)TabPage5).get_Controls().Add((Control)(object)Button9);
		((Control)TabPage5).get_Controls().Add((Control)(object)Button8);
		((Control)TabPage5).get_Controls().Add((Control)(object)TextBox2);
		((Control)TabPage5).get_Controls().Add((Control)(object)Label3);
		TabPage tabPage4 = TabPage5;
		location = new Point(4, 22);
		tabPage4.set_Location(location);
		((Control)TabPage5).set_Name("TabPage5");
		TabPage tabPage5 = TabPage5;
		size = new Size(670, 308);
		((Control)tabPage5).set_Size(size);
		TabPage5.set_TabIndex(4);
		TabPage5.set_Text("Quick");
		TabPage5.set_UseVisualStyleBackColor(true);
		((Control)TabPage2).get_Controls().Add((Control)(object)GroupBox1);
		((Control)TabPage2).get_Controls().Add((Control)(object)Button3);
		((Control)TabPage2).get_Controls().Add((Control)(object)Button1);
		TabPage tabPage6 = TabPage2;
		location = new Point(4, 22);
		tabPage6.set_Location(location);
		((Control)TabPage2).set_Name("TabPage2");
		TabPage tabPage7 = TabPage2;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage7).set_Padding(padding);
		TabPage tabPage8 = TabPage2;
		size = new Size(670, 308);
		((Control)tabPage8).set_Size(size);
		TabPage2.set_TabIndex(1);
		TabPage2.set_Text("LUA C");
		TabPage2.set_UseVisualStyleBackColor(true);
		((Control)TabPage3).get_Controls().Add((Control)(object)Label1);
		((Control)TabPage3).get_Controls().Add((Control)(object)GroupBox2);
		((Control)TabPage3).get_Controls().Add((Control)(object)Button2);
		((Control)TabPage3).get_Controls().Add((Control)(object)Button4);
		TabPage tabPage9 = TabPage3;
		location = new Point(4, 22);
		tabPage9.set_Location(location);
		((Control)TabPage3).set_Name("TabPage3");
		TabPage tabPage10 = TabPage3;
		size = new Size(670, 308);
		((Control)tabPage10).set_Size(size);
		TabPage3.set_TabIndex(2);
		TabPage3.set_Text("LUA");
		TabPage3.set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		Label label3 = Label1;
		location = new Point(185, 264);
		((Control)label3).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label4 = Label1;
		size = new Size(109, 26);
		((Control)label4).set_Size(size);
		((Control)Label1).set_TabIndex(7);
		Label1.set_Text("Full Environment LUA\r\n-Level 6");
		((Control)GroupBox2).get_Controls().Add((Control)(object)RichTextBox2);
		GroupBox groupBox3 = GroupBox2;
		location = new Point(8, 6);
		((Control)groupBox3).set_Location(location);
		((Control)GroupBox2).set_Name("GroupBox2");
		GroupBox groupBox4 = GroupBox2;
		size = new Size(654, 251);
		((Control)groupBox4).set_Size(size);
		((Control)GroupBox2).set_TabIndex(6);
		GroupBox2.set_TabStop(false);
		((TextBoxBase)RichTextBox2).set_BorderStyle((BorderStyle)1);
		RichTextBox richTextBox5 = RichTextBox2;
		location = new Point(6, 17);
		((Control)richTextBox5).set_Location(location);
		((Control)RichTextBox2).set_Name("RichTextBox2");
		RichTextBox richTextBox6 = RichTextBox2;
		size = new Size(642, 228);
		((Control)richTextBox6).set_Size(size);
		((Control)RichTextBox2).set_TabIndex(0);
		RichTextBox2.set_Text("");
		Button button7 = Button2;
		location = new Point(8, 263);
		((Control)button7).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button8 = Button2;
		size = new Size(171, 37);
		((Control)button8).set_Size(size);
		((Control)Button2).set_TabIndex(5);
		((ButtonBase)Button2).set_Text("Clear");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		Button button9 = Button4;
		location = new Point(491, 263);
		((Control)button9).set_Location(location);
		((Control)Button4).set_Name("Button4");
		Button button10 = Button4;
		size = new Size(171, 37);
		((Control)button10).set_Size(size);
		((Control)Button4).set_TabIndex(4);
		((ButtonBase)Button4).set_Text("Execute");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((Control)TabPage4).get_Controls().Add((Control)(object)Button7);
		((Control)TabPage4).get_Controls().Add((Control)(object)Button6);
		TabPage tabPage11 = TabPage4;
		location = new Point(4, 22);
		tabPage11.set_Location(location);
		((Control)TabPage4).set_Name("TabPage4");
		TabPage tabPage12 = TabPage4;
		size = new Size(670, 308);
		((Control)tabPage12).set_Size(size);
		TabPage4.set_TabIndex(3);
		TabPage4.set_Text("Settings");
		TabPage4.set_UseVisualStyleBackColor(true);
		Button button11 = Button6;
		location = new Point(8, 13);
		((Control)button11).set_Location(location);
		((Control)Button6).set_Name("Button6");
		Button button12 = Button6;
		size = new Size(195, 23);
		((Control)button12).set_Size(size);
		((Control)Button6).set_TabIndex(0);
		((ButtonBase)Button6).set_Text("Attach to RobloxPlayerBeta.exe");
		((ButtonBase)Button6).set_UseVisualStyleBackColor(true);
		Button button13 = Button7;
		location = new Point(8, 42);
		((Control)button13).set_Location(location);
		((Control)Button7).set_Name("Button7");
		Button button14 = Button7;
		size = new Size(195, 23);
		((Control)button14).set_Size(size);
		((Control)Button7).set_TabIndex(1);
		((ButtonBase)Button7).set_Text("Exit Roblox");
		((ButtonBase)Button7).set_UseVisualStyleBackColor(true);
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(8, 16);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(39, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(0);
		Label3.set_Text("Player:");
		TextBox textBox3 = TextBox2;
		location = new Point(53, 13);
		((Control)textBox3).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox4 = TextBox2;
		size = new Size(114, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(1);
		Button button15 = Button8;
		location = new Point(11, 68);
		((Control)button15).set_Location(location);
		((Control)Button8).set_Name("Button8");
		Button button16 = Button8;
		size = new Size(75, 23);
		((Control)button16).set_Size(size);
		((Control)Button8).set_TabIndex(2);
		((ButtonBase)Button8).set_Text("Shrek");
		((ButtonBase)Button8).set_UseVisualStyleBackColor(true);
		Button button17 = Button9;
		location = new Point(92, 39);
		((Control)button17).set_Location(location);
		((Control)Button9).set_Name("Button9");
		Button button18 = Button9;
		size = new Size(75, 23);
		((Control)button18).set_Size(size);
		((Control)Button9).set_TabIndex(3);
		((ButtonBase)Button9).set_Text("Bring");
		((ButtonBase)Button9).set_UseVisualStyleBackColor(true);
		Button button19 = Button10;
		location = new Point(11, 39);
		((Control)button19).set_Location(location);
		((Control)Button10).set_Name("Button10");
		Button button20 = Button10;
		size = new Size(75, 23);
		((Control)button20).set_Size(size);
		((Control)Button10).set_TabIndex(4);
		((ButtonBase)Button10).set_Text("Kill");
		((ButtonBase)Button10).set_UseVisualStyleBackColor(true);
		Button button21 = Button11;
		location = new Point(11, 97);
		((Control)button21).set_Location(location);
		((Control)Button11).set_Name("Button11");
		Button button22 = Button11;
		size = new Size(75, 23);
		((Control)button22).set_Size(size);
		((Control)Button11).set_TabIndex(5);
		((ButtonBase)Button11).set_Text("Freeze");
		((ButtonBase)Button11).set_UseVisualStyleBackColor(true);
		Button button23 = Button12;
		location = new Point(92, 68);
		((Control)button23).set_Location(location);
		((Control)Button12).set_Name("Button12");
		Button button24 = Button12;
		size = new Size(75, 23);
		((Control)button24).set_Size(size);
		((Control)Button12).set_TabIndex(6);
		((ButtonBase)Button12).set_Text("Noob");
		((ButtonBase)Button12).set_UseVisualStyleBackColor(true);
		Button button25 = Button13;
		location = new Point(92, 97);
		((Control)button25).set_Location(location);
		((Control)Button13).set_Name("Button13");
		Button button26 = Button13;
		size = new Size(75, 23);
		((Control)button26).set_Size(size);
		((Control)Button13).set_TabIndex(7);
		((ButtonBase)Button13).set_Text("Unfreeze");
		((ButtonBase)Button13).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(678, 334);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TabControl1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Flame v3 | Roblox | Beta Release");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage1).PerformLayout();
		((Control)TabPage5).ResumeLayout(false);
		((Control)TabPage5).PerformLayout();
		((Control)TabPage2).ResumeLayout(false);
		((Control)TabPage3).ResumeLayout(false);
		((Control)TabPage3).PerformLayout();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)TabPage4).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			if (Operators.CompareString(TextBox1.get_Text(), "cmds", false) == 0)
			{
				((TextBoxBase)RichTextBox3).AppendText("kill [p] - instant kill player\r\n");
				((TextBoxBase)RichTextBox3).AppendText("freeze [p] - freeze player & they cannot move\r\n");
				((TextBoxBase)RichTextBox3).AppendText("unfreeze [p] - make player can move again\r\n");
				((TextBoxBase)RichTextBox3).AppendText("flame [p] - Flame particles\r\n");
				((TextBoxBase)RichTextBox3).AppendText("rain [p] - Rain particles\r\n");
				((TextBoxBase)RichTextBox3).AppendText("spd [p] [val] - walkspeed player\r\n");
				((TextBoxBase)RichTextBox3).AppendText("devexplorer - bring explorer v3 gui\r\n");
				((TextBoxBase)RichTextBox3).AppendText("music [id] - play music ids\r\n");
				((TextBoxBase)RichTextBox3).AppendText("stopmusic - stop current music playing\r\n");
				((TextBoxBase)RichTextBox3).AppendText("goto [p] - teleport to player locations\r\n");
				((TextBoxBase)RichTextBox3).AppendText("tp [p] to [p] - teleport player to another player or me\r\n");
				((TextBoxBase)RichTextBox3).AppendText("more commands coming soon.!\r\n");
			}
			TextBox1.set_Text("");
		}
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void Label1_Click(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"Loadstring supported", (MsgBoxStyle)64, (object)"Flame V3");
	}

	private void Button6_Click(object sender, EventArgs e)
	{
	}
}
