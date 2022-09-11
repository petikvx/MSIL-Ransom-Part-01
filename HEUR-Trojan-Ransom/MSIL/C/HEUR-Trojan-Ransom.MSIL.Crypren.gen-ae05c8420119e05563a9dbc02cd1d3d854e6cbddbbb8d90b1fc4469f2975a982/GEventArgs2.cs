public class GEventArgs2 : GEventArgs1
{
	public enum GEnum0
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5
	}

	public static int int_2;

	public static int int_3;

	public static int int_4;

	public static int int_5;

	public static int int_6;

	public static int int_7;

	private bool bool_0;

	private bool bool_1;

	private object object_0;

	private int int_8;

	private string string_0;

	public virtual object Object_0
	{
		get
		{
			return Class26.smethod_0(7404798, this, null);
		}
		set
		{
			Class26.smethod_0(7404681, this, value);
		}
	}

	public virtual string String_0
	{
		get
		{
			return (string)Class26.smethod_0(7404702, this, null);
		}
		set
		{
			Class26.smethod_0(7404713, this, value);
		}
	}

	public virtual int Int32_2
	{
		get
		{
			return (int)Class26.smethod_0(7404734, this, null);
		}
		set
		{
			Class26.smethod_0(7404617, this, value);
		}
	}

	internal bool Boolean_0
	{
		set
		{
			Class26.smethod_0(7404638, this, value);
		}
	}

	internal bool Boolean_1
	{
		set
		{
			Class26.smethod_0(7404655, this, value);
		}
	}

	public GEventArgs2()
	{
	}

	public GEventArgs2(int int_9, int int_10, object object_1, string string_1, int int_11, bool bool_2, bool bool_3)
	{
	}

	static GEventArgs2()
	{
		Class26.smethod_0(7404782, null, null);
	}

	public virtual bool vmethod_1()
	{
		return (bool)Class26.smethod_0(7404668, this, null);
	}

	public virtual bool vmethod_2()
	{
		return (bool)Class26.smethod_0(7404559, this, null);
	}

	internal void method_1(int int_9, int int_10, object object_1, string string_1, int int_11, bool bool_2, bool bool_3)
	{
		Class26.smethod_0(7404574, this, int_9, int_10, object_1, string_1, int_11, bool_2, bool_3);
	}

	public override string ToString()
	{
		return (string)Class26.smethod_0(7404593, this, null);
	}
}
