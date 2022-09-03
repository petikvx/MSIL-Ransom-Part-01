using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns3;
using x;

namespace ns4;

[DesignerGenerated]
internal class pass : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("ComboBox2")]
	private ComboBox _ComboBox2;

	public static Assembly assembly_0 = Assembly.Load(Class5.x);

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

	internal virtual CheckBox CheckBox1
	{
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox1 = value;
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

	internal virtual LinkLabel LinkLabel1
	{
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_LinkLabel1 = value;
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

	internal virtual ComboBox ComboBox1
	{
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ComboBox1 = value;
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

	internal virtual ComboBox ComboBox2
	{
		get
		{
			return _ComboBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ComboBox2 = value;
		}
	}

	public pass()
	{
		((Form)this).add_Load((EventHandler)pass_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
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
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(pass));
		Button1 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		CheckBox1 = new CheckBox();
		Label1 = new Label();
		Label2 = new Label();
		LinkLabel1 = new LinkLabel();
		PictureBox2 = new PictureBox();
		RadioButton1 = new RadioButton();
		ComboBox1 = new ComboBox();
		Button4 = new Button();
		ComboBox2 = new ComboBox();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(73, 34);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(100, 132);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(75, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(1);
		((ButtonBase)Button2).set_Text("Button2");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		Button button5 = Button3;
		location = new Point(241, 33);
		((Control)button5).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button6 = Button3;
		size = new Size(75, 23);
		((Control)button6).set_Size(size);
		((Control)Button3).set_TabIndex(2);
		((ButtonBase)Button3).set_Text("Button3");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		location = new Point(90, 105);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(81, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(3);
		((ButtonBase)CheckBox1).set_Text("CheckBox1");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(25, 95);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("Label1");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(114, 73);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(39, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(5);
		Label2.set_Text("Label2");
		((Label)LinkLabel1).set_AutoSize(true);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(88, 162);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(59, 13);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(6);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("LinkLabel1");
		PictureBox pictureBox = PictureBox2;
		location = new Point(214, 57);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox2).set_Name("PictureBox2");
		PictureBox pictureBox2 = PictureBox2;
		size = new Size(100, 50);
		((Control)pictureBox2).set_Size(size);
		PictureBox2.set_TabIndex(8);
		PictureBox2.set_TabStop(false);
		((ButtonBase)RadioButton1).set_AutoSize(true);
		RadioButton radioButton = RadioButton1;
		location = new Point(-27, 196);
		((Control)radioButton).set_Location(location);
		((Control)RadioButton1).set_Name("RadioButton1");
		RadioButton radioButton2 = RadioButton1;
		size = new Size(90, 17);
		((Control)radioButton2).set_Size(size);
		((Control)RadioButton1).set_TabIndex(9);
		RadioButton1.set_TabStop(true);
		((ButtonBase)RadioButton1).set_Text("RadioButton1");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox comboBox = ComboBox1;
		location = new Point(113, 2);
		((Control)comboBox).set_Location(location);
		((Control)ComboBox1).set_Name("ComboBox1");
		ComboBox comboBox2 = ComboBox1;
		size = new Size(121, 21);
		((Control)comboBox2).set_Size(size);
		((Control)ComboBox1).set_TabIndex(10);
		Button button7 = Button4;
		location = new Point(13, 13);
		((Control)button7).set_Location(location);
		((Control)Button4).set_Name("Button4");
		Button button8 = Button4;
		size = new Size(75, 23);
		((Control)button8).set_Size(size);
		((Control)Button4).set_TabIndex(11);
		((ButtonBase)Button4).set_Text("Button4");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((ListControl)ComboBox2).set_FormattingEnabled(true);
		ComboBox comboBox3 = ComboBox2;
		location = new Point(37, 57);
		((Control)comboBox3).set_Location(location);
		((Control)ComboBox2).set_Name("ComboBox2");
		ComboBox comboBox4 = ComboBox2;
		size = new Size(121, 21);
		((Control)comboBox4).set_Size(size);
		((Control)ComboBox2).set_TabIndex(12);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(116, 10);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ComboBox2);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)RadioButton1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox2);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("pass");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void pass_Load(object sender, EventArgs e)
	{
		x.X();
	}
}
