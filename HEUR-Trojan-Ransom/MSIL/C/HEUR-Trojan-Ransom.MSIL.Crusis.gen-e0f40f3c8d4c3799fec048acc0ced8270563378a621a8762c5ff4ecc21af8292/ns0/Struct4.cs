using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns1;

namespace ns0;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 564)]
internal struct Struct4
{
	unsafe static void smethod_0()
	{
		//IL_0022: Expected O, but got I4
		//IL_002d: Expected O, but got I4
		//IL_006c: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		while (true)
		{
			string s = text;
			byte b = 72;
			b = b2;
			byte num = b;
			text = (string)(object)Settings.Default;
			formatProvider = formatProvider;
			int index = (int)((byte*)num)->ToString(text2, formatProvider);
			object obj = char.IsSurrogatePair("GzzcV5rE6nBfJsIHNDOa5ImOYnTUcmAYdbOzrpPODrnXyAKQFAlAS5Fv5CZVIJ4PWMG8ZLDKLMdfvA==", index);
			if (checked((sbyte.TryParse(s, out *unchecked((sbyte*)((obj is ref sbyte) ? obj : null))) ? 1u : 0u) + 1u * (flag ? 1u : 0u)) != 0)
			{
				text = text;
				string s2 = text;
				NumberStyles numberStyles = default(NumberStyles);
				_ = ulong.TryParse(s2, default(NumberStyles), ((flag = flag) ? ((bool*)1) : ((bool*)null))->GetTypeCode() as IFormatProvider, out *(ulong*)null) is Class2;
			}
		}
	}
}
