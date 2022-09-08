using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace builder;

[DesignerGenerated]
public class Form3 : Form
{
	private static List<WeakReference> list_0;

	private IContainer icontainer_0;

	[AccessedThroughProperty("BlackShadesNetForm1")]
	private BlackShadesNetForm _BlackShadesNetForm1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	private int int_0;

	internal virtual BlackShadesNetForm BlackShadesNetForm1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BlackShadesNetForm1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BlackShadesNetForm1_Click;
			if (_BlackShadesNetForm1 != null)
			{
				((Control)_BlackShadesNetForm1).remove_Click(eventHandler);
			}
			_BlackShadesNetForm1 = value;
			if (_BlackShadesNetForm1 != null)
			{
				((Control)_BlackShadesNetForm1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual RichTextBox RichTextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RichTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RichTextBox1_TextChanged;
			if (_RichTextBox1 != null)
			{
				((Control)_RichTextBox1).remove_TextChanged(eventHandler);
			}
			_RichTextBox1 = value;
			if (_RichTextBox1 != null)
			{
				((Control)_RichTextBox1).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox1 = value;
		}
	}

	internal virtual PictureBox PictureBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox2 = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = method_5;
			EventHandler eventHandler2 = method_3;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_MouseHover(eventHandler);
				((Control)_Button1).remove_Click(eventHandler2);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_MouseHover(eventHandler);
				((Control)_Button1).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = method_6;
			EventHandler eventHandler2 = method_4;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_MouseHover(eventHandler);
				((Control)_Button2).remove_Click(eventHandler2);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_MouseHover(eventHandler);
				((Control)_Button2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label3_Click;
			if (_Label3 != null)
			{
				((Control)_Label3).remove_Click(eventHandler);
			}
			_Label3 = value;
			if (_Label3 != null)
			{
				((Control)_Label3).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	[DebuggerNonUserCode]
	static Form3()
	{
		Class14.hYiyYvszsKHjE();
		list_0 = new List<WeakReference>();
	}

	public Form3()
	{
		Class14.hYiyYvszsKHjE();
		((Form)this)._002Ector();
		((Form)this).add_Load((EventHandler)Form3_Load);
		smethod_0(this);
		int_0 = 20;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		checked
		{
			lock (list_0)
			{
				if (list_0.Count == list_0.Capacity)
				{
					int num = 0;
					int num2 = list_0.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = list_0[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								list_0[num] = list_0[num3];
							}
							num++;
						}
						num3++;
					}
					list_0.RemoveRange(num, list_0.Count - num);
					list_0.Capacity = list_0.Count;
				}
				list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && icontainer_0 != null) ? true : false)
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
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected O, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected O, but got Unknown
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected O, but got Unknown
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_0821: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form3));
		vmethod_1(new Timer(icontainer_0));
		BlackShadesNetForm1 = new BlackShadesNetForm();
		Panel1 = new Panel();
		Label3 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		Button2 = new Button();
		Button1 = new Button();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		RichTextBox1 = new RichTextBox();
		((Control)BlackShadesNetForm1).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		vmethod_0().set_Interval(1000);
		((Control)BlackShadesNetForm1).set_BackColor(Color.Lime);
		BlackShadesNetForm1.CloseButtonExitsApp = false;
		((Control)BlackShadesNetForm1).get_Controls().Add((Control)(object)Panel1);
		((Control)BlackShadesNetForm1).set_Dock((DockStyle)5);
		((Control)BlackShadesNetForm1).set_Font(new Font("Trebuchet MS", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)BlackShadesNetForm1).set_ForeColor(Color.FromArgb(142, 152, 156));
		BlackShadesNetForm blackShadesNetForm = BlackShadesNetForm1;
		Point location = new Point(0, 0);
		((Control)blackShadesNetForm).set_Location(location);
		BlackShadesNetForm1.MinimizeButton = true;
		((Control)BlackShadesNetForm1).set_Name("BlackShadesNetForm1");
		BlackShadesNetForm blackShadesNetForm2 = BlackShadesNetForm1;
		Size size = new Size(837, 496);
		((Control)blackShadesNetForm2).set_Size(size);
		((Control)BlackShadesNetForm1).set_TabIndex(0);
		((Control)BlackShadesNetForm1).set_Text("Terms And Conditions ");
		((Control)Panel1).set_BackColor(Color.Black);
		((Control)Panel1).get_Controls().Add((Control)(object)Label3);
		((Control)Panel1).get_Controls().Add((Control)(object)Label2);
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).get_Controls().Add((Control)(object)Button2);
		((Control)Panel1).get_Controls().Add((Control)(object)Button1);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox2);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)RichTextBox1);
		Panel panel = Panel1;
		location = new Point(3, 27);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		size = new Size(841, 469);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(2);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Trebuchet MS", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.DodgerBlue);
		Label label = Label3;
		location = new Point(633, 20);
		((Control)label).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label2 = Label3;
		size = new Size(26, 27);
		((Control)label2).set_Size(size);
		((Control)Label3).set_TabIndex(43);
		Label3.set_Text(" )");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Trebuchet MS", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.DodgerBlue);
		Label label3 = Label2;
		location = new Point(540, 20);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(26, 27);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(42);
		Label2.set_Text(" (");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Trebuchet MS", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.Red);
		Label label5 = Label1;
		location = new Point(585, 20);
		((Control)label5).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label6 = Label1;
		size = new Size(24, 27);
		((Control)label6).set_Size(size);
		((Control)Label1).set_TabIndex(41);
		Label1.set_Text("0");
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)1);
		((Control)Button2).set_Font(new Font("Trebuchet MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button2).set_ForeColor(Color.DodgerBlue);
		Button button = Button2;
		location = new Point(214, 414);
		((Control)button).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button2 = Button2;
		size = new Size(99, 43);
		((Control)button2).set_Size(size);
		((Control)Button2).set_TabIndex(38);
		((ButtonBase)Button2).set_Text("I Decline");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)1);
		((Control)Button1).set_Font(new Font("Trebuchet MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_ForeColor(Color.DodgerBlue);
		((ButtonBase)Button1).set_ImageKey("(aucun)");
		Button button3 = Button1;
		location = new Point(9, 414);
		((Control)button3).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button4 = Button1;
		size = new Size(99, 43);
		((Control)button4).set_Size(size);
		((Control)Button1).set_TabIndex(37);
		((ButtonBase)Button1).set_Text(" I Agree");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)PictureBox2).set_Anchor((AnchorStyles)9);
		PictureBox2.set_Image((Image)componentResourceManager.GetObject("PictureBox2.Image"));
		PictureBox2.set_ImeMode((ImeMode)0);
		PictureBox pictureBox = PictureBox2;
		location = new Point(230, 3);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox2).set_Name("PictureBox2");
		PictureBox pictureBox2 = PictureBox2;
		size = new Size(302, 44);
		((Control)pictureBox2).set_Size(size);
		PictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox2.set_TabIndex(36);
		PictureBox2.set_TabStop(false);
		((Control)PictureBox1).set_Anchor((AnchorStyles)9);
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		PictureBox1.set_ImeMode((ImeMode)0);
		PictureBox pictureBox3 = PictureBox1;
		location = new Point(3, 3);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox4 = PictureBox1;
		size = new Size(60, 44);
		((Control)pictureBox4).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(35);
		PictureBox1.set_TabStop(false);
		((TextBoxBase)RichTextBox1).set_BackColor(Color.Black);
		((TextBoxBase)RichTextBox1).set_BorderStyle((BorderStyle)0);
		RichTextBox1.set_ForeColor(Color.DodgerBlue);
		RichTextBox richTextBox = RichTextBox1;
		location = new Point(3, 53);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox1).set_Name("RichTextBox1");
		((TextBoxBase)RichTextBox1).set_ReadOnly(true);
		RichTextBox richTextBox2 = RichTextBox1;
		size = new Size(828, 348);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox1).set_TabIndex(2);
		RichTextBox1.set_Text(componentResourceManager.GetString("RichTextBox1.Text"));
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(837, 496);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)BlackShadesNetForm1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form3");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Terms And Conditions ");
		((Form)this).set_TransparencyKey(Color.Fuchsia);
		((Control)BlackShadesNetForm1).ResumeLayout(false);
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Timer vmethod_0()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_1(Timer WithEventsValue)
	{
		EventHandler eventHandler = method_2;
		if (timer_0 != null)
		{
			timer_0.remove_Tick(eventHandler);
		}
		timer_0 = WithEventsValue;
		if (timer_0 != null)
		{
			timer_0.add_Tick(eventHandler);
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play((Stream)Class12.smethod_19(), (AudioPlayMode)1);
		((Control)Class2.Class3_0.Form1).Show();
		((Control)this).Hide();
	}

	private void BlackShadesNetForm1_Click(object sender, EventArgs e)
	{
	}

	private void Form3_Load(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play((Stream)Class12.smethod_3(), (AudioPlayMode)1);
		vmethod_0().set_Enabled(true);
		((Control)Button1).set_Enabled(false);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void method_1(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}

	private void RichTextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void method_2(object sender, EventArgs e)
	{
		int num = Conversions.ToInteger(Label1.get_Text());
		Label1.set_Text(Conversions.ToString(checked(num + 1)));
		if (Operators.CompareString(Label1.get_Text(), "20", false) == 0)
		{
			((Control)Button1).set_Enabled(true);
			((Control)Label1).set_Enabled(false);
			((Control)Label2).set_Enabled(false);
			((Control)Label3).set_Enabled(false);
		}
		if (((Control)Label1).get_ForeColor() == Color.Blue)
		{
			((Control)Label1).set_ForeColor(Color.Yellow);
		}
		else
		{
			((Control)Label1).set_ForeColor(Color.Blue);
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play((Stream)Class12.smethod_19(), (AudioPlayMode)1);
		((Control)Class2.Class3_0.Form1).Show();
		((Control)this).Hide();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void method_4(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}

	private void method_5(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play((Stream)Class12.smethod_6(), (AudioPlayMode)1);
	}

	private void method_6(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play((Stream)Class12.smethod_10(), (AudioPlayMode)1);
	}

	private void Label3_Click(object sender, EventArgs e)
	{
	}
}
