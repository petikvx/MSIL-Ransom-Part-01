using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
internal struct feeb32c3
{
	[FieldOffset(0)]
	private ulong ulong_0;

	[FieldOffset(0)]
	private double double_0;

	[FieldOffset(0)]
	private uint fa6080aa;

	[FieldOffset(0)]
	private float f7333801;

	[FieldOffset(0)]
	private ushort aa72316c;

	[FieldOffset(0)]
	private byte byte_0;

	[FieldOffset(8)]
	private object object_0;

	public static readonly feeb32c3 feeb32c3_0;

	[SpecialName]
	public ulong d9a53946()
	{
		return ulong_0;
	}

	[SpecialName]
	public void b67abfed(ulong ulong_1)
	{
		ulong_0 = ulong_1;
		object_0 = null;
	}

	[SpecialName]
	public uint method_0()
	{
		return fa6080aa;
	}

	[SpecialName]
	public void method_1(uint uint_0)
	{
		fa6080aa = uint_0;
		object_0 = null;
	}

	[SpecialName]
	public ushort method_2()
	{
		return aa72316c;
	}

	[SpecialName]
	public void d5b3e371(ushort ushort_0)
	{
		aa72316c = ushort_0;
		object_0 = null;
	}

	[SpecialName]
	public byte f939861c()
	{
		return byte_0;
	}

	[SpecialName]
	public void e885eacb(byte byte_1)
	{
		byte_0 = byte_1;
		object_0 = null;
	}

	[SpecialName]
	public double method_3()
	{
		return double_0;
	}

	[SpecialName]
	public void method_4(double double_1)
	{
		double_0 = double_1;
		object_0 = null;
	}

	[SpecialName]
	public float method_5()
	{
		return f7333801;
	}

	[SpecialName]
	public void method_6(float float_0)
	{
		f7333801 = float_0;
		object_0 = null;
	}

	[SpecialName]
	public object cc3408c2()
	{
		return object_0;
	}

	[SpecialName]
	public void method_7(object object_1)
	{
		object_0 = object_1;
		ulong_0 = 0uL;
	}

	public unsafe static feeb32c3 smethod_0(object object_1, Type type_0)
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
			feeb32c3 result;
			if (object_1 is Pointer)
			{
				result = default(feeb32c3);
				result.ulong_0 = (ulong)Pointer.Unbox(object_1);
				return result;
			}
			if (object_1 is IntPtr)
			{
				result = default(feeb32c3);
				result.ulong_0 = (ulong)(long)(IntPtr)object_1;
				return result;
			}
			if (object_1 is UIntPtr)
			{
				result = default(feeb32c3);
				result.ulong_0 = (ulong)(UIntPtr)object_1;
				return result;
			}
			if (type_0.IsValueType)
			{
				result = default(feeb32c3);
				result.object_0 = Class60.smethod_0(object_1, type_0);
				return result;
			}
			result = default(feeb32c3);
			result.object_0 = object_1;
			return result;
		}
		case TypeCode.Boolean:
		{
			feeb32c3 result = default(feeb32c3);
			result.byte_0 = (byte)(((bool)object_1) ? 1u : 0u);
			return result;
		}
		case TypeCode.Char:
		{
			feeb32c3 result = default(feeb32c3);
			result.aa72316c = (char)object_1;
			return result;
		}
		case TypeCode.SByte:
		{
			feeb32c3 result = default(feeb32c3);
			result.byte_0 = (byte)(sbyte)object_1;
			return result;
		}
		case TypeCode.Byte:
		{
			feeb32c3 result = default(feeb32c3);
			result.byte_0 = (byte)object_1;
			return result;
		}
		case TypeCode.Int16:
		{
			feeb32c3 result = default(feeb32c3);
			result.aa72316c = (ushort)(short)object_1;
			return result;
		}
		case TypeCode.UInt16:
		{
			feeb32c3 result = default(feeb32c3);
			result.aa72316c = (ushort)object_1;
			return result;
		}
		case TypeCode.Int32:
		{
			feeb32c3 result = default(feeb32c3);
			result.fa6080aa = (uint)(int)object_1;
			return result;
		}
		case TypeCode.UInt32:
		{
			feeb32c3 result = default(feeb32c3);
			result.fa6080aa = (uint)object_1;
			return result;
		}
		case TypeCode.Int64:
		{
			feeb32c3 result = default(feeb32c3);
			result.ulong_0 = (ulong)(long)object_1;
			return result;
		}
		case TypeCode.UInt64:
		{
			feeb32c3 result = default(feeb32c3);
			result.ulong_0 = (ulong)object_1;
			return result;
		}
		case TypeCode.Single:
		{
			feeb32c3 result = default(feeb32c3);
			result.f7333801 = (float)object_1;
			return result;
		}
		case TypeCode.Double:
		{
			feeb32c3 result = default(feeb32c3);
			result.double_0 = (double)object_1;
			return result;
		}
		}
	}

	public unsafe void d1bfa3d3(Struct1 struct1_0)
	{
		*(TypedReference*)Struct1.smethod_1(struct1_0) = __makeref(fa6080aa);
	}

	public unsafe void method_8(Struct1 struct1_0, Type type_0)
	{
		if (object_0 is ValueType && type_0.IsValueType)
		{
			Class59.b418db1(object_0, struct1_0);
		}
		else
		{
			*(TypedReference*)Struct1.smethod_1(struct1_0) = __makeref(object_0);
		}
	}

	public unsafe object method_9(Type type_0)
	{
		if (type_0.IsEnum)
		{
			return Enum.ToObject(type_0, method_9(Enum.GetUnderlyingType(type_0)));
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
				return Class0.bool_0 ? new IntPtr((long)ulong_0) : new IntPtr((int)fa6080aa);
			}
			if ((object)type_0 == typeof(UIntPtr))
			{
				return Class0.bool_0 ? new UIntPtr(ulong_0) : new UIntPtr(fa6080aa);
			}
			return Class60.smethod_1(object_0);
		case TypeCode.Boolean:
			return byte_0 != 0;
		case TypeCode.Char:
			return (char)aa72316c;
		case TypeCode.SByte:
			return (sbyte)byte_0;
		case TypeCode.Byte:
			return byte_0;
		case TypeCode.Int16:
			return (short)aa72316c;
		case TypeCode.UInt16:
			return aa72316c;
		case TypeCode.Int32:
			return (int)fa6080aa;
		case TypeCode.UInt32:
			return fa6080aa;
		case TypeCode.Int64:
			return (long)ulong_0;
		case TypeCode.UInt64:
			return ulong_0;
		case TypeCode.Single:
			return f7333801;
		case TypeCode.Double:
			return double_0;
		}
	}
}
