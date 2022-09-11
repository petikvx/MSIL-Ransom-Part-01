using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns17;
using ns9;

namespace ns4;

internal sealed class Class190 : Class189
{
	private readonly Encoding encoding_0;

	private static readonly string string_1;

	private static readonly string string_2;

	private static readonly string string_3;

	private static readonly string string_4;

	private static readonly string string_5;

	private static readonly string string_6;

	private static readonly string string_7;

	private static readonly string string_8;

	private static readonly string string_9;

	private static readonly string string_10;

	private static readonly string string_11;

	private static readonly string string_12;

	private static readonly string string_13;

	private static readonly string string_14;

	private static readonly string string_15;

	private static readonly string string_16;

	[NonSerialized]
	internal static GetString getString_0;

	protected internal Class190(string string_17, uint uint_1)
		: base(string_17, uint_1)
	{
		encoding_0 = Encoding.UTF8;
	}

	public override void vmethod_2(string string_17, object object_0, TimeSpan timeSpan_0)
	{
		method_2(string_1, string_17, object_0, timeSpan_0);
	}

	public override void vmethod_3(string string_17, object object_0)
	{
		method_3(string_2, string_17, object_0);
	}

	public override void vmethod_4(string string_17, object object_0, TimeSpan timeSpan_0, ulong ulong_0)
	{
		method_1(string_3, string_17, object_0, timeSpan_0, ulong_0);
	}

	public override void vmethod_5(string string_17, int int_0)
	{
		method_5(string_4, string_17, int_0);
	}

	public override void vmethod_6(string string_17)
	{
		method_4(string_5, string_17);
	}

	public override void vmethod_7(TimeSpan timeSpan_0)
	{
		method_6(string_6, timeSpan_0);
	}

	public override KeyValuePair<string, object> vmethod_8(string string_17)
	{
		KeyValuePair<string, object>[] array = method_0(string_17);
		if (array.Length == 0)
		{
			throw new Exception0(getString_0(107371516));
		}
		return array[0];
	}

