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

namespace ns2;

[DesignerGenerated]
internal class Foll : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("CheckedListBox1")]
	private CheckedListBox _CheckedListBox1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("RadioButton2")]
	private RadioButton _RadioButton2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	public static Assembly assembly_0 = Assembly.Load(Class7.x);

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

	public Foll()
	{
		((Form)this).add_Load((EventHandler)Foll_Load);
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
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Foll));
		Button1 = new Button();
		CheckedListBox1 = new CheckedListBox();
		ProgressBar1 = new ProgressBar();
		PictureBox1 = new PictureBox();
		PictureBox2 = new PictureBox();
		RadioButton1 = new RadioButton();
		RadioButton2 = new RadioButton();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		LinkLabel1 = new LinkLabel();
		Label4 = new Label();
		Button2 = new Button();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(11, 36);
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
		location = new Point(-35, 97);
		((Control)checkedListBox).set_Location(location);
		((Control)CheckedListBox1).set_Name("CheckedListBox1");
		CheckedListBox checkedListBox2 = CheckedListBox1;
		size = new Size(120, 94);
		((Control)checkedListBox2).set_Size(size);
		((Control)CheckedListBox1).set_TabIndex(1);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(186, 188);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(100, 23);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(2);
		PictureBox pictureBox = PictureBox1;
		location = new Point(206, 91);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(100, 50);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(3);
		PictureBox1.set_TabStop(false);
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(110, 45);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox2).set_Name("PictureBox2");
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(100, 50);
		((Control)pictureBox4).set_Size(size);
		PictureBox2.set_TabIndex(4);
		PictureBox2.set_TabStop(false);
		((ButtonBase)RadioButton1).set_AutoSize(true);
		RadioButton radioButton = RadioButton1;
		location = new Point(253, 38);
		((Control)radioButton).set_Location(location);
		((Control)RadioButton1).set_Name("RadioButton1");
		RadioButton radioButton2 = RadioButton1;
		size = new Size(90, 17);
		((Control)radioButton2).set_Size(size);
		((Control)RadioButton1).set_TabIndex(5);
		RadioButton1.set_TabStop(true);
		((ButtonBase)RadioButton1).set_Text("RadioButton1");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton2).set_AutoSize(true);
		RadioButton radioButton3 = RadioButton2;
		location = new Point(258, 74);
		((Control)radioButton3).set_Location(location);
		((Control)RadioButton2).set_Name("RadioButton2");
		RadioButton radioButton4 = RadioButton2;
		size = new Size(90, 17);
		((Control)radioButton4).set_Size(size);
		((Control)RadioButton2).set_TabIndex(6);
		RadioButton2.set_TabStop(true);
		((ButtonBase)RadioButton2).set_Text("RadioButton2");
		((ButtonBase)RadioButton2).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(84, 1);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(7);
		Label1.set_Text("Label1");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(186, 27);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(39, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(8);
		Label2.set_Text("Label2");
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(98, 157);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(39, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(9);
		Label3.set_Text("Label3");
		((Label)LinkLabel1).set_AutoSize(true);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(330, 19);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(59, 13);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(10);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("LinkLabel1");
		Label4.set_AutoSize(true);
		Label label7 = Label4;
		location = new Point(328, 160);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(39, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(11);
		Label4.set_Text("Label4");
		Button button3 = Button2;
		location = new Point(155, 12);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(75, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(12);
		((ButtonBase)Button2).set_Text("Button2");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(116, 0);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)RadioButton2);
		((Control)this).get_Controls().Add((Control)(object)RadioButton1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox2);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)CheckedListBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Foll");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowInTaskbar(false);
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Foll_Load(object sender, EventArgs e)
	{
		x.X();
	}
}
