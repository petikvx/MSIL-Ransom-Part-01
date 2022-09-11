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
using Microsoft.VisualBasic.FileIO;
using ns0;

namespace ns1;

[DesignerGenerated]
public class Form2 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label63")]
	private Label _Label63;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("cp")]
	private RichTextBox _cp;

	[AccessedThroughProperty("dc")]
	private Label _dc;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("ProgressBar4")]
	private ProgressBar _ProgressBar4;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("NotPause")]
	private Timer _NotPause;

	private DateTime dtInicial;

	private TimeSpan calcu;

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual Label Label63
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label63;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label63 = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
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

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
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

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual RichTextBox cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cp = value;
		}
	}

	internal virtual Label dc
	{
		[DebuggerNonUserCode]
		get
		{
			return _dc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dc = value;
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual ProgressBar ProgressBar4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBar4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBar4 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
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
			_Label3 = value;
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
			EventHandler eventHandler = Label2_Click;
			if (_Label2 != null)
			{
				((Control)_Label2).remove_Click(eventHandler);
			}
			_Label2 = value;
			if (_Label2 != null)
			{
				((Control)_Label2).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
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
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
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
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
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

	internal virtual Timer NotPause
	{
		[DebuggerNonUserCode]
		get
		{
			return _NotPause;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = NotPause_Tick;
			if (_NotPause != null)
			{
				_NotPause.remove_Tick(eventHandler);
			}
			_NotPause = value;
			if (_NotPause != null)
			{
				_NotPause.add_Tick(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public Form2()
	{
		((Form)this).add_Load((EventHandler)Form2_Load);
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected O, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected O, but got Unknown
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Expected O, but got Unknown
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Expected O, but got Unknown
		//IL_0920: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Expected O, but got Unknown
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ae: Expected O, but got Unknown
		//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected O, but got Unknown
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Expected O, but got Unknown
		//IL_0bcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd6: Expected O, but got Unknown
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1d: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		Label8 = new Label();
		Label63 = new Label();
		Label6 = new Label();
		Panel1 = new Panel();
		Label5 = new Label();
		Label1 = new Label();
		PictureBox1 = new PictureBox();
		GroupBox1 = new GroupBox();
		cp = new RichTextBox();
		dc = new Label();
		Label7 = new Label();
		ProgressBar4 = new ProgressBar();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		TextBox1 = new TextBox();
		Button2 = new Button();
		Button1 = new Button();
		Timer1 = new Timer(components);
		NotPause = new Timer(components);
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		Label8.set_AutoSize(true);
		((Control)Label8).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label8;
		Point location = new Point(260, 343);
		((Control)label).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label2 = Label8;
		Size size = new Size(87, 18);
		((Control)label2).set_Size(size);
		((Control)Label8).set_TabIndex(29);
		Label8.set_Text("segundo(s).");
		((Control)Label8).set_Visible(false);
		Label63.set_AutoSize(true);
		((Control)Label63).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label63).set_ForeColor(Color.Red);
		Label label3 = Label63;
		location = new Point(239, 343);
		((Control)label3).set_Location(location);
		((Control)Label63).set_Name("Label63");
		Label label4 = Label63;
		size = new Size(24, 18);
		((Control)label4).set_Size(size);
		((Control)Label63).set_TabIndex(28);
		Label63.set_Text("30");
		((Control)Label63).set_Visible(false);
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label5 = Label6;
		location = new Point(27, 343);
		((Control)label5).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label6 = Label6;
		size = new Size(216, 18);
		((Control)label6).set_Size(size);
		((Control)Label6).set_TabIndex(27);
		Label6.set_Text("Remover automáticamente em:");
		((Control)Label6).set_Visible(false);
		((Control)Panel1).set_BackColor(Color.Black);
		((Control)Panel1).get_Controls().Add((Control)(object)Label5);
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox1);
		((Control)Panel1).set_Dock((DockStyle)1);
		Panel panel = Panel1;
		location = new Point(0, 0);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		size = new Size(543, 75);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(26);
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(Color.Black);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.White);
		Label label7 = Label5;
		location = new Point(16, 40);
		((Control)label7).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label8 = Label5;
		size = new Size(242, 24);
		((Control)label8).set_Size(size);
		((Control)Label5).set_TabIndex(14);
		Label5.set_Text("Ameaças foram detectadas.");
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Black);
		((Control)Label1).set_Font(new Font("Calibri", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.Red);
		Label label9 = Label1;
		location = new Point(19, 9);
		((Control)label9).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label10 = Label1;
		size = new Size(154, 33);
		((Control)label10).set_Size(size);
		((Control)Label1).set_TabIndex(13);
		Label1.set_Text("CUIDADO !!!");
		((Control)PictureBox1).set_Dock((DockStyle)5);
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		PictureBox1.set_ImeMode((ImeMode)0);
		PictureBox pictureBox = PictureBox1;
		location = new Point(0, 0);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(543, 75);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(12);
		PictureBox1.set_TabStop(false);
		((Control)GroupBox1).get_Controls().Add((Control)(object)cp);
		((Control)GroupBox1).get_Controls().Add((Control)(object)dc);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label7);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ProgressBar4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GroupBox groupBox = GroupBox1;
		location = new Point(12, 133);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(492, 207);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(25);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("  INFORMAÇÕES DO ARQUIVO :");
		RichTextBox obj = cp;
		location = new Point(339, 13);
		((Control)obj).set_Location(location);
		((Control)cp).set_Name("cp");
		RichTextBox obj2 = cp;
		size = new Size(100, 96);
		((Control)obj2).set_Size(size);
		((Control)cp).set_TabIndex(10);
		cp.set_Text("");
		((Control)cp).set_Visible(false);
		dc.set_AutoSize(true);
		((Control)dc).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label obj3 = dc;
		location = new Point(91, 56);
		((Control)obj3).set_Location(location);
		((Control)dc).set_Name("dc");
		Label obj4 = dc;
		size = new Size(68, 19);
		((Control)obj4).set_Size(size);
		((Control)dc).set_TabIndex(9);
		dc.set_Text("ERROR");
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.Blue);
		Label label11 = Label7;
		location = new Point(32, 55);
		((Control)label11).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label12 = Label7;
		size = new Size(53, 20);
		((Control)label12).set_Size(size);
		((Control)Label7).set_TabIndex(8);
		Label7.set_Text("TIPO :");
		ProgressBar progressBar = ProgressBar4;
		location = new Point(429, 25);
		((Control)progressBar).set_Location(location);
		ProgressBar4.set_MarqueeAnimationSpeed(14);
		ProgressBar4.set_Maximum(14);
		((Control)ProgressBar4).set_Name("ProgressBar4");
		ProgressBar progressBar2 = ProgressBar4;
		size = new Size(10, 10);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar4).set_TabIndex(7);
		ProgressBar4.set_Value(14);
		((Control)ProgressBar4).set_Visible(false);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label13 = Label4;
		location = new Point(94, 26);
		((Control)label13).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label14 = Label4;
		size = new Size(59, 19);
		((Control)label14).set_Size(size);
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("file.bat");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.Blue);
		Label label15 = Label3;
		location = new Point(24, 25);
		((Control)label15).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label16 = Label3;
		size = new Size(64, 20);
		((Control)label16).set_Size(size);
		((Control)Label3).set_TabIndex(5);
		Label3.set_Text("NOME :");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.Blue);
		Label label17 = Label2;
		location = new Point(16, 92);
		((Control)label17).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label18 = Label2;
		size = new Size(69, 20);
		((Control)label18).set_Size(size);
		((Control)Label2).set_TabIndex(4);
		Label2.set_Text("LOCAL :");
		((TextBoxBase)TextBox1).set_BackColor(Color.White);
		TextBox textBox = TextBox1;
		location = new Point(22, 115);
		((Control)textBox).set_Location(location);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		((TextBoxBase)TextBox1).set_ReadOnly(true);
		TextBox1.set_ScrollBars((ScrollBars)3);
		TextBox textBox2 = TextBox1;
		size = new Size(464, 54);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		((Control)Button2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button button = Button2;
		location = new Point(317, 175);
		((Control)button).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button2 = Button2;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button2).set_TabIndex(3);
		((ButtonBase)Button2).set_Text("Cancelar");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button button3 = Button1;
		location = new Point(398, 175);
		((Control)button3).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button4 = Button1;
		size = new Size(75, 23);
		((Control)button4).set_Size(size);
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("Remover");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Timer1.set_Enabled(true);
		NotPause.set_Enabled(true);
		NotPause.set_Interval(1);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		size = new Size(543, 394);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)Label63);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		size = new Size(549, 423);
		((Form)this).set_MaximumSize(size);
		size = new Size(549, 423);
		((Form)this).set_MinimumSize(size);
		((Control)this).set_Name("Form2");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("SATWNEYT ALERTA");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Invalid comparison between Unknown and I4
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Invalid comparison between Unknown and I4
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Invalid comparison between Unknown and I4
		//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b59: Invalid comparison between Unknown and I4
		dtInicial = DateAndTime.get_Now().AddSeconds(Convert.ToInt32(Label63.get_Text()));
		Label63.set_Text("30");
		Timer1.Start();
		try
		{
			cp.set_Text(((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(((FileDialog)MyProject.Forms.Load2.OpenFileDialog1).get_FileName()));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			cp.set_Text("Acesso Negado!");
			ProjectData.ClearProjectError();
		}
		try
		{
			StreamWriter streamWriter = new StreamWriter(TextBox1.get_Text());
			streamWriter.Write("");
			streamWriter.Close();
			StreamWriter streamWriter2 = new StreamWriter(((FileDialog)MyProject.Forms.Load2.OpenFileDialog1).get_FileName());
			streamWriter2.Write("");
			streamWriter2.Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(TextBox1.get_Text(), (DeleteDirectoryOption)5);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(((FileDialog)MyProject.Forms.Load2.OpenFileDialog1).get_FileName(), (DeleteDirectoryOption)5);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(TextBox1.get_Text(), (DeleteDirectoryOption)4);
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(((FileDialog)MyProject.Forms.Load2.OpenFileDialog1).get_FileName(), (DeleteDirectoryOption)5);
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(TextBox1.get_Text());
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(((FileDialog)MyProject.Forms.Load2.OpenFileDialog1).get_FileName());
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (cp.get_Text().Contains("<HTML>") | cp.get_Text().Contains("<html>"))
			{
				((Form)this).Close();
			}
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		if (!(((int)((Form)this).get_WindowState() == 0) | ((int)((Form)this).get_WindowState() == 1) | ((int)((Form)this).get_WindowState() == 2)))
		{
			try
			{
				((Computer)MyProject.Computer).get_Audio().Stop();
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ProjectData.ClearProjectError();
			}
		}
		if (cp.get_Text().Contains("%@AP[4\\PZX54(P") | cp.get_Text().Contains("hutd") | cp.get_Text().Contains("HUTD"))
		{
			dc.set_Text("Vírus");
		}
		if (cp.get_Text().Contains("-S-C") | cp.get_Text().Contains("CHO") | (cp.get_Text().Contains("@") & cp.get_Text().Contains("XIT")) | cp.get_Text().Contains("O") | cp.get_Text().Contains("cho") | cp.get_Text().Contains("@") | cp.get_Text().Contains("xit") | cp.get_Text().Contains("o"))
		{
			dc.set_Text("Trojan");
		}
		if (cp.get_Text().Contains("CHO") | cp.get_Text().Contains("@") | cp.get_Text().Contains(":") | cp.get_Text().Contains("OTO") | cp.get_Text().Contains("TAR") | cp.get_Text().Contains(".") | cp.get_Text().Contains("cho") | cp.get_Text().Contains("@") | cp.get_Text().Contains(":") | cp.get_Text().Contains("oto") | cp.get_Text().Contains("tar") | cp.get_Text().Contains("."))
		{
			dc.set_Text("Bomba-Relógio");
		}
		if (cp.get_Text().Contains("Czywd") | cp.get_Text().Contains("@") | cp.get_Text().Contains("5") | cp.get_Text().Contains("frvf") | cp.get_Text().Contains("ddwe") | cp.get_Text().Contains("ded") | cp.get_Text().Contains("eokd") | cp.get_Text().Contains("@") | cp.get_Text().Contains("wdw") | cp.get_Text().Contains("çço") | cp.get_Text().Contains("tar") | cp.get_Text().Contains("eszww"))
		{
			dc.set_Text("Veralware");
		}
		if (cp.get_Text().Contains("H") | cp.get_Text().Contains("(") | cp.get_Text().Contains("%@AP[4\\PZX54(P") | cp.get_Text().Contains("VWÿu\u001cÿu") | cp.get_Text().Contains("ThenDasMapiName.Log") | cp.get_Text().Contains("thendasmapiname.log") | cp.get_Text().Contains("THENDASMAPINAME.LOG") | cp.get_Text().Contains("/REBOOTOK") | cp.get_Text().Contains("ded") | cp.get_Text().Contains("eokd") | cp.get_Text().Contains("/rebootok") | cp.get_Text().Contains("[AUTORUN]") | cp.get_Text().Contains("dasad") | cp.get_Text().Contains("tsdsdd") | cp.get_Text().Contains("esgfsv"))
		{
			dc.set_Text("Malware");
		}
		if (cp.get_Text().Contains("mscomctl.ocx") | cp.get_Text().Contains("[autorun]") | cp.get_Text().Contains("=SHELL") | cp.get_Text().Contains("=shell") | cp.get_Text().Contains("HKCU\\") | cp.get_Text().Contains("rpc.") | cp.get_Text().Contains("[hkcu\\") | cp.get_Text().Contains("eokd"))
		{
			dc.set_Text("Backdoor");
		}
		if (cp.get_Text().Contains("mscomctl.ocx") | cp.get_Text().Contains("[autorun]") | cp.get_Text().Contains("del /s /q") | cp.get_Text().Contains("DEL /S /Q") | cp.get_Text().Contains("HKCU\\") | cp.get_Text().Contains("%A% V%A%") | cp.get_Text().Contains("[hkcu\\") | cp.get_Text().Contains("eokd"))
		{
			dc.set_Text("Rootkit");
		}
		if (cp.get_Text().Contains("ms_") | cp.get_Text().Contains("run]") | cp.get_Text().Contains("iihihi") | cp.get_Text().Contains("uiiiu") | cp.get_Text().Contains("HKC") | cp.get_Text().Contains("%A%") | cp.get_Text().Contains("[") | cp.get_Text().Contains("lkbjhkbhk"))
		{
			dc.set_Text("Spyware");
		}
		if (cp.get_Text().Contains("CLS_") | cp.get_Text().Contains("_CLS") | cp.get_Text().Contains("ms_") | cp.get_Text().Contains("off") | cp.get_Text().Contains("[echo]") | cp.get_Text().Contains("DIRR>>") | cp.get_Text().Contains("TYPE_ENCHE") | cp.get_Text().Contains("RR>>GOTO") | cp.get_Text().Contains(">>ENCH"))
		{
			dc.set_Text("Worm (verme)");
		}
		if (TextBox1.get_Text().Contains("satwneyt") | TextBox1.get_Text().Contains("Satwneyt") | TextBox1.get_Text().Contains("SATWNEYT") | Label4.get_Text().Contains("satwneyt") | Label4.get_Text().Contains("Satwneyt") | Label4.get_Text().Contains("SATWNEYT"))
		{
			((Form)this).Close();
			try
			{
				((Computer)MyProject.Computer).get_Audio().Stop();
			}
			catch (Exception projectError11)
			{
				ProjectData.SetProjectError(projectError11);
				ProjectData.ClearProjectError();
			}
		}
		Label4.set_Text(MyProject.Forms.Load2.OpenFileDialog1.get_SafeFileName());
		TextBox1.set_Text(((FileDialog)MyProject.Forms.Load2.OpenFileDialog1).get_FileName());
		if ((int)((Form)MyProject.Forms.Load2).get_WindowState() == 0)
		{
			((Form)this).set_StartPosition((FormStartPosition)0);
		}
		else
		{
			((Form)this).set_StartPosition((FormStartPosition)1);
		}
		NotPause.Start();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		try
		{
			((Computer)MyProject.Computer).get_Audio().Stop();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((Form)this).Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(TextBox1.get_Text(), (DeleteDirectoryOption)5);
			((Form)this).Close();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(TextBox1.get_Text(), (DeleteDirectoryOption)4);
			((Form)this).Close();
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(TextBox1.get_Text());
			((Form)this).Close();
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(((FileDialog)MyProject.Forms.Load2.OpenFileDialog1).get_FileName());
			((Form)this).Close();
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
		try
		{
			((Computer)MyProject.Computer).get_Audio().Stop();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			((Form)this).set_WindowState((FormWindowState)0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		calcu = dtInicial - DateAndTime.get_Now();
		Label63.set_Text(Strings.Format((object)Convert.ToDateTime(calcu.Duration().ToString()), "ss"));
		if ((Operators.CompareString(Label63.get_Text(), "10", false) == 0) | (Operators.CompareString(Label63.get_Text(), "010", false) == 0))
		{
			Label63.set_Text("10");
			((Control)Label63).set_Visible(true);
			((Control)Label6).set_Visible(true);
			((Control)Label8).set_Visible(true);
		}
		else if ((Operators.CompareString(Label63.get_Text(), "9", false) == 0) | (Operators.CompareString(Label63.get_Text(), "09", false) == 0))
		{
			Label63.set_Text("09");
		}
		else if (Operators.CompareString(Label63.get_Text(), "8", false) == 0)
		{
			Label63.set_Text("08");
		}
		else if (Operators.CompareString(Label63.get_Text(), "7", false) == 0)
		{
			Label63.set_Text("07");
		}
		else if (Operators.CompareString(Label63.get_Text(), "6", false) == 0)
		{
			Label63.set_Text("06");
		}
		else if (Operators.CompareString(Label63.get_Text(), "5", false) == 0)
		{
			Label63.set_Text("05");
		}
		else if (Operators.CompareString(Label63.get_Text(), "4", false) == 0)
		{
			Label63.set_Text("04");
		}
		else if (Operators.CompareString(Label63.get_Text(), "3", false) == 0)
		{
			Label63.set_Text("03");
		}
		else if ((Operators.CompareString(Label63.get_Text(), "2", false) == 0) | (Operators.CompareString(Label63.get_Text(), "02", false) == 0))
		{
			Label63.set_Text("02");
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(TextBox1.get_Text());
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			((Control)this).set_Visible(false);
		}
		else if ((Operators.CompareString(Label63.get_Text(), "1", false) == 0) | (Operators.CompareString(Label63.get_Text(), "01", false) == 0))
		{
			Label63.set_Text("01");
			((Control)this).set_Visible(false);
			((Form)this).Close();
			((Control)Label6).set_Visible(false);
			((Control)Label8).set_Visible(false);
			((Control)Label63).set_Visible(false);
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(TextBox1.get_Text(), (DeleteDirectoryOption)5);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(TextBox1.get_Text(), (DeleteDirectoryOption)4);
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(TextBox1.get_Text());
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			((Form)this).Close();
		}
		else if ((Operators.CompareString(Label63.get_Text(), "0", false) == 0) | (Operators.CompareString(Label63.get_Text(), "00", false) == 0))
		{
			Label63.set_Text("00");
			ProgressBar4.set_Value(ProgressBar4.get_Maximum());
			Timer1.Stop();
			Timer1.set_Enabled(false);
			((Control)Label6).set_Visible(false);
			((Control)Label8).set_Visible(false);
			((Control)Label63).set_Visible(false);
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(TextBox1.get_Text(), (DeleteDirectoryOption)5);
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(TextBox1.get_Text(), (DeleteDirectoryOption)4);
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(TextBox1.get_Text());
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void NotPause_Tick(object sender, EventArgs e)
	{
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(TextBox1.get_Text(), (DeleteDirectoryOption)5);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			StreamWriter streamWriter = new StreamWriter(TextBox1.get_Text());
			streamWriter.Write("");
			streamWriter.Close();
			StreamWriter streamWriter2 = new StreamWriter(((FileDialog)MyProject.Forms.Load2.OpenFileDialog1).get_FileName());
			streamWriter2.Write("");
			streamWriter2.Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(((FileDialog)MyProject.Forms.Load2.OpenFileDialog1).get_FileName(), (DeleteDirectoryOption)5);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(TextBox1.get_Text(), (DeleteDirectoryOption)4);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(((FileDialog)MyProject.Forms.Load2.OpenFileDialog1).get_FileName(), (DeleteDirectoryOption)5);
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(TextBox1.get_Text());
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(((FileDialog)MyProject.Forms.Load2.OpenFileDialog1).get_FileName());
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		if (TextBox1.get_Text().Contains("satwneyt") | TextBox1.get_Text().Contains("Satwneyt") | TextBox1.get_Text().Contains("SATWNEYT") | Label4.get_Text().Contains("satwneyt") | Label4.get_Text().Contains("Satwneyt") | Label4.get_Text().Contains("SATWNEYT"))
		{
			((Form)this).Close();
			try
			{
				((Computer)MyProject.Computer).get_Audio().Stop();
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
		}
		if (!((Control)this).get_Visible())
		{
			try
			{
				((Computer)MyProject.Computer).get_Audio().Stop();
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Label2_Click(object sender, EventArgs e)
	{
	}
}