	private KeyValuePair<string, object>[] method_0(params string[] string_17)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(string.Format(getString_0(107359550), string_7));
		for (int i = 0; i < string_17.Length; i++)
		{
			stringBuilder.Append(string.Format(getString_0(107381774), string_17[i]));
		}
		stringBuilder.Append(getString_0(107370975));
		method_8(stringBuilder.ToString());
		byte[] byte_ = method_10();
		return method_9(byte_);
	}

	public override void vmethod_9(string string_17, int int_0)
	{
		method_5(string_8, string_17, int_0);
	}

	public override void vmethod_10(string string_17, object object_0)
	{
		method_3(string_9, string_17, object_0);
	}

	public override void vmethod_11(string string_17, object object_0, TimeSpan timeSpan_0)
	{
		method_2(string_10, string_17, object_0, timeSpan_0);
	}

	public override void vmethod_12(string string_17, object object_0, TimeSpan timeSpan_0)
	{
		method_2(string_11, string_17, object_0, timeSpan_0);
	}

	private void method_1(string string_17, string string_18, object object_0, TimeSpan timeSpan_0, ulong ulong_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(string.Format(getString_0(107370970), string_17, string_18, (int)timeSpan_0.TotalSeconds));
		byte[] bytes = encoding_0.GetBytes(object_0.ToString());
		string @string = encoding_0.GetString(bytes, 0, bytes.Length);
		stringBuilder.Append(@string.Length.ToString());
		stringBuilder.AppendFormat(getString_0(107381774), ulong_0);
		stringBuilder.Append(getString_0(107370975));
		stringBuilder.Append(@string);
		stringBuilder.Append(getString_0(107370975));
		method_8(stringBuilder.ToString());
		method_10();
	}

	private void method_2(string string_17, string string_18, object object_0, TimeSpan timeSpan_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(string.Format(getString_0(107370970), string_17, string_18, (int)timeSpan_0.TotalSeconds));
		byte[] bytes = encoding_0.GetBytes(object_0.ToString());
		string @string = encoding_0.GetString(bytes, 0, bytes.Length);
		stringBuilder.Append(@string.Length.ToString());
		stringBuilder.Append(getString_0(107370975));
		stringBuilder.Append(@string);
		stringBuilder.Append(getString_0(107370975));
		method_8(stringBuilder.ToString());
		method_10();
	}

	private void method_3(string string_17, string string_18, object object_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(string.Format(getString_0(107370917), string_17, string_18));
		byte[] bytes = encoding_0.GetBytes(object_0.ToString());
		string @string = encoding_0.GetString(bytes, 0, bytes.Length);
		if (string_17 == string_2 || string_17 == string_9)
		{
			stringBuilder.Append(getString_0(107370936));
		}
		stringBuilder.Append(@string.Length.ToString());
		stringBuilder.Append(getString_0(107370975));
		stringBuilder.Append(@string);
		stringBuilder.Append(getString_0(107370975));
		method_8(stringBuilder.ToString());
		method_10();
	}

	private void method_4(string string_17, string string_18)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(string.Format(getString_0(107370917), string_17, string_18));
		stringBuilder.Append(getString_0(107370975));
		method_8(stringBuilder.ToString());
		method_10();
	}

	private void method_5(string string_17, string string_18, int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(string.Format(getString_0(107406066), string_17, string_18, int_0));
		stringBuilder.Append(getString_0(107370975));
		method_8(stringBuilder.ToString());
		method_10();
	}

	private void method_6(string string_17, TimeSpan timeSpan_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(string.Format(getString_0(107370895), string_6, timeSpan_0.TotalSeconds));
		method_8(stringBuilder.ToString());
		method_10();
	}

	private void method_7(byte[] byte_0)
	{
		string @string = encoding_0.GetString(byte_0, 0, byte_0.Length);
		if (@string.StartsWith(string_14, StringComparison.OrdinalIgnoreCase) || @string.StartsWith(string_15, StringComparison.OrdinalIgnoreCase) || @string.StartsWith(string_16, StringComparison.OrdinalIgnoreCase))
		{
			throw new Exception0(@string);
		}
	}

	private void method_8(string string_17)
	{
		byte[] bytes = encoding_0.GetBytes(string_17);
		stream_0.Write(bytes, 0, bytes.Length);
	}

	private KeyValuePair<string, object>[] method_9(byte[] byte_0)
	{
		string[] array = encoding_0.GetString(byte_0, 0, byte_0.Length).Split(new string[1] { getString_0(107370975) }, StringSplitOptions.None);
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
		int i = 0;
		string key = getString_0(107399395);
		for (; array[i] != string_13 && i < array.Length; i++)
		{
			if (array[i].StartsWith(string_12, StringComparison.OrdinalIgnoreCase))
			{
				key = array[i].Split(new char[1] { ' ' })[1];
			}
			else
			{
				KeyValuePair<string, object> item = new KeyValuePair<string, object>(key, array[i]);
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	private byte[] method_10()
	{
		byte[] buffer = new byte[1024];
		MemoryStream memoryStream = new MemoryStream();
		for (int num = stream_0.Read(buffer, 0, 1024); num > 0; num = stream_0.Read(buffer, 0, 1024))
		{
			memoryStream.Write(buffer, 0, num);
			if (num < 1024)
			{
				break;
			}
		}
		byte[] array = memoryStream.ToArray();
		method_7(array);
		return array;
	}

	static Class190()
	{
		Strings.CreateGetStringDelegate(typeof(Class190));
		string_1 = getString_0(107353579);
		string_2 = getString_0(107370882);
		string_3 = getString_0(107370905);
		string_4 = getString_0(107370900);
		string_5 = getString_0(107370859);
		string_6 = getString_0(107370850);
		string_7 = getString_0(107370869);
		string_8 = getString_0(107370828);
		string_9 = getString_0(107370819);
		string_10 = getString_0(107370838);
		string_11 = getString_0(107361285);
		string_12 = getString_0(107357929);
		string_13 = getString_0(107370793);
		string_14 = getString_0(107370788);
		string_15 = getString_0(107370811);
		string_16 = getString_0(107370762);
	}
}
