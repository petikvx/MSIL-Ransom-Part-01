using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace ns1;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Hile1")]
	private Label _Hile1;

	[AccessedThroughProperty("Hile2")]
	private Label _Hile2;

	[AccessedThroughProperty("Hile3")]
	private Label _Hile3;

	[AccessedThroughProperty("Hile4")]
	private Label _Hile4;

	[AccessedThroughProperty("Hile7")]
	private Label _Hile7;

	[AccessedThroughProperty("Hile8")]
	private Label _Hile8;

	[AccessedThroughProperty("Hile6")]
	private Label _Hile6;

	[AccessedThroughProperty("Hile5")]
	private Label _Hile5;

	[AccessedThroughProperty("Hile9")]
	private Label _Hile9;

	[AccessedThroughProperty("Hile10")]
	private Label _Hile10;

	[AccessedThroughProperty("Hile11")]
	private Label _Hile11;

	[AccessedThroughProperty("Hile12")]
	private Label _Hile12;

	[AccessedThroughProperty("Hile13")]
	private Label _Hile13;

	[AccessedThroughProperty("Hile14")]
	private Label _Hile14;

	[AccessedThroughProperty("Hile15")]
	private Label _Hile15;

	[AccessedThroughProperty("H9")]
	private Label _H9;

	[AccessedThroughProperty("H10")]
	private Label _H10;

	[AccessedThroughProperty("H11")]
	private Label _H11;

	[AccessedThroughProperty("H12")]
	private Label _H12;

	[AccessedThroughProperty("H13")]
	private Label _H13;

	[AccessedThroughProperty("H14")]
	private Label _H14;

	[AccessedThroughProperty("H15")]
	private Label _H15;

	[AccessedThroughProperty("H7")]
	private Label _H7;

	[AccessedThroughProperty("H8")]
	private Label _H8;

	[AccessedThroughProperty("H6")]
	private Label _H6;

	[AccessedThroughProperty("H5")]
	private Label _H5;

	[AccessedThroughProperty("H3")]
	private Label _H3;

	[AccessedThroughProperty("H4")]
	private Label _H4;

	[AccessedThroughProperty("H2")]
	private Label _H2;

	[AccessedThroughProperty("H1")]
	private Label _H1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("versiyonn")]
	private Label _versiyonn;

	[AccessedThroughProperty("yapicii")]
	private Label _yapicii;

	[AccessedThroughProperty("Panel6")]
	private Panel _Panel6;

	[AccessedThroughProperty("Panelsag")]
	private Panel _Panelsag;

	[AccessedThroughProperty("Panelsol")]
	private Panel _Panelsol;

	[AccessedThroughProperty("logo")]
	private PictureBox _logo;

	[AccessedThroughProperty("Panelust")]
	private Panel _Panelust;

	[AccessedThroughProperty("Panelalt")]
	private Panel _Panelalt;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	[AccessedThroughProperty("bin")]
	private Label _bin;

	[AccessedThroughProperty("obj")]
	private Label _obj;

	[AccessedThroughProperty("csh")]
	private Label _csh;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Timer4")]
	private Timer _Timer4;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("f2pass")]
	private Label _f2pass;

	[AccessedThroughProperty("f2kullanici")]
	private Label _f2kullanici;

	[AccessedThroughProperty("Timer5")]
	private Timer _Timer5;

	[AccessedThroughProperty("bizeulass")]
	private Label _bizeulass;

	[AccessedThroughProperty("Timer6")]
	private Timer _Timer6;

	private string[] options;

	private string text1;

	private string text2;

	private string text3;

	private string text4;

	private string text5;

	private string text6;

	private string text7;

	private string text8;

	private string text9;

	private string text10;

	private string text11;

	private string text12;

	private string text13;

	private string text14;

	private string text15;

	private string phile1;

	private string phile2;

	private string phile3;

	private string phile4;

	private string phile5;

	private string phile6;

	private string phile7;

	private string phile8;

	private string phile9;

	private string phile10;

	private string phile11;

	private string phile12;

	private string phile13;

	private string phile14;

	private string phile15;

	private string vhile1;

	private string vhile2;

	private string vhile3;

	private string vhile4;

	private string vhile5;

	private string vhile6;

	private string vhile7;

	private string vhile8;

	private string vhile9;

	private string vhile10;

	private string vhile11;

	private string vhile12;

	private string vhile13;

	private string vhile14;

	private string vhile15;

	private string mhile1;

	private string mhile2;

	private string mhile3;

	private string mhile4;

	private string mhile5;

	private string mhile6;

	private string mhile7;

	private string mhile8;

	private string mhile9;

	private string mhile10;

	private string mhile11;

	private string mhile12;

	private string mhile13;

	private string mhile14;

	private string mhile15;

	private string resim;

	private string version;

	private string yapimci;

	private string arkaplaan;

	private string renkust;

	private string renkalt;

	private string renksag;

	private string renksol;

	private string arkaolan1;

	private string arkaplan2;

	private string kullanici;

	private string pass;

	private string f2sec;

	private string f2renk;

	private string f2resim;

	private string bizeulas;

	private const string filesolit = "paylasism";

	internal virtual Label Hile1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Hile1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Hile1_Click;
			if (_Hile1 != null)
			{
				((Control)_Hile1).remove_Click(eventHandler);
			}
			_Hile1 = value;
			if (_Hile1 != null)
			{
				((Control)_Hile1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Hile2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Hile2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Hile2 = value;
		}
	}

	internal virtual Label Hile3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Hile3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Hile3 = value;
		}
	}

	internal virtual Label Hile4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Hile4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label4_Click;
			if (_Hile4 != null)
			{
				((Control)_Hile4).remove_Click(eventHandler);
			}
			_Hile4 = value;
			if (_Hile4 != null)
			{
				((Control)_Hile4).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Hile7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Hile7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Hile7 = value;
		}
	}

	internal virtual Label Hile8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Hile8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Hile8 = value;
		}
	}

	internal virtual Label Hile6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Hile6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Hile6 = value;
		}
	}

	internal virtual Label Hile5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Hile5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Hile5 = value;
		}
	}

	internal virtual Label Hile9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Hile9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Hile9 = value;
		}
	}

	internal virtual Label Hile10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Hile10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Hile10 = value;
		}
	}

	internal virtual Label Hile11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Hile11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Hile11 = value;
		}
	}

	internal virtual Label Hile12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Hile12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Hile12 = value;
		}
	}

	internal virtual Label Hile13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Hile13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Hile13 = value;
		}
	}

	internal virtual Label Hile14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Hile14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Hile14 = value;
		}
	}

	internal virtual Label Hile15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Hile15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Hile15 = value;
		}
	}

	internal virtual Label H9
	{
		[DebuggerNonUserCode]
		get
		{
			return _H9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_H9 = value;
		}
	}

	internal virtual Label H10
	{
		[DebuggerNonUserCode]
		get
		{
			return _H10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_H10 = value;
		}
	}

	internal virtual Label H11
	{
		[DebuggerNonUserCode]
		get
		{
			return _H11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_H11 = value;
		}
	}

	internal virtual Label H12
	{
		[DebuggerNonUserCode]
		get
		{
			return _H12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_H12 = value;
		}
	}

	internal virtual Label H13
	{
		[DebuggerNonUserCode]
		get
		{
			return _H13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_H13 = value;
		}
	}

	internal virtual Label H14
	{
		[DebuggerNonUserCode]
		get
		{
			return _H14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_H14 = value;
		}
	}

	internal virtual Label H15
	{
		[DebuggerNonUserCode]
		get
		{
			return _H15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_H15 = value;
		}
	}

	internal virtual Label H7
	{
		[DebuggerNonUserCode]
		get
		{
			return _H7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_H7 = value;
		}
	}

	internal virtual Label H8
	{
		[DebuggerNonUserCode]
		get
		{
			return _H8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_H8 = value;
		}
	}

	internal virtual Label H6
	{
		[DebuggerNonUserCode]
		get
		{
			return _H6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_H6 = value;
		}
	}

	internal virtual Label H5
	{
		[DebuggerNonUserCode]
		get
		{
			return _H5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_H5 = value;
		}
	}

	internal virtual Label H3
	{
		[DebuggerNonUserCode]
		get
		{
			return _H3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_H3 = value;
		}
	}

	internal virtual Label H4
	{
		[DebuggerNonUserCode]
		get
		{
			return _H4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_H4 = value;
		}
	}

	internal virtual Label H2
	{
		[DebuggerNonUserCode]
		get
		{
			return _H2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_H2 = value;
		}
	}

	internal virtual Label H1
	{
		[DebuggerNonUserCode]
		get
		{
			return _H1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_H1 = value;
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

	internal virtual Label versiyonn
	{
		[DebuggerNonUserCode]
		get
		{
			return _versiyonn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_versiyonn = value;
		}
	}

	internal virtual Label yapicii
	{
		[DebuggerNonUserCode]
		get
		{
			return _yapicii;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_yapicii = value;
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

	internal virtual Panel Panelsag
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panelsag;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panelsag = value;
		}
	}

	internal virtual Panel Panelsol
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panelsol;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panelsol = value;
		}
	}

	internal virtual PictureBox logo
	{
		[DebuggerNonUserCode]
		get
		{
			return _logo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox1_Click;
			if (_logo != null)
			{
				((Control)_logo).remove_Click(eventHandler);
			}
			_logo = value;
			if (_logo != null)
			{
				((Control)_logo).add_Click(eventHandler);
			}
		}
	}

	internal virtual Panel Panelust
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panelust;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panelust = value;
		}
	}

	internal virtual Panel Panelalt
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panelalt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panelalt = value;
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

	internal virtual Label bin
	{
		[DebuggerNonUserCode]
		get
		{
			return _bin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bin_Click;
			if (_bin != null)
			{
				((Control)_bin).remove_Click(eventHandler);
			}
			_bin = value;
			if (_bin != null)
			{
				((Control)_bin).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label obj
	{
		[DebuggerNonUserCode]
		get
		{
			return _obj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = obj_Click;
			if (_obj != null)
			{
				((Control)_obj).remove_Click(eventHandler);
			}
			_obj = value;
			if (_obj != null)
			{
				((Control)_obj).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label csh
	{
		[DebuggerNonUserCode]
		get
		{
			return _csh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chs_Click;
			if (_csh != null)
			{
				((Control)_csh).remove_Click(eventHandler);
			}
			_csh = value;
			if (_csh != null)
			{
				((Control)_csh).add_Click(eventHandler);
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
			EventHandler eventHandler = PictureBox1_Click_1;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).remove_Click(eventHandler);
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).add_Click(eventHandler);
			}
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			PaintEventHandler val = new PaintEventHandler(Panel2_Paint);
			if (_Panel2 != null)
			{
				((Control)_Panel2).remove_Paint(val);
			}
			_Panel2 = value;
			if (_Panel2 != null)
			{
				((Control)_Panel2).add_Paint(val);
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

	internal virtual Label f2pass
	{
		[DebuggerNonUserCode]
		get
		{
			return _f2pass;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_f2pass = value;
		}
	}

	internal virtual Label f2kullanici
	{
		[DebuggerNonUserCode]
		get
		{
			return _f2kullanici;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_f2kullanici = value;
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

	internal virtual Label bizeulass
	{
		[DebuggerNonUserCode]
		get
		{
			return _bizeulass;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bizeulass_Click;
			if (_bizeulass != null)
			{
				((Control)_bizeulass).remove_Click(eventHandler);
			}
			_bizeulass = value;
			if (_bizeulass != null)
			{
				((Control)_bizeulass).add_Click(eventHandler);
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

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
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
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_133f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1349: Expected O, but got Unknown
		//IL_13fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1405: Expected O, but got Unknown
		//IL_14a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b1: Expected O, but got Unknown
		//IL_1552: Unknown result type (might be due to invalid IL or missing references)
		//IL_155c: Expected O, but got Unknown
		//IL_15fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1608: Expected O, but got Unknown
		//IL_208f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2099: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Hile1 = new Label();
		Hile2 = new Label();
		Hile3 = new Label();
		Hile4 = new Label();
		Hile7 = new Label();
		Hile8 = new Label();
		Hile6 = new Label();
		Hile5 = new Label();
		Hile9 = new Label();
		Hile10 = new Label();
		Hile11 = new Label();
		Hile12 = new Label();
		Hile13 = new Label();
		Hile14 = new Label();
		Hile15 = new Label();
		H9 = new Label();
		H10 = new Label();
		H11 = new Label();
		H12 = new Label();
		H13 = new Label();
		H14 = new Label();
		H15 = new Label();
		H7 = new Label();
		H8 = new Label();
		H6 = new Label();
		H5 = new Label();
		H3 = new Label();
		H4 = new Label();
		H2 = new Label();
		H1 = new Label();
		bin = new Label();
		this.obj = new Label();
		csh = new Label();
		versiyonn = new Label();
		yapicii = new Label();
		Panel6 = new Panel();
		Panelsag = new Panel();
		Panelsol = new Panel();
		logo = new PictureBox();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Panelust = new Panel();
		Panelalt = new Panel();
		Timer3 = new Timer(components);
		PictureBox1 = new PictureBox();
		Panel2 = new Panel();
		bizeulass = new Label();
		f2pass = new Label();
		f2kullanici = new Label();
		Panel1 = new Panel();
		Label1 = new Label();
		Timer4 = new Timer(components);
		Timer5 = new Timer(components);
		Timer6 = new Timer(components);
		((ISupportInitialize)logo).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel2).SuspendLayout();
		((Control)this).SuspendLayout();
		Hile1.set_AutoSize(true);
		((Control)Hile1).set_BackColor(Color.Transparent);
		((Control)Hile1).set_ForeColor(Color.Lime);
		Label hile = Hile1;
		Point location = new Point(8, 91);
		((Control)hile).set_Location(location);
		((Control)Hile1).set_Name("Hile1");
		Label hile2 = Hile1;
		Size size = new Size(77, 13);
		((Control)hile2).set_Size(size);
		((Control)Hile1).set_TabIndex(0);
		Hile1.set_Text("Güncelleniyor..");
		Hile2.set_AutoSize(true);
		((Control)Hile2).set_BackColor(Color.Transparent);
		((Control)Hile2).set_ForeColor(Color.White);
		Label hile3 = Hile2;
		location = new Point(8, 116);
		((Control)hile3).set_Location(location);
		((Control)Hile2).set_Name("Hile2");
		Label hile4 = Hile2;
		size = new Size(77, 13);
		((Control)hile4).set_Size(size);
		((Control)Hile2).set_TabIndex(1);
		Hile2.set_Text("Güncelleniyor..");
		Hile3.set_AutoSize(true);
		((Control)Hile3).set_BackColor(Color.Transparent);
		((Control)Hile3).set_ForeColor(Color.White);
		Label hile5 = Hile3;
		location = new Point(8, 138);
		((Control)hile5).set_Location(location);
		((Control)Hile3).set_Name("Hile3");
		Label hile6 = Hile3;
		size = new Size(77, 13);
		((Control)hile6).set_Size(size);
		((Control)Hile3).set_TabIndex(3);
		Hile3.set_Text("Güncelleniyor..");
		Hile4.set_AutoSize(true);
		((Control)Hile4).set_BackColor(Color.Transparent);
		((Control)Hile4).set_ForeColor(Color.White);
		Label hile7 = Hile4;
		location = new Point(8, 163);
		((Control)hile7).set_Location(location);
		((Control)Hile4).set_Name("Hile4");
		Label hile8 = Hile4;
		size = new Size(77, 13);
		((Control)hile8).set_Size(size);
		((Control)Hile4).set_TabIndex(2);
		Hile4.set_Text("Güncelleniyor..");
		Hile7.set_AutoSize(true);
		((Control)Hile7).set_BackColor(Color.Transparent);
		((Control)Hile7).set_ForeColor(Color.White);
		Label hile9 = Hile7;
		location = new Point(8, 231);
		((Control)hile9).set_Location(location);
		((Control)Hile7).set_Name("Hile7");
		Label hile10 = Hile7;
		size = new Size(77, 13);
		((Control)hile10).set_Size(size);
		((Control)Hile7).set_TabIndex(7);
		Hile7.set_Text("Güncelleniyor..");
		Hile8.set_AutoSize(true);
		((Control)Hile8).set_BackColor(Color.Transparent);
		((Control)Hile8).set_ForeColor(Color.White);
		Label hile11 = Hile8;
		location = new Point(8, 256);
		((Control)hile11).set_Location(location);
		((Control)Hile8).set_Name("Hile8");
		Label hile12 = Hile8;
		size = new Size(77, 13);
		((Control)hile12).set_Size(size);
		((Control)Hile8).set_TabIndex(6);
		Hile8.set_Text("Güncelleniyor..");
		Hile6.set_AutoSize(true);
		((Control)Hile6).set_BackColor(Color.Transparent);
		((Control)Hile6).set_ForeColor(Color.White);
		Label hile13 = Hile6;
		location = new Point(8, 209);
		((Control)hile13).set_Location(location);
		((Control)Hile6).set_Name("Hile6");
		Label hile14 = Hile6;
		size = new Size(77, 13);
		((Control)hile14).set_Size(size);
		((Control)Hile6).set_TabIndex(5);
		Hile6.set_Text("Güncelleniyor..");
		Hile5.set_AutoSize(true);
		((Control)Hile5).set_BackColor(Color.Transparent);
		((Control)Hile5).set_ForeColor(Color.White);
		Label hile15 = Hile5;
		location = new Point(8, 184);
		((Control)hile15).set_Location(location);
		((Control)Hile5).set_Name("Hile5");
		Label hile16 = Hile5;
		size = new Size(77, 13);
		((Control)hile16).set_Size(size);
		((Control)Hile5).set_TabIndex(4);
		Hile5.set_Text("Güncelleniyor..");
		Hile9.set_AutoSize(true);
		((Control)Hile9).set_BackColor(Color.Transparent);
		((Control)Hile9).set_ForeColor(Color.White);
		Label hile17 = Hile9;
		location = new Point(8, 279);
		((Control)hile17).set_Location(location);
		((Control)Hile9).set_Name("Hile9");
		Label hile18 = Hile9;
		size = new Size(77, 13);
		((Control)hile18).set_Size(size);
		((Control)Hile9).set_TabIndex(15);
		Hile9.set_Text("Güncelleniyor..");
		Hile10.set_AutoSize(true);
		((Control)Hile10).set_BackColor(Color.Transparent);
		((Control)Hile10).set_ForeColor(Color.White);
		Label hile19 = Hile10;
		location = new Point(8, 304);
		((Control)hile19).set_Location(location);
		((Control)Hile10).set_Name("Hile10");
		Label hile20 = Hile10;
		size = new Size(77, 13);
		((Control)hile20).set_Size(size);
		((Control)Hile10).set_TabIndex(14);
		Hile10.set_Text("Güncelleniyor..");
		Hile11.set_AutoSize(true);
		((Control)Hile11).set_BackColor(Color.Transparent);
		((Control)Hile11).set_ForeColor(Color.White);
		Label hile21 = Hile11;
		location = new Point(8, 328);
		((Control)hile21).set_Location(location);
		((Control)Hile11).set_Name("Hile11");
		Label hile22 = Hile11;
		size = new Size(77, 13);
		((Control)hile22).set_Size(size);
		((Control)Hile11).set_TabIndex(13);
		Hile11.set_Text("Güncelleniyor..");
		Hile12.set_AutoSize(true);
		((Control)Hile12).set_BackColor(Color.Transparent);
		((Control)Hile12).set_ForeColor(Color.White);
		Label hile23 = Hile12;
		location = new Point(8, 355);
		((Control)hile23).set_Location(location);
		((Control)Hile12).set_Name("Hile12");
		Label hile24 = Hile12;
		size = new Size(77, 13);
		((Control)hile24).set_Size(size);
		((Control)Hile12).set_TabIndex(12);
		Hile12.set_Text("Güncelleniyor..");
		Hile13.set_AutoSize(true);
		((Control)Hile13).set_BackColor(Color.Transparent);
		((Control)Hile13).set_ForeColor(Color.White);
		Label hile25 = Hile13;
		location = new Point(8, 383);
		((Control)hile25).set_Location(location);
		((Control)Hile13).set_Name("Hile13");
		Label hile26 = Hile13;
		size = new Size(77, 13);
		((Control)hile26).set_Size(size);
		((Control)Hile13).set_TabIndex(11);
		Hile13.set_Text("Güncelleniyor..");
		Hile14.set_AutoSize(true);
		((Control)Hile14).set_BackColor(Color.Transparent);
		((Control)Hile14).set_ForeColor(Color.White);
		Label hile27 = Hile14;
		location = new Point(8, 411);
		((Control)hile27).set_Location(location);
		((Control)Hile14).set_Name("Hile14");
		Label hile28 = Hile14;
		size = new Size(77, 13);
		((Control)hile28).set_Size(size);
		((Control)Hile14).set_TabIndex(10);
		Hile14.set_Text("Güncelleniyor..");
		Hile15.set_AutoSize(true);
		((Control)Hile15).set_BackColor(Color.Transparent);
		((Control)Hile15).set_ForeColor(Color.White);
		Label hile29 = Hile15;
		location = new Point(8, 434);
		((Control)hile29).set_Location(location);
		((Control)Hile15).set_Name("Hile15");
		Label hile30 = Hile15;
		size = new Size(77, 13);
		((Control)hile30).set_Size(size);
		((Control)Hile15).set_TabIndex(9);
		Hile15.set_Text("Güncelleniyor..");
		H9.set_AutoSize(true);
		((Control)H9).set_BackColor(Color.Transparent);
		((Control)H9).set_ForeColor(Color.Red);
		Label h = H9;
		location = new Point(142, 279);
		((Control)h).set_Location(location);
		((Control)H9).set_Name("H9");
		Label h2 = H9;
		size = new Size(33, 13);
		((Control)h2).set_Size(size);
		((Control)H9).set_TabIndex(30);
		H9.set_Text("[OFF]");
		H10.set_AutoSize(true);
		((Control)H10).set_BackColor(Color.Transparent);
		((Control)H10).set_ForeColor(Color.Red);
		Label h3 = H10;
		location = new Point(142, 304);
		((Control)h3).set_Location(location);
		((Control)H10).set_Name("H10");
		Label h4 = H10;
		size = new Size(33, 13);
		((Control)h4).set_Size(size);
		((Control)H10).set_TabIndex(29);
		H10.set_Text("[OFF]");
		H11.set_AutoSize(true);
		((Control)H11).set_BackColor(Color.Transparent);
		((Control)H11).set_ForeColor(Color.Red);
		Label h5 = H11;
		location = new Point(142, 328);
		((Control)h5).set_Location(location);
		((Control)H11).set_Name("H11");
		Label h6 = H11;
		size = new Size(33, 13);
		((Control)h6).set_Size(size);
		((Control)H11).set_TabIndex(28);
		H11.set_Text("[OFF]");
		H12.set_AutoSize(true);
		((Control)H12).set_BackColor(Color.Transparent);
		((Control)H12).set_ForeColor(Color.Red);
		Label h7 = H12;
		location = new Point(142, 355);
		((Control)h7).set_Location(location);
		((Control)H12).set_Name("H12");
		Label h8 = H12;
		size = new Size(33, 13);
		((Control)h8).set_Size(size);
		((Control)H12).set_TabIndex(27);
		H12.set_Text("[OFF]");
		H13.set_AutoSize(true);
		((Control)H13).set_BackColor(Color.Transparent);
		((Control)H13).set_ForeColor(Color.Red);
		Label h9 = H13;
		location = new Point(142, 383);
		((Control)h9).set_Location(location);
		((Control)H13).set_Name("H13");
		Label h10 = H13;
		size = new Size(33, 13);
		((Control)h10).set_Size(size);
		((Control)H13).set_TabIndex(26);
		H13.set_Text("[OFF]");
		H14.set_AutoSize(true);
		((Control)H14).set_BackColor(Color.Transparent);
		((Control)H14).set_ForeColor(Color.Red);
		Label h11 = H14;
		location = new Point(142, 411);
		((Control)h11).set_Location(location);
		((Control)H14).set_Name("H14");
		Label h12 = H14;
		size = new Size(33, 13);
		((Control)h12).set_Size(size);
		((Control)H14).set_TabIndex(25);
		H14.set_Text("[OFF]");
		H15.set_AutoSize(true);
		((Control)H15).set_BackColor(Color.Transparent);
		((Control)H15).set_ForeColor(Color.Red);
		Label h13 = H15;
		location = new Point(142, 434);
		((Control)h13).set_Location(location);
		((Control)H15).set_Name("H15");
		Label h14 = H15;
		size = new Size(33, 13);
		((Control)h14).set_Size(size);
		((Control)H15).set_TabIndex(24);
		H15.set_Text("[OFF]");
		H7.set_AutoSize(true);
		((Control)H7).set_BackColor(Color.Transparent);
		((Control)H7).set_ForeColor(Color.Red);
		Label h15 = H7;
		location = new Point(142, 231);
		((Control)h15).set_Location(location);
		((Control)H7).set_Name("H7");
		Label h16 = H7;
		size = new Size(33, 13);
		((Control)h16).set_Size(size);
		((Control)H7).set_TabIndex(23);
		H7.set_Text("[OFF]");
		H8.set_AutoSize(true);
		((Control)H8).set_BackColor(Color.Transparent);
		((Control)H8).set_ForeColor(Color.Red);
		Label h17 = H8;
		location = new Point(142, 256);
		((Control)h17).set_Location(location);
		((Control)H8).set_Name("H8");
		Label h18 = H8;
		size = new Size(33, 13);
		((Control)h18).set_Size(size);
		((Control)H8).set_TabIndex(22);
		H8.set_Text("[OFF]");
		H6.set_AutoSize(true);
		((Control)H6).set_BackColor(Color.Transparent);
		((Control)H6).set_ForeColor(Color.Red);
		Label h19 = H6;
		location = new Point(142, 209);
		((Control)h19).set_Location(location);
		((Control)H6).set_Name("H6");
		Label h20 = H6;
		size = new Size(33, 13);
		((Control)h20).set_Size(size);
		((Control)H6).set_TabIndex(21);
		H6.set_Text("[OFF]");
		H5.set_AutoSize(true);
		((Control)H5).set_BackColor(Color.Transparent);
		((Control)H5).set_ForeColor(Color.Red);
		Label h21 = H5;
		location = new Point(142, 184);
		((Control)h21).set_Location(location);
		((Control)H5).set_Name("H5");
		Label h22 = H5;
		size = new Size(33, 13);
		((Control)h22).set_Size(size);
		((Control)H5).set_TabIndex(20);
		H5.set_Text("[OFF]");
		H3.set_AutoSize(true);
		((Control)H3).set_BackColor(Color.Transparent);
		((Control)H3).set_ForeColor(Color.Red);
		Label h23 = H3;
		location = new Point(142, 138);
		((Control)h23).set_Location(location);
		((Control)H3).set_Name("H3");
		Label h24 = H3;
		size = new Size(33, 13);
		((Control)h24).set_Size(size);
		((Control)H3).set_TabIndex(19);
		H3.set_Text("[OFF]");
		H4.set_AutoSize(true);
		((Control)H4).set_BackColor(Color.Transparent);
		((Control)H4).set_ForeColor(Color.Red);
		Label h25 = H4;
		location = new Point(142, 163);
		((Control)h25).set_Location(location);
		((Control)H4).set_Name("H4");
		Label h26 = H4;
		size = new Size(33, 13);
		((Control)h26).set_Size(size);
		((Control)H4).set_TabIndex(18);
		H4.set_Text("[OFF]");
		H2.set_AutoSize(true);
		((Control)H2).set_BackColor(Color.Transparent);
		((Control)H2).set_ForeColor(Color.Red);
		Label h27 = H2;
		location = new Point(142, 116);
		((Control)h27).set_Location(location);
		((Control)H2).set_Name("H2");
		Label h28 = H2;
		size = new Size(33, 13);
		((Control)h28).set_Size(size);
		((Control)H2).set_TabIndex(17);
		H2.set_Text("[OFF]");
		H1.set_AutoSize(true);
		((Control)H1).set_BackColor(Color.Transparent);
		((Control)H1).set_ForeColor(Color.Red);
		Label h29 = H1;
		location = new Point(142, 91);
		((Control)h29).set_Location(location);
		((Control)H1).set_Name("H1");
		Label h30 = H1;
		size = new Size(33, 13);
		((Control)h30).set_Size(size);
		((Control)H1).set_TabIndex(16);
		H1.set_Text("[OFF]");
		bin.set_AutoSize(true);
		((Control)bin).set_BackColor(Color.Transparent);
		((Control)bin).set_Font(new Font("Microsoft Sans Serif", 6f, (FontStyle)0, (GraphicsUnit)3, (byte)162));
		((Control)bin).set_ForeColor(Color.White);
		Label obj = bin;
		location = new Point(129, 472);
		((Control)obj).set_Location(location);
		((Control)bin).set_Name("bin");
		Label obj2 = bin;
		size = new Size(56, 9);
		((Control)obj2).set_Size(size);
		((Control)bin).set_TabIndex(42);
		bin.set_Text("_____Bin_____");
		bin.set_TextAlign((ContentAlignment)64);
		this.obj.set_AutoSize(true);
		((Control)this.obj).set_BackColor(Color.Transparent);
		((Control)this.obj).set_Font(new Font("Microsoft Sans Serif", 6f, (FontStyle)0, (GraphicsUnit)3, (byte)162));
		((Control)this.obj).set_ForeColor(Color.White);
		Label obj3 = this.obj;
		location = new Point(65, 472);
		((Control)obj3).set_Location(location);
		((Control)this.obj).set_Name("obj");
		Label obj4 = this.obj;
		size = new Size(57, 9);
		((Control)obj4).set_Size(size);
		((Control)this.obj).set_TabIndex(41);
		this.obj.set_Text("_____Obj_____");
		csh.set_AutoSize(true);
		((Control)csh).set_BackColor(Color.Transparent);
		((Control)csh).set_Font(new Font("Microsoft Sans Serif", 6f, (FontStyle)0, (GraphicsUnit)3, (byte)162));
		((Control)csh).set_ForeColor(Color.White);
		Label obj5 = csh;
		location = new Point(2, 471);
		((Control)obj5).set_Location(location);
		((Control)csh).set_Name("csh");
		Label obj6 = csh;
		size = new Size(57, 9);
		((Control)obj6).set_Size(size);
		((Control)csh).set_TabIndex(40);
		csh.set_Text("_____csh_____");
		versiyonn.set_AutoSize(true);
		((Control)versiyonn).set_BackColor(Color.Transparent);
		((Control)versiyonn).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)162));
		((Control)versiyonn).set_ForeColor(Color.Yellow);
		Label obj7 = versiyonn;
		location = new Point(114, 488);
		((Control)obj7).set_Location(location);
		((Control)versiyonn).set_Name("versiyonn");
		Label obj8 = versiyonn;
		size = new Size(71, 16);
		((Control)obj8).set_Size(size);
		((Control)versiyonn).set_TabIndex(39);
		versiyonn.set_Text("Version v1");
		yapicii.set_AutoSize(true);
		((Control)yapicii).set_BackColor(Color.Transparent);
		((Control)yapicii).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)162));
		((Control)yapicii).set_ForeColor(Color.Yellow);
		Label obj9 = yapicii;
		location = new Point(6, 487);
		((Control)obj9).set_Location(location);
		((Control)yapicii).set_Name("yapicii");
		Label obj10 = yapicii;
		size = new Size(57, 16);
		((Control)obj10).set_Size(size);
		((Control)yapicii).set_TabIndex(38);
		yapicii.set_Text("Yapımcı");
		((Control)Panel6).set_BackColor(Color.Red);
		Panel panel = Panel6;
		location = new Point(17, 76);
		((Control)panel).set_Location(location);
		((Control)Panel6).set_Name("Panel6");
		Panel panel2 = Panel6;
		size = new Size(152, 5);
		((Control)panel2).set_Size(size);
		((Control)Panel6).set_TabIndex(33);
		((Control)Panelsag).set_BackColor(Color.Yellow);
		Panel panelsag = Panelsag;
		location = new Point(188, 1);
		((Control)panelsag).set_Location(location);
		((Control)Panelsag).set_Name("Panelsag");
		Panel panelsag2 = Panelsag;
		size = new Size(10, 546);
		((Control)panelsag2).set_Size(size);
		((Control)Panelsag).set_TabIndex(37);
		((Control)Panelsol).set_BackColor(Color.Yellow);
		Panel panelsol = Panelsol;
		location = new Point(-6, 0);
		((Control)panelsol).set_Location(location);
		((Control)Panelsol).set_Name("Panelsol");
		Panel panelsol2 = Panelsol;
		size = new Size(10, 551);
		((Control)panelsol2).set_Size(size);
		((Control)Panelsol).set_TabIndex(36);
		((Control)logo).set_BackColor(Color.Transparent);
		PictureBox obj11 = logo;
		location = new Point(29, 9);
		((Control)obj11).set_Location(location);
		((Control)logo).set_Name("logo");
		PictureBox obj12 = logo;
		size = new Size(130, 60);
		((Control)obj12).set_Size(size);
		logo.set_SizeMode((PictureBoxSizeMode)1);
		logo.set_TabIndex(31);
		logo.set_TabStop(false);
		Timer1.set_Interval(1);
		Timer2.set_Interval(1);
		((Control)Panelust).set_BackColor(Color.Red);
		Panel panelust = Panelust;
		location = new Point(-1, 0);
		((Control)panelust).set_Location(location);
		((Control)Panelust).set_Name("Panelust");
		Panel panelust2 = Panelust;
		size = new Size(194, 6);
		((Control)panelust2).set_Size(size);
		((Control)Panelust).set_TabIndex(32);
		((Control)Panelalt).set_BackColor(Color.Red);
		Panel panelalt = Panelalt;
		location = new Point(-1, 524);
		((Control)panelalt).set_Location(location);
		((Control)Panelalt).set_Name("Panelalt");
		Panel panelalt2 = Panelalt;
		size = new Size(194, 6);
		((Control)panelalt2).set_Size(size);
		((Control)Panelalt).set_TabIndex(33);
		((Control)PictureBox1).set_BackColor(Color.FromArgb(64, 64, 64));
		PictureBox pictureBox = PictureBox1;
		location = new Point(119, 507);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(1, 1);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(43);
		PictureBox1.set_TabStop(false);
		((Control)Panel2).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)Panel2).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Panel2).get_Controls().Add((Control)(object)PictureBox1);
		((Control)Panel2).get_Controls().Add((Control)(object)bizeulass);
		((Control)Panel2).get_Controls().Add((Control)(object)f2pass);
		((Control)Panel2).get_Controls().Add((Control)(object)f2kullanici);
		((Control)Panel2).get_Controls().Add((Control)(object)csh);
		((Control)Panel2).get_Controls().Add((Control)(object)bin);
		((Control)Panel2).get_Controls().Add((Control)(object)yapicii);
		((Control)Panel2).get_Controls().Add((Control)(object)this.obj);
		((Control)Panel2).get_Controls().Add((Control)(object)versiyonn);
		((Control)Panel2).get_Controls().Add((Control)(object)Panel1);
		((Control)Panel2).get_Controls().Add((Control)(object)Label1);
		((Control)Panel2).get_Controls().Add((Control)(object)logo);
		((Control)Panel2).get_Controls().Add((Control)(object)H10);
		((Control)Panel2).get_Controls().Add((Control)(object)Hile8);
		((Control)Panel2).get_Controls().Add((Control)(object)Hile10);
		((Control)Panel2).get_Controls().Add((Control)(object)H2);
		((Control)Panel2).get_Controls().Add((Control)(object)H1);
		((Control)Panel2).get_Controls().Add((Control)(object)H5);
		((Control)Panel2).get_Controls().Add((Control)(object)H15);
		((Control)Panel2).get_Controls().Add((Control)(object)H12);
		((Control)Panel2).get_Controls().Add((Control)(object)Panel6);
		((Control)Panel2).get_Controls().Add((Control)(object)Hile3);
		((Control)Panel2).get_Controls().Add((Control)(object)H13);
		((Control)Panel2).get_Controls().Add((Control)(object)Hile5);
		((Control)Panel2).get_Controls().Add((Control)(object)Hile7);
		((Control)Panel2).get_Controls().Add((Control)(object)H7);
		((Control)Panel2).get_Controls().Add((Control)(object)H3);
		((Control)Panel2).get_Controls().Add((Control)(object)Hile15);
		((Control)Panel2).get_Controls().Add((Control)(object)Hile1);
		((Control)Panel2).get_Controls().Add((Control)(object)H4);
		((Control)Panel2).get_Controls().Add((Control)(object)Hile11);
		((Control)Panel2).get_Controls().Add((Control)(object)Hile13);
		((Control)Panel2).get_Controls().Add((Control)(object)Hile6);
		((Control)Panel2).get_Controls().Add((Control)(object)Hile14);
		((Control)Panel2).get_Controls().Add((Control)(object)H9);
		((Control)Panel2).get_Controls().Add((Control)(object)H11);
		((Control)Panel2).get_Controls().Add((Control)(object)Hile2);
		((Control)Panel2).get_Controls().Add((Control)(object)H14);
		((Control)Panel2).get_Controls().Add((Control)(object)Hile9);
		((Control)Panel2).get_Controls().Add((Control)(object)H8);
		((Control)Panel2).get_Controls().Add((Control)(object)H6);
		((Control)Panel2).get_Controls().Add((Control)(object)Hile4);
		((Control)Panel2).get_Controls().Add((Control)(object)Hile12);
		Panel panel3 = Panel2;
		location = new Point(2, 5);
		((Control)panel3).set_Location(location);
		((Control)Panel2).set_Name("Panel2");
		Panel panel4 = Panel2;
		size = new Size(188, 525);
		((Control)panel4).set_Size(size);
		((Control)Panel2).set_TabIndex(46);
		bizeulass.set_AutoSize(true);
		Label obj13 = bizeulass;
		location = new Point(91, 44);
		((Control)obj13).set_Location(location);
		((Control)bizeulass).set_Name("bizeulass");
		Label obj14 = bizeulass;
		size = new Size(39, 13);
		((Control)obj14).set_Size(size);
		((Control)bizeulass).set_TabIndex(43);
		bizeulass.set_Text("Label2");
		((Control)bizeulass).set_Visible(false);
		f2pass.set_AutoSize(true);
		Label obj15 = f2pass;
		location = new Point(46, 44);
		((Control)obj15).set_Location(location);
		((Control)f2pass).set_Name("f2pass");
		Label obj16 = f2pass;
		size = new Size(39, 13);
		((Control)obj16).set_Size(size);
		((Control)f2pass).set_TabIndex(42);
		f2pass.set_Text("Label3");
		((Control)f2pass).set_Visible(false);
		f2kullanici.set_AutoSize(true);
		Label obj17 = f2kullanici;
		location = new Point(46, 31);
		((Control)obj17).set_Location(location);
		((Control)f2kullanici).set_Name("f2kullanici");
		Label obj18 = f2kullanici;
		size = new Size(39, 13);
		((Control)obj18).set_Size(size);
		((Control)f2kullanici).set_TabIndex(41);
		f2kullanici.set_Text("Label2");
		((Control)f2kullanici).set_Visible(false);
		((Control)Panel1).set_BackColor(Color.Red);
		Panel panel5 = Panel1;
		location = new Point(17, 457);
		((Control)panel5).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel6 = Panel1;
		size = new Size(152, 5);
		((Control)panel6).set_Size(size);
		((Control)Panel1).set_TabIndex(34);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_ForeColor(Color.Firebrick);
		Label label = Label1;
		location = new Point(59, 505);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(61, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(40);
		Label1.set_Text("Cmpburhan");
		Timer5.set_Enabled(true);
		Timer5.set_Interval(1);
		Timer6.set_Enabled(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ActiveCaptionText);
		size = new Size(192, 530);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Panelust);
		((Control)this).get_Controls().Add((Control)(object)Panelalt);
		((Control)this).get_Controls().Add((Control)(object)Panelsag);
		((Control)this).get_Controls().Add((Control)(object)Panelsol);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_Text("Form1");
		((ISupportInitialize)logo).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(long vKey);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.9);
		try
		{
			Interaction.AppActivate("Wolfteam.bin");
			((Form)this).set_TopMost(true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((Form)this).set_TopMost(true);
			ProjectData.ClearProjectError();
		}
		FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
		checked
		{
			text1 = Strings.Space((int)FileSystem.LOF(1));
			text2 = Strings.Space((int)FileSystem.LOF(1));
			text3 = Strings.Space((int)FileSystem.LOF(1));
			text4 = Strings.Space((int)FileSystem.LOF(1));
			text5 = Strings.Space((int)FileSystem.LOF(1));
			text6 = Strings.Space((int)FileSystem.LOF(1));
			text7 = Strings.Space((int)FileSystem.LOF(1));
			text8 = Strings.Space((int)FileSystem.LOF(1));
			text9 = Strings.Space((int)FileSystem.LOF(1));
			text10 = Strings.Space((int)FileSystem.LOF(1));
			text11 = Strings.Space((int)FileSystem.LOF(1));
			text12 = Strings.Space((int)FileSystem.LOF(1));
			text13 = Strings.Space((int)FileSystem.LOF(1));
			text14 = Strings.Space((int)FileSystem.LOF(1));
			text15 = Strings.Space((int)FileSystem.LOF(1));
			phile1 = Strings.Space((int)FileSystem.LOF(1));
			phile2 = Strings.Space((int)FileSystem.LOF(1));
			phile3 = Strings.Space((int)FileSystem.LOF(1));
			phile4 = Strings.Space((int)FileSystem.LOF(1));
			phile5 = Strings.Space((int)FileSystem.LOF(1));
			phile6 = Strings.Space((int)FileSystem.LOF(1));
			phile7 = Strings.Space((int)FileSystem.LOF(1));
			phile8 = Strings.Space((int)FileSystem.LOF(1));
			phile9 = Strings.Space((int)FileSystem.LOF(1));
			phile10 = Strings.Space((int)FileSystem.LOF(1));
			phile11 = Strings.Space((int)FileSystem.LOF(1));
			phile12 = Strings.Space((int)FileSystem.LOF(1));
			phile13 = Strings.Space((int)FileSystem.LOF(1));
			phile14 = Strings.Space((int)FileSystem.LOF(1));
			phile15 = Strings.Space((int)FileSystem.LOF(1));
			vhile1 = Strings.Space((int)FileSystem.LOF(1));
			vhile2 = Strings.Space((int)FileSystem.LOF(1));
			vhile3 = Strings.Space((int)FileSystem.LOF(1));
			vhile4 = Strings.Space((int)FileSystem.LOF(1));
			vhile5 = Strings.Space((int)FileSystem.LOF(1));
			vhile6 = Strings.Space((int)FileSystem.LOF(1));
			vhile7 = Strings.Space((int)FileSystem.LOF(1));
			vhile8 = Strings.Space((int)FileSystem.LOF(1));
			vhile9 = Strings.Space((int)FileSystem.LOF(1));
			vhile10 = Strings.Space((int)FileSystem.LOF(1));
			vhile11 = Strings.Space((int)FileSystem.LOF(1));
			vhile12 = Strings.Space((int)FileSystem.LOF(1));
			vhile13 = Strings.Space((int)FileSystem.LOF(1));
			vhile14 = Strings.Space((int)FileSystem.LOF(1));
			vhile15 = Strings.Space((int)FileSystem.LOF(1));
			mhile1 = Strings.Space((int)FileSystem.LOF(1));
			mhile2 = Strings.Space((int)FileSystem.LOF(1));
			mhile3 = Strings.Space((int)FileSystem.LOF(1));
			mhile4 = Strings.Space((int)FileSystem.LOF(1));
			mhile5 = Strings.Space((int)FileSystem.LOF(1));
			mhile6 = Strings.Space((int)FileSystem.LOF(1));
			mhile7 = Strings.Space((int)FileSystem.LOF(1));
			mhile8 = Strings.Space((int)FileSystem.LOF(1));
			mhile9 = Strings.Space((int)FileSystem.LOF(1));
			mhile10 = Strings.Space((int)FileSystem.LOF(1));
			mhile11 = Strings.Space((int)FileSystem.LOF(1));
			mhile12 = Strings.Space((int)FileSystem.LOF(1));
			mhile13 = Strings.Space((int)FileSystem.LOF(1));
			mhile14 = Strings.Space((int)FileSystem.LOF(1));
			mhile15 = Strings.Space((int)FileSystem.LOF(1));
			resim = Strings.Space((int)FileSystem.LOF(1));
			version = Strings.Space((int)FileSystem.LOF(1));
			yapimci = Strings.Space((int)FileSystem.LOF(1));
			arkaplaan = Strings.Space((int)FileSystem.LOF(1));
			renkust = Strings.Space((int)FileSystem.LOF(1));
			renkalt = Strings.Space((int)FileSystem.LOF(1));
			renksag = Strings.Space((int)FileSystem.LOF(1));
			renksol = Strings.Space((int)FileSystem.LOF(1));
			arkaolan1 = Strings.Space((int)FileSystem.LOF(1));
			arkaplan2 = Strings.Space((int)FileSystem.LOF(1));
			kullanici = Strings.Space((int)FileSystem.LOF(1));
			pass = Strings.Space((int)FileSystem.LOF(1));
			f2sec = Strings.Space((int)FileSystem.LOF(1));
			f2renk = Strings.Space((int)FileSystem.LOF(1));
			f2resim = Strings.Space((int)FileSystem.LOF(1));
			bizeulas = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref text1, -1L, false);
			FileSystem.FileGet(1, ref text2, -1L, false);
			FileSystem.FileGet(1, ref text3, -1L, false);
			FileSystem.FileGet(1, ref text4, -1L, false);
			FileSystem.FileGet(1, ref text5, -1L, false);
			FileSystem.FileGet(1, ref text6, -1L, false);
			FileSystem.FileGet(1, ref text7, -1L, false);
			FileSystem.FileGet(1, ref text8, -1L, false);
			FileSystem.FileGet(1, ref text9, -1L, false);
			FileSystem.FileGet(1, ref text10, -1L, false);
			FileSystem.FileGet(1, ref text11, -1L, false);
			FileSystem.FileGet(1, ref text12, -1L, false);
			FileSystem.FileGet(1, ref text13, -1L, false);
			FileSystem.FileGet(1, ref text14, -1L, false);
			FileSystem.FileGet(1, ref text15, -1L, false);
			FileSystem.FileGet(1, ref phile1, -1L, false);
			FileSystem.FileGet(1, ref phile2, -1L, false);
			FileSystem.FileGet(1, ref phile3, -1L, false);
			FileSystem.FileGet(1, ref phile4, -1L, false);
			FileSystem.FileGet(1, ref phile5, -1L, false);
			FileSystem.FileGet(1, ref phile6, -1L, false);
			FileSystem.FileGet(1, ref phile7, -1L, false);
			FileSystem.FileGet(1, ref phile8, -1L, false);
			FileSystem.FileGet(1, ref phile9, -1L, false);
			FileSystem.FileGet(1, ref phile10, -1L, false);
			FileSystem.FileGet(1, ref phile11, -1L, false);
			FileSystem.FileGet(1, ref phile12, -1L, false);
			FileSystem.FileGet(1, ref phile13, -1L, false);
			FileSystem.FileGet(1, ref phile14, -1L, false);
			FileSystem.FileGet(1, ref phile15, -1L, false);
			FileSystem.FileGet(1, ref vhile1, -1L, false);
			FileSystem.FileGet(1, ref vhile2, -1L, false);
			FileSystem.FileGet(1, ref vhile3, -1L, false);
			FileSystem.FileGet(1, ref vhile4, -1L, false);
			FileSystem.FileGet(1, ref vhile5, -1L, false);
			FileSystem.FileGet(1, ref vhile6, -1L, false);
			FileSystem.FileGet(1, ref vhile7, -1L, false);
			FileSystem.FileGet(1, ref vhile8, -1L, false);
			FileSystem.FileGet(1, ref vhile9, -1L, false);
			FileSystem.FileGet(1, ref vhile10, -1L, false);
			FileSystem.FileGet(1, ref vhile11, -1L, false);
			FileSystem.FileGet(1, ref vhile12, -1L, false);
			FileSystem.FileGet(1, ref vhile13, -1L, false);
			FileSystem.FileGet(1, ref vhile14, -1L, false);
			FileSystem.FileGet(1, ref vhile15, -1L, false);
			FileSystem.FileGet(1, ref mhile1, -1L, false);
			FileSystem.FileGet(1, ref mhile2, -1L, false);
			FileSystem.FileGet(1, ref mhile3, -1L, false);
			FileSystem.FileGet(1, ref mhile4, -1L, false);
			FileSystem.FileGet(1, ref mhile5, -1L, false);
			FileSystem.FileGet(1, ref mhile6, -1L, false);
			FileSystem.FileGet(1, ref mhile7, -1L, false);
			FileSystem.FileGet(1, ref mhile8, -1L, false);
			FileSystem.FileGet(1, ref mhile9, -1L, false);
			FileSystem.FileGet(1, ref mhile10, -1L, false);
			FileSystem.FileGet(1, ref mhile11, -1L, false);
			FileSystem.FileGet(1, ref mhile12, -1L, false);
			FileSystem.FileGet(1, ref mhile13, -1L, false);
			FileSystem.FileGet(1, ref mhile14, -1L, false);
			FileSystem.FileGet(1, ref mhile15, -1L, false);
			FileSystem.FileGet(1, ref resim, -1L, false);
			FileSystem.FileGet(1, ref version, -1L, false);
			FileSystem.FileGet(1, ref yapimci, -1L, false);
			FileSystem.FileGet(1, ref arkaplaan, -1L, false);
			FileSystem.FileGet(1, ref renkust, -1L, false);
			FileSystem.FileGet(1, ref renkalt, -1L, false);
			FileSystem.FileGet(1, ref renksag, -1L, false);
			FileSystem.FileGet(1, ref renksol, -1L, false);
			FileSystem.FileGet(1, ref arkaolan1, -1L, false);
			FileSystem.FileGet(1, ref arkaplan2, -1L, false);
			FileSystem.FileGet(1, ref kullanici, -1L, false);
			FileSystem.FileGet(1, ref pass, -1L, false);
			FileSystem.FileGet(1, ref f2sec, -1L, false);
			FileSystem.FileGet(1, ref f2renk, -1L, false);
			FileSystem.FileGet(1, ref f2resim, -1L, false);
			FileSystem.FileGet(1, ref bizeulas, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			options = Strings.Split(text1, "paylasism", -1, (CompareMethod)0);
			Hile1.set_Text(options[1]);
			Hile2.set_Text(options[2]);
			Hile3.set_Text(options[3]);
			Hile4.set_Text(options[4]);
			Hile5.set_Text(options[5]);
			Hile6.set_Text(options[6]);
			Hile7.set_Text(options[7]);
			Hile8.set_Text(options[8]);
			Hile9.set_Text(options[9]);
			Hile10.set_Text(options[10]);
			Hile11.set_Text(options[11]);
			Hile12.set_Text(options[12]);
			Hile13.set_Text(options[13]);
			Hile14.set_Text(options[14]);
			Hile15.set_Text(options[15]);
			f2kullanici.set_Text(options[71]);
			f2pass.set_Text(options[72]);
			if (Operators.CompareString(options[73], "Resim", false) == 0)
			{
				MyProject.Forms.Form2.PictureBox1.set_ImageLocation(options[75]);
				MyProject.Forms.Form2.Timer1.Start();
			}
			else
			{
				if (Operators.CompareString(options[74], "Black", false) == 0)
				{
					((Control)MyProject.Forms.Form2.PictureBox1).set_BackColor(Color.Black);
					((Form)MyProject.Forms.Form2).set_BackColor(Color.Black);
				}
				if (Operators.CompareString(options[74], "Green", false) == 0)
				{
					((Form)MyProject.Forms.Form2).set_BackColor(Color.Green);
					((Control)MyProject.Forms.Form2.PictureBox1).set_BackColor(Color.Green);
				}
				if (Operators.CompareString(options[74], "Blue", false) == 0)
				{
					((Form)MyProject.Forms.Form2).set_BackColor(Color.Blue);
					((Control)MyProject.Forms.Form2.PictureBox1).set_BackColor(Color.Blue);
				}
				if (Operators.CompareString(options[74], "Yellow", false) == 0)
				{
					((Form)MyProject.Forms.Form2).set_BackColor(Color.Yellow);
					((Control)MyProject.Forms.Form2.PictureBox1).set_BackColor(Color.Yellow);
				}
				if (Operators.CompareString(options[74], "Orange", false) == 0)
				{
					((Form)MyProject.Forms.Form2).set_BackColor(Color.Orange);
					((Control)MyProject.Forms.Form2.PictureBox1).set_BackColor(Color.Orange);
				}
				if (Operators.CompareString(options[74], "Pink", false) == 0)
				{
					((Form)MyProject.Forms.Form2).set_BackColor(Color.Pink);
					((Control)MyProject.Forms.Form2.PictureBox1).set_BackColor(Color.Pink);
				}
				if (Operators.CompareString(options[74], "Brown", false) == 0)
				{
					((Form)MyProject.Forms.Form2).set_BackColor(Color.Brown);
					((Control)MyProject.Forms.Form2.PictureBox1).set_BackColor(Color.Brown);
				}
				if (Operators.CompareString(options[74], "Beige", false) == 0)
				{
					((Form)MyProject.Forms.Form2).set_BackColor(Color.Beige);
					((Control)MyProject.Forms.Form2.PictureBox1).set_BackColor(Color.Beige);
				}
				if (Operators.CompareString(options[74], "Gray", false) == 0)
				{
					((Form)MyProject.Forms.Form2).set_BackColor(Color.Gray);
					((Control)MyProject.Forms.Form2.PictureBox1).set_BackColor(Color.Gray);
				}
				if (Operators.CompareString(options[74], "Purple", false) == 0)
				{
					((Form)MyProject.Forms.Form2).set_BackColor(Color.Purple);
					((Control)MyProject.Forms.Form2.PictureBox1).set_BackColor(Color.Purple);
				}
				if (Operators.CompareString(options[74], "Red", false) == 0)
				{
					((Form)MyProject.Forms.Form2).set_BackColor(Color.Red);
					((Control)MyProject.Forms.Form2.PictureBox1).set_BackColor(Color.Red);
				}
				if (Operators.CompareString(options[74], "White", false) == 0)
				{
					((Form)MyProject.Forms.Form2).set_BackColor(Color.White);
					((Control)MyProject.Forms.Form2.PictureBox1).set_BackColor(Color.White);
				}
			}
			yapicii.set_Text(options[63]);
			versiyonn.set_Text(options[62]);
			logo.set_ImageLocation(options[61]);
			if (Operators.CompareString(options[64], "Resim", false) == 0)
			{
				PictureBox1.set_ImageLocation(options[69]);
				Timer4.Start();
			}
			else
			{
				Timer4.Stop();
				if (Operators.CompareString(options[70], "Black", false) == 0)
				{
					((Control)Panel2).set_BackColor(Color.Black);
				}
				if (Operators.CompareString(options[70], "Green", false) == 0)
				{
					((Control)Panel2).set_BackColor(Color.Green);
				}
				if (Operators.CompareString(options[70], "Blue", false) == 0)
				{
					((Control)Panel2).set_BackColor(Color.Blue);
				}
				if (Operators.CompareString(options[70], "Yellow", false) == 0)
				{
					((Control)Panel2).set_BackColor(Color.Yellow);
				}
				if (Operators.CompareString(options[70], "Orange", false) == 0)
				{
					((Control)Panel2).set_BackColor(Color.Orange);
				}
				if (Operators.CompareString(options[70], "Pink", false) == 0)
				{
					((Control)Panel2).set_BackColor(Color.Pink);
				}
				if (Operators.CompareString(options[70], "Brown", false) == 0)
				{
					((Control)Panel2).set_BackColor(Color.Brown);
				}
				if (Operators.CompareString(options[70], "Beige", false) == 0)
				{
					((Control)Panel2).set_BackColor(Color.Beige);
				}
				if (Operators.CompareString(options[70], "Gray", false) == 0)
				{
					((Control)Panel2).set_BackColor(Color.Gray);
				}
				if (Operators.CompareString(options[70], "Purple", false) == 0)
				{
					((Control)Panel2).set_BackColor(Color.Purple);
				}
				if (Operators.CompareString(options[70], "Red", false) == 0)
				{
					((Control)Panel2).set_BackColor(Color.Red);
				}
				if (Operators.CompareString(options[70], "White", false) == 0)
				{
					((Control)Panel2).set_BackColor(Color.White);
				}
			}
			if (Operators.CompareString(options[65], "Black", false) == 0)
			{
				((Control)Panelust).set_BackColor(Color.Black);
			}
			if (Operators.CompareString(options[65], "Green", false) == 0)
			{
				((Control)Panelust).set_BackColor(Color.Green);
			}
			if (Operators.CompareString(options[65], "Blue", false) == 0)
			{
				((Control)Panelust).set_BackColor(Color.Blue);
			}
			if (Operators.CompareString(options[65], "Yellow", false) == 0)
			{
				((Control)Panelust).set_BackColor(Color.Yellow);
			}
			if (Operators.CompareString(options[65], "Orange", false) == 0)
			{
				((Control)Panelust).set_BackColor(Color.Orange);
			}
			if (Operators.CompareString(options[65], "Pink", false) == 0)
			{
				((Control)Panelust).set_BackColor(Color.Pink);
			}
			if (Operators.CompareString(options[65], "Brown", false) == 0)
			{
				((Control)Panelust).set_BackColor(Color.Brown);
			}
			if (Operators.CompareString(options[65], "Beige", false) == 0)
			{
				((Control)Panelust).set_BackColor(Color.Beige);
			}
			if (Operators.CompareString(options[65], "Gray", false) == 0)
			{
				((Control)Panelust).set_BackColor(Color.Gray);
			}
			if (Operators.CompareString(options[65], "Purple", false) == 0)
			{
				((Control)Panelust).set_BackColor(Color.Purple);
			}
			if (Operators.CompareString(options[65], "Red", false) == 0)
			{
				((Control)Panelust).set_BackColor(Color.Red);
			}
			if (Operators.CompareString(options[65], "White", false) == 0)
			{
				((Control)Panelust).set_BackColor(Color.White);
			}
			if (Operators.CompareString(options[66], "Black", false) == 0)
			{
				((Control)Panelalt).set_BackColor(Color.Black);
			}
			if (Operators.CompareString(options[66], "Green", false) == 0)
			{
				((Control)Panelalt).set_BackColor(Color.Green);
			}
			if (Operators.CompareString(options[66], "Blue", false) == 0)
			{
				((Control)Panelalt).set_BackColor(Color.Blue);
			}
			if (Operators.CompareString(options[66], "Yellow", false) == 0)
			{
				((Control)Panelalt).set_BackColor(Color.Yellow);
			}
			if (Operators.CompareString(options[66], "Orange", false) == 0)
			{
				((Control)Panelalt).set_BackColor(Color.Orange);
			}
			if (Operators.CompareString(options[66], "Pink", false) == 0)
			{
				((Control)Panelalt).set_BackColor(Color.Pink);
			}
			if (Operators.CompareString(options[66], "Brown", false) == 0)
			{
				((Control)Panelalt).set_BackColor(Color.Brown);
			}
			if (Operators.CompareString(options[66], "Beige", false) == 0)
			{
				((Control)Panelalt).set_BackColor(Color.Beige);
			}
			if (Operators.CompareString(options[66], "Gray", false) == 0)
			{
				((Control)Panelalt).set_BackColor(Color.Gray);
			}
			if (Operators.CompareString(options[66], "Purple", false) == 0)
			{
				((Control)Panelalt).set_BackColor(Color.Purple);
			}
			if (Operators.CompareString(options[66], "Red", false) == 0)
			{
				((Control)Panelalt).set_BackColor(Color.Red);
			}
			if (Operators.CompareString(options[66], "White", false) == 0)
			{
				((Control)Panelalt).set_BackColor(Color.White);
			}
			if (Operators.CompareString(options[67], "Black", false) == 0)
			{
				((Control)Panelsag).set_BackColor(Color.Black);
			}
			if (Operators.CompareString(options[67], "Green", false) == 0)
			{
				((Control)Panelsag).set_BackColor(Color.Green);
			}
			if (Operators.CompareString(options[67], "Blue", false) == 0)
			{
				((Control)Panelsag).set_BackColor(Color.Blue);
			}
			if (Operators.CompareString(options[67], "Yellow", false) == 0)
			{
				((Control)Panelsag).set_BackColor(Color.Yellow);
			}
			if (Operators.CompareString(options[67], "Orange", false) == 0)
			{
				((Control)Panelsag).set_BackColor(Color.Orange);
			}
			if (Operators.CompareString(options[67], "Pink", false) == 0)
			{
				((Control)Panelsag).set_BackColor(Color.Pink);
			}
			if (Operators.CompareString(options[67], "Brown", false) == 0)
			{
				((Control)Panelsag).set_BackColor(Color.Brown);
			}
			if (Operators.CompareString(options[67], "Beige", false) == 0)
			{
				((Control)Panelsag).set_BackColor(Color.Beige);
			}
			if (Operators.CompareString(options[67], "Gray", false) == 0)
			{
				((Control)Panelsag).set_BackColor(Color.Gray);
			}
			if (Operators.CompareString(options[67], "Purple", false) == 0)
			{
				((Control)Panelsag).set_BackColor(Color.Purple);
			}
			if (Operators.CompareString(options[67], "Red", false) == 0)
			{
				((Control)Panelsag).set_BackColor(Color.Red);
			}
			if (Operators.CompareString(options[67], "White", false) == 0)
			{
				((Control)Panelsag).set_BackColor(Color.White);
			}
			if (Operators.CompareString(options[68], "Black", false) == 0)
			{
				((Control)Panelsol).set_BackColor(Color.Black);
			}
			if (Operators.CompareString(options[68], "Green", false) == 0)
			{
				((Control)Panelsol).set_BackColor(Color.Green);
			}
			if (Operators.CompareString(options[68], "Blue", false) == 0)
			{
				((Control)Panelsol).set_BackColor(Color.Blue);
			}
			if (Operators.CompareString(options[68], "Yellow", false) == 0)
			{
				((Control)Panelsol).set_BackColor(Color.Yellow);
			}
			if (Operators.CompareString(options[68], "Orange", false) == 0)
			{
				((Control)Panelsol).set_BackColor(Color.Orange);
			}
			if (Operators.CompareString(options[68], "Pink", false) == 0)
			{
				((Control)Panelsol).set_BackColor(Color.Pink);
			}
			if (Operators.CompareString(options[68], "Brown", false) == 0)
			{
				((Control)Panelsol).set_BackColor(Color.Brown);
			}
			if (Operators.CompareString(options[68], "Beige", false) == 0)
			{
				((Control)Panelsol).set_BackColor(Color.Beige);
			}
			if (Operators.CompareString(options[68], "Gray", false) == 0)
			{
				((Control)Panelsol).set_BackColor(Color.Gray);
			}
			if (Operators.CompareString(options[68], "Purple", false) == 0)
			{
				((Control)Panelsol).set_BackColor(Color.Purple);
			}
			if (Operators.CompareString(options[68], "Red", false) == 0)
			{
				((Control)Panelsol).set_BackColor(Color.Red);
			}
			if (Operators.CompareString(options[68], "White", false) == 0)
			{
				((Control)Panelsol).set_BackColor(Color.White);
			}
		}
	}

	private void Label4_Click(object sender, EventArgs e)
	{
	}

	private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
	{
	}

	private void Panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (GetAsyncKeyState(40L) == -32767)
		{
			if (((Control)Hile1).get_ForeColor() == Color.Lime)
			{
				((Control)Hile1).set_ForeColor(Color.White);
				((Control)Hile2).set_ForeColor(Color.Lime);
				return;
			}
			if (((Control)Hile2).get_ForeColor() == Color.Lime)
			{
				((Control)Hile2).set_ForeColor(Color.White);
				((Control)Hile3).set_ForeColor(Color.Lime);
				return;
			}
			if (((Control)Hile3).get_ForeColor() == Color.Lime)
			{
				((Control)Hile3).set_ForeColor(Color.White);
				((Control)Hile4).set_ForeColor(Color.Lime);
				return;
			}
			if (((Control)Hile4).get_ForeColor() == Color.Lime)
			{
				((Control)Hile4).set_ForeColor(Color.White);
				((Control)Hile5).set_ForeColor(Color.Lime);
				return;
			}
			if (((Control)Hile5).get_ForeColor() == Color.Lime)
			{
				((Control)Hile5).set_ForeColor(Color.White);
				((Control)Hile6).set_ForeColor(Color.Lime);
				return;
			}
			if (((Control)Hile6).get_ForeColor() == Color.Lime)
			{
				((Control)Hile6).set_ForeColor(Color.White);
				((Control)Hile7).set_ForeColor(Color.Lime);
				return;
			}
			if (((Control)Hile7).get_ForeColor() == Color.Lime)
			{
				((Control)Hile7).set_ForeColor(Color.White);
				((Control)Hile8).set_ForeColor(Color.Lime);
				return;
			}
			if (((Control)Hile8).get_ForeColor() == Color.Lime)
			{
				((Control)Hile8).set_ForeColor(Color.White);
				((Control)Hile9).set_ForeColor(Color.Lime);
				return;
			}
			if (((Control)Hile9).get_ForeColor() == Color.Lime)
			{
				((Control)Hile9).set_ForeColor(Color.White);
				((Control)Hile10).set_ForeColor(Color.Lime);
				return;
			}
			if (((Control)Hile10).get_ForeColor() == Color.Lime)
			{
				((Control)Hile10).set_ForeColor(Color.White);
				((Control)Hile11).set_ForeColor(Color.Lime);
				return;
			}
			if (((Control)Hile11).get_ForeColor() == Color.Lime)
			{
				((Control)Hile11).set_ForeColor(Color.White);
				((Control)Hile12).set_ForeColor(Color.Lime);
				return;
			}
			if (((Control)Hile12).get_ForeColor() == Color.Lime)
			{
				((Control)Hile12).set_ForeColor(Color.White);
				((Control)Hile13).set_ForeColor(Color.Lime);
				return;
			}
			if (((Control)Hile13).get_ForeColor() == Color.Lime)
			{
				((Control)Hile13).set_ForeColor(Color.White);
				((Control)Hile14).set_ForeColor(Color.Lime);
				return;
			}
			if (((Control)Hile14).get_ForeColor() == Color.Lime)
			{
				((Control)Hile14).set_ForeColor(Color.White);
				((Control)Hile15).set_ForeColor(Color.Lime);
				return;
			}
			if (((Control)Hile15).get_ForeColor() == Color.Lime)
			{
				((Control)Hile15).set_ForeColor(Color.White);
				((Control)Hile1).set_ForeColor(Color.Lime);
				return;
			}
		}
		if (GetAsyncKeyState(38L) != -32767)
		{
			return;
		}
		if (((Control)Hile1).get_ForeColor() == Color.Lime)
		{
			((Control)Hile1).set_ForeColor(Color.White);
			((Control)Hile15).set_ForeColor(Color.Lime);
			return;
		}
		if (((Control)Hile15).get_ForeColor() == Color.Lime)
		{
			((Control)Hile15).set_ForeColor(Color.White);
			((Control)Hile14).set_ForeColor(Color.Lime);
			return;
		}
		if (((Control)Hile14).get_ForeColor() == Color.Lime)
		{
			((Control)Hile14).set_ForeColor(Color.White);
			((Control)Hile13).set_ForeColor(Color.Lime);
			return;
		}
		if (((Control)Hile13).get_ForeColor() == Color.Lime)
		{
			((Control)Hile13).set_ForeColor(Color.White);
			((Control)Hile12).set_ForeColor(Color.Lime);
			return;
		}
		if (((Control)Hile12).get_ForeColor() == Color.Lime)
		{
			((Control)Hile12).set_ForeColor(Color.White);
			((Control)Hile11).set_ForeColor(Color.Lime);
			return;
		}
		if (((Control)Hile11).get_ForeColor() == Color.Lime)
		{
			((Control)Hile11).set_ForeColor(Color.White);
			((Control)Hile10).set_ForeColor(Color.Lime);
			return;
		}
		if (((Control)Hile10).get_ForeColor() == Color.Lime)
		{
			((Control)Hile10).set_ForeColor(Color.White);
			((Control)Hile9).set_ForeColor(Color.Lime);
			return;
		}
		if (((Control)Hile9).get_ForeColor() == Color.Lime)
		{
			((Control)Hile9).set_ForeColor(Color.White);
			((Control)Hile8).set_ForeColor(Color.Lime);
			return;
		}
		if (((Control)Hile8).get_ForeColor() == Color.Lime)
		{
			((Control)Hile8).set_ForeColor(Color.White);
			((Control)Hile7).set_ForeColor(Color.Lime);
			return;
		}
		if (((Control)Hile7).get_ForeColor() == Color.Lime)
		{
			((Control)Hile7).set_ForeColor(Color.White);
			((Control)Hile6).set_ForeColor(Color.Lime);
			return;
		}
		if (((Control)Hile6).get_ForeColor() == Color.Lime)
		{
			((Control)Hile6).set_ForeColor(Color.White);
			((Control)Hile5).set_ForeColor(Color.Lime);
			return;
		}
		if (((Control)Hile5).get_ForeColor() == Color.Lime)
		{
			((Control)Hile5).set_ForeColor(Color.White);
			((Control)Hile4).set_ForeColor(Color.Lime);
			return;
		}
		if (((Control)Hile4).get_ForeColor() == Color.Lime)
		{
			((Control)Hile4).set_ForeColor(Color.White);
			((Control)Hile3).set_ForeColor(Color.Lime);
			return;
		}
		if (((Control)Hile3).get_ForeColor() == Color.Lime)
		{
			((Control)Hile3).set_ForeColor(Color.White);
			((Control)Hile2).set_ForeColor(Color.Lime);
			return;
		}
		if (((Control)Hile2).get_ForeColor() == Color.Lime)
		{
			((Control)Hile2).set_ForeColor(Color.White);
			((Control)Hile1).set_ForeColor(Color.Lime);
		}
		if (GetAsyncKeyState(45L) == -32767)
		{
			if (!((Control)Hile1).get_Visible())
			{
				((Control)Hile1).set_Visible(true);
				((Control)this).Show();
				return;
			}
			if (((Control)Hile1).get_Visible())
			{
				((Control)Hile1).set_Visible(false);
				((Control)this).Hide();
				return;
			}
		}
		if (GetAsyncKeyState(46L) == -32767)
		{
			Application.Exit();
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		checked
		{
			if (GetAsyncKeyState(39L) == -32767)
			{
				if (((Control)Hile1).get_ForeColor() == Color.Lime)
				{
					((Control)H1).set_ForeColor(Color.Lime);
					H1.set_Text("[ON]");
					try
					{
						string text = Conversions.ToString(46);
						string text2 = Conversions.ToString(16);
						string text3 = Conversions.ToString(31);
						if (Operators.CompareString(options[Conversions.ToInteger(text)], "csh", false) == 0)
						{
							int num = Conversions.ToInteger(csh.get_Text());
							num = (int)Math.Round((double)num + Conversions.ToDouble(options[Conversions.ToInteger(text2)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num, Conversions.ToLong(options[Conversions.ToInteger(text3)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text)], "obj", false) == 0)
						{
							int num2 = Conversions.ToInteger(obj.get_Text());
							num2 = (int)Math.Round((double)num2 + Conversions.ToDouble(options[Conversions.ToInteger(text2)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num2, Conversions.ToLong(options[Conversions.ToInteger(text3)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text)], "bin", false) == 0)
						{
							int num3 = Conversions.ToInteger(bin.get_Text());
							num3 = (int)Math.Round((double)num3 + Conversions.ToDouble(options[Conversions.ToInteger(text2)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num3, Conversions.ToLong(options[Conversions.ToInteger(text3)]));
						}
						return;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (((Control)Hile2).get_ForeColor() == Color.Lime)
				{
					((Control)H2).set_ForeColor(Color.Lime);
					H2.set_Text("[ON]");
					try
					{
						string text4 = Conversions.ToString(47);
						string text5 = Conversions.ToString(17);
						string text6 = Conversions.ToString(32);
						if (Operators.CompareString(options[Conversions.ToInteger(text4)], "csh", false) == 0)
						{
							int num4 = Conversions.ToInteger(csh.get_Text());
							num4 = (int)Math.Round((double)num4 + Conversions.ToDouble(options[Conversions.ToInteger(text5)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num4, Conversions.ToLong(options[Conversions.ToInteger(text6)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text4)], "obj", false) == 0)
						{
							int num5 = Conversions.ToInteger(obj.get_Text());
							num5 = (int)Math.Round((double)num5 + Conversions.ToDouble(options[Conversions.ToInteger(text5)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num5, Conversions.ToLong(options[Conversions.ToInteger(text6)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text4)], "bin", false) == 0)
						{
							int num6 = Conversions.ToInteger(bin.get_Text());
							num6 = (int)Math.Round((double)num6 + Conversions.ToDouble(options[Conversions.ToInteger(text5)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num6, Conversions.ToLong(options[Conversions.ToInteger(text6)]));
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)Hile3).get_ForeColor() == Color.Lime)
				{
					((Control)H3).set_ForeColor(Color.Lime);
					H3.set_Text("[ON]");
					try
					{
						string text7 = Conversions.ToString(48);
						string text8 = Conversions.ToString(18);
						string text9 = Conversions.ToString(33);
						if (Operators.CompareString(options[Conversions.ToInteger(text7)], "csh", false) == 0)
						{
							int num7 = Conversions.ToInteger(csh.get_Text());
							num7 = (int)Math.Round((double)num7 + Conversions.ToDouble(options[Conversions.ToInteger(text8)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num7, Conversions.ToLong(options[Conversions.ToInteger(text9)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text7)], "obj", false) == 0)
						{
							int num8 = Conversions.ToInteger(obj.get_Text());
							num8 = (int)Math.Round((double)num8 + Conversions.ToDouble(options[Conversions.ToInteger(text8)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num8, Conversions.ToLong(options[Conversions.ToInteger(text9)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text7)], "bin", false) == 0)
						{
							int num9 = Conversions.ToInteger(bin.get_Text());
							num9 = (int)Math.Round((double)num9 + Conversions.ToDouble(options[Conversions.ToInteger(text8)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num9, Conversions.ToLong(options[Conversions.ToInteger(text9)]));
						}
						return;
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (((Control)Hile4).get_ForeColor() == Color.Lime)
				{
					((Control)H4).set_ForeColor(Color.Lime);
					H4.set_Text("[ON]");
					try
					{
						string text10 = Conversions.ToString(49);
						string text11 = Conversions.ToString(19);
						string text12 = Conversions.ToString(34);
						if (Operators.CompareString(options[Conversions.ToInteger(text10)], "csh", false) == 0)
						{
							int num10 = Conversions.ToInteger(csh.get_Text());
							num10 = (int)Math.Round((double)num10 + Conversions.ToDouble(options[Conversions.ToInteger(text11)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num10, Conversions.ToLong(options[Conversions.ToInteger(text12)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text10)], "obj", false) == 0)
						{
							int num11 = Conversions.ToInteger(obj.get_Text());
							num11 = (int)Math.Round((double)num11 + Conversions.ToDouble(options[Conversions.ToInteger(text11)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num11, Conversions.ToLong(options[Conversions.ToInteger(text12)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text10)], "bin", false) == 0)
						{
							int num12 = Conversions.ToInteger(bin.get_Text());
							num12 = (int)Math.Round((double)num12 + Conversions.ToDouble(options[Conversions.ToInteger(text11)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num12, Conversions.ToLong(options[Conversions.ToInteger(text12)]));
						}
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)Hile5).get_ForeColor() == Color.Lime)
				{
					((Control)H5).set_ForeColor(Color.Lime);
					H5.set_Text("[ON]");
					try
					{
						string text13 = Conversions.ToString(50);
						string text14 = Conversions.ToString(20);
						string text15 = Conversions.ToString(35);
						if (Operators.CompareString(options[Conversions.ToInteger(text13)], "csh", false) == 0)
						{
							int num13 = Conversions.ToInteger(csh.get_Text());
							num13 = (int)Math.Round((double)num13 + Conversions.ToDouble(options[Conversions.ToInteger(text14)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num13, Conversions.ToLong(options[Conversions.ToInteger(text15)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text13)], "obj", false) == 0)
						{
							int num14 = Conversions.ToInteger(obj.get_Text());
							num14 = (int)Math.Round((double)num14 + Conversions.ToDouble(options[Conversions.ToInteger(text14)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num14, Conversions.ToLong(options[Conversions.ToInteger(text15)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text13)], "bin", false) == 0)
						{
							int num15 = Conversions.ToInteger(bin.get_Text());
							num15 = (int)Math.Round((double)num15 + Conversions.ToDouble(options[Conversions.ToInteger(text14)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num15, Conversions.ToLong(options[Conversions.ToInteger(text15)]));
						}
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)Hile6).get_ForeColor() == Color.Lime)
				{
					((Control)H6).set_ForeColor(Color.Lime);
					H6.set_Text("[ON]");
					try
					{
						string text16 = Conversions.ToString(51);
						string text17 = Conversions.ToString(21);
						string text18 = Conversions.ToString(36);
						if (Operators.CompareString(options[Conversions.ToInteger(text16)], "csh", false) == 0)
						{
							int num16 = Conversions.ToInteger(csh.get_Text());
							num16 = (int)Math.Round((double)num16 + Conversions.ToDouble(options[Conversions.ToInteger(text17)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num16, Conversions.ToLong(options[Conversions.ToInteger(text18)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text16)], "obj", false) == 0)
						{
							int num17 = Conversions.ToInteger(obj.get_Text());
							num17 = (int)Math.Round((double)num17 + Conversions.ToDouble(options[Conversions.ToInteger(text17)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num17, Conversions.ToLong(options[Conversions.ToInteger(text18)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text16)], "bin", false) == 0)
						{
							int num18 = Conversions.ToInteger(bin.get_Text());
							num18 = (int)Math.Round((double)num18 + Conversions.ToDouble(options[Conversions.ToInteger(text17)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num18, Conversions.ToLong(options[Conversions.ToInteger(text18)]));
						}
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)Hile7).get_ForeColor() == Color.Lime)
				{
					((Control)H7).set_ForeColor(Color.Lime);
					H7.set_Text("[ON]");
					try
					{
						string text19 = Conversions.ToString(52);
						string text20 = Conversions.ToString(22);
						string text21 = Conversions.ToString(37);
						if (Operators.CompareString(options[Conversions.ToInteger(text19)], "csh", false) == 0)
						{
							int num19 = Conversions.ToInteger(csh.get_Text());
							num19 = (int)Math.Round((double)num19 + Conversions.ToDouble(options[Conversions.ToInteger(text20)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num19, Conversions.ToLong(options[Conversions.ToInteger(text21)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text19)], "obj", false) == 0)
						{
							int num20 = Conversions.ToInteger(obj.get_Text());
							num20 = (int)Math.Round((double)num20 + Conversions.ToDouble(options[Conversions.ToInteger(text20)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num20, Conversions.ToLong(options[Conversions.ToInteger(text21)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text19)], "bin", false) == 0)
						{
							int num21 = Conversions.ToInteger(bin.get_Text());
							num21 = (int)Math.Round((double)num21 + Conversions.ToDouble(options[Conversions.ToInteger(text20)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num21, Conversions.ToLong(options[Conversions.ToInteger(text21)]));
						}
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)Hile8).get_ForeColor() == Color.Lime)
				{
					((Control)H8).set_ForeColor(Color.Lime);
					H8.set_Text("[ON]");
					try
					{
						string text22 = Conversions.ToString(53);
						string text23 = Conversions.ToString(23);
						string text24 = Conversions.ToString(38);
						if (Operators.CompareString(options[Conversions.ToInteger(text22)], "csh", false) == 0)
						{
							int num22 = Conversions.ToInteger(csh.get_Text());
							num22 = (int)Math.Round((double)num22 + Conversions.ToDouble(options[Conversions.ToInteger(text23)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num22, Conversions.ToLong(options[Conversions.ToInteger(text24)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text22)], "obj", false) == 0)
						{
							int num23 = Conversions.ToInteger(obj.get_Text());
							num23 = (int)Math.Round((double)num23 + Conversions.ToDouble(options[Conversions.ToInteger(text23)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num23, Conversions.ToLong(options[Conversions.ToInteger(text24)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text22)], "bin", false) == 0)
						{
							int num24 = Conversions.ToInteger(bin.get_Text());
							num24 = (int)Math.Round((double)num24 + Conversions.ToDouble(options[Conversions.ToInteger(text23)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num24, Conversions.ToLong(options[Conversions.ToInteger(text24)]));
						}
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)Hile9).get_ForeColor() == Color.Lime)
				{
					((Control)H9).set_ForeColor(Color.Lime);
					H9.set_Text("[ON]");
					try
					{
						string text25 = Conversions.ToString(54);
						string text26 = Conversions.ToString(24);
						string text27 = Conversions.ToString(39);
						if (Operators.CompareString(options[Conversions.ToInteger(text25)], "csh", false) == 0)
						{
							int num25 = Conversions.ToInteger(csh.get_Text());
							num25 = (int)Math.Round((double)num25 + Conversions.ToDouble(options[Conversions.ToInteger(text26)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num25, Conversions.ToLong(options[Conversions.ToInteger(text27)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text25)], "obj", false) == 0)
						{
							int num26 = Conversions.ToInteger(obj.get_Text());
							num26 = (int)Math.Round((double)num26 + Conversions.ToDouble(options[Conversions.ToInteger(text26)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num26, Conversions.ToLong(options[Conversions.ToInteger(text27)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text25)], "bin", false) == 0)
						{
							int num27 = Conversions.ToInteger(bin.get_Text());
							num27 = (int)Math.Round((double)num27 + Conversions.ToDouble(options[Conversions.ToInteger(text26)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num27, Conversions.ToLong(options[Conversions.ToInteger(text27)]));
						}
					}
					catch (Exception projectError9)
					{
						ProjectData.SetProjectError(projectError9);
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)Hile10).get_ForeColor() == Color.Lime)
				{
					((Control)H10).set_ForeColor(Color.Lime);
					H10.set_Text("[ON]");
					try
					{
						string text28 = Conversions.ToString(55);
						string text29 = Conversions.ToString(25);
						string text30 = Conversions.ToString(40);
						if (Operators.CompareString(options[Conversions.ToInteger(text28)], "csh", false) == 0)
						{
							int num28 = Conversions.ToInteger(csh.get_Text());
							num28 = (int)Math.Round((double)num28 + Conversions.ToDouble(options[Conversions.ToInteger(text29)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num28, Conversions.ToLong(options[Conversions.ToInteger(text30)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text28)], "obj", false) == 0)
						{
							int num29 = Conversions.ToInteger(obj.get_Text());
							num29 = (int)Math.Round((double)num29 + Conversions.ToDouble(options[Conversions.ToInteger(text29)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num29, Conversions.ToLong(options[Conversions.ToInteger(text30)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text28)], "bin", false) == 0)
						{
							int num30 = Conversions.ToInteger(bin.get_Text());
							num30 = (int)Math.Round((double)num30 + Conversions.ToDouble(options[Conversions.ToInteger(text29)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num30, Conversions.ToLong(options[Conversions.ToInteger(text30)]));
						}
					}
					catch (Exception projectError10)
					{
						ProjectData.SetProjectError(projectError10);
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)Hile11).get_ForeColor() == Color.Lime)
				{
					((Control)H11).set_ForeColor(Color.Lime);
					H11.set_Text("[ON]");
					try
					{
						string text31 = Conversions.ToString(56);
						string text32 = Conversions.ToString(26);
						string text33 = Conversions.ToString(41);
						if (Operators.CompareString(options[Conversions.ToInteger(text31)], "csh", false) == 0)
						{
							int num31 = Conversions.ToInteger(csh.get_Text());
							num31 = (int)Math.Round((double)num31 + Conversions.ToDouble(options[Conversions.ToInteger(text32)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num31, Conversions.ToLong(options[Conversions.ToInteger(text33)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text31)], "obj", false) == 0)
						{
							int num32 = Conversions.ToInteger(obj.get_Text());
							num32 = (int)Math.Round((double)num32 + Conversions.ToDouble(options[Conversions.ToInteger(text32)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num32, Conversions.ToLong(options[Conversions.ToInteger(text33)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text31)], "bin", false) == 0)
						{
							int num33 = Conversions.ToInteger(bin.get_Text());
							num33 = (int)Math.Round((double)num33 + Conversions.ToDouble(options[Conversions.ToInteger(text32)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num33, Conversions.ToLong(options[Conversions.ToInteger(text33)]));
						}
					}
					catch (Exception projectError11)
					{
						ProjectData.SetProjectError(projectError11);
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)Hile12).get_ForeColor() == Color.Lime)
				{
					((Control)H12).set_ForeColor(Color.Lime);
					H12.set_Text("[ON]");
					try
					{
						string text34 = Conversions.ToString(57);
						string text35 = Conversions.ToString(27);
						string text36 = Conversions.ToString(42);
						if (Operators.CompareString(options[Conversions.ToInteger(text34)], "csh", false) == 0)
						{
							int num34 = Conversions.ToInteger(csh.get_Text());
							num34 = (int)Math.Round((double)num34 + Conversions.ToDouble(options[Conversions.ToInteger(text35)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num34, Conversions.ToLong(options[Conversions.ToInteger(text36)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text34)], "obj", false) == 0)
						{
							int num35 = Conversions.ToInteger(obj.get_Text());
							num35 = (int)Math.Round((double)num35 + Conversions.ToDouble(options[Conversions.ToInteger(text35)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num35, Conversions.ToLong(options[Conversions.ToInteger(text36)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text34)], "bin", false) == 0)
						{
							int num36 = Conversions.ToInteger(bin.get_Text());
							num36 = (int)Math.Round((double)num36 + Conversions.ToDouble(options[Conversions.ToInteger(text35)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num36, Conversions.ToLong(options[Conversions.ToInteger(text36)]));
						}
					}
					catch (Exception projectError12)
					{
						ProjectData.SetProjectError(projectError12);
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)Hile13).get_ForeColor() == Color.Lime)
				{
					((Control)H13).set_ForeColor(Color.Lime);
					H13.set_Text("[ON]");
					try
					{
						string text37 = Conversions.ToString(58);
						string text38 = Conversions.ToString(28);
						string text39 = Conversions.ToString(43);
						if (Operators.CompareString(options[Conversions.ToInteger(text37)], "csh", false) == 0)
						{
							int num37 = Conversions.ToInteger(csh.get_Text());
							num37 = (int)Math.Round((double)num37 + Conversions.ToDouble(options[Conversions.ToInteger(text38)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num37, Conversions.ToLong(options[Conversions.ToInteger(text39)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text37)], "obj", false) == 0)
						{
							int num38 = Conversions.ToInteger(obj.get_Text());
							num38 = (int)Math.Round((double)num38 + Conversions.ToDouble(options[Conversions.ToInteger(text38)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num38, Conversions.ToLong(options[Conversions.ToInteger(text39)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text37)], "bin", false) == 0)
						{
							int num39 = Conversions.ToInteger(bin.get_Text());
							num39 = (int)Math.Round((double)num39 + Conversions.ToDouble(options[Conversions.ToInteger(text38)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num39, Conversions.ToLong(options[Conversions.ToInteger(text39)]));
						}
					}
					catch (Exception projectError13)
					{
						ProjectData.SetProjectError(projectError13);
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)Hile14).get_ForeColor() == Color.Lime)
				{
					((Control)H14).set_ForeColor(Color.Lime);
					H14.set_Text("[ON]");
					try
					{
						string text40 = Conversions.ToString(59);
						string text41 = Conversions.ToString(29);
						string text42 = Conversions.ToString(44);
						if (Operators.CompareString(options[Conversions.ToInteger(text40)], "csh", false) == 0)
						{
							int num40 = Conversions.ToInteger(csh.get_Text());
							num40 = (int)Math.Round((double)num40 + Conversions.ToDouble(options[Conversions.ToInteger(text41)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num40, Conversions.ToLong(options[Conversions.ToInteger(text42)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text40)], "obj", false) == 0)
						{
							int num41 = Conversions.ToInteger(obj.get_Text());
							num41 = (int)Math.Round((double)num41 + Conversions.ToDouble(options[Conversions.ToInteger(text41)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num41, Conversions.ToLong(options[Conversions.ToInteger(text42)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text40)], "bin", false) == 0)
						{
							int num42 = Conversions.ToInteger(bin.get_Text());
							num42 = (int)Math.Round((double)num42 + Conversions.ToDouble(options[Conversions.ToInteger(text41)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num42, Conversions.ToLong(options[Conversions.ToInteger(text42)]));
						}
					}
					catch (Exception projectError14)
					{
						ProjectData.SetProjectError(projectError14);
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)Hile15).get_ForeColor() == Color.Lime)
				{
					((Control)H15).set_ForeColor(Color.Lime);
					H15.set_Text("[ON]");
					try
					{
						string text43 = Conversions.ToString(60);
						string text44 = Conversions.ToString(30);
						string text45 = Conversions.ToString(45);
						if (Operators.CompareString(options[Conversions.ToInteger(text43)], "csh", false) == 0)
						{
							int num43 = Conversions.ToInteger(csh.get_Text());
							num43 = (int)Math.Round((double)num43 + Conversions.ToDouble(options[Conversions.ToInteger(text44)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num43, Conversions.ToLong(options[Conversions.ToInteger(text45)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text43)], "obj", false) == 0)
						{
							int num44 = Conversions.ToInteger(obj.get_Text());
							num44 = (int)Math.Round((double)num44 + Conversions.ToDouble(options[Conversions.ToInteger(text44)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num44, Conversions.ToLong(options[Conversions.ToInteger(text45)]));
						}
						else if (Operators.CompareString(options[Conversions.ToInteger(text43)], "bin", false) == 0)
						{
							int num45 = Conversions.ToInteger(bin.get_Text());
							num45 = (int)Math.Round((double)num45 + Conversions.ToDouble(options[Conversions.ToInteger(text44)]));
							ReadWritingMemory.WriteLong("WolfTeam.bin", num45, Conversions.ToLong(options[Conversions.ToInteger(text45)]));
						}
					}
					catch (Exception projectError15)
					{
						ProjectData.SetProjectError(projectError15);
						ProjectData.ClearProjectError();
					}
				}
			}
			if (GetAsyncKeyState(37L) == -32767)
			{
				if (((Control)Hile1).get_ForeColor() == Color.Lime)
				{
					((Control)H1).set_ForeColor(Color.Red);
					H1.set_Text("[OFF]");
					return;
				}
				if (((Control)Hile2).get_ForeColor() == Color.Lime)
				{
					((Control)H2).set_ForeColor(Color.Red);
					H2.set_Text("[OFF]");
				}
				if (((Control)Hile3).get_ForeColor() == Color.Lime)
				{
					((Control)H3).set_ForeColor(Color.Red);
					H3.set_Text("[OFF]");
					return;
				}
				if (((Control)Hile4).get_ForeColor() == Color.Lime)
				{
					((Control)H4).set_ForeColor(Color.Red);
					H4.set_Text("[OFF]");
				}
				if (((Control)Hile5).get_ForeColor() == Color.Lime)
				{
					((Control)H5).set_ForeColor(Color.Red);
					H5.set_Text("[OFF]");
				}
				if (((Control)Hile6).get_ForeColor() == Color.Lime)
				{
					((Control)H6).set_ForeColor(Color.Red);
					H6.set_Text("[OFF]");
				}
				if (((Control)Hile7).get_ForeColor() == Color.Lime)
				{
					((Control)H7).set_ForeColor(Color.Red);
					H7.set_Text("[OFF]");
				}
				if (((Control)Hile8).get_ForeColor() == Color.Lime)
				{
					((Control)H8).set_ForeColor(Color.Red);
					H8.set_Text("[OFF]");
				}
				if (((Control)Hile9).get_ForeColor() == Color.Lime)
				{
					((Control)H9).set_ForeColor(Color.Red);
					H9.set_Text("[OFF]");
				}
				if (((Control)Hile10).get_ForeColor() == Color.Lime)
				{
					((Control)H10).set_ForeColor(Color.Red);
					H10.set_Text("[OFF]");
				}
				if (((Control)Hile11).get_ForeColor() == Color.Lime)
				{
					((Control)H11).set_ForeColor(Color.Red);
					H11.set_Text("[OFF]");
				}
				if (((Control)Hile12).get_ForeColor() == Color.Lime)
				{
					((Control)H12).set_ForeColor(Color.Red);
					H12.set_Text("[OFF]");
				}
				if (((Control)Hile13).get_ForeColor() == Color.Lime)
				{
					((Control)H13).set_ForeColor(Color.Red);
					H13.set_Text("[OFF]");
				}
				if (((Control)Hile14).get_ForeColor() == Color.Lime)
				{
					((Control)H14).set_ForeColor(Color.Red);
					H14.set_Text("[OFF]");
				}
				if (((Control)Hile15).get_ForeColor() == Color.Lime)
				{
					((Control)H15).set_ForeColor(Color.Red);
					H15.set_Text("[OFF]");
				}
			}
			if (GetAsyncKeyState(45L) == -32767)
			{
				if (!((Control)Hile1).get_Visible())
				{
					((Control)Hile1).set_Visible(true);
					((Control)this).Show();
					return;
				}
				if (((Control)Hile1).get_Visible())
				{
					((Control)Hile1).set_Visible(false);
					((Control)this).Hide();
					return;
				}
			}
			if (GetAsyncKeyState(46L) == -32767)
			{
				Application.Exit();
			}
		}
	}

	private void Hile1_Click(object sender, EventArgs e)
	{
	}

	private void chs_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void Button2_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox1_Click_1(object sender, EventArgs e)
	{
		((Control)this).set_BackgroundImage(PictureBox1.get_Image());
	}

	private void Timer4_Tick(object sender, EventArgs e)
	{
		((Control)Panel2).set_BackgroundImage(PictureBox1.get_Image());
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
	}

	private void Panel2_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Timer5_Tick(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.Form2).Show();
		Timer5.Stop();
	}

	private void bizeulass_Click(object sender, EventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void Timer6_Tick(object sender, EventArgs e)
	{
		try
		{
			Process process = Process.GetProcessesByName("WolfTeam.bin")[0];
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = process.Modules.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ProcessModule processModule = (ProcessModule)enumerator.Current;
					if (processModule.FileName!.IndexOf("csh") != -1)
					{
						csh.set_Text(processModule.BaseAddress.ToString());
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process process2 = Process.GetProcessesByName("WolfTeam.bin")[0];
			IEnumerator enumerator2 = default(IEnumerator);
			try
			{
				enumerator2 = process2.Modules.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					ProcessModule processModule2 = (ProcessModule)enumerator2.Current;
					if (processModule2.FileName!.IndexOf("obj") != -1)
					{
						obj.set_Text(processModule2.BaseAddress.ToString());
					}
				}
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process process3 = Process.GetProcessesByName("WolfTeam.bin")[0];
			IEnumerator enumerator3 = default(IEnumerator);
			try
			{
				enumerator3 = process3.Modules.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					ProcessModule processModule3 = (ProcessModule)enumerator3.Current;
					if (processModule3.FileName!.IndexOf("bin") != -1)
					{
						bin.set_Text(processModule3.BaseAddress.ToString());
					}
				}
			}
			finally
			{
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	private void bin_Click(object sender, EventArgs e)
	{
	}

	private void obj_Click(object sender, EventArgs e)
	{
	}
}
