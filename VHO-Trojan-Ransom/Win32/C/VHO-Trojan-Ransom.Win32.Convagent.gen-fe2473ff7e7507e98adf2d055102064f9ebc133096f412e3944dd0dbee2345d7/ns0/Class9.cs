using System;
using System.Collections.Generic;
using ns3;

namespace ns0;

internal class Class9
{
	public static void smethod_0(string string_0)
	{
		string[] array = new string[0];
		array = string_0.Split(new char[1] { '*' }, StringSplitOptions.RemoveEmptyEntries);
		string key;
		if ((key = array[0].ToLower()) == null)
		{
			return;
		}
		if (_003CPrivateImplementationDetails_003E_007BDB18CA19_002D4EF7_002D467A_002DAA02_002D244B3B1B157A_007D.dictionary_0 == null)
		{
			_003CPrivateImplementationDetails_003E_007BDB18CA19_002D4EF7_002D467A_002DAA02_002D244B3B1B157A_007D.dictionary_0 = new Dictionary<string, int>(7)
			{
				{
					_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_25(),
					0
				},
				{
					_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_26(),
					1
				},
				{
					_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_27(),
					2
				},
				{
					_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_28(),
					3
				},
				{
					_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_29(),
					4
				},
				{
					_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_30(),
					5
				},
				{
					_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_31(),
					6
				}
			};
		}
		if (_003CPrivateImplementationDetails_003E_007BDB18CA19_002D4EF7_002D467A_002DAA02_002D244B3B1B157A_007D.dictionary_0.TryGetValue(key, out var value))
		{
			switch (value)
			{
			case 0:
				Class10.smethod_3();
				Class10.smethod_1();
				break;
			case 1:
				Class12.smethod_6(Convert.ToString(array[1]));
				break;
			case 2:
				Class12.smethod_8(Convert.ToString(array[1]));
				break;
			case 3:
				Class1.smethod_6(Convert.ToString(array[1]));
				break;
			case 4:
				Class7.smethod_6(Class7.Enum0.const_0, array);
				break;
			case 5:
				Class7.smethod_6(Class7.Enum0.const_1, array);
				break;
			case 6:
				Class7.smethod_6(Class7.Enum0.const_2, array);
				break;
			}
		}
	}
}
