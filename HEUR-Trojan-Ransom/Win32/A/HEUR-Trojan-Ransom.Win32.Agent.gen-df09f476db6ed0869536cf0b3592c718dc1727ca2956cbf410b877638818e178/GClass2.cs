using System;
using System.Runtime.CompilerServices;

public class GClass2
{
	private string string_0;

	private DateTime dateTime_0;

	private int int_0;

	private int int_1;

	private GEnum1 genum1_0;

	private int int_2;

	public string Description
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public GClass2(GEnum1 genum1_1, int int_3, int int_4)
	{
		Class51.smethod_0();
		this._002Ector(genum1_1, int_3, int_4, 0);
	}

	public GClass2(GEnum1 genum1_1, int int_3, int int_4, int int_5)
	{
		Class51.smethod_0();
		base._002Ector();
		genum1_0 = genum1_1;
		int_1 = int_3;
		int_2 = int_4;
		int_0 = int_5;
		switch (int_5)
		{
		case int.MaxValue:
			dateTime_0 = DateTime.MaxValue;
			break;
		case 0:
			dateTime_0 = DateTime.Now;
			break;
		default:
			dateTime_0 = DateTime.Now.AddSeconds(int_5);
			break;
		}
	}

	[SpecialName]
	public GEnum1 method_0()
	{
		return genum1_0;
	}

	[SpecialName]
	internal void method_1(GEnum1 genum1_1)
	{
		genum1_0 = genum1_1;
	}

	[SpecialName]
	public int method_2()
	{
		return int_1;
	}

	[SpecialName]
	internal void method_3(int int_3)
	{
		int_1 = int_3;
	}

	[SpecialName]
	public int method_4()
	{
		return int_2;
	}

	[SpecialName]
	internal void method_5(int int_3)
	{
		int_2 = int_3;
	}

	[SpecialName]
	public int method_6()
	{
		return int_0;
	}

	[SpecialName]
	internal void method_7(int int_3)
	{
		int_0 = int_3;
	}

	[SpecialName]
	public DateTime method_8()
	{
		return dateTime_0;
	}

	[SpecialName]
	internal void method_9(DateTime dateTime_1)
	{
		dateTime_0 = dateTime_1;
	}

	public bool method_10()
	{
		return dateTime_0 < DateTime.Now;
	}

	public override bool Equals(object obj)
	{
		if (obj is GClass2 gClass)
		{
			if (genum1_0 == gClass.genum1_0 && int_1 == gClass.int_1)
			{
				return int_2 == gClass.int_2;
			}
			return false;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return genum1_0.GetHashCode() ^ int_1.GetHashCode() ^ int_2.GetHashCode();
	}

	public override string ToString()
	{
		return $"Protocol: {genum1_0}, Public Port: {int_2}, Private Port: {int_1}, Description: {string_0}, Expiration: {dateTime_0}, Lifetime: {int_0}";
	}
}
