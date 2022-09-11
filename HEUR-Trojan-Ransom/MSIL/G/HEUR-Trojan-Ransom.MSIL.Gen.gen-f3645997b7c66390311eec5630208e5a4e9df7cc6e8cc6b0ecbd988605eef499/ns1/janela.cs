using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using ns0;

namespace ns1;

[DesignerGenerated]
public class janela : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PanelTela")]
	private Panel _PanelTela;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("GroupBox3")]
	private GroupBox _GroupBox3;

	[AccessedThroughProperty("GroupBox4")]
	private GroupBox _GroupBox4;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	[AccessedThroughProperty("PictureBox8")]
	private PictureBox _PictureBox8;

	[AccessedThroughProperty("LabelStatusInternet")]
	private Label _LabelStatusInternet;

	[AccessedThroughProperty("LabelDataExpiracao")]
	private Label _LabelDataExpiracao;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("LinkLabel2")]
	private LinkLabel _LinkLabel2;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("NotPause")]
	private Timer _NotPause;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox9")]
	private PictureBox _PictureBox9;

	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("RadioButtonDesativarFirewall")]
	private RadioButton _RadioButtonDesativarFirewall;

	[AccessedThroughProperty("RadioButtonAtivarFirewall")]
	private RadioButton _RadioButtonAtivarFirewall;

	[AccessedThroughProperty("RadioButtonDesativarPTR")]
	private RadioButton _RadioButtonDesativarPTR;

	[AccessedThroughProperty("RadioButtonAtivarPTR")]
	private RadioButton _RadioButtonAtivarPTR;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("PictureBoxEmRisco")]
	private PictureBox _PictureBoxEmRisco;

	[AccessedThroughProperty("PictureBoxProtegido")]
	private PictureBox _PictureBoxProtegido;

	[AccessedThroughProperty("PictureBoxAtencao")]
	private PictureBox _PictureBoxAtencao;

	[AccessedThroughProperty("PanelTelaError")]
	private Panel _PanelTelaError;

	[AccessedThroughProperty("LinkLabel4")]
	private LinkLabel _LinkLabel4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("LabelDataHoje")]
	private Label _LabelDataHoje;

	internal virtual Panel PanelTela
	{
		[DebuggerNonUserCode]
		get
		{
			return _PanelTela;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PanelTela = value;
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

	internal virtual Button Button4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button4_Click;
			if (_Button4 != null)
			{
				((Control)_Button4).remove_Click(eventHandler);
			}
			_Button4 = value;
			if (_Button4 != null)
			{
				((Control)_Button4).add_Click(eventHandler);
			}
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
			_Button1 = value;
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

	internal virtual PictureBox PictureBox8
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox8 = value;
		}
	}

	internal virtual Label LabelStatusInternet
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelStatusInternet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelStatusInternet = value;
		}
	}

	internal virtual Label LabelDataExpiracao
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelDataExpiracao;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelDataExpiracao = value;
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

	internal virtual LinkLabel LinkLabel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(LinkLabel2_LinkClicked);
			if (_LinkLabel2 != null)
			{
				_LinkLabel2.remove_LinkClicked(val);
			}
			_LinkLabel2 = value;
			if (_LinkLabel2 != null)
			{
				_LinkLabel2.add_LinkClicked(val);
			}
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
			EventHandler eventHandler = PictureBox4_Click;
			if (_PictureBox4 != null)
			{
				((Control)_PictureBox4).remove_Click(eventHandler);
			}
			_PictureBox4 = value;
			if (_PictureBox4 != null)
			{
				((Control)_PictureBox4).add_Click(eventHandler);
			}
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
			EventHandler eventHandler = PictureBox3_Click;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).remove_Click(eventHandler);
			}
			_PictureBox3 = value;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).add_Click(eventHandler);
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

	internal virtual PictureBox PictureBox9
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox9 = value;
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

	internal virtual RadioButton RadioButtonDesativarFirewall
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButtonDesativarFirewall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButtonDesativarFirewall_CheckedChanged;
			if (_RadioButtonDesativarFirewall != null)
			{
				_RadioButtonDesativarFirewall.remove_CheckedChanged(eventHandler);
			}
			_RadioButtonDesativarFirewall = value;
			if (_RadioButtonDesativarFirewall != null)
			{
				_RadioButtonDesativarFirewall.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton RadioButtonAtivarFirewall
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButtonAtivarFirewall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButtonAtivarFirewall_CheckedChanged;
			if (_RadioButtonAtivarFirewall != null)
			{
				_RadioButtonAtivarFirewall.remove_CheckedChanged(eventHandler);
			}
			_RadioButtonAtivarFirewall = value;
			if (_RadioButtonAtivarFirewall != null)
			{
				_RadioButtonAtivarFirewall.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton RadioButtonDesativarPTR
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButtonDesativarPTR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButtonDesativarPTR_CheckedChanged;
			if (_RadioButtonDesativarPTR != null)
			{
				_RadioButtonDesativarPTR.remove_CheckedChanged(eventHandler);
			}
			_RadioButtonDesativarPTR = value;
			if (_RadioButtonDesativarPTR != null)
			{
				_RadioButtonDesativarPTR.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton RadioButtonAtivarPTR
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButtonAtivarPTR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButtonAtivarPTR_CheckedChanged;
			if (_RadioButtonAtivarPTR != null)
			{
				_RadioButtonAtivarPTR.remove_CheckedChanged(eventHandler);
			}
			_RadioButtonAtivarPTR = value;
			if (_RadioButtonAtivarPTR != null)
			{
				_RadioButtonAtivarPTR.add_CheckedChanged(eventHandler);
			}
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

	internal virtual PictureBox PictureBoxEmRisco
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBoxEmRisco;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBoxEmRisco = value;
		}
	}

	internal virtual PictureBox PictureBoxProtegido
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBoxProtegido;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBoxProtegido = value;
		}
	}

	internal virtual PictureBox PictureBoxAtencao
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBoxAtencao;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBoxAtencao = value;
		}
	}

	internal virtual Panel PanelTelaError
	{
		[DebuggerNonUserCode]
		get
		{
			return _PanelTelaError;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PanelTelaError = value;
		}
	}

	internal virtual LinkLabel LinkLabel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(LinkLabel4_LinkClicked);
			if (_LinkLabel4 != null)
			{
				_LinkLabel4.remove_LinkClicked(val);
			}
			_LinkLabel4 = value;
			if (_LinkLabel4 != null)
			{
				_LinkLabel4.add_LinkClicked(val);
			}
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

	internal virtual Label LabelDataHoje
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelDataHoje;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelDataHoje = value;
		}
	}

	[DebuggerNonUserCode]
	public janela()
	{
		((Form)this).add_Load((EventHandler)janela_Load);
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
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected O, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected O, but got Unknown
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Expected O, but got Unknown
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected O, but got Unknown
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected O, but got Unknown
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected O, but got Unknown
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected O, but got Unknown
		//IL_0a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1e: Expected O, but got Unknown
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5f: Expected O, but got Unknown
		//IL_1092: Unknown result type (might be due to invalid IL or missing references)
		//IL_109c: Expected O, but got Unknown
		//IL_112a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1134: Expected O, but got Unknown
		//IL_11cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d9: Expected O, but got Unknown
		//IL_1274: Unknown result type (might be due to invalid IL or missing references)
		//IL_127e: Expected O, but got Unknown
		//IL_1316: Unknown result type (might be due to invalid IL or missing references)
		//IL_1320: Expected O, but got Unknown
		//IL_13ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f6: Expected O, but got Unknown
		//IL_1485: Unknown result type (might be due to invalid IL or missing references)
		//IL_148f: Expected O, but got Unknown
		//IL_1519: Unknown result type (might be due to invalid IL or missing references)
		//IL_1523: Expected O, but got Unknown
		//IL_15a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15af: Expected O, but got Unknown
		//IL_167a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1684: Expected O, but got Unknown
		//IL_170f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1719: Expected O, but got Unknown
		//IL_17b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17bb: Expected O, but got Unknown
		//IL_1842: Unknown result type (might be due to invalid IL or missing references)
		//IL_184c: Expected O, but got Unknown
		//IL_194b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1955: Expected O, but got Unknown
		//IL_19d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_19df: Expected O, but got Unknown
		//IL_1a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a69: Expected O, but got Unknown
		//IL_1af5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aff: Expected O, but got Unknown
		//IL_1be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf2: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(janela));
		PanelTela = new Panel();
		Label5 = new Label();
		PanelTelaError = new Panel();
		Label10 = new Label();
		Label9 = new Label();
		PictureBoxEmRisco = new PictureBox();
		PictureBoxProtegido = new PictureBox();
		PictureBoxAtencao = new PictureBox();
		Label1 = new Label();
		Panel2 = new Panel();
		PictureBox8 = new PictureBox();
		Label2 = new Label();
		GroupBox2 = new GroupBox();
		LabelDataHoje = new Label();
		LinkLabel1 = new LinkLabel();
		LinkLabel4 = new LinkLabel();
		LabelStatusInternet = new Label();
		LabelDataExpiracao = new Label();
		Label6 = new Label();
		LinkLabel2 = new LinkLabel();
		Label4 = new Label();
		Label3 = new Label();
		GroupBox1 = new GroupBox();
		PictureBox4 = new PictureBox();
		PictureBox3 = new PictureBox();
		PictureBox2 = new PictureBox();
		PictureBox9 = new PictureBox();
		GroupBox4 = new GroupBox();
		RadioButtonDesativarFirewall = new RadioButton();
		PictureBox6 = new PictureBox();
		RadioButtonAtivarFirewall = new RadioButton();
		GroupBox3 = new GroupBox();
		RadioButtonDesativarPTR = new RadioButton();
		RadioButtonAtivarPTR = new RadioButton();
		PictureBox5 = new PictureBox();
		RichTextBox1 = new RichTextBox();
		Button4 = new Button();
		Button3 = new Button();
		Button2 = new Button();
		Button1 = new Button();
		NotPause = new Timer(components);
		((Control)PanelTela).SuspendLayout();
		((ISupportInitialize)PictureBoxEmRisco).BeginInit();
		((ISupportInitialize)PictureBoxProtegido).BeginInit();
		((ISupportInitialize)PictureBoxAtencao).BeginInit();
		((Control)Panel2).SuspendLayout();
		((ISupportInitialize)PictureBox8).BeginInit();
		((Control)GroupBox2).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox9).BeginInit();
		((Control)GroupBox4).SuspendLayout();
		((ISupportInitialize)PictureBox6).BeginInit();
		((Control)GroupBox3).SuspendLayout();
		((ISupportInitialize)PictureBox5).BeginInit();
		((Control)this).SuspendLayout();
		((Control)PanelTela).set_BackColor(Color.Black);
		((Control)PanelTela).get_Controls().Add((Control)(object)Label5);
		((Control)PanelTela).get_Controls().Add((Control)(object)PanelTelaError);
		((Control)PanelTela).get_Controls().Add((Control)(object)Label10);
		((Control)PanelTela).get_Controls().Add((Control)(object)Label9);
		((Control)PanelTela).get_Controls().Add((Control)(object)PictureBoxEmRisco);
		((Control)PanelTela).get_Controls().Add((Control)(object)PictureBoxProtegido);
		((Control)PanelTela).get_Controls().Add((Control)(object)PictureBoxAtencao);
		((Control)PanelTela).set_Dock((DockStyle)1);
		Panel panelTela = PanelTela;
		Point location = new Point(0, 0);
		((Control)panelTela).set_Location(location);
		((Control)PanelTela).set_Name("PanelTela");
		Panel panelTela2 = PanelTela;
		Size size = new Size(962, 128);
		((Control)panelTela2).set_Size(size);
		((Control)PanelTela).set_TabIndex(0);
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.White);
		Label label = Label5;
		location = new Point(191, 80);
		((Control)label).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label2 = Label5;
		size = new Size(308, 24);
		((Control)label2).set_Size(size);
		((Control)Label5).set_TabIndex(35);
		Label5.set_Text("DEMO DUOZ MATRIX TOTAL 6");
		((Control)PanelTelaError).set_BackColor(Color.FromArgb(64, 64, 64));
		Panel panelTelaError = PanelTelaError;
		location = new Point(952, 0);
		((Control)panelTelaError).set_Location(location);
		((Control)PanelTelaError).set_Name("PanelTelaError");
		Panel panelTelaError2 = PanelTelaError;
		size = new Size(10, 125);
		((Control)panelTelaError2).set_Size(size);
		((Control)PanelTelaError).set_TabIndex(34);
		((Control)PanelTelaError).set_Visible(false);
		Label10.set_AutoSize(true);
		((Control)Label10).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label10).set_ForeColor(Color.White);
		Label label3 = Label10;
		location = new Point(192, 64);
		((Control)label3).set_Location(location);
		((Control)Label10).set_Name("Label10");
		Label label4 = Label10;
		size = new Size(182, 16);
		((Control)label4).set_Size(size);
		((Control)Label10).set_TabIndex(32);
		Label10.set_Text("ANTIVIRUS PLUS ONE-X");
		Label9.set_AutoSize(true);
		((Control)Label9).set_Font(new Font("Microsoft Sans Serif", 36f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_ForeColor(Color.White);
		Label label5 = Label9;
		location = new Point(186, 9);
		((Control)label5).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label6 = Label9;
		size = new Size(290, 55);
		((Control)label6).set_Size(size);
		((Control)Label9).set_TabIndex(31);
		Label9.set_Text("SATWNEYT");
		((Control)PictureBoxEmRisco).set_Dock((DockStyle)3);
		PictureBoxEmRisco.set_Image((Image)componentResourceManager.GetObject("PictureBoxEmRisco.Image"));
		PictureBox pictureBoxEmRisco = PictureBoxEmRisco;
		location = new Point(340, 0);
		((Control)pictureBoxEmRisco).set_Location(location);
		((Control)PictureBoxEmRisco).set_Name("PictureBoxEmRisco");
		PictureBox pictureBoxEmRisco2 = PictureBoxEmRisco;
		size = new Size(170, 128);
		((Control)pictureBoxEmRisco2).set_Size(size);
		PictureBoxEmRisco.set_SizeMode((PictureBoxSizeMode)1);
		PictureBoxEmRisco.set_TabIndex(29);
		PictureBoxEmRisco.set_TabStop(false);
		((Control)PictureBoxEmRisco).set_Visible(false);
		((Control)PictureBoxProtegido).set_Dock((DockStyle)3);
		PictureBoxProtegido.set_Image((Image)componentResourceManager.GetObject("PictureBoxProtegido.Image"));
		PictureBox pictureBoxProtegido = PictureBoxProtegido;
		location = new Point(170, 0);
		((Control)pictureBoxProtegido).set_Location(location);
		((Control)PictureBoxProtegido).set_Name("PictureBoxProtegido");
		PictureBox pictureBoxProtegido2 = PictureBoxProtegido;
		size = new Size(170, 128);
		((Control)pictureBoxProtegido2).set_Size(size);
		PictureBoxProtegido.set_SizeMode((PictureBoxSizeMode)1);
		PictureBoxProtegido.set_TabIndex(30);
		PictureBoxProtegido.set_TabStop(false);
		((Control)PictureBoxProtegido).set_Visible(false);
		((Control)PictureBoxAtencao).set_Dock((DockStyle)3);
		PictureBoxAtencao.set_Image((Image)componentResourceManager.GetObject("PictureBoxAtencao.Image"));
		PictureBox pictureBoxAtencao = PictureBoxAtencao;
		location = new Point(0, 0);
		((Control)pictureBoxAtencao).set_Location(location);
		((Control)PictureBoxAtencao).set_Name("PictureBoxAtencao");
		PictureBox pictureBoxAtencao2 = PictureBoxAtencao;
		size = new Size(170, 128);
		((Control)pictureBoxAtencao2).set_Size(size);
		PictureBoxAtencao.set_SizeMode((PictureBoxSizeMode)1);
		PictureBoxAtencao.set_TabIndex(29);
		PictureBoxAtencao.set_TabStop(false);
		((Control)PictureBoxAtencao).set_Visible(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label7 = Label1;
		location = new Point(128, 21);
		((Control)label7).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label8 = Label1;
		size = new Size(253, 25);
		((Control)label8).set_Size(size);
		((Control)Label1).set_TabIndex(6);
		Label1.set_Text("Status do Computador:");
		((Control)Panel2).set_BackColor(Color.White);
		((Control)Panel2).get_Controls().Add((Control)(object)PictureBox8);
		((Control)Panel2).get_Controls().Add((Control)(object)Label2);
		((Control)Panel2).get_Controls().Add((Control)(object)Label1);
		((Control)Panel2).get_Controls().Add((Control)(object)GroupBox2);
		((Control)Panel2).get_Controls().Add((Control)(object)GroupBox1);
		((Control)Panel2).get_Controls().Add((Control)(object)Button4);
		((Control)Panel2).get_Controls().Add((Control)(object)Button3);
		((Control)Panel2).get_Controls().Add((Control)(object)Button2);
		((Control)Panel2).get_Controls().Add((Control)(object)Button1);
		((Control)Panel2).set_Dock((DockStyle)5);
		Panel panel = Panel2;
		location = new Point(0, 128);
		((Control)panel).set_Location(location);
		((Control)Panel2).set_Name("Panel2");
		Panel panel2 = Panel2;
		size = new Size(962, 521);
		((Control)panel2).set_Size(size);
		((Control)Panel2).set_TabIndex(1);
		PictureBox8.set_Image((Image)componentResourceManager.GetObject("PictureBox8.Image"));
		PictureBox pictureBox = PictureBox8;
		location = new Point(51, 6);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox8).set_Name("PictureBox8");
		PictureBox pictureBox2 = PictureBox8;
		size = new Size(58, 50);
		((Control)pictureBox2).set_Size(size);
		PictureBox8.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox8.set_TabIndex(1);
		PictureBox8.set_TabStop(false);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label9 = Label2;
		location = new Point(387, 21);
		((Control)label9).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label10 = Label2;
		size = new Size(112, 25);
		((Control)label10).set_Size(size);
		((Control)Label2).set_TabIndex(7);
		Label2.set_Text("Atenção !");
		((Control)GroupBox2).get_Controls().Add((Control)(object)LabelDataHoje);
		((Control)GroupBox2).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)GroupBox2).get_Controls().Add((Control)(object)LinkLabel4);
		((Control)GroupBox2).get_Controls().Add((Control)(object)LabelStatusInternet);
		((Control)GroupBox2).get_Controls().Add((Control)(object)LabelDataExpiracao);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox2).get_Controls().Add((Control)(object)LinkLabel2);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox2).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GroupBox groupBox = GroupBox2;
		location = new Point(12, 362);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox2).set_Name("GroupBox2");
		GroupBox groupBox2 = GroupBox2;
		size = new Size(938, 147);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox2).set_TabIndex(5);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Assinatura de Renovação");
		LabelDataHoje.set_AutoSize(true);
		Label labelDataHoje = LabelDataHoje;
		location = new Point(209, 42);
		((Control)labelDataHoje).set_Location(location);
		((Control)LabelDataHoje).set_Name("LabelDataHoje");
		Label labelDataHoje2 = LabelDataHoje;
		size = new Size(88, 24);
		((Control)labelDataHoje2).set_Size(size);
		((Control)LabelDataHoje).set_TabIndex(13);
		LabelDataHoje.set_Text("00/00/00");
		((Label)LinkLabel1).set_AutoSize(true);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(694, 102);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(239, 24);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(12);
		LinkLabel1.set_TabStop(true);
		LinkLabel1.set_Text("Visite o nosso site oficial");
		((Label)LinkLabel4).set_AutoSize(true);
		LinkLabel linkLabel3 = LinkLabel4;
		location = new Point(768, 78);
		((Control)linkLabel3).set_Location(location);
		((Control)LinkLabel4).set_Name("LinkLabel4");
		LinkLabel linkLabel4 = LinkLabel4;
		size = new Size(147, 24);
		((Control)linkLabel4).set_Size(size);
		((Control)LinkLabel4).set_TabIndex(11);
		LinkLabel4.set_TabStop(true);
		LinkLabel4.set_Text("Chat Tub Desk");
		LabelStatusInternet.set_AutoSize(true);
		Label labelStatusInternet = LabelStatusInternet;
		location = new Point(209, 110);
		((Control)labelStatusInternet).set_Location(location);
		((Control)LabelStatusInternet).set_Name("LabelStatusInternet");
		Label labelStatusInternet2 = LabelStatusInternet;
		size = new Size(81, 24);
		((Control)labelStatusInternet2).set_Size(size);
		((Control)LabelStatusInternet).set_TabIndex(10);
		LabelStatusInternet.set_Text("Não sei");
		LabelDataExpiracao.set_AutoSize(true);
		((Control)LabelDataExpiracao).set_ForeColor(Color.FromArgb(0, 192, 0));
		Label labelDataExpiracao = LabelDataExpiracao;
		location = new Point(209, 77);
		((Control)labelDataExpiracao).set_Location(location);
		((Control)LabelDataExpiracao).set_Name("LabelDataExpiracao");
		Label labelDataExpiracao2 = LabelDataExpiracao;
		size = new Size(210, 24);
		((Control)labelDataExpiracao2).set_Size(size);
		((Control)LabelDataExpiracao).set_TabIndex(9);
		LabelDataExpiracao.set_Text("Grátis (Nunca Expira)");
		Label6.set_AutoSize(true);
		Label label11 = Label6;
		location = new Point(35, 110);
		((Control)label11).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label12 = Label6;
		size = new Size(178, 24);
		((Control)label12).set_Size(size);
		((Control)Label6).set_TabIndex(7);
		Label6.set_Text("Status de internet:");
		((Label)LinkLabel2).set_AutoSize(true);
		LinkLabel linkLabel5 = LinkLabel2;
		location = new Point(705, 50);
		((Control)linkLabel5).set_Location(location);
		((Control)LinkLabel2).set_Name("LinkLabel2");
		LinkLabel linkLabel6 = LinkLabel2;
		size = new Size(218, 24);
		((Control)linkLabel6).set_Size(size);
		((Control)LinkLabel2).set_TabIndex(3);
		LinkLabel2.set_TabStop(true);
		LinkLabel2.set_Text("Janela de notificações");
		Label4.set_AutoSize(true);
		Label label13 = Label4;
		location = new Point(26, 77);
		((Control)label13).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label14 = Label4;
		size = new Size(187, 24);
		((Control)label14).set_Size(size);
		((Control)Label4).set_TabIndex(1);
		Label4.set_Text("Data de Expiração:");
		Label3.set_AutoSize(true);
		Label label15 = Label3;
		location = new Point(76, 42);
		((Control)label15).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label16 = Label3;
		size = new Size(137, 24);
		((Control)label16).set_Size(size);
		((Control)Label3).set_TabIndex(0);
		Label3.set_Text("Data de Hoje:");
		((Control)GroupBox1).set_BackColor(Color.White);
		((Control)GroupBox1).get_Controls().Add((Control)(object)PictureBox4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)PictureBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)PictureBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)PictureBox9);
		((Control)GroupBox1).get_Controls().Add((Control)(object)GroupBox4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)GroupBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)RichTextBox1);
		((Control)GroupBox1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GroupBox groupBox3 = GroupBox1;
		location = new Point(12, 108);
		((Control)groupBox3).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox4 = GroupBox1;
		size = new Size(938, 248);
		((Control)groupBox4).set_Size(size);
		((Control)GroupBox1).set_TabIndex(4);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Tela Inicial");
		((Control)PictureBox4).set_Cursor(Cursors.get_Hand());
		PictureBox4.set_Image((Image)componentResourceManager.GetObject("PictureBox4.Image"));
		PictureBox pictureBox3 = PictureBox4;
		location = new Point(807, 129);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox4).set_Name("PictureBox4");
		PictureBox pictureBox4 = PictureBox4;
		size = new Size(103, 85);
		((Control)pictureBox4).set_Size(size);
		PictureBox4.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox4.set_TabIndex(41);
		PictureBox4.set_TabStop(false);
		((Control)PictureBox4).set_Tag((object)"Agenda e Quarentena");
		((Control)PictureBox3).set_Cursor(Cursors.get_Hand());
		PictureBox3.set_Image((Image)componentResourceManager.GetObject("PictureBox3.Image"));
		PictureBox pictureBox5 = PictureBox3;
		location = new Point(698, 129);
		((Control)pictureBox5).set_Location(location);
		((Control)PictureBox3).set_Name("PictureBox3");
		PictureBox pictureBox6 = PictureBox3;
		size = new Size(103, 85);
		((Control)pictureBox6).set_Size(size);
		PictureBox3.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox3.set_TabIndex(40);
		PictureBox3.set_TabStop(false);
		((Control)PictureBox3).set_Tag((object)"Proteção de Arquivo");
		((Control)PictureBox2).set_Cursor(Cursors.get_Hand());
		PictureBox2.set_Image((Image)componentResourceManager.GetObject("PictureBox2.Image"));
		PictureBox pictureBox7 = PictureBox2;
		location = new Point(807, 38);
		((Control)pictureBox7).set_Location(location);
		((Control)PictureBox2).set_Name("PictureBox2");
		PictureBox pictureBox8 = PictureBox2;
		size = new Size(103, 85);
		((Control)pictureBox8).set_Size(size);
		PictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox2.set_TabIndex(39);
		PictureBox2.set_TabStop(false);
		((Control)PictureBox2).set_Tag((object)"Varredura e Escaneamento");
		((Control)PictureBox9).set_Cursor(Cursors.get_Default());
		PictureBox9.set_Image((Image)componentResourceManager.GetObject("PictureBox9.Image"));
		PictureBox pictureBox9 = PictureBox9;
		location = new Point(698, 38);
		((Control)pictureBox9).set_Location(location);
		((Control)PictureBox9).set_Name("PictureBox9");
		PictureBox pictureBox10 = PictureBox9;
		size = new Size(103, 85);
		((Control)pictureBox10).set_Size(size);
		PictureBox9.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox9.set_TabIndex(38);
		PictureBox9.set_TabStop(false);
		((Control)PictureBox9).set_Tag((object)"Tela Inicial");
		((Control)GroupBox4).get_Controls().Add((Control)(object)RadioButtonDesativarFirewall);
		((Control)GroupBox4).get_Controls().Add((Control)(object)PictureBox6);
		((Control)GroupBox4).get_Controls().Add((Control)(object)RadioButtonAtivarFirewall);
		((Control)GroupBox4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GroupBox groupBox5 = GroupBox4;
		location = new Point(340, 23);
		((Control)groupBox5).set_Location(location);
		((Control)GroupBox4).set_Name("GroupBox4");
		GroupBox groupBox6 = GroupBox4;
		size = new Size(328, 144);
		((Control)groupBox6).set_Size(size);
		((Control)GroupBox4).set_TabIndex(7);
		GroupBox4.set_TabStop(false);
		GroupBox4.set_Text("Firewall Integrado");
		((ButtonBase)RadioButtonDesativarFirewall).set_AutoSize(true);
		((Control)RadioButtonDesativarFirewall).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		RadioButton radioButtonDesativarFirewall = RadioButtonDesativarFirewall;
		location = new Point(153, 67);
		((Control)radioButtonDesativarFirewall).set_Location(location);
		((Control)RadioButtonDesativarFirewall).set_Name("RadioButtonDesativarFirewall");
		RadioButton radioButtonDesativarFirewall2 = RadioButtonDesativarFirewall;
		size = new Size(131, 33);
		((Control)radioButtonDesativarFirewall2).set_Size(size);
		((Control)RadioButtonDesativarFirewall).set_TabIndex(7);
		RadioButtonDesativarFirewall.set_TabStop(true);
		((ButtonBase)RadioButtonDesativarFirewall).set_Text("Desativar");
		((ButtonBase)RadioButtonDesativarFirewall).set_UseVisualStyleBackColor(true);
		PictureBox6.set_Image((Image)componentResourceManager.GetObject("PictureBox6.Image"));
		PictureBox pictureBox11 = PictureBox6;
		location = new Point(13, 25);
		((Control)pictureBox11).set_Location(location);
		((Control)PictureBox6).set_Name("PictureBox6");
		PictureBox pictureBox12 = PictureBox6;
		size = new Size(125, 103);
		((Control)pictureBox12).set_Size(size);
		PictureBox6.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox6.set_TabIndex(4);
		PictureBox6.set_TabStop(false);
		((ButtonBase)RadioButtonAtivarFirewall).set_AutoSize(true);
		((Control)RadioButtonAtivarFirewall).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		RadioButton radioButtonAtivarFirewall = RadioButtonAtivarFirewall;
		location = new Point(153, 33);
		((Control)radioButtonAtivarFirewall).set_Location(location);
		((Control)RadioButtonAtivarFirewall).set_Name("RadioButtonAtivarFirewall");
		RadioButton radioButtonAtivarFirewall2 = RadioButtonAtivarFirewall;
		size = new Size(90, 33);
		((Control)radioButtonAtivarFirewall2).set_Size(size);
		((Control)RadioButtonAtivarFirewall).set_TabIndex(6);
		RadioButtonAtivarFirewall.set_TabStop(true);
		((ButtonBase)RadioButtonAtivarFirewall).set_Text("Ativar");
		((ButtonBase)RadioButtonAtivarFirewall).set_UseVisualStyleBackColor(true);
		((Control)GroupBox3).get_Controls().Add((Control)(object)RadioButtonDesativarPTR);
		((Control)GroupBox3).get_Controls().Add((Control)(object)RadioButtonAtivarPTR);
		((Control)GroupBox3).get_Controls().Add((Control)(object)PictureBox5);
		((Control)GroupBox3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GroupBox groupBox7 = GroupBox3;
		location = new Point(6, 23);
		((Control)groupBox7).set_Location(location);
		((Control)GroupBox3).set_Name("GroupBox3");
		GroupBox groupBox8 = GroupBox3;
		size = new Size(328, 144);
		((Control)groupBox8).set_Size(size);
		((Control)GroupBox3).set_TabIndex(6);
		GroupBox3.set_TabStop(false);
		GroupBox3.set_Text("Proteção Real");
		((ButtonBase)RadioButtonDesativarPTR).set_AutoSize(true);
		((Control)RadioButtonDesativarPTR).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		RadioButton radioButtonDesativarPTR = RadioButtonDesativarPTR;
		location = new Point(159, 67);
		((Control)radioButtonDesativarPTR).set_Location(location);
		((Control)RadioButtonDesativarPTR).set_Name("RadioButtonDesativarPTR");
		RadioButton radioButtonDesativarPTR2 = RadioButtonDesativarPTR;
		size = new Size(131, 33);
		((Control)radioButtonDesativarPTR2).set_Size(size);
		((Control)RadioButtonDesativarPTR).set_TabIndex(5);
		RadioButtonDesativarPTR.set_TabStop(true);
		((ButtonBase)RadioButtonDesativarPTR).set_Text("Desativar");
		((ButtonBase)RadioButtonDesativarPTR).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButtonAtivarPTR).set_AutoSize(true);
		((Control)RadioButtonAtivarPTR).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		RadioButton radioButtonAtivarPTR = RadioButtonAtivarPTR;
		location = new Point(159, 33);
		((Control)radioButtonAtivarPTR).set_Location(location);
		((Control)RadioButtonAtivarPTR).set_Name("RadioButtonAtivarPTR");
		RadioButton radioButtonAtivarPTR2 = RadioButtonAtivarPTR;
		size = new Size(90, 33);
		((Control)radioButtonAtivarPTR2).set_Size(size);
		((Control)RadioButtonAtivarPTR).set_TabIndex(4);
		RadioButtonAtivarPTR.set_TabStop(true);
		((ButtonBase)RadioButtonAtivarPTR).set_Text("Ativar");
		((ButtonBase)RadioButtonAtivarPTR).set_UseVisualStyleBackColor(true);
		PictureBox5.set_Image((Image)componentResourceManager.GetObject("PictureBox5.Image"));
		PictureBox pictureBox13 = PictureBox5;
		location = new Point(17, 25);
		((Control)pictureBox13).set_Location(location);
		((Control)PictureBox5).set_Name("PictureBox5");
		PictureBox pictureBox14 = PictureBox5;
		size = new Size(125, 103);
		((Control)pictureBox14).set_Size(size);
		PictureBox5.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox5.set_TabIndex(3);
		PictureBox5.set_TabStop(false);
		((TextBoxBase)RichTextBox1).set_BackColor(Color.White);
		RichTextBox richTextBox = RichTextBox1;
		location = new Point(5, 173);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox1).set_Name("RichTextBox1");
		((TextBoxBase)RichTextBox1).set_ReadOnly(true);
		RichTextBox1.set_ScrollBars((RichTextBoxScrollBars)19);
		RichTextBox richTextBox2 = RichTextBox1;
		size = new Size(670, 69);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox1).set_TabIndex(5);
		RichTextBox1.set_Text("");
		((Control)Button4).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button button = Button4;
		location = new Point(646, 62);
		((Control)button).set_Location(location);
		((Control)Button4).set_Name("Button4");
		Button button2 = Button4;
		size = new Size(305, 40);
		((Control)button2).set_Size(size);
		((Control)Button4).set_TabIndex(3);
		((ButtonBase)Button4).set_Text("Agenda e Quarentena");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((Control)Button3).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button button3 = Button3;
		location = new Point(380, 62);
		((Control)button3).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button4 = Button3;
		size = new Size(260, 40);
		((Control)button4).set_Size(size);
		((Control)Button3).set_TabIndex(2);
		((ButtonBase)Button3).set_Text("Proteção de Arquivo");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((Control)Button2).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button button5 = Button2;
		location = new Point(196, 62);
		((Control)button5).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button6 = Button2;
		size = new Size(178, 40);
		((Control)button6).set_Size(size);
		((Control)Button2).set_TabIndex(1);
		((ButtonBase)Button2).set_Text("Varredura");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((Control)Button1).set_Enabled(false);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button button7 = Button1;
		location = new Point(12, 62);
		((Control)button7).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button8 = Button1;
		size = new Size(178, 40);
		((Control)button8).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Tela Inicial");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		NotPause.set_Enabled(true);
		NotPause.set_Interval(1);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(962, 649);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)PanelTela);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		size = new Size(978, 688);
		((Form)this).set_MaximumSize(size);
		size = new Size(978, 688);
		((Form)this).set_MinimumSize(size);
		((Control)this).set_Name("janela");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("SATWNEYT Antivírus Plus One-X 6  (Anti-Ramsonware)");
		((Control)PanelTela).ResumeLayout(false);
		((Control)PanelTela).PerformLayout();
		((ISupportInitialize)PictureBoxEmRisco).EndInit();
		((ISupportInitialize)PictureBoxProtegido).EndInit();
		((ISupportInitialize)PictureBoxAtencao).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((ISupportInitialize)PictureBox8).EndInit();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)GroupBox1).ResumeLayout(false);
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox9).EndInit();
		((Control)GroupBox4).ResumeLayout(false);
		((Control)GroupBox4).PerformLayout();
		((ISupportInitialize)PictureBox6).EndInit();
		((Control)GroupBox3).ResumeLayout(false);
		((Control)GroupBox3).PerformLayout();
		((ISupportInitialize)PictureBox5).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void janela_Load(object sender, EventArgs e)
	{
		NotPause.Start();
		NotPause.set_Enabled(true);
		LabelDataHoje.set_Text(Conversions.ToString(((ServerComputer)MyProject.Computer).get_Clock().get_LocalTime().Day) + "/" + Conversions.ToString(((ServerComputer)MyProject.Computer).get_Clock().get_LocalTime().Month) + "/" + Conversions.ToString(((ServerComputer)MyProject.Computer).get_Clock().get_LocalTime().Year));
		try
		{
			if (NetworkInterface.GetIsNetworkAvailable())
			{
				LabelStatusInternet.set_Text("Conectado");
				((Control)LabelStatusInternet).set_ForeColor(Color.Green);
			}
			else if (NetworkInterface.GetIsNetworkAvailable())
			{
				LabelStatusInternet.set_Text("Desconectado");
				((Control)LabelStatusInternet).set_ForeColor(Color.Red);
			}
			else
			{
				LabelStatusInternet.set_Text("Atenção");
				((Control)LabelStatusInternet).set_ForeColor(Color.Orange);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if ((RadioButtonAtivarPTR.get_Checked() & RadioButtonAtivarFirewall.get_Checked()) | (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\atencao") & !((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\desativar")))
			{
				((Control)PanelTela).set_BackColor(Color.Green);
				Label2.set_Text("Protegido");
				((Control)Label2).set_ForeColor(Color.Green);
				((Control)PictureBoxProtegido).set_Visible(true);
				((Control)PictureBoxAtencao).set_Visible(false);
				((Control)PictureBoxEmRisco).set_Visible(false);
				RadioButtonAtivarPTR.set_Checked(true);
				RadioButtonAtivarFirewall.set_Checked(true);
				RadioButtonDesativarFirewall.set_Checked(false);
				RadioButtonDesativarPTR.set_Checked(false);
				MyProject.Forms.Load2.FileSystemWatcher1.EnableRaisingEvents = true;
				MyProject.Forms.Load2.FirewallLoad.set_Enabled(true);
				MyProject.Forms.Load2.FirewallLoad.Start();
			}
			else if ((RadioButtonAtivarPTR.get_Checked() & RadioButtonDesativarFirewall.get_Checked()) | (RadioButtonDesativarPTR.get_Checked() & RadioButtonAtivarFirewall.get_Checked()) | (((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\atencao") & !((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\desativar")))
			{
				((Control)PanelTela).set_BackColor(Color.Orange);
				Label2.set_Text("Atenção");
				((Control)PictureBoxProtegido).set_Visible(false);
				((Control)PictureBoxAtencao).set_Visible(true);
				((Control)PictureBoxEmRisco).set_Visible(false);
				((Control)Label2).set_ForeColor(Color.Orange);
				RadioButtonAtivarPTR.set_Checked(false);
				RadioButtonAtivarFirewall.set_Checked(false);
				RadioButtonDesativarFirewall.set_Checked(false);
				RadioButtonDesativarPTR.set_Checked(false);
			}
			else
			{
				if (!((!RadioButtonAtivarPTR.get_Checked() & !RadioButtonAtivarFirewall.get_Checked()) | (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\atencao") & ((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\desativar"))))
				{
					return;
				}
				((Control)PanelTela).set_BackColor(Color.Red);
				Label2.set_Text("Em risco");
				((Control)Label2).set_ForeColor(Color.Red);
				RadioButtonAtivarPTR.set_Checked(false);
				RadioButtonAtivarFirewall.set_Checked(false);
				RadioButtonDesativarFirewall.set_Checked(true);
				RadioButtonDesativarPTR.set_Checked(true);
				MyProject.Forms.Load2.FirewallLoad.set_Enabled(false);
				MyProject.Forms.Load2.FirewallLoad.Stop();
				try
				{
					if (!((Control)PanelTelaError).get_Visible())
					{
						((Control)PictureBoxProtegido).set_Visible(false);
						((Control)PictureBoxAtencao).set_Visible(false);
						((Control)PictureBoxEmRisco).set_Visible(true);
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				MyProject.Forms.Load2.FileSystemWatcher1.EnableRaisingEvents = false;
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	private void LinkLabelError_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process process = new Process();
			Process process2 = process;
			process2.StartInfo.FileName = "http://cnectoversy.negocio.site";
			process2.Start();
			process2 = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void NotPause_Tick(object sender, EventArgs e)
	{
		try
		{
			if (NetworkInterface.GetIsNetworkAvailable())
			{
				LabelStatusInternet.set_Text("Conectado");
				((Control)LabelStatusInternet).set_ForeColor(Color.Green);
			}
			else if (NetworkInterface.GetIsNetworkAvailable())
			{
				LabelStatusInternet.set_Text("Desconectado");
				((Control)LabelStatusInternet).set_ForeColor(Color.Red);
			}
			else
			{
				LabelStatusInternet.set_Text("Atenção");
				((Control)LabelStatusInternet).set_ForeColor(Color.Orange);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void PictureBox10_Click(object sender, EventArgs e)
	{
	}

	private void RadioButtonAtivarPTR_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			if ((RadioButtonAtivarPTR.get_Checked() & RadioButtonAtivarFirewall.get_Checked()) | (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\atencao") & !((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\desativar")))
			{
				((Control)PanelTela).set_BackColor(Color.Green);
				Label2.set_Text("Protegido");
				((Control)Label2).set_ForeColor(Color.Green);
				((Control)PictureBoxProtegido).set_Visible(true);
				((Control)PictureBoxAtencao).set_Visible(false);
				((Control)PictureBoxEmRisco).set_Visible(false);
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)5);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\desativar", (DeleteDirectoryOption)5);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)4);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\desativar", (DeleteDirectoryOption)4);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				MyProject.Forms.Load2.FileSystemWatcher1.EnableRaisingEvents = true;
				return;
			}
			if ((RadioButtonAtivarPTR.get_Checked() & RadioButtonDesativarFirewall.get_Checked()) | (RadioButtonDesativarPTR.get_Checked() & RadioButtonAtivarFirewall.get_Checked()) | !((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\desativar"))
			{
				((Control)PanelTela).set_BackColor(Color.Orange);
				Label2.set_Text("Atenção");
				((Control)PictureBoxProtegido).set_Visible(false);
				((Control)PictureBoxAtencao).set_Visible(true);
				((Control)PictureBoxEmRisco).set_Visible(false);
				((Control)Label2).set_ForeColor(Color.Orange);
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\atencao");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\desativar", (DeleteDirectoryOption)5);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\desativar", (DeleteDirectoryOption)4);
					return;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
					return;
				}
			}
			if ((!RadioButtonAtivarPTR.get_Checked() & !RadioButtonAtivarFirewall.get_Checked()) | !((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\atencao"))
			{
				((Control)PanelTela).set_BackColor(Color.Red);
				Label2.set_Text("Em risco");
				((Control)Label2).set_ForeColor(Color.Red);
				((Control)PictureBoxProtegido).set_Visible(false);
				((Control)PictureBoxAtencao).set_Visible(false);
				((Control)PictureBoxEmRisco).set_Visible(true);
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\desativar");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)5);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)4);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				MyProject.Forms.Load2.FileSystemWatcher1.EnableRaisingEvents = false;
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	private void RadioButtonDesativarPTR_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			if ((RadioButtonAtivarPTR.get_Checked() & RadioButtonAtivarFirewall.get_Checked()) | (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\atencao") & !((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\desativar")))
			{
				((Control)PanelTela).set_BackColor(Color.Green);
				Label2.set_Text("Protegido");
				((Control)Label2).set_ForeColor(Color.Green);
				((Control)PictureBoxProtegido).set_Visible(true);
				((Control)PictureBoxAtencao).set_Visible(false);
				((Control)PictureBoxEmRisco).set_Visible(false);
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)5);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\desativar", (DeleteDirectoryOption)5);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)4);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\desativar", (DeleteDirectoryOption)4);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				MyProject.Forms.Load2.FileSystemWatcher1.EnableRaisingEvents = true;
			}
			if ((RadioButtonAtivarPTR.get_Checked() & RadioButtonDesativarFirewall.get_Checked()) | (RadioButtonDesativarPTR.get_Checked() & RadioButtonAtivarFirewall.get_Checked()) | !((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\desativar"))
			{
				((Control)PanelTela).set_BackColor(Color.Orange);
				Label2.set_Text("Atenção");
				((Control)PictureBoxProtegido).set_Visible(false);
				((Control)Label2).set_ForeColor(Color.Orange);
				((Control)PictureBoxAtencao).set_Visible(true);
				((Control)PictureBoxEmRisco).set_Visible(false);
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\atencao");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\desativar", (DeleteDirectoryOption)5);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\desativar", (DeleteDirectoryOption)4);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			if ((!RadioButtonAtivarPTR.get_Checked() & !RadioButtonAtivarFirewall.get_Checked()) | !((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\atencao"))
			{
				((Control)PanelTela).set_BackColor(Color.Red);
				Label2.set_Text("Em risco");
				((Control)Label2).set_ForeColor(Color.Red);
				((Control)PictureBoxProtegido).set_Visible(false);
				((Control)PictureBoxAtencao).set_Visible(false);
				((Control)PictureBoxEmRisco).set_Visible(true);
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\desativar");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)5);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)4);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				MyProject.Forms.Load2.FileSystemWatcher1.EnableRaisingEvents = false;
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	private void RadioButtonAtivarFirewall_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			if ((RadioButtonAtivarPTR.get_Checked() & RadioButtonAtivarFirewall.get_Checked()) | (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\atencao") & !((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\desativar")))
			{
				((Control)PanelTela).set_BackColor(Color.Green);
				Label2.set_Text("Protegido");
				((Control)Label2).set_ForeColor(Color.Green);
				((Control)PictureBoxProtegido).set_Visible(true);
				((Control)PictureBoxAtencao).set_Visible(false);
				((Control)PictureBoxEmRisco).set_Visible(false);
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)5);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\desativar", (DeleteDirectoryOption)5);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)4);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\desativar", (DeleteDirectoryOption)4);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				MyProject.Forms.Load2.FileSystemWatcher1.EnableRaisingEvents = true;
				return;
			}
			if ((RadioButtonAtivarPTR.get_Checked() & RadioButtonDesativarFirewall.get_Checked()) | (RadioButtonDesativarPTR.get_Checked() & RadioButtonAtivarFirewall.get_Checked()) | !((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\desativar"))
			{
				((Control)PanelTela).set_BackColor(Color.Orange);
				Label2.set_Text("Atenção");
				((Control)PictureBoxProtegido).set_Visible(false);
				((Control)PictureBoxAtencao).set_Visible(true);
				((Control)Label2).set_ForeColor(Color.Orange);
				((Control)PictureBoxEmRisco).set_Visible(false);
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\atencao");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\desativar", (DeleteDirectoryOption)5);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\desativar", (DeleteDirectoryOption)4);
					return;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
					return;
				}
			}
			if ((!RadioButtonAtivarPTR.get_Checked() & !RadioButtonAtivarFirewall.get_Checked()) | !((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\atencao"))
			{
				((Control)PanelTela).set_BackColor(Color.Red);
				Label2.set_Text("Em risco");
				((Control)Label2).set_ForeColor(Color.Red);
				((Control)PictureBoxProtegido).set_Visible(false);
				((Control)PictureBoxAtencao).set_Visible(false);
				((Control)PictureBoxEmRisco).set_Visible(true);
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\desativar");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)5);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)4);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				MyProject.Forms.Load2.FileSystemWatcher1.EnableRaisingEvents = false;
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	private void RadioButtonDesativarFirewall_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			if ((RadioButtonAtivarPTR.get_Checked() & RadioButtonAtivarFirewall.get_Checked()) | (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\atencao") & !((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\desativar")))
			{
				((Control)PanelTela).set_BackColor(Color.Green);
				Label2.set_Text("Protegido");
				((Control)Label2).set_ForeColor(Color.Green);
				((Control)PictureBoxProtegido).set_Visible(true);
				((Control)PictureBoxAtencao).set_Visible(false);
				((Control)PictureBoxEmRisco).set_Visible(false);
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)5);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\desativar", (DeleteDirectoryOption)5);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)4);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\desativar", (DeleteDirectoryOption)4);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				MyProject.Forms.Load2.FileSystemWatcher1.EnableRaisingEvents = true;
			}
			if ((RadioButtonAtivarPTR.get_Checked() & RadioButtonDesativarFirewall.get_Checked()) | (RadioButtonDesativarPTR.get_Checked() & RadioButtonAtivarFirewall.get_Checked()) | !((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\desativar"))
			{
				((Control)PanelTela).set_BackColor(Color.Orange);
				Label2.set_Text("Atenção");
				((Control)PictureBoxProtegido).set_Visible(false);
				((Control)PictureBoxAtencao).set_Visible(true);
				((Control)PictureBoxEmRisco).set_Visible(false);
				((Control)Label2).set_ForeColor(Color.Orange);
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\atencao");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\desativar", (DeleteDirectoryOption)5);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\desativar", (DeleteDirectoryOption)4);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			if ((!RadioButtonAtivarPTR.get_Checked() & !RadioButtonAtivarFirewall.get_Checked()) | !((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists("C:\\atencao"))
			{
				((Control)PanelTela).set_BackColor(Color.Red);
				Label2.set_Text("Em risco");
				((Control)Label2).set_ForeColor(Color.Red);
				((Control)PictureBoxProtegido).set_Visible(false);
				((Control)PictureBoxAtencao).set_Visible(false);
				((Control)PictureBoxEmRisco).set_Visible(true);
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\desativar");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)5);
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)4);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				MyProject.Forms.Load2.FileSystemWatcher1.EnableRaisingEvents = false;
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Form)MyProject.Forms.Tools0).ShowDialog();
			((Control)MyProject.Forms.Tools0).set_Visible(true);
			((Form)MyProject.Forms.Tools0).set_WindowState((FormWindowState)0);
			MyProject.Forms.Tools0.TabControl1.SelectTab(0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MyProject.Forms.Tools0.TabControl1.SelectTab(0);
			((Control)MyProject.Forms.Tools0).set_Visible(true);
			((Form)MyProject.Forms.Tools0).set_WindowState((FormWindowState)0);
			ProjectData.ClearProjectError();
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MyProject.Forms.Tools0.TabControl1.SelectTab(1);
			((Form)MyProject.Forms.Tools0).ShowDialog();
			((Control)MyProject.Forms.Tools0).set_Visible(true);
			((Form)MyProject.Forms.Tools0).set_WindowState((FormWindowState)0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MyProject.Forms.Tools0.TabControl1.SelectTab(1);
			((Control)MyProject.Forms.Tools0).set_Visible(true);
			((Form)MyProject.Forms.Tools0).set_WindowState((FormWindowState)0);
			ProjectData.ClearProjectError();
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MyProject.Forms.Tools0.TabControl1.SelectTab(2);
			((Form)MyProject.Forms.Tools0).ShowDialog();
			((Control)MyProject.Forms.Tools0).set_Visible(true);
			((Form)MyProject.Forms.Tools0).set_WindowState((FormWindowState)0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MyProject.Forms.Tools0.TabControl1.SelectTab(2);
			((Control)MyProject.Forms.Tools0).set_Visible(true);
			((Form)MyProject.Forms.Tools0).set_WindowState((FormWindowState)0);
			ProjectData.ClearProjectError();
		}
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Form)MyProject.Forms.Tools0).ShowDialog();
			((Control)MyProject.Forms.Tools0).set_Visible(true);
			((Form)MyProject.Forms.Tools0).set_WindowState((FormWindowState)0);
			MyProject.Forms.Tools0.TabControl1.SelectTab(0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MyProject.Forms.Tools0.TabControl1.SelectTab(0);
			((Control)MyProject.Forms.Tools0).set_Visible(true);
			((Form)MyProject.Forms.Tools0).set_WindowState((FormWindowState)0);
			ProjectData.ClearProjectError();
		}
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MyProject.Forms.Tools0.TabControl1.SelectTab(1);
			((Form)MyProject.Forms.Tools0).ShowDialog();
			((Control)MyProject.Forms.Tools0).set_Visible(true);
			((Form)MyProject.Forms.Tools0).set_WindowState((FormWindowState)0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MyProject.Forms.Tools0.TabControl1.SelectTab(1);
			((Control)MyProject.Forms.Tools0).set_Visible(true);
			((Form)MyProject.Forms.Tools0).set_WindowState((FormWindowState)0);
			ProjectData.ClearProjectError();
		}
	}

	private void PictureBox4_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MyProject.Forms.Tools0.TabControl1.SelectTab(2);
			((Form)MyProject.Forms.Tools0).ShowDialog();
			((Control)MyProject.Forms.Tools0).set_Visible(true);
			((Form)MyProject.Forms.Tools0).set_WindowState((FormWindowState)0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MyProject.Forms.Tools0.TabControl1.SelectTab(2);
			((Control)MyProject.Forms.Tools0).set_Visible(true);
			((Form)MyProject.Forms.Tools0).set_WindowState((FormWindowState)0);
			ProjectData.ClearProjectError();
		}
	}

	private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (NetworkInterface.GetIsNetworkAvailable())
			{
				try
				{
					((Form)MyProject.Forms.chatdesk).ShowDialog();
					((Form)MyProject.Forms.chatdesk).set_WindowState((FormWindowState)0);
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					((Form)MyProject.Forms.chatdesk).set_WindowState((FormWindowState)0);
					((Control)MyProject.Forms.chatdesk).set_Visible(true);
					ProjectData.ClearProjectError();
					return;
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (NetworkInterface.GetIsNetworkAvailable())
			{
				try
				{
					((Form)MyProject.Forms.Notif).ShowDialog();
					((Form)MyProject.Forms.Notif).set_WindowState((FormWindowState)0);
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					((Form)MyProject.Forms.Notif).set_WindowState((FormWindowState)0);
					((Control)MyProject.Forms.Notif).set_Visible(true);
					ProjectData.ClearProjectError();
					return;
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (NetworkInterface.GetIsNetworkAvailable())
			{
				try
				{
					Process process = new Process();
					Process process2 = process;
					process2.StartInfo.FileName = "http://cnectoversy.negocio.site";
					process2.Start();
					process2 = null;
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
			ProjectData.ClearProjectError();
		}
	}
}
