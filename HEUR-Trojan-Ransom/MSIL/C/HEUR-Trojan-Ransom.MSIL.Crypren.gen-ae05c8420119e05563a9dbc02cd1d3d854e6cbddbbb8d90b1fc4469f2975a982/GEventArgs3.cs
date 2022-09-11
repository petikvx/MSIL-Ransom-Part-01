public class GEventArgs3 : GEventArgs1
{
	public const int int_2 = 0;

	public const int int_3 = 1;

	private int int_4;

	private bool bool_0;

	public virtual int Int32_2
	{
		get
		{
			return (int)Class26.smethod_0(7398865, this, null);
		}
		set
		{
			Class26.smethod_0(7398880, this, value);
		}
	}

	public virtual bool Boolean_0
	{
		get
		{
			return (bool)Class26.smethod_0(7398897, this, null);
		}
		set
		{
			Class26.smethod_0(7398784, this, value);
		}
	}

	public GEventArgs3()
	{
	}

	public GEventArgs3(int int_5)
	{
	}

	internal void method_1(int int_5, int int_6, bool bool_1, int int_7)
	{
		Class26.smethod_0(7398801, this, int_5, int_6, bool_1, int_7);
	}

	public override string ToString()
	{
		return (string)Class26.smethod_0(7398821, this, null);
	}
}
