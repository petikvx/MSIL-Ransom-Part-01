public class GEventArgs6 : GEventArgs0
{
	public const int int_1 = 0;

	public const int int_2 = 1;

	public const int int_3 = 2;

	public const int int_4 = 3;

	internal char char_0;

	internal int int_5;

	public virtual char Char_0
	{
		get
		{
			return (char)Class26.smethod_0(7391900, this, null);
		}
		set
		{
			Class26.smethod_0(7391919, this, value);
		}
	}

	public virtual int Int32_1
	{
		get
		{
			return (int)Class26.smethod_0(7391932, this, null);
		}
		set
		{
			Class26.smethod_0(7391823, this, value);
		}
	}

	public GEventArgs6()
	{
	}

	public GEventArgs6(int int_6, char char_1, int int_7)
	{
	}

	internal void method_1(int int_6, char char_1, int int_7)
	{
		Class26.smethod_0(7391836, this, int_6, char_1, int_7);
	}

	public override string ToString()
	{
		return (string)Class26.smethod_0(7391859, this, null);
	}
}
