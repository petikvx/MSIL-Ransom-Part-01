using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
internal struct Struct2
{
	[FieldOffset(0)]
	private ulong f78d26d8;

	[FieldOffset(0)]
	private double d72bfc57;

	[FieldOffset(0)]
	private uint uint_0;

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
		return f78d26d8;
	}

	[SpecialName]
	public void f6b2288d(ulong ulong_0)
	{
		f78d26d8 = ulong_0;
		object_0 = null;
	}

	[SpecialName]
	public uint b5683088()
	{
		return uint_0;
	}

	[SpecialName]
	public void b3579a47(uint uint_1)
	{
		uint_0 = uint_1;
		object_0 = null;
	}

	[SpecialName]
	public ushort method_1()
	{
		return ushort_0;
	}

	[SpecialName]
	public void method_2(ushort ushort_1)
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
	public void b65cc66b(byte byte_1)
	{
		byte_0 = byte_1;
		object_0 = null;
	}

	[SpecialName]
	public double d6a6a8ce()
	{
		return d72bfc57;
	}

	[SpecialName]
	public void method_4(double double_0)
	{
		d72bfc57 = double_0;
		object_0 = null;
	}

	[SpecialName]
	public float method_5()
	{
		return float_0;
	}

	[SpecialName]
	public void method_6(float float_1)
	{
		float_0 = float_1;
		object_0 = null;
	}

	[SpecialName]
	public object a90ed1e2()
	{
		return object_0;
	}

	[SpecialName]
	public void method_7(object object_1)
	{
		object_0 = object_1;
		f78d26d8 = 0uL;
	}

	public unsafe static Struct2 smethod_0(object object_1, Type type_0)
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
			Struct2 result;
			if (object_1 is Pointer)
			{
				result = default(Struct2);
				result.f78d26d8 = (ulong)Pointer.Unbox(object_1);
				return result;
			}
			if (object_1 is IntPtr)
			{
				result = default(Struct2);
				result.f78d26d8 = (ulong)(long)(IntPtr)object_1;
				return result;
			}
			if (object_1 is UIntPtr)
			{
				result = default(Struct2);
				result.f78d26d8 = (ulong)(UIntPtr)object_1;
				return result;
			}
			if (type_0.IsValueType)
			{
				result = default(Struct2);
				result.object_0 = Class59.smethod_0(object_1, type_0);
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
			result.uint_0 = (uint)(int)object_1;
			return result;
		}
		case TypeCode.UInt32:
		{
			Struct2 result = default(Struct2);
			result.uint_0 = (uint)object_1;
			return result;
		}
		case TypeCode.Int64:
		{
			Struct2 result = default(Struct2);
			result.f78d26d8 = (ulong)(long)object_1;
			return result;
		}
		case TypeCode.UInt64:
		{
			Struct2 result = default(Struct2);
			result.f78d26d8 = (ulong)object_1;
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
			result.d72bfc57 = (double)object_1;
			return result;
		}
		}
	}

	public unsafe void method_8(Struct1 struct1_0)
	{
		*(TypedReference*)Struct1.d9a770c4(struct1_0) = __makeref(uint_0);
	}

	public unsafe void f1932236(Struct1 struct1_0, Type type_0)
	{
		if (object_0 is ValueType && type_0.IsValueType)
		{
			Class57.smethod_0(object_0, struct1_0);
		}
		else
		{
			*(TypedReference*)Struct1.d9a770c4(struct1_0) = __makeref(object_0);
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
				return Pointer.Box((void*)f78d26d8, type_0);
			}
			if ((object)type_0 == typeof(IntPtr))
			{
				return Class0.ffeab2de ? new IntPtr((long)f78d26d8) : new IntPtr((int)uint_0);
			}
			if ((object)type_0 == typeof(UIntPtr))
			{
				return Class0.ffeab2de ? new UIntPtr(f78d26d8) : new UIntPtr(uint_0);
			}
			return Class59.cefadc0d(object_0);
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
			return (long)f78d26d8;
		case TypeCode.UInt64:
			return f78d26d8;
		case TypeCode.Single:
			return float_0;
		case TypeCode.Double:
			return d72bfc57;
		}
	}
}
