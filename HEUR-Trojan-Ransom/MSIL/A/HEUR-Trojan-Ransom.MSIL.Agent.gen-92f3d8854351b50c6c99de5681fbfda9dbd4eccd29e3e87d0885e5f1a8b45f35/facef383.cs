using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
internal struct facef383
{
	[FieldOffset(0)]
	private ulong eaaa2e78;

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
	private object fcc38b3e;

	public static readonly facef383 facef383_0;

	[SpecialName]
	public ulong method_0()
	{
		return eaaa2e78;
	}

	[SpecialName]
	public void method_1(ulong ulong_0)
	{
		eaaa2e78 = ulong_0;
		fcc38b3e = null;
	}

	[SpecialName]
	public uint df1ed028()
	{
		return uint_0;
	}

	[SpecialName]
	public void method_2(uint uint_1)
	{
		uint_0 = uint_1;
		fcc38b3e = null;
	}

	[SpecialName]
	public ushort c635f39a()
	{
		return ushort_0;
	}

	[SpecialName]
	public void method_3(ushort ushort_1)
	{
		ushort_0 = ushort_1;
		fcc38b3e = null;
	}

	[SpecialName]
	public byte a42951dc()
	{
		return byte_0;
	}

	[SpecialName]
	public void method_4(byte byte_1)
	{
		byte_0 = byte_1;
		fcc38b3e = null;
	}

	[SpecialName]
	public double method_5()
	{
		return double_0;
	}

	[SpecialName]
	public void b6c833f5(double double_1)
	{
		double_0 = double_1;
		fcc38b3e = null;
	}

	[SpecialName]
	public float method_6()
	{
		return float_0;
	}

	[SpecialName]
	public void method_7(float float_1)
	{
		float_0 = float_1;
		fcc38b3e = null;
	}

	[SpecialName]
	public object method_8()
	{
		return fcc38b3e;
	}

	[SpecialName]
	public void method_9(object object_0)
	{
		fcc38b3e = object_0;
		eaaa2e78 = 0uL;
	}

	public unsafe static facef383 b3e8ed04(object object_0, Type type_0)
	{
		if (type_0.IsEnum)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			return b3e8ed04(Convert.ChangeType(object_0, underlyingType), underlyingType);
		}
		switch (Type.GetTypeCode(type_0))
		{
		default:
		{
			facef383 result;
			if (object_0 is Pointer)
			{
				result = default(facef383);
				result.eaaa2e78 = (ulong)Pointer.Unbox(object_0);
				return result;
			}
			if (object_0 is IntPtr)
			{
				result = default(facef383);
				result.eaaa2e78 = (ulong)(long)(IntPtr)object_0;
				return result;
			}
			if (object_0 is UIntPtr)
			{
				result = default(facef383);
				result.eaaa2e78 = (ulong)(UIntPtr)object_0;
				return result;
			}
			if (type_0.IsValueType)
			{
				result = default(facef383);
				result.fcc38b3e = e94c75e3.f6ace54f(object_0, type_0);
				return result;
			}
			result = default(facef383);
			result.fcc38b3e = object_0;
			return result;
		}
		case TypeCode.Boolean:
		{
			facef383 result = default(facef383);
			result.byte_0 = (byte)(((bool)object_0) ? 1u : 0u);
			return result;
		}
		case TypeCode.Char:
		{
			facef383 result = default(facef383);
			result.ushort_0 = (char)object_0;
			return result;
		}
		case TypeCode.SByte:
		{
			facef383 result = default(facef383);
			result.byte_0 = (byte)(sbyte)object_0;
			return result;
		}
		case TypeCode.Byte:
		{
			facef383 result = default(facef383);
			result.byte_0 = (byte)object_0;
			return result;
		}
		case TypeCode.Int16:
		{
			facef383 result = default(facef383);
			result.ushort_0 = (ushort)(short)object_0;
			return result;
		}
		case TypeCode.UInt16:
		{
			facef383 result = default(facef383);
			result.ushort_0 = (ushort)object_0;
			return result;
		}
		case TypeCode.Int32:
		{
			facef383 result = default(facef383);
			result.uint_0 = (uint)(int)object_0;
			return result;
		}
		case TypeCode.UInt32:
		{
			facef383 result = default(facef383);
			result.uint_0 = (uint)object_0;
			return result;
		}
		case TypeCode.Int64:
		{
			facef383 result = default(facef383);
			result.eaaa2e78 = (ulong)(long)object_0;
			return result;
		}
		case TypeCode.UInt64:
		{
			facef383 result = default(facef383);
			result.eaaa2e78 = (ulong)object_0;
			return result;
		}
		case TypeCode.Single:
		{
			facef383 result = default(facef383);
			result.float_0 = (float)object_0;
			return result;
		}
		case TypeCode.Double:
		{
			facef383 result = default(facef383);
			result.double_0 = (double)object_0;
			return result;
		}
		}
	}

	public unsafe void method_10(Struct0 struct0_0)
	{
		*(TypedReference*)Struct0.smethod_1(struct0_0) = __makeref(uint_0);
	}

	public unsafe void f62210d6(Struct0 struct0_0, Type type_0)
	{
		if (fcc38b3e is ValueType && type_0.IsValueType)
		{
			Class63.a1521871(fcc38b3e, struct0_0);
		}
		else
		{
			*(TypedReference*)Struct0.smethod_1(struct0_0) = __makeref(fcc38b3e);
		}
	}

	public unsafe object f3c5123d(Type type_0)
	{
		if (type_0.IsEnum)
		{
			return Enum.ToObject(type_0, f3c5123d(Enum.GetUnderlyingType(type_0)));
		}
		switch (Type.GetTypeCode(type_0))
		{
		default:
			if (type_0.IsPointer)
			{
				return Pointer.Box((void*)eaaa2e78, type_0);
			}
			if ((object)type_0 == typeof(IntPtr))
			{
				return Class0.bool_0 ? new IntPtr((long)eaaa2e78) : new IntPtr((int)uint_0);
			}
			if ((object)type_0 == typeof(UIntPtr))
			{
				return Class0.bool_0 ? new UIntPtr(eaaa2e78) : new UIntPtr(uint_0);
			}
			return e94c75e3.smethod_0(fcc38b3e);
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
			return (long)eaaa2e78;
		case TypeCode.UInt64:
			return eaaa2e78;
		case TypeCode.Single:
			return float_0;
		case TypeCode.Double:
			return double_0;
		}
	}
}
