using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace ns1;

[DesignerGenerated]
public class chatdesk : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("RichTextBox3")]
	private RichTextBox _RichTextBox3;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Panel5")]
	private Panel _Panel5;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Panel6")]
	private Panel _Panel6;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("RichTextBox2")]
	private RichTextBox _RichTextBox2;

	[AccessedThroughProperty("Panel11")]
	private Panel _Panel11;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Panel12")]
	private Panel _Panel12;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

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

	internal virtual RichTextBox RichTextBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _RichTextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RichTextBox3 = value;
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

	internal virtual PictureBox PictureBox6
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox6 = value;
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
			_RichTextBox1 = value;
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

	internal virtual LinkLabel LinkLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.remove_LinkClicked(val);
			}
			_LinkLabel1 = value;
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.add_LinkClicked(val);
			}
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
			EventHandler eventHandler = Label9_Click;
			if (_Label9 != null)
			{
				((Control)_Label9).remove_Click(eventHandler);
			}
			_Label9 = value;
			if (_Label9 != null)
			{
				((Control)_Label9).add_Click(eventHandler);
			}
		}
	}

	internal virtual RichTextBox RichTextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RichTextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = RichTextBox2_TextChanged;
			KeyEventHandler val = new KeyEventHandler(RichTextBox2_KeyDown);
			if (_RichTextBox2 != null)
			{
				((Control)_RichTextBox2).remove_TextChanged(eventHandler);
				((Control)_RichTextBox2).remove_KeyDown(val);
			}
			_RichTextBox2 = value;
			if (_RichTextBox2 != null)
			{
				((Control)_RichTextBox2).add_TextChanged(eventHandler);
				((Control)_RichTextBox2).add_KeyDown(val);
			}
		}
	}

	internal virtual Panel Panel11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel11 = value;
		}
	}

	internal virtual Button Button3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button3_Click;
			if (_Button3 != null)
			{
				((Control)_Button3).remove_Click(eventHandler);
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				((Control)_Button3).add_Click(eventHandler);
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

	internal virtual Panel Panel12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel12 = value;
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
			_Panel3 = value;
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

	internal virtual PictureBox PictureBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox5 = value;
		}
	}

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	internal virtual PictureBox PictureBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox4 = value;
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal virtual PictureBox PictureBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox3 = value;
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
			_Label2 = value;
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

	[DebuggerNonUserCode]
	public chatdesk()
	{
		((Form)this).add_Load((EventHandler)chatdesk_Load);
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
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected O, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected O, but got Unknown
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected O, but got Unknown
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Expected O, but got Unknown
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Expected O, but got Unknown
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected O, but got Unknown
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09de: Expected O, but got Unknown
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a82: Expected O, but got Unknown
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afe: Expected O, but got Unknown
		//IL_0c1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c27: Expected O, but got Unknown
		//IL_0ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb0: Expected O, but got Unknown
		//IL_0e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4b: Expected O, but got Unknown
		//IL_0faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb4: Expected O, but got Unknown
		//IL_1034: Unknown result type (might be due to invalid IL or missing references)
		//IL_103e: Expected O, but got Unknown
		//IL_10b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c2: Expected O, but got Unknown
		//IL_1135: Unknown result type (might be due to invalid IL or missing references)
		//IL_113f: Expected O, but got Unknown
		//IL_11b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c0: Expected O, but got Unknown
		//IL_122f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1239: Expected O, but got Unknown
		//IL_12a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ab: Expected O, but got Unknown
		//IL_1313: Unknown result type (might be due to invalid IL or missing references)
		//IL_131d: Expected O, but got Unknown
		//IL_1393: Unknown result type (might be due to invalid IL or missing references)
		//IL_139d: Expected O, but got Unknown
		//IL_141a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1424: Expected O, but got Unknown
		//IL_14a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ab: Expected O, but got Unknown
		//IL_1528: Unknown result type (might be due to invalid IL or missing references)
		//IL_1532: Expected O, but got Unknown
		//IL_15a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ad: Expected O, but got Unknown
		//IL_1674: Unknown result type (might be due to invalid IL or missing references)
		//IL_167e: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(chatdesk));
		Panel1 = new Panel();
		RichTextBox3 = new RichTextBox();
		Panel4 = new Panel();
		Label7 = new Label();
		Label6 = new Label();
		Panel2 = new Panel();
		Panel5 = new Panel();
		Label8 = new Label();
		PictureBox6 = new PictureBox();
		RichTextBox1 = new RichTextBox();
		Label1 = new Label();
		Panel6 = new Panel();
		LinkLabel1 = new LinkLabel();
		Label9 = new Label();
		RichTextBox2 = new RichTextBox();
		Panel11 = new Panel();
		Button3 = new Button();
		Button1 = new Button();
		Panel12 = new Panel();
		Panel3 = new Panel();
		Button2 = new Button();
		GroupBox1 = new GroupBox();
		PictureBox5 = new PictureBox();
		Label11 = new Label();
		PictureBox4 = new PictureBox();
		Label10 = new Label();
		PictureBox3 = new PictureBox();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		TextBox1 = new TextBox();
		Timer1 = new Timer(components);
		((Control)Panel1).SuspendLayout();
		((Control)Panel4).SuspendLayout();
		((Control)Panel5).SuspendLayout();
		((ISupportInitialize)PictureBox6).BeginInit();
		((Control)Panel6).SuspendLayout();
		((Control)Panel11).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel1).set_BackColor(Color.White);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel3);
		((Control)Panel1).get_Controls().Add((Control)(object)RichTextBox3);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel4);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel2);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel5);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel6);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel11);
		((Control)Panel1).set_Dock((DockStyle)5);
		Panel panel = Panel1;
		Point location = new Point(0, 0);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		Size size = new Size(650, 524);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(18);
		((TextBoxBase)RichTextBox3).set_BackColor(Color.White);
		((Control)RichTextBox3).set_Cursor(Cursors.get_Default());
		RichTextBox3.set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		RichTextBox richTextBox = RichTextBox3;
		location = new Point(3, 160);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox3).set_Name("RichTextBox3");
		((TextBoxBase)RichTextBox3).set_ReadOnly(true);
		RichTextBox3.set_ScrollBars((RichTextBoxScrollBars)19);
		RichTextBox richTextBox2 = RichTextBox3;
		size = new Size(644, 189);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox3).set_TabIndex(21);
		RichTextBox3.set_Text("\n Desconhecido Diz:\n Oooooiii !!!!\n\nCah 78 Respondeu:\nOOOIII !");
		((Control)Panel4).get_Controls().Add((Control)(object)Label7);
		((Control)Panel4).get_Controls().Add((Control)(object)Label6);
		((Control)Panel4).set_Dock((DockStyle)1);
		Panel panel3 = Panel4;
		location = new Point(0, 107);
		((Control)panel3).set_Location(location);
		((Control)Panel4).set_Name("Panel4");
		Panel panel4 = Panel4;
		size = new Size(650, 47);
		((Control)panel4).set_Size(size);
		((Control)Panel4).set_TabIndex(20);
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label7;
		location = new Point(136, 8);
		((Control)label).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label2 = Label7;
		size = new Size(104, 29);
		((Control)label2).set_Size(size);
		((Control)Label7).set_TabIndex(1);
		Label7.set_Text("User Pc.");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label3 = Label6;
		location = new Point(4, 8);
		((Control)label3).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label4 = Label6;
		size = new Size(137, 29);
		((Control)label4).set_Size(size);
		((Control)Label6).set_TabIndex(0);
		Label6.set_Text("Bem Vindo;");
		((Control)Panel2).set_BackColor(Color.Black);
		((Control)Panel2).set_Dock((DockStyle)1);
		Panel panel5 = Panel2;
		location = new Point(0, 97);
		((Control)panel5).set_Location(location);
		((Control)Panel2).set_Name("Panel2");
		Panel panel6 = Panel2;
		size = new Size(650, 10);
		((Control)panel6).set_Size(size);
		((Control)Panel2).set_TabIndex(19);
		((Control)Panel5).set_BackColor(Color.White);
		((Control)Panel5).get_Controls().Add((Control)(object)Label8);
		((Control)Panel5).get_Controls().Add((Control)(object)PictureBox6);
		((Control)Panel5).get_Controls().Add((Control)(object)RichTextBox1);
		((Control)Panel5).get_Controls().Add((Control)(object)Label1);
		((Control)Panel5).set_Dock((DockStyle)1);
		Panel panel7 = Panel5;
		location = new Point(0, 0);
		((Control)panel7).set_Location(location);
		((Control)Panel5).set_Name("Panel5");
		Panel panel8 = Panel5;
		size = new Size(650, 97);
		((Control)panel8).set_Size(size);
		((Control)Panel5).set_TabIndex(18);
		Label8.set_AutoSize(true);
		((Control)Label8).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label5 = Label8;
		location = new Point(99, 60);
		((Control)label5).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label6 = Label8;
		size = new Size(123, 24);
		((Control)label6).set_Size(size);
		((Control)Label8).set_TabIndex(43);
		Label8.set_Text("Rede Social");
		((Control)PictureBox6).set_Cursor(Cursors.get_Default());
		((Control)PictureBox6).set_Dock((DockStyle)3);
		PictureBox6.set_Image((Image)componentResourceManager.GetObject("PictureBox6.Image"));
		PictureBox pictureBox = PictureBox6;
		location = new Point(0, 0);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox6).set_Name("PictureBox6");
		PictureBox pictureBox2 = PictureBox6;
		size = new Size(73, 97);
		((Control)pictureBox2).set_Size(size);
		PictureBox6.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox6.set_TabIndex(42);
		PictureBox6.set_TabStop(false);
		RichTextBox1.set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		RichTextBox richTextBox3 = RichTextBox1;
		location = new Point(-50, 9);
		((Control)richTextBox3).set_Location(location);
		((Control)RichTextBox1).set_Name("RichTextBox1");
		RichTextBox richTextBox4 = RichTextBox1;
		size = new Size(123, 55);
		((Control)richTextBox4).set_Size(size);
		((Control)RichTextBox1).set_TabIndex(26);
		RichTextBox1.set_Text("");
		((Control)RichTextBox1).set_Visible(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.White);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 36f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.Black);
		Label label7 = Label1;
		location = new Point(92, 9);
		((Control)label7).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label8 = Label1;
		size = new Size(345, 55);
		((Control)label8).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Chat Tub Desk");
		((Control)Panel6).set_BackColor(Color.FromArgb(0, 0, 64));
		((Control)Panel6).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)Panel6).get_Controls().Add((Control)(object)Label9);
		((Control)Panel6).get_Controls().Add((Control)(object)RichTextBox2);
		Panel panel9 = Panel6;
		location = new Point(9, 355);
		((Control)panel9).set_Location(location);
		((Control)Panel6).set_Name("Panel6");
		Panel panel10 = Panel6;
		size = new Size(638, 100);
		((Control)panel10).set_Size(size);
		((Control)Panel6).set_TabIndex(17);
		((Label)LinkLabel1).set_AutoSize(true);
		((Control)LinkLabel1).set_BackColor(Color.White);
		((Control)LinkLabel1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(194, 42);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(37, 24);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(17);
		LinkLabel1.set_TabStop(true);
		LinkLabel1.set_Text("OK");
		Label9.set_AutoSize(true);
		((Control)Label9).set_BackColor(Color.White);
		((Control)Label9).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label9 = Label9;
		location = new Point(19, 18);
		((Control)label9).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label10 = Label9;
		size = new Size(297, 48);
		((Control)label10).set_Size(size);
		((Control)Label9).set_TabIndex(13);
		Label9.set_Text("Digite aqui para conversar com seu novo amigo.\r\n E depois, clique em: Enviar.\r\nIsto é um Chat Original !!!");
		RichTextBox2.set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		RichTextBox richTextBox5 = RichTextBox2;
		location = new Point(3, 3);
		((Control)richTextBox5).set_Location(location);
		((Control)RichTextBox2).set_Name("RichTextBox2");
		RichTextBox richTextBox6 = RichTextBox2;
		size = new Size(632, 94);
		((Control)richTextBox6).set_Size(size);
		((Control)RichTextBox2).set_TabIndex(12);
		RichTextBox2.set_Text("");
		((Control)Panel11).set_BackColor(Color.White);
		((Control)Panel11).get_Controls().Add((Control)(object)Button3);
		((Control)Panel11).get_Controls().Add((Control)(object)Button1);
		((Control)Panel11).get_Controls().Add((Control)(object)Panel12);
		Panel panel11 = Panel11;
		location = new Point(3, 461);
		((Control)panel11).set_Location(location);
		((Control)Panel11).set_Name("Panel11");
		Panel panel12 = Panel11;
		size = new Size(647, 44);
		((Control)panel12).set_Size(size);
		((Control)Panel11).set_TabIndex(13);
		((Control)Panel11).set_Visible(false);
		((Control)Button3).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button button = Button3;
		location = new Point(204, 6);
		((Control)button).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button2 = Button3;
		size = new Size(179, 35);
		((Control)button2).set_Size(size);
		((Control)Button3).set_TabIndex(7);
		((ButtonBase)Button3).set_Text("Opções");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button button3 = Button1;
		location = new Point(389, 6);
		((Control)button3).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button4 = Button1;
		size = new Size(166, 35);
		((Control)button4).set_Size(size);
		((Control)Button1).set_TabIndex(4);
		((ButtonBase)Button1).set_Text("Enviar");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)Panel12).set_Dock((DockStyle)4);
		Panel panel13 = Panel12;
		location = new Point(635, 0);
		((Control)panel13).set_Location(location);
		((Control)Panel12).set_Name("Panel12");
		Panel panel14 = Panel12;
		size = new Size(12, 44);
		((Control)panel14).set_Size(size);
		((Control)Panel12).set_TabIndex(0);
		((Control)Panel3).set_BackColor(Color.White);
		((Control)Panel3).get_Controls().Add((Control)(object)Button2);
		((Control)Panel3).get_Controls().Add((Control)(object)GroupBox1);
		((Control)Panel3).get_Controls().Add((Control)(object)Label2);
		((Control)Panel3).get_Controls().Add((Control)(object)TextBox1);
		Panel panel15 = Panel3;
		location = new Point(0, 113);
		((Control)panel15).set_Location(location);
		((Control)Panel3).set_Name("Panel3");
		Panel panel16 = Panel3;
		size = new Size(650, 411);
		((Control)panel16).set_Size(size);
		((Control)Panel3).set_TabIndex(23);
		((Control)Button2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button button5 = Button2;
		location = new Point(459, 150);
		((Control)button5).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button6 = Button2;
		size = new Size(146, 30);
		((Control)button6).set_Size(size);
		((Control)Button2).set_TabIndex(3);
		((ButtonBase)Button2).set_Text("Ok");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((Control)GroupBox1).get_Controls().Add((Control)(object)PictureBox5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label11);
		((Control)GroupBox1).get_Controls().Add((Control)(object)PictureBox4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label10);
		((Control)GroupBox1).get_Controls().Add((Control)(object)PictureBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)PictureBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)PictureBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GroupBox groupBox = GroupBox1;
		location = new Point(3, 218);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(641, 181);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(4);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Opções e informações do Chat:");
		PictureBox5.set_Image((Image)componentResourceManager.GetObject("PictureBox5.Image"));
		PictureBox pictureBox3 = PictureBox5;
		location = new Point(10, 139);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox5).set_Name("PictureBox5");
		PictureBox pictureBox4 = PictureBox5;
		size = new Size(29, 26);
		((Control)pictureBox4).set_Size(size);
		PictureBox5.set_TabIndex(11);
		PictureBox5.set_TabStop(false);
		Label11.set_AutoSize(true);
		((Control)Label11).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label11 = Label11;
		location = new Point(42, 142);
		((Control)label11).set_Location(location);
		((Control)Label11).set_Name("Label11");
		Label label12 = Label11;
		size = new Size(448, 20);
		((Control)label12).set_Size(size);
		((Control)Label11).set_TabIndex(10);
		Label11.set_Text("A Chat Tub Desk será grátis e sempre será o melhor de todos.");
		PictureBox4.set_Image((Image)componentResourceManager.GetObject("PictureBox4.Image"));
		PictureBox pictureBox5 = PictureBox4;
		location = new Point(10, 107);
		((Control)pictureBox5).set_Location(location);
		((Control)PictureBox4).set_Name("PictureBox4");
		PictureBox pictureBox6 = PictureBox4;
		size = new Size(29, 26);
		((Control)pictureBox6).set_Size(size);
		PictureBox4.set_TabIndex(9);
		PictureBox4.set_TabStop(false);
		Label10.set_AutoSize(true);
		((Control)Label10).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label13 = Label10;
		location = new Point(42, 110);
		((Control)label13).set_Location(location);
		((Control)Label10).set_Name("Label10");
		Label label14 = Label10;
		size = new Size(459, 20);
		((Control)label14).set_Size(size);
		((Control)Label10).set_TabIndex(8);
		Label10.set_Text("Apenas o seu nome já é suficiente criar uma conta e fazer login.");
		PictureBox3.set_Image((Image)componentResourceManager.GetObject("PictureBox3.Image"));
		PictureBox pictureBox7 = PictureBox3;
		location = new Point(10, 81);
		((Control)pictureBox7).set_Location(location);
		((Control)PictureBox3).set_Name("PictureBox3");
		PictureBox pictureBox8 = PictureBox3;
		size = new Size(29, 26);
		((Control)pictureBox8).set_Size(size);
		PictureBox3.set_TabIndex(7);
		PictureBox3.set_TabStop(false);
		PictureBox2.set_Image((Image)componentResourceManager.GetObject("PictureBox2.Image"));
		PictureBox pictureBox9 = PictureBox2;
		location = new Point(10, 54);
		((Control)pictureBox9).set_Location(location);
		((Control)PictureBox2).set_Name("PictureBox2");
		PictureBox pictureBox10 = PictureBox2;
		size = new Size(29, 26);
		((Control)pictureBox10).set_Size(size);
		PictureBox2.set_TabIndex(6);
		PictureBox2.set_TabStop(false);
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		PictureBox pictureBox11 = PictureBox1;
		location = new Point(10, 24);
		((Control)pictureBox11).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox12 = PictureBox1;
		size = new Size(29, 26);
		((Control)pictureBox12).set_Size(size);
		PictureBox1.set_TabIndex(5);
		PictureBox1.set_TabStop(false);
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label15 = Label5;
		location = new Point(42, 84);
		((Control)label15).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label16 = Label5;
		size = new Size(483, 20);
		((Control)label16).set_Size(size);
		((Control)Label5).set_TabIndex(2);
		Label5.set_Text("Você pode fazer sua publicidade ou propaganda do seus produtos.");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label17 = Label4;
		location = new Point(42, 54);
		((Control)label17).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label18 = Label4;
		size = new Size(471, 20);
		((Control)label18).set_Size(size);
		((Control)Label4).set_TabIndex(1);
		Label4.set_Text("Com este Chat permite para conversar e tenha mais informações.");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label19 = Label3;
		location = new Point(42, 24);
		((Control)label19).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label20 = Label3;
		size = new Size(270, 20);
		((Control)label20).set_Size(size);
		((Control)Label3).set_TabIndex(0);
		Label3.set_Text("Faça novos amigos e descubra mais.");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label21 = Label2;
		location = new Point(51, 76);
		((Control)label21).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label22 = Label2;
		size = new Size(181, 24);
		((Control)label22).set_Size(size);
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("DIGITE SEU NOME:");
		((Control)TextBox1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox textBox = TextBox1;
		location = new Point(55, 103);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(550, 29);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(1);
		Timer1.set_Enabled(true);
		Timer1.set_Interval(1);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		size = new Size(650, 524);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		size = new Size(666, 563);
		((Form)this).set_MaximumSize(size);
		size = new Size(666, 563);
		((Form)this).set_MinimumSize(size);
		((Control)this).set_Name("chatdesk");
		((Form)this).set_Opacity(0.96);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Chat Tub Desk - Powered By MASSAHIRO Software");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel4).ResumeLayout(false);
		((Control)Panel4).PerformLayout();
		((Control)Panel5).ResumeLayout(false);
		((Control)Panel5).PerformLayout();
		((ISupportInitialize)PictureBox6).EndInit();
		((Control)Panel6).ResumeLayout(false);
		((Control)Panel6).PerformLayout();
		((Control)Panel11).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel3).PerformLayout();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void chatdesk_Load(object sender, EventArgs e)
	{
		if (((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\Chat Tub Desk\\sa4\\de"))
		{
			((Control)Label9).set_Visible(false);
			((Control)LinkLabel1).set_Visible(false);
			RichTextBox3.set_Text("");
			((Control)RichTextBox1).set_Cursor(Cursors.get_Default());
		}
		try
		{
			WebClient webClient = new WebClient();
			webClient.Credentials = new NetworkCredential("cnectoversy", "Msyende47928");
			RichTextBox3.set_Text(webClient.DownloadString("ftp://cnectoversy@ftp.xpg.com.br/chat/chat-tub-desk.txt"));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\Chat Tub Desk\\sa4\\de");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((Control)Label9).set_Visible(false);
			((Control)LinkLabel1).set_Visible(false);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		WebClient webClient = new WebClient();
		webClient.Credentials = new NetworkCredential("cnectoversy", "Msyende47928");
		try
		{
			RichTextBox3.set_Text(webClient.DownloadString("ftp://cnectoversy@ftp.xpg.com.br/chat/chat-tub-desk.txt"));
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text = TextBox1.get_Text();
			webClient.UploadString("ftp://cnectoversy@ftp.xpg.com.br/chat/chat-tub-desk.txt", RichTextBox1.get_Text() + "" + text + " Diz: \r\n" + RichTextBox2.get_Text() + "\r\n");
			webClient.Credentials = new NetworkCredential("cnectoversy", "Msyende47928");
			RichTextBox3.set_Text(webClient.DownloadString("ftp://cnectoversy@ftp.xpg.com.br/chat/chat-tub-desk.txt"));
			((TextBoxBase)RichTextBox2).Clear();
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			if (Operators.CompareString(RichTextBox2.get_Text(), "", false) == 0)
			{
				Interaction.MsgBox((object)"Digite aqui para conversar com seus novos amigos.", (MsgBoxStyle)48, (object)null);
			}
			else if (!NetworkInterface.GetIsNetworkAvailable())
			{
				Interaction.MsgBox((object)"ERROR: Não foi possível enviar sua mensagem por causa da falta de internet. Por favor,verifique a rede e conecta sua internet.", (MsgBoxStyle)48, (object)null);
			}
			else if (NetworkInterface.GetIsNetworkAvailable())
			{
				Interaction.MsgBox((object)("ERROR: " + Conversion.ErrorToString()), (MsgBoxStyle)48, (object)null);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Form)MyProject.Forms.chatopcoes).ShowDialog();
			((Form)MyProject.Forms.chatopcoes).set_WindowState((FormWindowState)0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			try
			{
				((Control)MyProject.Forms.chatopcoes).Show();
				((Form)MyProject.Forms.chatopcoes).set_WindowState((FormWindowState)0);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				((Form)MyProject.Forms.chatopcoes).set_WindowState((FormWindowState)0);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\Chat Tub Desk\\sa4\\de"))
		{
			((Control)Label9).set_Visible(false);
			((Control)LinkLabel1).set_Visible(false);
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(TextBox1.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Digite seu nome !!!", (MsgBoxStyle)48, (object)null);
			return;
		}
		((Control)Panel1).set_Visible(true);
		((Control)Panel3).set_Visible(false);
		((Control)Panel11).set_Visible(true);
	}

	private void TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Invalid comparison between Unknown and I4
		if ((Operators.CompareString(TextBox1.get_Text(), "", false) == 0) & ((int)e.get_KeyCode() == 13))
		{
			Interaction.MsgBox((object)"Digite seu nome !!!", (MsgBoxStyle)48, (object)null);
		}
		else if (((int)e.get_KeyCode() == 13) & (Operators.CompareString(TextBox1.get_Text(), "", false) != 0))
		{
			((Control)Panel1).set_Visible(true);
			((Control)Panel3).set_Visible(false);
			((Control)Panel11).set_Visible(true);
		}
		if ((int)e.get_KeyCode() == 8)
		{
			((TextBoxBase)TextBox1).set_ReadOnly(false);
		}
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)Panel3).get_Visible())
		{
			Label7.set_Text(TextBox1.get_Text());
		}
		if ((double)TextBox1.get_Text().Count() > Conversions.ToDouble("23"))
		{
			((TextBoxBase)TextBox1).set_ReadOnly(true);
			((TextBoxBase)TextBox1).set_BackColor(Color.White);
			Interaction.MsgBox((object)"ATENÇÃO: No maxímo de linhas para digitar seu nome é 23 ", (MsgBoxStyle)48, (object)null);
		}
	}

	private void Label9_Click(object sender, EventArgs e)
	{
		((Control)Label9).set_Visible(false);
		((Control)LinkLabel1).set_Visible(false);
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\Chat Tub Desk\\sa4\\de");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void RichTextBox2_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Invalid comparison between Unknown and I4
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		if (((int)e.get_KeyCode() == 8) | ((int)e.get_KeyCode() == 32))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\Chat Tub Desk\\sa4\\de");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		WebClient webClient = new WebClient();
		webClient.Credentials = new NetworkCredential("cnectoversy", "Msyende47928");
		if ((int)e.get_KeyCode() == 13)
		{
			try
			{
				RichTextBox3.set_Text("ftp://cnectoversy@ftp.xpg.com.br/chat/chat-tub-desk.txt");
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		if ((int)e.get_KeyCode() != 13)
		{
			return;
		}
		try
		{
			RichTextBox3.set_Text("ftp://cnectoversy@ftp.xpg.com.br/chat/chat-tub-desk.txt");
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text = TextBox1.get_Text();
			webClient.Credentials = new NetworkCredential("cnectoversy", "Msyende47928");
			webClient.UploadString("ftp://cnectoversy@ftp.xpg.com.br/chat/chat-tub-desk.txt", RichTextBox1.get_Text() + "" + text + " Diz: \r\n" + RichTextBox2.get_Text() + "\r\n");
			((TextBoxBase)RichTextBox2).Clear();
			RichTextBox3.set_Text(webClient.DownloadString("ftp://cnectoversy@ftp.xpg.com.br/chat/chat-tub-desk.txt"));
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			if (!NetworkInterface.GetIsNetworkAvailable())
			{
				Interaction.MsgBox((object)"ERROR: Não foi possível enviar sua mensagem por causa da falta de internet. Por favor,verifique a rede e conecta sua internet.", (MsgBoxStyle)48, (object)null);
			}
			else if (NetworkInterface.GetIsNetworkAvailable())
			{
				Interaction.MsgBox((object)("ERROR: " + Conversion.ErrorToString()), (MsgBoxStyle)48, (object)null);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void RichTextBox2_TextChanged(object sender, EventArgs e)
	{
		((Control)Label9).set_Visible(false);
		((Control)LinkLabel1).set_Visible(false);
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\Chat Tub Desk\\sa4\\de");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Control)Label9).set_Visible(false);
		((Control)LinkLabel1).set_Visible(false);
	}
}
