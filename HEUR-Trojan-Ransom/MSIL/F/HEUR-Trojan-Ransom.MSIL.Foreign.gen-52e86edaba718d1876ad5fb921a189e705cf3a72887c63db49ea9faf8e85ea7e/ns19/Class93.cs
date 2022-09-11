using System;
using System.Text;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns12;
using ns13;
using ns14;
using ns21;
using ns5;

namespace ns19;

internal sealed class Class93 : Class87
{
	private Encoding encoding_0;

	[NonSerialized]
	internal static GetString getString_0;

	public override void vmethod_0()
	{
		base.Column.Type = Enum49.const_16;
		base.Column.ClrType = typeof(string);
		delegate1_0 = method_0;
		string string_ = base.Column.CollationName.Split(new char[1] { '_' })[0];
		encoding_0 = Class137.smethod_1(default(Struct23), string_);
	}

	private object method_0(byte[] byte_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			if (byte_0.Length == 1 && byte_0[0] == 0)
			{
				return string.Empty;
			}
			if (byte_0.Length == 1 && byte_0[0] == 1)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder();
			string value = getString_0(107397766);
			int num = byte_0.Length;
			int num2 = 0;
			while (true)
			{
				if (num2 < num - 1)
				{
					stringBuilder.Append(value);
					int num3 = byte_0[num2++];
					if (num2 + num3 > byte_0.Length)
					{
						break;
					}
					stringBuilder.Append(encoding_0.GetString(byte_0, num2, num3));
					num2 += num3;
					value = getString_0(107404744);
					continue;
				}
				return stringBuilder.ToString();
			}
			throw new MySqlException(Class122.UnexpectedEndOfPacketFound);
		}
		return null;
	}

	static Class93()
	{
		Strings.CreateGetStringDelegate(typeof(Class93));
	}
}
