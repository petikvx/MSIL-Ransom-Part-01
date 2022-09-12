using System;
using System.Runtime.InteropServices;

namespace Gecko;

[StructLayout(LayoutKind.Explicit)]
public struct JsVal
{
	public enum ValueTag64Bit : uint
	{
		Clear = 131056u,
		Int32 = 131057u,
		Undefined = 131058u,
		String = 131061u,
		Boolean = 131059u,
		Magic = 131060u,
		Symbol = 131062u,
		Null = 131063u,
		Object = 131064u
	}

	public enum ValueTag32Bit : uint
	{
		Clear = 4294967168u,
		Int32 = 4294967169u,
		Undefined = 4294967170u,
		String = 4294967173u,
		Boolean = 4294967171u,
		Magic = 4294967172u,
		Symbol = 4294967174u,
		Null = 4294967175u,
		Object = 4294967176u
	}

	[FieldOffset(0)]
	public ulong AsBits;

	[FieldOffset(0)]
	public double AsDouble;

	[FieldOffset(0)]
	public IntPtr AsPtr;

	[FieldOffset(0)]
	public int I32;

	[FieldOffset(0)]
	public uint U32;

	[FieldOffset(0)]
	public int Boo;

	[FieldOffset(0)]
	public ulong Ptr;

	[FieldOffset(4)]
	public uint tag;

	public uint Tag => (uint)(Xpcom.Is32Bit ? tag : (AsBits >> 47));

	public bool IsNull => Tag == (uint)(Xpcom.Is32Bit ? (-121) : 131063);

	public bool IsUndefined => Tag == (uint)(Xpcom.Is32Bit ? (-126) : 131058);

	public bool IsBoolean => Tag == (uint)(Xpcom.Is32Bit ? (-125) : 131059);

	public bool IsNumber => Tag <= (uint)(Xpcom.Is32Bit ? (-127) : 131057);

	public bool IsInt => Tag <= (uint)(Xpcom.Is32Bit ? (-127) : 131057);

	public bool IsDouble => Tag <= (uint)(Xpcom.Is32Bit ? (-128) : 131056);

	public bool IsString => Tag == (uint)(Xpcom.Is32Bit ? (-123) : 131061);

	public bool IsObject => Tag <= (uint)(Xpcom.Is32Bit ? (-120) : 131064);

	public JSType Type
	{
		get
		{
			using AutoJSContext autoJSContext = new AutoJSContext();
			return SpiderMonkey.JS_TypeOfValue(autoJSContext.ContextPointer, this);
		}
	}

	public static JsVal FromPtr(ulong value)
	{
		JsVal result = default(JsVal);
		result.AsBits = value;
		return result;
	}

	public static JsVal FromPtr(IntPtr value)
	{
		JsVal result;
		if (Xpcom.Is32Bit)
		{
			result = default(JsVal);
			result.AsPtr = value;
			result.tag = 4294967176u;
			return result;
		}
		result = default(JsVal);
		result.AsBits = (ulong)value.ToInt64() | 0xFFFC000000000000uL;
		return result;
	}

	public static JsVal FromDouble(double d)
	{
		JsVal result = default(JsVal);
		result.AsDouble = d;
		return result;
	}

	public bool ToBoolean()
	{
		return Boo != 0;
	}

	public double ToDouble()
	{
		return AsDouble;
	}

	public int ToInteger()
	{
		return I32;
	}

	public override string ToString()
	{
		using AutoJSContext autoJSContext = new AutoJSContext();
		return autoJSContext.ConvertValueToString(this);
	}

	public object ToObject()
	{
		if (IsNull)
		{
			return null;
		}
		if (IsUndefined)
		{
			return "Undefined";
		}
		if (IsBoolean)
		{
			return ToBoolean();
		}
		if (IsInt)
		{
			return ToInteger();
		}
		if (IsDouble)
		{
			return ToDouble();
		}
		if (IsString)
		{
			return ToString();
		}
		if (IsObject)
		{
			return ToComObjectInternal(IntPtr.Zero);
		}
		return null;
	}

	private object ToComObjectInternal(IntPtr cx)
	{
		using AutoJSContext autoJSContext = new AutoJSContext(cx);
		IntPtr aJSObj = SpiderMonkey.JS_ValueToObject(autoJSContext.ContextPointer, this);
		Guid aIID = typeof(nsISupports).GUID;
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = Xpcom.XPConnect.Instance.WrapJS(autoJSContext.ContextPointer, aJSObj, ref aIID);
			return Xpcom.GetObjectForIUnknown(intPtr);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.Release(intPtr);
			}
		}
	}

	internal object ToComObject(IntPtr cx)
	{
		if (IsNull)
		{
			return null;
		}
		return ToComObjectInternal(cx);
	}
}
