using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Text;
using antlr;

public abstract class GClass30 : GInterface1, GInterface2, GInterface18
{
	internal const char char_0 = '\0';

	public static readonly char char_1;

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

	protected internal StringBuilder stringBuilder_0;

	protected bool bool_0;

	protected GClass60 gclass60_0;

	protected char char_2;

	protected char char_3;

	protected bool bool_1;

	protected bool bool_2;

	protected Hashtable hashtable_0;

	protected internal int int_0;

	protected internal GInterface17 ginterface17_0;

	protected internal GClass43 gclass43_0;

	protected internal bool bool_3;

	protected internal int int_1;

	protected internal EventHandlerList EventHandlerList_0 => (EventHandlerList)Class26.smethod_0(7401187, this, null);

	public event GDelegate6 Event_0
	{
		add
		{
			Class26.smethod_0(7400739, this, value);
		}
		remove
		{
			Class26.smethod_0(7400753, this, value);
		}
	}

	public event GDelegate6 Event_1
	{
		add
		{
			Class26.smethod_0(7400647, this, value);
		}
		remove
		{
			Class26.smethod_0(7400661, this, value);
		}
	}

	public event GDelegate6 Event_2
	{
		add
		{
			Class26.smethod_0(7400683, this, value);
		}
		remove
		{
			Class26.smethod_0(7400697, this, value);
		}
	}

	public event GDelegate0 Event_3
	{
		add
		{
			Class26.smethod_0(7400591, this, value);
		}
		remove
		{
			Class26.smethod_0(7400605, this, value);
		}
	}

	public event GDelegate0 Event_4
	{
		add
		{
			Class26.smethod_0(7400627, this, value);
		}
		remove
		{
			Class26.smethod_0(7400513, this, value);
		}
	}

	public event GDelegate1 Event_9
	{
		add
		{
			Class26.smethod_0(7400535, this, value);
		}
		remove
		{
			Class26.smethod_0(7400549, this, value);
		}
	}

	public event GDelegate2 Event_10
	{
		add
		{
			Class26.smethod_0(7400571, this, value);
		}
		remove
		{
			Class26.smethod_0(7400457, this, value);
		}
	}

	public event GDelegate2 Event_11
	{
		add
		{
			Class26.smethod_0(7400479, this, value);
		}
		remove
		{
			Class26.smethod_0(7400493, this, value);
		}
	}

	public event GDelegate2 Event_12
	{
		add
		{
			Class26.smethod_0(7401411, this, value);
		}
		remove
		{
			Class26.smethod_0(7401425, this, value);
		}
	}

	public event GDelegate2 Event_13
	{
		add
		{
			Class26.smethod_0(7401447, this, value);
		}
		remove
		{
			Class26.smethod_0(7401461, this, value);
		}
	}

	public event GDelegate3 Event_14
	{
		add
		{
			Class26.smethod_0(7401355, this, value);
		}
		remove
		{
			Class26.smethod_0(7401369, this, value);
		}
	}

	public event GDelegate3 Event_15
	{
		add
		{
			Class26.smethod_0(7401391, this, value);
		}
		remove
		{
			Class26.smethod_0(7401405, this, value);
		}
	}

	public event GDelegate4 Event_5
	{
		add
		{
			Class26.smethod_0(7401299, this, value);
		}
		remove
		{
			Class26.smethod_0(7401313, this, value);
		}
	}

	public event GDelegate5 Event_6
	{
		add
		{
			Class26.smethod_0(7401335, this, value);
		}
		remove
		{
			Class26.smethod_0(7401221, this, value);
		}
	}

	public event GDelegate5 Event_7
	{
		add
		{
			Class26.smethod_0(7401243, this, value);
		}
		remove
		{
			Class26.smethod_0(7401257, this, value);
		}
	}

	public event GDelegate5 Event_8
	{
		add
		{
			Class26.smethod_0(7401279, this, value);
		}
		remove
		{
			Class26.smethod_0(7401165, this, value);
		}
	}

	public GClass30()
	{
	}

	public GClass30(GClass39 gclass39_0)
	{
	}

	public GClass30(GClass43 gclass43_1)
	{
	}

	static GClass30()
	{
		Class26.smethod_0(7400723, null, null);
	}

	public virtual GInterface17 imethod_0()
	{
		return (GInterface17)Class26.smethod_0(7401202, this, null);
	}

	public virtual void vmethod_0(char char_4)
	{
		Class26.smethod_0(7401090, this, char_4);
	}

	public virtual void vmethod_1(string string_0)
	{
		Class26.smethod_0(7401107, this, string_0);
	}

	public virtual void vmethod_2()
	{
		Class26.smethod_0(7401120, this, null);
	}

	public virtual void vmethod_3()
	{
		Class26.smethod_0(7401136, this, null);
	}

	public virtual void vmethod_4(int int_2)
	{
		Class26.smethod_0(7401024, this, int_2);
	}

	public virtual void vmethod_5(GClass2 gclass2_0)
	{
		Class26.smethod_0(7401041, this, gclass2_0);
	}

	public virtual bool vmethod_6()
	{
		return (bool)Class26.smethod_0(7401063, this, null);
	}

	public bool method_0()
	{
		return (bool)Class26.smethod_0(7401078, this, null);
	}

	public virtual int vmethod_7()
	{
		return (int)Class26.smethod_0(7400961, this, null);
	}

	public virtual void vmethod_8(int int_2)
	{
		Class26.smethod_0(7400976, this, int_2);
	}

	public virtual bool vmethod_9()
	{
		return (bool)Class26.smethod_0(7400993, this, null);
	}

