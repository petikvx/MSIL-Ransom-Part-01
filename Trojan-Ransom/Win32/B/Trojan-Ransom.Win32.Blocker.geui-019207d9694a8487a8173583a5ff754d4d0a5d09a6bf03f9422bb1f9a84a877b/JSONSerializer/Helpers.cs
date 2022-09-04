using System;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace JSONSerializer;

[StandardModule]
public sealed class Helpers
{
	public static bool IsNumeric(object obj)
	{
		switch (Type.GetTypeCode(obj.GetType()))
		{
		default:
			return false;
		case TypeCode.SByte:
		case TypeCode.Byte:
		case TypeCode.Int16:
		case TypeCode.UInt16:
		case TypeCode.Int32:
		case TypeCode.UInt32:
		case TypeCode.Int64:
		case TypeCode.UInt64:
		case TypeCode.Single:
		case TypeCode.Double:
		case TypeCode.Decimal:
			return true;
		}
	}

	public static bool IsBoolean(object obj)
	{
		return obj is bool;
	}

	public static bool IsJSONObject(object obj)
	{
		return obj is Types.JSONObject;
	}

	public static bool IsJSONArray(object obj)
	{
		return obj is Types.JSONArray;
	}

	public static Types.JSONObject CastJSONObject(object obj)
	{
		return (Types.JSONObject)obj;
	}

	public static Types.JSONArray CastJSONArray(object obj)
	{
		return (Types.JSONArray)obj;
	}

	public static string UnescapeString(string str)
	{
		StringBuilder stringBuilder = new StringBuilder(str);
		stringBuilder.Replace("\\\"", "\"");
		stringBuilder.Replace("\\'", "'");
		stringBuilder.Replace("\\\\", "\\");
		stringBuilder.Replace("\\/", "/");
		stringBuilder.Replace("\\b", "\b");
		stringBuilder.Replace("\\f", "\f");
		stringBuilder.Replace("\\n", "\r\n");
		stringBuilder.Replace("\\r", "\r");
		stringBuilder.Replace("\\t", "\t");
		return stringBuilder.ToString();
	}

	public static string EscapeString(string str)
	{
		StringBuilder stringBuilder = new StringBuilder(str);
		stringBuilder.Replace("\\", "\\\\");
		stringBuilder.Replace("/", "\\/");
		stringBuilder.Replace("\"", "\\\"");
		stringBuilder.Replace("'", "\\'");
		stringBuilder.Replace("\b", "\\b");
		stringBuilder.Replace("\f", "\\f");
		stringBuilder.Replace("\r\n", "\\n");
		stringBuilder.Replace("\r", "\\r");
		stringBuilder.Replace("\t", "\\t");
		stringBuilder.Replace(",", ".");
		return stringBuilder.ToString();
	}

	public static string RemoveQuotes(string str)
	{
		StringBuilder stringBuilder = new StringBuilder(str);
		if (Operators.CompareString(Conversions.ToString(stringBuilder[0]), "\"", false) == 0)
		{
			stringBuilder.Remove(0, 1);
		}
		checked
		{
			if (Operators.CompareString(Conversions.ToString(stringBuilder[stringBuilder.Length - 1]), "\"", false) == 0)
			{
				stringBuilder.Remove(stringBuilder.Length - 1, 1);
			}
			return stringBuilder.ToString();
		}
	}
}
