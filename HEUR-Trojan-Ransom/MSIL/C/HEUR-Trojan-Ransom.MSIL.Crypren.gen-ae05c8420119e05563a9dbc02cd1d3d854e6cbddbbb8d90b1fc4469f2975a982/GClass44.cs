using System;
using System.ComponentModel;
using antlr;
using antlr.collections;

public abstract class GClass44 : GInterface2, GInterface4
{
	private EventHandlerList eventHandlerList_0;

	internal static readonly object object_0;

	internal static readonly object object_1;

	internal static readonly object object_2;

	internal static readonly object object_3;

	internal static readonly object object_4;

	internal static readonly object object_5;

	internal static readonly object object_6;

	internal static readonly object object_7;

	internal static readonly object object_8;

	internal static readonly object object_9;

	internal static readonly object object_10;

	internal static readonly object object_11;

	internal static readonly object object_12;

	internal static readonly object object_13;

	internal static readonly object object_14;

	internal static readonly object object_15;

	protected internal GClass52 gclass52_0;

	protected internal string[] string_0;

	protected internal AST ast_0;

	protected internal GClass17 gclass17_0;

	private bool bool_0;

	protected internal int int_0;

	protected internal EventHandlerList EventHandlerList_0 => (EventHandlerList)Class26.smethod_0(7344207, this, null);

	public virtual GClass17 GClass17_0
	{
		get
		{
			return (GClass17)Class26.smethod_0(7345059, this, null);
		}
		set
		{
			Class26.smethod_0(7345075, this, value);
		}
	}

	public event GDelegate6 Event_0
	{
		add
		{
			Class26.smethod_0(7345843, this, value);
		}
		remove
		{
			Class26.smethod_0(7345729, this, value);
		}
	}

	public event GDelegate6 Event_1
	{
		add
		{
			Class26.smethod_0(7345751, this, value);
		}
		remove
		{
			Class26.smethod_0(7345765, this, value);
		}
	}

	public event GDelegate6 Event_2
	{
		add
		{
			Class26.smethod_0(7345787, this, value);
		}
		remove
		{
			Class26.smethod_0(7345673, this, value);
		}
	}

	public event GDelegate0 Event_3
	{
		add
		{
			Class26.smethod_0(7345695, this, value);
		}
		remove
		{
			Class26.smethod_0(7345709, this, value);
		}
	}

	public event GDelegate0 Event_4
	{
		add
		{
			Class26.smethod_0(7344579, this, value);
		}
		remove
		{
			Class26.smethod_0(7344593, this, value);
		}
	}

	public event GDelegate2 Event_9
	{
		add
		{
			Class26.smethod_0(7344615, this, value);
		}
		remove
		{
			Class26.smethod_0(7344629, this, value);
		}
	}

	public event GDelegate2 Event_10
	{
		add
		{
			Class26.smethod_0(7344523, this, value);
		}
		remove
		{
			Class26.smethod_0(7344537, this, value);
		}
	}

	public event GDelegate2 Event_11
	{
		add
		{
			Class26.smethod_0(7344559, this, value);
		}
		remove
		{
			Class26.smethod_0(7344573, this, value);
		}
	}

	public event GDelegate2 Event_12
	{
		add
		{
			Class26.smethod_0(7344467, this, value);
		}
		remove
		{
			Class26.smethod_0(7344481, this, value);
		}
	}

	public event GDelegate3 Event_13
	{
		add
		{
			Class26.smethod_0(7344503, this, value);
		}
		remove
		{
			Class26.smethod_0(7344389, this, value);
		}
	}

	public event GDelegate3 Event_14
	{
		add
		{
			Class26.smethod_0(7344411, this, value);
		}
		remove
		{
			Class26.smethod_0(7344425, this, value);
		}
	}

	public event GDelegate4 Event_5
	{
		add
		{
			Class26.smethod_0(7344447, this, value);
		}
		remove
		{
			Class26.smethod_0(7344333, this, value);
		}
	}

	public event GDelegate5 Event_6
	{
		add
		{
			Class26.smethod_0(7344355, this, value);
		}
		remove
		{
			Class26.smethod_0(7344369, this, value);
		}
	}

	public event GDelegate5 Event_7
	{
		add
		{
			Class26.smethod_0(7344263, this, value);
		}
		remove
		{
			Class26.smethod_0(7344277, this, value);
		}
	}

	public event GDelegate5 Event_8
	{
		add
		{
			Class26.smethod_0(7344299, this, value);
		}
		remove
		{
			Class26.smethod_0(7344313, this, value);
		}
	}

	public GClass44()
	{
	}

	public GClass44(GClass52 gclass52_1)
	{
	}

	static GClass44()
	{
		Class26.smethod_0(7345827, null, null);
	}

	public virtual void vmethod_0(GInterface6 ginterface6_0)
	{
		Class26.smethod_0(7344222, this, ginterface6_0);
	}

	public virtual void vmethod_1(GInterface9 ginterface9_0)
	{
		Class26.smethod_0(7344236, this, ginterface9_0);
	}

	public virtual void vmethod_2(GInterface10 ginterface10_0)
	{
		Class26.smethod_0(7344130, this, ginterface10_0);
	}

	public virtual void vmethod_3(GInterface11 ginterface11_0)
	{
		Class26.smethod_0(7344144, this, ginterface11_0);
	}

	public virtual void vmethod_4(GInterface12 ginterface12_0)
	{
		Class26.smethod_0(7344166, this, ginterface12_0);
	}

	public virtual void vmethod_5(GInterface13 ginterface13_0)
	{
		Class26.smethod_0(7344180, this, ginterface13_0);
	}

