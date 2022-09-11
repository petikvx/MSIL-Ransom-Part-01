using System;
using System.Text;

namespace ns0;

internal sealed class Class0
{
	public struct Struct0
	{
		private readonly short short_0;

		internal short short_1;

		public short Int16_0 => short_1;

		public short Int16_1 => short_0;

		internal Struct0(short short_2, short short_3)
		{
			short num = (short_1 = short_2);
			short_0 = short_3;
		}

		public override bool Equals(object obj)
		{
			if (obj is Struct0)
			{
				return method_0((Struct0)obj);
			}
			return false;
		}

		public bool method_0(Struct0 struct0_0)
		{
			if (struct0_0.short_1 == short_1)
			{
				return struct0_0.short_0 == short_0;
			}
			return false;
		}

		public static bool operator ==(Struct0 struct0_0, Struct0 struct0_1)
		{
			return struct0_0.method_0(struct0_1);
		}

		public static bool operator !=(Struct0 struct0_0, Struct0 struct0_1)
		{
			return !(struct0_0 == struct0_1);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public static string smethod_0(Struct0 struct0_0)
		{
			return "Section{0x" + Convert.ToString(struct0_0.Int16_0, 16) + ", 0x" + Convert.ToString(struct0_0.Int16_1, 16) + "}";
		}

		public override string ToString()
		{
			return smethod_0(this);
		}
	}

	internal static byte[] byte_0 = Class3.smethod_3();

	internal uint uint_0;

	public bool this[int int_0]
	{
		get
		{
			return (uint_0 & int_0) == (uint)int_0;
		}
		set
		{
			if (value)
			{
				uint_0 |= (uint)int_0;
			}
			else
			{
				uint_0 &= (uint)(~int_0);
			}
		}
	}

	public int this[Struct0 struct0_0]
	{
		get
		{
			return (int)((uint_0 & (uint)(struct0_0.Int16_0 << (int)struct0_0.Int16_1)) >> (int)struct0_0.Int16_1);
		}
		set
		{
			value <<= (int)struct0_0.Int16_1;
			int num = (0xFFFF & struct0_0.Int16_0) << (int)struct0_0.Int16_1;
			uint num2 = (uint_0 = (uint_0 & (uint)(~num)) | (uint)(value & num));
		}
	}

	public int Int32_0 => (int)uint_0;

	public Class0(int int_0)
	{
		uint num = (uint_0 = (uint)int_0);
	}

	public Class0(Class0 class0_0)
	{
		uint num = (uint_0 = class0_0.uint_0);
	}

	private static short smethod_0(short short_0)
	{
		short num = 0;
		while (((uint)short_0 & (true ? 1u : 0u)) != 0)
		{
			num = (short)(num + 1);
			short_0 = (short)(short_0 >> 1);
		}
		return num;
	}

	public static int smethod_1()
	{
		return smethod_2(0);
	}

	public static int smethod_2(int int_0)
	{
		return int_0 switch
		{
			0 => 1, 
			int.MinValue => throw new InvalidOperationException(""), 
			_ => int_0 << 1, 
		};
	}

	private static short smethod_3(short short_0)
	{
		short num = 16;
		while ((short_0 & 0x8000) == 0)
		{
			num = (short)(num - 1);
			short_0 = (short)(short_0 << 1);
		}
		ushort num2 = 0;
		while (num > 0)
		{
			num = (short)(num - 1);
			num2 = (ushort)((ushort)(num2 << 1) | 1u);
		}
		return (short)num2;
	}

	public static Struct0 smethod_4(short short_0)
	{
		return smethod_6(short_0, 0, 0);
	}

	public static Struct0 smethod_5(short short_0, Struct0 struct0_0)
	{
		return smethod_6(short_0, struct0_0.Int16_0, struct0_0.Int16_1);
	}

	private static Struct0 smethod_6(short short_0, short short_1, short short_2)
	{
		if (short_0 < 1)
		{
			throw new ArgumentException("");
		}
		short num = (short)(short_2 + smethod_0(short_1));
		if (num >= 32)
		{
			throw new InvalidOperationException("");
		}
		return new Struct0(smethod_3(short_0), num);
	}

	public override bool vmethod_0(object object_0)
	{
		if (!(object_0 is Class0))
		{
			return false;
		}
		return uint_0 == ((Class0)object_0).uint_0;
	}

	public override int vmethod_1()
	{
		return base.GetHashCode();
	}

	public static string smethod_7(Class0 class0_0)
	{
		StringBuilder stringBuilder = new StringBuilder(45);
		stringBuilder.Append("BitVector32{");
		int num = (int)class0_0.uint_0;
		for (int i = 0; i < 32; i++)
		{
			if ((num & 0x80000000L) != 0L)
			{
				stringBuilder.Append("1");
			}
			else
			{
				stringBuilder.Append("0");
			}
			num <<= 1;
		}
		stringBuilder.Append("}");
		return stringBuilder.ToString();
	}

	public override string vmethod_2()
	{
		return smethod_7(this);
	}
}
