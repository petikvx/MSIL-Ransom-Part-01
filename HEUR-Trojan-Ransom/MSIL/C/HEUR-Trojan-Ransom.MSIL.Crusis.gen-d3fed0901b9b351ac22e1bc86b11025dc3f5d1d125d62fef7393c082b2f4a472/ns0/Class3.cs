using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ns0;

internal sealed class Class3
{
	[CompilerGenerated]
	private sealed class Class4
	{
		public string string_0;

		internal byte method_0(int int_0)
		{
			return Convert.ToByte(string_0.Substring(int_0, 2), 16);
		}
	}

	public static byte[] smethod_0(string string_0)
	{
		//IL_0002: Expected O, but got I4
		//IL_0016: Expected O, but got I4
		//IL_001e: Expected O, but got I4
		//IL_002e: Expected O, but got I4
		string text = (string)0;
		Class4 @class = default(Class4);
		do
		{
			if ((nint)text == 1)
			{
				@class = new Class4();
				text = (string)2;
			}
			if ((nint)text == 2)
			{
				@class.string_0 = string_0;
				text = (string)3;
			}
			if (text == null)
			{
				text = (string)1;
			}
		}
		while ((nint)text != 3);
		return (from int_0 in Enumerable.Range(0, @class.string_0.Length)
			where int_0 % 2 == 0
			select int_0).Select(@class.method_0).ToArray();
	}
}
