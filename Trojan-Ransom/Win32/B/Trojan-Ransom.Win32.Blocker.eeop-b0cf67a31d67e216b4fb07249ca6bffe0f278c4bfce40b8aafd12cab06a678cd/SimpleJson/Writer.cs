using System.Collections;
using System.Globalization;
using System.Text;
using e9a0jRW7WM0ZtAYBQW;

namespace SimpleJson;

public class Writer
{
	public static string WriteBoolean(bool b)
	{
		if (!b)
		{
			return "false";
		}
		return "true";
	}

	public static string WriteInteger(int i)
	{
		return i.ToString();
	}

	public static string WriteDouble(double i)
	{
		return i.ToString().Replace(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator, ".");
	}

	public static string WriteString(string str)
	{
		return "\"" + str.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\b", "\\b")
			.Replace("\f", "\\f")
			.Replace("\n", "\\n")
			.Replace("\r", "\\r")
			.Replace("\t", "\\t") + "\"";
	}

	public static string WriteList(IList list)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("[");
		bool flag = true;
		foreach (object item in list)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				stringBuilder.Append(",");
			}
			stringBuilder.Append(Write(item));
		}
		stringBuilder.Append("]");
		return stringBuilder.ToString();
	}

	public static string WriteDictionary(IDictionary dict)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("{");
		bool flag = true;
		foreach (DictionaryEntry item in dict)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				stringBuilder.Append(",");
			}
			stringBuilder.Append(Write((string)item.Key));
			stringBuilder.Append(":");
			stringBuilder.Append(Write(item.Value));
		}
		stringBuilder.Append("}");
		return stringBuilder.ToString();
	}

	public static string Write(object o)
	{
		if (o == null)
		{
			return "null";
		}
		if (o is bool)
		{
			return WriteBoolean((bool)o);
		}
		if (o is int)
		{
			return WriteInteger((int)o);
		}
		if (!(o is double) && !(o is float))
		{
			if (o is IList)
			{
				return WriteList((IList)o);
			}
			if (o is IDictionary)
			{
				return WriteDictionary((IDictionary)o);
			}
			return WriteString((string)o);
		}
		return WriteDouble((double)o);
	}

	public Writer()
	{
		eZTsNS9ebAJySZpK7R.eLHe04W3E();
		base._002Ector();
	}
}
