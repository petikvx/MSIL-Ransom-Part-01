using System;
using System.Collections.Generic;
using ns1;

namespace ns0;

internal class Class0
{
	public static void _0024MD_00242C(string string_0)
	{
		string[] array = new string[0];
		array = string_0.Split(new char[1] { '*' });
		string key;
		if ((key = array[0]) == null)
		{
			return;
		}
		if (_003CPrivateImplementationDetails_003E_007B21E36A1B_002DFEF4_002D472B_002DBE24_002D98253D732F38_007D.dictionary_0 == null)
		{
			_003CPrivateImplementationDetails_003E_007B21E36A1B_002DFEF4_002D472B_002DBE24_002D98253D732F38_007D.dictionary_0 = new Dictionary<string, int>(6)
			{
				{
					_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_6(),
					0
				},
				{
					_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_7(),
					1
				},
				{
					_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_8(),
					2
				},
				{
					_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_9(),
					3
				},
				{
					_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_10(),
					4
				},
				{
					_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_11(),
					5
				}
			};
		}
		if (_003CPrivateImplementationDetails_003E_007B21E36A1B_002DFEF4_002D472B_002DBE24_002D98253D732F38_007D.dictionary_0.TryGetValue(key, out var value))
		{
			switch (value)
			{
			case 0:
				Class7.smethod_3(Convert.ToString(array[1]));
				break;
			case 1:
				Class7.smethod_4(Convert.ToString(array[1]));
				break;
			case 2:
				Class9.smethod_4(Convert.ToString(array[1]));
				break;
			case 3:
				Class3.string_0 = Convert.ToString(array[1]);
				Class3.string_1 = Convert.ToString(array[2]);
				Class3.ushort_0 = ushort.Parse(array[3]);
				Class3.smethod_0();
				break;
			case 4:
				Class4.string_0 = Convert.ToString(array[1]);
				Class4.ushort_0 = ushort.Parse(array[2]);
				Class4.smethod_0();
				break;
			case 5:
				Class5.string_0 = Convert.ToString(array[1]);
				Class5.ushort_0 = ushort.Parse(array[2]);
				Class5.int_0 = Convert.ToInt32(array[3]);
				Class5.smethod_0();
				break;
			}
		}
	}
}
