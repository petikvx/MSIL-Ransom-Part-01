using System;
using System.Text;
using ns0;

namespace ns1;

public struct GStruct0
{
	public struct Section
	{
		internal short short_0;

		internal short short_1;

		public short Mask => short_0;

		public short Offset => short_1;

		internal Section(short short_2, short short_3)
		{
			short num = (short_0 = short_2);
			short num2 = (short_1 = short_3);
		}

		public override bool Equals(object o)
		{
			if (o is Section)
			{
				return Equals((Section)o);
			}
			return false;
		}

		public bool Equals(Section obj)
		{
			if (obj.short_0 == short_0)
			{
				return obj.short_1 == short_1;
			}
			return false;
		}

		public static bool operator ==(Section a, Section b)
		{
			return a.Equals(b);
		}

		public static bool operator !=(Section a, Section b)
		{
			return !(a == b);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public static string ToString(Section value)
		{
			return "Section{0x" + Convert.ToString(value.Mask, 16) + ", 0x" + Convert.ToString(value.Offset, 16) + "}";
		}

		public override string ToString()
		{
			return ToString(this);
		}
	}

	private uint uint_0;

	internal static byte[] byte_0 = Class3.smethod_3();

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

	public int this[Section section_0]
	{
		get
		{
			return (int)((uint_0 & (uint)(section_0.Mask << (int)section_0.Offset)) >> (int)section_0.Offset);
		}
		set
		{
			value <<= (int)section_0.Offset;
			int num = (0xFFFF & section_0.Mask) << (int)section_0.Offset;
			uint_0 = (uint_0 & (uint)(~num)) | (uint)(value & num);
		}
	}

	public int Data => (int)uint_0;

	public GStruct0(int data)
	{
		uint_0 = (uint)data;
	}

	public GStruct0(GStruct0 value)
	{
		uint_0 = value.uint_0;
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

	public static Section smethod_4(short short_0)
	{
		return smethod_6(short_0, 0, 0);
	}

	public static Section smethod_5(short short_0, Section section_0)
	{
		return smethod_6(short_0, section_0.Mask, section_0.Offset);
	}

	private static Section smethod_6(short short_0, short short_1, short short_2)
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
		return new Section(smethod_3(short_0), num);
	}

	public override bool vmethod_0(object object_0)
	{
		if (!(object_0 is GStruct0))
		{
			return false;
		}
		return uint_0 == ((GStruct0)object_0).uint_0;
	}

	public override int vmethod_1()
	{
		return GetHashCode();
	}

	public static string smethod_7(GStruct0 gstruct0_0)
	{
		StringBuilder stringBuilder = new StringBuilder(45);
		stringBuilder.Append("BitVector32{");
		int num = (int)gstruct0_0.uint_0;
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
