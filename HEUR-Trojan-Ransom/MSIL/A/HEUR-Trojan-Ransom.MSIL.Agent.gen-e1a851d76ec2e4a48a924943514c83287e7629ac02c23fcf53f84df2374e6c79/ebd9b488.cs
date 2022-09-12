using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
internal struct ebd9b488
{
	[FieldOffset(0)]
	private ulong ulong_0;

	[FieldOffset(0)]
	private double double_0;

	[FieldOffset(0)]
	private uint uint_0;

	[FieldOffset(0)]
	private float float_0;

	[FieldOffset(0)]
	private ushort ushort_0;

	[FieldOffset(0)]
	private byte byte_0;

	[FieldOffset(8)]
	private object d8431adf;

	public static readonly ebd9b488 ebd9b488_0;

	[SpecialName]
	public ulong method_0()
	{
		return ulong_0;
	}

	[SpecialName]
	public void eca936fa(ulong ulong_1)
	{
		ulong_0 = ulong_1;
		d8431adf = null;
	}

	[SpecialName]
	public uint b585a11()
	{
		return uint_0;
	}

	[SpecialName]
	public void cf774c3c(uint uint_1)
	{
		uint_0 = uint_1;
		d8431adf = null;
	}

	[SpecialName]
	public ushort bfb9ba6b()
	{
		return ushort_0;
	}

	[SpecialName]
	public void method_1(ushort ushort_1)
	{
		ushort_0 = ushort_1;
		d8431adf = null;
	}

	[SpecialName]
	public byte fc52add5()
	{
		return byte_0;
	}

	[SpecialName]
	public void f7b1a530(byte byte_1)
	{
		byte_0 = byte_1;
		d8431adf = null;
	}

	[SpecialName]
	public double b9f576cf()
	{
		return double_0;
	}

	[SpecialName]
	public void method_2(double double_1)
	{
		double_0 = double_1;
		d8431adf = null;
	}

	[SpecialName]
	public float d755fbd9()
	{
		return float_0;
	}

	[SpecialName]
	public void method_3(float float_1)
	{
		float_0 = float_1;
		d8431adf = null;
	}

	[SpecialName]
	public object ec0d6773()
	{
		return d8431adf;
	}

	[SpecialName]
	public void aa900636(object object_0)
	{
		d8431adf = object_0;
		ulong_0 = 0uL;
	}

	public unsafe static ebd9b488 e37ec81d(object object_0, Type type_0)
	{
		if (type_0.IsEnum)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			return e37ec81d(Convert.ChangeType(object_0, underlyingType), underlyingType);
		}
		switch (Type.GetTypeCode(type_0))
		{
		default:
		{
			ebd9b488 result;
			if (object_0 is Pointer)
			{
				result = default(ebd9b488);
				result.ulong_0 = (ulong)Pointer.Unbox(object_0);
				return result;
			}
			if (object_0 is IntPtr)
			{
				result = default(ebd9b488);
				result.ulong_0 = (ulong)(long)(IntPtr)object_0;
				return result;
			}
			if (object_0 is UIntPtr)
			{
				result = default(ebd9b488);
				result.ulong_0 = (ulong)(UIntPtr)object_0;
				return result;
			}
			if (type_0.IsValueType)
			{
				result = default(ebd9b488);
				result.d8431adf = Class68.cbd2da44(object_0, type_0);
				return result;
			}
			result = default(ebd9b488);
			result.d8431adf = object_0;
			return result;
		}
		case TypeCode.Boolean:
		{
			ebd9b488 result = default(ebd9b488);
			result.byte_0 = (byte)(((bool)object_0) ? 1u : 0u);
			return result;
		}
		case TypeCode.Char:
		{
			ebd9b488 result = default(ebd9b488);
			result.ushort_0 = (char)object_0;
			return result;
		}
		case TypeCode.SByte:
		{
			ebd9b488 result = default(ebd9b488);
			result.byte_0 = (byte)(sbyte)object_0;
			return result;
		}
		case TypeCode.Byte:
		{
			ebd9b488 result = default(ebd9b488);
			result.byte_0 = (byte)object_0;
			return result;
		}
		case TypeCode.Int16:
		{
			ebd9b488 result = default(ebd9b488);
			result.ushort_0 = (ushort)(short)object_0;
			return result;
		}
		case TypeCode.UInt16:
		{
			ebd9b488 result = default(ebd9b488);
			result.ushort_0 = (ushort)object_0;
			return result;
		}
		case TypeCode.Int32:
		{
			ebd9b488 result = default(ebd9b488);
			result.uint_0 = (uint)(int)object_0;
			return result;
		}
		case TypeCode.UInt32:
		{
			ebd9b488 result = default(ebd9b488);
			result.uint_0 = (uint)object_0;
			return result;
		}
		case TypeCode.Int64:
		{
			ebd9b488 result = default(ebd9b488);
			result.ulong_0 = (ulong)(long)object_0;
			return result;
		}
		case TypeCode.UInt64:
		{
			ebd9b488 result = default(ebd9b488);
			result.ulong_0 = (ulong)object_0;
			return result;
		}
		case TypeCode.Single:
		{
			ebd9b488 result = default(ebd9b488);
			result.float_0 = (float)object_0;
			return result;
		}
		case TypeCode.Double:
		{
			ebd9b488 result = default(ebd9b488);
			result.double_0 = (double)object_0;
			return result;
		}
		}
	}

	public unsafe void d86faad8(f06aee96 f06aee96_0)
	{
		*(TypedReference*)f06aee96.smethod_1(f06aee96_0) = __makeref(uint_0);
	}

	public unsafe void method_4(f06aee96 f06aee96_0, Type type_0)
	{
		if (d8431adf is ValueType && type_0.IsValueType)
		{
			bc2a451.smethod_2(d8431adf, f06aee96_0);
		}
		else
		{
			*(TypedReference*)f06aee96.smethod_1(f06aee96_0) = __makeref(d8431adf);
		}
	}

	public unsafe object method_5(Type type_0)
	{
		if (type_0.IsEnum)
		{
			return Enum.ToObject(type_0, method_5(Enum.GetUnderlyingType(type_0)));
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
				return Class0.e104f21f ? new IntPtr((long)ulong_0) : new IntPtr((int)uint_0);
			}
			if ((object)type_0 == typeof(UIntPtr))
			{
				return Class0.e104f21f ? new UIntPtr(ulong_0) : new UIntPtr(uint_0);
			}
			return Class68.smethod_0(d8431adf);
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
			return (int)uint_0;
		case TypeCode.UInt32:
			return uint_0;
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