	public virtual void vmethod_6(GInterface14 ginterface14_0)
	{
		Class26.smethod_0(7345098, this, ginterface14_0);
	}

	public abstract void vmethod_7();

	public virtual void vmethod_8(int int_1)
	{
		Class26.smethod_0(7345112, this, int_1);
	}

	public virtual void vmethod_9(GClass2 gclass2_0)
	{
		Class26.smethod_0(7345129, this, gclass2_0);
	}

	protected internal virtual void vmethod_10(GInterface18 ginterface18_0, GClass59 gclass59_0)
	{
		Class26.smethod_0(7345151, this, ginterface18_0, gclass59_0);
	}

	public virtual AST vmethod_11()
	{
		return (AST)Class26.smethod_0(7345043, this, null);
	}

	public virtual GClass17 vmethod_12()
	{
		return (GClass17)Class26.smethod_0(7344961, this, null);
	}

	public virtual string vmethod_13()
	{
		return (string)Class26.smethod_0(7344977, this, null);
	}

	public virtual GClass52 vmethod_14()
	{
		return (GClass52)Class26.smethod_0(7344992, this, null);
	}

	public virtual void vmethod_15(GClass52 gclass52_1)
	{
		Class26.smethod_0(7345008, this, gclass52_1);
	}

	public virtual void vmethod_16()
	{
		Class26.smethod_0(7344902, this, null);
	}

	public virtual string vmethod_17(int int_1)
	{
		return (string)Class26.smethod_0(7344918, this, int_1);
	}

	public virtual string[] vmethod_18()
	{
		return (string[])Class26.smethod_0(7344934, this, null);
	}

	public virtual bool vmethod_19()
	{
		return (bool)Class26.smethod_0(7344950, this, null);
	}

	public abstract int vmethod_20(int int_1);

	public abstract GInterface17 vmethod_21(int int_1);

	public virtual int vmethod_22()
	{
		return (int)Class26.smethod_0(7344833, this, null);
	}

	public virtual void vmethod_23(int int_1)
	{
		Class26.smethod_0(7344848, this, int_1);
	}

	public virtual void vmethod_24(GClass2 gclass2_0)
	{
		Class26.smethod_0(7344865, this, gclass2_0);
	}

	public virtual void vmethod_25(int int_1)
	{
		Class26.smethod_0(7344887, this, int_1);
	}

	[Obsolete("De-activated since version 2.7.2.6 as it cannot be overidden.", true)]
	public static void smethod_0()
	{
		Class26.smethod_0(7344772, null, null);
	}

	public virtual void vmethod_26(GInterface6 ginterface6_0)
	{
		Class26.smethod_0(7344788, this, ginterface6_0);
	}

	public virtual void vmethod_27(GInterface9 ginterface9_0)
	{
		Class26.smethod_0(7344810, this, ginterface9_0);
	}

	public virtual void vmethod_28(GInterface10 ginterface10_0)
	{
		Class26.smethod_0(7344824, this, ginterface10_0);
	}

	public virtual void vmethod_29(GInterface11 ginterface11_0)
	{
		Class26.smethod_0(7344718, this, ginterface11_0);
	}

	public virtual void vmethod_30(GInterface12 ginterface12_0)
	{
		Class26.smethod_0(7344732, this, ginterface12_0);
	}

	public virtual void vmethod_31(GInterface13 ginterface13_0)
	{
		Class26.smethod_0(7344754, this, ginterface13_0);
	}

	public virtual void vmethod_32(GInterface14 ginterface14_0)
	{
		Class26.smethod_0(7344640, this, ginterface14_0);
	}

	public virtual void vmethod_33(RecognitionException recognitionException_0)
	{
		Class26.smethod_0(7344662, this, recognitionException_0);
	}

	public virtual void vmethod_34(string string_1)
	{
		Class26.smethod_0(7344676, this, string_1);
	}

	public virtual void vmethod_35(string string_1)
	{
		Class26.smethod_0(7344693, this, string_1);
	}

	public virtual void vmethod_36(RecognitionException recognitionException_0, GClass2 gclass2_0)
	{
		Class26.smethod_0(7347658, this, recognitionException_0, gclass2_0);
	}

	public virtual void vmethod_37(int int_1)
	{
		Class26.smethod_0(7347678, this, int_1);
	}

	public virtual void vmethod_38(GClass17 gclass17_1)
	{
		Class26.smethod_0(7347695, this, gclass17_1);
	}

	public virtual void vmethod_39(string string_1)
	{
		Class26.smethod_0(7347709, this, string_1);
	}

	[Obsolete("Replaced by setASTNodeClass(string) since version 2.7.1", true)]
	public virtual void vmethod_40(string string_1)
	{
		Class26.smethod_0(7347602, this, string_1);
	}

	public virtual void vmethod_41(bool bool_1)
	{
		Class26.smethod_0(7347619, this, bool_1);
	}

	public virtual void vmethod_42(string string_1)
	{
		Class26.smethod_0(7347632, this, string_1);
	}

	public virtual void vmethod_43(bool bool_1)
	{
		Class26.smethod_0(7347521, this, bool_1);
	}

	public virtual void vmethod_44(GClass59 gclass59_0)
	{
		Class26.smethod_0(7347542, this, gclass59_0);
	}

	public virtual void vmethod_45()
	{
		Class26.smethod_0(7347556, this, null);
	}

	public virtual void vmethod_46(string string_1)
	{
		Class26.smethod_0(7347572, this, string_1);
	}

	public virtual void vmethod_47(string string_1)
	{
		Class26.smethod_0(7347461, this, string_1);
	}
}
