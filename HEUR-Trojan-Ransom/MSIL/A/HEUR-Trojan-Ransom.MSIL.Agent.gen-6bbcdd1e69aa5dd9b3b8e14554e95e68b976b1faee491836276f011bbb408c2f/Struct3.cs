using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
internal struct Struct3
{
	[FieldOffset(0)]
	private ulong d7c47367;

	[FieldOffset(0)]
	private double bc72d99a;

	[FieldOffset(0)]
	private uint d1015c31;

	[FieldOffset(0)]
	private float float_0;

	[FieldOffset(0)]
	private ushort ushort_0;

	[FieldOffset(0)]
	private byte byte_0;

	[FieldOffset(8)]
	private object object_0;

	public static readonly Struct3 struct3_0;

	[SpecialName]
	public ulong ba535d1d()
	{
		return d7c47367;
	}

	[SpecialName]
	public void method_0(ulong ulong_0)
	{
		d7c47367 = ulong_0;
		object_0 = null;
	}

	[SpecialName]
	public uint method_1()
	{
		return d1015c31;
	}

	[SpecialName]
	public void e63a4aca(uint uint_0)
	{
		d1015c31 = uint_0;
		object_0 = null;
	}

	[SpecialName]
	public ushort method_2()
	{
		return ushort_0;
	}

	[SpecialName]
	public void b8dc208c(ushort ushort_1)
	{
		ushort_0 = ushort_1;
		object_0 = null;
	}

	[SpecialName]
	public byte method_3()
	{
		return byte_0;
	}

	[SpecialName]
	public void method_4(byte byte_1)
	{
		byte_0 = byte_1;
		object_0 = null;
	}

	[SpecialName]
	public double ff1d6065()
	{
		return bc72d99a;
	}

	[SpecialName]
	public void method_5(double double_0)
	{
		bc72d99a = double_0;
		object_0 = null;
	}

	[SpecialName]
	public float method_6()
	{
		return float_0;
	}

	[SpecialName]
	public void fb7703b2(float float_1)
	{
		float_0 = float_1;
		object_0 = null;
	}

	[SpecialName]
	public object c9550f69()
	{
		return object_0;
	}

	[SpecialName]
	public void db2591b4(object object_1)
	{
		object_0 = object_1;
		d7c47367 = 0uL;
	}

	public unsafe static Struct3 smethod_0(object object_1, Type type_0)
	{
		if (type_0.IsEnum)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			return smethod_0(Convert.ChangeType(object_1, underlyingType), underlyingType);
		}
		switch (Type.GetTypeCode(type_0))
		{
		default:
		{
			Struct3 result;
			if (object_1 is Pointer)
			{
				result = default(Struct3);
				result.d7c47367 = (ulong)Pointer.Unbox(object_1);
				return result;
			}
			if (object_1 is IntPtr)
			{
				result = default(Struct3);
				result.d7c47367 = (ulong)(long)(IntPtr)object_1;
				return result;
			}
			if (object_1 is UIntPtr)
			{
				result = default(Struct3);
				result.d7c47367 = (ulong)(UIntPtr)object_1;
				return result;
			}
			if (type_0.IsValueType)
			{
				result = default(Struct3);
				result.object_0 = e6c45616.smethod_0(object_1, type_0);
				return result;
			}
			result = default(Struct3);
			result.object_0 = object_1;
			return result;
		}
		case TypeCode.Boolean:
		{
			Struct3 result = default(Struct3);
			result.byte_0 = (byte)(((bool)object_1) ? 1u : 0u);
			return result;
		}
		case TypeCode.Char:
		{
			Struct3 result = default(Struct3);
			result.ushort_0 = (char)object_1;
			return result;
		}
		case TypeCode.SByte:
		{
			Struct3 result = default(Struct3);
			result.byte_0 = (byte)(sbyte)object_1;
			return result;
		}
		case TypeCode.Byte:
		{
			Struct3 result = default(Struct3);
			result.byte_0 = (byte)object_1;
			return result;
		}
		case TypeCode.Int16:
		{
			Struct3 result = default(Struct3);
			result.ushort_0 = (ushort)(short)object_1;
			return result;
		}
		case TypeCode.UInt16:
		{
			Struct3 result = default(Struct3);
			result.ushort_0 = (ushort)object_1;
			return result;
		}
		case TypeCode.Int32:
		{
			Struct3 result = default(Struct3);
			result.d1015c31 = (uint)(int)object_1;
			return result;
		}
		case TypeCode.UInt32:
		{
			Struct3 result = default(Struct3);
			result.d1015c31 = (uint)object_1;
			return result;
		}
		case TypeCode.Int64:
		{
			Struct3 result = default(Struct3);
			result.d7c47367 = (ulong)(long)object_1;
			return result;
		}
		case TypeCode.UInt64:
		{
			Struct3 result = default(Struct3);
			result.d7c47367 = (ulong)object_1;
			return result;
		}
		case TypeCode.Single:
		{
			Struct3 result = default(Struct3);
			result.float_0 = (float)object_1;
			return result;
		}
		case TypeCode.Double:
		{
			Struct3 result = default(Struct3);
			result.bc72d99a = (double)object_1;
			return result;
		}
		}
	}

	public unsafe void method_7(Struct2 struct2_0)
	{
		*(TypedReference*)Struct2.smethod_1(struct2_0) = __makeref(d1015c31);
	}

	public unsafe void method_8(Struct2 struct2_0, Type type_0)
	{
		if (object_0 is ValueType && type_0.IsValueType)
		{
			Class61.smethod_1(object_0, struct2_0);
		}
		else
		{
			*(TypedReference*)Struct2.smethod_1(struct2_0) = __makeref(object_0);
		}
	}

	public unsafe object e3ce4628(Type type_0)
	{
		if (type_0.IsEnum)
		{
			return Enum.ToObject(type_0, e3ce4628(Enum.GetUnderlyingType(type_0)));
		}
		switch (Type.GetTypeCode(type_0))
		{
		default:
			if (type_0.IsPointer)
			{
				return Pointer.Box((void*)d7c47367, type_0);
			}
			if ((object)type_0 == typeof(IntPtr))
			{
				return Class0.bool_0 ? new IntPtr((long)d7c47367) : new IntPtr((int)d1015c31);
			}
			if ((object)type_0 == typeof(UIntPtr))
			{
				return Class0.bool_0 ? new UIntPtr(d7c47367) : new UIntPtr(d1015c31);
			}
			return e6c45616.smethod_1(object_0);
		case TypeCode.Boolean:
			return byte_0 != 0;
		case TypeCode.Char:
			return (char)ushort_0;
		case TypeCode.SByte:
			return (sbyte)byte_0;
		case TypeCode.Byte:
			return byte_0;
		case TypeCode.Int16:
			return (short)ushort_0;
		case TypeCode.UInt16:
			return ushort_0;
		case TypeCode.Int32:
			return (int)d1015c31;
		case TypeCode.UInt32:
			return d1015c31;
		case TypeCode.Int64:
			return (long)d7c47367;
		case TypeCode.UInt64:
			return d7c47367;
		case TypeCode.Single:
			return float_0;
		case TypeCode.Double:
			return bc72d99a;
		}
	}
}