	public virtual string vmethod_10()
	{
		return (string)Class26.smethod_0(7401008, this, null);
	}

	public virtual GClass39 vmethod_11()
	{
		return (GClass39)Class26.smethod_0(7399875, this, null);
	}

	public virtual GClass43 vmethod_12()
	{
		return (GClass43)Class26.smethod_0(7399891, this, null);
	}

	public virtual void vmethod_13(GClass43 gclass43_1)
	{
		Class26.smethod_0(7399907, this, gclass43_1);
	}

	public virtual int vmethod_14()
	{
		return (int)Class26.smethod_0(7399921, this, null);
	}

	public virtual string vmethod_15()
	{
		return (string)Class26.smethod_0(7399808, this, null);
	}

	public virtual GInterface17 vmethod_16()
	{
		return (GInterface17)Class26.smethod_0(7399827, this, null);
	}

	public virtual char vmethod_17(int int_2)
	{
		return (char)Class26.smethod_0(7399843, this, int_2);
	}

	protected internal virtual GInterface17 vmethod_18(int int_2)
	{
		return (GInterface17)Class26.smethod_0(7399859, this, int_2);
	}

	public virtual int vmethod_19()
	{
		return (int)Class26.smethod_0(7399744, this, null);
	}

	public virtual void vmethod_20(char char_4)
	{
		Class26.smethod_0(7399763, this, char_4);
	}

	public virtual void vmethod_21(int int_2)
	{
		Class26.smethod_0(7399776, this, int_2);
	}

	public virtual void vmethod_22(GClass2 gclass2_0)
	{
		Class26.smethod_0(7399793, this, gclass2_0);
	}

	public virtual void vmethod_23(string string_0)
	{
		Class26.smethod_0(7399687, this, string_0);
	}

	public virtual void vmethod_24(char char_4)
	{
		Class26.smethod_0(7399700, this, char_4);
	}

	public virtual void vmethod_25(int int_2)
	{
		Class26.smethod_0(7399717, this, int_2);
	}

	public virtual void vmethod_26(int int_2, int int_3)
	{
		Class26.smethod_0(7399738, this, int_2, int_3);
	}

	public virtual void vmethod_27(char char_4, char char_5)
	{
		Class26.smethod_0(7399624, this, char_4, char_5);
	}

	public virtual void vmethod_28()
	{
		Class26.smethod_0(7399646, this, null);
	}

	public virtual void vmethod_29()
	{
		Class26.smethod_0(7399662, this, null);
	}

	public virtual void vmethod_30(int int_2)
	{
		Class26.smethod_0(7399678, this, int_2);
	}

	public virtual int vmethod_31()
	{
		return (int)Class26.smethod_0(7399567, this, null);
	}

	public virtual void vmethod_32()
	{
		Class26.smethod_0(7399582, this, null);
	}

	public virtual void vmethod_33(string string_0)
	{
		Class26.smethod_0(7399598, this, string_0);
	}

	public virtual void vmethod_34(RecognitionException recognitionException_0)
	{
		Class26.smethod_0(7399615, this, recognitionException_0);
	}

	public virtual void vmethod_35(string string_0)
	{
		Class26.smethod_0(7399501, this, string_0);
	}

	public virtual void vmethod_36(string string_0)
	{
		Class26.smethod_0(7399522, this, string_0);
	}

	public virtual void vmethod_37()
	{
		Class26.smethod_0(7399539, this, null);
	}

	public virtual void vmethod_38(GClass39 gclass39_0)
	{
		Class26.smethod_0(7399427, this, gclass39_0);
	}

	public void method_1(Stream stream_0)
	{
		Class26.smethod_0(7399441, this, stream_0);
	}

	public void method_2(TextReader textReader_0)
	{
		Class26.smethod_0(7399462, this, textReader_0);
	}

	public virtual void vmethod_39()
	{
		Class26.smethod_0(7399479, this, null);
	}

	public virtual void vmethod_40(int int_2)
	{
		Class26.smethod_0(7400391, this, int_2);
	}

	public virtual void vmethod_41(bool bool_4)
	{
		Class26.smethod_0(7400404, this, bool_4);
	}

	public virtual void vmethod_42(bool bool_4)
	{
		Class26.smethod_0(7400421, this, bool_4);
	}

	public virtual void vmethod_43(string string_0)
	{
		Class26.smethod_0(7400442, this, string_0);
	}

	public virtual void vmethod_44(int int_2)
	{
		Class26.smethod_0(7400331, this, int_2);
	}

	public virtual void vmethod_45(string string_0)
	{
		Class26.smethod_0(7400344, this, string_0);
	}

	public virtual void vmethod_46(GClass60 gclass60_1)
	{
		Class26.smethod_0(7400361, this, gclass60_1);
	}

	public virtual int vmethod_47(int int_2)
	{
		return (int)Class26.smethod_0(7400383, this, int_2);
	}

	public virtual int vmethod_48(string string_0, int int_2)
	{
		return (int)Class26.smethod_0(7400271, this, string_0, int_2);
	}

	public virtual char vmethod_49(int int_2)
	{
		return (char)Class26.smethod_0(7400284, this, int_2);
	}

	public virtual void vmethod_50()
	{
		Class26.smethod_0(7400300, this, null);
	}

	public virtual void vmethod_51(string string_0)
	{
		Class26.smethod_0(7400316, this, string_0);
	}

	public virtual void vmethod_52(string string_0)
	{
		Class26.smethod_0(7400205, this, string_0);
	}

	public virtual void vmethod_53()
	{
		Class26.smethod_0(7400226, this, null);
	}
}
