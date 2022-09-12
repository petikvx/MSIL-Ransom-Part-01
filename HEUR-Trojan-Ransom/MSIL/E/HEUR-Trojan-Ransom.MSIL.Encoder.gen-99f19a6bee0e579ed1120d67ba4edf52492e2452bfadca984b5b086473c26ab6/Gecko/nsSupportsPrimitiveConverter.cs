using System;

namespace Gecko;

public static class nsSupportsPrimitiveConverter
{
	public static object GetObject(nsISupportsPrimitive value)
	{
		return value.GetTypeAttribute() switch
		{
			1 => GetID((nsISupportsID)value), 
			2 => GetString((nsISupportsCString)value), 
			3 => GetString((nsISupportsString)value), 
			4 => GetBool((nsISupportsPRBool)value), 
			5 => GetByte((nsISupportsPRUint8)value), 
			6 => GetUInt16((nsISupportsPRUint16)value), 
			7 => GetUInt32((nsISupportsPRUint32)value), 
			8 => GetUInt64((nsISupportsPRUint64)value), 
			9 => GetTime((nsISupportsPRTime)value), 
			10 => GetChar((nsISupportsChar)value), 
			11 => GetInt16((nsISupportsPRInt16)value), 
			12 => GetInt32((nsISupportsPRInt32)value), 
			13 => GetInt64((nsISupportsPRInt64)value), 
			14 => GetFloat((nsISupportsFloat)value), 
			15 => GetDouble((nsISupportsDouble)value), 
			16 => GetVoid((nsISupportsVoid)value), 
			17 => GetInterfacePointer((nsISupportsInterfacePointer)value), 
			_ => null, 
		};
	}

	public static object GetID(nsISupportsID value)
	{
		return value.GetDataAttribute();
	}

	public static string GetString(nsISupportsCString value)
	{
		return nsString.Get(value.GetDataAttribute);
	}

	public static string GetString(nsISupportsString value)
	{
		return nsString.Get(value.GetDataAttribute);
	}

	public static bool GetBool(nsISupportsPRBool value)
	{
		return value.GetDataAttribute();
	}

	public static byte GetByte(nsISupportsPRUint8 value)
	{
		return value.GetDataAttribute();
	}

	public static ushort GetUInt16(nsISupportsPRUint16 value)
	{
		return value.GetDataAttribute();
	}

	public static uint GetUInt32(nsISupportsPRUint32 value)
	{
		return value.GetDataAttribute();
	}

	public static ulong GetUInt64(nsISupportsPRUint64 value)
	{
		return value.GetDataAttribute();
	}

	public static long GetTime(nsISupportsPRTime value)
	{
		return value.GetDataAttribute();
	}

	public static char GetChar(nsISupportsChar value)
	{
		return value.GetDataAttribute();
	}

	public static short GetInt16(nsISupportsPRInt16 value)
	{
		return value.GetDataAttribute();
	}

	public static int GetInt32(nsISupportsPRInt32 value)
	{
		return value.GetDataAttribute();
	}

	public static long GetInt64(nsISupportsPRInt64 value)
	{
		return value.GetDataAttribute();
	}

	public static float GetFloat(nsISupportsFloat value)
	{
		return value.GetDataAttribute();
	}

	public static double GetDouble(nsISupportsDouble value)
	{
		return value.GetDataAttribute();
	}

	public static IntPtr GetVoid(nsISupportsVoid value)
	{
		return value.GetDataAttribute();
	}

	internal static nsISupports GetInterfacePointer(nsISupportsInterfacePointer value)
	{
		return value.GetDataAttribute();
	}

	public static nsISupportsPRBool SetBool(bool value)
	{
		nsISupportsPRBool obj = Xpcom.CreateInstance<nsISupportsPRBool>("@mozilla.org/supports-PRBool;1");
		obj = Xpcom.QueryInterface<nsISupportsPRBool>(obj);
		obj.SetDataAttribute(value);
		Xpcom.QueryInterface<nsISupports>(obj);
		return obj;
	}
}
