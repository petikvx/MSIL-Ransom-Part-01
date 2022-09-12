using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
internal struct Struct2
{
	[FieldOffset(0)]
	private ulong ulong_0;

	[FieldOffset(0)]
	private double double_0;

	[FieldOffset(0)]
	private uint f2047;

	[FieldOffset(0)]
	private float float_0;

	[FieldOffset(0)]
	private ushort ushort_0;

	[FieldOffset(0)]
	private byte byte_0;

	[FieldOffset(8)]
	private object object_0;

	public static readonly Struct2 struct2_0;

	[SpecialName]
	public ulong method_0()
	{
		return ulong_0;
	}

	[SpecialName]
	public void method_1(ulong ulong_1)
	{
		ulong_0 = ulong_1;
		object_0 = null;
	}

	[SpecialName]
	public uint method_2()
	{
		return f2047;
	}

	[SpecialName]
	public void c85fac38(uint uint_0)
	{
		f2047 = uint_0;
		object_0 = null;
	}

	[SpecialName]
	public ushort method_3()
	{
		return ushort_0;
	}

	[SpecialName]
	public void a49cfa2a(ushort ushort_1)
	{
		ushort_0 = ushort_1;
		object_0 = null;
	}

	[SpecialName]
	public byte method_4()
	{
		return byte_0;
	}

	[SpecialName]
	public void dc0866ec(byte byte_1)
	{
		byte_0 = byte_1;
		object_0 = null;
	}

	[SpecialName]
	public double ceea355b()
	{
		return double_0;
	}

	[SpecialName]
	public void method_5(double double_1)
	{
		double_0 = double_1;
		object_0 = null;
	}

	[SpecialName]
	public float e4021645()
	{
		return float_0;
	}

	[SpecialName]
	public void d22692e0(float float_1)
	{
		float_0 = float_1;
		object_0 = null;
	}

	[SpecialName]
	public object method_6()
	{
		return object_0;
	}

	[SpecialName]
	public void method_7(object object_1)
	{
		object_0 = object_1;
		ulong_0 = 0uL;
	}

	public unsafe static Struct2 a5dd3349(object object_1, Type type_0)
	{
		if (type_0.IsEnum)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			return a5dd3349(Convert.ChangeType(object_1, underlyingType), underlyingType);
		}
		switch (Type.GetTypeCode(type_0))
		{
		default:
		{
			Struct2 result;
			if (object_1 is Pointer)
			{
				result = default(Struct2);
				result.ulong_0 = (ulong)Pointer.Unbox(object_1);
				return result;
			}
			if (object_1 is IntPtr)
			{
				result = default(Struct2);
				result.ulong_0 = (ulong)(long)(IntPtr)object_1;
				return result;
			}
			if (object_1 is UIntPtr)
			{
				result = default(Struct2);
				result.ulong_0 = (ulong)(UIntPtr)object_1;
				return result;
			}
			if (type_0.IsValueType)
			{
				result = default(Struct2);
				result.object_0 = a4609aa4.ba1b63c0(object_1, type_0);
				return result;
			}
			result = default(Struct2);
			result.object_0 = object_1;
			return result;
		}
		case TypeCode.Boolean:
		{
			Struct2 result = default(Struct2);
			result.byte_0 = (byte)(((bool)object_1) ? 1u : 0u);
			return result;
		}
		case TypeCode.Char:
		{
			Struct2 result = default(Struct2);
			result.ushort_0 = (char)object_1;
			return result;
		}
		case TypeCode.SByte:
		{
			Struct2 result = default(Struct2);
			result.byte_0 = (byte)(sbyte)object_1;
			return result;
		}
		case TypeCode.Byte:
		{
			Struct2 result = default(Struct2);
			result.byte_0 = (byte)object_1;
			return result;
		}
		case TypeCode.Int16:
		{
			Struct2 result = default(Struct2);
			result.ushort_0 = (ushort)(short)object_1;
			return result;
		}
		case TypeCode.UInt16:
		{
			Struct2 result = default(Struct2);
			result.ushort_0 = (ushort)object_1;
			return result;
		}
		case TypeCode.Int32:
		{
			Struct2 result = default(Struct2);
			result.f2047 = (uint)(int)object_1;
			return result;
		}
		case TypeCode.UInt32:
		{
			Struct2 result = default(Struct2);
			result.f2047 = (uint)object_1;
			return result;
		}
		case TypeCode.Int64:
		{
			Struct2 result = default(Struct2);
			result.ulong_0 = (ulong)(long)object_1;
			return result;
		}
		case TypeCode.UInt64:
		{
			Struct2 result = default(Struct2);
			result.ulong_0 = (ulong)object_1;
			return result;
		}
		case TypeCode.Single:
		{
			Struct2 result = default(Struct2);
			result.float_0 = (float)object_1;
			return result;
		}
		case TypeCode.Double:
		{
			Struct2 result = default(Struct2);
			result.double_0 = (double)object_1;
			return result;
		}
		}
	}

	public unsafe void cd3aa414(fe387972 fe387972_0)
	{
		*(TypedReference*)fe387972.smethod_1(fe387972_0) = __makeref(f2047);
	}

	public unsafe void bbd4063(fe387972 fe387972_0, Type type_0)
	{
		if (object_0 is ValueType && type_0.IsValueType)
		{
			Class55.smethod_0(object_0, fe387972_0);
		}
		else
		{
			*(TypedReference*)fe387972.smethod_1(fe387972_0) = __makeref(object_0);
		}
	}

	public unsafe object method_8(Type type_0)
	{
		if (type_0.IsEnum)
		{
			return Enum.ToObject(type_0, method_8(Enum.GetUnderlyingType(type_0)));
		}
		switch (Type.GetTypeCode(type_0))
		{
		default:
			if (type_0.IsPointer)
			{
				return Pointer.Box((void*)ulong_0, type_0);
			}
			if ((object)type_0 == typeof(IntPtr))
			{
				return Class0.eef71fab ? new IntPtr((long)ulong_0) : new IntPtr((int)f2047);
			}
			if ((object)type_0 == typeof(UIntPtr))
			{
				return Class0.eef71fab ? new UIntPtr(ulong_0) : new UIntPtr(f2047);
			}
			return a4609aa4.b89e3a16(object_0);
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
			return (int)f2047;
		case TypeCode.UInt32:
			return f2047;
		case TypeCode.Int64:
			return (long)ulong_0;
		case TypeCode.UInt64:
			return ulong_0;
		case TypeCode.Single:
			return float_0;
		case TypeCode.Double:
			return double_0;
		}
	}
}
