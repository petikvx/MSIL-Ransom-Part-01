using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClientG.My;
using ClientG.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DesignerGenerated]
public class ChatOGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("GroupBox4")]
	private GroupBox _GroupBox4;

	[AccessedThroughProperty("GroupBox3")]
	private GroupBox _GroupBox3;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("StartChat")]
	private Button _StartChat;

	[AccessedThroughProperty("ColorC")]
	private Button _ColorC;

	[AccessedThroughProperty("ColorD")]
	private Button _ColorD;

	[AccessedThroughProperty("FormTitle")]
	private TextBox _FormTitle;

	[AccessedThroughProperty("ClientStatut")]
	private TextBox _ClientStatut;

	[AccessedThroughProperty("ClientID")]
	private TextBox _ClientID;

	[AccessedThroughProperty("AdminStatut")]
	private TextBox _AdminStatut;

	[AccessedThroughProperty("AdminID")]
	private TextBox _AdminID;

	[AccessedThroughProperty("ClientColor")]
	private TextBox _ClientColor;

	[AccessedThroughProperty("RadioButton3")]
	private RadioButton _RadioButton3;

	[AccessedThroughProperty("RadioButton4")]
	private RadioButton _RadioButton4;

	[AccessedThroughProperty("RadioButton2")]
	private RadioButton _RadioButton2;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("ColorDialog1")]
	private ColorDialog _ColorDialog1;

	[AccessedThroughProperty("Exitt")]
	private Button _Exitt;

	[AccessedThroughProperty("AdminColor")]
	private TextBox _AdminColor;

	public string MC;

	public string CCS;

	public int Sock;

	public int OS;

	public string FTT;

	public string ADP;

	public string CDP;

	public object Devices;

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

	internal virtual GroupBox GroupBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox2 = value;
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

	internal virtual GroupBox GroupBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox4 = value;
		}
	}

	internal virtual GroupBox GroupBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox3 = value;
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
			_Label9 = value;
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

	internal virtual Button StartChat
	{
		[DebuggerNonUserCode]
		get
		{
			return _StartChat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = NE_Click;
			if (_StartChat != null)
			{
				((Control)_StartChat).remove_Click(eventHandler);
			}
			_StartChat = value;
			if (_StartChat != null)
			{
				((Control)_StartChat).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button ColorC
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColorC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CD2_Click;
			if (_ColorC != null)
			{
				((Control)_ColorC).remove_Click(eventHandler);
			}
			_ColorC = value;
			if (_ColorC != null)
			{
				((Control)_ColorC).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button ColorD
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColorD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CD_Click;
			if (_ColorD != null)
			{
				((Control)_ColorD).remove_Click(eventHandler);
			}
			_ColorD = value;
			if (_ColorD != null)
			{
				((Control)_ColorD).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox FormTitle
	{
		[DebuggerNonUserCode]
		get
		{
			return _FormTitle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FormTitle = value;
		}
	}

	internal virtual TextBox ClientStatut
	{
		[DebuggerNonUserCode]
		get
		{
			return _ClientStatut;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ClientStatut = value;
		}
	}

	internal virtual TextBox ClientID
	{
		[DebuggerNonUserCode]
		get
		{
			return _ClientID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ClientID = value;
		}
	}

	internal virtual TextBox AdminStatut
	{
		[DebuggerNonUserCode]
		get
		{
			return _AdminStatut;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_AdminStatut = value;
		}
	}

	internal virtual TextBox AdminID
	{
		[DebuggerNonUserCode]
		get
		{
			return _AdminID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_AdminID = value;
		}
	}

	internal virtual TextBox ClientColor
	{
		[DebuggerNonUserCode]
		get
		{
			return _ClientColor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ClientColor = value;
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
			_RadioButton4 = value;
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

	internal virtual RadioButton RadioButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton1 = value;
		}
	}

	internal virtual ColorDialog ColorDialog1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColorDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColorDialog1 = value;
		}
	}

	internal virtual Button Exitt
	{
		[DebuggerNonUserCode]
		get
		{
			return _Exitt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Exitt != null)
			{
				((Control)_Exitt).remove_Click(eventHandler);
			}
			_Exitt = value;
			if (_Exitt != null)
			{
				((Control)_Exitt).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox AdminColor
	{
		[DebuggerNonUserCode]
		get
		{
			return _AdminColor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_AdminColor = value;
		}
	}

	[DebuggerNonUserCode]
	public ChatOGR()
	{
		((Form)this).add_Load((EventHandler)ChatOGR_Load);
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
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected O, but got Unknown
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected O, but got Unknown
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected O, but got Unknown
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected O, but got Unknown
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected O, but got Unknown
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Expected O, but got Unknown
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d8: Expected O, but got Unknown
		//IL_09dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e7: Expected O, but got Unknown
		//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Expected O, but got Unknown
		//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Expected O, but got Unknown
		//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc4: Expected O, but got Unknown
		//IL_0c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4c: Expected O, but got Unknown
		//IL_0cd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce0: Expected O, but got Unknown
		//IL_0d5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d65: Expected O, but got Unknown
		//IL_0e02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0c: Expected O, but got Unknown
		//IL_0e98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea2: Expected O, but got Unknown
		//IL_0f37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f41: Expected O, but got Unknown
		//IL_0ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffd: Expected O, but got Unknown
		//IL_1086: Unknown result type (might be due to invalid IL or missing references)
		//IL_1090: Expected O, but got Unknown
		//IL_1125: Unknown result type (might be due to invalid IL or missing references)
		//IL_112f: Expected O, but got Unknown
		//IL_121e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1228: Expected O, but got Unknown
		//IL_12a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b2: Expected O, but got Unknown
		//IL_13af: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b9: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ChatOGR));
		GroupBox1 = new GroupBox();
		ClientStatut = new TextBox();
		ClientID = new TextBox();
		AdminStatut = new TextBox();
		AdminID = new TextBox();
		FormTitle = new TextBox();
		Label8 = new Label();
		Label7 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		GroupBox2 = new GroupBox();
		ClientColor = new TextBox();
		AdminColor = new TextBox();
		ColorC = new Button();
		ColorD = new Button();
		Label9 = new Label();
		Label10 = new Label();
		GroupBox4 = new GroupBox();
		RadioButton3 = new RadioButton();
		RadioButton4 = new RadioButton();
		GroupBox3 = new GroupBox();
		RadioButton2 = new RadioButton();
		RadioButton1 = new RadioButton();
		Label3 = new Label();
		StartChat = new Button();
		ColorDialog1 = new ColorDialog();
		Exitt = new Button();
		((Control)GroupBox1).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((Control)GroupBox4).SuspendLayout();
		((Control)GroupBox3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox1).get_Controls().Add((Control)(object)ClientStatut);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ClientID);
		((Control)GroupBox1).get_Controls().Add((Control)(object)AdminStatut);
		((Control)GroupBox1).get_Controls().Add((Control)(object)AdminID);
		((Control)GroupBox1).get_Controls().Add((Control)(object)FormTitle);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label8);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label7);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GroupBox groupBox = GroupBox1;
		Point location = new Point(11, 12);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		Size size = new Size(314, 200);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(0);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("ID - Statut");
		((Control)ClientStatut).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox clientStatut = ClientStatut;
		location = new Point(137, 163);
		((Control)clientStatut).set_Location(location);
		((Control)ClientStatut).set_Name("ClientStatut");
		TextBox clientStatut2 = ClientStatut;
		size = new Size(158, 21);
		((Control)clientStatut2).set_Size(size);
		((Control)ClientStatut).set_TabIndex(11);
		ClientStatut.set_Text("Feeling angry !");
		((Control)ClientID).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox clientID = ClientID;
		location = new Point(137, 139);
		((Control)clientID).set_Location(location);
		((Control)ClientID).set_Name("ClientID");
		TextBox clientID2 = ClientID;
		size = new Size(158, 21);
		((Control)clientID2).set_Size(size);
		((Control)ClientID).set_TabIndex(10);
		ClientID.set_Text("Client");
		((Control)AdminStatut).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox adminStatut = AdminStatut;
		location = new Point(137, 91);
		((Control)adminStatut).set_Location(location);
		((Control)AdminStatut).set_Name("AdminStatut");
		TextBox adminStatut2 = AdminStatut;
		size = new Size(158, 21);
		((Control)adminStatut2).set_Size(size);
		((Control)AdminStatut).set_TabIndex(9);
		AdminStatut.set_Text("Feeling Happy !");
		((Control)AdminID).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox adminID = AdminID;
		location = new Point(137, 66);
		((Control)adminID).set_Location(location);
		((Control)AdminID).set_Name("AdminID");
		TextBox adminID2 = AdminID;
		size = new Size(158, 21);
		((Control)adminID2).set_Size(size);
		((Control)AdminID).set_TabIndex(8);
		AdminID.set_Text("Admin");
		((Control)FormTitle).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox formTitle = FormTitle;
		location = new Point(85, 25);
		((Control)formTitle).set_Location(location);
		((Control)FormTitle).set_Name("FormTitle");
		TextBox formTitle2 = FormTitle;
		size = new Size(210, 21);
		((Control)formTitle2).set_Size(size);
		((Control)FormTitle).set_TabIndex(7);
		FormTitle.set_Text("Live Chat !");
		Label8.set_AutoSize(true);
		((Control)Label8).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label8;
		location = new Point(6, 166);
		((Control)label).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label2 = Label8;
		size = new Size(87, 13);
		((Control)label2).set_Size(size);
		((Control)Label8).set_TabIndex(6);
		Label8.set_Text("Client Statut :");
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label3 = Label7;
		location = new Point(6, 141);
		((Control)label3).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label4 = Label7;
		size = new Size(67, 13);
		((Control)label4).set_Size(size);
		((Control)Label7).set_TabIndex(5);
		Label7.set_Text("Client ID :");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label5 = Label6;
		location = new Point(6, 94);
		((Control)label5).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label6 = Label6;
		size = new Size(131, 13);
		((Control)label6).set_Size(size);
		((Control)Label6).set_TabIndex(4);
		Label6.set_Text("Administrator Statut :");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label7 = Label5;
		location = new Point(6, 69);
		((Control)label7).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label8 = Label5;
		size = new Size(111, 13);
		((Control)label8).set_Size(size);
		((Control)Label5).set_TabIndex(3);
		Label5.set_Text("Administrator ID :");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label9 = Label4;
		location = new Point(6, 28);
		((Control)label9).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label10 = Label4;
		size = new Size(73, 13);
		((Control)label10).set_Size(size);
		((Control)Label4).set_TabIndex(2);
		Label4.set_Text("Form Title :");
		Label2.set_AutoSize(true);
		Label label11 = Label2;
		location = new Point(6, 117);
		((Control)label11).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label12 = Label2;
		size = new Size(195, 14);
		((Control)label12).set_Size(size);
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("ــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ");
		Label1.set_AutoSize(true);
		Label label13 = Label1;
		location = new Point(6, 46);
		((Control)label13).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label14 = Label1;
		size = new Size(195, 14);
		((Control)label14).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("ــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ");
		((Control)GroupBox2).get_Controls().Add((Control)(object)ClientColor);
		((Control)GroupBox2).get_Controls().Add((Control)(object)AdminColor);
		((Control)GroupBox2).get_Controls().Add((Control)(object)ColorC);
		((Control)GroupBox2).get_Controls().Add((Control)(object)ColorD);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label9);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label10);
		((Control)GroupBox2).get_Controls().Add((Control)(object)GroupBox4);
		((Control)GroupBox2).get_Controls().Add((Control)(object)GroupBox3);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox2).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GroupBox groupBox3 = GroupBox2;
		location = new Point(331, 12);
		((Control)groupBox3).set_Location(location);
		((Control)GroupBox2).set_Name("GroupBox2");
		GroupBox groupBox4 = GroupBox2;
		size = new Size(314, 200);
		((Control)groupBox4).set_Size(size);
		((Control)GroupBox2).set_TabIndex(1);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("DP - Colors");
		((TextBoxBase)ClientColor).set_BackColor(Color.White);
		((Control)ClientColor).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)ClientColor).set_ForeColor(Color.Green);
		TextBox clientColor = ClientColor;
		location = new Point(102, 110);
		((Control)clientColor).set_Location(location);
		((Control)ClientColor).set_Name("ClientColor");
		((TextBoxBase)ClientColor).set_ReadOnly(true);
		TextBox clientColor2 = ClientColor;
		size = new Size(168, 21);
		((Control)clientColor2).set_Size(size);
		((Control)ClientColor).set_TabIndex(13);
		ClientColor.set_Text("Text");
		((TextBoxBase)AdminColor).set_BackColor(Color.White);
		((Control)AdminColor).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)AdminColor).set_ForeColor(Color.MidnightBlue);
		TextBox adminColor = AdminColor;
		location = new Point(146, 18);
		((Control)adminColor).set_Location(location);
		((Control)AdminColor).set_Name("AdminColor");
		((TextBoxBase)AdminColor).set_ReadOnly(true);
		TextBox adminColor2 = AdminColor;
		size = new Size(124, 21);
		((Control)adminColor2).set_Size(size);
		((Control)AdminColor).set_TabIndex(12);
		AdminColor.set_Text("Text");
		((Control)ColorC).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ButtonBase)ColorC).set_Image((Image)(object)Resources.Letter_C_blue_icon1);
		Button colorC = ColorC;
		location = new Point(276, 108);
		((Control)colorC).set_Location(location);
		((Control)ColorC).set_Name("ColorC");
		Button colorC2 = ColorC;
		size = new Size(32, 23);
		((Control)colorC2).set_Size(size);
		((Control)ColorC).set_TabIndex(11);
		((ButtonBase)ColorC).set_UseVisualStyleBackColor(true);
		((Control)ColorD).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ButtonBase)ColorD).set_Image((Image)(object)Resources._1487245559_Untitled_2_26);
		Button colorD = ColorD;
		location = new Point(277, 16);
		((Control)colorD).set_Location(location);
		((Control)ColorD).set_Name("ColorD");
		Button colorD2 = ColorD;
		size = new Size(32, 23);
		((Control)colorD2).set_Size(size);
		((Control)ColorD).set_TabIndex(10);
		((ButtonBase)ColorD).set_UseVisualStyleBackColor(true);
		Label9.set_AutoSize(true);
		((Control)Label9).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label15 = Label9;
		location = new Point(12, 113);
		((Control)label15).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label16 = Label9;
		size = new Size(84, 13);
		((Control)label16).set_Size(size);
		((Control)Label9).set_TabIndex(9);
		Label9.set_Text("Client Color :");
		Label10.set_AutoSize(true);
		((Control)Label10).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label17 = Label10;
		location = new Point(12, 23);
		((Control)label17).set_Location(location);
		((Control)Label10).set_Name("Label10");
		Label label18 = Label10;
		size = new Size(128, 13);
		((Control)label18).set_Size(size);
		((Control)Label10).set_TabIndex(8);
		Label10.set_Text("Administrator Color :");
		((Control)GroupBox4).get_Controls().Add((Control)(object)RadioButton3);
		((Control)GroupBox4).get_Controls().Add((Control)(object)RadioButton4);
		((Control)GroupBox4).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GroupBox groupBox5 = GroupBox4;
		location = new Point(15, 139);
		((Control)groupBox5).set_Location(location);
		((Control)GroupBox4).set_Name("GroupBox4");
		GroupBox groupBox6 = GroupBox4;
		size = new Size(293, 47);
		((Control)groupBox6).set_Size(size);
		((Control)GroupBox4).set_TabIndex(3);
		GroupBox4.set_TabStop(false);
		GroupBox4.set_Text("Client DP");
		((ButtonBase)RadioButton3).set_AutoSize(true);
		((Control)RadioButton3).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		RadioButton radioButton = RadioButton3;
		location = new Point(197, 21);
		((Control)radioButton).set_Location(location);
		((Control)RadioButton3).set_Name("RadioButton3");
		RadioButton radioButton2 = RadioButton3;
		size = new Size(69, 17);
		((Control)radioButton2).set_Size(size);
		((Control)RadioButton3).set_TabIndex(3);
		((ButtonBase)RadioButton3).set_Text("Custom");
		((ButtonBase)RadioButton3).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton4).set_AutoSize(true);
		RadioButton4.set_Checked(true);
		((Control)RadioButton4).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		RadioButton radioButton3 = RadioButton4;
		location = new Point(15, 21);
		((Control)radioButton3).set_Location(location);
		((Control)RadioButton4).set_Name("RadioButton4");
		RadioButton radioButton4 = RadioButton4;
		size = new Size(66, 17);
		((Control)radioButton4).set_Size(size);
		((Control)RadioButton4).set_TabIndex(2);
		RadioButton4.set_TabStop(true);
		((ButtonBase)RadioButton4).set_Text("Default");
		((ButtonBase)RadioButton4).set_UseVisualStyleBackColor(true);
		((Control)GroupBox3).get_Controls().Add((Control)(object)RadioButton2);
		((Control)GroupBox3).get_Controls().Add((Control)(object)RadioButton1);
		((Control)GroupBox3).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GroupBox groupBox7 = GroupBox3;
		location = new Point(15, 45);
		((Control)groupBox7).set_Location(location);
		((Control)GroupBox3).set_Name("GroupBox3");
		GroupBox groupBox8 = GroupBox3;
		size = new Size(293, 44);
		((Control)groupBox8).set_Size(size);
		((Control)GroupBox3).set_TabIndex(2);
		GroupBox3.set_TabStop(false);
		GroupBox3.set_Text("Administrator DP");
		((ButtonBase)RadioButton2).set_AutoSize(true);
		((Control)RadioButton2).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		RadioButton radioButton5 = RadioButton2;
		location = new Point(197, 17);
		((Control)radioButton5).set_Location(location);
		((Control)RadioButton2).set_Name("RadioButton2");
		RadioButton radioButton6 = RadioButton2;
		size = new Size(69, 17);
		((Control)radioButton6).set_Size(size);
		((Control)RadioButton2).set_TabIndex(1);
		((ButtonBase)RadioButton2).set_Text("Custom");
		((ButtonBase)RadioButton2).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton1).set_AutoSize(true);
		RadioButton1.set_Checked(true);
		((Control)RadioButton1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		RadioButton radioButton7 = RadioButton1;
		location = new Point(15, 17);
		((Control)radioButton7).set_Location(location);
		((Control)RadioButton1).set_Name("RadioButton1");
		RadioButton radioButton8 = RadioButton1;
		size = new Size(66, 17);
		((Control)radioButton8).set_Size(size);
		((Control)RadioButton1).set_TabIndex(0);
		RadioButton1.set_TabStop(true);
		((ButtonBase)RadioButton1).set_Text("Default");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
		Label3.set_AutoSize(true);
		Label label19 = Label3;
		location = new Point(6, 88);
		((Control)label19).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label20 = Label3;
		size = new Size(195, 14);
		((Control)label20).set_Size(size);
		((Control)Label3).set_TabIndex(1);
		Label3.set_Text("ــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ");
		((Control)StartChat).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button startChat = StartChat;
		location = new Point(571, 218);
		((Control)startChat).set_Location(location);
		((Control)StartChat).set_Name("StartChat");
		Button startChat2 = StartChat;
		size = new Size(75, 23);
		((Control)startChat2).set_Size(size);
		((Control)StartChat).set_TabIndex(2);
		((ButtonBase)StartChat).set_Text("Start");
		((ButtonBase)StartChat).set_UseVisualStyleBackColor(true);
		((Control)Exitt).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button exitt = Exitt;
		location = new Point(490, 218);
		((Control)exitt).set_Location(location);
		((Control)Exitt).set_Name("Exitt");
		Button exitt2 = Exitt;
		size = new Size(75, 23);
		((Control)exitt2).set_Size(size);
		((Control)Exitt).set_TabIndex(3);
		((ButtonBase)Exitt).set_Text("Exit");
		((ButtonBase)Exitt).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(656, 246);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Exitt);
		((Control)this).get_Controls().Add((Control)(object)StartChat);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ChatOGR");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("CH_OP");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)GroupBox4).ResumeLayout(false);
		((Control)GroupBox4).PerformLayout();
		((Control)GroupBox3).ResumeLayout(false);
		((Control)GroupBox3).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void CD_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		try
		{
			if ((int)((CommonDialog)ColorDialog1).ShowDialog() == 1)
			{
				MC = ColorDialog1.get_Color().ToArgb().ToString();
				((TextBoxBase)AdminColor).set_ForeColor(Color.FromArgb(int.Parse(MC)));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void CD2_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		try
		{
			if ((int)((CommonDialog)ColorDialog1).ShowDialog() == 1)
			{
				CCS = ColorDialog1.get_Color().ToArgb().ToString();
				((TextBoxBase)ClientColor).set_ForeColor(Color.FromArgb(int.Parse(CCS)));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (RadioButton2.get_Checked())
		{
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).set_Title("Select your display picture");
			((FileDialog)val).set_Filter("Display picture |*.png");
			((CommonDialog)val).ShowDialog();
			try
			{
				ADP = Convert.ToBase64String(File.ReadAllBytes(((FileDialog)val).get_FileName()));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				RadioButton1.set_Checked(true);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void RadioButton3_CheckedChanged(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (RadioButton3.get_Checked())
		{
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).set_Title("Select client display picture");
			((FileDialog)val).set_Filter("Display picture |*.png");
			((CommonDialog)val).ShowDialog();
			try
			{
				CDP = Convert.ToBase64String(File.ReadAllBytes(((FileDialog)val).get_FileName()));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				RadioButton4.set_Checked(true);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void NE_Click(object sender, EventArgs e)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if ((FormTitle.get_Text().Length == 0) | (AdminID.get_Text().Length == 0) | (AdminStatut.get_Text().Length == 0) | (ClientID.get_Text().Length == 0) | (ClientStatut.get_Text().Length == 0))
		{
			MessageBox.Show("You must add all information!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		ChatGR chatGR = new ChatGR();
		chatGR.Sock = Sock;
		((Control)chatGR).set_Name("Chat" + OS);
		((Form)chatGR).set_Text("[ Chating With ][ " + FTT + " | " + MyProject.Forms.FrmMAINGR.s.IP(ref Sock) + " ]");
		chatGR.Sock = Sock;
		chatGR.MeColor = ((TextBoxBase)AdminColor).get_ForeColor();
		chatGR.ClinetColor = ((TextBoxBase)ClientColor).get_ForeColor();
		chatGR.MeColorString = chatGR.MeColor.ToArgb().ToString();
		chatGR.ClientColorString = chatGR.ClinetColor.ToArgb().ToString();
		chatGR.ID = SocketServer.Encode(AdminID.get_Text()).ToString();
		chatGR.CID = SocketServer.Encode(ClientID.get_Text()).ToString();
		chatGR.FT = SocketServer.Encode(FormTitle.get_Text()).ToString();
		chatGR.Label1.set_Text("ID : " + ClientID.get_Text());
		chatGR.Label2.set_Text("Status : " + ClientStatut.get_Text());
		chatGR.ASS = SocketServer.Encode(AdminStatut.get_Text()).ToString();
		if ((!RadioButton4.get_Checked() && Operators.CompareString(CDP, (string)null, false) == 0) ? true : false)
		{
			chatGR.CLDP = CDP;
			MyProject.Forms.FrmMAINGR.s.Send(Sock, "CLDP" + MyProject.Forms.FrmMAINGR.Key + CDP + MyProject.Forms.FrmMAINGR.Key + "True");
		}
		if ((!RadioButton1.get_Checked() && Operators.CompareString(ADP, (string)null, false) == 0) ? true : false)
		{
			chatGR.ADP = ADP;
			MyProject.Forms.FrmMAINGR.s.Send(Sock, "ADP" + MyProject.Forms.FrmMAINGR.Key + ADP + MyProject.Forms.FrmMAINGR.Key + "True");
		}
		chatGR.OS = OS;
		chatGR.Devices = Devices.ToString();
		((Control)chatGR).Show();
		((Form)this).Close();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void ChatOGR_Load(object sender, EventArgs e)
	{
	}
}
