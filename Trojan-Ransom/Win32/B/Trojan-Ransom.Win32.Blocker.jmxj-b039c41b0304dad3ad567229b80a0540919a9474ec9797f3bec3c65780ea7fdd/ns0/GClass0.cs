using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ns0;

public sealed class GClass0
{
	private static object[] object_0;

	private static Assembly assembly_0;

	static GClass0()
	{
		Class2.Class3.smethod_0();
		object_0 = null;
		assembly_0 = Class4.Class5.Class6.smethod_2('ˬ', 658).Load(smethod_0(Class4.Class5.Class6.smethod_0(null, 6, 2017833802)));
	}

	[STAThread]
	public static void Main()
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 5:
			{
				string string_3 = Class4.Class5.Class6.smethod_0(null, 3, 2017833829);
				object obj2 = new object[3];
				((object[])obj2)[0] = Class4.Class5.Class6.smethod_0(null, 6, 2017833838);
				(obj2 as object[])[1] = false;
				((object[])obj2)[2] = true;
				smethod_1(string_3, obj2 as object[]);
				goto case 2;
			}
			case 2:
				num = 1;
				break;
			default:
			{
				Class2.Class3.smethod_0();
				string string_2 = Class4.Class5.Class6.smethod_0(null, 7, 2017833850);
				object obj = new object[1];
				(obj as object[])[0] = Class2.smethod_2(Class4.Class5.Class6.smethod_1(855, '\u0358'), 601, 567);
				smethod_1(string_2, (object[])obj);
				num = 5;
				break;
			}
			case 0:
			case 1:
			{
				string string_ = Class4.Class5.Class6.smethod_0(null, 0, 2017833820);
				Array array = new object[2];
				(array as object[])[0] = smethod_0(Class4.Class5.Class6.smethod_0(null, 8, 2017833804));
				(array as object[])[1] = 0;
				smethod_1(string_, array as object[]);
				return;
			}
			}
		}
	}

	private static byte[] smethod_0(string string_0)
	{
		return Class0.smethod_3(Class0.smethod_1(string_0));
	}

	private static object smethod_1(string string_0, object[] object_1)
	{
		byte[] byte_ = Class1.byte_0;
		int num2 = default(int);
		object result = default(object);
		while (true)
		{
			object_0 = object_1;
			object obj = Class4.Class5.Class6.smethod_3(Class2.smethod_3(assembly_0, 571, 'Ȭ')[0], 980, 1002);
			while (true)
			{
				int num = 0;
				while (true)
				{
					int num3;
					switch (num)
					{
					default:
						num = byte_[49] - 40;
						continue;
					case 3:
					case 5:
						break;
					case 4:
						goto end_IL_0034;
					case 0:
						num2 = 0;
						goto case 2;
					case 6:
					{
						_MethodInfo val = (_MethodInfo)(object)((MethodInfo[])obj)[num2];
						try
						{
							switch (1)
							{
							default:
								result = Class4.Class5.smethod_1<object, MethodBase>(val as MethodInfo, null, object_0, 266, 'Ł');
								return result;
							}
						}
						catch
						{
						}
						num3 = 2;
						goto IL_00bb;
					}
					case 2:
						{
							if (num2 < ((MethodInfo[])obj).Length)
							{
								goto case 6;
							}
							num3 = 3;
							goto IL_00bb;
						}
						IL_00bb:
						while (true)
						{
							switch (num3)
							{
							default:
								goto IL_00e9;
							case 1:
							case 7:
								break;
							case 3:
								Class0.int_0[9] = (Class0.int_0[9] ^ Class0.int_0[399]) & 0xF2;
								return null;
							case 4:
							case 5:
								return result;
							}
							break;
							IL_00e9:
							num2++;
							num3 = 7;
						}
						goto case 2;
					}
					break;
				}
				continue;
				end_IL_0034:
				break;
			}
		}
	}
}
