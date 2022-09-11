using System;
using System.Collections.Generic;
using System.Diagnostics;

[DebuggerDisplay("Name: {OriginalName}, Value: {Value}")]
internal class Class36 : IComparable
{
	private int int_0;

	internal int int_1;

	internal string string_0;

	internal int int_2;

	internal int int_3;

	internal Class9 class9_0;

	internal Class23 class23_0;

	private Enum11 enum11_0 = (Enum11)Class84.smethod_0(1);

	internal int int_4;

	internal string string_1;

	internal int int_5;

	internal int int_6;

	public int Int32_0
	{
		get
		{
			return int_0;
		}
		internal set
		{
			int_0 = value;
		}
	}

	public int Int32_1 => int_1;

	public string String_0
	{
		get
		{
			if (string_0 == null && 0 == 0)
			{
				string_0 = class9_0.string_1.Substring(int_3, int_2);
			}
			return string_0.ToLower();
		}
		set
		{
			if (value == null && 0 == 0)
			{
				throw new ArgumentNullException(Class86.smethod_0("\uf429\uf43e\uf433\uf42a\uf43a", 62529));
			}
			string_0 = value;
			if (class23_0 != null || 1 == 0)
			{
				class23_0.bool_0 = (byte)Class84.smethod_0(1) != 0;
				class23_0.bool_1 = (byte)Class84.smethod_0(1) != 0;
			}
		}
	}

	public string String_1 => string_0;

	public Class9 Class9_0 => class9_0;

	public Class23 Class23_0 => class23_0;

	public Enum11 Enum11_0
	{
		get
		{
			return enum11_0;
		}
		set
		{
			enum11_0 = value;
		}
	}

	public int Int32_2 => int_4;

	public string String_2
	{
		get
		{
			if (string_1 == null && 0 == 0)
			{
				string_1 = class9_0.string_1.Substring(int_6, int_5);
			}
			return string_1;
		}
		set
		{
			string_1 = value;
			if (class23_0 != null || 1 == 0)
			{
				class23_0.bool_0 = (byte)Class84.smethod_0(1) != 0;
				class23_0.bool_1 = (byte)Class84.smethod_0(1) != 0;
			}
		}
	}

	internal string String_3 => Delegate452.smethod_0(Delegate486.smethod_0(this));

	internal string String_4 => Delegate487.smethod_0(this);

	public string String_5
	{
		get
		{
			string text = ((Delegate488.smethod_0(this) == null) ? Class86.smethod_0("\ue398", 58295) : (Delegate404.smethod_0(Delegate488.smethod_0(this)) + Class86.smethod_0("\ue398", 58295)));
			return text + Delegate489.smethod_0(this);
		}
	}

	internal Class36(Class9 class9_1)
	{
		class9_0 = class9_1;
	}

	public int CompareTo(object obj)
	{
		Class36 @class = obj as Class36;
		if (@class == null && 0 == 0)
		{
			throw new ArgumentException(Class86.smethod_0("\uf691\uf69c\uf694", 63158));
		}
		return Delegate486.smethod_0(this).CompareTo(Delegate206.smethod_0(@class));
	}

	public Class36 method_0()
	{
		Class36 @class = Delegate254.smethod_0(class9_0);
		while (true)
		{
			int num = Class46.Class47.smethod_0(65);
			while (true)
			{
				switch (num ^ Class84.smethod_0(405))
				{
				case -100:
					Delegate233.smethod_0(@class, Delegate487.smethod_0(this));
					num = -2;
					continue;
				case -101:
					num = Class89.smethod_1(55);
					continue;
				case -102:
					Delegate231.smethod_0(@class, Delegate486.smethod_0(this));
					num = -1;
					continue;
				case -99:
					return @class;
				}
				break;
			}
		}
	}

	public void method_1()
	{
		Delegate490.smethod_0(Delegate201.smethod_0(class23_0), this);
	}

	private string method_2()
	{
		if (Delegate488.smethod_0(this) == null && 0 == 0)
		{
			return Delegate486.smethod_0(this);
		}
		int num = Class84.smethod_0(1);
		IEnumerator<Class36> enumerator = ((IEnumerable<Class36>)Delegate201.smethod_0(Delegate488.smethod_0(this))).GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				Class36 current = enumerator.Current;
				if (!(Delegate206.smethod_0(current) != Delegate486.smethod_0(this)) && 0 == 0)
				{
					if (current == this)
					{
						break;
					}
					num += Class84.smethod_0(1);
				}
			}
		}
		finally
		{
			if (enumerator != null || 1 == 0)
			{
				enumerator.Dispose();
			}
		}
		object[] array = new object[Class84.smethod_0(9)];
		while (true)
		{
			int num2 = Class84.smethod_0(72);
			int num3 = -27;
			while (true)
			{
				num3 ^= Class84.smethod_0(409);
				while (true)
				{
					int num4 = Class46.Class47.smethod_0(76);
					while (true)
					{
						switch (num4 ^ Class84.smethod_0(411))
						{
						case -102:
							break;
						case -103:
							goto IL_00a5;
						case -104:
							num4 = -9;
							continue;
						default:
							goto end_IL_0190;
						case -101:
							goto end_IL_01b9;
						}
						goto IL_0093;
						IL_00a5:
						switch (num3)
						{
						case -114:
							goto IL_00c8;
						case -113:
							goto IL_0178;
						case -116:
							goto IL_01c4;
						case -115:
							goto end_IL_01ce;
						}
						num4 = -11;
						continue;
						IL_01c4:
						num3 = -26;
						goto end_IL_01b9;
						IL_00c8:
						switch (num2)
						{
						case 100:
							break;
						case 101:
							goto IL_0110;
						case 102:
							goto IL_0128;
						case 103:
							goto IL_0144;
						case 104:
							goto IL_0158;
						case 105:
							goto IL_015d;
						default:
							goto IL_01ca;
						case 106:
							return string.Concat(array);
						}
						array[Class84.smethod_0(0)] = Class86.smethod_0("\uf0bc", 61628);
						num2 = 14;
						goto IL_0178;
						IL_01ca:
						num3 = -25;
						goto end_IL_01b9;
						IL_015d:
						array[Class84.smethod_0(6)] = Class86.smethod_0("\uf2a5", 62102);
						num2 = 12;
						goto IL_0178;
						IL_0158:
						num2 = 3;
						goto IL_0178;
						IL_0144:
						array[Class84.smethod_0(7)] = num;
						num2 = 13;
						goto IL_0178;
						IL_0128:
						array[Class84.smethod_0(8)] = Class86.smethod_0("\ue58a", 58823);
						num2 = 1;
						goto IL_0178;
						IL_0110:
						array[Class84.smethod_0(1)] = Delegate486.smethod_0(this);
						num2 = Class84.smethod_0(6);
						goto IL_0178;
						IL_0093:
						num3 = Class89.smethod_2(91);
						num4 = -12;
						continue;
						IL_0178:
						num2 ^= Class84.smethod_0(414);
						goto IL_0093;
						continue;
						end_IL_0190:
						break;
					}
					continue;
					end_IL_01b9:
					break;
				}
				continue;
				end_IL_01ce:
				break;
			}
		}
	}
}
